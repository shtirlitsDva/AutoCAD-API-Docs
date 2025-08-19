# ViewTableRecord Class

## Overview

#### Description
This .NET class wraps the AcDbViewTableRecord ObjectARX class. 
Objects of this class represent stored views within AutoCAD. The ViewTable object (referred to in the AutoCAD and DXF documentation as the VIEW table) within each database is the container or owner of objects of this class. 
Most of the data and functionality of this class is inherited from its AbstractViewTableRecord parent class. 
Within AutoCAD, objects of this class are created whenever the VIEW command's "save" option is used to save a view with a name that does not already exist.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTableRecord
        Autodesk.AutoCAD.DatabaseServices.AbstractViewTableRecord
            Autodesk.AutoCAD.DatabaseServices.ViewTableRecord
```

```text
public class ViewTableRecord : AbstractViewTableRecord;
```

### Constructors

- [ViewTableRecord](#viewtablerecord)

### Methods

- [DisassociateUcsFromView](#disassociateucsfromview)

### Properties

- [AnnotationScale](#annotationscale)
- [CategoryName](#categoryname)
- [IsPaperspaceView](#ispaperspaceview)
- [IsUcsAssociatedToView](#isucsassociatedtoview)
- [LayerState](#layerstate)
- [Layout](#layout)
- [LiveSection](#livesection)
- [Thumbnail](#thumbnail)
- [ViewAssociatedToViewport](#viewassociatedtoviewport)


## Constructors Details

### ViewTableRecord

#### Description
Constructor.
```text
public ViewTableRecord();
```

### DisassociateUcsFromView

#### Description
Disassociates the ucs from this view. If this function is called, then no ucs will be associated with the view and the ucs will not change when the view is restored.
```text
public void DisassociateUcsFromView();
```

### AnnotationScale

#### Description
This function returns a pointer to the AnnotationScale object associated with the viewport. 
The controlling application must explicitly delete the memory of the returned pointer to AcDbAnnotationScale. Otherwise, a small memory leak will result.
```text
public Autodesk.AutoCAD.DatabaseServices.AnnotationScale AnnotationScale;
```

#### Conditions
Read / Write
### CategoryName

#### Description
Returns the name of the category of the view.
```text
public string CategoryName;
```

#### Conditions
Read / Write
### IsPaperspaceView

#### Description
Returns true if this ViewTableRecord is a Paper Space view. Otherwise it returns false. 
Within AutoCAD, if a Paper Space view is restored while in Model Space, AutoCAD automatically switches to Paper Space. If a Model Space view is restored while in PaperSpace, AutoCAD prompts the end user to determine which Model Space viewport to restore it to. 
The isPaperSpaceView flag is represented as bit 1 of DXF group code 70 (if bit 1 is set, then the view is a Paper Space view).
```text
public bool IsPaperspaceView;
```

#### Conditions
Read / Write
### IsUcsAssociatedToView

#### Description
Returns true if this view table record has an associated ucs. If this function returns true, then the ucs that is associated with this view will become active whenever this view is restored. The associated ucs can be obtained by calling getUcs() (defined in AbstractViewTableRecord parent class). A ucs can be associated to this view by calling one of the setUcs() functions in the AcDbAbstractViewTableRecord class.
```text
public bool IsUcsAssociatedToView;
```

#### Conditions
Read / Write
### LayerState

#### Description
Returns the name of the layer state. The caller is responsible for creating the layer state and storing it into the ACAD_LAYERSTATES dictionary. Passing in null will clear the layer state from the view.
```text
public string LayerState;
```

#### Conditions
Read / Write
### Layout

#### Description
Returns the layout of the view. 
Returns an error if the layout ID could not be stored. Because paperspace views refer to a position on a specific layout rather than just an arbitrary paper region, this field is required to accurately restore a paperspace view.
```text
public ObjectId Layout;
```

#### Conditions
Read / Write
### LiveSection

#### Description
Returns a live section to be associated with a view. During the restoration of a view, it's associated live section is enabled.
```text
public ObjectId LiveSection;
```

#### Conditions
Read / Write
### Thumbnail

#### Description
Returns the packed BITMAPINFO structure of the thumbnail with the thumbnail data following it immediately in memory. It can be set to null if no thumbnail is desired for this view. 
Returns an error if the thumbnail data could not be stored.
```text
public Bitmap Thumbnail;
```

#### Conditions
Read / Write
### ViewAssociatedToViewport

#### Description
Returns a flag to indicate whether or not the view is associated with a paperspace viewport.
```text
public bool ViewAssociatedToViewport;
```

#### Conditions
Read / Write