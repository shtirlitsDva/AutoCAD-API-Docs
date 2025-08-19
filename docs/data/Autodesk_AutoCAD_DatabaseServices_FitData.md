# FitData Structure

## Overview

#### Description
This class encapsulates the data returned by the Spline.getFitData() ObjectARX function. 
If the spline has fit data, then this struct contains all the fit points (in WCS coordinates), fit tolerance, and, if tangents exist, the start and end tangents of the spline. The data is returned via the properties FitPoints, FitTolerance, StartTangent, and EndTangent respectively.
### Methods

- [Equals](#equals)
- [GetFitPoints](#getfitpoints)
- [GetHashCode](#gethashcode)
- [IsEqualTo(FitData)](#isequalto(fitdata))
- [IsEqualTo(FitData, Tolerance)](#isequalto(fitdata,-tolerance))

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [Degree](#degree)
- [EndTangent](#endtangent)
- [FitTolerance](#fittolerance)
- [StartTangent](#starttangent)
- [TangentsExist](#tangentsexist)


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
| object obj | Object to compare with |

### GetFitPoints

#### Description
Returns the fit points of the spline, in WCS coordinates.
```text
public Point3dCollection GetFitPoints();
```

### GetHashCode

#### Description
Returns the hash code for this object. See the Microsoft .NET API documentation for details.
```text
public sealed override int GetHashCode();
```

### IsEqualTo(FitData)

#### Description
Compares this object to other and returns true if they are equal.
```text
public bool IsEqualTo(
    FitData other
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FitData other | Object to compare with |

### IsEqualTo(FitData, Tolerance)

#### Description
This method tests other against this object for equivalency within the tolerance range specified by tolerance.
```text
public bool IsEqualTo(
    FitData other, 
    Tolerance tolerance
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FitData other | Object to compare with |
| Tolerance tolerance | Tolerance range |

### != Operator

#### Description
Returns true if a is not equal to b
```text
public static bool operator !=(
    FitData a, 
    FitData b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FitData a | Left operand |
| FitData b | Right operand |

### == Operator

#### Description
Returns true if a is equal to b
```text
public static bool operator ==(
    FitData a, 
    FitData b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FitData a | Left operand |
| FitData b | Right operand |

### Degree

#### Description
Accesses the degree of spline.
```text
public int Degree;
```

#### Conditions
Read-only
### EndTangent

#### Description
Accesses the end tangent of spline.
```text
public Vector3d EndTangent;
```

#### Conditions
Read-only
### FitTolerance

#### Description
Accesses the fit tolerance of spline
```text
public double FitTolerance;
```

#### Conditions
Read-only
### StartTangent

#### Description
Accesses the start tangent of spline
```text
public Vector3d StartTangent;
```

#### Conditions
Read-only
### TangentsExist

#### Description
Assesses whether or not specific tangents exist at the endpoints.
```text
public bool TangentsExist;
```

#### Conditions
Read-only