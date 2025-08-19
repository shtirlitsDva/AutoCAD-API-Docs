# TypedValue Structure

## Overview

#### Description
This value type may contain objects of various types. The type of the value is indicated by this object's TypeCode property, which is analogous to the restype member of the ObjectARX resbuf structure. See _ObjectARX Developer's Guide_ for more information on resbuf. 
This type also defines XML serialization elements that correspond to the data types supported by the resbuf struct.
```text
public struct TypedValue : IFormattable {
}
```

### Constructors

- [TypedValue(int)](#typedvalue(int))
- [TypedValue(int, object)](#typedvalue(int,-object))

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))
- [ToString(string, IFormatProvider)](#tostring(string,-iformatprovider))

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [TypeCode](#typecode)
- [Value](#value)


## Constructors Details

### TypedValue(int)

#### Description
Constructs an object given a type code.
```text
public TypedValue(
    int typeCode
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int typeCode | Input the type code. |

### TypedValue(int, object)

#### Description
Constructs an object given a type code and a value.
```text
public TypedValue(
    int typeCode, 
    object value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int typeCode | Input the type code. |
| object value | Input the value. |

### Equals

#### Description
Returns true if this object is identical to the argument object.
```text
public sealed override bool Equals(
    object obj
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| object obj | Input object to compare with. |

### GetHashCode

#### Description
Returns the hash code for this object.
```text
public sealed override int GetHashCode();
```

### ToString()

#### Description
Returns an equivalent string representation of this object.
```text
public sealed override string ToString();
```

### ToString(IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider.
```text
public string ToString(
    IFormatProvider provider
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IFormatProvider provider | Input System.IFormatProvider object. |

### ToString(string, IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider, displayed with a specific format.
```text
public string ToString(
    string format, 
    IFormatProvider provider
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string format | Input format to display |
| IFormatProvider provider | Input System.IFormatProvider object. |

#### Returns
string object.
### != Operator

#### Description
Returns true if a does not equal b.
```text
public static bool operator !=(
    TypedValue a, 
    TypedValue b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| TypedValue a | Left operand |
| TypedValue b | Right operand |

### == Operator

#### Description
Returns true if a equals b.
```text
public static bool operator ==(
    TypedValue a, 
    TypedValue b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| TypedValue a | Left operand |
| TypedValue b | Right operand |

### TypeCode

#### Description
Returns the TypeCode property value.
```text
public short TypeCode;
```

#### Conditions
Read-only
### Value

#### Description
Returns the Value property value.
```text
public object Value;
```

#### Conditions
Read-only