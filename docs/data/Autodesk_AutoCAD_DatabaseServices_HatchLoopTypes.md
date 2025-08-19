# Autodesk.AutoCAD.DatabaseServices.HatchLoopTypes Enumeration

## Overview

#### Description
This .NET class wraps the AcDbHatch::HatchLoopType ObjectARX enum. 
The HatchLoopTypes enumeration is used to define the different types of bounding areas used in hatching.
```text
public enum HatchLoopTypes {
  Default = 0,
  Derived = 4,
  Duplicate = 0x100,
  External = 1,
  NotClosed = 0x20,
  Outermost = 0x10,
  Polyline = 2,
  SelfIntersecting = 0x40,
  Textbox = 8,
  TextIsland = 0x80
}
```

#### Members

| Members | Description |
| --- | --- |
| Default = 0 | The loop type hasn't been specified yet. It turns to a "real" value as soon as some real loops get created. |
| Derived = 4 | A loop that was derived by AutoCAD's boundary tracer from a picked point. |
| External = 1 | A loop that consists of external entities (derived from Entity and owned by an Database). The hatch might be associative to these entities. |
| NotClosed = 0x20 | A loop that is not closed. |
| Outermost = 0x10 | The outermost loop of this hatch. |
| Polyline = 2 | The hatch loop consists of a polyline ( geometry, not geometry). |
| SelfIntersecting = 0x40 | A loop that intersects with itself. |
| Textbox = 8 | A loop that consists of a box around an existing text object (Text). |
| TextIsland = 0x80 | Text loops that are surrounded by even number of outer loops. Text island loops are avoided when performing solid fill. |