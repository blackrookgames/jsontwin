# JTNumber

Namespace: jsontwin

Represents a JSON number element

```csharp
public class JTNumber : JTElement
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelement.md) → [JTNumber](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtnumber.md)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [JTElementAttribute](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelementattribute.md), [JsonConverterAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverterattribute)

## Properties

### **Value**

Number value

```csharp
public decimal Value { get; set; }
```

#### Property Value

[Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal)<br>

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

### **JTNumber()**

Initializer for [JTNumber](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtnumber.md)

```csharp
public JTNumber()
```

### **JTNumber(Decimal)**

Initializer for [JTNumber](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtnumber.md)

```csharp
public JTNumber(decimal value)
```

#### Parameters

`value` [Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal)<br>
Number value
