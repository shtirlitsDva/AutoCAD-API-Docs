# PromptStringOptions Class

## Overview

#### Description
This class represents optional parameters for a prompt for a string.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
        Autodesk.AutoCAD.EditorInput.PromptStringOptions
```

```text
public sealed class PromptStringOptions : PromptEditorOptions;
```

### Constructors

- [PromptStringOptions](#promptstringoptions)

### Properties

- [AllowSpaces](#allowspaces)
- [DefaultValue](#defaultvalue)
- [UseDefaultValue](#usedefaultvalue)


## Constructors Details

### PromptStringOptions

#### Description
Constructor.
```text
public PromptStringOptions(
    string message
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string message | Input. |

### AllowSpaces

#### Description
Gets or sets whether the prompt should allow spaces.
```text
public bool AllowSpaces;
```

#### Conditions
Read / Write
### DefaultValue

#### Description
Returns the DefaultValue property value.
```text
public string DefaultValue;
```

#### Conditions
Read / Write
### UseDefaultValue

#### Description
Returns the UseDefaultValue property value.
```text
public bool UseDefaultValue;
```

#### Conditions
Read / Write