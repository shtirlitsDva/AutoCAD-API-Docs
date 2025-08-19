# ObjectSnapContext Class

## Overview

#### Description
This class represents the input parameters of the CustomOsnapInfo.getOsnapInfo() ObjectARX function.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ObjectSnapContext
```

```text
public sealed class ObjectSnapContext;
```

### Properties

- [GraphicsSystemSelectionMark](#graphicssystemselectionmark)
- [LastPoint](#lastpoint)
- [PickedObject](#pickedobject)
- [PickPoint](#pickpoint)
- [ViewTransform](#viewtransform)


## Properties Details

### GraphicsSystemSelectionMark

#### Description
Accesses the graphic system marker of the subentity involved in the object snap operation.
```text
public int GraphicsSystemSelectionMark;
```

#### Conditions
Read-only
### LastPoint

#### Description
Accesses the point (in WCS coordinates) selected just before PickPoint
```text
public Point3d LastPoint;
```

#### Conditions
Read-only
### PickedObject

#### Description
Accesses the entity involved in the object snap operation.
```text
public Entity PickedObject;
```

#### Conditions
Read-only
### PickPoint

#### Description
Accesses the point (in WCS coordinates) picked during the object snap operation.
```text
public Point3d PickPoint;
```

#### Conditions
Read-only
### ViewTransform

#### Description
Accesses the transformation matrix to transform from WCS to DCS.
```text
public Matrix3d ViewTransform;
```

#### Conditions
Read-only