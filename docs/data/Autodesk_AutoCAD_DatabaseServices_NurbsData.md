# NurbsData Structure

## Overview

#### Description
Replaces any existing spline data with the data passed in via NurbsData parameters. 
If the spline is not periodic, the length of knot vector will be greater than length of the control array by degree+1. 
If the spline is periodic, the length of knot vector will be greater than length of the control array by 1.
```text
public struct NurbsData {
}
```

### Methods

- [Equals](#equals)
- [GetControlPoints](#getcontrolpoints)
- [GetHashCode](#gethashcode)
- [GetKnots](#getknots)
- [GetWeights](#getweights)
- [IsEqualTo(NurbsData)](#isequalto(nurbsdata))
- [IsEqualTo(NurbsData, Tolerance)](#isequalto(nurbsdata,-tolerance))

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [Closed](#closed)
- [ControlPointTolerance](#controlpointtolerance)
- [Degree](#degree)
- [KnotTolerance](#knottolerance)
- [Periodic](#periodic)
- [Rational](#rational)


## Methods Details

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
| object obj | Object to check against. |

### GetControlPoints

#### Description
Returns a collection of the Spline object's control points.
```text
public Point3dCollection GetControlPoints();
```

### GetHashCode

#### Description
Returns the hash code for this object. See the Microsoft .NET API documentation for details.
```text
public sealed override int GetHashCode();
```

### GetKnots

#### Description
Returns a collection of the Spline object's knot values.
```text
public DoubleCollection GetKnots();
```

### GetWeights

#### Description
Returns a collection of the Spline object's control point weights.
```text
public DoubleCollection GetWeights();
```

### IsEqualTo(NurbsData)

#### Description
Compares this object to other and returns true if they are equal.
```text
public bool IsEqualTo(
    NurbsData other
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| NurbsData other | Object to check against. |

### IsEqualTo(NurbsData, Tolerance)

#### Description
This method tests other against this object for equivalency within the tolerance range specified by tolerance.
```text
public bool IsEqualTo(
    NurbsData other, 
    Tolerance tolerance
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| NurbsData other | Object to check against. |
| Tolerance tolerance | Tolerance range |

### != Operator

#### Description
Returns true if a does not equal b.
```text
public static bool operator !=(
    NurbsData a, 
    NurbsData b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| NurbsData a | Left operand |
| NurbsData b | Right operand |

### == Operator

#### Description
Returns true if a equals b.
```text
public static bool operator ==(
    NurbsData a, 
    NurbsData b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| NurbsData a | Left operand |
| NurbsData b | Right operand |

### Closed

#### Description
Assesses if the spline is closed.
```text
public bool Closed;
```

#### Conditions
Read-only
### ControlPointTolerance

#### Description
Accesses the control points (in WCS coordinates) of the spline.
```text
public double ControlPointTolerance;
```

#### Conditions
Read-only
### Degree

#### Description
Accesses the degree of spline.
```text
public int Degree;
```

#### Conditions
Read-only
### KnotTolerance

#### Description
Accesses the knot value tolerance of spline
```text
public double KnotTolerance;
```

#### Conditions
Read-only
### Periodic

#### Description
Assesses if the spline is periodic. A periodic spline is a spline with period T such that the point at parameter t + T is equal to the point at parameter t for any value of t.
```text
public bool Periodic;
```

#### Conditions
Read-only
### Rational

#### Description
Assesses if the spline is rational.
```text
public bool Rational;
```

#### Conditions
Read-only