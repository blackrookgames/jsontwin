using System.IO;
using System.Text.Json;
using jsontwin;

var element = JsonSerializer.Deserialize<JTElement>(File.ReadAllText("./test.json"));