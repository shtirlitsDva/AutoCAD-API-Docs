# LayoutEventArgs Class

## Overview

#### Description
This class provides data for various events of the LayoutManager class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.LayoutEventArgs
```

```text
public sealed class LayoutEventArgs : EventArgs;
```

### Properties

- [Id](#id)
- [Name](#name)


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