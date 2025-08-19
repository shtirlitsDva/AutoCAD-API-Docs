# PromptDragOptions Class

## Overview

#### Description
This class lets applications define custom options to be displayed at the command line before a dragging operation.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
        Autodesk.AutoCAD.EditorInput.PromptDragOptions
```

```text
public sealed class PromptDragOptions : PromptEditorOptions;
```

### Constructors

- [PromptDragOptions(SelectionSet, string, DragCallback)](#promptdragoptions(selectionset,-string,-dragcallback))
- [PromptDragOptions(SelectionSet, string, string, DragCallback)](#promptdragoptions(selectionset,-string,-string,-dragcallback))

### Properties

- [AllowArbitraryInput](#allowarbitraryinput)
- [AllowNone](#allownone)
- [Callback](#callback)
- [Cursor](#cursor)
- [Selection](#selection)


## Constructors Details

### PromptDragOptions(SelectionSet, string, DragCallback)

#### Description
Constructor.
```text
public PromptDragOptions(
    SelectionSet selection, 
    string message, 
    DragCallback callback
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SelectionSet selection | Input selection set |
| string message | Input prompt message |
| DragCallback callback | Input drag callback |

### PromptDragOptions(SelectionSet, string, string, DragCallback)

#### Description
Constructor.
```text
public PromptDragOptions(
    SelectionSet selection, 
    string messageAndKeywords, 
    string globalKeywords, 
    DragCallback callback
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SelectionSet selection | Input selection set |
| string messageAndKeywords | Input message and keywords |
| string globalKeywords | Input global keywords |
| DragCallback callback | Input drag callback |

### AllowArbitraryInput

#### Description
Gets or sets whether the prompts accepts arbitrary input.
```text
public bool AllowArbitraryInput;
```

#### Conditions
Read / Write
### AllowNone

#### Description
Gets or sets whether the prompt accepts ENTER as sole input.
```text
public bool AllowNone;
```

#### Conditions
Read / Write
### Callback

#### Description
Returns the callback property for the prompt option.
```text
public DragCallback Callback;
```

#### Conditions
Read / Write
### Cursor

#### Description
Returns the cursor type used while dragging.
```text
public DragCursor Cursor;
```

#### Conditions
Read / Write
### Selection

#### Description
Returns the selection from the SelectionSet selected by the user.
```text
public SelectionSet Selection;
```

#### Conditions
Read / Write