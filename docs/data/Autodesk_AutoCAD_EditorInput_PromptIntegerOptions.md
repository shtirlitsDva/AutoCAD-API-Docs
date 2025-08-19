# PromptIntegerOptions Class

## Overview

#### Description
This class represents optional parameters for a prompt for an integer.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
        Autodesk.AutoCAD.EditorInput.PromptNumericalOptions
            Autodesk.AutoCAD.EditorInput.PromptIntegerOptions
```

```text
public sealed class PromptIntegerOptions : PromptNumericalOptions;
```

### Constructors

- [PromptIntegerOptions(string)](#promptintegeroptions(string))
- [PromptIntegerOptions(string, string)](#promptintegeroptions(string,-string))
- [PromptIntegerOptions(string, string, int, int)](#promptintegeroptions(string,-string,-int,-int))

### Properties

- [DefaultValue](#defaultvalue)
- [LowerLimit](#lowerlimit)
- [UpperLimit](#upperlimit)


## Constructors Details

### PromptIntegerOptions(string)

#### Description
Constructor.
```text
public PromptIntegerOptions(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### PromptIntegerOptions(string, string)

#### Description
Constructor.
```text
public PromptIntegerOptions(
    string messageAndKeywords, 
    string globalKeywords
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string messageAndKeywords | Input message and keywords |
| string globalKeywords | Input global keywords |

### PromptIntegerOptions(string, string, int, int)

#### Description
Constructor.
```text
public PromptIntegerOptions(
    string messageAndKeywords, 
    string globalKeywords, 
    int lowerLimit, 
    int upperLimit
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string messageAndKeywords | Input message and keywords |
| string globalKeywords | Input global keywords |
| int lowerLimit | Input lower limit |
| int upperLimit | Input upper limit |

### DefaultValue

#### Description
The default value to be used when the user presses ENTER without any other input.
```text
public int DefaultValue;
```

#### Conditions
Read / Write
### LowerLimit

#### Description
Returns the lower limit integer value.
```text
public int LowerLimit;
```

#### Conditions
Read / Write
### UpperLimit

#### Description
Returns the lower limit integer value.
```text
public int UpperLimit;
```

#### Conditions
Read / Write