# Autodesk.AutoCAD.DatabaseServices.Filters Namespace

## Overview

#### Description
This is namespace Autodesk.AutoCAD.DatabaseServices.Filters.
Dynamic-Link Library (DLL)
AcDbMgd.dll
Classes
| Class | Description |
| --- | --- |
| [Filter](Autodesk_AutoCAD_DatabaseServices_Filters_Filter.md) | This .NET class wraps the AcDbFilter ObjectARX class.This class defines a "query." It provides the "key" to the CompositeFilteredBlockIterator... [more](Autodesk_AutoCAD_DatabaseServices_Filters_Filter.md) |
| [FilteredBlockIterator](Autodesk_AutoCAD_DatabaseServices_Filters_FilteredBlockIterator.md) | This .NET class wraps the AcDbFilteredBlockIterator ObjectARX class.This class provides a method to process a query on an index.... [more](Autodesk_AutoCAD_DatabaseServices_Filters_FilteredBlockIterator.md) |
| [Index](Autodesk_AutoCAD_DatabaseServices_Filters_Index.md) | This .NET class wraps the AcDbIndex ObjectARX class.This is the base class for Index objects. SpatialIndex and LayerIndex derive... [more](Autodesk_AutoCAD_DatabaseServices_Filters_Index.md) |
| [IndexUpdateData](Autodesk_AutoCAD_DatabaseServices_Filters_IndexUpdateData.md) | This .NET class wraps the AcDbIndexUpdateData ObjectARX class.This class is used to serve as a mapping between an ObjectId... [more](Autodesk_AutoCAD_DatabaseServices_Filters_IndexUpdateData.md) |
| [LayerFilter](Autodesk_AutoCAD_DatabaseServices_Filters_LayerFilter.md) | This .NET class wraps the AcDbLayerFilter ObjectARX class.This class is a list of layers that need to have their... [more](Autodesk_AutoCAD_DatabaseServices_Filters_LayerFilter.md) |
| [LayerIndex](Autodesk_AutoCAD_DatabaseServices_Filters_LayerIndex.md) | This .NET class wraps the AcDbLayerIndex ObjectARX class.This class is an index implementation especially for layers. |
| [SpatialFilter](Autodesk_AutoCAD_DatabaseServices_Filters_SpatialFilter.md) | This .NET class wraps the AcDbSpatialFilter ObjectARX class.This class defines an extruded volume based on a 2D boundary definition,... [more](Autodesk_AutoCAD_DatabaseServices_Filters_SpatialFilter.md) |
| [SpatialIndex](Autodesk_AutoCAD_DatabaseServices_Filters_SpatialIndex.md) | This .NET class wraps the AcDbSpatialIndex ObjectARX class. This class is an index implementation especially for the spatial index. |

## Members

### Constructors

