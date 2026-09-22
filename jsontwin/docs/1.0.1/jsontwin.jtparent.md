# JTParent

Namespace: jsontwin

Represents a JSON parent element

```csharp
public abstract class JTParent : JTElement
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelement.md) → [JTParent](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtparent.md)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [JsonConverterAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverterattribute)

## Properties

### **Capacity**

Number of child elements internal data structure can hold without resizing

```csharp
public int Capacity { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Count**

Number of child elements

```csharp
public int Count { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

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

## Methods

### **Get(Int32)**

Gets the child element at the specified index

```csharp
public JTElement Get(int index)
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Index of child element

#### Returns

[JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelement.md)<br>
Child element at the specified index

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`index` is out of range

### **Get&lt;T&gt;(Int32)**

Gets the child element at the specified index

```csharp
public T Get<T>(int index) where T : JTElement
```

#### Type Parameters

`T`<br>

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Index of child element

#### Returns

T<br>
Child element at the specified index

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`index` is out of range

[JTException](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtexception.md)<br>
Child element is not an instance of
