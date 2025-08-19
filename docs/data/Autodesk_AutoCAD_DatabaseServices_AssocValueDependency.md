# AssocValueDependency Class

## Overview

#### Description
A concrete dependency class that represents a dependency on a scalar value, such as on a numerical variable. The dependent-on object needs to expose AssocValueProviderPE protocol extension class that is used to obtain the value from the object. It is possible to specify the name of the value in case the object provides more than one value.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocDependency
        Autodesk.AutoCAD.DatabaseServices.AssocValueDependency
```

```text
public class AssocValueDependency : AssocDependency;
```

### Constructors

- [AssocValueDependency](#assocvaluedependency)

### Properties

- [DependentOnObjectValue](#dependentonobjectvalue)
- [ValueName](#valuename)


## Constructors Details

### AssocValueDependency

#### Description
Default constructor.
```text
public AssocValueDependency();
```

### DependentOnObjectValue

#### Description
Gets and sets the value in the dependent-on object and updates the cached value; queries the dependent-on object and returns its value. 
If the object cannot be opened, but the dependency holds the cached value of the object (HasCachedValue is true), it returns this cached value.
```text
public ResultBuffer DependentOnObjectValue;
```

#### Conditions
Read / write
### ValueName

#### Description
Gets and sets the name of the referenced value or an empty string if the value name is not needed because the referenced object exposes only a single value (it is a common case, such as for AssocVariable objects). 
```text
public string ValueName;
```

#### Conditions
Read / write