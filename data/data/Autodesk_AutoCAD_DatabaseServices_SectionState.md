# Autodesk.AutoCAD.DatabaseServices.SectionState Enumeration

## Overview

#### Description
This .NET class wraps the AcDbSection::State ObjectARX class. It gives the type of section plane.
```text
public enum SectionState {
  Boundary = 2,
  Plane = 1,
  Volume = 4
}
```

#### Members
| Members | Description |
| --- | --- |
| Boundary = 2 | Section plane is bounded by the section line, two side lines, and a back line. However it extends infinitely up and down. |
| Plane = 1 | Section plane extends infinitely in all directions. |
| Volume = 4 | Section plane is bounded by the front, side, back, top, and bottom lines. |