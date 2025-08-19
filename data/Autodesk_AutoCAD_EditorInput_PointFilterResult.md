# PointFilterResult Class

## Overview

#### Description
This class provides output data for the PointFilter event. It wraps the output parameters of the AcEdInputPointFilter.processInputPoint() ObjectARX function.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PointFilterResult
```

```text
public sealed class PointFilterResult : IDisposable;
```

### Properties

- [DisplayObjectSnapGlyph](#displayobjectsnapglyph)
- [NewPoint](#newpoint)
- [Retry](#retry)
- [ToolTipText](#tooltiptext)


## Properties Details

### DisplayObjectSnapGlyph

#### Description
If true, AutoCAD will display the osnap glyph, even in the case the computed point has been changed by the application.
```text
public bool DisplayObjectSnapGlyph;
```

#### Conditions
Read / Write
### NewPoint

#### Description
Returns the new point if changedPoint is true.
```text
public Point3d NewPoint;
```

#### Conditions
Read / Write
### Retry

#### Description
Returns a Boolean indicating whether to force the user to try again.
```text
public bool Retry;
```

#### Conditions
Read / Write
### ToolTipText

#### Description
Returns the tool tip string.
```text
public string ToolTipText;
```

#### Conditions
Read / Write