# SectionViewStyle Class

## Overview

Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SectionViewStyle
```

```text
public class SectionViewStyle : DBObject;
```

### Constructors

- [SectionViewStyle](#sectionviewstyle)

### Methods

- [DefaultViewName](#defaultviewname)
- [GetViewLabelPattern](#getviewlabelpattern)
- [PostViewStyleToDb](#postviewstyletodb)
- [SetDatabaseDefaults](#setdatabasedefaults)
- [SetViewLabelPattern](#setviewlabelpattern)
- [ValidateIdentifierExcludeCharacters](#validateidentifierexcludecharacters)
- [ValidateViewName](#validateviewname)

### Properties

- [ArrowEndSymbolId](#arrowendsymbolid)
- [ArrowPosition](#arrowposition)
- [ArrowStartSymbolId](#arrowstartsymbolid)
- [ArrowSymbolColor](#arrowsymbolcolor)
- [ArrowSymbolExtensionLength](#arrowsymbolextensionlength)
- [ArrowSymbolSize](#arrowsymbolsize)
- [BendLineColor](#bendlinecolor)
- [BendLineLength](#bendlinelength)
- [BendLineTypeId](#bendlinetypeid)
- [BendLineWeight](#bendlineweight)
- [Description](#description)
- [EndLineLength](#endlinelength)
- [EndLineOvershoot](#endlineovershoot)
- [HatchAngles](#hatchangles)
- [HatchBackgroundColor](#hatchbackgroundcolor)
- [HatchColor](#hatchcolor)
- [HatchPattern](#hatchpattern)
- [HatchScale](#hatchscale)
- [HatchTransparency](#hatchtransparency)
- [IdentifierColor](#identifiercolor)
- [IdentifierExcludeCharacters](#identifierexcludecharacters)
- [IdentifierHeight](#identifierheight)
- [IdentifierOffset](#identifieroffset)
- [IdentifierPosition](#identifierposition)
- [IdentifierStyleId](#identifierstyleid)
- [IsContinuousLabeling](#iscontinuouslabeling)
- [IsModifiedForRecompute](#ismodifiedforrecompute)
- [Name](#name)
- [PlaneLineColor](#planelinecolor)
- [PlaneLineTypeId](#planelinetypeid)
- [PlaneLineWeight](#planelineweight)
- [ShowAllBendIndentifiers](#showallbendindentifiers)
- [ShowAllPlaneLines](#showallplanelines)
- [ShowArrowheads](#showarrowheads)
- [ShowEndAndBendLines](#showendandbendlines)
- [ShowHatching](#showhatching)
- [ShowViewLabel](#showviewlabel)
- [ViewLabelAlignment](#viewlabelalignment)
- [ViewLabelAttachment](#viewlabelattachment)
- [ViewLabelOffset](#viewlabeloffset)
- [ViewLabelPattern](#viewlabelpattern)
- [ViewLabelTextColor](#viewlabeltextcolor)
- [ViewLabelTextHeight](#viewlabeltextheight)
- [ViewLabelTextStyleId](#viewlabeltextstyleid)


## Constructors Details

### SectionViewStyle

#### Description
This is SectionViewStyle, a member of class SectionViewStyle.
```text
public SectionViewStyle();
```

### DefaultViewName

#### Description
Returns the default section name based on the given index.
```text
public string DefaultViewName(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | The index of the default name. |

#### Returns
System::String
Example
Returns default view name based on index for 1 it returns A, for 2 B, ...AA, AB, ....
### GetViewLabelPattern

#### Description
This method gets the pattern for view label. If the view label pattern is using fields, the master field will be copied to the given 'field' including child fields.
```text
public string GetViewLabelPattern(
    Field field
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Field field | Input: a field object to be updated with the view label pattern master field. |

#### Returns
Returns the view label pattern. If the view label pattern uses fields, the returned string will have the field code string from the master field.
#### See Also
NAMESPACE_ACDB::Field.

### PostViewStyleToDb

#### Description
Add this view style object to the given database using the given name. Returns the object id of the newly added SectionViewStyle object.
```text
public ObjectId PostViewStyleToDb(
    Database dataBasePointer, 
    string styleName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Database dataBasePointer | Input: database to be updated |
| string styleName | Input: name to be used for this view style. |

#### Returns
ObjectId
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId

### SetDatabaseDefaults

#### Description
Sets this object's properties to the default values of given database.
```text
public void SetDatabaseDefaults(
    Database dataBasePointer
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Database dataBasePointer | Input: database to be used |

### SetViewLabelPattern

#### Description
Sets the pattern for view label. If 'field' parameter is specified and contains child fields, then label pattern will be acquired from the field. Otherwise the 'pattern' string is used.
```text
public void SetViewLabelPattern(
    string pattern, 
    Field field
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string pattern | Input: the pattern string for the view label. |
| Field field | Input: optional pointer to a Field object to provide the field data to be used in the view label pattern. |

#### See Also
NAMESPACE_ACDB::Field.

### ValidateIdentifierExcludeCharacters

#### Description
Checks whether the identifier exclude character string is correctly formatted and contains valid characters.
```text
public bool ValidateIdentifierExcludeCharacters(
    string characters
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string characters | Input: the characters to validate. |

#### Returns
true if the identifier exclude character string is valid; otherwise false.
### ValidateViewName

#### Description
Validates the given name as a section name.
```text
public bool ValidateViewName(
    string name
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input: section name to validate. |

#### Returns
True if the given name is valid; else returns false.
### ArrowEndSymbolId

#### Description
The objectId of the block table record used to represent the arrow end symbol. Return value is ObjectId.
```text
public ObjectId ArrowEndSymbolId;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId

### ArrowPosition

#### Description
The section view symbol arrow direction setting which can be towards the cutting plane or away from the cutting plane. Return value is SectionViewArrowDirection.
```text
public SectionViewArrowDirection ArrowPosition;
```

#### Conditions
Read/Write
#### See Also
SectionViewArrowDirection

### ArrowStartSymbolId

#### Description
The objectId of the block table record used to represent the arrow start symbol. Return value is ObjectId.
```text
public ObjectId ArrowStartSymbolId;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId

### ArrowSymbolColor

#### Description
The color for the section symbol arrow. Return value is Color.
```text
public Autodesk.AutoCAD.Colors.Color ArrowSymbolColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### ArrowSymbolExtensionLength

#### Description
The length for the section symbol arrow extension line. Return value is double.
```text
public double ArrowSymbolExtensionLength;
```

#### Conditions
Read/Write
### ArrowSymbolSize

#### Description
The size for the section symbol arrow. Return value is double.
```text
public double ArrowSymbolSize;
```

#### Conditions
Read/Write
### BendLineColor

#### Description
The color for the section bend line. Return value is Color.
```text
public Autodesk.AutoCAD.Colors.Color BendLineColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### BendLineLength

#### Description
The length for the section symbol bend lines. Return value is double.
```text
public double BendLineLength;
```

#### Conditions
Read/Write
### BendLineTypeId

#### Description
The ObjectId of the linetype for the section symbol bend lines. Return value is ObjectId.
```text
public ObjectId BendLineTypeId;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId

### BendLineWeight

#### Description
The line weight for the section symbol bend lines. Return value is LineWeight.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight BendLineWeight;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.LineWeight

### Description

#### Description
The description of the section view style. Return value is System::String.
```text
public string Description;
```

#### Conditions
Read/Write
### EndLineLength

#### Description
The length for the section symbol end lines. Return value is double.
```text
public double EndLineLength;
```

#### Conditions
Read/Write
### EndLineOvershoot

#### Description
The length of the end line overshoot. Return value is double.
```text
public double EndLineOvershoot;
```

#### Remarks
This value must be zero or greater.
#### Conditions
Read/Write
### HatchAngles

#### Description
The list of angles to be used by the hatching within a section view. Return value is NAMESPACE_ACGE::DoubleCollection.
```text
public DoubleCollection HatchAngles;
```

#### Remarks
This property can also be set. 
This property wraps the AcDbSectionViewStyle::hatchAngles and setHatchAngles methods. 
Hatch angles are in radians. 
The first component within the section view uses the first angle, the second component uses the second angle, the third component uses the third angle, and so on. 
When the number of components exceeds the number of angles, the list is cycled. 
For example, if the list includes 6 angles, the 7th component uses the first angle, the 8th component uses the second angle, and so on. The list must contain at least 1 angle.
#### Conditions
Read/Write
#### See Also
NAMESPACE_ACGE::DoubleCollection

### HatchBackgroundColor

#### Description
The color for the hatching background to be used by the section view. Return value is Color.
```text
public Autodesk.AutoCAD.Colors.Color HatchBackgroundColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### HatchColor

#### Description
The color for the hatching to be used by the section view. Return value is Color.
```text
public Autodesk.AutoCAD.Colors.Color HatchColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### HatchPattern

#### Description
The name of the hatch pattern to be used by the section view hatching. Return value is String.
```text
public string HatchPattern;
```

#### Conditions
Read/Write
### HatchScale

#### Description
The scale for the hatching to be used by the section view. Return value is double.
```text
public double HatchScale;
```

#### Conditions
Read/Write
### HatchTransparency

#### Description
The transparency for the hatching to be used by the section view. Return value is Transparency.
```text
public Transparency HatchTransparency;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Transparency

### IdentifierColor

#### Description
The color to be used for the identifier of section view symbols. Return value is Color.
```text
public Autodesk.AutoCAD.Colors.Color IdentifierColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### IdentifierExcludeCharacters

#### Description
The characters excluded from use by section symbol identifiers. Return value is System::String.
```text
public string IdentifierExcludeCharacters;
```

#### Conditions
Read/Write
### IdentifierHeight

#### Description
The text height to be used by the identifier of section view symbols. Return value is double.
```text
public double IdentifierHeight;
```

#### Conditions
Read/Write
### IdentifierOffset

#### Description
The distance the section view symbol identifiers are offset from the section view symbol arrowheads. Return value is double.
```text
public double IdentifierOffset;
```

#### Conditions
Read/Write
### IdentifierPosition

#### Description
The identifier offset type. Return value is SectionViewIdentifierPosition.
```text
public SectionViewIdentifierPosition IdentifierPosition;
```

#### Conditions
Read/Write
#### See Also
SectionViewIdentifierPosition

### IdentifierStyleId

#### Description
The id of the text style table record to be associated to section symbol identifiers. return value is ObjectId.
```text
public ObjectId IdentifierStyleId;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId

### IsContinuousLabeling

#### Description
Indicates whether the section view symbol should be created with continuous labeling at every bend. Return value is bool.
```text
public bool IsContinuousLabeling;
```

#### Conditions
Read/Write
### IsModifiedForRecompute

#### Description
Indicates whether the section view style has been modified and associated section views and section view symbols need to be updated. Return value is bool.
```text
public bool IsModifiedForRecompute;
```

#### Conditions
Read/Write
### Name

#### Description
The name of the section view style. Return value is System::String.
```text
public string Name;
```

#### Conditions
Read/Write
### PlaneLineColor

#### Description
The color for the section symbol plane line. Return value is Color.
```text
public Autodesk.AutoCAD.Colors.Color PlaneLineColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### PlaneLineTypeId

#### Description
The ObjectId of the linetype for the section symbol plane line. Return value is ObjectId.
```text
public ObjectId PlaneLineTypeId;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId

### PlaneLineWeight

#### Description
The line weight for the section symbol plane line. Return value is Lineweight.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight PlaneLineWeight;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.LineWeight

### ShowAllBendIndentifiers

#### Description
Indicates whether the section symbol should display the all the bend identifiers. Return value is bool.
```text
public bool ShowAllBendIndentifiers;
```

#### Conditions
Read/Write
### ShowAllPlaneLines

#### Description
Indicates whether the section symbol should display all the plane lines. Return value is bool.
```text
public bool ShowAllPlaneLines;
```

#### Conditions
Read/Write
### ShowArrowheads

#### Description
Indicates whether the section symbol should display the arrowheads. Return value is bool.
```text
public bool ShowArrowheads;
```

#### Conditions
Read/Write
### ShowEndAndBendLines

#### Description
Indicates whether the section symbol should display the end and bend lines. Return value is bool.
```text
public bool ShowEndAndBendLines;
```

#### Conditions
Read/Write
### ShowHatching

#### Description
Indicates whether the section view should display hatching. Return value is bool.
```text
public bool ShowHatching;
```

#### Conditions
Read/Write
### ShowViewLabel

#### Description
Indicates whether the section view should display the view label text. Return value is bool.
```text
public bool ShowViewLabel;
```

#### Conditions
Read/Write
### ViewLabelAlignment

#### Description
The type of alignment for the section view label text. Return value is ModelDocViewLabelAlignmentType.
```text
public ModelDocViewLabelAlignmentType ViewLabelAlignment;
```

#### Conditions
Read/Write
#### See Also
ModelDocViewLabelAlignmentType

### ViewLabelAttachment

#### Description
The type of attachment for the section view label text. Return value is ModelDocViewLabelAttachmentPoint.
```text
public ModelDocViewLabelAttachmentPoint ViewLabelAttachment;
```

#### Conditions
Read/Write
#### See Also
ModelDocViewLabelAttachmentPoint

### ViewLabelOffset

#### Description
The offset distance for the section view label text. Return value is double.
```text
public double ViewLabelOffset;
```

#### Conditions
Read/Write
### ViewLabelPattern

#### Description
The pattern for the section view label text. Return value is String.
```text
public string ViewLabelPattern;
```

#### Conditions
Read/Write
### ViewLabelTextColor

#### Description
The color for section view label text. Return value is Color.
```text
public Autodesk.AutoCAD.Colors.Color ViewLabelTextColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### ViewLabelTextHeight

#### Description
The height for the section view label text. Return value is double.
```text
public double ViewLabelTextHeight;
```

#### Conditions
Read/Write
### ViewLabelTextStyleId

#### Description
The id of the text style table record to be associated to the section view label text. Return value is ObjectId.
```text
public ObjectId ViewLabelTextStyleId;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId