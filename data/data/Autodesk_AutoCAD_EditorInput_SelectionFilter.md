# SelectionFilter Class

## Overview

#### Description
This class describes the kind of filtering to be applied to the object during a selection prompt.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectionFilter
```

```text
public sealed class SelectionFilter;
```

### Constructors

- [SelectionFilter](#selectionfilter)

### Methods

- [GetFilter](#getfilter)


## Constructors Details

### SelectionFilter

#### Description
Constructor.
```text
public SelectionFilter(
    TypedValue\[\] value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| TypedValue[] value | Input Autodesk.AutoCAD.DatabaseServices.TypedValue[] object. |

### GetFilter

#### Description
Returns an array of TypeValues that contains the filtering instructions.
```text
public TypedValue\[\] GetFilter();
```
