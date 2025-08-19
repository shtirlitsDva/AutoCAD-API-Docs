# DynamicBlockReferencePropertyCollection Class

## Overview

#### Description
This class provides a container for Autodesk.AutoCAD.DatabaseServices.DynamicBlockReferenceProperty objects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DynamicBlockReferencePropertyCollection
```

```text
public sealed class DynamicBlockReferencePropertyCollection : DisposableWrapper, ICollection, IEnumerable;
```

### Methods

- [CopyTo](#copyto)
- [GetEnumerator](#getenumerator)

### Properties

- [Count](#count)


## Methods Details

### CopyTo

#### Description
Copies objects in array to this collection, starting from index.
```text
public void CopyTo(
    DynamicBlockReferenceProperty\[\] array, 
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DynamicBlockReferenceProperty[] array | Input array to copy from |
| int index | Input zero-based index to start at |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public IEnumerator GetEnumerator();
```

### Count

#### Description
Accesses the number of objects in this collection.
```text
public virtual int Count;
```

#### Conditions
Read-only