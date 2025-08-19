# AssocGlobalUtility Class

## Overview

#### Description
A Utility class to wrap all global utility methods
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocGlobalUtility
```

```text
public sealed class AssocGlobalUtility;
```

### Methods

- [EvaluationRequestSeverityLevel](#evaluationrequestseveritylevel)
- [IsDraggingProvidingSubstituteObjects](#isdraggingprovidingsubstituteobjects)
- [IsEvaluationRequest](#isevaluationrequest)
- [IsToBeSkipped](#istobeskipped)


## Methods Details

### EvaluationRequestSeverityLevel

#### Description
Returns the severity level (positive integer) of those status values that indicate a request for an AssocAction or an AssocDependency to be evaluated, or 0 if the status does not indicate an evaluation request. Higher numbers mean more "severe" requests to evaluate.
```text
public static int EvaluationRequestSeverityLevel(
    AssocStatus status
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocStatus status | The AssocStatus. |

#### Returns
Evaluation request severity level (positive integer) if or 0 if not a request to evaluate.
### IsDraggingProvidingSubstituteObjects

#### Description
Returns true if in the middle of dragging and the AssocDraggingState indicates that the dragger is providing substitute non-database resident objects that are clones of the original database-resident objects.
```text
public static bool IsDraggingProvidingSubstituteObjects(
    AssocEvaluationCallback evaluationCallback
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocEvaluationCallback evaluationCallback | The current AssocEvaluationCallback. NULL pointer is allowed. |

### IsEvaluationRequest

#### Description
Returns true for the AssocStatus values that are a request for an AssocAction or AssocDependency to be evaluated, and false for other AssocStatus values.
```text
public static bool IsEvaluationRequest(
    AssocStatus status
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocStatus status | The AssocStatus. |

#### Returns
Returns true if the value of the AssocStatus indicates that an AssocAction or AssocDependency needs to be evaluated.
### IsToBeSkipped

#### Description
Returns true if the AssocStatus indicates that the action or dependency should be skipped and treated as if it were not there.
```text
public static bool IsToBeSkipped(
    AssocStatus status
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocStatus status | The AssocStatus. |

#### Returns
Returns true if the AssocStatus indicates that the action or dependency should be skipped and treated as if it were not there.