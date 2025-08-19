# DataLink Class

## Overview

#### Description
This .NET class wraps the AcDbDataLink ObjectARX class. 
It manages the connection information for establishing a data link between a table in a drawing to an external data source.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.DataLink
```

```text
public sealed class DataLink : DBObject;
```

### Constructors

- [DataLink](#datalink)

### Methods

- [GetSourceFiles](#getsourcefiles)
- [GetTargets](#gettargets)
- [GetUpdateStatus](#getupdatestatus)
- [RepathSourceFiles](#repathsourcefiles)
- [Update](#update)

### Properties

- [ConnectionString](#connectionstring)
- [DataAdapterId](#dataadapterid)
- [DataLinkOption](#datalinkoption)
- [Description](#description)
- [IsValid](#isvalid)
- [Name](#name)
- [ToolTip](#tooltip)
- [UpdateOption](#updateoption)


## Constructors Details

### DataLink

#### Description
Default constructor.
```text
public DataLink();
```

### GetSourceFiles

#### Description
Returns the external source files on which the data link is dependent.
```text
public ArrayList GetSourceFiles(
    Autodesk.AutoCAD.DatabaseServices.DataLinkGetSourceContext nContext
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.DataLinkGetSourceContext nContext | Context in which this method is called |

### GetTargets

#### Description
Returns the IDs of the entities which use this data link.
```text
public ObjectIdCollection GetTargets();
```

### GetUpdateStatus

#### Description
Returns the status of the last update.
```text
public Autodesk.AutoCAD.Runtime.ErrorStatus GetUpdateStatus(
    out Autodesk.AutoCAD.DatabaseServices.UpdateDirection pDir, 
    out DateTime pTime, 
    [Out] string errMessage
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| out Autodesk.AutoCAD.DatabaseServices.UpdateDirection pDir | Stores the direction of the last update. |
| out DateTime pTime | Stores the time of the last update. |
| [Out] string errMessage | Stores the error message of the last update. |

### RepathSourceFiles

#### Description
Repaths the path references to the external source files.
```text
public void RepathSourceFiles(
    string sBasePath, 
    Autodesk.AutoCAD.DatabaseServices.PathOption nOption
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string sBasePath | The base path |
| Autodesk.AutoCAD.DatabaseServices.PathOption nOption | The path option |

### Update

#### Description
Updates the data from source or the source from data.
```text
public void Update(
    Autodesk.AutoCAD.DatabaseServices.UpdateDirection dir, 
    Autodesk.AutoCAD.DatabaseServices.UpdateOption option
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.UpdateDirection dir | Direction of update |
| Autodesk.AutoCAD.DatabaseServices.UpdateOption option | Update options |

### ConnectionString

#### Description
Accesses the connection string which describes the data source.
```text
public virtual string ConnectionString;
```

#### Conditions
Read / Write
### DataAdapterId

#### Description
Accesses the data adapter ID.
```text
public virtual string DataAdapterId;
```

#### Conditions
Read / Write
### DataLinkOption

#### Description
Accesses the data link option.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.DataLinkOption DataLinkOption;
```

#### Conditions
Read / Write
### Description

#### Description
Accesses the data link description.
```text
public virtual string Description;
```

#### Conditions
Read / Write
### IsValid

#### Description
Accesses if the data link is valid and can be used to update data.
```text
public virtual bool IsValid;
```

#### Conditions
Read / Write
### Name

#### Description
Accesses the name of the data link.
```text
public virtual string Name;
```

#### Conditions
Read / Write
### ToolTip

#### Description
Accesses the data link tool tip string.
```text
public virtual string ToolTip;
```

#### Conditions
Read / Write
### UpdateOption

#### Description
Accesses the update option.
```text
public virtual int UpdateOption;
```

#### Conditions
Read / Write