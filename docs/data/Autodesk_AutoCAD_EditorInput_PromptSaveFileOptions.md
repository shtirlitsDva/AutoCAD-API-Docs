# PromptSaveFileOptions Class

## Overview

#### Description
This class contains file dialog configuration options that are passed to the Editor.GetFileNameForSave() method.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptFileOptions
    Autodesk.AutoCAD.EditorInput.PromptSaveFileOptions
```

```text
public sealed class PromptSaveFileOptions : PromptFileOptions;
```

### Constructors

- [PromptSaveFileOptions](#promptsavefileoptions)

### Properties

- [DeriveInitialFilenameFromDrawingName](#deriveinitialfilenamefromdrawingname)
- [DisplaySaveOptionsMenuItem](#displaysaveoptionsmenuitem)
- [ForceOverwriteWarningForScriptsAndLisp](#forceoverwritewarningforscriptsandlisp)


## Constructors Details

### PromptSaveFileOptions

#### Description
Constructor.
```text
public PromptSaveFileOptions(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### DeriveInitialFilenameFromDrawingName

#### Description
Accesses if the derivation of the initial filename is is from the drawing name.
```text
public bool DeriveInitialFilenameFromDrawingName;
```

#### Conditions
Read / Write
#### Notes
This property only has an impact when a default file name is not provided functions that reportedly uses this property (it is difficult to discern which properties are supported by which functions). When a default file name is not provided, use this property to leave the default name blank in the dialog. Leave out the property, and a default name is generated and displayed in the dialog, based on the current drawing name.
### DisplaySaveOptionsMenuItem

#### Description
Assesses if the save options ought to be displayed from a menu item.
```text
public bool DisplaySaveOptionsMenuItem;
```

#### Conditions
Read / Write
#### Notes
This property does not ensure any options will be available, just that the menu entry will not be hidden.
### ForceOverwriteWarningForScriptsAndLisp

#### Description
Accesses if the overwrite warning prompt ought to be displayed, even when the command is run from LISP or a script. Otherwise, overwrite warning prompts are generally suppressed under these conditions
```text
public bool ForceOverwriteWarningForScriptsAndLisp;
```

#### Conditions
Read / Write