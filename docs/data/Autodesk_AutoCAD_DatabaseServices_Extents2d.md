# Extents2d Structure

## Overview

#### Description
This class encapsulates values of simple 2D extents used in layouts and plot settings.
```text
public struct Extents2d : IFormattable {
}
```

### Constructors

- [Extents2d(double, double, double, double)](#extents2d(double,-double,-double,-double))
- [Extents2d(Point2d, Point2d)](#extents2d(point2d,-point2d))

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)
- [IsEqualTo(Extents2d)](#isequalto(extents2d))
- [IsEqualTo(Extents2d, Tolerance)](#isequalto(extents2d,-tolerance))
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))
- [ToString(string, IFormatProvider)](#tostring(string,-iformatprovider))

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [MaxPoint](#maxpoint)
- [MinPoint](#minpoint)


## Constructors Details

### Extents2d(double, double, double, double)

#### Description
This constructor creates a new 2D Extents using Double values.
```text
public Extents2d(
    double minX, 
    double minY, 
    double maxX, 
    double maxY
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double minX | Minimum X extent |
| double minY | Minimum Y extent |
| double maxX | Maximum X extent |
| double maxY | Maximum Y extent |

### Extents2d(Point2d, Point2d)

#### Description
This constructor creates a new 2D Extents using Point 2D values.
```text
public Extents2d(
    Point2d minimum, 
    Point2d maximum
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point2d minimum | Input minimum extent |
| Point2d maximum | Input maximum extent |

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

### IsEqualTo(Extents2d)

#### Description
This method compares this Extents2d object to a by calling the IsEqualTol(Extents2d a, Tolerance tolerance) overloaded method with tolerance set to Global.
```text
public bool IsEqualTo(
    Extents2d a
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Extents2d a | Object to compare |

### IsEqualTo(Extents2d, Tolerance)

#### Description
This method compares this Extents2d object with a by testing the equivalency of their definition points. If the points match within the range specified by tolerance, this method returns true. Otherwise, it returns false.
```text
public bool IsEqualTo(
    Extents2d a, 
    Tolerance tolerance
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Extents2d a | Input object to compare |
| Tolerance tolerance | Input tolerance to be used |

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

### ToString(string, IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider, displayed with a specific format. See the Microsoft .NET API documentation for details.
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
| IFormatProvider provider | Input culture-specific format |

### != Operator

#### Description
Returns true if a is not equivalent to b.
```text
public static bool operator !=(
    Extents2d a, 
    Extents2d b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Extents2d a | Left-hand operand |
| Extents2d b | Right-hand operand |

### == Operator

#### Description
Returns true if a is equivalent to b.
```text
public static bool operator ==(
    Extents2d a, 
    Extents2d b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Extents2d a | Left-hand operand |
| Extents2d b | Right-hand operand |

### MaxPoint

#### Description
Accesses the maximum point
```text
public Point2d MaxPoint;
```

#### Conditions
Read-only
### MinPoint

#### Description
Accesses the minimum point
```text
public Point2d MinPoint;
```

#### Conditions
Read-only