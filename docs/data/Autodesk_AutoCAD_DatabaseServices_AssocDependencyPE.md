# AssocDependencyPE Class

## Overview

#### Description
Wrapper AcRx protocol extension base class that allows objects and entities to control whether they allow AssocDependencies to be attached to them. When there is no protocol extension for the object's class, it means that the object allows both read and write-type dependencies. 
Other AssocDependency-related protocol may later be added.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocDependencyPE
```

```text
public abstract class AssocDependencyPE : RXObject;
```

### Constructors

- [AssocDependencyPE](#assocdependencype)

### Methods

- [AllowsDependencies](#allowsdependencies)


## Constructors Details

### AssocDependencyPE

#### Description
Default constructor
```text
public AssocDependencyPE();
```

### AllowsDependencies

#### Description
This predicate allows objects and entities to control whether they allow AssocDependencies to be attached to them. Returns true if the object allows AssocDependencies to be attached to it.
```text
public abstract bool AllowsDependencies(
    DBObject dbObj, 
    [MarshalAs(UnmanagedType.U1)] bool isWriteDependency
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool isWriteDependency | The dependency will also modify the object. |
| object | The queried object, must be open for read. |

#### Returns
True if the object allows AssocDependencies on itself.