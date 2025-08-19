# Autodesk.AutoCAD.DatabaseServices.FieldState Enumeration

## Overview

#### Description
This .NET enum wraps the AcDbField::State ObjectARX enum. These values specify the state of the field.
```text
public enum FieldState {
  Compiled = 2,
  Evaluated = 8,
  HasCache = 0x10,
  HasFormattedString = 0x20,
  Initialized = 1,
  Modified = 4
}
```

#### Members

| Members | Description |
| --- | --- |
| Compiled = 2 | Field has been compiled. |
| Evaluated = 8 | Field has been evaluated. Use Field.EvaluationStatus to get the evaluation status. |
| HasCache = 0x10 | The field has a cache of the evaluated result. |
| HasFormattedString = 0x20 | The field has a properly formatted string. |
| Initialized = 1 | Field is not yet initialized with any field code or data. |
| Modified = 4 | Field has been modified and not yet evaluated. |