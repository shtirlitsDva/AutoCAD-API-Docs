# HelpParameter Class

## Overview

#### Description
This class represents a help parameter node in the owning Assoc2dConstraintGroup. 
Help parameters are only applicable for splines and ellipses and are required for some kind of constraints. 
A HelpParameter object is always connected with a GeometricalConstraint object and a ConstrainedGeometry object.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.HelpParameter
```

```text
public class HelpParameter : ConstraintGroupNode;
```

### Constructors

- [HelpParameter](#helpparameter)

### Properties

- [ConnectedConstraint](#connectedconstraint)
- [ConnectedEqualparamConstraints](#connectedequalparamconstraints)
- [ConnectedGeometry](#connectedgeometry)
- [Value](#value)


## Constructors Details

### HelpParameter

#### Description
Default constructor.
```text
public HelpParameter();
```

### ConnectedConstraint

#### Description
Gets the reference to the GeometricalConstraint which this help parameter is connected to. 
This property does not take in account equal parameter constraints applied on this help parameter
```text
public GeometricalConstraint ConnectedConstraint;
```

#### Conditions
Read-only
### ConnectedEqualparamConstraints

#### Description
Gets the array of references to EqualHelpParameterConstraint objects which this constraint is connected to. 
If this help parameter is not involved in any equal help parameter constraint, the array returned is empty.
```text
public EqualHelpParameterConstraint ConnectedEqualparamConstraints;
```

#### Conditions
Read-only
### ConnectedGeometry

#### Description
Gets the reference to the ConstrainedGeometry which this help parameter is connected to.
```text
public ConstrainedGeometry ConnectedGeometry;
```

#### Conditions
Read-only
### Value

#### Description
Gets the value of this help parameter; the value is always larger than or equal to 0.0
```text
public double Value;
```

#### Conditions
Read-only