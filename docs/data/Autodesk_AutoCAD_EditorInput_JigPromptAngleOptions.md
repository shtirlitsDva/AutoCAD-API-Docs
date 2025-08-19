# JigPromptAngleOptions Class

## Overview

#### Description
This class provides a container for command line options that can be passed to the JigPrompts.AcquireAngle() method.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.JigPromptOptions
        Autodesk.AutoCAD.EditorInput.JigPromptGeometryOptions
            Autodesk.AutoCAD.EditorInput.JigPromptAngleOptions
```

```text
public sealed class JigPromptAngleOptions : JigPromptGeometryOptions;
```

### Constructors

- [JigPromptAngleOptions()](#jigpromptangleoptions())
- [JigPromptAngleOptions(string)](#jigpromptangleoptions(string))
- [JigPromptAngleOptions(string, string)](#jigpromptangleoptions(string,-string))

### Properties

- [DefaultValue](#defaultvalue)


## Constructors Details

### JigPromptAngleOptions()

#### Description
Constructor.
```text
public JigPromptAngleOptions();
```

### JigPromptAngleOptions(string)

#### Description
Constructor.
```text
public JigPromptAngleOptions(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### JigPromptAngleOptions(string, string)

#### Description
Constructor.
```text
public JigPromptAngleOptions(
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
Returns the default jig prompt angle options value.
```text
public double DefaultValue;
```

#### Conditions
Read / Write