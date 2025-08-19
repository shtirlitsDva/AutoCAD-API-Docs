# DataColumn Class

## Overview

#### Description
This .NET class wraps the AcDbDataColumn ObjectARX class. It represents a single column of a DataTable.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DataColumn
```

```text
public class DataColumn : RXObject;
```

### Constructors

- [DataColumn()](#datacolumn())
- [DataColumn(DataColumn)](#datacolumn(datacolumn))

### Methods

- [AppendCell](#appendcell)
- [Assign](#assign)
- [GetCellAt](#getcellat)
- [GetIndexAtCell](#getindexatcell)
- [InsertCellAt](#insertcellat)
- [RemoveCellAt](#removecellat)
- [SetCellAt](#setcellat)

### Properties

- [ColumnName](#columnname)
- [ColumnType](#columntype)
- [GrowLength](#growlength)
- [NumCells](#numcells)
- [PhysicalLength](#physicallength)


## Constructors Details

### DataColumn()

#### Description
Default constructor.
```text
public DataColumn();
public DataColumn(
    Autodesk.AutoCAD.DatabaseService.CellType type, 
    string columnName
);
```

### DataColumn(DataColumn)

#### Description
Sets the column to a standard format.
```text
public DataColumn(
    DataColumn column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DataColumn column | Set the column to a specific type |

### AppendCell

#### Description
This function appends the specified cell to the end of the column.
```text
public virtual void AppendCell(
    DataCell cell
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DataCell cell | New cell to add |

### Assign

#### Description
Assigns a new column to this object.
```text
public void Assign(
    DataColumn col
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DataColumn col | New column to add |

### GetCellAt

#### Description
This function retrieves the cell at the position in this column specified by index.
```text
public virtual DataCell GetCellAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Index of cell to retrieve |

### GetIndexAtCell

#### Description
This function searches the column for the first cell with a value that matches cell. It returns the index of the first cell found in the column with the value of cell.
```text
public virtual int GetIndexAtCell(
    DataCell cell
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DataCell cell | Input cell to be matched |

### InsertCellAt

#### Description
This function inserts the cell into the column at the specified index. If index is greater than or equal to the number of cells in the column, it calls the appendCell() function.
```text
public virtual void InsertCellAt(
    int index, 
    DataCell cell
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Position at which to insert the cell |
| DataCell cell | Cell to insert |

### RemoveCellAt

#### Description
This function removes the cell at the specified index. The index must be less than the number of cells in the column.
```text
public virtual void RemoveCellAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Index of cell to remove from the column |

### SetCellAt

#### Description
This function sets the cell at the specified index. The index must be less than the number of cells in the column.
```text
public virtual void SetCellAt(
    int index, 
    DataCell cell
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Index of the cell to be updated |
| DataCell cell | Cell to set |

### ColumnName

#### Description
Accesses the name of the column.
```text
public virtual string ColumnName;
```

#### Conditions
Read / Write
### ColumnType

#### Description
Accesses the type of the column
```text
public virtual Autodesk.AutoCAD.DatabaseService.CellType ColumnType;
```

#### Conditions
Read / Write
### GrowLength

#### Description
Accesses the grow length of the column
```text
public virtual int GrowLength;
```

#### Conditions
Read-only 
Read / Write
### NumCells

#### Description
Accesses the number of cells
```text
public virtual int NumCells;
```

#### Conditions
Read-only
### PhysicalLength

#### Description
Accesses the physical length of the column.
```text
public virtual int PhysicalLength;
```

#### Conditions
Read / Write