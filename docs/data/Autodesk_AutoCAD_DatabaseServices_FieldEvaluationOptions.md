# Autodesk.AutoCAD.DatabaseServices.FieldEvaluationOptions Enumeration

## Overview

#### Description
This .NET enum wraps the AcDbField::EvalOption ObjectARX enum. These values specify the evaluation option for the field.
```text
public enum FieldEvaluationOptions {
  Automatic = 0x3f,
  Disable = 0,
  OnDemand = 0x20,
  OnEtransmit = 8,
  OnOpen = 1,
  OnPlot = 4,
  OnRegen = 0x10,
  OnSave = 2
}
```

#### Members

| Members | Description |
| --- | --- |
| Automatic = 0x3f | Automatically evaluate fields during all the operations. |
| Disable = 0 | Disable evaluation. |
| OnDemand = 0x20 | Evaluate only on demand by the user or the API. |
| OnEtransmit = 8 | Evaluate only on demand by the user or the API. |
| OnOpen = 1 | Evaluate during drawing load. |
| OnPlot = 4 | Evaluate during drawing plot. |
| OnRegen = 0x10 | Evaluate during regen. |
| OnSave = 2 | Evaluate during drawing save. |