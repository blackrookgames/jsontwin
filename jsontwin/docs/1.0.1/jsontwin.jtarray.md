# JTArray

Namespace: jsontwin

Represents a JSON array element

```csharp
public class JTArray : JTParent, System.Collections.Generic.IReadOnlyList`1[[jsontwin.JTElement, jsontwin, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IReadOnlyCollection`1[[jsontwin.JTElement, jsontwin, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IEnumerable`1[[jsontwin.JTElement, jsontwin, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null]], System.Collections.IEnumerable
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelement.md) → [JTParent](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtparent.md) → [JTArray](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtarray.md)<br>
Implements [IReadOnlyList&lt;JTElement&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1), [IReadOnlyCollection&lt;JTElement&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1), [IEnumerable&lt;JTElement&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [DefaultMemberAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.defaultmemberattribute), [JTElementAttribute](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelementattribute.md), [JsonConverterAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverterattribute)

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

## Indexers

### **this[Int32]**

```csharp
public JTElement this[int index] { get; }
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Property Value

[JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelement.md)<br>

## Constructors

### **JTArray()**

```csharp
public JTArray()
```

## Methods

### **EnsureCapacity(Int32)**

Ensures the capacity is at least the specified minimum

```csharp
public int EnsureCapacity(int capacity)
```

#### Parameters

`capacity` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Minimum capacity

#### Returns

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Adjusted capacity

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`capacity` is negative

### **TrimExcess()**

Sets the capacity to the actual number of child elements

```csharp
public void TrimExcess()
```

### **TryAdd(JTElement)**

Attempts to add the specified element to the array

```csharp
public bool TryAdd(JTElement element)
```

#### Parameters

`element` [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelement.md)<br>
Element to add

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not successful

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`element` is null

### **TryInsert(Int32, JTElement)**

Attempts to insert the specified element into the array

```csharp
public bool TryInsert(int index, JTElement element)
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Insertion index

`element` [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelement.md)<br>
Element to insert

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not successful

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`index` is out of range

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`element` is null

### **RemoveAt(Int32)**

Removes the element at the specified index from the array

```csharp
public JTElement RemoveAt(int index)
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Index of element to remove

#### Returns

[JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.1/jsontwin.jtelement.md)<br>
Removed element

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`index` is out of range

### **Clear()**

Removes all elements from the array

```csharp
public void Clear()
```

### **GetEnumerator()**

Gets an enumerator thru the array elements

```csharp
public IEnumerator<JTElement> GetEnumerator()
```

#### Returns

[IEnumerator&lt;JTElement&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)<br>
Enumerator thru the array elements
