# DatabaseIOEventArgs Class

## Overview

#### Description
This class provides data for the DwgFileOpened, BeginSave and SaveComplete events of the database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DatabaseIOEventArgs
```

```text
public sealed class DatabaseIOEventArgs : EventArgs;
```

### Properties

- [FileName](#filename)


## Properties Details

### FileName

#### Description
Accesses the name of the drawing file being operated on
```text
public string FileName;
```

#### Conditions
Read-only