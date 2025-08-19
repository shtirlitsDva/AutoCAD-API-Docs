# BlockReference Class

## Overview

#### Description
This .NET class wraps the AcDbBlockReference ObjectARX class. 
The BlockReference class represents the INSERT entity within AutoCAD. A block reference is used to place, size, and display an instance of the collection of entities within the BlockTableRecord that it references. In addition, block references can be the owner of Attribute entities (the list of which is automatically terminated by an SequenceEnd entity). 
Classes Derived from AcDbBlockReference
Classes derived from BlockReference must supermessage the base class's WorldDraw() function and allow it to do the work of drawing the entities in the block table record. This allows the osnap code to distinguish the graphics for each entity in the block table record and automatically get each entity's osnap points without having to iterate through the block reference.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.BlockReference
            Autodesk.AutoCAD.DatabaseServices.MInsertBlock
            Autodesk.AutoCAD.DatabaseServices.Table
            Autodesk.AutoCAD.DatabaseServices.ViewRepBlockReference
```

```text
public class BlockReference : Entity;
```

#### Notes
The controlling application must explicitly delete the subentities of any complex entity that is not database resident. Otherwise, a small memory leak will result. 
When the entities within the BlockTableRecord referenced by the block reference are resolved for display, the WCS for the entities within the block table record is mapped onto a coordinate system, which is essentially the OCS of the block reference. The origin is translated to the block reference's position point and the _X_ and _Y_ axes are rotated around the _Z_ axis by the amount of the block reference's rotation value. The rotation value is in radians with positive going counterclockwise when looking down the _Z_ axis towards the origin. 
Any _X, Y, Z_ scaling of the block reference is applied to the entities relative to their perceived WCS coordinate axes. This makes it possible to orient a scaled version of the entities in any way desired. 
The BlockTransform property will return a matrix that represents the coordinate system mapping (including the scaling) described above. 
Classes derived from BlockReference cannot append attributes. This is by design.
### Constructors

- [BlockReference](#blockreference)

### Methods

- [ConvertToStaticBlock()](#converttostaticblock())
- [ConvertToStaticBlock(string)](#converttostaticblock(string))
- [ExplodeToOwnerSpace](#explodetoownerspace)
- [GeometryExtentsBestFit()](#geometryextentsbestfit())
- [GeometryExtentsBestFit(Matrix3d)](#geometryextentsbestfit(matrix3d))
- [ResetBlock](#resetblock)

### Properties

- [AnonymousBlockTableRecord](#anonymousblocktablerecord)
- [AttributeCollection](#attributecollection)
- [BlockTableRecord](#blocktablerecord)
- [BlockTransform](#blocktransform)
- [BlockUnit](#blockunit)
- [DynamicBlockReferencePropertyCollection](#dynamicblockreferencepropertycollection)
- [DynamicBlockTableRecord](#dynamicblocktablerecord)
- [IsDynamicBlock](#isdynamicblock)
- [Name](#name)
- [Normal](#normal)
- [Position](#position)
- [Rotation](#rotation)
- [ScaleFactors](#scalefactors)
- [TreatAsBlockRefForExplode](#treatasblockrefforexplode)
- [UnitFactor](#unitfactor)


## Constructors Details

### BlockReference

#### Description
This constructor initializes the block reference to use position (in WCS) as the position point; blockTableRecord as the object ID of the block table record to reference; the X, Y, and Z scale factors to 1.0; the rotation to 0.0; and the normal vector to (0,0,1).
```text
public BlockReference(
    Point3d position, 
    ObjectId blockTableRecord
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d position | Input Autodesk.AutoCAD.Geometry.Point3d object, the position point |
| ObjectId blockTableRecord | Input Autodesk.AutoCAD.DatabaseServices.ObjectId object, the object ID of BlockTableRecord to reference |

### ConvertToStaticBlock()

#### Description
Converts the dynamic block instance to a legacy (non-dynamic) anonymous block.
```text
public virtual void ConvertToStaticBlock();
```

#### Notes
When successful, the block reference freezes the dynamic block properties at their current values and ceases to be a dynamic block. It becomes an anonymous block for all purposes.
### ConvertToStaticBlock(string)

#### Description
Converts the dynamic block instance to a legacy (non-dynamic) block.
```text
public virtual void ConvertToStaticBlock(
    string newBlockName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string newBlockName | Input the name of the new block definition |

#### Notes
When successful, the dynamic block properties are frozen at their current values and the reference ceases to be a dynamic block. A new block is defined with the name newBlockName, which must not already exist in the drawing and must satisfy all of the naming restrictions of normal block references.
### ExplodeToOwnerSpace

#### Description
Explodes the block reference into individual components. It appends the resulting entities to the BlockTableRecord that owns the BlockReference on which this method was called.
```text
public virtual void ExplodeToOwnerSpace();
```

#### Notes
BlockReference must be in a database and must be uniformly scaled.
### GeometryExtentsBestFit()

#### Description
Retrieves copies of all the entities in the referenced block table record.
```text
public Extents3d GeometryExtentsBestFit();
```

### GeometryExtentsBestFit(Matrix3d)

#### Description
Retrieves copies of all the entities in the referenced block table record, applying parentTransform to them, and then calculating the extents on the resulting entity set.
```text
public Extents3d GeometryExtentsBestFit(
    Matrix3d parentTransform
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Matrix3d parentTransform | Input Autodesk.AutoCAD.Geometry.Matrix3d transformation to be applied to the block reference’s geometry |

#### Notes
This method works recursively for nested block references. When this method is called on the outermost block reference (the normal case for applications), parentTransform should be the identity matrix. For calls on nested block references, parentTransform should be the cumulative transformation from the outermost block reference down to the block reference that is referencing the block table record that owns the block reference on which this method is being called
### ResetBlock

#### Description
Resets the BlockReference to the default state of the dynamic block.
```text
public virtual void ResetBlock();
```

### AnonymousBlockTableRecord

#### Description
Returns the anonymous block definition used to draw the dynamic block.
```text
public ObjectId AnonymousBlockTableRecord;
```

#### Conditions
Read-only
### AttributeCollection

#### Description
Returns the AttributeCollection property value.
```text
public Autodesk.AutoCAD.DatabaseServices.AttributeCollection AttributeCollection;
```

#### Conditions
Read-only
### BlockTableRecord

#### Description
Accesses the object ID of the BlockTableRecord referenced by the block reference.
```text
public ObjectId BlockTableRecord;
```

#### Conditions
Read / Write
### BlockTransform

#### Description
Accesses the block reference’s position (insertion point), normal vector, scale factors, and rotation so that the resulting MCS-to-drawing-WCS transform is the same as the transform matrix. MCS is the WCS within the block table record’s microspace.
```text
public Matrix3d BlockTransform;
```

#### Conditions
Read / Write
### BlockUnit

#### Description
Accesses the units associated with block.
```text
public Autodesk.AutoCAD.DatabaseServices.UnitsValue BlockUnit;
```

#### Conditions
Read / Write
### DynamicBlockReferencePropertyCollection

#### Description
Returns the collection the dynamic block (a BlockTableRecord) is a part of, if the block reference is a dynamic block.
```text
public Autodesk.AutoCAD.DatabaseServices.DynamicBlockReferencePropertyCollection DynamicBlockReferencePropertyCollection;
```

#### Conditions
Read-only
### DynamicBlockTableRecord

#### Description
Returns the object ID of the dynamic block definition (a BlockTableRecord) if the block reference is a dynamic block.
```text
public ObjectId DynamicBlockTableRecord;
```

#### Conditions
Read-only
### IsDynamicBlock

#### Description
Determines whether the BlockReference passed to the class constructor contains dynamic block information.
```text
public bool IsDynamicBlock;
```

#### Conditions
Read-only
### Name

#### Description
Returns the name of the associated BlockTableRecord.
```text
public string Name;
```

#### Conditions
Read-only
### Normal

#### Description
Accesses the normal vector (in WCS coordinates) of the plane containing the block reference.
```text
public Vector3d Normal;
```

#### Conditions
Read-only
### Position

#### Description
Accesses the position value (often referred to as the insertion point), in WCS coordinates.
```text
public Point3d Position;
```

#### Conditions
Read / Write
#### Notes
The position value is the WCS equivalent of the DXF group code 10.
### Rotation

#### Description
Accesses the rotation value (in radians) of the block reference. The rotation value is relative to the _X_ axis of a coordinate system that is parallel to the OCS of the block reference, but has its origin at the position point of the block reference. The rotation axis is the _Z_ axis of this coordinate system with positive rotations going counterclockwise when looking down the _Z_ axis towards the origin.
```text
public double Rotation;
```

#### Conditions
Read / Write
#### Notes
The rotation value is used for DXF group code 50.
### ScaleFactors

#### Description
Accesses the block reference to use the _X_ , _Y_ , and _Z_ scale factors contained in scale.
```text
public Scale3d ScaleFactors;
```

#### Conditions
Read / Write
#### Notes
The _X_ , _Y_ , and _Z_ scaling of the block reference is applied to the entities in the referenced block table record relative to their perceived WCS coordinate axes, which may or may not be the same as the drawing’s WCS axes. 
The _X_ scale factor value is used for DXF group code 41. 
The _Y_ scale factor value is used for DXF group code 42. 
The _Z_ scale factor value is used for DXF group code 43.
### TreatAsBlockRefForExplode

#### Description
Called by the AutoCAD EXPLODE command to determine how the entity should be exploded.
```text
public virtual bool TreatAsBlockRefForExplode;
```

#### Conditions
Read-only
#### Notes
The default value is to false, which will result in the entity's explode() method being used. 
If the entity's class implementation has overridden this method and has it return true, then the AutoCAD EXPLODE command will treat the entity as though it is an actual BlockReference object and will use AutoCAD's internal code to do the explode operation.
### UnitFactor

#### Description
Returns the unit factor.
```text
public double UnitFactor;
```

#### Conditions
Read-only