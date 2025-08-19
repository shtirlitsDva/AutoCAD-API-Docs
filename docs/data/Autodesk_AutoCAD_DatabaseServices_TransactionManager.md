# TransactionManager Class

## Overview

#### Description
This .NET class wraps the AcDbTransactionManager ObjectARX class. 
There is a single object of class TransactionManager created by the ObjectARX system when AutoCAD first starts up. This TransactionManager object is globally available to all ObjectARX applications. 
The system TransactionManager object is used to start, end, or terminate transactions. In addition, it provides functionality to manage transactions and the objects within them. 
For more information on the transaction mechanism, see the transaction section in the _ObjectARX Developer's Guide_.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.TransactionManager
```

```text
public class TransactionManager : RXObject;
```

### Methods

- [AddNewlyCreatedDBObject](#addnewlycreateddbobject)
- [GetAllObjects](#getallobjects)
- [GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode)](#getobject(objectid,-autodesk.autocad.databaseservices.openmode))
- [GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode, [MarshalAs(UnmanagedType.U1)] bool)](#getobject(objectid,-autodesk.autocad.databaseservices.openmode,-[marshalas(unmanagedtype.u1)]-bool))
- [GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#getobject(objectid,-autodesk.autocad.databaseservices.openmode,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [QueueForGraphicsFlush](#queueforgraphicsflush)
- [StartOpenCloseTransaction](#startopenclosetransaction)
- [StartTransaction](#starttransaction)

### Properties

- [NumberOfActiveTransactions](#numberofactivetransactions)
- [NumberOfOpenedObjects](#numberofopenedobjects)
- [TopTransaction](#toptransaction)


## Methods Details

### AddNewlyCreatedDBObject

#### Description
This method wraps the AcDbTransactionManager::addNewlyCreatedDBRObject ObjectARX function. 
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

### GetAllObjects

#### Description
Searches all currently existing transaction objects and returns an objects collection with pointers to all objects it finds.
```text
public virtual DBObjectCollection GetAllObjects();
```

### GetObject(ObjectId, Autodesk.AutoCAD.DatabaseServices.OpenMode)

#### Description
This function calls the GetObject() function of the top transaction passing on all the arguments it has received. Objects can only be obtained within the top transaction, so this function saves the trouble of having to either keep a pointer to the top transaction or use the TransactionManager.TopTransaction property to obtain it. 
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
This function calls the GetObject() function of the top transaction passing on all the arguments it has received. Objects can only be obtained within the top transaction, so this function saves the trouble of having to either keep a pointer to the top transaction or use the TransactionManager.TopTransaction property to obtain it. 
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
This function calls the GetObject() function of the top transaction passing on all the arguments it has received. Objects can only be obtained within the top transaction, so this function saves the trouble of having to either keep a pointer to the top transaction or use the TransactionManager.TopTransaction property to obtain it. 
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

### QueueForGraphicsFlush

#### Description
Queues up the graphics changes of all transaction-resident modified entities from any existing transaction.
```text
public virtual void QueueForGraphicsFlush();
```

### StartOpenCloseTransaction

#### Description
This method instantiates, initializes, and returns an OpenCloseTransaction object.
```text
public virtual OpenCloseTransaction StartOpenCloseTransaction();
```

### StartTransaction

#### Description
Begins a new transaction.
```text
public virtual Transaction StartTransaction();
```

### NumberOfActiveTransactions

#### Description
Returns the number of active transactions.
```text
public virtual int NumberOfActiveTransactions;
```

#### Conditions
Read-only
### NumberOfOpenedObjects

#### Description
Returns the number of objects opened by all transactions.
```text
public virtual int NumberOfOpenedObjects;
```

#### Conditions
Read-only
### TopTransaction

#### Description
Accesses the the Transaction object that is at the top of the transaction stack (that is, the most recently created Transaction object). This can be compared to a cached Transaction to determine if the cached object is the top (that is, "current") transaction, or it can be used to access the two member functions of that transaction object. However, because there are member functions in the TransactionManager class that provide direct access to the two member functions in the top transaction, there's no need to use TopTransaction for this purpose
```text
public virtual Transaction TopTransaction;
```

#### Conditions
Read-only