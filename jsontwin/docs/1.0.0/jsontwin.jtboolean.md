# JTBoolean

Namespace: jsontwin

Represents a JSON boolean element

```csharp
public class JTBoolean : JTElement
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelement.md) → [JTBoolean](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtboolean.md)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [JTElementAttribute](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelementattribute.md), [JsonConverterAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverterattribute)

## Properties

### **Value**

Boolean value

```csharp
public bool Value { get; set; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Document**

Document

```csharp
public JTDocument? Document { get; }
```

#### Property Value

[JTDocument](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtdocument.md)<br>

### **Parent**

Parent element

```csharp
public JTParent? Parent { get; }
```

#### Property Value

[JTParent](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtparent.md)<br>

### **Index**

Index in parent; meaningless if element does not have a parent

```csharp
public int Index { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **JTBoolean()**

Initializer for [JTBoolean](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtboolean.md)

```csharp
public JTBoolean()
```

### **JTBoolean(Boolean)**

Initializer for [JTBoolean](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtboolean.md)

```csharp
public JTBoolean(bool value)
```

#### Parameters

`value` [Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Boolean value
