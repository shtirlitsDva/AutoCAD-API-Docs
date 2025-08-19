# LongTransaction Class

## Overview

#### Description
This wraps the ObjectARX [AcDbLongTransaction](AcDbLongTransaction.md) class
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.LongTransaction
```

```text
public sealed class LongTransaction : DBObject;
```

### Constructors

- [LongTransaction](#longtransaction)

### Methods

- [AddToWorkSet](#addtoworkset)
- [OriginObject](#originobject)
- [RegenWorkSetWithDrawOrder](#regenworksetwithdraworder)
- [RemoveFromWorkSet](#removefromworkset)
- [SyncWorkSet](#syncworkset)
- [WorkSetHas](#worksethas)

### Properties

- [ActiveIdMap](#activeidmap)
- [DestinationBlock](#destinationblock)
- [DisallowDrawOrder](#disallowdraworder)
- [LongTransactionName](#longtransactionname)
- [OriginBlock](#originblock)
- [Type](#type)


## Constructors Details

### LongTransaction

#### Description
Constructor.
```text
public LongTransaction(
    IntPtr unmanagedPointer, 
    [MarshalAs(UnmanagedType.U1)] bool autoDelete
);
```

### AddToWorkSet

#### Description
This wraps the ObjectARX [AcDbLongTransaction::addToWorkSet](AcDbLongTransaction__addToWorkSet@AcDbObjectId.md)() method.
```text
public void AddToWorkSet(
    ObjectId id
);
```

### OriginObject

#### Description
This wraps the ObjectARX [AcDbLongTransaction::originObject](AcDbLongTransaction__originObject@AcDbObjectId@const.md)() method.
```text
public ObjectId OriginObject(
    ObjectId id
);
```

### RegenWorkSetWithDrawOrder

#### Description
This wraps the ObjectARX [AcDbLongTransaction::regenWorkSetWithDrawOrder](AcDbLongTransaction__regenWorkSetWithDrawOrder.md)() method.
```text
public void RegenWorkSetWithDrawOrder();
```

### RemoveFromWorkSet

#### Description
This wraps the ObjectARX [AcDbLongTransaction::removeFromWorkSet](AcDbLongTransaction__removeFromWorkSet@AcDbObjectId.md)() method.
```text
public void RemoveFromWorkSet(
    ObjectId id
);
```

### SyncWorkSet

#### Description
This wraps the ObjectARX [AcDbLongTransaction::syncWorkSet](AcDbLongTransaction__syncWorkSet.md)() method.
```text
public void SyncWorkSet();
```

### WorkSetHas

#### Description
This wraps the ObjectARX [AcDbLongTransaction::workSetHas](AcDbLongTransaction__workSetHas@AcDbObjectId@bool@const.md)() method.
```text
public bool WorkSetHas(
    ObjectId id, 
    [MarshalAs(UnmanagedType.U1)] bool includeErased
);
```

### ActiveIdMap

#### Description
This wraps the ObjectARX [AcDbLongTransaction::activeIdMap](AcDbLongTransaction__activeIdMap.md)() method.
```text
public IdMapping ActiveIdMap;
```

### DestinationBlock

#### Description
This wraps the ObjectARX [AcDbLongTransaction::destinationBlock](AcDbLongTransaction__destinationBlock.md)() method.
```text
public ObjectId DestinationBlock;
```

### DisallowDrawOrder

#### Description
This wraps the ObjectARX [AcDbLongTransaction::disallowDrawOrder](AcDbLongTransaction__disallowDrawOrder.md)() method.
```text
public bool DisallowDrawOrder;
```

### LongTransactionName

#### Description
This wraps the ObjectARX [AcDbLongTransaction::getLongTransactionName](AcDbLongTransaction__getLongTransactionName@ACHAR__@const.md)() method.
```text
public string LongTransactionName;
```

### OriginBlock

#### Description
This wraps the ObjectARX [AcDbLongTransaction::originBlock](AcDbLongTransaction__originBlock.md)() method.
```text
public ObjectId OriginBlock;
```

### Type

#### Description
This wraps the ObjectARX [AcDbLongTransaction::type](AcDbLongTransaction__type.md)() method.
```text
public LongTransactionType Type;
```
