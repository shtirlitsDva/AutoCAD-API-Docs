# PlotSettingsValidator Class

## Overview

#### Description
This .NET class wraps the AcDbPlotSettingsValidator ObjectARX class. 
This class exports access methods that validate data on an PlotSettings object before actually setting the data on the object.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.PlotSettingsValidator
```

```text
public sealed class PlotSettingsValidator : DisposableWrapper;
```

#### Notes
In order to ensure that the plot device and plot style table lists maintained within this class are up to date, it is highly recommended that RefreshLists() is called to rebuild them prior to using any of the methods of this class. It is not necessary to call RefreshLists() more than once before accessing methods within this class since this call can be expensive.
#### See Also
PlotSettings

## Members

### Methods

- [GetCanonicalMediaNameList](#getcanonicalmedianamelist)
- [GetLocaleMediaName(PlotSettings, int)](#getlocalemedianame(plotsettings,-int))
- [GetLocaleMediaName(PlotSettings, string)](#getlocalemedianame(plotsettings,-string))
- [GetPlotDeviceList](#getplotdevicelist)
- [GetPlotStyleSheetList](#getplotstylesheetlist)
- [RefreshLists](#refreshlists)
- [SetCanonicalMediaName](#setcanonicalmedianame)
- [SetClosestMediaName](#setclosestmedianame)
- [SetCurrentStyleSheet](#setcurrentstylesheet)
- [SetCustomPrintScale](#setcustomprintscale)
- [SetDefaultPlotConfig](#setdefaultplotconfig)
- [SetPlotCentered](#setplotcentered)
- [SetPlotConfigurationName](#setplotconfigurationname)
- [SetPlotOrigin](#setplotorigin)
- [SetPlotPaperUnits](#setplotpaperunits)
- [SetPlotRotation](#setplotrotation)
- [SetPlotType](#setplottype)
- [SetPlotViewName](#setplotviewname)
- [SetPlotWindowArea](#setplotwindowarea)
- [SetStdScale](#setstdscale)
- [SetStdScaleType](#setstdscaletype)
- [SetUseStandardScale](#setusestandardscale)
- [SetZoomToPaperOnUpdate](#setzoomtopaperonupdate)

### Properties

- [Current](#current)


## Methods Details

### GetCanonicalMediaNameList

#### Description
Returns all available canonical media names available for the plot device configured on the PlotSettings object pointed to by plotSet.
```text
public StringCollection GetCanonicalMediaNameList(
    PlotSettings plotSet
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input pointer to PlotSettings object |

### GetLocaleMediaName(PlotSettings, int)

#### Description
Given an index into the canonical media name list returned by GetCanonicalMediaNameList(), returns the localized version of the media name at the index
```text
public string GetLocaleMediaName(
    PlotSettings plotSet, 
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input |
| int index | Input index into collection returned by GetCanonicalMediaNameList() |

### GetLocaleMediaName(PlotSettings, string)

#### Description
Given the canonical (locale-independent) representation for a given media name, returns the localized version.
```text
public string GetLocaleMediaName(
    PlotSettings plotSet, 
    string canonicalName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input |
| string canonicalName | Input locale independent media name identifier (item type returned by GetCanonicalMediaNameList()) |

### GetPlotDeviceList

#### Description
Returns a collection of all available plot devices found on the system This list is built only once per AutoCAD session. Call RefreshLists() if plot devices were added or removed from the system after starting the AutoCAD session.
```text
public StringCollection GetPlotDeviceList();
```

### GetPlotStyleSheetList

#### Description
Returns an array of all available plot style tables found on the system This list is built only once per AutoCAD session. Call RefreshLists() if plot style tables were added or removed from the system after starting the AutoCAD session.
```text
public StringCollection GetPlotStyleSheetList();
```

### RefreshLists

#### Description
Rebuilds the plot, canonical media, and plot style table arrays to reflect the current system state.
```text
public void RefreshLists(
    PlotSettings plotSet
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input |

### SetCanonicalMediaName

#### Description
Sets a locale-independent identifier for a specific media size. Use GetLocaleMediaName() to get the locale version of the identifier. 
**Note**
The canonical media name is case-sensitive. Be sure to enter the desired name in the proper letter case to avoid invalid media configuration messages.
```text
public void SetCanonicalMediaName(
    PlotSettings plotSet, 
    string mediaName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input |
| string mediaName | Input pointer to canonical media name |

### SetClosestMediaName

#### Description
For the configured plot device, sets the closest matching media size on the given PlotSettings object using the input criteria. 
This function is not implemented.
```text
public void SetClosestMediaName(
    PlotSettings plotSet, 
    double paperWidth, 
    double paperHeight, 
    PlotPaperUnit units, 
    [MarshalAs(UnmanagedType.U1)] bool matchPrintableArea
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | _nt_ |
| double paperWidth | _nt_ |
| double paperHeight | _nt_ |
| PlotPaperUnit units | _nt_ |
| [MarshalAs(UnmanagedType.U1)] bool matchPrintableArea | _nt_ |

### SetCurrentStyleSheet

#### Description
This method is used to set a specific plot style table on a layout.
```text
public void SetCurrentStyleSheet(
    PlotSettings plotSet, 
    string styleSheetName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input |
| string styleSheetName | Input pointer to plot style table name |

### SetCustomPrintScale

#### Description
This method sets the custom scale, a ratio of paperspace units to media units. The CustomPrintScale property stores the current scale (actually the numerator and denominator) for the plot settings for both "computed/standard" scales and "custom" scales. It always reflects the scale that will be used to plot. 
The paperspace units are represented by the numerator, and the media units (paper units) are represented by the denominator. For example, 1 unit in paperspace would equal 0.5 units on the media when the print scale is set to 0.5.
```text
public void SetCustomPrintScale(
    PlotSettings plotSet, 
    CustomScale scale
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input |
| CustomScale scale | Input paperspace units |

### SetDefaultPlotConfig

#### Description
Sets default plot configuration values on the given PlotSettings object pointed to by plotSet.
```text
public void SetDefaultPlotConfig(
    PlotSettings plotSet
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input |

### SetPlotCentered

#### Description
Sets whether the plot will be centered. 
If true, the paper margins are automatically computed to position the plot in the center of the sheet.
```text
public void SetPlotCentered(
    PlotSettings plotSet, 
    [MarshalAs(UnmanagedType.U1)] bool isCentered
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input PlotSettings object |
| [MarshalAs(UnmanagedType.U1)] bool isCentered | Input Boolean indicating whether the plot should be centered |

### SetPlotConfigurationName

#### Description
Specifies a system printer or PC3 file containing the "how to plot" information. 
**Note**
plotDeviceName cannot be set to none_device unless the mediaName is set to none_user_media. 
```text
public void SetPlotConfigurationName(
    PlotSettings plotSet, 
    string plotDeviceName, 
    string mediaName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input PlotSettings object |
| string plotDeviceName | Input pointer to plot device name |
| string mediaName | Input media name |

### SetPlotOrigin

#### Description
Sets the plot origin offset that is applied inside of the paper margins.
```text
public void SetPlotOrigin(
    PlotSettings plotSet, 
    Point2d origin
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input PlotSettings object |
| Point2d origin | Input offset coordinates |

### SetPlotPaperUnits

#### Description
Sets the units for plotting using the enumeration PlotPaperUnits.
```text
public void SetPlotPaperUnits(
    PlotSettings plotSet, 
    PlotPaperUnit units
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input PlotSettings object |
| PlotPaperUnit units | Input units by which the margins, offset, and paper size are interpreted |

### SetPlotRotation

#### Description
Sets the rotation of the plot on the paper.
```text
public void SetPlotRotation(
    PlotSettings plotSet, 
    Autodesk.AutoCAD.DatabaseServices.PlotRotation rotationType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input PlotSettings object |
| Autodesk.AutoCAD.DatabaseServices.PlotRotation rotationType | Input enumeration indicating rotation |

### SetPlotType

#### Description
Specifies the area of the model to output to the media.
```text
public void SetPlotType(
    PlotSettings plotSet, 
    Autodesk.AutoCAD.DatabaseServices.PlotType plotAreaType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input PlotSettings object |
| Autodesk.AutoCAD.DatabaseServices.PlotType plotAreaType | Input enumeration indicating the portion of the layout to plot |

### SetPlotViewName

#### Description
Specifies the named view that in which defines the area of the model to output. 
Plot type must be set to View.
```text
public void SetPlotViewName(
    PlotSettings plotSet, 
    string viewName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input PlotSettings object |
| string viewName | Input named view indicating the portion of the model to plot |

### SetPlotWindowArea

#### Description
Specifies the two points in which define the area to be output to the specified media. 
Plot type must be set to Window.
```text
public void SetPlotWindowArea(
    PlotSettings plotSet, 
    Extents2d windowArea
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input PlotSettings object |
| Extents2d windowArea | Input window coordinates (coordinates must be in DCS) |

#### Remarks
The following code snippet can be used to convert WCS to DCS:
VB.NET
```text
' Gets the current view
Dim acView As ViewTableRecord = acDoc.Editor.GetCurrentView()
Dim eExtents As Extents3d = New Extents3d(New Point3d(0, 0, 0), New Point3d(630, 445.5, 0))

' Translates WCS coordinates to DCS
Dim matWCS2DCS As Matrix3d
matWCS2DCS = Matrix3d.PlaneToWorld(acView.ViewDirection)
matWCS2DCS = Matrix3d.Displacement(acView.Target - Point3d.Origin) * matWCS2DCS
matWCS2DCS = Matrix3d.Rotation(-acView.ViewTwist,
                               acView.ViewDirection,
                               acView.Target) * matWCS2DCS

' Tranforms the extents to DCS
matWCS2DCS = matWCS2DCS.Inverse()
eExtents.TransformBy(matWCS2DCS)

' Defines the area to output
acPlSetVdr.SetPlotType(acPlSet, Autodesk.AutoCAD.DatabaseServices.PlotType.Window)
acPlSetVdr.SetPlotWindowArea(acPlSet, New Extents2d(eExtents.MinPoint.X, eExtents.MinPoint.Y,
                                                    eExtents.MaxPoint.X, eExtents.MaxPoint.Y))
```

```text
// Gets the current view
ViewTableRecord acView = acDoc.Editor.GetCurrentView();
Extents3d eExtents = new Extents3d(new Point3d(0, 0, 0), new Point3d(630, 445.5, 0));

// Translates WCS coordinates to DCS
Matrix3d matWCS2DCS;
matWCS2DCS = Matrix3d.PlaneToWorld(acView.ViewDirection);
matWCS2DCS = Matrix3d.Displacement(acView.Target - Point3d.Origin) * matWCS2DCS;
matWCS2DCS = Matrix3d.Rotation(-acView.ViewTwist,
                               acView.ViewDirection,
                               acView.Target) * matWCS2DCS;

// Tranforms the extents to DCS
matWCS2DCS = matWCS2DCS.Inverse();
eExtents.TransformBy(matWCS2DCS);

// Defines the area to output
acPlSetVdr.SetPlotType(acPlSet, Autodesk.AutoCAD.DatabaseServices.PlotType.Window);
acPlSetVdr.SetPlotWindowArea(acPlSet, new Extents2d(eExtents.MinPoint.X, eExtents.MinPoint.Y,
                                                    eExtents.MaxPoint.X, eExtents.MaxPoint.Y));
```

### SetStdScale

#### Description
Sets the standard scale value as a floating point scale. Each enumerated value in the enum StdScaleType maps to a single floating point number. This method allows an application to specify a standard scale without having to do a table lookup to compute the scale value. 
The StdScaleType property stores the "standard" print scale selection, including scale-to-fit, for the plot settings object. It is not a number like CustomPrintScale, but is an enum indicating the desired print scale. AutoCAD uses this, along with other information like the plot area, to compute the CustomPrintScale when UseStandardScale is true. While the StdScaleType property always has a value, it may or may not be reflected in the CustomPrintScale, depending on the value of the UseStandardScale property.
```text
public void SetStdScale(
    PlotSettings plotSet, 
    double standardScale
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input |
| double standardScale | Input standard scale value |

### SetStdScaleType

#### Description
Sets the standard scale from a value in the enumerated type StdScaleType. 
The StdScaleType property stores the "standard" print scale selection, including scale-to-fit, for the plot settings object. It is not a number like CustomPrintScale, but is an enum indicating the desired print scale. AutoCAD uses this, along with other information like the plot area, to compute the CustomPrintScale when UseStandardScale is true. While the StdScaleType property always has a value, it may or may not be reflected in the CustomPrintScale, depending on the value of the UseStandardScale property. 
| Name | Usage | Name | Usage |
| --- | --- | --- | --- |
| CustomScale | Scale is not a standard scale | Scale1To1 | 1:1 |
| Scale1To128inAnd1ft | 1/128"= 1' | Scale1To64inchAnd1ft | 1/64"= 1' |
| Scale1To32inchAnd1ft | 1/32"= 1' | Scale1To16inchAnd1ft | 1/16"= 1' |
| StdScale3To32InchIs1ft | 3/32"= 1' | Scale1To8inchAnd1ft | 1/8" = 1' |
| StdScale3To16InchIs1ft | 3/16"= 1' | Scale1To4inchAnd1ft | 1/4" = 1' |
| StdScale3To8InchIs1ft | 3/8" = 1' | Scale1To2InchIs1ft | 1/2" = 1' |
| StdScale3To4InchIs1ft | 3/4" = 1' | StdScale1InchIs1ft | 1"= 1' |
| Scale3inIs1ft | 3"= 1' | Scale6inIs1ft | 6"= 1' |
| Scale1ftIs1ft | 1'= 1' | Scale1To2 | 1:2 |
| Scale1To4 | 1:4 | Scale1To8 | 1:8 |
| Scale1To10 | 1:10 | Scale1To16 | 1:16 |
| Scale1To20 | 1:20 | Scale1To30 | 1:30 |
| Scale1To30 | 1:40 | Scale1To50 | 1:50 |
| Scale1To100 | 1:100 | Scale2To1 | 2:1 |
| Scale4To1 | 4:1 | Scale8To1 | 8:1 |
| Scale10To1 | 10:1 | Scale100To1 | 100:1 |
| Scale1000To1 | 1000:1 |  |

This scale is used to determine the ratio of paperspace units to plotter media units.
```text
public void SetStdScaleType(
    PlotSettings plotSet, 
    Autodesk.AutoCAD.DatabaseServices.StdScaleType scaleType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input plot set |
| Autodesk.AutoCAD.DatabaseServices.StdScaleType scaleType | Input standard scale |

### SetUseStandardScale

#### Description
Determines whether the layout will use the StdScaleType property to calculate the current plot scale. 
The UseStandardScale property indicates whether the StdScaleType property is used to compute the scale of the plot. If true, the CustomPrintScale property reflects the computed scale corresponding to the StdScaleType. If false, the CustomPrintScale property and the StdScaleType properties are unrelated, and only the CustomPrintScale property is valid. 
In other words, the CustomPrintScale property always reflects the current scale used to plot, regardless of whether it was computed based on a standard scale or was specified directly by the user. The UseStandardScale property indicates how the CustomPrintScale was obtained (by calculating it from a standard scale, including scale-to-fit, or by the user specifying it directly). The StdScaleType property always has a value, but is only used to compute the CustomPrintScale when the UseStandardScale property is true.
```text
public void SetUseStandardScale(
    PlotSettings plotSet, 
    [MarshalAs(UnmanagedType.U1)] bool useStandard
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input |
| [MarshalAs(UnmanagedType.U1)] bool useStandard | Input Boolean indicating whether to use standard scale |

### SetZoomToPaperOnUpdate

#### Description
This method sets a flag on an Layout object to indicate that a zoom to the associated paper image represented by the underlying Layout be performed if the paper receives update notification. An update notification can occur in a number of ways, but the most explicit is to call the UpdateCurrentPaper() method on the Layout Manager. It doesn't get notification, however, merely by setting attributes on the Layout object.
```text
public void SetZoomToPaperOnUpdate(
    PlotSettings plotSet, 
    [MarshalAs(UnmanagedType.U1)] bool doZoom
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PlotSettings plotSet | Input |
| [MarshalAs(UnmanagedType.U1)] bool doZoom | Input Boolean indicating whether to zoom |

### Current

#### Description
Accesses the current item.
```text
public static PlotSettingsValidator Current;
```

#### Conditions
Read-only