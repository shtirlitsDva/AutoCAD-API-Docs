# DecomposeForSaveReplacementRecord Structure

## Overview

#### Description
This class encapsulates the three output parameters used by the Object.decomposeForSave() ObjectARX function. These values represent the replacement object if it is non-database-resident, the replacement object's object ID if it is database-resident, and a flag indicating whether xdata should be transferred to the replacement object.
```text
public struct DecomposeForSaveReplacementRecord {
}
```

### Constructors

- [DecomposeForSaveReplacementRecord](#decomposeforsavereplacementrecord)

### Properties

- [ExchangeXData](#exchangexdata)
- [ReplacementId](#replacementid)
- [ReplacementObject](#replacementobject)


## Constructors Details

### DecomposeForSaveReplacementRecord

#### Description
Constructor which sets the replacement as a DBObject, and whether Xdata should be exchanged.
```text
public DecomposeForSaveReplacementRecord(
    DBObject replacement, 
    [MarshalAs(UnmanagedType.U1)] bool exchangeXData
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DBObject replacement | Input Autodesk.AutoCAD.DatabaseServices.DBObject object |
| [MarshalAs(UnmanagedType.U1)] bool exchangeXData | Input System.Boolean object |

### ExchangeXData

#### Description
Accessesthe exchange xdata property value.
```text
public bool ExchangeXData;
```

#### Conditions
Read-only
### ReplacementId

#### Description
Accesses the replacement id property value.
```text
public ObjectId ReplacementId;
```

#### Conditions
Read-only
### ReplacementObject

#### Description
Accesses the replacement object property value.
```text
public DBObject ReplacementObject;
```

#### Conditions
Read-only