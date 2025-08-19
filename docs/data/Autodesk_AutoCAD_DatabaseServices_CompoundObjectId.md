# CompoundObjectId Class

## Overview

#### Description
Class used to identify an Object in an Database when the object is references via a path of BlockReferences, and possibly by some other ways in the future. The object may reside in the host database (the same database as the CompoundObjectId belongs to) or it may reside in an XREF database or even in an unrelated database. 
Notice that if the CompoundObjectId references an object in another database, reactors will be created to keep tract of relevant events happening to the database, such as database deletion or XREF unload/reload.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.CompoundObjectId
```

```text
public class CompoundObjectId : RXObject;
```

### Constructors

- [CompoundObjectId()](#compoundobjectid())
- [CompoundObjectId(CompoundObjectId)](#compoundobjectid(compoundobjectid))
- [CompoundObjectId(ObjectId)](#compoundobjectid(objectid))
- [CompoundObjectId(ObjectId, Database)](#compoundobjectid(objectid,-database))
- [CompoundObjectId(ObjectId, ObjectIdCollection, Database)](#compoundobjectid(objectid,-objectidcollection,-database))

### Methods

- [DwgInFields](#dwginfields)
- [DwgOutFields](#dwgoutfields)
- [DxfInFields](#dxfinfields)
- [DxfOutFields](#dxfoutfields)
- [IsValid](#isvalid)
- [NullId](#nullid)
- [Remap](#remap)
- [Set(CompoundObjectId, Database)](#set(compoundobjectid,-database))
- [Set(ObjectId, Database)](#set(objectid,-database))
- [Set(ObjectId, ObjectIdCollection, Database)](#set(objectid,-objectidcollection,-database))
- [SetEmpty](#setempty)
- [SetFullPath](#setfullpath)

### Other

- [AutoCAD.DatabaseServices.CompoundObjectId.StatusType Enumeration](#autocad.databaseservices.compoundobjectid.statustype-enumeration)

### Properties

- [FullPath](#fullpath)
- [IsEmpty](#isempty)
- [IsExternal](#isexternal)
- [IsSimpleObjectId](#issimpleobjectid)
- [LeafId](#leafid)
- [Path](#path)
- [Status](#status)
- [TopId](#topid)
- [Transform](#transform)


## Constructors Details

### CompoundObjectId()

#### Description
The default constructor creates an empty CompoundObjectId.
```text
public CompoundObjectId();
```

### CompoundObjectId(CompoundObjectId)

#### Description
Copy constructor.
```text
public CompoundObjectId(
    CompoundObjectId A_0
);
```

### CompoundObjectId(ObjectId)

#### Description
Creates CompoundObjectId from an ordinary ObjectId. If the host database is null, the host database is obtained from the given ObjectId. Even if it is in XREF database, the database hosting the XREF is obtained.
```text
public CompoundObjectId(
    ObjectId id
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | ObjectId of the DBObject that this CompoundObjectId is going to reference. |

### CompoundObjectId(ObjectId, Database)

#### Description
Creates CompoundObjectId from an ordinary ObjectId. If the host database is null, the host database is obtained from the given ObjectId. Even if it is in XREF database, the database hosting the XREF is obtained.
```text
public CompoundObjectId(
    ObjectId id, 
    Database hostDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | ObjectId of the DBObject that this CompoundObjectId is going to reference. |
| Database hostDatabase | The host database. If null, the database is taken from the ObjectId (even if it is in XREF database). |

### CompoundObjectId(ObjectId, ObjectIdCollection, Database)

#### Description
Creates CompoundObjectId from an ordinary ObjectId and a path of BlockReferences. If the host database is null, the host database is obtained from the first id in the path. Even if it is in XREF database, the database hosting the XREF is obtained.
```text
public CompoundObjectId(
    ObjectId id, 
    ObjectIdCollection path, 
    Database hostDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | ObjectId of the DBObject that this CompoundObjectId is going to reference. |
| ObjectIdCollection path | The path of BlockRefrences that lead to the referenced object. The first BlockReference in the path resides in the host database, the second BlockReference is from the BlockTableRecord that the first BlockReference references, the third BlockReference is from the BlockTableRecord that the second BlockReference references, etc. |
| pHostDatabase | The host database. If null, the database is taken from the first BlockReference id in the path (even if it is in XREF database). |

### DwgInFields

#### Description
The standard filing protocol.
```text
public void DwgInFields(
    DwgFiler filer, 
    int ownerVersion
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgFiler filer | The filer to read the object data from. |

### DwgOutFields

#### Description
The standard filing protocol.
```text
public void DwgOutFields(
    DwgFiler filer, 
    Database hostDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgFiler filer | The filer to read the object data to. |

### DxfInFields

#### Description
The standard filing protocol.
```text
public void DxfInFields(
    DxfFiler filer, 
    Database hostDatabase, 
    int ownerVersion
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DxfFiler filer | The filer to read the object data from. |

### DxfOutFields

#### Description
The standard filing protocol.
```text
public void DxfOutFields(
    DxfFiler filer, 
    Database hostDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DxfFiler filer | The filer to read the object data to. |

### IsValid

#### Description
Returns true if the CompoundObjectId is valid. 
The given validityCheckingLevel specifies the level of testing. Bigger number means more thorough checks are being performed. At this moment the validityCheckingLevel argument is unused but will be used in the future.
```text
public bool IsValid(
    int validityCheckingLevel
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int validityCheckingLevel | Input the level of testing. |

#### Returns
true if the CompoundObjectId is valid.
### NullId

#### Description
Returns an empty CompoundObjectId.
```text
public static CompoundObjectId NullId();
```

### Remap

#### Description
Remaps all the ObjectIds in this CompoundObjectId by the given IdMapping. Returns true if any remapping actually happened, false otherwise.
```text
public bool Remap(
    IdMapping idMap
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IdMapping idMap | See the description of the IdMapping class. |

#### Returns
True if some ids actually changed, false otherwise.
### Set(CompoundObjectId, Database)

#### Description
Sets this CompoundObjectId from another CompoundObjectId.
```text
public void Set(
    CompoundObjectId compoundID, 
    Database hostDatabase
);
```

### Set(ObjectId, Database)

#### Description
Sets this CompoundObjectId from an ordinary ObjectId. If the host database is null, the host database is obtained from the given ObjectId. Even if it is in XREF database, the database hosting the XREF is obtained.
```text
public void Set(
    ObjectId id, 
    Database hostDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | ObjectId of the Object that this CompoundObjectId is going to reference. |
| Database hostDatabase | The host database. If null, the database is taken from the ObjectId (even if it is in XREF database). |

### Set(ObjectId, ObjectIdCollection, Database)

#### Description
Sets this CompoundObjectId from an ordinary ObjectId and a path of BlockReferences. If the host database is null, the host database is obtained from the first id in the path. Even if it is in XREF database, the database hosting the XREF is obtained.
```text
public void Set(
    ObjectId id, 
    ObjectIdCollection path, 
    Database hostDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | ObjectId of the DBObject that this CompoundObjectId is going to reference. |
| ObjectIdCollection path | The path of BlockRefrences that lead to the referenced object. The first BlockRefrence in the path resides in the host database, the second BlockReference is from the BlockTableRecord that the first BlockReference references, the third BlockReference is from the BlockTableRecord that the second BlockReference references, etc. |
| Database hostDatabase | The host database. If null, the database is taken from the first BlockReference id in the path (even if it is in XREF database). |

### SetEmpty

#### Description
Sets the CompoundObjectId to be empty, containing no data.
```text
public void SetEmpty();
```

### SetFullPath

#### Description
Sets this AcDbCompoundObjectId from the path that contains the path of AcDbBlockReferences apppended by the leaf AcDbObjectId.
```text
public void SetFullPath(
    ObjectIdCollection fullPath, 
    Database hostDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdCollection fullPath | The path of AcDbBlockRefrences and the leaf level object itself as the last element of the array. |
| pHostDatabase | The host database. If null, the database is taken from the first AcDbBlockReference id in the fullPath. |

### AutoCAD.DatabaseServices.CompoundObjectId.StatusType Enumeration

#### Description
The status of the CompoundObjectId
```text
public enum StatusType {
  CouldNotResolveNonTerminal = 2,
  CouldNotResolveTerminal = 3,
  CouldNotResolveTooEarly = 4,
  IncompatibleIdType = 0x3e8,
  Valid = 0,
  WasLoadedNowUnloaded = 1
}
```

#### Members

| Members | Description |
| --- | --- |
| CouldNotResolveNonTerminal = 2 | Couldn't be resolved - xref not found, unloaded when last saved, etc. non-terminal |
| CouldNotResolveTerminal = 3 | Couldn't be resolved, bad sceario - xref dwg replaced, not referenced, etc. |
| CouldNotResolveTooEarly = 4 | Couldn't be resolved yet - too early - xref not finished resolving |
| IncompatibleIdType = 0x3e8 | Id Type is incompatible |
| Valid = 0 | Good to go, can be Null |
| WasLoadedNowUnloaded = 1 | Loaded during dwgOpen, then xref was unloaded |


## Properties Details

### FullPath

#### Description
Gets the full path, i.e., the given path of BlockReference ids appended with the leaf ObjectId.
```text
public ObjectIdCollection FullPath;
```

#### Conditions
Read-only
### IsEmpty

#### Description
Indicates whether the CompoundObjectId contains no data.
```text
public bool IsEmpty;
```

#### Conditions
Read-only
### IsExternal

#### Description
Returns true iff the CompoundObjectId is from an external drawing.
```text
public bool IsExternal;
```

### IsSimpleObjectId

#### Description
Indicates whether there is no path, only the leaf id (which may be null).
```text
public bool IsSimpleObjectId;
```

#### Conditions
Read-only
### LeafId

#### Description
Gets the leaf-node ObjectId that resides in the BlockTableRecord that the last BlockReference in the path references, or simply the ObjectId if there is no path.
```text
public ObjectId LeafId;
```

#### Conditions
Read-only
### Path

#### Description
Gets the BlockReference path.
```text
public ObjectIdCollection Path;
```

#### Conditions
Read-only
### Status

#### Description
Gets the status type.
```text
public StatusType Status;
```

#### Conditions
Read-only
### TopId

#### Description
Gets the first ObjectId (of an BlockReference) in the path, or the leaf-node ObjectId, if there is no path.
```text
public ObjectId TopId;
```

#### Conditions
Read-only
### Transform

#### Description
Gets the compound transform from the leaf object to the world, concatenating all the BlockReference transforms, from the most nested one to the topmost one. This transformation represents mapping of the coordinates of the leaf-level object from its BlockTableRecord coordinate space to the world coordinate space.
```text
public Matrix3d Transform;
```

#### Conditions
Read-only