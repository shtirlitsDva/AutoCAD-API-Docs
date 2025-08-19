# Layout Class

## Overview

#### Description
This .NET class wraps the AcDbLayout ObjectARX class. 
An Layout object stores characteristics of each paperspace layout. Layout objects are stored in an Dictionary object with an ACAD_LAYOUT key, allowing easy iteration and indexing.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.PlotSettings
        Autodesk.AutoCAD.DatabaseServices.Layout
```

```text
public class Layout : PlotSettings;
```

### Constructors

- [Layout](#layout)

### Methods

- [AddToLayoutDictionary](#addtolayoutdictionary)
- [GetViewports](#getviewports)
- [Initialize](#initialize)

### Properties

- [AnnoAllVisible](#annoallvisible)
- [BlockTableRecordId](#blocktablerecordid)
- [Extents](#extents)
- [LayoutName](#layoutname)
- [Limits](#limits)
- [TabOrder](#taborder)
- [TabSelected](#tabselected)
- [Thumbnail](#thumbnail)


## Constructors Details

### Layout

#### Description
Default constructor.
```text
public Layout();
```

### AddToLayoutDictionary

#### Description
This method adds the layout to the specified database's layout dictionary, and specifies the block table record to use.
```text
public virtual void AddToLayoutDictionary(
    Database toWhichDatabase, 
    ObjectId blockTableRecordId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Database toWhichDatabase | Input database to which to add the layout |
| ObjectId blockTableRecordId | Input block table record to use |

### GetViewports

#### Description
This function returns a collection of ObjectIds of all the Viewports that exist in the Layout's paperspace. The first ID in the list will be the paperspace viewport. If the list returned is empty, then this Layout has never been switched to (activated). The list is updated each time a layout is activated, and kept up-to-date while that layout is active (whenever viewports are added or deleted).
```text
public ObjectIdCollection GetViewports();
```

### Initialize

#### Description
This method will do the behind the scenes work to establish a Paper Space viewport for the layout. This allows a layout to be set up and made ready for other viewports and entities to be put into the layout as well as to set various layout properties. 
Returns an existing ObjectId object that will be set to the objectId of the paper space Viewport created by this function
```text
public ObjectId Initialize();
```

### AnnoAllVisible

#### Description
Accesses current ANNOALLVISIBLE value for the database 
See the System Variables section of the _AutoCAD Command Reference_ for information on ANNOALLVISIBLE. 
This is an Database Header Variable Query Function.
```text
public bool AnnoAllVisible;
```

#### Conditions
Read / Write
### BlockTableRecordId

#### Description
Accesses the Layout's associated BlockTableRecord. Corresponding methods in BlockTableRecord implement a forward pointer to the Layout.
```text
public ObjectId BlockTableRecordId;
```

#### Conditions
Read / Write
### Extents

#### Description
Accesses the current extents setting of the layout. This value may not be the actual extents of the geometry in the layout, it is just the value last saved in the layout.
```text
public Extents3d Extents;
```

#### Conditions
Read-only
### LayoutName

#### Description
Accesses the user-friendly layout name that is displayed in the tab control.
```text
public string LayoutName;
```

#### Conditions
Read / Write
### Limits

#### Description
Accesses the current limits set in the layout.
```text
public Extents2d Limits;
```

#### Conditions
Read-only
### TabOrder

#### Description
Accesses the tab order field, which controls the order in which the layouts are displayed in the tab control that is docked to the bottom of the viewport. The tab order should be unique and sequential for each layout in the database.
```text
public int TabOrder;
```

#### Conditions
Read / Write
### TabSelected

#### Description
Accesses the layout tab is included in the selection set for operations that affect multiple tabs. The user can perform multiple selection via the user interface using shift-click.
```text
public bool TabSelected;
```

#### Conditions
Read / Write
### Thumbnail

#### Description
Accesses the thumbnail argument to point to a newly-allocated buffer that contains this layout's thumbnail bitmap.
```text
public Bitmap Thumbnail;
```

#### Conditions
Read / Write