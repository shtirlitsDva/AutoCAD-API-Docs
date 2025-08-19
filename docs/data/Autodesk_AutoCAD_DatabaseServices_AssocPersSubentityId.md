# AssocPersSubentityId Class

## Overview

#### Description
Abstract base class used to persistently identify an SubentityId of an Entity. Unlike SubentityId that is transient and may change when the entity is modified, reevaluated, or similar, the AssocPersSubentityId identifies the subentity in such a way that it is always possible to obtain the corresponding subentities (if they still exist), even after the entity has been edited or reevaluated any number of times. 
The base AssocPersSubentityId class is an abstract base class. Concrete Entity classes need their own way how to represent a persistent identitfication of their subentities. Therefore there are derived AssocPersSubentityId classes that keep the persistent identitifcation of the subentities of particular entity types. The simplest one is the AssocSimplePersSubentityId derived class that just keeps the SubentityId in case it can be relied on that it does not change. 
The AcRx protocol extension classes derived from AssocPersSubentityIdPE base class provide mapping from transient SubentityId to the persistent AssocPersSubentityId, they allow to create new AssocPersSubentityIds from given SubentityIds. The AssocPersSubentityId provides mapping in the opposite direction, from AssocPersSubentityIds to SubentityIds.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocPersSubentityId
    Autodesk.AutoCAD.DatabaseServices.AssocSimplePersSubentId
    Autodesk.AutoCAD.DatabaseServices.AssocSingleEdgePersSubentId
