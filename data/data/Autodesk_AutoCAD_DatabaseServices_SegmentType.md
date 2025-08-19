# Autodesk.AutoCAD.DatabaseServices.SegmentType Enumeration

## Overview

#### Description
This .NET class wraps the AcDbPolyline::SegType ObjectARX class. This enumeration identifies the different types of line segments that can make up a polyline.
```text
public enum SegmentType {
  Line,
  Arc,
  Coincident,
  Point,
  Empty
}
```

#### Members
| Members | Description |
| --- | --- |
| Line | This is a non-zero length line segment. |
| Arc | This is a non-zero length arc segment. |
| Coincident | This is a zero-length segment. |
| Point | This is a single vertex polyline. |
| Empty | This entity has no vertices. |