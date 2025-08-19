# DataTable Class

## Overview

#### Description
This .NET class wraps the AcDbDataTable ObjectARX class. 
The DataTable class provides a general-purpose repository for simple numeric, character, 3D point, or object ID information arranged in a two-dimensional table. It relies on two component classes: DataCell and DataColumn. A row of data is represented by an DataCellArray.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.DataTable
```

```text
public class DataTable : DBObject;
```

### Constructors

- [DataTable](#datatable)

### Methods

- [AppendColumn](#appendcolumn)
- [AppendRow](#appendrow)
- [Assign](#assign)
- [GetCellAt](#getcellat)
- [GetColumnAt](#getcolumnat)
- [GetColumnIndexAtName](#getcolumnindexatname)
- [GetColumnNameAt](#getcolumnnameat)
- [GetColumnTypeAt](#getcolumntypeat)
- [GetRowAt](#getrowat)
- [InsertColumnAt](#insertcolumnat)
- [InsertRowAt](#insertrowat)
- [RemoveColumnAt](#removecolumnat)
- [RemoveRowAt](#removerowat)
- [SetCellAt](#setcellat)
- [SetRowAt](#setrowat)

### Other

- [AutoCAD.DatabaseServices.DataTable.AppendColumn@Autodesk.AutoCAD.DatabaseServices.CellType@string](#autocad.databaseservices.datatable.appendcolumn@autodesk.autocad.databaseservices.celltype@string)
- [AutoCAD.DatabaseServices.DataTable.InsertColumnAt@int@Autodesk.AutoCAD.DatabaseServices.CellType@string](#autocad.databaseservices.datatable.insertcolumnat@int@autodesk.autocad.databaseservices.celltype@string)

### Properties

- [NumColsGrowSize](#numcolsgrowsize)
- [NumColsPhysicalSize](#numcolsphysicalsize)
- [NumColumns](#numcolumns)
- [NumRows](#numrows)
- [NumRowsGrowSize](#numrowsgrowsize)
- [NumRowsPhysicalSize](#numrowsphysicalsize)
- [TableName](#tablename)


## Constructors Details

### DataTable

#### Description
Default constructor.
```text
public DataTable();
```

### AppendColumn

#### Description
This is AppendColumn, a member of class DataTable.
```text
public virtual void AppendColumn(
    Autodesk.AutoCAD.DatabaseService.CellType type, 
    string columnName
);
```

### AppendRow

#### Description
This method appends a row to the end of the table. 
Set the validate parameter to true if the type of each cell in the new row should be validated against the type of each corresponding column and if the number of columns in the row should be validated with regard to the number of columns in the table.
```text
public virtual void AppendRow(
    DataCellCollection row, 
    [MarshalAs(UnmanagedType.U1)] bool validate
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DataCellCollection row | Row being added |
| [MarshalAs(UnmanagedType.U1)] bool validate | Validation flag |

### Assign

#### Description
Assigns a new table to this object.
```text
public void Assign(
    DataTable other
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DataTable other | New table to assign. |

### GetCellAt

#### Description
This function gets the cell at the specified row and column indexes.
```text
public virtual DataCell GetCellAt(
    int row, 
    int col
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Row index of cell to access |
| int col | Column index of cell to access |

### GetColumnAt

#### Description
This function gets the column at the specified column index.
```text
public virtual DataColumn GetColumnAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Index of column |

### GetColumnIndexAtName

#### Description
This function gets the index of the column with the specified column name.
```text
public virtual int GetColumnIndexAtName(
    string name
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Name of column |

### GetColumnNameAt

#### Description
This function gets the name of the column at the specified column index.
```text
public virtual string GetColumnNameAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Column index |

### GetColumnTypeAt

#### Description
This function gets the type of the column at the specified column index.
```text
public virtual Autodesk.AutoCAD.DatabaseService.CellType GetColumnTypeAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Column index |

### GetRowAt

#### Description
This function gets the row of data at the specified row index.
```text
public virtual DataCellCollection GetRowAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Row index |

### InsertColumnAt

#### Description
This is InsertColumnAt, a member of class DataTable.
```text
public virtual void InsertColumnAt(
    int index, 
    Autodesk.AutoCAD.DatabaseService.CellType type, 
    string columnName
);
```

### InsertRowAt

#### Description
This function inserts a row of data into the table immediately before the row at the specified index.
```text
public virtual void InsertRowAt(
    int index, 
    DataCellCollection row, 
    [MarshalAs(UnmanagedType.U1)] bool validate
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Row index of position at which to insert the row |
| DataCellCollection row | Row of data to insert |
| [MarshalAs(UnmanagedType.U1)] bool validate | Validation flag |

### RemoveColumnAt

#### Description
This function removes the specified column from the table.
```text
public virtual void RemoveColumnAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Index of column to remove |

### RemoveRowAt

#### Description
This function removes the specified row from the table.
```text
public virtual void RemoveRowAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Index of row to remove |

### SetCellAt

#### Description
This function replaces the cell in the table at the specified row and column with the specified cell.
```text
public virtual void SetCellAt(
    int row, 
    int col, 
    DataCell cell
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int row | Row index of the cell to be replaced |
| int col | Column index of the cell to be replaced |
| DataCell cell | New cell |

### SetRowAt

#### Description
This function replaces the row at the specified index . 
Set the validate parameter to true if the type of each cell in the new row should be validated against the type of each corresponding column and if the number of columns in the row should be validated with regard to the number of columns in the table.
```text
public virtual void SetRowAt(
    int index, 
    DataCellCollection row, 
    [MarshalAs(UnmanagedType.U1)] bool validate
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Row index of the row to be replaced |
| DataCellCollection row | New row of data |
| [MarshalAs(UnmanagedType.U1)] bool validate | Validation flag |

### AutoCAD.DatabaseServices.DataTable.AppendColumn@Autodesk.AutoCAD.DatabaseServices.CellType@string

#### Parameters
| Parameters | Description |
| --- | --- |
| type | Type of the column being added |
| columnName | Name of the column |

#### Description
This function creates a new column and adds it as the last column of the table. If the table already has rows in it, the new column is created with a cell for each row that has a default value.

### AutoCAD.DatabaseServices.DataTable.InsertColumnAt@int@Autodesk.AutoCAD.DatabaseServices.CellType@string

#### Parameters
| Parameters | Description |
| --- | --- |
| index | Column index at which to insert the new column |
| type | Type of new column |
| columnName | Name of new column |

#### Description
This function creates a new column and inserts it into the table at the specified column index. If the table already has rows in it, the new column is created with a cell for each row that has a default value.


## Properties Details

### NumColsGrowSize

#### Description
Accesses the grow size for the number of physical columns of a table.
```text
public virtual int NumColsGrowSize;
```

#### Conditions
Read / Write
### NumColsPhysicalSize

#### Description
Accesses the number of columns allocated for the table.
```text
public virtual int NumColsPhysicalSize;
```

#### Conditions
Read / Write
### NumColumns

#### Description
Accesses the number of columns in the table.
```text
public virtual int NumColumns;
```

#### Conditions
Read-only
### NumRows

#### Description
Accesses the number of rows in the table.
```text
public virtual int NumRows;
```

#### Conditions
Read-only
### NumRowsGrowSize

#### Description
Accesses the grow size for the number of physical rows of a table.
```text
public virtual int NumRowsGrowSize;
```

#### Conditions
Read / Write
### NumRowsPhysicalSize

#### Description
Accesses the number of rows allocated for the physical size of the table.
```text
public virtual int NumRowsPhysicalSize;
```

#### Conditions
Read / Write
### TableName

#### Description
Accesses the table name.
```text
public virtual string TableName;
```

#### Conditions
Read / Write