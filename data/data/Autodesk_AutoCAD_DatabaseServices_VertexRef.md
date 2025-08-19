# VertexRef Class

## Overview

#### Description
This wraps the ObjectARX [AcDbVertexRef](AcDbVertexRef.md) class
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GeomRef
    Autodesk.AutoCAD.DatabaseServices.SubentRef
        Autodesk.AutoCAD.DatabaseServices.VertexRef
```

```text
public class VertexRef : SubentRef;
```

### Constructors

- [VertexRef()](#vertexref())
- [VertexRef(CompoundObjectId)](#vertexref(compoundobjectid))
- [VertexRef(CompoundObjectId, SubentityId)](#vertexref(compoundobjectid,-subentityid))
- [VertexRef(CompoundObjectId, SubentityId, Point3d)](#vertexref(compoundobjectid,-subentityid,-point3d))
- [VertexRef(Entity)](#vertexref(entity))
- [VertexRef(FullSubentityPath)](#vertexref(fullsubentitypath))
- [VertexRef(Point3d)](#vertexref(point3d))

### Properties

- [Point](#point)


## Constructors Details

### VertexRef()

#### Description
This wraps the ObjectARX [AcDbVertexRef::AcDbVertexRef](AcDbVertexRef__AcDbVertexRef.md)() method
```text
public VertexRef();
```

### VertexRef(CompoundObjectId)

#### Description
This wraps the ObjectARX [AcDbVertexRef::AcDbVertexRef](AcDbVertexRef__AcDbVertexRef@AcDbCompoundObjectId_@AcDbSubentId_@AcGePoint3d_.md)() method.
```text
public VertexRef(
    CompoundObjectId compoundObjectId
);
```

### VertexRef(CompoundObjectId, SubentityId)

#### Description
This wraps the ObjectARX [AcDbVertexRef::AcDbVertexRef](AcDbVertexRef__AcDbVertexRef@AcDbCompoundObjectId_@AcDbSubentId_@AcGePoint3d_.md)() method.
```text
public VertexRef(
    CompoundObjectId compoundObjectId, 
    SubentityId subentId
);
```

### VertexRef(CompoundObjectId, SubentityId, Point3d)

#### Description
This wraps the ObjectARX [AcDbVertexRef::AcDbVertexRef](AcDbVertexRef__AcDbVertexRef@AcDbCompoundObjectId_@AcDbSubentId_@AcGePoint3d_.md)() method.
```text
public VertexRef(
    CompoundObjectId compoundObjectId, 
    SubentityId subentId, 
    Point3d point
);
```

### VertexRef(Entity)

#### Description
This wraps the ObjectARX [AcDbVertexRef::VertexRef](AcDbVertexRef__AcDbVertexRef@AcDbEntity_.md)() method
```text
public VertexRef(
    Entity entity
);
```

### VertexRef(FullSubentityPath)

#### Description
This wraps the ObjectARX [AcDbVertexRef::AcDbVertexRef](AcDbVertexRef__AcDbVertexRef@AcDbFullSubentPath_.md)() method
```text
public VertexRef(
    FullSubentityPath path
);
```

### VertexRef(Point3d)

#### Description
This wraps the ObjectARX [AcDbVertexRef::AcDbVertexRef](AcDbVertexRef__AcDbVertexRef@AcGePoint3d_.md)(const AcGePoint3d *pGePoint) method
```text
public VertexRef(
    Point3d point
);
```

### Point

#### Description
This wraps the ObjectARX [AcDbVertexRef::point](AcDbVertexRef__point@const.md)() method
```text
public Point3d Point;
```
