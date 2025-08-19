# Assoc2dConstraintCallback Class

## Overview

#### Description
Client code can register callbacks derived from Assoc2dConstraintCallback that are then called when some events happen with Assoc2dConstraintGroup.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Assoc2dConstraintCallback
```

```text
public class Assoc2dConstraintCallback : IDisposable;
```

### Constructors

- [Assoc2dConstraintCallback](#assoc2dconstraintcallback)

### Methods

- [CanBeRelaxed](#canberelaxed)
- [ConstraintDeactivated](#constraintdeactivated)


## Constructors Details

### Assoc2dConstraintCallback

#### Description
Default constructor.
```text
public Assoc2dConstraintCallback();
```

### CanBeRelaxed

#### Description
Allows client code to veto erasing a dimension constraint when a dimension constraint is not satisfied and is being erased during a relax evaluation of a 2D constraint group. 
If this method returns true then this dimension constraint is converted to a reference dimension; the client needs to update the variable value with it's measured value.
```text
public virtual bool CanBeRelaxed(
    ExplicitConstraint constraint
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ExplicitConstraint constraint | The dimension constraint that is to be erased. |

#### Returns
true if the client code allows the constraint to be converted to the reference or driven constraint; false if the client code allows the constraint to be erased.
### ConstraintDeactivated

#### Description
This function will be called when a constraint is deactivated or reactivated. This notification takes place when ExplicitConstraint.deactivate() or ExplicitConstraint.reactivate() is invoked.
```text
public virtual void ConstraintDeactivated(
    ExplicitConstraint constraint, 
    [MarshalAs(UnmanagedType.U1)] bool deactivated
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ExplicitConstraint constraint | The constraint that is to be activated or deactivated. |
| [MarshalAs(UnmanagedType.U1)] bool deactivated | Whether to deactivate or reactivate the constraint |
