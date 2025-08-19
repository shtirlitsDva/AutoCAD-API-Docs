# GripModeCollection Class

## Overview

#### Description
The collection that wraps AcArray of AcDbMultiModesGripPE::GripMode
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GripModeCollection
```

```text
public sealed class GripModeCollection : DisposableWrapper, ICollection<Autodesk.AutoCAD.DatabaseServices.GripMode>;
```

### Constructors

- [GripModeCollection](#gripmodecollection)

### Methods

- [Add](#add)
- [Clear](#clear)
- [Contains](#contains)
- [CopyTo](#copyto)
- [GetEnumerator](#getenumerator)
- [Remove](#remove)

### Other

- [this Indexer](#this-indexer)

### Properties

- [Count](#count)
- [IsReadOnly](#isreadonly)


## Constructors Details

### GripModeCollection

#### Description
Default constructor
```text
public GripModeCollection();
```

### Add

#### Description
Appends a GripMode object to the collection.
```text
public void Add(
    Autodesk.AutoCAD.DatabaseServices.GripMode gripMode
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GripMode gripMode | The mode object to add. |

### Clear

#### Description
Empties the collection.
```text
public void Clear();
```

### Contains

#### Description
Indicates whether a GripMode object is in the collection.
```text
public bool Contains(
    Autodesk.AutoCAD.DatabaseServices.GripMode gripMode
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GripMode gripMode | The gripMode object to test. |

#### Returns
True if _gripMode_ is in the collection.
### CopyTo

#### Description
This is CopyTo, a member of class GripModeCollection.
```text
public void CopyTo(
    Autodesk.AutoCAD.DatabaseServices.GripMode\[\] A_0, 
    int A_1
);
```

### GetEnumerator

#### Description
Gets the internal IEnumerator object to enumerate the collection.
```text
public IEnumerator<Autodesk.AutoCAD.DatabaseServices.GripMode> GetEnumerator();
```

#### Returns
The internal IEnumerator object to enumerate the collection.
### Remove

#### Description
Removes a GripMode object from the collection.
```text
public bool Remove(
    Autodesk.AutoCAD.DatabaseServices.GripMode gripMode
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GripMode gripMode | The gripMode object to remove. |

#### Returns
True if gripMode was in the collection and is removed.
### this Indexer

#### Description
Gets and sets the array index operator.
```text
public Autodesk.AutoCAD.DatabaseServices.GripMode this[
    int i
];
```

### Count

#### Description
Gets the item count in the collection.
```text
public virtual int Count;
```

#### Conditions
Read-only
### IsReadOnly

#### Description
Indicates whether the collection is read-only.
```text
public virtual bool IsReadOnly;
```

#### Conditions
Read-only