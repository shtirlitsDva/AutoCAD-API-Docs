# ObjectContextManager Class

## Overview

#### Description
This .NET class wraps the AcDbObjectContextManager ObjectARX class. 
Exposes the collection of context types supported by the drawing. 
Each Database exposes an ObjectContextManager which can be used to register, unregister, and enumerate custom context collections.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ObjectContextManager
```

```text
public class ObjectContextManager : RXObject;
```

### Constructors

- [ObjectContextManager](#objectcontextmanager)

### Methods

- [GetContextCollection](#getcontextcollection)
- [RegisterContextCollection](#registercontextcollection)
- [UnregisterContextCollection](#unregistercontextcollection)


## Constructors Details

### ObjectContextManager

#### Description
Default constructor. 
For internal use only.
```text
public ObjectContextManager();
```

### GetContextCollection

#### Description
Returns the collection registered if one exists with the specified name
```text
public ObjectContextCollection GetContextCollection(
    string collectionName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string collectionName | The name of the desired collection. |

### RegisterContextCollection

#### Description
Registers a context collection with the context manager.
```text
public void RegisterContextCollection(
    string collectionName, 
    ObjectContextCollection collection
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string collectionName | The name of the collection to register with the manager. |
| ObjectContextCollection collection | The collection to register with the manager. |

### UnregisterContextCollection

#### Description
Unregisters a context collection with the context manager.
```text
public void UnregisterContextCollection(
    string collectionName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string collectionName | The name of the collection to unregister with the manager. |

#### Conditions
Read-only