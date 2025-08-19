# SubDMesh Class

## Overview

#### Description
This .NET class wraps the ObjectARX [AcDbSubDMesh Class](AcDbSubDMesh.md).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.SubDMesh
```

```text
public class SubDMesh : Entity;
```

### Methods

- [Cap](#cap)
- [Collapse](#collapse)
- [ComputeSurfaceArea](#computesurfacearea)
- [ComputeVolume](#computevolume)
- [ConvertToSolid](#converttosolid)
- [ConvertToSurface([MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#converttosurface([marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [ConvertToSurface([MarshalAs(UnmanagedType.U1)] bool, SubentityId)](#converttosurface([marshalas(unmanagedtype.u1)]-bool,-subentityid))
- [ExtrudeConnectedFaces(FullSubentityPath[], double, Vector3d, double)](#extrudeconnectedfaces(fullsubentitypath[],-double,-vector3d,-double))
- [ExtrudeConnectedFaces(FullSubentityPath[], Point3dCollection, double)](#extrudeconnectedfaces(fullsubentitypath[],-point3dcollection,-double))
- [ExtrudeFaces(FullSubentityPath[], double, Vector3d, double)](#extrudefaces(fullsubentitypath[],-double,-vector3d,-double))
- [ExtrudeFaces(FullSubentityPath[], Point3dCollection, double)](#extrudefaces(fullsubentitypath[],-point3dcollection,-double))
- [GetAdjacentSubentPath](#getadjacentsubentpath)
- [GetCrease(FullSubentityPath[])](#getcrease(fullsubentitypath[]))
- [GetCrease(SubentityId)](#getcrease(subentityid))
- [GetFacePlane](#getfaceplane)
- [GetNumberOfSubDividedFacesAt](#getnumberofsubdividedfacesat)
- [GetObjectMesh](#getobjectmesh)
- [GetSubDividedVertexAt(int)](#getsubdividedvertexat(int))
- [GetSubDividedVertexAt(SubentityId)](#getsubdividedvertexat(subentityid))
- [GetSubentColor](#getsubentcolor)
- [GetSubentMaterial](#getsubentmaterial)
- [GetSubentMaterialMapper](#getsubentmaterialmapper)
- [GetSubentPath](#getsubentpath)
- [GetVertexAt(int)](#getvertexat(int))
- [GetVertexAt(SubentityId)](#getvertexat(subentityid))
- [MergeFaces](#mergefaces)
- [Setbox](#setbox)
- [SetCone](#setcone)
- [SetCrease(double)](#setcrease(double))
- [SetCrease(FullSubentityPath[], double)](#setcrease(fullsubentitypath[],-double))
- [SetCylinder](#setcylinder)
- [SetDragStatus](#setdragstatus)
- [SetPyramid](#setpyramid)
- [SetSphere](#setsphere)
- [SetSubDMesh](#setsubdmesh)
- [SetSubentColor](#setsubentcolor)
- [SetSubentMaterial](#setsubentmaterial)
- [SetSubentMaterialMapper](#setsubentmaterialmapper)
- [SetTorus](#settorus)
- [SetVertexAt(int, Point3d)](#setvertexat(int,-point3d))
- [SetVertexAt(SubentityId, Point3d)](#setvertexat(subentityid,-point3d))
- [SetWedge](#setwedge)
- [Spin](#spin)
- [SplitFace](#splitface)
- [SubdDivideDown](#subddividedown)
- [SubdDivideUp](#subddivideup)
- [SubdRefine()](#subdrefine())
- [SubdRefine(FullSubentityPath[])](#subdrefine(fullsubentitypath[]))

### Properties

- [FaceArray](#facearray)
- [NormalArray](#normalarray)
- [NumberOfFaces](#numberoffaces)
- [NumberOfSubDividedFaces](#numberofsubdividedfaces)
- [NumberOfSubDividedVertices](#numberofsubdividedvertices)
- [NumberOfVertices](#numberofvertices)
- [SmoothLevel](#smoothlevel)
- [SubDividedFaceArray](#subdividedfacearray)
- [SubDividedNormalArray](#subdividednormalarray)
- [SubDividedVertices](#subdividedvertices)
- [VertexColorArray](#vertexcolorarray)
- [VertexNormalArray](#vertexnormalarray)
- [VertexTextureArray](#vertextexturearray)
- [Vertices](#vertices)
- [Watertight](#watertight)


## Methods Details

### Cap

#### Description
This wraps the ObjectARX AcDbSubDMesh::cap() method
```text
public void Cap(
    FullSubentityPath\[\] edges
);
```

### Collapse

#### Description
This wraps the ObjectARX AcDbSubDMesh::collapse() method 
```text
public void Collapse(
    SubentityId subentityId
);
```

### ComputeSurfaceArea

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::computeSurfaceArea](AcDbSubDMesh__computeSurfaceArea@double__@const.md).
```text
public double ComputeSurfaceArea();
```

### ComputeVolume

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::computeVolume](AcDbSubDMesh__computeVolume@double__@const.md).
```text
public double ComputeVolume();
```

### ConvertToSolid

#### Description
This .NET method wraps the ObjectARX [AcDbSubDMesh::convertToSolid](AcDbSubDMesh__convertToSolid@bool@bool@AcDb3dSolid__@const.md).
```text
public Solid3d ConvertToSolid(
    [MarshalAs(UnmanagedType.U1)] bool convertAsSmooth, 
    [MarshalAs(UnmanagedType.U1)] bool optimize
);
```

### ConvertToSurface([MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::convertToSurface Method](AcDbSubDMesh__convertToSurface@bool@bool@AcDbSurface__@const.md).
```text
public Autodesk.AutoCAD.DatabaseServices.Surface ConvertToSurface(
    [MarshalAs(UnmanagedType.U1)] bool convertAsSmooth, 
    [MarshalAs(UnmanagedType.U1)] bool optimize
);
```

### ConvertToSurface([MarshalAs(UnmanagedType.U1)] bool, SubentityId)

#### Description
This .NET method wraps the ObjectARX method 
AcDbSubDMesh::convertToSurface(bool bConvertAsSmooth, const AcDbSubentId& id, AcDbSurface*& pSurface).
```text
public Autodesk.AutoCAD.DatabaseServices.Surface ConvertToSurface(
    [MarshalAs(UnmanagedType.U1)] bool convertAsSmooth, 
    SubentityId subentId
);
```

### ExtrudeConnectedFaces(FullSubentityPath[], double, Vector3d, double)

#### Description
This wraps the ObjectARX [AcDbSubDMesh::extrudeConnectedFaces](AcDbSubDMesh__extrudeConnectedFaces@AcDbFullSubentPathArray_@double@AcGeVector3d_@double.md)(const AcDbFullSubentPathArray&amp; subentPaths, double length, const AcGeVector3d&amp; dir, double taper) method
```text
public void ExtrudeConnectedFaces(
    FullSubentityPath\[\] paths, 
    double length, 
    Vector3d dir, 
    double taper
);
```

### ExtrudeConnectedFaces(FullSubentityPath[], Point3dCollection, double)

#### Description
This wraps the ObjectARX [AcDbSubDMesh::extrudeConnectedFaces](AcDbSubDMesh__extrudeConnectedFaces@AcDbFullSubentPathArray_@AcGePoint3dArray_@double.md)() method
```text
public void ExtrudeConnectedFaces(
    FullSubentityPath\[\] paths, 
    Point3dCollection alongPath, 
    double taper
);
```

### ExtrudeFaces(FullSubentityPath[], double, Vector3d, double)

#### Description
This .NET method wraps the ObjectARX method AcDbSubDMesh::extrudeFaces(const AcDbFullSubentPathArray& subentPaths, double length, const AcGeVector3d& dir, double taper).
```text
public void ExtrudeFaces(
    FullSubentityPath\[\] paths, 
    double length, 
    Vector3d dir, 
    double taper
);
```

### ExtrudeFaces(FullSubentityPath[], Point3dCollection, double)

#### Description
This .NET method wraps the ObjectARX method AcDbSubDMesh::extrudeFaces(const AcDbFullSubentPathArray& subentPaths, const AcGePoint3dArray& alongPath).
```text
public void ExtrudeFaces(
    FullSubentityPath\[\] paths, 
    Point3dCollection alongPath, 
    double taper
);
```

### GetAdjacentSubentPath

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::getAdjacentSubentPath](AcDbSubDMesh__getAdjacentSubentPath@AcDbFullSubentPath_@AcDb__SubentType@AcDbFullSubentPathArray_@const.md).
```text
public FullSubentityPath\[\] GetAdjacentSubentPath(
    FullSubentityPath path, 
    SubentityType type
);
```

### GetCrease(FullSubentityPath[])

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::getCrease](AcDbSubDMesh__getCrease@AcDbFullSubentPathArray_@AcArray_double__@const.md).
```text
public DoubleCollection GetCrease(
    FullSubentityPath\[\] subentPaths
);
```

### GetCrease(SubentityId)

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::getCrease.](AcDbSubDMesh__getCrease@AcDbSubentId_@double_@const.md)
```text
public double GetCrease(
    SubentityId id
);
```

### GetFacePlane

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::getFacePlane](AcDbSubDMesh__getFacePlane@AcDbSubentId_@AcGePlane_@const.md).
```text
public Plane GetFacePlane(
    SubentityId subentId
);
```

### GetNumberOfSubDividedFacesAt

#### Description
This .NET method wraps the ObjectARX [AcDbSubDMesh::numOfSubDividedFacesAt Method](AcDbSubDMesh__numOfSubDividedFacesAt@AcDbFullSubentPathArray_@Adesk__Int32_@const.md).
```text
public int GetNumberOfSubDividedFacesAt(
    FullSubentityPath\[\] paths
);
```

### GetObjectMesh

#### Description
Tessellates existing solid or surface object to mesh data using the given faceter settings. The mesh data includes the vertex array, face list array and face data.
```text
public static MeshDataCollection GetObjectMesh(
    DBObject dbObj, 
    MeshFaceterData faceterData
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DBObject dbObj | Input object to get the mesh. |
| MeshFaceterData faceterData | Input faceter setting information. |

#### Returns
MeshDataCollection containing vertex array, face list array and face data.
#### See Also
[MeshDataCollection Structure](Autodesk_AutoCAD_DatabaseServices_MeshDataCollection.md "MeshDataCollection Structure"), [MeshFaceterData Structure](Autodesk_AutoCAD_DatabaseServices_MeshFaceterData.md "MeshFaceterData Structure")

### GetSubDividedVertexAt(int)

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::getSubDividedVertexAt(Adesk::Int32, AcGePoint3d&)](AcDbSubDMesh__getSubDividedVertexAt@Adesk__Int32@AcGePoint3d_@const.md).
```text
public Point3d GetSubDividedVertexAt(
    int index
);
```

