# GripMode Class

## Overview

#### Description
The type that contains all information to present a single mode.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GripMode
```

```text
public class GripMode : DisposableWrapper;
```

### Constructors

- [GripMode](#gripmode)

### Other

- [AutoCAD.DatabaseServices.GripMode.ActionType Enumeration](#autocad.databaseservices.gripmode.actiontype-enumeration)
- [AutoCAD.DatabaseServices.GripMode.CursorType Enumeration](#autocad.databaseservices.gripmode.cursortype-enumeration)
- [AutoCAD.DatabaseServices.GripMode.ModeIdentifier Enumeration](#autocad.databaseservices.gripmode.modeidentifier-enumeration)

### Properties

- [Action](#action)
- [CLIDisplayString](#clidisplaystring)
- [CLIKeywordList](#clikeywordlist)
- [CLIPromptString](#clipromptstring)
- [CommandString](#commandstring)
- [Cursor](#cursor)
- [DisplayString](#displaystring)
- [ModeId](#modeid)
- [ToolTip](#tooltip)


## Constructors Details

### GripMode

#### Description
Default constructor
```text
public GripMode();
```

### AutoCAD.DatabaseServices.GripMode.ActionType Enumeration

#### Description
The type of actions the grip editing complex takes when a mode is becoming current.
```text
public enum ActionType {
  DragOn,
  Immediate,
  Command
}
```

#### Members
| Members | Description |
| --- | --- |
| DragOn | Instructs the grip editor to proceed with dragging. The mode specific behavior is determined by object's moveGripPointsAt current mode awareness. |
| Immediate | Instructs the grip editor to call moveGripPointsAt once and end dragging sequence. |
| Command | External command, specified as GripMode.CommandString, is called. |

### AutoCAD.DatabaseServices.GripMode.CursorType Enumeration

#### Description
The type of canvas cursor that can be specified for each mode.
```text
public enum CursorType {
  CursorNone,
  CursorCrosshairPlus,
  CursorCrosshairMinus,
  CursorCrosshairCurve,
  CursorCrosshairLine,
  CursorCrosshairAngle
}
```

#### Members
| Members | Description |
| --- | --- |
| CursorNone | No cursor change, using default. |
| CursorCrosshairPlus | Default cursor combined with a plus sign. |
| CursorCrosshairMinus | Default cursor combined with a minus sign. |
| CursorCrosshairCurve | Default cursor combined with a curve sign. |
| CursorCrosshairLine | Default cursor combined with a straight line sign. |
| CursorCrosshairAngle | Default cursor combined with an angle sign. For future use. |

### AutoCAD.DatabaseServices.GripMode.ModeIdentifier Enumeration

#### Description
The numerical identifier of a grip mode.
```text
public enum ModeIdentifier {
  CustomStart = 100,
  Move = 1,
  None = 0
}
```

#### Members
| Members | Description |
| --- | --- |
| CustomStart = 100 | The start of custom mode types. All custom defined mode behavior should be larger than this value. |
| Move = 1 | Stretch at the grip point |
| None = 0 | Default |


## Properties Details

### Action

#### Description
Gets and sets the action type of this mode uses.
```text
public ActionType Action;
```

#### Conditions
Read / write
### CLIDisplayString

#### Description
Gets and sets the display string of this mode in various UI elements (including the hover menu and object context menu).
```text
public string CLIDisplayString;
```

#### Conditions
Read / write
### CLIKeywordList

#### Description
Gets and sets the command line keyword list associated to CLIPromptString.
```text
public string CLIKeywordList;
```

#### Conditions
Read / write
### CLIPromptString

#### Description
Gets and sets the command line prompt string when this mode is switched as current.
```text
public string CLIPromptString;
```

#### Conditions
Read / write
### CommandString

#### Description
Gets and sets the command used for this mode if the action type is kCommand. Optional.
```text
public string CommandString;
```

#### Conditions
Read / write
### Cursor

#### Description
Gets and sets the type of cursor this mode uses. Optional.
```text
public CursorType Cursor;
```

#### Conditions
Read / write
### DisplayString

#### Description
Gets and sets the command line version of the display string for this mode.
```text
public string DisplayString;
```

#### Conditions
Read / write
### ModeId

#### Description
Gets and sets the unique identifier among the collection of modes this PE implements.
```text
public uint ModeId;
```

#### Conditions
Read / write
### ToolTip

#### Description
Gets and sets the string tool tip of this mode. (For future use.)
```text
public string ToolTip;
```

#### Conditions
Read / write