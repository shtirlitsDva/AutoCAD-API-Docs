# PromptAngleOptions Class

## Overview

#### Description
This class represents optional parameters for a prompt for an angle.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
        Autodesk.AutoCAD.EditorInput.PromptAngleOptions
```

```text
public sealed class PromptAngleOptions : PromptEditorOptions;
```

### Constructors

- [PromptAngleOptions(string)](#promptangleoptions(string))
- [PromptAngleOptions(string, string)](#promptangleoptions(string,-string))

### Properties

- [AllowArbitraryInput](#allowarbitraryinput)
- [AllowNone](#allownone)
- [AllowZero](#allowzero)
- [BasePoint](#basepoint)
- [DefaultValue](#defaultvalue)
- [UseAngleBase](#useanglebase)
- [UseBasePoint](#usebasepoint)
- [UseDashedLine](#usedashedline)
- [UseDefaultValue](#usedefaultvalue)


## Constructors Details

### PromptAngleOptions(string)

#### Description
Constructor.
```text
public PromptAngleOptions(
    string message
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### PromptAngleOptions(string, string)

#### Description
Constructor.
```text
public PromptAngleOptions(
    string messageAndKeywords, 
    string globalKeywords
);
```

### AllowArbitraryInput

#### Description
Gets or sets whether the prompts accepts arbitrary input. 
True if arbitrary input is accepted, false otherwise.
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
### AllowZero

#### Description
Gets or sets whether the prompt accepts zero valued input. 
True if zero valued input is accepted, false otherwise.
```text
public bool AllowZero;
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
### DefaultValue

#### Description
The default value to be used when the user presses ENTER without any other input.
```text
public double DefaultValue;
```

#### Conditions
Read / Write
### UseAngleBase

#### Description
Gets or sets whether the base angle value is used.
```text
public bool UseAngleBase;
```

#### Conditions
Read / Write
### UseBasePoint

#### Description
Gets or sets whether the base point is to be used.
```text
public bool UseBasePoint;
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
### UseDefaultValue

#### Description
Gets or sets whether the prompt should use the default value when the user presses ENTER without any other input. The property allowing client code to set the default value is declared by derived classes.
```text
public bool UseDefaultValue;
```

#### Conditions
Read / Write