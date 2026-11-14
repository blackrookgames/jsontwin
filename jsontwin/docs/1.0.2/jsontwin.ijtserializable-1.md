# IJTSerializable&lt;TElement&gt;

Namespace: jsontwin

Represents object data that can be serialized into JSON data

```csharp
public interface IJTSerializable<TElement> where TElement : JTElement
```

#### Type Parameters

`TElement`<br>
Output JSON element type

Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute)

## Methods

### **Serialize(TElement)**

Serializes the object's data

```csharp
void Serialize(TElement output)
```

#### Parameters

`output` TElement<br>
Output element

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`output` is null
