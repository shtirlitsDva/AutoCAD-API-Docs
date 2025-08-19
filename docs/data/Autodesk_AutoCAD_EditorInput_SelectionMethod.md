# Autodesk.AutoCAD.EditorInput.SelectionMethod Enumeration

## Overview

#### Description
This enumeration denotes various AutoCAD object selection methods.
```text
public enum SelectionMethod {
  Crossing = 3,
  Fence = 4,
  NonGraphical = 0,
  PickPoint = 1,
  SubEntity = 5,
  Unavailable = -1,
  Window = 2
}
```

#### Members

| Members | Description |
| --- | --- |
| Crossing = 3 | Crossing or crossing polygon selection.For crossing polygon selections, a window ID value is provided in the entity data sublist in order to identify which crossing was used to select the entity. This same window ID is also provided within the data list for the window/crossing/polygon. By matching up these IDs, the application can determine all the information about how the entity was selected.Window IDs start with -1 sequentially decrease (in other words, -1, -2, -3, and so on). Each individual crossing used during the selection process will get its own window ID. |
| Fence = 4 | Fence selection.For fence selection the selection point is the intersection of the fence with the entity being selected. The fence point data list is the same as for a standard pick point, however, there will be a point data sublist for each intersection between the fence and visible edges of the entity. |
| NonGraphical = 0 | Non-graphical selection.If the selection method is non-graphical, the selection method, entity name, and GS marker will be the only information in the sublist. |
| PickPoint = 1 | Pick point selection.For entities selected by a pick point, information about the point will follow the GS marker information. |
| SubEntity = 5 | Subentity selection.This selection method is set when an entity appears in the selection set due to subentity selections on the entity. In this case, the format of the remaining result buffers in the chain will be the same as the format for non-graphical selections. |
| Unavailable = -1 | No selection method available. |
| Window = 2 | Window or window polygon selection.For window polygon selections, a window ID value is provided in the entity data sublist in order to identify which window was used to select the entity. This same window ID is also provided within the data list for the window/crossing/polygon. By matching up these IDs, the application can determine all the information about how the entity was selected.Window IDs start with -1 sequentially decrease (in other words, -1, -2, -3, and so on). Each individual window used during the selection process will get its own window ID. |