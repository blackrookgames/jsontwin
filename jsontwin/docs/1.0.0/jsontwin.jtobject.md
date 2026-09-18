# JTObject

Namespace: jsontwin

Represents a JSON object element

```csharp
public class JTObject : JTParent, System.Collections.Generic.IReadOnlyList`1[[jsontwin.JTObjectProperty, jsontwin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IReadOnlyCollection`1[[jsontwin.JTObjectProperty, jsontwin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IEnumerable`1[[jsontwin.JTObjectProperty, jsontwin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections.IEnumerable
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelement.md) → [JTParent](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtparent.md) → [JTObject](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtobject.md)<br>
Implements [IReadOnlyList&lt;JTObjectProperty&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1), [IReadOnlyCollection&lt;JTObjectProperty&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1), [IEnumerable&lt;JTObjectProperty&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [DefaultMemberAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.defaultmemberattribute), [JTElementAttribute](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelementattribute.md), [JsonConverterAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverterattribute)

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

## Indexers

### **this[Int32]**

```csharp
public JTObjectProperty this[int index] { get; }
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Property Value

[JTObjectProperty](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtobjectproperty.md)<br>

## Constructors

### **JTObject()**

Initializer for [JTObject](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtobject.md)

```csharp
public JTObject()
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

### **TryAdd(String, JTElement)**

Attempts to add the specified property to the object

```csharp
public bool TryAdd(string name, JTElement element)
```

#### Parameters

`name` [String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>
Property name

`element` [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelement.md)<br>
Property element

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not successful

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`name` is null
 <br>or<br>`element` is null

### **TryInsert(Int32, String, JTElement)**

Attempts to insert the specified property into the object

```csharp
public bool TryInsert(int index, string name, JTElement element)
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Insertion index

`name` [String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>
Property name

`element` [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelement.md)<br>
Property element

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not successful

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`index` is out of range

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`name` is null
 <br>or<br>`element` is null

### **RemoveAt(Int32)**

Removes the property at the specified index from the object

```csharp
public JTObjectProperty RemoveAt(int index)
```

#### Parameters

`index` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Index of property to remove

#### Returns

[JTObjectProperty](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtobjectproperty.md)<br>
Removed property

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)<br>
`index` is out of range

### **Clear()**

Removes all properties from the object

```csharp
public void Clear()
```

### **TryGet(String, out JTElement)**

Attempts to get the element of the property with the specified name

```csharp
public bool TryGet(string name, out JTElement element)
```

#### Parameters

`name` [String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>
Property name

`out` `element` [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelement.md)<br>
Property element

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether or not the property was found

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`name` is null

### **Get(String)**

Gets the element of the property with the specified name

```csharp
public JTElement Get(string name)
```

#### Parameters

`name` [String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>
Property name

#### Returns

[JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelement.md)<br>
Property element

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`name` is null

[JTException](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtexception.md)<br>
Property could not be found

### **Get&lt;T&gt;(String)**

Gets the element of the property with the specified name

```csharp
public T Get<T>(string name) where T : JTElement
```

#### Type Parameters

`T`<br>

#### Parameters

`name` [String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>
Property name

#### Returns

T<br>
Property element

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`name` is null

[JTException](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtexception.md)<br>
Property could not be found
 <br>or<br>
 Property element is not an instance of

### **GetEnumerator()**

Gets an enumerator thru the object properties

```csharp
public IEnumerator<JTObjectProperty> GetEnumerator()
```

#### Returns

[IEnumerator&lt;JTObjectProperty&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)<br>
Enumerator thru the object properties
