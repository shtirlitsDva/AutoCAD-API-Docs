# UnderlayReference Class

## Overview

#### Description
This .Net class wraps AcDbUnderlayReference ObjectARX class. 
UnderlayReference is an abstract class that represents underlays in the drawing. Underlays are similar to raster images, but their content is snappable. An UnderlayReference object must reference a compatible UnderlayDefinition object. 
The UnderlayReference object is responsible for the placement of the content within the drawing, while the UnderlayDefinition object handles the linkage to the underlay content. Instances of UnderlayReference-derived concrete classes are inserted into a block table record. Instances of UnderlayDefinition-derived concrete classes are inserted into a dictionary under the named object dictionary.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.UnderlayReference
            Autodesk.AutoCAD.DatabaseServices.DgnReference
            Autodesk.AutoCAD.DatabaseServices.DwfReference
            Autodesk.AutoCAD.DatabaseServices.PdfReference
```

```text
public abstract class UnderlayReference : Entity;
```

### Methods

- [GenerateClipBoundaryFromPline](#generateclipboundaryfrompline)
- [GetClipBoundary](#getclipboundary)
- [SetClipBoundary](#setclipboundary)

### Properties

- [AdjustColorForBackground](#adjustcolorforbackground)
- [Contrast](#contrast)
- [ContrastLowerLimit](#contrastlowerlimit)
- [ContrastUpperLimit](#contrastupperlimit)
- [DefaultContrast](#defaultcontrast)
- [DefaultFade](#defaultfade)
- [DefinitionId](#definitionid)
- [Fade](#fade)
- [FadeLowerLimit](#fadelowerlimit)
- [FadeUpperLimit](#fadeupperlimit)
- [Height](#height)
- [IsClipInverted](#isclipinverted)
- [IsClipped](#isclipped)
- [IsOn](#ison)
- [Monochrome](#monochrome)
- [Name](#name)
- [NameOfSheet](#nameofsheet)
- [Normal](#normal)
- [Path](#path)
- [Position](#position)
- [Rotation](#rotation)
- [ScaleFactors](#scalefactors)
- [Transform](#transform)
- [UnderlayLayerCollection](#underlaylayercollection)
- [Width](#width)


## Methods Details

### GenerateClipBoundaryFromPline

#### Description
Generates the clip boundary from a polyline
```text
public void GenerateClipBoundaryFromPline(
    ObjectId polyId
);
```

### GetClipBoundary

#### Description
Returns an array of points that specify the clip boundary of the underlay. The boundary is defined in model coordinates. You must use the transformation matrix returned by the transform()function to obtain WCS points.
```text
public Point2d\[\] GetClipBoundary();
```

### SetClipBoundary

#### Description
Sets the clip boundary of the underlay. The boundary is defined in model coordinates. (i.e. Given WCS points one must use the inverse of the transformation matrix return by Transform to obtain points that can be passed to this function.)
```text
public void SetClipBoundary(
    Point2d\[\] points
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point2d[] points | Input the clip boundary. An array describing a self intersecting polyline is not allowed. An array of two points is allowed and is treated as the minimum, maximum point of a rectangle. |

### AdjustColorForBackground

#### Description
Sets or returns a Boolean indicating whether the underlay content is adjusted for the current background color. Not all underlay types observe this setting.
```text
public bool AdjustColorForBackground;
```

#### Conditions
Read / Write
### Contrast

#### Description
Returns the contrast value for the underlay ([0-100]).
```text
public int Contrast;
```

#### Conditions
Read / Write
### ContrastLowerLimit

#### Description
Returns the lower limit of the legal contrast values.
```text
public static int ContrastLowerLimit;
```

#### Conditions
Read-only
### ContrastUpperLimit

#### Description
Returns the upper limit of the legal contrast values.
```text
public static int ContrastUpperLimit;
```

#### Conditions
Read-only
### DefaultContrast

#### Description
Returns the default contrast value.
```text
public static int DefaultContrast;
```

#### Conditions
Read-only
### DefaultFade

#### Description
Returns the default fade value.
```text
public static int DefaultFade;
```

#### Conditions
Read-only
### DefinitionId

#### Description
Returns the object ID of the UnderlayDefinition that this underlay references.
```text
public ObjectId DefinitionId;
```

#### Conditions
Read / Write
### Fade

#### Description
Returns the fade value for the underlay ([0-100]).
```text
public int Fade;
```

#### Conditions
Read / Write
### FadeLowerLimit

#### Description
Returns the lower limit of the legal fade values.
```text
public static int FadeLowerLimit;
```

#### Conditions
Read-only
### FadeUpperLimit

#### Description
Returns the upper limit of the legal fade values.
```text
public static int FadeUpperLimit;
```

#### Conditions
Read-only
### Height

#### Description
Accesses the height of the underlay reference.
```text
public double Height;
```

#### Conditions
Read / Write
### IsClipInverted

#### Description
Accesses the value of the inverted clip flag.
```text
public bool IsClipInverted;
```

#### Conditions
Read / write
### IsClipped

#### Description
Returns a Boolean value indicating whether the clip boundary should be used.
```text
public bool IsClipped;
```

#### Conditions
Read / Write
### IsOn

#### Description
Returns a Boolean indicating whether the underlay content is shown. 
This variable governs the visibility of the underlay content, not its frame or clipping boundary.
```text
public bool IsOn;
```

#### Conditions
Read / Write
### Monochrome

#### Description
Returns a Boolean value indicating whether the underlay content is shown in monochrome.
```text
public bool Monochrome;
```

#### Conditions
Read / Write
### Name

#### Description
Returns the name of the object.
```text
public string Name;
```

#### Conditions
Read / Write
### NameOfSheet

#### Description
Returns the sheet name.
```text
public string NameOfSheet;
```

#### Conditions
Read / Write
### Normal

#### Description
Returns the normal of the underlay.
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
### Path

#### Description
Returns the full path of the underlay.
```text
public string Path;
```

#### Conditions
Read / Write
### Position

#### Description
Returns the position of the underlay in WCS (or block space coordinates if the reference is part of a block).
```text
public Point3d Position;
```

#### Conditions
Read / Write
### Rotation

#### Description
Returns the rotation value around the axis defined by the point returned by position()> and the vector returned by normal().
```text
public double Rotation;
```

#### Conditions
Read / Write
### ScaleFactors

#### Description
Returns the scale factors used to scale the underlay.
```text
public Scale3d ScaleFactors;
```

#### Conditions
Read / Write
### Transform

#### Description
Gets the transformation matrix from the underlay coordinate system to the world coordinate system (or block space coordinates if the underlay is part of a block). the transformation is defined by position()>, normal(), and [rotation()](Autodesk_AutoCAD_DatabaseServices_UnderlayReference_Rotation.md). 
Returns the model to WCS transformation of the underlay.
```text
public Matrix3d Transform;
```

#### Conditions
Read / Write
### UnderlayLayerCollection

#### Description
Returns underlay layers from the database.
```text
public Autodesk.AutoCAD.DatabaseServices.UnderlayLayerCollection UnderlayLayerCollection;
```

#### Conditions
Read-only
### Width

#### Description
Accesses the width of the underlay reference.
```text
public double Width;
```

#### Conditions
Read / Write