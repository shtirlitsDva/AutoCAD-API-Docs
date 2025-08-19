# HyperLinkCollection Class

## Overview

#### Description
This .NET class wraps the AcDbHyperlinkCollection ObjectARX class. 
This class is a collection of Hyperlink objects. The HyperlinkCollection deletes its contents when they are removed, and when the collection object itself is deleted. Hyperlinks in the collection are numbered from 0. 
See the _ObjectARX Developer's Guide_ for an example of how to use this class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.HyperLinkCollection
```

```text
public sealed class HyperLinkCollection : DisposableWrapper, IList;
```

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


## Methods Details

### Add

#### Description
Add an item to the collection.
```text
public int Add(
    HyperLink value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| HyperLink value | Item to add. |

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
    HyperLink value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| HyperLink value | Item to check for. |

### CopyTo

#### Description
Copies the entire collection to another zero-based array.
```text
public void CopyTo(
    HyperLink\[\] array, 
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| HyperLink[] array | Target array. |
| int index | The zero-based index in array at which copying begins. |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public IEnumerator GetEnumerator();
```

### IndexOf

#### Description
Returns the 0-based index of the collection item that matches value.
```text
public int IndexOf(
    HyperLink value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| HyperLink value | Item to look for. |

### Insert

#### Description
Inserts value at position index in the collection.
```text
public void Insert(
    int index, 
    HyperLink value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Location to insert at |
| HyperLink value | Item to insert. |

### Remove

#### Description
Removes the object represented by value from this collection.
```text
public void Remove(
    HyperLink value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| HyperLink value | Object to remove. |

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
| int index | Index of object to remove. |

### Count

#### Description
Accesses the number of objects in the array.
```text
public int Count;
```

#### Conditions
Read-only