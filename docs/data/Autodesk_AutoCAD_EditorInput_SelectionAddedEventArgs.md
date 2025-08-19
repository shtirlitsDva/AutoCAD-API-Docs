# SelectionAddedEventArgs Class

## Overview

#### Description
This class provides data for the SelectionAdded event of the Editor class.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectionAddedEventArgs
```

```text
public sealed class SelectionAddedEventArgs : EventArgs, IDisposable;
```

### Methods

- [Add](#add)
- [AddSubEntity](#addsubentity)
- [Highlight](#highlight)
- [Remove](#remove)
- [RemoveSubEntity](#removesubentity)

### Properties

- [AddedObjects](#addedobjects)
- [Flags](#flags)
- [Selection](#selection)


## Methods Details

### Add

#### Description
To add entities to the sub SelectionSet and final SelectionSet array.
```text
public void Add(
    SelectedObject value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SelectedObject value | Input value to add |

### AddSubEntity

#### Description
Adds the sub entity to the selected subobject.
```text
public void AddSubEntity(
    SelectedSubObject value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SelectedSubObject value | Input subentity to add |

### Highlight

#### Description
Highlights the selection based on the subSelectionIndex value and the full sub entity path.
```text
public void Highlight(
    int subSelectionIndex, 
    FullSubentityPath path
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int subSelectionIndex | Input subselection index |
| FullSubentityPath path | Input path to highlight |

### Remove

#### Description
Removes the object from the index value specified.
```text
public void Remove(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index of object to remove |

### RemoveSubEntity

#### Description
Removes the sub entity based on the specified entityIndex and subEntityIndex.
```text
public void RemoveSubEntity(
    int entityIndex, 
    int subEntityIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int entityIndex | Input entity index |
| int subEntityIndex | Input subentity index |

### AddedObjects

#### Description
The objects added to the selection set.
```text
public SelectionSet AddedObjects;
```

#### Conditions
Read-only
### Flags

#### Description
Gets the flags that provide further details about the selection in progress.
```text
public Autodesk.AutoCAD.EditorInput.SelectionFlags Flags;
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
Read-only