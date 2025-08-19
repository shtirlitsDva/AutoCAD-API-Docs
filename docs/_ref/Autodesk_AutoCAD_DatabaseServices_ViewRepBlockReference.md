# ViewRepBlockReference Class

## Overview

#### Description
The ViewRepBlockReference class represents the AcDbViewRepBlockReference entity used by model documentation views in association with a Viewport entity. 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.BlockReference
            Autodesk.AutoCAD.DatabaseServices.ViewRepBlockReference
```

```text
public class ViewRepBlockReference : BlockReference;
```

#### See Also
Autodesk.AutoCAD.DatabaseServices.Viewport

## Members

### Constructors

- [ViewRepBlockReference](#viewrepblockreference)

### Properties

- [OwnerViewportId](#ownerviewportid)


## Constructors Details

### ViewRepBlockReference

#### Description
This is ViewRepBlockReference, a member of class ViewRepBlockReference.
```text
public ViewRepBlockReference();
```

### OwnerViewportId

#### Description
This property returns the ObjectID of the associated model documentation view's Viewport entity. Return value is Autodesk.AutoCAD.DatabaseServices.ObjectId.
```text
public ObjectId OwnerViewportId;
```

#### Conditions
This property is read only.
Example
```text
Autodesk.AutoCAD.DatabaseServices.ObjectId vId = viewRepBlockReference.OwnerViewportId;
Autodesk.AutoCAD.DatabaseServices.Viewport vp =
(Autodesk.AutoCAD.DatabaseServices.Viewport)trans.GetObject(vId, OpenMode.ForRead);
```

#### See Also
Autodesk.AutoCAD.DatabaseServices.Viewport