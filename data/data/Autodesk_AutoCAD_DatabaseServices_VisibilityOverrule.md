# VisibilityOverrule Class

## Overview

#### Description
Wraps the ObjectARX [AcDbVisibilityOverrule](AcDbVisibilityOverrule.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.VisibilityOverrule
```

```text
public abstract class VisibilityOverrule : Overrule;
```

### Constructors

- [VisibilityOverrule](#visibilityoverrule)

### Methods

- [SetVisibility](#setvisibility)
- [Visibility](#visibility)


## Constructors Details

### VisibilityOverrule

#### Description
Default Constructor.
```text
protected internal VisibilityOverrule();
```

### SetVisibility

#### Description
Wraps the ObjectARX [AcDbVisibilityOverrule::setVisibility](AcDbVisibilityOverrule__setVisibility@AcDbEntity_@AcDb__Visibility@Adesk__Boolean.md)() method.
```text
public virtual void SetVisibility(
    Entity entity, 
    Autodesk.AutoCAD.DatabaseServices.Visibility newVal, 
    [MarshalAs(UnmanagedType.U1)] bool doSubents
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | An Autodesk.AutoCAD.DatabaseServices.Entity that this overrule is applied against. |
| Autodesk.AutoCAD.DatabaseServices.Visibility newVal | The new visibility state. |
| [MarshalAs(UnmanagedType.U1)] bool doSubents | Pass in true if the new value should apply to subentitites. |

### Visibility

#### Description
Wraps the ObjectARX [AcDbVisibilityOverrule::visibility](AcDbVisibilityOverrule__visibility@AcDbEntity_.md)() method.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.Visibility Visibility(
    Entity entity
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | An Autodesk.AutoCAD.DatabaseServices.Entity that this overrule is applied against. |

#### Returns
Returns the visibility state of the object being overruled.