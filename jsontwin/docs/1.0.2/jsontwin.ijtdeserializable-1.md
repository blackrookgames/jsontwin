# IJTDeserializable&lt;TElement&gt;

Namespace: jsontwin

Represents object data that can be deserialized from JSON data

```csharp
public interface IJTDeserializable<TElement> where TElement : JTElement
```

#### Type Parameters

`TElement`<br>
Input JSON element type

Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute)

## Methods

### **Deserialize(TElement)**

Deserializes JSON data

```csharp
void Deserialize(TElement input)
```

#### Parameters

`input` TElement<br>
Input element

#### Exceptions

[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
`input` is null

[JTException](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.2/jsontwin.jtexception.md)<br>
`input` contains invalid data
