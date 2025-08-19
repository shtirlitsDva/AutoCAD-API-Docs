# CellRange Class

## Overview

#### Description
This class represents ranges of table cells. 
Autodesk.AutoCAD.DatabaseServices.CellRange.CellRange 
Default constructor.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.CellRange
    Autodesk.AutoCAD.DatabaseServices.Cell
```

```text
public class CellRange : ISubObject, IEnumerable<CellReference>;
```

### Constructors

- [CellRange](#cellrange)

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [BottomRight](#bottomright)
- [BottomRow](#bottomrow)
- [LeftColumn](#leftcolumn)
- [RightColumn](#rightcolumn)
- [TopLeft](#topleft)
- [TopRow](#toprow)


## Constructors Details

### CellRange

#### Description
Default constructor.
```text
protected CellRange(
    Table table, 
    int topRow, 
    int leftColumn, 
    int bottomRow, 
    int rightColumn
);
```

### Equals

#### Description
Returns true if the two CellRange objects match.
```text
public override bool Equals(
    object pRange
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| object pRange | Input range to check against. |

### GetHashCode

#### Description
Returns a hash code for the specific cell.
```text
public override int GetHashCode();
```

### != Operator

#### Description
Returns true if the two cells do not match.
```text
public static bool operator !=(
    CellRange t1, 
    CellRange t2
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CellRange t1 | Input Autodesk.AutoCAD.DatabaseServices.CellRange object for left operator. |
| CellRange t2 | Input Autodesk.AutoCAD.DatabaseServices.CellRange object for right operator. |

### == Operator

#### Description
Returns true if the values within the two cells (each row and column) is equal.
```text
public static bool operator ==(
    CellRange t1, 
    CellRange t2
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CellRange t1 | Input Autodesk.AutoCAD.DatabaseServices.CellRange object for left operator. |
| CellRange t2 | Input Autodesk.AutoCAD.DatabaseServices.CellRange object for right operator. |

### BottomRight

#### Description
Returns the Cell from the bottom row.
```text
public Cell BottomRight;
```

#### Conditions
Read-only
### BottomRow

#### Description
Returns the index of the bottom row.
```text
public int BottomRow;
```

#### Conditions
Read-only
### LeftColumn

#### Description
Returns the index of the left column.
```text
public int LeftColumn;
```

#### Conditions
Read-only
### RightColumn

#### Description
Returns the index of the right column.
```text
public int RightColumn;
```

#### Conditions
Read-only
### TopLeft

#### Description
Returns the Cell in the top left.
```text
public Cell TopLeft;
```

#### Conditions
Read-only
### TopRow

#### Description
Returns the index of the top row.
```text
public int TopRow;
```

#### Conditions
Read-only