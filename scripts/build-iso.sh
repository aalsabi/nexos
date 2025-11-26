#!/bin/bash
set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
PROJECT_ROOT="$(cd "$SCRIPT_DIR/.." && pwd)"

echo "📀 Building NexOS ISO..."

cd "$PROJECT_ROOT/iso"

if ! command -v live-build &> /dev/null; then
    echo "❌ live-build not found. Installing..."
    sudo apt update
    sudo apt install -y live-build
fi

sudo live-build --config configs/auto/ --verbose

echo "✅ ISO built successfully!"
