# Extents3d Structure

## Overview

#### Description
This .NET class wraps the AcDbExtents ObjectARX class. 
It class was designed to be used with the GetSubentityGeometricExtents() function of Entity-derived classes. It embodies a box in 3D space whose edges are parallel to the axes of the WCS. This box is represented in the private data of an Extents3d object as a minimum point (MinPoint) and a maximum point (MaxPoint). At all times **except** immediately after an Extents3d object has been instantiated with the default constructor (see below), each of the X, Y, and Z values of MinPoint must be <= the corresponding values of MaxPoint.
```text
public struct Extents3d : IFormattable {
}
```

#### Notes
The intended use of an Extents3d object is to store the "tight bounding box" of an entity or collection of entities. A typical way to compute it is to instantiate it with the default constructor, then to iterate through all the points of the geometry in question and feed them to the AddPoint() member function. This accumulates a bounding box with the smallest values encountered for X, Y, and Z in MinPoint and the largest values in MaxPoint.
#### See Also
Entity.GetSubentityGeometricExtents()

## Members

### Constructors

- [Extents3d()](#extents3d())
- [Extents3d(Point3d, Point3d)](#extents3d(point3d,-point3d))

### Methods

- [AddBlockExtents](#addblockextents)
- [AddExtents](#addextents)
- [AddPoint](#addpoint)
- [Equals](#equals)
- [ExpandBy](#expandby)
- [GetHashCode](#gethashcode)
- [IsEqualTo(Extents3d)](#isequalto(extents3d))
- [IsEqualTo(Extents3d, Tolerance)](#isequalto(extents3d,-tolerance))
- [Set](#set)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))
- [ToString(string, IFormatProvider)](#tostring(string,-iformatprovider))
- [TransformBy](#transformby)

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [MaxPoint](#maxpoint)
- [MinPoint](#minpoint)


## Constructors Details

### Extents3d()

#### Description
Default constructor.
```text
public Extents3d();
```

### Extents3d(Point3d, Point3d)

#### Description
This constructor creates a new 3D Extents using Point 3D values.
```text
public Extents3d(
    Point3d min, 
    Point3d max
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d min | Input minimum extent |
| Point3d max | Input maximum extent |

### AddBlockExtents

#### Description
Compute the minimum box that encloses all of the entities in the block pointed to by pointerToBlockTableRecord and the box already defined by this object.
```text
public void AddBlockExtents(
    BlockTableRecord pointerToBlockTableRecord
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| BlockTableRecord pointerToBlockTableRecord | Pointer to a block table record |

### AddExtents

#### Description
Expand the box defined by this object to also enclose the box defined by source.
```text
public void AddExtents(
    Extents3d source
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Extents3d source | Input another Extents3d object |

### AddPoint

#### Description
Expand this box to also enclose the point pt.
```text
public void AddPoint(
    Point3d pt
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d pt | Input 3D point |

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

### ExpandBy

#### Description
Expand this box by the amount in the vector. This could be used for objects with a constant thickness, for example. You would accumulate the basic box by iterating through the object's points calling AddPoint(), then you would make a single ExpandBy() call to expand that box by the thickness amount.
```text
public void ExpandBy(
    Vector3d vector
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vector3d vector | Input 3D vector |

### GetHashCode

#### Description
Returns the hash code for this object. See the Microsoft .NET API documentation for details.
```text
public sealed override int GetHashCode();
```

### IsEqualTo(Extents3d)

#### Description
This method returns a value indicating whether the minimum and maximum points of a are equivalent to those of this object. Tolerance is set to Global for this overload.
```text
public bool IsEqualTo(
    Extents3d a
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Extents3d a | Input object to compare |

### IsEqualTo(Extents3d, Tolerance)

#### Description
This method returns a value indicating whether the minimum and maximum points of a are equivalent, within the tolerance range specified by tolerance, to those of this object.
```text
public bool IsEqualTo(
    Extents3d a, 
    Tolerance tolerance
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Extents3d a | Input object to compare |
| Tolerance tolerance | Input tolerance to check against |

### Set

#### Description
Set MinPoint to min and MaxPoint to max if each of the _X_ , _Y_ , and _Z_ values of min are less than or equal to the corresponding values of max.
```text
public void Set(
    Point3d min, 
    Point3d max
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d min | Input minimum extent |
| Point3d max | Input maximum extent |

### ToString()

#### Description
Returns an equivalent string representation of this object. See the Microsoft .NET API documentation for details
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
| IFormatProvider provider | Input culture-specific format |

### TransformBy

#### Description
Transform the eight corners of the current box by this matrix and compute the box that encloses the current box and those points.
```text
public void TransformBy(
    Matrix3d mat
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Matrix3d mat | Input 3D transformation matrix |

### != Operator

#### Description
Returns true if a is not equivalent to b.
```text
public static bool operator !=(
    Extents3d a, 
    Extents3d b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Extents3d a | Left-hand operand |
| Extents3d b | Right-hand operand |

### == Operator

#### Description
Returns true if a is equivalent to b.
```text
public static bool operator ==(
    Extents3d a, 
    Extents3d b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Extents3d a | Left-hand operand |
| Extents3d b | Right-hand operand |

### MaxPoint

#### Description
Accesses the maximum point.
```text
public Point3d MaxPoint;
```

#### Conditions
Read-only
### MinPoint

#### Description
Accesses the miniimum point
```text
public Point3d MinPoint;
```

#### Conditions
Read-only