# MeshDataCollection Structure

## Overview

#### Description
MeshDataCollection is the output of the SubDMesh.GetObjectMesh() method. It is the mesh representation that contains the following mesh data: 
Point3dCollection vertexArray 
Int32Collection faceArray; 
EntityColorCollection colorArray; 
ObjectIdCollection materialIdArray;
```text
public struct MeshDataCollection {
}
```

### Constructors

- [MeshDataCollection](#meshdatacollection)

### Properties

- [ColorArray](#colorarray)
- [FaceArray](#facearray)
- [MaterialIdArray](#materialidarray)
- [VertexArray](#vertexarray)


## Constructors Details

### MeshDataCollection

#### Description
Constructor.
```text
public MeshDataCollection(
    Point3dCollection pts, 
    Int32Collection faces, 
    EntityColorCollection colors, 
    ObjectIdCollection materialIds
);
```

### ColorArray

#### Description
Accesses the colorArray value.
```text
public EntityColorCollection ColorArray;
```

#### Conditions
Read / Write
### FaceArray

#### Description
Accesses the faceArray value.
```text
public Int32Collection FaceArray;
```

#### Conditions
Read / Write
### MaterialIdArray

#### Description
Accesses the materialIdArray value.
```text
public ObjectIdCollection MaterialIdArray;
```

#### Conditions
Read / Write
### VertexArray

#### Description
Accesses the vertexArray value.
```text
public Point3dCollection VertexArray;
```

#### Conditions
Read / Write