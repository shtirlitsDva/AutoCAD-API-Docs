# BulgeVertexCollection Class

## Overview

#### Description
This collection provides a container for Autodesk.AutoCAD.DatabaseServices.BulgeVertex objects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.BulgeVertexCollection
```

```text
public class BulgeVertexCollection : CollectionBase;
```

### Constructors

- [BulgeVertexCollection](#bulgevertexcollection)

### Methods

- [Add](#add)
- [Contains](#contains)
- [CopyTo](#copyto)
- [IndexOf](#indexof)
- [Insert](#insert)
- [Remove](#remove)


## Constructors Details

### BulgeVertexCollection

#### Description
Default constructor.
```text
public BulgeVertexCollection();
```

### Add

#### Description
Adds the object represented by value to this collection. Returns the zero-based index of the newly added collection item.
```text
public int Add(
    BulgeVertex value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| BulgeVertex value | Input the object to add. |

### Contains

#### Description
Returns a value indicating whether the collection contains an object that matches value.
```text
public bool Contains(
    BulgeVertex value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| BulgeVertex value | Input the object to check for. |

### CopyTo

#### Description
Copies objects in array to this collection.
```text
public void CopyTo(
    BulgeVertex\[\] array, 
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| BulgeVertex[] array | Input the object to copy from. |
| int index | Input the index to begin copying. |

### IndexOf

#### Description
Returns the index of the collection item that possesses value.
```text
public int IndexOf(
    BulgeVertex value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| BulgeVertex value | Input the object to check. |

### Insert

#### Description
Inserts value at position index in the collection.
```text
public void Insert(
    int index, 
    BulgeVertex value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input the index to insert at. |
| BulgeVertex value | Input the object to insert. |

### Remove

#### Description
Removes the object represented by value from this collection.
```text
public void Remove(
    BulgeVertex value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| BulgeVertex value | Input the object to remove. |

#### Conditions
Read-only