### GetSubDividedVertexAt(SubentityId)

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::getSubDividedVertexAt (AcDbSubentId&, AcGePoint3d&)](AcDbSubDMesh__getSubDividedVertexAt@AcDbSubentId_@AcGePoint3d_@const.md).
```text
public Point3d GetSubDividedVertexAt(
    SubentityId subentId
);
```

### GetSubentColor

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::getSubentColor](AcDbSubDMesh__getSubentColor@AcDbSubentId_@AcCmColor_@const.md).
```text
public Autodesk.AutoCAD.Colors.Color GetSubentColor(
    SubentityId subentId
);
```

### GetSubentMaterial

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::getSubentMaterial](AcDbSubDMesh__getSubentMaterial@AcDbSubentId_@AcDbObjectId_@const.md).
```text
public ObjectId GetSubentMaterial(
    SubentityId subentId
);
```

### GetSubentMaterialMapper

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::getSubentMaterialMapper](AcDbSubDMesh__getSubentMaterialMapper@AcDbSubentId_@AcGiMapper_@const.md).
```text
public Mapper GetSubentMaterialMapper(
    SubentityId subentId
);
```

### GetSubentPath

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::getSubentPath](AcDbSubDMesh__getSubentPath@Adesk__Int32@AcDb__SubentType@AcDbFullSubentPathArray_@const.md).
```text
public FullSubentityPath\[\] GetSubentPath(
    int index, 
    SubentityType type
);
```

