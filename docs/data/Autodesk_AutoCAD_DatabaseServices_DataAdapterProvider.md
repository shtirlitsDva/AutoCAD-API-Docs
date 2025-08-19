# DataAdapterProvider Class

## Overview

#### Description
This .NET class wraps the AcDbDataAdapterProvider ObjectARX class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DataAdapterProvider
```

```text
public abstract class DataAdapterProvider : RXObject;
```

### Constructors

- [DataAdapterProvider](#dataadapterprovider)

### Methods

- [GetDataAdapter](#getdataadapter)


## Constructors Details

### DataAdapterProvider

#### Description
Default constructor.
```text
protected DataAdapterProvider();
```

### GetDataAdapter

#### Description
Returns the data adapter based on its ID.
```text
public abstract DataAdapter GetDataAdapter(
    string adapterId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string adapterId | Input ID to check for |

#### Conditions
Read-only Accesses the pre-existing