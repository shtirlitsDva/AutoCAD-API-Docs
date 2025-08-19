# IdMapping Class

## Overview

#### Description
IdMapping is used by the deep clone operation to map ObjectIds between original objects and their clones (using IdPairs). 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.IdMapping
```

```text
public sealed class IdMapping : RXObject, IEnumerable;
```

#### Notes
There is no method provided to clear all entries in an instance of IdMapping. A new instance must be created for each use in a deep clone operation. Making IdMapping unique for each deep clone operation makes it possible to use the instance address as a distinguishing identifier in deep clone notification. 
IdPair instances that have been added to the map are destroyed when the IDMapping instance is destroyed. 
#### See Also
IdPair, Database.DeepCloneObjects, Database.AbortDeepClone, DBObject.DeepClone, DBObject.WblockClone

## Members

### Constructors

- [IdMapping](#idmapping)

### Methods

- [Add](#add)
- [Change](#change)
- [Contains](#contains)
- [Delete](#delete)
- [GetEnumerator](#getenumerator)
- [Lookup](#lookup)

### Properties

- [DeepCloneContext](#deepclonecontext)
- [DestinationDatabase](#destinationdatabase)
- [DuplicateRecordCloning](#duplicaterecordcloning)
- [OriginalDatabase](#originaldatabase)


## Constructors Details

### IdMapping

#### Description
Default constructor. The new IdMapping object is initialized as follows:
```text
public IdMapping();
```

#### Conditions
Read / Write 
Since the destination database is initialized to NULL, the DestinationDatabase property must be called to set the destination database before the IdMapping object can be used.
### Add

#### Description
This function adds pairToAdd to the IdMapping object's map.
```text
public void Add(
    IdPair pairToAdd
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IdPair pairToAdd | Input IdPair to add |

### Change

#### Description
This function searches the IDMapping object's map for the key contained in pairToChange and, if found, replaces the entry with a copy of pairToChange.
```text
public void Change(
    IdPair pairToChange
);
```

### Contains

#### Description
This function searches the IdMapping object's ID map for an IdPair that has a key that matches the key passed. 
If the key is found, the remaining data in the "found" IdPair within the map will be copied into idPair and the function returns true. If the key is not found and the ID map is being used to clone within the same database, then the function sets the value of idPair equal to the key and returns false. If the key is not found and the ID map is either being used as a container, or for cloning between two databases, then the value of idPair is set to NULL and the function returns false. 
This function can only be used to find an entry based on the key for the IdPair, not on the value for the pair.
```text
public bool Contains(
    ObjectId key
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId key | Input key to look for |

### Delete

#### Description
This function searches the IdMapping ID map for an entry that has a key matching key. If a matching entry is found, it is deleted from the ID map.
```text
public void Delete(
    ObjectId key
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId key | Input objectId which is the key of the ID pair to be deleted from the map |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public IEnumerator GetEnumerator();
```

### Lookup

#### Description
This function searches the IdMapping object's ID map for an IdPair that has a key that matches the key passed. 
If the key is found, the remaining data in the "found" IdPair within the map will be copied into idPair and returned. If the key is not found and the ID map is being used to clone within the same database, then the function sets the value of idPair equal to the key and returns NULL. If the key is not found and the ID map is either being used as a container, or for cloning between two databases, then the value of idPair is set to NULL and the function returns NULL. 
This function can only be used to find an entry based on the key for the IdPair, not on the value for the pair.
```text
public IdPair Lookup(
    ObjectId key
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId key | Input key to look for |

### DeepCloneContext

#### Description
Accesses the context of the deepclone operation the IdMapping object is involved in.
```text
public Autodesk.AutoCAD.DatabaseServices.DeepCloneType DeepCloneContext;
```

#### Conditions
Read-only
### DestinationDatabase

#### Description
Accesses the database that is the destination for the deep clone operation for which the IdMapping object is being used.
```text
public Database DestinationDatabase;
```

#### Conditions
Read / Write
### DuplicateRecordCloning

#### Description
Accesses the value for duplicate record cloning, which determines what happens if symbols or dictionary entries are cloned, and a duplicate is found to already exist in the destination database.
```text
public Autodesk.AutoCAD.DatabaseServices.DuplicateRecordCloning DuplicateRecordCloning;
```

#### Conditions
Read -only
### OriginalDatabase

#### Description
Accesses the source database for the deep clone operation.
```text
public Database OriginalDatabase;
```

#### Conditions
Read-only