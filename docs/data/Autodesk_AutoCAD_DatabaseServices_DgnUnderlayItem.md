# DgnUnderlayItem Class

## Overview

#### Description
This .NET class wraps the AcDbDgnUnderlayItem ObjectARX class. It represents underlay items.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.UnderlayItem
    Autodesk.AutoCAD.DatabaseServices.DgnUnderlayItem
```

```text
public class DgnUnderlayItem : UnderlayItem;
```

### Properties

- [SetShowRasterRef](#setshowrasterref)
- [ShowRasterRef](#showrasterref)
- [UseMasterUnits](#usemasterunits)


## Properties Details

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