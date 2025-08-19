# MeshPointMaps Structure

## Overview

#### Description
This class acts as a wrapper for a GeoMesh.
```text
public struct MeshPointMaps {
}
```

### Constructors

- [MeshPointMaps](#meshpointmaps)

### Properties

- [DestPonints](#destponints)
- [SourcePonints](#sourceponints)


## Constructors Details

### MeshPointMaps

#### Description
Constructor sets the default values.
```text
public MeshPointMaps(
    Point2dCollection sourcePts, 
    Point2dCollection destPts
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point2dCollection sourcePts | Input source points collection |
| Point2dCollection destPts | Input destination points collection |

### DestPonints

#### Description
Accesses the destination points collection.
```text
public Point2dCollection DestPonints;
```

#### Conditions
Read / Write
### SourcePonints

#### Description
Accesses the source points collection.
```text
public Point2dCollection SourcePonints;
```

#### Conditions
Read / Write