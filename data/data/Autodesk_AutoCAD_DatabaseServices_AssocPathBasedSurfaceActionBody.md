# AssocPathBasedSurfaceActionBody Class

## Overview

#### Description
This wraps [AcDbAssocPathBasedSurfaceActionBody](AcDbAssocPathBasedSurfaceActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocBlendSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocEdgeChamferActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocExtendSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocExtrudedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocLoftedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocNetworkSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocPatchSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocPlaneSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocRevolvedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocSweptSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocTrimSurfaceActionBody
```

```text
public class AssocPathBasedSurfaceActionBody : AssocSurfaceActionBody;
```

### Constructors

- [AssocPathBasedSurfaceActionBody](#assocpathbasedsurfaceactionbody)

### Methods

- [GetInputPaths](#getinputpaths)
- [GetInputPoints](#getinputpoints)
- [MakeInputPathsDrawOnTopOfResultingSurface](#makeinputpathsdrawontopofresultingsurface)
- [RemoveAllPathParams](#removeallpathparams)
- [SetInputPaths(EdgeRef[])](#setinputpaths(edgeref[]))
- [SetInputPaths(PathRef[])](#setinputpaths(pathref[]))
- [SetInputPoints](#setinputpoints)
- [UpdateInputPath](#updateinputpath)

### Properties

- [InputPathParams](#inputpathparams)


## Constructors Details

### AssocPathBasedSurfaceActionBody

#### Description
This wraps the ObjectARX [AcDbAssocPathBasedSurfaceActionBody::AcDbAssocPathBasedSurfaceActionBody](AcDbAssocPathBasedSurfaceActionBody__AcDbAssocPathBasedSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocPathBasedSurfaceActionBody();
```

### GetInputPaths

#### Description
This wraps the ObjectARX [AcDbAssocPathBasedSurfaceActionBody::getInputPaths](AcDbAssocPathBasedSurfaceActionBody__getInputPaths@AcArray_AcArray_AcArray_AcDbEdgeRef______@const.md)() method.
```text
public void GetInputPaths(
    out EdgeRef\[\] paths
);
```

### GetInputPoints

#### Description
This wraps the ObjectARX [AcDbAssocPathBasedSurfaceActionBody::getInputPoints](AcDbAssocPathBasedSurfaceActionBody__getInputPoints@AcArray_AcDbVertexRef__@const.md)() method.
```text
public VertexRef\[\] GetInputPoints();
```

### MakeInputPathsDrawOnTopOfResultingSurface

#### Description
This wraps the ObjectARX [AcDbAssocPathBasedSurfaceActionBody::makeInputPathsDrawOnTopOfResultingSurface](AcDbAssocPathBasedSurfaceActionBody__makeInputPathsDrawOnTopOfResultingSurface@const.md)() method.
```text
public void MakeInputPathsDrawOnTopOfResultingSurface();
```

### RemoveAllPathParams

#### Description
This wraps the ObjectARX [AcDbAssocPathBasedSurfaceActionBody::removeAllPathParams](AcDbAssocPathBasedSurfaceActionBody__removeAllPathParams.md)() method.
```text
public void RemoveAllPathParams();
```

### SetInputPaths(EdgeRef[])

#### Description
This wraps the ObjectARX[AcDbAssocPathBasedSurfaceActionBody::setInputPaths](AcDbAssocPathBasedSurfaceActionBody__setInputPaths@AcArray_AcArray_AcDbEdgeRef____.md)() method.
```text
public void SetInputPaths(
    EdgeRef\[\] edges
);
```

### SetInputPaths(PathRef[])

#### Description
This wraps the ObjectARX [AcDbAssocPathBasedSurfaceActionBody::setInputPaths](AcDbAssocPathBasedSurfaceActionBody__setInputPaths@AcArray_AcDbPathRef__.md)() method.
```text
public void SetInputPaths(
    PathRef\[\] paths
);
```

### SetInputPoints

#### Description
This wraps the ObjectARX [AcDbAssocPathBasedSurfaceActionBody::setInputPoints](AcDbAssocPathBasedSurfaceActionBody__setInputPoints@AcArray_AcDbVertexRef__.md)() method.
```text
public void SetInputPoints(
    VertexRef\[\] points
);
```

### UpdateInputPath

#### Description
This wraps the ObjectARX [AcDbAssocPathBasedSurfaceActionBody::updateInputPath](AcDbAssocPathBasedSurfaceActionBody__updateInputPath@int@AcDbPathRef_.md)() method.
```text
public void UpdateInputPath(
    int index, 
    PathRef pathRef
);
```

### InputPathParams

#### Description
This wraps the ObjectARX [AcDbAssocPathBasedSurfaceActionBody::getInputPathParams](AcDbAssocPathBasedSurfaceActionBody__getInputPathParams@AcDbObjectIdArray_@const.md)() method.
```text
public ObjectIdCollection InputPathParams;
```
