# PromptDoubleOptions Class

## Overview

#### Description
This class represents optional parameters for a prompt for a double.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
        Autodesk.AutoCAD.EditorInput.PromptNumericalOptions
            Autodesk.AutoCAD.EditorInput.PromptDoubleOptions
```

```text
public sealed class PromptDoubleOptions : PromptNumericalOptions;
```

### Constructors

- [PromptDoubleOptions(string)](#promptdoubleoptions(string))
- [PromptDoubleOptions(string, string)](#promptdoubleoptions(string,-string))

### Properties

- [DefaultValue](#defaultvalue)


## Constructors Details

### PromptDoubleOptions(string)

#### Description
Constructor.
```text
public PromptDoubleOptions(
    string message
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### PromptDoubleOptions(string, string)

#### Description
Constructor.
```text
public PromptDoubleOptions(
    string messageAndKeywords, 
    string globalKeywords
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string messageAndKeywords | Input prompt message and keywords |
| string globalKeywords | Input global keywords |

### DefaultValue

#### Description
The default value to be used when the user presses ENTER without any other input.
```text
public double DefaultValue;
```

#### Conditions
Read / Write