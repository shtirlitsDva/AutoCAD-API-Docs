# Leader Class

## Overview

#### Description
This .NET class wraps the AcDbLeader ObjectARX class. 
The Leader class represents the LEADER entity within AutoCAD. Leaders are considered as dimensions in AutoCAD, which means they are controlled by dimension variable settings and dimension styles. 
This class contains a dynamic array of points that are the vertices for the leader line. The first point in the array is the start of the leader. If the leader has an arrowhead it is located here. If the length of the first segment of the leader is less than twice the arrowhead size the arrowhead is suppressed. If the leader has an associated annotation object the last point of the leader is placed near it. 
By default a leader has straight line segments, but it may be set to fit a spline to the vertexes. 
To update the leader endpoint position relative to its associated annotation use the EvaluateLeader() method.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Leader
```

```text
public class Leader : Curve;
```

#### Notes
This class overrides Entity.SubSetDatabaseDefaults() to set the object's dimension style (dimstyle) to the current style for the database. Typically objects of this class are initialized with a call to SetDatabaseDefaults() followed by a call to SetDimstyleData() using data obtained by a call to DatabaseGetDimstyleData(). 
If the leader is associated to an annotation object, the final end point of the leader is placed so as to attach to the annotation, that is the final point in the leader point array is ignored! You may also find that you must force it to happen sometimes by using Leader.EvaluateLeader().
#### See Also
[MText](Autodesk_AutoCAD_DatabaseServices_MText.md "MText Class"), BlockReference, FeatureControlFrame, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), [Point3d](Autodesk_AutoCAD_Geometry_Point3d.md), DBObject, ObjectId

## Members

### Constructors

- [Leader](#leader)

### Methods

- [AppendVertex](#appendvertex)
- [EvaluateLeader](#evaluateleader)
- [GetDimstyleData](#getdimstyledata)
- [RemoveLastVertex](#removelastvertex)
- [SetDimstyleData](#setdimstyledata)
- [SetPlane](#setplane)
- [SetVertexAt](#setvertexat)
- [VertexAt](#vertexat)

### Properties

- [AnnoHeight](#annoheight)
- [Annotation](#annotation)
- [AnnotationOffset](#annotationoffset)
- [AnnoType](#annotype)
- [AnnoWidth](#annowidth)
- [Dimasz](#dimasz)
- [Dimclrd](#dimclrd)
- [DimensionStyle](#dimensionstyle)
- [DimensionStyleName](#dimensionstylename)
- [Dimgap](#dimgap)
- [Dimldrblk](#dimldrblk)
- [Dimlwd](#dimlwd)
- [Dimsah](#dimsah)
- [Dimscale](#dimscale)
- [Dimtad](#dimtad)
- [Dimtxt](#dimtxt)
- [FirstVertex](#firstvertex)
- [HasArrowHead](#hasarrowhead)
- [HasHookLine](#hashookline)
- [IsSplined](#issplined)
- [LastVertex](#lastvertex)
- [Normal](#normal)
- [NumVertices](#numvertices)


## Constructors Details

### Leader

#### Description
Default constructor.
```text
public Leader();
```

### AppendVertex

#### Description
Appends vertex to the end of the vertex list for this leader. If vertex is not in the plane of the leader, then it will be projected parallel the leader's normal onto the leader's plane and the projection will be appended to the leader's vertex list. If the new vertex is too close to the one next to it (that is, within 1.e-10 for X, Y, and Z), the new vertex will not be appended. 
Returns true if the vertex is successfully appended, false if the append fails. 
Note
This function breaks associativity.
```text
public virtual bool AppendVertex(
    Point3d pointToAdd
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d pointToAdd | Input point (in WCS coordinates) to add to the vertex list |

### EvaluateLeader

#### Description
Evaluate the relation of the leader to its associated annotation, and update the leader geometry if necessary. 
This call may change the location of the final point of the leader, and it will remove associativity completely in either of these cases: 
  * The leader's annotation ID is not a valid entity ID.
  * The leader's objectId is not present as a persistent reactor on the annotation object.

```text
public virtual void EvaluateLeader();
```

### GetDimstyleData

#### Description
This function returns the DimStyle information from the DimStyleTableRecord referenced by this object into the DimStyleTableRecord.
```text
public DimStyleTableRecord GetDimstyleData();
```

### RemoveLastVertex

#### Description
Removes the last vertex (the vertex at the annotation end) from the vertex list.
Note
This function breaks associativity.
```text
public virtual void RemoveLastVertex();
```

### SetDimstyleData

#### Description
Sets the leader to use the DimensionStyle (and dim overrides associated with it) specified by style.
```text
public void SetDimstyleData(
    DimStyleTableRecord style
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DimStyleTableRecord style | Input objectId of the desired DimensionStyle |

### SetPlane

#### Description
Sets the plane that will contain the leader object. This leader's data members will be updated to reflect the change of plane. To do this, a transformation matrix will be created that will translate all points from the current plane's coordinate system to the new plane's coordinate system--a projection is **not** used. 
**Note**
This function breaks associativity.
```text
public virtual void SetPlane(
    Plane value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Plane value | Input desired plane within which the leader will reside |

### SetVertexAt

#### Description
Resets the vertex at index to the point point projected (along the plane normal) onto the plane containing the leader. It doesn't reset the vertex if that would cause one of the segments to become zero length (within 1e-10). 
Returns true if the new vertex value is successfully set. Otherwise returns false.
```text
public virtual bool SetVertexAt(
    int index, 
    Point3d pointValue
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index number (0 based) of the vertex to change |
| Point3d pointValue | Input new point value (in WCS) to use |

### VertexAt

#### Description
Returns the Point3d that is the vertex at the location index (0 based) in this leader's vertex array.
```text
public virtual Point3d VertexAt(
    int value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int value | Input index number (0 based) of the vertex desired |

### AnnoHeight

#### Description
Accesses the annotation height. 
If the annotation is an MText, then the height returned is the actual height. If the annotation is an FeatureControlFrame, then the height returned is the height of the bounding box. For other annotation types, the height will be 0.0. 
```text
public double AnnoHeight;
```

#### Conditions
Read-only
### Annotation

#### Description
Accesses the leader's annotation ID.
```text
public virtual ObjectId Annotation;
```

#### Conditions
Read / Write
### AnnotationOffset

#### Description
```text
public virtual Vector3d AnnotationOffset;
```

#### Conditions
Read-only 
Read / Write
### AnnoType

#### Description
Accesses the leader's annotation type.
```text
public AnnotationType AnnoType;
```

#### Conditions
Read-only
### AnnoWidth

#### Description
Accesses the annotation width. 
If the annotation is an MText, then the width returned is the actual width. If the annotation is an FeatureControlFrame, then the width returned is the width of the bounding box. For other annotation types, the width will be 0.0.
```text
public double AnnoWidth;
```

#### Conditions
Read-only
### Dimasz

#### Description
Accesses the current DIMASZ value for the leader. If the value is overridden for this object, then that value is returned, otherwise the function will return the value from this dimension's dimension style. See the System Variables section of the _AutoCAD Command Reference_ manual for information on DIMASZ.
```text
public virtual double Dimasz;
```

#### Conditions
Read / Write
### Dimclrd

#### Description
Accesses the current DIMCLRD value for the leader. If the value is overridden for this object, then that value is returned, otherwise the function will return the value from this dimension's dimension style. See the System Variables section of the _AutoCAD Command Reference_ manual for information on DIMCLRD. 
**Note** You can use the Color.ColorIndex() method to obtain the AutoCAD color index number from the returned Color object. 
```text
public virtual Autodesk.AutoCAD.Colors.Color Dimclrd;
```

#### Conditions
Read / Write
### DimensionStyle

#### Description
Accesses the objectId of the DimensionStyle object referenced by the leader.
```text
public virtual ObjectId DimensionStyle;
```

#### Conditions
Read / Write
### DimensionStyleName

#### Description
Accesses the associated dimension style name.
```text
public string DimensionStyleName;
```

#### Conditions
Read / Write
### Dimgap

#### Description
Accesses the current DIMGAP value for the leader. If the value is overridden for this object, then that value is returned, otherwise the function will return the value from this dimension's dimension style. See the System Variables section of the _AutoCAD Command Reference_ for information on DIMGAP.
```text
public virtual double Dimgap;
```

#### Conditions
Read / Write
### Dimldrblk

#### Description
Accesses the object ID of the block reference that is the current DIMLDRBLK value for the leader. If the value is overridden for this leader, then that value is returned; otherwise, the function will return the value from this leader's dimension style. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMLDRBLK.
```text
public virtual ObjectId Dimldrblk;
```

#### Conditions
Read / Write
### Dimlwd

#### Description
Accesses the current DIMLWD value for the leader. If the value is overridden for this object, then that value is returned, otherwise the function will return the value from this dimension's dimension style. See the System Variables section of the _AutoCAD Command Reference_ for information on DIMLWD.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.LineWeight Dimlwd;
```

#### Conditions
Read / Write
### Dimsah

#### Description
Accesses the current DIMSAH value for the leader. If the value is overridden for this leader, then that value is returned; otherwise, the function will return the value from this leader's dimension style. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMSAH.
```text
public virtual bool Dimsah;
```

#### Conditions
Read / Write
### Dimscale

#### Description
Accesses the current DIMSCALE value for the leader. If the value is overridden for this object, then that value is returned, otherwise the function will return the value from this dimension's dimension style. See the System Variables section of the _AutoCAD Command Reference_ for information on DIMSCALE.
```text
public virtual double Dimscale;
```

#### Conditions
Read / Write
### Dimtad

#### Description
Accesses the current DIMTAD value for the leader. If the value is overridden for this object, then that value is returned, otherwise the function will return the value from this dimension's dimension style. See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTAD.
```text
public virtual int Dimtad;
```

#### Conditions
Read / Write
### Dimtxt

#### Description
Accesses the current DIMTXT value for the leader. If the value is overridden for this leader, then that value is returned; otherwise, the function will return the value from this leader's dimension style. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTXT.
```text
public virtual double Dimtxt;
```

#### Conditions
Read / Write
### FirstVertex

#### Description
Accesses the leader's start point in WCS coordinates. This will be the start of the arrowhead if enabled.
```text
public virtual Point3d FirstVertex;
```

#### Conditions
Read-only
### HasArrowHead

#### Description
Assesses if arrowhead is currently enabled for this leader.
```text
public virtual bool HasArrowHead;
```

#### Conditions
Read / Write
### HasHookLine

#### Description
Assesses if this leader has a hookline. The "hookline" is the small horizontal line at the end of the leader line just before the annotation. 
```text
public virtual bool HasHookLine;
```

#### Conditions
Read-only
### IsSplined

#### Description
Assesses if this leader is spline-fit.
```text
public virtual bool IsSplined;
```

#### Conditions
Read / Write
### LastVertex

#### Description
Accesses the leader's last vertex in WCS coordinates. This is the vertex at the end where the annotation is attached. 
Note that this may be a different value than set for the vertex if the associated annotation has been moved.
```text
public virtual Point3d LastVertex;
```

#### Conditions
Read-only
### Normal

#### Description
Accesses the unit normal that contains the leader.
```text
public virtual Vector3d Normal;
```

#### Conditions
Read-only
### NumVertices

#### Description
Accesses the number of vertices in the leader.
```text
public virtual int NumVertices;
```

#### Conditions
Read-only