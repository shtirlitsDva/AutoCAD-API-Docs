# XrefSubCommandEventArgs Class

## Overview

#### Description
This class provides data for the XrefSubCommand event.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.XrefSubCommandEventArgs
    Autodesk.AutoCAD.DatabaseServices.XrefVetoableSubCommandEventArgs
```

```text
public class XrefSubCommandEventArgs : EventArgs;
```

### Properties

- [btrIds](#btrids)
- [btrNames](#btrnames)
- [paths](#paths)
- [xrefOp](#xrefop)


## Properties Details

### btrIds

#### Description
Returns the block table record id collection.
```text
public ObjectIdCollection btrIds;
```

#### Conditions
Read-only
### btrNames

#### Description
Returns the block table record names.
```text
public string btrNames;
```

#### Conditions
Read-only
### paths

#### Description
Returns the path of block table records.
```text
public string paths;
```

#### Conditions
Read-only
### xrefOp

#### Description
Returns the xrefOp property value.
```text
public XrefOperation xrefOp;
```

#### Conditions
Read-only