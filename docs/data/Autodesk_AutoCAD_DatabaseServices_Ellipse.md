# Ellipse Class

## Overview

#### Description
This .NET class wraps the AcDbEllipse ObjectARX class. 
It represents the ELLIPSE entity in AutoCAD. It contains the methods to create, modify, and obtain properties of the ellipse.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Ellipse
```

```text
public class Ellipse : Curve;
```

#### See Also
[Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), [Point3d](Autodesk_AutoCAD_Geometry_Point3d.md), [Vector3d](Autodesk_AutoCAD_Geometry_Vector3d.md)

## Members

### Constructors

- [Ellipse()](#ellipse())
- [Ellipse(Point3d, Vector3d, Vector3d, double, double, double)](#ellipse(point3d,-vector3d,-vector3d,-double,-double,-double))

### Methods

- [GetAngleAtParameter](#getangleatparameter)
- [GetParameterAtAngle](#getparameteratangle)
- [Set](#set)

### Properties

- [Center](#center)
- [EndAngle](#endangle)
- [EndParam](#endparam)
- [IsNull](#isnull)
- [MajorAxis](#majoraxis)
- [MajorRadius](#majorradius)
- [MinorAxis](#minoraxis)
- [MinorRadius](#minorradius)
- [Normal](#normal)
- [RadiusRatio](#radiusratio)
- [StartAngle](#startangle)
- [StartParam](#startparam)


## Constructors Details

### Ellipse()

#### Description
Default constructor. Initializes to circle of radius 1 in XY plane with center (0,0,0).
```text
public Ellipse();
```

### Ellipse(Point3d, Vector3d, Vector3d, double, double, double)

#### Description
This constructor is used to create an Ellipse using the values passed in. The center, unitNormal and majorAxis are used to calculate the start point. The majorAxis vector represents half the major axis of the ellipse (that is, from the center point to the start point of the ellipse) and is the zero angle for startAngle and endAngle. Positive angles are counter-clockwise when looking down the normal vector (that is, right-hand rule). A startAngle of 0 and endAngle of 2pi will produce a closed Ellipse. 
radiusRatio must be in the range 1E-6 to 1.0. 
The dot product of unitNormal with itself and majorAxis with itself must be greater than 1E-12. 
majorAxis must perpendicular to normal within 1E-6. 
The difference between startAngle and endAngle must be greater than 1E-6. 
If any of the parameters are not acceptable, then the gelib object for the Ellipse will not be created and this constructor will behave like the default constructor (that is, the passed in values will not be used and the data query methods on the Ellipse will return invalid values). 
The isNull property can be used to determine if this constructor succeeded in initializing the Ellipse to the values passed in. If isNull is false, then the initialization succeeded.
```text
public Ellipse(
    Point3d center, 
    Vector3d unitNormal, 
    Vector3d majorAxis, 
    double radiusRatio, 
    double startAngle, 
    double endAngle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d center | Input center of the ellipse |
| Vector3d unitNormal | Input vector specifying normal, which determines the plane of the ellipse |
| Vector3d majorAxis | Input vector which represents 1/2 the major axis of the ellipse |
| double radiusRatio | Input ratio of the major radius to the minor radius |
| double startAngle | Input start angle of the ellipse in radians |
| double endAngle | Input end angle of the ellipse in radians |

### GetAngleAtParameter

#### Description
This function returns the first period equivalent of the angle at the value location on the ellipse. The returned angle will be in the range -pi to pi. 
The Ellipse's majorAxis vector is the zero angle. Positive angles are counter-clockwise when looking down the Ellipse's normal vector (that is, right-hand rule).
```text
public double GetAngleAtParameter(
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double value | Input parameter to evaluate |

### GetParameterAtAngle

#### Description
Returns the first period parameter value at angle (in radians). The parameter value is in the range 0 to 2pi. 
The ellipse's majorAxis vector is the zero angle for angle. Positive angles are counter-clockwise when looking down the ellipse's normal vector (that is, right-hand rule).
```text
public double GetParameterAtAngle(
    double angle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double angle | Input angle (in radians) at which the parameter is desired |

### Set

#### Description
This function sets the properties of the ellipse to the values specified in the arguments. 
center, unitNormal, and majorAxis are in WCS coordinates. startAngle and endAngle are in radians, in the range -pi to pi. Positive angles are counter-clockwise when looking down the normal vector (that is, right-hand rule). A closed Ellipse will have a startAngle of 0 and an endAngle of 2pi. 
radiusRatio must be in the range 1E-6 to 1.0. 
The dot product of normal with itself and majorAxis with itself must be greater than 1E-12. 
majorAxis must perpendicular to normal within 1E-6. 
The difference between startAngle and endAngle must be greater than 1E-6. 
If any of the parameters are not acceptable, then this method fails.
```text
public void Set(
    Point3d center, 
    Vector3d unitNormal, 
    Vector3d majorAxis, 
    double radiusRatio, 
    double startAngle, 
    double endAngle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d center | Input center point (in WCS coordinates) for the ellipse |
| Vector3d unitNormal | Input normal vector (in WCS coordinates) which defines the plane in which the ellipse lies |
| Vector3d majorAxis | Input major axis (in WCS coordinates) for the ellipse |
| double radiusRatio | Input desired ratio of the major radius to the minor radius |
| double startAngle | Input start angle (in radians) for the ellipse |
| double endAngle | Input end angle (in radians) for the ellipse |

### Center

#### Description
Accesses the center point of the ellipse.
```text
public Point3d Center;
```

#### Conditions
Read / Write
### EndAngle

#### Description
Accesses the end angle of the ellipse.
```text
public double EndAngle;
```

#### Conditions
Read / Write
### EndParam

#### Description
Accesses the end parameter of the ellipse.
```text
public double EndParam;
```

#### Conditions
Read / Write
### IsNull

#### Description
Assesses if this Ellipse has no gelib object within itself.
```text
public bool IsNull;
```

#### Conditions
Read-only
### MajorAxis

#### Description
Accesses the major axis of the ellipse.
```text
public Vector3d MajorAxis;
```

#### Conditions
Read-only
### MajorRadius

#### Description
Returns the major radius of the ellipse.
```text
public double MajorRadius;
```

#### Conditions
Read-only
### MinorAxis

#### Description
Accesses the major radius of the ellipse.
```text
public Vector3d MinorAxis;
```

#### Conditions
Read-only
### MinorRadius

#### Description
Returns the minor radius of the ellipse.
```text
public double MinorRadius;
```

#### Conditions
Read-only
### Normal

#### Description
Accesses the vector normal to this ellipse.
```text
public Vector3d Normal;
```

#### Conditions
Read-only
### RadiusRatio

#### Description
Accesses the ratio of the major to minor radius for the ellipse. The value will be in the range 1e-6 to 1.0.
```text
public double RadiusRatio;
```

#### Conditions
Read / Write
### StartAngle

#### Description
Accesses the first period equivalent of the start angle (in radians) of the ellipse. The angle will be in the range -pi to pi. 
The ellipse's majorAxis vector is the zero angle for startAngle and endAngle. Positive angles are counter-clockwise when looking down the normal vector (that is, right-hand rule).
```text
public double StartAngle;
```

#### Conditions
Read / Write
### StartParam

#### Description
Accesses the new start parameter
```text
public double StartParam;
```

#### Conditions
Read / Write