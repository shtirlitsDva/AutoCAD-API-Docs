# Handle Structure

## Overview

#### Description
This .NET class wraps the AcDbHandle ObjectARX class. 
The Handle class is the ObjectARX class designed to encapsulate the 64-bit integer handle identifiers that have been in AutoCAD for several releases before R13. A handle uniquely identifies an DBObject within a single database and is saved with that object in the database so that it persists from session to session. Handles are not unique across databases, however. In fact, duplication across databases is almost a certainty, since all databases start with the same hand seed value of 1 and go up from there.
```text
public struct Handle {
}
```

#### Notes
If you have a handle and want the objectId of the object it goes to, then you need to use the Database.GetObjectId() function. 
If you have an objectId and want to get the handle of the object it identifies, then you need to open the object and use its DBObject.GetHandle() function.
### Constructors

- [Handle](#handle)

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [IsOne](#isone)
- [Value](#value)


## Constructors Details

### Handle

#### Description
Constructs a handle using the input the 64 bit handle value.
```text
public Handle(
    long value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| long value | Input all 64 bits of the handle |

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
| object obj | Object to compare |

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
| IFormatProvider provider | Input culture-specific format |

### != Operator

#### Description
Returns true if a is not equal to b
```text
public static bool operator !=(
    Handle a, 
    Handle b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Handle a | Left operand |
| Handle b | Right operand |

### == Operator

#### Description
Returns true if a is equal to b
```text
public static bool operator ==(
    Handle a, 
    Handle b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Handle a | Left operand |
| Handle b | Right operand |

### IsOne

#### Description
Assesses true if the handle value in this object is 1.
```text
public bool IsOne;
```

#### Conditions
Read-only
### Value

#### Description
Accesses the value of the handle.
```text
public long Value;
```

#### Conditions
Read-only