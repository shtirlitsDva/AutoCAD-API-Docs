# DgnDefinition Class

## Overview

#### Description
This .NET class wraps the AcDbDgnDefinition ObjectARX class. 
Represents DGN underlays in the drawing. Underlays are similar to raster images but their content is snappable.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.UnderlayDefinition
        Autodesk.AutoCAD.DatabaseServices.DgnDefinition
```

```text
public class DgnDefinition : UnderlayDefinition;
```

### Constructors

- [DgnDefinition](#dgndefinition)

### Properties

- [SetShowRasterRef](#setshowrasterref)
- [ShowRasterRef](#showrasterref)
- [UseMasterUnits](#usemasterunits)
- [XrefDepth](#xrefdepth)


## Constructors Details

### DgnDefinition

#### Description
Default constructor.
```text
public DgnDefinition();
```

### SetShowRasterRef

#### Description
Sets a boolean indicating whether raster images should be displayed in referenced DGN files. 
#### Conditions
```text
public bool SetShowRasterRef;
```

### ShowRasterRef

#### Description
Gets a boolean indicating whether raster images should be displayed in referenced (xref) DGN files. 
Returns true, if images should be displayed in referenced DGN files.
```text
public bool ShowRasterRef;
```

#### Conditions
Read-only
### UseMasterUnits

#### Description
Assesses whether the underlay uses master units in the DGN file when the DGN file is being translated to DWG for the underlay to use. If master units are not used, then subunits are used. 
True if the underlay uses Master units during translation.
```text
public bool UseMasterUnits;
```

#### Conditions
Read / Write
### XrefDepth

#### Description
Accesses the xref depth value (if any) that the underlay uses. This depth value is used if the DWG file is exported as DGN. For DWG to DGN translation, DGN underlays become DGN xrefs and will be given this depth value.
```text
public int XrefDepth;
```

#### Conditions
Read / Write