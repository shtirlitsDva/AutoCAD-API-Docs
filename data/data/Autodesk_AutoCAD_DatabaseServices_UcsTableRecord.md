# UcsTableRecord Class

## Overview

#### Description
This .NET class wraps the AcDbUCSTableRecord ObjectARX class. 
Objects of this class represent records in the UcsTable. Each of these records contains the information about a user coordinate system (UCS) that has been saved in the drawing database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTableRecord
        Autodesk.AutoCAD.DatabaseServices.UcsTableRecord
```

```text
public class UcsTableRecord : SymbolTableRecord;
```

### Constructors

- [UcsTableRecord](#ucstablerecord)

### Methods

- [GetUcsBaseOrigin](#getucsbaseorigin)
- [SetUcsBaseOrigin](#setucsbaseorigin)

### Properties

- [Origin](#origin)
- [XAxis](#xaxis)
- [YAxis](#yaxis)


## Constructors Details

### UcsTableRecord

#### Description
Default constructor.
```text
public UcsTableRecord();
```

### GetUcsBaseOrigin

#### Description
Returns the origin point of the input orthographic view when UCSBASE is set to this UCS. For instance if this UCS is named "MYUCS" and UCSBASE is set to "MYUCS", then the command UCS/FRONT will change the UCS to the orthographic view "FRONT" (relative to MYUCS) and the origin of the new UCS will be the point that is returned by this function when called with the parameter FrontView.
```text
public Point3d GetUcsBaseOrigin(
    Autodesk.AutoCAD.DatabaseServices.OrthographicView view
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.OrthographicView view | Input orthographic view |

### SetUcsBaseOrigin

#### Description
Sets the origin point of the input orthographic view when UCSBASE is set to this UCS. For instance, if this UCS is named "MYUCS" and UCSBASE is set to "MYUCS", then after this function has been called the command UCS/FRONT will change the UCS to the orthographic view "FRONT" (relative to MYUCS) and the origin of the new UCS will be the origin point that is passed into this function with the second parameter set to FrontView.
```text
public void SetUcsBaseOrigin(
    Point3d origin, 
    Autodesk.AutoCAD.DatabaseServices.OrthographicView view
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d origin | Input origin point |
| Autodesk.AutoCAD.DatabaseServices.OrthographicView view | Input orthographic view |

### Origin

#### Description
Accesses the origin of the table record.
```text
public Point3d Origin;
```

#### Conditions
Read / Write
### XAxis

#### Description
Accesses the X-axis of the table record.
```text
public Vector3d XAxis;
```

#### Conditions
Read / Write
### YAxis

#### Description
Accesses the Y-axis of the table record.
```text
public Vector3d YAxis;
```

#### Conditions
Read / Write