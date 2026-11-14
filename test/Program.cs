using System;
using System.IO;
using jsontwin;

class Test : IJTDeserializable<JTObject>, IJTSerializable<JTObject>
{
    public readonly TestHeader Header = new();
    public readonly TestAssembly Assembly = new();
    public readonly TestPalette Palette = new();

    /// <inheritdoc/>
    public void Deserialize(JTObject input)
    {
        Header.Deserialize(input.Get<JTObject>("header"));
        Assembly.Deserialize(input.Get<JTObject>("assembly"));
        Palette.Deserialize(input.Get<JTObject>("palette"));
    }

    /// <inheritdoc/>
    public void Serialize(JTObject output)
    {
        JTObject e_Header = new();
        Header.Serialize(e_Header);
        output.TryAdd("header", e_Header);
        JTObject e_Assembly = new();
        Assembly.Serialize(e_Assembly);
        output.TryAdd("assembly", e_Assembly);
        JTObject e_Palette = new();
        Palette.Serialize(e_Palette);
        output.TryAdd("palette", e_Palette);
    }
}

class TestHeader : IJTDeserializable<JTObject>, IJTSerializable<JTObject>
{
    public string? Output;
    public string? Def;

    /// <inheritdoc/>
    public void Deserialize(JTObject input)
    {
        ArgumentNullException.ThrowIfNull(input);
        Output = input.Get<JTString>("output").Value;
        Def = input.Get<JTString>("def").Value;
    }

    /// <inheritdoc/>
    public void Serialize(JTObject output)
    {
        ArgumentNullException.ThrowIfNull(output);
        output.TryAdd("output", new JTString() { Value = Output });
        output.TryAdd("def", new JTString() { Value = Def });
    }
}

class TestAssembly : IJTDeserializable<JTObject>, IJTSerializable<JTObject>
{
    public string? Output;

    /// <inheritdoc/>
    public void Deserialize(JTObject input)
    {
        ArgumentNullException.ThrowIfNull(input);
        Output = input.Get<JTString>("output").Value;
    }

    /// <inheritdoc/>
    public void Serialize(JTObject output)
    {
        ArgumentNullException.ThrowIfNull(output);
        output.TryAdd("output", new JTString() { Value = Output });
    }
}

class TestPalette : IJTDeserializable<JTObject>, IJTSerializable<JTObject>
{
    public string? Output;
    public string? LabelBeg;
    public string? LabelEnd;

    /// <inheritdoc/>
    public void Deserialize(JTObject input)
    {
        ArgumentNullException.ThrowIfNull(input);
        Output = input.Get<JTString>("output").Value;
        LabelBeg = input.Get<JTString>("label_beg").Value;
        LabelEnd = input.Get<JTString>("label_end").Value;
    }

    /// <inheritdoc/>
    public void Serialize(JTObject output)
    {
        ArgumentNullException.ThrowIfNull(output);
        output.TryAdd("output", new JTString() { Value = Output });
        output.TryAdd("label_beg", new JTString() { Value = LabelBeg });
        output.TryAdd("label_end", new JTString() { Value = LabelEnd });
    }
}

class Program
{
    static void Main(string[] args)
    {
        Test test = new();
        // Load JSON
        using (var s = File.OpenRead("./test.json"))
        {
            JTDocument doc = new();
            doc.Load(s);
            // Find root element
            if (doc.RootElement is null)
                throw new JTException("Source cannot be empty.");
            // Deserialize
            test.Deserialize(doc.RootElement.CastAs<JTObject>());
        }
        // Print content
        Console.WriteLine($"Header.Output:      {test.Header.Output}");
        Console.WriteLine($"Header.Def:         {test.Header.Def}");
        Console.WriteLine($"Assembly.Output:    {test.Assembly.Output}");
        Console.WriteLine($"Palette.Output:     {test.Palette.Output}");
        Console.WriteLine($"Palette.LabelBeg:   {test.Palette.LabelBeg}");
        Console.WriteLine($"Palette.LabelEnd:   {test.Palette.LabelEnd}");
        // Save JSON
        Directory.CreateDirectory("./.secret");
        using (var s = File.OpenWrite("./.secret/test.output.json"))
        {
            JTDocument doc = new();
            JTObject root = new();
            test.Serialize(root);
            doc.RootElement = root;
            doc.Save(s);
        }
    }
}