# PlotStyleDescriptor Structure

## Overview

#### Description
This class encapsulates a PlotStyleNameType ObjectARX enum value, and the object ID of the associated plot style name dictionary entry.
```text
public struct PlotStyleDescriptor {
}
```

### Constructors

- [PlotStyleDescriptor](#plotstyledescriptor)

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [Id](#id)
- [Type](#type)


## Constructors Details

### PlotStyleDescriptor

#### Description
Creates a new object.
```text
public PlotStyleDescriptor(
    ObjectId id, 
    Autodesk.AutoCAD.DatabaseServices.PlotStyleNameType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | Object ID of plot to create from |
| Autodesk.AutoCAD.DatabaseServices.PlotStyleNameType type | New type of plot style name |

### Equals

#### Description
Returns true if this object is identical to the argument object.
```text
public sealed override bool Equals(
    object unmanagedObjPtr
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| object unmanagedObjPtr | Object to compare with |

### GetHashCode

#### Description
Returns the hash code for this object. See the Microsoft .NET API documentation for details.
```text
public int GetHashCode();
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
Returns true if a does not equal b.
```text
public static bool operator !=(
    PlotStyleDescriptor a, 
    PlotStyleDescriptor b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotStyleDescriptor a | Left operand |
| PlotStyleDescriptor b | Right operand |

### == Operator

#### Description
Returns true if a equals b.
```text
public static bool operator ==(
    PlotStyleDescriptor a, 
    PlotStyleDescriptor b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotStyleDescriptor a | Left operand |
| PlotStyleDescriptor b | Right operand |

### Id

#### Description
Accesses the plot ID.
```text
public ObjectId Id;
```

#### Conditions
Read-only
### Type

#### Description
Accesses the type of plot style name.
```text
public Autodesk.AutoCAD.DatabaseServices.PlotStyleNameType Type;
```

#### Conditions
Read-only