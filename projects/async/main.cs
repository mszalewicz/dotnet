Console.WriteLine("Calling async method...");
string result = await GetDataAsync();
Console.WriteLine($"Result: {result}");

static async Task<string> GetDataAsync()
{
    await Task.Delay(2000);
    return "data...";
}