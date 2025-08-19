# Autodesk.AutoCAD.DatabaseServices.AssocStatus Enumeration

## Overview

#### Description
The status of AssocActions and AssocDependencies. In case of an action it relates to the action itself, in case of a dependency it relates to the object the dependency depends on.
```text
public enum AssocStatus {
  IsUpToDateAssocStatus,
  ChangedDirectlyAssocStatus,
  ChangedTransitivelyAssocStatus,
  ChangedNoDifferenceAssocStatus,
  FailedToEvaluateAssocStatus,
  ErasedAssocStatus,
  SuppressedAssocStatus
}
```

#### Members
| Members | Description |
| --- | --- |
| IsUpToDateAssocStatus | Everything is in sync. |
| ChangedDirectlyAssocStatus | Explicitly changed (such as by the user). |
| ChangedTransitivelyAssocStatus | Changed indirectly due to something else changed. |
| ChangedNoDifferenceAssocStatus | No real change, only forces to evaluate. |
| FailedToEvaluateAssocStatus |
| ErasedAssocStatus | Dependent-on object erased or action is to be erased. |
| SuppressedAssocStatus | Action evaluation suppressed, treated as if evaluated. |