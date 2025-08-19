# Rectangle3d Structure

## Overview

#### Description
This .NET class loosely wraps the CRectangle3d ObjectARX class. 
This class provides a container for the points that define a 3D rectangle.
```text
public struct Rectangle3d {
}
```

### Constructors

- [Rectangle3d](#rectangle3d)

### Methods

- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [LowerLeft](#lowerleft)
- [LowerRight](#lowerright)
- [UpperLeft](#upperleft)
- [UpperRight](#upperright)


## Constructors Details

### Rectangle3d

#### Description
Constructs a new rectangle
```text
public Rectangle3d(
    Point3d upperLeft, 
    Point3d upperRight, 
    Point3d lowerLeft, 
    Point3d lowerRight
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d upperLeft | Input upper left point |
| Point3d upperRight | Input upper right point |
| Point3d lowerLeft | Input lower left point |
| Point3d lowerRight | Input lower right point |

### ToString()

#### Description
Returns an equivalent string representation of this object. See the Microsoft .NET API documentation for details.
```text
public sealed override string ToString();
```

### ToString(IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider. See the Microsoft .NET API documentation for details
```text
public string ToString(
    IFormatProvider provider
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IFormatProvider provider | Input culture-specific format. |

### LowerLeft

#### Description
Accesses the lower left point
```text
public Point3d LowerLeft;
```

#### Conditions
Read-only
### LowerRight

#### Description
Accesses the lower right point
```text
public Point3d LowerRight;
```

#### Conditions
Read-only
### UpperLeft

#### Description
Accesses the upper left point
```text
public Point3d UpperLeft;
```

#### Conditions
Read-only
### UpperRight

#### Description
Accesses the upper right point
```text
public Point3d UpperRight;
```

#### Conditions
Read-only