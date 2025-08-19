# AssocArrayRectangularParameters Class

## Overview

#### Description
AssocArrayRectangularParameters wraps the ObjectARX [AcDbAssocArrayRectangularParameters](AcDbAssocArrayRectangularParameters.md) class. 
This class provides an interface for manipulating rectangular array parameters.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocArrayParameters
    Autodesk.AutoCAD.DatabaseServices.AssocArrayCommonParameters
        Autodesk.AutoCAD.DatabaseServices.AssocArrayRectangularParameters
```

```text
public class AssocArrayRectangularParameters : AssocArrayCommonParameters;
```

### Constructors

- [AssocArrayRectangularParameters()](#assocarrayrectangularparameters())
- [AssocArrayRectangularParameters(double, double, double, int, int, int, double, double)](#assocarrayrectangularparameters(double,-double,-double,-int,-int,-int,-double,-double))

### Methods

- [GetAxesAngle](#getaxesangle)
- [GetColumnCount](#getcolumncount)
- [GetColumnSpacing](#getcolumnspacing)
- [SetAxesAngle](#setaxesangle)
- [SetColumnCount](#setcolumncount)
- [SetColumnSpacing](#setcolumnspacing)

### Properties

- [AxesAngle](#axesangle)
- [ColumnCount](#columncount)
- [ColumnSpacing](#columnspacing)
- [XAxisDirection](#xaxisdirection)
- [YAxisDirection](#yaxisdirection)


## Constructors Details

### AssocArrayRectangularParameters()

#### Description
Default constructor. 
Wraps the default [AcDbAssocArrayRectangularParameters](AcDbAssocArrayRectangularParameters__AcDbAssocArrayRectangularParameters@double@double@double@int@int@int@double@double.md) constructor, with all default values.
```text
public AssocArrayRectangularParameters();
```

### AssocArrayRectangularParameters(double, double, double, int, int, int, double, double)

#### Description
Parameterized constructor. The _axesAngle_ and _rotation_ parameters are in degrees.
```text
public AssocArrayRectangularParameters(
    double columnSpacing, 
    double rowSpacing, 
    double levelSpacing, 
    int columnCount, 
    int rowCount, 
    int levelCount, 
    double rowElevation, 
    double axesAngle
);
```

### GetAxesAngle

#### Description
Wraps the ObjectARX [AcDbAssocArrayRectangularParameters::axesAngle](AcDbAssocArrayRectangularParameters__axesAngle@AcString_@AcString_@const.md)() method. 
The angle is measured in degrees.
```text
public double GetAxesAngle(
    out string expression, 
    out string evaluatorId
);
```

### GetColumnCount

#### Description
Wraps the ObjectARX [AcDbAssocArrayRectangularParameters::columnCount](AcDbAssocArrayRectangularParameters__columnCount@AcString_@AcString_@const.md)() method.
```text
public int GetColumnCount(
    out string expression, 
    out string evaluatorId
);
```

### GetColumnSpacing

#### Description
Wraps the ObjectARX [AcDbAssocArrayRectangularParameters::columnSpacing](AcDbAssocArrayRectangularParameters__columnSpacing@AcString_@AcString_@const.md)() method.
```text
public double GetColumnSpacing(
    out string expression, 
    out string evaluatorId
);
```

### SetAxesAngle

#### Description
Wraps the ObjectARX [AcDbAssocArrayRectangularParameters::setAxesAngle](AcDbAssocArrayRectangularParameters__setAxesAngle@double@AcString_@AcString_@AcString_.md)() method. 
The axesAngle being set is measured in degrees.
```text
public void SetAxesAngle(
    double val, 
    string expression, 
    string evaluatorId
);
```

### SetColumnCount

#### Description
Wraps the ObjectARX [AcDbAssocArrayRectangularParameters::setColumnCount](AcDbAssocArrayRectangularParameters__setColumnCount@int@AcString_@AcString_@AcString_.md)() method.
```text
public void SetColumnCount(
    int count, 
    string expression, 
    string evaluatorId
);
```

### SetColumnSpacing

#### Description
Wraps the ObjectARX [AcDbAssocArrayRectangularParameters::setColumnSpacing](AcDbAssocArrayRectangularParameters__setColumnSpacing@double@AcString_@AcString_@AcString_.md)() method.
```text
public void SetColumnSpacing(
    double spacing, 
    string expression, 
    string evaluatorId
);
```

### AxesAngle

#### Description
Wraps the ObjectARX [AcDbAssocArrayRectangularParameters::axesAngle](AcDbAssocArrayRectangularParameters__axesAngle@AcString_@AcString_@const.md)() and [AcDbAssocArrayRectangularParameters::setAxesAngle](AcDbAssocArrayRectangularParameters__setAxesAngle@double@AcString_@AcString_@AcString_.md)() methods. 
The axesAngle being set is measured in degrees.
```text
public double AxesAngle;
```

#### Conditions
Read / write
### ColumnCount

#### Description
Wraps the ObjectARX [AcDbAssocArrayRectangularParameters::columnCount](AcDbAssocArrayRectangularParameters__columnCount@AcString_@AcString_@const.md)() and [AcDbAssocArrayRectangularParameters::setColumnCount](AcDbAssocArrayRectangularParameters__setColumnCount@int@AcString_@AcString_@AcString_.md)() methods.
```text
public int ColumnCount;
```

#### Conditions
Read / write
### ColumnSpacing

#### Description
Wraps the ObjectARX [AcDbAssocArrayRectangularParameters::columnSpacing](AcDbAssocArrayRectangularParameters__columnSpacing@AcString_@AcString_@const.md)() and [AcDbAssocArrayRectangularParameters::setColumnSpacing](AcDbAssocArrayRectangularParameters__setColumnSpacing@double@AcString_@AcString_@AcString_.md)() methods.
```text
public double ColumnSpacing;
```

#### Conditions
Read / write
### XAxisDirection

#### Description
Wraps the ObjectARX [AcDbAssocArrayRectangularParameters::axisDirection](AcDbAssocArrayRectangularParameters__axisDirection@AcGeVector3d_@const.md)() and [AcDbAssocArrayRectangularParameters::setAxisDirection](AcDbAssocArrayRectangularParameters__setAxisDirection@AcGeVector3d_.md)() methods.
```text
public Vector3d XAxisDirection;
```

#### Conditions
Read / write
### YAxisDirection

#### Description
Wraps the ObjectARX [AcDbAssocArrayRectangularParameters::axisDirection](AcDbAssocArrayRectangularParameters__axisDirection@AcGeVector3d_@const.md)() and [AcDbAssocArrayRectangularParameters::setAxisDirection](AcDbAssocArrayRectangularParameters__setAxisDirection@AcGeVector3d_.md)() methods. 
This property updates the axes angle between the x axis and y axis. It is not allowed that the x axis and y axis are parallel. Moreover, if the normal vector of the plane formed by the x axis and y axis changes, the normal will also be updated.
```text
public Vector3d YAxisDirection;
```

#### Conditions
Read / write