# AssocSurfaceActionBody Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocSurfaceActionBody](AcDbAssocSurfaceActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocEdgeFilletActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocFilletSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocOffsetSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
```

```text
public class AssocSurfaceActionBody : AssocParamBasedActionBody;
```

### Constructors

- [AssocSurfaceActionBody](#assocsurfaceactionbody)

### Methods

- [EvaluateOverride](#evaluateoverride)
- [FindActionsThatAffectedTopologicalSubentity](#findactionsthataffectedtopologicalsubentity)
- [ResultingSurfaceDep([MarshalAs(UnmanagedType.U1)] bool)](#resultingsurfacedep([marshalas(unmanagedtype.u1)]-bool))
- [ResultingSurfaceDep([MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#resultingsurfacedep([marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [SetResultingSurface](#setresultingsurface)

### Properties

- [IsSemiAssociative](#issemiassociative)
- [ResultingSurface](#resultingsurface)


## Constructors Details

### AssocSurfaceActionBody

#### Description
This wraps the ObjectARX [AcDbAssocSurfaceActionBody::AcDbAssocSurfaceActionBody](AcDbAssocSurfaceActionBody__AcDbAssocSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocSurfaceActionBody();
```

### EvaluateOverride

#### Description
This wraps the ObjectARX [AcDbAssocSurfaceActionBody::evaluateOverride](AcDbAssocSurfaceActionBody__evaluateOverride.md)() method.
```text
public override void EvaluateOverride();
```

### FindActionsThatAffectedTopologicalSubentity

#### Description
This wraps the ObjectARX [AcDbAssocSurfaceActionBody::findActionsThatAffectedTopologicalSubentity](AcDbAssocSurfaceActionBody__findActionsThatAffectedTopologicalSubentity@AcDbEntity_@AcDbSubentId_@AcDbObjectIdArray_.md)(); method.
```text
public static ObjectIdCollection FindActionsThatAffectedTopologicalSubentity(
    Entity entity, 
    SubentityId subEntityId
);
```

### ResultingSurfaceDep([MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbAssocSurfaceActionBody::resultingSurfaceDep](AcDbAssocSurfaceActionBody__resultingSurfaceDep@bool@bool.md)() method.
```text
public ObjectId ResultingSurfaceDep(
    [MarshalAs(UnmanagedType.U1)] bool createIfDoesNotExist
);
```

### ResultingSurfaceDep([MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbAssocSurfaceActionBody::resultingSurfaceDep](AcDbAssocSurfaceActionBody__resultingSurfaceDep@bool@bool.md)() method.
```text
public ObjectId ResultingSurfaceDep(
    [MarshalAs(UnmanagedType.U1)] bool createIfDoesNotExist, 
    [MarshalAs(UnmanagedType.U1)] bool isWriteOnlyDependency
);
```

### SetResultingSurface

#### Description
This wraps the ObjectARX [AcDbAssocSurfaceActionBody::setResultingSurface](AcDbAssocSurfaceActionBody__setResultingSurface@AcDbObjectId_@bool.md)() method.
```text
public void SetResultingSurface(
    ObjectId surfaceId, 
    [MarshalAs(UnmanagedType.U1)] bool isWriteOnlyDependency
);
```

### IsSemiAssociative

#### Description
This wraps the ObjectARX[AcDbAssocSurfaceActionBody::isSemiAssociative](AcDbAssocSurfaceActionBody__isSemiAssociative@const.md)( ) method.
```text
public bool IsSemiAssociative;
```

### ResultingSurface

#### Description
This wraps the ObjectARX [AcDbAssocSurfaceActionBody::resultingSurface](AcDbAssocSurfaceActionBody__resultingSurface@const.md)() and[AcDbAssocSurfaceActionBody::setResultingSurface](AcDbAssocSurfaceActionBody__setResultingSurface@AcDbObjectId_@bool.md) ()methods.
```text
public ObjectId ResultingSurface;
```
