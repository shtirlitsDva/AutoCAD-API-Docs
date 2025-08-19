# Transaction Class

## Overview

#### Description
This .NET class wraps the AcTransaction ObjectARX class. 
Transactions provide a way to extend the boundary of operation on an object beyond open and close, and avoid those vexing open conflict errors. They also improve performance by being lenient on multiple open requests while postponing all the opened objects close-time work to the end of the transaction.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Transaction
    Autodesk.AutoCAD.DatabaseServices.OpenCloseTransaction
```

```text
public class Transaction : RXObject;
```

### Methods

- [Abort](#abort)
- [AddNewlyCreatedDBObject](#addnewlycreateddbobject)
- [Commit](#commit)
- [GetAllObjects](#getallobjects)
- [GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode)](#getobject(objectid,-autodesk.autocad.databaseservices.openmode))
- [GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode, [MarshalAs(UnmanagedType.U1)] bool)](#getobject(objectid,-autodesk.autocad.databaseservices.openmode,-[marshalas(unmanagedtype.u1)]-bool))
- [GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#getobject(objectid,-autodesk.autocad.databaseservices.openmode,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))

### Properties

- [NumberOfOpenedObjects](#numberofopenedobjects)
- [TransactionManager](#transactionmanager)


## Methods Details

### Abort

#### Description
Aborts the transaction.
```text
public virtual void Abort();
```

### AddNewlyCreatedDBObject

#### Description
obj must point to an object that is newly created (that is, it has never been closed) and is already database resident (that is, it's been added to an Database so it has an objectId). 
If add == true, the object pointed to by obj is added to the top transaction. If add == false, then the object is removed from whatever transaction it's within.
```text
public virtual void AddNewlyCreatedDBObject(
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
This function commits the changes made in all the DBObjects opened during the Transaction, and then closes them.
```text
public virtual void Commit();
```

### GetAllObjects

#### Description
This function returns all the objects currently open in the transaction.
```text
public DBObjectCollection GetAllObjects();
```

### GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode)

#### Description
This function calls the Open() function of the top transaction passing on all the arguments it has received. Objects can only be obtained within the top transaction, so this function saves the trouble of having to either keep a pointer to the top transaction or use the TransactionManager.TopTransaction property to obtain it. 
For more information, see the section on transactions in the _ObjectARX Developer's Guide_.
```text
public virtual DBObject GetObject(
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
public virtual DBObject GetObject(
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
public virtual DBObject GetObject(
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

### NumberOfOpenedObjects

#### Description
Returns the number of objects opened by the transaction.
```text
public virtual int NumberOfOpenedObjects;
```

#### Conditions
Read-only
### TransactionManager

#### Description
Accesses the associated transaction manager.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.TransactionManager TransactionManager;
```

#### Conditions
Read-only