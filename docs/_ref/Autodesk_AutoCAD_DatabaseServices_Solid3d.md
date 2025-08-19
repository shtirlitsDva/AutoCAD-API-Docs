# Solid3d Class

## Overview

#### Description
This .Net class wraps the ObjectARX class AcDbSolid3d.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Solid3d
```

```text
public class Solid3d : Entity;
```

### Constructors

- [Solid3d](#solid3d)

### Methods

- [BooleanOperation](#booleanoperation)
- [ChamferEdges](#chamferedges)
- [CheckInterference](#checkinterference)
- [CleanBody](#cleanbody)
- [ConvertToBrepAtSubentPaths](#converttobrepatsubentpaths)
- [CopyEdge](#copyedge)
- [CopyFace](#copyface)
- [CreateBox](#createbox)
- [CreateExtrudedSolid(Entity, SubentityId, double, SweepOptions)](#createextrudedsolid(entity,-subentityid,-double,-sweepoptions))
- [CreateExtrudedSolid(Entity, SubentityId, Vector3d, SweepOptions)](#createextrudedsolid(entity,-subentityid,-vector3d,-sweepoptions))
- [CreateExtrudedSolid(Entity, Vector3d, SweepOptions)](#createextrudedsolid(entity,-vector3d,-sweepoptions))
- [CreateFrustum](#createfrustum)
- [CreateLoftedSolid(Entity[], Entity[], Entity, LoftOptions)](#createloftedsolid(entity[],-entity[],-entity,-loftoptions))
- [CreateLoftedSolid(LoftProfile[], LoftProfile[], LoftProfile, LoftOptions)](#createloftedsolid(loftprofile[],-loftprofile[],-loftprofile,-loftoptions))
- [CreatePyramid](#createpyramid)
- [CreateRevolvedSolid(Entity, Point3d, Vector3d, double, double, RevolveOptions)](#createrevolvedsolid(entity,-point3d,-vector3d,-double,-double,-revolveoptions))
- [CreateRevolvedSolid(Entity, SubentityId, Point3d, Vector3d, double, double, RevolveOptions)](#createrevolvedsolid(entity,-subentityid,-point3d,-vector3d,-double,-double,-revolveoptions))
- [CreateSculptedSolid](#createsculptedsolid)
- [CreateSphere](#createsphere)
- [CreateSweptSolid(Entity, Entity, SweepOptions)](#createsweptsolid(entity,-entity,-sweepoptions))
- [CreateSweptSolid(Entity, SubentityId, Entity, SweepOptions)](#createsweptsolid(entity,-subentityid,-entity,-sweepoptions))
- [CreateTorus](#createtorus)
- [CreateWedge](#createwedge)
- [Extrude](#extrude)
- [ExtrudeAlongPath](#extrudealongpath)
- [ExtrudeFaces](#extrudefaces)
- [ExtrudeFacesAlongPath](#extrudefacesalongpath)
- [FilletEdges](#filletedges)
- [GetSection](#getsection)
- [GetSubentityColor](#getsubentitycolor)
- [GetSubentityMaterial](#getsubentitymaterial)
- [GetSubentityMaterialMapper](#getsubentitymaterialmapper)
- [ImprintEntity](#imprintentity)
- [OffsetBody](#offsetbody)
- [OffsetFaces](#offsetfaces)
- [ProjectOnToSolid](#projectontosolid)
- [RemoveFaces](#removefaces)
- [Revolve](#revolve)
- [SeparateBody](#separatebody)
- [SetSubentityColor](#setsubentitycolor)
- [SetSubentityMaterial](#setsubentitymaterial)
- [SetSubentityMaterialMapper](#setsubentitymaterialmapper)
- [ShellBody](#shellbody)
- [Slice(Autodesk.AutoCAD.DatabaseServices.Surface)](#slice(autodesk.autocad.databaseservices.surface))
- [Slice(Autodesk.AutoCAD.DatabaseServices.Surface, [MarshalAs(UnmanagedType.U1)] bool)](#slice(autodesk.autocad.databaseservices.surface,-[marshalas(unmanagedtype.u1)]-bool))
- [Slice(Plane)](#slice(plane))
- [Slice(Plane, [MarshalAs(UnmanagedType.U1)] bool)](#slice(plane,-[marshalas(unmanagedtype.u1)]-bool))
- [StlOut](#stlout)
- [TaperFaces](#taperfaces)
- [TransformFaces](#transformfaces)

### Properties

- [Area](#area)
- [GeometricExtents](#geometricextents)
- [IsNull](#isnull)
- [MassProperties](#massproperties)
- [NumChanges](#numchanges)
- [RecordHistory](#recordhistory)
- [ShowHistory](#showhistory)
- [UsesGraphicsCache](#usesgraphicscache)


## Constructors Details

### Solid3d

#### Description
Constructor.
```text
public Solid3d();
```

### BooleanOperation

#### Description
Performs Boolean operation between this solid and Solid. Possible operation types are: 
  * BoolUnite
  * BoolIntersect
  * BoolSubtract

If the Boolean operation is successful, then the solid ShapeManager object is deleted.
```text
public virtual void BooleanOperation(
    BooleanOperationType operation, 
    Solid3d solid
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| BooleanOperationType operation | Input type of Boolean operation |
| Solid3d solid | Input the other solid with which to carry out the Boolean operation |

### ChamferEdges

#### Description
Creates chamfers at the edges of a solid.
```text
public virtual void ChamferEdges(
    SubentityId\[\] subentityIds, 
    SubentityId baseSubentityId, 
    double baseDist, 
    double otherDist
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId[] subentityIds | Input object ids of edges at which the chamfer will be applied |
| SubentityId baseSubentityId | Input object id of the base face where the chamfer will be applied |
| double baseDist | Input chamfer distance on the base face |
| double otherDist | Input chamfer distance on the other faces |

#### Notes
Due to the graphics dependency of the SubentId object, this function is not applicable for the RealDWG SDK.
### CheckInterference

#### Description
Checks whether this solid interferes with otherSolid.
```text
public virtual bool CheckInterference(
    Solid3d otherSolid
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Solid3d otherSolid | Input pointer for other solid |

#### Notes
The caller of this function is responsible for the memory used by the object, if any, that returns (resulting from intersection of this solid and otherSolid) pointing to when the function finishes. If such an object is added to an Database, then the database takes over responsibility for the memory. If the object is not added to a database, then the caller will need to delete it when it is no longer needed.
### CleanBody

#### Description
Removes all edges and faces not necessary to support the topology of the solid.
```text
public virtual void CleanBody();
```

### ConvertToBrepAtSubentPaths

#### Description
This method is used to convert individual history items from a parameterized type such as a box to a simple boundary-representation without its parameter or type information. 
If this succeeds for a box history item, for example, box grips will no longer be available for that history item. 
This will fail for an individual subentity when the referenced history item comes before a history item, such as a blend that uses a persistent subentity ID.
```text
public virtual void ConvertToBrepAtSubentPaths(
    FullSubentityPath\[\] paths
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| FullSubentityPath[] paths | Input array of references to history items |

### CopyEdge

#### Description
This method copies the specified edge as an AutoCAD entity, which can be an Line, AcDbCircle, AcDbArc, Ellipse, or AcDbSpline. The properties of the resulting entity (color, layer, linetype, lineweight) are set from the corresponding current document settings. The calling application is responsible for the resulting entity (either appending it to a database or deleting it when it is no longer needed).
```text
public virtual Entity CopyEdge(
    SubentityId subEntityId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId subEntityId | Input subentity ID of an edge in the Solid3d |

#### Notes
Due to the graphics dependency of the SubentId object, this function is not applicable for the RealDWG SDK.
### CopyFace

#### Description
This method copies the specified face as an AutoCAD entity, which can be an Region if the face is planar, or otherwise will be an Body. The properties of the resulting entity (color, layer, linetype, lineweight) are set from the corresponding current document settings. The calling application is responsible for the resulting entity (either appending it to a database or deleting it when it is no longer needed). 
Due to the graphics dependency of the SubentId object, this function is not applicable for the RealDWG SDK.
```text
public virtual Entity CopyFace(
    SubentityId subEntityId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId subEntityId | Input subentity ID of a face in the Solid3d |

### CreateBox

#### Description
This method is used for creating a box solid primitive with centroid at world origin. The length, width, and height axes of the box are aligned with the WCS X, Y, and Z axes, respectively.
```text
public virtual void CreateBox(
    double lengthAlongX, 
    double lengthAlongY, 
    double lengthAlongZ
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double lengthAlongX | Input value for length of the box |
| double lengthAlongY | Input value for width of the box |
| double lengthAlongZ | Input value for height of the box |

### CreateExtrudedSolid(Entity, SubentityId, double, SweepOptions)

#### Description
Creates an extruded solid by extruding an entity or face. 
This .NET method wraps the ObjectARX method [AcDb3dSolid::createExtrudedSolid](AcDb3dSolid__createExtrudedSolid@AcDbEntity_@AcDbSubentId_@double@AcDbSweepOptions_.md).
```text
public virtual void CreateExtrudedSolid(
    Entity sweepEntity, 
    SubentityId faceSubEntityId, 
    double height, 
    SweepOptions sweepOptions
);
```

### CreateExtrudedSolid(Entity, SubentityId, Vector3d, SweepOptions)

#### Description
Creates an extruded solid by extruding an entity or face. 
This .NET method wraps the ObjectARX method [AcDb3dSolid::createExtrudedSolid](AcDb3dSolid__createExtrudedSolid@AcDbEntity_@AcDbSubentId_@AcGeVector3d_@AcDbSweepOptions_.md).
```text
public virtual void CreateExtrudedSolid(
    Entity sweepEntity, 
    SubentityId faceSubEntityId, 
    Vector3d directionVector, 
    SweepOptions sweepOptions
);
```

### CreateExtrudedSolid(Entity, Vector3d, SweepOptions)

#### Description
Creates an extruded solid by extruding an entity or face. 
This .NET method wraps the ObjectARX method [AcDb3dSolid::createExtrudedSolid](AcDb3dSolid__createExtrudedSolid@AcDbEntity_@AcGeVector3d_@AcDbSweepOptions_.md).
```text
public virtual void CreateExtrudedSolid(
    Entity sweepEntity, 
    Vector3d directionVector, 
    SweepOptions sweepOptions
);
```

### CreateFrustum

#### Description
This method is used for creating a cylinder or cone with the world origin being centered about its diameter and positioned at half of the height. If radiusAlongX and radiusAlongY are the same and topRadius is zero, then a normal circular cone is created. If radiusAlongX and radiusAlongY are not the same and topRadius is zero, then an elliptical cone is created. Otherwise, based on radiusAlongX and radiusAlongY values, a circular or elliptical tapered cylinder is created. If radiusAlongX and topRadius are the same, then a cylinder is created. Otherwise, a cone is created. radiusAlongY determines whether the created cone or cylinder is circular or elliptical, based on whether radiusAlongY is equal to radiusAlongX or not. The base of the frustum lies in the WCS X-Y plane. The direction from the base of the frustum to the top will be in the direction of the positive WCS Z axis.
```text
public virtual void CreateFrustum(
    double height, 
    double radiusAlongX, 
    double radiusAlongY, 
    double topRadius
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double height | Input height for the frustum |
| double radiusAlongX | Input radius for the frustum in X direction |
| double radiusAlongY | Input radius for the frustum in Y direction |
| double topRadius | Input radius for top end of the frustum |

### CreateLoftedSolid(Entity[], Entity[], Entity, LoftOptions)

#### Description
This .NET method wraps the ObjectARX method [AcDb3dSolid::createLoftedSolid](AcDb3dSolid__createLoftedSolid@AcArray_AcDbEntity___@AcArray_AcDbEntity___@AcDbEntity_@AcDbLoftOptions_.md).
```text
public virtual void CreateLoftedSolid(
    Entity\[\] crossSectionCurves, 
    Entity\[\] guideCurves, 
    Entity pathCurve, 
    LoftOptions loftOptions
);
```

### CreateLoftedSolid(LoftProfile[], LoftProfile[], LoftProfile, LoftOptions)

#### Description
This wraps the ObjectARX [AcDb3dSolid::createLoftedSolid](AcDb3dSolid__createLoftedSolid@AcArray_AcDbLoftProfile___@AcArray_AcDbLoftProfile___@AcDbLoftProfile__@AcDbLoftOptions_.md) () method
```text
public virtual void CreateLoftedSolid(
    LoftProfile\[\] crossSections, 
    LoftProfile\[\] guides, 
    LoftProfile path, 
    LoftOptions loftOptions
);
```

### CreatePyramid

#### Description
This method is used for creating a pyramid with the world origin being centered about its base and positioned at half of the height. If radius and topRadius are the same, then a prism is created. Otherwise, a pyramid is created. The base of the pyramid lies in the WCS X-Y plane. The direction from the base of the pyramid to the top will be in the direction of the positive WCS Z axis.
```text
public virtual void CreatePyramid(
    double height, 
    int sides, 
    double radius, 
    double topRadius
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double height | Input height for pyramid |
| int sides | Input number of sides for pyramid |
| double radius | Input radius for inscribed circle of bottom polygon |
| double topRadius | Input radius for inscribed circle of top polygon |

### CreateRevolvedSolid(Entity, Point3d, Vector3d, double, double, RevolveOptions)

#### Description
Create revolved solid by revolving an entity or face. 
This .NET method wraps the ObjectARX method [AcDb3dSolid::createRevolvedSolid](AcDb3dSolid__createRevolvedSolid@AcDbEntity_@AcGePoint3d_@AcGeVector3d_@double@double@AcDbRevolveOptions_.md).
```text
public virtual void CreateRevolvedSolid(
    Entity profileEntity, 
    Point3d axisPoint, 
    Vector3d axisDir, 
    double angleOfRevolution, 
    double startAngle, 
    RevolveOptions revolveOptions
);
```

### CreateRevolvedSolid(Entity, SubentityId, Point3d, Vector3d, double, double, RevolveOptions)

#### Description
Create revolved solid by revolving an entity or face. 
This .NET method wraps the ObjectARX method [AcDb3dSolid::createSweptSolid](AcDb3dSolid__createSweptSolid@AcDbEntity__@AcDbSubentId_@AcDbEntity_@AcDbSweepOptions_.md).
```text
public virtual void CreateRevolvedSolid(
    Entity profileEntity, 
    SubentityId faceSubEntityId, 
    Point3d axisPoint, 
    Vector3d axisDir, 
    double angleOfRevolution, 
    double startAngle, 
    RevolveOptions revolveOptions
);
```

### CreateSculptedSolid

#### Description
This wraps the ObjectARX [AcDb3dSolid::createSculptedSolid](AcDb3dSolid__createSculptedSolid@AcArray_AcDbEntity___@AcGeIntArray_.md)() method.
```text
public void CreateSculptedSolid(
    Entity\[\] limitingBodies, 
    IntegerCollection limitingFlags
);
```

### CreateSphere

#### Description
This method is used for creating a sphere with centroid at world origin and radius radius.
```text
public virtual void CreateSphere(
    double radius
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double radius | Input radius for the sphere |

### CreateSweptSolid(Entity, Entity, SweepOptions)

#### Description
Create swept solid by sweeping an entity or face along a path. 
This .NET method wraps the ObjectARX method [AcDb3dSolid::createSweptSolid](AcDb3dSolid__createSweptSolid@AcDbEntity_@AcDbEntity_@AcDbSweepOptions_.md).
```text
public virtual void CreateSweptSolid(
    Entity sweepEntity, 
    Entity pathEntity, 
    SweepOptions sweepOptions
);
```

### CreateSweptSolid(Entity, SubentityId, Entity, SweepOptions)

#### Description
Create swept solid by sweeping an entity or face along a path. 
This .NET method wraps the ObjectARX method [AcDb3dSolid::createSweptSolid](AcDb3dSolid__createSweptSolid@AcDbEntity__@AcDbSubentId_@AcDbEntity_@AcDbSweepOptions_.md).
```text
public virtual void CreateSweptSolid(
    Entity sweepEntity, 
    SubentityId faceSubEntityId, 
    Entity pathEntity, 
    SweepOptions sweepOptions
);
```

### CreateTorus

#### Description
This method is used for creating a torus with centroid at the WCS origin and using the WCS Z axis as the axis of rotational symmetry for the torus. 
majorRadius specifies the radius of the torus and minorRadius specifies the radius of the tube. majorRadius can have positive or negative values but cannot be zero. The minorRadius value cannot be zero. If majorRadius has a negative value, then minorRadius should have a larger value than the absolute value of majorRadius. 
```text
public virtual void CreateTorus(
    double majorRadius, 
    double minorRadius
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double majorRadius | Input major radius for the torus |
| double minorRadius | Input minor radius for the torus |

### CreateWedge

#### Description
This method is used for creating a wedge solid with center at the WCS origin. The length, width, and height of the wedge are aligned with the WCS’s X, Y, and Z axes, respectively.
```text
public virtual void CreateWedge(
    double lengthAlongX, 
    double lengthAlongY, 
    double lengthAlongZ
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double lengthAlongX | Input length for the wedge |
| double lengthAlongY | Input width for the wedge |
| double lengthAlongZ | Input height for the wedge |

### Extrude

#### Description
Creates a solid by extruding region, a distance of height with a taper angle of taper. The extrusion direction is along the normal of the region if the height is positive. taper should be between half pi and -half pi. If the absolute value of taper < 1e-6, then the taper angle is set to 0. 
If taper is nonzero, the region should only have lines, circles, and circular arcs that join together smoothly (equal tangents at the points of connection). 
The region should not have self-intersections. Any self-intersections caused by the sweep will not be corrected. 
For more information, see the EXTRUDE command in the AutoCAD Command Reference.
```text
public virtual void Extrude(
    Region region, 
    double height, 
    double taperAngle
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Region region | Input a region object |
| double height | Input height for extrusion |
| double taperAngle | Input taper angle in radians |

### ExtrudeAlongPath

#### Description
Creates a solid by extruding region along the path curve. path must be an Line, AcDbArc, AcDbCircle, Ellipse, AcDbSpline, AcDb2dPolyline, or a non-spline fit 3dPolyline. path should not have self-intersections and, preferably, should not have high curvature areas. If one of the endpoints of the path is not on the plane of the region, then the path will be moved to make this true. 
taperAngle should be between 0.5 pi and -0.5 pi. If the absolute value of taperAngle is less than 1e-6, the taper angle is set to 0. If the path entity is closed, the taper angle parameter is ignored. 
```text
public virtual void ExtrudeAlongPath(
    Region region, 
    Curve path, 
    double taperAngle
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Region region | Input a region object |
| Curve path | Input a curve object to extrude along |
| double taperAngle | Input extrusion taper angle in radians |

### ExtrudeFaces

#### Description
This method extrudes faces of a solid by a distance of height with a taper angle of taper. The extrusion direction is along the normal of each face if the height is positive or in the opposite direction if the height is negative. If the absolute value of taper < 1e-6, then a taper angle of 0.0 will be used for the extrusion. 
If taper is nonzero, each face should only have edges join together smoothly (equal tangents at the points of connection).
```text
public virtual void ExtrudeFaces(
    SubentityId\[\] subentityIds, 
    double height, 
    double taper
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId[] subentityIds | Input array of subentity IDs of faces to be extruded; these faces must be planar |
| double height | Input extrusion distance to be applied to the specified faces. Use a positive value to extrude in the direction of the face normals, which point outward from the solid. Use a negative value to extrude faces into the solid. |
| double taper | Input angle of tapering to be applied to the extrusion; the tapering is relative to the axis formed from the center of each face in the direction of the face normal when a positive height is used or in the opposite direction when a negative height is used; this value should be between half pi and half pi |

### ExtrudeFacesAlongPath

#### Description
This method extrudes the given faces along the given path curve entity, which must be an Line, AcDbArc, Circle, AcDbEllipse, AcDbSpline, AcDb2dPolyline, or a non-spline fit 3dPolyline. The path should not have self-intersections and, preferably, should not have high curvature areas. If one of the end points of the path is not on the plane of the region, then the path will be moved to make this true.
```text
public virtual void ExtrudeFacesAlongPath(
    SubentityId\[\] subentityIds, 
    Curve path
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId[] subentityIds | Input array of subentity IDs of faces to be extruded; these faces must be planar |
| Curve path | Input a curve object to extrude along |

### FilletEdges

#### Description
This method creates rounded fillets the edges of a solid.
```text
public virtual void FilletEdges(
    SubentityId\[\] subentityIds, 
    DoubleCollection radius, 
    DoubleCollection startSetback, 
    DoubleCollection endSetback
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId[] subentityIds | Input object ids of the edges where the fillet will be applied |
| DoubleCollection radius | Input radius at the corresponding edge |
| DoubleCollection startSetback | Input start setback at the corresponding edge |
| DoubleCollection endSetback | Input end setback at the corresponding edge |

### GetSection

#### Description
This function creates an Region entity that represents the intersection of plane with the solid, and returns the region that represents the section. 
If the solid has no ShapeManager object, or the plane doesn’t intersect the solid, or the intersection is not a valid region (for example, it intersects at a point, along a bounding face of the solid, and so on), then the return is NULL.
```text
public virtual Region GetSection(
    Plane plane
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Plane plane | Input plane to use as the section cutting plane |

### GetSubentityColor

#### Description
Retrieves the color of the specified subentity.
```text
public virtual Autodesk.AutoCAD.Colors.Color GetSubentityColor(
    SubentityId subEntityId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId subEntityId | Input subentity Id |

### GetSubentityMaterial

#### Description
This function returns the material of the specified subentity.
```text
public virtual ObjectId GetSubentityMaterial(
    SubentityId subEntityId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId subEntityId | Input subentity Id |

### GetSubentityMaterialMapper

#### Description
Retrieves the material mapper for the specified subentity.
```text
public virtual Mapper GetSubentityMaterialMapper(
    SubentityId subEntityId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId subEntityId | Input subenttity Id |

#### Notes
As the const qualifier indicates, do not attempt to deallocate the returned Mapper.
### ImprintEntity

#### Description
This method intersects the given entity with the solid and imprints their intersection graph onto the solid. If a closed loop of new edges is created, a new face is made. An open loop of edges can be added as a spur to an existing loop on a face or as a slit in the face. The given entity must be a kind of Curve, Solid3d, Body, Region, Trace, bSolid, or Face.
```text
public virtual void ImprintEntity(
    Entity entity
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | Input entity to be imprinted |

### OffsetBody

#### Description
This method offsets all faces of the solid by the given distance. Faces with surfaces that cannot be offset are removed and the solid is healed, if possible. Note that this operation can produce an invalid solid in some cases. The function will check for an invalid solid result if the SOLIDCHECK system variable is set to 1.
```text
public virtual void OffsetBody(
    double offsetDistance
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double offsetDistance | Input distance to offset each face |

### OffsetFaces

#### Description
Offsets the given faces of the solid by the given distance. Faces with surfaces that cannot be offset are removed and the solid is healed, if possible. Note that this operation can produce an invalid solid in some cases. The function will check for an invalid solid result if the SOLIDCHECK system variable is set to 1.
```text
public virtual void OffsetFaces(
    SubentityId\[\] subentityIds, 
    double offsetDistance
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId[] subentityIds | Input array of subentity IDs of faces to be offset |
| double offsetDistance | Input distance to offset each face |

### ProjectOnToSolid

#### Description
This wraps the ObjectARX [AcDb3dSolid::projectOnToSolid](AcDb3dSolid__projectOnToSolid@AcDbEntity_@AcGeVector3d_@AcArray_AcDbEntity___@const.md)() method.
```text
public Entity\[\] ProjectOnToSolid(
    Entity entityToProject, 
    Vector3d projectionDirection
);
```

### RemoveFaces

#### Description
This method removes the given faces, growing the adjacent faces to fill the gaps. Note that the gap filling can fill if there is no solution using adjacent faces only. 
Note that this operation can produce an invalid solid in some cases. The function will check for an invalid solid result if the SOLIDCHECK system variable is set to 1.
```text
public virtual void RemoveFaces(
    SubentityId\[\] subentityIds
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId[] subentityIds | Input array of subentity IDs of faces to be removed |

### Revolve

#### Description
Creates a solid by revolving region around the axis defined by the projection of the line from axisPoint to axisPoint+axisDir onto the plane containing region. Therefore, the rotation axis will always be coplanar with region. The region is revolved angleOfRevolution radians around the rotation axis. Positive angles result in a clockwise rotation, when looking in the direction of the projection of axisDir onto the plane containing region (that is, right-hand rule). Angles of revolution more than 2 pi are treated as 2 pi. The rotation axis must not pass through region.
```text
public virtual void Revolve(
    Region region, 
    Point3d axisPoint, 
    Vector3d axisDir, 
    double angleOfRevolution
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Region region | Input region object to be revolved |
| Point3d axisPoint | Input point on the line to be projected to create the axis of revolution |
| Vector3d axisDir | Input vector representing the direction of the line to be projected to create the axis of revolution |
| double angleOfRevolution | Input angle of revolution in radians |

### SeparateBody

#### Description
This method separates the solid into a list of solids representing the additional disjoint volumes. This solid is reduced to a solid with one volume. The calling application is responsible for the resulting entities (either appending them to a database or deleting them when they are no longer needed). When the calling application closes this Solid3d, the resulting solid will be committed to the database. So, if the other solids are not appended to the database, you will lose some data.
```text
public virtual Solid3d\[\] SeparateBody();
```

### SetSubentityColor

#### Description
Sets the color of the face or edge subentity of the Solid3d to the specified AutoCAD color.
```text
public virtual void SetSubentityColor(
    SubentityId subEntityId, 
    Autodesk.AutoCAD.Colors.Color color
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId subEntityId | Input ID of subentity face or edge to be colored |
| Autodesk.AutoCAD.Colors.Color color | Input color for the subentity |

### SetSubentityMaterial

#### Description
This function sets a material on a specified subentity. You can remove a previously assigned material by providing a null objectId for the materialId parameter.
```text
public virtual void SetSubentityMaterial(
    SubentityId subEntityId, 
    ObjectId materialId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId subEntityId | Input subentity Id |
| ObjectId materialId | Input object Id of the material |

### SetSubentityMaterialMapper

#### Description
This function sets an explicit material mapper on the specified subentity. You can remove the explicit mapper assignment by providing Mapper.kIdentity for the mapper parameter.
```text
public virtual void SetSubentityMaterialMapper(
    SubentityId subEntityId, 
    Mapper mapper
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId subEntityId | Input subentity ID |
| Mapper mapper | Input a Mapper object |

### ShellBody

#### Description
Changes the solid into a thin-walled solid shell with the faces offset to the outside of the solid when given positive offset distances, and to the inside when given negative distances. 
Faces with surfaces that cannot be offset by the thickness are removed and the resulting wound healed by the surrounding face surfaces. Mergeable edges and vertices on the supplied faces will be merged out. Isolated edges in tweaked faces and neighboring faces may degenerate to a point and will be removed, but removal of a loop or face and insertion of edges and other topology changes are not permitted. 
Note that this operation can produce an invalid solid in some cases. The function will check for an invalid solid result if the SOLIDCHECK system variable is set to 1.
```text
public virtual void ShellBody(
    SubentityId\[\] subentityIds, 
    double offsetDistance
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId[] subentityIds | Input array of subentity IDs of faces to be removed from the shell |
| double offsetDistance | Input distance to offset each face |

### Slice(Autodesk.AutoCAD.DatabaseServices.Surface)

#### Description
This method slices the solid by a given surface.
```text
public virtual void Slice(
    Autodesk.AutoCAD.DatabaseServices.Surface surface
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.Surface surface | Input the surface entity to be used to slice the solid |

### Slice(Autodesk.AutoCAD.DatabaseServices.Surface, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This method slices the solid by a given surface. If the negativeHalfToo parameter is true, the negative side of the solid is also created.
```text
public virtual Solid3d Slice(
    Autodesk.AutoCAD.DatabaseServices.Surface surface, 
    [MarshalAs(UnmanagedType.U1)] bool negativeHalfToo
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.Surface surface | Input the surface entity to be used to slice the solid |
| [MarshalAs(UnmanagedType.U1)] bool negativeHalfToo | Input flag to indicate whether the other side of the solid is to be generated |

### Slice(Plane)

#### Description
Slices the solid with plane and sets the solid to be the portion on the positive normal side plane.
```text
public virtual void Slice(
    Plane plane
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Plane plane | Input plane to be used for slicing the solid |

#### Notes
The calling application is responsible for the memory used by any negative half solid created by this function. If such a solid is subsequently added to an Database, then the responsibility is passed on to that database object.
### Slice(Plane, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Slices the solid with plane and sets the solid to be the portion on the positive normal side plane.
```text
public virtual Solid3d Slice(
    Plane plane, 
    [MarshalAs(UnmanagedType.U1)] bool negativeHalfToo
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Plane plane | Input plane to be used for slicing the solid |
| [MarshalAs(UnmanagedType.U1)] bool negativeHalfToo | Input flag to indicate whether the other side of the solid is to be generated |

#### Notes
The calling application is responsible for the memory used by any negative half solid created by this function. If such a solid is subsequently added to an Database, then the responsibility is passed on to that database object.
### StlOut

#### Description
Writes out a Stereo Lithography (STL) representation of this solid to a file with the name fileName. 
If asciiFormat is true, then the STL file format will be ASCII text; otherwise, it will be a binary format file. Any pre-existing fileName file will be overwritten.
```text
public virtual void StlOut(
    string fileName, 
    [MarshalAs(UnmanagedType.U1)] bool asciiFormat
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string fileName | Input file name |
| [MarshalAs(UnmanagedType.U1)] bool asciiFormat | Input Boolean indicating file format |

### TaperFaces

#### Description
Tapers the given faces of the solid about the given base point and supplied draft vector by a given draft angle. The base point and draft vector define a draft plane about which faces are tapered. Any face lying in the draft plane will not be modified. 
Note that this operation can produce an invalid solid in some cases. The function will check for an invalid solid result if the SOLIDCHECK system variable is set to 1.
```text
public virtual void TaperFaces(
    SubentityId\[\] subentityIds, 
    Point3d basePoint, 
    Vector3d draftVector, 
    double draftAngle
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId[] subentityIds | Input array of subentity IDs of faces to be tapered |
| Point3d basePoint | Input origin of the draft plane |
| Vector3d draftVector | Input draft direction vector |
| double draftAngle | Input draft angle |

### TransformFaces

#### Description
Transforms the given faces of the solid by applying the transformation matrix to rotate and or move the faces. 
Note that this operation can produce an invalid solid in some cases. The function will check for an invalid solid result if the SOLIDCHECK system variable is set to 1.
```text
public virtual void TransformFaces(
    SubentityId\[\] subentityIds, 
    Matrix3d matrix
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SubentityId[] subentityIds | Input array of subentity IDs of faces to be transformed |
| Matrix3d matrix | Input rotation and/or translation matrix to be applied to the faces |

### Area

#### Description
Returns the area set to the surface area of the solid. The area will be in square drawing units.
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
Returns true if the solid does not have a ShapeManager object within itself.
```text
public virtual bool IsNull;
```

#### Conditions
Read-only
### MassProperties

#### Description
Returns the MassProperties property value.
```text
public virtual Solid3dMassProperties MassProperties;
```

#### Conditions
Read-only
### NumChanges

#### Description
Returns the number of changes that have occurred to this solid since it was first created.
```text
public virtual int NumChanges;
```

#### Conditions
Read-only
### RecordHistory

#### Description
Returns whether the solid will record operations supported by solid history.
```text
public virtual bool RecordHistory;
```

#### Conditions
Read / Write
### ShowHistory

#### Description
Returns whether items in the history should be drawn when the sysvar SHOWHIST is 1.
```text
public virtual bool ShowHistory;
```

#### Conditions
Read / Write
### UsesGraphicsCache

#### Description
This property is a wrapper for the AcDb3dSolid::usesGraphicsCache() method which is used by AutoCAD to determine whether or not to use cached graphics for the region. If the method returns true, then cached graphics will be used. Only database resident entities can use graphics caching, so this method is not called for entities not in an AcDbDatabase.
```text
public virtual bool UsesGraphicsCache;
```
