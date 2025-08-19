# SelectionRemovedEventArgs Class

## Overview

#### Description
This class provides data for the SelectionRemoved event of the Editor class.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectionRemovedEventArgs
```

```text
public sealed class SelectionRemovedEventArgs : EventArgs, IDisposable;
```

### Methods

- [Remove](#remove)
- [RemoveSubentity](#removesubentity)

### Properties

- [Flags](#flags)
- [RemovedObjects](#removedobjects)
- [Selection](#selection)


## Methods Details

### Remove

#### Description
Removes the object at the specified index from the selection.
```text
public void Remove(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index of object to remove |

### RemoveSubentity

#### Description
Removes the subentity at subentityIndex, in the entity at the specified index, from this selection.
```text
public void RemoveSubentity(
    int index, 
    int subentityIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index of object to remove |
| int subentityIndex | Input subentity index |

### Flags

#### Description
Gets the flags that provide further details about the selection in progress.
```text
public Autodesk.AutoCAD.EditorInput.SelectionFlags Flags;
```

#### Conditions
Read-only
### RemovedObjects

#### Description
The objects removed from the selection set.
```text
public SelectionSet RemovedObjects;
```

#### Conditions
Read-only
### Selection

#### Description
Gets the objects currently selected.
```text
public SelectionSet Selection;
```

#### Conditions
Read-only