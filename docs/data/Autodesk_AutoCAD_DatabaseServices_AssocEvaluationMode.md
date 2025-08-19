# Autodesk.AutoCAD.DatabaseServices.AssocEvaluationMode Enumeration

## Overview

#### Description
At the beginning of AssocActionBody.EvaluateOverride() implementation, the custom code needs to query the mode in which it should evaluate itself.
```text
public enum AssocEvaluationMode {
  ModifyObjectsAssocEvaluationMode,
  ModifyActionAssocEvaluationMode
}
```

#### Members

| Members | Description |
| --- | --- |
| ModifyObjectsAssocEvaluationMode | The standard action evaluation mode in which the objects the action depends-on via write-dependencies are modified so that they satisfy the requirements imposed on them by the action.If this cannot be achieved, the action needs to report an error and set its status to FailedToEvaluateAssocStatus or possibly to ErasedAssocStatus (if it wants itself to be erased.) |
| ModifyActionAssocEvaluationMode | The action evaluation mode in which the action is modified so that it satisfies the objects the action depends on. The objects are not modified, the internal data in the action or its dependencies are. An example is an Assoc2dConstraintGroup action that may remove the constraints that are not satisfied by the current geometry configuration.If this cannot be achieved, the action needs to report an error and set its status to FailedToEvaluateAssocStatus or possibly to ErasedAssocStatus (if it wants itself to be erased.) |