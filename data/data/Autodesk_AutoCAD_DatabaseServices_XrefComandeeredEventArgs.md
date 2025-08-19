# XrefComandeeredEventArgs Class

## Overview

#### Description
This class provides data for the XrefComandeered event of the database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.XrefComandeeredEventArgs
```

```text
public sealed class XrefComandeeredEventArgs : EventArgs;
```

### Properties

- [From](#from)
- [Id](#id)


## Properties Details

### From

#### Description
Gets the database being xrefed.
```text
public Database From;
```

#### Conditions
Read / Write
### Id

#### Description
Gets the object ID of the object being commandeered.
```text
public ObjectId Id;
```

#### Conditions
Read / Write