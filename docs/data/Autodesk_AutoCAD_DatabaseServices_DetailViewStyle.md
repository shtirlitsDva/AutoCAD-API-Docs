# DetailViewStyle Class

## Overview

#### Description
The wrapper class for the AcDbDetailViewStyle class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.DetailViewStyle
```

```text
public class DetailViewStyle : DBObject;
```

### Constructors

- [DetailViewStyle](#detailviewstyle)

### Methods

- [DefaultViewName](#defaultviewname)
- [GetViewLabelPattern](#getviewlabelpattern)
- [PostViewStyleToDb](#postviewstyletodb)
- [SetDatabaseDefaults](#setdatabasedefaults)
- [SetViewLabelPattern](#setviewlabelpattern)
- [ValidateViewName](#validateviewname)

### Properties

- [ArrowSymbolColor](#arrowsymbolcolor)
- [ArrowSymbolId](#arrowsymbolid)
- [ArrowSymbolSize](#arrowsymbolsize)
- [BorderLineColor](#borderlinecolor)
- [BorderLineTypeId](#borderlinetypeid)
- [BorderLineWeight](#borderlineweight)
- [BoundaryLineColor](#boundarylinecolor)
- [BoundaryLineTypeId](#boundarylinetypeid)
- [BoundaryLineWeight](#boundarylineweight)
- [ConnectionLineColor](#connectionlinecolor)
- [ConnectionLineTypeId](#connectionlinetypeid)
- [ConnectionLineWeight](#connectionlineweight)
- [Description](#description)
- [IdentifierColor](#identifiercolor)
- [IdentifierHeight](#identifierheight)
- [IdentifierOffset](#identifieroffset)
- [IdentifierPlacement](#identifierplacement)
- [IdentifierStyleId](#identifierstyleid)
- [IsModifiedForRecompute](#ismodifiedforrecompute)
- [ModelEdge](#modeledge)
- [Name](#name)
- [ShowArrowheads](#showarrowheads)
- [ShowViewLabel](#showviewlabel)
- [ViewLabelAlignment](#viewlabelalignment)
- [ViewLabelAttachment](#viewlabelattachment)
- [ViewLabelOffset](#viewlabeloffset)
- [ViewLabelPattern](#viewlabelpattern)
- [ViewLabelTextColor](#viewlabeltextcolor)
- [ViewLabelTextHeight](#viewlabeltextheight)
- [ViewLabelTextStyleId](#viewlabeltextstyleid)


## Constructors Details

### DetailViewStyle

#### Description
This is DetailViewStyle, a member of class DetailViewStyle.
```text
public DetailViewStyle();
```

### DefaultViewName

#### Description
Returns the default detail view name based on the given index.
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
Add this view style object to the given database using the given name. Returns the object id of the newly added DetailViewStyle object
```text
public ObjectId PostViewStyleToDb(
    Database dataBasePointer, 
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database dataBasePointer | Input: database to be updated. |
| string styleName | Input: name to be used for this view style. |

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
| Field field | Input: optional pointer to a Field |

### ValidateViewName

#### Description
Validates the given name as a detail view name.
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
True if the given name is valid; else false.
### ArrowSymbolColor

#### Description
The color for the detail view symbol arrowhead. Return value is Color.
```text
public Autodesk.AutoCAD.Colors.Color ArrowSymbolColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### ArrowSymbolId

#### Description
The objectId of the block table record used to represent the detail view symbol arrowhead. Return value is ObjectId.
```text
public ObjectId ArrowSymbolId;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId

### ArrowSymbolSize

#### Description
The size for the detail view symbol arrowhead. Return value is double.
```text
public double ArrowSymbolSize;
```

#### Conditions
Read/Write
### BorderLineColor

#### Description
The color for the detail view border line. Return value is Color.
```text
public Autodesk.AutoCAD.Colors.Color BorderLineColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### BorderLineTypeId

#### Description
The ObjectId of the linetype for the detail view border line. Return value is ObjectId.
```text
public ObjectId BorderLineTypeId;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId

### BorderLineWeight

#### Description
The line weight for the detail view border line. Return value is LineWeight.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight BorderLineWeight;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.LineWeight

### BoundaryLineColor

#### Description
The color for the detail view symbol boundary line. Return value is Color.
```text
public Autodesk.AutoCAD.Colors.Color BoundaryLineColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### BoundaryLineTypeId

#### Description
The ObjectId of the linetype for the detail view symbol boundary line. Return value is ObjectId.
```text
public ObjectId BoundaryLineTypeId;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId

### BoundaryLineWeight

#### Description
The line weight for the detail view symbol boundary line. The return value is LineWeight.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight BoundaryLineWeight;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.LineWeight

### ConnectionLineColor

#### Description
The color for the detail view symbol connection line. Return value is Color.
```text
public Autodesk.AutoCAD.Colors.Color ConnectionLineColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### ConnectionLineTypeId

#### Description
The ObjectId of the linetype for the detail view symbol connection line. Return value is ObjectId.
```text
public ObjectId ConnectionLineTypeId;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId

### ConnectionLineWeight

#### Description
The line weight for the detail view symbol connection line. Return value is .ineWeight
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight ConnectionLineWeight;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.LineWeight

### Description

#### Description
The description of the detail view style. Return value is System::String
```text
public string Description;
```

#### Conditions
Read/Write
### IdentifierColor

#### Description
The color to be used for the identifier detail view symbols. Return value is Color.
```text
public Autodesk.AutoCAD.Colors.Color IdentifierColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### IdentifierHeight

#### Description
The text height to be used by the identifier of detail view symbols. Return value is double.
```text
public double IdentifierHeight;
```

#### Conditions
Read/Write
### IdentifierOffset

#### Description
The offset of the detail view symbol identifier from the extension line. Return value is double.
```text
public double IdentifierOffset;
```

#### Remarks
The value must be in the range of 0.0 to 1.0, where 0.0 means that arrow touches extension line at beginning and 1.0 means that arrow touches the extension line at the end.
#### Conditions
Read/Write
### IdentifierPlacement

#### Description
The identifer placement flags relating to the detail view symbol boundary. Return value is NAMESPACE_ACDB::DetailViewIdentifierPlacement.
```text
public DetailViewIdentifierPlacement IdentifierPlacement;
```

#### Conditions
Read/Write
#### See Also
AcDbDetailViewStyle::IdentifierPlacement

### IdentifierStyleId

#### Description
The id of the text style table record to be associated to detail symbol identifier. Return value is ObjectId.
```text
public ObjectId IdentifierStyleId;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId

### IsModifiedForRecompute

#### Description
Indicates whether the detail view style has been modified and associated detail views and detail view symbols need to be updated. Return value is bool.
```text
public bool IsModifiedForRecompute;
```

#### Conditions
Read/Write
### ModelEdge

#### Description
The type of model edge for the detail view. Return value is NAMESPACE_ACDB::DetailViewModelEdge.
```text
public DetailViewModelEdge ModelEdge;
```

#### Conditions
Read/Write
### Name

#### Description
The name of the detail view style. Return value is System::String
```text
public string Name;
```

#### Conditions
Read/Write
### ShowArrowheads

#### Description
Indicates whether the detail symbol should display the detail view symbol arrowhead. Return value is bool.
```text
public bool ShowArrowheads;
```

#### Conditions
Read/Write
### ShowViewLabel

#### Description
Indicates whether the section view should display the detail view label text. Return value is bool.
```text
public bool ShowViewLabel;
```

#### Conditions
Read/Write
### ViewLabelAlignment

#### Description
The type of alignment for the detail view label text.
```text
public ModelDocViewLabelAlignmentType ViewLabelAlignment;
```

#### Conditions
Read/Write
#### See Also
ModelDocViewLabelAlignmentType

### ViewLabelAttachment

#### Description
The type of attachment for the detail view label text. 
ModelDocViewLabelAttachmentPoint
```text
public ModelDocViewLabelAttachmentPoint ViewLabelAttachment;
```

#### Conditions
Read/Write
#### See Also
ModelDocViewLabelAttachmentPoint

### ViewLabelOffset

#### Description
The offset distance for the detail view label text. Return is double.
```text
public double ViewLabelOffset;
```

#### Conditions
Read/Write
### ViewLabelPattern

#### Description
The pattern for the detail view label text. The return value is String.
```text
public string ViewLabelPattern;
```

#### Conditions
Read/Write
### ViewLabelTextColor

#### Description
The color for detial view label text. Return is Color.
```text
public Autodesk.AutoCAD.Colors.Color ViewLabelTextColor;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.Colors.Color

### ViewLabelTextHeight

#### Description
The height for the detail view label text. Return is double.
```text
public double ViewLabelTextHeight;
```

#### Conditions
Read/Write
### ViewLabelTextStyleId

#### Description
The id of the text style table record to be associated to the detial view label text. Return is ObjectId.
```text
public ObjectId ViewLabelTextStyleId;
```

#### Conditions
Read/Write
#### See Also
Autodesk.AutoCAD.DatabaseServices.ObjectId