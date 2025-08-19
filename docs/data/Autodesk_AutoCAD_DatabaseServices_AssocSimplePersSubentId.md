# AssocSimplePersSubentId Class

## Overview

#### Description
The concrete derived AssocPersSubentityId class that simply keeps the SubentityId when it is persistent and does not change.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocPersSubentityId
    Autodesk.AutoCAD.DatabaseServices.AssocSimplePersSubentId
```

```text
public class AssocSimplePersSubentId : AssocPersSubentityId;
```

### Constructors

- [AssocSimplePersSubentId](#assocsimpleperssubentid)

### Methods

- [Audit](#audit)
- [DwgInFields](#dwginfields)
- [DwgOutFields](#dwgoutfields)
- [DxfInFields](#dxfinfields)
- [DxfOutFields](#dxfoutfields)
- [IsEqualTo](#isequalto)
- [SubentId](#subentid)
- [SubentType](#subenttype)
- [TransientSubentCount](#transientsubentcount)

### Properties

- [IsNull](#isnull)


## Constructors Details

### AssocSimplePersSubentId

#### Description
Constructor. Just keeps the given SubentityId.
```text
public AssocSimplePersSubentId(
    SubentityId SubentityId
);
```

### Audit

#### Description
The standard protocol.
```text
public override void Audit(
    AuditInfo auditInfo
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AuditInfo auditInfo | See the [AuditInfo](Autodesk_AutoCAD_DatabaseServices_AuditInfo.md "AuditInfo Class") documentation. |

### DwgInFields

#### Description
The standard filing protocol.
```text
public override void DwgInFields(
    DwgFiler filer
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
public override void DwgOutFields(
    DwgFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgFiler filer | The filer to write the object data to. |

### DxfInFields

#### Description
The standard filing protocol.
```text
public override void DxfInFields(
    DxfFiler filer
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
public override void DxfOutFields(
    DxfFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DxfFiler filer | The filer to write the object data to. |

### IsEqualTo

#### Description
Returns true if this and the other AssocSimplePersSubentityId reference exactly the same subentity of the same entity. It simply compares the stored SubentityIds.
```text
public override bool IsEqualTo(
    Entity entity, 
    AssocPersSubentityId other
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entity | The entity owning the subentities of this and the other AssocPersSubentityId. |
| AssocPersSubentityId other | The other AssocSimplePersSubentityId. |

#### Returns
True if this and the other AssocSimplePersSubentityId are equal.
### SubentId

#### Description
Returns the stored SubentityId.
```text
public virtual SubentityId SubentId(
    Entity entity
);
```

#### Returns
The stored SubentityId.
### SubentType

#### Description
Returns the type of the stored SubentityId.
```text
public override SubentityType SubentType(
    Entity entity
);
```

#### Returns
[SubentityType](Autodesk_AutoCAD_DatabaseServices_SubentityType.md "SubentityType Enumeration").
### TransientSubentCount

#### Description
Returns number 1 if not null or 0 if null.
```text
public override int TransientSubentCount(
    Entity entity
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entity | Not used. |

#### Returns
Returns count 1 or 0.
### IsNull

#### Description
Indicates whether the SubentityId stored in this AssocSimplePersSubentityId is null.
```text
public override bool IsNull;
```

#### Conditions
Read-only