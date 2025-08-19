# Viewport Class

## Overview

#### Description
This .NET class wraps the AcDbViewport ObjectARX class. 
The Viewport class represents the VIEWPORT entity within AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Viewport
```

```text
public class Viewport : Entity;
```

#### Notes
Do not derive from this class. Attempting to do so will cause your application to halt AutoCAD. 
Most Viewport properties are reset to default values when the viewport is appended to a database. Therefore, you should always wait until you have added a new Viewport object to the database before you change its property values.
### Constructors

- [Viewport](#viewport)

### Methods

- [FreezeLayersInViewport](#freezelayersinviewport)
- [GetFrozenLayers](#getfrozenlayers)
- [GetPreviousBackground](#getpreviousbackground)
- [GetUcs](#getucs)
- [IsLayerFrozenInViewport](#islayerfrozeninviewport)
- [SetPreviousBackground](#setpreviousbackground)
- [SetShadePlot](#setshadeplot)
- [SetSun](#setsun)
- [SetUcs(Autodesk.AutoCAD.DatabaseServices.OrthographicView)](#setucs(autodesk.autocad.databaseservices.orthographicview))
- [SetUcs(ObjectId)](#setucs(objectid))
- [SetUcs(Point3d, Vector3d, Vector3d)](#setucs(point3d,-vector3d,-vector3d))
- [SetUcsToWorld](#setucstoworld)
- [SetViewDirection](#setviewdirection)
- [ThawAllLayersInViewport](#thawalllayersinviewport)
- [ThawLayersInViewport](#thawlayersinviewport)
- [UpdateDisplay](#updatedisplay)

### Properties

- [AmbientLightColor](#ambientlightcolor)
- [AnnotationScale](#annotationscale)
- [BackClipDistance](#backclipdistance)
- [BackClipOn](#backclipon)
- [Background](#background)
- [Brightness](#brightness)
- [CenterPoint](#centerpoint)
- [CircleSides](#circlesides)
- [Contrast](#contrast)
- [CustomScale](#customscale)
- [DefaultLightingOn](#defaultlightingon)
- [DefaultLightingType](#defaultlightingtype)
- [EffectivePlotStyleSheet](#effectiveplotstylesheet)
- [Elevation](#elevation)
- [FastZoomOn](#fastzoomon)
- [FrontClipAtEyeOn](#frontclipateyeon)
- [FrontClipDistance](#frontclipdistance)
- [FrontClipOn](#frontclipon)
- [GridAdaptive](#gridadaptive)
- [GridBoundToLimits](#gridboundtolimits)
- [GridFollow](#gridfollow)
- [GridIncrement](#gridincrement)
- [GridMajor](#gridmajor)
- [GridOn](#gridon)
- [GridSubdivisionRestricted](#gridsubdivisionrestricted)
- [Height](#height)
- [HiddenLinesRemoved](#hiddenlinesremoved)
- [LensLength](#lenslength)
- [LinkedToSheetView](#linkedtosheetview)
- [Locked](#locked)
- [NonRectClipEntityId](#nonrectclipentityid)
- [NonRectClipOn](#nonrectclipon)
- [Number](#number)
- [On](#on)
- [PerspectiveOn](#perspectiveon)
- [PlotAsRaster](#plotasraster)
- [PlotStyleSheet](#plotstylesheet)
- [PlotWireframe](#plotwireframe)
- [ShadePlot](#shadeplot)
- [ShadePlotId](#shadeplotid)
- [SnapAngle](#snapangle)
- [SnapBasePoint](#snapbasepoint)
- [SnapIncrement](#snapincrement)
- [SnapIsometric](#snapisometric)
- [SnapIsoPair](#snapisopair)
- [SnapOn](#snapon)
- [StandardScale](#standardscale)
- [SunId](#sunid)
- [Thumbnail](#thumbnail)
- [ToneOperatorParameters](#toneoperatorparameters)
- [Transparent](#transparent)
- [TwistAngle](#twistangle)
- [Ucs](#ucs)
- [UcsFollowModeOn](#ucsfollowmodeon)
- [UcsIconAtOrigin](#ucsiconatorigin)
- [UcsIconVisible](#ucsiconvisible)
- [UcsName](#ucsname)
- [UcsOrthographic](#ucsorthographic)
- [UcsPerViewport](#ucsperviewport)
- [ViewCenter](#viewcenter)
- [ViewDirection](#viewdirection)
- [ViewHeight](#viewheight)
- [ViewOrthographic](#vieworthographic)
- [ViewTarget](#viewtarget)
- [VisualStyleId](#visualstyleid)
- [Width](#width)


## Constructors Details

### Viewport

#### Description
Default constructor. Initializes: 
  * View center point to (0,0,0)
  * Viewport width and height to 0.0
  * Viewport center point to (0,0,0)
  * viewTarget to (0,0,0)
  * viewDirection to (0,0,1)
  * viewHeight and viewCenter to arbitrary values
  * twistAngle to 0.0
  * lensLength to 50.0
  * Front and back clipping off
  * Front clip at eye
  * Front and back clip distances to 0.0
  * Perspective off
  * UcsFollowMode off
  * UcsIconVisible on
  * UcsIconAtOrigin off
  * Fast Zooms on
  * Circle zoom percent (that is, CircleSides() return value) to 100
  * Snap off
  * Standard snap mode (not isometric)
  * Snap angle to 0.0
  * Snap base point to (0,0)
  * Snap increment to (1,1)
  * snapIsoPair to 0
  * Grid off grid increment to (0,0)
  * Hidden line removal off

```text
public Viewport();
```

### FreezeLayersInViewport

#### Description
This function Freezes, in this viewport only, the layers whose ids are in layerIds.
```text
public void FreezeLayersInViewport(
    IEnumerator layerIds
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IEnumerator layerIds | Input array of object IDs of layers to be frozen in the viewport |

### GetFrozenLayers

#### Description
This function returns a collection of the objectIds of all LayerTableRecords currently frozen in the viewport.
```text
public ObjectIdCollection GetFrozenLayers();
```

### GetPreviousBackground

#### Description
Returns the viewport's previously set background of the specified type.
```text
public ObjectId GetPreviousBackground(
    Autodesk.AutoCAD.GraphicsInterface.DrawableType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.GraphicsInterface.DrawableType type | Input type of the preferred previous background object |

### GetUcs

#### Description
This function returns the origin, x-axis, and y-axis of the ucs for this viewport.
#### Parameters

| Parameters | Description |
| --- | --- |
| ref Point3d origin | Input origin |

  * : Input x-axis

  
ref Vector3d y |  Input y-axis   
Previous Declaration
```text
public void GetUcs(Point3d origin, Vector3d x, Vector3d y);
```

### IsLayerFrozenInViewport

#### Description
This function returns true if the LayerTableRecord with objectId layerId is frozen in the viewport. Otherwise false is returned.
```text
public bool IsLayerFrozenInViewport(
    ObjectId layerId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId layerId | Input id of the LayerTableRecord in question |

### SetPreviousBackground

#### Description
Sets the the previous background for the viewport.
```text
public void SetPreviousBackground(
    ObjectId value, 
    Autodesk.AutoCAD.GraphicsInterface.DrawableType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value | Input object ID of the new background |
| Autodesk.AutoCAD.GraphicsInterface.DrawableType type | Input the drawable type |

### SetShadePlot

#### Description
Sets the shade plot mode and shade plot object associated with this viewport. The shade plot object is a visual style or render preset that defines how the current viewport will plot. 
If shade plot mode is set to AsDisplayed or Rendered, the shadePlotId parameter is ignored and the shade plot object ID is automatically set to Null. If the shade plot mode is set to VisualStyle or RenderPreset, the shade plot object ID must point to a valid VisualStyle or RenderSettings object.
```text
public void SetShadePlot(
    Autodesk.AutoCAD.DatabaseServices.ShadePlotType type, 
    ObjectId shadePlotId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.ShadePlotType type | Input type of shade plot |
| ObjectId shadePlotId | Input object id for VisualStyle or RenderSettings object to be used as the new shade plot object |

### SetSun

#### Description
Sets and returns the object Id of the sun object associated with this viewport.
```text
public ObjectId SetSun(
    [CallerMustClose] DBObject sun
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [CallerMustClose] DBObject sun | Input a sun object |

### SetUcs(Autodesk.AutoCAD.DatabaseServices.OrthographicView)

#### Description
This function sets the UCS for this viewport to the orthographic UCS defined by view (relative to UCSBASE).
```text
public void SetUcs(
    Autodesk.AutoCAD.DatabaseServices.OrthographicView view
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.OrthographicView view | Input orthographic UCS |

### SetUcs(ObjectId)

#### Description
This function sets the UCS for this viewport. The new UCS will be named and userCoordinateSystemId must reference a valid UcsTableRecord object.
```text
public void SetUcs(
    ObjectId userCoordinateSystemId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId userCoordinateSystemId | Input reference to a valid UcsTableRecord object |

### SetUcs(Point3d, Vector3d, Vector3d)

#### Description
This function sets the UCS for this viewport as defined by origin, x, and y. The resulting UCS will be unnamed.
```text
public void SetUcs(
    Point3d origin, 
    Vector3d x, 
    Vector3d y
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d origin | Input origin |

  * : Input X axis

  
Vector3d y |  Input Y axis   
### SetUcsToWorld

#### Description
This function sets the ucs for this viewport to the world ucs.
```text
public void SetUcsToWorld();
```

### SetViewDirection

#### Description
This function sets the view direction of this viewport to the specified orthographic view (relative to UCSBASE).
```text
public void SetViewDirection(
    Autodesk.AutoCAD.DatabaseServices.OrthographicView view
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.OrthographicView view | Input orthographic view |

### ThawAllLayersInViewport

#### Description
This function thaws, in this viewport only, all the layers currently frozen in the viewport.
```text
public void ThawAllLayersInViewport();
```

### ThawLayersInViewport

#### Description
This function thaws, in this viewport only, the layers whose IDs are in layerIds.
```text
public void ThawLayersInViewport(
    IEnumerator layerIds
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IEnumerator layerIds | Input enumeration of object IDs of layers to be thawed in the viewport |

### UpdateDisplay

#### Description
This function updates the onscreen display to reflect any changes made to the viewport's view parameters. If no changes have been made, or the viewport is not on, or is not onscreen, then this function does nothing. 
This function is automatically called when the viewport is closed, so the only time this function should need to be explicitly called is when the viewport is in a transaction and the onscreen graphics need to be updated before the outermost transaction is ended.
```text
public void UpdateDisplay();
```

### AmbientLightColor

#### Description
Accesses the ambient light color for the viewport.
```text
public Autodesk.AutoCAD.Colors.Color AmbientLightColor;
```

#### Conditions
Read / Write
### AnnotationScale

#### Description
Accesses the AnnotationScale associated with the viewport
```text
public Autodesk.AutoCAD.DatabaseServices.AnnotationScale AnnotationScale;
```

#### Conditions
Read / Write
### BackClipDistance

#### Description
Accesses the distance (along the camera-target line) from the target to the back clipping plane. Positive values indicate that the clipping plane is in front of the target (that is, between the target and the camera) whereas negative values indicate the clipping plane is behind the target. 
See DVIEW in the _AutoCAD Command Reference_ for more information on clipping planes.
```text
public double BackClipDistance;
```

#### Conditions
Read / Write
### BackClipOn

#### Description
Assesses if the back clipping plane is currently turned on in the viewport, otherwise false is returned. 
See DVIEW in the _AutoCAD Command Reference_ for more information on clipping planes.
```text
public bool BackClipOn;
```

#### Conditions
Read / Write
### Background

#### Description
Accesses the object ID for the background of the current viewport. Returns NULL if no background has been defined.
```text
public ObjectId Background;
```

#### Conditions
Read / Write
### Brightness

#### Description
Accesses the brightness factor for this viewport.
```text
public double Brightness;
```

#### Conditions
Read / Write
### CenterPoint

#### Description
Accesses the center point of the viewport entity in WCS coordinates (within Paper Space).
```text
public Point3d CenterPoint;
```

#### Conditions
Read / Write
### CircleSides

#### Description
Accesses the circle zoom percent for the viewport. 
The circle zoom percent controls the number of sides to the tessellation used when displaying curves. The value can be between 1 and 20000, with higher settings using more sides in the curve tessellation. 
See VIEWRES in the _AutoCAD Command Reference_ for more information on circle zoom percent.
```text
public int CircleSides;
```

#### Conditions
Read / Write
### Contrast

#### Description
Accesses the contrast factor for the viewport.
```text
public double Contrast;
```

#### Conditions
Read / Write
### CustomScale

#### Description
Accesses the custom scale for the viewport. The custom scale defines the relationship of units in paperspace to units in the viewport. For example, a custom scale of 0.5 would indicate that 1 unit in the viewport maps to 0.5 units in paperspace.
```text
public double CustomScale;
```

#### Conditions
Read / Write
### DefaultLightingOn

#### Description
Assesses if any kind of default light is on.
```text
public bool DefaultLightingOn;
```

#### Conditions
Read / Write
### DefaultLightingType

#### Description
Accesses the type of default lighting being used in the viewport.
```text
public Autodesk.AutoCAD.DatabaseServices.DefaultLightingType DefaultLightingType;
```

#### Conditions
Read / Write
### EffectivePlotStyleSheet

#### Description
Accesses the layout's plot style table name.
```text
public string EffectivePlotStyleSheet;
```

#### Conditions
Read / Write
### Elevation

#### Description
Accesses the elevation of the ucs plane for this viewport.
```text
public double Elevation;
```

#### Conditions
Read / Write
### FastZoomOn

#### Description
This property always returns true and is obsolete and will be removed in a future release.
```text
public bool FastZoomOn;
```

#### Conditions
Read / Write
### FrontClipAtEyeOn

#### Description
Assesses if the front clipping plane is currently located at the camera, otherwise false is returned. 
See DVIEW in the _AutoCAD Command Reference_ for more information on clipping planes.
```text
public bool FrontClipAtEyeOn;
```

#### Conditions
Read / Write
### FrontClipDistance

#### Description
Accesses the distance (along the camera-target line) from the target to the front clipping plane. Positive values indicate that the clipping plane is in front of the target (that is, between the target and the camera) whereas negative values indicate the clipping plane is behind the target. 
See DVIEW in the _AutoCAD Command Reference_ for more information on clipping planes.
```text
public double FrontClipDistance;
```

#### Conditions
Read / Write
### FrontClipOn

#### Description
Assesses the front clipping plane is currently turned on in the viewport, otherwise false is returned. 
See DVIEW in the _AutoCAD Command Reference_ for more information on clipping planes.
```text
public bool FrontClipOn;
```

#### Conditions
Read / Write
### GridAdaptive

#### Description
Assesses if the grid adapts to display fewer lines in the viewport than the GRIDUNIT setting.
```text
public bool GridAdaptive;
```

#### Conditions
Read / Write
### GridBoundToLimits

#### Description
Assesses if the grid is drawn beyond limits for the WCS and user-defined UCS in the viewport, otherwise false is returned.
```text
public bool GridBoundToLimits;
```

#### Conditions
Read / Write
### GridFollow

#### Description
Assesses if the grid will follow a dynamic UCS change in the viewport.
```text
public bool GridFollow;
```

#### Conditions
Read / Write
### GridIncrement

#### Description
Accesses the Vector2d in which the X value represents the X spacing (in drawing units) of the grid and the Y value represents the Y spacing of the grid. 
For information on what the grid is and how it's used, see GRID in the _AutoCAD Command Reference_.
```text
public Vector2d GridIncrement;
```

#### Conditions
Read / Write
### GridMajor

#### Description
Accesses the number of minor grid lines between each major grid line in the viewport.
```text
public short GridMajor;
```

#### Conditions
Read / Write
### GridOn

#### Description
Assesses if the grid is currently turned on in the viewport, otherwise false is returned. 
See GRID in the _AutoCAD Command Reference_ for more information.
```text
public bool GridOn;
```

#### Conditions
Read / Write
### GridSubdivisionRestricted

#### Description
Assesses if subdivisions are allowed below the minor grid spacing in the viewport. 
This property is ignored if GridAdaptive returns false.
```text
public bool GridSubdivisionRestricted;
```

#### Conditions
Read / Write
### Height

#### Description
Accesses the height of the viewport entity's window in drawing units.
```text
public double Height;
```

#### Conditions
Read / Write
### HiddenLinesRemoved

#### Description
Accesses the viewport is set to remove hidden lines during plotting, otherwise false is returned. 
For more information on viewport specific hidden line removal during plotting, see MVIEW and the Hideplot option in the _AutoCAD Command Reference_.
```text
public bool HiddenLinesRemoved;
```

#### Conditions
Read / Write
### LensLength

#### Description
Accesses the lens length used when perspective mode is on in the viewport. 
See DVIEW in the _AutoCAD Command Reference_ for more information on perspective mode and lens length.
```text
public double LensLength;
```

#### Conditions
Read / Write
### LinkedToSheetView

#### Description
Assesses if the viewport is linked to a sheet view.
```text
public bool LinkedToSheetView;
```

#### Conditions
Read / Write
### Locked

#### Description
Assesses if a viewport's scale is locked. When a viewport is locked, its zoom factor relative to paperspace cannot be changed via AutoCAD commands such as ZOOM and VIEW.
```text
public bool Locked;
```

#### Conditions
Read / Write
### NonRectClipEntityId

#### Description
Accesses the single clipping entity for the viewport.
```text
public ObjectId NonRectClipEntityId;
```

#### Conditions
Read / Write
### NonRectClipOn

#### Description
Assesses if non-rectangular clipping is currently turned on for this viewport.
```text
public bool NonRectClipOn;
```

#### Conditions
Read / Write
### Number

#### Description
Accesses the viewport ID number. This is the number that is reported by the AutoCAD CVPORT system variable when the viewport is the current viewport in the AutoCAD editor. If the viewport is inactive, -1 is returned. 
This value is not saved with the drawing, and changes each time the drawing is opened.
```text
public int Number;
```

#### Conditions
Read-only
### On

#### Description
Assesses if the grid is currently turned on in the viewport, otherwise false is returned. 
See GRID in the _AutoCAD Command Reference_ for more information.
```text
public bool On;
```

#### Conditions
Read / Write
### PerspectiveOn

#### Description
Assesses if the perspective mode is currently turned on in the viewport, otherwise false is returned. 
See DVIEW in the _AutoCAD Command Reference_ for more information on perspective mode.
```text
public bool PerspectiveOn;
```

#### Conditions
Read / Write
### PlotAsRaster

#### Description
Assesses whether or not the viewport will plot as a raster based on the viewport's current shade plot settings.
```text
public bool PlotAsRaster;
```

#### Conditions
Read-only
### PlotStyleSheet

#### Description
Accesses the style sheet applied to objects in this viewport.
```text
public string PlotStyleSheet;
```

#### Conditions
Read / Write
### PlotWireframe

#### Description
Assesses whether or not the viewport will plot as a vector output based on the viewport's current shade plot settings.
```text
public bool PlotWireframe;
```

#### Conditions
Read-only
### ShadePlot

#### Description
Accesses the shade plot mode of the current viewport. The shade plot mode specifies how the current viewport will plot.
```text
public Autodesk.AutoCAD.DatabaseServices.ShadePlotType ShadePlot;
```

#### Conditions
Read / Write
### ShadePlotId

#### Description
Accesses the shade object associated with this viewport. The shade object is a visual style or render preset that defines how the current viewport will plot.
```text
public ObjectId ShadePlotId;
```

#### Conditions
Read-only
### SnapAngle

#### Description
Accesses the snap angle setting (in radians) for the viewport. 
The snap angle is within the UCS XY plane, with zero being the UCS X axis and positive angles going counterclockwise when looking down the UCS Z axis towards the UCS origin. 
For more information about snap angle, see SNAPANG in Appendix B (System Variables) of the _AutoCAD Command Reference_ and SNAP in the _AutoCAD Command Reference_.
```text
public double SnapAngle;
```

#### Conditions
Read / Write
### SnapBasePoint

#### Description
Accesses the snap basepoint (in UCS coordinates) for the viewport. 
For more information about snap basepoint, see SNAPBASE in Appendix B (System Variables) of the _AutoCAD Command Reference_ and SNAP in the _AutoCAD Command Reference_.
```text
public Point2d SnapBasePoint;
```

#### Conditions
Read / Write
### SnapIncrement

#### Description
Accesses the snap basepoint (in UCS coordinates) for the viewport. 
For more information about snap basepoint, see SNAPBASE in Appendix B (System Variables) of the _AutoCAD Command Reference_ and SNAP in the _AutoCAD Command Reference_.
```text
public Vector2d SnapIncrement;
```

#### Conditions
Read / Write
### SnapIsometric

#### Description
Assesses if snap mode is currently set to isometric in the viewport, otherwise false is returned. 
See SNAP in the _AutoCAD Command Reference_ for more information on the isometric snap mode.
```text
public bool SnapIsometric;
```

#### Conditions
Read / Write
### SnapIsoPair

#### Description
Accesses the snap IsoPair setting for the viewport. 
The snap IsoPair indicates the current isometric plane for the viewport. 
Possible values are: 
| 0 | Left isoplane |
| --- | --- |
| 1 | Top isoplane |
| 2 | Right isoplane |

```text
public int SnapIsoPair;
```

#### Conditions
Read / Write
### SnapOn

#### Description
Assesses if snap mode is currently turned on in the viewport, otherwise false is returned. 
See SNAP in the _AutoCAD Command Reference_ for more information on snap.
```text
public bool SnapOn;
```

#### Conditions
Read / Write
### StandardScale

#### Description
This function returns the scale of a viewport by using a standard scale defined by the StdScaleType enumeration. Possible values are: 
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

If you accesses StandardScale on a viewport whose scale doesn't match any of the standard scales, the CustomScale is returned.
```text
public Autodesk.AutoCAD.DatabaseServices.StandardScaleType StandardScale;
```

#### Conditions
Read / Write
### SunId

#### Description
Accesses the Sun object associated with this viewport. If not sun object has been set, it returns Null.
```text
public ObjectId SunId;
```

#### Conditions
Read-only
### Thumbnail

#### Description
Accesses the packed BITMAPINFO structure of the thumbnail, with the thumbnail data following it immediately in memory. It will be set to null if no thumbnail has been set.
```text
public Bitmap Thumbnail;
```

#### Conditions
Read / Write
### ToneOperatorParameters

#### Description
Accesses the tone parameters for this viewport.
```text
public Autodesk.AutoCAD.GraphicsInterface.ToneOperatorParameters ToneOperatorParameters;
```

#### Conditions
Read / Write
### Transparent

#### Description
Not implemented.
```text
public bool Transparent;
```

#### Conditions
Read / Write
### TwistAngle

#### Description
Accesses the twist angle (in radians) of the view in the viewport. 
The twist angle is a rotation around the view's line of sight (that is, the vector from camera to target, which is always perpendicular to the display, looking from the front of the display toward the back). The zero angle is horizontally to the right (that is, the display coordinate system's positive X axis). 
For more information about the view twist angle, see DVIEW in the _AutoCAD Command Reference_.
```text
public double TwistAngle;
```

#### Conditions
Read / Write
### Ucs

#### Description
Accesses the CoordinateSystem3d value that represents the UCS assigned to the viewport.
```text
public CoordinateSystem3d Ucs;
```

#### Conditions
Read / Write
### UcsFollowModeOn

#### Description
Assesses if the viewport is set to generate and display a plan view whenever the UCS changes in the viewport, otherwise false is returned. 
See UCSFOLLOW in Appendix B (System Variables) of the _AutoCAD Command Reference_ for more information on UCSFOLLOW mode.
```text
public bool UcsFollowModeOn;
```

#### Conditions
Read / Write
### UcsIconAtOrigin

#### Description
Assesses if the viewport is currently set to have the UCS icon follow the current UCS origin, as long as the origin is far enough within the viewport to allow the icon to display properly. If the icon is not set to follow the UCS origin in the viewport, then false is returned. 
See UCSICON in the _AutoCAD Command Reference_ for more information on the UCS icon following origin.
```text
public bool UcsIconAtOrigin;
```

#### Conditions
Read / Write
### UcsIconVisible

#### Description
Assesses if the viewport is currently set to have the UCS icon display, otherwise false is returned. 
See UCSICON in the _AutoCAD Command Reference_ for more information on the UCS icon visibility.
```text
public bool UcsIconVisible;
```

#### Conditions
Read / Write
### UcsName

#### Description
Accesses the object id of an UcsTableRecord if this viewport's ucs is a named ucs, otherwise it returns a null id.
```text
public ObjectId UcsName;
```

#### Conditions
Read / Write
### UcsOrthographic

#### Description
Retrieves the orthographic UCS.
```text
public Autodesk.AutoCAD.DatabaseServices.OrthographicView UcsOrthographic;
```

#### Conditions
Read-only
### UcsPerViewport

#### Description
Assesses the value of UCSVP for the viewport. If ucsvp is true, then the UCS that is saved with this viewport will become active whenever the viewport is made active.
```text
public bool UcsPerViewport;
```

#### Conditions
Read / Write
### ViewCenter

#### Description
Accesses the view center (in display coordinate system coordinates) of the view in the viewport.
```text
public Point2d ViewCenter;
```

#### Conditions
Read / Write
### ViewDirection

#### Description
Accesses the vector (in Model Space WCS coordinates) from the view's target to the view's camera. This also represents the point coordinate set by the AutoCAD VPOINT command. 
For more information on view direction, see VPOINT in the _AutoCAD Command Reference_.
```text
public Vector3d ViewDirection;
```

#### Conditions
Read / Write
### ViewHeight

#### Description
Accesses the height (in display coordinate system coordinates) of the Model Space view within the viewport. Zooming the view out within the viewport increases this value and zooming in decreases this value.
```text
public double ViewHeight;
```

#### Conditions
Read / Write
### ViewOrthographic

#### Description
Accesses the orthographic view.
```text
public Autodesk.AutoCAD.DatabaseServices.OrthographicView ViewOrthographic;
```

#### Conditions
Read-only
### ViewTarget

#### Description
Accesses the location (in Model Space WCS coordinates) of the view's target.
```text
public Point3d ViewTarget;
```

#### Conditions
Read / Write
### VisualStyleId

#### Description
Accesses the object ID of the visual style in effect for this viewport.
```text
public ObjectId VisualStyleId;
```

#### Conditions
Read / Write
### Width

#### Description
Accesses the width of the viewport entity's window in drawing units. This is the width in Paper Space of the viewport itself, not the width of the Model Space view within the viewport.
```text
public double Width;
```

#### Conditions
Read / Write