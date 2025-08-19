# AssocManager Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocManager](AcDbAssocManager.md) class. 
This class currently just contains static methods to evaluate the top-level network of a given database and to add/remove global evaluation callbacks. 
There is currently no need to create an object of AssocManager class and add it to the database, but this object is still derived from DBObject, in case in the future there is a need to have a database-resident instance of AssocManager class that might keep additional data.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocManager
```

```text
public class AssocManager : DBObject;
```

### Constructors

- [AssocManager](#assocmanager)

### Methods

- [AddGlobalEvaluationCallback](#addglobalevaluationcallback)
- [AuditAssociativeData](#auditassociativedata)
- [EvaluateTopLevelNetwork](#evaluatetoplevelnetwork)
- [GetGlobalEvaluationCallbacks](#getglobalevaluationcallbacks)
- [GlobalEvaluationMultiCallback](#globalevaluationmulticallback)
- [HasAssocNetwork](#hasassocnetwork)
- [Initialize](#initialize)
- [RemoveGlobalEvaluationCallback](#removeglobalevaluationcallback)


## Constructors Details

### AssocManager

#### Description
Default constructor.
```text
public AssocManager();
```

### AddGlobalEvaluationCallback

#### Description
Adds the given user-provided AssocEvaluationCallback to the global AssocEvaluationMultiCallback.
```text
public static void AddGlobalEvaluationCallback(
    AssocEvaluationCallback callback, 
    int order
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int order | Specifies the ordering of the user-provided callbacks in the global AssocEvaluationMultiCallback. The lower-order callbacks are called before the higher-order callbacks. The drag callback is inserted with order 0, i.e. callbacks with negative order will be called before it and callbacks with positive order will be called after it. |
| pCallback | The user-provided evaluation callback. The callback does not become owned by the global AssocEvaluationMultiCallback, it is just referenced by it. |

### AuditAssociativeData

#### Description
Audits the associative data in the database and tries to fix the errors that might have happened during round-trip, due to lazy-erase, etc.
```text
public static void AuditAssociativeData(
    Database database, 
    [MarshalAs(UnmanagedType.U1)] bool traverseWholeDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database database | Database whose associative data is to be audited. |
| [MarshalAs(UnmanagedType.U1)] bool traverseWholeDatabase | If true, all objects in the database are visited and checked, and therefore loaded into memory. |

### EvaluateTopLevelNetwork

#### Description
Evaluates the top-level AssocNetwork of the given database, using the global evaluation callback. The top-level network owns subnetworks, such as subnetworks owned by the individual BlockTableRecords. Notice that the top-level network owns its subentworks in logical sense, but not necessarily in AutoCAD database ownership sense. See AddAction() and GetInstanceFromObject() methods of AssocNetwork class for more details. 
Evaluating the top-level network evaluates all the subnetworks that need to be evaluated. 
When a sub-network owned by an BlockTableRecord becomes empty, i.e. containing no actions, is is erased at the end of the evaluation of the top-level network. Also, when the top-level network becomes empty, it is erased. When an Assoc2dConstraintGroup becomes empty, i.e. not having any dependencies on Entities, it is erased at the end of its evaluation. 
In most cases the client code does not need to evaluate the top-level network explicitly. It is happening automatically on document lock mode change and also during dragging, on every drag sample.
```text
public static bool EvaluateTopLevelNetwork(
    Database database, 
    AssocEvaluationCallback callback, 
    int callbackOrder
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocEvaluationCallback callback | Optional AssocEvaluationCallback that is added to the global callback before the evaluation and removed after the evaluation is completed. |
| int callbackOrder | Order of the optional AssocEvaluationCallback. |
| patabase | Database whose top-level network is to be evaluated. |

#### Returns
Returns true if any evaluation happened, false otherwise.
### GetGlobalEvaluationCallbacks

#### Description
Returns all evaluation callbacks kept in the global AssocEvaluationMultiCallback.
```text
public static void GetGlobalEvaluationCallbacks(
    ref ArrayList callbacks, 
    ref ArrayList orders
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ref ArrayList callbacks | The returned evaluation callbacks. |
| ref ArrayList orders | The returned evaluation callback orders. |

### GlobalEvaluationMultiCallback

#### Description
Returns the global AssocEvaluationCallback that is used while dragging, when evaluating the top-level associative network on document lock mode change, or anytime AssocManager.EvaluateTopLevelNetwork() is explicitly called by the client code. 
It is actually an object of AssocEvaluationMultiCallback class (this class is currently not exposed, but may be expossed if needed) that keeps a vector of AssocEvaluationCallbacks and sequentially calls all the individual callbacks. The returned AssocEvaluationMultiCallback object must not be modified or deleted by the caller. 
During dragging, the dragging evaluation callback is temporarily inserted into this global multi-callback with order 0 and is removed after the dragging is finished.
```text
public static AssocEvaluationCallback GlobalEvaluationMultiCallback();
```

#### Returns
The global AssocEvaluationMultiCallback object.
### HasAssocNetwork

#### Description
Returns true if the given database has some associative data; in particular, if there is a global AssocNetwork for the whole database. See the related [AssocNetwork.GetInstanceFromDatabase](Autodesk_AutoCAD_DatabaseServices_AssocNetwork_GetInstanceFromDatabase@Database@\[MarshalAsUnmanagedType_U1\]_bool@string.md)() method.
```text
public static bool HasAssocNetwork(
    Database database
);
```

### Initialize

#### Description
This is an internal method that initializes the Associative Framework subsystem. 
It must be called before the subsystem is first used and may safely be called more than once. There is no need for the client code to call this method.
```text
public static void Initialize();
```

### RemoveGlobalEvaluationCallback

#### Description
Removes the given user-provided evaluation callback from the global AssocEvaluationMultiCallback.
```text
public static void RemoveGlobalEvaluationCallback(
    AssocEvaluationCallback callback
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| pCallback | The user-provided evaluation callback to be removed. |
