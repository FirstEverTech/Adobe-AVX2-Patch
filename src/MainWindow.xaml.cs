using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.Storage.Pickers;
using Microsoft.UI.Windowing;
using Microsoft.UI;

namespace AdobeAVX2Patch
{
    public sealed partial class MainWindow : Window
    {
        private string _currentDirectory = Directory.GetCurrentDirectory();

        private static readonly Dictionary<string, string> SapCodes = new()
        {
            { "AEFT", "After Effects" },
            { "FLPR", "Animate and Mobile Packaging" },
            { "AUDT", "Audition" },
            { "KBRG", "Bridge" },
            { "CHAR", "Character Animator" },
            { "ESHR", "Dimension" },
            { "DRWV", "Dreamweaver" },
            { "FRSC", "Fresco" },
            { "ILST", "Illustrator" },
            { "AICY", "InCopy" },
            { "IDSN", "InDesign" },
            { "LRCC", "Lightroom" },
            { "LTRM", "Lightroom Classic" },
            { "AME", "Media Encoder" },
            { "PHSP", "Photoshop" },
            { "PRLD", "Prelude" },
            { "PPRO", "Premiere Pro" },
            { "RUSH", "Premiere Rush" },
            { "SBSTD", "Substance Designer" },
            { "SHPR", "Substance Modeler" },
            { "SBSTP", "Substance Painter" },
            { "SBSTA", "Substance Sampler" },
            { "STGR", "Substance Stager" },
            { "SPRK", "XD" }
        };

        public string AppVersion { get; }

        public MainWindow()
        {
            // Pobranie wersji z assembly
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            string versionString = version == null ? "1.0.0" : $"{version.Major}.{version.Minor}.{version.Build}";
            AppVersion = $"Adobe AVX2 Patch v{versionString} by Marcin Grygiel";

            this.InitializeComponent();

            // Ustawienie kontekstu danych na głównym Grid (który ma x:Name="RootGrid")
            RootGrid.DataContext = this;

            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            var appWindow = AppWindow.GetFromWindowId(windowId);

            appWindow.Resize(new Windows.Graphics.SizeInt32(640, 720));

            if (appWindow.Presenter is OverlappedPresenter presenter)
            {
                presenter.IsResizable = false;
                presenter.IsMaximizable = false;
            }

            if (AppWindowTitleBar.IsCustomizationSupported())
            {
                var titleBar = appWindow.TitleBar;
                titleBar.ExtendsContentIntoTitleBar = true;

                if (Application.Current.RequestedTheme == ApplicationTheme.Light)
                {
                    titleBar.BackgroundColor = Colors.White;
                    titleBar.ForegroundColor = Colors.Black;
                    titleBar.ButtonBackgroundColor = Colors.White;
                    titleBar.ButtonForegroundColor = Colors.Black;
                }
                else
                {
                    titleBar.BackgroundColor = Colors.Black;
                    titleBar.ForegroundColor = Colors.White;
                    titleBar.ButtonBackgroundColor = Colors.Black;
                    titleBar.ButtonForegroundColor = Colors.White;
                }
            }
        }

        private void RunButton_Click(object sender, RoutedEventArgs e)
        {
            ProcessAdobeInstaller();
        }

        private async void ChangeDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            var folderPicker = new FolderPicker();
            folderPicker.FileTypeFilter.Add("*");

            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            WinRT.Interop.InitializeWithWindow.Initialize(folderPicker, hWnd);

            var folder = await folderPicker.PickSingleFolderAsync();
            if (folder != null)
            {
                _currentDirectory = folder.Path;
                ShowMessage($"Selected directory: {_currentDirectory}");
            }
        }

        private void RestoreBackupButton_Click(object sender, RoutedEventArgs e)
        {
            RestoreBackups();
        }

