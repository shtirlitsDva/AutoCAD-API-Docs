# ViewBorder Class

## Overview

#### Description
The ViewBorder class represents the border entity used by model documentation views in association with a Viewport entity.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.ViewBorder
```

```text
public class ViewBorder : Entity;
```

#### See Also
[Autodesk.AutoCAD.DatabaseServices.Viewport](Autodesk_AutoCAD_DatabaseServices_Viewport.md "Viewport Class")

## Members

### Constructors

- [ViewBorder](#viewborder)

### Methods

- [GetSourceType](#getsourcetype)
- [GetViewStyleType](#getviewstyletype)

### Properties

- [Height](#height)
- [InsertionPoint](#insertionpoint)
- [InventorFileReference](#inventorfilereference)
- [IsFirstAngleProjection](#isfirstangleprojection)
- [RotationAngle](#rotationangle)
- [Scale](#scale)
- [ShadedDPI](#shadeddpi)
- [ViewportId](#viewportid)
- [Width](#width)


## Constructors Details

### ViewBorder

#### Description
This .NET method wraps the ObjectARX method. For internal use only.
```text
public ViewBorder();
```

### GetSourceType

#### Description
This method gets the SourceType of the model documentation view - undefined, Inventor, Fusion, or model space.
```text
public Autodesk.AutoCAD.DatabaseServices.SourceType GetSourceType();
```

#### Returns
enum SourceType: SourceNotDefined, InventorSource, FusionSource, ModelSpaceSource
Example
```text
SourceType st = viewborder.GetSourceType();
switch (st){
   case SourceType.SourceNotDefined:
        ed.WriteMessage("SourceType: SourceNotDefinedn");
        break;
   case SourceType.InventorSource:
        ed.WriteMessage("SourceType: InventorSourcen");
        break;
   case SourceType.FusionSource:
        ed.WriteMessage("SourceType: FusionSourcen");
        break;
   case SourceType.ModelSpaceSource:
        ed.WriteMessage("SourceType: ModelSpaceSourcen");
        break;
}
```

#### See Also
SourceType

### GetViewStyleType

#### Description
This method gets the style type of the model documentation view -- from the base view, wireframe with visible edges, wireframe with hidden edges, shaded with visible edges, or shaded with hidden edges.
```text
public Autodesk.AutoCAD.DatabaseServices.ViewStyleType GetViewStyleType();
```

#### Returns
enum ViewStyleType: FromBase, WireframeVisibleEdges, WireframeHiddenEdges, ShadedVisibleEdges, ShadedHiddenEdges
Example
```text
ViewStyleType vst = viewborder.GetViewStyleType();
switch (vst) {
   case ViewStyleType.FromBase:
        ed.WriteMessage("ViewStyleType: FromBasen");
        break;
   case ViewStyleType.WireframeVisibleEdges:
        ed.WriteMessage("ViewStyleType: WireframeVisibleEdgesn");
        break;
   case ViewStyleType.WireframeHiddenEdges:
        ed.WriteMessage("ViewStyleType: WireframeHiddenEdgesn");
        break;
   case ViewStyleType.ShadedVisibleEdges:
        ed.WriteMessage("ViewStyleType: ShadedVisibleEdgesn");
        break;
   case ViewStyleType.ShadedHiddenEdges:
        ed.WriteMessage("ViewStyleType: ShadedHiddenEdgesn");
       break;
}
```

#### See Also
ViewStyleType


## Properties Details

### Height

#### Description
Gets the height of the model documentation view border. Return value is double.
```text
public double Height;
```

#### Remarks
This property is read only. 
This property wraps AcDbViewBorder::height() method.
Example
```text
double height = viewborder.Height;
```

### InsertionPoint

#### Description
Gets the center of the view border in WCS coordinates (in paperspace). Return value is Autodesk.AutoCAD.Geometry.Point3d.
```text
public Point3d InsertionPoint;
```

#### Remarks
This property is read only. 
This wraps the AcDbViewBorder::insertionPoint() method.
Example
```text
Autodesk.AutoCAD.Geometry.Point3d pt = viewborder.InsertionPoint;
```

### InventorFileReference

#### Description
This method wraps AcDbViewBorder::inventorFileReference method. Return value is String.
```text
public string InventorFileReference;
```

#### Remarks
This property is read only. 
The string returned might be empty if the model documentation view source is not from Inventor.
Example
```text
String fileref = viewborder.InventorFileReference;
if (fileref.Length > 0) { ... }
```

### IsFirstAngleProjection

#### Description
to indicate whether the projection type is first angle or third angle. Return value is bool. 
True indicates the projection type is first angle and false indicates the projection type is third angle.
```text
public bool IsFirstAngleProjection;
```

#### Remarks
This property is read only. 
This property wraps the AcDbViewBorder::isFirstAngleProjection method.
Example
```text
if (viewborder.IsFirstAngleProjection)
```

### RotationAngle

#### Description
Gets the rotation angle (in radians) of the model documentation view in the viewport. The rotation angle is a rotation around the view's line of sight (that is, the vector from camera to target, which is always perpendicular to the display, looking from the front of the display toward the back). The zero angle is horizontally to the right (that is, the display coordinate system's positive X axis). Return value is double, in radians.
```text
public double RotationAngle;
```

#### Remarks
This property is read only. 
This property wraps the AcDbViewBorder::rotationAngle method.
Example
```text
Double rotationAng = viewborder.RotationAngle;
```

### Scale

#### Description
Gets the scale used by the model documentation view. The scale defines the relationship of units in paperspace to units in model space of the viewport. For example, a scale of 0.5 would indicate that 1 unit in the model space of the viewport maps to 0.5 units in paperspace. Return value is double.
```text
public double Scale;
```

#### Remarks
This property is read only. 
This property wraps the AcDbViewBorder::scale method.
Example
```text
double scale = viewborder.Scale;
```

### ShadedDPI

#### Description
Gets the DPI of the image generated for the shaded view style. Return value is System::UInt32
```text
public uint ShadedDPI;
```

#### Remarks
This property is read only. 
This property wraps the AcDbViewBorder::shadedDPI method.
Example
```text
System.UInt32 dpi = viewborder.ShadedDPI;
```

### ViewportId

#### Description
This method returns the ObjectID of the associated model documentation view's Viewport entity 
Autodesk.AutoCAD.DatabaseServices.ObjectId
```text
public ObjectId ViewportId;
```

#### Remarks
This property is read only. 
This method wraps the AcDbViewBorder::viewportId method.
Example
```text
Autodesk.AutoCAD.DatabaseServices.ObjectId vId = viewborder.ViewportId;
Autodesk.AutoCAD.DatabaseServices.Viewport
vp = (Autodesk.AutoCAD.DatabaseServices.Viewport)trans.GetObject(vId, OpenMode.ForRead);
```

#### See Also
Autodesk.AutoCAD.DatabaseServices.Viewport

### Width

#### Description
Gets the width of the model documentation view border. Return value is double.
```text
public double Width;
```

#### Remarks
This property is read only. 
This property wraps the AcDbViewBorder::width method.
Example
```text
double width = viewborder.Width;
```
