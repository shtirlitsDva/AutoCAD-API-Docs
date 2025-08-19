# UnderlayLayerCollection Class

## Overview

#### Description
This class provides a collection for UnderlayLayer objects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.UnderlayLayerCollection
```

```text
public sealed class UnderlayLayerCollection : ICollection, IEnumerable;
```

### Methods

- [CopyTo](#copyto)
- [GetEnumerator](#getenumerator)

### Properties

- [Count](#count)


## Methods Details

### CopyTo

#### Description
Copies the underlay layers to the collection from the specified index.
```text
public void CopyTo(
    UnderlayLayer\[\] array, 
    int index
);
```

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public IEnumerator GetEnumerator();
```

### Count

#### Description
Returns the number of layers in the collection.
```text
public int Count;
```

#### Conditions
Read-only