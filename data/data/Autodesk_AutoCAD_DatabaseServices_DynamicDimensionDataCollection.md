# DynamicDimensionDataCollection Class

## Overview

#### Description
This class represents a collection of DynamicDimenionData objects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DynamicDimensionDataCollection
```

```text
public sealed class DynamicDimensionDataCollection : DisposableWrapper, ICollection;
```

### Methods

- [Add](#add)
- [Clear](#clear)
- [CopyTo](#copyto)
- [DeleteUnmanagedObject](#deleteunmanagedobject)
- [GetEnumerator](#getenumerator)
- [RemoveAt](#removeat)

### Properties

- [Count](#count)


## Methods Details

### Add

#### Description
Adds a new DynamicDimensionData object to the collection. 
Returns the position of the newly created item in the collection.
```text
public int Add(
    DynamicDimensionData data
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DynamicDimensionData data | A DynamicDimensionData object to add. |

### Clear

#### Description
Clears the collection.
```text
public void Clear();
```

### CopyTo

#### Description
Copies the element in array starting from index into the collection.
```text
public void CopyTo(
    DynamicDimensionData\[\] array, 
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DynamicDimensionData[] array | Array to copy from |
| int index | Zero-based index to begin at |

### DeleteUnmanagedObject

#### Description
Deletes the unmanaged object.
```text
protected sealed override void DeleteUnmanagedObject();
```

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public IEnumerator GetEnumerator();
```

### RemoveAt

#### Description
Removes the item at position i from the collection.
```text
public void RemoveAt(
    int i
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int i | The position of the item to be removed. |

### Count

#### Description
Accesses the number of elements in the count.
```text
public virtual int Count;
```

#### Conditions
Read-only