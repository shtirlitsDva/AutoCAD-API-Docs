# MLeader Class

## Overview

#### Description
This .NET class wraps the AcDbMLeader ObjectARX class. 
The MLeader class represents the multi-leader object.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.MLeader
```

```text
public class MLeader : Entity;
```

### Constructors

- [MLeader](#mleader)

### Methods

- [AddFirstVertex](#addfirstvertex)
- [AddLastVertex](#addlastvertex)
- [AddLeader](#addleader)
- [AddLeaderLine(int)](#addleaderline(int))
- [AddLeaderLine(Point3d)](#addleaderline(point3d))
- [ConnectionPoint(Vector3d)](#connectionpoint(vector3d))
- [ConnectionPoint(Vector3d, Autodesk.AutoCAD.DatabaseServices.TextAttachmentDirection)](#connectionpoint(vector3d,-autodesk.autocad.databaseservices.textattachmentdirection))
- [GetArrowSymbolId](#getarrowsymbolid)
- [GetBlockAttribute](#getblockattribute)
- [GetContentGeomExtents](#getcontentgeomextents)
- [getContextDataManager](#getcontextdatamanager)
- [GetDogleg](#getdogleg)
- [GetDoglegLength](#getdogleglength)
- [GetFirstVertex](#getfirstvertex)
- [GetLastVertex](#getlastvertex)
- [GetLeaderIndex](#getleaderindex)
- [GetLeaderIndexes](#getleaderindexes)
- [GetLeaderLineIndexes](#getleaderlineindexes)
- [getOverridedMLeaderStyle](#getoverridedmleaderstyle)
- [GetPlane](#getplane)
- [GetTextAttachmentType](#gettextattachmenttype)
- [GetVertex](#getvertex)
- [HasContent](#hascontent)
- [MoveMLeader](#movemleader)
- [PostMLeaderToDb](#postmleadertodb)
- [recomputeBreakPoints](#recomputebreakpoints)
- [RemoveFirstVertex](#removefirstvertex)
- [RemoveLastVertex](#removelastvertex)
- [RemoveLeader](#removeleader)
- [RemoveLeaderLine](#removeleaderline)
- [SetArrowSymbolId](#setarrowsymbolid)
- [SetBlockAttribute](#setblockattribute)
- [SetContextDataManager](#setcontextdatamanager)
- [SetDogleg](#setdogleg)
- [SetDoglegLength](#setdogleglength)
- [SetFirstVertex](#setfirstvertex)
- [SetLastVertex](#setlastvertex)
- [SetPlane](#setplane)
- [SetTextAttachmentType](#settextattachmenttype)
- [SetVertex](#setvertex)
- [VerticesCount](#verticescount)

### Properties

- [ArrowSize](#arrowsize)
- [ArrowSymbolId](#arrowsymbolid)
- [BlockColor](#blockcolor)
- [BlockConnectionType](#blockconnectiontype)
- [BlockContentId](#blockcontentid)
- [BlockPosition](#blockposition)
- [BlockRotation](#blockrotation)
- [BlockScale](#blockscale)
- [ContentType](#contenttype)
- [DoglegLength](#dogleglength)
- [EnableAnnotationScale](#enableannotationscale)
- [EnableDogleg](#enabledogleg)
- [EnableFrameText](#enableframetext)
- [EnableLanding](#enablelanding)
- [ExtendLeaderToText](#extendleadertotext)
- [LandingGap](#landinggap)
- [LeaderCount](#leadercount)
- [LeaderLineColor](#leaderlinecolor)
- [LeaderLineCount](#leaderlinecount)
- [LeaderLineType](#leaderlinetype)
- [LeaderLineTypeId](#leaderlinetypeid)
- [LeaderLineWeight](#leaderlineweight)
- [MLeaderStyle](#mleaderstyle)
- [MText](#mtext)
- [Normal](#normal)
- [Scale](#scale)
- [TextAlignmentType](#textalignmenttype)
- [TextAngleType](#textangletype)
- [TextAttachmentDirection](#textattachmentdirection)
- [TextAttachmentType](#textattachmenttype)
- [TextColor](#textcolor)
- [TextHeight](#textheight)
- [TextLocation](#textlocation)
- [TextStyleId](#textstyleid)
- [ToleranceLocation](#tolerancelocation)


## Constructors Details

### MLeader

#### Description
Default constructor.
```text
public MLeader();
```

### AddFirstVertex

#### Description
Inserts a vertex to the leader line with specified index as new leader head.
```text
public void AddFirstVertex(
    int leaderLineIndex, 
    Point3d point
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input index of the leader line. |
| Point3d point | Input the vertex position. |

### AddLastVertex

#### Description
Appends a vertex to the specified leader line as the new leader tail.
```text
public void AddLastVertex(
    int leaderLineIndex, 
    Point3d point
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input leader line index. |
| Point3d point | Input the vertex position. |

### AddLeader

#### Description
Adds a new leader cluster to this MLeader object. A leader cluster is made up by a dog-leg and some leader lines.
```text
public int AddLeader();
```

### AddLeaderLine(int)

#### Description
Adds a leaderline to the leader cluster with specified index. 
Returns the index of added leader line.
```text
public int AddLeaderLine(
    int leaderIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderIndex | Index of the leader cluster. |

### AddLeaderLine(Point3d)

#### Description
Adds a new leader line to this MLeader object. 
This function can be invoked when the MLeader already have a content. If the input point is on the side of exist leader cluster, a new leaderline will be added, the new leaderline's last point have already exist, the input point will be the first point of the new leaderline. If no leader cluster exists on the input point side, a new leader will be added automatically, then add a new leaderline. 
Returns the index of added leader line.
```text
public int AddLeaderLine(
    Point3d point
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d point | Input position of the first(head) vertex of the new leader line. |

### ConnectionPoint(Vector3d)

#### Description
Gets the leader connection point of the specific direction.
```text
public Point3d ConnectionPoint(
    Vector3d direction
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vector3d direction | Input the specific direction. |

### ConnectionPoint(Vector3d, Autodesk.AutoCAD.DatabaseServices.TextAttachmentDirection)

#### Description
Accesses the leader connection point of the specific direction.
```text
public Point3d ConnectionPoint(
    Vector3d direction, 
    Autodesk.AutoCAD.DatabaseServices.TextAttachmentDirection textAttachmentDirection
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vector3d direction | Input the specific direction. |
| Autodesk.AutoCAD.DatabaseServices.TextAttachmentDirection textAttachmentDirection | Specify if the leader attaches to the MText horizontally or vertically (Horizontally by default). |

#### Returns
The connection point.
### GetArrowSymbolId

#### Description
Returns the object id of the arrow head symbol of the specific leaderline.
```text
public ObjectId GetArrowSymbolId(
    int leaderLineIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input the index of the specific leaderline. |

### GetBlockAttribute

#### Description
Gets attribute in block content determined by attribute definition id.
```text
public AttributeReference GetBlockAttribute(
    ObjectId attDefId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId attDefId | Input attribute definition id. |

### GetContentGeomExtents

#### Description
Gets the extents of content in this MLeader object.
```text
public Extents3d GetContentGeomExtents();
```

### getContextDataManager

#### Description
Returns the context data manager in MLeader.
```text
public IntPtr getContextDataManager();
```

### GetDogleg

#### Description
Gets the dog-leg in the leader cluster specified by leaderIndex.
```text
public Vector3d GetDogleg(
    int leaderIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderIndex | Input leader index. |

### GetDoglegLength

#### Description
Gets the length of doglegs in the leader cluster specified by leaderIndex.
```text
public double GetDoglegLength(
    int leaderIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderIndex | Input leader index |

### GetFirstVertex

#### Description
Gets head point of specified leader line.
```text
public Point3d GetFirstVertex(
    int leaderLineIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input leader line index. |

### GetLastVertex

#### Description
Gets the tail vertex position of specified leader line.
```text
public Point3d GetLastVertex(
    int leaderLineIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input leader line index. |

### GetLeaderIndex

#### Description
Gets the index of leader cluster which the specified leader line is in.
```text
public int GetLeaderIndex(
    int leaderLineIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input leader line index. |

### GetLeaderIndexes

#### Description
Gets the indexes of leaders.
```text
public ArrayList GetLeaderIndexes();
```

### GetLeaderLineIndexes

#### Description
Gets the indexes of leaderlines of the specific leader.
```text
public ArrayList GetLeaderLineIndexes(
    int leaderIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderIndex | Input leader index. |

### getOverridedMLeaderStyle

#### Description
Gets the current MLeader's properties, include override properties.
```text
public void getOverridedMLeaderStyle(
    Autodesk.AutoCAD.DatabaseServices.MLeaderStyle mleaderStyle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| MLeaderStyle | Input a reference of MLeaderStyle, MLeader object will set its properties to this object. |

### GetPlane

#### Description
Return the WCS plane which the MLeader resides on.
```text
public override Plane GetPlane();
```

### GetTextAttachmentType

#### Description
Returns text attachment type of MText in MLeader content.
```text
public Autodesk.AutoCAD.DatabaseServices.TextAttachmentType GetTextAttachmentType(
    Autodesk.AutoCAD.DatabaseServices.LeaderDirectionType leaderDirection
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.LeaderDirectionType leaderDirection | Input text leader direction type |

### GetVertex

#### Description
Gets position of the vertex with specified index in the leader line with a new position specified by point.
```text
public Point3d GetVertex(
    int leaderLineIndex, 
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input leader line index. |
| int index | Input index of the vertex. |

### HasContent

#### Description
Returns true if MLeader has content; otherwise, returns false.
```text
public bool HasContent();
```

### MoveMLeader

#### Description
Moves MLeader according to the vector.
```text
public void MoveMLeader(
    Vector3d vec, 
    Autodesk.AutoCAD.DatabaseServices.MoveType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vector3d vec | Input vector indicate direction and distance the MLeader will be moved. |
| Autodesk.AutoCAD.DatabaseServices.MoveType type | Input MoveType indicate how the MLeader will be moved. |

### PostMLeaderToDb

#### Description
Adds current MLeader object to the modal space of input database.
```text
public void PostMLeaderToDb(
    Database db
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database db | Input database into which the current MLeader object should be added. |

### recomputeBreakPoints

#### Description
Recalculates the dim break point.
```text
public void recomputeBreakPoints();
```

### RemoveFirstVertex

#### Description
Removes the head of the leader line with specified index. The second vertex in this leader line becomes the new head.
```text
public void RemoveFirstVertex(
    int leaderLineIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input leader line index. |

### RemoveLastVertex

#### Description
Removes the leader tail of specified leader line.
```text
public void RemoveLastVertex(
    int leaderLineIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input leader line index. |

### RemoveLeader

#### Description
Removes the leader cluster with specified index.
```text
public void RemoveLeader(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input the index of the leader to be removed. |

### RemoveLeaderLine

#### Description
Removes the leader line with specified index.
```text
public void RemoveLeaderLine(
    int leaderLineIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input the index of leader cluster. |

### SetArrowSymbolId

#### Description
Sets the arrow head symbol id for the specific leaderline.
```text
public void SetArrowSymbolId(
    int leaderLineIndex, 
    ObjectId id
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input the index of the specific leaderline. |
| ObjectId id | Input the object id of the arrow head symbol. |

### SetBlockAttribute

#### Description
Set attribute in block content with attribute definition id.
```text
public void SetBlockAttribute(
    ObjectId attDefId, 
    AttributeReference attributeValue
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId attDefId | Input attribute definition id. |
| AttributeReference attributeValue | Input attribute value. |

### SetContextDataManager

#### Description
Sets the context data manager to MLeader.
```text
public void SetContextDataManager(
    IntPtr contextDataManager
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IntPtr contextDataManager | Input the pointer of context data manager. |

### SetDogleg

#### Description
Sets the dog-leg in the leader cluster specified by leaderIndex with vector.
```text
public void SetDogleg(
    int leaderIndex, 
    Vector3d vector
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderIndex | Input leader index. |
| Vector3d vector | Input the vector represents the new length and new direction of dog-leg. |

### SetDoglegLength

#### Description
Set the length of doglegs in the leader cluster specified by leaderIndex.
```text
public void SetDoglegLength(
    int leaderIndex, 
    double doglegLength
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderIndex | Input leader index |
| double doglegLength | Input the length of dog-leg leader line |

### SetFirstVertex

#### Description
Sets the leader head with specified point.
```text
public void SetFirstVertex(
    int leaderLineIndex, 
    Point3d point
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input the leader line index. |
| Point3d point | Input the point where the new leader head is on. |

### SetLastVertex

#### Description
Sets leader tail with specified point.
```text
public void SetLastVertex(
    int leaderLineIndex, 
    Point3d point
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input the leader line index. |
| Point3d point | Input the point where the new leader tail is on. |

### SetPlane

#### Description
Sets the plane that will contain the MLeader object. This leader's data members will be updated to reflect the change of plane. To do this, a transformation matrix will be created that will translate all points from the current plane's coordinate system to the new plane's coordinate system--a projection is not used.
```text
public virtual void SetPlane(
    Plane value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Plane value | Input desired plane within which the MLeader will reside. |

### SetTextAttachmentType

#### Description
Sets text attachment type of MText content to a specific direction leader.
```text
public void SetTextAttachmentType(
    Autodesk.AutoCAD.DatabaseServices.TextAttachmentType textAttachmentType, 
    Autodesk.AutoCAD.DatabaseServices.LeaderDirectionType leaderDirection
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.TextAttachmentType textAttachmentType | Input text attachment type |
| Autodesk.AutoCAD.DatabaseServices.LeaderDirectionType leaderDirection | Input text leader direction types |

### SetVertex

#### Description
Sets the vertex with specified index in the leader line with a new position specified by point.
```text
public void SetVertex(
    int leaderLineIndex, 
    int index, 
    Point3d point
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input leader line index. |
| int index | Input the index of vertex. |
| Point3d point | Input the new position of this vertex. |

### VerticesCount

#### Description
Returns the number of vertices on a leader line.
```text
public int VerticesCount(
    int leaderLineIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int leaderLineIndex | Input leader line index. |

### ArrowSize

#### Description
Accesses the arrow size.
```text
public double ArrowSize;
```

#### Conditions
Read / Write
### ArrowSymbolId

#### Description
Accesses the objectId of current arrow symbol.
```text
public ObjectId ArrowSymbolId;
```

#### Conditions
Read / Write
### BlockColor

#### Description
Accesses the block color in block content.
```text
public Autodesk.AutoCAD.Colors.Color BlockColor;
```

#### Conditions
Read / Write
### BlockConnectionType

#### Description
Accesses how the block is connected with leader lines.
```text
public Autodesk.AutoCAD.DatabaseServices.BlockConnectionType BlockConnectionType;
```

#### Conditions
Read / Write
### BlockContentId

#### Description
Accesses the id of referenced block.
```text
public ObjectId BlockContentId;
```

#### Conditions
Read / Write
### BlockPosition

#### Description
Accesses the position of MLeader block content.
```text
public Point3d BlockPosition;
```

#### Conditions
Read / Write
### BlockRotation

#### Description
Accesses the rotation of referenced block.
```text
public double BlockRotation;
```

#### Conditions
Read / Write
### BlockScale

#### Description
Accesses the scale of referenced block.
```text
public Scale3d BlockScale;
```

#### Conditions
Read / Write
### ContentType

#### Description
Accesses the content type of MLeader object.
```text
public Autodesk.AutoCAD.DatabaseServices.ContentType ContentType;
```

#### Conditions
Read / Write
### DoglegLength

#### Description
Accesses the length of dog-leg leader line.
```text
public double DoglegLength;
```

#### Conditions
Read / Write
### EnableAnnotationScale

#### Description
Assesses if annotation scale is enabled
```text
public bool EnableAnnotationScale;
```

#### Conditions
Read / Write
### EnableDogleg

#### Description
Assesses if dog-leg leader line is enabled
```text
public bool EnableDogleg;
```

#### Conditions
Read / Write
### EnableFrameText

#### Description
Assesses if text frame of MText is visible
```text
public bool EnableFrameText;
```

#### Conditions
Read / Write
### EnableLanding

#### Description
Assesses whether landing of leader line is enabled
```text
public bool EnableLanding;
```

#### Conditions
Read / Write
### ExtendLeaderToText

#### Description
Gets and Sets the value indicating whether horizontal leader lines are automatically extended to text.
```text
public bool ExtendLeaderToText;
```

### LandingGap

#### Description
Accesses the gap between leader tail and MText.
```text
public double LandingGap;
```

#### Conditions
Read / Write
### LeaderCount

#### Description
Accesses the number of leaders.
```text
public int LeaderCount;
```

#### Conditions
Read-only
### LeaderLineColor

#### Description
Accesses the color of leader lines.
```text
public Autodesk.AutoCAD.Colors.Color LeaderLineColor;
```

#### Conditions
Read / Write
### LeaderLineCount

#### Description
Accesses the number of leader lines.
```text
public int LeaderLineCount;
```

#### Conditions
Read-only
### LeaderLineType

#### Description
Accesses the leader line type.
```text
public Autodesk.AutoCAD.DatabaseServices.LeaderType LeaderLineType;
```

#### Conditions
Read / Write
### LeaderLineTypeId

#### Description
Accesses the objectId of leader line type.
```text
public ObjectId LeaderLineTypeId;
```

#### Conditions
Read / Write
### LeaderLineWeight

#### Description
Accesses the line weight of leader lines.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight LeaderLineWeight;
```

#### Conditions
Read / Write
### MLeaderStyle

#### Description
Accesses the object ID of current MLeader style.
```text
public ObjectId MLeaderStyle;
```

#### Conditions
Read / Write
### MText

#### Description
Accesses the cloned MText.
```text
public Autodesk.AutoCAD.DatabaseServices.MText MText;
```

#### Conditions
Read / Write
### Normal

#### Description
Accesses the unit normal vector (in WCS coordinates) of the plane that contains the leader.
```text
public virtual Vector3d Normal;
```

#### Conditions
Read-only
### Scale

#### Description
Gets or sets the scale for the MLeader.
```text
public double Scale;
```

#### Conditions
Read / Write
### TextAlignmentType

#### Description
Accesses the text alignment type of Mtext in MLeader content.
```text
public Autodesk.AutoCAD.DatabaseServices.TextAlignmentType TextAlignmentType;
```

#### Conditions
Read / Write
### TextAngleType

#### Description
Accesses the angle type of text with respect to the last leader line segment.
```text
public Autodesk.AutoCAD.DatabaseServices.TextAngleType TextAngleType;
```

#### Conditions
Read / Write
### TextAttachmentDirection

#### Description
Accesses the value of the text attachment Direction of MText content.
```text
public Autodesk.AutoCAD.DatabaseServices.TextAttachmentDirection TextAttachmentDirection;
```

#### Conditions
Read / write
### TextAttachmentType

#### Description
Accesses the text attachment type of MText in MLeader content.
```text
public Autodesk.AutoCAD.DatabaseServices.TextAttachmentType TextAttachmentType;
```

#### Conditions
Read / Write
### TextColor

#### Description
Accesses the text color of Mtext in MLeader content.
```text
public Autodesk.AutoCAD.Colors.Color TextColor;
```

#### Conditions
Read / Write
### TextHeight

#### Description
Accesses the text height of MText in MLeader content.
```text
public double TextHeight;
```

#### Conditions
Read / Write
### TextLocation

#### Description
Accesses the location of MLeader MText content.
```text
public Point3d TextLocation;
```

#### Conditions
Read / Write
### TextStyleId

#### Description
Accesses the objectId of current text style.
```text
public ObjectId TextStyleId;
```

#### Conditions
Read / Write
### ToleranceLocation

#### Description
Accesses the location of MLeader tolerance content.
```text
public Point3d ToleranceLocation;
```

#### Conditions
Read / Write