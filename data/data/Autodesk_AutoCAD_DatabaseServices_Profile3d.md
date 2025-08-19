# Profile3d Class

## Overview

#### Description
This wraps the ObjectARX [AcDb3dProfile](AcDb3dProfile.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Profile3d
    Autodesk.AutoCAD.DatabaseServices.LoftProfile
```

```text
public class Profile3d : RXObject;
```

### Constructors

- [Profile3d()](#profile3d())
- [Profile3d(Autodesk.AutoCAD.DatabaseServices.Entity)](#profile3d(autodesk.autocad.databaseservices.entity))
- [Profile3d(FullSubentityPath)](#profile3d(fullsubentitypath))
- [Profile3d(PathRef)](#profile3d(pathref))
- [Profile3d(Profile3d)](#profile3d(profile3d))
- [Profile3d(VertexRef)](#profile3d(vertexref))

### Methods

- [ConvertProfile([MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#convertprofile([marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [ConvertProfile(PathRef[])](#convertprofile(pathref[]))
- [CopyFrom](#copyfrom)
- [MergeProfiles](#mergeprofiles)

### Properties

- [Entity](#entity)
- [IsClosed](#isclosed)
- [IsEdge](#isedge)
- [IsFace](#isface)
- [IsPlanar](#isplanar)
- [IsSubent](#issubent)
- [IsValid](#isvalid)
- [ProfilePathRef](#profilepathref)
- [ProfileVertexRef](#profilevertexref)


## Constructors Details

### Profile3d()

#### Description
This wraps the ObjectARX [AcDb3dProfile::AcDb3dProfile](AcDb3dProfile__AcDb3dProfile.md) () method.
```text
public Profile3d();
```

### Profile3d(Autodesk.AutoCAD.DatabaseServices.Entity)

#### Description
This wraps the ObjectARX [AcDb3dProfile::AcDb3dProfile](AcDb3dProfile__AcDb3dProfile@AcDbEntity__.md) () method.
```text
public Profile3d(
    Autodesk.AutoCAD.DatabaseServices.Entity entity
);
```

### Profile3d(FullSubentityPath)

#### Description
This wraps the ObjectARX [AcDb3dProfile::AcDb3dProfile](AcDb3dProfile__AcDb3dProfile@AcDbFullSubentPath_.md)() method.
```text
public Profile3d(
    FullSubentityPath faceSubentPath
);
```

### Profile3d(PathRef)

#### Description
This wraps the ObjectARX [AcDb3dProfile::AcDb3dProfile](AcDb3dProfile__AcDb3dProfile@AcDbPathRef__.md) () method.
```text
public Profile3d(
    PathRef pathRef
);
```

### Profile3d(Profile3d)

#### Description
This wraps the ObjectARX [AcDb3dProfile::AcDb3dProfile](AcDb3dProfile__AcDb3dProfile@AcDb3dProfile_.md) () method.
```text
public Profile3d(
    Profile3d profile3d
);
```

### Profile3d(VertexRef)

#### Description
This wraps the ObjectARX [AcDb3dProfile::AcDb3dProfile](AcDb3dProfile__AcDb3dProfile@AcDbVertexRef__.md) () method.
```text
public Profile3d(
    VertexRef vertexRef
);
```

### ConvertProfile([MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDb3dProfile::convertProfile](AcDb3dProfile__convertProfile@bool@bool@bool@bool@AcArray_AcDb3dProfile___@const.md)() method.
```text
public Profile3d\[\] ConvertProfile(
    [MarshalAs(UnmanagedType.U1)] bool explodeMultiFaceRegions, 
    [MarshalAs(UnmanagedType.U1)] bool convertSurfaceToEdges, 
    [MarshalAs(UnmanagedType.U1)] bool nonPlanarOnly, 
    [MarshalAs(UnmanagedType.U1)] bool outerLoopOnly
);
```

### ConvertProfile(PathRef[])

#### Description
This wraps the ObjectARX [AcDb3dProfile::convertProfile](AcDb3dProfile__convertProfile@AcArray_AcDbPathRef__.md)() method.
```text
public static Profile3d ConvertProfile(
    PathRef\[\] pathRefArray
);
```

### CopyFrom

#### Description
This wraps the ObjectARX [AcDb3dProfile::operator =](AcDb3dProfile__=@AcDb3dProfile_.md)() method.
```text
public void CopyFrom(
    Profile3d source
);
```

### MergeProfiles

#### Description
This wraps the ObjectARX[AcDb3dProfile::mergeProfiles](AcDb3dProfile__mergeProfiles@AcArray_AcDb3dProfile___@bool@bool@AcArray_AcDb3dProfile___.md) () method.
```text
public static Profile3d\[\] MergeProfiles(
    Profile3d\[\] profiles, 
    [MarshalAs(UnmanagedType.U1)] bool mergeEdges, 
    [MarshalAs(UnmanagedType.U1)] bool mergeCurves
);
```

### Entity

#### Description
This wraps the ObjectARX [AcDb3dProfile::entity](AcDb3dProfile__entity@const.md)() and [AcDb3dProfile::set](AcDb3dProfile__set@AcDbEntity__.md)() methods.
```text
public Autodesk.AutoCAD.DatabaseServices.Entity Entity;
```

### IsClosed

#### Description
This wraps the ObjectARX [AcDb3dProfile::isClosed](AcDb3dProfile__isClosed@const.md) () method.
```text
public bool IsClosed;
```

### IsEdge

#### Description
This wraps the ObjectARX [AcDb3dProfile::isEdge](AcDb3dProfile__isEdge@const.md) () method.
```text
public bool IsEdge;
```

### IsFace

#### Description
This wraps the ObjectARX[AcDb3dProfile::isFace](AcDb3dProfile__isFace@const.md) () method.
```text
public bool IsFace;
```

### IsPlanar

#### Description
This wraps the ObjectARX [AcDb3dProfile::isPlanar](AcDb3dProfile__isPlanar@const.md) () method.
```text
public bool IsPlanar;
```

### IsSubent

#### Description
This wraps the ObjectARX [AcDb3dProfile::isSubent](AcDb3dProfile__isSubent@const.md) () method.
```text
public bool IsSubent;
```

### IsValid

#### Description
This wraps the ObjectARX [AcDb3dProfile::isValid](AcDb3dProfile__isValid@const.md) () method.
```text
public bool IsValid;
```

### ProfilePathRef

#### Description
This wraps the ObjectARX [AcDb3dProfile::getPathRef](AcDb3dProfile__getPathRef@AcDbPathRef__@const.md)() and [AcDb3dProfile::set](AcDb3dProfile__set@AcDbPathRef__.md)() methods.
```text
public PathRef ProfilePathRef;
```

### ProfileVertexRef

#### Description
This wraps the ObjectARX [AcDb3dProfile::getVertexRef](AcDb3dProfile__getVertexRef@AcDbVertexRef__@const.md)() and [AcDb3dProfile::set](AcDb3dProfile__set@AcDbVertexRef__.md)() methods.
```text
public VertexRef ProfileVertexRef;
```
