# EqualHelpParameterConstraint Class

## Overview

#### Description
This class represents a EqualHelpParameter constraint node in the owning Assoc2dConstraintGroup. 
It can be applied between two [HelpParameter](Autodesk_AutoCAD_DatabaseServices_HelpParameter.md "HelpParameter Class") objects which belong to the same spline or ellipse.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint
        Autodesk.AutoCAD.DatabaseServices.EqualHelpParameterConstraint
```

```text
public class EqualHelpParameterConstraint : GeometricalConstraint;
```

### Constructors

- [EqualHelpParameterConstraint](#equalhelpparameterconstraint)

### Methods

- [GetEqualHelpParameters](#getequalhelpparameters)


## Constructors Details

### EqualHelpParameterConstraint

#### Description
Default constructor.
```text
public EqualHelpParameterConstraint();
```

### GetEqualHelpParameters

#### Description
Returns pointers to the two HelpParameter objects which this constraint is connected to.
```text
public void GetEqualHelpParameters(
    ref HelpParameter helpParameter1, 
    ref HelpParameter helpParameter2
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| pHelpParameter1 | The returned pointer to the first AcHelpParameter object. |
| pHelpParameter2 | The returned pointer to the second AcHelpParameter object. |

#### Returns
Returns Acad::eOk if successful.