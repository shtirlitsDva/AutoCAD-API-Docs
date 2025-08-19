# LayoutManager Class

## Overview

#### Description
This .NET class wraps the AcDbLayoutManager ObjectARX class. 
This is an interface class for database-specific routines that manipulate and access Layout objects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.LayoutManager
```

```text
public class LayoutManager : RXObject;
```

### Events

- [AbortLayoutCopied](#abortlayoutcopied)
- [AbortLayoutRemoved](#abortlayoutremoved)
- [AbortLayoutRename](#abortlayoutrename)
- [LayoutCopied](#layoutcopied)
- [LayoutCreated](#layoutcreated)
- [LayoutRemoved](#layoutremoved)
- [LayoutRenamed](#layoutrenamed)
- [LayoutsRefresh](#layoutsrefresh)
- [LayoutsReordered](#layoutsreordered)
- [LayoutSwitched](#layoutswitched)
- [LayoutToBeCopied](#layouttobecopied)
- [LayoutToBeRemoved](#layouttoberemoved)
- [LayoutToBeRenamed](#layouttoberenamed)
- [PlotStyleTableChanged](#plotstyletablechanged)

### Methods

- [CloneLayout](#clonelayout)
- [CopyLayout](#copylayout)
- [CreateLayout](#createlayout)
- [DeleteLayout](#deletelayout)
- [GetLayoutId](#getlayoutid)
- [GetNonRectangularViewportIdFromClipId](#getnonrectangularviewportidfromclipid)
- [LayoutExists](#layoutexists)
- [RenameLayout](#renamelayout)
- [SetCurrentLayoutId](#setcurrentlayoutid)

### Properties

- [Current](#current)
- [CurrentLayout](#currentlayout)
- [LayoutCount](#layoutcount)


## Events Details

### AbortLayoutCopied

#### Description
This event is fired when the layout copy is aborted.
```text
public event LayoutEventHandler AbortLayoutCopied;
```

### AbortLayoutRemoved

#### Description
This event is fired when the layout remove is aborted.
```text
public event LayoutEventHandler AbortLayoutRemoved;
```

### AbortLayoutRename

#### Description
This event is fired when the layout rename is aborted.
```text
public event LayoutRenamedEventHandler AbortLayoutRename;
```

### LayoutCopied

#### Description
This event is fired when the layout copy ends.
```text
public event LayoutCopiedEventHandler LayoutCopied;
```

### LayoutCreated

#### Description
This event is fired when the layout creation ends.
```text
public event LayoutEventHandler LayoutCreated;
```

### LayoutRemoved

#### Description
This event is fired when the layout removal ends.
```text
public event LayoutEventHandler LayoutRemoved;
```

### LayoutRenamed

#### Description
This event is fired when the layout rename ends.
```text
public event LayoutRenamedEventHandler LayoutRenamed;
```

### LayoutsRefresh

#### Description
This is LayoutsRefresh, a member of class LayoutManager.
```text
public event EventHandler LayoutsRefresh;
```

### LayoutsReordered

#### Description
This event is fired when the layouts are reordered.
```text
public event EventHandler LayoutsReordered;
```

### LayoutSwitched

#### Description
This event is fired when the layout is switched.
```text
public event LayoutEventHandler LayoutSwitched;
```

### LayoutToBeCopied

#### Description
This event is fired when the layout is about to be copied.
```text
public event LayoutEventHandler LayoutToBeCopied;
```

### LayoutToBeRemoved

#### Description
This event is fired when the layout is about to be removed.
```text
public event LayoutEventHandler LayoutToBeRemoved;
```

### LayoutToBeRenamed

#### Description
This event is fired when the layout is about to be renamed.
```text
public event LayoutRenamedEventHandler LayoutToBeRenamed;
```

### PlotStyleTableChanged

#### Description
This event is fired when the plot style table is changed.
```text
public event PlotStyleTableChangedEventHandler PlotStyleTableChanged;
```

### CloneLayout

#### Description
This function clones the given Layout object and sets the cloned layout to the given layout name and tab order.
```text
public void CloneLayout(
    string copyName, 
    string newName, 
    int newTabOrder
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string copyName | Input to the old Layout name |
| string newName | Input the name for new layout |
| int newTabOrder | Optional input integer specifying new tab order |

### CopyLayout

#### Description
This function makes a copy of an existing Layout object with the given copyName and creates a new copy with the layout name of newName.
```text
public void CopyLayout(
    string copyName, 
    string newName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string copyName | Input name of Layout object to be copied |
| string newName | Input name for new copy of Layout object |

### CreateLayout

#### Description
This function creates a new Layout object given a unique layout name. The default viewports for the new layout are not created until the layout is first activated.
```text
public ObjectId CreateLayout(
    string newName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string newName | Input name to give new Layout object |

### DeleteLayout

#### Description
This function removes the Layout object associated with the given layout name from the current database.
```text
public void DeleteLayout(
    string deleteName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string deleteName | Input name of Layout object to delete |

### GetLayoutId

#### Description
This function returns the Layout object associated with the given input name. The returned object is not open for reading from or writing to the database by default.
```text
public ObjectId GetLayoutId(
    string name
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input name of Layout object to search for |

### GetNonRectangularViewportIdFromClipId

#### Description
This function returns the ObjectId for the non rectangular viewport ID associated with the given clipId. Returns NULL if given entity isn't a valid clip entity.
```text
public ObjectId GetNonRectangularViewportIdFromClipId(
    ObjectId clipId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId clipId | Input ObjectId of clip entity to get the nonrectangular viewport ID from |
| name | Input name of Layout object to search for. |

### LayoutExists

#### Description
This function returns true if the layout named name is found in the database.
```text
public bool LayoutExists(
    string name
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input name of layout to find. |

### RenameLayout

#### Description
This function renames a Layout object by the given oldName to the new name given by newName.
```text
public void RenameLayout(
    string oldName, 
    string newName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string oldName | Input name of Layout object to rename |
| string newName | Input new name for renamed Layout object |

### SetCurrentLayoutId

#### Description
Accesses the current layout. This will get/set the current layout from the current working database. If you want to get/set current layout from the database other than the current working database, you should set the working database to it first, and then set it back after you get/set the current layout.
```text
public void SetCurrentLayoutId(
    ObjectId layoutId
);
```

### Current

#### Description
Accesses the current layout manager.
```text
public static LayoutManager Current;
```

#### Conditions
Read-only
### CurrentLayout

#### Description
Accesses the current layout.
```text
public string CurrentLayout;
```

#### Conditions
Read / Write
### LayoutCount

#### Description
Accesses the current number of layouts.
```text
public int LayoutCount;
```

#### Conditions
Read-only