# AssocVariableCallback Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocVariableCallback](AcDbAssocVariableCallback.md) class. 
Client code can register callback(s) derived from AssocVariableCallback that are then called when some events happen with AssocVariables.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocVariableCallback
```

```text
public abstract class AssocVariableCallback : IDisposable;
```

### Constructors

- [AssocVariableCallback](#assocvariablecallback)

### Methods

- [CanBeErased](#canbeerased)
- [ValidateNameAndExpression](#validatenameandexpression)


## Constructors Details

### AssocVariableCallback

#### Description
Default constructor
```text
public AssocVariableCallback();
```

### CanBeErased

#### Description
Allows client code to veto erasing a variable when the variable would be erased because the dimensional constraint that uses the variable is erased and the variable is no more referenced.
```text
public abstract bool CanBeErased(
    AssocVariable variable
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocVariable variable | The AcDbAssocVariable that is to be erased. |

#### Returns
true if client code allows the variable to be erased; false if client code vetoes the variable erase.
### ValidateNameAndExpression

#### Description
Called from [AssocVariable.ValidateNameAndExpression](Autodesk_AutoCAD_DatabaseServices_AssocVariable_ValidateNameAndExpression@string@string@string.md)(). It lets the client code perform additional checks to decide if a given name and/or expression can be used as a name and/or expression for the given variable.
```text
public abstract string ValidateNameAndExpression(
    AssocVariable variable, 
    string nameToValidate, 
    string expressionToValidate
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocVariable variable | The variable whose name and/or expression are being validated. |
| string nameToValidate | The variable name to validate. May be null. |
| string expressionToValidate | The variable expression to validate. May be null. |

#### Returns
Error string if the name or expression is not valid, empty otherwise.