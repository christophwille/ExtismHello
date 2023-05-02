using Extism.Sdk;
using Extism.Sdk.Native;
using System.Text;

var context = new Context();
var wasm = await File.ReadAllBytesAsync("code.wasm");
using var plugin = context.CreatePlugin(wasm, new HostFunction[0], withWasi: true);

var output = Encoding.UTF8.GetString(
    plugin.CallFunction("count_vowels", Encoding.UTF8.GetBytes("Hello World!"))
);

Console.WriteLine(output);