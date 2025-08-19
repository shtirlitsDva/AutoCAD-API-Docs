# GeoLocationData Class

## Overview

#### Description
This .NET class wraps the AcDbGeoData ObjectARX class. 
This class maintains geo-location data, including DwgPoint, UpDirection, NorthDirection in drawing space, and latitude, longitude and elevation in geographic space. It is stored in the extension dictionary of model space block table record of BlockTableRecord object. 
GeoLocationData also provides coordinate transformation functions to convert coordinates between DWG drawing space and geographic space. 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.GeoLocationData
```

```text
public class GeoLocationData : DBObject;
```

### Constructors

- [GeoLocationData](#geolocationdata)

### Methods

- [AddMeshPointMap](#addmeshpointmap)
- [EraseFromDb](#erasefromdb)
- [GetMeshPointMap](#getmeshpointmap)
- [GetMeshPointMaps](#getmeshpointmaps)
- [PostToDb](#posttodb)
- [ResetMeshPointMaps](#resetmeshpointmaps)
- [SetMeshPointMaps](#setmeshpointmaps)
- [TransformFromLonLatAlt](#transformfromlonlatalt)
- [TransformToLonLatAlt(double, double, double)](#transformtolonlatalt(double,-double,-double))
- [TransformToLonLatAlt(Point3d)](#transformtolonlatalt(point3d))
- [UpdateTransformationMatrix](#updatetransformationmatrix)

### Properties

- [BlockTableRecordId](#blocktablerecordid)
- [CoordinateProjectionRadius](#coordinateprojectionradius)
- [DoSeaLevelCorrection](#dosealevelcorrection)
- [GeoRSSTag](#georsstag)
- [NorthDirection](#northdirection)
- [NorthDirectionVector](#northdirectionvector)
- [NumMeshPoints](#nummeshpoints)
- [ScaleEstimationMethod](#scaleestimationmethod)
- [ScaleFactor](#scalefactor)
- [SeaLevelElevation](#sealevelelevation)
- [UpDirection](#updirection)


## Constructors Details

### GeoLocationData

#### Description
Default constructor.
```text
public GeoLocationData();
```

### AddMeshPointMap

#### Description
This function adds a source point and destination point pair at the specified index.
```text
public void AddMeshPointMap(
    int index, 
    Point2d sourcePt, 
    Point2d destPt
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input the index to insert at |
| Point2d sourcePt | Input the source point |
| Point2d destPt | Input the destination point |

### EraseFromDb

#### Description
This function erase this object from the database.
```text
public void EraseFromDb();
```

### GetMeshPointMap

#### Description
This function gets the source point and destination point pair at the specified index as a MeshPointMap.
```text
public MeshPointMap GetMeshPointMap(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input the index to insert at |

### GetMeshPointMaps

#### Description
This function gets a GeoMesh source points collection and a destination points collection as a MeshPointMaps.
```text
public MeshPointMaps GetMeshPointMaps();
```

### PostToDb

#### Description
This function posts this object to the extension dictionary of the dimension or MLeader object.
```text
public ObjectId PostToDb();
```

### ResetMeshPointMaps

#### Description
This function resets the GeoMesh to NULL.
```text
public void ResetMeshPointMaps();
```

### SetMeshPointMaps

#### Description
This function sets the source points collection and destination points collection for a GeoMesh.
```text
public void SetMeshPointMaps(
    Point2dCollection sourcePts, 
    Point2dCollection destPts
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point2dCollection sourcePts | Input source points collection |
| Point2dCollection destPts | Input destination points collection |

### TransformFromLonLatAlt

#### Description
This is TransformFromLonLatAlt, a member of class GeoLocationData.
```text
public Point3d TransformFromLonLatAlt(
    Point3d geoPt
);
```

### TransformToLonLatAlt(double, double, double)

#### Description
This function transforms the dwg point provided into a geo space point. It then returns the longitude, latitude, and elevation.
```text
public GeoDataLonLatAltInfo TransformToLonLatAlt(
    double x, 
    double y, 
    double z
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double y | Input y coordinate of dwg point |
| double z | Input z coordinate of dwg point |

### TransformToLonLatAlt(Point3d)

#### Description
This function transforms the dwg point provided into a geo space point. 
It then returns the longitude, latitude, and elevation.
```text
public Point3d TransformToLonLatAlt(
    Point3d dwgPt
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d dwgPt | Input dwg point (x, y, z) |

### UpdateTransformationMatrix

#### Description
This function updates the transformation matrix.
```text
public void UpdateTransformationMatrix();
```

### BlockTableRecordId

#### Description
Accesses the object Id of model space block table record object.
```text
public ObjectId BlockTableRecordId;
```

#### Conditions
Read / Write
### CoordinateProjectionRadius

#### Description
Accesses the coordinate projection radius.
```text
public double CoordinateProjectionRadius;
```

#### Conditions
Read / Write
### DoSeaLevelCorrection

#### Description
Assesses if sea level correction is enabled.
```text
public bool DoSeaLevelCorrection;
```

#### Conditions
Read / Write
### GeoRSSTag

#### Description
Accesses the the geoRSS tag string.
```text
public string GeoRSSTag;
```

#### Conditions
Read / Write
### NorthDirection

#### Description
Accesses the north direction angle in DWG world coordinate system.
```text
public double NorthDirection;
```

#### Conditions
Read / Write
### NorthDirectionVector

#### Description
Accesses the north direction vector.
```text
public Vector2d NorthDirectionVector;
```

#### Conditions
Read-only
### NumMeshPoints

#### Description
Accesses the total number of mesh points.
```text
public int NumMeshPoints;
```

#### Conditions
Read-only
### ScaleEstimationMethod

#### Description
Accesses the scale estimation method.
```text
public Autodesk.AutoCAD.DatabaseServices.ScaleEstimationMethod ScaleEstimationMethod;
```

#### Conditions
Read / Write
### ScaleFactor

#### Description
Accesses the scale factor.
```text
public double ScaleFactor;
```

#### Conditions
Read / Write
### SeaLevelElevation

#### Description
Accesses the sea level elevation.
```text
public double SeaLevelElevation;
```

#### Conditions
Read / Write
### UpDirection

#### Description
Accesses the up direction in DWG world coordinate system.
```text
public Vector3d UpDirection;
```

#### Conditions
Read / Write