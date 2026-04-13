using Microsoft.UI.Xaml;
using System;

namespace AdobeAVX2Patch
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            // Utwórz i pokaż główne okno aplikacji
            var window = new MainWindow();
            window.Activate();
        }
    }
}