# PointMonitorEventArgs Class

## Overview

#### Description
This class provides data for the PointMonitor event.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PointMonitorEventArgs
```

```text
public sealed class PointMonitorEventArgs : EventArgs, IDisposable;
```

### Methods

- [AppendToolTipText](#appendtooltiptext)

### Properties

- [Context](#context)


## Methods Details

### AppendToolTipText

#### Description
Appends tool tip text value to this event.
```text
public void AppendToolTipText(
    string value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string value | Input item to be appended. |

### Context

#### Description
Gets an object that provides input data for this event.
```text
public InputPointContext Context;
```

#### Conditions
Read-only