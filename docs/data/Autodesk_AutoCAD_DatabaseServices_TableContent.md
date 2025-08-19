# TableContent Class

## Overview

#### Description
This .NET class wraps the AcDbTableContent ObjectARX class. 
TableContent derives from AcDbFormattedTableData and supports formatting of table using table style and cell styles. 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.LinkedData
        Autodesk.AutoCAD.DatabaseServices.LinkedTableData
            Autodesk.AutoCAD.DatabaseServices.FormattedTableData
                Autodesk.AutoCAD.DatabaseServices.TableContent
                    Autodesk.AutoCAD.DatabaseServices.TableTemplate
```

```text
public class TableContent : FormattedTableData;
```

### Constructors

- [TableContent](#tablecontent)

### Methods

- [GetCellStyle](#getcellstyle)
- [GetColumnWidth](#getcolumnwidth)
- [GetRowHeight](#getrowheight)
- [SetCellStyle](#setcellstyle)
- [SetColumnWidth](#setcolumnwidth)
- [SetRowHeight](#setrowheight)

### Properties

- [TableStyleId](#tablestyleid)


## Constructors Details

### TableContent

#### Description
Constructor.
```text
public TableContent();
```

#### Conditions
Read-only
### GetCellStyle

#### Description
Gets the cell style of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index. 
Returns the cell style of cell, row, or column.
```text
public virtual string GetCellStyle(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object; row index. This can be -1. |
| int column | Input System.Int32 object; column index. This can be -1. |

### GetColumnWidth

#### Description
Returns the column width.
```text
public virtual double GetColumnWidth(
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int column | Input System.Int32 object; column index. It should be more than or equal to 0 and less than the number of columns. |

### GetRowHeight

#### Description
Returns the row height.
```text
public virtual double GetRowHeight(
    int row
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object; row index. It should be more than or equal to 0 and less than the number of rows. |

### SetCellStyle

#### Description
Sets the cell style of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
```text
public virtual void SetCellStyle(
    int row, 
    int column, 
    string cellStyle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object; row index. This can be -1. |
| int column | Input System.Int32 object; column index. This can be -1. |
| string cellStyle | Input System.String object; cell style to set. The cell style should exist in the table style set in this table. |

### SetColumnWidth

#### Description
Sets the column width
```text
public virtual void SetColumnWidth(
    int column, 
    double width
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int column | Input System.Int32 object; column index. It should be more than or equal to 0 and less than the number of columns. |
| double width | Input System.Double object; column width to set |

### SetRowHeight

#### Description
Sets the row height
```text
public virtual void SetRowHeight(
    int row, 
    double height
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input System.Int32 object. |
| double height | Input System.Double object. |

### TableStyleId

#### Description
Returns the table style id.
```text
public virtual ObjectId TableStyleId;
```

#### Conditions
Read / Write