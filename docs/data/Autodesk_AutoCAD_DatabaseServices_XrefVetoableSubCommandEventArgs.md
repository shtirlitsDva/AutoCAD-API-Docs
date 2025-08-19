# XrefVetoableSubCommandEventArgs Class

## Overview

#### Description
This class provides data for the XrefVetoableSubCommand event.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.XrefSubCommandEventArgs
    Autodesk.AutoCAD.DatabaseServices.XrefVetoableSubCommandEventArgs
```

```text
public sealed class XrefVetoableSubCommandEventArgs : XrefSubCommandEventArgs;
```

### Properties

- [abortOp](#abortop)


## Properties Details

### abortOp

#### Description
Returns a Boolean indicating whether the operation is aborted or not.
```text
public bool abortOp;
```

#### Conditions
Read / Write