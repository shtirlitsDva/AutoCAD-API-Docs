# BeginWblockObjectsEventArgs Class

## Overview

#### Description
This class provides data for the BeginWblockObjects event of the database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.BeginWblockObjectsEventArgs
```

```text
public sealed class BeginWblockObjectsEventArgs : EventArgs;
```

### Properties

- [From](#from)
- [IdMapping](#idmapping)


## Properties Details

### From

#### Description
Gets the database being wblock'ed.
```text
public Database From;
```

#### Conditions
Read-only
### IdMapping

#### Description
Get the IdMapping that maps the source objects to the destination objects.
```text
public Autodesk.AutoCAD.DatabaseServices.IdMapping IdMapping;
```

#### Conditions
Read-only