# LayerTableRecord Class

## Overview

#### Description
This .NET class wraps the AcDbLayerTableRecord ObjectARX class. 
Objects of this class represent records in the LayerTable. Each of these records contains the information (color, on or off, frozen or thawed, etc.) about a layer in the drawing database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTableRecord
        Autodesk.AutoCAD.DatabaseServices.LayerTableRecord
```

```text
public class LayerTableRecord : SymbolTableRecord;
```

### Constructors

- [LayerTableRecord](#layertablerecord)

### Methods

- [GetViewportOverrides](#getviewportoverrides)
- [HasViewportOverrides](#hasviewportoverrides)
- [RemoveAllOverrides](#removealloverrides)

### Properties

- [Color](#color)
- [Description](#description)
- [EntityColor](#entitycolor)
- [HasOverrides](#hasoverrides)
- [IsFrozen](#isfrozen)
- [IsHidden](#ishidden)
- [IsLocked](#islocked)
- [IsOff](#isoff)
- [IsPlottable](#isplottable)
- [IsReconciled](#isreconciled)
- [IsUsed](#isused)
- [LinetypeObjectId](#linetypeobjectid)
- [LineWeight](#lineweight)
- [MaterialId](#materialid)
- [PlotStyleName](#plotstylename)
- [PlotStyleNameId](#plotstylenameid)
- [Transparency](#transparency)
- [ViewportVisibilityDefault](#viewportvisibilitydefault)


## Constructors Details

### LayerTableRecord

#### Description
Default constructor. Initializes color to 7 (white); IsFrozen, IsLocked, IsOff, ViewportVisibilityDefault, and IsPlottable to false; and linetype object ID to NULL.
```text
public LayerTableRecord();
```

### GetViewportOverrides

#### Description
Retrieves all of the table record's overrides.
```text
public LayerViewportProperties GetViewportOverrides(
    ObjectId viewportId
);
```

### HasViewportOverrides

#### Description
Returns true if this layer has one or more property overrides that are associated with the viewport whose object id is passed in to the method.
```text
public bool HasViewportOverrides(
    ObjectId viewportId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId viewportId | The object id of the viewport. |

### RemoveAllOverrides

#### Description
Removes all overrides associated with this layer, for all viewports.
```text
public void RemoveAllOverrides();
```

### Color

#### Description
Accesses the color value of the layer.
```text
public Autodesk.AutoCAD.Colors.Color Color;
```

#### Conditions
Read / Write
### Description

#### Description
Accesses the user-defined descriptive text for the layer.
```text
public string Description;
```

#### Conditions
Read / Write
### EntityColor

#### Description
Accesses the color settings of the layer.
```text
public Autodesk.AutoCAD.Colors.EntityColor EntityColor;
```

#### Conditions
Read / Write
### HasOverrides

#### Description
Assesses if this layer has any property overrides associated with any viewport in the drawing.
```text
public bool HasOverrides;
```

#### Conditions
Read-only
### IsFrozen

#### Description
Assesses if the layer is frozen.
```text
public bool IsFrozen;
```

#### Conditions
Read / Write
### IsHidden

#### Description
Assesses if the layer is frozen.
```text
public bool IsHidden;
```

#### Conditions
Read / Write
### IsLocked

#### Description
Assesses if the layer is frozen.
```text
public bool IsLocked;
```

#### Conditions
Read / Write
### IsOff

#### Description
Assesses if the layer is off.
```text
public bool IsOff;
```

#### Conditions
Read / Write
### IsPlottable

#### Description
Assesses if the layer is plottable.
```text
public bool IsPlottable;
```

#### Conditions
Read / Write
### IsReconciled

#### Description
Assesses if the layer is reconciled.
```text
public bool IsReconciled;
```

#### Conditions
Read / Write
### IsUsed

#### Description
Assesses if the layer is used.
```text
public bool IsUsed;
```

#### Conditions
Read-only
### LinetypeObjectId

#### Description
Accesses the ObjectId referenced by the LinetypeTableRecord.
```text
public ObjectId LinetypeObjectId;
```

#### Conditions
Read / Write
### LineWeight

#### Description
Accesses the LineWeight of the layer table record.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight LineWeight;
```

#### Conditions
Read / Write
### MaterialId

#### Description
Accesses the id of the associated Material.
```text
public ObjectId MaterialId;
```

#### Conditions
Read / Write
### PlotStyleName

#### Description
Accesses the PlotStyleName of the layer table record.
```text
public string PlotStyleName;
```

#### Conditions
Read / Write
### PlotStyleNameId

#### Description
Accesses the objectId of the entry in the PlotStyleName dictionary for the PlotStyleName of the layer table record.
```text
public ObjectId PlotStyleNameId;
```

#### Conditions
Read / Write
### Transparency

#### Description
Accesses the transparency value of the layer.
```text
public Autodesk.AutoCAD.Colors.Transparency Transparency;
```

#### Conditions
Read / Write
### ViewportVisibilityDefault

#### Description
Assesses if the layer is frozen by default in new viewports.
```text
public bool ViewportVisibilityDefault;
```

#### Conditions
Read / Write