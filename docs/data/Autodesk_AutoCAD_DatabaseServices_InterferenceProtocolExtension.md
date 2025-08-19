# InterferenceProtocolExtension Class

## Overview

#### Description
This .NET class wraps the AcDbInterferencePE ObjectARX class. 
It is the protocol extension abstract base class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.InterferenceProtocolExtension
```

```text
public class InterferenceProtocolExtension : RXObject;
```

### Methods

- [CreateInterferenceObjects](#createinterferenceobjects)


## Methods Details

### CreateInterferenceObjects

#### Description
The implementer is expected to create new Entity instance(s), based on interference between the two provided entities, and append the new entities to the returned array. The caller will either post the new entities to the database or delete them.
```text
public virtual Entity\[\] CreateInterferenceObjects(
    Entity ent1, 
    Entity ent2, 
    int flags
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity ent1 | Input entity 1 |
| Entity ent2 | Input entity 2 |
| int flags | Input interference flags |

#### Conditions
Read-only