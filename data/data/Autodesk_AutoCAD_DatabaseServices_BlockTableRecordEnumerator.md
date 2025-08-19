# BlockTableRecordEnumerator Class

## Overview

#### Description
This .NET class wraps the AcDbBlockTableRecordIterator ObjectARX class. 
That iterator is used to iterate through an BlockTableRecord.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.BlockTableRecordEnumerator
```

```text
public sealed class BlockTableRecordEnumerator : DisposableWrapper, IEnumerator;
```

### Methods

- [MoveNext](#movenext)


## Methods Details

### MoveNext

#### Description
This function returns true if the enumerator has been positioned past either end of the block.
```text
public bool MoveNext();
```
