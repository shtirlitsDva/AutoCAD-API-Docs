# PointCloudClassificationColorRamp Class

## Overview

#### Description
This is class Autodesk.AutoCAD.DatabaseServices.PointCloudClassificationColorRamp.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.PointCloudClassificationColorRamp
```

```text
public class PointCloudClassificationColorRamp : DisposableWrapper;
```

### Constructors

- [PointCloudClassificationColorRamp](#pointcloudclassificationcolorramp)

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

### PointCloudClassificationColorRamp

#### Description
This is PointCloudClassificationColorRamp, a member of class PointCloudClassificationColorRamp.
```text
public PointCloudClassificationColorRamp();
```

### Color

#### Description
This is Color, a member of class PointCloudClassificationColorRamp.
```text
public virtual EntityColor Color(
    int c
);
```

### DeleteUnmanagedObject

#### Description
This is DeleteUnmanagedObject, a member of class PointCloudClassificationColorRamp.
```text
protected override void DeleteUnmanagedObject();
```

### SetColor

#### Description
This is SetColor, a member of class PointCloudClassificationColorRamp.
```text
public virtual void SetColor(
    int c, 
    EntityColor color
);
```

### SetFrom

#### Description
This is SetFrom, a member of class PointCloudClassificationColorRamp.
```text
public virtual void SetFrom(
    PointCloudClassificationColorRamp source
);
```

### SetVisibility

#### Description
This is SetVisibility, a member of class PointCloudClassificationColorRamp.
```text
public virtual void SetVisibility(
    int c, 
    [MarshalAs(UnmanagedType.U1)] bool bVisible
);
```

### Visibility

#### Description
This is Visibility, a member of class PointCloudClassificationColorRamp.
```text
public virtual bool Visibility(
    int c
);
```

### Name

#### Description
This is Name, a member of class PointCloudClassificationColorRamp.
```text
public virtual string Name;
```

### NumColors

#### Description
This is NumColors, a member of class PointCloudClassificationColorRamp.
```text
public virtual int NumColors;
```
