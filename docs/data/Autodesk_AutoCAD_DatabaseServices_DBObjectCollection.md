# DBObjectCollection Class

## Overview

#### Description
An interface to a collection of DBObjects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObjectCollection
```

```text
public sealed class DBObjectCollection : DisposableWrapper, IList;
```

#### Notes
When a DBObjectCollection is populated by unmanaged code, the objects in the collection do not yet have managed wrappers. Neither are they (typically) database-resident. DBObjectCollection will generate a wrapper for each object if and when that object is accessed (retrieved) from the collection. If there are no retrieval requests, no wrappers are generated. When a DBObjectCollection is disposed, it looks at the set of unmanaged objects it holds, and the set of wrappers it has generated. For those objects with wrappers, it assumes the wrappers will manage the lifetime of the object, and it does nothing. For those objects without wrappers, it will delete them or close them: it takes responsibility for object lifetime. 
Therefore, you must not get into a situation where an AcDbObject, with a managed wrapper, gets stored in a DBObjectCollection without its wrapper. This can happen if the DBObject is passed into unmanaged code, the unmanaged object is stored in an AcDbVoidPtrArray (the imp-side of a DBObjectCollection), and the AcDbVoidPtrArray turned back into a DBObjectCollection and returned to managed code. 
it is important to be sure DBObjectCollections are properly (perhaps explicitly) disposed.
### Constructors

- [DBObjectCollection](#dbobjectcollection)

### Methods

- [Add](#add)
- [Clear](#clear)
- [Contains](#contains)
- [CopyTo](#copyto)
- [GetEnumerator](#getenumerator)
- [IndexOf](#indexof)
- [Insert](#insert)
- [Remove](#remove)
- [RemoveAt](#removeat)

### Properties

- [Count](#count)


## Constructors Details

### DBObjectCollection

#### Description
Default constructor.
```text
public DBObjectCollection();
```

### Add

#### Description
Adds the object represented by value to this collection. Returns the zero-based index of the newly added collection item.
```text
public int Add(
    DBObject value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DBObject value | Input object to add |

### Clear

#### Description
Removes all objects from the collection.
```text
public void Clear();
```

### Contains

#### Description
Returns a Boolean indicating whether the collection contains an object that matches value
```text
public bool Contains(
    DBObject value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DBObject value | Object to look for |

### CopyTo

#### Description
Copies objects in array to this collection.
```text
public void CopyTo(
    DBObject\[\] array, 
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DBObject[] array | Array to copy from |
| int index | Zero-based index to start copying at |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public IEnumerator GetEnumerator();
```

### IndexOf

#### Description
Returns the zero-based index of the collection item that matches value.
```text
public int IndexOf(
    DBObject value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DBObject value | Item to retrieve the index of |

### Insert

#### Description
Inserts value at position index in the collection
```text
public void Insert(
    int index, 
    DBObject value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Index to insert at |
| DBObject value | Item to insert |

### Remove

#### Description
Removes the object represented by value from this collection.
```text
public void Remove(
    DBObject value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DBObject value | Item to remove |

### RemoveAt

#### Description
Removes the object at index from this collection.
```text
public void RemoveAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Index of item to remove |

### Count

#### Description
Returns the number of objects in this collection.
```text
public int Count;
```

#### Conditions
Read-only