# Autodesk.AutoCAD.DatabaseServices.GridLineType Enumeration

## Overview

#### Description
This .NET class wraps the [AcDb::GridLineType](AcDb__GridLineType.md) ObjectARX enum. These values describe the grid lines of a table.
```text
public enum GridLineType {
  AllGridLines = 0x3f,
  HorizontalBottom = 4,
  HorizontalGridLines = 7,
  HorizontalInside = 2,
  HorizontalTop = 1,
  InnerGridLines = 0x12,
  InvalidGridLine = 0,
  OuterGridLines = 0x2d,
  VerticalGridLines = 0x38,
  VerticalInside = 0x10,
  VerticalLeft = 8,
  VerticalRight = 0x20
}
```

#### Members
| Members | Description |
| --- | --- |
| AllGridLines = 0x3f | All grid line types |
| HorizontalBottom = 4 | The top or bottom horizontal grid line of the table, depending on flow direction. |
| HorizontalGridLines = 7 | Outer grid line types |
| HorizontalInside = 2 | All horizontal grid lines, excluding the top and bottom lines. |
| HorizontalTop = 1 | The top or bottom horizontal grid line of the table, depending on flow direction. |
| InnerGridLines = 0x12 | Inner grid line types |
| InvalidGridLine = 0 | Invalid. |
| OuterGridLines = 0x2d | Outer grid line types |
| VerticalGridLines = 0x38 | Vertical grid line types |
| VerticalInside = 0x10 | All vertical grid lines, excluding the ones on the far left and far right of the table. |
| VerticalLeft = 8 | The grid line at the far left of the table. |
| VerticalRight = 0x20 | The grid line at the far right of the table. |