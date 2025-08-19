# PointFilterEventArgs Class

## Overview

#### Description
This class provides data for the PointFilter event.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PointFilterEventArgs
```

```text
public sealed class PointFilterEventArgs : EventArgs, IDisposable;
```

### Properties

- [CallNext](#callnext)
- [Context](#context)
- [Result](#result)


## Properties Details

### CallNext

#### Description
Gets or sets a value that determines whether the next point filter is called to do further filtering. 
True if the next filter is to be called, otherwise false.
```text
public bool CallNext;
```

#### Conditions
Read-only
### Context

#### Description
Gets an object that provides input data for this event. 
```text
public InputPointContext Context;
```

#### Conditions
Read-only
### Result

#### Description
Gets an object whose properties and methods can be used to set the result of this event.
```text
public PointFilterResult Result;
```

#### Conditions
Read-only