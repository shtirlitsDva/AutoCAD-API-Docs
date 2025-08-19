# PointCloudEx Class

## Overview

#### Description
The PointCloudEx entity (or "point cloud extension entity") works with the AcDbPointCloudDefEx object (or "point cloud extension definition object") to manage point cloud data inside AutoCAD. The relationship between these two classes is much like the relationship between an AutoCAD block definition object and a block reference entity. 
The PointCloudEx entity is a drawable, selectable AutoCAD entity that places point cloud data in model or paper space at a particular location and orientation, and with a particular scale. It also contains crop boundaries, scan and region visibilities, stylization types, color mapping schemes, a limit box, and other typical AcDbEntity properties, like layer. 
The PointCloudEx entity cannot be used by itself. It must be linked to an AcDbPointCloudDefEx object by calling PointCloudEx::setPointCloudDefExId(). 
Furthermore, an AcDbPointCloudDefReactorEx must be constructed and linked to each PointCloudEx entity and AcDbPointCloudDefEx object.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.PointCloudEx
```

```text
public class PointCloudEx : Entity;
```

### Constructors

- [PointCloudEx](#pointcloudex)

### Methods

- [addCroppingBoundary](#addcroppingboundary)
- [AttachPointCloud](#attachpointcloud)
- [clearCropping](#clearcropping)
- [findRegionItem](#findregionitem)
- [findScanItem](#findscanitem)
- [GetColorSchemeForStylization](#getcolorschemeforstylization)
- [getCroppingCount](#getcroppingcount)
- [getPointCloudCropping](#getpointcloudcropping)
- [getPointCloudDataList](#getpointclouddatalist)
- [GetScanViewInfo](#getscanviewinfo)
- [HasProperty](#hasproperty)
- [removeLastCropping](#removelastcropping)
- [setAllRegionsVisibility](#setallregionsvisibility)
- [setAllScansVisibility](#setallscansvisibility)
- [SetColorSchemeForStylization](#setcolorschemeforstylization)
- [setRegionVisibility](#setregionvisibility)
- [setScanVisibility](#setscanvisibility)
- [TransformBy](#transformby)

### Properties

- [ActiveFileName](#activefilename)
- [CroppingInverted](#croppinginverted)
- [CurrentColorScheme](#currentcolorscheme)
- [ElevationApplyToFixedRange](#elevationapplytofixedrange)
- [ElevationGradient](#elevationgradient)
- [ElevationOutOfRangeBehavior](#elevationoutofrangebehavior)
- [GeomExtents](#geomextents)
- [IntensityGradient](#intensitygradient)
- [IntensityOutOfRangeBehavior](#intensityoutofrangebehavior)
- [LimitBoxBound](#limitboxbound)
- [Location](#location)
- [MinMaxElevation](#minmaxelevation)
- [MinMaxIntensity](#minmaxintensity)
- [NativeExtents](#nativeextents)
- [PointCloudDefExId](#pointclouddefexid)
- [Rotation](#rotation)
- [Scale](#scale)
- [ShowCropped](#showcropped)
- [Stylization](#stylization)


## Constructors Details

### PointCloudEx

#### Description
This is PointCloudEx, a member of class PointCloudEx.
```text
public PointCloudEx();
```

### addCroppingBoundary

#### Description
Adds a new cropping boundary to this point cloud entity.
```text
public void addCroppingBoundary(
    PointCloudCrop cropping
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PointCloudCrop cropping | An AcDbPointCloudCrop object which is to be added. |

### AttachPointCloud

#### Description
Create a PointCloudEx entity.
```text
public static ObjectId AttachPointCloud(
    string filename, 
    Point3d location, 
    double scale, 
    double rotation, 
    Database db
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string filename | Point cloud source file path. This represent the original filepath use to cerate the index. This entry can be blank. |
| Point3d location | Location of point cloud entity. If entity is inserted at 0,0,0 the points will appear where they are located in the point cloud. |
| double scale | Scale factor. 1.0 is default scale, and cannot less than 0.0 |
| double rotation | Rotation Angle in degrees. 0 is default rotation |
| Database db | Returns object id of created PointCloudEx |

### clearCropping

#### Description
Removes all cropping boundaries on this point cloud entity.
```text
public bool clearCropping();
```

#### Returns
Returns true if successful or false otherwise.
### findRegionItem

#### Description
Gets the region item by its ID in the point cloud. The region ID is stored in the RCP file.
```text
public PointCloudItem findRegionItem(
    int regionId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int regionId | The region ID to be returned. |

### findScanItem

#### Description
Gets a scan item by the scan GUID in the point cloud.
```text
public PointCloudItem findScanItem(
    string scanGuid
);
```

### GetColorSchemeForStylization

#### Description
Returns the color scheme name based on the given stylization mode. This property only applies when the point cloud is being displayed using a stylization mode that has a color ramp. Returns an empty string if the stylization mode is not kIntensityRamp, kHeightRamp, or kClassificationRamp.
```text
public string GetColorSchemeForStylization(
    PointCloudStylizationType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PointCloudStylizationType type | Indicates a stylization type. |

#### Returns
Returns the GUID of corresponding color scheme.
#### Remarks
For Internal Use.
### getCroppingCount

#### Description
Returns the number of cropping boundaries that are set on this entity.
```text
public int getCroppingCount();
```

### getPointCloudCropping

#### Description
Returns a cropping boundary by index, for editing. Requires that the AcDbPointCloudEx be open for writing.
```text
public PointCloudCrop getPointCloudCropping(
    int index
);
```

### getPointCloudDataList

#### Description
Get the list of PointCloudItem, which includes the scan items and region items.
```text
public List<PointCloudItem> getPointCloudDataList();
```

### GetScanViewInfo

#### Description
Gets the origin location and extents of a scan item specified the scan guid.
```text
public bool GetScanViewInfo(
    string scanGuid, 
    out ValueType modopt(Point3d) modopt(IsBoxed) origin, 
    out ValueType modopt(Extents3d) modopt(IsBoxed) extent
);
```

### HasProperty

#### Description
Gets the state if the point cloud contains intensity, classification, elevation, etc.
```text
public PointCloudPropertyState HasProperty(
    PointCloudProperty prop
);
```

### removeLastCropping

#### Description
Removes most recently added cropping boundary from this point cloud entity.
```text
public bool removeLastCropping();
```

#### Returns
Returns true if successful or false otherwise.
### setAllRegionsVisibility

#### Description
Sets whether or not all regions are visible.
```text
public void setAllRegionsVisibility(
    [MarshalAs(UnmanagedType.U1)] bool visible, 
    [MarshalAs(UnmanagedType.U1)] bool includeUnassigned
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool visible | The visibility for all regions. |
| [MarshalAs(UnmanagedType.U1)] bool includeUnassigned | true or false, whether or not set the bVisible to unassigned points |

### setAllScansVisibility

#### Description
Sets whether or not all scans are visible.
```text
public void setAllScansVisibility(
    [MarshalAs(UnmanagedType.U1)] bool visible
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool visible | The visibility of all scans. |

### SetColorSchemeForStylization

#### Description
Sets the current color scheme based on the given stylization mode. This property only applies when the point cloud is being displayed using a stylization mode that has a color ramp. If the color scheme guid doesn't exist, the color scheme will not take effect.
```text
public void SetColorSchemeForStylization(
    string name, 
    PointCloudStylizationType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Indicates the name of a color scheme to be set. |
| PointCloudStylizationType type | Indicates a stylization type |

#### Remarks
For Internal Use.
### setRegionVisibility

#### Description
Sets whether or not a specified region is visible. This function can be used to set visibility of any region, or to points that are not assigned to any region. If the given region ID is outside of the range of valid region IDs, there is no change.
```text
public void setRegionVisibility(
    int regionId, 
    [MarshalAs(UnmanagedType.U1)] bool visible
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int regionId | The region ID |
| [MarshalAs(UnmanagedType.U1)] bool visible | The region's visibility |

### setScanVisibility

#### Description
Sets whether or not a scan is visible. This method does nothing if the scan GUID does not exist.
```text
public void setScanVisibility(
    string scanGuid, 
    [MarshalAs(UnmanagedType.U1)] bool visible
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string scanGuid | The scan GUID |
| [MarshalAs(UnmanagedType.U1)] bool visible | Whether or not the scan is visible |

### TransformBy

#### Description
Transform the PointCloudEx with the input matrix.
```text
public bool TransformBy(
    Matrix3d xform
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Matrix3d xform | The input transform matrix. |

#### Returns
Returns true if successful.
### ActiveFileName

#### Description
Gets the active path name of the externally referenced point cloud file.
```text
public string ActiveFileName;
```

#### Conditions
Read / Write
### CroppingInverted

#### Description
Gets or sets whether cropping on this entity is currently inverted.
```text
public bool CroppingInverted;
```

#### Conditions
Read / Write
### CurrentColorScheme

#### Description
Gets or sets the current color scheme name that corresponds to the current stylization mode. This property only applies when the point cloud is being displayed using a stylization mode that has a color ramp. This method returns an empty string if the stylization mode is not kIntensityRamp, kHeightRamp, or kClassificationRamp.
```text
public string CurrentColorScheme;
```

#### Remarks
For Internal Use.
#### Conditions
Read / Write
### ElevationApplyToFixedRange

#### Description
Gets or sets whether or not the elevation range update dynamically as the extents of the limit box change.
```text
public bool ElevationApplyToFixedRange;
```

#### Remarks
For Internal Use
#### Conditions
Read / Write
### ElevationGradient

#### Description
Gets or sets whether show Elevation in gradient.
```text
public bool ElevationGradient;
```

#### Remarks
For Internal Use
#### Conditions
Read / Write
### ElevationOutOfRangeBehavior

#### Description
Gets or sets the current display option for any points which are out of elevation range.
```text
public PointCloudDispOptionOutOfRange ElevationOutOfRangeBehavior;
```

#### Remarks
For Internal Use.
#### Conditions
Read / Write
### GeomExtents

#### Description
Geometry extents of point cloud.
```text
public Extents3d GeomExtents;
```

#### Conditions
Read / Write
### IntensityGradient

#### Description
Gets or sets whether show Intensity in gradient.
```text
public bool IntensityGradient;
```

#### Remarks
For Internal Use.
#### Conditions
Read / Write
### IntensityOutOfRangeBehavior

#### Description
Gets or sets the current display option for the points which are out of intensity range
```text
public PointCloudDispOptionOutOfRange IntensityOutOfRangeBehavior;
```

#### Remarks
For Internal Use.
#### Conditions
Read / Write
### LimitBoxBound

#### Description
Gets the bound of limit box.
```text
public Tuple<double, double> LimitBoxBound;
```

#### Remarks
For Internal Use.
#### Conditions
Read / Write
### Location

#### Description
Get or set the location in the drawing where the base point of the point cloud is attached.
```text
public Point3d Location;
```

#### Conditions
Read / Write
### MinMaxElevation

#### Description
Get or sets the range (min/max values) of the elevation colorization range.
```text
public Tuple<double, double> MinMaxElevation;
```

#### Remarks
For Internal Use.
#### Conditions
Read / Write
### MinMaxIntensity

#### Description
Gets or sets the range (min/max values) of the current intensity colorization range.
```text
public Tuple<int, int> MinMaxIntensity;
```

#### Remarks
For Internal Use
#### Conditions
Read / Write
### NativeExtents

#### Description
Returns the non-translated native 3D extent of the point cloud in ECS, which is taken from point cloud data file directly.
```text
public Extents3d NativeExtents;
```

#### Conditions
Read / Write
### PointCloudDefExId

#### Description
Object Id of PointCloudDefEx.
```text
public ObjectId PointCloudDefExId;
```

#### Conditions
Read / Write
### Rotation

#### Description
Gets or sets the rotation angle of the point cloud in the current UCS.
```text
public double Rotation;
```

#### Conditions
Read / Write
### Scale

#### Description
Gets or sets the scale factor of the point cloud.
```text
public double Scale;
```

#### Remarks
The user may give a customized scale, while the point cloud may have a unit factor based on current drawing. The input scale factor is the product of the customized scale and the unit factor.
#### Conditions
Read / Write
### ShowCropped

#### Description
Gets or sets whether or not this entity should show the cropped point cloud.
```text
public bool ShowCropped;
```

#### Conditions
Read / Write
### Stylization

#### Description
This is Stylization, a member of class PointCloudEx.
```text
public PointCloudStylizationType Stylization;
```
