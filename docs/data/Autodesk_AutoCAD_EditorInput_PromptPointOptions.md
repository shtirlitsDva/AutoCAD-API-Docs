# PromptPointOptions Class

## Overview

#### Description
This class represents optional parameters for a prompt for point.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
        Autodesk.AutoCAD.EditorInput.PromptCornerOptions
            Autodesk.AutoCAD.EditorInput.PromptPointOptions
```

```text
public class PromptPointOptions : PromptCornerOptions;
```

### Constructors

- [PromptPointOptions(string)](#promptpointoptions(string))
- [PromptPointOptions(string, string)](#promptpointoptions(string,-string))

### Properties

- [UseBasePoint](#usebasepoint)


## Constructors Details

### PromptPointOptions(string)

#### Description
Constructor.
```text
public PromptPointOptions(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### PromptPointOptions(string, string)

#### Description
Constructor.
```text
public PromptPointOptions(
    string messageAndKeywords, 
    string globalKeywords
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string messageAndKeywords | Input message and keywords |
| string globalKeywords | Input global keywords |

### UseBasePoint

#### Description
Gets or sets whether the base point is to be used. 
True if the BasePoint value is to be used, false otherwise.
```text
public bool UseBasePoint;
```

#### Conditions
Read / Write