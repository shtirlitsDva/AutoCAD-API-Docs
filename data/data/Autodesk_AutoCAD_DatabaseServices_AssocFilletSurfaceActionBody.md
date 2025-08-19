# AssocFilletSurfaceActionBody Class

## Overview

#### Description
This wraps the ObjectARX AcDbAssocFilletSurfaceActionBody class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocFilletSurfaceActionBody
```

```text
public class AssocFilletSurfaceActionBody : AssocSurfaceActionBody;
```

### Constructors

- [AssocFilletSurfaceActionBody](#assocfilletsurfaceactionbody)

### Methods

- [CreateInstance](#createinstance)
- [GetFilletHandleData](#getfillethandledata)
- [GetHintPoints](#gethintpoints)
- [GetRadius](#getradius)
- [SetHintPoints](#sethintpoints)
- [SetRadius](#setradius)

### Properties

- [Radius](#radius)
- [TrimMode](#trimmode)


## Constructors Details

### AssocFilletSurfaceActionBody

#### Description
This wraps the ObjectARX AcDbAssocFilletSurfaceActionBody::AcDbAssocFilletSurfaceActionBody() method.
```text
public AssocFilletSurfaceActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX AcDbAssocFilletSurfaceActionBody::createInstance( ) method.
```text
public static ObjectId CreateInstance(
    ObjectId resultingSurfaceId, 
    ObjectId inputSurfaceId1, 
    Point3d pickPt1, 
    ObjectId inputSurfaceId2, 
    Point3d pickPt2, 
    double radius, 
    Autodesk.AutoCAD.DatabaseServices.FilletTrimMode trimMode, 
    Vector3d viewDir, 
    [MarshalAs(UnmanagedType.U1)] bool bEnable
);
```

### GetFilletHandleData

#### Description
This wraps the ObjectARX AcDbAssocFilletSurfaceActionBody::getFilletHandleData() method.
```text
public void GetFilletHandleData(
    out Point3d pt, 
    out Vector3d dir, 
    out Point3d cenPt, 
    out Vector3d normal
);
```

### GetHintPoints

#### Description
This wraps the ObjectARX AcDbAssocFilletSurfaceActionBody::getHintPoints() method.
```text
public Point3d\[\] GetHintPoints();
```

### GetRadius

#### Description
This wraps the ObjectARX AcDbAssocFilletSurfaceActionBody::radius() method.
```text
public double GetRadius(
    out string expression, 
    out string evaluatorId
);
```

### SetHintPoints

#### Description
This wraps the ObjectARX AcDbAssocFilletSurfaceActionBody::setHintPoints() method.
```text
public void SetHintPoints(
    Point3d\[\] hintPoints, 
    Vector3d viewDir
);
```

### SetRadius

#### Description
This wraps the ObjectARX AcDbAssocFilletSurfaceActionBody::setRadius() method.
```text
public void SetRadius(
    double radius, 
    string expression, 
    string evaluatorId
);
```

### Radius

#### Description
This wraps the ObjectARX AcDbAssocFilletSurfaceActionBody::radius() and AcDbAssocFilletSurfaceActionBody::setRadius() methods.
```text
public double Radius;
```

### TrimMode

#### Description
This wraps the ObjectARX AcDbAssocFilletSurfaceActionBody::setTrimMode() and AcDbAssocFilletSurfaceActionBody::trimMode() methods.
```text
public Autodesk.AutoCAD.DatabaseServices.FilletTrimMode TrimMode;
```
