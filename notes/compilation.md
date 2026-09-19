Compile NativeAot and strip output:

```bash
dotnet publish -c Release -r osx-arm64 \
    -p:PublishAot=true                 \
    -p:PublishTrimmed=true             \
    -p:StripSymbols=true               \
    -p:DebuggerSupport=false
```

Version for single file app:

```bash
dotnet publish -c Release -r osx-arm64 \
    -p:PublishSingleFile=true          \
    -p:PublishAot=true                 \
    -p:PublishTrimmed=true             \
    -p:StripSymbols=true               \
    -p:DebuggerSupport=false
```

Not aot, but with pre-compiled methods with ReadyToRun (app lauches faster):

```bash
dotnet publish -c Release -r osx-arm64 \
    -p:PublishSingleFile=true          \
    -p:PublishReadyToRun=true          \
    -p:PublishTrimmed=true             \
    -p:StripSymbols=true               \
    -p:DebuggerSupport=false
```