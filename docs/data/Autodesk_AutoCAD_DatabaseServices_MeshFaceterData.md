# MeshFaceterData Structure

## Overview

#### Description
Faceter settings to be used with the [SubDMesh.GetObjectMesh Method](Autodesk_AutoCAD_DatabaseServices_SubDMesh_GetObjectMesh@DBObject@MeshFaceterData.md).
```text
public struct MeshFaceterData {
}
```

### Constructors

- [MeshFaceterData](#meshfaceterdata)

### Properties

- [FaceterDevNormal](#faceterdevnormal)
- [FaceterDevSurface](#faceterdevsurface)
- [FaceterGridRatio](#facetergridratio)
- [FaceterMaxEdgeLength](#facetermaxedgelength)
- [FaceterMaxGrid](#facetermaxgrid)
- [FaceterMeshType](#facetermeshtype)
- [FaceterMinUGrid](#faceterminugrid)
- [FaceterMinVGrid](#faceterminvgrid)


## Constructors Details

### MeshFaceterData

#### Description
Contructor.
```text
public MeshFaceterData(
    double surface, 
    double normal, 
    double gRatio, 
    double eLength, 
    ushort numGrid, 
    ushort uGrid, 
    ushort vGrid, 
    short mType
);
```

### FaceterDevNormal

#### Description
Accesses the faceter devNormal setting. This value is used (when subdividing the edges and also when placing the grid lines across the face) to control the angle between facets in the mesh.
```text
public double FaceterDevNormal;
```

#### Conditions
Read / Write
### FaceterDevSurface

#### Description
Accesses the devSurface setting. This value is used (when subdividing the edges and also when placing the grid lines across the face) to control the deviation of the mesh from the FACE.
```text
public double FaceterDevSurface;
```

#### Conditions
Read / Write
### FaceterGridRatio

#### Description
Accesses the value for the maximum aspect ratio for the (quads in the) grid.
```text
public double FaceterGridRatio;
```

#### Conditions
Read / Write
### FaceterMaxEdgeLength

#### Description
Accesses the value for the maximum number of grid lines that may be used.
```text
public double FaceterMaxEdgeLength;
```

#### Conditions
Read / Write
### FaceterMaxGrid

#### Description
Accesses the value for the maximum number of grid lines that may be used.
```text
public ushort FaceterMaxGrid;
```

#### Conditions
Read / Write
### FaceterMeshType

#### Description
Accesses the value for the faceter mesh type: 
0: for new quad type, 
1: for hybrid type(triangle & quad), 
2: for triangle type
```text
public short FaceterMeshType;
```

#### Conditions
Read / Write
### FaceterMinUGrid

#### Description
Accesses the value for the minimum number of U parameter grid lines
```text
public ushort FaceterMinUGrid;
```

#### Conditions
Read / Write
### FaceterMinVGrid

#### Description
Accesses the value for the minimum number of V parameter grid lines.
```text
public ushort FaceterMinVGrid;
```

#### Conditions
Read / Write