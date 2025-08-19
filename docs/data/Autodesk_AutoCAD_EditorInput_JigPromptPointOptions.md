# JigPromptPointOptions Class

## Overview

#### Description
This class provides a container for command line options that can be passed to the JigPrompts.AcquirePoint() method.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.JigPromptOptions
        Autodesk.AutoCAD.EditorInput.JigPromptGeometryOptions
            Autodesk.AutoCAD.EditorInput.JigPromptPointOptions
```

```text
public sealed class JigPromptPointOptions : JigPromptGeometryOptions;
```

### Constructors

- [JigPromptPointOptions()](#jigpromptpointoptions())
- [JigPromptPointOptions(string)](#jigpromptpointoptions(string))
- [JigPromptPointOptions(string, string)](#jigpromptpointoptions(string,-string))

### Properties

- [DefaultValue](#defaultvalue)


## Constructors Details

### JigPromptPointOptions()

#### Description
Constructor.
```text
public JigPromptPointOptions();
```

### JigPromptPointOptions(string)

#### Description
Constructor.
```text
public JigPromptPointOptions(
    string message
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string message | Input prompt string |

### JigPromptPointOptions(string, string)

#### Description
Constructor.
```text
public JigPromptPointOptions(
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
Returns the default value to be used for point option prompt.
```text
public Point3d DefaultValue;
```

#### Conditions
Read / Write