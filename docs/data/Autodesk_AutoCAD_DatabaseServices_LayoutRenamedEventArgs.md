# LayoutRenamedEventArgs Class

## Overview

#### Description
This class provides data for LayoutRenamed event of the LayoutManager class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.LayoutRenamedEventArgs
```

```text
public sealed class LayoutRenamedEventArgs : EventArgs;
```

### Properties

- [Id](#id)
- [Name](#name)
- [NewName](#newname)


## Properties Details

### Id

#### Description
Accesses the object ID of the layout that is changing.
```text
public ObjectId Id;
```

#### Conditions
Read-only
### Name

#### Description
Accesses the name of the layout that is changing.
```text
public string Name;
```

#### Conditions
Read-only
### NewName

#### Description
Accesses the new name of the layout.
```text
public string NewName;
```

#### Conditions
Read-only