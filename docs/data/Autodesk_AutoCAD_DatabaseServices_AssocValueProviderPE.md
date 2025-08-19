# AssocValueProviderPE Class

## Overview

#### Description
AcRx protocol extension pure virtual base class that defines protocol to get and set arbitrary simple scalar values of DBObjects. The values are identified by string names (needed if there is more than one of them for the same object) and their meaning is up to the implementor of the concrete protocol extension derived classes. 
The derived concrete classes implement this protocol for the individual DBObject classes that want to offer some named values. The immediate clients of this protocol are AssocVariable class that exposes this interface to provide the value of the variable and AssocValueDependency class that uses this interface to obtain the value from the dependent-on object.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocValueProviderPE
```

```text
public abstract class AssocValueProviderPE : RXObject;
```

### Constructors

- [AssocValueProviderPE](#assocvalueproviderpe)

### Methods

- [CanGetValue](#cangetvalue)
- [CanSetValue](#cansetvalue)
- [GetValue](#getvalue)
- [SetValue](#setvalue)


## Constructors Details

### AssocValueProviderPE

#### Description
Default Constructor
```text
public AssocValueProviderPE();
```

### CanGetValue

#### Description
Checks whether it is possible to get the value identified by valueName. The default implementation always returns true for any valueName.
```text
public virtual bool CanGetValue(
    DBObject dbObj, 
    string valueName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string valueName | The name of the queried value. |
| object | The object must be open for read. |

#### Returns
True if a value with the given name can be obtained. The default implementation always returns true.
### CanSetValue

#### Description
Checks whether it is possible to set the value identified by valueName. The default implementation always returns false for any valueName.
```text
public virtual bool CanSetValue(
    DBObject dbObj, 
    string valueName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string valueName | The name of the queried value. |
| object | The object must be open for read. |

#### Returns
True if a value with the given name can be changed. The default implementation always returns false.
### GetValue

#### Description
Gets the value identified by valueName. This method must always be overridden by concrete derived classes.
```text
public abstract ResultBuffer GetValue(
    DBObject dbObj, 
    string valueName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string valueName | The name of the queried value. |
| object | The object must be open for read. |

#### Returns
The returned value
### SetValue

#### Description
Sets the value identified by valueName.
```text
public virtual void SetValue(
    DBObject dbObj, 
    string valueName, 
    ResultBuffer newValue
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string valueName | The name of the value to be set. |
| ResultBuffer newValue | The new value. |
| object | The object must be open for write. |
