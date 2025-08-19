# DataLinkManager Class

## Overview

#### Description
This .NET class wraps the AcDbDataLinkManager ObjectARX class. 
This class is used to manage the data links in a database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DataLinkManager
```

```text
public sealed class DataLinkManager : RXObject;
```

### Methods

- [AddDataLink](#adddatalink)
- [GetDataLink()](#getdatalink())
- [GetDataLink(string)](#getdatalink(string))
- [RemoveDataLink(ObjectId)](#removedatalink(objectid))
- [RemoveDataLink(string)](#removedatalink(string))
- [Update(Autodesk.AutoCAD.DatabaseServices.UpdateDirection, Autodesk.AutoCAD.DatabaseServices.UpdateOption)](#update(autodesk.autocad.databaseservices.updatedirection,-autodesk.autocad.databaseservices.updateoption))
- [Update(ObjectIdCollection, Autodesk.AutoCAD.DatabaseServices.UpdateDirection, Autodesk.AutoCAD.DatabaseServices.UpdateOption)](#update(objectidcollection,-autodesk.autocad.databaseservices.updatedirection,-autodesk.autocad.databaseservices.updateoption))

### Properties

- [DataLinkCount](#datalinkcount)


## Methods Details

### AddDataLink

#### Description
Adds the specified data link object to the manager.
```text
public ObjectId AddDataLink(
    DataLink dataLink
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DataLink dataLink | Data link object to add to the manager. |

### GetDataLink()

#### Description
Returns a collection of data links.
```text
public ObjectIdCollection GetDataLink();
```

### GetDataLink(string)

#### Description
Returns the object ID for the selected data link.
```text
public ObjectId GetDataLink(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Name of the data link to get. |

### RemoveDataLink(ObjectId)

#### Description
Removes the specified data link from the manager.
```text
public void RemoveDataLink(
    ObjectId idDataLink
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId idDataLink | Reference to the data link to remove. |

### RemoveDataLink(string)

#### Description
Removes the specified data link from the manager.
```text
public ObjectId RemoveDataLink(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Key to retrieve the data link. |

### Update(Autodesk.AutoCAD.DatabaseServices.UpdateDirection, Autodesk.AutoCAD.DatabaseServices.UpdateOption)

#### Description
Updates the data for all the data links.
```text
public void Update(
    Autodesk.AutoCAD.DatabaseServices.UpdateDirection direction, 
    Autodesk.AutoCAD.DatabaseServices.UpdateOption option
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.UpdateDirection direction | Update direction. |
| Autodesk.AutoCAD.DatabaseServices.UpdateOption option | Update options. |

### Update(ObjectIdCollection, Autodesk.AutoCAD.DatabaseServices.UpdateDirection, Autodesk.AutoCAD.DatabaseServices.UpdateOption)

#### Description
Updates the data for the specified data links.
```text
public void Update(
    ObjectIdCollection dataIds, 
    Autodesk.AutoCAD.DatabaseServices.UpdateDirection direction, 
    Autodesk.AutoCAD.DatabaseServices.UpdateOption option
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdCollection dataIds | Data link ids to update |
| Autodesk.AutoCAD.DatabaseServices.UpdateDirection direction | Update direction. |
| Autodesk.AutoCAD.DatabaseServices.UpdateOption option | Update options. |

### DataLinkCount

#### Description
Returns the number of data links.
```text
public int DataLinkCount;
```

#### Conditions
Read-only