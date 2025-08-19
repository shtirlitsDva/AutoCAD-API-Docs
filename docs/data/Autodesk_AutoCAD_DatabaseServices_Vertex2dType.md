# Autodesk.AutoCAD.DatabaseServices.Vertex2dType Enumeration

## Overview

#### Description
This .NET enum wraps the AcDb::Vertex2dType ObjectARX enum. 
It lists the type of vertex 2D polylines.
```text
public enum Vertex2dType {
  SimpleVertex,
  SplineControlVertex,
  SplineFitVertex,
  CurveFitVertex
}
```

#### Members

| Members | Description |
| --- | --- |
| SimpleVertex | A standard vertex within a 2D polyline. |
| SplineControlVertex | A control point for a spline or curve-fit polyline. |
| SplineFitVertex | A vertex that was automatically generated as the result of a spline-fit operation. This type of vertex can go away or change automatically during subsequent editing operations on the polyline. |
| CurveFitVertex | A vertex that was automatically generated as the result of a curve-fit operation. This type of vertex can go away or change automatically during subsequent editing operations on the polyline. |