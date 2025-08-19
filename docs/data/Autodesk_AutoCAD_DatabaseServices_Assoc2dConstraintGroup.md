# Assoc2dConstraintGroup Class

## Overview

#### Description
The Assoc2dConstraintGroup class represents a set of geometric constraint relations between subentities of geometric entities. All the geometries must lie in a single plane. 
The Assoc2dConstraintGroup object owns the constraints that are derived from the GeometricalConstraint class, and "proxies" of the constrained geometried, derived from ConstrainedGeometry class. ConstrainedGeometries often refer to subentities of AutoCAD entities and the Assoc2dConstraintGroup owns AssocGeomDepedencies on these entities. It also owns AssocValueDependencies on the AssocVariables that are the values of dimensional constraints (represented by classes derived from ExplicitConstraint). 
If the dimensional constraint has a graphical representation, such as in the form of a Dimension entity, the ExplicitConstraint also owns the AssocDependency owning an object derived from the AssocDimDependencyBody that facilitates the interaction between the ExplicitConstraint, the AssocVariable keeping the value of the dimensional constraint, and the Dimension (or other object/entity) that serves as a graphical representation of the dimensional constraint. 
The evaluate() method of this action takes the current properties of the referenced geometries and the current values of the variables referenced by ExplicitConstraints. Then it invokes a constraint solver that finds new positions and shapes of the constrained geometries so that they satisfy the constraints. Finally the referenced geometries are updated to their new positions and shapes. The evaluate method call may fail if a solution satisfying all the constraints can not be found.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocAction
        Autodesk.AutoCAD.DatabaseServices.Assoc2dConstraintGroup
