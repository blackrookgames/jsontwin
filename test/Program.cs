using System;
using System.IO;
using System.Text.Json;
using jsontwin;

JTDocument doc0 = new();
JTDocument doc1 = new();

JTObject root = new();
doc0.RootElement = root;

JTArray array = new();
root.TryAdd("List", array);

JTNumber number = new();
Console.WriteLine(array.TryAdd(number));

JTBoolean boolean = new();
Console.WriteLine(array.TryAdd(boolean));
Console.WriteLine(array.TryAdd(number));

File.WriteAllText("./test.json", JsonSerializer.Serialize<JTElement>(root));