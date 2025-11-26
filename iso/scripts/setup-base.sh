#!/bin/bash
set -e

echo "Setting up NexOS base system inside chroot..."

apt-get update
apt-get install -y \
  live-boot live-config systemd-sysv \
  gnome-shell gnome-session gdm3 \
  nexos-base nexos-desktop-gnome nexos-welcome

systemctl enable gdm3 || true
systemctl enable NetworkManager || true

echo "Base system setup completed."
