# ObjectSnapInfo Class

## Overview

#### Description
This class represents the output parameters of CustomOsnapInfo.getOsnapInfo() ObjectARX function.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ObjectSnapInfo
```

```text
public sealed class ObjectSnapInfo;
```

### Properties

- [SnapCurves](#snapcurves)
- [SnapPoints](#snappoints)


## Properties Details

### SnapCurves

#### Description
Accesses the pre-existing collection to append osnap curves to (may already contain curves)
```text
public Curve3dCollection SnapCurves;
```

#### Conditions
Read-only
### SnapPoints

#### Description
Accesses the pre-existing snap points.
```text
public Point3dCollection SnapPoints;
```

#### Conditions
Read-only