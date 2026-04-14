<a id="top"></a>
# 🎨 **Adobe AVX2 Patch**

[![Version](https://img.shields.io/badge/Version-1.0.1-red?style=flat-square)](https://github.com/FirstEverTech/Adobe-AVX2-Patch/releases)[![Windows](https://img.shields.io/badge/Windows-10%2F11-blueviolet?style=flat-square)](https://www.microsoft.com/windows)[![WinUI](https://img.shields.io/badge/WinUI-3-blueviolet?style=flat-square)](https://learn.microsoft.com/en-us/windows/apps/winui/winui3/)[![DotNET](https://img.shields.io/badge/.NET-10.0-blueviolet?style=flat-square)](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)[![Downloads](https://img.shields.io/github/downloads/FirstEverTech/Adobe-AVX2-Patch/total?style=flat-square&color=gold&label=Downloads)](https://github.com/FirstEverTech/Adobe-AVX2-Patch/releases)[![GitHub Stars](https://img.shields.io/github/stars/FirstEverTech/Adobe-AVX2-Patch?style=flat-square&color=gold&label=Stars)](https://github.com/FirstEverTech/Adobe-AVX2-Patch)  
[![License](https://img.shields.io/badge/License-GPL--3.0-0056b3?style=flat-square)](LICENSE)[![VirusTotal](https://img.shields.io/badge/VirusTotal-1%2F70-008631?style=flat-square)](https://www.virustotal.com/gui/file/0bacca9c6a7c17cebff84ec51098b1cddd665523a0749c6470f60d5136d7e798?nocache=1)[![Issues](https://img.shields.io/github/issues/FirstEverTech/Adobe-AVX2-Patch?style=flat-square&label=Issues)](https://github.com/FirstEverTech/Adobe-AVX2-Patch/issues)

[<img width="1280" height="720" alt="Adobe AVX2 Patch Demo" src="https://github.com/user-attachments/assets/668a7a53-b0bf-46d2-9d4e-61976cc85f5c" />](https://www.youtube.com/watch?v=PaJg91RZIro)

## 🔧 Install Adobe on Older CPUs Without AVX2

**Adobe AVX2 Patch** is a lightweight tool that modifies Adobe standalone installer files, allowing installation of Adobe products (e.g., Photoshop 2026) on processors that support AVX but not AVX2.

Adobe has restricted its latest products to processors with AVX2 — even though these products do not actually require AVX2 to run. This tool unlocks the installer without modifying any installed program files.

⭐ If this project helped you, please click the **"Star"** button at the top of this page on GitHub.  
👉 [Share your feedback!](https://github.com/FirstEverTech/FirstEverTech/Adobe-AVX2-Patch/discussions)

[![Stargazers over time](https://starchart.cc/FirstEverTech/Adobe-AVX2-Patch.svg?variant=adaptive)](https://github.com/FirstEverTech/Adobe-AVX2-Patch/discussions)

---

## 💼 Career Opportunity

> [!TIP]
> **I'm currently seeking new challenges where I can apply my expertise in solving complex IT infrastructure problems. If your organization struggles with system compatibility, automation, or tooling gaps – let's discuss how I can help.**
>
> 🔗 **Connect with me:** [linkedin.com/in/marcin-grygiel](https://linkedin.com/in/marcin-grygiel)

---

<a id="table_of_contents"></a>
## 📑 **Table of Contents**

1. [**Overview**](#overview)
2. [**Features**](#features)
3. [**Supported Adobe Products**](#supported-adobe-products)
4. [**System Requirements**](#system-requirements)
5. [**How to Use**](#how-to-use)
6. [**Download Options**](#download-options)
7. [**Building from Source**](#building-from-source)
8. [**FAQ**](#faq)
9. [**Contributing**](#contributing)
10. [**License**](#license)
11. [**Author & Contact**](#author--contact)
12. [**Support This Project**](#support-this-project)

[↑ Back to top](#top)

---

<a id="overview"></a>
## 📋 **1. Overview**
Adobe AVX2 Patch works with official Adobe standalone (offline) installers. It modifies the `Application.json` files inside the installer's `products\` directory — replacing the `AVX2` processor requirement with `AVX` — and creates backups of the original files before doing so.

This tool does **not** modify any installed Adobe program files.

<img width="626" height="713" alt="image" src="https://github.com/user-attachments/assets/5554a456-a911-4bb8-b28a-680e07533058" />

[↑ Back to top](#top)

---

<a id="features"></a>
## ✨ **2. Features**

- **Patch Adobe Installer** — modifies `Application.json` files to replace the AVX2 requirement with AVX
- **Automatic Backups** — creates `.bak` files before any modification
- **Restore Backups** — one-click restoration of original files
- **21 Adobe Products Supported** — covers most of the Adobe Creative Cloud lineup
- **Clean WinUI 3 Interface** — modern UI with automatic light/dark mode
- **No Admin Rights Required** — runs as a standard user

[↑ Back to top](#top)

---

<a id="supported-adobe-products"></a>
## 🎯 **3. Supported Adobe Products**

| Product | Code | Patchable |
|---------|------|-----------|
| Animate and Mobile Packaging | FLPR | ✅ |
| Audition | AUDT | ✅* |
| Bridge | KBRG | ✅ |
| Character Animator | CHAR | ✅* |
| Dimension | ESHR | ✅ |
| Dreamweaver | DRWV | ✅ |
| Fresco | FRSC | ✅ |
| Illustrator | ILST | ✅ |
| InCopy | AICY | ✅ |
| InDesign | IDSN | ✅ |
| Lightroom | LRCC | ✅ |
| Lightroom Classic | LTRM | ✅ |
| Photoshop | PHSP | ✅ |
| Prelude | PRLD | ✅* |
| Premiere Rush | RUSH | ✅* |
| Substance Designer | SBSTD | ✅ |
| Substance Modeler | SHPR | ✅ |
| Substance Painter | SBSTP | ✅ |
| Substance Sampler | SBSTA | ✅ |
| Substance Stager | STGR | ✅ |
| XD | SPRK | ✅ |

`*` — Indicates that the program successfully passes the installer check after patching. If it runs unstable or doesn't launch at all after installation, please report it in [Issues](https://github.com/FirstEverTech/Adobe-AVX2-Patch/issues). This applies especially to video editing applications (Audition, Premiere Rush, Character Animator, Prelude) – their functionality is not guaranteed.

### ⚠️ Not Supported (actually require AVX2 to run)

| Product | Code | Patchable |
|---------|------|-----------|
| After Effects | AEFT | ❌ |
| Media Encoder | AME | ❌ |
| Premiere Pro | PPRO | ❌ |

Note: These applications truly require AVX2 to run. Patching the installer will not make them work on CPUs without AVX2.

[↑ Back to top](#top)

---

<a id="system-requirements"></a>
## 💻 **4. System Requirements**

| Requirement | Details |
|-------------|---------|
| OS | Windows 10 / Windows 11 (x64) |
| Runtime | [Windows App Runtime 1.7](https://aka.ms/windowsappsdk/1.7/latest/windowsappruntimeinstall-x64.exe) — only needed if app doesn't start |
| Installer | Adobe standalone (offline) installer |
| CPU | Any x64 processor with at least AVX support |

> [!NOTE]
> Standalone (offline) installers for recent Adobe versions may not be publicly listed. You can request direct download links by contacting **Adobe Customer Care via [live chat](https://helpx.adobe.com/contact.html?rghtup=autoOpen&clickref=1100lAdw2Tms&mv=affiliate&mv2=pz&as_camptype=&as_channel=affiliate&as_source=partnerize&as_campaign=prodesigntools)**.

  
[↑ Back to top](#top)

---

<a id="how-to-use"></a>
## 🚀 **5. How to Use**

1. **Download** the tool from the [Releases page](https://github.com/FirstEverTech/Adobe-AVX2-Patch/releases)
2. **Run** `Adobe_AVX2_Patch_v1.0.1.exe` — no installation required
3. **Select Directory** — the tool should be pointed at the folder containing Adobe's `Set-up.exe`. Use the **"Change Directory"** button if needed
4. **Run the Patch** — click **"Run AVX2 Patch"** to modify the installer files
5. **Install Adobe** — run Adobe's `Set-up.exe` to install your desired products
6. **Restore (Optional)** — click **"Restore Backups"** to revert to original files if needed

[↑ Back to top](#top)

---

<a id="download-options"></a>
## 📥 **6. Download Options**

### Option 1: SFX Executable (Recommended)
Download `Adobe_AVX2_Patch_v1.0.exe` from the [Releases page](https://github.com/FirstEverTech/Adobe-AVX2-Patch/releases).
- Self-extracting, portable, no installation required
- Extracts to `%TEMP%` and cleans up automatically on exit
- Size: 34.7 MB (compressed) / 115 MB (extracted)

### Option 2: Source Code
Clone the repository and build with Visual Studio 2022. See [Building from Source](#building-from-source).

[↑ Back to top](#top)

---

<a id="building-from-source"></a>
## 🛠️ **7. Building from Source**

### Requirements
- Visual Studio 2022
- Workload: **Desktop development with C++** + **Windows application development**
- Windows App SDK 1.7 (installed via Visual Studio Installer)

### Steps
1. Clone this repository
2. Open `src\Adobe AVX2 Patch.sln` in Visual Studio 2022
3. Select `Release` / `x64` configuration
4. Build → **Build Solution** (`Ctrl+Shift+B`)

[↑ Back to top](#top)

---

<a id="faq"></a>
## ❓ **8. FAQ**

- **Is this tool safe to use?**  
Yes. It only modifies JSON files inside the Adobe installer package. No installed program files are touched. Original files are backed up before any change.

- **Will patched Adobe products run normally?**  
Yes — for all supported products. The AVX2 restriction exists only in the installer check, not in the actual application code.

- **The app doesn't start after downloading.**  
Install [Windows App Runtime 1.7](https://aka.ms/windowsappsdk/1.7/latest/windowsappruntimeinstall-x64.exe) and try again.

- **Where can I get the Adobe offline installer?**  
Contact Adobe Customer Care via live chat and request the standalone (offline) installer direct download link for your product.

- **Does this work with Adobe CC app / online installer?**  
No — this tool only works with official standalone (offline) installers.

- **Why is the certificate "not trusted"?**  
The FirstEver.tech certificate is self-signed. A commercial Code Signing certificate would eliminate the SmartScreen warning, but it isn't necessary here. Its SHA-256 hash is published on GitHub. The SFX executable is a convenience wrapper for end users.

- **Why does VirusTotal show detections for the SFX executable?**  
The SFX package (`Adobe_AVX2_Patch_v1.0.exe`) may show a small number of detections on VirusTotal — currently 1 out of 70 engines. These are **known false positives** caused by the self-extracting archive and "not trusted" execution, which some generic heuristic engines flag without analyzing the actual content.

[↑ Back to top](#top)

---

<a id="contributing"></a>
## 🤝 **9. Contributing**

Contributions are welcome! Feel free to submit pull requests, report bugs, or suggest new features.

- 🐛 [Report Issues](https://github.com/FirstEverTech/Adobe-AVX2-Patch/issues)
- 💬 [Discussions](https://github.com/FirstEverTech/Adobe-AVX2-Patch/discussions)

[↑ Back to top](#top)

---

<a id="legal-disclaimer"></a>
## ⚠️ **Legal Disclaimer & Important Notice**

This tool does not crack or bypass any software licensing or payment mechanisms. It is not an activator, keygen, or crack. Its sole purpose is to modify a hardware requirement check (AVX2 instruction set) within an Adobe product's installer to enable installation on older CPUs.

**You must have a valid, paid license** (e.g., an active Creative Cloud subscription, a trial license, or a perpetual license) to use the Adobe software after installation. This tool does not grant you any rights to the software itself.

Please ensure you obtain the Adobe installer files from a **legal source**. Using unofficial distribution channels may constitute a violation of copyright law, regardless of your license status.

**The developer of this tool assumes no legal responsibility** for the user's compliance with applicable laws and regulations.

[↑ Back to top](#top)

---

<a id="license"></a>
## 📄 **10. License**

This project is open-source and available under the **GNU General Public License v3.0 (GPL-3.0)**.

- You are free to use, modify, and distribute this software
- Modified versions must also be distributed under GPL-3.0 with source code
- Provided without any warranty

See the [LICENSE](LICENSE) file for full details.

[↑ Back to top](#top)

---

<a id="author--contact"></a>
## 🧑‍💻 **11. Author & Contact**

**Marcin Grygiel** aka FirstEver
- 🌐 **Website**: [www.firstever.tech](https://www.firstever.tech)
- 💼 **LinkedIn**: [Marcin Grygiel](https://www.linkedin.com/in/marcin-grygiel/)
- 🔧 **GitHub**: [FirstEverTech](https://github.com/FirstEverTech)
- 📧 **Contact**: [Contact Form](https://www.firstever.tech/contact)

[↑ Back to top](#top)

---

<a id="support-this-project"></a>
## 💖 **12. Support This Project**

This project is maintained in my free time. If it helped you, consider supporting its development.

[![PayPal](https://img.shields.io/badge/PayPal-Support_Development-00457C?style=for-the-badge&logo=paypal)](https://www.paypal.com/donate/?hosted_button_id=23A75PS9GB4Y2)[![Buy Me a Coffee](https://img.shields.io/badge/Buy_Me_a_Coffee-Support_Work-FFDD00?style=for-the-badge&logo=buymeacoffee)](https://buymeacoffee.com/firstevertech)[![GitHub Sponsors](https://img.shields.io/badge/GitHub-Sponsor-EA4AAA?style=for-the-badge&logo=githubsponsors)](https://github.com/sponsors/FirstEverTech)

**Your support means everything!** If this project helped you, please consider:
- If this project helped you, please give it a ⭐ "Star" on GitHub
- Sharing with friends and colleagues
- Reporting issues or suggesting features
- Supporting development financially
- 👉 [Share your feedback!](https://github.com/FirstEverTech/Adobe-AVX2-Patch/discussions)

---
<div align="center">
<img width="480" alt="Author Photo" title="Marcin Grygiel aka FirstEver and AI" src="https://github.com/user-attachments/assets/452c8553-5059-47c6-9ff9-d73443bb6c06" />
</div>

---

<div align="center">

**Note**: This tool is provided as-is. It only modifies Adobe installer files and does not circumvent any licensing or DRM. Always obtain Adobe products through official channels.

</div>

[↑ Back to top](#top)
