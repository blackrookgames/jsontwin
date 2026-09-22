# JTString

Namespace: jsontwin

Represents a JSON string element

```csharp
public class JTString : JTElement
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelement.md) → [JTString](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtstring.md)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [JTElementAttribute](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelementattribute.md), [JsonConverterAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverterattribute)

## Properties

### **Value**

String value

```csharp
public string? Value { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Document**

Document

```csharp
public JTDocument? Document { get; }
```

#### Property Value

[JTDocument](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtdocument.md)<br>

### **Parent**

Parent element

```csharp
public JTParent? Parent { get; }
```

#### Property Value

[JTParent](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtparent.md)<br>

### **Index**

Index in parent; meaningless if element does not have a parent

```csharp
public int Index { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **JTString()**

Initializer for [JTString](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtstring.md)

```csharp
public JTString()
```

### **JTString(String)**

Initializer for [JTString](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtstring.md)

```csharp
public JTString(string? value)
```

#### Parameters

`value` [String](https://learn.microsoft.com/en-us/dotnet/api/system.string)?<br>
String value
