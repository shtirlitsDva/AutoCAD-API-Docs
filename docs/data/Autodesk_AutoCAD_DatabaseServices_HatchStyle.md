# Autodesk.AutoCAD.DatabaseServices.HatchStyle Enumeration

## Overview

#### Description
This .NET class wraps the AcDbHatch::HatchStyle ObjectARX enum. 
AutoCAD currently supports three hatch styles, which are Normal, Outer, and Ignore. If there are no internal loops, specifying a hatching style has no effect on the resulting hatch.
```text
public enum HatchStyle {
  Normal,
  Outer,
  Ignore
}
```

#### Members

| Members | Description |
| --- | --- |
| Normal | Normal hatch style will hatch inward from the outer loop. If it encounters an internal intersection, it turns off hatching until it encounters another intersection. Thus, areas separated from the outside of the hatched area by an odd number of intersections are hatched, while areas separated by an even number of intersections are not. |
| Outer | Outer hatch style will hatch inward from the outer loop. It turns off hatching if it encounters an intersection and does not turn it back on. Because this process starts from both ends of each hatch line, only the outmost level of the structure is hatched, and the internal structure is left blank. |
| Ignore | Ignore hatch style will hatch inward from the outer loop and ignores all internal loops. |