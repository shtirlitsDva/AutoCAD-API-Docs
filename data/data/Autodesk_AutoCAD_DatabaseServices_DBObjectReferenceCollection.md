# DBObjectReferenceCollection Class

## Overview

#### Description
This class provides a container for Autodesk.AutoCAD.DatabaseServices.DBObjectReference objects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObjectReferenceCollection
```

```text
public sealed class DBObjectReferenceCollection : CollectionBase;
```

### Methods

- [Add](#add)
- [Contains](#contains)
- [CopyTo](#copyto)
- [IndexOf](#indexof)
- [Insert](#insert)
- [Remove](#remove)


## Methods Details

### Add

#### Description
Adds the object represented by value to this collection. Returns the zero-based index of the newly added collection item.
```text
public int Add(
    DBObjectReference value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DBObjectReference value | Input object to add |

### Contains

#### Description
Returns a Boolean indicating whether the collection contains an object that matches value
```text
public bool Contains(
    DBObjectReference value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DBObjectReference value | Object to look for |

### CopyTo

#### Description
Copies objects in array to this collection.
```text
public void CopyTo(
    DBObjectReference\[\] array, 
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DBObjectReference[] array | Array to copy from |
| int index | Zero-based index to start copying at |

### IndexOf

#### Description
Returns the zero-based index of the collection item that matches value.
```text
public int IndexOf(
    DBObjectReference value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DBObjectReference value | Item to retrieve the index of |

### Insert

#### Description
Inserts value at position index in the collection
```text
public void Insert(
    int index, 
    DBObjectReference value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Index to insert at |
| DBObjectReference value | Item to insert |

### Remove

#### Description
Removes the object represented by value from this collection.
```text
public void Remove(
    DBObjectReference value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DBObjectReference value | Item to remove |
