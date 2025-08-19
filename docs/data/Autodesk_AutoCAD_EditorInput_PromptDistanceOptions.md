# PromptDistanceOptions Class

## Overview

#### Description
This class represents optional parameters for a distance prompt.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
        Autodesk.AutoCAD.EditorInput.PromptNumericalOptions
            Autodesk.AutoCAD.EditorInput.PromptDistanceOptions
```

```text
public sealed class PromptDistanceOptions : PromptNumericalOptions;
```

### Constructors

- [PromptDistanceOptions(string)](#promptdistanceoptions(string))
- [PromptDistanceOptions(string, string)](#promptdistanceoptions(string,-string))

### Properties

- [BasePoint](#basepoint)
- [DefaultValue](#defaultvalue)
- [Only2d](#only2d)
- [UseBasePoint](#usebasepoint)
- [UseDashedLine](#usedashedline)


## Constructors Details

### PromptDistanceOptions(string)

#### Description
Constructor.
```text
public PromptDistanceOptions(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### PromptDistanceOptions(string, string)

#### Description
Constructor.
```text
public PromptDistanceOptions(
    string messageAndKeywords, 
    string globalKeywords
);
```

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
### Only2d

#### Description
Gets or sets whether the distance returned should be measured as a 2D projection to the UCS.
```text
public bool Only2d;
```

#### Conditions
Read / Write
### UseBasePoint

#### Description
Gets or sets whether tthe base point is to be used.
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