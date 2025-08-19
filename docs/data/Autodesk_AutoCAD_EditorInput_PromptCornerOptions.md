# PromptCornerOptions Class

## Overview

#### Description
This class represents optional parameters for a corner prompt.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
        Autodesk.AutoCAD.EditorInput.PromptCornerOptions
            Autodesk.AutoCAD.EditorInput.PromptPointOptions
```

```text
public class PromptCornerOptions : PromptEditorOptions;
```

### Constructors

- [PromptCornerOptions(string, Point3d)](#promptcorneroptions(string,-point3d))
- [PromptCornerOptions(string, string, Point3d)](#promptcorneroptions(string,-string,-point3d))

### Properties

- [AllowArbitraryInput](#allowarbitraryinput)
- [AllowNone](#allownone)
- [BasePoint](#basepoint)
- [LimitsChecked](#limitschecked)
- [UseDashedLine](#usedashedline)


## Constructors Details

### PromptCornerOptions(string, Point3d)

#### Description
Constructor.
```text
public PromptCornerOptions(
    string message, 
    Point3d basePoint
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |
| Point3d basePoint | Input base point |

### PromptCornerOptions(string, string, Point3d)

#### Description
Constructor.
```text
public PromptCornerOptions(
    string messageAndKeywords, 
    string globalKeywords, 
    Point3d basePoint
);
```

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
### BasePoint

#### Description
Gets or sets the base point to be used by the prompt.
```text
public Point3d BasePoint;
```

#### Conditions
Read / Write
### LimitsChecked

#### Description
Gets or sets whether limits checks are carried out on the input value.
```text
public bool LimitsChecked;
```

#### Conditions
Read / Write
### UseDashedLine

#### Description
Gets or sets whether a dashed "rubber band" line is to be drawn between the base point and the cursor's current location while prompting.
```text
public bool UseDashedLine;
```

#### Conditions
Read / Write