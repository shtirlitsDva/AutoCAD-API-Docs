# Surface Class

## Overview

#### Description
This .Net class wraps the ObjectARX class [AcDbSurface](AcDbSurface.md).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Surface
            Autodesk.AutoCAD.DatabaseServices.LoftedSurface
            Autodesk.AutoCAD.DatabaseServices.PlaneSurface
            Autodesk.AutoCAD.DatabaseServices.SweptSurface
```

```text
public class Surface : Entity;
```

### Methods

- [ChamferEdges(SubentityId[], SubentityId, double, double)](#chamferedges(subentityid[],-subentityid,-double,-double))
- [ChamferEdges(SubentityId[], SubentityId, double, double, [MarshalAs(UnmanagedType.U1)] bool)](#chamferedges(subentityid[],-subentityid,-double,-double,-[marshalas(unmanagedtype.u1)]-bool))
- [ConvertToNurbSurface](#converttonurbsurface)
- [CreateBlendSurface(LoftProfile, LoftProfile, BlendOptions)](#createblendsurface(loftprofile,-loftprofile,-blendoptions))
- [CreateBlendSurface(LoftProfile, LoftProfile, BlendOptions, [MarshalAs(UnmanagedType.U1)] bool)](#createblendsurface(loftprofile,-loftprofile,-blendoptions,-[marshalas(unmanagedtype.u1)]-bool))
- [CreateExtendSurface](#createextendsurface)
- [CreateExtrudedSurface(Profile3d, Vector3d, SweepOptions)](#createextrudedsurface(profile3d,-vector3d,-sweepoptions))
- [CreateExtrudedSurface(Profile3d, Vector3d, SweepOptions, [MarshalAs(UnmanagedType.U1)] bool)](#createextrudedsurface(profile3d,-vector3d,-sweepoptions,-[marshalas(unmanagedtype.u1)]-bool))
- [CreateFilletSurface(ObjectId, Point3d, ObjectId, Point3d, double, Autodesk.AutoCAD.DatabaseServices.FilletTrimMode, Vector3d)](#createfilletsurface(objectid,-point3d,-objectid,-point3d,-double,-autodesk.autocad.databaseservices.fillettrimmode,-vector3d))
- [CreateFilletSurface(ObjectId, Point3d, ObjectId, Point3d, double, Autodesk.AutoCAD.DatabaseServices.FilletTrimMode, Vector3d, [MarshalAs(UnmanagedType.U1)] bool)](#createfilletsurface(objectid,-point3d,-objectid,-point3d,-double,-autodesk.autocad.databaseservices.fillettrimmode,-vector3d,-[marshalas(unmanagedtype.u1)]-bool))
- [CreateInterferenceObjects](#createinterferenceobjects)
- [CreateLoftedSurface(LoftProfile[], LoftProfile[], LoftProfile, LoftOptions)](#createloftedsurface(loftprofile[],-loftprofile[],-loftprofile,-loftoptions))
- [CreateLoftedSurface(LoftProfile[], LoftProfile[], LoftProfile, LoftOptions, [MarshalAs(UnmanagedType.U1)] bool)](#createloftedsurface(loftprofile[],-loftprofile[],-loftprofile,-loftoptions,-[marshalas(unmanagedtype.u1)]-bool))
- [CreateNetworkSurface(Profile3d[], Profile3d[])](#createnetworksurface(profile3d[],-profile3d[]))
- [CreateNetworkSurface(Profile3d[], Profile3d[], [MarshalAs(UnmanagedType.U1)] bool)](#createnetworksurface(profile3d[],-profile3d[],-[marshalas(unmanagedtype.u1)]-bool))
- [CreateOffsetSurface(Entity, double)](#createoffsetsurface(entity,-double))
- [CreateOffsetSurface(Entity, double, [MarshalAs(UnmanagedType.U1)] bool)](#createoffsetsurface(entity,-double,-[marshalas(unmanagedtype.u1)]-bool))
- [CreatePatchSurface(PathRef, ObjectIdCollection, int, double)](#createpatchsurface(pathref,-objectidcollection,-int,-double))
- [CreatePatchSurface(PathRef, ObjectIdCollection, int, double, [MarshalAs(UnmanagedType.U1)] bool)](#createpatchsurface(pathref,-objectidcollection,-int,-double,-[marshalas(unmanagedtype.u1)]-bool))
- [CreateRevolvedSurface(Profile3d, Point3d, Vector3d, double, double, RevolveOptions)](#createrevolvedsurface(profile3d,-point3d,-vector3d,-double,-double,-revolveoptions))
- [CreateRevolvedSurface(Profile3d, Point3d, Vector3d, double, double, RevolveOptions, [MarshalAs(UnmanagedType.U1)] bool)](#createrevolvedsurface(profile3d,-point3d,-vector3d,-double,-double,-revolveoptions,-[marshalas(unmanagedtype.u1)]-bool))
- [CreateRevolvedSurface(Profile3d, Profile3d, [MarshalAs(UnmanagedType.U1)] bool, double, double, RevolveOptions)](#createrevolvedsurface(profile3d,-profile3d,-[marshalas(unmanagedtype.u1)]-bool,-double,-double,-revolveoptions))
- [CreateRevolvedSurface(Profile3d, Profile3d, [MarshalAs(UnmanagedType.U1)] bool, double, double, RevolveOptions, [MarshalAs(UnmanagedType.U1)] bool)](#createrevolvedsurface(profile3d,-profile3d,-[marshalas(unmanagedtype.u1)]-bool,-double,-double,-revolveoptions,-[marshalas(unmanagedtype.u1)]-bool))
- [CreateSectionObjects](#createsectionobjects)
- [CreateSweptSurface(Profile3d, Profile3d, SweepOptions)](#createsweptsurface(profile3d,-profile3d,-sweepoptions))
- [CreateSweptSurface(Profile3d, Profile3d, SweepOptions, [MarshalAs(UnmanagedType.U1)] bool)](#createsweptsurface(profile3d,-profile3d,-sweepoptions,-[marshalas(unmanagedtype.u1)]-bool))
- [ExtendEdges](#extendedges)
- [FilletEdges(SubentityId[], double, [MarshalAs(UnmanagedType.U1)] bool)](#filletedges(subentityid[],-double,-[marshalas(unmanagedtype.u1)]-bool))
- [FilletEdges(SubentityId[], DoubleCollection, DoubleCollection, DoubleCollection)](#filletedges(subentityid[],-doublecollection,-doublecollection,-doublecollection))
- [GetSubentityColor](#getsubentitycolor)
- [GetSubentityMaterial](#getsubentitymaterial)
- [GetSubentityMaterialMapper](#getsubentitymaterialmapper)
- [ImprintEntity](#imprintentity)
- [ProjectOnToSurface](#projectontosurface)
- [RayTest](#raytest)
- [SetSubentityColor](#setsubentitycolor)
- [SetSubentityMaterial](#setsubentitymaterial)
- [SetSubentityMaterialMapper](#setsubentitymaterialmapper)
- [SliceByPlane](#slicebyplane)
- [SliceBySurface](#slicebysurface)
- [TrimSurface](#trimsurface)

### Other

- [AutoCAD.DatabaseServices.Surface.WireframeTypeEnum Enumeration](#autocad.databaseservices.surface.wireframetypeenum-enumeration)

### Properties

- [CreationActionBodyId](#creationactionbodyid)
- [GeometricExtents](#geometricextents)
- [ModificationActionBodyIds](#modificationactionbodyids)
- [Perimeter](#perimeter)
- [UIsoLineDensity](#uisolinedensity)
- [UsesGraphicsCache](#usesgraphicscache)
- [WireframeType](#wireframetype)


## Methods Details

### ChamferEdges(SubentityId[], SubentityId, double, double)

#### Description
This .NET method wraps the ObjectARX method [AcDbSurface::chamferEdges Method](AcDbSurface__chamferEdges@AcArray_AcDbSubentId_____@AcDbSubentId_@double@double.md).
```text
public virtual void ChamferEdges(
    SubentityId\[\] edgeSubentIds, 
    SubentityId baseFaceSubentId, 
    double baseDist, 
    double otherDist
);
```

### ChamferEdges(SubentityId[], SubentityId, double, double, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps [AcDbSurface::chamferEdges](AcDbSurface__chamferEdges@AcArray_AcDbSubentId_____@AcDbSubentId_@double@double@bool.md)() method
```text
public void ChamferEdges(
    SubentityId\[\] subentityIds, 
    SubentityId baseSubentityId, 
    double baseDist, 
    double otherDist, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### ConvertToNurbSurface

#### Description
This wraps the ObjectARX [AcDbSurface::convertToNurbSurface](AcDbSurface__convertToNurbSurface@AcDbNurbSurfaceArray_.md)() method
```text
public Autodesk.AutoCAD.DatabaseServices.NurbSurface\[\] ConvertToNurbSurface();
```

### CreateBlendSurface(LoftProfile, LoftProfile, BlendOptions)

#### Description
This wraps the ObjectARX [AcDbSurface::createBlendSurface](AcDbSurface__createBlendSurface@AcDbLoftProfile_@AcDbLoftProfile_@AcDbBlendOptions_@AcDbSurface__.md) () method.
```text
public static Autodesk.AutoCAD.DatabaseServices.Surface CreateBlendSurface(
    LoftProfile startProfile, 
    LoftProfile endProfile, 
    BlendOptions blendOptionsd
);
```

### CreateBlendSurface(LoftProfile, LoftProfile, BlendOptions, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbSurface::createBlendSurface](AcDbSurface__createBlendSurface@AcDbLoftProfile_@AcDbLoftProfile_@AcDbBlendOptions_@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateBlendSurface(
    LoftProfile startProfile, 
    LoftProfile endProfile, 
    BlendOptions blendOptions, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### CreateExtendSurface

#### Description
This wraps the ObjectARX [AcDbSurface::createExtendSurface](AcDbSurface__createExtendSurface@AcDbObjectId@AcArray_AcDbSubentId__@double@EdgeExtensionType@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateExtendSurface(
    ObjectId sourceSurface, 
    SubentityId\[\] edges, 
    double extension, 
    EdgeExtensionType extOption, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### CreateExtrudedSurface(Profile3d, Vector3d, SweepOptions)

#### Description
This wraps: [AcDbSurface::createExtrudedSurface](AcDbSurface__createExtrudedSurface@AcDb3dProfile__@AcGeVector3d_@AcDbSweepOptions_@AcDbExtrudedSurface__.md) (edSurface) method.
```text
public static ExtrudedSurface CreateExtrudedSurface(
    Profile3d pSweep, 
    Vector3d directionVec, 
    SweepOptions sweepOptions
);
```

### CreateExtrudedSurface(Profile3d, Vector3d, SweepOptions, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbSurface::createExtrudedSurface](AcDbSurface__createExtrudedSurface@AcDb3dProfile__@AcGeVector3d_@AcDbSweepOptions_@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateExtrudedSurface(
    Profile3d pSweep, 
    Vector3d directionVec, 
    SweepOptions sweepOptions, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### CreateFilletSurface(ObjectId, Point3d, ObjectId, Point3d, double, Autodesk.AutoCAD.DatabaseServices.FilletTrimMode, Vector3d)

#### Description
This wraps the ObjectARX[AcDbSurface::createFilletSurface](AcDbSurface__createFilletSurface@AcDbObjectId_@AcGePoint3d_@AcDbObjectId_@AcGePoint3d_@double@AcDb__FilletTrimMode@AcGeVector3d_@AcDbSurface__.md) () method.
```text
public static Autodesk.AutoCAD.DatabaseServices.Surface CreateFilletSurface(
    ObjectId surfId1, 
    Point3d pickPt1, 
    ObjectId surfId2, 
    Point3d pickPt2, 
    double radius, 
    Autodesk.AutoCAD.DatabaseServices.FilletTrimMode trimMode, 
    Vector3d projDir
);
```

### CreateFilletSurface(ObjectId, Point3d, ObjectId, Point3d, double, Autodesk.AutoCAD.DatabaseServices.FilletTrimMode, Vector3d, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbSurface::createFilletSurface](AcDbSurface__createFilletSurface@AcDbObjectId_@AcGePoint3d_@AcDbObjectId_@AcGePoint3d_@double@AcDb__FilletTrimMode@AcGeVector3d_@bool@AcDbObjectId_.md) () method.
```text
public static ObjectId CreateFilletSurface(
    ObjectId surfId1, 
    Point3d pickPt1, 
    ObjectId surfId2, 
    Point3d pickPt2, 
    double radius, 
    Autodesk.AutoCAD.DatabaseServices.FilletTrimMode trimMode, 
    Vector3d projDir, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### CreateInterferenceObjects

#### Description
This .NET method wraps the ObjectARX method [AcDbSurface::createInterferenceObjects()](AcDbSurface__createInterferenceObjects@AcArray_AcDbEntity___@AcDbEntity_@unsigned_int@const.md).
```text
public virtual Entity\[\] CreateInterferenceObjects(
    Entity ent, 
    int flags
);
```

### CreateLoftedSurface(LoftProfile[], LoftProfile[], LoftProfile, LoftOptions)

#### Description
This wraps the ObjectARX [AcDbLoftedSurface::createLoftedSurface](AcDbLoftedSurface__createLoftedSurface@AcArray_AcDbEntity___@AcArray_AcDbEntity___@AcDbEntity_@AcDbLoftOptions_.md) ( ) method.
```text
public static Autodesk.AutoCAD.DatabaseServices.Surface CreateLoftedSurface(
    LoftProfile\[\] crossSections, 
    LoftProfile\[\] guides, 
    LoftProfile path, 
    LoftOptions loftOptions
);
```

### CreateLoftedSurface(LoftProfile[], LoftProfile[], LoftProfile, LoftOptions, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbLoftedSurface::createLoftedSurface](AcDbLoftedSurface__createLoftedSurface@AcArray_AcDbEntity___@AcArray_AcDbEntity___@AcDbEntity_@AcDbLoftOptions_.md) ( ) method.
```text
public static ObjectId CreateLoftedSurface(
    LoftProfile\[\] crossSections, 
    LoftProfile\[\] guides, 
    LoftProfile path, 
    LoftOptions loftOptions, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### CreateNetworkSurface(Profile3d[], Profile3d[])

#### Description
This wraps the ObjectARX [AcDbSurface:: createNetworkSurface](AcDbSurface__createNetworkSurface@AcArray_AcDb3dProfile___@AcArray_AcDb3dProfile___@AcDbSurface__.md) () method.
```text
public static Autodesk.AutoCAD.DatabaseServices.Surface CreateNetworkSurface(
    Profile3d\[\] uProfiles, 
    Profile3d\[\] vProfiles
);
```

### CreateNetworkSurface(Profile3d[], Profile3d[], [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbSurface::createNetworkSurface](AcDbSurface__createNetworkSurface@AcArray_AcDb3dProfile___@AcArray_AcDb3dProfile___@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateNetworkSurface(
    Profile3d\[\] uProfiles, 
    Profile3d\[\] vProfiles, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### CreateOffsetSurface(Entity, double)

#### Description
This wraps the ObjectARX [AcDbSurface::createOffsetSurface](AcDbSurface__createOffsetSurface@AcDbEntity_@double@AcDbEntity__.md) () method.
```text
public static Entity CreateOffsetSurface(
    Entity entity, 
    double offsetDistance
);
```

### CreateOffsetSurface(Entity, double, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbSurface::createOffsetSurface](AcDbSurface__createOffsetSurface@AcDbEntity_@double@bool@AcDbObjectId_.md) () method.
```text
public static ObjectId CreateOffsetSurface(
    Entity entity, 
    double offsetDistance, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### CreatePatchSurface(PathRef, ObjectIdCollection, int, double)

#### Description
This wrap ObjectARX [AcDbSurface::createPatchSurface](AcDbSurface__createPatchSurface@AcDbPathRef_@AcDbObjectIdArray_@int@double@AcDbSurface__.md) () method.
```text
public static Autodesk.AutoCAD.DatabaseServices.Surface CreatePatchSurface(
    PathRef inputPathRef, 
    ObjectIdCollection constraintIds, 
    int continuity, 
    double bulge
);
```

### CreatePatchSurface(PathRef, ObjectIdCollection, int, double, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbSurface::createPatchSurface](AcDbSurface__createPatchSurface@AcDbPathRef_@AcDbObjectIdArray_@int@double@bool@AcDbObjectId_.md) () method.
```text
public static ObjectId CreatePatchSurface(
    PathRef inputPathRef, 
    ObjectIdCollection constraintIds, 
    int continuity, 
    double bulge, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### CreateRevolvedSurface(Profile3d, Point3d, Vector3d, double, double, RevolveOptions)

#### Description
This wraps the ObjectARX [AcDbSurface::createRevolvedSurface](AcDbSurface__createRevolvedSurface@AcDb3dProfile__@AcGePoint3d_@AcGeVector3d_@double@double@AcDbRevolveOptions_@AcDbRevolvedSurface__.md)() method.
```text
public static RevolvedSurface CreateRevolvedSurface(
    Profile3d rev, 
    Point3d axisPnt, 
    Vector3d axisDir, 
    double revAngle, 
    double startAngle, 
    RevolveOptions revolveOptions
);
```

### CreateRevolvedSurface(Profile3d, Point3d, Vector3d, double, double, RevolveOptions, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbSurface::createRevolvedSurface](AcDbSurface__createRevolvedSurface@AcDb3dProfile__@AcGePoint3d_@AcGeVector3d_@double@double@AcDbRevolveOptions_@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateRevolvedSurface(
    Profile3d rev, 
    Point3d axisPnt, 
    Vector3d axisDir, 
    double revAngle, 
    double startAngle, 
    RevolveOptions revolveOptions, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### CreateRevolvedSurface(Profile3d, Profile3d, [MarshalAs(UnmanagedType.U1)] bool, double, double, RevolveOptions)

#### Description
This wraps the ObjectARX [AcDbSurface::createRevolvedSurface](AcDbSurface__createRevolvedSurface@AcDb3dProfile__@AcDb3dProfile__@bool@double@double@AcDbRevolveOptions_@AcDbRevolvedSurface__.md)() method.
```text
public static RevolvedSurface CreateRevolvedSurface(
    Profile3d rev, 
    Profile3d axisEnt, 
    [MarshalAs(UnmanagedType.U1)] bool flipAxisDirection, 
    double revAngle, 
    double startAngle, 
    RevolveOptions revolveOptions
);
```

### CreateRevolvedSurface(Profile3d, Profile3d, [MarshalAs(UnmanagedType.U1)] bool, double, double, RevolveOptions, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbSurface::createRevolvedSurface](AcDbSurface__createRevolvedSurface@AcDb3dProfile__@AcDb3dProfile__@bool@double@double@AcDbRevolveOptions_@bool@AcDbObjectId_.md)( ) method.
```text
public static ObjectId CreateRevolvedSurface(
    Profile3d rev, 
    Profile3d axisEnt, 
    [MarshalAs(UnmanagedType.U1)] bool flipAxisDirection, 
    double revAngle, 
    double startAngle, 
    RevolveOptions revolveOptions, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### CreateSectionObjects

#### Description
This .NET method wraps the ObjectARX method [AcDbSurface::createSectionObjects Method](AcDbSurface__createSectionObjects@AcGePlane_@AcArray_AcDbEntity___@const.md).
```text
public virtual Entity\[\] CreateSectionObjects(
    Plane sectionPlane
);
```

### CreateSweptSurface(Profile3d, Profile3d, SweepOptions)

#### Description
This wraps the ObjectARX [AcDbSurface:: createSweptSurface](AcDbSurface__createSweptSurface@AcDb3dProfile__@AcDb3dProfile__@AcDbSweepOptions_@AcDbSweptSurface__.md)() method.
```text
public static SweptSurface CreateSweptSurface(
    Profile3d sweep, 
    Profile3d path, 
    SweepOptions sweepOptions
);
```

### CreateSweptSurface(Profile3d, Profile3d, SweepOptions, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbSurface::createSweptSurface](AcDbSurface__createSweptSurface@AcDb3dProfile__@AcDb3dProfile__@AcDbSweepOptions_@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateSweptSurface(
    Profile3d sweep, 
    Profile3d path, 
    SweepOptions sweepOptions, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### ExtendEdges

#### Description
This wraps the ObjectARX [AcDbSurface::extendEdges](AcDbSurface__extendEdges@AcDbFullSubentPathArray_@double@EdgeExtensionType@bool.md)() method
```text
public void ExtendEdges(
    FullSubentityPath\[\] edges, 
    double extension, 
    EdgeExtensionType extOption, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### FilletEdges(SubentityId[], double, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbSurface::filletEdges](AcDbSurface__filletEdges@AcArray_AcDbSubentId_____@double@bool.md)() method
```text
public void FilletEdges(
    SubentityId\[\] subentityIds, 
    double radius, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### FilletEdges(SubentityId[], DoubleCollection, DoubleCollection, DoubleCollection)

#### Description
This .NET method wraps the ObjectARX method [AcDbSurface::filletEdges Method](AcDbSurface__filletEdges@AcArray_AcDbSubentId_____@AcGeDoubleArray_@AcGeDoubleArray_@AcGeDoubleArray_.md).
```text
public virtual void FilletEdges(
    SubentityId\[\] subentityIds, 
    DoubleCollection radius, 
    DoubleCollection startSetback, 
    DoubleCollection endSetback
);
```

### GetSubentityColor

#### Description
This .NET method wraps the ObjectARX method [AcDbSurface::getSubentColor Method](AcDbSurface__getSubentColor@AcDbSubentId_@AcCmColor_@const.md).
```text
public virtual Autodesk.AutoCAD.Colors.Color GetSubentityColor(
    SubentityId subEntityId
);
```

### GetSubentityMaterial

#### Description
This .NET method wraps the ObjectARX method [AcDbSurface::getSubentMaterial Method](AcDbSurface__getSubentMaterial@AcDbSubentId_@AcDbObjectId_@const.md).
```text
public virtual ObjectId GetSubentityMaterial(
    SubentityId subEntityId
);
```

### GetSubentityMaterialMapper

#### Description
This .NET method wraps the ObjectARX method [AcDbSurface::getSubentMaterialMapper](AcDbSurface__getSubentMaterialMapper@AcDbSubentId_@AcGiMapper_@const.md).
```text
public virtual Mapper GetSubentityMaterialMapper(
    SubentityId subEntityId
);
```

### ImprintEntity

```text
public virtual void ImprintEntity(
    Entity entityToImprint
);
```

### ProjectOnToSurface

#### Description
This wraps the ObjectARX [AcDbSurface::projectOnToSurface](AcDbSurface__projectOnToSurface@AcDbEntity_@AcGeVector3d_@AcArray_AcDbEntity___@const.md)() method
```text
public Entity\[\] ProjectOnToSurface(
    Entity entityToProject, 
    Vector3d projectionDirection
);
```

### RayTest

#### Description
This wraps the ObjectARX [AcDbSurface::rayTest](AcDbSurface__rayTest@AcGePoint3d_@AcGeVector3d_@double@AcArray_AcDbSubentId__@AcGeDoubleArray_@const.md)() method.
```text
public void RayTest(
    Point3d rayBasePoint, 
    Vector3d rayDir, 
    double rayRadius, 
    out SubentityId\[\] subEntIds, 
    out DoubleCollection parameters
);
```

### SetSubentityColor

#### Description
This .NET method wraps the ObjectARX method [AcDbSurface::setSubentColor Method](AcDbSurface__setSubentColor@AcDbSubentId_@AcCmColor_.md).
```text
public virtual void SetSubentityColor(
    SubentityId subEntityId, 
    Autodesk.AutoCAD.Colors.Color color
);
```

### SetSubentityMaterial

#### Description
This .NET method wraps the ObjectARX method [AcDbSurface::setSubentMaterial Method](AcDbSurface__setSubentMaterial@AcDbSubentId_@AcDbObjectId_.md).
```text
public virtual void SetSubentityMaterial(
    SubentityId subEntityId, 
    ObjectId materialId
);
```

### SetSubentityMaterialMapper

#### Description
This .NET method wraps the ObjectARX method [AcDbSurface::setSubentMaterialMapper Method](AcDbSurface__setSubentMaterialMapper@AcDbSubentId_@AcGiMapper_.md).
```text
public virtual void SetSubentityMaterialMapper(
    SubentityId subEntityId, 
    Mapper mapper
);
```

### SliceByPlane

#### Description
This .NET method wraps the ObjectARX method [AcDbSurface::sliceByPlane Method](AcDbSurface__sliceByPlane@AcGePlane_@AcDbSurface__@AcDbSurface__.md).
```text
public virtual SurfaceSliceResults SliceByPlane(
    Plane slicePlane
);
```

### SliceBySurface

#### Description
This .NET method wraps the ObjectARX method [AcDbSurface::sliceBySurface Method](AcDbSurface__sliceBySurface@AcDbSurface_@AcDbSurface__@AcDbSurface__.md).
```text
public virtual SurfaceSliceResults SliceBySurface(
    Autodesk.AutoCAD.DatabaseServices.Surface slicingSurface
);
```

### TrimSurface

#### Description
This wraps the ObjectARX [AcDbSurface::trimSurface](AcDbSurface__trimSurface@AcDbObjectId__@AcDbObjectIdArray__@AcDbObjectIdArray__@AcArray_AcGeVector3d_@AcGePoint3d_@AcGeVector3d_@bool@bool.md)() method.
```text
public static void TrimSurface(
    ObjectId blankSurfaceId, 
    ObjectIdCollection toolSurfaceIds, 
    ObjectIdCollection toolCurveIds, 
    Vector3dCollection projVectors, 
    Point3d pickPoint, 
    Vector3d viewVector, 
    [MarshalAs(UnmanagedType.U1)] bool bAutoExtend, 
    [MarshalAs(UnmanagedType.U1)] bool associativeEnabled
);
```

### AutoCAD.DatabaseServices.Surface.WireframeTypeEnum Enumeration

#### Description
This wraps AcDbLoftedSurface::WireframeType enumeration. 
```text
public enum WireframeTypeEnum {
  Isolines,
  IsoParms
}
```


## Properties Details

### CreationActionBodyId

#### Description
This wraps the ObjectARX [AcDbSurface::creationActionBodyId](AcDbSurface__creationActionBodyId@const.md)() method
```text
public ObjectId CreationActionBodyId;
```

### GeometricExtents

#### Description
Accesses the corner points (in WCS coordinates) of a box (with edges parallel to the WCS X, Y, and Z axes) that encloses the 3D extents of the entity, and return those points as an instance of class Extents in the "extents" parameter.
```text
public override Extents3d GeometricExtents;
```

#### Conditions
Read-only
### ModificationActionBodyIds

#### Description
This wraps the ObjectARX [AcDbSurface::modificationActionBodyIds](AcDbSurface__modificationActionBodyIds@AcDbObjectIdArray_@const.md)() method
```text
public ObjectIdCollection ModificationActionBodyIds;
```

### Perimeter

#### Description
This wraps the ObjectARX [AcDbSurface::getPerimeter](AcDbSurface__getPerimeter@double_@const.md)() method
```text
public double Perimeter;
```

### UIsoLineDensity

#### Description
This wraps the ObjectARX[AcDbSurface::setUIsolineDensity](AcDbSurface__setUIsolineDensity@Adesk__UInt16.md)() and [AcDbSurface::uIsolineDensity](AcDbSurface__uIsolineDensity.md)() methods.
```text
public short UIsoLineDensity;
```

### UsesGraphicsCache

#### Description
This property is a wrapper for the AcDbSurface::usesGraphicsCache() method which is used by AutoCAD to determine whether or not to use cached graphics for the surface. If the method returns true, then cached graphics will be used. Only database resident entities can use graphics caching, so this method is not called for entities not in an AcDbDatabase.
```text
public bool UsesGraphicsCache;
```

### WireframeType

#### Description
This wraps the ObjectARX [AcDbSurface::getWireframeType](AcDbSurface__getWireframeType@const.md)() and [AcDbSurface::setWireframeType](AcDbSurface__setWireframeType@WireframeType.md)() methods.
```text
public WireframeTypeEnum WireframeType;
```
