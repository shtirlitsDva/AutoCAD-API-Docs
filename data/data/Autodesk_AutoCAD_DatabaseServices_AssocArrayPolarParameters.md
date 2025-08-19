# AssocArrayPolarParameters Class

## Overview

#### Description
AssocArrayPolarParameters wraps the ObjectARX [AcDbAssocArrayPolarParameters](AcDbAssocArrayPolarParameters.md) class. 
This class provides an interface for manipulating polar array parameters.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocArrayParameters
    Autodesk.AutoCAD.DatabaseServices.AssocArrayCommonParameters
        Autodesk.AutoCAD.DatabaseServices.AssocArrayPolarParameters
```

```text
public class AssocArrayPolarParameters : AssocArrayCommonParameters;
```

### Constructors

- [AssocArrayPolarParameters()](#assocarraypolarparameters())
- [AssocArrayPolarParameters(double, double, double, int, int, int, double)](#assocarraypolarparameters(double,-double,-double,-int,-int,-int,-double))

### Methods

- [GetAngleBetweenItems](#getanglebetweenitems)
- [GetFillAngle](#getfillangle)
- [GetItemCount](#getitemcount)
- [GetRadius](#getradius)
- [GetStartAngle](#getstartangle)
- [SetAngleBetweenItems](#setanglebetweenitems)
- [SetFillAngle](#setfillangle)
- [SetItemCount](#setitemcount)
- [SetRadius](#setradius)
- [SetStartAngle](#setstartangle)

### Other

- [AutoCAD.DatabaseServices.AssocArrayPolarParameters.ArcDirection Enumeration](#autocad.databaseservices.assocarraypolarparameters.arcdirection-enumeration)

### Properties

- [AngleBetweenItems](#anglebetweenitems)
- [Direction](#direction)
- [FillAngle](#fillangle)
- [ItemCount](#itemcount)
- [Radius](#radius)
- [RotateItems](#rotateitems)
- [StartAngle](#startangle)


## Constructors Details

### AssocArrayPolarParameters()

#### Description
Default constructor. 
Wraps the default constructor [AcDbAssocArrayPolarParameters](AcDbAssocArrayPolarParameters__AcDbAssocArrayPolarParameters@double@double@double@int@int@int@double.md) constructor, with all default values.
```text
public AssocArrayPolarParameters();
protected internal AssocArrayPolarParameters(
    IntPtr unmanagedPointer, 
    [MarshalAs(UnmanagedType.U1)] bool autoDelete
);
```

### AssocArrayPolarParameters(double, double, double, int, int, int, double)

#### Description
Parameterized constructor. The angle, which stands for angle between, is measured in degrees.
```text
public AssocArrayPolarParameters(
    double angle, 
    double rowSpacing, 
    double levelSpacing, 
    int itemCount, 
    int rowCount, 
    int levelCount, 
    double rowElevation
);
```

### GetAngleBetweenItems

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::angleBetweenItems](AcDbAssocArrayPolarParameters__angleBetweenItems@AcString_@AcString_@const.md)() method. 
The angle is measured in degrees.
```text
public double GetAngleBetweenItems(
    out string expression, 
    out string evaluatorId
);
```

### GetFillAngle

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::fillAngle](AcDbAssocArrayPolarParameters__fillAngle@AcString_@AcString_@const.md)() method. 
The angle is measured in degrees.
```text
public double GetFillAngle(
    out string expression, 
    out string evaluatorId
);
```

### GetItemCount

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::itemCount](AcDbAssocArrayPolarParameters__itemCount@AcString_@AcString_@const.md)() method.
```text
public int GetItemCount(
    out string expression, 
    out string evaluatorId
);
```

### GetRadius

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::radius](AcDbAssocArrayPolarParameters__radius@AcString_@AcString_@const.md)() method.
```text
public double GetRadius(
    out string expression, 
    out string evaluatorId
);
```

### GetStartAngle

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::startAngle](AcDbAssocArrayPolarParameters__startAngle@AcString_@AcString_@const.md)() method. 
The angle is measured in degrees.
```text
public double GetStartAngle(
    out string expression, 
    out string evaluatorId
);
```

### SetAngleBetweenItems

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::setAngleBetweenItems](AcDbAssocArrayPolarParameters__setAngleBetweenItems@double@AcString_@AcString_@AcString_.md)() method. 
The angle is measured in degrees.
```text
public void SetAngleBetweenItems(
    double val, 
    string expression, 
    string evaluatorId
);
```

### SetFillAngle

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::setFillAngle](AcDbAssocArrayPolarParameters__setFillAngle@double@AcString_@AcString_@AcString_.md)() method. 
The angle is measured in degrees.
```text
public void SetFillAngle(
    double val, 
    string expression, 
    string evaluatorId
);
```

### SetItemCount

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::setItemCount](AcDbAssocArrayPolarParameters__setItemCount@int@AcString_@AcString_@AcString_.md)() method.
```text
public void SetItemCount(
    int count, 
    string expression, 
    string evaluatorId
);
```

### SetRadius

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::setRadius](AcDbAssocArrayPolarParameters__setRadius@double@AcString_@AcString_@AcString_.md)() method.
```text
public void SetRadius(
    double val, 
    string expression, 
    string evaluatorId
);
```

### SetStartAngle

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::setStartAngle](AcDbAssocArrayPolarParameters__setStartAngle@double@AcString_@AcString_@AcString_.md)() method. 
The angle is measured in degrees.
```text
public void SetStartAngle(
    double val, 
    string expression, 
    string evaluatorId
);
```

### AutoCAD.DatabaseServices.AssocArrayPolarParameters.ArcDirection Enumeration

#### Description
Specifies the direction of the arc which the array items depend on.
```text
public enum ArcDirection {
  Clockwise,
  CounterClockwise
}
```

#### Members
| Members | Description |
| --- | --- |
| Clockwise | Clockwise direction of the arc. |
| CounterClockwise | Counterclockwise direction of the arc. |


## Properties Details

### AngleBetweenItems

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::angleBetweenItems](AcDbAssocArrayPolarParameters__angleBetweenItems@AcString_@AcString_@const.md)() and [AcDbAssocArrayPolarParameters::setAngleBetweenItems](AcDbAssocArrayPolarParameters__setAngleBetweenItems@double@AcString_@AcString_@AcString_.md)() methods. 
The angle is measured in degrees.
```text
public double AngleBetweenItems;
```

#### Conditions
Read / write
### Direction

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::direction](AcDbAssocArrayPolarParameters__direction@const.md)() and [AcDbAssocArrayPolarParameters::setDirection](AcDbAssocArrayPolarParameters__setDirection@Direction.md)() methods.
```text
public ArcDirection Direction;
```

#### Conditions
Read / write
### FillAngle

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::fillAngle](AcDbAssocArrayPolarParameters__fillAngle@AcString_@AcString_@const.md)() and [AcDbAssocArrayPolarParameters::setFillAngle](AcDbAssocArrayPolarParameters__setFillAngle@double@AcString_@AcString_@AcString_.md)() methods. 
The angle is measured in degrees.
```text
public double FillAngle;
```

#### Conditions
Read / write
### ItemCount

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::itemCount](AcDbAssocArrayPolarParameters__itemCount@AcString_@AcString_@const.md)() and [AcDbAssocArrayPolarParameters::setItemCount](AcDbAssocArrayPolarParameters__setItemCount@int@AcString_@AcString_@AcString_.md)() methods.
```text
public int ItemCount;
```

#### Conditions
Read / write
### Radius

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::radius](AcDbAssocArrayPolarParameters__radius@AcString_@AcString_@const.md)() and [AcDbAssocArrayPolarParameters::setRadius](AcDbAssocArrayPolarParameters__setRadius@double@AcString_@AcString_@AcString_.md)() methods.
```text
public double Radius;
```

#### Conditions
Read / write
### RotateItems

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::rotateItems](AcDbAssocArrayPolarParameters__rotateItems@const.md)() and [AcDbAssocArrayPolarParameters::setRotateItems](AcDbAssocArrayPolarParameters__setRotateItems@bool.md)() methods.
```text
public bool RotateItems;
```

#### Conditions
Read / write
### StartAngle

#### Description
Wraps the ObjectARX [AcDbAssocArrayPolarParameters::startAngle](AcDbAssocArrayPolarParameters__startAngle@AcString_@AcString_@const.md)() and [AcDbAssocArrayPolarParameters::setStartAngle](AcDbAssocArrayPolarParameters__setStartAngle@double@AcString_@AcString_@AcString_.md)() methods. 
The angle is measured in degrees.
```text
public double StartAngle;
```

#### Conditions
Read / write