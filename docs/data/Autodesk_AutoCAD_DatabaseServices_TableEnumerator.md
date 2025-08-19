# TableEnumerator Class

## Overview

#### Description
This .NET class wraps the AcDbTableIterator ObjectARX class. It creates an iterator to traverse table rows, columns, and cells.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.TableEnumerator
```

```text
public sealed class TableEnumerator : DisposableWrapper, IEnumerator;
```

### Methods

- [MoveNext](#movenext)
- [Reset](#reset)

### Properties

- [Current](#current)


## Methods Details

### MoveNext

#### Description
Returns true if the target moves to next row, column or cell.
```text
public bool MoveNext();
```

### Reset

#### Description
Resets the current target row, column or cell.
```text
public void Reset();
```

### Current

#### Description
Input cell at which to position the iterator. This should specify a cell, row, or column depending on what is being iterated.
```text
public Cell Current;
```

#### Conditions
Read-only