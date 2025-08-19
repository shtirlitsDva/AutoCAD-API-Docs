# LinkedTableData Class

## Overview

#### Description
This .NET class wraps the AcDbLinkedTableData ObjectARX class. 
This class is used to store and manage data in a tabular structure. Though this class is similar to a database table it differs in one respect: all the cells in a column need not be of the same data type. In addition, the cells in this table can contain multiple contents, and the contents can be a value of any supported data type, field, or block. This table stores and manages only data without any format information.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.LinkedData
        Autodesk.AutoCAD.DatabaseServices.LinkedTableData
            Autodesk.AutoCAD.DatabaseServices.FormattedTableData
```

```text
public class LinkedTableData : LinkedData;
```

### Constructors

- [LinkedTableData](#linkedtabledata)

### Methods

- [AppendColumn](#appendcolumn)
- [AppendRow](#appendrow)
- [DataType](#datatype)
- [DeleteColumn](#deletecolumn)
- [DeleteContent](#deletecontent)
- [DeleteRow](#deleterow)
- [GetBlockAttributeValue](#getblockattributevalue)
- [GetBlockTableRecordId](#getblocktablerecordid)
- [GetCellState](#getcellstate)
- [GetColumnName](#getcolumnname)
- [GetContentTypes](#getcontenttypes)
- [GetCustomData](#getcustomdata)
- [GetDataFormat](#getdataformat)
- [GetDataLink()](#getdatalink())
- [GetDataLink(CellRange)](#getdatalink(cellrange))
- [GetDataLink(int, int)](#getdatalink(int,-int))
- [GetEnumerator()](#getenumerator())
- [GetEnumerator(TableEnumeratorOption)](#getenumerator(tableenumeratoroption))
- [GetFieldId](#getfieldid)
- [GetToolTip](#gettooltip)
- [GetValue(int, int)](#getvalue(int,-int))
- [GetValue(int, int, int, Autodesk.AutoCAD.DatabaseServices.FormatOption)](#getvalue(int,-int,-int,-autodesk.autocad.databaseservices.formatoption))
- [InsertColumn](#insertcolumn)
- [InsertRow](#insertrow)
- [IsContentEditable](#iscontenteditable)
- [IsLinked](#islinked)
- [SetBlockAttributeValue](#setblockattributevalue)
- [SetBlockTableRecordId](#setblocktablerecordid)
- [SetCellState](#setcellstate)
- [SetColumnName](#setcolumnname)
- [SetCustomData](#setcustomdata)
- [SetDataFormat](#setdataformat)
- [SetDataLink(CellRange, ObjectId, [MarshalAs(UnmanagedType.U1)] bool)](#setdatalink(cellrange,-objectid,-[marshalas(unmanagedtype.u1)]-bool))
- [SetDataLink(int, int, ObjectId, [MarshalAs(UnmanagedType.U1)] bool)](#setdatalink(int,-int,-objectid,-[marshalas(unmanagedtype.u1)]-bool))
- [SetDataType](#setdatatype)
- [SetFieldId](#setfieldid)
- [SetSize](#setsize)
- [SetToolTip](#settooltip)
- [SetValue(int, int, int, object, Autodesk.AutoCAD.DatabaseServices.ParseOption)](#setvalue(int,-int,-int,-object,-autodesk.autocad.databaseservices.parseoption))
- [SetValue(int, int, object)](#setvalue(int,-int,-object))
- [UnitType](#unittype)
- [UpdateDataLink(Autodesk.AutoCAD.DatabaseServices.UpdateDirection, Autodesk.AutoCAD.DatabaseServices.UpdateOption)](#updatedatalink(autodesk.autocad.databaseservices.updatedirection,-autodesk.autocad.databaseservices.updateoption))
- [UpdateDataLink(int, int, Autodesk.AutoCAD.DatabaseServices.UpdateDirection, Autodesk.AutoCAD.DatabaseServices.UpdateOption)](#updatedatalink(int,-int,-autodesk.autocad.databaseservices.updatedirection,-autodesk.autocad.databaseservices.updateoption))

### Properties

- [NumberOfColumns](#numberofcolumns)
- [NumberOfRows](#numberofrows)


## Constructors Details

### LinkedTableData

#### Description
Constructor.
```text
public LinkedTableData();
```

### AppendColumn

#### Description
Appends one or more columns. Returns the starting index of the appended columns.
```text
public virtual int AppendColumn(
    int columnsNumber
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int columnsNumber | Input number of columns to append |

### AppendRow

#### Description
Appends one or more rows. Returns the starting index of the appended row.
```text
public virtual int AppendRow(
    int rowsNumber
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int rowsNumber | Input number of rows to append |

### DataType

#### Description
Gets the data type of the first content.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.DataType DataType(
    int row, 
    int column
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### DeleteColumn

#### Description
Deletes one or more columns
```text
public virtual void DeleteColumn(
    int index, 
    int columnsNumberToDelete
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input starting index of the columns to delete |
| int columnsNumberToDelete | Input number of columns to delete |

### DeleteContent

#### Description
Deletes all the contents in a cell.
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

### DeleteRow

#### Description
Deletes one or more rows.
```text
public virtual void DeleteRow(
    int index, 
    int rowsNumberToDelete
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input starting index of the rows to delete |
| int rowsNumberToDelete | Input number of rows to delete |

### GetBlockAttributeValue

#### Description
Gets the block attribute value if the first content is a block with attributes.
```text
public virtual string GetBlockAttributeValue(
    int row, 
    int column, 
    ObjectId attributeDefinitionId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| ObjectId attributeDefinitionId | Input object ID of the AttributeDefinition object |

### GetBlockTableRecordId

#### Description
Returns the id of the block table record if the first content is a block; returns null id if the first content is not a block.
```text
public virtual ObjectId GetBlockTableRecordId(
    int row, 
    int column
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### GetCellState

#### Description
Gets the cell state of the first content.
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

### GetColumnName

#### Description
This function gets the name of the column at the specified column index.
```text
public virtual string GetColumnName(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input column index |

### GetContentTypes

#### Description
Gets the content type of the first content.
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

### GetCustomData

#### Description
Gets the custom data value set in cell, row, or column as key-value pairs. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
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
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| string key | Input key to retrieve the custom data |

### GetDataFormat

#### Description
Gets the data format at the specified content index.
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

### GetDataLink()

#### Description
Returns a collection of all the data links.
```text
public virtual ObjectIdCollection GetDataLink();
```

### GetDataLink(CellRange)

#### Description
Gets the datalinks set in the specified range.
```text
public virtual ObjectIdCollection GetDataLink(
    CellRange range
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| CellRange range | Input range to get the data links. If this is NULL it gets all the data links in the table |

### GetDataLink(int, int)

#### Description
Gets the id of the data link if the specified cell is linked to a data source using a data link. Returns null id if the cell is not linked using a data link. 
This function may be called on any of the cells in a linked range.
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

### GetEnumerator()

#### Description
Returns an enumerator object for this collection.
```text
public TableEnumerator GetEnumerator();
```

### GetEnumerator(TableEnumeratorOption)

#### Description
Returns an enumerator iterator.
```text
public TableEnumerator GetEnumerator(
    TableEnumeratorOption option
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| TableEnumeratorOption option | Input iterator option. |

### GetFieldId

#### Description
Returns the id of the field if the first content is a field; returns null id if there is no field.
```text
public virtual ObjectId GetFieldId(
    int row, 
    int column
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### GetToolTip

#### Description
Gets the tooltip string for cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
```text
public virtual string GetToolTip(
    int row, 
    int column
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |

### GetValue(int, int)

#### Description
Gets the value of the first content.
```text
public virtual object GetValue(
    int row, 
    int column
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### GetValue(int, int, int, Autodesk.AutoCAD.DatabaseServices.FormatOption)

#### Description
Gets the value of the content at the specified content index. 
Only the following values of FormatOption enum are valid for this function. All the other values will be ignored. 
FormatOptionNone: Gets the original value 
IgnoreMtextFormat: If the value is text strips out the Mtext formatting code from the text. If the value is not text this option is ignored. 
```text
public virtual object GetValue(
    int row, 
    int column, 
    int content, 
    Autodesk.AutoCAD.DatabaseServices.FormatOption formatOption
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int content | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| Autodesk.AutoCAD.DatabaseServices.FormatOption formatOption | Input format option for formatting the cell value. See Remarks for description of each option. |

### InsertColumn

#### Description
Inserts one or more columns at the specified index. 
Returns the starting index of the inserted columns.
```text
public virtual int InsertColumn(
    int index, 
    int columnsNumber
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index at which to insert the new columns |
| int columnsNumber | Input number of columns to insert |

### InsertRow

#### Description
Inserts one or more rows at the specified index. 
Returns the starting index of the inserted rows.
```text
public virtual int InsertRow(
    int index, 
    int rowsNumber
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index at which to insert the new rows. |
| int rowsNumber | Input number of rows to insert |

### IsContentEditable

#### Description
Checks if the content of the specified cell can be modified. 
This function checks the cell state to determine if a cell content can be modified. For example content locked and read-only cells cannot be modified. Applications should use this function to determine if a cell is editable instead of calling cellState directly and checking the state since the semantics of an editable cell may change as new states are added. 
Returns true if the content can be modified and false if not.
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

### IsLinked

#### Description
Checks if a cell is linked to a data source. 
Returns true if the cell is linked and false if not.
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

### SetBlockAttributeValue

#### Description
Sets the block attribute value if the first content is a block with attributes.
```text
public virtual void SetBlockAttributeValue(
    int row, 
    int column, 
    ObjectId attributeDefinitionId, 
    string value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| ObjectId attributeDefinitionId | Input object ID of the AttributeDefinition object |
| string value | Input attribute value to set |

### SetBlockTableRecordId

#### Description
Sets the id of the block table record as the content at the specified content index.
```text
public virtual void SetBlockTableRecordId(
    int row, 
    int column, 
    ObjectId value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| ObjectId value | Input attribute value to set |

### SetCellState

#### Description
Sets the cell state. 
This function will ignore internal cell states like CellStateLinked which cannot be changed.
```text
public virtual void SetCellState(
    int row, 
    int column, 
    CellStates value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| CellStates value | Cell state to set. This will replace all the bits of the current state. |

### SetColumnName

#### Description
Gets the columns name. 
Column name is optional; it can be blank.
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

### SetCustomData

#### Description
Sets the custom data value set in cell, row, or column as key-value pairs. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
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
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| string key | Input key to use for the custom data |
| object value | Input custom data to set. This can be NULL. If it is NULL it deletes the custom data. |

### SetDataFormat

#### Description
Sets the data format of the first content.
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
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| string format | Input data format to set |

### SetDataLink(CellRange, ObjectId, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Sets the specified data link in a cell range. 
The current contents of the cells in the specified range will be deleted. If the top-left cell of the specified range is top-left cell of an existing linked range this will overwrite the current data link. If the range overlaps any other cells in any linked range the function will fail. This function does not automatically update the data. Call UpdateDataLink to update the data.
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
| CellRange range | Range of cells to link to external source. |
| ObjectId dataLinkId | Id of the data link to set |
| [MarshalAs(UnmanagedType.U1)] bool bUpdate | Input true if the data link has is to be updated after setting it, false if not |

### SetDataLink(int, int, ObjectId, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Sets the specified data link in a cell. 
If the specified cell is top-left cell of an existing linked range this will overwrite the current data link. If it is any other cell in a linked range the function will fail. This function does not automatically update the data. Call UpdateDataLink to update the data.
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
| ObjectId dataLinkId | Input id of the data link to set |
| [MarshalAs(UnmanagedType.U1)] bool bUpdate | Input true if the data link is to be updated after setting it, false if not. |

### SetDataType

#### Description
Sets the data type and unit type of the first content.
```text
public virtual void SetDataType(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.DataType dataType, 
    Autodesk.AutoCAD.DatabaseServices.UnitType unitType
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| Autodesk.AutoCAD.DatabaseServices.DataType dataType | Input data type to set |
| Autodesk.AutoCAD.DatabaseServices.UnitType unitType | Input unit type to set |

### SetFieldId

#### Description
Sets the id of the field as the first content.
```text
public virtual void SetFieldId(
    int row, 
    int column, 
    ObjectId value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| ObjectId value | Input field id to set |

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
| int numRows | Input new row size. |
| int numCols | Input new column size. |

### SetToolTip

#### Description
Sets the tooltip string for cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
```text
public virtual void SetToolTip(
    int row, 
    int column, 
    string value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| string value | Input tool tip string to set |

### SetValue(int, int, int, object, Autodesk.AutoCAD.DatabaseServices.ParseOption)

#### Description
Sets the value of the content at the specified content index 
Only the following values of ParseOption enum are valid for this function. All the other options will be ignored. 
ParseOptionNone: No option 
PreserveMtextFormat: Preserves the current MText formatting code in the text if the current value and new value are texts. 
```text
public virtual void SetValue(
    int row, 
    int column, 
    int content, 
    object value, 
    Autodesk.AutoCAD.DatabaseServices.ParseOption parseOption
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| int content | Input content index. It should be more than or equal to 0 and less than the number of contents. |
| object value | Input value to set. |
| Autodesk.AutoCAD.DatabaseServices.ParseOption parseOption | Input parse option. See remarks. |

### SetValue(int, int, object)

#### Description
Sets the value of the first content.
```text
public virtual void SetValue(
    int row, 
    int column, 
    object value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| object value | Input value to set |

### UnitType

#### Description
Gets the unit type of the first content.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.UnitType UnitType(
    int row, 
    int column
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### UpdateDataLink(Autodesk.AutoCAD.DatabaseServices.UpdateDirection, Autodesk.AutoCAD.DatabaseServices.UpdateOption)

#### Description
Updates all the data links in the table
```text
public virtual void UpdateDataLink(
    Autodesk.AutoCAD.DatabaseServices.UpdateDirection dir, 
    Autodesk.AutoCAD.DatabaseServices.UpdateOption option
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.UpdateDirection dir | Input direction of update |
| Autodesk.AutoCAD.DatabaseServices.UpdateOption option | Input option flag |

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
| Autodesk.AutoCAD.DatabaseServices.UpdateOption option | Input option flag |

### NumberOfColumns

#### Description
Accesses the number of columns.
```text
public virtual int NumberOfColumns;
```

#### Conditions
Read-only
### NumberOfRows

#### Description
Accesses the number of rows.
```text
public virtual int NumberOfRows;
```

#### Conditions
Read-only