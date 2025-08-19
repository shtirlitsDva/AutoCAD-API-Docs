# SelectionSet Class

## Overview

#### Description
This class is a collection of objects typically selected by the user.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectionSet
```

```text
public abstract class SelectionSet : ICollection, IDisposable;
```

### Constructors

- [SelectionSet](#selectionset)

### Methods

- [CopyTo](#copyto)
- [FromObjectIds](#fromobjectids)
- [GetEnumerator](#getenumerator)
- [GetObjectIds](#getobjectids)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [Count](#count)
- [IsSynchronized](#issynchronized)
- [SyncRoot](#syncroot)


## Constructors Details

### SelectionSet

#### Description
Constructor.
#### Parameters

| Parameters | Description |
| --- | --- |
| AdsName ss | Input adsname that represents the selection set to use |

Previous Declaration
```text
AutoCAD 2024 and earlier
protected SelectionSet();
```

### CopyTo

#### Description
Copies the SelectionSet or a portion of it to a one-dimensional array.
```text
public void CopyTo(
    SelectedObject\[\] array, 
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| SelectedObject[] array | Input the one-dimensional array that is the destination of the elements copied from SelectionSet. The array must have zero-based indexing |
| int index | Input the zero-based index in array at which copying begins. |

### FromObjectIds

#### Description
Creates a new selection set using the object IDs in ids.
```text
public static SelectionSet FromObjectIds(
    ObjectId\[\] ids
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId[] ids | Input array of IDs to copy |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public abstract IEnumerator GetEnumerator();
```

### GetObjectIds

#### Description
Gets an array of object IDs representing the selected objects.
```text
public abstract ObjectId\[\] GetObjectIds();
```

### ToString()

#### Description
Returns an equivalent string representation of this object.
```text
public override string ToString();
```

### ToString(IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider.
```text
public string ToString(
    IFormatProvider provider
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IFormatProvider provider | Input for culture-specific format |

### Count

#### Description
Gets the number of elements actually contained in the SelectionSet.
```text
public abstract int Count;
```

#### Conditions
Read-only
### IsSynchronized

#### Description
Assesses if the selection set is synchronized.
```text
public virtual bool IsSynchronized;
```

#### Conditions
Read-only
### SyncRoot

#### Description
Accesses the synchronized root.
```text
public virtual object SyncRoot;
```

#### Conditions
Read / Write