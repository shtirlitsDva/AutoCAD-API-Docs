# ObjectContextCollection Class

## Overview

#### Description
This .NET class wraps the AcDbObjectContextCollection ObjectARX class. 
An interface to an application-defined collection of ObjectContext objects. 
Applications implement this interface to define custom object contexts for their context-sensitive objects. Applications must instantiate an instance of the collection (typically one instance for each database) and register it with the ObjectContextManager for each Database which needs to support the context type. Each context collection has a state; this is represented by the collection of contexts, the "current" context, and the ability to lock or unlock context instances.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ObjectContextCollection
```

```text
public abstract class ObjectContextCollection : RXObject, IEnumerable;
```

### Methods

- [AddContext](#addcontext)
- [GetContext](#getcontext)
- [GetEnumerator](#getenumerator)
- [HasContext](#hascontext)
- [RemoveContext](#removecontext)

### Properties

- [CurrentContext](#currentcontext)
- [Name](#name)


## Methods Details

### AddContext

#### Description
Adds a copy of a context to the collection. 
Because the unique identifier of the collection resident contexts must be unique, the copied context added to the collection may be assigned a different identifier than the context it is copied from.
```text
public virtual void AddContext(
    ObjectContext ctxt
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectContext ctxt | The context to copy and add to the collection. |

### GetContext

#### Description
Gets a copy of a context with the specified name.
```text
public virtual ObjectContext GetContext(
    string contextName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string contextName | The name of the context to copy and return. |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public ObjectContextCollectionEnumerator GetEnumerator();
```

### HasContext

#### Description
Determines whether a context with the specified name exists in the collection.
```text
public virtual bool HasContext(
    string contextName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string contextName | The name of the context to find. |

#### Conditions
Read-only 
### RemoveContext

#### Description
Removes a context from the collection. 
The active context cannot be removed from a collection.
```text
public virtual void RemoveContext(
    string contextName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string contextName | The name of the context to remove from the collection. |

### CurrentContext

#### Description
Accesses the current context for the collection.
```text
public virtual ObjectContext CurrentContext;
```

#### Conditions
Read / Write
### Name

#### Description
Accesses the name of the context collection.
```text
public virtual string Name;
```

#### Conditions
Read-only