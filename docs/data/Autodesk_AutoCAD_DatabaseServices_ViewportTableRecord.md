# ViewportTableRecord Class

## Overview

#### Description
This .NET class wraps the AcDbViewportTableRecord ObjectARX class. 
Objects of this class represent viewport arrangements when TILEMODE == 1 within AutoCAD (the ViewportTable and its records are not used when TILEMODE == 0). The ViewportTable (referred to in AutoCAD and DXF documentation as the VPORT table) is the container or owner of objects of this class. 
The ViewportTable is unique in that it can contain multiple ViewportTableRecords with the same name. This is necessary because when a multiple viewport configuration is saved, all viewports in the configuration must share the name, but each viewport has its own ViewportTableRecord created to save the data for that viewport.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTableRecord
        Autodesk.AutoCAD.DatabaseServices.AbstractViewTableRecord
            Autodesk.AutoCAD.DatabaseServices.ViewportTableRecord
```

```text
public class ViewportTableRecord : AbstractViewTableRecord;
```

### Constructors

- [ViewportTableRecord](#viewporttablerecord)

### Methods

- [GetPreviousBackground](#getpreviousbackground)
- [SetPreviousBackground](#setpreviousbackground)

### Properties

- [CircleSides](#circlesides)
- [FastZoomsEnabled](#fastzoomsenabled)
- [GridAdaptive](#gridadaptive)
- [GridBoundToLimits](#gridboundtolimits)
- [GridEnabled](#gridenabled)
- [GridFollow](#gridfollow)
- [GridIncrements](#gridincrements)
- [GridMajor](#gridmajor)
- [GridSubdivisionRestricted](#gridsubdivisionrestricted)
- [IconAtOrigin](#iconatorigin)
- [IconEnabled](#iconenabled)
- [IsometricSnapEnabled](#isometricsnapenabled)
- [LowerLeftCorner](#lowerleftcorner)
- [SnapAngle](#snapangle)
- [SnapBase](#snapbase)
- [SnapEnabled](#snapenabled)
- [SnapIncrements](#snapincrements)
- [SnapPair](#snappair)
- [ToneOperatorParameters](#toneoperatorparameters)
- [UcsFollowMode](#ucsfollowmode)
- [UcsSavedWithViewport](#ucssavedwithviewport)
- [UpperRightCorner](#upperrightcorner)


## Constructors Details

### ViewportTableRecord

#### Description
Constructor.
```text
public ViewportTableRecord();
```

### GetPreviousBackground

#### Description
Returns the viewport's previously set background based on the specified type.
```text
public ObjectId GetPreviousBackground(
    Autodesk.AutoCAD.GraphicsInterface.DrawableType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.GraphicsInterface.DrawableType type | Input type of the preferred previous background object. |

### SetPreviousBackground

#### Description
Sets the viewport's previously set background to the specified type based on the objectId value of the object.
```text
public void SetPreviousBackground(
    ObjectId value, 
    Autodesk.AutoCAD.GraphicsInterface.DrawableType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value | Input object ID of the new background. |
| Autodesk.AutoCAD.GraphicsInterface.DrawableType type | Input the drawable type |

### CircleSides

#### Description
Returns the circle zoom percent of the ViewportTableRecord. 
The circle zoom percent controls the number of sides to the tessellation used when displaying curves. The value can be between 1 and 20000, with higher settings using more sides in the curve tessellation. 
The circle zoom percent value is used for DXF group code 72.
```text
public short CircleSides;
```

#### Conditions
Read / Write
### FastZoomsEnabled

#### Description
This function always returns true. It is obsolete and will be removed in a future release.
```text
public bool FastZoomsEnabled;
```

#### Conditions
Read / Write
### GridAdaptive

#### Description
Returns true if the grid adapts to display fewer lines in the viewport than specified by the GRIDUNIT setting.
```text
public bool GridAdaptive;
```

#### Conditions
Read / Write
### GridBoundToLimits

#### Description
Returns true if the grid is drawn beyond the limits for the WCS and user-defined UCS in the viewport.
```text
public bool GridBoundToLimits;
```

#### Conditions
Read / Write
### GridEnabled

#### Description
This function returns true if the grid is set on in the ViewportTableRecord; otherwise, returns false. 
See GRID in the AutoCAD Command Reference for more information about the grid. 
The grid on or off setting is reflected in DXF group code 76.
```text
public bool GridEnabled;
```

#### Conditions
Read / Write
### GridFollow

#### Description
Returns true of the grid will follow a dynamic UCS change in the viewport.
```text
public bool GridFollow;
```

#### Conditions
Read / Write
### GridIncrements

#### Description
Returns an Vector2d in which the X value represents the X spacing (in drawing units) of the grid and the Y value represents the Y spacing of the grid. 
For information on what the grid is and how it's used, see GRID in the AutoCAD Command Reference. 
The X spacing value is used for DXF group code 15. 
The Y spacing value is used for DXF group code 25.
```text
public Point2d GridIncrements;
```

#### Conditions
Read / Write
### GridMajor

#### Description
Returns the number of minor grid lines between each major grid line in the viewport.
```text
public short GridMajor;
```

#### Conditions
Read / Write
### GridSubdivisionRestricted

#### Description
Returns true if the grid adapts to display more lines that specified in the GRIDUNIT setting. When zooming in the gridlines may get too sparse, so more lines are displayed.
```text
public bool GridSubdivisionRestricted;
```

#### Conditions
Read / Write
### IconAtOrigin

#### Description
This function returns true if the ViewportTableRecord is currently set to have the UCS icon follow the current UCS origin (as long as the origin is far enough within the viewport to allow the icon to display properly). If the icon is not set to follow the UCS origin in the viewport, then false is returned. 
See UCSICON in the AutoCAD Command Reference for more information on the UCS icon following origin. 
The UCS icon setting is reflected in the second bit DXF group code 74 (if the bit is set, then the icon will follow the origin).
```text
public bool IconAtOrigin;
```

#### Conditions
Read / Write
### IconEnabled

#### Description
This function returns true if the ViewportTableRecord is currently set to have the UCS icon display; otherwise, returns false. 
See UCSICON in the AutoCAD Command Reference for more information on the UCS icon visibility. 
The UCS icon visibility setting is reflected in the first bit of DXF group code 74 (if set, the icon will display).
```text
public bool IconEnabled;
```

#### Conditions
Read / Write
### IsometricSnapEnabled

#### Description
This function returns true if snap mode is currently set to isometric in the ViewportTableRecord; otherwise, returns false. 
See SNAP in the AutoCAD Command Reference for more information on the isometric snap mode. 
The snap Isometric setting is reflected in DXF group code 77.
```text
public bool IsometricSnapEnabled;
```

#### Conditions
Read / Write
### LowerLeftCorner

#### Description
This function returns an Point2d object containing the lower left corner of the viewport window. 
The X and Y values of this point are expressed as a value between (0.0, 0.0) for the lower left corner of the AutoCAD graphics area and (1.0, 1.0) for upper right corner of the AutoCAD graphics area. For example, a lower left corner value of (0.5, 0.0) indicates that the viewport's lower left corner is along the bottom of the AutoCAD graphics area, midway between the left and right edges of the graphics area. 
The lower left corner is used for DXF group code 10.
```text
public Point2d LowerLeftCorner;
```

#### Conditions
Read / Write
### SnapAngle

#### Description
This function returns the snap angle setting (in radians) for the ViewportTableRecord. 
The snap angle is measured within the UCS XY plane, with zero being the UCS X axis and positive angles going counterclockwise when looking down the UCS Z axis towards the UCS origin. 
For more information about snap angle, see the AutoCAD SNAPANG system variable documentation and SNAP in the AutoCAD Command Reference. 
The snap angle value is used for DXF group code 50.
```text
public double SnapAngle;
```

#### Conditions
Read / Write
### SnapBase

#### Description
This function returns the snap basepoint (in UCS coordinates) for the ViewportTableRecord. 
For more information about snap basepoint, see the AutoCAD SNAPBASE system variable documentation and SNAP in the AutoCAD Command Reference. 
The snap basepoint is used for DXF group code 13.
```text
public Point2d SnapBase;
```

#### Conditions
Read / Write
### SnapEnabled

#### Description
This function returns true if snap mode is currently set on in the ViewportTableRecord; otherwise, returns false. 
See SNAP in the AutoCAD Command Reference for more information on snap. 
The snap on or off setting is reflected in DXF group code 75.
```text
public bool SnapEnabled;
```

#### Conditions
Read / Write
### SnapIncrements

#### Description
This function returns an Point2d in which the X value represents the X spacing of the snap grid and the Y value represents the Y spacing of the snap grid. Both values are in drawing units. 
For information on the snap grid, see SNAP in the AutoCAD Command Reference. 
The X spacing value is used for DXF group code 14. 
The Y spacing value is used for DXF group code 24.
```text
public Point2d SnapIncrements;
```

#### Conditions
Read / Write
### SnapPair

#### Description
This function returns the snap IsoPair setting for the ViewportTableRecord. 
The snap IsoPair indicates the current isometric plane for the ViewportTableRecord.
```text
public short SnapPair;
```

#### Conditions
Read / Write
### ToneOperatorParameters

#### Description
Accesses the tone operator paramters.
```text
public Autodesk.AutoCAD.GraphicsInterface.ToneOperatorParameters ToneOperatorParameters;
```

#### Conditions
Read / Write
### UcsFollowMode

#### Description
This function returns true if the ViewportTableRecord is set to generate and display a plan view whenever the UCS changes in the viewport; otherwise, returns false. 
See UCSFOLLOW in the AutoCAD system variable documentation for more information on UCSFOLLOW mode. 
The UCSFOLLOW setting is reflected in the fourth bit of DXF group code 71 (if the bit is set, then follow mode is on).
```text
public bool UcsFollowMode;
```

#### Conditions
Read / Write
### UcsSavedWithViewport

#### Description
This function returns the value of UCSVP for the viewport. If this function returns true, then the ucs that is saved with this viewport will become active whenever the viewport is made active.
```text
public bool UcsSavedWithViewport;
```

#### Conditions
Read / Write
### UpperRightCorner

#### Description
This function returns an Point2d object containing the upper right corner of the viewport window. 
The X and Y values of this point are expressed as a value between (0.0, 0.0) for the lower left corner of the AutoCAD graphics area and (1.0, 1.0) for upper right corner of the AutoCAD graphics area. For example, an upper right corner value of (0.5, 1.0) indicates that the viewport's upper right corner is along the top of the AutoCAD graphics area, midway between the left and right edges of the graphics area. 
The upper right corner is used for DXF group code 11.
```text
public Point2d UpperRightCorner;
```

#### Conditions
Read / Write