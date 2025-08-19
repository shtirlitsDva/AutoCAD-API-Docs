# BlockTableRecord Class

## Overview

#### Description
This .NET class wraps the AcDbBlockTableRecord ObjectARX class. 
Objects of the BlockTableRecord class are used as containers for entities within drawing file databases. BlockTableRecord objects (often referred to as BTRs) are owned by the database’s BlockTable object. The BTRs in turn own the entity objects they contain. 
There are two special BTRs that are always present in every database. They are *MODEL_SPACE and *PAPER_SPACE. They are the Model and Paper Spaces for the database. Any entity that is created by AutoCAD while in Model Space is owned and contained by the *MODEL_SPACE BTR. Entities created while in Paper Space go into the *PAPER_SPACE BTR. 
BTRs other than *MODEL_SPACE and *PAPER_SPACE were known in previous versions of AutoCAD as block definitions and are referenced by BlockReferences (which are often referred to as inserts). The BTR contains a collection of entities that can be referenced by multiple inserts to save space in the drawing, save time in drawing creation, and guarantee that all inserts will appear the same (except possibly in color and linetype).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTableRecord
        Autodesk.AutoCAD.DatabaseServices.BlockTableRecord
```

```text
public class BlockTableRecord : SymbolTableRecord, IEnumerable;
```

#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), BlockTable, BlockReference

## Members

### Constructors

- [BlockTableRecord](#blocktablerecord)

### Events

- [BlockInsertionPoints](#blockinsertionpoints)

### Methods

- [AppendEntity](#appendentity)
- [AssumeOwnershipOf](#assumeownershipof)
- [GetAnonymousBlockIds](#getanonymousblockids)
- [GetBlockReferenceIds](#getblockreferenceids)
- [GetEnumerator](#getenumerator)
- [GetErasedBlockReferenceIds](#geterasedblockreferenceids)
- [GetXrefDatabase](#getxrefdatabase)
- [UpdateAnonymousBlocks](#updateanonymousblocks)

### Properties

- [BlockBeginId](#blockbeginid)
- [BlockEndId](#blockendid)
- [BlockScaling](#blockscaling)
- [Comments](#comments)
- [DrawOrderTableId](#drawordertableid)
- [Explodable](#explodable)
- [HasAttributeDefinitions](#hasattributedefinitions)
- [HasPreviewIcon](#haspreviewicon)
- [Hyperlinks](#hyperlinks)
- [IncludingErased](#includingerased)
- [IsAnonymous](#isanonymous)
- [IsDynamicBlock](#isdynamicblock)
- [IsFromExternalReference](#isfromexternalreference)
- [IsFromOverlayReference](#isfromoverlayreference)
- [IsLayout](#islayout)
- [IsUnloaded](#isunloaded)
- [LayoutId](#layoutid)
- [Origin](#origin)
- [PathName](#pathname)
- [PreviewIcon](#previewicon)
- [Units](#units)
- [XrefStatus](#xrefstatus)


## Constructors Details

### BlockTableRecord

#### Description
Default constructor. Initializes the origin to (0,0,0); the IsAnonymous, HasAttributeDefinitions, IsFromExternalReference, and IsFromOverlayReference flags to false; and the PathName to NULL. In addition, the SymbolTableRecord default constructor is invoked.
```text
public BlockTableRecord();
```

### BlockInsertionPoints

#### Description
This event occurs during the insertion of a block for which an application has defined custom insertion points.
```text
public static event BlockInsertionPointsEventHandler BlockInsertionPoints;
```

### AppendEntity

#### Description
Adds entity to the database and the block table record.
```text
public ObjectId AppendEntity(
    [CallerMustClose] Entity entity
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [CallerMustClose] Entity entity | Input the object to append (must not be NULL) |

### AssumeOwnershipOf

#### Description
This method causes the invoked block table record to assume the ownership of all the entities listed in the input entitiesToMove collection, and provides an optimized way of moving entities between block table records.
```text
public void AssumeOwnershipOf(
    ObjectIdCollection entitiesToMove
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectIdCollection entitiesToMove | Input a collection of entities to change ownership of |

#### Conditions
This action takes place only after all of the following conditions are verified: 
  * The function is able to open all entities specified in entitiesToMove and write to them.
  * All entities reside in the same database as the target block table record.
  * The current entity owners are all instances of BlockTableRecord.

If all these conditions are met, then the ownership of all the entities is switched, the transaction for the prior owner block table records (BTRs) is closed, the entities are marked as modifed, and the change is recorded in the entities’ undo filers. 
Viewports and vertex, attribute or other AutoCAD subentities, or bracket entities are not supported. This is an all-or-nothing operation, that is, if one entity cannot be moved, none of them will be moved.
#### Notes
Calling this function on an entity that is already open for write will cause AutoCAD to terminate.
### GetAnonymousBlockIds

#### Description
Retrieves a collection populated with the ObjectIds of the anonymous blocks created from the dynamic block definition.
```text
public ObjectIdCollection GetAnonymousBlockIds();
```

### GetBlockReferenceIds

#### Description
This function returns a list of BlockReferences that either directly or indirectly, through block nesting, reference this block. It only returns those block references that are currently active. Use getErasedBlockReferenceIds() to get a list of erased references.
```text
public ObjectIdCollection GetBlockReferenceIds(
    [MarshalAs(UnmanagedType.U1)] bool directOnly, 
    [MarshalAs(UnmanagedType.U1)] bool forceValidity
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool directOnly | Input an indication that only those BlockReferences that directly refer to this BlockTableRecord should be included in the IDs. If this value is true and the block is nested, the parent block's references will not be included. |
| [MarshalAs(UnmanagedType.U1)] bool forceValidity | Input an indication that older drawings which have been demand loaded should be loaded completely, in order to find their BlockReferenceIds. This is because older drawings did not store this information. This parameter is only applicable if directOnly is false. |

#### Notes
Callers need to decide what the most efficient setting will be for forceValidity. For example, if the caller wants the set of IDs in order to queue the BlockReferences for regen in order to avoid calling REGENALL, then it would probably be less costly to set forceValidity to false, and do the REGENALL. 
A full regen would be faster, and better memory management, than forcing the entire file into memory. However, if the function is being called for block cycle detection, then forceValidity must be true in order to guarantee that all block references (potential cycles) have been found.
### GetEnumerator

#### Description
Returns an enumerator that iterates through the collection.
```text
public BlockTableRecordEnumerator GetEnumerator();
```

### GetErasedBlockReferenceIds

#### Description
This function returns a list of BlockReferences that directly reference this block. It only returns those block references that have been erased.
```text
public ObjectIdCollection GetErasedBlockReferenceIds();
```

### GetXrefDatabase

#### Description
This function returns the database that defines this block table record’s contents. If incrementUnresolved is true, then a database will be returned, even if the xref block table record is currently unresolved (for reasons other than that the xref drawing file could not be found).
```text
public Database GetXrefDatabase(
    [MarshalAs(UnmanagedType.U1)] bool incrementUnresolved
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool incrementUnresolved | Input an indication whether or not to return the database of an unresolved xref |

### UpdateAnonymousBlocks

#### Description
Updates the anonymous blocks created from this dynamic block definition to reflect any changes made to the dynamic block definition. 
Calling this method after updating a dynamic block definition causes AutoCAD to replace all anonymous block definitions created from this definition with new anonymous block definitions, thereby causing all references to reflect changes made to the dynamic block. The update preserves the values of dynamic block properties on the references where possible, adding newly created properties and deleting properties that no longer exist. When complete all references to the dynamic block reflect the new state of the block definition.
```text
public void UpdateAnonymousBlocks();
```

### BlockBeginId

#### Description
Returns the the block begin opened openMode.
```text
public ObjectId BlockBeginId;
```

#### Conditions
Read-only
### BlockEndId

#### Description
Returns the the block end opened openMode.
```text
public ObjectId BlockEndId;
```

#### Conditions
Read-only
### BlockScaling

#### Description
Specifies whether block references associated with this block table record can be uniformly or non-uniformly scaled.
```text
public Autodesk.AutoCAD.DatabaseServices.BlockScaling BlockScaling;
```

#### Conditions
Read / Write
### Comments

#### Description
Accesses the description text associated with the BlockTableRecord.
```text
public string Comments;
```

#### Conditions
Read / Write
### DrawOrderTableId

#### Description
Returns the DrawOrderTable object ID.
```text
public ObjectId DrawOrderTableId;
```

#### Conditions
Read-only
### Explodable

#### Description
Specifies whether block references associated with this block table record can be exploded.
```text
public bool Explodable;
```

#### Conditions
Read / Write
### HasAttributeDefinitions

#### Description
Returns true if the block table record contains attribute definitions.
```text
public bool HasAttributeDefinitions;
```

#### Conditions
Read-only
### HasPreviewIcon

#### Description
Returns true if the block table record has a preview icon.
```text
public bool HasPreviewIcon;
```

#### Conditions
Read-only
### Hyperlinks

#### Description
Accesses a collection of hyperlinks associated with the BlockTableRecord.
```text
public HyperLinkCollection Hyperlinks;
```

#### Conditions
Read-Only.
### IncludingErased

#### Description
Returns the IncludingErased property value.
```text
public BlockTableRecord IncludingErased;
```

#### Conditions
Read-only
### IsAnonymous

#### Description
Returns true if the block table record is anonymous.
```text
public bool IsAnonymous;
```

#### Conditions
Read-only
#### Notes
The IsAnonymous value is used for the first bit in DXF group code 70
### IsDynamicBlock

#### Description
Returns true if the block table record is a dynamic block.
```text
public bool IsDynamicBlock;
```

#### Conditions
Read-only
### IsFromExternalReference

#### Description
Returns true if the block table record is describing an xref drawing.
```text
public bool IsFromExternalReference;
```

#### Conditions
Read-only
#### Notes
The IsFromExternalReference value is used for the third bit in DXF group code 70
### IsFromOverlayReference

#### Description
Gets and sets the BlockTableRecord's overlay flag. 
Wraps the ObjectARX [AcDbBlockTableRecord::isFromOverlayReference](AcDbBlockTableRecord__isFromOverlayReference.md)() and [AcDbBlockTableRecord::setIsFromOverlayReference](AcDbBlockTableRecord__isFromOverlayReference.md)() methods.
```text
public bool IsFromOverlayReference;
```

#### Conditions
Read / write
### IsLayout

#### Description
Returns true if this block table record represents a layout.
```text
public bool IsLayout;
```

#### Conditions
Read-only
### IsUnloaded

#### Description
Returns true if this block table record is an xref that is currently unloaded
```text
public bool IsUnloaded;
```

#### Conditions
Read / Write
### LayoutId

#### Description
Accesses the layout ID.
```text
public ObjectId LayoutId;
```

#### Conditions
Read / Write
### Origin

#### Description
Accesses the insertion point of the block table record in WCS coordinates. This point is the origin of the MCS (which is the local WCS for the entities within the block table record).
```text
public Point3d Origin;
```

#### Conditions
Read / Write
#### Notes
For all block table records created by AutoCAD versions after Release 10, this point is always (0,0,0). It is highly recommended that this point be left at (0,0,0). 
The origin value is used for DXF group code 10.
### PathName

#### Description
Accesses the path and name of the xref drawing. If this block table record is not an xref, then this string will be copied into the block table record, but will not be used.
```text
public string PathName;
```

#### Conditions
Read / Write
#### Notes
The pathName value is used for DXF group code 1.
### PreviewIcon

#### Description
Accesses the preview icon.
```text
public Bitmap PreviewIcon;
```

#### Conditions
Read / Write
### Units

#### Description
Accesses the units value.
```text
public Autodesk.AutoCAD.DatabaseServices.UnitsValue Units;
```

#### Conditions
Read / Write
### XrefStatus

#### Description
Retrieves the xref status of the block table record on which this method is called.
```text
public Autodesk.AutoCAD.DatabaseServices.XrefStatus XrefStatus;
```

#### Conditions
Read-only