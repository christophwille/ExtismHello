// https://github.com/extism/dotnet-sdk

using Extism.Sdk;
using System.Text;

var manifest = new Manifest(new PathWasmSource("code.wasm"));
using var plugin = new Plugin(manifest, new HostFunction[] { }, withWasi: true);

var output = Encoding.UTF8.GetString(
    plugin.Call("count_vowels", Encoding.UTF8.GetBytes("Hello World!"))
);

Console.WriteLine(output);