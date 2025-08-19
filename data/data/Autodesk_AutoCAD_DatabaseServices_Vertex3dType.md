# Autodesk.AutoCAD.DatabaseServices.Vertex3dType Enumeration

## Overview

#### Description
This .NET class wraps the [AcDb::Vertex3dType](AcDb__Vertex3dType.md) ObjectARX class. 
It lists the type of vertex 3D polylines.
```text
public enum Vertex3dType {
  SimpleVertex,
  ControlVertex,
  FitVertex
}
```

#### Members
| Members | Description |
| --- | --- |
| SimpleVertex | A standard vertex within a 3D polyline. |
| ControlVertex | Creates a control point for a polyline. |
| FitVertex | A vertex that was automatically generated as the result of a curve-fit operation. |