        private void GitHubButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/FirstEverTech/Adobe-AVX2-Patch",
                UseShellExecute = true
            });
        }

        private void PayPalButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.paypal.com/donate/?hosted_button_id=23A75PS9GB4Y2",
                UseShellExecute = true
            });
        }

        private void GetOfflineInstallerButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://helpx.adobe.com/contact.html?rghtup=autoOpen&clickref=1100lAdw2Tms&mv=affiliate&mv2=pz&as_camptype=&as_channel=affiliate&as_source=partnerize&as_campaign=prodesigntools",
                UseShellExecute = true
            });
        }

        private void ProcessAdobeInstaller()
        {
            try
            {
                string productsDirectory = Path.Combine(_currentDirectory, "products");

                if (!Directory.Exists(productsDirectory))
                {
                    ShowMessage("Adobe Products directory not found!\nPlease select the directory where the Set-up.exe file is located.");
                    return;
                }

                var summaryLines = new List<string>();

                foreach (var sapCode in SapCodes)
                {
                    string productDirectory = Path.Combine(productsDirectory, sapCode.Key);
                    string jsonFilePath = Path.Combine(productDirectory, "Application.json");

                    if (File.Exists(jsonFilePath))
                    {
                        try
                        {
                            string jsonContent = File.ReadAllText(jsonFilePath);

                            if (jsonContent.Contains("AVX2"))
                            {
                                string backupFilePath = jsonFilePath + ".bak";
                                File.Copy(jsonFilePath, backupFilePath, true);

                                jsonContent = jsonContent.Replace("AVX2", "AVX");
                                File.WriteAllText(jsonFilePath, jsonContent);

                                summaryLines.Add($"{sapCode.Value}: Modification was needed (AVX2 found and replaced).");
                            }
                            else
                            {
                                summaryLines.Add($"{sapCode.Value}: No modification needed (AVX2 not found).");
                            }
                        }
                        catch (Exception ex)
                        {
                            summaryLines.Add($"{sapCode.Value}: Error processing file - {ex.Message}");
                        }
                    }
                }

                if (summaryLines.Count > 0)
                {
                    string summary = "Summary of changes:\n\n";
                    summary += string.Join("\n", summaryLines);
                    summary += "\n\nYou can now close this program and run the Set-up.exe installer.";
                    ShowMessage(summary);
                }
                else
                {
                    ShowMessage("No Adobe products were found in the 'products' directory.");
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"An error occurred: {ex.Message}");
            }
        }

        private void RestoreBackups()
        {
            try
            {
                string productsDirectory = Path.Combine(_currentDirectory, "products");

                if (!Directory.Exists(productsDirectory))
                {
                    ShowMessage("Adobe Products directory not found!\nMake sure this program is running from the folder where the Set-up.exe file is located.");
                    return;
                }

                var summaryLines = new List<string>();

                foreach (var sapCode in SapCodes)
                {
                    string productDirectory = Path.Combine(productsDirectory, sapCode.Key);
                    string jsonFilePath = Path.Combine(productDirectory, "Application.json");
                    string backupFilePath = jsonFilePath + ".bak";

                    if (File.Exists(backupFilePath))
                    {
                        try
                        {
                            File.Copy(backupFilePath, jsonFilePath, true);
                            File.Delete(backupFilePath);
                            summaryLines.Add($"{sapCode.Value}: Backup restored successfully.");
                        }
                        catch (Exception ex)
                        {
                            summaryLines.Add($"{sapCode.Value}: Error restoring backup - {ex.Message}");
                        }
                    }
                }

                if (summaryLines.Count > 0)
                {
                    string summary = "Summary of backup restoration:\n\n";
                    summary += string.Join("\n", summaryLines);
                    ShowMessage(summary);
                }
                else
                {
                    ShowMessage("No backups were found in the 'products' directory.");
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"An error occurred: {ex.Message}");
            }
        }

        private void ShowMessage(string message)
        {
            SummaryTextBox.Text = message;
        }
    }
}