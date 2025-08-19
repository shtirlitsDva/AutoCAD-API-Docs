# TableHitTestInfo Structure

## Overview

#### Description
This class encapsulates the data returned in the output parameters of the Table.hitTest() ObjectARX function. It performs a hit test for the specified point and viewing direction.
```text
public struct TableHitTestInfo {
}
```

### Methods

- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [Column](#column)
- [Row](#row)
- [Type](#type)


## Methods Details

### ToString()

#### Description
Returns an equivalent string representation of this object.
```text
public sealed override string ToString();
```

### ToString(IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider.
```text
public string ToString(
    IFormatProvider provider
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IFormatProvider provider | Input culture format |

### Column

#### Description
Returns column index of the selected cell.
```text
public int Column;
```

#### Conditions
Read-only
### Row

#### Description
Returns column index of the selected cell.
```text
public int Row;
```

#### Conditions
Read-only
### Type

#### Description
Returns the type of table hit test performed.
```text
public TableHitTestType Type;
```

#### Conditions
Read-only