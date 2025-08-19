# AssocVariable Class

## Overview

#### Description
AssocVariable keeps a name, value and expression. The name is an arbitrary non-empty string but the client code sets rules that define valid variable names. 
The expression is optional and is in the form of a string. An evaluator id needs to be provided with each espression. It specifies which expression evaluator should be used to parse the expression. The expression can reference other objects that provide values, such as it can reference other variables. The AssocVariable then owns AssocValueDependencies on these referenced objects. If the expression string is empty, or if the expression string does not reference other objects, the variable is a constant. 
The variable value is a scalar value such as a double, int, point, or a string. Currently only these four value types are supported. 
AssocVariable exposes AssocVariableValueProviderPE protocol extension that is used by other variables and generally by other actions that own AssocValueDependencies to obtain the value of the variable. 
The Evaluate() method of the variable evaluates the expression using the current values of the referenced symbols and sets the evaluated value.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocAction
        Autodesk.AutoCAD.DatabaseServices.AssocVariable
```

```text
public class AssocVariable : AssocAction;
```

### Constructors

- [AssocVariable](#assocvariable)

### Methods

- [AddGlobalCallback](#addglobalcallback)
- [EvaluateExpression(ObjectIdCollection, ResultBuffer[], ResultBuffer)](#evaluateexpression(objectidcollection,-resultbuffer[],-resultbuffer))
- [EvaluateExpression(ResultBuffer)](#evaluateexpression(resultbuffer))
- [FindObjectByName](#findobjectbyname)
- [globalCallback](#globalcallback)
- [RemoveGlobalCallback](#removeglobalcallback)
- [SetName](#setname)
- [ValidateNameAndExpression](#validatenameandexpression)

### Properties

- [Description](#description)
- [EvaluatorId](#evaluatorid)
- [Expression](#expression)
- [Name](#name)
- [Value](#value)


## Constructors Details

### AssocVariable

#### Description
Default constructor.
```text
public AssocVariable();
```

### AddGlobalCallback

#### Description
See the explanation of [AssocVariableCallback](Autodesk_AutoCAD_DatabaseServices_AssocVariableCallback.md "AssocVariableCallback Class"). Multiple global callbacks can be registered and they apply to all AssocVariables.
```text
public static void AddGlobalCallback(
    AssocVariableCallback callback
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| pCallback | The callback to be registered. |

### EvaluateExpression(ObjectIdCollection, ResultBuffer[], ResultBuffer)

#### Description
A helper method allowing to evaluate the expression at any time without modifying the variable and by explicitly providing values of the referenced objects (variables). It is a read-only method, it does not change the value of this or other variables, neither it changes the status of any variables. 
Evaluates the expression based on the provided values of the refrenced objects. The objectIds array is an array of ids of value-providing objects (such as AssocVariables) and objectValues is an array of provided values of these objects. These arrays have the same lengths. 
If the id of this variable is already in objectIds array, the corresponding value from objectValues is returned. Otherwise it evaluates the expression of this variable. Anytime is comes across a symbol referenced by the expression, it checks the objectIds array to see if the value of the object is already known. If yes, it uses this value, otherwise expects that the object is an AssocVariable, obtains its value by recursively calling this method, and uses the returned value. After the value of a variable has been obtained, the variable id and the just obtained value are added to objectIds and objectValues arrays, so that if the same variable is encountered again, its value is used and not evaluated again. 
This method does not change the value of this or any other variable, neither it changes the status of any variable. It does however append id-value pairs to the objectIds and objectValues arrays which are in/out arguments.
```text
public string EvaluateExpression(
    ref ObjectIdCollection objectIds, 
    ref ResultBuffer\[\] objectValues, 
    ref ResultBuffer evaluatedExpressionValue
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ref ObjectIdCollection objectIds | Array of ids of value-providing objects. It is an in/out argument. It is being appended during the evaluation with ids of the value-providing objects whose values have been obtained (currently these objects are only AssocVariables). |
| ref ResultBuffer[] objectValues | Array of values of value-providing objects. It is an in/out argument. It is being appended during the evaluation with values of the value-providing objects whose values have been obtained (currently these objects are only AssocVariables). |
| ref ResultBuffer evaluatedExpressionValue | Returned evaluated value of the expression. |

#### Returns
Error string if expression evaluation has failed.
### EvaluateExpression(ResultBuffer)

#### Description
A helper method allowing the expression to evaluated at any time without modifying the variable. It is a read-only method. 
Evaluates the expression based on the current values of the referenced symbols and returns it in evaluatedExpressionValue. If there is no expression, the stored value is returned. It does not change the stored value, neither it changes the status of the variable.
```text
public string EvaluateExpression(
    ref ResultBuffer evaluatedExpressionValue
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ref ResultBuffer evaluatedExpressionValue | Returned evaluated value of the expression. |

#### Returns
Error string if expression evaluation has failed.
### FindObjectByName

#### Description
Using this AssocVariable as the starting context, searches for an object with the given name. The initial implementation just searches the AssocNetwork owning this variable, but later we may add more sophisticated searches, such as cross-network references, nested-network references, global references, etc.
```text
public ObjectId FindObjectByName(
    string objectName, 
    RXClass pObjectClass
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string objectName | The name of the searched-for object. |
| RXClass pObjectClass | The class of the searched-for object (isKindOf() test is used). |

#### Returns
ObjectId of the found object or null ObjectId if no object found.
#### Remarks
Currently the only named objects are AssocVariables, but there may be more object types in the future. We may also in the future promote this method to the base AssocAction class if we find more cases of named objects.
### globalCallback

#### Description
Returns a callback that is the collection of all callbacks registered by client code. This function is meant mostly for private use and there should not be much need for the client code to use it. Anyway, the client code must never delete or unregister the returned callback, or do anything with it except for calling its methods.
```text
public static AssocVariableCallback globalCallback();
```

#### Returns
The global AssocVariable(Multi)Callback that keeps all the callbacks registered by the client code. The returned pointer is never null.
### RemoveGlobalCallback

#### Description
See the explanation of AssocVariableCallback. Multiple global callbacks can be registered and they apply to all AssocVariables.
```text
public static void RemoveGlobalCallback(
    AssocVariableCallback callback
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| pCallback | The callback to be unregistered. |

### SetName

#### Description
Sets the name of the variable. It does not verify the name. Names should be validated using the [AssocVariable.ValidateNameAndExpression](Autodesk_AutoCAD_DatabaseServices_AssocVariable_ValidateNameAndExpression@string@string@string.md) m[ethod](Autodesk_AutoCAD_DatabaseServices_AssocVariable_ValidateNameAndExpression@string@string@string.md) before being used. 
If the updateReferencingExpressions argument is true, it also finds all expressions referencing this variable and changes them (changes their strings) to reflect the new name of the variable.
```text
public void SetName(
    string newName, 
    [MarshalAs(UnmanagedType.U1)] bool updateReferencingExpressions
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string newName | New name of the variable. |
| [MarshalAs(UnmanagedType.U1)] bool updateReferencingExpressions | If true, it finds all expressions referencing this variable and changes them (changes their strings) to reflect the new name of the variable. |

#### Remarks
Names should not have spaces or begin with numbers.
### ValidateNameAndExpression

#### Description
Validates the given nameToValidate, expressionToValidate or both, to see whether they can be used as name and/or expression for this variable. If either string is empty, it is not validated and is assumed that the name and/or expression of this variable is not going to change. 
For nameToValidate it checks if it is a valid identifier and checks that nameToValidate is not used as name of some other variable in the same network as this variable belongs to. 
For expressionToValidate it performs syntactic checks of the expression, including checks for refrences to undefined symbols and for cyclic dependencies between symbols, but it does not evaluate the expression. 
If these common checks pass, it calls AssocVariableCallback::validateNameAndExpression() so that the client code can perform additional validation, such as that a variable name is used as dimensional constraint name in no more than one dimensional constraint.
```text
public void ValidateNameAndExpression(
    string nameToValidate, 
    string expressionToValidate, 
    ref string errorMessage
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string nameToValidate | The variable name to validate. May be null. |
| string expressionToValidate | The variable expression to validate. May be null. |
| ref string errorMessage | Error string if the name or expression is not valid, empty otherwise. |

### Description

#### Description
Gets and sets the description of the variable which is an arbitrary string. It does not have any additional meaning and does not affect the expression evaluation in any way. 
```text
public string Description;
```

#### Conditions
Read / write
### EvaluatorId

#### Description
Gets and sets the id of the expression evaluator that is used to parse the expression. 
An empty string means the default evaluator. 
```text
public string EvaluatorId;
```

#### Conditions
Read / write
### Expression

#### Description
Gets the expression or an empty string if the variable is a constant.
```text
public string Expression;
```

#### Conditions
Read-only
### Name

#### Description
Gets the variable name which is an arbitrary string.
```text
public string Name;
```

#### Conditions
Read-only
### Value

#### Description
Gets and sets the evaluated and cached value of the variable. Sets the evaluated value. 
Notice that if the expression is not empty, this value will be overwritten the next time the expression is evaluated. 
```text
public ResultBuffer Value;
```

#### Conditions
Read / write