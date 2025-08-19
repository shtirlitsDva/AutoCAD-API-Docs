# ProxyResurrectionCompletedEventArgs Class

## Overview

#### Description
This class provides data for the ProxyResurrectionCompleted event of the database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ProxyResurrectionCompletedEventArgs
```

```text
public sealed class ProxyResurrectionCompletedEventArgs : EventArgs;
```

### Properties

- [ApplicationName](#applicationname)
- [Ids](#ids)


## Properties Details

### ApplicationName

#### Description
Accesses the name of the application
```text
public string ApplicationName;
```

#### Conditions
Read-only
### Ids

#### Description
Accesses the objects that were resurrected.
```text
public ObjectIdCollection Ids;
```

#### Conditions
Read-only