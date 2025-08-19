# XrefRedirectedEventArgs Class

## Overview

#### Description
This class provides data for the XrefRedirected event of the database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.XrefRedirectedEventArgs
```

```text
public sealed class XrefRedirectedEventArgs : EventArgs;
```

### Properties

- [NewId](#newid)
- [OldId](#oldid)


## Properties Details

### NewId

#### Description
Gets the object ID of the symbol table record that the xref symbol table record is redirected to.
```text
public ObjectId NewId;
```

#### Conditions
Read-only
### OldId

#### Description
Gets the object ID of the symbol table record in the xref that is being redirected.
```text
public ObjectId OldId;
```

#### Conditions
Read-only