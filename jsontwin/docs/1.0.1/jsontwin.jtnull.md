# JTNull

Namespace: jsontwin

Represents a JSON null element

```csharp
public class JTNull : JTElement
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelement.md) → [JTNull](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtnull.md)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [JTElementAttribute](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelementattribute.md), [JsonConverterAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverterattribute)

## Properties

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

### **JTNull()**

```csharp
public JTNull()
```
