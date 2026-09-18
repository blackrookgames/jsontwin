# JTException

Namespace: jsontwin

Thrown when a JSON related error occurs

```csharp
public class JTException : System.Exception, System.Runtime.Serialization.ISerializable
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception) → [JTException](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtexception.md)<br>
Implements [ISerializable](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute)

## Properties

### **Element**

Related JSON element

```csharp
public JTElement? Element { get; }
```

#### Property Value

[JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelement.md)<br>

### **BaseMessage**

Base message

```csharp
public string? BaseMessage { get; }
```

#### Property Value

[String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TargetSite**

```csharp
public MethodBase? TargetSite { get; }
```

#### Property Value

[MethodBase](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.methodbase)<br>

### **Message**

```csharp
public virtual string Message { get; }
```

#### Property Value

[String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Data**

```csharp
public virtual IDictionary Data { get; }
```

#### Property Value

[IDictionary](https://learn.microsoft.com/en-us/dotnet/api/system.collections.idictionary)<br>

### **InnerException**

```csharp
public Exception? InnerException { get; }
```

#### Property Value

[Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **HelpLink**

```csharp
public virtual string? HelpLink { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Source**

```csharp
public virtual string? Source { get; set; }
```

#### Property Value

[String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>

### **HResult**

```csharp
public int HResult { get; set; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **StackTrace**

```csharp
public virtual string? StackTrace { get; }
```

#### Property Value

[String](https://learn.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **JTException(String)**

Initializer for [JTException](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtexception.md)

```csharp
public JTException(string? message)
```

#### Parameters

`message` [String](https://learn.microsoft.com/en-us/dotnet/api/system.string)?<br>
Message

### **JTException(JTElement, String)**

Initializer for [JTException](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtexception.md)

```csharp
public JTException(JTElement? element, string? message)
```

#### Parameters

`element` [JTElement](https://github.com/blackrookgames/jsontwin/tree/main/jsontwin/docs/1.0.0/jsontwin.jtelement.md)?<br>
Related JSON element

`message` [String](https://learn.microsoft.com/en-us/dotnet/api/system.string)?<br>
Base message

## Events

### **SerializeObjectState**

#### Caution

BinaryFormatter serialization is obsolete and should not be used. See https://aka.ms/binaryformatter for more information.

---

```csharp
protected event EventHandler<SafeSerializationEventArgs>? SerializeObjectState;
```
