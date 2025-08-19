# AssocSingleEdgePersSubentId Class

## Overview

#### Description
The concrete derived AssocPersSubentId class that identifies an edge subentity if the entity has only a single edge subentity (such as in the case of curve entities).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocPersSubentityId
    Autodesk.AutoCAD.DatabaseServices.AssocSingleEdgePersSubentId
```

```text
public class AssocSingleEdgePersSubentId : AssocPersSubentityId;
```

### Constructors

- [AssocSingleEdgePersSubentId](#assocsingleedgeperssubentid)

### Methods

- [IsEqualTo](#isequalto)
- [SubentType](#subenttype)
- [TransientSubentCount](#transientsubentcount)

### Properties

- [IsNull](#isnull)


## Constructors Details

### AssocSingleEdgePersSubentId

#### Description
Default Constructor
```text
public AssocSingleEdgePersSubentId();
```

### IsEqualTo

#### Description
Returns true if this and the other AssocSingleEdgePersSubentId reference exactly the same subentity of the same entity. It just calls the base class [AssocPersSubentityId.IsEqualTo](Autodesk_AutoCAD_DatabaseServices_AssocPersSubentityId_IsEqualTo@Entity@AssocPersSubentityId.md)() because there is no additional data stored in this derived AssocSingleEdgePersSubentId class.
```text
public override bool IsEqualTo(
    Entity entity, 
    AssocPersSubentityId other
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity owning the subentities of this and the other AssocSingleEdgePersSubentId. |
| AssocPersSubentityId other | The other AssocSingleEdgePersSubentId. |

#### Returns
True iff this and the other AssocSingleEdgePersSubentId are equal.
### SubentType

#### Description
Always returns SubentityType.Edge.
```text
public override SubentityType SubentType(
    Entity entity
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | Not used. |

#### Returns
SubentityType.Edge.
### TransientSubentCount

#### Description
Always returns number 1.
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
Always returns count 1.
### IsNull

#### Description
Is always false because AssocSingleEdgePersSubentId always identities the single edge of an entity.
```text
public override bool IsNull;
```

#### Conditions
Read-only