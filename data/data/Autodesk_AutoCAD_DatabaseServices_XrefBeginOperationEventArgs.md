# XrefBeginOperationEventArgs Class

## Overview

#### Description
This class provides data for the XrefBeginRestore, XrefBeginAttached and XrefBeginOtherAttached events of the database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.XrefBeginOperationEventArgs
```

```text
public sealed class XrefBeginOperationEventArgs : EventArgs;
```

### Properties

- [FileName](#filename)
- [From](#from)


## Properties Details

### FileName

#### Description
Gets the name of the file being xrefed.
```text
public string FileName;
```

#### Conditions
Read-only
### From

#### Description
Gets the database being xref.
```text
public Database From;
```

#### Conditions
Read-only