```

```text
public abstract class AssocPersSubentityId : RXObject;
```

### Constructors

- [AssocPersSubentityId](#assocperssubentityid)

### Methods

- [Audit](#audit)
- [CreateObjectAndDwgInFields](#createobjectanddwginfields)
- [CreateObjectAndDxfInFields](#createobjectanddxfinfields)
- [DwgInFields](#dwginfields)
- [DwgOutFields](#dwgoutfields)
- [DxfInFields](#dxfinfields)
- [DxfOutFields](#dxfoutfields)
- [GetTransientSubentIds](#gettransientsubentids)
- [IsEqualTo](#isequalto)
- [Mirror](#mirror)
- [SubentType](#subenttype)
- [TransientSubentCount](#transientsubentcount)

### Properties

- [IsNull](#isnull)


## Constructors Details

### AssocPersSubentityId

#### Description
Default constructor.
```text
public AssocPersSubentityId();
```

### Audit

#### Description
The standard protocol.
```text
public virtual void Audit(
    AuditInfo auditInfo
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AuditInfo auditInfo | See the AuditInfo documentation. |

### CreateObjectAndDwgInFields

#### Description
A static method that reads the class identification of the actual AssocPersSubentityId-derived class, creates an object of this derived class and calls DwgInFields() on it.
#### Parameters

| Parameters | Description |
| --- | --- |
| Database database | AcDbDatabase that is going to own the AcDbAssocPersSubentId. |
| DwgFiler filer | The filer to read the data from. The first data is the class identification. |
| ref AssocPersSubentityId createdPersSubentId | This is an in/out argument used to return the created and filled-in object of an AssocPersSubentityId-derived class. If the createdPersSubentId is passed in as not NULL, the code tries to reuse the existing object, if it is of the expected derived class. If it is passed in as NULL or is not of the expected derived type, it creates a new object (deleting the existing one, if any). |

Previous Declaration
```text
static Acad::ErrorStatus createObjectAndDwgInFields(AcDbDwgFiler* pFiler, AcDbAssocPersSubentId*& pCreatedPersSubentId);
```

### CreateObjectAndDxfInFields

#### Description
A static method that reads the class identification of the actual AssocPersSubentityId-derived class, creates an object of this derived class and calls DxfInFields() on it.
```text
public static void CreateObjectAndDxfInFields(
    DxfFiler filer, 
    ref AssocPersSubentityId createdPersSubentId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DxfFiler filer | The filer to read the data from. The first data is the class identification. |
| ref AssocPersSubentityId createdPersSubentId | This is an in/out argument used to return the created and filled-in object of an AssocPersSubentityId-derived class. If the createdPersSubentId is passed in as not NULL, the code tries to reuse the existing object, if it is of the expected derived class. If it is passed in as NULL or is not of the expected derived type, it creates a new object (deleting the existing one, if any). |

### DwgInFields

#### Description
The standard filing protocol. The AssocPersSubentityId base class implementation does nothing and doesn't therefore need to be called from the derived classes.
```text
public virtual void DwgInFields(
    DwgFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgFiler filer | The filer to read the object data from. |

### DwgOutFields

#### Description
The standard filing protocol. The AssocPersSubentityId base class implementation writes-out the actual class identification so that it is possible to create an object of the same class when the data is read back in (this happens in CreateObjectAndDwgInFields()).
```text
public virtual void DwgOutFields(
    DwgFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgFiler filer | The filer to write the object data to. |

### DxfInFields

#### Description
The standard filing protocol. The AssocPersSubentityId base class implementation does nothing and doesn't therefore need to be called from the derived classes.
```text
public virtual void DxfInFields(
    DxfFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DxfFiler filer | The filer to read the object data from. |

### DxfOutFields

#### Description
The standard filing protocol. The AssocPersSubentityId base class implementation writes-out the actual class identification so that it is possible to create an object of the same class when the data is read back in (this happens in CreateObjectAndDxfInFields()).
```text
public virtual void DxfOutFields(
    DxfFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DxfFiler filer | The filer to write the object data to. |

### GetTransientSubentIds

#### Description
Mapping: AssocPersSubentityId --> SubentityId(s) 
Obtains all SubentityIds corresponding to this AssocPersSubentityId.
```text
public virtual SubentityId\[\] GetTransientSubentIds(
    Entity entity
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entity | The entity needs to be open for read. |
| subents | The returned SubentityIds. |

#### Remarks
Notice that one AssocPersSubentityId may correspond to none, one or more than one SubentityId, because the entity may have changed and there may not be just a single subentity corresponding to the original subentity identified by this AssocPersSubentityId. The default implementation just calls the AssocPersSubentityIdPE.GetTransientSubentIds() method.
### IsEqualTo

#### Description
Returns true if this and the other AssocPersSubentityId reference are exactly the same subentity of the same entity. The base class implementation just checks whether the classes of this and of the other AssocPersSubentityId are identical.
```text
public virtual bool IsEqualTo(
    Entity entity, 
    AssocPersSubentityId other
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocPersSubentityId other | The other AssocPersSubentityId. |
| ntity | The entity owning the subentities of this and the other AssocPersSubentityId. |

#### Returns
True if this and the other AssocPersSubentityId are equal.
### Mirror

#### Description
Notifies this AssocPersSubentityId that the entity has been mirrored and that the AssocPersSubentityId may possibly need to update itself to identify the same subentity in the mirrored entity as it identified before the entity has been mirrored. 
The default implementation obtains AssocPersSubentityIdPE from the mirrored entity and calls [AssocPersSubentityIdPE.MirrorPersSubent](Autodesk_AutoCAD_DatabaseServices_AssocPersSubentityIdPE_MirrorPersSubent@Entity@AssocPersSubentityId.md)() that does all the work. By default the "work" is a no-op, except for some entity types, such as Arc and its AssocArcPersSubentityIdPE protocol extension class.
```text
public virtual void Mirror(
    Entity mirroredEntity
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity mirroredEntity | The entity that has been mirrored. It needs to be open for read. |

### SubentType

#### Description
Returns the type of the subentity.
```text
public abstract SubentityType SubentType(
    Entity entity
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entity | The entity needs to be open for read. |

### TransientSubentCount

#### Description
Returns the number of transient SubentityIds corresponding to this AssocPersSubentityId. The default implementation just calls GetTransientSubentIds() and returns their count which usually is 1.
```text
public virtual int TransientSubentCount(
    Entity entity
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entity | The entity needs to be open for read. |

#### Returns
Number of transient SubentityIds corresponding to this AssocPersSubentityId.
### IsNull

#### Description
Indicates whether this AssocPersSubentityId is null, i.e., not referencing any subentity of any entity. 
It is logically slightly different from when GetTransientSubentIds() returns no SubentityIds. In the latter case the AssocPersSubentityId may reference some subentities, but they may have been deleted, changed, or similar.
```text
public abstract bool IsNull;
```

#### Conditions
Read-only