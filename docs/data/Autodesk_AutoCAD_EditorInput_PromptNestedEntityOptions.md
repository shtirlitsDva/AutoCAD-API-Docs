# PromptNestedEntityOptions Class

## Overview

#### Description
This class represents optional parameters for a prompt for a nested entity.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
        Autodesk.AutoCAD.EditorInput.PromptNestedEntityOptions
```

```text
public sealed class PromptNestedEntityOptions : PromptEditorOptions;
```

### Constructors

- [PromptNestedEntityOptions(string)](#promptnestedentityoptions(string))
- [PromptNestedEntityOptions(string, string)](#promptnestedentityoptions(string,-string))

### Properties

- [AllowNone](#allownone)
- [NonInteractivePickPoint](#noninteractivepickpoint)
- [UseNonInteractivePickPoint](#usenoninteractivepickpoint)


## Constructors Details

### PromptNestedEntityOptions(string)

#### Description
Constructor.
```text
public PromptNestedEntityOptions(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### PromptNestedEntityOptions(string, string)

#### Description
Constructor.
```text
public PromptNestedEntityOptions(
    string messageAndKeywords, 
    string globalKeywords
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string messageAndKeywords | Input message and keywords |
| string globalKeywords | Input global keywords |

### AllowNone

#### Description
Gets or sets whether the prompt accepts ENTER as sole input. 
True if ENTER on its own is allowed, false otherwise.
```text
public bool AllowNone;
```

#### Conditions
Read / Write
### NonInteractivePickPoint

#### Description
Gets or sets the value for a non-interactive pick point.
```text
public Point3d NonInteractivePickPoint;
```

#### Conditions
Read / Write
### UseNonInteractivePickPoint

#### Description
Gets or sets whether the prompt should attempt a non-interactive pick
```text
public bool UseNonInteractivePickPoint;
```

#### Conditions
Read / Write