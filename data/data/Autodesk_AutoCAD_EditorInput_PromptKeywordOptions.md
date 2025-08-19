# PromptKeywordOptions Class

## Overview

#### Description
This class represents optional parameters for a prompt for a keyword.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
        Autodesk.AutoCAD.EditorInput.PromptKeywordOptions
```

```text
public sealed class PromptKeywordOptions : PromptEditorOptions;
```

### Constructors

- [PromptKeywordOptions(string)](#promptkeywordoptions(string))
- [PromptKeywordOptions(string, string)](#promptkeywordoptions(string,-string))

### Properties

- [AllowArbitraryInput](#allowarbitraryinput)
- [AllowNone](#allownone)


## Constructors Details

### PromptKeywordOptions(string)

#### Description
Constructor.
```text
public PromptKeywordOptions(
    string message
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### PromptKeywordOptions(string, string)

#### Description
Constructor.
```text
public PromptKeywordOptions(
    string messageAndKeywords, 
    string globalKeywords
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string messageAndKeywords | Input message and keywords |
| string globalKeywords | Input global keywords |

### AllowArbitraryInput

#### Description
Gets or sets whether the prompts accepts arbitrary input. 
Returns true if arbitrary inputs are accepted.
```text
public bool AllowArbitraryInput;
```

#### Conditions
Read / Write
### AllowNone

#### Description
Gets or sets whether the prompt accepts ENTER as sole input. 
True if ENTER on its own is allowed, false otherwise.
```text
public bool AllowNone;
```

#### Conditions
Read / Write