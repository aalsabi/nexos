# Developer Setup Guide

## Prerequisites

- Debian sid (أو مشتق قريب).
- .NET 8.0 SDK على الأقل.
- libgtk-4-dev
- libadwaita-1-dev
- debhelper, dpkg-dev
- live-build

## Setup

```bash
sudo apt update
sudo apt install -y dotnet-sdk-8.0 libgtk-4-dev libadwaita-1-dev debhelper dpkg-dev live-build

git clone https://github.com/GITHUB_USERNAME/nexos-project
cd nexos-project

./scripts/build-tools.sh
./scripts/build-debs.sh
./scripts/build-iso.sh
```

## Project Layout (مختصر)

- `tools/` : أدوات NexOS (C#/GTK4).
- `packages/` : تعريفات الحزم (.deb و meta).
- `iso/` : إعدادات live-build و الـ ISO.
- `branding/` : ثيمات، أيقونات، خلفيات.
- `scripts/` : سكربتات البناء.
