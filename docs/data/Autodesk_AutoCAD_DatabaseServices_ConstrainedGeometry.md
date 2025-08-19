# ConstrainedGeometry Class

## Overview

#### Description
This class represents a constrained geometry node in the owning Assoc2dConstraintGroup. 
It is the base class for all the kind of supported geometries.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedCurve
        Autodesk.AutoCAD.DatabaseServices.ConstrainedPoint
        Autodesk.AutoCAD.DatabaseServices.ConstrainedRigidSet
```

```text
public class ConstrainedGeometry : ConstraintGroupNode;
```

### Methods

- [CommonConstraints](#commonconstraints)

### Properties

- [ConnectedConstraints](#connectedconstraints)
- [ConnectedGeometries](#connectedgeometries)
- [FullSubentityPaths](#fullsubentitypaths)
- [GeomDependencyId](#geomdependencyid)
- [IsReadOnly](#isreadonly)
- [OwningRigidSet](#owningrigidset)


## Methods Details

### CommonConstraints

#### Description
Returns the array of references to GeometricalConstraint objects between this constrained geometry and the other constrained geometry otherConsGeom.
```text
public GeometricalConstraint\[\] CommonConstraints(
    ConstrainedGeometry otherConsGeom
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ConstrainedGeometry otherConsGeom | The reference to the other ConstrainedGeometry object. |

#### Returns
The returned array of reference to GeometricalConstraint objects.
### ConnectedConstraints

#### Description
Gets the the array of references to GeometricalConstraint objects which reference this constrained geometry. For a bounded line, arc or bounded ellipse, the array also contains the Coincident constraints between its implicit points and this constrained geometry.
```text
public GeometricalConstraint ConnectedConstraints;
```

#### Conditions
Read-only
### ConnectedGeometries

#### Description
Gets the array of references to ConstrainedGeometry objects to which this constrained geometry is indirectly connected through the common constraints.
```text
public ConstrainedGeometry ConnectedGeometries;
```

#### Conditions
Read-only
### FullSubentityPaths

#### Description
Gets the array of FullSubentPaths of the subentities of the AutoCAD Entities that correspond to this constrained geometry. 
Notice that the output argument is an array, because there may be more than one subentity corresponding to the ConstrainedGeometry, but in the great majority of cases there will be exactly one subentity.
```text
public FullSubentityPath FullSubentityPaths;
```

#### Conditions
Read-only
### GeomDependencyId

#### Description
Gets the ObjectId of the AssocGeomDependency object referenced by this constrained geometry. 
It maybe Null for some kind of constrained geometry.
Class
Read-only
```text
public ObjectId GeomDependencyId;
```

### IsReadOnly

#### Description
Indicates whether this constrained geometry is read-only -- cannot be modified or transformed, in other words, it is fixed.
```text
public virtual bool IsReadOnly;
```

#### Conditions
Read-only
### OwningRigidSet

#### Description
Gets the reference to the owning ConstrainedRigidSet object which this constrained geometry belongs to. 
One constrained geometry can only stay in one rigid set. If this geometry is not in a rigid set, NULL is returned.
```text
public ConstrainedRigidSet OwningRigidSet;
```

#### Conditions
Read-only