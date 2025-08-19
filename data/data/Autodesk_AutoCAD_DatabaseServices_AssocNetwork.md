# AssocNetwork Class

## Overview

#### Description
The AssocNetwork class keeps a network of AssocActions. Notice that it is derived from AssocAction, therefore it also behaves as an individual AssocAction. It means as a whole network can depend on other objects via its AssocDependencies or be owned by a higher-level AssocNetwork, allowing to create hierarchical associative structures. 
The AssocDependencies between AssocActions in the AssocNetwork define how the actions are tied together, how they depend on objects and on each other. For example, if one action modifies (writes) an object and another action uses (reads) the object, then the second action depends on the first one and the second action needs to be evaluated only after the first action has been evaluated.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocAction
        Autodesk.AutoCAD.DatabaseServices.AssocNetwork
```

```text
public class AssocNetwork : AssocAction;
```

### Constructors

- [AssocNetwork](#assocnetwork)

### Methods

- [AddAction](#addaction)
- [AddActions](#addactions)
- [GetInstanceFromDatabase](#getinstancefromdatabase)
- [GetInstanceFromObject](#getinstancefromobject)
- [OwnedActionStatusChanged](#ownedactionstatuschanged)
- [RemoveAction](#removeaction)
- [RemoveAllActions](#removeallactions)
- [RemoveInstanceFromDatabase](#removeinstancefromdatabase)
- [RemoveInstanceFromObject](#removeinstancefromobject)

### Properties

- [GetActions](#getactions)


## Constructors Details

### AssocNetwork

#### Description
Default constructor.
```text
public AssocNetwork();
```

### AddAction

#### Description
Adds an AssocAction to be owned by this network. The action being added must not be owned by any network. Every action except for the topmost AssocNetwork is "logically" owned by a single AssocNetwork. 
The network becomes the "logical" owner of the action. It may also become the "physical" database owner of the action (the network has hard-ownership id of the action), but the "physical" owner may be some other object. For example, for networks attached to BlockTableRecords, the "logical" owner is the top-level network of the whole database but the "physical" database owner is the subdictionary of the extension dictionary of the AcBdBlockTableRecord.
```text
public void AddAction(
    ObjectId actionId, 
    [MarshalAs(UnmanagedType.U1)] bool alsoSetAsDatabaseOwner
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId actionId | AssocAction being added to the network. |
| [MarshalAs(UnmanagedType.U1)] bool alsoSetAsDatabaseOwner | Make this network the database owner of the action. |

### AddActions

#### Description
Adds the given AssocActions to be owned by this network. The actions being added must not be owned by any network. 
The network becomes the "logical" owner of the action. It may also become the "physical" database owner of the actions (the network has hard-ownership id of the actions), but the "physical" owner may be some other object. For example, for networks attached to BlockTableRecords, the "logical" owner is the top-level network of the whole database but the "physical" database owner is the subdictionary of the extension dictionary of the BlockTableRecord.
```text
public void AddActions(
    ObjectIdCollection actionIds, 
    [MarshalAs(UnmanagedType.U1)] bool alsoSetAsDatabaseOwner
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectIdCollection actionIds | AssocActions being added to the network. |
| [MarshalAs(UnmanagedType.U1)] bool alsoSetAsDatabaseOwner | Make this network the database owner of the actions. |

### GetInstanceFromDatabase

#### Description
Returns ObjectId of the AssocNetwork owned by the given database, optionally creating a new one if it does not exist yet. Returns ObjectId::Null if the network cannot be obtained. 
The network is owned by a special sub-dictionary owned by the named object dictionary of the database.
```text
public static ObjectId GetInstanceFromDatabase(
    Database database, 
    [MarshalAs(UnmanagedType.U1)] bool createIfDoesNotExist, 
    string dictionaryKey
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Database database | Database owning the network. |
| [MarshalAs(UnmanagedType.U1)] bool createIfDoesNotExist | If it does not exist yet, create a new subdictionary under the named object dictionary of the database. Create an AssocNetwork and make it owned by this newly created subdictionary. |
| string dictionaryKey | The name of the sub-dictionary under which the network belongs. If no key name is given, the default "ACAD_ASSOCNETWORK" key is used. |

#### Returns
ObjectId of the existing or newly created AssocNetwork.
### GetInstanceFromObject

#### Description
Returns ObjectId of the AssocNetwork owned by the extension dictionary of the given DBObject, optionally creating a new one if it does not exist yet. Returns ObjectId.Null if the network cannot be obtained. 
The network is owned by a special sub-dictionary owned by the extension dictionary of the given object.
```text
public static ObjectId GetInstanceFromObject(
    ObjectId owningObjectId, 
    [MarshalAs(UnmanagedType.U1)] bool createIfDoesNotExist, 
    [MarshalAs(UnmanagedType.U1)] bool addToTopLevelNetwork, 
    string dictionaryKey
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId owningObjectId | The Object owning the sub-dictionary that owns the AssocNetwork. |
| [MarshalAs(UnmanagedType.U1)] bool createIfDoesNotExist | If it does not exist yet, create a new subdictionary of the extension dictionary of the object. Create an AssocNetwork and make it owned by this newly created subdictionary. |
| [MarshalAs(UnmanagedType.U1)] bool addToTopLevelNetwork | If the network is newly created, it also adds it to the the top-level network of the database that owns the owningObjectId. It has no effect if the network already exists or if createIfDoesNotExist is false. |
| string dictionaryKey | The name of the sub-dictionary under which the network belongs. If no key name is given, the default "ACAD_ASSOCNETWORK" key is used. |

#### Returns
ObjectId of the existing or newly created AssocNetwork.
### OwnedActionStatusChanged

#### Description
This callback is called from AssocAction.SetStatus(..., true) and notifies the network owing the action that the status of the action has just been changed. The action is still open for write and already has the new status.
```text
public void OwnedActionStatusChanged(
    AssocAction ownedAction, 
    AssocStatus previousStatus
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocAction ownedAction | The action whose status has just been changed. |
| AssocStatus previousStatus | Previous status of the action. |

### RemoveAction

#### Description
Removes an AssocAction from the network and optionally erases it. The action being removed must be owned by this network.
```text
public void RemoveAction(
    ObjectId actionId, 
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseIt
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId actionId | AssocAction being removed from the network. |
| [MarshalAs(UnmanagedType.U1)] bool alsoEraseIt | Erase the action after removing it. |

### RemoveAllActions

#### Description
Removes all AssocActions from the network and optionally erases them. The network will become empty.
```text
public void RemoveAllActions(
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseThem
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool alsoEraseThem | Erase the actions after removing them. |

### RemoveInstanceFromDatabase

#### Description
Removes the network and the sub-dictionary that owns it from the named object dictionary of the database.
```text
public static void RemoveInstanceFromDatabase(
    Database database, 
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseIt, 
    string dictionaryKey
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool alsoEraseIt | Erase the network after removing it. |
| string dictionaryKey | The name of the sub-dictionary under which the network belongs. If no key name is given, the default "ACAD_ASSOCNETWORK" key is used. |
| owningObjectId | The database whose named object dictionary owns the sub-dictionary that owns the AssocNetwork. |

### RemoveInstanceFromObject

#### Description
Removes the network and the sub-dictionary that owns it from the extension dictionary of the object.
```text
public static void RemoveInstanceFromObject(
    ObjectId owningObjectId, 
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseIt, 
    string dictionaryKey
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId owningObjectId | The DBObject whose extension dictionary owns the sub-dictionary that owns the AssocNetwork. |
| [MarshalAs(UnmanagedType.U1)] bool alsoEraseIt | Erase the network after removing it. |
| string dictionaryKey | The name of the sub-dictionary under which the network belongs. If no key name is given, the default "ACAD_ASSOCNETWORK" key is used. |

### GetActions

#### Description
Gets the reference to the *internal* array of ObjectIds of all owned AssocActions. If used for anything more than just a simple iteration, or when there is any chance that some actions may be added/removed, you need to make a copy of this array FIRST, because the array may change.
```text
public ObjectIdCollection GetActions;
```

#### Conditions
Read-only