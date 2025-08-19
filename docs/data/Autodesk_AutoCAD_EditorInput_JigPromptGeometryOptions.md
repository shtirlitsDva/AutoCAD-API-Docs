# JigPromptGeometryOptions Class

## Overview

#### Description
This is a base class for containers of input arguments for Jig sampling prompts that acquire geometric input.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.JigPromptOptions
        Autodesk.AutoCAD.EditorInput.JigPromptGeometryOptions
            Autodesk.AutoCAD.EditorInput.JigPromptAngleOptions
            Autodesk.AutoCAD.EditorInput.JigPromptDistanceOptions
            Autodesk.AutoCAD.EditorInput.JigPromptPointOptions
```

```text
public abstract class JigPromptGeometryOptions : JigPromptOptions;
```

### Constructors

- [JigPromptGeometryOptions()](#jigpromptgeometryoptions())
- [JigPromptGeometryOptions(string)](#jigpromptgeometryoptions(string))
- [JigPromptGeometryOptions(string, string)](#jigpromptgeometryoptions(string,-string))

### Properties

- [BasePoint](#basepoint)
- [UseBasePoint](#usebasepoint)


## Constructors Details

### JigPromptGeometryOptions()

#### Description
Constructor.
```text
public JigPromptGeometryOptions();
```

### JigPromptGeometryOptions(string)

#### Description
Constructor.
```text
public JigPromptGeometryOptions(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### JigPromptGeometryOptions(string, string)

#### Description
Constructor.
```text
public JigPromptGeometryOptions(
    string messageAndKeywords, 
    string globalKeywords
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string messageAndKeywords | Input prompt message and keywords |
| string globalKeywords | Input global keywords |

### BasePoint

#### Description
Returns the base point to be used by the prompt.
```text
public Point3d BasePoint;
```

#### Conditions
Read / Write
### UseBasePoint

#### Description
Returns a Boolean indicating whether the base point is to be used or not.
```text
public bool UseBasePoint;
```

#### Conditions
Read / Write