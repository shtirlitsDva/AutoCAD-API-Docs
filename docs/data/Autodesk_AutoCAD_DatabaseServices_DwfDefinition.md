# DwfDefinition Class

## Overview

#### Description
This .NET class wraps the AcDbDwfDefinition ObjectARX class. 
Represents DWF underlays in the drawing. Underlays are similar to raster images but their content is snappable.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.UnderlayDefinition
        Autodesk.AutoCAD.DatabaseServices.DwfDefinition
```

```text
public class DwfDefinition : UnderlayDefinition;
```

### Constructors

- [DwfDefinition](#dwfdefinition)

### Properties

- [isDWFx](#isdwfx)


## Constructors Details

### DwfDefinition

#### Description
Default constructor.
```text
public DwfDefinition();
```

### isDWFx

#### Description
Assesses if this is a DWFx file.
```text
public bool isDWFx;
```

#### Conditions
Read-only