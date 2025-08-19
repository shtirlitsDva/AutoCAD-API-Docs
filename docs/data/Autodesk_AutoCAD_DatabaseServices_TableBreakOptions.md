# Autodesk.AutoCAD.DatabaseServices.TableBreakOptions Enumeration

## Overview

#### Description
This .NET class wraps the AcDb::TableBreakOptions ObjectARX class. It gives the table break options.
```text
public enum TableBreakOptions {
  AllowManualHeights = 0x10,
  AllowManualPositions = 8,
  EnableBreaking = 1,
  None = 0,
  RepeatBottomLabels = 4,
  RepeatTopLabels = 2
}
```

#### Members

| Members | Description |
| --- | --- |
| AllowManualHeights = 0x10 | Allow setting of maximum height for individual tables. |
| AllowManualPositions = 8 | Allow manual positioning of all tables individually. |
| EnableBreaking = 1 | Enable table breaking. |
| None = 0 | No table break. |
| RepeatBottomLabels = 4 | Repeat bottom labels in all tables. |
| RepeatTopLabels = 2 | Repeat top labels in all tables. |