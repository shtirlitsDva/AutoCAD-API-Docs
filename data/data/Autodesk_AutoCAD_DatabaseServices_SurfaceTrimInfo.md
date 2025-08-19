# SurfaceTrimInfo Class

## Overview

#### Description
This wraps the ObjectARX [AcDbSurfaceTrimInfo](AcDbSurfaceTrimInfo.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.SurfaceTrimInfo
```

```text
public class SurfaceTrimInfo : DisposableWrapper;
```

### Constructors

- [SurfaceTrimInfo](#surfacetriminfo)

### Methods

- [SetTrimInfo(CompoundObjectId, TrimRelation, SubentityId)](#settriminfo(compoundobjectid,-trimrelation,-subentityid))
- [SetTrimInfo(CompoundObjectId, Vector3d, TrimRelation)](#settriminfo(compoundobjectid,-vector3d,-trimrelation))

### Other

- [AutoCAD.DatabaseServices.SurfaceTrimInfo.TrimRelation Enumeration](#autocad.databaseservices.surfacetriminfo.trimrelation-enumeration)

### Properties

- [IsCurve](#iscurve)
- [ProjVector](#projvector)
- [Relation](#relation)
- [ToolBodyId](#toolbodyid)


## Constructors Details

### SurfaceTrimInfo

#### Description
This wraps the ObjectARX [AcDbSurfaceTrimInfo::AcDbSurfaceTrimInfo](AcDbSurfaceTrimInfo__AcDbSurfaceTrimInfo.md)() method.
```text
public SurfaceTrimInfo();
```

### SetTrimInfo(CompoundObjectId, TrimRelation, SubentityId)

#### Description
This wraps the ObjectARX [AcDbSurfaceTrimInfo::setTrimInfo](AcDbSurfaceTrimInfo__setTrimInfo@AcDbCompoundObjectId__@TrimRelation@AcDbSubentId_.md)() method.
```text
public void SetTrimInfo(
    CompoundObjectId surfaceId, 
    TrimRelation relation, 
    SubentityId subEntityId
);
```

### SetTrimInfo(CompoundObjectId, Vector3d, TrimRelation)

#### Description
This wraps the ObjectARX [AcDbSurfaceTrimInfo::setTrimInfo](AcDbSurfaceTrimInfo__setTrimInfo@AcDbCompoundObjectId_@AcGeVector3d__@TrimRelation.md)() method.
```text
public void SetTrimInfo(
    CompoundObjectId curveId, 
    Vector3d projVector, 
    TrimRelation relation
);
```

### AutoCAD.DatabaseServices.SurfaceTrimInfo.TrimRelation Enumeration

#### Description
This wraps the ObjectARX [AcDbSurfaceTrimInfo::TrimRelation](AcDbSurfaceTrimInfo__TrimRelation.md) enum.
```text
public enum TrimRelation {
  InsideTool,
  OutsideTool
}
```


## Properties Details

### IsCurve

#### Description
This wraps the ObjectARX [AcDbSurfaceTrimInfo::isCurve](AcDbSurfaceTrimInfo__isCurve@const.md)() method.
```text
public bool IsCurve;
```

### ProjVector

#### Description
This wraps the ObjectARX [AcDbSurfaceTrimInfo::projVector](AcDbSurfaceTrimInfo__projVector@const.md)() and [AcDbSurfaceTrimInfo::setProjVector](AcDbSurfaceTrimInfo__setProjVector@AcGeVector3d_.md)() methods.
```text
public Vector3d ProjVector;
```

### Relation

#### Description
This wraps the ObjectARX [AcDbSurfaceTrimInfo::relation](AcDbSurfaceTrimInfo__relation@const.md)() and [AcDbSurfaceTrimInfo::setRelation](AcDbSurfaceTrimInfo__setRelation@TrimRelation.md) () methods.
```text
public TrimRelation Relation;
```

### ToolBodyId

#### Description
This wraps the ObjectARX [AcDbSurfaceTrimInfo::toolBodyId()](AcDbSurfaceTrimInfo__toolBodyId@const.md) and [AcDbSurfaceTrimInfo::setToolBodyId()](AcDbSurfaceTrimInfo__setToolBodyId@AcDbCompoundObjectId__.md) methods.
```text
public CompoundObjectId ToolBodyId;
```
