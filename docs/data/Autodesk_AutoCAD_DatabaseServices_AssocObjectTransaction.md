# AssocObjectTransaction Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocObjectPointer](AcDbAssocObjectPointer.md) template.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocObjectTransaction
```

```text
public class AssocObjectTransaction : IDisposable;
```

### Constructors

- [AssocObjectTransaction(AssocAction)](#assocobjecttransaction(assocaction))
- [AssocObjectTransaction(AssocActionBody)](#assocobjecttransaction(assocactionbody))
- [AssocObjectTransaction(AssocDependency)](#assocobjecttransaction(assocdependency))
- [AssocObjectTransaction(AssocDependencyBody)](#assocobjecttransaction(assocdependencybody))

### Methods

- [GetDBObject](#getdbobject)
- [IsSubstituteObject](#issubstituteobject)


## Constructors Details

### AssocObjectTransaction(AssocAction)

#### Description
Constructor.
```text
public AssocObjectTransaction(
    AssocAction actionBeingEvaluated
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocAction actionBeingEvaluated | The action that is just being evaluated. |

### AssocObjectTransaction(AssocActionBody)

#### Description
Constructor.
```text
public AssocObjectTransaction(
    AssocActionBody actionBodyBeingEvaluated
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocActionBody actionBodyBeingEvaluated | The action that is just being evaluated. |

### AssocObjectTransaction(AssocDependency)

#### Description
Constructor.
```text
public AssocObjectTransaction(
    AssocDependency dependencyBeingEvaluated
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocDependency dependencyBeingEvaluated | The action that is just being evaluated. |

### AssocObjectTransaction(AssocDependencyBody)

#### Description
Constructor.
```text
public AssocObjectTransaction(
    AssocDependencyBody dependencyBodyBeingEvaluated
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocDependencyBody dependencyBodyBeingEvaluated | The action that is just being evaluated. |

### GetDBObject

#### Description
GetDBObject.
```text
public DBObject GetDBObject(
    ObjectId objectId, 
    OpenMode openMode, 
    [MarshalAs(UnmanagedType.U1)] bool openErased, 
    [MarshalAs(UnmanagedType.U1)] bool openOnLockedLayer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId objectId | ObjectId of the object that should be opened. |
| OpenMode openMode | ForRead, ForWrite, ForNotify. |
| [MarshalAs(UnmanagedType.U1)] bool openErased | Opens the object even if it is erased. |
| [MarshalAs(UnmanagedType.U1)] bool openOnLockedLayer | Opens the object even on the locked layer. |

### IsSubstituteObject

#### Description
Indicates whether there is a substitute object.
```text
public bool IsSubstituteObject(
    DBObject dbObject
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DBObject dbObject | Object for which it finds out whether there is a substitute object. |

#### Returns
Returns true if the substitute object exists.