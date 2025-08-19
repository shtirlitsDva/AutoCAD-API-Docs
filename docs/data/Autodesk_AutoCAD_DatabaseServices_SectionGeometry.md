# Autodesk.AutoCAD.DatabaseServices.SectionGeometry Enumeration

## Overview

#### Description
This .NET enum wraps the AcDbSectionSettings::Geometry ObjectARX enum. It gives options for section generation. This enum is used to get and set properties for generated section geometry.
```text
public enum SectionGeometry {
  BackgroundGeometry = 4,
  CurveTangencyLines = 0x10,
  ForegroundGeometry = 8,
  IntersectionBoundary = 1,
  IntersectionFill = 2
}
```

#### Members

| Members | Description |
| --- | --- |
| BackgroundGeometry = 4 | Background geometry settings. |
| CurveTangencyLines = 0x10 | Curve tangency line settings. |
| ForegroundGeometry = 8 | Foreground geometry settings. |
| IntersectionBoundary = 1 | Intersection boundary settings. |
| IntersectionFill = 2 | Intersection surface settings. |