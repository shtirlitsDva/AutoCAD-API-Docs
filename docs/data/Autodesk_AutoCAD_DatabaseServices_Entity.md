# Entity Class

## Overview

#### Description
This .NET class wraps the AcDbEntity ObjectARX class. It is the base class for all database objects having a graphical representation.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.BlockBegin
        Autodesk.AutoCAD.DatabaseServices.BlockEnd
        Autodesk.AutoCAD.DatabaseServices.BlockReference
        Autodesk.AutoCAD.DatabaseServices.Body
        Autodesk.AutoCAD.DatabaseServices.Curve
        Autodesk.AutoCAD.DatabaseServices.DBPoint
        Autodesk.AutoCAD.DatabaseServices.DBText
        Autodesk.AutoCAD.DatabaseServices.DetailSymbol
        Autodesk.AutoCAD.DatabaseServices.Dimension
        Autodesk.AutoCAD.DatabaseServices.Face
        Autodesk.AutoCAD.DatabaseServices.FeatureControlFrame
        Autodesk.AutoCAD.DatabaseServices.GeoPositionMarker
        Autodesk.AutoCAD.DatabaseServices.Hatch
        Autodesk.AutoCAD.DatabaseServices.Image
        Autodesk.AutoCAD.DatabaseServices.Light
        Autodesk.AutoCAD.DatabaseServices.MLeader
        Autodesk.AutoCAD.DatabaseServices.Mline
        Autodesk.AutoCAD.DatabaseServices.MText
        Autodesk.AutoCAD.DatabaseServices.Ole2Frame
        Autodesk.AutoCAD.DatabaseServices.PointCloud
        Autodesk.AutoCAD.DatabaseServices.PointCloudEx
        Autodesk.AutoCAD.DatabaseServices.PolyFaceMesh
        Autodesk.AutoCAD.DatabaseServices.PolygonMesh
        Autodesk.AutoCAD.DatabaseServices.ProxyEntity
        Autodesk.AutoCAD.DatabaseServices.Region
        Autodesk.AutoCAD.DatabaseServices.Section
        Autodesk.AutoCAD.DatabaseServices.SectionSymbol
        Autodesk.AutoCAD.DatabaseServices.SequenceEnd
        Autodesk.AutoCAD.DatabaseServices.Shape
        Autodesk.AutoCAD.DatabaseServices.Solid
        Autodesk.AutoCAD.DatabaseServices.Solid3d
        Autodesk.AutoCAD.DatabaseServices.SubDMesh
        Autodesk.AutoCAD.DatabaseServices.Surface
        Autodesk.AutoCAD.DatabaseServices.UnderlayReference
        Autodesk.AutoCAD.DatabaseServices.Vertex
        Autodesk.AutoCAD.DatabaseServices.ViewBorder
        Autodesk.AutoCAD.DatabaseServices.Viewport
