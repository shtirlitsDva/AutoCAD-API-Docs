# PickPointDescriptor Structure

## Overview

#### Description
This class describes the shape of a pick point.
```text
public struct PickPointDescriptor {
}
```

### Constructors

- [PickPointDescriptor](#pickpointdescriptor)

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)
- [IsEqualTo(PickPointDescriptor)](#isequalto(pickpointdescriptor))
- [IsEqualTo(PickPointDescriptor, Tolerance)](#isequalto(pickpointdescriptor,-tolerance))
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [Direction](#direction)
- [Kind](#kind)
- [PointOnLine](#pointonline)


## Constructors Details

### PickPointDescriptor

#### Description
Constructor.
```text
public PickPointDescriptor(
    PickPointKind kind, 
    Point3d pointOnLine, 
    Vector3d direction
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| PickPointKind kind | Input the type of pick point |
| Point3d pointOnLine | Input the point on the line to pick |
| Vector3d direction | Input the direction of the pick |

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
| object obj | Input object to compare |

### GetHashCode

#### Description
Returns the hash code for this object. See the Microsoft .NET API documentation for details.
```text
public sealed override int GetHashCode();
```

### IsEqualTo(PickPointDescriptor)

#### Description
This method compares the PointOnLine and Direction properties of a to those of this object, using Global tolerance.
```text
public bool IsEqualTo(
    PickPointDescriptor a
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| PickPointDescriptor a | Input object to compare |

### IsEqualTo(PickPointDescriptor, Tolerance)

#### Description
This method compares the PointOnLine and Direction properties of a to those of this object, using the tolerance specified by tolerance.
```text
public bool IsEqualTo(
    PickPointDescriptor a, 
    Tolerance tolerance
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| PickPointDescriptor a | Input object to compare |
| Tolerance tolerance | Input tolerance value |

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
| IFormatProvider provider | Input culture-specific format |

### != Operator

#### Description
Returns true if a does not equal b.
```text
public static bool operator !=(
    PickPointDescriptor a, 
    PickPointDescriptor b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| PickPointDescriptor a | Left operand |
| PickPointDescriptor b | Right operand |

### == Operator

#### Description
Returns true if a equals b.
```text
public static bool operator ==(
    PickPointDescriptor a, 
    PickPointDescriptor b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| PickPointDescriptor a | Left operand |
| PickPointDescriptor b | Right operand |

### Direction

#### Description
Gets a vector that describes the direction of the infinite line or the direction and length for ray and line segment "shapes".
```text
public Vector3d Direction;
```

#### Conditions
Read-only
### Kind

#### Description
Gets the general "shape" of the pick point.
```text
public PickPointKind Kind;
```

#### Conditions
Read-only
### PointOnLine

#### Description
Gets a point on the line, ray or line segment that represents the pick point. For a ray or line segment "shapes" this is the first point.
```text
public Point3d PointOnLine;
```

#### Conditions
Read-only