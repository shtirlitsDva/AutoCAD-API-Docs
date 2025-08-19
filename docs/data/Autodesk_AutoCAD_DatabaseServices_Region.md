# Region Class

## Overview

#### Description
This .NET class wraps the AcDbRegion ObjectARX class. 
Objects of this class represent region entities in AutoCAD. 
An Region entity is a container and interface for a ShapeManager object that is the actual geometrical representation of the region. This class provides no provisions for directly manipulating the edges, vertices, or faces of the ShapeManager object that is the actual region representation.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Region
```

```text
public class Region : Entity;
```

### Constructors

- [Region](#region)

### Methods

- [AreaProperties](#areaproperties)
- [BooleanOperation](#booleanoperation)
- [CreateFromCurves](#createfromcurves)

### Properties

- [Area](#area)
- [GeometricExtents](#geometricextents)
- [IsNull](#isnull)
- [Normal](#normal)
- [NumChanges](#numchanges)
- [Perimeter](#perimeter)
- [UsesGraphicsCache](#usesgraphicscache)


## Constructors Details

### Region

#### Description
Default constructor. Initializes the change count to 0 and IsNull to true.
```text
public Region();
```

### AreaProperties

#### Description
This function calculates the area properties of the Region. All of the values in the returned RegionAreaProperties struct are in the coordinate system specified by origin, xAxis, and yAxis (which must be in WCS coordinates). The function validates the origin, xAxis, and yAxis parameters to ensure that the axes are of unit length and are perpendicular to each other, and that the axes and origin lie in the same plane as the Region.
```text
public virtual RegionAreaProperties AreaProperties(
    ref Point3d origin, 
    ref Vector3d xAxis, 
    ref Vector3d yAxis
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ref Point3d origin | Input point (in WCS coords) for origin of the coordinate system to usefor evaluation. |
| ref Vector3d xAxis | Input X axis (in WCS coords) of the coordinate system to use forevaluation. |
| ref Vector3d yAxis | Input Y axis (in WCS coords) of the coordinate system to use forevaluation. |

#### Returns
Returns a RegionAreaProperties struct containing the Region's area property data.
### BooleanOperation

#### Description
Performs Boolean operation between this region and otherRegion. 
If the Boolean operation is successful, then the otherRegion ShapeManager object is deleted (so its IsNull property returns true).
```text
public virtual void BooleanOperation(
    BooleanOperationType operation, 
    Region otherRegion
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| BooleanOperationType operation | Input type of Boolean operation. |
| Region otherRegion | Input pointer to another region to perform the Boolean operation |

### CreateFromCurves

#### Description
```text
public static DBObjectCollection CreateFromCurves(
    DBObjectCollection curveSegments
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DBObjectCollection curveSegments | Input collection to curve entities used to define the region's perimeter(s) |

#### Conditions
This static member function creates a set of Region objects from the closed loops represented by the curves contained in the curveSegments collection. The newly created region objects are returned in the regions array. 
The curveSegments must contain only Line, Arc, Ellipse, Circle, Spline, Polyline3d, or Polyline2d objects. 
Note
The objects in curveSegments must be opened for read and not for write. If the objects are opened, calling this function will crash AutoCAD. 
It is the calling application's responsibility to either add the Region objects returned in the regions array to an Database or to delete them when they are no longer needed.
### Area

#### Description
Accesses the surface area of the region. The area is in square drawing units.
```text
public virtual double Area;
```

#### Conditions
Read-only
### GeometricExtents

#### Description
Accesses the corner points (in WCS coordinates) of a box (with edges parallel to the WCS X, Y, and Z axes) that encloses the 3D extents of the entity, and return those points as an instance of class Extents in the "extents" parameter.
```text
public override Extents3d GeometricExtents;
```

#### Conditions
Read-only
### IsNull

#### Description
Assesses if the region has no ShapeManager object within itself.
```text
public virtual bool IsNull;
```

#### Conditions
Read-only
### Normal

#### Description
Accesses the normal vector of the region. Normal is in WCS coordinates.
```text
public virtual Vector3d Normal;
```

#### Conditions
Read-only
### NumChanges

#### Description
Accesses the number of changes that have occurred to this region since it was first created.
```text
public virtual int NumChanges;
```

#### Conditions
Read-only
### Perimeter

#### Description
Accesses the perimeter length (in drawing units) of the region.
```text
public virtual double Perimeter;
```

#### Conditions
Read-only
### UsesGraphicsCache

#### Description
This property is a wrapper for the AcDbRegion::usesGraphicsCache() method which is used by AutoCAD to determine whether or not to use cached graphics for the region. If the method returns true, then cached graphics will be used. Only database resident entities can use graphics caching, so this method is not called for entities not in an AcDbDatabase.
```text
public virtual bool UsesGraphicsCache;
```
