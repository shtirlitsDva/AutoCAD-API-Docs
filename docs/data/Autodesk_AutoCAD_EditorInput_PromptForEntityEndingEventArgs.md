# PromptForEntityEndingEventArgs Class

## Overview

#### Description
This class provides data for the PromptForEntityEnding event of the Editor class.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptForEntityEndingEventArgs
```

```text
public sealed class PromptForEntityEndingEventArgs : EventArgs, IDisposable;
```

### Methods

- [RemoveSelectedObject](#removeselectedobject)
- [ReplaceSelectedObject](#replaceselectedobject)

### Properties

- [Result](#result)


## Methods Details

### RemoveSelectedObject

#### Description
Removes the selected object based on prompt selection.
```text
public void RemoveSelectedObject();
```

### ReplaceSelectedObject

#### Description
Replaces the selected object with newValue.
```text
public void ReplaceSelectedObject(
    SelectedObject newValue
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| SelectedObject newValue | Input new value |

### Result

#### Description
The result of the prompt operation.
```text
public PromptEntityResult Result;
```

#### Conditions
Read-only