# Autodesk.AutoCAD.EditorInput.SelectionFlags Enumeration

## Overview

#### Description
This .NET class wraps the AcEdSSGet::AcEdSSGetFlags ObjectARX enumeration. 
This enumeration contains the flag settings for an entity selection process. The settings are used by methods that add entities to or remove entities from a subSelectionSet.
```text
public enum SelectionFlags {
  Duplicates = 2,
  FailedPickAuto = 0x200,
  NestedEntities = 4,
  Normal = 0,
  PickfirstSet = 0x20,
  PickPoints = 1,
  PreviousSet = 0x40,
  SinglePick = 0x10,
  SubEntities = 8,
  SubSelection = 0x80,
  Undo = 0x100
}
```

#### Members
| Members | Description |
| --- | --- |
| Duplicates = 2 | Duplicate selections are allowed. |
| FailedPickAuto = 0x200 | The selection resulted from a missed pick in PICKAUTO mode, AutoCAD will next perform a window or crossing window selection based on the next point picked. |
| NestedEntities = 4 | Nested entities are allowed. |
| Normal = 0 | Standard entity selection. |
| PickfirstSet = 0x20 | Pickfirst set used. |
| PickPoints = 1 | Real pick points are needed. |
| PreviousSet = 0x40 | The previous selection set. |
| SinglePick = 0x10 | Force a single pick. |
| SubEntities = 8 | Subentity selections are requested. |
| SubSelection = 0x80 | When set, indicates that the ":U" option was used in a call to acedSSGet() and that the selection set may contain subentity information. |
| Undo = 0x100 | AutoCAD is undoing a selection operation |