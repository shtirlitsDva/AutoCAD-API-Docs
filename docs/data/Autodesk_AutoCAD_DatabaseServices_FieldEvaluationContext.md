# Autodesk.AutoCAD.DatabaseServices.FieldEvaluationContext Enumeration

## Overview

#### Description
This .NET enum wraps the AcDbField::EvalContext ObjectARX enum. These values specify the context in which the field is evaluated.
```text
public enum FieldEvaluationContext {
  Demand = 0x20,
  Etransmit = 8,
  Open = 1,
  Plot = 4,
  Preview = 0x40,
  Regen = 0x10,
  Save = 2
}
```

#### Members

| Members | Description |
| --- | --- |
| Demand = 0x20 | Evaluated upon manual demand by the user. |
| Etransmit = 8 | Evaluated during eTransmit. |
| Open = 1 | Evaluated during drawing open. |
| Plot = 4 | Evaluated during drawing plot. |
| Preview = 0x40 | Evaluated for preview. If the context is Preview, the field is always evaluated regardless of the evaluation option setting in the database. |
| Regen = 0x10 | Evaluated during drawing regeneration. |
| Save = 2 | Evaluated during drawing save. |