```

```text
public abstract class Entity : DBObject;
```

#### See Also
[RXObject](Autodesk_AutoCAD_Runtime_RXObject.md)

## Members

### Methods

- [AddSubentityPaths](#addsubentitypaths)
- [BoundingBoxIntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Plane, Point3dCollection, IntPtr, IntPtr)](#boundingboxintersectwith(entity,-autodesk.autocad.databaseservices.intersect,-plane,-point3dcollection,-intptr,-intptr))
- [BoundingBoxIntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Plane, Point3dCollection, long, long)](#boundingboxintersectwith(entity,-autodesk.autocad.databaseservices.intersect,-plane,-point3dcollection,-long,-long))
- [BoundingBoxIntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Point3dCollection, IntPtr, IntPtr)](#boundingboxintersectwith(entity,-autodesk.autocad.databaseservices.intersect,-point3dcollection,-intptr,-intptr))
- [BoundingBoxIntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Point3dCollection, long, long)](#boundingboxintersectwith(entity,-autodesk.autocad.databaseservices.intersect,-point3dcollection,-long,-long))
- [DeleteSubentityPaths](#deletesubentitypaths)
- [Draw](#draw)
- [Explode](#explode)
- [GetGraphicsMarkersAtSubentityPathIntPtr](#getgraphicsmarkersatsubentitypathintptr)
- [GetGripPoints(GripDataCollection, double, int, Vector3d, GetGripPointsFlags)](#getgrippoints(gripdatacollection,-double,-int,-vector3d,-getgrippointsflags))
- [GetGripPoints(Point3dCollection, IntegerCollection, IntegerCollection)](#getgrippoints(point3dcollection,-integercollection,-integercollection))
- [GetGripPointsAtSubentityPath](#getgrippointsatsubentitypath)
- [GetObjectSnapPoints(ObjectSnapModes, int, Point3d, Point3d, Matrix3d, Point3dCollection, IntegerCollection)](#getobjectsnappoints(objectsnapmodes,-int,-point3d,-point3d,-matrix3d,-point3dcollection,-integercollection))
- [GetObjectSnapPoints(ObjectSnapModes, int, Point3d, Point3d, Matrix3d, Point3dCollection, IntegerCollection, Matrix3d)](#getobjectsnappoints(objectsnapmodes,-int,-point3d,-point3d,-matrix3d,-point3dcollection,-integercollection,-matrix3d))
- [GetPlane](#getplane)
- [GetStretchPoints](#getstretchpoints)
- [GetSubentity](#getsubentity)
- [GetSubentityGeometricExtents](#getsubentitygeometricextents)
- [GetSubentityPathsAtGraphicsMarker(SubentityType, IntPtr, Point3d, Matrix3d, ObjectId[])](#getsubentitypathsatgraphicsmarker(subentitytype,-intptr,-point3d,-matrix3d,-objectid[]))
- [GetSubentityPathsAtGraphicsMarker(SubentityType, long, Point3d, Matrix3d, int, ObjectId[])](#getsubentitypathsatgraphicsmarker(subentitytype,-long,-point3d,-matrix3d,-int,-objectid[]))
- [GetTransformedCopy](#gettransformedcopy)
- [Highlight()](#highlight())
- [Highlight(FullSubentityPath, [MarshalAs(UnmanagedType.U1)] bool)](#highlight(fullsubentitypath,-[marshalas(unmanagedtype.u1)]-bool))
- [HighlightState](#highlightstate)
- [IntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Plane, Point3dCollection, IntPtr, IntPtr)](#intersectwith(entity,-autodesk.autocad.databaseservices.intersect,-plane,-point3dcollection,-intptr,-intptr))
- [IntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Plane, Point3dCollection, long, long)](#intersectwith(entity,-autodesk.autocad.databaseservices.intersect,-plane,-point3dcollection,-long,-long))
- [IntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Point3dCollection, IntPtr, IntPtr)](#intersectwith(entity,-autodesk.autocad.databaseservices.intersect,-point3dcollection,-intptr,-intptr))
- [IntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Point3dCollection, long, long)](#intersectwith(entity,-autodesk.autocad.databaseservices.intersect,-point3dcollection,-long,-long))
- [JoinEntities](#joinentities)
- [JoinEntity](#joinentity)
- [List](#list)
- [MoveGripPointsAt(GripDataCollection, Vector3d, MoveGripPointsFlags)](#movegrippointsat(gripdatacollection,-vector3d,-movegrippointsflags))
- [MoveGripPointsAt(IntegerCollection, Vector3d)](#movegrippointsat(integercollection,-vector3d))
- [MoveStretchPointsAt](#movestretchpointsat)
- [PopHighlight](#pophighlight)
- [PushHighlight](#pushhighlight)
- [RecordGraphicsModified](#recordgraphicsmodified)
- [SaveAs](#saveas)
- [SetDatabaseDefaults()](#setdatabasedefaults())
- [SetDatabaseDefaults(Database)](#setdatabasedefaults(database))
- [SetDragStatus](#setdragstatus)
- [SetGripStatus](#setgripstatus)
- [SetLayerId](#setlayerid)
- [SetPropertiesFrom](#setpropertiesfrom)
- [SetSubentityGripStatus](#setsubentitygripstatus)
- [TransformBy](#transformby)
- [TransformSubentityPathsBy](#transformsubentitypathsby)
- [Unhighlight()](#unhighlight())
- [Unhighlight(FullSubentityPath, [MarshalAs(UnmanagedType.U1)] bool)](#unhighlight(fullsubentitypath,-[marshalas(unmanagedtype.u1)]-bool))

### Properties

- [BlockId](#blockid)
- [BlockName](#blockname)
- [CastShadows](#castshadows)
- [CloneMeForDragging](#clonemefordragging)
- [CollisionType](#collisiontype)
- [Color](#color)
- [ColorIndex](#colorindex)
- [CompoundObjectTransform](#compoundobjecttransform)
- [Ecs](#ecs)
- [EdgeStyleId](#edgestyleid)
- [EntityColor](#entitycolor)
- [FaceStyleId](#facestyleid)
- [ForceAnnoAllVisible](#forceannoallvisible)
- [GeometricExtents](#geometricextents)
- [Hyperlinks](#hyperlinks)
- [IsPlanar](#isplanar)
- [Layer](#layer)
- [LayerId](#layerid)
- [Linetype](#linetype)
- [LinetypeId](#linetypeid)
- [LinetypeScale](#linetypescale)
- [LineWeight](#lineweight)
- [Material](#material)
- [MaterialId](#materialid)
- [MaterialMapper](#materialmapper)
- [PlotStyleName](#plotstylename)
- [PlotStyleNameId](#plotstylenameid)
- [ReceiveShadows](#receiveshadows)
- [Transparency](#transparency)
- [Visible](#visible)
- [VisualStyleId](#visualstyleid)


## Methods Details

### AddSubentityPaths

#### Description
Adds one or more subentities to an entity. 
The prototype of this method is provided for completeness of the subentity manipulation APIs. AutoCAD will never call this method on a custom object.
```text
public void AddSubentityPaths(
    FullSubentityPath\[\] subPaths
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath[] subPaths | Input an array of FullSubentityPath identifiers to add to the entity. |

### BoundingBoxIntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Plane, Point3dCollection, IntPtr, IntPtr)

#### Description
Projects the bounding box edges of this entity and the entityPointer entity onto the projectionPlane, finds the intersection points, and then projects the intersection points back onto the appropriate bounding box edge of this entity. 
All points appended to the points array are on the bounding box edges of the entity. The projections are done parallel to the projectionPlane's normal vector.
```text
public void BoundingBoxIntersectWith(
    Entity entityPointer, 
    Autodesk.AutoCAD.DatabaseServices.Intersect intersectType, 
    Plane projectionPlane, 
    Point3dCollection points, 
    IntPtr thisGraphicSystemMarker, 
    IntPtr otherGraphicSystemMarker
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entityPointer | Input entity with which "this" entity will intersect |
| Autodesk.AutoCAD.DatabaseServices.Intersect intersectType | Input requested intersection type |
| Plane projectionPlane | Input projection plane for the apparent intersection of the two entities |
| Point3dCollection points | Output with the points (in WCS coordinates) of intersection appended |
| IntPtr thisGraphicSystemMarker | Input GS marker of subentity of "this" entity that's involved in the intersection operation. May be 0 if not applicable |
| IntPtr otherGraphicSystemMarker | Input GS marker of subentity of the entity pointed to by entityPointer that's involved in the intersection operation. May be 0 if not applicable |

#### Remarks
The possible Intersect values for intersectType are: 
| Intersect.OnBothOperands | Do not extend either this entity's bounding box edges nor the entityPointer entity. This results in only calculating intersections where the bounding box lines actually intersect with the entityPointer entity. |
| --- | --- |
| Intersect.ExtendThis | Extend this entity's bounding box edges (if necessary) when calculating intersections, but do not extend the entityPointer entity. |
| Intersect.ExtendArg | Extend the entityPointer entity (if necessary) when calculating intersections, but do not extend this entity's bounding box edges. |
| Intersect.ExtendBoth | Extend both the entityPointer entity and this entity's bounding box edges (if necessary) when calculating intersections |

### BoundingBoxIntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Plane, Point3dCollection, long, long)

#### Description
**Obsolete** \- Use the BoundingBoxIntersectWith method that accepts IntPtr values instead. 
Projects the bounding box edges of this entity and the entityPointer entity onto the projectionPlane, finds the intersection points, and then projects the intersection points back onto the appropriate bounding box edge of this entity. 
All points appended to the points array are on the bounding box edges of the entity. The projections are done parallel to the projectionPlane's normal vector.
Class
Autodesk.AutoCAD.DatabaseServices.Entity
#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entityPointer | Input entity with which "this" entity will intersect |
| Autodesk.AutoCAD.DatabaseServices.Intersect intersectType | Input requested intersection type |
| Plane projectionPlane | Input projection plane for the apparent intersection of the two entities |
| Point3dCollection points | Output with the points (in WCS coordinates) of intersection appended |
| long thisGraphicSystemMarker | Input GS marker of subentity of "this" entity that's involved in the intersection operation. May be 0 if not applicable |
| long otherGraphicSystemMarker | Input GS marker of subentity of the entity pointed to by entityPointer that's involved in the intersection operation. May be 0 if not applicable |

#### Remarks
The possible Intersect values for intersectType are: 
| Intersect.OnBothOperands | Do not extend either this entity's bounding box edges nor the entityPointer entity. This results in only calculating intersections where the bounding box lines actually intersect with the entityPointer entity. |
| --- | --- |
| Intersect.ExtendThis | Extend this entity's bounding box edges (if necessary) when calculating intersections, but do not extend the entityPointer entity. |
| Intersect.ExtendArg | Extend the entityPointer entity (if necessary) when calculating intersections, but do not extend this entity's bounding box edges. |
| Intersect.ExtendBoth | Extend both the entityPointer entity and this entity's bounding box edges (if necessary) when calculating intersections |

public void BoundingBoxIntersectWith( 
Entity entityPointer, 
Autodesk.AutoCAD.DatabaseServices.Intersect intersectType, 
Plane projectionPlane, 
Point3dCollection points, 
IntPtr thisGraphicSystemMarker, 
IntPtr otherGraphicSystemMarker 
);
Previous Declaration
```text
public void BoundingBoxIntersectWith(Entity entityPointer, Autodesk.AutoCAD.DatabaseServices.Intersect intersectType, Plane projectionPlane, Point3dCollection points, int thisGraphicSystemMarker, int otherGraphicSystemMarker);
```

### BoundingBoxIntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Point3dCollection, IntPtr, IntPtr)

#### Description
This method first calculates the bounding box for this entity (in WCS coordinates). It then finds the intersections of the entity pointed to by entityPointer and all the edges of the bounding box of this entity.
```text
public void BoundingBoxIntersectWith(
    Entity entityPointer, 
    Autodesk.AutoCAD.DatabaseServices.Intersect intersectType, 
    Point3dCollection points, 
    IntPtr thisGraphicSystemMarker, 
    IntPtr otherGraphicSystemMarker
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entityPointer | Input entity with which "this" entity will intersect |
| Autodesk.AutoCAD.DatabaseServices.Intersect intersectType | Input requested intersection type |
| Point3dCollection points | Output with the points (in WCS coordinates) of intersection appended |
| IntPtr thisGraphicSystemMarker | Input GS marker of subentity of "this" entity that's involved in the intersection operation. May be 0 if not applicable |
| IntPtr otherGraphicSystemMarker | Input GS marker of subentity of the entity pointed to by entityPointer that's involved in the intersection operation. May be 0 if not applicable |

#### Remarks
The intersectType is used to determine how to deal with extending the boundary edges or the entityPointer entity in order to calculate intersections. 
The possible Intersect values are: 
| Intersect.OnBothOperands | Do not extend either this entity's bounding box edges nor the entityPointer entity. This results in only calculating intersections where the bounding box lines actually intersect with the entityPointer entity. |
| --- | --- |
| Intersect.ExtendThis | Extend this entity's bounding box edges (if necessary) when calculating intersections, but do not extend the entityPointer entity. |
| Intersect.ExtendArg | Extend the entityPointer entity (if necessary) when calculating intersections, but do not extend this entity's bounding box edges. |
| Intersect.ExtendBoth | Extend both the entityPointer entity and this entity's bounding box edges (if necessary) when calculating intersections |

Any intersection points found are appended to the points array. All points are in WCS coordinates. 
**Note** In the process of determining the intersections of the entityPointer entity with the bounding box edges of this entity, the non-projection plane version of entityPointer's intersectWith() method may be called (if the entityPointer entity is a custom entity, then the intersectWith() method will definitely be called). If the intersectWith() method has not been implemented for the entityPointer entity's class, then this function fails if that method is called. 
The thisGraphicSystemMarker and otherGraphicSystemMarker arguments are only used if the entityPointer entity's intersectWith() method is called, and even then they are just passed on into that method where they may still not be used.
### BoundingBoxIntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Point3dCollection, long, long)

#### Description
**Obsolete** \- Use the BoundingBoxIntersectWith method that accepts IntPtr values instead. 
First calculates the bounding box for this entity (in WCS coordinates). It then finds the intersections of the entity pointed to by entityPointer and all the edges of the bounding box of this entity.
Class
Autodesk.AutoCAD.DatabaseServices.Entity
#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entityPointer | Input entity with which "this" entity will intersect |
| Autodesk.AutoCAD.DatabaseServices.Intersect intersectType | Input requested intersection type |
| Point3dCollection points | Output with the points (in WCS coordinates) of intersection appended |
| long thisGraphicSystemMarker | Input GS marker of subentity of "this" entity that's involved in the intersection operation. May be 0 if not applicable |
| long otherGraphicSystemMarker | Input GS marker of subentity of the entity pointed to by entityPointer that's involved in the intersection operation. May be 0 if not applicable |

#### Remarks
The intersectType is used to determine how to deal with extending the boundary edges or the entityPointer entity in order to calculate intersections. 
The possible Intersect values are: 
| Intersect.OnBothOperands | Do not extend either this entity's bounding box edges nor the entityPointer entity. This results in only calculating intersections where the bounding box lines actually intersect with the entityPointer entity. |
| --- | --- |
| Intersect.ExtendThis | Extend this entity's bounding box edges (if necessary) when calculating intersections, but do not extend the entityPointer entity. |
| Intersect.ExtendArg | Extend the entityPointer entity (if necessary) when calculating intersections, but do not extend this entity's bounding box edges. |
| Intersect.ExtendBoth | Extend both the entityPointer entity and this entity's bounding box edges (if necessary) when calculating intersections |

Any intersection points found are appended to the points array. All points are in WCS coordinates. 
**Note** In the process of determining the intersections of the entityPointer entity with the bounding box edges of this entity, the non-projection plane version of entityPointer's intersectWith() method may be called (if the entityPointer entity is a custom entity, then the intersectWith() method will definitely be called). If the intersectWith() method has not been implemented for the entityPointer entity's class, then this function fails if that method is called. 
The thisGraphicSystemMarker and otherGraphicSystemMarker arguments are only used if the entityPointer entity's intersectWith() method is called, and even then they are just passed on into that method where they may still not be used.
public void BoundingBoxIntersectWith( 
Entity entityPointer, 
Autodesk.AutoCAD.DatabaseServices.Intersect intersectType, 
Point3dCollection points, 
IntPtr thisGraphicSystemMarker, 
IntPtr otherGraphicSystemMarker 
);
Previous Declaration
```text
public void BoundingBoxIntersectWith(Entity entityPointer, Autodesk.AutoCAD.DatabaseServices.Intersect intersectType, Point3dCollection points, int thisGraphicSystemMarker, int otherGraphicSystemMarker);
```

### DeleteSubentityPaths

#### Description
Deletes one or more subentities from an entity. 
Custom objects which expose subentity behavior can choose to override this method to support erasing subentities from the main entity.
```text
public void DeleteSubentityPaths(
    FullSubentityPath\[\] subPaths
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath[] subPaths | Input an array of FullSubentityPath identifiers to delete from the entity |

### Draw

#### Description
This function queues up the entity's graphics and flushes the graphics queue, forcing the entity and anything else in the queue to be drawn or re-drawn on-screen.
```text
public void Draw();
```

### Explode

#### Description
This function is primarily intended for AutoCAD to call as part of an explode operation that includes this entity. However, this function can be used by ObjectARX applications to obtain a collection of pointers to non-database-resident entity objects that are what the entity considers to be its exploded parts. 
When calling this function, the entitySet collection does not need to be empty. This function will append to it, and pointers to entities that it creates to be used in its place as the "exploded" result. 
Function Implementation in Derived Classes
This function should dynamically create (using the new operator) whatever entity objects are appropriate to be used to replace the entity after an explode operation has taken place. Pointers to these entities are then appended to the entitySet collection. 
Note
This function must not add the new entities to the database, nor should it erase the entity it is a part of. Both of these steps will be taken care of by AutoCAD (or whatever other application calls this function). 
This also means that if an ObjectARX application calls the explode method of an object, the calling application is responsible for the resulting entities (that is, either appending them to a database or deleting them when they are no longer needed) and for erasing the original entity (if appropriate). 
Custom Entities
When using a custom entity, you must define an explode method in order for the AutoCAD commands BHATCH and EXPLODE to work. Your explode method should break your entity down into less complicated entities.
```text
public void Explode(
    DBObjectCollection entitySet
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DBObjectCollection entitySet | Input collection of pointers to new entities; this array may already contain pointers from other entities' explode() methods |

### GetGraphicsMarkersAtSubentityPathIntPtr

#### Description
Entities use various graphic primitives to draw themselves. Part of this mechanism is the ability to associate an integer identifier called a graphics system marker (or, GS marker) with each primitive or with groups of primitives. Through the use of certain selection mechanisms the GS marker for the actual subentity selected on screen can be obtained and used with this function and several other functions for various purposes such as highlighting or unhighlighting the subentity on screen.
Function usage
This function uses the SubentId property within the subPath object to determine which GS markers within the entity are appropriate. Any GS markers that match are appended to the returned collection. 
The subPath object's object ID array is not used, so it does not need to be filled in. 
The SubentId object within subPath does needs to be fully filled in with the desired SubentityType and a valid index value (which may or may not actually be the GS marker). 
Typically, this function will be called with an FullSubentityPath object that was filled in by the entity's Entity.GetSubentityPathsAtGraphicsMarker() method. 
Function implementation in derived classes
This function must be able to properly interpret the SubentityType and index values in the SubentId property within subPath in order to determine the GS markers for the corresponding subentity (or subentities). The GS markers thus determined are then appended to the returned collection. 
The index values in SubentId objects can be any values you want (they are often simply the GS markers themselves), but if implemented, the GetSubentityPathsAtGraphicsMarker() method must be able to calculate them based on a provided GS marker and, if implemented, the GetSubentity() method must be able to interpret them to determine the corresponding subentity (or subentities): 
Returns a collection of GSMarker(s) pointer(s) for the subentity (or subentities) 
**Note** The Entity.Highlight() and Entity.Unhighlight() methods both call this function to obtain the GS marker(s) associated with a FullSubentityPath. If this function is not overridden, then they will not work. 
```text
public IntPtrCollection GetGraphicsMarkersAtSubentityPathIntPtr(
    FullSubentityPath subPath
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath subPath | Input FullSubentityPath object that contains an SubentId property with the information necessary to determine the subentity (or subentities) for which the GS Marker(s) is requested. |

### GetGripPoints(GripDataCollection, double, int, Vector3d, GetGripPointsFlags)

#### Description
This .NET method wraps the ObjectARX method [AcDbEntity::getGripPoints](AcDbEntity__getGripPoints@AcDbGripDataPtrArray_@double@int@AcGeVector3d_@int@const.md).
```text
public bool GetGripPoints(
    GripDataCollection grips, 
    double curViewUnitSize, 
    int gripSize, 
    Vector3d curViewDir, 
    GetGripPointsFlags bitFlags
);
```

### GetGripPoints(Point3dCollection, IntegerCollection, IntegerCollection)

#### Description
Function usage
This function supports "old style" grips, in applications that existed before the enhancement of grip functionality. 
This function is not intended to be called by ObjectARX applications. However, it is possible to do so (for example, as a pass-through from the GetStretchPoints() method).
Function implementation in derived classes
This function should append to the gripPoints array any points that are to treated as grip points for the entity. 
The gripPoints array is passed to all entities involved in the grip operation, so the array may already contain grip points for other entities. Therefore, it is very important to append the new points rather than assigning them to any existing elements in the array. 
The snapModes and geometryIds arguments are not currently used.
```text
public void GetGripPoints(
    Point3dCollection gripPoints, 
    IntegerCollection snapModes, 
    IntegerCollection geometryIds
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3dCollection gripPoints | Input pre-existing array to append the grip points to; output with the entity's grip points appended |
| IntegerCollection snapModes | not currently used |
| IntegerCollection geometryIds | not currently used |

### GetGripPointsAtSubentityPath

#### Description
This .NET method wraps the ObjectARX method [AcDbEntity::getGripPointsAtSubentPath](AcDbEntity__getGripPointsAtSubentPath@AcDbFullSubentPath_@AcDbGripDataPtrArray_@double@int@AcGeVector3d_@int@const.md).
```text
public bool GetGripPointsAtSubentityPath(
    FullSubentityPath subPath, 
    GripDataCollection grips, 
    double curViewUnitSize, 
    int gripSize, 
    Vector3d curViewDir, 
    GetGripPointsFlags bitFlags
);
```

### GetObjectSnapPoints(ObjectSnapModes, int, Point3d, Point3d, Matrix3d, Point3dCollection, IntegerCollection)

#### Description
This function must use the material provided in snapMode, gsSelectionMark, pickPoint, lastPoint, and viewTransform to determine all appropriate osnap points for the entity. It must then append all such osnap points to the snapPoints array. 
The snapPoints array is passed to all entities involved in the osnap operation, so it's possible that the array will already have entries in it when passed in. For this reason, it's very important that points be appended to the snapPoints array instead of assigning to any existing elements. 
The snapMode argument indicates which osnap mode is involved in the operation. Not all modes are applicable to all entity types (for example, ObjectSnapModes.ModeIns is not applicable to a line). The possible values for this argument are: 
| ObjectSnapModes.ModeEnd | Find the endpoint on the entity that is nearest to the pickPoint. |
| --- | --- |
| ObjectSnapModes.ModeMid | Find the midpoint (of any line, arc, etc., subentity) that is nearest to the pickPoint |
| ObjectSnapModes.ModeCenter | Find the center point (of any circle or arc subentity) that is nearest to the pickPoint |
| ObjectSnapModes.ModeNode | Find the node point (for example, dimension node points) that is nearest to the pickPoint |
| ObjectSnapModes.ModeQuad | Find the quad point (traditionally the four quadrant points on a circle) that's nearest to pickPoint |
| ObjectSnapModes.ModeIns | Find the intersection point of the entity and a line perpendicular to the entity that passes through lastPoint |
| ObjectSnapModes.ModePerpindicular | Find the intersection point of the entity and a line perpendicular to the entity that passes through lastPoint |
| ObjectSnapModes.ModeTangent | Find a point on the entity where a line that passes through lastPoint will be tangent to the entity |
| ObjectSnapModes.ModeNear | Find the point on the entity that's nearest to pickPoint. You decide what 'nearest' means |

The gsSelectionMark argument contains the GS marker of the subentity that's involved in the osnap operation. If the entity hasn't set any GS markers, then this is the default GS marker value of 0. The GS marker is provided to allow narrowing down the osnap point(s) search parameter if desired. 
The pickPoint argument provides the point (in WCS coordinates) that started this osnap operation. 
The lastPoint argument provides the point picked just prior to the pickPoint point. This point is used when determining perpendicular and tangent osnap values. 
The viewTransform argument provides a transformation matrix to transform from WCS (World Coordinate System) to DCS (display coordinate system). 
The display coordinate system is oriented such that the positive Z axis is coming out of the display screen towards the user, the positive X axis is horizontally from left to right on screen, and the positive Y axis is vertically upward on screen. 
So, if the current viewpoint is at (1,0,0) (the viewer is always looking towards (0,0,0)) then the viewTransform matrix would be: 
```text
0 1 0 0
0 0 1 0
1 0 0 0
0 0 0 1
```

In this matrix the last row and the last column are not used. Notice also that the third row is the DCS Z axis in WCS coordinates (which is the WCS version of the AutoCAD VIEWPOINT system variable). 
This transformation matrix is provided to allow you to determine positions of various points in the current view. This is most useful for the ObjectSnapModes.ModeNear mode where "nearest" may depend on the viewpoint. 
The snapPoints argument is the array to append the resulting osnap points to. You may append zero or more points to the array. 
This same array is passed to all entities involved in the osnap operation. When all entities have been queried, AutoCAD determines which point in the array is most appropriate for the desired osnap mode. So, this function does not need to narrow the search down to one point.
```text
public void GetObjectSnapPoints(
    ObjectSnapModes snapMode, 
    int gsSelectionMark, 
    Point3d pickPoint, 
    Point3d lastPoint, 
    Matrix3d viewTransform, 
    Point3dCollection snapPoints, 
    IntegerCollection geometryIds
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectSnapModes snapMode | Input osnap mode being requested |
| int gsSelectionMark | Input GS marker of the subentity involved in the object snap operation |
| Point3d pickPoint | Input point (in WCS coordinates) picked during the object snap operation |
| Point3d lastPoint | Input point (in WCS coordinates) selected just before pickPoint |
| Matrix3d viewTransform | Input transformation matrix to transform from WCS to DCS |
| Point3dCollection snapPoints | Input pre-existing array to append osnap points to (may already contain points); output with object snap points appended |
| IntegerCollection geometryIds | Not in use |

### GetObjectSnapPoints(ObjectSnapModes, int, Point3d, Point3d, Matrix3d, Point3dCollection, IntegerCollection, Matrix3d)

#### Description
This function behaves exactly as its counterpart without the insertionMat parameter. Entities contained in a block will receive the block transformation in the insertionMat parameter.
```text
public void GetObjectSnapPoints(
    ObjectSnapModes snapMode, 
    int gsSelectionMark, 
    Point3d pickPoint, 
    Point3d lastPoint, 
    Matrix3d viewTransform, 
    Point3dCollection snapPoints, 
    IntegerCollection geometryIds, 
    Matrix3d insertionMat
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectSnapModes snapMode | Input osnap mode being requested |
| int gsSelectionMark | Input GS marker of the subentity involved in the object snap operation |
| Point3d pickPoint | Input point (in WCS coordinates) picked during the object snap operation |
| Point3d lastPoint | Input point (in WCS coordinates) selected just before pickPoint |
| Matrix3d viewTransform | Input transformation matrix to transform from WCS to DCS |
| Point3dCollection snapPoints | Input pre-existing array to append osnap points to (may already contain points); output with object snap points appended |
| IntegerCollection geometryIds | Not in use |
| Matrix3d insertionMat | Input block transformation |

### GetPlane

#### Description
Returns the plane which contains the curve.
```text
public virtual Plane GetPlane();
```

### GetStretchPoints

#### Description
Function usage
This function is not intended to be called by ObjectARX applications. However, it is possible to do so (for example, as a pass-through from the GetGripPoints() method).
Function implementation in derived classes
This function should append to the stretchPoints array any points that are to treated as stretch points for the entity. 
Stretch points are used by the stretch command within AutoCAD. Any stretch points that are within the crossing selection window during the stretch command, will be moved by whatever amount the user decides to "stretch" the selected entities. Any stretch points not in the crossing selection window will be left alone. This combination of some stretch points moving while others do not is what "stretches" the entity. If all stretch points are in the crossing window, then the entity is moved instead of stretched. 
The stretchPoints array is passed to all entities involved in the stretch operation, so the array may already contain stretch points for other entities. Therefore it is very important to append the new points rather than assigning them to any existing elements in the array.
Default implementation
Calls the Entity.GetGripPoints() method. So, unless the entity needs to have stretch points that are different from the grip points, there is no need to override this method.
```text
public void GetStretchPoints(
    Point3dCollection stretchPoints
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3dCollection stretchPoints | Input pre-existing array to append the stretch points to; output with the entity's stretch points appended |

### GetSubentity

#### Description
Obtains the subentity.
```text
public Entity GetSubentity(
    FullSubentityPath id
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath id | Input the path to the subentity |

### GetSubentityGeometricExtents

#### Description
Retrieves the geometric extents for a subentity. 
Unimplemented at the Entity level, this method is intended to be overridden in derived classes. 
Derived classes should calculate and return the corner points (in WCS coordinates) of a box (with edges parallel to the WCS X, Y, and Z axes) that encloses the 3D extents of the subentity, and return those points as an instance of class Extents in the "extents" parameter.
```text
public Extents3d GetSubentityGeometricExtents(
    FullSubentityPath subPath
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath subPath | Input the path to the subentity |

### GetSubentityPathsAtGraphicsMarker(SubentityType, IntPtr, Point3d, Matrix3d, ObjectId[])

#### Description
This is GetSubentityPathsAtGraphicsMarker, a member of class Entity.
```text
public FullSubentityPath\[\] GetSubentityPathsAtGraphicsMarker(
    SubentityType type, 
    IntPtr gsMark, 
    Point3d pickPoint, 
    Matrix3d viewTransform, 
    ObjectId\[\] entityAndInsertStack
);
```

### GetSubentityPathsAtGraphicsMarker(SubentityType, long, Point3d, Matrix3d, int, ObjectId[])

#### Description
**Obsolete** \- Use the GetSubentityPathsAtGraphicsMarker method that accepts an IntPtr value.
Class
Autodesk.AutoCAD.DatabaseServices.Entity
public FullSubentityPath[] GetSubentityPathsAtGraphicsMarker( 
SubentityType type, 
IntPtr gsMark, 
Point3d pickPoint, 
Matrix3d viewTransform, 
ObjectId[] entityAndInsertStack 
);
Previous Declaration
```text
public FullSubentityPath[] GetSubentityPathsAtGraphicsMarker(SubentityType type, int gsMark, Point3d pickPoint, Matrix3d viewTransform, int numInserts, ObjectId[] entityAndInsertStack);
```

### GetTransformedCopy

#### Description
Function usage
This function creates a clone of the entity, applies the transform transformation matrix to the clone, and then returns the transformed clone. 
**Warning** For AutoCAD built-in complex entities such as polylines, this function produces a shallow clone of the header entity only, which also owns the original set of "owned" entities (such as vertices for a polyline) which are then transformed by the transform matrix. This results in a corrupt drawing (two header entities owning the same set of "owned" entities) as well as transforming the original set of "owned" entities instead of a copied set. 
**Function implementation in derived classes**
The default Entity implementation of this function should be adequate for most derived entity types. However, derived entity classes that wish to support non-uniform scaling or non-orthogonal transformations will need to override this method with their own implementation. 
This function must create a copy of the entity (using memory that has been dynamically allocated), apply the transformation matrix transform to the copy and then return the transformed copy. 
Determining what constitutes a valid transformation matrix and whether to do a shallow clone (that is, the entity's clone() method), a deepclone (if the entity owns other objects), or no clone at all (that is, make this function a no-op), is up to the implementer. 
**Default implementation**
If the entity is uniformly scaled and orthogonal, Entity.GetTransformedCopy will call the entity's clone() method to create a clone of the entity, then call Entity.TransformBy() on the clone, and then return the transformed clone.
```text
public Entity GetTransformedCopy(
    Matrix3d transform
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Matrix3d transform | Input matrix by which to transform the copy of the entity |

### Highlight()

#### Description
Function usage
This function highlights the entire entity on the screen. 
It is not necessary to balance each Highlight() function call with a corresponding call to Unhighlight(). Calling the Unhighlight() function will unhighlight the entity regardless of how many times the highlight function has been called on it. 
Warning
If the entity on which this method is called has its graphics queued for regeneration (that is, changes have been made to the entity but have not yet been reflected on screen), then this method will not cause a highlight to occur. Also, calling this method on an entity that's open for write and whose graphics are queued for regeneration may terminate AutoCAD. 
To avoid this limitation, before calling Highlight(), you should flush the entity's graphics by either calling the entity's Draw() method, or calling the TransactionManager.FlushGraphics() function. 
Function implementation in derived classes
The Entity.Highlight() implementation does all the work necessary to highlight any subentities. So, there is no need to override this method unless you wish to do some pre-or post-processing, or you wish to disable the ability to highlight subentities. 
If this method is overridden and it is supposed to highlight subentities, then the Entity.Highlight() method will need to be invoked at some point within this function in order to do the actual highlighting.
```text
public void Highlight();
```

### Highlight(FullSubentityPath, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Function usage
This function uses the FullSubentityPath ID to determine which subentity in the entity is desired. It then highlights that subentity on screen. If no FullSubentityPath argument is provided, then the entire entity will be highlighted. 
Typically, the FullSubentityPath object passed in via subId is obtained from the entity's Entity.GetSubentPathsAtGraphicsMarker() method. This guarantees that it is fully and properly filled in. 
This function uses the entity's GetGraphicsMarkersAtSubentPath() method to get the GS markers associated with subId. 
It is not necessary to balance each Highlight() function call with a corresponding call to Unhighlight(). Calling the Unhighlight() function will unhighlight the entity designated by subId regardless of how many times the highlight function has been called on it. 
Warning
If the entity on which this method is called has its graphics queued for regeneration (that is, changes have been made to the entity but have not yet been reflected on screen), then this method will not cause a highlight to occur. Also, calling this method on an entity that's open for write and whose graphics are queued for regeneration may terminate AutoCAD. 
To avoid this limitation, before calling highlight(), you should flush the entity's graphics by either calling the entity's draw() method, or calling the TransactionManager.FlushGraphics() function. 
Function implementation in derived classes
The Entity.Highlight() implementation does all the work necessary to highlight any subentities that correspond to the subId. So, there is no need to override this method unless you wish to do some pre-or post-processing, or you wish to disable the ability to highlight subentities. 
If this method is overridden and it is supposed to highlight subentities, then the Entity.Highlight() method will need to be invoked at some point within this function in order to do the actual highlighting. 
Within the Entity.Highlight() method, the GetGraphicsMarkersAtSubentPath() method of this entity is called to translate the FullSubentityPath into the corresponding GS markers. So, if this function is to succeed, the GetGraphicsMarkersAtSubentPath() method needs to be implemented as well. 
For more information on the subId argument, see the documentation on the GetGraphicsMarkersAtSubentPath() or GetSubentPathsAtGraphicsMarker() methods.
```text
public void Highlight(
    FullSubentityPath subId, 
    [MarshalAs(UnmanagedType.U1)] bool highlightAll
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath subId | Input FullSubentityPath that identifies the subentity to highlight |
| [MarshalAs(UnmanagedType.U1)] bool highlightAll | Input Boolean indicating whether to highlight in all viewports |

### HighlightState

#### Description
This wraps the ObjectARX [AcDbEntity::highlightState](AcDbEntity__highlightState@AcDbFullSubentPath_.md)() method.
```text
public HighlightStyle HighlightState(
    FullSubentityPath subId
);
```

### IntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Plane, Point3dCollection, IntPtr, IntPtr)

#### Description
Function usage
This method finds the intersections of the entity pointed to by entityPointer and all the edges of the bounding box of this entity. 
The intersectType is used to determine how to deal with extending the two entities in order to calculate intersections. 
Any intersection points found are appended to the points array. All points are in WCS coordinates. 
The thisGraphicSystemMarker and otherGraphicSystemMarker arguments are intended to provide this function with information to allow it to localize the search for intersections to be between specific subentities. However, this function is not required to make use of either of these arguments (most, if not all, of the AutoCAD built-in entity classes do not). When calling this function, either or both of these arguments may be 0 in order to indicate that they should be ignored. 
Function implementation in derived classes
This function should do all it can to find all intersection points between the entity it's being called on and the entity pointed to by entityPointer. All intersection points found should be appended to the points array. All such points must be in WCS coordinates. 
When implementing the intersection calculation portion of this function you should take a good look at the graphics classes to see if they can provide any useful functionality to help in finding intersections with the geometric primitives that make up the entity this function is being called on and the entityPointer entity. For example, the Curve3d class has an IsOn() method that will indicate if a supplied point is on the curve and the CircularArc3d class has several IntersectWith() methods to find intersections with other graphics types. 
If the entityPointer entity is a type not recognized by this function, it is quite reasonable to call the entityPointer entity's IntersectWith() method passing in a pointer to this entity as the "entityPointer", and all the other arguments passed into this function (remembering to convert the intType argument If necessary) to see if that entity can determine any intersection points. This is what the AutoCAD built-in classes do. 
Also, don't forget to take into account the intersectType value. The intersectType tells you which, if any, of the two entities should be extended to find "apparent" intersections. It is not required that apparent intersection be supported. 
The thisGraphicSystemMarker and otherGraphicSystemMarker arguments are provided to allow this function to determine exactly which subentities are involved in the intersection operation (for example, if this function is being called by AutoCAD as part of an intersection Osnap operation these arguments would indicate which subentities are within the osnap pickbox). For these arguments, a value less than or equal to zero indicates that that argument should not be used.
```text
public void IntersectWith(
    Entity entityPointer, 
    Autodesk.AutoCAD.DatabaseServices.Intersect intersectType, 
    Plane projectionPlane, 
    Point3dCollection points, 
    IntPtr thisGraphicSystemMarker, 
    IntPtr otherGraphicSystemMarker
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entityPointer | Input entity with which "this" entity is to intersect |
| Autodesk.AutoCAD.DatabaseServices.Intersect intersectType | Input type of intersection requested |
| Point3dCollection points | Output with the points of intersection appended |
| IntPtr thisGraphicSystemMarker | Input GS marker of subentity of "this" entity that's involved in the intersection operation. Use the 0 default if not applicable. |
| IntPtr otherGraphicSystemMarker | Input GS marker of subentity of the entity pointed to by entityPointer that's involved in the intersection operation. Use the 0 default if not applicable. |

### IntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Plane, Point3dCollection, long, long)

#### Description
**Obsolete** \- Use the IntersectWith method that accepts IntPtr values.
Function usage
This method finds the intersections of the entity pointed to by entityPointer and all the edges of the bounding box of this entity. 
The intersectType is used to determine how to deal with extending the two entities in order to calculate intersections. 
Any intersection points found are appended to the points array. All points are in WCS coordinates. 
The thisGraphicSystemMarker and otherGraphicSystemMarker arguments are intended to provide this function with information to allow it to localize the search for intersections to be between specific subentities. However, this function is not required to make use of either of these arguments (most, if not all, of the AutoCAD built-in entity classes do not). When calling this function, either or both of these arguments may be 0 in order to indicate that they should be ignored. 
Function implementation in derived classes
This function should do all it can to find all intersection points between the entity it's being called on and the entity pointed to by entityPointer. All intersection points found should be appended to the points array. All such points must be in WCS coordinates. 
When implementing the intersection calculation portion of this function you should take a good look at the graphics classes to see if they can provide any useful functionality to help in finding intersections with the geometric primitives that make up the entity this function is being called on and the entityPointer entity. For example, the Curve3d class has an IsOn() method that will indicate if a supplied point is on the curve and the CircularArc3d class has several IntersectWith() methods to find intersections with other graphics types. 
If the entityPointer entity is a type not recognized by this function, it is quite reasonable to call the entityPointer entity's IntersectWith() method passing in a pointer to this entity as the "entityPointer", and all the other arguments passed into this function (remembering to convert the intType argument If necessary) to see if that entity can determine any intersection points. This is what the AutoCAD built-in classes do. 
Also, don't forget to take into account the intersectType value. The intersectType tells you which, if any, of the two entities should be extended to find "apparent" intersections. It is not required that apparent intersection be supported. 
The thisGraphicSystemMarker and otherGraphicSystemMarker arguments are provided to allow this function to determine exactly which subentities are involved in the intersection operation (for example, if this function is being called by AutoCAD as part of an intersection Osnap operation these arguments would indicate which subentities are within the osnap pickbox). For these arguments, a value less than or equal to zero indicates that that argument should not be used.
Class
Autodesk.AutoCAD.DatabaseServices.Entity
#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entityPointer | Input entity with which "this" entity is to intersect |
| Autodesk.AutoCAD.DatabaseServices.Intersect intersectType | Input type of intersection requested |
| Plane projectionPlane | Input plane for the projection to occur |
| Point3dCollection points | Output with the points of intersection appended |
| long thisGraphicSystemMarker | Input GS marker of subentity of "this" entity that's involved in the intersection operation. Use the 0 default if not applicable. |
| long otherGraphicSystemMarker | Input GS marker of subentity of the entity pointed to by entityPointer that's involved in the intersection operation. Use the 0 default if not applicable. |

public void IntersectWith( 
Entity entityPointer, 
Autodesk.AutoCAD.DatabaseServices.Intersect intersectType, 
Plane projectionPlane, 
Point3dCollection points, 
IntPtr thisGraphicSystemMarker, 
IntPtr otherGraphicSystemMarker 
);
Previous Declaration
```text
public void BoundingBoxIntersectWith(Entity entityPointer, Autodesk.AutoCAD.DatabaseServices.Intersect intersectType, Plane projectionPlane, Point3dCollection points, int thisGraphicSystemMarker, int otherGraphicSystemMarker);
```

### IntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Point3dCollection, IntPtr, IntPtr)

#### Description
Function usage
This method finds the intersections of the entity pointed to by entityPointer and all the edges of the bounding box of this entity. 
The intersectType is used to determine how to deal with extending the two entities in order to calculate intersections. 
Any intersection points found are appended to the points array. All points are in WCS coordinates. 
The thisGraphicSystemMarker and otherGraphicSystemMarker arguments are intended to provide this function with information to allow it to localize the search for intersections to be between specific subentities. However, this function is not required to make use of either of these arguments (most, if not all, of the AutoCAD built-in entity classes do not). When calling this function, either or both of these arguments may be 0 in order to indicate that they should be ignored. 
Function implementation in derived classes
This function should do all it can to find all intersection points between the entity it's being called on and the entity pointed to by entityPointer. All intersection points found should be appended to the points array. All such points must be in WCS coordinates. 
When implementing the intersection calculation portion of this function you should take a good look at the graphics classes to see if they can provide any useful functionality to help in finding intersections with the geometric primitives that make up the entity this function is being called on and the entityPointer entity. For example, the Curve3d class has an IsOn() method that will indicate if a supplied point is on the curve and the CircularArc3d class has several IntersectWith() methods to find intersections with other graphics types. 
If the entityPointer entity is a type not recognized by this function, it is quite reasonable to call the entityPointer entity's IntersectWith() method passing in a pointer to this entity as the "entityPointer", and all the other arguments passed into this function (remembering to convert the intType argument If necessary) to see if that entity can determine any intersection points. This is what the AutoCAD built-in classes do. 
Also, don't forget to take into account the intersectType value. The intersectType tells you which, if any, of the two entities should be extended to find "apparent" intersections. It is not required that apparent intersection be supported. 
The thisGraphicSystemMarker and otherGraphicSystemMarker arguments are provided to allow this function to determine exactly which subentities are involved in the intersection operation (for example, if this function is being called by AutoCAD as part of an intersection Osnap operation these arguments would indicate which subentities are within the osnap pickbox). For these arguments, a value less than or equal to zero indicates that that argument should not be used.
```text
public void IntersectWith(
    Entity entityPointer, 
    Autodesk.AutoCAD.DatabaseServices.Intersect intersectType, 
    Point3dCollection points, 
    IntPtr thisGraphicSystemMarker, 
    IntPtr otherGraphicSystemMarker
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entityPointer | Input entity with which "this" entity is to intersect |
| Autodesk.AutoCAD.DatabaseServices.Intersect intersectType | Input type of intersection requested |
| Point3dCollection points | Output with the points of intersection appended |
| IntPtr thisGraphicSystemMarker | Input GS marker of subentity of "this" entity that's involved in the intersection operation. Use the 0 default if not applicable. |
| IntPtr otherGraphicSystemMarker | Input GS marker of subentity of the entity pointed to by entityPointer that's involved in the intersection operation. Use the 0 default if not applicable. |

### IntersectWith(Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Point3dCollection, long, long)

#### Description
**Obsolete** \- Use the IntersectWith method that accepts IntPtr values. 
**Function usage**
This method finds the intersections of the entity pointed to by entityPointer and all the edges of the bounding box of this entity. 
The intersectType is used to determine how to deal with extending the two entities in order to calculate intersections. 
Any intersection points found are appended to the points array. All points are in WCS coordinates. 
The thisGraphicSystemMarker and otherGraphicSystemMarker arguments are intended to provide this function with information to allow it to localize the search for intersections to be between specific subentities. However, this function is not required to make use of either of these arguments (most, if not all, of the AutoCAD built-in entity classes do not). When calling this function, either or both of these arguments may be 0 in order to indicate that they should be ignored. 
**Function implementation in derived classes**
This function should do all it can to find all intersection points between the entity it's being called on and the entity pointed to by entityPointer. All intersection points found should be appended to the points array. All such points must be in WCS coordinates. 
When implementing the intersection calculation portion of this function you should take a good look at the graphics classes to see if they can provide any useful functionality to help in finding intersections with the geometric primitives that make up the entity this function is being called on and the entityPointer entity. For example, the Curve3d class has an IsOn() method that will indicate if a supplied point is on the curve and the CircularArc3d class has several IntersectWith() methods to find intersections with other graphics types. 
If the entityPointer entity is a type not recognized by this function, it is quite reasonable to call the entityPointer entity's IntersectWith() method passing in a pointer to this entity as the "entityPointer", and all the other arguments passed into this function (remembering to convert the intType argument If necessary) to see if that entity can determine any intersection points. This is what the AutoCAD built-in classes do. 
Also, don't forget to take into account the intersectType value. The intersectType tells you which, if any, of the two entities should be extended to find "apparent" intersections. It is not required that apparent intersection be supported. 
The thisGraphicSystemMarker and otherGraphicSystemMarker arguments are provided to allow this function to determine exactly which subentities are involved in the intersection operation (for example, if this function is being called by AutoCAD as part of an intersection Osnap operation these arguments would indicate which subentities are within the osnap pickbox). For these arguments, a value less than or equal to zero indicates that that argument should not be used.
Class
Autodesk.AutoCAD.DatabaseServices.Entity
#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entityPointer | Input entity with which "this" entity is to intersect |
| Autodesk.AutoCAD.DatabaseServices.Intersect intersectType | Input type of intersection requested |
| Point3dCollection points | Output with the points of intersection appended |
| long thisGraphicSystemMarker | Input GS marker of subentity of "this" entity that's involved in the intersection operation. Use the 0 default if not applicable. |
| long otherGraphicSystemMarker | Input GS marker of subentity of the entity pointed to by entityPointer that's involved in the intersection operation. Use the 0 default if not applicable. |

public void IntersectWith( 
Entity entityPointer, 
Autodesk.AutoCAD.DatabaseServices.Intersect intersectType, 
Point3dCollection points, 
IntPtr thisGraphicSystemMarker, 
IntPtr otherGraphicSystemMarker 
);
Previous Declaration
```text
public void IntersectWith(Entity entityPointer, Autodesk.AutoCAD.DatabaseServices.Intersect intersectType, Point3dCollection points, int thisGraphicSystemMarker, int otherGraphicSystemMarker);
```

### JoinEntities

#### Description
This wraps AcDbJoinEntityPE::joinEntities(), which when implemented for an Entity can be used to join supported entities together. Some implementations might require the entities be of the same type, while other implementations might convert the data from the other entities to match the type of the this entity.
```text
public IntegerCollection JoinEntities(
    Entity\[\] otherEntities
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity[] otherEntities | The other entities to be joined to the primary entity. Note, some implementations might require all of these entities to be of the same type as the primary entity. |

#### Returns
An array of indices to the entities from the otherEntities array that were successfully joined.
#### Remarks
Line.JoinEntities requires the given entities to be other Line entities that are collinear. 
Arc.JoinEntities requires the given entities to be other Arc entities that lie on the same circle. 
Ellipse.JoinEntities requires the given entities to be other, unclosed Ellipse entities that lie on the same ellipse. 
Spline.JoinEntities requires the given entities to be other, unclosed curves (Line, Polyline, Polyline2d, Polyline3d, Arc, 
Ellipse, Spline, Helix) which share common start or end points. 
Polyline3d.JoinEntities requires the given entities to be other, unclosed curves (Line, Polyline, Polyline2d, Polyline3d, Arc, 
Ellipse, Spline, Helix) which share common start or end points. Some curves (Arc, Ellipse, Spline, Helix) will be approximated by linear segments of the Polyline3d using Spline.ToPolyline. Preconvert those curves if a different approximation is required. 
Polyline2d.JoinEntities requires the given entities to be other, unclosed Polyline2d or Polyline, Line, and/or Arc entities, which share common start or end points. Curve-fit and spline-fit polylines are not supported. 
Polyline.JoinEntities requires the given entities to be other, unclosed Polyline or Polyline2d, Line, and/or Arc entities, which share common start or end points. 
See the JOIN command for additional information about the behavior of the join operation.
#### Exceptions

| Exceptions | Description |
| --- | --- |
| Autodesk.AutoCAD.Runtime.Exception for ErrorStatus {InvalidInput} or {NotApplicable} | _nt_ |

Example
<![CDATA[Database db = Application.DocumentManager.MdiActiveDocument.Database; Autodesk.AutoCAD.DatabaseServices.TransactionManager tm = db.TransactionManager; 
using (Transaction t = tm.StartTransaction()) { try { Line pLine = new Line(new Point3d(10, 10, 0), new Point3d(10, 10, 1)); Line pLine1 = new Line(new Point3d(10, 10, 2), new Point3d(10, 10, 3)); Line pLine2 = new Line(new Point3d(0, 0, 0), new Point3d(1, 1, 0)); Line pLine3 = new Line(new Point3d(1, 1, 0), new Point3d(2, 2, 0)); 
Entity[] otherEntities = new Entity[2]; otherEntities[0] = pLine1; otherEntities[1] = pLine2; 
// join the other entities Autodesk.AutoCAD.Geometry.IntegerCollection joinedEntities = pLine.JoinEntities(otherEntities); if (joinedEntities.Count > 0) Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage("nSome or all entities joined!"); } catch (Autodesk.AutoCAD.Runtime.Exception e) { Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage("nJoin error: "); Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage(e.ErrorStatus.ToString()); } t.Commit(); }]]>
### JoinEntity

#### Description
This wraps AcDbJoinEntityPE::joinEntity, which when implemented for an Entity, it can be used to join two supported entities together. Some implementations might require the this and the secondary entity be of the same type, while other implementations might convert the data from the secondary entity to match the type of the this entity.
```text
public void JoinEntity(
    Entity secondaryEntity
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity secondaryEntity | The secondary entity, which provides the data to be joined to the this entity. |

#### Exceptions

| Exceptions | Description |
| --- | --- |
| Autodesk.AutoCAD.Runtime.Exception for ErrorStatus {InvalidInput} or {NotApplicable} | _nt_ |

Example
<![CDATA[Database db = Application.DocumentManager.MdiActiveDocument.Database; Autodesk.AutoCAD.DatabaseServices.TransactionManager tm = db.TransactionManager; 
using (Transaction t = tm.StartTransaction()) { try { Line pLine1 = new Line(new Point3d(0, 0, 0), new Point3d(1, 1, 0)); Line pLine2 = new Line(new Point3d(1, 1, 0), new Point3d(2, 2, 0)); 
// Join the second line to the first line pLine1.JoinEntity(pLine2); } catch (Autodesk.AutoCAD.Runtime.Exception e) { Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage("nJoin error: "); Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage(e.ErrorStatus.ToString()); } t.Commit(); }]]>
### List

#### Description
Function usage
This function is intended to be called from AutoCAD whenever the entity is selected during the LIST command. However, it can be called from ObjectARX applications if desired. 
This function will print entity specific information to the AutoCAD command line.
Function implementation in derived classes
When implementing this function in a derived class, the first thing that should be done in the function is to make a call to AssertReadEnabled(). The next thing to do is to call the parent class's list() method to allow the parent class to list it's information (the parent class should in turn call its parent class first and so on up the inheritance chain until DBObject is reached. This way all the entity's information will be properly printed out in order). Once the parent class's list function has been called then a series of print() calls can be used to list whatever information is desired.
Default implementation
Lists out the entity's DXF name, the layer, the space the entity resides in (model or paper), and the entity's handle.
```text
public void List();
```

### MoveGripPointsAt(GripDataCollection, Vector3d, MoveGripPointsFlags)

#### Description
This .NET method wraps the ObjectARX method [AcDbEntity::moveGripPointsAtSubentPaths](AcDbEntity__moveGripPointsAtSubentPaths@AcDbFullSubentPathArray_@AcDbVoidPtrArray_@AcGeVector3d_@int.md).
```text
public void MoveGripPointsAt(
    GripDataCollection grips, 
    Vector3d offset, 
    MoveGripPointsFlags bitFlags
);
```

### MoveGripPointsAt(IntegerCollection, Vector3d)

#### Description
Function usage
This function is intended to be called by AutoCAD during a grip edit of the entity. However, it is certainly possible for ObjectARX applications to call this function. 
A call of this function should be preceded by a call to the entity's GetGripPoints() method in order to obtain the valid grip points and the order they come in which is then used to determine the index values to be passed in within the indices array. 
The offset vector indicates the direction and magnitude of the translation to be applied to the grip points specified in indices. 
The end result will be that this function will modify the entity in whatever way it deems appropriate so that the grip points identified by the index values in indices are moved the direction and magnitude of the offset vector. 
Function implementation in derived classes
This function must modify the entity such that the grip points identified by the indices array are translated to the direction and magnitude specified by the offset vector (which is in WCS coordinates). How this affects the rest of the entity is, of course, dependent on the entity, but any other effects must also be taken care of by this function since this is the function that is expected to do all entity modifications that result from the grip edit. 
If this function is implemented in a derived class, then the GetGripPoints() method must also be implemented because the index values within the indices array represent the 0-based index of the grip points appended to the array passed into the GetGripPoints() method. So a value of 0 in the indices array corresponds to the first point that the GetGripPoints() method appended to the array passed into it, a value of 1 in the indices array corresponds to the second point the GetGripPoints() method appended, etc. So, for example, if the user has gripped the first and third points the GetGripPoints() appended, then the indices array would have two elements. The first would be 0 and the second would be 2. 
Because of the dependence of this function on the points appended by the GetGripPoints() method, it is absolutely essential that this function know exactly what points are reported by the GetGripPoints() method and the order they are reported in (that is, the order they are appended to the array passed into the GetGripPoints() method).
Default implementation
Calls the entity's Entity.TransformBy() method with a transformation matrix that translates the entire entity by offset.
```text
public void MoveGripPointsAt(
    IntegerCollection indices, 
    Vector3d offset
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IntegerCollection indices | Input array containing index values (which correspond to grip points reported by the GetGripPoints() method) that indicate which grip points are currently "hot" |
| Vector3d offset | Input vector (in WCS coordinates) indicating the direction and magnitude that the grip points have been translated |

### MoveStretchPointsAt

#### Description
Function usage
This function is intended to be called by AutoCAD during execution of a stretch command in which the entity has been selected. However, it is certainly possible for ObjectARX applications to call this function. 
A call of this function should be preceded by a call to the entity's GetStretchPoints() method in order to obtain the valid stretch points and the order they come in which is then used to determine the index values to be passed in within the indices array. 
The offset vector indicates the direction and magnitude of the translation to be applied to the stretch points specified in indices. 
The end result will be that this function will modify the entity in whatever way it deems appropriate so that the stretch points identified by the index values in indices are moved the direction and magnitude of the offset vector. 
Function implementation in derived classes
This function must modify the entity such that the stretch points identified by the indices array are translated to the direction and magnitude specified by the offset vector (which is in WCS coordinates). How this affects the rest of the entity is, of course, dependent on the entity, but any other effects must also be taken care of by this function since this is the function that is expected to do all entity modifications that result from the stretch operation. 
If this function is implemented in a derived class, then the GetStretchPoints() method must also be implemented because the index values within the indices array represent the 0-based index of the stretch points appended to the array passed into the GetStretchPoints() method. So a value of 0 in the indices array corresponds to the first point that the GetStretchPoints() method appended to the array passed into it, a value of 1 in the indices array corresponds to the second point the GetStretchPoints() method appended, etc. So, for example, if the first and third points the GetGripPoints() appended are to be "stretched" by the stretch operation, then the indices array would have two elements: the first would be 0 and the second would be 2. 
Because of the dependence of this function on the points appended by the GetStretchPoints() method, it is absolutely essential that this function know exactly what points are reported by the GetStretchPoints() method and the order they are reported in (that is, the order they are appended to the array passed into the GetStretchPoints() method). 
Default implementation
Calls the entity's Entity.TransformBy() method with a transformation matrix that translates the entire entity by offset. It then returns whatever status the TransformBy() method returns.
```text
public void MoveStretchPointsAt(
    IntegerCollection indices, 
    Vector3d offset
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IntegerCollection indices | Input array containing index values (which correspond to stretch points reported by the GetStretchPoints() method) that indicate which stretch points are being translated |
| Vector3d offset | Input vector (in WCS coordinates) indicating the direction and magnitude that the stretch points have been translated |

### PopHighlight

#### Description
This wraps the ObjectARX [AcDbEntity::popHighlight](AcDbEntity__popHighlight@AcDbFullSubentPath_.md)() method. 
The current highlight effect of subId will be removed, and the former pushed highlight effect for subId will be displayed again. If there is no former pushed highlight, then the subId has no highlight effect.
```text
public void PopHighlight(
    FullSubentityPath subId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath subId | Input AcDbFullSubentPath that identifies the subentity to unhighlight |

#### See Also
pushHighlight

### PushHighlight

#### Description
This wraps the ObjectARX [AcDbEntity::pushHighlight](AcDbEntity__pushHighlight@AcDbFullSubentPath_@AcGiHighlightStyle.md)() method. 
The later pushed highlight effect will override the former push highlight effect. We could highlight different sub-entity with different style at the same time. 
If we first push sub-entity with highlight style1, then push entity with highlight style2, then the whole entity will display highlight style2. After pop the entity highlight, the former sub-entity will continue display with highlight style1. 
If we first push entity with highlight style1, then push sub-entity with highlight style2, then the whole entity will not be highlight, and only display highlight of sub-entity with highlight style2. After pop the highlight of former sub-entity, the whole entity will display with highlight style1.
```text
public void PushHighlight(
    FullSubentityPath subId, 
    HighlightStyle highlightStyle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath subId | Input AcDbFullSubentPath that identifies the subentity to highlight |
| HighlightStyle highlightStyle | Input AcGiHighlightStyle for this subid |

#### See Also
popHighlight

### RecordGraphicsModified

#### Description
This method sets the entity's state to indicate whether or not the entity should be updated on screen when it is closed. If the entity is set not to update, then any changes made will appear the next time the entity is regenerated. 
If setModified is false and the entity is currently set to update its graphics on close (which is its default state), then this function sets the entity so that it will not update on screen when it is closed and objectModified notification is sent to all entity type reactors attached to the entity. 
If setModified is true, then the entity is set to update on screen when it is closed.
```text
public void RecordGraphicsModified(
    [MarshalAs(UnmanagedType.U1)] bool setModified
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool setModified | Input Boolean value to indicate if the entity's graphics should be updated on screen when the object is closed |

### SaveAs

#### Description
Function usage
This function is used by AutoCAD to generate the graphic primitives whenever a DWG save is occurring that requires proxy graphics to be saved for the entity. Overriding this function allows control of the graphics that will be stored. 
It is possible for an ObjectARX application to call this function, but it will need to provide a fully functional WorldDraw object and the WorldGeometry and SubEntityTraits objects for which it provides references. The only way to do this is to derive custom classes from these three graphics classes. 
Function implementation in derived classes
The WorldDraw object pointed at by mode, as well as the WorldGeometry and SubEntityTraits objects available from the WorldDraw object, are all provided to allow this function to generate whatever graphics primitives are desired to represent the entity when it is displayed as a proxy. The _ObjectARX Developer's Guide_ explains how to use these classes. 
In the contexts that this function is called, there is no need to deal with GS marker assignments. However, all the visible properties such as colors, layer, linetypes, visibilities, etc. are relevant. 
The st argument provides the context for the call of this function. 
The graphics primitives generated by this function will be stored with the entity in the drawing file so that if the drawing is ever loaded up with the entity's controlling application not loaded (that is, the entity becomes a proxy), the entity can still be displayed. 
Default implementation
By default, this method calls the entity's WorldDraw() method using the mode pointer.
```text
public virtual void SaveAs(
    WorldDraw mode, 
    Autodesk.AutoCAD.DatabaseServices.SaveType st
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| WorldDraw mode | Input pointer to fully initialized WorldDraw object (or an object of a class derived from WorldDraw) |
| Autodesk.AutoCAD.DatabaseServices.SaveType st | Input SaveType indicates why the saveAs is being called. |

### SetDatabaseDefaults()

#### Description
This function sets the entity's 
  * Color
  * Layer
  * Linetype
  * Linetype scale
  * Visibility
  * Plot style name
  * Line weight

to the default values of the database in which the entity currently resides or, if the entity is not part of a database yet, the current database in the AutoCAD editor is used.
```text
public void SetDatabaseDefaults();
```

### SetDatabaseDefaults(Database)

#### Description
This function sets the entity's: 
  * Color
  * Layer
  * Linetype
  * Linetype scale
  * Visibility
  * Plot style name
  * Line weight

to the default values of the database indicated by sourceDatabase: If sourceDatabase == NULL, then the current database in the AutoCAD editor is used.
```text
public void SetDatabaseDefaults(
    Database sourceDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database sourceDatabase | Input database whose defaults will be used to set the values of the entity |

### SetDragStatus

#### Description
This function is called when a drag operation involving this entity is starting, ending, or aborting. The status argument provides information about what is happening with the drag operation.
```text
public virtual void SetDragStatus(
    DragStatus status
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DragStatus status | Value describing the status of the drag operation; one of the values from the DragStat enumeration |

### SetGripStatus

#### Description
This notification allows the entity to perform any required resource management tasks before the grip's GripStatus objects and any alternate basepoint objects pointed to by the GripStatus objects are deleted.
```text
public virtual void SetGripStatus(
    GripStatus status
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GripStatus status | Value describing the status of the grip operation; one of the values from the GripStatus enumeration |

### SetLayerId

#### Description
This method sets entity to reference the LayerTableRecord identified by the name specified in newValue. For an BlockReference entity, this method will also update any associated SequenceEnd subentity. 
**Note**
The only built-in entities for which kTrue has an effect are: 2dPolyline, 3dPolyline, PolyFaceMesh, and PolygonMesh. 
The database containing the entity is searched for the LayerTableRecord object with the name pointed to by newValue. If the entity is not currently in a database, then the database currently in the AutoCAD editor is searched. 
Specifying true for allowHidden allows newValue to denote a hidden layer. If this parameter is false (default) and newValue denotes a hidden layer the change request is silently ignored.
```text
public virtual void SetLayerId(
    ObjectId newValue, 
    [MarshalAs(UnmanagedType.U1)] bool allowHidden
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId newValue | Input name of the LayerTableRecord to be referenced by the entity |
| [MarshalAs(UnmanagedType.U1)] bool allowHidden | Input Boolean indicating whether to allow newValue to specify a hidden layer |

### SetPropertiesFrom

#### Description
This method copies the 
  * Color
  * Layer
  * Linetype
  * Linetype scale
  * Visibility

values from the entity pointed to by entityPointer into this entity.
```text
public void SetPropertiesFrom(
    Entity entityPointer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entityPointer | Input entity from which to copy the properties |

### SetSubentityGripStatus

#### Description
This function is called with a status value of GripsToBeDeleted when the grips for the subentity are about to be deleted in the host application. This notification allows the entity to perform any required resource management tasks before the grip's GripStatus objects and any alternate base point objects pointed to by the GripStatus objects are deleted. This notification may be sent more than once for a given grip edit session. If the grip edit session is not over when this notification is sent, the entity will subsequently receive a call to its GetGripPoints() function to acquire new grip points to be used by the grip edit session. 
This function is called with a status value of GripsDone when the grips for the entity have been deleted in the host application and the entity is no longer involved in any grip edit operations.
```text
public void SetSubentityGripStatus(
    GripStatus status, 
    FullSubentityPath subentity
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GripStatus status | Input the status of the grip operation |
| FullSubentityPath subentity | Input the subentity on the object whose grip status changed |

### TransformBy

#### Description
Function usage
This function provides a means by which AutoCAD and ObjectARX applications can ask the entity to apply a transformation matrix (xform) to itself. 
Each entity class must implement this function, so restrictions on what types of transformations are supported are up to the implementer of the entity class. The AutoCAD built-in entity classes for entity types that existed before R13 (such as Circle, Line, Arc, 2dPolyline, etc.) require that the transformation matrix represent a uniformly scaling orthogonal transformation. Other AutoCAD built-in classes have no restrictions. 
Function implementation in derived classes
This function must apply the transformation matrix xform to the entity and change the entity's state to reflect the transformation. It is completely up to the implementer as to how to apply the transformation. It is also up to the implementer to decide what, if any, restrictions will be placed on the type of transformations supported. If any restrictions are desired, then it's up to the implementation of this function to enforce them. 
If your derived class implements TransformBy() without calling the base class, you must call DBObject.XDataTransformBy() or your Xdata will not be transformed. 
**Note** If this method is not overridden, then AutoCAD commands such as MOVE, ROTATE, SCALE, etc. will have no effect on entities of this class. 
```text
public void TransformBy(
    Matrix3d transform
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Matrix3d transform | Input transformation matrix to be applied to the entity |

### TransformSubentityPathsBy

#### Description
Applies a geometric transformation to one or more subentities on an object. 
This function provides a means by which AutoCAD and ObjectARX applications can ask the entity to apply a transformation matrix (xform) to one or more of its subentities. 
Implementation of this method is optional. Restrictions on what types of transformations are supported are up to the implementer of the entity class. 
This function must apply the transformation matrix xform to the subentities and change the entity's state to reflect the transformation. It is completely up to the implementer as to how to apply the transformation. It is also up to the implementer to decide what, if any, restrictions will be placed on the type of transformations supported. If any restrictions are desired, then it's up to the implementation of this function to enforce them. 
**Note** If this method is not overridden, then AutoCAD commands such as MOVE, ROTATE, SCALE, etc. will have no effect on subentities of this class. 
```text
public void TransformSubentityPathsBy(
    FullSubentityPath\[\] subPaths, 
    Matrix3d transform
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath[] subPaths | Input an array of one or more FullSubentityPath objects identifying the subentities to transform |
| Matrix3d transform | Input the WCS transformation to apply to each of the supplied subentities. |

### Unhighlight()

#### Description
Function usage
This unhighlights the entire entity on screen. 
It is not necessary to balance each Highlight() function call with a corresponding call to Unhighlight(). Calling the Unhighlight() function will unhighlight the entity regardless of how many times the highlight function has been called on it. 
Function implementation in derived classes
The Entity.Unhighlight() implementation does all the work necessary to highlight any subentities. So, there is no need to override this method unless you wish to do some pre-or post-processing, or you wish to disable the ability to highlight subentities. 
If this method is overridden and it is supposed to highlight subentities, then the Entity.Unhighlight() method will need to be invoked at some point within this function in order to do the actual unhighlighting.
```text
public void Unhighlight();
```

### Unhighlight(FullSubentityPath, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Function usage
This function uses the FullSubentityPath id to determine which subentity in the entity is desired. It then unhighlights that subentity on screen. If no FullSubentityPathargument is provided, then the entire entity will be unhighlighted. 
Typically the FullSubentityPath object passed in via subId will be obtained from the entity's Entity.GetSubentPathsAtGraphicsMarker() method. This guarantees that it is fully and properly filled in. 
This function uses the entity's GetGsMarkersAtSubentPath() method to get the GS markers associated with subId. 
It is not necessary to balance each Highlight() function call with a corresponding call to Unhighlight(). Calling the Unhighlight() function will unhighlight the entity designated by subId regardless of how many times the highlight function has been called on it. 
Function implementation in derived classes
The Entity.Unhighlight() implementation does all the work necessary to unhighlight any subentities that correspond to the subIdFullSubentPath. So, there is no need to override this method unless you wish to do some pre-or post processing, or you wish to disable the ability to unhighlight subentities. 
If this method is overridden and it is supposed to unhighlight subentities, then the DBEntity.Unhighlight() method needs to be invoked at some point within this function in order to do the actual unhighlighting. 
Within the Entity.Unhighlight() method, the GetGraphicsMarkersAtSubentPath() method of this entity is called to translate the FullSubentityPath into the corresponding GS markers. So, if this function is to succeed, the GetGraphicsMarkersAtSubentPath() method needs to be implemented as well. 
For more information on the subId argument, see the documentation on the Entity.GetGraphicsMarkersAtSubentPath() or Entity.GetSubentPathsAtGraphicsMarker() methods.
```text
public void Unhighlight(
    FullSubentityPath subId, 
    [MarshalAs(UnmanagedType.U1)] bool highlightAll
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath subId | Input FullSubentityPath that identifies which subentity to unhighlight |
| [MarshalAs(UnmanagedType.U1)] bool highlightAll | Input Boolean indicating whether to unhighlight in all viewports |

### BlockId

#### Description
Accesses the ObjectId of the entity's owner, which must be a BlockTableRecord
```text
public ObjectId BlockId;
```

#### Conditions
Read-only
### BlockName

#### Description
Accesses the name of the owner block.
```text
public string BlockName;
```

#### Conditions
Read-only
### CastShadows

#### Description
Accesses whether the entity can cast shadows.
```text
public bool CastShadows;
```

#### Conditions
Read / Write
### CloneMeForDragging

#### Description
Accesses whether a clone should be created for use in a dragging operation. AutoCAD has always created a clone in the past, but due to entities with large amounts of data (for example, polylines) it is sometimes desirable to have AutoCAD perform dragging with the original entity.
```text
public virtual bool CloneMeForDragging;
```

#### Conditions
Read-only
### CollisionType

#### Description
Accesses the collision detection treatment for this entity. Subclasses may override this method to customize how the class interacts in collision-aware features.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.CollisionType CollisionType;
```

#### Conditions
Read-only
### Color

#### Description
Accesses the full true color information for the entity within an instance of Color.
```text
public Autodesk.AutoCAD.Colors.Color Color;
```

#### Conditions
Read / Write
### ColorIndex

#### Description
Accesses the AutoCAD color number of the entity.
```text
public int ColorIndex;
```

#### Conditions
Read / Write
### CompoundObjectTransform

#### Description
Accesses the transformation matrix used for nested objects.
```text
public virtual Matrix3d CompoundObjectTransform;
```

#### Conditions
Read-only
### Ecs

#### Description
Accesses a transformation matrix that can be used to transform vectors or points from the object's object coordinate system (OCS) to the World Coordinate System (WCS).
```text
public virtual Matrix3d Ecs;
```

#### Conditions
Read-only
### EdgeStyleId

#### Description
Get and set the edge-only visual style object ID.
```text
public ObjectId EdgeStyleId;
```

#### Remarks
Not yet supported. 
### EntityColor

#### Description
Accesses the color settings of the entity in an EntityColor form.
```text
public Autodesk.AutoCAD.Colors.EntityColor EntityColor;
```

#### Conditions
Read / Write
### FaceStyleId

#### Description
Get and set the face-only visual style object ID.
```text
public ObjectId FaceStyleId;
```

#### Remarks
Not yet supported. 
### ForceAnnoAllVisible

#### Description
Accesses the current ANNOALLVISIBLE value for the database 
See the System Variables section of the _AutoCAD Command Reference_ for information on ANNOALLVISIBLE.
```text
public bool ForceAnnoAllVisible;
```

#### Conditions
Read / Write
### GeometricExtents

#### Description
Accesses the corner points (in WCS coordinates) of a box (with edges parallel to the WCS X, Y, and Z axes) that encloses the 3D extents of the entity, and return those points as an instance of class Extents in the "extents" parameter.
```text
public virtual Extents3d GeometricExtents;
```

#### Conditions
Read-only
### Hyperlinks

#### Description
Accesses a collection of hyperlinks associated with the object.
```text
public HyperLinkCollection Hyperlinks;
```

#### Conditions
Read-only
### IsPlanar

#### Description
Assesses if a plane contains the entity.
```text
public virtual bool IsPlanar;
```

#### Conditions
Read-only
### Layer

#### Description
Accesses the name string in the LayerTableRecord object referenced by the entity.
```text
public string Layer;
```

#### Conditions
Read / Write
### LayerId

#### Description
Accesses the ObjectId of the LayerTableRecord referenced by the entity.
```text
public ObjectId LayerId;
```

#### Conditions
Read / Write
### Linetype

#### Description
Accesses the name string in the LinetypeTableRecord object referenced by the entity.
```text
public string Linetype;
```

#### Conditions
Read / Write
### LinetypeId

#### Description
Accesses the ObjectId of the LinetypeTableRecord referenced by the entity.
```text
public ObjectId LinetypeId;
```

#### Conditions
Read / Write
### LinetypeScale

#### Description
Accesses the linetype scale factor for the entity.
```text
public double LinetypeScale;
```

#### Conditions
Read / Write
### LineWeight

#### Description
Accesses the LineWeight of the entity.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight LineWeight;
```

#### Conditions
Read / Write
### Material

#### Description
Accesses the material name.
```text
public string Material;
```

#### Conditions
Read / Write
### MaterialId

#### Description
Accesses the ID of the associated Material object.
```text
public ObjectId MaterialId;
```

#### Conditions
Read / Write
### MaterialMapper

#### Description
Accesses the Mapper that is use to map a material to the entity
```text
public Mapper MaterialMapper;
```

#### Conditions
Read / Write
### PlotStyleName

#### Description
Accesses the plotstyle name string of the entity.
```text
public string PlotStyleName;
```

#### Conditions
Read / Write
### PlotStyleNameId

#### Description
Accesses the object ID of the PlaceHolder object referenced by the entity.
```text
public PlotStyleDescriptor PlotStyleNameId;
```

#### Conditions
Read / Write
### ReceiveShadows

#### Description
Accesses whether this entity can receive shadows.
```text
public bool ReceiveShadows;
```

#### Conditions
Read / Write
### Transparency

#### Description
Accesses the transparency value for the entity.
```text
public Autodesk.AutoCAD.Colors.Transparency Transparency;
```

#### Conditions
Read / Write
### Visible

#### Description
Accesses the visibility of an entity.
```text
public bool Visible;
```

#### Conditions
Read / Write
### VisualStyleId

#### Description
Get and set the full visual style object ID.
```text
public ObjectId VisualStyleId;
```

#### Remarks
Not yet supported. 