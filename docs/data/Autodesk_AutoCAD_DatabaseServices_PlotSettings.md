# PlotSettings Class

## Overview

#### Description
This .NET class wraps the AcDbPlotSettings ObjectARX class. 
The PlotSettings object stores "what-to-plot" settings as a named plot setup description. The plot settings objects are stored in an PlotSettingsDictionary.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.PlotSettings
        Autodesk.AutoCAD.DatabaseServices.Layout
```

```text
public class PlotSettings : DBObject;
```

#### See Also
PlotSettingsValidator

## Members

### Constructors

- [PlotSettings](#plotsettings)

### Methods

- [AddToPlotSettingsDictionary](#addtoplotsettingsdictionary)
- [SetShadePlot](#setshadeplot)

### Properties

- [CanonicalMediaName](#canonicalmedianame)
- [CurrentStyleSheet](#currentstylesheet)
- [CustomPrintScale](#customprintscale)
- [DrawViewportsFirst](#drawviewportsfirst)
- [ModelType](#modeltype)
- [PlotAsRaster](#plotasraster)
- [PlotCentered](#plotcentered)
- [PlotConfigurationName](#plotconfigurationname)
- [PlotHidden](#plothidden)
- [PlotOrigin](#plotorigin)
- [PlotPaperMargins](#plotpapermargins)
- [PlotPaperSize](#plotpapersize)
- [PlotPaperUnits](#plotpaperunits)
- [PlotPlotStyles](#plotplotstyles)
- [PlotRotation](#plotrotation)
- [PlotSettingsName](#plotsettingsname)
- [PlotType](#plottype)
- [PlotViewName](#plotviewname)
- [PlotViewportBorders](#plotviewportborders)
- [PlotWindowArea](#plotwindowarea)
- [PlotWireframe](#plotwireframe)
- [PrintLineweights](#printlineweights)
- [ScaleLineweights](#scalelineweights)
- [ShadePlot](#shadeplot)
- [ShadePlotCustomDpi](#shadeplotcustomdpi)
- [ShadePlotId](#shadeplotid)
- [ShadePlotResLevel](#shadeplotreslevel)
- [ShowPlotStyles](#showplotstyles)
- [StdScale](#stdscale)
- [StdScaleType](#stdscaletype)
- [UseStandardScale](#usestandardscale)


## Constructors Details

### PlotSettings

#### Description
This constructor allows you to set whether the new plot setup is a model space type (modelType == true) or a paperspace (layout) type (modelType == false).
```text
public PlotSettings(
    [MarshalAs(UnmanagedType.U1)] bool modelType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool modelType | Input Boolean that determines the plot setup type |

### AddToPlotSettingsDictionary

#### Description
This method adds plot settings to the dictionary.
```text
public void AddToPlotSettingsDictionary(
    Database toWhichDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database toWhichDatabase | Input database to which to add plot settings object |

### SetShadePlot

#### Description
Sets the plot settings for shaded or rendered plotting. 
If shade plot mode is set to AsDisplayed or Rendered, the shadePlotId parameter is ignored and the shade plot object ID is automatically set to Null. If the shade plot mode is set to VisualStyle or RenderPreset, the shade plot object ID must point to a valid VisualStyle or RenderSettings object.
```text
public void SetShadePlot(
    PlotSettingsShadePlotType type, 
    ObjectId shadePlotId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettingsShadePlotType type | Input type of the shade plot object |
| ObjectId shadePlotId | Input object ID of the VisualStyle or RenderSettings object to be used as the shade plot object |

### CanonicalMediaName

#### Description
Accesses the locale-independent name of the currently configured paper. For the localized version of the media name, use LocaleMediaName.
```text
public string CanonicalMediaName;
```

#### Conditions
Read-only
### CurrentStyleSheet

#### Description
Accesses the name of the configured plot style table.
```text
public string CurrentStyleSheet;
```

#### Conditions
Read-only
### CustomPrintScale

#### Description
Accesses the custom scale, a ratio of paperspace units to media units. The CustomPrintScale property stores the current scale (actually the numerator and denominator) for the plot settings for both "computed/standard" scales and "custom" scales. It always reflects the scale that will be used to plot. 
The paperspace units are represented by the numerator, and the media units (paper units) are represented by the denominator. For example, 1 unit in paperspace would equal 0.5 units on the media when the print scale is set to 0.5.
```text
public CustomScale CustomPrintScale;
```

#### Conditions
Read-only
### DrawViewportsFirst

#### Description
Assesses whether the plotting system will plot the objects in paperspace first (if it returns false), or last (if it returns true). This is relative to the floating model space viewports.
```text
public bool DrawViewportsFirst;
```

#### Conditions
Read / Write
### ModelType

#### Description
Assesses whether a named plot setup is a model space type or a paperspace (layout) type.
```text
public bool ModelType;
```

#### Conditions
Read-only
### PlotAsRaster

#### Description
Assesses whether or not the viewport will plot as a raster based on the viewport's current shade plot settings.
```text
public bool PlotAsRaster;
```

#### Conditions
Read-only
### PlotCentered

#### Description
Assesses whether the plot will be centered. If true, the paper margins are automatically computed to position the plot in the center of the sheet.
```text
public bool PlotCentered;
```

#### Conditions
Read-only
### PlotConfigurationName

#### Description
Accesses a PC3 file containing the "how to plot" information.
```text
public string PlotConfigurationName;
```

#### Conditions
Read-only
### PlotHidden

#### Description
Assesses whether or not the objects in paperspace are processed through the hidden line algorithm. Note that this doesn't affect objects inside of floating model space viewports. A separate control, specified per viewport, controls hidden line removal within those viewports.
```text
public bool PlotHidden;
```

#### Conditions
Read / Write
### PlotOrigin

#### Description
Accesses the plot origin offset that is applied inside of the paper margins.
```text
public Point2d PlotOrigin;
```

#### Conditions
Read-only
### PlotPaperMargins

#### Description
Accesses the printable area of the configured paper. The values returned are in millimeters, regardless of the units selected by the user. The values are in physical media coordinates, so they are not affected by the current scale of the drawing. This function does not take into account plots that may be rotated or mirrored.
```text
public Extents2d PlotPaperMargins;
```

#### Conditions
Read-only
### PlotPaperSize

#### Description
Accesses the width and height of the configured paper. This is defined as the entire physical paper area including the unprintable area.
```text
public Point2d PlotPaperSize;
```

#### Conditions
Read-only
### PlotPaperUnits

#### Description
Accesses the units used for plotting in the enumeration PlotPaperUnits.
```text
public PlotPaperUnit PlotPaperUnits;
```

#### Conditions
Read-only
### PlotPlotStyles

#### Description
Indicates whether plot styles are plotted (as opposed to just displayed).
```text
public bool PlotPlotStyles;
```

#### Conditions
Read / Write
### PlotRotation

#### Description
Accesses the rotation of the plot on the paper.
```text
public Autodesk.AutoCAD.DatabaseServices.PlotRotation PlotRotation;
```

#### Conditions
Read-only
### PlotSettingsName

#### Description
Accesses the current name of your plot settings.
```text
public string PlotSettingsName;
```

#### Conditions
Read / Write
### PlotType

#### Description
Accesses the portion of paperspace to output to the media.
```text
public Autodesk.AutoCAD.DatabaseServices.PlotType PlotType;
```

#### Conditions
Read-only
### PlotViewName

#### Description
Accesses a named view that in turn specifies what portion of the layout to plot.
```text
public string PlotViewName;
```

#### Conditions
Read-only
### PlotViewportBorders

#### Description
Accesses the floating model space viewport borders are plotted. Note that the viewport borders are always displayed on screen during layout mode.
```text
public bool PlotViewportBorders;
```

#### Conditions
Read / Write
### PlotWindowArea

#### Description
Accesses the portion of the layout to plot. The arguments specify the two points in paperspace positioned on the output media.
```text
public Extents2d PlotWindowArea;
```

#### Conditions
Read-only
### PlotWireframe

#### Description
Assesses whether or not the viewport will plot as vector output based on the viewport's current shade plot settings.
```text
public bool PlotWireframe;
```

#### Conditions
Read-only
### PrintLineweights

#### Description
Assesses whether lineweights will get plotted.
```text
public bool PrintLineweights;
```

#### Conditions
Read / Write
### ScaleLineweights

#### Description
Assesses whether lineweights will be scaled proportionately with the plot scale.
```text
public bool ScaleLineweights;
```

#### Conditions
Read / Write
### ShadePlot

#### Description
Accesses the type of shade plot specified in the plot settings.
```text
public PlotSettingsShadePlotType ShadePlot;
```

#### Conditions
Read / Write
### ShadePlotCustomDpi

#### Description
Accesses the shade plot custom dpi of the current PlotSettings object. This setting specifies the user-defined resolution at which shaded and rendered viewports will plot. This setting should be used only if the shade plot resolution level is set to ShadePlotResLevel.Custom.
```text
public short ShadePlotCustomDpi;
```

#### Conditions
Read / Write
### ShadePlotId

#### Description
Accesses the ObjectId of the VisualStyle or RenderSettings object referenced by this object.
```text
public ObjectId ShadePlotId;
```

#### Conditions
Read-only
### ShadePlotResLevel

#### Description
Accesses the shade plot resolution level of the current PlotSettings object. This setting specifies the resolution level at which shaded and rendered viewports will plot.
```text
public Autodesk.AutoCAD.DatabaseServices.ShadePlotResLevel ShadePlotResLevel;
```

#### Conditions
Read / Write
### ShowPlotStyles

#### Description
Assesses whether the object style is displayed during layout mode. This setting does not affect the plotting of pen styles.
```text
public bool ShowPlotStyles;
```

#### Conditions
Read / Write
### StdScale

#### Description
Accesses the standard scale value as a floating point scale. Each enumerated value in the enum StdScaleType maps to a single floating point number. This method allows an application to retrieve a standard scale without having to do a table lookup to compute the scale value.
```text
public double StdScale;
```

#### Conditions
Read-only
### StdScaleType

#### Description
Accesses the standard scale as a value of the enumerated type StdScaleType. 
The StdScaleType property stores the "standard" print scale selection, including scale-to-fit, for the plot settings object. It is not a number like CustomPrintScale, but is an enum indicating the desired print scale. AutoCAD uses this, along with other information like the plot area, to compute the CustomPrintScale when UseStandardScale is true. While the StdScaleType property always has a value, it may or may not be reflected in the CustomPrintScale, depending on the value of the UseStandardScale property.
```text
public Autodesk.AutoCAD.DatabaseServices.StdScaleType StdScaleType;
```

#### Conditions
Read-only
### UseStandardScale

#### Description
Assesses whether the layout is currently using the StdScaleType property to calculate the current plot scale. 
The UseStandardScale property indicates whether the StdScaleType property is used to compute the scale of the plot. If true, the CustomPrintScale property reflects the computed scale corresponding to the StdScaleType. If false, the CustomPrintScale property and the StdScaleType properties are unrelated, and only the CustomPrintScale property is valid. 
In other words, the CustomPrintScale property always reflects the current scale used to plot, regardless of whether it was computed based on a standard scale or was specified directly by the user. The UseStandardScale property indicates how the CustomPrintScale was obtained (by calculating it from a standard scale, including scale-to-fit, or by the user specifying it directly). The StdScaleType property always has a value, but is only used to compute the CustomPrintScale when the UseStandardScale property is true.
```text
public bool UseStandardScale;
```

#### Conditions
Read-only