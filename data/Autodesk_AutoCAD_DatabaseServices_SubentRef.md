# SubentRef Class

## Overview

#### Description
This wraps the ObjectARX [AcDbSubentRef](AcDbSubentRef.md) class
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GeomRef
    Autodesk.AutoCAD.DatabaseServices.SubentRef
        Autodesk.AutoCAD.DatabaseServices.EdgeRef
        Autodesk.AutoCAD.DatabaseServices.FaceRef
        Autodesk.AutoCAD.DatabaseServices.VertexRef
```

```text
public abstract class SubentRef : GeomRef;
```

### Methods

- [CopyFrom](#copyfrom)
- [CreateEntity](#createentity)

### Properties

- [Entity](#entity)
- [SubentId](#subentid)


## Methods Details

### CopyFrom

#### Description
This wraps the ObjectARX AcDbSubentRef::operator =(const AcDbSubentRef&amp;) method
```text
public void CopyFrom(
    SubentRef source
);
```

### CreateEntity

#### Description
This wraps the ObjectARX [AcDbSubentRef::createEntity](AcDbSubentRef__createEntity@const.md)() method
```text
public Autodesk.AutoCAD.DatabaseServices.Entity CreateEntity();
```

### Entity

#### Description
This wraps the ObjectARX[AcDbSubentRef::entity](AcDbSubentRef__entity@const.md)() method
```text
public CompoundObjectId Entity;
```

### SubentId

#### Description
This wraps the ObjectARX [AcDbSubentRef::subentId](AcDbSubentRef__subentId@const.md)() method
```text
public SubentityId SubentId;
```
