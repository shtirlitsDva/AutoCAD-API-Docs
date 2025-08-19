# AssocArrayCommonParameters Class

## Overview

#### Description
AssocArrayCommonParameters wraps the ObjectARX [AcDbAssocArrayCommonParameters](AcDbAssocArrayCommonParameters.md) class. 
This class provides an interface for manipulating array parameters that are common to Rectangular, Path and Polar Array. Its derived classes provide specific interfaces to manipulate array parameters that are unique each array type.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocArrayParameters
    Autodesk.AutoCAD.DatabaseServices.AssocArrayCommonParameters
        Autodesk.AutoCAD.DatabaseServices.AssocArrayPathParameters
        Autodesk.AutoCAD.DatabaseServices.AssocArrayPolarParameters
        Autodesk.AutoCAD.DatabaseServices.AssocArrayRectangularParameters
```

```text
public abstract class AssocArrayCommonParameters : AssocArrayParameters;
```

### Methods

- [GetLevelCount](#getlevelcount)
- [GetLevelSpacing](#getlevelspacing)
- [GetRowCount](#getrowcount)
- [GetRowElevation](#getrowelevation)
- [GetRowSpacing](#getrowspacing)
- [SetLevelCount](#setlevelcount)
- [SetLevelSpacing](#setlevelspacing)
- [SetRowCount](#setrowcount)
- [SetRowElevation](#setrowelevation)
- [SetRowSpacing](#setrowspacing)

### Properties

- [BaseNormal](#basenormal)
- [BasePlane](#baseplane)
- [BasePoint](#basepoint)
- [LevelCount](#levelcount)
- [LevelSpacing](#levelspacing)
- [RowCount](#rowcount)
- [RowElevation](#rowelevation)
- [RowSpacing](#rowspacing)


## Methods Details

### GetLevelCount

#### Description
This wraps the ObjectARX ObjectARX [AcDbAssocArrayCommonParameters::levelCount](AcDbAssocArrayCommonParameters__levelCount@AcString_@AcString_@const.md)() method.
```text
public int GetLevelCount(
    out string expression, 
    out string evaluatorId
);
```

### GetLevelSpacing

#### Description
This wraps the ObjectARX [AcDbAssocArrayCommonParameters::levelSpacing](AcDbAssocArrayCommonParameters__levelSpacing@AcString_@AcString_@const.md)() method.
```text
public double GetLevelSpacing(
    out string expression, 
    out string evaluatorId
);
```

### GetRowCount

#### Description
This wraps the ObjectARX [AcDbAssocArrayCommonParameters::rowCount](AcDbAssocArrayCommonParameters__rowCount@AcString_@AcString_@const.md)() method.
```text
public int GetRowCount(
    out string expression, 
    out string evaluatorId
);
```

### GetRowElevation

#### Description
This wraps the ObjectARX [AcDbAssocArrayCommonParameters::rowElevation](AcDbAssocArrayCommonParameters__rowElevation@AcString_@AcString_@const.md)() method.
```text
public double GetRowElevation(
    out string expression, 
    out string evaluatorId
);
```

### GetRowSpacing

#### Description
This wraps the ObjectARX [AcDbAssocArrayCommonParameters::rowSpacing](AcDbAssocArrayCommonParameters__rowSpacing@AcString_@AcString_@const.md)() method.
```text
public double GetRowSpacing(
    out string expression, 
    out string evaluatorId
);
```

### SetLevelCount

#### Description
This wraps the ObjectARX [AcDbAssocArrayCommonParameters::setLevelCount](AcDbAssocArrayCommonParameters__setLevelCount@int@AcString_@AcString_@AcString_.md)() method.
```text
public void SetLevelCount(
    int count, 
    string expression, 
    string evaluatorId
);
```

### SetLevelSpacing

#### Description
This wraps the ObjectARX [AcDbAssocArrayCommonParameters::setLevelSpacing](AcDbAssocArrayCommonParameters__setLevelSpacing@double@AcString_@AcString_@AcString_.md)() method.
```text
public void SetLevelSpacing(
    double spacing, 
    string expression, 
    string evaluatorId
);
```

### SetRowCount

#### Description
This wraps the ObjectARX [AcDbAssocArrayCommonParameters::setRowCount](AcDbAssocArrayCommonParameters__setRowCount@int@AcString_@AcString_@AcString_.md)() method.
```text
public void SetRowCount(
    int count, 
    string expression, 
    string evaluatorId
);
```

### SetRowElevation

#### Description
This wraps the ObjectARX [AcDbAssocArrayCommonParameters::setRowElevation](AcDbAssocArrayCommonParameters__setRowElevation@double@AcString_@AcString_@AcString_.md)() method.
```text
public void SetRowElevation(
    double value, 
    string expression, 
    string evaluatorId
);
```

### SetRowSpacing

#### Description
This wraps the ObjectARX [AcDbAssocArrayCommonParameters::setRowSpacing](AcDbAssocArrayCommonParameters__setRowSpacing@double@AcString_@AcString_@AcString_.md)() method.
```text
public void SetRowSpacing(
    double spacing, 
    string expression, 
    string evaluatorId
);
```

### BaseNormal

#### Description
Wraps the ObjectARX [AcDbAssocArrayCommonParameters::getBasePlane](AcDbAssocArrayCommonParameters__getBasePlane@AcDbVertexRef_@AcGeVector3d_@AcDbFaceRef_@const.md)() and [AcDbAssocArrayCommonParameters::setBasePlane](AcDbAssocArrayCommonParameters__setBasePlane@AcDbVertexRef_@AcGeVector3d_@AcDbFaceRef_.md)() methods.
```text
public Vector3d BaseNormal;
```

#### Conditions
Read / write
### BasePlane

#### Description
Wraps the ObjectARX [AcDbAssocArrayCommonParameters::getBasePlane](AcDbAssocArrayCommonParameters__getBasePlane@AcDbVertexRef_@AcGeVector3d_@AcDbFaceRef_@const.md)() and [AcDbAssocArrayCommonParameters::setBasePlane](AcDbAssocArrayCommonParameters__setBasePlane@AcDbVertexRef_@AcGeVector3d_@AcDbFaceRef_.md)() methods.
```text
public FaceRef BasePlane;
```

#### Conditions
Read / write
### BasePoint

#### Description
Wraps the ObjectARX [AcDbAssocArrayCommonParameters::getBasePlane](AcDbAssocArrayCommonParameters__getBasePlane@AcDbVertexRef_@AcGeVector3d_@AcDbFaceRef_@const.md)() and [AcDbAssocArrayCommonParameters::setBasePlane](AcDbAssocArrayCommonParameters__setBasePlane@AcDbVertexRef_@AcGeVector3d_@AcDbFaceRef_.md)() methods.
```text
public VertexRef BasePoint;
```

#### Conditions
Read / write
### LevelCount

#### Description
Wraps the ObjectARX [AcDbAssocArrayCommonParameters::levelCount](AcDbAssocArrayCommonParameters__levelCount@AcString_@AcString_@const.md)() and [AcDbAssocArrayCommonParameters::setLevelCount](AcDbAssocArrayCommonParameters__setLevelCount@int@AcString_@AcString_@AcString_.md)() methods.
```text
public int LevelCount;
```

#### Conditions
Read / write
### LevelSpacing

#### Description
Wraps the ObjectARX [AcDbAssocArrayCommonParameters::levelSpacing](AcDbAssocArrayCommonParameters__levelSpacing@AcString_@AcString_@const.md)() and [AcDbAssocArrayCommonParameters::setLevelSpacing](AcDbAssocArrayCommonParameters__setLevelSpacing@double@AcString_@AcString_@AcString_.md)() methods.
```text
public double LevelSpacing;
```

#### Conditions
Read / write
### RowCount

#### Description
Wraps the ObjectARX the ObjectARX [AcDbAssocArrayCommonParameters::rowCount](AcDbAssocArrayCommonParameters__rowCount@AcString_@AcString_@const.md)() and [AcDbAssocArrayCommonParameters::setRowCount](AcDbAssocArrayCommonParameters__setRowCount@int@AcString_@AcString_@AcString_.md)() methodS.
```text
public int RowCount;
```

#### Conditions
Read / write
### RowElevation

#### Description
Wraps the ObjectARX [AcDbAssocArrayCommonParameters::rowElevation](AcDbAssocArrayCommonParameters__rowElevation@AcString_@AcString_@const.md)() and [AcDbAssocArrayCommonParameters::setRowElevation](AcDbAssocArrayCommonParameters__setRowElevation@double@AcString_@AcString_@AcString_.md)() methods.
```text
public double RowElevation;
```

#### Conditions
Read / write
### RowSpacing

#### Description
Wraps the ObjectARX [AcDbAssocArrayCommonParameters::rowSpacing](AcDbAssocArrayCommonParameters__rowSpacing@AcString_@AcString_@const.md)() and [AcDbAssocArrayCommonParameters::setRowSpacing](AcDbAssocArrayCommonParameters__setRowSpacing@double@AcString_@AcString_@AcString_.md)() methods.
```text
public double RowSpacing;
```

#### Conditions
Read / write