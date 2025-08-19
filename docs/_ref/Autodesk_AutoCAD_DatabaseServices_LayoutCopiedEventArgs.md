# LayoutCopiedEventArgs Class

## Overview

#### Description
This class provides data for LayoutCopied event of the LayoutManager class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.LayoutCopiedEventArgs
```

```text
public sealed class LayoutCopiedEventArgs : EventArgs;
```

### Properties

- [Id](#id)
- [Name](#name)
- [NewId](#newid)
- [NewName](#newname)


## Properties Details

### Id

#### Description
Accesses the object ID of the layout that is copied.
```text
public ObjectId Id;
```

#### Conditions
Read-only
### Name

#### Description
Accesses the name of the layout that is copied.
```text
public string Name;
```

#### Conditions
Read-only
### NewId

#### Description
Accesses the object ID of the new layout.
```text
public ObjectId NewId;
```

#### Conditions
Read-only
### NewName

#### Description
Accesses the name of the new layout.
```text
public string NewName;
```

#### Conditions
Read-only