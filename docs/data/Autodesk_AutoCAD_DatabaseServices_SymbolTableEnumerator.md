# SymbolTableEnumerator Class

## Overview

#### Description
This .NET class wraps the AcDbSymbolTableIterator ObjectARX class. This class is a base class for iterator classes that are used for iterating over the records in the SymbolTable objects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.SymbolTableEnumerator
```

```text
public class SymbolTableEnumerator : DisposableWrapper, IEnumerator;
```

### Methods

- [MoveNext](#movenext)
- [Reset](#reset)

### Properties

- [Current](#current)


## Methods Details

### MoveNext

#### Description
Increments the enumerator to the next entry.
```text
public virtual bool MoveNext();
```

### Reset

#### Description
Resets the enumerator.
```text
public virtual void Reset();
```

### Current

#### Description
Returns the objectId of the current symbol table entry.
```text
public ObjectId Current;
```

#### Conditions
Read-only