#!/bin/bash
set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
PROJECT_ROOT="$(cd "$SCRIPT_DIR/.." && pwd)"

echo "🚀 Building NexOS..."

echo "📦 Building C# tools..."
"$SCRIPT_DIR/build-tools.sh"

echo "📦 Building .deb packages..."
"$SCRIPT_DIR/build-debs.sh"

echo "📀 Building ISO..."
"$SCRIPT_DIR/build-iso.sh"

echo "✅ Build completed successfully!"
