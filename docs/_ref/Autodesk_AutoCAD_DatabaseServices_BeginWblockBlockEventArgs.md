# BeginWblockBlockEventArgs Class

## Overview

#### Description
This class provides data for the BeginWblockBlock event of the database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.BeginWblockBlockEventArgs
```

```text
public sealed class BeginWblockBlockEventArgs : EventArgs;
```

### Properties

- [BlockId](#blockid)
- [From](#from)


## Properties Details

### BlockId

#### Description
Gets the object ID of the block being wblock'ed.
```text
public ObjectId BlockId;
```

#### Conditions
Read-only
### From

#### Description
Gets the database being wblock'ed.
```text
public Database From;
```

#### Conditions
Read-only