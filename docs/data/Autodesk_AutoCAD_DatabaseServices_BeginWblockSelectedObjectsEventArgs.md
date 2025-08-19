# BeginWblockSelectedObjectsEventArgs Class

## Overview

#### Description
This class provides data for the BeginWblockSelectedObjects event of the database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.BeginWblockSelectedObjectsEventArgs
```

```text
public sealed class BeginWblockSelectedObjectsEventArgs : EventArgs;
```

### Properties

- [From](#from)
- [InsertionPoint](#insertionpoint)


## Properties Details

### From

#### Description
Gets the database being wblock'ed.
```text
public Database From;
```

#### Conditions
Read-only
### InsertionPoint

#### Description
Gets the insertion point chosen by the user at the beginning of the wblock operation.
```text
public Point3d InsertionPoint;
```

#### Conditions
Read-only