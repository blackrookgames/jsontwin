using System;
using System.IO;
using jsontwin;

JTDocument doc = new();
using (var s = File.OpenRead("./test.json"))
    doc.Load(s);
Console.WriteLine(doc.RootElement!.CastAs<JTObject>().
    Get<JTObject>("tileset").
    Get<JTArray>("sheets").
    Get<JTObject>(3).
    Get<JTArray>("swaps").
    Get<JTObject>(0));
using (var s = File.OpenWrite("./test.output.json"))
    doc.Save(s);