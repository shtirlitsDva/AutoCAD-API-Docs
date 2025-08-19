# DynamicBlockReferencePropertyCollectionEnumerator Class

## Overview

#### Description
This class enumerates the properties in a DynamicBlockReferencePropertyCollection.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DynamicBlockReferencePropertyCollectionEnumerator
```

```text
public sealed class DynamicBlockReferencePropertyCollectionEnumerator : IEnumerator;
```

### Methods

- [MoveNext](#movenext)
- [Reset](#reset)

### Properties

- [Current](#current)


## Methods Details

### MoveNext

#### Description
This method moves the current pointer to the next item, or to the end marker if the current item is at the end of the collection.
```text
public bool MoveNext();
```

### Reset

#### Description
This method resets the current pointer to the first item in the collection.
```text
public void Reset();
```

### Current

#### Description
Accesses the current item.
```text
public virtual object Current;
```

#### Conditions
Read-only