- [LayerFilter](#layerfilter)
- [LayerIndex](#layerindex)
- [SpatialFilter](#spatialfilter)
- [SpatialFilterDefinition](#spatialfilterdefinition)
- [SpatialFilterVolume](#spatialfiltervolume)
- [SpatialIndex](#spatialindex)

### Methods

- [Accepts](#accepts)
- [Add](#add)
- [AddId](#addid)
- [AddToBuffer](#addtobuffer)
- [ClipVolumeIntersectsExtents](#clipvolumeintersectsextents)
- [Compute](#compute)
- [GetAt](#getat)
- [GetIdData](#getiddata)
- [GetIdDataPtr](#getiddataptr)
- [GetIdFlags](#getidflags)
- [GetIterator](#getiterator)
- [GetPoints](#getpoints)
- [GetQueryBounds()](#getquerybounds())
- [GetQueryBounds(BlockReference)](#getquerybounds(blockreference))
- [GetVolume](#getvolume)
- [RebuildFull](#rebuildfull)
- [Remove](#remove)
- [Seek](#seek)
- [SetIdData(ObjectId, int)](#setiddata(objectid,-int))
- [SetIdData(ObjectId, IntPtr)](#setiddata(objectid,-intptr))
- [SetIdFlags](#setidflags)
- [SetPerspectiveCamera](#setperspectivecamera)
- [Start](#start)

### Other

- [Filter Class](#filter-class)
- [FilteredBlockIterator Class](#filteredblockiterator-class)
- [Index Class](#index-class)
- [IndexUpdateData Class](#indexupdatedata-class)
- [LayerFilter Class](#layerfilter-class)
- [LayerIndex Class](#layerindex-class)
- [SpatialFilter Class](#spatialfilter-class)
- [SpatialFilterDefinition Structure](#spatialfilterdefinition-structure)
- [SpatialFilterVolume Structure](#spatialfiltervolume-structure)
- [SpatialIndex Class](#spatialindex-class)

### Properties

- [BackClip](#backclip)
- [BuffersForComposition](#buffersforcomposition)
- [ClipSpaceToWorldCoordinateSystemTransform](#clipspacetoworldcoordinatesystemtransform)
- [Definition](#definition)
- [Elevation](#elevation)
- [Enabled](#enabled)
- [EstimatedHitFraction](#estimatedhitfraction)
- [FromPoint](#frompoint)
- [FrontClip](#frontclip)
- [HasPerspectiveCamera](#hasperspectivecamera)
- [Id](#id)
- [IndexClass](#indexclass)
- [Inverted](#inverted)
- [IsUptoDate](#isuptodate)
- [IsValid](#isvalid)
- [LastUpdatedAt](#lastupdatedat)
- [LastUpdatedAtU](#lastupdatedatu)
- [LayerCount](#layercount)
- [Next](#next)
- [Normal](#normal)
- [ObjectBeingIndexedId](#objectbeingindexedid)
- [OriginalInverseBlockTransform](#originalinverseblocktransform)
- [ToPoint](#topoint)
- [UpDirection](#updirection)
- [ViewField](#viewfield)


## Constructors Details

### LayerFilter

#### Description
Default constructor.
```text
public LayerFilter();
```

### LayerIndex

#### Description
Default constructor.
```text
public LayerIndex();
```

### SpatialFilter

#### Description
Default constructor.
```text
public SpatialFilter();
```

### SpatialFilterDefinition

#### Description
This is the constructor for the SpatialFilterDefinition object.
```text
public SpatialFilterDefinition(
    Point2dCollection pts, 
    Vector3d normal, 
    double elevation, 
    double frontClip, 
    double backClip, 
    [MarshalAs(UnmanagedType.U1)] bool enabled
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point2dCollection pts | Input boundary definition. If the number of points is 2, they are diagonal points of a rectangle. Otherwise, they are vertices of a polygon. The polygon should be non self intersecting. |
| Vector3d normal | Input positive extrusion direction vector |
| double elevation | Input elevation; along with the normal, this will define an ECS in which the polygon points are defined |
| double frontClip | Input front clip distance in the positive extrusion direction |
| double backClip | Input back clip distance in the negative extrusion direction |
| [MarshalAs(UnmanagedType.U1)] bool enabled | Input Boolean to make the clip volume effective, or alternatively, be all of 3D space |

### SpatialFilterVolume

#### Description
Constructor.
```text
public SpatialFilterVolume(
    Point3d fromPoint, 
    Point3d toPoint, 
    Vector3d upDir, 
    Vector2d viewField
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d fromPoint | Input the transformed clip boundary "from" point |
| Point3d toPoint | Input the transformed clip boundary "to" point |
| Vector3d upDir | Input the transformed clip boundary normal vector |
| Vector2d viewField | Input the transformed clip boundary's view field vector |

### SpatialIndex

#### Description
Default constructor.
```text
public SpatialIndex();
```

### Accepts

#### Description
Returns true if the id is accepted (that is, if it can be output)
```text
public bool Accepts(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Object ID that is being composed, typically output of a previous iterator's Accepts() method or Id property |

### Add

#### Description
This function will add the input layer to the set of layers within the filter object that define those entities that pass the filter test. Once layer is added, all entities on layer will be accepted.
```text
public void Add(
    string layer
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string layer | Input layer name to add |

### AddId

#### Description
This method does not check to see if the ObjectId corresponds to the same database as the one whose indexes are being updated.
```text
public void AddId(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Object ID for which mapping data or flag data will be added later |

### AddToBuffer

#### Description
This method adds the Id to an internal buffer maintained by an index iterator. This method can be expected to return true only if the BuffersForComposition property returns true. 
If BuffersForComposition property returns true, then composition of a FilteredBlockIterator objects will be done through buffering. This means that the output of one iterator will be added to the buffering iterator with the least EstimatedHitFraction property, then the next one, and so on. The final buffered iterator's output will be fed to the accepts() method of the subsequent non-buffering iterators. 
An example of a custom index iterator that would need buffering could be an index-filter scheme that returns data based on a proximity query. For example, return circles at least a distance of 10 units from polylines on layers 'Roads.' So all the polylines would need to be available before the query can be processed. 
After all the IDs from the previous index iterator have been added to the buffer, the normal Start() method will be used, along with the Next and Id properties. 
It is up to the filtered block iterator implementation to iterate the buffered data as opposed to the original block data.
```text
public void AddToBuffer(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Object ID that is being composed, typically output of a previous iterator's Accepts() method or Id property |

### ClipVolumeIntersectsExtents

#### Description
This function is used to determine whether an object with extents ext intersects this SpatialFilter object's clipping volume.
```text
public bool ClipVolumeIntersectsExtents(
    Extents3d ext
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Extents3d ext | Input extents |

### Compute

#### Description
This function uses the layer table pointed to by pLT and the block table record pointed to by pBTR to compute the appropriate filter information.
```text
public void Compute(
    LayerTable pLT, 
    BlockTableRecord record
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| LayerTable pLT | Input layer table of the Database |
| BlockTableRecord record | Input block table record for which the filter should be generated |

### GetAt

#### Description
This function finds the layer whose index is index and sets name to point to that layer's name.
```text
public void GetAt(
    int index, 
    string name
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index of layer to get |
| string name | Input name of layer at index index |

### GetIdData

#### Description
**Obsolete** \- Use the GetIdDataPtr property instead. 
Returns the 32-bit data associated with id.
Class
Autodesk.AutoCAD.DatabaseServices.Filters.IndexUpdateData
#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Object ID that data is associated with |

public IntPtr GetIdDataPtr( 
ObjectId id 
);
Previous Declaration
```text
public int GetIdData(ObjectId id);
```

### GetIdDataPtr

#### Description
Returns the 32-bit data value associated with id
```text
public IntPtr GetIdDataPtr(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Object ID that data is associated with |

### GetIdFlags

#### Description
Returns the 8-bit flag value associated with id
```text
public byte GetIdFlags(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Object ID that flags is associated with |

### GetIterator

#### Description
This function will create a new FilteredBlockIterator object. The index and filter classes should be compatible. The returned index iterator will essentially be the method by which the results of the query posted to the index object is traversed. It is up to the concrete class implementation to verify whether or not the index is up-to-date and valid. 
Returns a FilteredBlockIterator abstract base class or NULL if unsuccessful. It is up to the concrete class to perform a timestamp validity check if desired.
```text
public virtual FilteredBlockIterator GetIterator(
    Autodesk.AutoCAD.DatabaseServices.Filters.Filter filter
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.Filters.Filter filter | Input filter (query) to be applied to the index for the iterator based traversal |

### GetPoints

#### Description
Returns the points that define the boundary.
```text
public Point2dCollection GetPoints();
```

### GetQueryBounds()

#### Description
This function is used to get the boundary area of this SpatialFilter object. 
Returns the extents that define the query volume
```text
public Extents3d GetQueryBounds();
```

### GetQueryBounds(BlockReference)

#### Description
This function has been deprecated and will be removed in a future release.
```text
public virtual Extents3d GetQueryBounds(
    BlockReference blockReference
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| BlockReference blockReference | Deprecated |

### GetVolume

#### Description
Transforms the SpatialFilter object's clip boundary definition into the coordinate space of the associated block or xref.
```text
public SpatialFilterVolume GetVolume();
```

### RebuildFull

#### Description
This function completely rebuilds the index from the entities in the associated block table record. Implementation is needed at the concrete class. The concrete class should supermessage the base class.
```text
public virtual void RebuildFull(
    IndexUpdateData indexData
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IndexUpdateData indexData | Input IndexUpdateData object for use during the index rebuild |

### Remove

#### Description
This function will remove the input layer from the filter. This will mean entities NOT on this layer are considered NOT to pass the filtered test.
```text
public void Remove(
    string layer
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string layer | Input layer name to remove |

### Seek

#### Description
The Seek() method is only provided to implement legacy behavior. 
This is a somewhat awkward method for generalized index traversal. It is needed to support legacy database emulation. In practice, the capability to seek up to two of the previously visited Ids (not including the one at the cursor) is needed. Seeking back up to two earlier visited Ids is a must.
```text
public void Seek(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | ObjectId to seek to |

### SetIdData(ObjectId, int)

#### Description
Sets the ID data.
```text
public void SetIdData(
    ObjectId id, 
    int data
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Object ID that data is associated with |
| int data | 32-bit data value associated with id |

### SetIdData(ObjectId, IntPtr)

#### Description
Sets the ID data.
```text
public void SetIdData(
    ObjectId id, 
    IntPtr data
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Object ID that data is associated with |
| IntPtr data | 32-bit data value associated with id |

### SetIdFlags

#### Description
Sets the ID flags.
```text
public void SetIdFlags(
    ObjectId id, 
    byte flags
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Object ID that flags is associated with |
| byte flags | 8-bit flag value associated with id |

### SetPerspectiveCamera

#### Description
Sets the perspective camera position to the location specified by fromPoint.
```text
public void SetPerspectiveCamera(
    Point3d fromPoint
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d fromPoint | Input new base point for the camera |

### Start

#### Description
Initiates iteration.
```text
public void Start();
```

### Filter Class

#### Description
This .NET class wraps the AcDbFilter ObjectARX class. 
This class defines a "query." It provides the "key" to the CompositeFilteredBlockIterator, for which the corresponding index is obtained through the IndexClass property. 
The AcDbSpatialFilter.IndexClass property will return SpatialIndex.Desc. 
Applications that need to provide their own indexing scheme need to provide versions of these three classes: 
  * [Index](Autodesk_AutoCAD_DatabaseServices_Filters_Index.md)
  * Filter
  * FilteredBlockIterator

Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Filters.Filter
```

```text
public abstract class Filter : DBObject;
```

### FilteredBlockIterator Class

#### Description
This .NET class wraps the AcDbFilteredBlockIterator ObjectARX class. 
This class provides a method to process a query on an index. Used by the CompositeFilteredBlockIterator class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Filters.FilteredBlockIterator
```

```text
public sealed class FilteredBlockIterator : DisposableWrapper;
```

### Index Class

#### Description
This .NET class wraps the AcDbIndex ObjectARX class. 
This is the base class for Index objects. SpatialIndex and LayerIndex derive from this class. 
Keeping the index up-to-date is achieved through the IndexFilterManager.UpdateIndexes() call explicitly invoked (either by an application or AutoCAD) 
The FilteredBlockIterator will serve as the means to visit all the ObjectIds that are "hits" from the query defined by the Filter passed to its constructor. For example, in the Spatial index case, the SpatialFilter object instance passed to the GetIterator() method will define a query region. The SpatialIndex object, through its GetIterator() method, will provide an SpatialIndexIterator that will return IDs that correspond to entities that fit within the query volume.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Filters.Index
        Autodesk.AutoCAD.DatabaseServices.Filters.LayerIndex
        Autodesk.AutoCAD.DatabaseServices.Filters.SpatialIndex
```

```text
public abstract class Index : DBObject;
```

#### Notes
When using indexes, make sure the INDEXCTL system variable is set to the appropriate value. See the System Variables section of the _AutoCAD Command Reference_ for information on INDEXCTL.
### IndexUpdateData Class

#### Description
This .NET class wraps the AcDbIndexUpdateData ObjectARX class. 
This class is used to serve as a mapping between an ObjectId and any index specific data or flags. For example, during spatial index update, one could associate an entity extents with the ObjectId within this instance. 
The primary purpose of the class's get and set methods is to give applications a non-intrusive yet efficient method (_O(1)_) of associating flags and data with an ObjectId during an index update. 
An IndexUpdateData instance is never directly instantiated. It is always supplied as an argument.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Filters.IndexUpdateData
```

```text
public sealed class IndexUpdateData : DisposableWrapper;
```

### LayerFilter Class

#### Description
This .NET class wraps the AcDbLayerFilter ObjectARX class. 
This class is a list of layers that need to have their corresponding entity lists traversed during filtered block traversal.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Filters.LayerFilter
```

```text
public class LayerFilter : Autodesk.AutoCAD.DatabaseServices.Filters.Filter;
```

### LayerIndex Class

#### Description
This .NET class wraps the AcDbLayerIndex ObjectARX class. 
This class is an index implementation especially for layers.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Filters.Index
        Autodesk.AutoCAD.DatabaseServices.Filters.LayerIndex
```

```text
public class LayerIndex : Index;
```

#### Notes
When using AutoCAD indexes, the INDEXCTL system variable must be set to the appropriate value. For example, INDEXCTL must be either 1 or 3 for the AutoCAD layer index. See the System Variables section of the _AutoCAD Command Reference_ for information on INDEXCTL.
### SpatialFilter Class

#### Description
This .NET class wraps the AcDbSpatialFilter ObjectARX class. 
This class defines an extruded volume based on a 2D boundary definition, local coordinate system, and the front and back clipping planes.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Filters.SpatialFilter
```

```text
public class SpatialFilter : Autodesk.AutoCAD.DatabaseServices.Filters.Filter;
```

### SpatialFilterDefinition Structure

#### Description
This class encapsulates the data required to define a spatial filter. Properties of this class correlate to the arguments used by the SpatialFilter.setDefinition and AcDbSpatialFilter.getDefinition ObjectARX functions.
```text
public struct SpatialFilterDefinition {
}
```

### SpatialFilterVolume Structure

#### Description
This class encapsulates the data required to describe a spatial filter's volume. Properties of this class correlate to the arguments used by the SpatialFilter.getVolume ObjectARX function.
```text
public struct SpatialFilterVolume {
}
```

### SpatialIndex Class

#### Description
This .NET class wraps the AcDbSpatialIndex ObjectARX class. This class is an index implementation especially for the spatial index.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Filters.Index
        Autodesk.AutoCAD.DatabaseServices.Filters.SpatialIndex
```

```text
public class SpatialIndex : Index;
```

#### Notes
When using AutoCAD indexes, the INDEXCTL system variable must be set to the appropriate value. For example, INDEXCTL must be either 2 or 3 for the AutoCAD spatial index. See the System Variables section of the _AutoCAD Command Reference_ for information on INDEXCTL.


## Properties Details

### BackClip

#### Description
Accesses the back clip distance in the negative extrusion direction.
```text
public double BackClip;
```

#### Conditions
Read-only
### BuffersForComposition

#### Description
During use by CompositeFilteredBlockIterator, the way multiple index/filter pairs are handled is through allocating corresponding FilteredBlockIterator objects, and prioritizing their use through the EstimatedHitFraction property. As a result, only the first index iterator does a 'true' index traversal. The remaining are queried for acceptance or rejection of individual Ids through the Accepts() method in most cases. 
In some cases, however, a custom index may require that acceptance or rejection require all the Ids to be supplied to it. In that case, BuffersForComposition returns true, and the Accepts() method is not used as a means for composing indexes. Instead, the AddToBuffer() method and the normal iterator properties of Next and Id are used to visit the output. 
Returns true if the index iterator needs to buffer output if it is not used as the primary index iterator. Default is false.
```text
public bool BuffersForComposition;
```

#### Conditions
Read-only
### ClipSpaceToWorldCoordinateSystemTransform

#### Description
Transforms the clip boundary points from their coordinate system (whatever it may be) to WCS
```text
public Matrix3d ClipSpaceToWorldCoordinateSystemTransform;
```

#### Conditions
Read-only
### Definition

#### Description
Accesses the definition of the SpatialFilter object.
```text
public SpatialFilterDefinition Definition;
```

#### Conditions
Read / Write
### Elevation

#### Description
Accesses the elevation; along with the normal, this will define an ECS in which the polygon points are defined
```text
public double Elevation;
```

#### Conditions
Read-only
### Enabled

#### Description
Assesses if to make the clip volume effective, or alternatively, be all of 3D space
```text
public bool Enabled;
```

#### Conditions
Read-only
### EstimatedHitFraction

#### Description
Used to prioritize the order in which FilteredBlockIterator objects will be used during a block traversal. If a concrete implementation cannot estimate, it should return 1.0. Returning 0.0 will force the iterator to be the first one used for the traversal. Returning 1.0 will force it to be the last iterator used. 
Returns the estimated fraction in the interval (0.0 to 1.0) of the amount of the contents of the index that will be hit based on the Filter query
```text
public double EstimatedHitFraction;
```

#### Conditions
Read-only
### FromPoint

#### Description
Accesses the transformed clip boundary "from" point
```text
public Point3d FromPoint;
```

#### Conditions
Read-only
### FrontClip

#### Description
Accesses the front clip distance in the positive extrusion direction
```text
public double FrontClip;
```

#### Conditions
Read-only
### HasPerspectiveCamera

#### Description
Assesses if a perspective camera is currently defined for this SpatialFilter object.
```text
public bool HasPerspectiveCamera;
```

#### Conditions
Read-only
### Id

#### Description
Accesses the ObjectId at the current iterator position
```text
public ObjectId Id;
```

#### Conditions
Read-only
### IndexClass

#### Description
Accesses the class descriptor for the Index for this filter
```text
public virtual RXClass IndexClass;
```

#### Conditions
Read-only
### Inverted

#### Description
This property controls whether or not the SpatialFilter filters out the contents outside of the clip boundary (not inverted) or inside the clip boundary (inverted). 
Returns true when the SpatialFilter is inverted, otherwise false.
```text
public bool Inverted;
```

#### Conditions
Read / Write
### IsUptoDate

#### Description
Accesses information in addition to TDUPDATE to verify the up-to-date status. This can be used to verify the validity within a session (as opposed to the TDUPDATE value being compared to LastUpdatedAt). This has a concrete implementation.
```text
public bool IsUptoDate;
```

#### Conditions
Read-only
### IsValid

#### Description
Assesses whether all the layers exist in the layer table of the database the object is associated with.
```text
public virtual bool IsValid;
```

#### Conditions
Read-only
### LastUpdatedAt

#### Description
Accesses the TDUPDATE value of the Database when the index was last updated. This is particularly useful when using index objects in saved drawings. For example, if the TDUPDATE value is not equal to the LastUpdatedAt timestamp, the index is stale. This has a concrete implementation.
```text
public DateTime LastUpdatedAt;
```

#### Conditions
Read / Write
### LastUpdatedAtU

#### Description
Accesses the Universal time that the index was last updated.
```text
public DateTime LastUpdatedAtU;
```

#### Conditions
Read / Write
### LayerCount

#### Description
Assesses the number of layers in the filter.
```text
public int LayerCount;
```

#### Conditions
Read-only
### Next

#### Description
Accesses the cursor and returns the next ObjectId
```text
public ObjectId Next;
```

#### Conditions
Read-only
### Normal

#### Description
Accesses the positive extrusion direction vector
```text
public Vector3d Normal;
```

#### Conditions
Read-only
### ObjectBeingIndexedId

#### Description
Accesses Index objects are associated with Block Table Records, and indirectly owned by them. This function returns the parent block table record ID. This method has a concrete implementation.
```text
public virtual ObjectId ObjectBeingIndexedId;
```

#### Conditions
Read-only
### OriginalInverseBlockTransform

#### Description
Accesses the inverse of the block transform for the associated BlockReference when the Filter was last set.
```text
public Matrix3d OriginalInverseBlockTransform;
```

#### Conditions
Read-only
### ToPoint

#### Description
Accesses the transformed clip boundary "to" point
```text
public Point3d ToPoint;
```

#### Conditions
Read-only
### UpDirection

#### Description
Accesses the transformed clip boundary normal vector
```text
public Vector3d UpDirection;
```

#### Conditions
Read-only
### ViewField

#### Description
Accesses the transformed clip boundary's view field vector
```text
public Vector2d ViewField;
```

#### Conditions
Read-only