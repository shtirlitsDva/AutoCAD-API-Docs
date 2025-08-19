# ExplicitConstraint Class

## Overview

#### Description
This class represents a dimensional constraint node in the owning Assoc2dConstraintGroup. 
It is the base class for all the kind of dimensional constraints.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint
        Autodesk.AutoCAD.DatabaseServices.ExplicitConstraint
            Autodesk.AutoCAD.DatabaseServices.AngularConstraint
            Autodesk.AutoCAD.DatabaseServices.DistanceConstraint
            Autodesk.AutoCAD.DatabaseServices.RadiusDiameterConstraint
```

```text
public class ExplicitConstraint : GeometricalConstraint;
```

### Properties

- [DimDependencyId](#dimdependencyid)
- [MeasuredValue](#measuredvalue)
- [ValueDependencyId](#valuedependencyid)


## Properties Details

### DimDependencyId

#### Description
Gets and sets the ObjectId of the dimension dependency object referenced by this dimensional constraint. 
```text
public ObjectId DimDependencyId;
```

#### Conditions
Read / write
### MeasuredValue

#### Description
Gets the value of the dimensional constraint measured from the distances/angles/radii of the constrained geometries. 
If the constraint is satisfied, it is the same value as the dimension value obtained from the AssocVariable.
```text
public double MeasuredValue;
```

#### Conditions
Read-only
### ValueDependencyId

#### Description
Gets the ObjectId of the AssocValueDependency object referenced by this dimensional constraint.
```text
public ObjectId ValueDependencyId;
```

#### Conditions
Read-only