# AttributeDefinition Class

## Overview

#### Description
This .NET class wraps the AcDbAttributeDefinition ObjectARX class. 
The AttributeDefinition class represents the ATTDEF entity within AutoCAD. ATTDEF entities are used within block definitions (BlockTableRecords) for AutoCAD to use as templates for creating ATTRIB entities (Attribute objects) when an INSERT (BlockReference) is created that references the block definition.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.DBText
            Autodesk.AutoCAD.DatabaseServices.AttributeDefinition
```

```text
public class AttributeDefinition : DBText;
```

#### Notes
To set all the non-AttributeReference-specific properties such as position, text string, text height, text rotation, etc. for the attribute, use the methods inherited from Text.
#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), AttributeReference

## Members

### Constructors

- [AttributeDefinition()](#attributedefinition())

### Methods

- [UpdateMTextAttributeDefinition](#updatemtextattributedefinition)

### Properties

- [Constant](#constant)
- [FieldLength](#fieldlength)
- [Invisible](#invisible)
- [IsMTextAttributeDefinition](#ismtextattributedefinition)
- [LockPositionInBlock](#lockpositioninblock)
- [MTextAttributeDefinition](#mtextattributedefinition)
- [Preset](#preset)
- [Prompt](#prompt)
- [Tag](#tag)
- [Verifiable](#verifiable)


## Constructors Details

### AttributeDefinition()

#### Description
Default constructor. Initializes the field length to 0, the flags to 0 (that is, non-constant, visible, not preset, and not verifiable), and the tag to 0. In addition, all the initializations for a default new DBText object take place.
```text
public AttributeDefinition();
public AttributeDefinition(
    Point3d position, 
    string value, 
    string tag, 
    string prompt, 
    ObjectId style
);
```

### UpdateMTextAttributeDefinition

#### Description
Updates the internal MText entity from the basic AttributeDefinition properties
```text
public void UpdateMTextAttributeDefinition();
```

### Constant

#### Description
Accesses the constant flag of the AttributeDefinition. 
If true, then the AttributeDefinition object is set to be constant.Otherwise, the attribute object is set to be visible.
```text
public bool Constant;
```

#### Conditions
Read / Write
#### Notes
This function reflects the setting on bit 2 of DXF group code 70. That is, if bit 2 is set, then no Attribute will be created during insertion of the block containing the AttributeDefinition. 
The AttributeDefinition will be used instead, since it will be the same for all BlockReferences that reference the BlockTableRecord containing the AttributeDefinition.
### FieldLength

#### Description
Accesses the attribute’s field length value.
```text
public int FieldLength;
```

#### Conditions
Read / Write
#### Notes
This value is not currently used within AutoCAD. 
The field length value is used for DXF group code 73.
### Invisible

#### Description
Accesses the visibility flag of the AttributeDefinition. If invisible is true, then the AttributeDefinition object is set to be invisible.
```text
public bool Invisible;
```

#### Conditions
Read / Write
#### Notes
This function reflects the setting on bit 1 of DXF group code 70 (that is, if bit 1 is set, then attributes created with this AttributeDefinition as a template will be invisible).
### IsMTextAttributeDefinition

#### Description
Tells whether the attribute definition is a multi-line attribute definition.
```text
public bool IsMTextAttributeDefinition;
```

#### Conditions
Read / Write
### LockPositionInBlock

#### Description
Accesses the lock position property of the AttributeDefinition. 
If true, then the AttributeDefinition object is set to be immovable relative to the geometry in the block.
```text
public bool LockPositionInBlock;
```

#### Conditions
Read / Write
### MTextAttributeDefinition

#### Description
Accesses the internal MText entity, to replace or modify it.
```text
public MText MTextAttributeDefinition;
```

#### Conditions
Read / Write
### Preset

#### Description
Accesses the preset flag of the AttributeDefinition. 
If true, then the AttributeDefinition object is set to be preset.
```text
public bool Preset;
```

#### Conditions
Read / Write
#### Notes
This function reflects the setting on bit 4 of DXF group code 70 (that is, if bit 4 is set, then attributes created with this AttributeDefinition as a template will use the preset value and not prompt for user input).
### Prompt

#### Description
Accesses the prompt string for the AttributeDefinition. When the BockTableRecord containing the AttributeDefinition is inserted and an AttributeReference object is created using the AttributeDefinition as the template, the prompt string is displayed to ask the user to input a text string for the AttributeReference.
```text
public string Prompt;
```

#### Conditions
Read / Write
#### Notes
The prompt string is used for DXF group code 3.
### Tag

#### Description
Accesses the tag string, which is the identifier you see on screen to represent the AttributeDefinition.
```text
public string Tag;
```

#### Conditions
Read / Write
#### Notes
The tag string is used for DXF group code 2.
### Verifiable

#### Description
Accesses the verifiable flag of the AttributeDefinition. If true, then the AttributeDefinition object is set to be verifiable.
```text
public bool Verifiable;
```

#### Conditions
Read / Write
#### Notes
This function reflects the setting of bit 3 of DXF group code 70 (that is, if bit 3 is set, then attributes created with this AttributeDefinition as a template will ask for verification of user input).