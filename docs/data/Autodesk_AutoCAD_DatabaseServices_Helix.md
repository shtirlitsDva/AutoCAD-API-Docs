# Helix Class

## Overview

#### Description
This .NET class wraps the AcDbHelix ObjectARX class. 
This class implements the AutoCAD helix entity. Helix derives from Spline, but overrides the spline properties with its own behavior. Objects of the Helix class contain an embedded Spline which is wrapped by the Helix in order to constrain its behavior so that its basic shape is maintained. The behavior of calling NURB functions on the Helix class is unknown and not recommended.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Spline
                Autodesk.AutoCAD.DatabaseServices.Helix
```

```text
public class Helix : Spline;
```

#### Notes
When setting the constraints on a helix object, the order in which the set functions are called is important. Refer to ConstrainType for a detailed explanation.
### Constructors

- [Helix](#helix)

### Methods

- [CreateHelix](#createhelix)
- [GetAxisPoint](#getaxispoint)
- [SetAxisPoint](#setaxispoint)

### Properties

- [AxisVector](#axisvector)
- [BaseRadius](#baseradius)
- [Constrain](#constrain)
- [Height](#height)
- [StartPoint](#startpoint)
- [TopRadius](#topradius)
- [TotalLength](#totallength)
- [TurnHeight](#turnheight)
- [Turns](#turns)
- [TurnSlope](#turnslope)
- [Twist](#twist)


## Constructors Details

### Helix

#### Description
Default constructor.
```text
public Helix();
```

### CreateHelix

#### Description
This functions creates the helix geometry based on the values set in prior function calls. Without calling this function, no geometry will be visible on the screen.
```text
public void CreateHelix();
```

### GetAxisPoint

#### Description
Returns the start point of the axis for the helix.
```text
public Point3d GetAxisPoint();
```

### SetAxisPoint

#### Description
Sets the start point of the axis for the helix.
```text
public void SetAxisPoint(
    Point3d axisPoint, 
    [MarshalAs(UnmanagedType.U1)] bool moveStartPoint
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d axisPoint | Input the 3D point where the axis starts |
| [MarshalAs(UnmanagedType.U1)] bool moveStartPoint | Input Boolean indicating whether to relocate the start point by the same offset that the axis point moved |

### AxisVector

#### Description
Accesses the vector for the axis of the helix. The vector is always perpendicular to the line joining the start point and the axis point.
```text
public Vector3d AxisVector;
```

#### Conditions
Read / Write
### BaseRadius

#### Description
Accesses the base radius of the helix. This is always the distance between the start point and the axis point.
```text
public double BaseRadius;
```

#### Conditions
Read / Write
### Constrain

#### Description
Accesses the constrain property of the helix.
```text
public Autodesk.AutoCAD.DatabaseServices.ConstrainType Constrain;
```

#### Conditions
Read / Write
### Height

#### Description
Accesses the height of the helix.
```text
public double Height;
```

#### Conditions
Read / Write
### StartPoint

#### Description
Accesses the start point of the helix.
```text
public override Point3d StartPoint;
```

#### Conditions
Read / Write
### TopRadius

#### Description
Accesses the top radius of the helix.
```text
public double TopRadius;
```

#### Conditions
Read / Write
### TotalLength

#### Description
Accesses the total length of the helix.
```text
public double TotalLength;
```

#### Conditions
Read-only
### TurnHeight

#### Description
Accesses the turn height (distance between turns).
```text
public double TurnHeight;
```

#### Conditions
Read / Write
### Turns

#### Description
Accesses the number of turns (revolutions).
```text
public double Turns;
```

#### Conditions
Read / Write
### TurnSlope

#### Description
Accesses the turn slope angle of the helix.
```text
public double TurnSlope;
```

#### Conditions
Read-only
### Twist

#### Description
Accesses the twist of the helix.
```text
public bool Twist;
```

#### Conditions
Read / Write