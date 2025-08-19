# Table Class

## Overview

#### Description
This .NET class wraps the AcDbTable ObjectARX class. 
Table is a planar entity that can be created and placed in an arbitrary plane in 3D space. A table is generally thought of as an n x m rectangular array of cells whose contents consist of annotation objects, primarily text. In the AEC industry, tables are often referred to as "schedules" and contain information on the materials needed for construction of the building being designed. In the manufacturing industry, tables are referred to as "BOMs" (bills of materials); in GIS, they are referred to simply as "tables." Tables often contain a title row, a header row, and multiple data rows. 
After creating a new Table object using the constructor, applications usually need to set the table style, number of rows and columns, column width, row height, insert position, width direction, and normal vector. Applications can also enter text or block contents into each cell using Table methods.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.BlockReference
            Autodesk.AutoCAD.DatabaseServices.Table
```

```text
public class Table : BlockReference, IEnumerable;
```

### Constructors

- [Table](#table)

### Methods

- [Alignment(Autodesk.AutoCAD.DatabaseServices.RowType)](#alignment(autodesk.autocad.databaseservices.rowtype))
- [Alignment(int, int)](#alignment(int,-int))
- [AttachmentPoint](#attachmentpoint)
- [BackgroundColor(Autodesk.AutoCAD.DatabaseServices.RowType)](#backgroundcolor(autodesk.autocad.databaseservices.rowtype))
- [BackgroundColor(int, int)](#backgroundcolor(int,-int))
- [BlockRotation](#blockrotation)
- [BlockScale](#blockscale)
- [BlockTableRecordId](#blocktablerecordid)
- [CanDeleteColumns](#candeletecolumns)
- [CanDeleteRows](#candeleterows)
- [CanInsertColumn](#caninsertcolumn)
- [CanInsertRow](#caninsertrow)
- [CellStyleOverrides](#cellstyleoverrides)
- [CellType](#celltype)
- [ClearSubSelection](#clearsubselection)
- [ClearTableStyleOverrides](#cleartablestyleoverrides)
- [ColumnWidth](#columnwidth)
- [ContentColor(Autodesk.AutoCAD.DatabaseServices.RowType)](#contentcolor(autodesk.autocad.databaseservices.rowtype))
- [ContentColor(int, int)](#contentcolor(int,-int))
- [CopyFrom(LinkedTableData, TableCopyOptions)](#copyfrom(linkedtabledata,-tablecopyoptions))
- [CopyFrom(LinkedTableData, TableCopyOptions, CellRange, CellRange)](#copyfrom(linkedtabledata,-tablecopyoptions,-cellrange,-cellrange))
- [CopyFrom(Table, TableCopyOptions, CellRange, CellRange)](#copyfrom(table,-tablecopyoptions,-cellrange,-cellrange))
- [CreateContent](#createcontent)
- [DataType(Autodesk.AutoCAD.DatabaseServices.RowType)](#datatype(autodesk.autocad.databaseservices.rowtype))
- [DataType(int, int)](#datatype(int,-int))
- [DeleteCellContent](#deletecellcontent)
- [DeleteColumns](#deletecolumns)
- [DeleteContent(CellRange)](#deletecontent(cellrange))
- [DeleteContent(int, int)](#deletecontent(int,-int))
- [DeleteContent(int, int, int)](#deletecontent(int,-int,-int))
- [DeleteRows](#deleterows)
- [FieldId](#fieldid)
- [Fill](#fill)
- [Format(Autodesk.AutoCAD.DatabaseServices.RowType)](#format(autodesk.autocad.databaseservices.rowtype))
- [Format(int, int)](#format(int,-int))
- [GenerateLayout](#generatelayout)
- [GetBlockAttributeValue(int, int, int, ObjectId)](#getblockattributevalue(int,-int,-int,-objectid))
- [GetBlockAttributeValue(int, int, ObjectId)](#getblockattributevalue(int,-int,-objectid))
- [GetBlockTableRecordId](#getblocktablerecordid)
- [GetBreakHeight](#getbreakheight)
- [GetBreakOffset](#getbreakoffset)
- [GetBreakSpacing](#getbreakspacing)
- [GetCellExtents](#getcellextents)
- [GetCellState](#getcellstate)
- [GetCellStyle](#getcellstyle)
- [GetColumnName](#getcolumnname)
- [GetContentColor](#getcontentcolor)
- [GetContentLayout](#getcontentlayout)
- [GetContentTypes(int, int)](#getcontenttypes(int,-int))
- [GetContentTypes(int, int, int)](#getcontenttypes(int,-int,-int))
- [GetCustomData(int, int)](#getcustomdata(int,-int))
- [GetCustomData(int, int, string)](#getcustomdata(int,-int,-string))
- [GetDataFormat(int, int)](#getdataformat(int,-int))
- [GetDataFormat(int, int, int)](#getdataformat(int,-int,-int))
- [GetDataLink()](#getdatalink())
- [GetDataLink(CellRange)](#getdatalink(cellrange))
- [GetDataLink(int, int)](#getdatalink(int,-int))
- [GetDataLinkRange](#getdatalinkrange)
- [GetDataType](#getdatatype)
- [GetEnumerator()](#getenumerator())
- [GetEnumerator(CellRange, TableEnumeratorOption)](#getenumerator(cellrange,-tableenumeratoroption))
- [GetFieldId](#getfieldid)
- [GetFormula](#getformula)
- [GetGridColor](#getgridcolor)
- [GetGridDoubleLineSpacing](#getgriddoublelinespacing)
- [GetGridLineStyle](#getgridlinestyle)
- [GetGridLinetype](#getgridlinetype)
- [GetGridLineWeight](#getgridlineweight)
- [GetGridProperty](#getgridproperty)
- [GetGridVisibility](#getgridvisibility)
- [GetIsAutoScale](#getisautoscale)
- [GetMargin](#getmargin)
- [GetMergeAllEnabled](#getmergeallenabled)
- [GetMergeRange](#getmergerange)
- [GetNumberOfContents](#getnumberofcontents)
- [GetOverrides(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType)](#getoverrides(int,-int,-autodesk.autocad.databaseservices.gridlinetype))
- [GetOverrides(int, int, int)](#getoverrides(int,-int,-int))
- [GetRotation](#getrotation)
- [GetScale](#getscale)
- [GetTextHeight](#gettextheight)
- [GetTextString(int, int, int)](#gettextstring(int,-int,-int))
- [GetTextString(int, int, int, Autodesk.AutoCAD.DatabaseServices.FormatOption)](#gettextstring(int,-int,-int,-autodesk.autocad.databaseservices.formatoption))
- [GetTextStyleId](#gettextstyleid)
- [GetToolTip](#gettooltip)
- [GetValue(int, int, int)](#getvalue(int,-int,-int))
- [GetValue(int, int, int, Autodesk.AutoCAD.DatabaseServices.FormatOption)](#getvalue(int,-int,-int,-autodesk.autocad.databaseservices.formatoption))
- [GridColor(Autodesk.AutoCAD.DatabaseServices.GridLineType, Autodesk.AutoCAD.DatabaseServices.RowType)](#gridcolor(autodesk.autocad.databaseservices.gridlinetype,-autodesk.autocad.databaseservices.rowtype))
- [GridColor(int, int, CellEdgeMasks)](#gridcolor(int,-int,-celledgemasks))
- [GridLineWeight(Autodesk.AutoCAD.DatabaseServices.GridLineType, Autodesk.AutoCAD.DatabaseServices.RowType)](#gridlineweight(autodesk.autocad.databaseservices.gridlinetype,-autodesk.autocad.databaseservices.rowtype))
- [GridLineWeight(int, int, CellEdgeMasks)](#gridlineweight(int,-int,-celledgemasks))
- [GridVisibility(Autodesk.AutoCAD.DatabaseServices.GridLineType, Autodesk.AutoCAD.DatabaseServices.RowType)](#gridvisibility(autodesk.autocad.databaseservices.gridlinetype,-autodesk.autocad.databaseservices.rowtype))
- [GridVisibility(int, int, CellEdgeMasks)](#gridvisibility(int,-int,-celledgemasks))
- [HasFormula](#hasformula)
- [HitTest](#hittest)
- [InsertColumns](#insertcolumns)
- [InsertColumnsAndInherit](#insertcolumnsandinherit)
- [InsertRows](#insertrows)
- [InsertRowsAndInherit](#insertrowsandinherit)
- [IsAutoScale](#isautoscale)
- [IsBackgroundColorNone(Autodesk.AutoCAD.DatabaseServices.RowType)](#isbackgroundcolornone(autodesk.autocad.databaseservices.rowtype))
- [IsBackgroundColorNone(int, int)](#isbackgroundcolornone(int,-int))
- [IsContentEditable](#iscontenteditable)
- [IsEmpty](#isempty)
- [IsFormatEditable](#isformateditable)
- [IsLinked](#islinked)
- [IsMergedCell](#ismergedcell)
- [MergeCells](#mergecells)
- [MinimumColumnWidth](#minimumcolumnwidth)
- [MinimumRowHeight](#minimumrowheight)
- [MoveContent](#movecontent)
- [RecomputeTableBlock](#recomputetableblock)
- [RemoveAllOverrides](#removealloverrides)
- [RemoveDataLink()](#removedatalink())
- [RemoveDataLink(int, int)](#removedatalink(int,-int))
- [ReselectSubRegion](#reselectsubregion)
- [ResetValue](#resetvalue)
- [RowHeight](#rowheight)
- [RowType](#rowtype)
- [Select](#select)
- [SelectSubRegion](#selectsubregion)
- [SetAlignment(Autodesk.AutoCAD.DatabaseServices.CellAlignment, int)](#setalignment(autodesk.autocad.databaseservices.cellalignment,-int))
- [SetAlignment(int, int, Autodesk.AutoCAD.DatabaseServices.CellAlignment)](#setalignment(int,-int,-autodesk.autocad.databaseservices.cellalignment))
- [SetAutoScale](#setautoscale)
- [SetBackgroundColor(Autodesk.AutoCAD.Colors.Color, int)](#setbackgroundcolor(autodesk.autocad.colors.color,-int))
- [SetBackgroundColor(int, int, Autodesk.AutoCAD.Colors.Color)](#setbackgroundcolor(int,-int,-autodesk.autocad.colors.color))
- [SetBackgroundColorNone([MarshalAs(UnmanagedType.U1)] bool, int)](#setbackgroundcolornone([marshalas(unmanagedtype.u1)]-bool,-int))
- [SetBackgroundColorNone(int, int, [MarshalAs(UnmanagedType.U1)] bool)](#setbackgroundcolornone(int,-int,-[marshalas(unmanagedtype.u1)]-bool))
- [SetBlockAttributeValue(int, int, int, ObjectId, string)](#setblockattributevalue(int,-int,-int,-objectid,-string))
- [SetBlockAttributeValue(int, int, ObjectId, string)](#setblockattributevalue(int,-int,-objectid,-string))
- [SetBlockRotation](#setblockrotation)
- [SetBlockScale](#setblockscale)
- [SetBlockTableRecordId(int, int, int, ObjectId, [MarshalAs(UnmanagedType.U1)] bool)](#setblocktablerecordid(int,-int,-int,-objectid,-[marshalas(unmanagedtype.u1)]-bool))
- [SetBlockTableRecordId(int, int, ObjectId, [MarshalAs(UnmanagedType.U1)] bool)](#setblocktablerecordid(int,-int,-objectid,-[marshalas(unmanagedtype.u1)]-bool))
- [SetBreakHeight](#setbreakheight)
- [SetBreakOffset](#setbreakoffset)
- [SetBreakSpacing](#setbreakspacing)
- [SetCellState](#setcellstate)
- [SetCellStyle](#setcellstyle)
- [SetCellType](#setcelltype)
- [SetColumnName](#setcolumnname)
- [SetColumnWidth(double)](#setcolumnwidth(double))
- [SetColumnWidth(int, double)](#setcolumnwidth(int,-double))
- [SetContentColor(Autodesk.AutoCAD.Colors.Color, int)](#setcontentcolor(autodesk.autocad.colors.color,-int))
- [SetContentColor(int, int, Autodesk.AutoCAD.Colors.Color)](#setcontentcolor(int,-int,-autodesk.autocad.colors.color))
- [SetContentColor(int, int, int, Autodesk.AutoCAD.Colors.Color)](#setcontentcolor(int,-int,-int,-autodesk.autocad.colors.color))
- [SetContentLayout](#setcontentlayout)
- [SetCustomData(int, int, int)](#setcustomdata(int,-int,-int))
- [SetCustomData(int, int, string, object)](#setcustomdata(int,-int,-string,-object))
- [SetDataFormat(int, int, int, string)](#setdataformat(int,-int,-int,-string))
- [SetDataFormat(int, int, string)](#setdataformat(int,-int,-string))
- [SetDataLink(CellRange, ObjectId, [MarshalAs(UnmanagedType.U1)] bool)](#setdatalink(cellrange,-objectid,-[marshalas(unmanagedtype.u1)]-bool))
- [SetDataLink(int, int, ObjectId, [MarshalAs(UnmanagedType.U1)] bool)](#setdatalink(int,-int,-objectid,-[marshalas(unmanagedtype.u1)]-bool))
- [SetDataType(Autodesk.AutoCAD.DatabaseServices.DataType, Autodesk.AutoCAD.DatabaseServices.UnitType, int)](#setdatatype(autodesk.autocad.databaseservices.datatype,-autodesk.autocad.databaseservices.unittype,-int))
- [SetDataType(int, int, Autodesk.AutoCAD.DatabaseServices.DataType, Autodesk.AutoCAD.DatabaseServices.UnitType)](#setdatatype(int,-int,-autodesk.autocad.databaseservices.datatype,-autodesk.autocad.databaseservices.unittype))
- [SetDataType(int, int, int, DataTypeParameter)](#setdatatype(int,-int,-int,-datatypeparameter))
- [SetFieldId(int, int, int, ObjectId, Autodesk.AutoCAD.DatabaseServices.CellOption)](#setfieldid(int,-int,-int,-objectid,-autodesk.autocad.databaseservices.celloption))
- [SetFieldId(int, int, ObjectId)](#setfieldid(int,-int,-objectid))
- [SetFormat(int, int, string)](#setformat(int,-int,-string))
- [SetFormat(string, int)](#setformat(string,-int))
- [SetFormula](#setformula)
- [SetGridColor(Autodesk.AutoCAD.Colors.Color, int, int)](#setgridcolor(autodesk.autocad.colors.color,-int,-int))
- [SetGridColor(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType, Autodesk.AutoCAD.Colors.Color)](#setgridcolor(int,-int,-autodesk.autocad.databaseservices.gridlinetype,-autodesk.autocad.colors.color))
- [SetGridColor(int, int, short, Autodesk.AutoCAD.Colors.Color)](#setgridcolor(int,-int,-short,-autodesk.autocad.colors.color))
- [SetGridDoubleLineSpacing](#setgriddoublelinespacing)
- [SetGridLineStyle](#setgridlinestyle)
- [SetGridLinetype](#setgridlinetype)
- [SetGridLineWeight(Autodesk.AutoCAD.DatabaseServices.LineWeight, int, int)](#setgridlineweight(autodesk.autocad.databaseservices.lineweight,-int,-int))
- [SetGridLineWeight(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType, Autodesk.AutoCAD.DatabaseServices.LineWeight)](#setgridlineweight(int,-int,-autodesk.autocad.databaseservices.gridlinetype,-autodesk.autocad.databaseservices.lineweight))
- [SetGridLineWeight(int, int, short, Autodesk.AutoCAD.DatabaseServices.LineWeight)](#setgridlineweight(int,-int,-short,-autodesk.autocad.databaseservices.lineweight))
- [SetGridProperty(CellRange, Autodesk.AutoCAD.DatabaseServices.GridLineType, GridPropertyParameter)](#setgridproperty(cellrange,-autodesk.autocad.databaseservices.gridlinetype,-gridpropertyparameter))
- [SetGridProperty(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType, GridPropertyParameter)](#setgridproperty(int,-int,-autodesk.autocad.databaseservices.gridlinetype,-gridpropertyparameter))
- [SetGridVisibility([MarshalAs(UnmanagedType.U1)] bool, int, int)](#setgridvisibility([marshalas(unmanagedtype.u1)]-bool,-int,-int))
- [SetGridVisibility(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType, Autodesk.AutoCAD.DatabaseServices.Visibility)](#setgridvisibility(int,-int,-autodesk.autocad.databaseservices.gridlinetype,-autodesk.autocad.databaseservices.visibility))
- [SetGridVisibility(int, int, short, [MarshalAs(UnmanagedType.U1)] bool)](#setgridvisibility(int,-int,-short,-[marshalas(unmanagedtype.u1)]-bool))
- [SetIsAutoScale](#setisautoscale)
- [SetMargin](#setmargin)
- [SetMergeAllEnabled](#setmergeallenabled)
- [SetOverrides(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType, CellProperties)](#setoverrides(int,-int,-autodesk.autocad.databaseservices.gridlinetype,-cellproperties))
- [SetOverrides(int, int, int, CellProperties)](#setoverrides(int,-int,-int,-cellproperties))
- [SetRotation](#setrotation)
- [SetRowHeight(double)](#setrowheight(double))
- [SetRowHeight(int, double)](#setrowheight(int,-double))
- [SetScale](#setscale)
- [SetSize](#setsize)
- [SetTextHeight(double, int)](#settextheight(double,-int))
- [SetTextHeight(int, int, double)](#settextheight(int,-int,-double))
- [SetTextHeight(int, int, int, double)](#settextheight(int,-int,-int,-double))
- [SetTextRotation](#settextrotation)
- [SetTextString(int, int, int, string)](#settextstring(int,-int,-int,-string))
- [SetTextString(int, int, string)](#settextstring(int,-int,-string))
- [SetTextStyle(int, int, ObjectId)](#settextstyle(int,-int,-objectid))
- [SetTextStyle(ObjectId, int)](#settextstyle(objectid,-int))
- [SetTextStyleId](#settextstyleid)
- [SetToolTip](#settooltip)
- [SetValue(int, int, int, object)](#setvalue(int,-int,-int,-object))
- [SetValue(int, int, int, object, Autodesk.AutoCAD.DatabaseServices.ParseOption)](#setvalue(int,-int,-int,-object,-autodesk.autocad.databaseservices.parseoption))
- [SetValue(int, int, int, string, Autodesk.AutoCAD.DatabaseServices.ParseOption)](#setvalue(int,-int,-int,-string,-autodesk.autocad.databaseservices.parseoption))
- [SetValue(int, int, object)](#setvalue(int,-int,-object))
- [SetValue(int, int, string, Autodesk.AutoCAD.DatabaseServices.ParseOption)](#setvalue(int,-int,-string,-autodesk.autocad.databaseservices.parseoption))
- [SuppressRegenerateTable](#suppressregeneratetable)
- [TableStyleOverrides](#tablestyleoverrides)
- [TextHeight(Autodesk.AutoCAD.DatabaseServices.RowType)](#textheight(autodesk.autocad.databaseservices.rowtype))
- [TextHeight(int, int)](#textheight(int,-int))
- [TextRotation](#textrotation)
- [TextString(int, int)](#textstring(int,-int))
- [TextString(int, int, Autodesk.AutoCAD.DatabaseServices.FormatOption)](#textstring(int,-int,-autodesk.autocad.databaseservices.formatoption))
- [TextStringConst](#textstringconst)
- [TextStyle(Autodesk.AutoCAD.DatabaseServices.RowType)](#textstyle(autodesk.autocad.databaseservices.rowtype))
- [TextStyle(int, int)](#textstyle(int,-int))
- [UnitType(Autodesk.AutoCAD.DatabaseServices.RowType)](#unittype(autodesk.autocad.databaseservices.rowtype))
- [UnitType(int, int)](#unittype(int,-int))
- [UnmergeCells](#unmergecells)
- [UpdateDataLink(Autodesk.AutoCAD.DatabaseServices.UpdateDirection, Autodesk.AutoCAD.DatabaseServices.UpdateOption)](#updatedatalink(autodesk.autocad.databaseservices.updatedirection,-autodesk.autocad.databaseservices.updateoption))
- [UpdateDataLink(int, int, Autodesk.AutoCAD.DatabaseServices.UpdateDirection, Autodesk.AutoCAD.DatabaseServices.UpdateOption)](#updatedatalink(int,-int,-autodesk.autocad.databaseservices.updatedirection,-autodesk.autocad.databaseservices.updateoption))
- [Value](#value)

### Properties

- [BreakEnabled](#breakenabled)
- [BreakFlowDirection](#breakflowdirection)
- [BreakOptions](#breakoptions)
- [Cells](#cells)
- [Columns](#columns)
- [Direction](#direction)
- [FlowDirection](#flowdirection)
- [HasSubSelection](#hassubselection)
- [Height](#height)
- [HorizontalCellMargin](#horizontalcellmargin)
- [IsHeaderSuppressed](#isheadersuppressed)
- [IsTitleSuppressed](#istitlesuppressed)
- [MinimumTableHeight](#minimumtableheight)
- [MinimumTableWidth](#minimumtablewidth)
- [NumColumns](#numcolumns)
- [NumRows](#numrows)
- [Rows](#rows)
- [SubSelection](#subselection)
- [TableStyle](#tablestyle)
- [TableStyleName](#tablestylename)
- [VerticalCellMargin](#verticalcellmargin)
- [Width](#width)


## Constructors Details

### Table

#### Description
Constructor.
```text
public Table();
```

### Alignment(Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
Obsolete. Returns the cell alignment for a given row type of the table object. 
The possible row type values are DataRow, TitleRow, and HeaderRow. If no row type is specified, the default of DataRow will be used. 
Possible values for CellAlignment are TopLeft, TopCenter, TopRight, MiddleLeft, MiddleCenter, MiddleRight, BottomLeft, BottomCenter, and BottomRight. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.CellAlignment Alignment(
    Autodesk.AutoCAD.DatabaseServices.RowType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType type | Input row type for which the cell alignment value will be returned |

Use Cell functionality instead
### Alignment(int, int)

#### Description
Obsolete. Returns the alignment of the text or block in the specified cell of the table. 
Possible cell alignment values are TopLeft, TopCenter, TopRight, MiddleLeft, MiddleCenter, MiddleRight, BottomLeft, BottomCenter, and BottomRight. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.CellAlignment Alignment(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |

Use Table.Cells[row,column].Alignment instead.
### AttachmentPoint

#### Description
Obsolete. Returns the attachment point of the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Point3d AttachmentPoint(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |

Use Table.Cells[row,column].AttachmentPoint instead.
### BackgroundColor(Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
Obsolete. Returns the background color for a given row type of the table object. 
The possible row type values are DataRow, TitleRow, and HeaderRow. If no row type is specified, the default of DataRow is used. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.Colors.Color BackgroundColor(
    Autodesk.AutoCAD.DatabaseServices.RowType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType type | Input row type for which the Color value is returned |

Body Source
```text
[Obsolete("Use Cell functionality instead.")]
public virtual Autodesk.AutoCAD.Colors.Color BackgroundColor(Autodesk.AutoCAD.DatabaseServices.RowType type)
{
}

