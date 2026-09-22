# JTDocument

Namespace: jsontwin

Represents a JSON document

```csharp
public class JTDocument
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [JTDocument](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtdocument.md)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute)

## Properties

### **RootElement**

Gets or sets the root element

```csharp
public JTElement? RootElement { get; set; }
```

#### Property Value

[JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelement.md)<br>

#### Exceptions

[ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception)<br>
Value is already part of a document

## Constructors

### **JTDocument()**

```csharp
public JTDocument()
```

## Methods

### **Load(Stream, Encoding)**

Loads JSON data from the specified stream

```csharp
public void Load(Stream s, Encoding? encoding = null)
```

#### Parameters

`s` [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream)<br>
Stream to load from

`encoding` [Encoding](https://learn.microsoft.com/en-us/dotnet/api/system.text.encoding)?<br>
Character encoding

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`s` is null

[ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception)<br>
`s` does not support reading

[OutOfMemoryException](https://learn.microsoft.com/en-us/dotnet/api/system.outofmemoryexception)<br>
Insufficient memory

[IOException](https://learn.microsoft.com/en-us/dotnet/api/system.io.ioexception)<br>
I/O error occurred

[JTException](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtexception.md)<br>
`s` does not contain valid JSON

### **Load(Stream, Boolean, Encoding)**

Loads JSON data from the specified stream

```csharp
public void Load(Stream s, bool detectEncodingFromByteOrderMarks, Encoding? encoding = null)
```

#### Parameters

`s` [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream)<br>
Stream to load from

`detectEncodingFromByteOrderMarks` [Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not to look for byte order marks at beginning

`encoding` [Encoding](https://learn.microsoft.com/en-us/dotnet/api/system.text.encoding)?<br>
Character encoding

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`s` is null

[ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception)<br>
`s` does not support reading

[OutOfMemoryException](https://learn.microsoft.com/en-us/dotnet/api/system.outofmemoryexception)<br>
Insufficient memory

[IOException](https://learn.microsoft.com/en-us/dotnet/api/system.io.ioexception)<br>
I/O error occurred

[JTException](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtexception.md)<br>
`s` does not contain valid JSON

### **Save(Stream, Encoding)**

Saves JSON data to the specified stream

```csharp
public void Save(Stream s, Encoding? encoding = null)
```

#### Parameters

`s` [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream)<br>
Stream to save to

`encoding` [Encoding](https://learn.microsoft.com/en-us/dotnet/api/system.text.encoding)?<br>
Character encoding

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`s` is null

[ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception)<br>
`s` does not support writing

[IOException](https://learn.microsoft.com/en-us/dotnet/api/system.io.ioexception)<br>
I/O error occurred

### **LoadFromString(String)**

Loads JSON data from the specified string

```csharp
public void LoadFromString(string s)
```

#### Parameters

`s` [String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>
String to load from

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`s` is null

[JTException](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtexception.md)<br>
`s` is not valid JSON

### **SaveToString()**

Saves JSON data to a string

```csharp
public string SaveToString()
```

#### Returns

[String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>
