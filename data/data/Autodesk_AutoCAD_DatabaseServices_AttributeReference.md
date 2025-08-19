# AttributeReference Class

## Overview

#### Description
This .NET class wraps the AcDbAttribute ObjectARX class. 
The Attribute class represents the ATTRIB entity within AutoCAD. ATTRIB entities are associated with INSERT entities (BlockReference objects).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.DBText
            Autodesk.AutoCAD.DatabaseServices.AttributeReference
```

```text
public class AttributeReference : DBText;
```

#### Notes
To set all the non-AttributeReference-specific properties such as position, text string, text height, text rotation, and others, for the attribute, use the methods inherited from Text.
#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), BlockReference, AttributeDefinition

## Members

### Constructors

- [AttributeReference()](#attributereference())

### Methods

- [SetAttributeFromBlock(AttributeDefinition, Matrix3d)](#setattributefromblock(attributedefinition,-matrix3d))
- [SetAttributeFromBlock(Matrix3d)](#setattributefromblock(matrix3d))
- [UpdateMTextAttribute](#updatemtextattribute)

### Properties

- [FieldLength](#fieldlength)
- [Invisible](#invisible)
- [IsConstant](#isconstant)
- [IsMTextAttribute](#ismtextattribute)
- [IsPreset](#ispreset)
- [IsVerifiable](#isverifiable)
- [LockPositionInBlock](#lockpositioninblock)
- [MTextAttribute](#mtextattribute)
- [Tag](#tag)


## Constructors Details

### AttributeReference()

#### Description
Default constructor. Initializes the field length to 0, the flags to 0 (that is, non-constant, visible, not preset, and not verifiable), and the tag to 0. In addition, all the initializations for a default new DBText object take place.
```text
public AttributeReference();
public AttributeReference(
    Point3d position, 
    string value, 
    string tag, 
    ObjectId style
);
```

### SetAttributeFromBlock(AttributeDefinition, Matrix3d)

#### Description
Uses definition as a template for the attributes textual, entity, and starting geometric properties (in other words, it copies this information from the attribute definition into the attribute). It then applies blockTransform to transform the position, sizing, and obliquing as would be done by the INSERT command.
```text
public void SetAttributeFromBlock(
    AttributeDefinition definition, 
    Matrix3d blockTransform
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AttributeDefinition definition | Input the the attribute definition entity to be used as a data template |
| Matrix3d blockTransform | Input a block transformation matrix. |

### SetAttributeFromBlock(Matrix3d)

#### Description
Applies blockTransform to the attribute's geometric data to transform the position, sizing, and obliquing as would be done by the INSERT command. The attribute's textual and entity properties data is left alone.
```text
public void SetAttributeFromBlock(
    Matrix3d blockTransform
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Matrix3d blockTransform | Input a block transformation matrix. |

### UpdateMTextAttribute

#### Description
Updates the internal MText entity from the basic AttributeReference properties.
```text
public void UpdateMTextAttribute();
```

### FieldLength

#### Description
Accesses the attribute’s field length value. This value is not currently used within AutoCAD.
```text
public int FieldLength;
```

#### Conditions
Read / Write
#### Notes
The field length value is used for DXF group code 73.
### Invisible

#### Description
Accesses the visibility flag of the AttributeReference. If invisible is true, then the AttributeReference object is set to be invisible.
```text
public bool Invisible;
```

#### Conditions
Read / Write
#### Notes
This function reflects the setting on bit 1 of DXF group code 70 (that is, if bit 1 is set, then attributes created with this AttributeReference as a template will be invisible).
### IsConstant

#### Description
Returns true if the AttributeReference object is set to be constant.
```text
public bool IsConstant;
```

#### Conditions
Read-only
#### Notes
This function reflects the setting on bit 2 of DXF group code 70 (that is, if bit 2 is set then the attribute will use the preset value and not prompt for user input). 
AutoCAD itself never creates a constant AttributeReference object. AutoCAD creates the AttributeReference objects for each BlockReference based on the AttributeDefinition objects within the referenced BlockTableRecord. If a constant AttributeDefinition is encountered, then AutoCAD uses the AttributeDefinition itself instead of creating a matching AttributeReference.
### IsMTextAttribute

#### Description
Returns true if the attribute is a multi-line attribute.
```text
public bool IsMTextAttribute;
```

#### Conditions
Read-only
### IsPreset

#### Description
Returns true if the attribute object has a preset value and will not prompt for user input.
```text
public bool IsPreset;
```

#### Conditions
Read-only
### IsVerifiable

#### Description
Returns true if the attribute object is set to verify user input.
```text
public bool IsVerifiable;
```

#### Conditions
Read-only
#### Notes
This function reflects the setting of bit 3 of DXF group code 70 (that is, if bit 3 is set, then the attribute will ask for verification of user input).
### LockPositionInBlock

#### Description
Returns true if the AttributeReference object is set to be immovable relative to the geometry in the block.
```text
public bool LockPositionInBlock;
```

#### Conditions
Read-only
### MTextAttribute

#### Description
Accesses the internal MText entity, to replace or modify it.
```text
public MText MTextAttribute;
```

#### Conditions
Read / Write
### Tag

#### Description
Accesses the tag string, which is the identifier you see if you explode the BlockReference that owns the attribute, so that the attribute reverts back to the AttributeDefinition that was part of the original reference’s block definition.
```text
public string Tag;
```

#### Conditions
Read / Write
#### Notes
The tag string is used for DXF group code 2.