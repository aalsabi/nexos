#!/bin/bash
set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
PROJECT_ROOT="$(cd "$SCRIPT_DIR/.." && pwd)"

echo "📦 Building Debian packages..."

cd "$PROJECT_ROOT/packages/meta"

for package in */; do
    if [ -f "$package/debian/control" ]; then
        echo "Building $package..."
        cd "$package"
        dpkg-buildpackage -uc -us -b
        cd ..
    fi
done

echo "✅ Debian packages built successfully!"
