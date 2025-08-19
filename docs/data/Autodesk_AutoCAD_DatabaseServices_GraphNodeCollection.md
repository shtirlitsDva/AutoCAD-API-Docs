# GraphNodeCollection Class

## Overview

#### Description
This class contains a collection of graph nodes.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GraphNodeCollection
```

```text
public sealed class GraphNodeCollection : DisposableWrapper, IList;
```

### Constructors

- [GraphNodeCollection](#graphnodecollection)

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

### GraphNodeCollection

#### Description
Default constructor.
```text
public GraphNodeCollection();
```

### Add

#### Description
Adds an item to the collection.
```text
public int Add(
    GraphNode value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode value | Item to add. |

### Clear

#### Description
Removes all objects from the collection.
```text
public void Clear();
```

### Contains

#### Description
Returns a value indicating whether the collection contains an object that matches value.
```text
public bool Contains(
    GraphNode value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode value | Object to check for |

### CopyTo

#### Description
Copies objects in array to this collection, starting from index.
```text
public void CopyTo(
    GraphNode\[\] array, 
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode[] array | Array to copy from |
| int index | Zero-based index to start from |

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
    GraphNode value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode value | Item to seek |

### Insert

#### Description
Inserts value at position index in the collection.
```text
public void Insert(
    int index, 
    GraphNode value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Location to insert |
| GraphNode value | Item to insert |

### Remove

#### Description
Removes the object represented by value from this collection.
```text
public void Remove(
    GraphNode value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode value | Item to remove. |

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
| int index | Index to remove from |

### Count

#### Description
Accesses the number of items in the collection.
```text
public int Count;
```

#### Conditions
Read-only