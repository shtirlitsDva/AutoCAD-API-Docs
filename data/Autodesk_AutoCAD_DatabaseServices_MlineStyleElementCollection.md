# MlineStyleElementCollection Class

## Overview

#### Description
This collection class provides a container for MlineStyleElement objects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.MlineStyleElementCollection
```

```text
public sealed class MlineStyleElementCollection : ICollection;
```

### Methods

- [Add](#add)
- [CopyTo](#copyto)
- [GetEnumerator](#getenumerator)
- [RemoveAt](#removeat)

### Properties

- [Count](#count)


## Methods Details

### Add

#### Description
Adds a new element to the collection. 
If checkIfReferenced is true and the mline style object is referenced, then the set operation will be aborted. This indicates that it is not safe to change this mline style object. 
Returns the index of the new element.
```text
public int Add(
    MlineStyleElement element, 
    [MarshalAs(UnmanagedType.U1)] bool checkIfReferenced
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| MlineStyleElement element | Input element to add |
| [MarshalAs(UnmanagedType.U1)] bool checkIfReferenced | Input Boolean indicating whether to check if the style is referenced |

### CopyTo

#### Description
Copies objects in array starting from index to this collection.
```text
public void CopyTo(
    MlineStyleElement\[\] array, 
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| MlineStyleElement[] array | Target array. |
| int index | The zero-based index in array at which copying begins. |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public MlineStyleElementCollectionEnumerator GetEnumerator();
```

### RemoveAt

#### Description
Removes an object from the collection at the specified index.
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
Accesses the number of elements in the collection.
```text
public virtual int Count;
```

#### Conditions
Read-only