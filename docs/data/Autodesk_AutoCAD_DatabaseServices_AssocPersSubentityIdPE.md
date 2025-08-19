# AssocPersSubentityIdPE Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocPersSubentIdPE](AcDbAssocPersSubentIdPE.md) class. 
This is a AcRx protocol extension base class that defines protocol to obtain a persistent query and manipulation protocol that is not available in the Entity class proper so that the client code can manipulate subentities of entities. 
The derived concrete classes implement this protocol for the individual derived Entity classes. Only the methods that are pertinent to the particular Entity type need to be overridden. 
Notice that ObjectARX provides an implementation of the AssocPersSubentityIdPE protocol extension for the common entity types such as Line, Circle, Arc, Polyline, Polyline2d, etc.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocPersSubentityIdPE
```

```text
public class AssocPersSubentityIdPE : RXObject;
```

### Constructors

- [AssocPersSubentityIdPE](#assocperssubentityidpe)

### Methods

- [CreateNewPersSubent](#createnewperssubent)
- [GetAllSubentities](#getallsubentities)
- [GetEdgeSubentityGeometry](#getedgesubentitygeometry)
- [GetEdgeVertexSubentities](#getedgevertexsubentities)
- [GetFaceSubentityGeometry](#getfacesubentitygeometry)
- [GetRigidSetState](#getrigidsetstate)
- [GetRigidSetTransform](#getrigidsettransform)
- [GetSplineEdgeVertexSubentities](#getsplineedgevertexsubentities)
- [GetSubentGeometryXform](#getsubentgeometryxform)
- [GetTransientSubentityIds](#gettransientsubentityids)
- [GetVertexSubentityGeometry](#getvertexsubentitygeometry)
- [MirrorPersSubent](#mirrorperssubent)
- [SetEdgeSubentityGeometry](#setedgesubentitygeometry)
- [SetFaceSubentityGeometry](#setfacesubentitygeometry)
- [SetRigidSetTransform](#setrigidsettransform)
- [SetVertexSubentityGeometry](#setvertexsubentitygeometry)


## Constructors Details

### AssocPersSubentityIdPE

#### Description
Default Constructor
```text
public AssocPersSubentityIdPE();
```

### CreateNewPersSubent

#### Description
Mapping: SubentityId --> AssocPersSubentityId 
Creates a new AssocPersSubentityId object from a given SubentityId. The default implementation creates a SimplePersSubentityId that just holds the given SubentityId.
```text
public virtual AssocPersSubentityId CreateNewPersSubent(
    Entity entity, 
    CompoundObjectId compId, 
    SubentityId subentId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for write, but usually no changes to the entity will be made. |
| CompoundObjectId compId | Contains full context path to entity. Can be empty for simple reference. |
| SubentityId subentId | Transient SubentityId. |

#### Returns
The newly created AssocPersSubentityId or NULL if it cannot be created.
### GetAllSubentities

#### Description
Gets all subentities of the given type. The default implementation just returns [NotImplementedYe](Autodesk_AutoCAD_Runtime_ErrorStatus.md)t.
```text
public virtual SubentityId\[\] GetAllSubentities(
    Entity entity, 
    SubentityType subentType
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for read. |
| SubentityType subentType | The required type of the subentities. |

#### Returns
Returned SubentityIds of the required type.
### GetEdgeSubentityGeometry

#### Description
Gets the curve of an edge subentity. The default implementation just returns [NotImplementedYet](Autodesk_AutoCAD_Runtime_ErrorStatus.md).
```text
public virtual Curve3d GetEdgeSubentityGeometry(
    Entity entity, 
    SubentityId edgeSubentId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for read. |
| SubentityId edgeSubentId | Edge SubentityId whose curve is to be obtained. |

#### Returns
Returned curve of the edge subentity (the caller becomes its owner).
### GetEdgeVertexSubentities

#### Description
Gets the vertex SubentityIds corresponding to the given edge SubentityId. This protocol is needed to query the relations between the edge and vertex subentities. The default implementation just returns [NotImplementedYet](Autodesk_AutoCAD_Runtime_ErrorStatus.md).
```text
public virtual void GetEdgeVertexSubentities(
    Entity entity, 
    SubentityId edgeSubentId, 
    ref SubentityId startVertexSubentId, 
    ref SubentityId endVertexSubentId, 
    ref SubentityId\[\] otherVertexSubentIds
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for read. |
| SubentityId edgeSubentId | Edge SubentityId whose vertex SubentityIds are to be obtained. |
| ref SubentityId startVertexSubentId | Returned SubentityId of the start vertex of the edge (or NullSubentityId if there is not any). |
| ref SubentityId endVertexSubentId | Returned SubentityId of the end vertex of the edge (or NullSubentityId if there is not any). |
| ref SubentityId[] otherVertexSubentIds | Returned other SubentityIds associated with the edge, such as the circle or arc center, spline control and fit points, etc. |

### GetFaceSubentityGeometry

#### Description
Gets the surface of a face subentity. The default implementation just returns NotImplementedYet.
```text
public virtual Autodesk.AutoCAD.Geometry.Surface GetFaceSubentityGeometry(
    Entity entity, 
    SubentityId faceSubentId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for read. |
| SubentityId faceSubentId | Face SubentityId whose surface is to be changed. |

#### Returns
Returned surface of the face subentity (the caller becomes its owner).
### GetRigidSetState

#### Description
Returns [ScalableRigidSet](Autodesk_AutoCAD_DatabaseServices_RigidSetTypeInfo.md "RigidSetTypeInfo Enumeration") or [NonScalableRigidSet](Autodesk_AutoCAD_DatabaseServices_RigidSetTypeInfo.md "RigidSetTypeInfo Enumeration") if the entity is a rigid set, i.e. it can be rotated and translated as a whole, but its subentities cannot be individually changed. The default implementation returns [NotRigidSet](Autodesk_AutoCAD_DatabaseServices_RigidSetTypeInfo.md "RigidSetTypeInfo Enumeration").
```text
public virtual int GetRigidSetState(
    Entity entity
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for read. |

#### Returns
ScalableRigidSet or NonScalableRigidSet if the entity is a rigid set.
### GetRigidSetTransform

#### Description
Get the transformation of the rigid set entity. The default implementation returns [NotApplicable](Autodesk_AutoCAD_Runtime_ErrorStatus.md).
```text
public virtual Matrix3d GetRigidSetTransform(
    Entity entity
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for read. |

#### Returns
The returned transformation matrix.
### GetSplineEdgeVertexSubentities

#### Description
Gets the vertex SubentityIds corresponding to the given edge SubentityId whose geometry is defined by a spline. This protocol is needed to query the relations between the edge and vertex subentities. The default implementation just returns NotImplementedYet.
```text
public virtual void GetSplineEdgeVertexSubentities(
    Entity entity, 
    SubentityId edgeSubentId, 
    ref SubentityId startVertexSubentId, 
    ref SubentityId endVertexSubentId, 
    ref SubentityId\[\] controlPointSubentIds, 
    ref SubentityId\[\] fitPointSubentIds
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for read. |
| SubentityId edgeSubentId | Edge SubentId whose vertex SubentityIds are to be obtained. |
| ref SubentityId startVertexSubentId | Returned SubentityId of the start vertex of the edge (or NullSubentityId if there is not any). |
| ref SubentityId endVertexSubentId | Returned SubentityId of the end vertex of the edge (or NullSubentityId if there is not any). |
| ref SubentityId[] controlPointSubentIds | Returned SubentityIds identifying the spline control points. The order is the same as the order of the spline control points. |
| ref SubentityId[] fitPointSubentIds | Returned SubentityIds identifying the spline fit points (if any). The order is the same as the order of the spline fit points. |

### GetSubentGeometryXform

#### Description
Call this method to obtain block transformation matrix for a given sub-entity within the block reference.
```text
public virtual Matrix3d GetSubentGeometryXform(
    Entity entity, 
    ObjectId\[\] fullSubentPath
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for read. |
| ObjectId[] fullSubentPath | Full path of the sub-entity whose collective transformation matrix is to be determined. |

#### Returns
Output block transformation matrix.
### GetTransientSubentityIds

#### Description
Mapping: AssocPersSubentityId --> SubentityId(s) 
Obtains all SubentityIds of the provided Entity that correspond to the provided AssocPersSubentityId.
```text
public virtual SubentityId\[\] GetTransientSubentityIds(
    Entity entity, 
    AssocPersSubentityId perSubentId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity needs to be open for read. |
| AssocPersSubentityId perSubentId | The persistent subentity id on the entity. |

#### Returns
The returned SubentityIds.
#### Remarks
Notice that one AssocPersSubentityId may correspond to none, one or more that one SubentityId, because the entity may have changed and there may not be just a single subentity corresponding to the original subentity identified by the AssocPersSubentityId.
### GetVertexSubentityGeometry

#### Description
Gets the coordinates of a vertex subentity. The default implementation just returns NotImplementedYet.
```text
public virtual Point3d GetVertexSubentityGeometry(
    Entity entity, 
    SubentityId vertexSubentId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for read. |
| SubentityId vertexSubentId | Vertex SubentityId whose position is to be obtained. |

#### Returns
Returned coordinates of the vertex subentity.
### MirrorPersSubent

#### Description
Mirrors the given AssocPersSubentityId, i.e., it changes it so that it identifies the same subentity in the mirrored entity as it identified before the entity is mirrored. It is called from the default implementation of the [AssocPersSubentityId.Mirror](Autodesk_AutoCAD_DatabaseServices_AssocPersSubentityId_Mirror@Entity.md)() method. 
The default implementation is a no-op, but some derived AssocPersSubentityIdPE protocol extension classes (such as AssocArcPersSubentityIdPE) may need to override this method.
```text
public virtual void MirrorPersSubent(
    Entity mirroredEntity, 
    AssocPersSubentityId persSubentIdToMirror
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity mirroredEntity | The entity that has been mirrored. It needs to be open for read. |
| AssocPersSubentityId persSubentIdToMirror | The AssocPersSubentityId to be changed to reflect the fact that the entity has been mirrored. |

### SetEdgeSubentityGeometry

#### Description
Change the curve of an edge subentity. The subentity can also be transformed, but for doing so there already is Entity protocol so no protocol extension is needed. The default implementation just returns NotImplementedYet.
```text
public virtual void SetEdgeSubentityGeometry(
    Entity entity, 
    SubentityId edgeSubentId, 
    Curve3d newEdgeCurve
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for write. |
| SubentityId edgeSubentId | Edge SubentityId whose curve is to be changed. |
| Curve3d newEdgeCurve | New curve of the edge subentity (copied, not reused). |

### SetFaceSubentityGeometry

#### Description
Change the surface of a face subentity. The subentity can also be transformed, but for doing so there already is Entity protocol so no protocol extension is needed. The default implementation just returns NotImplementedYet.
```text
public virtual void SetFaceSubentityGeometry(
    Entity entity, 
    SubentityId faceSubentId, 
    Autodesk.AutoCAD.Geometry.Surface newFaceSurface
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for write. |
| SubentityId faceSubentId | Face SubentityId whose surface is to be changed. |
| Autodesk.AutoCAD.Geometry.Surface newFaceSurface | New surface of the face subentity (copied, not reused). |

### SetRigidSetTransform

#### Description
Set the transformation of the rigid set entity. The default implementation returns NotApplicable.
```text
public virtual void SetRigidSetTransform(
    Entity entity, 
    Matrix3d trans
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for write. |
| Matrix3d trans | New transformation matrix of the rigid set entity. |

### SetVertexSubentityGeometry

#### Description
Change the geometry of a vertex subentity. The subentity can also be transformed, but for doing so there already is Entity protocol so no protocol extension is needed. The default implementation just returns NotImplementedYet.
```text
public virtual void SetVertexSubentityGeometry(
    Entity entity, 
    SubentityId vertexSubentId, 
    Point3d newVertexPosition
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | The entity must be open for write. |
| SubentityId vertexSubentId | Vertex SubentityId whose position is to be changed. |
| Point3d newVertexPosition | New coordinates of the vertex subentity. |
