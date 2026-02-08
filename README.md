# Adobe AVX2 Patch

## Overview

Adobe AVX2 Patch is a tool designed to modify the Adobe installer files, allowing users to install Adobe products (e.g., Photoshop 2026) on computers with processors that do not support the AVX2 instruction set (but support the older AVX). This tool works with official Adobe standalone (offline) installers.

Adobe has restricted its latest products to processors with AVX2, even though these products do not require AVX2 to function. This tool unlocks the installer, enabling installation on non-AVX2 CPUs without modifying any program files.

## Features

- **Patch Adobe Installer**: Modifies the `Application.json` files in the Adobe installer to replace AVX2 with AVX, allowing installation on older CPUs.
- **Restore Backups**: Restores the original `Application.json` files from backups created during the patching process.
- **User-Friendly Interface**: Simple and intuitive UI with buttons for patching, changing directories, and restoring backups.
- **Cross-Platform**: Built using WinUI 3, ensuring compatibility with modern Windows systems.

## Supported Adobe Products

The following Adobe products are supported by this tool:

- ~**After Effects** (AEFT)~
- **Animate and Mobile Packaging** (FLPR)
- **Audition** (AUDT)
- **Bridge** (KBRG)
- **Character Animator** (CHAR)
- **Dimension** (ESHR)
- **Dreamweaver** (DRWV)
- **Fresco** (FRSC)
- **Illustrator** (ILST)
- **InCopy** (AICY)
- **InDesign** (IDSN)
- **Lightroom** (LRCC)
- **Lightroom Classic** (LTRM)
- ~**Media Encoder** (AME)~
- **Photoshop** (PHSP)
- **Prelude** (PRLD)
- ~**Premiere Pro** (PPRO)~
- **Premiere Rush** (RUSH)
- **Substance Designer** (SBSTD)
- **Substance Modeler** (SHPR)
- **Substance Painter** (SBSTP)
- **Substance Sampler** (SBSTA)
- **Substance Stager** (STGR)
- **XD** (SPRK)

## Unsupported Adobe Products

The following Adobe products will be installed but will not be able to run because they actually require the AVX2 instruction set to run.

- **Premiere Pro** (PPRO)

## How to Use

1. **Download the Tool**: Clone or download this repository to your local machine.
2. **Run the Application**: Launch the `AdobeAVX2Patch.exe` file.
3. **Select Directory**: Ensure the tool is running in the same directory as the Adobe `Set-up.exe` file. If not, use the "Change Directory" button to select the correct folder.
4. **Run the Patch**: Click the "Run AVX2 Patch" button to modify the installer files.
5. **Install Adobe Products**: After patching, run the Adobe `Set-up.exe` to install your desired Adobe products.
6. **Restore Backups (Optional)**: If needed, you can restore the original files by clicking the "Restore Backups" button.

## Requirements

- **Windows 10/11**: The tool is built using WinUI 3 and requires Windows 10 or later.
- **Adobe Standalone Installer**: The tool only works with official Adobe standalone (offline) installers.

## Notes

- This tool only modifies the installer files and does not alter any program files of the installed Adobe products.
- Standalone (offline) installers for new versions of Adobe products may not be publicly available. You can request the 2025 direct download links by contacting Adobe Customer Care via live chat.

## Support

If you find this tool helpful, consider supporting the developer:

- **Donate via PayPal**: [PayPal Donation Link](https://www.paypal.com/donate/?hosted_button_id=23A75PS9GB4Y2)
- **Contact the Developer**: You can reach out to the developer via [LinkedIn](https://www.linkedin.com/in/marcin-grygiel/).

## Screenshot

<img width="626" height="713" alt="image" src="https://github.com/user-attachments/assets/09a479d7-2168-4cc1-82d6-735c2703c7a6" />

## License

This project is open-source and available under the **GNU General Public License v3.0 (GPL-3.0)**. 

### GPL-3.0 License Summary:
- You are free to use, modify, and distribute this software.
- If you distribute modified versions, you must also distribute the source code under the same GPL-3.0 license.
- This software is provided **without any warranty**.

For the full license text, see the [LICENSE](LICENSE) file in this repository.

## Acknowledgments

- Developed by **First Ever** (Marcin Grygiel).
- Special thanks to the WinUI 3 community for their support and resources.

## Version

**Adobe AVX2 Patch v1.0.0**

---

For more information, visit the [GitHub repository](https://github.com/FirstEver-eu/Adobe-AVX2-Patch).
