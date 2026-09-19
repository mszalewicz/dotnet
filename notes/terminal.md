Can change terminal colors like this:

```csharp
Console.ForegroundColor = ConsoleColor.Red;
```

Reading particular key strokes:

```csharp
ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

if (keyInfo.Key == ConsoleKey.H)
{
    ...
}
```
