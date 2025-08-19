# TableStyle Class

## Overview

#### Description
This .NET class wraps the AcDbTableStyle ObjectARX class. 
TableStyle class objects are used to store the table formatting properties (for example, grid visibility, lineweight, line color, and cell font, height, color, and background fill) used by Table entities. 
Because tables appear in a variety of forms, table objects will be based on a table style similar to the way text objects and dimension objects are based on styles in AutoCAD. The table style controls the initial formatting of a newly created table object and whether the table includes a title and header row.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.TableStyle
```

```text
public class TableStyle : DBObject;
```

### Constructors

- [TableStyle](#tablestyle)

### Methods

- [Alignment](#alignment)
- [BackgroundColor](#backgroundcolor)
- [CellClass](#cellclass)
- [Color](#color)
- [DataType](#datatype)
- [Format](#format)
- [GridColor](#gridcolor)
- [GridDoubleLineSpacing](#griddoublelinespacing)
- [GridLineStyle](#gridlinestyle)
- [GridLinetype](#gridlinetype)
- [GridLineWeight](#gridlineweight)
- [GridVisibility](#gridvisibility)
- [IsBackgroundColorNone](#isbackgroundcolornone)
- [Margin](#margin)
- [PostTableStyleToDatabase](#posttablestyletodatabase)
- [SetAlignment](#setalignment)
- [SetBackgroundColor](#setbackgroundcolor)
- [SetBackgroundColorNone](#setbackgroundcolornone)
- [SetCellClass](#setcellclass)
- [SetColor](#setcolor)
- [SetDataType](#setdatatype)
- [SetFormat](#setformat)
- [SetGridColor](#setgridcolor)
- [SetGridDoubleLineSpacing](#setgriddoublelinespacing)
- [SetGridLineStyle](#setgridlinestyle)
- [SetGridLinetype](#setgridlinetype)
- [SetGridLineWeight](#setgridlineweight)
- [SetGridVisibility](#setgridvisibility)
- [SetMargin](#setmargin)
- [SetTextHeight](#settextheight)
- [SetTextStyle(ObjectId, int)](#settextstyle(objectid,-int))
- [SetTextStyle(ObjectId, string)](#settextstyle(objectid,-string))
- [TextHeight](#textheight)
- [TextStyle(Autodesk.AutoCAD.DatabaseServices.RowType)](#textstyle(autodesk.autocad.databaseservices.rowtype))
- [TextStyle(string)](#textstyle(string))
- [UnitType](#unittype)

### Properties

- [BitFlags](#bitflags)
- [CellStyles](#cellstyles)
- [Description](#description)
- [FlowDirection](#flowdirection)
- [HorizontalCellMargin](#horizontalcellmargin)
- [IsHeaderSuppressed](#isheadersuppressed)
- [IsTitleSuppressed](#istitlesuppressed)
- [Name](#name)
- [Template](#template)
- [VerticalCellMargin](#verticalcellmargin)


## Constructors Details

### TableStyle

#### Description
Default constructor.
```text
public TableStyle();
```

### Alignment

#### Description
This function returns the cell alignment for a given row type of the table style object. 
The possible values of rowType are DataRow, TitleRow, and HeaderRow. If no row type is specified, the default of DataRow will be used.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.CellAlignment Alignment(
    Autodesk.AutoCAD.DatabaseServices.RowType rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType rowType | Input value specifying the row type for which the cell alignment value will be returned |

### BackgroundColor

#### Description
This function returns the background color for a given row type of the table style object. 
The possible values of rowType are DataRow, TitleRow, and HeaderRow. If no row type is specified, the default of DataRow will be used.
```text
public virtual Autodesk.AutoCAD.Colors.Color BackgroundColor(
    Autodesk.AutoCAD.DatabaseServices.RowType rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType rowType | Input value specifying the row type for which the Color value will be returned |

### CellClass

#### Description
Returns the cell classification value for the specified cell style.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.CellClass CellClass(
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string styleName | Input cell style name |

### Color

#### Description
This function returns the text color for a given row type of the table style object. 
The possible values of rowType are DataRow, TitleRow, and HeaderRow. If no row type is specified, the default of DataRow will be used.
```text
public virtual Autodesk.AutoCAD.Colors.Color Color(
    Autodesk.AutoCAD.DatabaseServices.RowType rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType rowType | Input value specifying the row type for which the Color value will be returned |

### DataType

#### Description
This function returns the data type for a given row type of the table style object. 
The possible values of rowType are DataRow, TitleRow, and HeaderRow. If no row type is specified, the default of DataRow will be used.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.DataType DataType(
    Autodesk.AutoCAD.DatabaseServices.RowType rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType rowType | Input value specifying the row type for which the DataType value will be returned |

### Format

#### Description
This function returns the string format for a given row type of the table style object. 
The possible values of rowType are DataRow, TitleRow, and HeaderRow. If no row type is specified, the default of DataRow will be used.
```text
public virtual string Format(
    Autodesk.AutoCAD.DatabaseServices.RowType rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType rowType | Input value specifying the row type for which the string format value will be returned |

### GridColor

#### Description
This function returns the grid color for a given grid line type of the table style object.
```text
public virtual Autodesk.AutoCAD.Colors.Color GridColor(
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    Autodesk.AutoCAD.DatabaseServices.RowType rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input type of grid line for which to return the Color value |
| Autodesk.AutoCAD.DatabaseServices.RowType rowType | Input row type for which to return the color value |

### GridDoubleLineSpacing

#### Description
Gets the grid double line spacing in the specified cell style.
```text
public virtual double GridDoubleLineSpacing(
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line type. |
| string styleName | Input cell style name. |

#### Returns
Returns the grid double line spacing of the specified cell style.
### GridLineStyle

#### Description
Gets the grid line style of the specified cell style.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.GridLineStyle GridLineStyle(
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line type. |
| string styleName | Input cell style name. |

#### Returns
Returns the grid line style of the specified cell style.
### GridLinetype

#### Description
Gets the grid double line spacing in the specified cell style.
```text
public virtual ObjectId GridLinetype(
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line type. |
| string styleName | Input cell style name. |

#### Returns
Returns the grid line type of the specified cell style.
### GridLineWeight

#### Description
This function returns the grid color for a given grid line weight of the table style object.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.LineWeight GridLineWeight(
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    Autodesk.AutoCAD.DatabaseServices.RowType rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input type of grid line for which to return the LineWeight value |
| Autodesk.AutoCAD.DatabaseServices.RowType rowType | Input row type for which to return the grid line weight value |

### GridVisibility

#### Description
This function returns the grid color for a given grid line visibility of the table style object.
```text
public virtual bool GridVisibility(
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    Autodesk.AutoCAD.DatabaseServices.RowType rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input type of grid line for which to return the grid visibility value |
| Autodesk.AutoCAD.DatabaseServices.RowType rowType | Input row type for which to return the grid visibility value |

### IsBackgroundColorNone

#### Description
Returns true if the background color for a given row type of the table style object is set to no color value. Otherwise, returns false. 
This method is deprecated and may be removed in a future release
```text
public virtual bool IsBackgroundColorNone(
    Autodesk.AutoCAD.DatabaseServices.RowType rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType rowType | Input value specifying the row type for which to return the Boolean indicating whether the background color is set to none |

### Margin

#### Description
This .NET method wraps the ObjectARX method [AcDbTableStyle::margin()](AcDbTableStyle__margin@AcDb__CellMargin@ACHAR_@const.md).
```text
public virtual double Margin(
    CellMargins cellMargin, 
    string styleName
);
```

#### See Also
[CellMargins Enumeration](Autodesk_AutoCAD_DatabaseServices_CellMargins.md "CellMargins Enumeration")

### PostTableStyleToDatabase

#### Description
Adds a table style to the specified database.
```text
public virtual ObjectId PostTableStyleToDatabase(
    Database databasePointer, 
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database databasePointer | Input the database to which to add the table style |
| string styleName | Input name for the table style; must be a non-empty string that is less than 256 characters long and conforms to the requirements for Dictionary key strings |

### SetAlignment

#### Description
Sets the cell alignment for the specified cell style.
```text
public virtual void SetAlignment(
    Autodesk.AutoCAD.DatabaseServices.CellAlignment alignment, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.CellAlignment alignment | Input alignment value |
| int rowTypes | Input row types for which to set the alignment |

### SetBackgroundColor

#### Description
Sets the background color for a cell style. Different row types can be OR'd.
```text
public virtual void SetBackgroundColor(
    Autodesk.AutoCAD.Colors.Color color, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.Colors.Color color | Input value indicating the new background color |
| int rowTypes | Input row types for which to set the background color |

### SetBackgroundColorNone

#### Description
This function enables or disables the background color for the specified row types. Different row types can be OR'd.
```text
public virtual void SetBackgroundColorNone(
    [MarshalAs(UnmanagedType.U1)] bool value, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool value | Input Boolean indicating whether to enable the background color for the specified row type |
| int rowTypes | Input row types for which to enable or disable the background color |

### SetCellClass

#### Description
Sets the class of a cell, by style.
```text
public virtual void SetCellClass(
    Autodesk.AutoCAD.DatabaseServices.CellClass cellClass, 
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.CellClass cellClass | Input new cell class value |
| string styleName | Input cell style name |

### SetColor

#### Description
This function sets the text color for the specified row types. Different row types can be OR'd.
```text
public virtual void SetColor(
    Autodesk.AutoCAD.Colors.Color color, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.Colors.Color color | Input color |
| int rowTypes | Input row types for which to set the color |

### SetDataType

#### Description
Sets the data type and unit type of the specified row type of the table style object.
```text
public virtual void SetDataType(
    Autodesk.AutoCAD.DatabaseServices.DataType nDataType, 
    Autodesk.AutoCAD.DatabaseServices.UnitType nUnitType, 
    Autodesk.AutoCAD.DatabaseServices.RowType rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.DataType nDataType | Input data type to set |
| Autodesk.AutoCAD.DatabaseServices.UnitType nUnitType | Input unit type to set |
| Autodesk.AutoCAD.DatabaseServices.RowType rowTypes | Input row types for which to set the data type |

### SetFormat

#### Description
Sets the format string of the specified cell style.
```text
public virtual void SetFormat(
    string pFormat, 
    Autodesk.AutoCAD.DatabaseServices.RowType rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string pFormat | Input format to set |
| Autodesk.AutoCAD.DatabaseServices.RowType rowTypes | Input row types for which to set the format string |

### SetGridColor

#### Description
This function sets the grid color for the specified grid line types and row types. Different border and row types can be combined using the OR operator.
```text
public virtual void SetGridColor(
    Autodesk.AutoCAD.Colors.Color color, 
    int gridLineTypes, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.Colors.Color color | Input color value |
| int gridLineTypes | Input types of grid lines for which to set the color |
| int rowTypes | Input row types for which to set the color |

### SetGridDoubleLineSpacing

#### Description
Sets the grid double line spacing in the specified cell style.
```text
public virtual void SetGridDoubleLineSpacing(
    double spacing, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineTypes, 
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double spacing | Input grid double line spacing to set. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineTypes | Input grid line type. Multiple grid line types can be combined using OR. |
| string styleName | Input cell style name. |

### SetGridLineStyle

#### Description
Sets the grid line style of the specified cell style.
```text
public virtual void SetGridLineStyle(
    Autodesk.AutoCAD.DatabaseServices.GridLineStyle lineStyle, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineTypes, 
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GridLineStyle lineStyle | Input grid line style to set. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineTypes | Input grid line styles. Multiple grid line types can be combined using OR. |
| string styleName | Input cell style name. |

### SetGridLinetype

#### Description
Sets the grid double line spacing in the specified cell style.
```text
public virtual void SetGridLinetype(
    ObjectId linetype, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineTypes, 
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId linetype | Input grid double line spacing to set. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineTypes | Input grid line type. Multiple grid line types can be combined using OR. |
| string styleName | Input cell style name. |

### SetGridLineWeight

#### Description
This function sets the lineweight for the specified grid line types and row types. Different grid line and row types can be OR'd.
```text
public virtual void SetGridLineWeight(
    Autodesk.AutoCAD.DatabaseServices.LineWeight lineWeight, 
    int gridLineTypes, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.LineWeight lineWeight | Input lineweight value |
| int gridLineTypes | Input grid line types for which to set the lineweight |
| int rowTypes | Input row types for which to set the lineweight |

### SetGridVisibility

#### Description
This function sets the grid visibility for the specified grid line types and row types. Different grid line and row types can be OR'd.
```text
public virtual void SetGridVisibility(
    [MarshalAs(UnmanagedType.U1)] bool visible, 
    int gridLineTypes, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool visible | Input visibility value |
| int gridLineTypes | Input grid line types for which to set the visibility |
| int rowTypes | Input row types for which to set the visibility |

### SetMargin

#### Description
This .NET method wraps the ObjectARX method [AcDbTableStyle::setMargin()](AcDbTableStyle__setMargin@AcDb__CellMargin@double@ACHAR_.md).
```text
public virtual void SetMargin(
    CellMargins cellMargin, 
    double margin, 
    string styleName
);
```

#### See Also
[CellMargins Enumeration](Autodesk_AutoCAD_DatabaseServices_CellMargins.md "CellMargins Enumeration")

### SetTextHeight

#### Description
This function sets the text height for the specified row types. Different row types can be combined using the OR operator.
```text
public virtual void SetTextHeight(
    double height, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double height | Input value indicating the new text height |
| int rowTypes | Input row types for which to set the text height |

### SetTextStyle(ObjectId, int)

#### Description
This function sets the table object to use the TextStyleTableRecord specified by ID for the specified row types. Different row types can be OR'ed.
```text
public virtual void SetTextStyle(
    ObjectId id, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | Input TextStyleTableRecord object ID |
| int rowTypes | Input row types |

### SetTextStyle(ObjectId, string)

#### Description
Sets the text style for a cell style.
```text
public virtual void SetTextStyle(
    ObjectId id, 
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | Input TextStyleTableRecord object ID |
| string styleName | Input cell style name |

### TextHeight

#### Description
This function returns the text height for a given row type of the table style object.
```text
public virtual double TextHeight(
    Autodesk.AutoCAD.DatabaseServices.RowType rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType rowType | Input value specifying the row type for which the text height will be returned |

### TextStyle(Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
This function returns the object ID of the text style for a given row type currently referenced by the TableStyle object.
```text
public virtual ObjectId TextStyle(
    Autodesk.AutoCAD.DatabaseServices.RowType rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType rowType | Input row type |

### TextStyle(string)

#### Description
Returns the textstyle id of the specified cell style.
```text
public virtual ObjectId TextStyle(
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string styleName | Input cell style |

### UnitType

#### Description
Gets the unit type.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.UnitType UnitType(
    Autodesk.AutoCAD.DatabaseServices.RowType rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType rowType | Input row type |

### BitFlags

#### Description
Accesses an integer representing the operation bit SetFlowDirection flags set for the TableStyle object.
```text
public virtual int BitFlags;
```

#### Conditions
Read / Write
### CellStyles

#### Description
Accesses the cell styles in the table style.
```text
public virtual ArrayList CellStyles;
```

#### Conditions
Read-only
### Description

#### Description
Accesses the description of the table style.
```text
public virtual string Description;
```

#### Conditions
Read / Write
### FlowDirection

#### Description
Accesses the flow direction of the table.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.FlowDirection FlowDirection;
```

#### Conditions
Read / Write
### HorizontalCellMargin

#### Description
Accesses the horizontal cell margin value used by the table style.
```text
public virtual double HorizontalCellMargin;
```

#### Conditions
Read / Write
### IsHeaderSuppressed

#### Description
Assesses if the header is suppressed.
```text
public virtual bool IsHeaderSuppressed;
```

#### Conditions
Read / Write
### IsTitleSuppressed

#### Description
Assesses if the title is suppressed.
```text
public virtual bool IsTitleSuppressed;
```

#### Conditions
Read / Write
### Name

#### Description
Accesses the name of the table style.
```text
public virtual string Name;
```

#### Conditions
Read / Write
### Template

#### Description
Accesses the ID of the Template object in the table style. If the table style does not contain a template, then the returned objectId will be set to NULL.
#### Remarks
When setting this property, the MergeCellStyleOption is none. To remove the template, set this property to null.
#### Conditions
Read/Write
Previous Declaration
```text
public virtual ObjectId Template;
Previously, this was only a get property.
```

### VerticalCellMargin

#### Description
Accesses the vertical cell margin value used by the table style.
```text
public virtual double VerticalCellMargin;
```

#### Conditions
Read / Write