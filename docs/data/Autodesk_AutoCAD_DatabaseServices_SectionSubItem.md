# Autodesk.AutoCAD.DatabaseServices.SectionSubItem Enumeration

## Overview

#### Description
This .NET class wraps the AcDbSection::SubItem ObjectARX class. 
It gives the hit flags for section plane. This enum value is returned by the method hitTest>.
```text
public enum SectionSubItem {
  BackLine = 8,
  BackLineBottom = 0x20,
  BackLineTop = 0x10,
  SectionLine = 1,
  SectionLineBottom = 4,
  SectionLineTop = 2,
  SectionSubItemNone = 0,
  VerticalLineBottom = 0x80,
  VerticalLineTop = 0x40
}
```

#### Members

| Members | Description |
| --- | --- |
| BackLine = 8 | The hit test point is on one of the back lines at the section line level. |
| BackLineBottom = 0x20 | The hit test point is on one of the back lines at the bottom line level. |
| BackLineTop = 0x10 | The hit test point is on one of the back lines at the top line level. |
| SectionLine = 1 | The hit test point is on the section line. |
| SectionLineBottom = 4 | The hit test point is on the bottom line of the section plane. |
| SectionLineTop = 2 | The hit test point is on the top line of the section plane. |
| SectionSubItemNone = 0 | The hit test point is not on the section plane. |
| VerticalLineBottom = 0x80 | The hit test point is on one of the vertical lines on bottom half of the section plane. |
| VerticalLineTop = 0x40 | The hit test point is on one of the vertical lines on top half of the section plane. |