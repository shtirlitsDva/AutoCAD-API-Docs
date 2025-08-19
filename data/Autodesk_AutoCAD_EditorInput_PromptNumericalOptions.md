# PromptNumericalOptions Class

## Overview

#### Description
This is the base class for types that represent optional parameters for numerical prompts.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
        Autodesk.AutoCAD.EditorInput.PromptNumericalOptions
            Autodesk.AutoCAD.EditorInput.PromptDistanceOptions
            Autodesk.AutoCAD.EditorInput.PromptDoubleOptions
            Autodesk.AutoCAD.EditorInput.PromptIntegerOptions
```

```text
public class PromptNumericalOptions : PromptEditorOptions;
```

### Properties

- [AllowArbitraryInput](#allowarbitraryinput)
- [AllowNegative](#allownegative)
- [AllowNone](#allownone)
- [AllowZero](#allowzero)
- [UseDefaultValue](#usedefaultvalue)


## Properties Details

### AllowArbitraryInput

#### Description
Gets or sets whether the prompts accepts arbitrary input.
```text
public bool AllowArbitraryInput;
```

#### Conditions
Read / Write
### AllowNegative

#### Description
Gets or sets whether the prompt accepts negative valued input. 
True if negative valued input is accepted, false otherwise.
```text
public bool AllowNegative;
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
### UseDefaultValue

#### Description
Gets or sets whether the prompt should use the default value when the user presses ENTER without any other input. The property allowing client code to set the default value is declared by derived classes.
```text
public bool UseDefaultValue;
```

#### Conditions
Read / Write