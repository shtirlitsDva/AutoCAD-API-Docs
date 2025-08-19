# Autodesk.AutoCAD.DatabaseServices.CellStates Enumeration

## Overview

#### Description
This .NET class wraps the CellState ObjectARX enum. 
These values specify the various states of the data in a cell.
```text
public enum CellStates {
  ContentLocked = 1,
  ContentModifiedAfterUpdate = 8,
  ContentReadOnly = 2,
  FormatLocked = 0x10,
  FormatModifiedAfterUpdate = 0x40,
  FormatReadOnly = 0x20,
  Linked = 4,
  None = 0
}
```

#### Members
| Members | Description |
| --- | --- |
| ContentLocked = 1 | Cell's content is locked. Can be unlocked by user |
| ContentModifiedAfterUpdate = 8 | Cell's content has been modified since last update. |
| ContentReadOnly = 2 | Cell's content is read-only. Cannot be unlocked by user. |
| FormatLocked = 0x10 | Cell's format is locked. Can be unlocked by user. |
| FormatModifiedAfterUpdate = 0x40 | Cell's content has been modified since last update. |
| FormatReadOnly = 0x20 | Cell's format is read-only. Cannot be unlocked by user. |
| Linked = 4 | Cell is linked to a data source. |
| None = 0 | None |