# PromptSelectionOptionsEventArgs Class

## Overview

#### Description
This class provides data for the PromptingForSelection event of the Editor class.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptSelectionOptionsEventArgs
```

```text
public sealed class PromptSelectionOptionsEventArgs : EventArgs;
```

### Methods

- [GetPoints](#getpoints)

### Properties

- [Filter](#filter)
- [Options](#options)


## Methods Details

### GetPoints

#### Description
Gets the array of points associated with this selection operation.
```text
public Point3d\[\] GetPoints();
```

### Filter

#### Description
Gets the filer that is used with this selection.
```text
public SelectionFilter Filter;
```

#### Conditions
Read-only
### Options

#### Description
Gets the input parameters of the prompt.
```text
public PromptSelectionOptions Options;
```

#### Conditions
Read-only