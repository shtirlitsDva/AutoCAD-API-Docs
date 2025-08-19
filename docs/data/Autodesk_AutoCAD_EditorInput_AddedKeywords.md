# Autodesk.AutoCAD.EditorInput.AddedKeywords Enumeration

## Overview

#### Description
This enumeration is used to add object selection keywords to the prompt message displayed using the PromptSelectionOptions class.
```text
public enum AddedKeywords {
  All = 4,
  CrossingCPolygon = 0x20,
  Fence = 0x40,
  Group = 0x400,
  Last = 0x80,
  LastAllPrevious = 1,
  Multiple = 0x10,
  PickImplied = 2,
  Previous = 0x100,
  WindowCrossingBoxWPolygonCPolygon = 8,
  WindowWPolygon = 0x200
}
```

#### Members

| Members | Description |
| --- | --- |
| All = 4 | Adds the "All" keyword |
| CrossingCPolygon = 0x20 | Adds the "Crossing" and "CPolygon" keywords |
| Fence = 0x40 | Adds the "Fence" keyword |
| Group = 0x400 | Adds the "Group" keyword |
| Last = 0x80 | Adds the "Last" keyword |
| LastAllPrevious = 1 | Adds the "Last", "All", and "Previous" keywords |
| Multiple = 0x10 | Adds the "Multiple" keyword |
| PickImplied = 2 | Adds the ability of the user to pick with the pointing device or coordinate entry; this is not an explicit keyword, but rather an implied keyword |
| Previous = 0x100 | Adds the "Previous" keyword |
| WindowCrossingBoxWPolygonCPolygon = 8 | Adds the "Window", "Crossing", "BOX", "WPolygon", and "CPolygon" keywords |
| WindowWPolygon = 0x200 | Adds the "Window" and "WPolygon" keywords |