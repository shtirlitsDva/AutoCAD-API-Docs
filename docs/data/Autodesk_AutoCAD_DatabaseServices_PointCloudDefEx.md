# PointCloudDefEx Class

## Overview

#### Description
The PointCloudDefEx object (or "point cloud extension definition object") controls the actual point cloud data associated with one or more PointCloudEx entities (or "point cloud extension entity"). These objects link the .rcp/.rcs file to the dwg file, similar to how Xrefs work. 
The relationship between the PointCloudDefEx and PointCloudEx classes is much like the relationship between an AutoCAD block definition object and a block reference entity. 
PointCloudDefEx objects are stored in a special db dictionary named "ACAD_POINTCLOUD_EX_DICT". These objects are not AutoCAD entities, so they cannot be displayed or selected by the end user.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.PointCloudDefEx
```

```text
public class PointCloudDefEx : DBObject;
```

### Constructors

- [PointCloudDefEx](#pointclouddefex)

### Methods

- [classVersion](#classversion)
- [getAllRcsFilePaths](#getallrcsfilepaths)
- [getRcsFilePath](#getrcsfilepath)
- [load](#load)
- [unload](#unload)

### Properties

- [ActiveFileName](#activefilename)
- [defaultHeight](#defaultheight)
- [defaultLength](#defaultlength)
- [defaultWidth](#defaultwidth)
- [EntityCount](#entitycount)
- [extents](#extents)
- [FileType](#filetype)
- [SourceFileName](#sourcefilename)
- [totalPointsCount](#totalpointscount)
- [totalRegionsCount](#totalregionscount)
- [totalScansCount](#totalscanscount)


## Constructors Details

### PointCloudDefEx

#### Description
This is PointCloudDefEx, a member of class PointCloudDefEx.
```text
public PointCloudDefEx();
```

### classVersion

#### Description
Returns the class version number that indicates which version of AcDbPointCloudEx this object represents. This is primarily used during filing operations to determine what data to read or write.
```text
public static int classVersion();
```

### getAllRcsFilePaths

#### Description
Gets the list which contains all RCS filepath.
```text
public string\[\] getAllRcsFilePaths();
```

### getRcsFilePath

#### Description
Gets the file path of specified RCS.
```text
public string getRcsFilePath(
    string guid
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string guid | Specifies the GUID of the RCS |

#### Returns
Returns the filepath.
### load

#### Description
Loads point cloud data from the source point cloud file. If the point cloud is already loaded, true is returned. This will notifies all dependent AcDbPointCloudEx entities to be redrawn.
```text
public bool load();
```

#### Returns
Returns true if successful.
#### Remarks
For Internal Use.
### unload

#### Description
Unloads all point cloud data in the AcDbPointCloudDefEx immediately, but does not delete the AcDbPointCloudDefEx itself. This method notifies all dependent AcDbPointCloudEx entities to be redrawn.
```text
public bool unload();
```

#### Returns
Returns true if successful.
#### Remarks
For Internal Use.
### ActiveFileName

#### Description
Sets the active path name of the externally referenced point cloud file. The active path points to the file that is actually used to define the point cloud in the current drawing. However, the active path is not persistent, and is not saved in the drawing file. If pathname does not point to a valid point cloud file, then the active path is unchanged.
```text
public string ActiveFileName;
```

#### Conditions
Read / Write
### defaultHeight

#### Description
Returns the default extent's height of the point cloud file.
```text
public double defaultHeight;
```

#### Conditions
Read / Write
### defaultLength

#### Description
Returns the default extent's length of the point cloud file.
```text
public double defaultLength;
```

#### Conditions
Read / Write
### defaultWidth

#### Description
Returns the default extent's width of the point cloud file.
```text
public double defaultWidth;
```

#### Conditions
Read / Write
### EntityCount

#### Description
Returns the number of AcDbPointCloudEx entities in the current drawing.
```text
public int EntityCount;
```

#### Conditions
Read / Write
### extents

#### Description
Gets the whole extents of attached point cloud.
```text
public Extents3d extents;
```

#### Conditions
Read / Write
### FileType

#### Description
Returns the file extension of this definition's point cloud file. There are two types: RCP for a ReCap Project file; RCS for a ReCap Scan file.
```text
public string FileType;
```

#### Conditions
Read / Write
### SourceFileName

#### Description
Sets the pathname of a externally referenced point cloud file. The point cloud filepath name is stored when the current drawing is saved. The point cloud extension definition is initialized and a file descriptor is created for access to the point cloud file.
```text
public string SourceFileName;
```

#### Conditions
Read / Write
### totalPointsCount

#### Description
Returns the total point count for the point cloud file.
```text
public long totalPointsCount;
```

#### Conditions
Read / Write
### totalRegionsCount

#### Description
Returns the total region count for the point cloud file.
```text
public int totalRegionsCount;
```

#### Conditions
Read / Write
### totalScansCount

#### Description
Returns the total scan count for the point cloud file.
```text
public int totalScansCount;
```

#### Conditions
Read / Write