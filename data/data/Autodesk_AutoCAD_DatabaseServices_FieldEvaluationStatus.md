# Autodesk.AutoCAD.DatabaseServices.FieldEvaluationStatus Enumeration

## Overview

#### Description
This .NET enum wraps the AcDbField::EvalStatus ObjectARX enum. These values specify the evaluation status of the field.
```text
public enum FieldEvaluationStatus {
  EvaluatorNotFound = 4,
  InvalidCode = 0x10,
  InvalidContext = 0x20,
  NotYetEvaluated = 1,
  OtherError = 0x40,
  Success = 2,
  SyntaxError = 8
}
```

#### Members
| Members | Description |
| --- | --- |
| EvaluatorNotFound = 4 | Evaluator was not found. |
| InvalidCode = 0x10 | Invalid field code or expression. |
| InvalidContext = 0x20 | Current context is invalid for evaluating the field. |
| NotYetEvaluated = 1 | Field is not yet evaluated. |
| OtherError = 0x40 | Evaluation has failed. |
| Success = 2 | Field is evaluated successfully. |
| SyntaxError = 8 | Syntax error in the field expression. |