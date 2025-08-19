# RenderGlobal Class

## Overview

#### Description
This .NET class wraps the AcDbRenderGlobal ObjectARX class. 
Container for all global rendering properties. One and only one of these objects is resident in the database, in the named object dictionary as ACAD_RENDER_GLOBAL.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.RenderGlobal
```

```text
public class RenderGlobal : DBObject;
```

### Constructors

- [DimensionsParameter.DimensionsParameter](#dimensionsparameter.dimensionsparameter)
- [ProcedureAndDestinationParameter.ProcedureAndDestinationParameter](#procedureanddestinationparameter.procedureanddestinationparameter)
- [RenderGlobal](#renderglobal)

### Other

- [AutoCAD.DatabaseServices.RenderGlobal.Destination Enumeration](#autocad.databaseservices.renderglobal.destination-enumeration)
- [AutoCAD.DatabaseServices.RenderGlobal.Procedure Enumeration](#autocad.databaseservices.renderglobal.procedure-enumeration)
- [DimensionsParameter Structure](#dimensionsparameter-structure)
- [ProcedureAndDestinationParameter Structure](#procedureanddestinationparameter-structure)

### Properties

- [Dimensions](#dimensions)
- [DimensionsParameter.Height](#dimensionsparameter.height)
- [DimensionsParameter.Width](#dimensionsparameter.width)
- [HighInfoLevel](#highinfolevel)
- [PredefinedPresetsFirst](#predefinedpresetsfirst)
- [ProcedureAndDestination](#procedureanddestination)
- [ProcedureAndDestinationParameter.Destination](#procedureanddestinationparameter.destination)
- [ProcedureAndDestinationParameter.Procedure](#procedureanddestinationparameter.procedure)
- [SaveEnabled](#saveenabled)
- [SaveFileName](#savefilename)


## Constructors Details

### DimensionsParameter.DimensionsParameter

#### Description
Constructs a new DimensionsParameter object with the given width and height.
```text
public DimensionsParameter(
    int w, 
    int h
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int w | Width parameter |
| int h | Height parameter |

### ProcedureAndDestinationParameter.ProcedureAndDestinationParameter

#### Description
Constructs a new ProcedureAndDestinationParameter object with the given procedure and destination.
```text
public ProcedureAndDestinationParameter(
    Autodesk.AutoCAD.DatabaseServices.RenderGlobal.Procedure p, 
    Autodesk.AutoCAD.DatabaseServices.RenderGlobal.Destination d
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RenderGlobal.Procedure p | Input a procedure |
| Autodesk.AutoCAD.DatabaseServices.RenderGlobal.Destination d | Input a destination |

### RenderGlobal

#### Description
Default constructor.
```text
public RenderGlobal();
```

### AutoCAD.DatabaseServices.RenderGlobal.Destination Enumeration

#### Description
This .NET class wraps the AcDbRenderGlobal::Destination ObjectARX enum. 
It describes the available outputs targets for rendering.
```text
public enum Destination {
  Window,
  Viewport
}
```

#### Members
| Members | Description |
| --- | --- |
| Window | The rendered image appears in the separate Render window. |
| Viewport | The rendered image appears directly in the current viewport. |

### AutoCAD.DatabaseServices.RenderGlobal.Procedure Enumeration

#### Description
This .NET class wraps the AcDbRenderGlobal::Procedure ObjectARX enum. 
It describes the available types of view content to render (render procedures).
```text
public enum Procedure {
  View,
  Crop,
  Selected
}
```

#### Members
| Members | Description |
| --- | --- |
| View | Render only the selected objects in the view. |
| Crop | Render only the user-defined rectangular region of the view. |
| Selected | Render only the selected objects in the view. |

### DimensionsParameter Structure

#### Description
This class is a container for the height and width parameters used by the RenderGlobal.Dimensions property.
```text
public struct DimensionsParameter {
}
```

### ProcedureAndDestinationParameter Structure

#### Description
This class is a container for the procedure and destination parameters used by the RenderGlobal.ProcedureAndDestination property.
```text
public struct ProcedureAndDestinationParameter {
}
```

### Dimensions

#### Description
Accesses the dimensions of the rendered image.
```text
public DimensionsParameter Dimensions;
```

#### Conditions
Read / Assesses whether a fog effect is 
Read / Write
### DimensionsParameter.Height

#### Description
Accesses the height.
```text
public int Height;
```

#### Conditions
Read-only
### DimensionsParameter.Width

#### Description
Accesses the width.
```text
public int Width;
```

#### Conditions
Read-only
### HighInfoLevel

#### Description
Assesses whether settings/statistics are shown in higher level of detail in the user interface.
```text
public bool HighInfoLevel;
```

#### Conditions
Read / Write
### PredefinedPresetsFirst

#### Description
Assesses whether predefined (factory) presets appear before the user-defined presets in the user interface.
```text
public bool PredefinedPresetsFirst;
```

#### Conditions
Read / Write
### ProcedureAndDestination

#### Description
Accesses the type of view content to render (the procedure) and the desired output target for rendering.
```text
public ProcedureAndDestinationParameter ProcedureAndDestination;
```

#### Conditions
Read / Write
### ProcedureAndDestinationParameter.Destination

#### Description
Accesses the destination.
```text
public Autodesk.AutoCAD.DatabaseServices.RenderGlobal.Destination Destination;
```

#### Conditions
Read-only
### ProcedureAndDestinationParameter.Procedure

#### Description
Accesses the procedure.
```text
public Autodesk.AutoCAD.DatabaseServices.RenderGlobal.Procedure Procedure;
```

#### Conditions
Read-only
### SaveEnabled

#### Description
Assesses whether to save an image to disk after rendering.
```text
public bool SaveEnabled;
```

#### Conditions
Read / Write
### SaveFileName

#### Description
Accesses the full path and file name of the value returned by SaveEnabled.
```text
public string SaveFileName;
```

#### Conditions
Read / Write