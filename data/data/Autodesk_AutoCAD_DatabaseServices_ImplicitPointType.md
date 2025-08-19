# Autodesk.AutoCAD.DatabaseServices.ImplicitPointType Enumeration

## Overview

#### Description
The type of a constrained implicit point.
```text
public enum ImplicitPointType {
  StartImplicit,
  EndImplicit,
  MidImplicit,
  CenterImplicit,
  DefineImplicit
}
```

#### Members
| Members | Description |
| --- | --- |
| StartImplicit | Start point of bounded line, arc or bounded ellipse. |
| EndImplicit | End point of a bounded line (not valid for ray), arc or bounded ellipse. |
| MidImplicit | Mid point of a bounded line (not valid for ray) or arc. |
| CenterImplicit | Center point of a circle, arc, ellipse or bounded ellipse. |
| DefineImplicit | Define point of a parametric curve, currently only valid for spline control point. |