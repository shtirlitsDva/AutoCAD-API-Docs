# AssocGeomDependency Class

## Overview

#### Description
This class represents a dependency on a subentity (face/edge/vertex) of a geometric entity. It keeps an AssocPersSubentId that persistently identitfies the subentity and provides new protocol to set the referenced subentity and get/set the subentity geometry. 
This class may also optionally cache the geometry of the referenced subentity that then allows to filter-out irrelevant change notifications that do no affect the referenced subentity. The caching is controlled by the IsCachingSubentityGeometry property. 
By default the dependency does not cache the geometry of the referenced subentity. The IsRelevantChange property uses the base class implementation that calls AssocAction.IsRelevantDependencyChange() of the owning action, letting the action that owns the dependency decide, such as by caching the geometry of the referenced subentity and comparing it with the current subentity geometry. 
When the dependency caches the geometry of the referenced subentity, the IsRelevantChange property indicates whether the geometry of the referenced subentity is the same as the cached geometry. This is how the dependency can filter-out irrelevant change notifications when the referenced subentity geometry does not really change when something else changes.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocDependency
        Autodesk.AutoCAD.DatabaseServices.AssocGeomDependency
```

```text
public class AssocGeomDependency : AssocDependency;
```

### Constructors

- [AssocGeomDependency](#assocgeomdependency)

### Methods

- [DependentOnObjectMirrored](#dependentonobjectmirrored)
- [RedirectToAnotherSubentity](#redirecttoanothersubentity)

### Properties

- [EdgeSubentityGeometry](#edgesubentitygeometry)
- [FaceSubentityGeometry](#facesubentitygeometry)
- [IsCachingSubentityGeometry](#iscachingsubentitygeometry)
- [PersistentSubentId](#persistentsubentid)
- [Subentity](#subentity)
- [SubentityType](#subentitytype)
- [TransientSubentCount](#transientsubentcount)
- [TransientSubentIds](#transientsubentids)
- [VertexSubentityGeometry](#vertexsubentitygeometry)


## Constructors Details

### AssocGeomDependency

#### Description
Default constructor.
```text
public AssocGeomDependency();
```

### DependentOnObjectMirrored

#### Description
Called by the client code to inform the AssocGeomDependency that the object, whose subentity it depends on, has been mirrored. The dependency then mirrors the AssocPersSubentityId it holds. For the majority of dependent-on entity types it is a no-op, but for some entity types (such as for Arc) the AssocPersSubentityId actually needs to be updated.
```text
public void DependentOnObjectMirrored();
```

### RedirectToAnotherSubentity

#### Description
Gets all AssocGeomDependencies on the old object that reference the given oldSubentId of that object and redirects them to reference the newSubentId of the new object.
```text
public static void RedirectToAnotherSubentity(
    ObjectId oldObjectId, 
    SubentityId oldSubentId, 
    ObjectId newObjectId, 
    SubentityId newSubentId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId oldObjectId | The DBObject whose AssocGeomDependencies are to be redirected. It will be opened for write. |
| SubentityId oldSubentId | The SubentityId of the AssocGeomDependencies that is to be redirected. |
| ObjectId newObjectId | The object to redirect the dependencies to. It will be opened for write. |
| SubentityId newSubentId | The new SubentityId in the new object. |

### EdgeSubentityGeometry

#### Description
Gets and sets curves of edge subentities corresponding to the internally held AssocPersSubentityId, which must identify an edge subentity type. 
Notice that one AssocPersSubentityId may generally correspond to any number of subentities, though in most cases it will be just one subentity. The caller will become the owner of the returned curves and is responsible for freeing them after thay are not needed. The length of the input array must be the same as the number of subentities corresponding to the internally held AssocPersSubentityId. The pased-in curves are not reused but copied, they do not become owned by the dependency.
```text
public Curve3d EdgeSubentityGeometry;
```

#### Conditions
Read / write
### FaceSubentityGeometry

#### Description
Gets and sets surfaces of face subentities corresponding to the internally held AssocPersSubentityId, which must identify a face subentity type. 
Notice that one AssocPersSubentityId may generally correspond to any number of subentities, though in most cases it will be just one subentity. The caller will become the owner of the returned surfaces and is responsible for freeing them after thay are not needed. The length of the input array must be the same as the number of subentities corresponding to the internally held AssocPersSubentityId. The pased-in surfraces are not reused but copied, they do not become owned by the dependency.
```text
public Autodesk.AutoCAD.Geometry.Surface FaceSubentityGeometry;
```

#### Conditions
Read / write
### IsCachingSubentityGeometry

#### Description
Indicates whether the dependency keeps a cache of the referenced subentity geometry (even if the cache may currently be empty). 
The initial state is false, i.e., the dependency does not keep the subentity geometry cache. Also, sets whether the dependency is to keep the cache of the referenced subentity geometry. The initial state is false, i.e., the dependency does not keep the subentity geometry cache.
```text
public bool IsCachingSubentityGeometry;
```

#### Conditions
Read / write
### PersistentSubentId

#### Description
Gets the reference to the internally held AssocPersSubentityId that identifies a subentity of the dependent-on entity. 
The returned pointer points to internal data owned by this class. The caller must not change or hold-on to this returned AssocPersSubentityId and should only call read-only methods on it. 
The retuned pointer may be NULL.
```text
public AssocPersSubentityId PersistentSubentId;
```

#### Conditions
Read-only
### Subentity

#### Description
Sets the internally held AssocPersSubentityId to persistently identify the given subentity. 
The subentity must be on the entity the dependency currently depends on. It returns the type of the persistently referenced subentity or NullSubentType if no subentity is referenced.
```text
public SubentityId Subentity;
```

#### Conditions
Reas / write
### SubentityType

#### Description
This is SubentityType, a member of class AssocGeomDependency.
```text
public uint SubentityType;
```

### TransientSubentCount

#### Description
Gets the number of transient SubentityIds corresponding to the internally held AssocPersSubentityId. In typical cases, it is just a single subentity, but generally it may be none, one or any number of subentities.
```text
public int TransientSubentCount;
```

#### Conditions
Read-only
### TransientSubentIds

#### Description
Gets the transient SubentityIds of the dependent-on entity corresponding to the internally held AssocPersSubentityId. 
Notice that one AssocPersSubentityId may generally correspond to none, one, or more than one subentity, though in typical cases, it will be exactly one subentity.
```text
public SubentityId TransientSubentIds;
```

#### Conditions
Read-only
### VertexSubentityGeometry

#### Description
Gets and sets coordinates of vertex subentities corresponding to the internally held AssocPersSubentityId, which must identify a vertex subentity type. 
Notice that one AssocPersSubentityId may generally correspond to any number of subentities, though in most cases it will be just one subentity. The length of the input array must be the same as the number of subentities corresponding to the internally held AssocPersSubentityId. 
```text
public Point3d VertexSubentityGeometry;
```

#### Conditions
Read / write