```

Use Cell functionality instead.
### BackgroundColor(int, int)

#### Description
Obsolete. Returns the background color of the specified cell in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.Colors.Color BackgroundColor(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |

Use Table.Cells[row,column].BackgroundColor instead.
### BlockRotation

#### Description
Obsolete. Returns the rotation angle of the block reference at the specified cell in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double BlockRotation(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |

Use Table.Cells[row,column].Contents[i].Rotation instead.
### BlockScale

#### Description
Obsolete. Returns the scale factor of the block reference at the specified cell in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double BlockScale(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |

Use Table.Cells[row,column].Contents[i].Scale instead.
### BlockTableRecordId

#### Description
Obsolete. Returns the object ID of the block table record at the specified cell in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual ObjectId BlockTableRecordId(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |

Use Table.Cells[row,column].Contents[i].BlockTableRecordId instead.
### CanDeleteColumns

#### Description
Obsolete. Checks whether the column can be deleted from the specified index. 
Returns true if new column can be deleted, false if not. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool CanDeleteColumns(
    int index, 
    int nCount
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input System.Int32 object to check if a column can be deleted. |
| int nCount | Input number of columns to delete |

Use CellRange.CanDeleteColumns instead.
### CanDeleteRows

#### Description
Obsolete. Checks whether the row can be deleted from the specified index. 
Returns true if new row can be deleted, false if not. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool CanDeleteRows(
    int index, 
    int nCount
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input System.Int32 object to check if a row can be deleted. |
| int nCount | Input number of rows to delete |

Use CellRange.CanDeleteRows instead.
### CanInsertColumn

#### Description
Obsolete. Checks whether new columns can be inserted at the specified index. 
Returns true if new column can be inserted, false if not. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool CanInsertColumn(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input System.Int32 object to check if new column can be inserted. |

Use Table.Columns[column].CanInsertColumn instead.
### CanInsertRow

#### Description
Checks whether new rows can be inserted at the specified index. 
Returns true if new row can be inserted, false if not. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool CanInsertRow(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input System.Int32 object to check if new row can be inserted. |

Use Table.Rows[row].CanInsertRow instead.
### CellStyleOverrides

#### Description
Obsolete. Returns the cell overrides for the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual TableStyleOverride\[\] CellStyleOverrides(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |

Use Table.Cells[row,column].StyleOverrides instead.
### CellType

#### Description
Returns the cell type of the cell at the specified location in the table. Possible values for cell type are Table.TextCell and Table.BlockCell.
```text
public virtual TableCellType CellType(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |

### ClearSubSelection

#### Description
Removes the subselection set of cells from the table.
```text
public virtual void ClearSubSelection();
```

### ClearTableStyleOverrides

#### Description
Obsolete. Clears the overrides used in a table and its cells. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void ClearTableStyleOverrides(
    int options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int options | Input System.Int32 object. |

Use Cell functionality instead.
### ColumnWidth

#### Description
Obsolete. Returns the column width at the specified column index in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double ColumnWidth(
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int col | Input zero-based column index |

Use Table.Columns[col].Width instead.
### ContentColor(Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
Obsolete. Returns the content color for a given row type of the table object. 
The possible values of type are DataRow, TitleRow, and HeaderRow. If no row type is specified, the default of DataRow will be used. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.Colors.Color ContentColor(
    Autodesk.AutoCAD.DatabaseServices.RowType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType type | Input Autodesk.AutoCAD.DatabaseServices.RowType object specifying the row type for which the Color value will be returned |

Use Cell functionality instead.
### ContentColor(int, int)

#### Description
Obsolete. Returns the color of the cell content for the specified cell in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.Colors.Color ContentColor(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |

Use Table.Cells[row,column].ContentColor instead.
### CopyFrom(LinkedTableData, TableCopyOptions)

#### Description
Copies content and format from source table. The table copy options can be passed to specify what to copy.
```text
public virtual void CopyFrom(
    LinkedTableData source, 
    TableCopyOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| LinkedTableData source | Input source table |
| TableCopyOptions options | Input copy option |

### CopyFrom(LinkedTableData, TableCopyOptions, CellRange, CellRange)

#### Description
Copies content and format from source table. The table copy options can be passed to specify what to copy. The source and target range can be specified. If the source and target range does not match then it is copied to a new range depending on the table option value.
```text
public virtual CellRange CopyFrom(
    LinkedTableData source, 
    TableCopyOptions options, 
    CellRange sourceRange, 
    CellRange targetRange
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| LinkedTableData source | Input source table |
| TableCopyOptions options | Input copy option |
| CellRange sourceRange | Input source cell range |
| CellRange targetRange | Input target cell range |

### CopyFrom(Table, TableCopyOptions, CellRange, CellRange)

#### Description
Copies content and format from source table. The table copy options can be passed to specify what to copy. The source and target range can be specified. If the source and target range does not match then it is copied to a new range depending on the table option value.
```text
public virtual CellRange CopyFrom(
    Table source, 
    TableCopyOptions options, 
    CellRange sourceRange, 
    CellRange targetRange
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Table source | Input table source |
| TableCopyOptions options | Input table copy options |
| CellRange sourceRange | Input source cell range |
| CellRange targetRange | Input target cell range |

### CreateContent

#### Description
Obsolete. This function is called to create additional contents for a cell; one is created by default. 
Returns the index of the created content. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual int CreateContent(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents.Add or InsertAt instead.
### DataType(Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
Obsolete. Returns the data type and unit type of the specified row type. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.DataType DataType(
    Autodesk.AutoCAD.DatabaseServices.RowType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType type | Input Autodesk.AutoCAD.DatabaseServices.RowType object specifying the data type |

Use Table.Cells[row,column].DataType instead.
### DataType(int, int)

#### Description
Obsolete. Returns the data type and unit type of the first content. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.DataType DataType(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int col | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].DataType instead.
### DeleteCellContent

#### Description
Obsolete. Deletes the cell content for the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void DeleteCellContent(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |

Use Table.Cells[row,column].DeleteCellContent instead.
### DeleteColumns

#### Description
Deletes the specified number of columns from the table at the column index col.
```text
public virtual void DeleteColumns(
    int col, 
    int columns
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |
| int columns | Input System.Int32 object number of columns to delete |

### DeleteContent(CellRange)

#### Description
Obsolete. Deletes all the contents in a range of cells. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void DeleteContent(
    CellRange A_0
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| range | Input range of cells to delete the contents |

Use CellRange.DeleteContent instead.
### DeleteContent(int, int)

#### Description
Obsolete. Deletes all the contents in a cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void DeleteContent(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].Contents.Clear instead.
### DeleteContent(int, int, int)

#### Description
Obsolete. Deletes content from a cell from the specified index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void DeleteContent(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of row. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents.RemoveAt instead.
### DeleteRows

#### Description
Deletes the specified number of rows from the table at the row index row.
```text
public virtual void DeleteRows(
    int row, 
    int rows
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int rows | Input System.Int32 object number of rows to delete |

### FieldId

#### Description
Obsolete. Returns the object ID of the Field in the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual ObjectId FieldId(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |

Use Table.Cells[row,column].FieldId instead.
### Fill

#### Description
Fills or clears cells in rows or columns by copying or generating series.
```text
public virtual void Fill(
    CellRange fillRange, 
    CellRange sourceRange, 
    TableFillOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CellRange fillRange | Input Autodesk.AutoCAD.DatabaseServices.CellRange object. Range to be filled. This shouldn't overlap the source range except when this range is to be cleared instead of filled in which case this range should be contained fully in source range. |
| CellRange sourceRange | Input Autodesk.AutoCAD.DatabaseServices.CellRange object. Source range to copy or use as pattern. This can be set to invalid range if the fill range is to be cleared. |
| TableFillOptions options | Input table copy options |

### Format(Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
Obsolete. Returns the cell format type. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string Format(
    Autodesk.AutoCAD.DatabaseServices.RowType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType type | Input cell format type |

Use Table.Cells[row,column].DataFormat instead.
### Format(int, int)

#### Description
Obsolete. Returns the cell format based on the zero-based row and column index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string Format(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |

Use Table.Cells[row,column].DataFormat instead.
### GenerateLayout

#### Description
This function will update the table object according to the current table style. It computes table geometry, including grid lines, text content, block content, and background fills, from given definition data and table style. The generated table geometry are maintained internally by member data mpEntities, which is a list of in-memory Entity pointers. 
This function does not generate the table block. The table block is created automatically from the in-memory entity list when the application posts the table object to database and closes the object. 
This function empowers the table object for full use regardless of its database status--resident or non-resident. The generated in-memory table geometry will be deleted automatically by table object destructor.
```text
public virtual void GenerateLayout();
```

### GetBlockAttributeValue(int, int, int, ObjectId)

#### Description
Obsolete. Gets the block attribute value if the content at the specified content index is a block with attributes. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string GetBlockAttributeValue(
    int row, 
    int column, 
    int contentIndex, 
    ObjectId attDefId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int column | Input System.Int32 object specifying the zero-based column index for the cell |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| ObjectId attDefId | Input Autodesk.AutoCAD.DatabaseServices.ObjectId object. |

Use Table.Cells[row,column].Contents[i].GetBlockAttributeValue instead.
### GetBlockAttributeValue(int, int, ObjectId)

#### Description
Obsolete. Gets the attribute value from the block cell using the specified object ID key. If there is no overridden attribute value, it returns the default attribute value defined in the original AttributeDefinition object. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string GetBlockAttributeValue(
    int row, 
    int col, 
    ObjectId attributeDefinitionId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |
| ObjectId attributeDefinitionId | Input Autodesk.AutoCAD.DatabaseServices.ObjectId object. |

Use Table.Cells[row,column].Contents[i].GetBlockAttributeValue instead.
### GetBlockTableRecordId

#### Description
Obsolete. Returns the id of the block table record for the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual ObjectId GetBlockTableRecordId(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int column | Input System.Int32 object specifying the zero-based column index for the cell |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents[i].BlockTableRecordId instead.
### GetBreakHeight

#### Description
Returns the break height of the specified table when table breaking is enabled.
```text
public virtual double GetBreakHeight(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input table index. It should be more than or equal to 0 and less than the number of multiple tables, when the table breaks. |

### GetBreakOffset

#### Description
Returns the table break offset of the table.
```text
public virtual Vector3d GetBreakOffset(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input table index. It should be more than or equal to 0 and less than the number of multiple tables, when the table breaks. |

### GetBreakSpacing

#### Description
Returns the table break spacing.
```text
public virtual double GetBreakSpacing();
```

### GetCellExtents

#### Description
Obsolete. Gets the cell extents for the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void GetCellExtents(
    int row, 
    int col, 
    [MarshalAs(UnmanagedType.U1)] bool isOuterCell, 
    Point3dCollection pts
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |
| [MarshalAs(UnmanagedType.U1)] bool isOuterCell | Output System.Boolean object indicating whether the specified cell is an outer cell |
| Point3dCollection pts | Output Autodesk.AutoCAD.Geometry.Point3dCollection object; point collection containing the cell extents information |

Use Table.Cells[row,column].GetExtents instead.
### GetCellState

#### Description
Obsolete. Returns the cell state. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual CellStates GetCellState(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

#### Notes
This function will ignore internal cell states like CellStateLinked which cannot be changed.
Use Table.Cells[row,column].State instead.
### GetCellStyle

#### Description
Obsolete. Returns the the cell style of a cell, row, or column. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string GetCellStyle(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |

#### Notes
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
Use Table.Cells[row,column].Style instead.
### GetColumnName

#### Description
Obsolete. Returns the columns name retrieved from the specified index. 
Column name is optional so it can be blank. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string GetColumnName(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input zero based index of the column |

Use Table.Columns[i].Name instead.
### GetContentColor

#### Description
Obsolete. Returns the color of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.Colors.Color GetContentColor(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].ContentColor instead.
### GetContentLayout

#### Description
Obsolete. Returns the content layout of the first content. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.CellContentLayout GetContentLayout(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].ContentLayout instead.
### GetContentTypes(int, int)

#### Description
Obsolete. Returns the content type of the first content. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual CellContentTypes GetContentTypes(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].ContentTypes instead.
### GetContentTypes(int, int, int)

#### Description
Obsolete. Returns the content type of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual CellContentTypes GetContentTypes(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Content[i].ContentTypes instead.
### GetCustomData(int, int)

#### Description
Obsolete. Returns the custom data value set in cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual int GetCustomData(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |

Use Table.Cells[row,column].GetCustomData instead.
### GetCustomData(int, int, string)

#### Description
Obsolete. Gets the custom data value set in cell, row, or column as key-value pairs. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual object GetCustomData(
    int row, 
    int column, 
    string key
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| string key | Input key to store the custom data |

Use Table.Cells[row,column].SetCustomData instead.
### GetDataFormat(int, int)

#### Description
Obsolete. Returns the data format of the first content. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string GetDataFormat(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].DataFormat instead.
### GetDataFormat(int, int, int)

#### Description
Obsolete. Returns the data format of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string GetDataFormat(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents[i].DataFormat instead.
### GetDataLink()

#### Description
Gets the data link if the cell is linked to a data source using data link.
```text
public virtual ObjectIdCollection GetDataLink();
```

### GetDataLink(CellRange)

#### Description
Obsolete. Gets the data links set in the specified range. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual ObjectIdCollection GetDataLink(
    CellRange range
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CellRange range | Input range to get the data links. If this is NULL it gets all the data links in the table. |

### GetDataLink(int, int)

#### Description
Obsolete. Returns the id of the data link if the specified cell is linked to a data source using a data link. Returns null id if the cell is not linked using a data link. 
This function may be called on any of the cells in a linked range. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual ObjectId GetDataLink(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].DataLink instead.
### GetDataLinkRange

#### Description
Obsolete. Returns the data link range if the specified cell is part of a linked range. Returns invalid range if the specified cell is not part of a linked range. The specified cell can be any cell in a linked range. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual CellRange GetDataLinkRange(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].GetDataLinkRange instead.
### GetDataType

#### Description
Obsolete. Returns the data type and unit type of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual DataTypeParameter GetDataType(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents[i].DataType instead.
### GetEnumerator()

#### Description
Obsolete. Returns the enumerator object. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual TableEnumerator GetEnumerator();
```

Use Table.Cells instead.
### GetEnumerator(CellRange, TableEnumeratorOption)

#### Description
Obsolete. Returns the enumerator object within the specified range based on the table enumeration option. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual TableEnumerator GetEnumerator(
    CellRange range, 
    TableEnumeratorOption option
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CellRange range | Input range of cells to delete the contents |
| TableEnumeratorOption option | Input enumerator option |

Use Table.Cells instead.
### GetFieldId

#### Description
Obsolete. Returns the id of the field at the specified index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual ObjectId GetFieldId(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents[i].FieldId instead.
### GetFormula

#### Description
Obsolete. Returns the formula if the content at the specified content index has a formula, otherwise returns empty string. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string GetFormula(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents[i].Formula instead.
### GetGridColor

#### Description
Obsolete. Returns the grid color of cell, row, or column. 
To specify cell, pass a valid row and column indices. 
To specify row, pass a valid row index and pass -1 as column index. 
To specify column, pass a valid column index and pass -1 as row index. 
To set same value in multiple grid line types combine multiple grid line types using OR operator and pass it. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.Colors.Color GetGridColor(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line type |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.Color instead.
### GetGridDoubleLineSpacing

#### Description
Obsolete. Returns the grid double line spacing in a cell, row, or column. 
To specify cell, pass a valid row and column indices. To specify row, pass a valid row index and pass -1 as column index. To specify column, pass a valid column index and pass -1 as row index. To set the same value in multiple grid line types combine multiple grid line types using the OR operator and pass it. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double GetGridDoubleLineSpacing(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input Autodesk.AutoCAD.DatabaseServices.GridLineType object; grid line type |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.DoubleLineSpacing instead.
### GetGridLineStyle

#### Description
Obsolete. Returns the grid line style in a cell, row, or column. 
To specify cell, pass a valid row and column indices. To specify row, pass a valid row index and pass -1 as column index. To specify column, pass a valid column index and pass -1 as row index. To set the same value in multiple grid line types combine multiple grid line types using the OR operator and pass it. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.GridLineStyle GetGridLineStyle(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input Autodesk.AutoCAD.DatabaseServices.GridLineType object; grid line type |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.LineStyle instead.
### GetGridLinetype

#### Description
Obsolete. Returns the grid line type in a cell, row, or column. 
To specify cell, pass a valid row and column indices. To specify row, pass a valid row index and pass -1 as column index. To specify column, pass a valid column index and pass -1 as row index. To set the same value in multiple grid line types combine multiple grid line types using the OR operator and pass it. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual ObjectId GetGridLinetype(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input Autodesk.AutoCAD.DatabaseServices.GridLineType object. To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.Linetype instead.
### GetGridLineWeight

#### Description
Returns the grid line weight in a cell, row, or column. 
To specify cell, pass a valid row and column indices. To specify row, pass a valid row index and pass -1 as column index. To specify column, pass a valid column index and pass -1 as row index. To set the same value in multiple grid line types combine multiple grid line types using the OR operator and pass it. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.LineWeight GetGridLineWeight(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line type |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.LineWeight instead.
### GetGridProperty

#### Description
Returns the grid line weight in a cell, row, or column. 
To specify cell, pass a valid row and column indices. To specify row, pass a valid row index and pass -1 as column index. To specify column, pass a valid column index and pass -1 as row index. To set the same value in multiple grid line types combine multiple grid line types using the OR operator and pass it. 
Before calling this function, the mnPropMask member of the structure AcGridProperty should be initialized to a value indicating which properties to set. If it is set to zero it sets all the properties.
```text
public virtual GridPropertyParameter GetGridProperty(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input Autodesk.AutoCAD.DatabaseServices.GridLineType object; grid line type |

### GetGridVisibility

#### Description
Obsolete. Returns the grid visibility of cell, row, or column. 
To specify cell, pass a valid row and column indices; to specify row, pass a valid row index and pass -1 as column index. 
To specify column, pass a valid column index and pass -1 as row index. 
To set same value in multiple grid line types combine multiple grid line types using OR operator and pass it. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.Visibility GetGridVisibility(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line type |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.IsVisible instead.
### GetIsAutoScale

#### Description
Obsolete. Returns the status of the mBlockAutoFit flag at the specified cell in the table. If this flag is true, the Table object automatically computes the scale and insertion point for the block content in order to fit it into the specified cell. 
Returns true if the block at the specified index is auto-scaled. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool GetIsAutoScale(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents[i].IsAutoScale instead.
### GetMargin

#### Description
Obsolete. Returns the margin of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double GetMargin(
    int row, 
    int column, 
    CellMargins margin
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. Pass the value -1 if you are only concerned with the column. |
| int column | Input row index. Pass the value -1 if you are only concerned with the row. |
| CellMargins margin | Input margin type to get |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.Margin instead.
### GetMergeAllEnabled

#### Description
Obsolete. Returns true if the merge-all flag is enabled in a row or column, else false. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool GetMergeAllEnabled(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].IsMergeAllEnabled instead.
### GetMergeRange

#### Description
Obsolete. Returns merge range. The merge range will be invalid if the cell is not part of a merge range. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual CellRange GetMergeRange(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### GetNumberOfContents

#### Description
Obsolete. Returns the number of contents in the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual int GetNumberOfContents(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].Contents.Count instead.
### GetOverrides(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType)

#### Description
Obsolete. Returns the override in specified grid line type in cell, row, or column. 
To specify cell pass a valid row and column indices. 
To specify row pass a valid row index and pass -1 as column index. 
To specify column pass a valid column index and pass -1 as row index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual CellProperties GetOverrides(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line type |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.Overrides instead.
### GetOverrides(int, int, int)

#### Description
Obsolete. Returns the override of cell, row, column, or content. 
To specify content pass a valid row, column, and content indices. 
To specify cell pass a valid row and column indices and pass -1 as content index. 
To specify row pass a valid row index and pass -1 as column and content indices. 
To specify column pass a valid column index and pass -1 as row and content indices. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual CellProperties GetOverrides(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| int contentIndex | Input content index. |

Use Table.Cells[row,column].Contents[i].Overrides instead.
### GetRotation

#### Description
Obsolete. Returns the rotation angle of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double GetRotation(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents[i].Rotation instead.
### GetScale

#### Description
Obsolete. Returns the scale of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double GetScale(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents[i].Scale instead.
### GetTextHeight

#### Description
Obsolete. Returns the text height of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double GetTextHeight(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents[i].TextHeight instead.
### GetTextString(int, int, int)

#### Description
Obsolete. Returns the text for the first content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string GetTextString(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents |

Use Table.Cells[row,column].Contents[i].TextString instead.
### GetTextString(int, int, int, Autodesk.AutoCAD.DatabaseServices.FormatOption)

#### Description
Obsolete. Returns the text for the first content at the specified content index. This function makes a copy of text and uses the copy as the text string in the specified cell through the formatOption parameter. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string GetTextString(
    int row, 
    int column, 
    int contentIndex, 
    Autodesk.AutoCAD.DatabaseServices.FormatOption formatOption
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents |
| Autodesk.AutoCAD.DatabaseServices.FormatOption formatOption | Input null-terminated text string |

Use Table.Cells[row,column].Contents[i].SetTextString instead.
### GetTextStyleId

#### Description
Obsolete. Returns the text style of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual ObjectId GetTextStyleId(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents[i].TextStyleId instead.
### GetToolTip

#### Description
Obsolete. Returns the tooltip string for cell, row, or column. 
To specify cell, pass a valid row and column indices. 
To specify row, pass a valid row index and pass -1 as column index. 
To specify column, pass a valid column index and pass -1 as row index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string GetToolTip(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |

Use Table.Cells[row,column].ToolTip instead.
### GetValue(int, int, int)

#### Description
Obsolete. Returns the value of the first content based on the specified contentIndex. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual object GetValue(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Content[i].Value instead.
### GetValue(int, int, int, Autodesk.AutoCAD.DatabaseServices.FormatOption)

#### Description
Obsolete. Returns the value of the first content based on the specified contentIndex. This function makes a copy of the value and uses the copy in the specified cell through the formatOption parameter. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual object GetValue(
    int row, 
    int column, 
    int contentIndex, 
    Autodesk.AutoCAD.DatabaseServices.FormatOption formatOption
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| Autodesk.AutoCAD.DatabaseServices.FormatOption formatOption | Input Autodesk.AutoCAD.DatabaseServices.FormatOption object; format option |

Use Table.Cells[row,column].Content[i].GetValue instead.
### GridColor(Autodesk.AutoCAD.DatabaseServices.GridLineType, Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
Obsolete. Returns the grid color for a given grid line type and row type of the table object. 
The possible values of the grid line type are HorzTop, HorzInside, HorzBottom, VertLeft, VertInside, and VertRight. 
The possible values of the row type are DataRow, TitleRow, and HeaderRow. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.Colors.Color GridColor(
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridlineType, 
    Autodesk.AutoCAD.DatabaseServices.RowType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridlineType | Input grid line type for which to return the Color value |
| Autodesk.AutoCAD.DatabaseServices.RowType type | Input row type for which to return the Color value |

Use Cell functionality instead.
### GridColor(int, int, CellEdgeMasks)

#### Description
Obsolete. Returns the grid color of the specified edge of the cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.Colors.Color GridColor(
    int row, 
    int col, 
    CellEdgeMasks edge
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input object specifying the zero-based row index for the cell |
| int col | Input object specifying the zero-based column index for the cell |
| CellEdgeMasks edge | Input object specifying the edge index for the cell |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.Color instead.
### GridLineWeight(Autodesk.AutoCAD.DatabaseServices.GridLineType, Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
Obsolete. Returns the lineweight for a given grid line type and row type of the table object. 
The possible values of the grid line type are HorzTop, HorzInside, HorzBottom, VertLeft, VertInside, and VertRight. 
The possible values of the row type are DataRow, TitleRow, and HeaderRow. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.LineWeight GridLineWeight(
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridlineType, 
    Autodesk.AutoCAD.DatabaseServices.RowType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridlineType | To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index. |
| Autodesk.AutoCAD.DatabaseServices.RowType type | Input row type. |

Use Cell functionality instead.
### GridLineWeight(int, int, CellEdgeMasks)

#### Description
Obsolete. Returns the grid lineweight of the specified edge of the cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.LineWeight GridLineWeight(
    int row, 
    int col, 
    CellEdgeMasks edge
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int col | Input column index. This can be -1. |
| CellEdgeMasks edge | Input integer specifying the edge index for the cell |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.LineWeight instead.
### GridVisibility(Autodesk.AutoCAD.DatabaseServices.GridLineType, Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
Obsolete. Returns the grid visibility for a given grid line type and row type of the table object. 
The possible values of the grid line type are HorzTop, HorzInside, HorzBottom, VertLeft, VertInside, and VertRight. 
The possible values of the row type are DataRow, TitleRow, and HeaderRow. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool GridVisibility(
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridlineType, 
    Autodesk.AutoCAD.DatabaseServices.RowType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridlineType | Input grid line type for which to return the grid visibility |
| Autodesk.AutoCAD.DatabaseServices.RowType type | Input row type for which to return the grid visibility |

Use Cell functionality instead.
### GridVisibility(int, int, CellEdgeMasks)

#### Description
Obsolete. Returns the grid visibility of the specified edge of the cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool GridVisibility(
    int row, 
    int col, 
    CellEdgeMasks edge
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| CellEdgeMasks edge | Input specifying the edge index for the cell |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.Visibility instead.
### HasFormula

#### Description
Obsolete. Returns true if the content at the specified index is a formula. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool HasFormula(
    int row, 
    int column, 
    int contentIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].Contents[i].HasFormula instead.
### HitTest

#### Description
This function performs a hit test for the specified point and viewing direction. 
Returns true if a table set is hit; otherwise, returns false.
```text
public virtual TableHitTestInfo HitTest(
    Point3d point, 
    Vector3d viewVector
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d point | Input 3D point in WCS specifying the input picking point |
| Vector3d viewVector | Input 3D vector in WCS specifying the view direction for the hit test |

### InsertColumns

#### Description
Inserts one or more columns at the specified index.
```text
public virtual void InsertColumns(
    int col, 
    double width, 
    int columns
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int col | Input specifying the zero-based column index for the cell |
| double width | Input width for the inserted columns |
| int columns | Input number of columns to insert |

### InsertColumnsAndInherit

#### Description
Inserts the specified number of new columns into the table at the column index col.
```text
public virtual void InsertColumnsAndInherit(
    int col, 
    int inheritFrom, 
    int numCols
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int col | Input index at which to insert the new columns |
| int inheritFrom | Input index of the column to inherit the format for the new columns. It can be -1. If it is -1 new columns don't inherit any format and they use default format. |
| int numCols | Input number of columns to insert |

### InsertRows

#### Description
Inserts one or more rows at the specified index.
```text
public virtual void InsertRows(
    int row, 
    double height, 
    int rows
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| double height | Input height for the inserted rows |
| int rows | Input number of rows to insert |

### InsertRowsAndInherit

#### Description
Inserts the specified number of new rows into the table at the row index.
```text
public virtual void InsertRowsAndInherit(
    int index, 
    int inheritFrom, 
    int numRows
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index at which to insert the new rows |
| int inheritFrom | Input index of the row to inherit the format for the new rows. It can be -1. If it is -1 new rows don't inherit any format and they use default format. |
| int numRows | Input number of rows to insert |

### IsAutoScale

#### Description
Obsolete. Returns the status of the mBlockAutoFit flag at the specified cell in the table. If this flag is true, the Table object automatically computes the scale and insertion point for the block content in order to fit it into the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool IsAutoScale(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |

Use Table.Cells[row,column].Contents[i].IsAutoScale instead.
### IsBackgroundColorNone(Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
Obsolete. Returns true if the background color for the given row type of the table object is set to no color value. Otherwise, returns false. 
The possible row type values are DataRow, TitleRow, and HeaderRow. If no row type is specified, the default of DataRow is used. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool IsBackgroundColorNone(
    Autodesk.AutoCAD.DatabaseServices.RowType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType type | Input row type for which to return the Boolean value indicating whether the background color is set to none |

Use Cell functionality instead.
### IsBackgroundColorNone(int, int)

#### Description
Obsolete. Returns true if the background color for the specified cell in the table is set to no color value. Otherwise, returns false. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool IsBackgroundColorNone(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |

Use Table.Cells[row,column].IsBackgroundColorNone instead.
### IsContentEditable

#### Description
Obsolete. This function checks the cell state to determine if a cell content can be modified. 
For example, content locked and read-only cells cannot be modified. Applications should use this function to determine if a cell is editable instead of calling cellState directly and checking the state since the semantics of an editable cell may change as new states are added. 
Returns true if the content can be modified and false if not. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool IsContentEditable(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].IsContentEditable instead.
### IsEmpty

#### Description
Obsolete. Checks whether the content of the specified cell is empty 
Returns true if the cell is empty, false if not. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool IsEmpty(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].IsEmpty instead.
### IsFormatEditable

#### Description
Obsolete. This function checks the cell state to determine if a cell format can be modified. Applications should use this function to determine if a cell is editable instead of calling cellState directly and checking the state since the semantics of an editable cell may change as new states are added. 
Returns true if the format can be modified and false if not. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool IsFormatEditable(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].IsFormatEditable instead.
### IsLinked

#### Description
Obsolete. Checks whether a cell is linked to a data source. 
Returns true if the cell is linked and false if not. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual bool IsLinked(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].IsLinked instead.
### IsMergedCell

#### Description
Obsolete. Returns true if the specified cell is within merged cells. The merged cell region is always a rectangular area. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public bool IsMergedCell(
    int row, 
    int col, 
    out CellRange range
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| out CellRange range | Output the range of merged cells |

Use Table.Cells[row,column].IsMerged instead.
### MergeCells

#### Description
This function merges cells within the specified range.
```text
public virtual void MergeCells(
    CellRange range
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CellRange range | Input range of cells to merge |

### MinimumColumnWidth

#### Description
Obsolete. Returns the minimum column width at the specified column index in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double MinimumColumnWidth(
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int col | Input zero-based column index |

Use Table.Columns[col].MinimumWidth instead.
### MinimumRowHeight

#### Description
Obsolete. Returns the minimum row height for the specified row in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double MinimumRowHeight(
    int row
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input zero-based row index |

Use Table.Rows[col].MinimumHeight instead.
### MoveContent

#### Description
Obsolete. Moves a content in a cell from one position to another position within the cell 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void MoveContent(
    int row, 
    int column, 
    int fromIndex, 
    int toIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int fromIndex | Input index of the content to move |
| int toIndex | Input get index to which the content should be moved |

Use Table.Cells[row,column].Contents.Move instead.
### RecomputeTableBlock

#### Description
This function updates the block table record the table object references to match any changes made to the table object since the last time the block table record was updated. 
If forceUpdate is true, then the block table record will be updated regardless of whether or not the table object has had any changes since the last time the block table record was updated. If forceUpdate is false, then the block table record will only be updated if the table object has been changed since it was opened, is not currently erased, and is not in the middle of an undo operation.
```text
public virtual void RecomputeTableBlock(
    [MarshalAs(UnmanagedType.U1)] bool forceUpdate
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool forceUpdate | Input indicating whether to force an update on the screen |

### RemoveAllOverrides

#### Description
Obsolete. Removes all the overrides in cell, row, or column. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void RemoveAllOverrides(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. Insert the value -1 if you are only concerned with a column. |
| int column | Input column index. Insert the value -1 if you are only concerned with a row. |

Use Cell functionality instead.
### RemoveDataLink()

#### Description
Removes all the data links in the table.
```text
public virtual void RemoveDataLink();
```

### RemoveDataLink(int, int)

#### Description
Obsolete. Removes the data link in the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void RemoveDataLink(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. Insert the value -1 if you are only concerned with a column. |
| int column | Input column index. Insert the value -1 if you are only concerned with a row. |

Use Table.Cells[row,column].RemoveDataLink instead.
### ReselectSubRegion

#### Description
This function provides the subentities of the current subselection cells. The paths may be empty if there are no subselection cells.
```text
public virtual void ReselectSubRegion(
    FullSubentityPath\[\] paths
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath[] paths | Output array of FullSubentPath |

### ResetValue

#### Description
Obsolete. Resets the value in a particular cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void ResetValue(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input object specifying the zero-based row index for the cell |
| int col | Input object specifying the zero-based column index for the cell |

Use Table.Cells[row,column].Contents(i).ResetValue instead.
### RowHeight

#### Description
Obsolete. Returns the row height of the specified row in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double RowHeight(
    int row
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input zero-based row index |

Use Table.Rows[col].Height instead.
### RowType

#### Description
Obsolete. Returns the row type of the specified row in the table. The row type may be TitleRow, HeaderRow, or DataRow. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.RowType RowType(
    int row
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input zero-based row index |

Use Row functionality instead.
### Select

#### Description
Selects a cell in the table using a specified point, viewing direction, and orientation. If Paths is not null, the cell subentities, including bounding grid lines, MText, and block insert, will be returned by Paths.
```text
public virtual TableHitTestInfo Select(
    Point3d pickingPoint, 
    Vector3d hitTestViewDirection, 
    Vector3d hitTestViewOrientation, 
    [MarshalAs(UnmanagedType.U1)] bool allowOutside, 
    [MarshalAs(UnmanagedType.U1)] bool inPickFirst, 
    FullSubentityPath\[\] paths
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d pickingPoint | Input 3D point in WCS specifying the input picking point |
| Vector3d hitTestViewDirection | Input 3D vector in WCS specifying the view direction for the hit test |
| Vector3d hitTestViewOrientation | Input 3D vector in WCS specifying the view orientation for the hit test |
| [MarshalAs(UnmanagedType.U1)] bool allowOutside | Input indicating whether a pick point outside the table will select a cell |
| [MarshalAs(UnmanagedType.U1)] bool inPickFirst | Input indicating if the entity is already in the pickfirst set (true) or if the pickfirst logic should attempt to subselect the entity directly (false) |
| FullSubentityPath[] paths | Output SubentPathArray |

### SelectSubRegion

#### Description
Selects a set of cells in the table using a specified window box, viewing direction, and orientation. 
If Paths is not null, the cell subentities, including bounding grid lines, MTexts, and block inserts, will be returned in Paths.
```text
public virtual CellRange SelectSubRegion(
    Point3d cornerPoint1, 
    Point3d cornerPoint2, 
    Vector3d selectionViewDirection, 
    Vector3d hitTestViewDirection, 
    Autodesk.AutoCAD.DatabaseServices.SelectType selectionType, 
    [MarshalAs(UnmanagedType.U1)] bool includeCurrentSelection, 
    [MarshalAs(UnmanagedType.U1)] bool inPickFirst, 
    FullSubentityPath\[\] paths
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d cornerPoint1 | Input 3D point in WCS specifying the first corner point of the window box selection |
| Point3d cornerPoint2 | Input 3D point in WCS specifying the second corner point of the window box selection |
| Vector3d selectionViewDirection | Input 3D vector in WCS specifying the view direction of the selection |
| Vector3d hitTestViewDirection | Input 3D vector in WCS specifying the view orientation of the hit test |
| Autodesk.AutoCAD.DatabaseServices.SelectType selectionType | Input SelectType enum specifying the selection type |
| [MarshalAs(UnmanagedType.U1)] bool includeCurrentSelection | Input System.Boolean object indicating whether the selected cells returned will include currently selected cells and newly selected cells or only newly selected cells |
| [MarshalAs(UnmanagedType.U1)] bool inPickFirst | Input System.Boolean object indicating if the entity is already in the pickfirst set (true) or if the pickfirst logic should attempt to subselect the entity directly (false) |
| FullSubentityPath[] paths | Output SubentPathArray |

### SetAlignment(Autodesk.AutoCAD.DatabaseServices.CellAlignment, int)

#### Description
Obsolete. Sets the cell alignment for the specified row types. Different row types can be OR'd. 
The possible row type values are DataRow,TitleRow, and HeaderRow. If no row type is specified, this function sets all the possible row types. 
Possible cell alignment values are TopLeft, TopCenter, TopRight, MiddleLeft, MiddleCenter, MiddleRight, BottomLeft, BottomCenter, and BottomRight. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetAlignment(
    Autodesk.AutoCAD.DatabaseServices.CellAlignment align, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.CellAlignment align | Input cell alignment |
| int rowTypes | Input row types |

Use Cell functionality instead.
### SetAlignment(int, int, Autodesk.AutoCAD.DatabaseServices.CellAlignment)

#### Description
Obsolete. Sets the alignment of the text or block in the specified cell of the table. 
Possible cell alignment values are TopLeft, TopCenter, TopRight, MiddleLeft, MiddleCenter, MiddleRight, BottomLeft, BottomCenter, and BottomRight. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetAlignment(
    int row, 
    int col, 
    Autodesk.AutoCAD.DatabaseServices.CellAlignment align
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the ce |
| int col | Input specifying the zero-based column index for the cell |
| Autodesk.AutoCAD.DatabaseServices.CellAlignment align | Input enum value specifying the cell alignment |

Use Table.Cells[row,column].Alignment instead.
### SetAutoScale

#### Description
Obsolete. Sets the auto fit flag, which determines whether to automatically fit the block into the specified cell. If autoFit is true, the Table object automatically computes the scale and insertion point for the block content in order to fit it into the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetAutoScale(
    int row, 
    int col, 
    [MarshalAs(UnmanagedType.U1)] bool autoFit
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| [MarshalAs(UnmanagedType.U1)] bool autoFit | Input Boolean indicating whether to auto fit the block at the specified cell |

Use Table.Cells[row,column].Contents[i].IsAutoScale instead.
### SetBackgroundColor(Autodesk.AutoCAD.Colors.Color, int)

#### Description
Obsolete. Sets the background color for the specified row types. Different row types can be OR'd. 
The possible row type values are DataRow, TitleRow, and HeaderRow. If no row type is specified, this function sets all the possible row types. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetBackgroundColor(
    Autodesk.AutoCAD.Colors.Color color, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.Colors.Color color | Input background color |
| int rowTypes | Input row types |

Use Cell functionality instead.
### SetBackgroundColor(int, int, Autodesk.AutoCAD.Colors.Color)

#### Description
Obsolete. Sets the background color of the specified cell in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetBackgroundColor(
    int row, 
    int col, 
    Autodesk.AutoCAD.Colors.Color color
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| Autodesk.AutoCAD.Colors.Color color | Input background color |

Use Table.Cells[row,column].BackgroundColor instead.
### SetBackgroundColorNone([MarshalAs(UnmanagedType.U1)] bool, int)

#### Description
Obsolete. Enables or disables the background color for the specified row type. Different row types can be combined. 
The possible row type values are DataRow, TitleRow, and HeaderRow. If no row type is specified, this function sets all the possible row types. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetBackgroundColorNone(
    [MarshalAs(UnmanagedType.U1)] bool value, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool value | Input indicating whether to enable the background color for the specified row type |
| int rowTypes | Input row types |

Use Cell functionality instead.
### SetBackgroundColorNone(int, int, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Obsolete. Enables or disables the background color for the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetBackgroundColorNone(
    int row, 
    int col, 
    [MarshalAs(UnmanagedType.U1)] bool value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| [MarshalAs(UnmanagedType.U1)] bool value | Input indicating whether to enable the background color for the specified cell |

Use Table.Cells[row,column].IsBackgroundColorNone instead.
### SetBlockAttributeValue(int, int, int, ObjectId, string)

#### Description
Obsolete. Sets the block attribute value if the content at the specified content index is a block with attributes. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetBlockAttributeValue(
    int row, 
    int column, 
    int contentIndex, 
    ObjectId attDefId, 
    string value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents |
| ObjectId attDefId | Input the object ID of the AttributeDefinition object |
| string value | Input character string specifying attribute value |

Use Table.Cells[row,column].Contents[i].GetBlockAttributeValue instead.
### SetBlockAttributeValue(int, int, ObjectId, string)

#### Description
Obsolete. Sets the block attribute value if the content at the specified content index is a block with attributes. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetBlockAttributeValue(
    int row, 
    int col, 
    ObjectId attributeDefinitionId, 
    string value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| ObjectId attributeDefinitionId | Input the object ID of an of AttributeDefinition object |
| string value | Input character string specifying attribute v |

Use Table.Cells[row,column].Contents[i].GetBlockAttributeValue instead.
### SetBlockRotation

#### Description
Obsolete. Sets the rotation angle of the block reference at the specified cell in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetBlockRotation(
    int row, 
    int col, 
    double rotationalAngle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| double rotationalAngle | Input rotation angle |

Use Table.Cells[row,column].Contents[i].Rotation instead.
### SetBlockScale

#### Description
Obsolete. Sets the scale factor of the block reference at the specified cell in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetBlockScale(
    int row, 
    int col, 
    double scale
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| double scale | Input scale factor |

Use Table.Cells[row,column].Contents[i].Scale instead.
### SetBlockTableRecordId(int, int, int, ObjectId, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Obsolete. Sets the id of the block table record for the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetBlockTableRecordId(
    int row, 
    int column, 
    int contentIndex, 
    ObjectId blockId, 
    [MarshalAs(UnmanagedType.U1)] bool autoFit
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| ObjectId blockId | Input block table record id to set |
| [MarshalAs(UnmanagedType.U1)] bool autoFit | Input System.Boolean object indicating whether to auto fit the block into the specified cell |

Use Table.Cells[row,column].Contents[i].BlockTableRecordId instead.
### SetBlockTableRecordId(int, int, ObjectId, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Obsolete. Sets the object ID of the block table record at the specified cell in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetBlockTableRecordId(
    int row, 
    int col, 
    ObjectId blockId, 
    [MarshalAs(UnmanagedType.U1)] bool autoFit
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| ObjectId blockId | Input BlockTableRecord object ID |
| [MarshalAs(UnmanagedType.U1)] bool autoFit | Input indicating whether to auto fit the block into the specified cell |

Use Table.Cells[row,column].Contents[i].BlockTableRecordId instead.
### SetBreakHeight

#### Description
Sets the break height of the specified table when table breaking is enabled.
```text
public virtual void SetBreakHeight(
    int index, 
    double height
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input table index. It should be more than or equal to 0 and less than the number of multiple tables, when the table breaks. |
| double height | Input break height |

### SetBreakOffset

#### Description
Sets the table break offset of the table.
```text
public virtual void SetBreakOffset(
    int index, 
    Vector3d offset
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input table index. It should be more than or equal to 0 and less than the number of multiple tables, when the table breaks. |
| Vector3d offset | Input offset value |

### SetBreakSpacing

#### Description
Sets the table break spacing.
```text
public virtual void SetBreakSpacing(
    double spacing
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double spacing | Input spacing |

### SetCellState

#### Description
Obsolete. Sets the cell state. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetCellState(
    int row, 
    int column, 
    CellStates cellState
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| CellStates cellState | Input cell state to set. This will replace all the bits of the current state |

#### Notes
This function will ignore internal cell states like CellStateLinked which cannot be changed.
Use Table.Cells[row,column].State instead.
### SetCellStyle

#### Description
Obsolete. Sets the the cell style of a cell, row, or column. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetCellStyle(
    int row, 
    int column, 
    string styleName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| string styleName | Input cell style to set. The cell style should exist in the table style set in this table. |

#### Notes
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
Use Table.Cells[row,column].Style instead.
### SetCellType

#### Description
Obsolete. Sets the cell type to be applied to the cell at the specified location in the table. Possible values for cell type are Table.TextCell and Table.BlockCell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetCellType(
    int row, 
    int col, 
    TableCellType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input the zero-based row index for the cell |
| int col | Input the zero-based column index for the cell |
| TableCellType type | Input enum value specifying the cell type |

Use Cell functionality instead.
### SetColumnName

#### Description
Obsolete. Sets a column's name; it can be left blank. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetColumnName(
    int index, 
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input zero based index of the column |
| string name | Input column name to set. This can be an empty string. |

Use Table.Columns[i].Name instead.
### SetColumnWidth(double)

#### Description
Sets a uniform column width for all the columns in the table.
```text
public virtual void SetColumnWidth(
    double width
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double width | Input uniform width to be used for all the columns in the table |

### SetColumnWidth(int, double)

#### Description
Obsolete. Sets the column width at the specified column index in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetColumnWidth(
    int col, 
    double width
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int col | Input zero-based column index |
| double width | Input width to be used for the specified column |

Use Table.Columns[col].Width instead.
### SetContentColor(Autodesk.AutoCAD.Colors.Color, int)

#### Description
Obsolete. Sets the content color for the specified row types. Different row types can be OR'd. 
The possible row type values are DataRow, TitleRow, and HeaderRow. If no row type is specified, this function sets all the possible row types. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetContentColor(
    Autodesk.AutoCAD.Colors.Color color, 
    int rowType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.Colors.Color color | Input text color |
| int rowType | Input row types |

Use Cell functionality instead.
### SetContentColor(int, int, Autodesk.AutoCAD.Colors.Color)

#### Description
Obsolete. Sets the color of the cell content for the specified cell in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetContentColor(
    int row, 
    int col, 
    Autodesk.AutoCAD.Colors.Color color
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int col | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| Autodesk.AutoCAD.Colors.Color color | Input content index. It should be more than or equal to 0 and less than the number of contents. |

Use Table.Cells[row,column].ContentColor instead.
### SetContentColor(int, int, int, Autodesk.AutoCAD.Colors.Color)

#### Description
Obsolete. Sets the color of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetContentColor(
    int row, 
    int column, 
    int contentIndex, 
    Autodesk.AutoCAD.Colors.Color color
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| Autodesk.AutoCAD.Colors.Color color | Input Autodesk.AutoCAD.Colors.Color object. |

Use Table.Cells[row,column].ContentColor instead.
### SetContentLayout

#### Description
Obsolete. Sets the content layout of the first content. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetContentLayout(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.CellContentLayout layout
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| Autodesk.AutoCAD.DatabaseServices.CellContentLayout layout | Input layout to set |

Use Table.Cells[row,column].ContentLayout instead.
### SetCustomData(int, int, int)

#### Description
Obsolete. Sets the custom data value set in cell, row, or column. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetCustomData(
    int row, 
    int column, 
    int data
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| int data | Input custom data to set. If this is NULL, it deletes the custom data. |

#### Notes
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
Use Table.Cells[row,column].SetCustomData instead.
### SetCustomData(int, int, string, object)

#### Description
Obsolete. Sets the custom data value set in cell, row, or column. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetCustomData(
    int row, 
    int column, 
    string key, 
    object value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| string key | Input key to use for the custom data |
| object value | Input custom data to set. If this is NULL, it deletes the custom data. |

#### Notes
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
Use Table.Cells[row,column].SetCustomData instead.
### SetDataFormat(int, int, int, string)

#### Description
Obsolete. Sets the data format of the first content. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetDataFormat(
    int row, 
    int column, 
    int contentIndex, 
    string format
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| string format | Input data format to set |

Use Table.Cells[row,column].Contents[i].DataFormat instead.
### SetDataFormat(int, int, string)

#### Description
Obsolete. Sets the data format of the first content. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetDataFormat(
    int row, 
    int column, 
    string format
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns |
| string format | Input data format to set |

Use Table.Cells[row,column].DataFormat instead.
### SetDataLink(CellRange, ObjectId, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Obsolete. Sets the specified data link in a cell. 
If the specified cell is top-left cell of an existing linked range this will overwrite the current data link. If it is any other cell in a linked range the function will fail. This function does not automatically update the data; call updateDataLink() to update the data. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetDataLink(
    CellRange range, 
    ObjectId dataLinkId, 
    [MarshalAs(UnmanagedType.U1)] bool bUpdate
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CellRange range | Input range to get the data links. If this is NULL it gets all the data links in the table. |
| ObjectId dataLinkId | Output reference to an array to receive the data link IDs. |
| [MarshalAs(UnmanagedType.U1)] bool bUpdate | Input true if the data link is to be updated after setting it, false if not. |

Use CellRange.SetDataLink instead.
### SetDataLink(int, int, ObjectId, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Obsolete. Sets the specified data link in a cell. 
If the specified cell is top-left cell of an existing linked range this will overwrite the current data link. If it is any other cell in a linked range the function will fail. This function does not automatically update the data; call updateDataLink() to update the data. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetDataLink(
    int row, 
    int column, 
    ObjectId dataLinkId, 
    [MarshalAs(UnmanagedType.U1)] bool bUpdate
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| ObjectId dataLinkId | Input the data link object |
| [MarshalAs(UnmanagedType.U1)] bool bUpdate | Input true if the data link is to be updated after setting it, false if not. |

Use Table.Cells[row,column].DataLink instead.
### SetDataType(Autodesk.AutoCAD.DatabaseServices.DataType, Autodesk.AutoCAD.DatabaseServices.UnitType, int)

#### Description
Obsolete. Sets the data type, unit type and row type of a cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetDataType(
    Autodesk.AutoCAD.DatabaseServices.DataType nDataType, 
    Autodesk.AutoCAD.DatabaseServices.UnitType nUnitType, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.DataType nDataType | Input data type to set |
| Autodesk.AutoCAD.DatabaseServices.UnitType nUnitType | Input unit type to set |
| int rowTypes | Input row type to set |

Use Table.Cells[row,column].DataType instead.
### SetDataType(int, int, Autodesk.AutoCAD.DatabaseServices.DataType, Autodesk.AutoCAD.DatabaseServices.UnitType)

#### Description
Obsolete. Sets the data type and unit type of a cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetDataType(
    int row, 
    int col, 
    Autodesk.AutoCAD.DatabaseServices.DataType nDataType, 
    Autodesk.AutoCAD.DatabaseServices.UnitType nUnitType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int col | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| Autodesk.AutoCAD.DatabaseServices.DataType nDataType | Input data type to set |
| Autodesk.AutoCAD.DatabaseServices.UnitType nUnitType | Input unit type to set |

Use Table.Cells[row,column].DataType instead.
### SetDataType(int, int, int, DataTypeParameter)

#### Description
Obsolete. Sets the data type of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetDataType(
    int row, 
    int column, 
    int contentIndex, 
    DataTypeParameter dataType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| DataTypeParameter dataType | Input data type to set |

Use Table.Cells[row,column].Contents[i].DataType instead.
### SetFieldId(int, int, int, ObjectId, Autodesk.AutoCAD.DatabaseServices.CellOption)

#### Description
Obsolete. Sets the id of the field at the specified index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetFieldId(
    int row, 
    int column, 
    int contentIndex, 
    ObjectId fieldId, 
    Autodesk.AutoCAD.DatabaseServices.CellOption option
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| ObjectId fieldId | Input field id to set |
| Autodesk.AutoCAD.DatabaseServices.CellOption option | Input one of the CellOption values. If this is InheritCellFormat then the format of the cell will be set in the field. |

Use Table.Cells[row,column].Contents[i].FieldId instead.
### SetFieldId(int, int, ObjectId)

#### Description
Obsolete. Sets the Field object ID for the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetFieldId(
    int row, 
    int col, 
    ObjectId fieldId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int col | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| ObjectId fieldId | Input field id to set |

Use Table.Cells[row,column].FieldId instead.
### SetFormat(int, int, string)

#### Description
Obsolete. For internal use. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetFormat(
    int row, 
    int col, 
    string pFormat
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object specifying the zero-based row index for the cell |
| int col | Input System.Int32 object specifying the zero-based column index for the cell |
| string pFormat | Input format string to set |

Use Table.Cells[row,column].Contents[i].FieldId instead.
### SetFormat(string, int)

#### Description
Obsolete. For internal use. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetFormat(
    string pFormat, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string pFormat | Input System.String object. |
| int rowTypes | Input System.Int32 object. |

Use Table.Cells[row,column].DataFormat instead.
### SetFormula

#### Description
Obsolete. Sets the formula at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetFormula(
    int row, 
    int column, 
    int contentIndex, 
    string formula
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| string formula | Input formula to set. |

### SetGridColor(Autodesk.AutoCAD.Colors.Color, int, int)

#### Description
Obsolete. Sets the grid color for a given grid line type and row type of the table object. Different grid line and row types can be combined. 
The possible values of the grid line type are HorzTop, HorzInside, HorzBottom, VertLeft, VertInside, and VertRight. 
The possible values of the row type are DataRow, TitleRow, and HeaderRow. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetGridColor(
    Autodesk.AutoCAD.Colors.Color color, 
    int borders, 
    int rows
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.Colors.Color color | Input color |
| int borders | Input grid line types for which to set the color |
| int rows | Input row types for which to set the color |

Use Cell functionality instead.
### SetGridColor(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType, Autodesk.AutoCAD.Colors.Color)

#### Description
Obsolete. Sets the grid color of cell, row, or column. 
To specify cell, pass a valid row and column indices. 
To specify row, pass a valid row index and pass -1 as column index. 
To specify column, pass a valid column index and pass -1 as row index. 
To set same value in multiple grid line types combine multiple grid line types using OR operator and pass it. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetGridColor(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    Autodesk.AutoCAD.Colors.Color color
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid color to set |
| Autodesk.AutoCAD.Colors.Color color | Input grid line types. Multiple grid line types can be combined using OR. |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.Color instead.
### SetGridColor(int, int, short, Autodesk.AutoCAD.Colors.Color)

#### Description
Obsolete. Sets the grid color of the specified edge of the cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetGridColor(
    int row, 
    int col, 
    short edges, 
    Autodesk.AutoCAD.Colors.Color color
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| short edges | Input specifying the edge index for the cell |
| Autodesk.AutoCAD.Colors.Color color | Input color to be used for the grid at the specified edge of the cell |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.Color instead.
### SetGridDoubleLineSpacing

#### Description
Obsolete. Sets the grid double line spacing in a cell, row, or column. 
To specify cell, pass a valid row and column indices. To specify row, pass a valid row index and pass -1 as column index. To specify column, pass a valid column index and pass -1 as row index. To set the same value in multiple grid line types combine multiple grid line types using the OR operator and pass it. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetGridDoubleLineSpacing(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    double spacing
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line types. Multiple grid line types can be combined using OR. |
| double spacing | Input grid double line spacing to set |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.DoubleLineSpacing instead.
### SetGridLineStyle

#### Description
Obsolete. Sets the grid line style in a cell, row, or column. 
To specify cell, pass a valid row and column indices. To specify row, pass a valid row index and pass -1 as column index. To specify column, pass a valid column index and pass -1 as row index. To set the same value in multiple grid line types combine multiple grid line types using the OR operator and pass it. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetGridLineStyle(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    Autodesk.AutoCAD.DatabaseServices.GridLineStyle lineStyle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line types. Multiple grid line types can be combined using OR. |
| Autodesk.AutoCAD.DatabaseServices.GridLineStyle lineStyle | Input grid line style to set |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.LineStyle instead.
### SetGridLinetype

#### Description
Obsolete. Sets the grid line type in a cell, row, or column. 
To specify cell, pass a valid row and column indices. To specify row, pass a valid row index and pass -1 as column index. To specify column, pass a valid column index and pass -1 as row index. To set the same value in multiple grid line types combine multiple grid line types using the OR operator and pass it. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetGridLinetype(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    ObjectId linetype
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line types. Multiple grid line types can be combined using OR. |
| lineStyle | Input grid line style to set |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.Linetype instead.
### SetGridLineWeight(Autodesk.AutoCAD.DatabaseServices.LineWeight, int, int)

#### Description
Obsolete. Sets the lineweight for a given grid line type and row type of the table object. Different grid line and row types can be combined. 
The possible values of the grid line type are HorzTop, HorzInside, HorzBottom, VertLeft, VertInside, and VertRight. 
The possible values of the row type are DataRow, TitleRow, and HeaderRow. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetGridLineWeight(
    Autodesk.AutoCAD.DatabaseServices.LineWeight lineWeight, 
    int borders, 
    int rows
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.LineWeight lineWeight | Input lineweight value |
| int borders | Input grid line types for which to set the lineweight |
| int rows | Input row types for which to set the lineweight |

Use Cell functionality instead.
### SetGridLineWeight(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType, Autodesk.AutoCAD.DatabaseServices.LineWeight)

#### Description
Obsolete. Sets the grid line weight in a cell, row, or column. 
To specify cell, pass a valid row and column indices. To specify row, pass a valid row index and pass -1 as column index. To specify column, pass a valid column index and pass -1 as row index. To set the same value in multiple grid line types combine multiple grid line types using the OR operator and pass it. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetGridLineWeight(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    Autodesk.AutoCAD.DatabaseServices.LineWeight lineWeight
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line types. Multiple grid line types can be combined using OR. |
| Autodesk.AutoCAD.DatabaseServices.LineWeight lineWeight | Input grid line weight to set |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.LineWeight instead.
### SetGridLineWeight(int, int, short, Autodesk.AutoCAD.DatabaseServices.LineWeight)

#### Description
Obsolete. Sets the grid lineweight of the specified edge of the cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetGridLineWeight(
    int row, 
    int col, 
    short edges, 
    Autodesk.AutoCAD.DatabaseServices.LineWeight value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| short edges | Input specifying the edge index for the cell |
| Autodesk.AutoCAD.DatabaseServices.LineWeight value | Input lineweight to be used for the grid at the specified edge of the cell |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.LineWeight instead.
### SetGridProperty(CellRange, Autodesk.AutoCAD.DatabaseServices.GridLineType, GridPropertyParameter)

#### Description
Sets the grid line properties of cells, rows, or columns in a range of cells. 
The range can be a cell range, row range, or column range to set the properties in cells, rows, or columns.
```text
public virtual void SetGridProperty(
    CellRange rangeIn, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineTypes, 
    GridPropertyParameter gridProp
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CellRange rangeIn | Input cell range, row range, or column range. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineTypes | Input grid line types. Multiple grid line types can be combined using OR. |
| GridPropertyParameter gridProp | Input grid line properties to set. |

### SetGridProperty(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType, GridPropertyParameter)

#### Description
Sets the grid line weight in a cell, row, or column. 
To specify cell, pass a valid row and column indices. To specify row, pass a valid row index and pass -1 as column index. To specify column, pass a valid column index and pass -1 as row index. To set the same value in multiple grid line types combine multiple grid line types using the OR operator and pass it. 
Before calling this function, the mnPropMask member of the structure AcGridProperty should be initialized to a value indicating which properties to set. If it is set to zero it sets all the properties.
```text
public virtual void SetGridProperty(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    GridPropertyParameter gridProperty
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line types. Multiple grid line types can be combined using OR. |
| GridPropertyParameter gridProperty | Input grid line properties to set. |

### SetGridVisibility([MarshalAs(UnmanagedType.U1)] bool, int, int)

#### Description
Obsolete. Sets the grid visibility for a given grid line type and row type of the table object. Different grid line and row types can be combined. 
The possible values of the grid line type are HorzTop, HorzInside, HorzBottom, VertLeft, VertInside, and VertRight. 
The possible values of the row type are DataRow, TitleRow, and HeaderRow. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetGridVisibility(
    [MarshalAs(UnmanagedType.U1)] bool visible, 
    int borders, 
    int rows
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool visible | Input visibility |
| int borders | Input grid line type for which to set the visibility |
| int rows | Input row type for which to set the visibility |

Use Cell functionality instead.
### SetGridVisibility(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType, Autodesk.AutoCAD.DatabaseServices.Visibility)

#### Description
Obsolete. Sets the grid visibility of cell, row, or column. 
To specify cell, pass a valid row and column indices; to specify row, pass a valid row index and pass -1 as column index. 
To specify column, pass a valid column index and pass -1 as row index. 
To set same value in multiple grid line types combine multiple grid line types using OR operator and pass it. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetGridVisibility(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    Autodesk.AutoCAD.DatabaseServices.Visibility visibility
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line types. Multiple grid line types can be combined using OR. |
| Autodesk.AutoCAD.DatabaseServices.Visibility visibility | Input grid visibility to set |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.IsVisible instead.
### SetGridVisibility(int, int, short, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Obsolete. Sets the grid visibility of the specified edge of the cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetGridVisibility(
    int row, 
    int col, 
    short edges, 
    [MarshalAs(UnmanagedType.U1)] bool value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| short edges | Input specifying the edge index for the cell |
| [MarshalAs(UnmanagedType.U1)] bool value | Input visibility to be used for the grid at the specified edge of the cell |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.Visibility instead.
### SetIsAutoScale

#### Description
Obsolete. Sets the status of the autoFit flag at the specified cell in the table. If this flag is true, the Table object automatically computes the scale and insertion point for the block content in order to fit it into the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetIsAutoScale(
    int row, 
    int column, 
    int contentIndex, 
    [MarshalAs(UnmanagedType.U1)] bool autoFit
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| [MarshalAs(UnmanagedType.U1)] bool autoFit | Input status of autofit flag |

Use Table.Cells[row,column].Contents[i].IsAutoScale instead.
### SetMargin

#### Description
Obsolete. Sets the margin of cell, row, or column. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetMargin(
    int row, 
    int column, 
    CellMargins margin, 
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| CellMargins margin | Input margin type to set. Multiple margin types can be combined using OR |
| double value | Input margin value to set |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.Margin instead.
### SetMergeAllEnabled

#### Description
Obsolete. Enables the merge-all flag in a row or column. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetMergeAllEnabled(
    int row, 
    int column, 
    [MarshalAs(UnmanagedType.U1)] bool enable
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input zero-based row index |
| int column | Input zero-based column index |
| [MarshalAs(UnmanagedType.U1)] bool enable | Input status of merge all for the cell |

Use Table.Cells[row,column].IsMergeAllEnabled instead.
### SetOverrides(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType, CellProperties)

#### Description
Obsolete. Sets the override in cell, row, or column. 
To specify cell, pass valid row and column indices. To specify row, pass a valid row index and pass -1 as column and content indices.To specify column, pass a valid column index and pass -1 as row and content indices. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetOverrides(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType, 
    CellProperties @override
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLineType | Input grid line type |
| override | Input override to set |

Use Table.Cells[row,column].{Top,Bottom,Left,Right}Edge.Overrides instead.
### SetOverrides(int, int, int, CellProperties)

#### Description
Obsolete. Sets the override in cell, row, column, or content. 
To specify content, pass valid row, column, and content indices. To specify cell, pass a valid row and column indices and pass -1 as content index. To specify row, pass a valid row index and pass -1 as column and content indices.To specify column, pass a valid column index and pass -1 as row and content indices. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetOverrides(
    int row, 
    int column, 
    int contentIndex, 
    CellProperties @override
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| int contentIndex | Input content index. This can be -1. |
| override | Input override to set |

Use Table.Cells[row,column].Contents[i].Overrides instead.
### SetRotation

#### Description
Obsolete. Sets the rotation angle of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetRotation(
    int row, 
    int column, 
    int contentIndex, 
    double angle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| double angle | Input angle in radians |

Use Table.Cells[row,column].Contents[i].Rotation instead.
### SetRowHeight(double)

#### Description
Sets a uniform row height for all the rows in the table.
```text
public virtual void SetRowHeight(
    double height
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double height | Input height to be used for the specified row |

### SetRowHeight(int, double)

#### Description
Obsolete. Sets the row height for the specified row index in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetRowHeight(
    int row, 
    double height
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input zero-based row index |
| double height | Input height to be used for the specified row |

Use Table.Rows[col].Height instead.
### SetScale

#### Description
Obsolete. Sets the scale of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetScale(
    int row, 
    int column, 
    int contentIndex, 
    double scale
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| double scale | Input angle in radians |

Use Table.Cells[row,column].Contents[i].Scale instead.
### SetSize

#### Description
Resizes the table.
```text
public virtual void SetSize(
    int numRows, 
    int numCols
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int numRows | Input number of rows |
| int numCols | Input number of columns |

### SetTextHeight(double, int)

#### Description
Obsolete. Sets the text height for the specified row types. Different row types can be OR'd. 
The possible row type values are DataRow, TitleRow, and HeaderRow. If no row type is specified, this function sets all the possible row types. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetTextHeight(
    double height, 
    int rowTypes
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double height | Input text height |
| int rowTypes | Input row types |

Use Cell functionality instead.
### SetTextHeight(int, int, double)

#### Description
Obsolete. Sets the text height for the specified table cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetTextHeight(
    int row, 
    int col, 
    double height
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| double height | Input text height |

Use Table.Cells[row,column].TextHeight instead.
### SetTextHeight(int, int, int, double)

#### Description
Obsolete. Sets the text height of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetTextHeight(
    int row, 
    int column, 
    int contentIndex, 
    double height
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| double height | Input text height |

Use Table.Cells[row,column].Contents[i].TextHeight instead.
### SetTextRotation

#### Description
Obsolete. Sets the rotation angle of the text in the specified cell. 
The possible values for rotation angle are Degrees000, Degrees090, Degrees180, and Degrees270. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetTextRotation(
    int row, 
    int col, 
    Autodesk.AutoCAD.DatabaseServices.RotationAngle rot
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| Autodesk.AutoCAD.DatabaseServices.RotationAngle rot | Input specifying the text rotation angle for the cell |

Return Values
| Return Values | Description |
| --- | --- |
| [Value](Autodesk_AutoCAD_DatabaseServices_Table_Value@int@int.md) | Description Description |

Use Table.Cells[row,column].Contents[i].Rotation instead.
### SetTextString(int, int, int, string)

#### Description
Obsolete. Sets the text for the first content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetTextString(
    int row, 
    int column, 
    int contentIndex, 
    string text
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents |
| string text | Input null-terminated text string |

Use Table.Cells[row,column].Contents[i].TextString instead.
### SetTextString(int, int, string)

#### Description
Obsolete. Sets the text as the value in the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetTextString(
    int row, 
    int col, 
    string value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| string value | Input null-terminated text string |

Use Table.Cells[row,column].TextString instead.
### SetTextStyle(int, int, ObjectId)

#### Description
Obsolete. Sets the table object to use the TextStyleTableRecord specified by id for the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetTextStyle(
    int row, 
    int col, 
    ObjectId id
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| ObjectId id | Input TextStyleTableRecord object ID |

Use Table.Cells[row,column].TextStyleId instead.
### SetTextStyle(ObjectId, int)

#### Description
Obsolete. Sets the table object to use the TextStyleTableRecord specified by id for the specified row types. Different row types can be OR'd. 
The possible row type values are DataRow, TitleRow, and HeaderRow. If no row type is specified, this function sets all the possible row types. 
**Note:** This method is deprecated and may be removed in a future release. 
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
| int rowTypes | Input row types for which to set the text style |

Use Cell functionality instead.
### SetTextStyleId

#### Description
Obsolete. Sets the text style of the content at the specified content index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetTextStyleId(
    int row, 
    int column, 
    int contentIndex, 
    ObjectId id
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| ObjectId id | Input text style |

Use Table.Cells[row,column].Contents[i].TextStyleId instead.
### SetToolTip

#### Description
Obsolete. Sets the tooltip string for cell, row, or column. 
To specify cell, pass a valid row and column indices. 
To specify row, pass a valid row index and pass -1 as column index. 
To specify column pass a valid column index and pass -1 as row index. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetToolTip(
    int row, 
    int column, 
    string toolTip
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. |
| int column | Input column index. This can be -1. |
| string toolTip | Input tool tip string to set |

Use Table.Cells[row,column].Contents[i].TextStyleId instead.
### SetValue(int, int, int, object)

#### Description
Obsolete. Sets the value of the first content. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetValue(
    int row, 
    int column, 
    int contentIndex, 
    object value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| object value | Input value to be set |

Use Table.Cells[row,column].Content[i].Value instead.
### SetValue(int, int, int, object, Autodesk.AutoCAD.DatabaseServices.ParseOption)

#### Description
Obsolete. Sets the value of the first content. 
Only the following values of ParseOption enum are valid for this function. All the other options will be ignored. 
  * ParseOptionNone: No option.
  * PreserveMtextFormat: Preserves the current MText formatting code in the text if the current value and new value are texts.

**Note:** This method is deprecated and may be removed in a future release.
```text
public virtual void SetValue(
    int row, 
    int column, 
    int contentIndex, 
    object value, 
    Autodesk.AutoCAD.DatabaseServices.ParseOption parseOption
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| object value | Input value to be set |
| Autodesk.AutoCAD.DatabaseServices.ParseOption parseOption | Input Autodesk.AutoCAD.DatabaseServices.ParseOption object; parse option |

Use Table.Cells[row,column].Content[i].SetValue instead.
### SetValue(int, int, int, string, Autodesk.AutoCAD.DatabaseServices.ParseOption)

#### Description
Obsolete. Sets the value of the first content. 
Only the following values of ParseOption enum are valid for this function. All the other options will be ignored. 
  * ParseOptionNone: No option.
  * PreserveMtextFormat: Preserves the current MText formatting code in the text if the current value and new value are texts.

**Note:** This method is deprecated and may be removed in a future release.
```text
public virtual void SetValue(
    int row, 
    int column, 
    int contentIndex, 
    string value, 
    Autodesk.AutoCAD.DatabaseServices.ParseOption parseOption
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int contentIndex | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| string value | Input value to set |
| Autodesk.AutoCAD.DatabaseServices.ParseOption parseOption | Input Autodesk.AutoCAD.DatabaseServices.ParseOption object; parse option |

Use Table.Cells[row,column].Content[i].SetValue instead.
### SetValue(int, int, object)

#### Description
Obsolete. Sets the value of the first content of a cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetValue(
    int row, 
    int col, 
    object pValue
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| object pValue | Input value to set |

Use Table.Cells[row,column].Contents(i).Value instead
### SetValue(int, int, string, Autodesk.AutoCAD.DatabaseServices.ParseOption)

#### Description
Obsolete. Parses the specified text, converts it to a value of appropriate data type and sets it in the cell. 
If nOption is set to AcValue.ParseOptionNone it does default parsing. If it is AcValue.SetDefaultFormat it sets a default format appropriate for the data type, in the value. If it is AcValue.PreserveMtextFormat it uses the MText format code in the passed text if it is present. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void SetValue(
    int row, 
    int col, 
    string pText, 
    Autodesk.AutoCAD.DatabaseServices.ParseOption nOption
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int col | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| string pText | Input text to convert to value and set |
| Autodesk.AutoCAD.DatabaseServices.ParseOption nOption | Input parse option. |

Use Table.Cells[row,column].Contents(i).Value instead.
### SuppressRegenerateTable

#### Description
This method allows the user to temporarily disable the regeneration of the table object during changes in one or more of its properties.
Warning
This method is provided for VBA applications to temporarily disable the regenerating of the table object. It is not intended for use in ObjectARX applications. Calling this function with suppress set to true disables regenerating the table object. The table object is recomputed when this function is called with suppress set to false. Before saving the table object to the drawing file, the user should either call this function with false value or call RecomputeTableBlock(true). Otherwise, the table object will never be displayed.
```text
public virtual void SuppressRegenerateTable(
    [MarshalAs(UnmanagedType.U1)] bool suppress
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool suppress | Input boolean value to suppress or enable the regeneration of a table object |

### TableStyleOverrides

#### Description
Obsolete. Returns the table style overrides. Table.TableStyleOverrides defines the values for table style overrides. 
Returns true if successful, false otherwise. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual TableStyleOverride\[\] TableStyleOverrides();
```

Use Cell functionality instead.
### TextHeight(Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
Obsolete. Returns the text height for a given row type of the table object. 
The possible row type values are DataRow, TitleRow, and HeaderRow. If no row type is specified, the default of DataRow is used. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double TextHeight(
    Autodesk.AutoCAD.DatabaseServices.RowType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType type | Input the row type for which the text height is returned |

Use Cell functionality instead.
### TextHeight(int, int)

#### Description
Obsolete. Returns the text height of the specified table cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual double TextHeight(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input the zero-based row index for the cell |
| int col | Input the zero-based column index for the cell |

Use Table.Cells[row,column].TextHeight instead.
### TextRotation

#### Description
Obsolete. Returns the rotation angle of the text in the specified cell. 
The possible values for rotation angle are Degrees000, Degrees090, Degrees180, and Degrees270. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.RotationAngle TextRotation(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input the zero-based row index for the cell |
| int col | Input the zero-based column index for the cell |

Use Table.Cells[row,column].Contents[i].Rotation instead.
### TextString(int, int)

#### Description
Obsolete. Returns a copy of the null-terminated text string in the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string TextString(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input the zero-based row index for the cell |
| int col | Input the zero-based column index for the cell |

Use Table.Cells[row,column].TextString instead.
### TextString(int, int, Autodesk.AutoCAD.DatabaseServices.FormatOption)

#### Description
Obsolete. Returns the formatted text string of the content. 
This function gets the value of the object as a string in a specific format. It uses the format string stored in the object to format the string. nOption specifies optional flags to control the formatting. The flags are described below: 
  * FormatOptionNone: Does default formatting. The formatted string can be used for display.
  * ForEditing: Formats the value in such a way that it can be used in editing. It formats the value using maximum precision even if the format set in the value has an explicit precision.
  * ForExpression: Formats the value in such a way that it can be used in expression. It formats the value using maximum precision even if the format set in the value has an explicit precision.
  * UseMaximumPrecision: Uses maximum precision for the value.
  * IgnoreMtextFormat: Mtext formatting code is not included in the formatted text.

**Note:** This method is deprecated and may be removed in a future release.
```text
public virtual string TextString(
    int row, 
    int col, 
    Autodesk.AutoCAD.DatabaseServices.FormatOption nOption
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input specifying the zero-based row index for the cell |
| int col | Input specifying the zero-based column index for the cell |
| Autodesk.AutoCAD.DatabaseServices.FormatOption nOption | Input format option |

Use Table.Cells[row,column].TextString instead.
### TextStringConst

#### Description
Obsolete. Returns a copy of the null-terminated text string in the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual string TextStringConst(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input the zero-based row index for the cell |
| int col | Input the zero-based column index for the cell |

Use Table.Cells[row,column].TextString instead.
### TextStyle(Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
Obsolete. Returns the object ID of the text style for a given row type currently referenced by the table object. 
The possible row type values are DataRow, TitleRow, and HeaderRow. If no row type is specified, the default of DataRow is used. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual ObjectId TextStyle(
    Autodesk.AutoCAD.DatabaseServices.RowType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType type | Input row type |

Use Cell functionality instead.
### TextStyle(int, int)

#### Description
Obsolete. Returns the object ID of the text style of the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual ObjectId TextStyle(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input the zero-based row index for the cell |
| int col | Input the zero-based column index for the cell |

Use Table.Cells[row,column].TextStyleId instead.
### UnitType(Autodesk.AutoCAD.DatabaseServices.RowType)

#### Description
Obsolete. Returns the object ID of the unit type for a given row type currently referenced by the table object. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.UnitType UnitType(
    Autodesk.AutoCAD.DatabaseServices.RowType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.RowType type | Input unit type |

Use Table.Cells[row,column].DataType instead.
### UnitType(int, int)

#### Description
Obsolete. Returns the object ID of the unit type of the specified cell. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual Autodesk.AutoCAD.DatabaseServices.UnitType UnitType(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input the zero-based row index for the cell |
| int col | Input the zero-based column index for the cell |

Use Table.Cells[row,column].DataType instead.
### UnmergeCells

#### Description
This function unmerges a cells within a specified range.
```text
public virtual void UnmergeCells(
    CellRange range
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CellRange range | Input the cell range |

### UpdateDataLink(Autodesk.AutoCAD.DatabaseServices.UpdateDirection, Autodesk.AutoCAD.DatabaseServices.UpdateOption)

#### Description
Updates all the data links in the table. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual void UpdateDataLink(
    Autodesk.AutoCAD.DatabaseServices.UpdateDirection dir, 
    Autodesk.AutoCAD.DatabaseServices.UpdateOption option
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.UpdateDirection dir | Input direction to update |
| Autodesk.AutoCAD.DatabaseServices.UpdateOption option | Input options to update |

### UpdateDataLink(int, int, Autodesk.AutoCAD.DatabaseServices.UpdateDirection, Autodesk.AutoCAD.DatabaseServices.UpdateOption)

#### Description
Updates the data link at the specified cell.
```text
public virtual void UpdateDataLink(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.UpdateDirection dir, 
    Autodesk.AutoCAD.DatabaseServices.UpdateOption option
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| Autodesk.AutoCAD.DatabaseServices.UpdateDirection dir | Input direction of update |
| Autodesk.AutoCAD.DatabaseServices.UpdateOption option | Input options to update |

### Value

#### Description
Obsolete. Returns the content type of the content. 
**Note:** This method is deprecated and may be removed in a future release. 
```text
public virtual object Value(
    int row, 
    int col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int col | Input column index. It should be more than or equal to 0 and less than the number of columns. |

Use Table.Cells[row,column].Contents(i).Value instead.
### BreakEnabled

#### Description
Returns true if break feature is enabled in the cell.
```text
public bool BreakEnabled;
```

#### Conditions
Read / Write
### BreakFlowDirection

#### Description
Returns the table break flow direction of the table. The break flow direction determines the positioning of the tables when the table break is enabled.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.TableBreakFlowDirection BreakFlowDirection;
```

#### Conditions
Read / Write
### BreakOptions

#### Description
Returns the table break option.
```text
public virtual TableBreakOptions BreakOptions;
```

#### Conditions
Read / Write
### Cells

#### Description
Returns the cells of the table.
```text
public CellRange Cells;
```

#### Conditions
Read-only
### Columns

#### Description
Returns a collection of the columns in the table.
```text
public ColumnsCollection Columns;
```

#### Conditions
Read-only
### Direction

#### Description
Returns the unit horizontal direction vector for the table in WCS coordinates.
```text
public virtual Vector3d Direction;
```

#### Conditions
Read / Write
### FlowDirection

#### Description
Returns the direction that the table follows from its start to its finish. 
Possible values for FlowDirection are TtoB (top to bottom) and BtoT (bottom to top).
```text
public virtual Autodesk.AutoCAD.DatabaseServices.FlowDirection FlowDirection;
```

#### Conditions
Read / Write
### HasSubSelection

#### Description
Returns true if the table has a subselection set. Otherwise, returns false.
```text
public virtual bool HasSubSelection;
```

#### Conditions
Read-only
### Height

#### Description
Returns the total height of the table.
```text
public virtual double Height;
```

#### Conditions
Read / Write
### HorizontalCellMargin

#### Description
Obsolete. Returns the horizontal cell margin for the table.
```text
public virtual double HorizontalCellMargin;
```

#### Conditions
Read / Write
Table.Cells[row, column].HorizontalLine.Margin
### IsHeaderSuppressed

#### Description
Obsolete. Returns true if the header row of the table is suppressed, or false if it is not.
```text
public virtual bool IsHeaderSuppressed;
```

#### Conditions
Read / Write
Use Cell functionality instead.
### IsTitleSuppressed

#### Description
Obsolete. Returns true if the title row of the table is suppressed, or false if it is not.
```text
public virtual bool IsTitleSuppressed;
```

#### Conditions
Read / Write
Use Cell functionality instead.
### MinimumTableHeight

#### Description
Returns the minimum total height for the table.
```text
public virtual double MinimumTableHeight;
```

#### Conditions
Read-only
### MinimumTableWidth

#### Description
Returns the minimum total width for the table.
```text
public virtual double MinimumTableWidth;
```

#### Conditions
Read-only
### NumColumns

#### Description
Obsolete. Returns a non-negative integer representing the number of columns in the table.
```text
public virtual int NumColumns;
```

#### Conditions
Read / Write
Use Table.Columns.Count and Table.SetSize(int numRows, int numCols) instead.
### NumRows

#### Description
Obsolete. Returns a non-negative integer representing the number of rows in the table.
```text
public virtual int NumRows;
```

#### Conditions
Read / Write
Use Table.Rows.Count and Table.SetSize(int numRows, int numCols) instead.
### Rows

#### Description
Returns a collection of the rows in the table.
```text
public RowsCollection Rows;
```

#### Conditions
Read-only
### SubSelection

#### Description
Returns range of cells in the subselection set. Returns invalid range if there are no subselection cells.
```text
public virtual CellRange SubSelection;
```

#### Conditions
Read / Write
### TableStyle

#### Description
Returns the object ID of the TableStyle referenced by the table object.
```text
public virtual ObjectId TableStyle;
```

#### Conditions
Read / Write
### TableStyleName

#### Description
Returns the name of the table style.
```text
public string TableStyleName;
```

#### Conditions
Read-only
### VerticalCellMargin

#### Description
Obsolete. Returns the vertical cell margin for the table.
```text
public virtual double VerticalCellMargin;
```

#### Conditions
Read / Write
Use Table.Cells[row, column].VerticalLine.Margin instead.
### Width

#### Description
Returns the total width for the table.
```text
public virtual double Width;
```

#### Conditions
Read / Write