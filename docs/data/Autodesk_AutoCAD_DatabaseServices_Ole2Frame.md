# Ole2Frame Class

## Overview

#### Description
This .NET class wraps the AcDbOle2Frame ObjectARX class. 
This class provides support for OLE 2 objects in AutoCAD drawings. Essentially it provides a window to display the OLE 2 object it has a pointer to.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Ole2Frame
```

```text
public class Ole2Frame : Entity;
```

### Constructors

- [Ole2Frame](#ole2frame)

### Other

- [AutoCAD.DatabaseServices.Ole2Frame.ItemType Enumeration](#autocad.databaseservices.ole2frame.itemtype-enumeration)

### Properties

- [AutoOutputQuality](#autooutputquality)
- [IsLinked](#islinked)
- [LinkName](#linkname)
- [LinkPath](#linkpath)
- [Location](#location)
- [LockAspect](#lockaspect)
- [OleObject](#oleobject)
- [OutputQuality](#outputquality)
- [Position2d](#position2d)
- [Position3d](#position3d)
- [Rotation](#rotation)
- [ScaleHeight](#scaleheight)
- [ScaleWidth](#scalewidth)
- [Type](#type)
- [UserType](#usertype)
- [WcsHeight](#wcsheight)
- [WcsWidth](#wcswidth)


## Constructors Details

### Ole2Frame

#### Description
Default constructor. Objects constructed with this constructor must call OleObject to establish a valid OLE object to be used.
```text
public Ole2Frame();
```

### AutoCAD.DatabaseServices.Ole2Frame.ItemType Enumeration

#### Description
Defines the item type in the frame.
```text
public enum ItemType {
  Embedded = 2,
  Link = 1,
  Static = 3
}
```


## Properties Details

### AutoOutputQuality

#### Description
Accesses the whether the plot quality setting is Automatically Select in the Properties palette.
```text
public byte AutoOutputQuality;
```

#### Conditions
Read / Write
### IsLinked

#### Description
Assesses if the frame is linked.
```text
public virtual bool IsLinked;
```

#### Conditions
Read-only
### LinkName

#### Description
```text
public virtual string LinkName;
```

#### Conditions
Read-only 
Read-only
### LinkPath

#### Description
Accesses the path and file name to which the object is linked.
```text
public virtual string LinkPath;
```

#### Conditions
Read-only
### Location

#### Description
Accesses the WCS point that corresponds to the lower-left corner of the OLE display rectangle of the Ole2Frame object.
```text
public virtual Point3d Location;
```

#### Conditions
Read-only
### LockAspect

#### Description
Accesses the lock aspect ratio property, which affects the behavior of the OLE object when its size is changed. If the lock aspect ratio property is true, and a new value is entered for the object's width, height, scale width, or scale height, both the width and the height change uniformly.
```text
public bool LockAspect;
```

#### Conditions
Read / Write
### OleObject

#### Description
Accesses the MFC object currently used by the Ole2Frame object.
```text
public virtual object OleObject;
```

#### Conditions
Read / Write
### OutputQuality

#### Description
Accesses the current output quality assigned to this Ole2Frame object. Output quality affects the color depth and resolution at which the OLE object is plotted.
```text
public virtual byte OutputQuality;
```

#### Conditions
Read / Write
### Position2d

#### Description
Accesses the coordinates of the four corners of OLE object in the GDI coordinates of the current viewport.
```text
public virtual Rectangle Position2d;
```

#### Conditions
Read / Write
### Position3d

#### Description
Accesses the world coordinate system coordinates of the four corners of OLE object.
```text
public virtual Rectangle3d Position3d;
```

#### Conditions
Read / Write
### Rotation

#### Description
Accesses the rotation value, which users may change to any angle using the Properties window or the ROTATE command. The angle is returned in degrees.
```text
public double Rotation;
```

#### Conditions
Read / Write
### ScaleHeight

#### Description
Accesses the scale height, which represents the current object scale relative to the original scale from the default text size to the AutoCAD units scale. This is expressed as a percentage of the original scale. 
The scale height value may be affected by changes in the actual coordinates of the object during a manipulation command such as STRETCH, during grip editing that results in a resizing operation, or by changes to the height of the object in the Properties palette or the Text Size dialog.
```text
public double ScaleHeight;
```

#### Conditions
Read / Write
### ScaleWidth

#### Description
Accesses the scale width, which represents the current object scale relative to the original scale from the default text size to the AutoCAD units scale. This is expressed as a percentage of the original scale. 
The scale width value may be affected by changes in the actual coordinates of the object during a manipulation command such as STRETCH, during grip editing that results in a resizing operation, or by changes to the width of the object in the Properties palette or the Text Size dialog.
```text
public double ScaleWidth;
```

#### Conditions
Read / Write
### Type

#### Description
Accesses the OLE object's type.
```text
public virtual ItemType Type;
```

#### Conditions
Read-only
### UserType

#### Description
Accesses the user type string (for example "Paintbrush Bitmap") of the MFC object used by this Ole2Frame object.
```text
public virtual string UserType;
```

#### Conditions
Read / Write
### WcsHeight

#### Description
Accesses the actual height of the OLE object expressed in AutoCAD world coordinates. 
The WcsHeight value may be affected by changes in the actual coordinates of the object during a manipulation command such as STRETCH, during grip editing that results in a resizing operation, or by changes to the height of the object in the Properties palette or the Text Size dialog.
```text
public double WcsHeight;
```

#### Conditions
Read / Write
### WcsWidth

#### Description
Accesses the actual width of the OLE object expressed in AutoCAD world coordinates. 
The WcsWidth value may be affected by changes in the actual coordinates of the object during a manipulation command such as STRETCH, during grip editing that results in a resizing operation, or by changes to the width of the object in the Properties palette or the Text Size dialog.
```text
public double WcsWidth;
```

#### Conditions
Read / Write