# BlockInsertionPointsEventArgs Class

## Overview

#### Description
This class provides data for the BlockInsertionPoints event of the database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.BlockInsertionPointsEventArgs
```

```text
public class BlockInsertionPointsEventArgs : EventArgs;
```

### Constructors

- [BlockInsertionPointsEventArgs](#blockinsertionpointseventargs)

### Properties

- [AlignmentVectors](#alignmentvectors)
- [BlockTableRecord](#blocktablerecord)
- [InsertionPoints](#insertionpoints)


## Constructors Details

### BlockInsertionPointsEventArgs

#### Description
Constructor.
```text
public BlockInsertionPointsEventArgs(
    Autodesk.AutoCAD.DatabaseServices.BlockTableRecord blockTableRecord, 
    Point3dCollection points, 
    Vector3dCollection alignmentVectors
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.BlockTableRecord blockTableRecord | Input block table record to insert at |
| Point3dCollection points | Input the points to insert |
| Vector3dCollection alignmentVectors | Input the vectors to align against |

### AlignmentVectors

#### Description
Accesses the AlignmentVectors property value.
```text
public Vector3dCollection AlignmentVectors;
```

#### Conditions
Read-only
### BlockTableRecord

#### Description
Accesses the BlockTableRecord property value.
```text
public Autodesk.AutoCAD.DatabaseServices.BlockTableRecord BlockTableRecord;
```

#### Conditions
Read-only
### InsertionPoints

#### Description
Accesses the InsertionPoints property value.
```text
public Point3dCollection InsertionPoints;
```

#### Conditions
Read-only