# XrecordEnumerator Class

## Overview

#### Description
This is class Autodesk.AutoCAD.DatabaseServices.XrecordEnumerator.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.XrecordEnumerator
```

```text
public sealed class XrecordEnumerator : RXObject, IEnumerator<TypedValue>;
```

### Methods

- [InsertAtCurrent](#insertatcurrent)
- [MoveNext](#movenext)
- [RemoveCurrent](#removecurrent)
- [Reset](#reset)

### Properties

- [Current](#current)
- [CurrentTypeCode](#currenttypecode)
- [IEnumeratorCurrent](#ienumeratorcurrent)


## Methods Details

### InsertAtCurrent

#### Description
Allows callers to insert one or more resbufs into the AcDbXrecord without having to get/set the whole chain. More efficient in terms of amount of data that needs to be copied and also does partial undo. After calling insertRbChain, AcDbXrecordIterator::getCurResbuf will return the first item inserted.
```text
public void InsertAtCurrent(
    ResultBuffer data
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ResultBuffer data | Input first result buffer (not its address) in a linked list of result buffer that contain the data for the xrecord. |

### MoveNext

#### Description
This is MoveNext, a member of class XrecordEnumerator.
```text
public bool MoveNext();
```

### RemoveCurrent

#### Description
Allows callers to delete an item from the AcDbXrecord without having to get/set the whole chain. More efficient in terms of amount of data that needs to be copied and also does partial undo. After calling removeResbuf, AcDbXrecordIterator::getCurResbuf will return the first item after the deleted item. You must call AcDbXrecordIterator::done() to determine if the last item was removed.
```text
public void RemoveCurrent();
```

### Reset

#### Description
This is Reset, a member of class XrecordEnumerator.
```text
public void Reset();
```

### Current

#### Description
Allows callers to modify the resbuf chain inside the AcDbXrecord without having to get/set the whole chain. More efficient in terms of amount of data that needs to be copied and also does partial undo. After calling modifyCurResbuf, AcDbXrecordIterator::getCurResbuf will return the new value.
```text
public TypedValue Current;
```

#### Conditions
Read / Write
### CurrentTypeCode

#### Description
This is CurrentTypeCode, a member of class XrecordEnumerator.
```text
public short CurrentTypeCode;
```

### IEnumeratorCurrent

#### Description
This is IEnumeratorCurrent, a member of class XrecordEnumerator.
```text
public virtual object IEnumeratorCurrent;
```
