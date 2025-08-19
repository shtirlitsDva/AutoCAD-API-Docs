# IdPair Structure

## Overview

#### Description
This .NET class wraps the AcDbIdPair ObjectARX class. 
IdPair is the element class for IdMapping, which is used in deep clone operations. It holds a pair of ObjectIds. The key is the original object's ID, and the value is the cloned object's ID. 
```text
public struct IdPair {
}
```

#### See Also
IdMapping, [ObjectId](Autodesk_AutoCAD_DatabaseServices_ObjectId.md "ObjectId Structure")

## Members

### Constructors

- [IdPair](#idpair)

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [IsCloned](#iscloned)
- [IsOwnerTranslated](#isownertranslated)
- [IsPrimary](#isprimary)
- [Key](#key)
- [Value](#value)


## Constructors Details

### IdPair

#### Description
This constructor allows the creation of an IdPair object with all internal data specified in the arguments passed in.
```text
public IdPair(
    ObjectId key, 
    ObjectId value, 
    [MarshalAs(UnmanagedType.U1)] bool isCloned, 
    [MarshalAs(UnmanagedType.U1)] bool isPrimary, 
    [MarshalAs(UnmanagedType.U1)] bool isOwnerTranslated
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId key | Input objectId to use as the key |
| ObjectId value | Input objectId to use as the value |
| [MarshalAs(UnmanagedType.U1)] bool isCloned | Input Boolean indicating if it has been cloned already |
| [MarshalAs(UnmanagedType.U1)] bool isPrimary | Input Boolean indicating if it is a primary object |
| [MarshalAs(UnmanagedType.U1)] bool isOwnerTranslated | Input Boolean indicating if its owner has already been translated |

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
| object obj | Object to compare against |

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
| IFormatProvider provider | Culture-specific format |

### != Operator

#### Description
Returns true if a does not equal b
```text
public static bool operator !=(
    IdPair a, 
    IdPair b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IdPair a | Left operand |
| IdPair b | Right operand |

### == Operator

#### Description
Returns true if a equals b
```text
public static bool operator ==(
    IdPair a, 
    IdPair b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IdPair a | Left operand |
| IdPair b | Right operand |

### IsCloned

#### Description
Assesses if the key object has been cloned.
```text
public bool IsCloned;
```

#### Conditions
Read-only
### IsOwnerTranslated

#### Description
Assesses if the owner has been translated.
```text
public bool IsOwnerTranslated;
```

#### Conditions
Read-only
### IsPrimary

#### Description
Assesses if the key object is part of the primary set of objects being cloned, or if it was "deep cloned" because it was owned by a cloned primary object.
```text
public bool IsPrimary;
```

#### Conditions
Read-only
### Key

#### Description
Accesses the key (which is the objectId of the original object).
```text
public ObjectId Key;
```

#### Conditions
Read-only
### Value

#### Description
Accesses the value (which is the objectId of the cloned object).
```text
public ObjectId Value;
```

#### Conditions
Read-only