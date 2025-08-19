# MlineStyleElementCollectionEnumerator Class

## Overview

#### Description
This class enumerates the contents of MlineStyleElementCollection objects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.MlineStyleElementCollectionEnumerator
```

```text
public sealed class MlineStyleElementCollectionEnumerator : IEnumerator;
```

### Constructors

- [MlineStyleElementCollectionEnumerator](#mlinestyleelementcollectionenumerator)

### Methods

- [MoveNext](#movenext)
- [Reset](#reset)

### Properties

- [Current](#current)


## Constructors Details

### MlineStyleElementCollectionEnumerator

#### Description
Constructs a new enumeration based on an existing collection.
```text
public MlineStyleElementCollectionEnumerator(
    MlineStyleElementCollection col
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| MlineStyleElementCollection col | Input collection to generate from |

### MoveNext

#### Description
This method moves the collection pointer to the next object, or to the end of the collection if it is currently positioned at the final collection object.
```text
public bool MoveNext();
```

### Reset

#### Description
This method moves the collection pointer to the beginning of the collection.
```text
public void Reset();
```

### Current

#### Description
Accesses the current enumeration.
```text
public MlineStyleElement Current;
```

#### Conditions
Read-only