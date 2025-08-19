# FieldEvaluationStatusResult Structure

## Overview

#### Description
This class is used to return the codes that describe the results of a field evaluation. These results are the equivalent of the three values returned by the Field.evaluationStatus() ObjectARX function.
```text
public struct FieldEvaluationStatusResult {
}
```

### Constructors

- [FieldEvaluationStatusResult](#fieldevaluationstatusresult)

### Properties

- [ErrorCode](#errorcode)
- [ErrorMessage](#errormessage)
- [Status](#status)


## Constructors Details

### FieldEvaluationStatusResult

#### Description
For internal use only.
```text
public FieldEvaluationStatusResult(
    FieldEvaluationStatus s, 
    int e, 
    string m
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| FieldEvaluationStatus s | _nt_ |
| int e | _nt_ |
| string m | _nt_ |

### ErrorCode

#### Description
Accesses the ErrorCode property value.
```text
public int ErrorCode;
```

#### Conditions
Read-only
### ErrorMessage

#### Description
Accesses the ErrorMessage property value.
```text
public string ErrorMessage;
```

#### Conditions
Read-only
### Status

#### Description
Accesses the Status property value.
```text
public FieldEvaluationStatus Status;
```

#### Conditions
Read / Write