# GeomapImage Class

## Overview

#### Description
The GeomapImage class represents an embedded raster image which is captured from a portion of LiveMap.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Image
            Autodesk.AutoCAD.DatabaseServices.RasterImage
                Autodesk.AutoCAD.DatabaseServices.GeomapImage
```

```text
public class GeomapImage : RasterImage;
```

### Constructors

- [GeomapImage](#geomapimage)

### Methods

- [GetImageVertices](#getimagevertices)
- [GetVertices](#getvertices)
- [ImageSize](#imagesize)
- [UpdateMapImage](#updatemapimage)

### Properties

- [BottomLeftPoint](#bottomleftpoint)
- [Brightness](#brightness)
- [Contrast](#contrast)
- [Fade](#fade)
- [Height](#height)
- [ImageBottomLeftPoint](#imagebottomleftpoint)
- [ImageHeight](#imageheight)
- [ImageWidth](#imagewidth)
- [IsOutOfDate](#isoutofdate)
- [LOD](#lod)
- [MapType](#maptype)
- [Resolution](#resolution)
- [Width](#width)


## Constructors Details

### GeomapImage

#### Description
This is GeomapImage, a member of class GeomapImage.
```text
public GeomapImage();
```

### GetImageVertices

#### Description
This is GetImageVertices, a member of class GeomapImage.
```text
public virtual Point3dCollection GetImageVertices();
```

### GetVertices

#### Description
Gets the 4 corner points of the embeded image.
```text
public override Point3dCollection GetVertices();
```

#### Returns
Point3dCollection
### ImageSize

#### Description
The size of the embeded image in pixel.
```text
public virtual Vector2d ImageSize();
```

#### Returns
Vector2d
### UpdateMapImage

#### Description
Update the embeded image by re-capturing the live map.
```text
public bool UpdateMapImage(
    [MarshalAs(UnmanagedType.U1)] bool Reset
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool Reset | Input Boolean to indicate whether to recapture the image in optimal resolution to the screen. If true, the L |

### BottomLeftPoint

#### Description
The original point in the bottom left corner of the image frame. 
Point3d
```text
public Point3d BottomLeftPoint;
```

#### Remarks
This property is read only. 
This wraps the AcDbGeoMap:bottomLeftPt() method. 
Example
<![CDATA[Point3d pt = GeomapImage.BottomLeftPoint;}]]>
### Brightness

#### Description
The brightness of the map image.
```text
public override byte Brightness;
```

Example
<![CDATA[Byte brightness = GeomapImage.Brightness;]]>
### Contrast

#### Description
The brightness of the map image.
```text
public override byte Contrast;
```

Example
<![CDATA[Byte contrast = GeomapImage.Contrast;]]>
### Fade

#### Description
The brightness of the map image.
```text
public override byte Fade;
```

Example
<![CDATA[Byte fade = GeomapImage.Fade;]]>
### Height

#### Description
Height of the Geomap Image frame. 
double
```text
public double Height;
```

#### Remarks
This property is read only. 
This property wraps AcDbGeoMap::height() method. 
Example
<![CDATA[double height = GeomapImage.Height;]]>
### ImageBottomLeftPoint

#### Description
The original point in the bottom left corner of the embeded image. 
Point3d
```text
public Point3d ImageBottomLeftPoint;
```

#### Remarks
This property is read only. 
This wraps the AcDbGeoMap:imageBottomLeftPt() method. 
Example
<![CDATA[Point3d pt = GeomapImage.ImageBottomLeftPoint;}]]>
### ImageHeight

#### Description
Height of the Geomap embeded image. 
double
```text
public double ImageHeight;
```

#### Remarks
This property is read only. 
This property wraps AcDbGeoMap::imageHeight() method. 
Example
<![CDATA[double height = GeomapImage.ImageHeight;]]>
### ImageWidth

#### Description
Width of the Geomap embeded image. 
double
```text
public double ImageWidth;
```

#### Remarks
This property is read only. 
This property wraps the AcDbGeoMap::imageWidth() method. 
Example
<![CDATA[double width = GeomapImage.ImageWidth;]]>
### IsOutOfDate

#### Description
A flag to indicate whether the image is up to date. 
bool
```text
public bool IsOutOfDate;
```

#### Remarks
This property is read only. 
This method wraps the AcDbGeoMap.isOutOfDate() method. 
Example
<![CDATA[bool outOfDate = GeomapImage.IsOutOfDate;]]>
### LOD

#### Description
Map Level Of Details (Zoom level) at the point of captured. Update will reset this value. 
System::UInt32
```text
public uint LOD;
```

#### Remarks
This property is read only. 
This property wraps the AcDbGeoMap::LOD() method. 
Example
<![CDATA[UInt32 lod = GeomapImage.LOD;]]>
### MapType

#### Description
The map type of the map image as an enumerated value.
```text
public GeomapType MapType;
```

Example
<![CDATA[GeomapMapType mapType = GeomapImage.MapType;]]>
### Resolution

#### Description
The resolution of the image as an enumerated value that apply on top of LOD.
```text
public GeomapResolution Resolution;
```

Example
<![CDATA[GeomapResolution resolution = GeomapImage.Resolution;]]>
### Width

#### Description
Width of the Geomap Image. 
double
```text
public double Width;
```

#### Remarks
This property is read only. 
This property wraps the AcDbGeoMap::width() method. 
Example
<![CDATA[double width = GeomapImage.Width;]]>