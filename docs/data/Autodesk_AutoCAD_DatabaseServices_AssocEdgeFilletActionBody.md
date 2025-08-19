# AssocEdgeFilletActionBody Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocEdgeFilletActionBody](AcDbAssocEdgeFilletActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocEdgeFilletActionBody
```

```text
public class AssocEdgeFilletActionBody : AssocSurfaceActionBody;
```

### Constructors

- [AssocEdgeFilletActionBody](#assocedgefilletactionbody)

### Methods

- [CreateInstance](#createinstance)
- [GetRadius](#getradius)
- [SetRadius](#setradius)

### Properties

- [Radius](#radius)


## Constructors Details

### AssocEdgeFilletActionBody

#### Description
This wraps the ObjectARX [AcDbAssocEdgeFilletActionBody::AcDbAssocEdgeFilletActionBody](AcDbAssocEdgeFilletActionBody__AcDbAssocEdgeFilletActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocEdgeFilletActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX [AcDbAssocEdgeFilletActionBody::createInstance](AcDbAssocEdgeFilletActionBody__createInstance@AcDbFullSubentPathArray_@double@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    FullSubentityPath\[\] filletEdges, 
    double radius, 
    [MarshalAs(UnmanagedType.U1)] bool enable
);
```

### GetRadius

#### Description
This wraps the ObjectARX [AcDbAssocEdgeFilletActionBody::radius](AcDbAssocEdgeFilletActionBody__radius@AcString_@AcString_@const.md)() method.
```text
public double GetRadius(
    out string expression, 
    out string evaluatorId
);
```

### SetRadius

#### Description
This wraps the ObjectARX [AcDbAssocEdgeFilletActionBody::setRadius](AcDbAssocEdgeFilletActionBody__setRadius@double@AcString_@AcString_.md)() method.
```text
public void SetRadius(
    double radius, 
    string expression, 
    string evaluatorId
);
```

### Radius

#### Description
This wraps the ObjectARX [AcDbAssocEdgeFilletActionBody::radius](AcDbAssocEdgeFilletActionBody__radius@AcString_@AcString_@const.md)() and [AcDbAssocEdgeFilletActionBody::setRadius](AcDbAssocEdgeFilletActionBody__setRadius@double@AcString_@AcString_.md)() methods.
```text
public double Radius;
```
