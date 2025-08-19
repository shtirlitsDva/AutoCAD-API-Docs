# RasterImage Class

## Overview

#### Description
This .NET class wraps the AcDbRasterImage ObjectARX class. 
The RasterImage entity (or "image entity") works with the RasterImageDef object (or "image definition object") to implement raster images inside AutoCAD. The relationship between these two classes is much like the relationship between an AutoCAD block definition object and a block insert entity. 
The image entity is a drawable, selectable AutoCAD entity that places a raster image in model or paper space at a particular location and orientation. The image entity is linked to exactly one image definition object, to which it sends requests for image processing operations needed for displaying and plotting images. Because the image definition object manages all the image information, the image entity is relatively small. Besides the image location and orientation, it contains a clip boundary, image fade, contrast and brightness parameters and other typical Entity properties like layer and color. 
Two or more image entities can be linked to a single image definition object. Since each image entity has its own clip boundary, this is an efficient way to display different regions of a single raster image at different positions in the drawing. 
The RasterImage entity must sometimes translate between two coordinate systems: 3D model coordinates in which Entities live and 2D pixel coordinates that the RasterImageDef object understands. For this purpose, the image entity carries inside it a planar bounding rectangle, specified in 3D World Coordinates, that outlines the raw image boundary as it floats in space. Several API functions are available to help translate between pixel and model coordinates. 
The image definition object plays a behind-the-scenes role like the block definition, maintaining links to the source image file and managing low-level image processing operations required to display and plot images. Image definition objects are stored in a special AutoCAD dictionary. They are not AutoCAD entities, so they can't be displayed or selected directly by the end user. They understand only 2D pixel coordinates, so all image processing requests must be expressed as 2D operations. 
Image processing operations, like scaling and rotating the image for display, are executed by the Autodesk Image Engine. The Image Engine has its own extensive developer API on which sophisticated image editing applications can be built. (Information on the Autodesk Image Engine is available through the Autodesk Developer Program.)
RasterImage As Complex Entity
The RasterImage entity cannot be used by itself. It must be linked to an RasterImageDef object to display images by using RasterImage.ImageDefId. Furthermore, an RasterImageDefReactor must be constructed and linked to RasterImage entity and RasterImageDef object.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Image
            Autodesk.AutoCAD.DatabaseServices.RasterImage
                Autodesk.AutoCAD.DatabaseServices.GeomapImage
                Autodesk.AutoCAD.DatabaseServices.Wipeout
