# RasterImageDef Class

## Overview

#### Description
This .NET class wraps the AcDbRasterImageDef ObjectARX class. 
The RasterImageDef object (or "image definition object") works with the RasterImage entity (or "image entity") to implement raster images inside AutoCAD. The relationship between these two classes is much like the relationship between an AutoCAD block definition object and a block insert entity. 
The image definition object plays a behind-the-scenes role like the block definition, maintaining links to the source image file and managing low-level image processing operations required to display and plot images. Image definition objects are stored in a special Dictionary named ISM_RASTER_IMAGE_DICT. These objects are not AutoCAD entities, so they can't be displayed or selected directly by the end user. They handle only 2D pixel coordinates, so all image processing requests must be expressed as 2D operations. 
Image processing operations like scaling and rotating the image for display are executed by the Autodesk Image Engine. The Image Engine has its own extensive developer API on which sophisticated image editing applications can be built. (Information on the Autodesk Image Engine is available through the Autodesk Developer Program.) 
Refer to the description of class RasterImage for more information.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.RasterImageDef
```

```text
public class RasterImageDef : DBObject;
```

#### See Also
DBObject, RasterImage, RasterImageDefReactor, RasterVariables

## Members

### Constructors

- [RasterImageDef](#rasterimagedef)

### Methods

- [CloseImage](#closeimage)
- [CreateImageDictionary](#createimagedictionary)
- [Embed](#embed)
- [GetEntityCount](#getentitycount)
- [GetImageDictionary](#getimagedictionary)
- [ImageCopy](#imagecopy)
- [Load](#load)
- [LocateActivePath](#locateactivepath)
- [OpenImage](#openimage)
- [SetImage](#setimage)
- [SuggestName](#suggestname)
- [Unload](#unload)
- [UpdateEntities](#updateentities)

### Properties

- [ActiveFileName](#activefilename)
- [ColorDepth](#colordepth)
- [FileDescCopy](#filedesccopy)
- [FileType](#filetype)
- [ImageModified](#imagemodified)
- [IsEmbedded](#isembedded)
- [IsLoaded](#isloaded)
- [Organization](#organization)
- [ResolutionMMPerPixel](#resolutionmmperpixel)
- [ResolutionUnits](#resolutionunits)
- [SearchForActivePath](#searchforactivepath)
- [Size](#size)
- [SourceFileName](#sourcefilename)
- [UndoStoreSize](#undostoresize)


## Constructors Details

### RasterImageDef

#### Description
Default constructor.
```text
public RasterImageDef();
```

### CloseImage

#### Description
Closes the associated image data object, and updates any changes to the image instances in AutoCAD.
```text
public virtual void CloseImage();
```

### CreateImageDictionary

#### Description
Call this function to create a new image dictionary if the function RasterImageDef.GetImageDictionary returns 0, indicating that no image dictionary exists.
```text
public static ObjectId CreateImageDictionary(
    Database database
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database database | Input AutoCAD database in which to create the dictionary |

### Embed

#### Description
This function is currently unimplemented, but may appear in a future release.
```text
public virtual void Embed();
```

### GetEntityCount

#### Description
Returns the number of RasterImage entities in the current drawing that are dependent upon this object for display graphics. If locked is non-zero, then this function will set the value to true if any dependent entities reside on locked layers.
```text
public virtual int GetEntityCount(
    out bool locked
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| out bool locked | Input locked value |

### GetImageDictionary

#### Description
Returns the object ID of the image dictionary in the specified drawing database or 0 if the dictionary was not found.
```text
public static ObjectId GetImageDictionary(
    Database database
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database database | Input AutoCAD database in which to find the dictionary |

### ImageCopy

#### Description
Creates a copy of the image data, and returns a pointer to it. 
**Note**
Since the ATIL Engine doesn't make a physical copy of the image unless or until the original or the copy is modified, this function can be used for efficient read-only access to the source image data.
```text
public virtual IntPtr ImageCopy(
    [MarshalAs(UnmanagedType.U1)] bool forceImageLoad
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool forceImageLoad | Input Boolean indicating whether to load the image if it is not currently loaded |

### Load

#### Description
This function enables "lazy loading" of the image pixel data from the source image file (specified by RasterImageDef.SourceFileName) into an ATIL object. Requires that the RasterImageDef be open for writing. Triggers notification that causes all dependent RasterImage entities to be redrawn. 
Note that with lazy loading, the image isn't physically loaded into memory until it is required (for example, to appear on the screen.) A delay may be noticed later when the image is physically loaded.
```text
public virtual void Load();
```

### LocateActivePath

#### Description
Returns the path name of the actual file being currently used to define the image. Requires that the RasterImageDef be open for reading.
```text
public string LocateActivePath();
```

### OpenImage

#### Description
Returns the associated image data object for writing. (See ATIL documentation for information about the Atil.Image class.) Each call to OpenImage must eventually be followed by a call to RasterImageDef.CloseImage(). 
This function is intended for use by raster editing application developers for image modification operations only. (Use RasterImageDef.ImageCopy() for read-only access to the image data.) The image returned by this function is the image being displayed. Any modifications to that image will appear the next time the image is redrawn. A copy of the image is automatically saved for Undo. 
You may call OpenImage, then close the RasterImageDef object without calling CloseImage. This is called a "long term write lock." You can modify the image data at will while you hold the Atil.Image pointer. Any changes made in the image data appear the next time the image entities are redrawn. The write lock should not be held so long as to interfere with other user commands such as Image Reload, Unload and Detach.
```text
public virtual IntPtr OpenImage();
```

### SetImage

#### Description
Directly specifies an in-memory Atil.Image or a custom Atil.FileReadDescriptor to be used. Either image or fileDescription can be null, but not both. Copies of the Atil.Image and Atil.FileReadDescriptor are retained by the RasterImageDef, so the caller's copy of these objects may be deleted at any time. 
This function is intended for use by raster editing application developers. 
The Loaded status must be false when this function is called. It can be used to construct an RasterImageDef object in lieu of calling ActiveFileName. 
If image is not null and is valid, the "loaded" status is set true. Otherwise, "loaded" status is set to false. If image is null, then fileDescription must be a valid read or write Atil.FileReadDescriptor from which an image can be read on demand. 
If fileDescription is not null and is valid, resolution and file type information is extracted from it. If fileDescription has a valid file path, it is used as the "active path." Otherwise, "active path" is set to the null string. 
If modifyDatabase is true, undo recording will be done for changes made to the RasterImageDef object. 
Use ImageModified and the RasterImageDefReactor mechanism to be notified of attempts to delete this image. Otherwise, the user may be able to Unload or Reload the image through the user interface, possibly losing image data that hasn't been saved to disk.
```text
public virtual void SetImage(
    IntPtr image, 
    IntPtr fileDescription, 
    [MarshalAs(UnmanagedType.U1)] bool modifyDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IntPtr image | Input NULL or pointer to valid Atil::Image object |
| IntPtr fileDescription | Input NULL or pointer to valid Atil::FileReadDescriptor object |
| [MarshalAs(UnmanagedType.U1)] bool modifyDatabase | Input Boolean indicating whether to do undo recording |

### SuggestName

#### Description
Operates on the original image file name to produce a string as similar as possible to the original file name, but suitable for use in the image dictionary. 
Returns a string containing a unique name suitable for use in the image dictionary.
```text
public static string SuggestName(
    DBDictionary imageDictionary, 
    string newImagePathName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DBDictionary imageDictionary | Input pointer to the (previously opened for reading) image dictionary within which this name must be unique |
| string newImagePathName | Input pointer to a string containing the source image file or path name |

### Unload

#### Description
Immediately unloads the image data in RasImageDef from the Image Engine's working memory, but does not delete the RasImageDef itself. Triggers notification that causes all dependent RasterImage entities are redrawn as frames only. Requires that the RasterImageDef be open for writing. 
If modifyDatabase is true, then undo recording will be done for the changes made to the RasterImageDef object.
```text
public virtual void Unload(
    [MarshalAs(UnmanagedType.U1)] bool modifyDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool modifyDatabase | Input Boolean indicating whether or not to do undo recording |

### UpdateEntities

#### Description
Causes all the RasterImage entities in the current drawing that are dependent upon this object to be redrawn when this object is next closed. This function requires that the image definition be open for writing. 
**Note**
The dependent image entities will be updated automatically after any RasterImageDef modification operation (for example, load, unload, closeImage.) This function is needed only by applications modifying the underlying raster image through the Image Engine API after having executed openImage to get a pointer to the image data.
```text
public virtual void UpdateEntities();
```

### ActiveFileName

#### Description
Accesses the path name of the actual file being currently used to define the image. Requires that the RasterImageDef be open for reading.
```text
public virtual string ActiveFileName;
```

#### Conditions
Read / Write
### ColorDepth

#### Description
Accesses the number of bits per pixel for the source image data. Possible values are 1, 8, 24, or 32.
```text
public virtual int ColorDepth;
```

#### Conditions
Read-only
### FileDescCopy

#### Description
Accesses a copy to this object's Atil.FileReadDescriptor member. If this object does not have a valid Atil.FileReadDescriptor, null is returned.
```text
public virtual IntPtr FileDescCopy;
```

#### Conditions
Read-only
### FileType

#### Description
Accesses the type of image file, such as BMP for a Windows bitmap.
```text
public virtual string FileType;
```

#### Conditions
Read-only
### ImageModified

#### Description
Accesses the state of the internal "image data modified" flag, which is true if the image has been modified.
```text
public virtual bool ImageModified;
```

#### Conditions
Read / Write
### IsEmbedded

#### Description
Assesses if the image is embedded in the drawing file
```text
public virtual bool IsEmbedded;
```

#### Conditions
Read-only
### IsLoaded

#### Description
Assesses if the image is loaded. 
Note that due to lazy loading, the image may not be physically loaded in memory, even though IsLoaded returns true.
```text
public virtual bool IsLoaded;
```

#### Conditions
Read-only
### Organization

#### Description
Accesses the pixel organization scheme of the source image file. Requires that the image be loaded to work properly. If the image is not loaded, the value RGBA is returned.
```text
public virtual ImageOrg Organization;
```

#### Conditions
Read-only
### ResolutionMMPerPixel

#### Description
Accesses the default physical size of a single image pixel in millimeters. If the image has no default resolution, then this function returns pixel height and width values equal to 1/width of image in pixels.
```text
public virtual Vector2d ResolutionMMPerPixel;
```

#### Conditions
Read / Write
### ResolutionUnits

#### Description
Accesses the units in which the image resolution was specified in the source image file. If the image file doesn't contain resolution information, then a value of None is returned.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.Unit ResolutionUnits;
```

#### Conditions
Read / Write
### SearchForActivePath

#### Description
This searches the local drives and network for a valid image file that matches the source file name that is saved in the drawing file. This mechanism allows image files to be located differently on machines that are used for editing or viewing the same drawing file. Users can set up project search paths that contain directories in which image and xref files may be contained. 
The search for a valid image file follows a specific order. First, the source file name (the path name set by SourceFileName and saved in the drawing) is checked as is. If it doesn't indicate a valid image file, then the file name is extracted from the path.
```text
public virtual string SearchForActivePath;
```

#### Conditions
Read-only
#### Notes
For example, a path of _c:imagespicture1.bmp_ has the filename _picture1.bmp_. This file name is then searched for in each of a series of directories specified by the current project, followed by the standard AutoCAD paths. 
The search order is as follows: 
  1. The source file name as specified by RasterImageDef.SourceFileName.
  2. The current project directories in order.
  3. The current directory.
  4. The directory that contains the current drawing file.
  5. The directories named by the ACAD environment variable (if this variable has been specified).
  6. The directory that contains the AutoCAD program files.

The first valid image file that is found will terminate the search. If the file extension is omitted from the file name, then all files with the same base file name (_picture1, picture1.txt, picture1_._exe,_ etc.) are also checked for validity as image files.
### Size

#### Description
Accesses the raw image size in pixels.
```text
public virtual Vector2d Size;
```

#### Conditions
Read-only
### SourceFileName

#### Description
Accesses the path name of the externally referenced image file name. This file name is saved in the DWG file with the object. Requires that the RasterImageDef be open for reading.
```text
public virtual string SourceFileName;
```

#### Conditions
Read / Write
### UndoStoreSize

#### Description
Accesses the current value of the Undo store size.
```text
public virtual int UndoStoreSize;
```
