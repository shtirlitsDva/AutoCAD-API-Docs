# FormattedTableData Class

## Overview

#### Description
This .NET class wraps the AcDbFormattedTableData ObjectARX class. 
This class derives from LinkedTableData and adds formatting support for the cells, rows, and columns in the table. This class contains formatting information for display of the table.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.LinkedData
        Autodesk.AutoCAD.DatabaseServices.LinkedTableData
            Autodesk.AutoCAD.DatabaseServices.FormattedTableData
                Autodesk.AutoCAD.DatabaseServices.TableContent
```

```text
public class FormattedTableData : LinkedTableData;
```

### Constructors

- [FormattedTableData](#formattedtabledata)

### Methods

- [GetAlignment](#getalignment)
- [GetBackgroundColor](#getbackgroundcolor)
- [GetContentColor](#getcontentcolor)
- [GetGridColor](#getgridcolor)
- [GetGridLinetype](#getgridlinetype)
- [GetGridLineWeight](#getgridlineweight)
- [GetGridVisibility](#getgridvisibility)
- [GetMargin](#getmargin)
- [GetMergeRange](#getmergerange)
- [GetOverride(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType)](#getoverride(int,-int,-autodesk.autocad.databaseservices.gridlinetype))
- [GetOverride(int, int, int)](#getoverride(int,-int,-int))
- [GetRotation](#getrotation)
- [GetScale](#getscale)
- [GetTextHeight](#gettextheight)
- [GetTextStyle](#gettextstyle)
- [IsFormatEditable](#isformateditable)
- [IsMerged](#ismerged)
- [Merge](#merge)
- [RemoveAllOverrides](#removealloverrides)
- [SetAlignment](#setalignment)
- [SetBackgroundColor](#setbackgroundcolor)
- [SetContentColor](#setcontentcolor)
- [SetGridColor](#setgridcolor)
- [SetGridLinetype](#setgridlinetype)
- [SetGridLineWeight](#setgridlineweight)
- [SetGridVisibility](#setgridvisibility)
- [SetMargin](#setmargin)
- [SetOverride(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType, GridProperties)](#setoverride(int,-int,-autodesk.autocad.databaseservices.gridlinetype,-gridproperties))
- [SetOverride(int, int, int, CellProperties)](#setoverride(int,-int,-int,-cellproperties))
- [SetRotation](#setrotation)
- [SetScale](#setscale)
- [SetTextHeight](#settextheight)
- [SetTextStyle](#settextstyle)
- [Unmerge](#unmerge)


## Constructors Details

### FormattedTableData

#### Description
Default constructor.
```text
public FormattedTableData();
```

### GetAlignment

#### Description
Returns the alignment of the first content in radians.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.CellAlignment GetAlignment(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### GetBackgroundColor

#### Description
Returns the background color of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
```text
public virtual Autodesk.AutoCAD.Colors.Color GetBackgroundColor(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |

### GetContentColor

#### Description
Returns the color of the first content in radians.
```text
public virtual Autodesk.AutoCAD.Colors.Color GetContentColor(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### GetGridColor

#### Description
Returns the grid color of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
```text
public virtual Autodesk.AutoCAD.Colors.Color GetGridColor(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype | Input grid line type |

### GetGridLinetype

#### Description
Returns the grid line type of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
```text
public virtual ObjectId GetGridLinetype(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype | Input grid line type |

### GetGridLineWeight

#### Description
Returns the grid line weight of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.LineWeight GetGridLineWeight(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype | Input grid line type |

### GetGridVisibility

#### Description
Returns the grid visibility of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.Visibility GetGridVisibility(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype | Input grid line type |

### GetMargin

#### Description
Returns the margin of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
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
| int column | Input column index. This can be -1. See remarks. |
| CellMargins margin | Input margin type to get |

### GetMergeRange

#### Description
Returns merge range. The merge range will be invalid if the cell is not part of a merge range.
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

### GetOverride(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType)

#### Description
Returns the override in specified grid line type in cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
```text
public virtual GridProperties GetOverride(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype | Input grid line type |

### GetOverride(int, int, int)

#### Description
Returns the override of cell, row, column, or content. 
To specify content pass a valid row, column, and content indices; to specifiy cell pass a valid row and column indices and pass -1 as content index; to specify row pass a valid row index and pass -1 as column and content indices; to specify column pass a valid column index and pass -1 as row and content indices.
```text
public virtual CellProperties GetOverride(
    int row, 
    int column, 
    int content
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| int content | Input content index. This can be -1. See remarks. |

### GetRotation

#### Description
Returns the rotation angle of the first content in radians.
```text
public virtual double GetRotation(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### GetScale

#### Description
Returns the scale of the first content in radians.
```text
public virtual double GetScale(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### GetTextHeight

#### Description
Returns the text height of the first content in radians.
```text
public virtual double GetTextHeight(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### GetTextStyle

#### Description
Returns the text style of the first content in radians.
```text
public virtual ObjectId GetTextStyle(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### IsFormatEditable

#### Description
This function checks the cell state to determine if a cell format can be modified. Applications should use this function to determine if a cell is editable instead of calling cellState directly and checking the state since the semantics of an editable cell may change as new states are added. 
Returns true if the format can be modified and false if not.
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

### IsMerged

#### Description
Returns true if the specified cell is part of a merge range; false if not.
```text
public virtual bool IsMerged(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |

### Merge

#### Description
Merges the cells in the range. 
The specified range can be a cell range, row range, or column range.
```text
public virtual void Merge(
    CellRange range
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CellRange range | Input cell range to merge |

### RemoveAllOverrides

#### Description
Removes all the overrides in cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
```text
public virtual void RemoveAllOverrides(
    int row, 
    int column
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |

### SetAlignment

#### Description
Sets the alignment of the first content.
```text
public virtual void SetAlignment(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.CellAlignment value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| Autodesk.AutoCAD.DatabaseServices.CellAlignment value | Input alignment |

### SetBackgroundColor

#### Description
Sets the background color of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
```text
public virtual void SetBackgroundColor(
    int row, 
    int column, 
    Autodesk.AutoCAD.Colors.Color value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| Autodesk.AutoCAD.Colors.Color value | Input color to set |

### SetContentColor

#### Description
Sets the color of the first content.
```text
public virtual void SetContentColor(
    int row, 
    int column, 
    Autodesk.AutoCAD.Colors.Color value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| Autodesk.AutoCAD.Colors.Color value | Input color |

### SetGridColor

#### Description
Sets the grid color of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index. To set same value in multiple grid line types combine multiple grid line types using OR and pass it.
```text
public virtual void SetGridColor(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype, 
    Autodesk.AutoCAD.Colors.Color value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype | Input grid line types. Multiple grid line types can be combined using OR. |
| Autodesk.AutoCAD.Colors.Color value | Input grid color to set |

### SetGridLinetype

#### Description
Sets the grid line type of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index. To set same value in multiple grid line types combine multiple grid line types using OR and pass it.
```text
public virtual void SetGridLinetype(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype, 
    ObjectId value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype | Input grid line types. Multiple grid line types can be combined using OR. |
| ObjectId value | Input grid line type to set |

### SetGridLineWeight

#### Description
Sets the grid line weight of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index. To set same value in multiple grid line types combine multiple grid line types using OR and pass it.
```text
public virtual void SetGridLineWeight(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype, 
    Autodesk.AutoCAD.DatabaseServices.LineWeight value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype | Input grid line types. Multiple grid line types can be combined using OR. |
| Autodesk.AutoCAD.DatabaseServices.LineWeight value | Input grid line weight to set |

### SetGridVisibility

#### Description
Sets the grid visibility of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index. To set same value in multiple grid line types combine multiple grid line types using OR and pass it.
```text
public virtual void SetGridVisibility(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype, 
    Autodesk.AutoCAD.DatabaseServices.Visibility value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype | Input grid line types. Multiple grid line types can be combined using OR. |
| Autodesk.AutoCAD.DatabaseServices.Visibility value | Input grid visibility to set |

### SetMargin

#### Description
Sets the margin of cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
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
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| CellMargins margin | Input margin type to set. Multiple margin types can be combined using OR. |
| double value | Input margin value to set |

### SetOverride(int, int, Autodesk.AutoCAD.DatabaseServices.GridLineType, GridProperties)

#### Description
Gets the override in specified grid line type in cell, row, or column. 
To specify cell pass a valid row and column indices; to specify row pass a valid row index and pass -1 as column index; to specify column pass a valid column index and pass -1 as row index.
```text
public virtual void SetOverride(
    int row, 
    int column, 
    Autodesk.AutoCAD.DatabaseServices.GridLineType gridLinetype, 
    GridProperties gridProperty
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks |
| int column | Input column index. This can be -1. See |

#### Remarks
gridLinetype : Input grid line types. Multiple grid line types can be combined using OR. gridProperty : Input override to set.
### SetOverride(int, int, int, CellProperties)

#### Description
Sets the override in cell, row, column, or content. 
To specify content pass a valid row, column, and content indices; to specify cell pass a valid row and column indices and pass -1 as content index; to specify row pass a valid row index and pass -1 as column and content indices; to specify column pass a valid column index and pass -1 as row and content indices.
```text
public virtual void SetOverride(
    int row, 
    int column, 
    int content, 
    CellProperties cellProperty
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. This can be -1. See remarks. |
| int column | Input column index. This can be -1. See remarks. |
| int content | Input content index. This can be -1. See remarks. |
| CellProperties cellProperty | Input override to set |

### SetRotation

#### Description
Sets the rotation angle of the first content.
```text
public virtual void SetRotation(
    int row, 
    int column, 
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| double value | Input angle in radians |

### SetScale

#### Description
Sets the scale of the first content.
```text
public virtual void SetScale(
    int row, 
    int column, 
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| double value | Input scale |

### SetTextHeight

#### Description
Sets the text height of the first content.
```text
public virtual void SetTextHeight(
    int row, 
    int column, 
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int row | Input row index. It should be more than or equal to 0 and less than the number of rows. |
| int column | Input column index. It should be more than or equal to 0 and less than the number of columns. |
| double value | Input text height |

### SetTextStyle

#### Description
Sets the text style of the first content.
```text
public virtual void SetTextStyle(
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
| ObjectId value | Input text style |

### Unmerge

#### Description
Unmerges the cells in the range. The specified range can be a cell range, row range, or column range.
```text
public virtual void Unmerge(
    CellRange range
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CellRange range | Input cell range to unmerge |