### GetVertexAt(int)

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::getVertexAt](AcDbSubDMesh__getVertexAt@Adesk__Int32@AcGePoint3d_@const.md).
```text
public Point3d GetVertexAt(
    int index
);
```

### GetVertexAt(SubentityId)

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::getVertexAt](AcDbSubDMesh__getVertexAt@AcDbSubentId_@AcGePoint3d_@const.md).
```text
public Point3d GetVertexAt(
    SubentityId subentId
);
```

### MergeFaces

#### Description
This wraps the ObjectARX [AcDbSubDMesh::mergeFaces](AcDbSubDMesh__mergeFaces@AcDbFullSubentPathArray_.md)() method
```text
public void MergeFaces(
    FullSubentityPath\[\] faces
);
```

### Setbox

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setBox](AcDbSubDMesh__setBox@double@double@double@int@int@int@int.md).
```text
public void Setbox(
    double xlen, 
    double ylen, 
    double zlen, 
    int divx, 
    int divy, 
    int divz, 
    int smoothLevel
);
```

### SetCone

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setCone](AcDbSubDMesh__setCone@double@double@double@int@int@int@double@int.md).
```text
public void SetCone(
    double majorRadius, 
    double minorRadius, 
    double height, 
    int divAxis, 
    int divHeight, 
    int divCap, 
    double radiusRatio, 
    int smoothLevel
);
```

