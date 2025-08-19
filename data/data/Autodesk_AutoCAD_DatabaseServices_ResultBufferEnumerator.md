# ResultBufferEnumerator Class

## Overview

#### Description
This enumerator walks the linked list of an underlying resbuf ObjectARX structure.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ResultBufferEnumerator
```

```text
public sealed class ResultBufferEnumerator : IEnumerator;
```

### Methods

- [MoveNext](#movenext)
- [Reset](#reset)

### Properties

- [Current](#current)


## Methods Details

### MoveNext

#### Description
Advances this enumerator to the next node in the ResultBuffer list, or to the first node if the current node is null. Returns false if the pointer advances past the end of the list, or if the list is empty. Otherwise, returns true.
```text
public bool MoveNext();
```

### Reset

#### Description
Sets the current ResultBuffer node to null.
```text
public void Reset();
```

### Current

#### Description
Accesses the current item.
```text
public TypedValue Current;
```

#### Conditions
Read-only