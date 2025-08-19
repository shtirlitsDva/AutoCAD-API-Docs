# PlaneSurface Class

## Overview

#### Description
This .NET class wraps the AcDbPlaneSurface ObjectARX class. 
This class represents a plane surface entity. It provides methods to create and manipulate ASM surfaces.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Surface
            Autodesk.AutoCAD.DatabaseServices.PlaneSurface
```

```text
public class PlaneSurface : Surface;
```

### Constructors

- [PlaneSurface](#planesurface)

### Methods

- [CreateFromRegion](#createfromregion)


## Constructors Details

### PlaneSurface

#### Description
Default constructor.
```text
public PlaneSurface();
```

### CreateFromRegion

#### Description
Creates a plane surface from region.
```text
public virtual void CreateFromRegion(
    Region region
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Region region | Input pointer to any Region object |

#### Conditions
Read-only