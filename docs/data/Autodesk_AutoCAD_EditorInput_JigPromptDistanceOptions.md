# JigPromptDistanceOptions Class

## Overview

#### Description
This class provides a container for command line options that can be passed to the JigPrompts.AcquireDistance() method.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.JigPromptOptions
        Autodesk.AutoCAD.EditorInput.JigPromptGeometryOptions
            Autodesk.AutoCAD.EditorInput.JigPromptDistanceOptions
```

```text
public sealed class JigPromptDistanceOptions : JigPromptGeometryOptions;
```

### Constructors

- [JigPromptDistanceOptions()](#jigpromptdistanceoptions())
- [JigPromptDistanceOptions(string)](#jigpromptdistanceoptions(string))
- [JigPromptDistanceOptions(string, string)](#jigpromptdistanceoptions(string,-string))

### Properties

- [DefaultValue](#defaultvalue)


## Constructors Details

### JigPromptDistanceOptions()

#### Description
Constructor.
```text
public JigPromptDistanceOptions();
```

### JigPromptDistanceOptions(string)

#### Description
Constructor.
```text
public JigPromptDistanceOptions(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### JigPromptDistanceOptions(string, string)

#### Description
Constructor.
```text
public JigPromptDistanceOptions(
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
Returns the default jig prompt distance options value.
```text
public double DefaultValue;
```

#### Conditions
Read / Write