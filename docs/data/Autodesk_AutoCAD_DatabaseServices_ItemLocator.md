# ItemLocator Structure

## Overview

#### Description
ItemLocator wraps the ObjectARX class [AcDbItemLocator](AcDbItemLocator.md). 
ItemLocator represents spatial index of an item in a 3D array, that is, an item index{i,j,k} for a rectangular array.
```text
public struct ItemLocator {
}
```

### Constructors

- [ItemLocator](#itemlocator)

### Properties

- [ItemIndex](#itemindex)
- [LevelIndex](#levelindex)
- [RowIndex](#rowindex)


## Constructors Details

### ItemLocator

#### Description
Parameterized constructor. 
Initializes all indices of the object.
```text
public ItemLocator(
    int itemIndex, 
    int rowIndex, 
    int levelIndex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int itemIndex | The input Index relative to the first item. itemIndex >= 0. |
| int rowIndex | The input Index relative to the first row. rowIndex >= 0. |
| int levelIndex | The input Index relative to the first level. levelIndex >=0. |

### ItemIndex

#### Description
Item position relative to the first item.
```text
public int ItemIndex;
```

### LevelIndex

#### Description
Item position relative to the first level.
```text
public int LevelIndex;
```

### RowIndex

#### Description
Item position relative to the first row.
```text
public int RowIndex;
```
