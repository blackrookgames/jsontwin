# JTElement

Namespace: jsontwin

Represents a JSON element

```csharp
public abstract class JTElement
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelement.md)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [JsonConverterAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverterattribute)

## Properties

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

## Methods

### **CastAs&lt;T&gt;()**

Casts the current element as an instance of

```csharp
public T CastAs<T>() where T : JTElement
```

#### Type Parameters

`T`<br>

#### Returns

T<br>
Current element casted as an instance of

#### Exceptions

[JTException](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtexception.md)<br>
Current element is not an instance of
