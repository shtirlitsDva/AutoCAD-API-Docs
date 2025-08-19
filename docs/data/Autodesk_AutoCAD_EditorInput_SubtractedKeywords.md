# Autodesk.AutoCAD.EditorInput.SubtractedKeywords Enumeration

## Overview

#### Description
This enumeration is used to remove object selection keywords from the prompt message displayed using the PromptSelectionOptions class.
```text
public enum SubtractedKeywords {
  AddRemove = 0x800,
  All = 4,
  BoxAuto = 8,
  CrossingCPolygon = 0x20,
  Fence = 0x40,
  Group = 0x400,
  Last = 0x80,
  LastAllGroupPrevious = 1,
  Multiple = 0x10,
  PickImplied = 2,
  Previous = 0x100,
  WindowWPolygon = 0x200
}
```

#### Members

| Members | Description |
| --- | --- |
| AddRemove = 0x800 | Removes the "Add" and "Remove" keywords |
| All = 4 | Removes the "All" keyword |
| BoxAuto = 8 | Removes the "BOX" and "AUto" keywords |
| CrossingCPolygon = 0x20 | Removes the "Crossing" and "CPolygon" keywords |
| Fence = 0x40 | Removes the "Fence" keyword |
| Group = 0x400 | Removes the "Group" keyword |
| Last = 0x80 | Removes the "Last" keyword |
| LastAllGroupPrevious = 1 | Removes the "Last", "All", "Group", and "Previous" keyword |
| Multiple = 0x10 | Removes the "Multiple" keyword |
| PickImplied = 2 | Removes the ability of the user to pick with the pointing device or coordinate entry; this is not an explicit keyword, but rather an implied keyword |
| Previous = 0x100 | Removes the "Previous" keyword |
| WindowWPolygon = 0x200 | Removes the "Window" and "WPolygon" keywords |