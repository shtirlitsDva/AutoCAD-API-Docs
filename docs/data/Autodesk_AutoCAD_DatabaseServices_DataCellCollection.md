# DataCellCollection Class

## Overview

#### Description
This .NET class is a wrapper for the typedef AcArray<AcDbDataCell> ObjectARX class. 
An DataCellArray is used as an argument to various DataTable functions to pass row data. It is also the underlying structure for the DataColumn class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DataCellCollection
```

```text
public sealed class DataCellCollection : DisposableWrapper, IList;
```

### Constructors

- [DataCellCollection](#datacellcollection)

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

### DataCellCollection

#### Description
Default constructor.
```text
public DataCellCollection();
```

### Add

#### Description
Adds the object represented by value to this collection. Returns the zero-based index of the newly added collection item.
```text
public int Add(
    DataCell value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DataCell value | Input Autodesk.AutoCAD.DatabaseServices.DataCell object |

### Clear

#### Description
Clears the collection of its contents.
```text
public void Clear();
```

### Contains

#### Description
Returns a value indicating whether the collection contains an object that matches value
```text
public bool Contains(
    DataCell value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DataCell value | Input Autodesk.AutoCAD.DatabaseServices.DataCell object. |

### CopyTo

#### Description
Copies objects in array to this collection, starting from index
```text
public void CopyTo(
    DataCell\[\] array, 
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DataCell[] array | Input Autodesk.AutoCAD.DatabaseServices.DataCell[] object |
| int index | Input |

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
    DataCell value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DataCell value | Input Autodesk.AutoCAD.DatabaseServices.DataCell object |

### Insert

#### Description
Inserts value at position index in the collection.
```text
public void Insert(
    int index, 
    DataCell value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index to insert at |
| DataCell value | Input the data to be inserted |

### Remove

#### Description
Removes the object represented by value from this collection
```text
public void Remove(
    DataCell value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DataCell value | Input value to be removed. |

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
Accesses the number of objects in this collection.
```text
public int Count;
```

#### Conditions
Read-only