```

```text
public class RasterImage : Image;
```

#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), [Image](Autodesk_AutoCAD_DatabaseServices_Image.md "Image Class"), RasterImageDef, RasterVariables,

## Members

### Constructors

- [RasterImage](#rasterimage)

### Methods

- [AssociateRasterDef](#associaterasterdef)
- [EnableReactors](#enablereactors)
- [GetClipBoundary](#getclipboundary)
- [GetVertices](#getvertices)
- [ImageSize](#imagesize)
- [SetClipBoundary(Autodesk.AutoCAD.DatabaseServices.ClipBoundaryType, Point2dCollection)](#setclipboundary(autodesk.autocad.databaseservices.clipboundarytype,-point2dcollection))
- [SetClipBoundary(Vector2d)](#setclipboundary(vector2d))
- [SetClipBoundaryToWholeImage](#setclipboundarytowholeimage)

### Properties

- [Brightness](#brightness)
- [ClipBoundaryType](#clipboundarytype)
- [Contrast](#contrast)
- [DisplayOptions](#displayoptions)
- [Fade](#fade)
- [Height](#height)
- [ImageDefId](#imagedefid)
- [ImageHeight](#imageheight)
- [ImageTransparency](#imagetransparency)
- [ImageWidth](#imagewidth)
- [IsClipped](#isclipped)
- [Name](#name)
- [Orientation](#orientation)
- [Path](#path)
- [PixelToModelTransform](#pixeltomodeltransform)
- [Position](#position)
- [ReactorId](#reactorid)
- [Rotation](#rotation)
- [Scale](#scale)
- [ShowImage](#showimage)
- [Width](#width)


## Constructors Details

### RasterImage

#### Description
The constructor for this class is declared protected, so it cannot be accessed directly by most other applications.
```text
public RasterImage();
```

### AssociateRasterDef

#### Description
Associates the raster image def with this object.
```text
public virtual void AssociateRasterDef(
    RasterImageDef definition
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| RasterImageDef definition | Input raster image def |

### EnableReactors

#### Description
Assesses if reactors ought to be enabled or not.
```text
public static void EnableReactors(
    [MarshalAs(UnmanagedType.U1)] bool enable
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool enable | Input boolean switch |

### GetClipBoundary

#### Description
Returns a collection of clip boundary vertices in image pixel coordinates. Invert the PixelToModelTransform matrix to convert these to model coordinates.
```text
public virtual Point2dCollection GetClipBoundary();
```

### GetVertices

#### Description
Returns the image frame vertices to it. These points represent either the four corners of the image, or if the image is clipped, the vertices of a polygonal clip boundary.
```text
public virtual Point3dCollection GetVertices();
```

### ImageSize

#### Description
the raw image size in pixels. (The image size is also available directly from the RasterImageDef object.) 
Under certain rare conditions the cached value will temporarily be different from the value kept in the RasterImageDef object (for example, immediately after the image size has been changed by a raster edit operation but before the RasterImage entity cache is updated). 
If bGetCachedValue is false (default), the image size request is forwarded to the associated RasterImageDef object. If that object can't be opened, then a locally cached value is used. If bGetCachedValue is true, the function is forced to return the cached value.
```text
public virtual Vector2d ImageSize(
    [MarshalAs(UnmanagedType.U1)] bool getCachedValue
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool getCachedValue | Input Boolean indicating whether the cached should be used |

### SetClipBoundary(Autodesk.AutoCAD.DatabaseServices.ClipBoundaryType, Point2dCollection)

#### Description
Specifies a polygonal clip boundary. The clip boundary must be closed, the last point being identical to the first point. The value of type must match the shape of the points in the array.
```text
public virtual void SetClipBoundary(
    Autodesk.AutoCAD.DatabaseServices.ClipBoundaryType type, 
    Point2dCollection clipBoundaryVertices
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.ClipBoundaryType type | Input clip boundary type |
| Point2dCollection clipBoundaryVertices | Input collection of clip boundary vertices |

### SetClipBoundary(Vector2d)

#### Description
Specifies a polygonal clip boundary. The clip boundary must be closed, the last point being identical to the first point. The value of type must match the shape of the points in the array.
```text
public virtual void SetClipBoundary(
    Vector2d size
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vector2d size | Input vector of boundary |

### SetClipBoundaryToWholeImage

#### Description
Sets the clip boundary to coincide with the image borders. Any existing clip boundary is deleted.
```text
public virtual void SetClipBoundaryToWholeImage();
```

### Brightness

#### Description
Accesses the current brightness value of the image.
```text
public virtual byte Brightness;
```

#### Conditions
Read / Write
### ClipBoundaryType

#### Description
Accesses the current clip boundary type.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.ClipBoundaryType ClipBoundaryType;
```

#### Conditions
Read-only
### Contrast

#### Description
Accesses the current contrast value of the image.
```text
public virtual byte Contrast;
```

#### Conditions
Read / Write
### DisplayOptions

#### Description
Accesses the image display options.
```text
public virtual ImageDisplayOptions DisplayOptions;
```

#### Conditions
Read / Write
### Fade

#### Description
Accesses the current fade value of the image.
```text
public virtual byte Fade;
```

#### Conditions
Read / Write
### Height

#### Description
Accesses the height of the raster image in drawing units.
```text
public double Height;
```

#### Conditions
Read-only
### ImageDefId

#### Description
Accesses the objectId of an image entity's image definition object.
```text
public virtual ObjectId ImageDefId;
```

#### Conditions
Read / Write
### ImageHeight

#### Description
Accesses the image's height.
```text
public double ImageHeight;
```

#### Conditions
Read / Write
### ImageTransparency

#### Description
Assesses if the image is transparent or not.
```text
public bool ImageTransparency;
```

#### Conditions
Read / Write
### ImageWidth

#### Description
Accesses the image's width.
```text
public double ImageWidth;
```

#### Conditions
Read-only
### IsClipped

#### Description
Assesses if the image is clipped.
```text
public virtual bool IsClipped;
```

#### Conditions
Read-only
### Name

#### Description
Accesses the name of the image.
```text
public string Name;
```

#### Conditions
Read / Write
### Orientation

#### Description
Accesses the position and orientation of an image entity. These vectors lie along the outer edge of the unclipped image. The clipped image may be smaller than the rectangle specified by these vectors.
```text
public virtual CoordinateSystem3d Orientation;
```

#### Conditions
Read / Write
### Path

#### Description
Accesses the filename of the image.
```text
public string Path;
```

#### Conditions
Read-only
### PixelToModelTransform

#### Description
Accesses an affine transformation from image source pixels to model coordinates.
```text
public virtual Matrix3d PixelToModelTransform;
```

#### Conditions
Read-only
### Position

#### Description
Accesses the insertion point.
```text
public Point3d Position;
```

#### Conditions
Read-only
### ReactorId

#### Description
Accesses the objectId of an image entity's reactor.
```text
public virtual ObjectId ReactorId;
```

#### Conditions
Read / Write
### Rotation

#### Description
Accesses the rotation in radians.
```text
public double Rotation;
```

#### Conditions
Read / Write
### Scale

#### Description
Accesses the effective _XY_ scale factor for this image entity, expressed as image size in user units (as inserted and scaled into model space) divided by the original image size (derived from the image resolution specified in the image file.) 
**Example** If the image started as an 8.5"x11" sheet of paper, but is inserted in the AutoCAD drawing so that it measures 85"x110", then the scale factor is 10. 
**Exception** If no resolution information is available for the image or if the user hasn't specified what one AutoCAD unit means (inch, meter, and so on, accessible through RasterVariables.UserScale), then the image width is assumed to be one AutoCAD unit for purposes of computing the scale factor. 
```text
public virtual Vector2d Scale;
```

#### Conditions
Read-only
### ShowImage

#### Description
Accesses the show parameter of the display options.
```text
public bool ShowImage;
```

#### Conditions
Read / Write
### Width

#### Description
Accesses the width of the raster image.
```text
public double Width;
```

#### Conditions
Read-only