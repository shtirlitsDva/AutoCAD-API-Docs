# PlotStyleTableChangedEventArgs Class

## Overview

#### Description
This class provides data for PlotStyleTableChanged event of the LayoutManager class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.PlotStyleTableChangedEventArgs
```

```text
public sealed class PlotStyleTableChangedEventArgs : EventArgs;
```

### Properties

- [Id](#id)
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
### NewName

#### Description
Accesses the name of the plot style table that is newly associated with the layout denoted by Id.
```text
public string NewName;
```

#### Conditions
Read-only