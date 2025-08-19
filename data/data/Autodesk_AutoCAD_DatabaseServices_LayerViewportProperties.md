# LayerViewportProperties Class

## Overview

#### Description
Defines further properties of the layer viewports in LayerTableRecord.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.LayerViewportProperties
```

```text
public sealed class LayerViewportProperties;
```

#### See Also
LayerTableRecord

## Members

### Methods

- [RemoveOverrides](#removeoverrides)

### Properties

- [Color](#color)
- [IsColorOverridden](#iscoloroverridden)
- [IsLinetypeOverridden](#islinetypeoverridden)
- [IsLineWeightOverridden](#islineweightoverridden)
- [IsPlotStyleOverridden](#isplotstyleoverridden)
- [IsTransparencyOverridden](#istransparencyoverridden)
- [LinetypeObjectId](#linetypeobjectid)
- [LineWeight](#lineweight)
- [PlotStyleName](#plotstylename)
- [PlotStyleNameId](#plotstylenameid)
- [Transparency](#transparency)


## Methods Details

### RemoveOverrides

#### Description
Removes all overrides associated with this layer and this viewport.
```text
public void RemoveOverrides();
```

### Color

#### Description
Accesses the color of this layer.
```text
public Autodesk.AutoCAD.Colors.Color Color;
```

#### Conditions
Read / Write
### IsColorOverridden

#### Description
Assesses whether or not the color is overridden for the associated layer and viewport.
```text
public bool IsColorOverridden;
```

#### Conditions
Read / Write
### IsLinetypeOverridden

#### Description
Accesses whether or not the linetype is overridden for the associated layer and viewport.
```text
public bool IsLinetypeOverridden;
```

#### Conditions
Read / Write
### IsLineWeightOverridden

#### Description
Accesses whether or not the line weight is overridden for the associated layer and viewport.
```text
public bool IsLineWeightOverridden;
```

#### Conditions
Read / Write
### IsPlotStyleOverridden

#### Description
Accesses whether or not the plot style is overridden for the associated layer and viewport.
```text
public bool IsPlotStyleOverridden;
```

#### Conditions
Read / Write
### IsTransparencyOverridden

#### Description
Indicates whether the transparency is overridden for the associated layer and viewport.
```text
public bool IsTransparencyOverridden;
```

#### Conditions
Read / Write
### LinetypeObjectId

#### Description
Accesses the linetype object id of this layer, in this viewport.
```text
public ObjectId LinetypeObjectId;
```

#### Conditions
Read / Write
### LineWeight

#### Description
Accesses the line weight of this layer, in this viewport.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight LineWeight;
```

#### Conditions
Read / Write
### PlotStyleName

#### Description
Accesses the plot style name.
```text
public string PlotStyleName;
```

#### Conditions
Read / Write
### PlotStyleNameId

#### Description
Accesses the plot style name ID.
```text
public ObjectId PlotStyleNameId;
```

#### Conditions
Read / Write
### Transparency

#### Description
Gets and sets the transparency or this layer, in this viewport.
```text
public Autodesk.AutoCAD.Colors.Transparency Transparency;
```

#### Conditions
Read / Write