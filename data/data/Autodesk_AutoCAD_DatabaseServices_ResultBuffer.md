# ResultBuffer Class

## Overview

#### Description
This .NET class wraps the resbuf ObjectARX struct. 
Result buffer structure that handles all AutoCAD basic data types. See _ObjectARX Global Utility Functions- >Variables, Types, and Values Defined in ObjectARX->Result Buffers and Type Codes_ in the _ObjectARX Developer's Guide_ for more information.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ResultBuffer
```

```text
public sealed class ResultBuffer : DisposableWrapper, IEnumerable, IFormattable;
```

### Constructors

- [ResultBuffer()](#resultbuffer())
- [ResultBuffer(params TypedValue[])](#resultbuffer(params-typedvalue[]))

### Methods

- [Add(object)](#add(object))
- [Add(TypedValue)](#add(typedvalue))
- [AsArray](#asarray)
- [Create](#create)
- [Equals](#equals)
- [GetEnumerator](#getenumerator)
- [GetHashCode](#gethashcode)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))
- [ToString(string, IFormatProvider)](#tostring(string,-iformatprovider))

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)


## Constructors Details

### ResultBuffer()

#### Description
Default constructor.
```text
public ResultBuffer();
```

### ResultBuffer(params TypedValue[])

#### Description
```text
public ResultBuffer(
    params TypedValue\[\] values
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| params TypedValue[] values | Input values |

#### Conditions
Read-only
### Add(object)

#### Description
Adds value to the end of this ResultBuffer's list.
```text
public void Add(
    object value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| object value | Input object to add |

### Add(TypedValue)

#### Description
If value can be coerced to type TypedValue , then it is added to the end of this ResultBuffer's list.
```text
public void Add(
    TypedValue value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| TypedValue value | Input object to add |

### AsArray

#### Description
This method returns an array of typed values representing the nodes in the resbuf chain.
```text
public TypedValue\[\] AsArray();
```

### Create

#### Description
This method creates a managed ResultBuffer object from an unmanaged resbuf pointer.
```text
public static ResultBuffer Create(
    IntPtr buffer, 
    [MarshalAs(UnmanagedType.U1)] bool autoDelete
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IntPtr buffer | Input pointer |
| [MarshalAs(UnmanagedType.U1)] bool autoDelete | Set to true if the pointer should be deleted after creation |

### Equals

#### Description
Returns true if this object is identical to the argument object..
```text
public sealed override bool Equals(
    object obj
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| object obj | Object to check against |

### GetEnumerator

#### Description
Returns an enumerator object for this ResultBuffer object.
```text
public ResultBufferEnumerator GetEnumerator();
```

### GetHashCode

#### Description
Returns the hash code for this object. See the Microsoft .NET API documentation for details.
```text
public sealed override int GetHashCode();
```

### ToString()

#### Description
Returns an equivalent string representation of this object. See the Microsoft .NET API documentation for details.
```text
public sealed override string ToString();
```

### ToString(IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider. See the Microsoft .NET API documentation for details.
```text
public string ToString(
    IFormatProvider provider
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IFormatProvider provider | Input culture definition |

### ToString(string, IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in a specific format, with the culture-specific format defined by provider.
```text
public string ToString(
    string format, 
    IFormatProvider provider
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string format | Input format for string |
| IFormatProvider provider | Input culture definition |

### != Operator

#### Description
Returns true if a does not equal b.
```text
public static bool operator !=(
    ResultBuffer a, 
    ResultBuffer b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ResultBuffer a | Left operand |
| ResultBuffer b | Right operand |

### == Operator

#### Description
Returns true if a equals b.
```text
public static bool operator ==(
    ResultBuffer a, 
    ResultBuffer b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ResultBuffer a | Left operand |
| ResultBuffer b | Right operand |
