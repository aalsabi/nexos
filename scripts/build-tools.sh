#!/bin/bash
set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
PROJECT_ROOT="$(cd "$SCRIPT_DIR/.." && pwd)"

echo "🛠️ Building C# tools..."

cd "$PROJECT_ROOT/tools"

for project in */; do
    if [ -f "$project/${project%/}.csproj" ]; then
        echo "Building $project..."
        cd "$project"
        dotnet build -c Release
        dotnet publish -c Release -r linux-x64 --self-contained true
        cd ..
    fi
done

echo "✅ C# tools built successfully!"
