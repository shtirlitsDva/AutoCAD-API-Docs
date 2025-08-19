# HighlightStateOverrule Class

## Overview

#### Description
This wraps the ObjectARX [AcDbHighlightStateOverrule](AcDbHighlightStateOverrule.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.HighlightStateOverrule
```

```text
public abstract class HighlightStateOverrule : Overrule;
```

### Methods

- [HighlightState](#highlightstate)
- [PopHighlight](#pophighlight)
- [PushHighlight](#pushhighlight)


## Methods Details

### HighlightState

#### Description
this wraps the ObjectARX [AcDbHighlightStateOverrule::highlightState](AcDbHighlightStateOverrule__highlightState@AcDbEntity_@AcDbFullSubentPath_.md)() method.
```text
public virtual HighlightStyle HighlightState(
    Entity entity, 
    FullSubentityPath subId
);
```

### PopHighlight

#### Description
This wraps the ObjectARX [AcDbHighlightStateOverrule::popHighlight](AcDbHighlightStateOverrule__popHighlight@AcDbEntity_@AcDbFullSubentPath_.md)( AcDbEntity* pSubject, const AcDbFullSubentPath& subId) method.
```text
public virtual void PopHighlight(
    Entity entity, 
    FullSubentityPath subId
);
```

### PushHighlight

#### Description
This wraps the ObjectARX [AcDbHighlightStateOverrule::pushHighlight](AcDbHighlightStateOverrule__pushHighlight@AcDbEntity_@AcDbFullSubentPath_@AcGiHighlightStyle.md)() method.
```text
public virtual void PushHighlight(
    Entity entity, 
    FullSubentityPath subId, 
    HighlightStyle highlightStyle
);
```
