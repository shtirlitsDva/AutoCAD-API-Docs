# PromptForSelectionEndingEventArgs Class

## Overview

#### Description
This class provides data for the PromptForSelectionEnding event of the Editor class.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptForSelectionEndingEventArgs
```

```text
public sealed class PromptForSelectionEndingEventArgs : EventArgs, IDisposable;
```

### Methods

- [Add](#add)
- [AddSubEntity](#addsubentity)
- [Remove](#remove)
- [RemoveSubEntity](#removesubentity)

### Properties

- [Flags](#flags)
- [Selection](#selection)


## Methods Details

### Add

#### Description
Adds entities to the subSelection array.
```text
public void Add(
    SelectedObject value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| SelectedObject value | Input object to be added. |

### AddSubEntity

#### Description
Adds sub entity to the selected subobject.
```text
public void AddSubEntity(
    SelectedSubObject value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| SelectedSubObject value | Input object to be added. |

### Remove

#### Description
Removes the object from the point specified by index.
```text
public void Remove(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index of item to removes |

### RemoveSubEntity

#### Description
Removes subentity from the point specified by entityIndex and subEntityIndex.
```text
public void RemoveSubEntity(
    int entityIndex, 
    int subEntityIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int entityIndex | Input entity index of item to remove |
| int subEntityIndex | Input subEntity index of item to removes |

### Flags

#### Description
Gets extra information about the selection in progress.
```text
public Autodesk.AutoCAD.EditorInput.SelectionFlags Flags;
```

#### Conditions
Read-only
### Selection

#### Description
Gets the SelectionSet that this prompt has obtained.
```text
public SelectionSet Selection;
```

#### Conditions
Read-only