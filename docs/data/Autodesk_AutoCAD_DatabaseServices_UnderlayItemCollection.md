# UnderlayItemCollection Class

## Overview

#### Description
This class provides a collection for UnderlayItem objects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.UnderlayItemCollection
```

```text
public sealed class UnderlayItemCollection : ICollection;
```

### Methods

- [CopyTo](#copyto)
- [GetEnumerator](#getenumerator)

### Properties

- [Count](#count)


## Methods Details

### CopyTo

#### Description
Copies the underlay items to the collection from the specified index.
```text
public void CopyTo(
    UnderlayItem\[\] array, 
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| UnderlayItem[] array | Input array to copy to |
| int index | Input index to begin copying from |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public IEnumerator GetEnumerator();
```

### Count

#### Description
Returns the number of items in the collection.
```text
public int Count;
```

#### Conditions
Read-only