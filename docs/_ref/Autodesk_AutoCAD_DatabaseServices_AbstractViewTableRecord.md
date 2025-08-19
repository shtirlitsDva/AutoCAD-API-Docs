# AbstractViewTableRecord Class

## Overview

#### Description
This .NET class wraps the AcDbAbstractViewTableRecord ObjectARX class. 
AbstractViewTableRecord is the base class for the ViewTableRecord and ViewportTableRecord classes. 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTableRecord
        Autodesk.AutoCAD.DatabaseServices.AbstractViewTableRecord
            Autodesk.AutoCAD.DatabaseServices.ViewportTableRecord
            Autodesk.AutoCAD.DatabaseServices.ViewTableRecord
```

```text
public abstract class AbstractViewTableRecord : SymbolTableRecord;
```

### Methods

- [SetSun](#setsun)
- [SetUcs(Autodesk.AutoCAD.DatabaseServices.OrthographicView)](#setucs(autodesk.autocad.databaseservices.orthographicview))
- [SetUcs(ObjectId)](#setucs(objectid))
- [SetUcs(Point3d, Vector3d, Vector3d)](#setucs(point3d,-vector3d,-vector3d))
- [SetUcsToWorld](#setucstoworld)
- [SetViewDirection](#setviewdirection)

### Properties

- [AmbientLightColor](#ambientlightcolor)
- [BackClipDistance](#backclipdistance)
- [BackClipEnabled](#backclipenabled)
- [Background](#background)
- [Brightness](#brightness)
- [CenterPoint](#centerpoint)
- [Contrast](#contrast)
- [DefaultLightingOn](#defaultlightingon)
- [DefaultLightingType](#defaultlightingtype)
- [Elevation](#elevation)
- [FrontClipAtEye](#frontclipateye)
- [FrontClipDistance](#frontclipdistance)
- [FrontClipEnabled](#frontclipenabled)
- [Height](#height)
- [LensLength](#lenslength)
- [PerspectiveEnabled](#perspectiveenabled)
- [SunId](#sunid)
- [Target](#target)
- [ToneOperatorParameters](#toneoperatorparameters)
- [Ucs](#ucs)
- [UcsName](#ucsname)
- [UcsOrthographic](#ucsorthographic)
- [ViewDirection](#viewdirection)
- [ViewOrthographic](#vieworthographic)
- [ViewTwist](#viewtwist)
- [VisualStyleId](#visualstyleid)
- [Width](#width)


## Methods Details

### SetSun

#### Description
Sets the object id to associate a sun object with this viewport.
```text
public ObjectId SetSun(
    [CallerMustClose] DBObject sun
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [CallerMustClose] DBObject sun | Input the sun object. |

### SetUcs(Autodesk.AutoCAD.DatabaseServices.OrthographicView)

#### Description
This function sets the UCS for the view or viewport table record. The new UCS will be unnamed and will be set to the orthographic UCS specified by view (relative to UCSBASE).
```text
public void SetUcs(
    Autodesk.AutoCAD.DatabaseServices.OrthographicView view
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.OrthographicView view | Input the object for the UCS view |

### SetUcs(ObjectId)

#### Description
This function sets the UCS for the view or viewport table record. The new UCS will be named and UcsId must reference a valid UcsTableRecord object.
```text
public void SetUcs(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input the object which references a UcsTableRecord. |

### SetUcs(Point3d, Vector3d, Vector3d)

#### Description
This function sets the UCS for the view or viewport table record. The new UCS will be unnamed and is defined by origin, x, and y.
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
| Point3d origin | Input the object to act as an origin |
| Vector3d y | Input the object to act as a _Y_ -coordinate |

### SetUcsToWorld

#### Description
This function sets the UCS for the view or viewport table record to the world UCS.
```text
public void SetUcsToWorld();
```

### SetViewDirection

#### Description
This function sets the view direction of the view or view table record to the specified orthographic view (relative to UCSBASE).
```text
public void SetViewDirection(
    Autodesk.AutoCAD.DatabaseServices.OrthographicView view
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.OrthographicView view | Input the orthographic view |

### AmbientLightColor

#### Description
Accesses the ambient light color for the viewport.
```text
public Autodesk.AutoCAD.Colors.Color AmbientLightColor;
```

#### Conditions
Read / Write
### BackClipDistance

#### Description
Accesses the distance (along the camera-target line) from the target to the back clipping plane. 
Positive values indicate that the clipping plane is in front of the target (that is, between the target and the camera). Negative values indicate the clipping plane is behind the target. 
See the AutoCAD DVIEW command documentation for more information on clipping planes. 
The back clipping plane distance value is used for DXF group code 44.
```text
public double BackClipDistance;
```

#### Conditions
Read / Write
### BackClipEnabled

#### Description
If set to true, the back clipping is On for TableRecord.
```text
public bool BackClipEnabled;
```

#### Conditions
Read / Write
#### Notes
See the AutoCAD DVIEW command documentation for more information on clipping planes. 
The back clipping plane On/Off setting is reflected in the third bit of DXF group code 71 (if bit is set then back clip is enabled).
### Background

#### Description
Accesses the background associated with this view. To unset one, set it to NULL.
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
Accesses the center point of the view in DCS coordinates.
```text
public Point2d CenterPoint;
```

#### Conditions
Read / Write
#### Notes
The center point value is used for DXF group code 10 in the ViewTableRecord class and group code 12 in the ViewportTableRecord class.
### Contrast

#### Description
Accesses the contrast factor for the viewport.
```text
public double Contrast;
```

#### Conditions
Read / Write
### DefaultLightingOn

#### Description
Accesses the state of default lighting for the viewport.
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
### Elevation

#### Description
Accesses the elevation of the UCS plane for the view or viewport table record.
```text
public double Elevation;
```

#### Conditions
Read / Write
### FrontClipAtEye

#### Description
Accesses the front clipping plane for perspective views. 
If true, then the front clipping plane is located at the camera (eye) regardless of the FrontClipDistance value. If false, then the front clipping plane is located using the FrontClipDistance value.
```text
public bool FrontClipAtEye;
```

#### Conditions
Read / Write
### FrontClipDistance

#### Description
Accesses the value of the distance (along the camera-target line) from the target to the front clipping plane. 
Positive values indicate that the clipping plane is in front of the target (that is, between the target and the camera). Negative values indicate the clipping plane is behind the target.
```text
public double FrontClipDistance;
```

#### Conditions
Read / Write
#### Notes
See the AutoCAD DVIEW command documentation for more information on clipping planes. 
The front clipping plane distance value is used for DXF group code 43.
### FrontClipEnabled

#### Description
If set to true, the front clipping is On in the TableRecord.
```text
public bool FrontClipEnabled;
```

#### Conditions
Read / Write
#### Notes
See the AutoCAD DVIEW command documentation for more information on clipping planes. 
The front clipping plane On/Off setting is reflected in the second bit of DXF group code 71 (if the bit is set, front clipping is On).
### Height

#### Description
Accesses the TableRecord height (in DCS coordinates) as the height of the view. 
Zooming out within the viewport (and then re-saving the view if it's an ViewTableRecord) will increase this value. Zooming in (and re-saving if appropriate) will decrease this value. 
```text
public double Height;
```

#### Conditions
Read / Write
#### Notes
The view height is used for DXF group code 40.
### LensLength

#### Description
Accesses the lens length when perspective mode is on in the TableRecord.
```text
public double LensLength;
```

#### Conditions
Read / Write
#### Notes
See the AutoCAD DVIEW command documentation for more information on perspective mode and lens length. 
The lens length value is used for DXF group code 42.
### PerspectiveEnabled

#### Description
If true, this function sets perspective mode to On in the TableRecord.
```text
public bool PerspectiveEnabled;
```

#### Conditions
Read / Write
#### Notes
See the AutoCAD DVIEW command documentation for more information on perspective mode. 
The perspective mode On/Off setting is reflected in the first bit of DXF group code 71 (if the bit is set, perspective mode is On).
### SunId

#### Description
Accesses the object id associated as a sun object with this viewport.
```text
public ObjectId SunId;
```

#### Conditions
Read / Write
### Target

#### Description
Accesses the location of the view's target, in WCS coordinates.
```text
public Point3d Target;
```

#### Conditions
Read / Write
#### Notes
The view target is used for DXF group code 12 in ViewTableRecords and group code 17 in ViewportTableRecords.
### ToneOperatorParameters

#### Description
Accesses the tone operator parameters for this view.
```text
public Autodesk.AutoCAD.GraphicsInterface.ToneOperatorParameters ToneOperatorParameters;
```

#### Conditions
Read / Write
### Ucs

#### Description
Accesses the UCS for the view or viewport table record.
```text
public CoordinateSystem3d Ucs;
```

#### Conditions
Read / Write
### UcsName

#### Description
Accesses the name of the UCS.
```text
public ObjectId UcsName;
```

#### Conditions
Read / Write
### UcsOrthographic

#### Description
Accesses the orthographic view associated with the UCS.
```text
public Autodesk.AutoCAD.DatabaseServices.OrthographicView UcsOrthographic;
```

#### Conditions
Read / Write
### ViewDirection

#### Description
Accesses the vector (in WCS coordinates) from the view's target to the view's camera.
```text
public Vector3d ViewDirection;
```

#### Conditions
Read / Write
#### Notes
This also represents the point coordinate set by the AutoCAD VPOINT command. See the AutoCAD VPOINT command documentation for more information on view direction. 
The view direction is used for DXF group code 11 in ViewTableRecords and group code 16 in ViewportTableRecords .
### ViewOrthographic

#### Description
Accesses the orthographic view from the view's target to the view's camera.
```text
public Autodesk.AutoCAD.DatabaseServices.OrthographicView ViewOrthographic;
```

#### Conditions
Read / Write
### ViewTwist

#### Description
Accesses the twist angle (in radians) of the view in the viewport.
```text
public double ViewTwist;
```

#### Conditions
Read / Write
#### Notes
The twist angle is a rotation around the view's line of sight. That is, the vector from camera to target, which is always perpendicular to the display, looking from the front of the display towards the back). The zero angle runs horizontally to the right (that is, the DCS's positive X-axis). 
For more information about the view twist angle, see the AutoCAD DVIEW command documentation. 
The view twist angle is used for DXF group code 50 in ViewTableRecords and group code 51 in ViewportTableRecords.
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
Accesses the width of the view in DCS coordinates
```text
public double Width;
```

#### Conditions
Read / Write
#### Notes
The view width is used for DXF group code 41 for ViewTableRecords. For ViewportTableRecords, the DXF group code 41 contains the ratio of the view width to height.