# Autodesk.AutoCAD.DatabaseServices.AssocEvaluationPriority Enumeration

## Overview

#### Description
Negative numbers mean that an AssocAction cannot be evaluated at this time, positive numbers mean that the action can now be evaluated. Higher positive priority numbers mean that the action should be evaluated sooner, ahead of actions with lower positive priority. The negative numbers mean how much the action cannot be evaluated. The smaller the number, the less the action can be evaluated.
```text
public enum AssocEvaluationPriority {
  CanBeEvaluatedAssocEvaluationPriority = 0x3e8,
  CannotBeEvaluatedAssocEvaluationPriority = -1000,
  CannotDermineAssocEvaluationPriority = 0
}
```

#### Members
| Members | Description |
| --- | --- |
| CanBeEvaluatedAssocEvaluationPriority = 0x3e8 |
| CannotBeEvaluatedAssocEvaluationPriority = -1000 |
| CannotDermineAssocEvaluationPriority = 0 |