### SetCrease(double)

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setCrease(double)](AcDbSubDMesh__setCrease@double.md).
```text
public void SetCrease(
    double creaseVal
);
```

### SetCrease(FullSubentityPath[], double)

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setCrease(AcDbFullSubentPathArray&, double)](AcDbSubDMesh__setCrease@AcDbFullSubentPathArray_@double.md).
```text
public void SetCrease(
    FullSubentityPath\[\] subentPaths, 
    double creaseVal
);
```

### SetCylinder

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setCylinder](AcDbSubDMesh__setCylinder@double@double@double@int@int@int@int.md).
```text
public void SetCylinder(
    double majorRadius, 
    double minorRadius, 
    double height, 
    int divAxis, 
    int divHeight, 
    int divCap, 
    int smoothLevel
);
```

### SetDragStatus

#### Description
This function is called when a drag operation involving this entity is starting, ending, or aborting. The status argument provides information about what is happening with the drag operation.
```text
public override void SetDragStatus(
    DragStatus status
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DragStatus status | Value describing the status of the drag operation; one of the values from the DragStat enumeration |

### SetPyramid

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setPyramid](AcDbSubDMesh__setPyramid@double@double@int@int@int@int@double@int.md).
```text
public void SetPyramid(
    double radius, 
    double height, 
    int divLength, 
    int divHeight, 
    int divCap, 
    int nSides, 
    double radiusRatio, 
    int smoothLevel
);
```

### SetSphere

#### Description
This .NET method wraps the ObjectARX method AcDbSubDMesh::setSphere.
```text
public void SetSphere(
    double radius, 
    int divAxis, 
    int divHeight, 
    int smoothLevel
);
```

### SetSubDMesh

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setSubDMesh](AcDbSubDMesh__setSubDMesh@AcGePoint3dArray_@AcArray_Adesk__Int32__@int.md).
```text
public void SetSubDMesh(
    Point3dCollection vertexArray, 
    Int32Collection indexArray, 
    int smoothLevel
);
```

### SetSubentColor

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setSubentColor](AcDbSubDMesh__setSubentColor@AcDbSubentId_@AcCmColor_.md).
```text
public void SetSubentColor(
    SubentityId subentId, 
    Autodesk.AutoCAD.Colors.Color color
);
```

### SetSubentMaterial

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setSubentMaterial](AcDbSubDMesh__setSubentMaterial@AcDbSubentId_@AcDbObjectId_.md).
```text
public void SetSubentMaterial(
    SubentityId subentId, 
    ObjectId matId
);
```

### SetSubentMaterialMapper

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setSubentMaterialMapper](AcDbSubDMesh__setSubentMaterialMapper@AcDbSubentId_@AcGiMapper_.md).
```text
public void SetSubentMaterialMapper(
    SubentityId subentId, 
    Mapper mapper
);
```

### SetTorus

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setTorus](AcDbSubDMesh__setTorus@double@int@int@double@double@int.md).
```text
public void SetTorus(
    double majorRadius, 
    int divSection, 
    int divSweepPath, 
    double sectionRadiusRatio, 
    double sectionRotate, 
    int smoothLevel
);
```

### SetVertexAt(int, Point3d)

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setVertexAt](AcDbSubDMesh__setVertexAt@Adesk__Int32@AcGePoint3d_.md).
```text
public void SetVertexAt(
    int index, 
    Point3d position
);
```

### SetVertexAt(SubentityId, Point3d)

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setVertexAt](AcDbSubDMesh__setVertexAt@AcDbSubentId_@AcGePoint3d_.md).
```text
public void SetVertexAt(
    SubentityId subentId, 
    Point3d position
);
```

### SetWedge

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::setWedge](AcDbSubDMesh__setWedge@double@double@double@int@int@int@int@int@int.md).
```text
public void SetWedge(
    double xLen, 
    double yLen, 
    double zLen, 
    int divLength, 
    int divWidth, 
    int divHeight, 
    int divSlope, 
    int divCap, 
    int smoothLevel
);
```

### Spin

#### Description
This wraps the ObjectARX [AcDbSubDMesh::spin](AcDbSubDMesh__spin@AcDbSubentId_.md)() method
```text
public void Spin(
    SubentityId subentFaceId
);
```

### SplitFace

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::splitFace](AcDbSubDMesh__splitFace@AcDbSubentId_@AcDbSubentId_@AcGePoint3d_@AcDbSubentId_@AcGePoint3d_.md).
```text
public void SplitFace(
    SubentityId subentFaceId, 
    SubentityId subent0, 
    Point3d point0, 
    SubentityId subent1, 
    Point3d point1
);
```

### SubdDivideDown

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::subdDivideDown](AcDbSubDMesh__subdDivideDown.md).
```text
public void SubdDivideDown();
```

### SubdDivideUp

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::subdDivideUp](AcDbSubDMesh__subdDivideUp.md).
```text
public void SubdDivideUp();
```

### SubdRefine()

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::subdRefine](AcDbSubDMesh__subdRefine.md).
```text
public void SubdRefine();
```

### SubdRefine(FullSubentityPath[])

#### Description
This .NET method wraps the ObjectARX method [AcDbSubDMesh::subdRefine](AcDbSubDMesh__subdRefine@AcDbFullSubentPathArray_.md).
```text
public void SubdRefine(
    FullSubentityPath\[\] paths
);
```

### FaceArray

#### Description
This .NET property wraps the ObjectARX method [AcDbSubDMesh::getFaceArray](AcDbSubDMesh__getFaceArray@AcArray_Adesk__Int32__@const.md).
```text
public Int32Collection FaceArray;
```

### NormalArray

#### Description
This .NET property wraps the ObjectARX method [AcDbSubDMesh::getNormalArray](AcDbSubDMesh__getNormalArray@AcGeVector3dArray_@const.md).
```text
public Vector3dCollection NormalArray;
```

### NumberOfFaces

#### Description
This .NET property wraps the ObjectARX method [AcDbSubDMesh::numOfFaces](AcDbSubDMesh__numOfFaces@Adesk__Int32_@const.md).
```text
public int NumberOfFaces;
```

### NumberOfSubDividedFaces

#### Description
This .NET property wraps the ObjectARX method [AcDbSubDMesh::numOfSubDividedFaces](AcDbSubDMesh__numOfSubDividedFaces@Adesk__Int32_@const.md).
```text
public int NumberOfSubDividedFaces;
```

### NumberOfSubDividedVertices

#### Description
This .NET property wraps the ObjectARX method [AcDbSubDMesh::numOfSubDividedVertices](AcDbSubDMesh__numOfSubDividedVertices@Adesk__Int32_@const.md).
```text
public int NumberOfSubDividedVertices;
```

### NumberOfVertices

#### Description
This .NET property wraps the ObjectARX method [AcDbSubDMesh::numOfVertices](AcDbSubDMesh__numOfVertices@Adesk__Int32_@const.md).
```text
public int NumberOfVertices;
```

### SmoothLevel

#### Description
This .NET property wraps the ObjectARX method [AcDbSubDMesh::subdLevel](AcDbSubDMesh__subdLevel@Adesk__Int32_@const.md).
```text
public int SmoothLevel;
```

### SubDividedFaceArray

#### Description
This .NET property wraps the ObjectARX method [AcDbSubDMesh::getSubDividedFaceArray](AcDbSubDMesh__getSubDividedFaceArray@AcArray_Adesk__Int32__@const.md).
```text
public Int32Collection SubDividedFaceArray;
```

### SubDividedNormalArray

#### Description
This .NET property wraps the ObjectARX method [AcDbSubDMesh::getSubDividedNormalArray](AcDbSubDMesh__getSubDividedNormalArray@AcGeVector3dArray_@const.md).
```text
public Vector3dCollection SubDividedNormalArray;
```

### SubDividedVertices

#### Description
This .NET property wraps the ObjectARX method [AcDbSubDMesh::getSubDividedVertices](AcDbSubDMesh__getSubDividedVertices@AcGePoint3dArray_@const.md).
```text
public Point3dCollection SubDividedVertices;
```

### VertexColorArray

#### Description
This wraps the ObjectARX [AcDbSubDMesh::getVertexColorArray](AcDbSubDMesh__getVertexColorArray@AcArray_AcCmEntityColor___.md)() and [AcDbSubDMesh::setVertexColorArray](AcDbSubDMesh__setVertexColorArray@AcArray_AcCmEntityColor___.md)() methods.
```text
public EntityColor VertexColorArray;
```

### VertexNormalArray

#### Description
This wraps the ObjectARX [AcDbSubDMesh::getVertexNormalArray](AcDbSubDMesh__getVertexNormalArray@AcGeVector3dArray__.md) and [AcDbSubDMesh::setVertexNormalArray](AcDbSubDMesh__setVertexNormalArray@AcGeVector3dArray__.md)() methods.
```text
public Vector3dCollection VertexNormalArray;
```

### VertexTextureArray

#### Description
This wraps the ObjectARX [AcDbSubDMesh::getVertexTextureArray](AcDbSubDMesh__getVertexTextureArray@AcGePoint3dArray__.md)() and [AcDbSubDMesh::setVertexTextureArray](AcDbSubDMesh__setVertexTextureArray@AcGePoint3dArray__.md)() methods.
```text
public Point3dCollection VertexTextureArray;
```

### Vertices

#### Description
This .NET property wraps the ObjectARX method [AcDbSubDMesh::getVertices](AcDbSubDMesh__getVertices@AcGePoint3dArray_@const.md).
```text
public Point3dCollection Vertices;
```

### Watertight

#### Description
This .NET property wraps the ObjectARX method [AcDbSubDMesh::isWatertight](AcDbSubDMesh__isWatertight@bool_@const.md).
```text
public bool Watertight;
```
