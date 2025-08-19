# EntityAlignmentEventArgs Class

## Overview

#### Description
This class provides data for the EntityAlignment event.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.EntityAlignmentEventArgs
```

```text
public class EntityAlignmentEventArgs : EventArgs;
```

### Constructors

- [EntityAlignmentEventArgs](#entityalignmenteventargs)

### Methods

- [GetPickedEntities](#getpickedentities)

### Properties

- [ClosestPoint](#closestpoint)
- [Direction](#direction)
- [Entity](#entity)
- [Normal](#normal)
- [PickPoint](#pickpoint)


## Constructors Details

### EntityAlignmentEventArgs

#### Description
Constructor.
```text
public EntityAlignmentEventArgs(
    Autodesk.AutoCAD.DatabaseServices.Entity Entity, 
    Point3d PickPoint, 
    Vector3d Normal, 
    Point3d ClosestPoint, 
    Vector3d Direction, 
    FullSubentityPath\[\] Path
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.Entity Entity | Input Autodesk.AutoCAD.DatabaseServices.Entity object. |
| Point3d PickPoint | Input Autodesk.AutoCAD.Geometry.Point3d object. |
| Vector3d Normal | Input Autodesk.AutoCAD.Geometry.Vector3d object. |
| Point3d ClosestPoint | Input Autodesk.AutoCAD.Geometry.Point3d object. |
| Vector3d Direction | Input Autodesk.AutoCAD.Geometry.Vector3d object. |
| FullSubentityPath[] Path | Input Autodesk.AutoCAD.DatabaseServices.FullSubentityPath[] object. |

### GetPickedEntities

#### Description
This method returns an array containing the full subentity paths of the picked entities.
```text
public FullSubentityPath\[\] GetPickedEntities();
```

### ClosestPoint

#### Description
Accesses the ClosestPoint property value.
```text
public Point3d ClosestPoint;
```

#### Conditions
Read / Write
### Direction

#### Description
Accesses the Direction property value.
```text
public Vector3d Direction;
```

#### Conditions
Read / Write
### Entity

#### Description
Accesses the Entity property value.
```text
public Autodesk.AutoCAD.DatabaseServices.Entity Entity;
```

#### Conditions
Read-only
### Normal

#### Description
Accesses the Normal property value.
```text
public Vector3d Normal;
```

#### Conditions
Read-only
### PickPoint

#### Description
Accesses the PickPoint property value.
```text
public Point3d PickPoint;
```

#### Conditions
Read / Write