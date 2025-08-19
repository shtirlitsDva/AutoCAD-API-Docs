# OpenCloseTransaction Class

## Overview

#### Description
This class may be used instead of the transaction class in certain scenarios.. It wraps the ObjectId.Open/Close functions, but makes it easier to correctly pair these functions by storing references to every object opened and automatically closing them.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Transaction
    Autodesk.AutoCAD.DatabaseServices.OpenCloseTransaction
```

```text
public class OpenCloseTransaction : Transaction;
```

#### See Also
Transaction

## Members

### Methods

- [Abort](#abort)
- [AddNewlyCreatedDBObject](#addnewlycreateddbobject)
- [Commit](#commit)
- [GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode)](#getobject(objectid,-autodesk.autocad.databaseservices.openmode))
- [GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode, [MarshalAs(UnmanagedType.U1)] bool)](#getobject(objectid,-autodesk.autocad.databaseservices.openmode,-[marshalas(unmanagedtype.u1)]-bool))
- [GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#getobject(objectid,-autodesk.autocad.databaseservices.openmode,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))

### Properties

- [TransactionManager](#transactionmanager)


## Methods Details

### Abort

#### Description
Cancels the changes made in all the DBObject opened during the OpenCloseTransaction.
```text
public override void Abort();
```

### AddNewlyCreatedDBObject

#### Description
obj must point to an object that is newly created (that is, it has never been closed) and is already database resident (that is, it's been added to an Database so it has an objectId). 
If add == true, the object pointed to by obj is added to the top transaction. If add == false, then the object is removed from whatever transaction it's within.
```text
public override void AddNewlyCreatedDBObject(
    DBObject obj, 
    [MarshalAs(UnmanagedType.U1)] bool add
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DBObject obj | Input object to be added or removed |
| [MarshalAs(UnmanagedType.U1)] bool add | Input Boolean indicating whether to add or remove the object |

### Commit

#### Description
This function commits the changes made in all the DBObjects opened during the OpenCloseTransaction, and then closes them.
```text
public override void Commit();
```

### GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode)

#### Description
This function calls the Open() function of the top transaction passing on all the arguments it has received. Objects can only be obtained within the top transaction, so this function saves the trouble of having to either keep a pointer to the top transaction or use the TransactionManager.TopTransaction property to obtain it. 
For more information, see the section on transactions in the _ObjectARX Developer's Guide_.
```text
public override DBObject GetObject(
    ObjectId id, 
    Autodesk.AutoCAD.DatabaseServices.OpenMode mode
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input objectId of object to obtain |
| Autodesk.AutoCAD.DatabaseServices.OpenMode mode | Input mode to obtain in |

### GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This function calls the Open() function of the top transaction passing on all the arguments it has received. Objects can only be obtained within the top transaction, so this function saves the trouble of having to either keep a pointer to the top transaction or use the TransactionManager.TopTransaction property to obtain it. 
If the openErased Boolean is true, then even an erased object can be obtained. If openErased is false, then trying to obtain an erased entity results in an error return value. 
For more information, see the section on transactions in the _ObjectARX Developer's Guide_.
```text
public override DBObject GetObject(
    ObjectId id, 
    Autodesk.AutoCAD.DatabaseServices.OpenMode mode, 
    [MarshalAs(UnmanagedType.U1)] bool openErased
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input objectId of object to obtain |
| Autodesk.AutoCAD.DatabaseServices.OpenMode mode | Input mode to obtain in |
| [MarshalAs(UnmanagedType.U1)] bool openErased | Input Boolean indicating whether to obtain erased objects |

### GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This function calls the Open() function of the top transaction passing on all the arguments it has received. Objects can only be obtained within the top transaction, so this function saves the trouble of having to either keep a pointer to the top transaction or use the TransactionManager.TopTransaction property to obtain it. 
If the openErased Boolean is true, then even an erased object can be obtained. If openErased is false, then trying to obtain an erased entity results in an error return value. 
For more information, see the section on transactions in the _ObjectARX Developer's Guide_.
```text
public override DBObject GetObject(
    ObjectId id, 
    Autodesk.AutoCAD.DatabaseServices.OpenMode mode, 
    [MarshalAs(UnmanagedType.U1)] bool openErased, 
    [MarshalAs(UnmanagedType.U1)] bool forceOpenOnLockedLayer
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input objectId of object to obtain |
| Autodesk.AutoCAD.DatabaseServices.OpenMode mode | Input mode to obtain in |
| [MarshalAs(UnmanagedType.U1)] bool openErased | Input Boolean indicating whether to obtain erased objects |
| [MarshalAs(UnmanagedType.U1)] bool forceOpenOnLockedLayer | Input true if locked layers should be opened |

### TransactionManager

#### Description
Accesses the associated transaction manager.
```text
public override Autodesk.AutoCAD.DatabaseServices.TransactionManager TransactionManager;
```

#### Conditions
Read-only