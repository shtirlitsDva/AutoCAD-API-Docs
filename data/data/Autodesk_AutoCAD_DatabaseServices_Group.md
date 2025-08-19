# Group Class

## Overview

#### Description
This .NET class wraps the AcDbGroup ObjectARX class. 
The Group class represents a collection of entities referred to by a single name. All Group objects belong to a dictionary object which can be obtained through the Database.GetGroupDictionary() method. 
Unlike a block, entities within a group can be individually manipulated. 
This class contains a dynamic array of object IDs that are the objects in the group.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Group
```

```text
public class Group : DBObject;
```

#### Notes
Group plants persistent reactors on its entries when the entries are added to the group. To accomplish this, it must have an objectId. When the group is added to the group dictionary, it is also added to the database, and thus it obtains an objectId. Therefore, do not attempt to add entries to a newly created group before adding the group to the group dictionary.
#### See Also
GroupIterator, Entity, ObjectId

## Members

### Constructors

- [Group()](#group())
- [Group(string, [MarshalAs(UnmanagedType.U1)] bool)](#group(string,-[marshalas(unmanagedtype.u1)]-bool))

### Methods

- [Append(ObjectId)](#append(objectid))
- [Append(ObjectIdCollection)](#append(objectidcollection))
- [Clear](#clear)
- [GetAllEntityIds](#getallentityids)
- [GetIndex](#getindex)
- [Has](#has)
- [InsertAt(int, ObjectId)](#insertat(int,-objectid))
- [InsertAt(int, ObjectIdCollection)](#insertat(int,-objectidcollection))
- [Prepend(ObjectId)](#prepend(objectid))
- [Prepend(ObjectIdCollection)](#prepend(objectidcollection))
- [Remove(ObjectId)](#remove(objectid))
- [Remove(ObjectIdCollection)](#remove(objectidcollection))
- [RemoveAt(int)](#removeat(int))
- [RemoveAt(int, ObjectIdCollection)](#removeat(int,-objectidcollection))
- [Replace](#replace)
- [Reverse](#reverse)
- [SetAnonymous](#setanonymous)
- [SetColor](#setcolor)
- [SetColorIndex](#setcolorindex)
- [SetHighlight](#sethighlight)
- [SetLayer(ObjectId)](#setlayer(objectid))
- [SetLayer(string)](#setlayer(string))
- [SetLinetype(ObjectId)](#setlinetype(objectid))
- [SetLinetype(string)](#setlinetype(string))
- [SetLinetypeScale](#setlinetypescale)
- [SetVisibility](#setvisibility)
- [Transfer](#transfer)

### Properties

- [Description](#description)
- [IsAnonymous](#isanonymous)
- [IsNotAccessible](#isnotaccessible)
- [Name](#name)
- [NumEntities](#numentities)
- [Selectable](#selectable)


## Constructors Details

### Group()

#### Description
Default constructor. Initializes the group description string to NULL, Selectable to true, and the entities list to empty. 
Before the Group object can be added to a database, it must have its Description property called to set a valid description string.
```text
public Group();
```

### Group(string, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Initializes the group object to use a copy of the description string as the description. If selectable == true, then when any entity within the group is selected, all entities in the group are selected. If selectable == false, then entities within the group are treated as individuals during the selection process. 
description must not be NULL. 
```text
public Group(
    string description, 
    [MarshalAs(UnmanagedType.U1)] bool selectable
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string description | Input null terminated string describing the group |
| [MarshalAs(UnmanagedType.U1)] bool selectable | Input Boolean value indicating whether the group is selectable or not |

### Append(ObjectId)

#### Description
This function appends the object identified by id to the group. 
**Note**
The same object can belong to more than one group. However, it can be added only once within each group.
```text
public void Append(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input objectId of the object to be appended to group |

### Append(ObjectIdCollection)

#### Description
This function appends the objects whose objectIds are in the ids collection to the group. 
**Note**
The same object can belong to more than one group. However, it can be added only once within each group.
```text
public void Append(
    ObjectIdCollection ids
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectIdCollection ids | Input objectId collection containing the objectIds of the objects to be appended |

### Clear

#### Description
This methods resets or clears the contents of a group. After this method is called the group contains no elements. All other settings in the group remain unchanged (for example, name, description, colorIndex, etc.).
```text
public void Clear();
```

### GetAllEntityIds

#### Description
Returns an array with the objectIds of the entities in the group.
```text
public ObjectId\[\] GetAllEntityIds();
```

### GetIndex

#### Description
Returns the index of the object identified by id.
```text
public int GetIndex(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input objectId of the object whose index is being queried |

### Has

#### Description
This method returns true if entity is present in the group or false if entity is not part of the group.
```text
public bool Has(
    Entity entity
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity entity | Input the entity being looked up |

### InsertAt(int, ObjectId)

#### Description
Inserts the object specified by id into the group just after the entry at the index. The indices are zero based. Hence the first element in the group will have an index of 0.
```text
public void InsertAt(
    int index, 
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input insertion index |
| ObjectId id | Input objectId of the object to be inserted |

### InsertAt(int, ObjectIdCollection)

#### Description
Inserts the objects whose objectIds are in the ids collection into the group just after the entry at index. The indices are zero based. Hence the first element in the group will have an index of 0.
```text
public void InsertAt(
    int index, 
    ObjectIdCollection ids
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input insertion index |
| ObjectIdCollection ids | Input objectId collection containing objects to be inserted |

### Prepend(ObjectId)

#### Description
This function prepends the object identified by id to the group. 
**Note** The same object can belong to more than one group. However, it can be added only once within each group. 
```text
public void Prepend(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input objectId of the object to be prepended to group |

### Prepend(ObjectIdCollection)

#### Description
This function prepends the objects whose objectIds are in the ids collection to the group. 
**Note** The same object can belong to more than one group. However, it can be added only once within each group. 
```text
public void Prepend(
    ObjectIdCollection ids
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectIdCollection ids | Input objectId collection containing the objectIds of the objects to be prepended |

### Remove(ObjectId)

#### Description
Removes from the group, the object whose object ID is id.
```text
public void Remove(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input objectId of the object to be removed |

### Remove(ObjectIdCollection)

#### Description
Removes from the group, all objects whose object IDs are in the ids collection.
```text
public void Remove(
    ObjectIdCollection ids
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectIdCollection ids | Input array of objectIds of objects to be removed from the group |

### RemoveAt(int)

#### Description
Removes from the group, the object at the index index.
```text
public void RemoveAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index of the object to be removed |

### RemoveAt(int, ObjectIdCollection)

#### Description
Removes, from the group, the objects whose object IDs are in the ids collection. All objects must be in the group and be at index locations equal to or higher than index.
```text
public void RemoveAt(
    int index, 
    ObjectIdCollection ids
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input starting index of the objects to be removed |
| ObjectIdCollection ids | Input objectId array of objects to be removed after start index |

### Replace

#### Description
This function replaces the oldId entity with the newId entity in the group.
```text
public void Replace(
    ObjectId oldId, 
    ObjectId newId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId oldId | Input objectId of the object to be removed from the group |
| ObjectId newId | Input objectId of the object to be added to the group in place of oldId |

### Reverse

#### Description
This method reverses the indices of all the objects in the group. The first object in the group will become the last object in the group, and so on.
```text
public void Reverse();
```

### SetAnonymous

#### Description
This method sets the group to be anonymous. The group's current name will be replaced by an automatically generated anonymous group name.
```text
public void SetAnonymous();
```

### SetColor

#### Description
All the entities in the group will be set to the color specified by color.
```text
public void SetColor(
    Autodesk.AutoCAD.Colors.Color color
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.Colors.Color color | Input Color object representing the color to be set |

### SetColorIndex

#### Description
All the entities in the group will be set to the color specified by color.
```text
public void SetColorIndex(
    int color
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int color | Input AutoCAD color index to be set for entities in the group (color index must be in the range 0 to 256) |

### SetHighlight

#### Description
If newVal == true, then all entities in the group will be highlighted. If newVal == false, then all entities in the group will be unhighlighted.
```text
public void SetHighlight(
    [MarshalAs(UnmanagedType.U1)] bool value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool value | Input Boolean indicating whether to highlight or not |

### SetLayer(ObjectId)

#### Description
Sets all entities in the group to use the LayerTableRecord with objectId value.
```text
public void SetLayer(
    ObjectId value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId value | Input objectId of the layer to use |

### SetLayer(string)

#### Description
Sets the LayerTableRecord with name value to be the layer for all entities in the group. If the layer specified by value exists, the entities will be modified to reference that layer. If the layer does not exist, a layer of name value is created before modifying the entities.
```text
public void SetLayer(
    string value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string value | Input null terminated string that is the name of the new layer |

### SetLinetype(ObjectId)

#### Description
Sets the LinetypeTableRecord with objectId value to be the line type for all entities in the group.
```text
public void SetLinetype(
    ObjectId value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId value | Input objectId of the line type |

### SetLinetype(string)

#### Description
Sets the LinetypeTableRecord with name value to be the line type for all entities in the group. 
This function will succeed only if the specified linetype is already loaded.
```text
public void SetLinetype(
    string value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string value | Input objectId null terminated string that is the name of the new line type |

### SetLinetypeScale

#### Description
Sets the line type scale to value for all entities in the group.
```text
public void SetLinetypeScale(
    double value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double value | Input new value for the line type scale |

### SetVisibility

#### Description
Sets the visibility to value for all entities in the group.
```text
public void SetVisibility(
    [MarshalAs(UnmanagedType.U1)] bool value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool value | Input enum value for visibility |

### Transfer

#### Description
Starting with the item at index fromIndex and going upwards in index values, this function transfers numItems from the index fromIndex to the index toIndex. 
This method enables users to re-arrange ranges of items within a group.
```text
public void Transfer(
    int fromIndex, 
    int toIndex, 
    int numItems
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int fromIndex | Input start index to transfer from |
| int toIndex | Input start index to transfer to |
| int numItems | Input number of items to transfer |

### Description

#### Description
Accesses the group description string Conditions
```text
public string Description;
```

### IsAnonymous

#### Description
Assesses true if the group is an anonymous group
```text
public bool IsAnonymous;
```

#### Conditions
Read-only
### IsNotAccessible

#### Description
Assesses true if the group is marked as inaccessible
```text
public bool IsNotAccessible;
```

#### Conditions
Read-only
### Name

#### Description
Accesses the name string for the group.
```text
public string Name;
```

#### Conditions
Read / Write
### NumEntities

#### Description
Accesses the number of entities in the group.
```text
public int NumEntities;
```

#### Conditions
Read-only
### Selectable

#### Description
Assesses true if the entire group is selected and manipulated as one unit
```text
public bool Selectable;
```

#### Conditions
Read / Write