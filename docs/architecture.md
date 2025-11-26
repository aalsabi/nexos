# NexOS Architecture

## System Layers

### 1. Base Layer (Debian sid)
- Linux kernel 6.x+
- systemd + core utilities
- Firmware & microcode
- APT/dpkg

### 2. System Layer
- Meta-packages:
  - `nexos-base`
  - `nexos-desktop-gnome`
  - `nexos-gaming`
  - `nexos-devtools`
  - `nexos-l10n-ar`
- System configuration & services
- Security and hardening

### 3. Desktop Layer
- GNOME 45+ (Wayland only)
- Custom themes & icons
- GNOME extensions
- RTL support fully enabled

### 4. Tools Layer (C#/GTK4)
- NexOS.Welcome
- NexOS.Installer
- NexOS.Drivers
- NexOS.Gaming
- NexOS.Settings
- NexOS.DevCenter

### 5. Apps Layer
- Flatpak as primary delivery
- Flathub remote
- Selected desktop apps
