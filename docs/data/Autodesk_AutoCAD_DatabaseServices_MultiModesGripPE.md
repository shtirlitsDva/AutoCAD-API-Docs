# MultiModesGripPE Class

## Overview

#### Description
When implemented and registered as a protocol extension to an Autodesk.AutoCAD.DatabaseServices.Entity-derived class, this protocol extension interface specifies the communication with the grip editing complex for information on what alternatives can be provided to stretching grip points. 
These alternatives are represented as an array of modes (of type Autodesk.AutoCAD.DatabaseServices.GripMode). 
The grip editing complex is responsible for querying all available modes, interacting with the user to set the current mode, or switching between modes, and either: 
  * proceeding with grip dragging (if the current mode's action type is ActionType.DragOn),
  * calling moveGripPointsAt once (if the current mode's action type is ActionType.Immediate)
  * executing a command (if the current mode's action type is ActionType.Command).

Clients that implement MultiModesGripPE are responsible for maintaining the "current" mode and providing runtime
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.MultiModesGripPE
```

```text
public abstract class MultiModesGripPE : RXObject;
```

#### Remarks
When the user hovers over a warm grip, the AutoCAD grip complex queries the grip'ed object for this protocol extension and retrieves the available modes. The current mode can be set during the warm grip stage through a multi-mode UI or during hot grip editing through Ctrl-cycling or context menu selection. 
Clients that implement this protocol extension for a given object type (Autodesk.AutoCAD.DatabaseServices.Entity derived) should either own the object type to be able to directly make its MoveGripPointsAt mode-aware or overrule the object's runtime MoveGripPointsAt behavior through GripOverrule.
### Constructors

- [MultiModesGripPE](#multimodesgrippe)

### Methods

- [CurrentMode](#currentmode)
- [CurrentModeId](#currentmodeid)
- [GetGripModes](#getgripmodes)
- [GetGripType](#getgriptype)
- [Reset](#reset)
- [SetCurrentMode](#setcurrentmode)

### Other

- [AutoCAD.DatabaseServices.MultiModesGripPE.GripType Enumeration](#autocad.databaseservices.multimodesgrippe.griptype-enumeration)


## Constructors Details

### MultiModesGripPE

#### Description
Default constructor
```text
public MultiModesGripPE();
```

### CurrentMode

#### Description
Gets the current mode.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.GripMode CurrentMode(
    Entity entity, 
    GripData gripData
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The Entity whose current mode is requested. |
| GripData gripData | The grip whose mode is requested. |

#### Returns
The mode object which is current.
### CurrentModeId

#### Description
Gets the current mode identifier.
```text
public virtual uint CurrentModeId(
    Entity entity, 
    GripData gripData
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The Entity whose current mode id is requested. |
| GripData gripData | The grip whose mode id is requested. |

#### Returns
The returned identifier of current mode.
### GetGripModes

#### Description
Queries an object, on a given grip point, for the available modes it provides. It also returns the current mode identifier.
```text
public virtual bool GetGripModes(
    Entity entity, 
    GripData gripData, 
    GripModeCollection modes, 
    ref uint curMode
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The Entity whose modes are requested. The object needs to be open at least for read. |
| GripData gripData | The grip whose modes are requested. |
| GripModeCollection modes | The returned collection of available modes. |
| ref uint curMode | The returned identifier of current mode. |

#### Returns
True if successful.
### GetGripType

#### Description
Gets the grip type of a given grip.
```text
public virtual GripType GetGripType(
    Entity entity, 
    GripData gripData
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The Entity whose grip type is requested. |
| GripData gripData | The grip whose grip type is requested. |

#### Returns
The grip type of the grip.
### Reset

#### Description
Resets the current mode to default (up to each concrete class to establish what the default is).
```text
public virtual void Reset(
    Entity entity
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The Entity whose current mode is reset to default. |

### SetCurrentMode

#### Description
Sets the current mode.
```text
public virtual bool SetCurrentMode(
    Entity entity, 
    GripData gripData, 
    uint curMode
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The Entity whose current mode is to be set current. |
| GripData gripData | The grip whose current mode is to be set current. |
| uint curMode | The numerical identifier for the new current mode. |

#### Returns
True of successful.
### AutoCAD.DatabaseServices.MultiModesGripPE.GripType Enumeration

#### Description
The type of a grip.
```text
public enum GripType {
  Primary,
  Secondary
}
```

#### Members
| Members | Description |
| --- | --- |
| Primary | The primary grip. Always shown if host applications's GRIPS variable is not 0; |
| Secondary | The secondary grip. Only shown when host application's GRIPS variable is 2; |