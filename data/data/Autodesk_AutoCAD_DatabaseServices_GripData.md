# GripData Class

## Overview

#### Description
This .NET class wraps the ObjectARX class GripData class. 
This class describes a specific grip for a specific entity. It allows applications with control over grips to: 
  * Draw their own grip glyph graphics
  * Perform custom operations when the user picks or hovers over a grip
  * Control a right-click menu that involves grips
  * Receive detailed notification about a grip editing operation

When a custom class implements the AcDbEntity::getGripPoints() function, it fills the AcDbGripDataArray argument with AcDbGripData objects, one per grip point. 
The AcDbGripData object contains two members that define the grip: the actual 3d point for the grip and a pointer to a data structure specified by the custom entity that is used as the identifier for the grip. These two data members are required. 
The object also includes optional members that contain pointers to callbacks that the host application may call during a grip edit operation to allow the custom entity to do event processing. These pointers may be null if the functionality is not provided. 
The object also includes an optional bitmask that controls the appearance of the grip during drag operations. These bit values may be OR'd together.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GripData
```

```text
public class GripData : DisposableWrapper;
```

### Methods

- [DeleteUnmanagedObject](#deleteunmanagedobject)
- [GetHotGripDimensionData](#gethotgripdimensiondata)
- [GetHoverDimensionData](#gethoverdimensiondata)
- [GetTooltip](#gettooltip)
- [OnGripStatusChanged](#ongripstatuschanged)
- [OnHotGrip](#onhotgrip)
- [OnHover](#onhover)
- [OnRightClick](#onrightclick)
- [ViewportDraw](#viewportdraw)
- [WorldDraw](#worlddraw)

### Other

- [AutoCAD.DatabaseServices.GripData.Context Enumeration](#autocad.databaseservices.gripdata.context-enumeration)
- [AutoCAD.DatabaseServices.GripData.DrawType Enumeration](#autocad.databaseservices.gripdata.drawtype-enumeration)
- [AutoCAD.DatabaseServices.GripData.ReturnValue Enumeration](#autocad.databaseservices.gripdata.returnvalue-enumeration)
- [AutoCAD.DatabaseServices.GripData.Status Enumeration](#autocad.databaseservices.gripdata.status-enumeration)

### Properties

- [AlternateBasePoint](#alternatebasepoint)
- [DrawAtDragImageGripPoint](#drawatdragimagegrippoint)
- [ForcedPickOn](#forcedpickon)
- [GizmosEnabled](#gizmosenabled)
- [GripPoint](#grippoint)
- [HotGripInvokesRightClick](#hotgripinvokesrightclick)
- [IsPerViewport](#isperviewport)
- [ModeKeywordsDisabled](#modekeywordsdisabled)
- [RubberBandLineDisabled](#rubberbandlinedisabled)
- [SkipWhenShared](#skipwhenshared)
- [TriggerGrip](#triggergrip)


## Methods Details

### DeleteUnmanagedObject

#### Description
This is DeleteUnmanagedObject, a member of class GripData.
```text
protected override void DeleteUnmanagedObject();
```

### GetHotGripDimensionData

#### Description
This is GetHotGripDimensionData, a member of class GripData.
```text
public virtual DynamicDimensionDataCollection GetHotGripDimensionData(
    ObjectId id, 
    double dimScale
);
```

### GetHoverDimensionData

#### Description
This is GetHoverDimensionData, a member of class GripData.
```text
public virtual DynamicDimensionDataCollection GetHoverDimensionData(
    ObjectId id, 
    double dimScale
);
```

### GetTooltip

#### Description
This .NET method wraps the ObjectARX method. 
This method sets the function to call to get the string for this grip's tooltip.
```text
public virtual string GetTooltip();
```

### OnGripStatusChanged

#### Description
This is OnGripStatusChanged, a member of class GripData.
```text
public virtual void OnGripStatusChanged(
    ObjectId entityId, 
    Status newStatus
);
```

### OnHotGrip

#### Description
This .NET method wraps the ObjectARX method.
```text
public virtual ReturnValue OnHotGrip(
    ObjectId entityId, 
    Context contextFlags
);
```

### OnHover

#### Description
This is OnHover, a member of class GripData.
```text
public virtual ReturnValue OnHover(
    ObjectId entityId, 
    Context contextFlags
);
```

### OnRightClick

#### Description
This is OnRightClick, a member of class GripData.
```text
public virtual IEnumerable<IMenuItem> OnRightClick(
    GripDataCollection hotGrips, 
    ObjectIdCollection entities
);
```

### ViewportDraw

#### Description
This .NET method wraps the ObjectARX method.
```text
public virtual bool ViewportDraw(
    Autodesk.AutoCAD.GraphicsInterface.ViewportDraw worldDraw, 
    ObjectId entityId, 
    DrawType type, 
    Point3d? imageGripPoint, 
    int gripSizeInPixels
);
```

### WorldDraw

#### Description
This .NET method wraps the ObjectARX method. 
This function returns a pointer to the callback that draws this grip's non-viewport-specific custom grip glyph graphics. The returned value may be null.
```text
public virtual bool WorldDraw(
    Autodesk.AutoCAD.GraphicsInterface.WorldDraw worldDraw, 
    ObjectId entityId, 
    DrawType type, 
    Point3d? imageGripPoint, 
    double dGripSize
);
```

### AutoCAD.DatabaseServices.GripData.Context Enumeration

#### Description
This is record Autodesk.AutoCAD.DatabaseServices.GripData.Context.
```text
public enum Context {
  MultiHotGrip = 2,
  SharedGrip = 1
}
```

### AutoCAD.DatabaseServices.GripData.DrawType Enumeration

#### Description
This is record Autodesk.AutoCAD.DatabaseServices.GripData.DrawType.
```text
public enum DrawType {
  WarmGrip,
  HoverGrip,
  HotGrip,
  DragImageGrip
}
```

### AutoCAD.DatabaseServices.GripData.ReturnValue Enumeration

#### Description
This is record Autodesk.AutoCAD.DatabaseServices.GripData.ReturnValue.
```text
public enum ReturnValue {
  Ok,
  Failure,
  NoRedrawGrip,
  GripHotToWarm,
  GetNewGripPoints
}
```

### AutoCAD.DatabaseServices.GripData.Status Enumeration

#### Description
This is record Autodesk.AutoCAD.DatabaseServices.GripData.Status.
```text
public enum Status {
  GripStart,
  GripEnd,
  GripAbort,
  Stretch,
  Move,
  Rotate,
  Scale,
  Mirror,
  DimFocusChanged,
  PopUpMenu
}
```


## Properties Details

### AlternateBasePoint

#### Description
This is AlternateBasePoint, a member of class GripData.
```text
public Point3d? AlternateBasePoint;
```

### DrawAtDragImageGripPoint

#### Description
This is DrawAtDragImageGripPoint, a member of class GripData.
```text
public bool DrawAtDragImageGripPoint;
```

### ForcedPickOn

#### Description
This is ForcedPickOn, a member of class GripData.
```text
public bool ForcedPickOn;
```

### GizmosEnabled

#### Description
This is GizmosEnabled, a member of class GripData.
```text
public bool GizmosEnabled;
```

### GripPoint

#### Description
This is GripPoint, a member of class GripData.
```text
public Point3d GripPoint;
```

### HotGripInvokesRightClick

#### Description
This is HotGripInvokesRightClick, a member of class GripData.
```text
public bool HotGripInvokesRightClick;
```

### IsPerViewport

#### Description
This is IsPerViewport, a member of class GripData.
```text
public bool IsPerViewport;
```

### ModeKeywordsDisabled

#### Description
This is ModeKeywordsDisabled, a member of class GripData.
```text
public bool ModeKeywordsDisabled;
```

### RubberBandLineDisabled

#### Description
This is RubberBandLineDisabled, a member of class GripData.
```text
public bool RubberBandLineDisabled;
```

### SkipWhenShared

#### Description
This is SkipWhenShared, a member of class GripData.
```text
public bool SkipWhenShared;
```

### TriggerGrip

#### Description
This is TriggerGrip, a member of class GripData.
```text
public bool TriggerGrip;
```
