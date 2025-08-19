# PointCloudColorRamp Class

## Overview

#### Description
This is class Autodesk.AutoCAD.DatabaseServices.PointCloudColorRamp.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.PointCloudColorRamp
```

```text
public class PointCloudColorRamp : DisposableWrapper;
```

### Constructors

- [PointCloudColorRamp](#pointcloudcolorramp)

### Methods

- [Color](#color)
- [DeleteUnmanagedObject](#deleteunmanagedobject)
- [SetColor](#setcolor)
- [SetFrom](#setfrom)
- [SetVisibility](#setvisibility)
- [Visibility](#visibility)

### Properties

- [Name](#name)
- [NumColors](#numcolors)


## Constructors Details

### PointCloudColorRamp

#### Description
This is PointCloudColorRamp, a member of class PointCloudColorRamp.
```text
public PointCloudColorRamp();
```

### Color

#### Description
This is Color, a member of class PointCloudColorRamp.
```text
public virtual EntityColor Color(
    int c
);
```

### DeleteUnmanagedObject

#### Description
This is DeleteUnmanagedObject, a member of class PointCloudColorRamp.
```text
protected override void DeleteUnmanagedObject();
```

### SetColor

#### Description
This is SetColor, a member of class PointCloudColorRamp.
```text
public virtual void SetColor(
    int c, 
    EntityColor color
);
```

### SetFrom

#### Description
This is SetFrom, a member of class PointCloudColorRamp.
```text
public virtual void SetFrom(
    PointCloudColorRamp source
);
```

### SetVisibility

#### Description
This is SetVisibility, a member of class PointCloudColorRamp.
```text
public virtual void SetVisibility(
    int c, 
    [MarshalAs(UnmanagedType.U1)] bool bVisible
);
```

### Visibility

#### Description
This is Visibility, a member of class PointCloudColorRamp.
```text
public virtual bool Visibility(
    int c
);
```

### Name

#### Description
This is Name, a member of class PointCloudColorRamp.
```text
public virtual string Name;
```

### NumColors

#### Description
This is NumColors, a member of class PointCloudColorRamp.
```text
public virtual int NumColors;
```
