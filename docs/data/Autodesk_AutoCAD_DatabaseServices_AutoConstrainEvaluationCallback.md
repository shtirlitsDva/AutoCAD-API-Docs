# AutoConstrainEvaluationCallback Class

## Overview

#### Description
Client needs to implement this callback to provide constraint priorities and priority override for autconstraint evaluation.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AutoConstrainEvaluationCallback
```

```text
public class AutoConstrainEvaluationCallback : IDisposable;
```

### Constructors

- [AutoConstrainEvaluationCallback](#autoconstrainevaluationcallback)

### Methods

- [GetAutoConstrainPriority](#getautoconstrainpriority)
- [GetConstraintPriorityOverride](#getconstraintpriorityoverride)
- [GetTotalConstraints](#gettotalconstraints)

### Properties

- [IsEvaluationCancelled](#isevaluationcancelled)


## Constructors Details

### AutoConstrainEvaluationCallback

#### Description
Constructor.
```text
protected internal unsafe AutoConstrainEvaluationCallback(
    AcAutoConstrainEvaluationCallback* impObj, 
    [MarshalAs(UnmanagedType.U1)] bool autoDelete
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AcAutoConstrainEvaluationCallback* impObj | Unmanaged C++ object pointer |

### GetAutoConstrainPriority

#### Description
Defines the order in which constraint types can be used for autoConstrain.
```text
public virtual GeometricalConstraint.ConstraintType\[\] GetAutoConstrainPriority();
```

#### Parameters

| Parameters | Description |
| --- | --- |
| constraintList | List of constraint types to be considered for autoConstrain in decending order of priority. Constraint type not present in the list will not be considered for autoconstraint. |

### GetConstraintPriorityOverride

#### Description
This function will be called when the system finds a possible constraint between a given set of constrained geometries. This function expects to get an override to increase, decrease or maintain the priority for the given constraint condition.
```text
public virtual int GetConstraintPriorityOverride(
    GeometricalConstraint.ConstraintType type, 
    ConstrainedGeometry\[\] geometries
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GeometricalConstraint.ConstraintType type | Geometric constraint type that is possible between given set of constrained geometry. |
| ConstrainedGeometry[] geometries | List of constrained geometry, which are potential candidate for provided constraint type. User may |

#### Returns
Priority for the given constraint. Applications may modify it by increasing or decreasing the priority; a negative value means the constraint should not be applied between the given geometries. Higher value of priority means this constraint will be given preference over other possible constraints and will be applied earlier.
### GetTotalConstraints

#### Description
Returns a list of constraints found by autoconstraint evaluation.
```text
public int GetTotalConstraints(
    ref GeometricalConstraint\[\] constraints
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ref GeometricalConstraint[] constraints | reference to array of constraints, to return list of constraints found by autoconstraint evaluation. This parameter can be null if caller doesn't want list of constraints. |

#### Returns
Number of constraints found by autoconstraint evaluation.
### IsEvaluationCancelled

#### Description
Indicates whether the evaluation was canceled by the caller. 
If this function returns true the autoconstraint evaluation from DCM will be cancelled.
```text
public virtual bool IsEvaluationCancelled;
```

#### Conditions
Read-only