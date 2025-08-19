# ObjectErasedEventArgs Class

## Overview

#### Description
This class provides data for the ObjectErased event of the Database class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ObjectErasedEventArgs
```

```text
public sealed class ObjectErasedEventArgs : EventArgs;
```

### Properties

- [DBObject](#dbobject)
- [Erased](#erased)


## Properties Details

### DBObject

#### Description
Accesses the object that is changed.
```text
public Autodesk.AutoCAD.DatabaseServices.DBObject DBObject;
```

#### Conditions
Read-only
### Erased

#### Description
Accesses a value indicating whether the object was erased or unerased.
```text
public bool Erased;
```

#### Conditions
Read / Write