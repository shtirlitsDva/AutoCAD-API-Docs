# ObjectIdCollection Class

## Overview

#### Description
This class contains a collection of Object IDs.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection
```

```text
public sealed class ObjectIdCollection : DisposableWrapper, IList;
```

### Constructors

- [ObjectIdCollection()](#objectidcollection())

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

### ObjectIdCollection()

#### Description
Default constructor.
```text
public ObjectIdCollection();
public ObjectIdCollection(
    ObjectId\[\] values
);
```

### Add

#### Description
Adds the object represented by value to this collection. Returns the zero-based index of the newly added collection item.
```text
public int Add(
    ObjectId value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value | Item to add |

### Clear

#### Description
Erases the entire collection.
```text
public void Clear();
```

### Contains

#### Description
Returns true if value exists within the collection.
```text
public bool Contains(
    ObjectId value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value | Item to check for |

### CopyTo

#### Description
Copies objects in array to this collection, starting from index.
```text
public void CopyTo(
    ObjectId\[\] array, 
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId[] array | Array to copy from |
| int index | Index to begin at |

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
    ObjectId value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value | Item to search for |

### Insert

#### Description
Inserts value at position index in the collection.
```text
public void Insert(
    int index, 
    ObjectId value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Index to insert at |
| ObjectId value | Item to add |

### Remove

#### Description
Removes the object represented by value from this collection.
```text
public void Remove(
    ObjectId value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value | Object to remove |

### RemoveAt

#### Description
Removes the object whose index in the collection is index.
```text
public void RemoveAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Index of object to remove |

### Count

#### Description
Accesses the total number of objects in the collection.
```text
public int Count;
```

#### Conditions
Read-only