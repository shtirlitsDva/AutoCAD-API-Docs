# Autodesk.AutoCAD.EditorInput.SelectionMode Enumeration

## Overview

#### Description
This .NET class wraps the AcEdSSGetModes ObjectARX enumeration. 
This enumeration contains the mode settings for an entity selection process. The settings are used by methods that provide notification of a failed entity subselection.
```text
public enum SelectionMode {
  All = 6,
  Box = 3,
  Crossing = 2,
  CrossingPolygon = 8,
  Entity = 5,
  Every = 11,
  Extents = 12,
  FencePolyline = 7,
  Group = 13,
  Last = 4,
  Multiple = 15,
  Pick = 10,
  Previous = 14,
  Window = 1,
  WindowPolygon = 9
}
```

#### Members
| Members | Description |
| --- | --- |
| All = 6 | Select all |
| Box = 3 | Box specification |
| Crossing = 2 | Crossing specification |
| CrossingPolygon = 8 | Crossing poly |
| Entity = 5 | Explicit entity name |
| Every = 11 | Every entity on single pick |
| Extents = 12 | ssget "X |
| FencePolyline = 7 | Fence selection |
| Group = 13 | Selection set from group specification |
| Last = 4 | Last |
| Pick = 10 | Single pick |
| Previous = 14 | Previous selection set |
| Window = 1 | Window specification |
| WindowPolygon = 9 | Window poly |