```

```text
public class Assoc2dConstraintGroup : AssocAction;
```

### Constructors

- [Assoc2dConstraintGroup](#assoc2dconstraintgroup)

### Methods

- [Add3PointAngularConstraint](#add3pointangularconstraint)
- [AddAngularConstraint](#addangularconstraint)
- [AddConstrainedGeometry](#addconstrainedgeometry)
- [AddDistanceConstraint](#adddistanceconstraint)
- [AddGeometricalConstraint(GeometricalConstraint.ConstraintType, ConstrainedGeometry[])](#addgeometricalconstraint(geometricalconstraint.constrainttype,-constrainedgeometry[]))
- [AddGeometricalConstraint(GeometricalConstraint.ConstraintType, FullSubentityPath[])](#addgeometricalconstraint(geometricalconstraint.constrainttype,-fullsubentitypath[]))
- [AddGlobalCallback](#addglobalcallback)
- [AddRadiusDiameterConstraint](#addradiusdiameterconstraint)
- [AutoConstrain](#autoconstrain)
- [ConstraintStatus](#constraintstatus)
- [DeleteConstrainedGeometry](#deleteconstrainedgeometry)
- [DeleteConstraint](#deleteconstraint)
- [GeometryMirrored](#geometrymirrored)
- [GeometryStatus](#geometrystatus)
- [GetAllConnectedGeomDependencies](#getallconnectedgeomdependencies)
- [GetConstrainedGeometry(AssocGeomDependency)](#getconstrainedgeometry(assocgeomdependency))
- [GetConstrainedGeometry(AssocGeomDependency, Autodesk.AutoCAD.DatabaseServices.ImplicitPointType, int, [MarshalAs(UnmanagedType.U1)] bool)](#getconstrainedgeometry(assocgeomdependency,-autodesk.autocad.databaseservices.implicitpointtype,-int,-[marshalas(unmanagedtype.u1)]-bool))
- [GetConstrainedGeometry(FullSubentityPath, [MarshalAs(UnmanagedType.U1)] bool)](#getconstrainedgeometry(fullsubentitypath,-[marshalas(unmanagedtype.u1)]-bool))
- [GetGroupNode](#getgroupnode)
- [GlobalCallback](#globalcallback)
- [RegenDimensionSystem](#regendimensionsystem)
- [RemoveGlobalCallback](#removeglobalcallback)
- [SolutionStatus](#solutionstatus)
- [TransformActionBy](#transformactionby)

### Other

- [AutoCAD.DatabaseServices.Assoc2dConstraintGroup.SolutionStatusType Enumeration](#autocad.databaseservices.assoc2dconstraintgroup.solutionstatustype-enumeration)

### Properties

- [ConstrainedGeometries](#constrainedgeometries)
- [Constraints](#constraints)
- [GetDOF](#getdof)
- [WorkPlane](#workplane)


## Constructors Details

### Assoc2dConstraintGroup

#### Description
Default constructor.
```text
public Assoc2dConstraintGroup(
    Plane plane
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Plane plane | Input Plane of the newly created constraint group object. Default value is Plane::kXYPlane. |

### Add3PointAngularConstraint

#### Description
Creates and adds a 3point angle constraint into this constraint group.
```text
public ThreePointAngleConstraint Add3PointAngularConstraint(
    ConstrainedPoint consPoint1, 
    ConstrainedPoint consPoint2, 
    ConstrainedPoint consPoint3, 
    AngularConstraint.AngularSectorType sectorType, 
    ObjectId valueDependencyId, 
    ObjectId dimDependencyId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ConstrainedPoint consPoint1 | Input reference of the first (angle) point which must be a kind of ConstraintPoint |
| ConstrainedPoint consPoint2 | Input reference of the second point which must be a kind of ConstraintPoint |
| ConstrainedPoint consPoint3 | Input reference of the third point which must be a kind of ConstraintPoint |
| AngularConstraint.AngularSectorType sectorType | Input AngularConstraint::SectorType indicating the angle sector to measure. |
| ObjectId valueDependencyId | Input object id of the value dependency object. |
| ObjectId dimDependencyId | Input object id of the dimension dependency object. |

#### Returns
Reference to Ac3PointAngleConstraint* pointing at the newly created Ac3PointAngleConstraint object. Default value is NULL.
### AddAngularConstraint

#### Description
Creates and adds an angle constraint into this constraint group.
```text
public AngularConstraint AddAngularConstraint(
    ConstrainedLine consLine1, 
    ConstrainedLine consLine2, 
    AngularConstraint.AngularSectorType sectorType, 
    ObjectId valueDependencyId, 
    ObjectId dimDependencyId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ConstrainedLine consLine1 | Input reference to ConstrainedLine object |
| ConstrainedLine consLine2 | Input reference to ConstrainedLine object |
| AngularConstraint.AngularSectorType sectorType | Input AngularConstraint.SectorType indicating the angle sector to measure. |
| ObjectId valueDependencyId | Input object id of the value dependency object. |
| ObjectId dimDependencyId | Input object id of the dimension dependency object. |

#### Returns
Reference to AngularConstraint* pointing the newly created AngularConstraint object. Default value is NULL.
### AddConstrainedGeometry

#### Description
Creates and adds a new ConstrainedGeometry object into this constraint group. The caller should not cache the reference returned for future use; instead the caller may cache the node id of ConstrainedGeometry.
```text
public ConstrainedGeometry AddConstrainedGeometry(
    FullSubentityPath subentPath
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath subentPath | Input FullSubentPath of the constrained entity, down to the subentity level. Only SubentityType.Edge and SubentityType.Vertex are valid subent types. The vertex subent must NOT be edge vertex. |

#### See Also
ConstraintGroupNode.NodeId

### AddDistanceConstraint

#### Description
Creates and adds a distance constraint into this constraint group.
```text
public DistanceConstraint AddDistanceConstraint(
    ConstrainedGeometry consGeom1, 
    ConstrainedGeometry consGeom2, 
    DistanceConstraint.DistanceDirectionType directionType, 
    ObjectId valueDependencyId, 
    ObjectId dimDependencyId, 
    Vector3d fixedDirection, 
    ConstrainedLine directionLine
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ConstrainedGeometry consGeom1 | Input reference to the first ConstrainedGeometry object. |
| ConstrainedGeometry consGeom2 | Input reference to the second ConstrainedGeometry object. |
| DistanceConstraint.DistanceDirectionType directionType | Input DistanceConstraint::DirectionType indicating the direction type of the distance constraint to be created. |
| ObjectId valueDependencyId | Input object id of the value dependency object. |
| Vector3d fixedDirection | Input reference to Vector3d indicating the fixed direction of the distance constraint to be created. It will be used only when the directionType is kFixedDirection. Relative to the World Coordinate System. |
| ConstrainedLine directionLine | Input reference to ConstrainedLine object indicating the relative direction of the distance constraint to be created. It will be used only when the directionType is kPerpendicularToLine or kParallelToLine. |

#### Returns
Reference to DistanceConstraint* pointing the newly created DistanceConstraint object. Default value is NULL.
### AddGeometricalConstraint(GeometricalConstraint.ConstraintType, ConstrainedGeometry[])

#### Description
Creates and adds a geometrical constraint into this constraint group.
```text
public GeometricalConstraint AddGeometricalConstraint(
    GeometricalConstraint.ConstraintType type, 
    ConstrainedGeometry\[\] consGeoms
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GeometricalConstraint.ConstraintType type | Input GeometricalConstraint::GeometricalConstraintType indicating the type of constraint to be created. |
| ConstrainedGeometry[] consGeoms | Input array of the ConstrainedGeometry. |

#### Returns
Reference to GeometricalConstraint* pointing the newly created GeometricalConstraint object. Default value is NULL.
### AddGeometricalConstraint(GeometricalConstraint.ConstraintType, FullSubentityPath[])

#### Description
Creates and adds a geometrical constraint into this constraint group.
```text
public GeometricalConstraint AddGeometricalConstraint(
    GeometricalConstraint.ConstraintType type, 
    FullSubentityPath\[\] paths
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GeometricalConstraint.ConstraintType type | Input GeometricalConstraint::GeometricalConstraintType indicating the type of constraint to be created. |
| FullSubentityPath[] paths | Input array of the FullSubentPath which can be mapped to ConstrainedGeometry. |

#### Returns
Reference to GeometricalConstraint* pointing the newly created GeometricalConstraint object. Default value is NULL.
### AddGlobalCallback

#### Description
See the explanation of [Assoc2dConstraintCallback](Autodesk_AutoCAD_DatabaseServices_Assoc2dConstraintCallback.md "Assoc2dConstraintCallback Class"). Multiple global callbacks can be registered and they apply to all Assoc2dConstraintGroup.
```text
public static void AddGlobalCallback(
    Assoc2dConstraintCallback callback
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Assoc2dConstraintCallback callback | The callback to be registered. |

### AddRadiusDiameterConstraint

#### Description
Creates and adds a radius or diameter constraint into this constraint group.
```text
public RadiusDiameterConstraint AddRadiusDiameterConstraint(
    ConstrainedGeometry consGeom, 
    RadiusDiameterConstraint.RadDiaConstrType type, 
    ObjectId valueDependencyId, 
    ObjectId dimDependencyId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ConstrainedGeometry consGeom | Input reference to ConstrainedGeometry object which must be a kind of ConstrainedCircle or ConstrainedEllipse. |
| RadiusDiameterConstraint.RadDiaConstrType type | Input RadiusDiameterConstraint::RadiusDiameterConstrType indicating the type of constraint to be created. |
| ObjectId valueDependencyId | Input object id of the value dependency object. |

#### Returns
Reference to RadiusDiameterConstraint* pointing the newly created RadiusDiameterConstraint object. Default value is NULL.
### AutoConstrain

#### Description
Defines constraints that can be added to an under-constrained model.
```text
public void AutoConstrain(
    FullSubentityPath\[\] paths, 
    Tolerance tol, 
    AutoConstrainEvaluationCallback callback
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath[] paths | List of subentites which are to be constrained automatically. |
| Tolerance tol | Tol to define distance tolerance as well as angle tolerance. [Tolerance.EqualPoint](Autodesk_AutoCAD_Geometry_Tolerance_EqualPoint.md)() defines distance tolerance and [Tolerance.EqualVector](Autodesk_AutoCAD_Geometry_Tolerance_EqualVector.md)() defines angle tolerance. Angle tolerance is in radians of angle. |
| AutoConstrainEvaluationCallback callback | Reference to autoconstraint evaluation callback. This callback will implement constraint priority and priority override. |

### ConstraintStatus

#### Description
Gets the evaluation status of the passed in constraint.
```text
public SolutionStatusType ConstraintStatus(
    GeometricalConstraint constraint
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GeometricalConstraint constraint | Input reference to GeometricalConstraint indicating the constraint object to be checked. |

#### Returns
SolutionStatus
### DeleteConstrainedGeometry

#### Description
Deletes an existing ConstrainedGeometry object which is internally held. This function also removes and erases the AssocGeomDependency object from this constraint group action.
```text
public void DeleteConstrainedGeometry(
    ObjectId geomDependencyId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId geomDependencyId | Input ObjectId of the AssocGeomDependency object. |

### DeleteConstraint

#### Description
Deletes an existing GeometricalConstraint object which is internally held.
```text
public void DeleteConstraint(
    GeometricalConstraint geomConst
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GeometricalConstraint geomConst | Input GeometricalConstraint indicating the constraint to be deleted. |

### GeometryMirrored

#### Description
Called by the client code to inform the constraint group that the dependent entity for _geomDependency_ has been mirrored. The constraint group then mirrors the implicit points for the constrained curve for the given geom dependency. For the majority of constrained curves it is just a no-op, but for some curves (such as for ConstrainedArc) the implicit points needs to be actually updated.
```text
public void GeometryMirrored(
    AssocGeomDependency geomDependency
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocGeomDependency geomDependency | Reference to AssocGeomDependency for which implicit point needs to be updated for mirror action. |

### GeometryStatus

#### Description
Gets the evaluation status of the passed in constrained geometry. Normally this method should only be called after an evaluation
```text
public SolutionStatusType GeometryStatus(
    ConstrainedGeometry consGeom
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ConstrainedGeometry consGeom | Input reference to ConstrainedGeometry indicating the constrained geometry object to be checked. |

#### Returns
SolutionStatus
### GetAllConnectedGeomDependencies

#### Description
Gets all AssocGeomDependency objects which are connected by constraints.
```text
public ObjectIdCollection GetAllConnectedGeomDependencies(
    ObjectIdCollection srcGeomDependencyIds
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdCollection srcGeomDependencyIds | Input ObjectIdArray indicating the source AssocGeomDependency objects. |

#### Returns
Output ObjectIdArray indicating the all the connected AssocGeomDependency objects. It contains all the source AssocGeomDependency objects.
### GetConstrainedGeometry(AssocGeomDependency)

#### Description
Gets the reference to the corresponding internally held ConstrainedGeometry. The reference returned might be temporary and the caller should not cache it for future use; instead the caller may cache the node id of ConstrainedGeometry.
```text
public ConstrainedGeometry GetConstrainedGeometry(
    AssocGeomDependency geomDependency
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocGeomDependency geomDependency | Input reference to AssocGeomDependency of the constrained entity. The AssocGeomDependency object maybe transient, in other words, not added into the database yet. |

#### Returns
Reference to ConstrainedGeometry. If the constrained geometry is not found, pConsGeom is set to NULL.
#### See Also
ConstraintGroupNode.NodeId

### GetConstrainedGeometry(AssocGeomDependency, Autodesk.AutoCAD.DatabaseServices.ImplicitPointType, int, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Gets the reference to the corresponding internally held ConstrainedGeometry. The reference returned might be temporary and the caller should not cache it for future use; instead the caller may cache the node id of ConstrainedGeometry.
```text
public ConstrainedGeometry GetConstrainedGeometry(
    AssocGeomDependency geomDependency, 
    Autodesk.AutoCAD.DatabaseServices.ImplicitPointType ptType, 
    int defPtIndex, 
    [MarshalAs(UnmanagedType.U1)] bool bCreateArcLineMid
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocGeomDependency geomDependency | Input reference to AssocGeomDependency of the constrained entity. The AssocGeomDependency object maybe transient, in other words, not added into the database yet. |
| Autodesk.AutoCAD.DatabaseServices.ImplicitPointType ptType | Input reference to ConstrainedImplicitPoint::ImplicitPointType indicating the implicit point type of a constrained curve. Only present when caller want to retrieve the ConstrainedImplicitPoint of a ConstrainedCurve. Default value is NULL. |
| int defPtIndex | Input integer index of define points of a parametric curve. Currently only control points of a spline are supported. It is only valid when the implicit point type is kDefineImplicit. Default value is -1(invalid index value). |
| createArcLineMid | Input Boolean indicating if create implicit midpoint of arc or line segment if it is not there. Default value is false. |

#### Returns
Reference to ConstrainedGeometry. If the constrained geometry is not found, pConsGeom is set to NULL.
#### See Also
ConstraintGroupNode.NodeId

### GetConstrainedGeometry(FullSubentityPath, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Gets the reference to the corresponding internally held ConstrainedGeometry. The reference returned might be temporary and the caller should not cache it for future use; instead the caller may cache the node id of ConstrainedGeometry.
```text
public ConstrainedGeometry GetConstrainedGeometry(
    FullSubentityPath subentPath, 
    [MarshalAs(UnmanagedType.U1)] bool createArcLineMid
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool createArcLineMid | Input Boolean indicating if create implicit midpoint of arc or line segment if it is not there. Default value is false. |
| fullSubentPath | Input FullSubentPath of the constrained entity, down to the subentity level. Only vertex or edge subentity type can be passed in. |

#### Returns
Reference to ConstrainedGeometry. If the constrained geometry is not found, pConsGeom is set to NULL.
#### See Also
ConstraintGroupNode.NodeId

### GetGroupNode

#### Description
Gets a reference to the ConstraintGroupNode object.
```text
public ConstraintGroupNode GetGroupNode(
    uint nodeId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| uint nodeId | Input ConstraintGroupNodeId indicating the node id. |

#### Returns
Returns reference to ConstraintGroupNode if successful, otherwise NULL
### GlobalCallback

#### Description
Returns a callback that is the collection of all callbacks registered by the client code. This function is meant mostly for private use and there should not be much need for the client code to use it. In any case, the client code must never delete or unregister the returned callback, or do anything with it except for calling its methods.
```text
public static Assoc2dConstraintCallback GlobalCallback();
```

#### Returns
The global Assoc2dConstraintCallback that keeps all the callbacks registered by the client code. The returned reference is never null.
### RegenDimensionSystem

#### Description
Regenerates the internal dimension system. For internal use only.
```text
public void RegenDimensionSystem();
```

#### Returns
Returns void
### RemoveGlobalCallback

#### Description
See the explanation for [Assoc2dConstraintCallback](Autodesk_AutoCAD_DatabaseServices_Assoc2dConstraintCallback.md "Assoc2dConstraintCallback Class"). Multiple global callbacks can be registered and they apply to all Assoc2dConstraintGroup.
```text
public static void RemoveGlobalCallback(
    Assoc2dConstraintCallback callback
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Assoc2dConstraintCallback callback | The callback to be unregistered. |

### SolutionStatus

#### Description
Gets the solution evaluation status of this constraint group. Normally this method should only be called after an evaluation
```text
public SolutionStatusType SolutionStatus(
    [MarshalAs(UnmanagedType.U1)] bool alsoCheckForConstraints
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool alsoCheckForConstraints | Input boolean indicating if need to check constraints. Default value is true. |

#### Returns
SolutionStatusType
### TransformActionBy

#### Description
Transforms the work plane of the constraint group by the rigid motion component of the transformation matrix. If the transformation matrix also contains a uniform scaling factor, it removes all ExplicitConstraint nodes. If the transformation matrix contains a general component, it removes all GeometricalConstraint nodes.
```text
public void TransformActionBy(
    Matrix3d transform
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Matrix3d transform | The given transformation matrix. |

### AutoCAD.DatabaseServices.Assoc2dConstraintGroup.SolutionStatusType Enumeration

#### Description
The solution status of this constraint group.
```text
public enum SolutionStatusType {
  WellDefined,
  UnderConstrained,
  OverConstrained,
  Inconsistent,
  NotEvaluated,
  NotAvailable,
  RejectedByClient
}
```

#### Members

| Members | Description |
| --- | --- |
| WellDefined | All constrained geometries are fully constrained. The degree of freedom of the entire model is 0. |
| UnderConstrained | Some or all constrained geometries are under constrained. The degree of freedom of the entire model is larger than 0. |
| OverConstrained | Some or all constrained geometries are over constrained. Normally this is because duplicate or redundant constraints are added. |
| Inconsistent | Some or all constrained geometries/constraints are inconsistent. Normally this is because invalid constraints are added. For example, two lines are made both parallel and perpendicular. |
| NotEvaluated | Some or all constrained geometries/constraints are not evaluated. Normally this means new constrained geometries or constraints were added since last evaluation. |
| NotAvailable | Not able to get the solution status. Normally this means fatal errors. |
| RejectedByClient | Evaluation produced result that may be considered valid by DCM but is rejected by the client code, such as when degenerate geometry was created and the client code does not want to accept it. |


## Properties Details

### ConstrainedGeometries

#### Description
Gets all ConstrainedGeometry objects in this constraint group, including ConstraintImplicitPoint objects which are associated with corresponding ConstrainedCurve objects.
```text
public ConstrainedGeometry ConstrainedGeometries;
```

#### Conditions
Read-only
### Constraints

#### Description
Gets all GeometricalConstraint objects in this constraint group, including topological and dimensional constraints
```text
public GeometricalConstraint Constraints;
```

#### Conditions
Read-only
### GetDOF

#### Description
Gets the remaining DOF (Degree of Freedom) of this constraint group. It includes the positional DOF of a well-defined model.
```text
public int GetDOF;
```

#### Conditions
Read-only
### WorkPlane

#### Description
This is WorkPlane, a member of class Assoc2dConstraintGroup.
```text
public Plane WorkPlane;
```
