# GeometricalConstraint Class

## Overview

#### Description
This class represents a constraint node in the owning Assoc2dConstraintGroup. 
It is the base class for all kinds of constraints, including geometrical and dimensional constraints.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint
        Autodesk.AutoCAD.DatabaseServices.ColinearConstraint
        Autodesk.AutoCAD.DatabaseServices.CompositeConstraint
        Autodesk.AutoCAD.DatabaseServices.ConcentricConstraint
        Autodesk.AutoCAD.DatabaseServices.EqualCurvatureConstraint
        Autodesk.AutoCAD.DatabaseServices.EqualDistanceConstraint
        Autodesk.AutoCAD.DatabaseServices.EqualHelpParameterConstraint
        Autodesk.AutoCAD.DatabaseServices.EqualLengthConstraint
        Autodesk.AutoCAD.DatabaseServices.EqualRadiusConstraint
        Autodesk.AutoCAD.DatabaseServices.ExplicitConstraint
        Autodesk.AutoCAD.DatabaseServices.FixedConstraint
        Autodesk.AutoCAD.DatabaseServices.MidPointConstraint
        Autodesk.AutoCAD.DatabaseServices.NormalConstraint
        Autodesk.AutoCAD.DatabaseServices.ParallelConstraint
        Autodesk.AutoCAD.DatabaseServices.PerpendicularConstraint
        Autodesk.AutoCAD.DatabaseServices.PointCoincidenceConstraint
        Autodesk.AutoCAD.DatabaseServices.PointCurveConstraint
        Autodesk.AutoCAD.DatabaseServices.SymmetricConstraint
        Autodesk.AutoCAD.DatabaseServices.TangentConstraint
```

```text
public class GeometricalConstraint : ConstraintGroupNode;
```

### Methods

- [Deactivate](#deactivate)
- [GetConnectedHelpParameterFor](#getconnectedhelpparameterfor)
- [Reactivate](#reactivate)

### Other

- [AutoCAD.DatabaseServices.GeometricalConstraint.ConstraintType Enumeration](#autocad.databaseservices.geometricalconstraint.constrainttype-enumeration)

### Properties

- [ConnectedGeometries](#connectedgeometries)
- [ConnectedHelpParameters](#connectedhelpparameters)
- [IsActive](#isactive)
- [IsEnabled](#isenabled)
- [IsImplied](#isimplied)
- [IsInternal](#isinternal)
- [OwningCompositeConstraint](#owningcompositeconstraint)


## Methods Details

### Deactivate

#### Description
Leaves the GeometricalConstraint node in the Assoc2dConstraintGroup but removes it from the DCM dimension system. 
Currently only implemented for ExplicitConstraint because we need to temporarily deactivate them during grip-point editing of dimensional constraint attachment grips.
```text
public void Deactivate();
```

### GetConnectedHelpParameterFor

#### Description
Returns reference to HelpParameter which this constraint and the specified constrained geometry both are connected to. 
A HelpParameter object is always connected with a GeometricalConstraint object and a ConstrainedGeometry object.
```text
public virtual HelpParameter GetConnectedHelpParameterFor(
    ConstrainedGeometry consGeom
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ConstrainedGeometry consGeom | The reference to ConstrainedGeometry object. |

#### Returns
Returns reference to the connected HelpParameter object if successful, otherwise NULL is returned.
### Reactivate

#### Description
Takes an inactive GeometricalConstraint and adds it to the DCM dimension system. 
Currently only implemented for ExplicitConstraint because we need to temporarily deactivate them during grip-point editing of dimensional constraint attachment grips.
```text
public void Reactivate();
```

### AutoCAD.DatabaseServices.GeometricalConstraint.ConstraintType Enumeration

#### Description
The type of a geometrical constraint. It is mainly used to indicate the new constraint type to be added between geometries.
```text
public enum ConstraintType {
  Horizontal,
  Vertical,
  Parallel,
  Perpendicular,
  Normal,
  Collinear,
  Coincident,
  Concentric,
  Tangent,
  EqualRadius,
  EqualLength,
  Symmetric,
  Smooth,
  Fix
}
```

#### Members
| Members | Description |
| --- | --- |
| Horizontal | Horizontal constraint. Can be applied to a line or two points. |
| Vertical | Vertical constraint. Can be applied to a line or two points. |
| Parallel | Parallel constraint. Can be applied between two lines. |
| Perpendicular | Perpendicular constraint. Can be applied between two lines. |
| Normal | Normal constraint. Currently can only be applied between a line and circle(or arc). |
| Collinear | Colinear constraint. Can be applied between two lines. |
| Coincident | Coincident constraint. Can be applied between two points, a point and a curve. |
| Concentric | Concentric constraint. Can be applied between any two of circles, ellipses, arcs or bounded ellipses. |
| Tangent | Tangent constraint. Can be applied between two of curves (except two lines). This constraint is not applicable for closed splines; for bounded splines, the tangent point can only be the start or end point which is coincident with start or end point of the other bounded curve. |
| EqualRadius | EqualRadius constraint. Can be applied between any two of circles or arcs. |
| EqualLength | EqualLength constraint. Can be applied between two bounded lines (not rays). |
| Symmetric | Symmetric constraint. Can be applied between two same type geometries. circle and arc are considered to be the same type of geometry. The symmetry axis is a line. |
| Smooth | G2Smooth constraint. Can be applied between a bounded spline and a bounded curve (including spline). |
| Fix | Fix constraint. Can be applied on any supported geometry. |


## Properties Details

### ConnectedGeometries

#### Description
Gets the array of references to ConstrainedGeometry objects which this constraint is connected to.
```text
public virtual ConstrainedGeometry ConnectedGeometries;
```

#### Conditions
Read-only
### ConnectedHelpParameters

#### Description
Gets the array of references to HelpParameter objects which this constraint is connected to. 
The number of the HelpParameter object is the same as the number of geometries involved in this constraint. 
Only a few kinds of constraints may have help parameters, which are only applicable for splines and ellipses. For example, in case of Tangent constraint, a help parameter may be used to indicate the tangent point on a spline or ellipse.
```text
public virtual HelpParameter ConnectedHelpParameters;
```

#### Conditions
Read-only
### IsActive

#### Description
Indicates whether the GeometricalConstraint is in DCM dimension system.
```text
public bool IsActive;
```

#### Conditions
Read-only
### IsEnabled

#### Description
Indicates whether the constraint is enabled
```text
public bool IsEnabled;
```

#### Conditions
Read-only
### IsImplied

#### Description
Indicates whether the GeometricalConstraint is implied. 
This flag "implied" means the constraints are applied by the framework for implied geometric conditions, such as end point constraints for bounded curve. In polyline, if any geometric constrains are applied to the segment(s), there would be a few implied point-point or point-curve constraints added by the framework; these are implied constraints and the constraint UI (constraint bar/icon) should not show these constraints.
```text
public bool IsImplied;
```

#### Conditions
Read-only
### IsInternal

#### Description
Indicates whether the constraint is implied or is part of a composite constraint. 
Internal constraints should not be directly dealt with at client-code level.
```text
public bool IsInternal;
```

#### Conditions
Read-only
### OwningCompositeConstraint

#### Description
Gets the reference to the owning CompositeConstraint object if this constraint is owned by a composite constraint.
```text
public CompositeConstraint OwningCompositeConstraint;
```

#### Conditions
Read-only