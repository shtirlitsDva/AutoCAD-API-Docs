# LayerStateManager Class

## Overview

#### Description
This .NET class wraps the AcDbLayerStateManager ObjectARX class. 
The LayerStateManager class is used to access and manipulate individual layer states associated with a drawing database. The layer state manager is not implemented as a collection class. Instead it is intended for high-level access to layer state manager functions. For enumerating, listing, and other lower-level functions, developers should use the existing APIs to access the layer state dictionary within the layer table's extension dictionary. The specific name of the layer state dictionary is ACAD_LAYERSTATES.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.LayerStateManager
```

```text
public sealed class LayerStateManager : RXObject;
```

### Constructors

- [LayerStateManager](#layerstatemanager)

### Events

- [AbortLayerStateDelete](#abortlayerstatedelete)
- [AbortLayerStateRename](#abortlayerstaterename)
- [AbortLayerStateRestore](#abortlayerstaterestore)
- [LayerStateCompareFailed](#layerstatecomparefailed)
- [LayerStateCreated](#layerstatecreated)
- [LayerStateDeleted](#layerstatedeleted)
- [LayerStateRenamed](#layerstaterenamed)
- [LayerStateRestored](#layerstaterestored)
- [LayerStateToBeDeleted](#layerstatetobedeleted)
- [LayerStateToBeRenamed](#layerstatetoberenamed)
- [LayerStateToBeRestored](#layerstatetoberestored)

### Methods

- [CompareLayerStateToDb](#comparelayerstatetodb)
- [DeleteLayerState](#deletelayerstate)
- [ExportLayerState](#exportlayerstate)
- [GetLayerStateDescription](#getlayerstatedescription)
- [GetLayerStateLayers](#getlayerstatelayers)
- [GetLayerStateMask](#getlayerstatemask)
- [GetLayerStateNames](#getlayerstatenames)
- [HasLayerState](#haslayerstate)
- [ImportLayerState](#importlayerstate)
- [ImportLayerStateFromDb](#importlayerstatefromdb)
- [LayerStateHasViewportData](#layerstatehasviewportdata)
- [LayerStatesDictionaryId](#layerstatesdictionaryid)
- [RenameLayerState](#renamelayerstate)
- [RestoreLayerState](#restorelayerstate)
- [SaveLayerState](#savelayerstate)
- [SetLayerStateDescription](#setlayerstatedescription)
- [SetLayerStateMask](#setlayerstatemask)

### Properties

- [LastRestoredLayerState](#lastrestoredlayerstate)


## Constructors Details

### LayerStateManager

#### Description
Database to be used by the new layer state manager object
```text
public LayerStateManager(
    Database database
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Database database | Database association constructor. |

### AbortLayerStateDelete

#### Description
Event if the layer state delete process is aborted.
```text
public event LayerStateEventHandler AbortLayerStateDelete;
```

### AbortLayerStateRename

#### Description
Event if the layer state rename process is aborted.
```text
public event LayerStateRenameEventHandler AbortLayerStateRename;
```

### AbortLayerStateRestore

#### Description
Event if the layer state restore process is aborted.
```text
public event LayerStateEventHandler AbortLayerStateRestore;
```

### LayerStateCompareFailed

#### Description
Event if the layer state compare failed.
```text
public event LayerStateEventHandler LayerStateCompareFailed;
```

### LayerStateCreated

#### Description
Event if the layer state is created.
```text
public event LayerStateEventHandler LayerStateCreated;
```

### LayerStateDeleted

#### Description
Event if the layer state is deleted.
```text
public event LayerStateDeletedEventHandler LayerStateDeleted;
```

### LayerStateRenamed

#### Description
Event if the layer state is renamed.
```text
public event LayerStateRenameEventHandler LayerStateRenamed;
```

### LayerStateRestored

#### Description
Event if the layer state is restored.
```text
public event LayerStateEventHandler LayerStateRestored;
```

### LayerStateToBeDeleted

#### Description
Event if the layer state is about to be deleted.
```text
public event LayerStateEventHandler LayerStateToBeDeleted;
```

### LayerStateToBeRenamed

#### Description
Event if the layer state is about to be renamed.
```text
public event LayerStateRenameEventHandler LayerStateToBeRenamed;
```

### LayerStateToBeRestored

#### Description
Event if the layer state is about to be restored.
```text
public event LayerStateEventHandler LayerStateToBeRestored;
```

### CompareLayerStateToDb

#### Description
Compares the layer values saved in a layer state to the current layer values in the drawing. This method compares everything except layer description. This method can also use VPLAYER and override settings of a viewport for comparison of visibility and overridable properties. Specify Null for the idVp argument to ignore viewport settings. 
Returns true if the layer state matches the layers in the drawing, false otherwise.
```text
public bool CompareLayerStateToDb(
    string name, 
    ObjectId idVp
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input name of layer state to be compared to the drawing. |
| ObjectId idVp | Input object ID of the viewport whose VPLAYER settings are to be used when comparing. |

### DeleteLayerState

#### Description
Deletes the specified layer state.
```text
public void DeleteLayerState(
    string name
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input layer state name to delete |

### ExportLayerState

#### Description
ExportLayerState() reads the passed-in layer state name and exports the corresponding layer state to the export file. The layer state name must be passed with a single 0 after the name. 
```text
public void ExportLayerState(
    string nameToExport, 
    string fileName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string nameToExport | Input layer state name to export |
| string fileName | Input filename to export layer state to |

### GetLayerStateDescription

#### Description
Retrieves the description set by SetLayerStateDescription().
```text
public string GetLayerStateDescription(
    string name
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input layer state whose description is to be retrieved |

### GetLayerStateLayers

#### Description
Gets an array of the names of all the layers that are saved in a layer state. If bInvert is true, the array will contain the names of the layers in the current drawing that are NOT saved in the layer state.
```text
public ArrayList GetLayerStateLayers(
    string name, 
    [MarshalAs(UnmanagedType.U1)] bool bInvert
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input the name of the layer state to query |
| [MarshalAs(UnmanagedType.U1)] bool bInvert | Input if true, the returned array will contain the names of the layers in the current drawing that are NOT saved in the layer state. |

### GetLayerStateMask

#### Description
Gets the mask for the named layer state.
```text
public LayerStateMasks GetLayerStateMask(
    string name
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input layer state name |

### GetLayerStateNames

#### Description
Gets an array of the names of all the layer states.
```text
public ArrayList GetLayerStateNames(
    [MarshalAs(UnmanagedType.U1)] bool bIncludeHidden, 
    [MarshalAs(UnmanagedType.U1)] bool bIncludeXref
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool bIncludeHidden | Input flag to include names of hidden layer states in array. |
| [MarshalAs(UnmanagedType.U1)] bool bIncludeXref | Input flag to include XRefs |

### HasLayerState

#### Description
Checks if the layer state name is present and returns true if so, and false otherwise.
```text
public bool HasLayerState(
    string name
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input layer state name |

### ImportLayerState

#### Description
ImportLayerState() reads the passed-in filename (saved by a previous export) and extracts layer states to import. If an import file layer state has the same name as a layer state already existing in the drawing, the imported layer state is ignored. If an import file layer state name is not found in the drawing, it is created in the drawing. If any newly-created layer states refer to layers which are nonexistent in the drawing, the layers are created using default settings. 
```text
public void ImportLayerState(
    string fileName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string fileName | Input file to extract layer states from |

### ImportLayerStateFromDb

#### Description
Imports the layer state name passed in name from the open drawing file pointer passed in database. This method will also import linetypes, materials and plot styles that are saved in the imported layer state but are missing in the current drawing. This method allows importing of layer states directly from drawing files rather than having to export to an _.LAS_ file format in order to import a layer state.
```text
public void ImportLayerStateFromDb(
    string name, 
    Database database
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input the name of the layer state to be imported |
| Database database | Input a pointer to a valid, readable database from which the layer state is to be imported. |

### LayerStateHasViewportData

#### Description
Returns a Boolean indicating whether the given layer state has viewport data associated with it. A layer state has viewport data if SaveLayerState() was called with a non-null id parameter.
```text
public bool LayerStateHasViewportData(
    string name
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input layer state to be interrogated |

### LayerStatesDictionaryId

#### Description
Returns ObjectId of the layer states extension dictionary (within the layer table extension dictionary) or ObjectId(NULL) if the database is Null, or if the symbol table is Null, or if the layer table extension dictionary or the layer states extension dictionary is Null (and createIfNotPresent is false), or if the layer table extension dictionary or layer states extension dictionary cannot be created (and createIfNotPresent is true), or if the layer table extension dictionary cannot be opened for read.
```text
public ObjectId LayerStatesDictionaryId(
    [MarshalAs(UnmanagedType.U1)] bool createIfNotPresent
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool createIfNotPresent | Input flag controlling dictionary creation |

### RenameLayerState

#### Description
Renames the layer state name to be newName.
```text
public void RenameLayerState(
    string name, 
    string newName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input existing layer state name |
| string newName | Input new layer state name |

### RestoreLayerState

#### Description
Restores the layer state name and the VPLAYER settings for the viewport specified. Also restores attributes specified in clientMask.
```text
public void RestoreLayerState(
    string name, 
    ObjectId id, 
    int undefinedLayerStatePolicy, 
    LayerStateMasks clientMask
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input name of layer state to make current |
| ObjectId id | Input object ID of the viewport whose VPLAYER setting is to be updated with the viewport data stored |
| int undefinedLayerStatePolicy | Input value that indicates whether to handle undefined layers |
| LayerStateMasks clientMask | Input layer attribute mask |

### SaveLayerState

#### Description
Saves the current state of the layer table to the layer state specified by name. This function also captures the VPLAYER settings for the viewport specified. Specify Null for the id argument to capture a layer state without VPLAYER settings.
```text
public void SaveLayerState(
    string name, 
    LayerStateMasks mask, 
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input name of layer state to save |
| LayerStateMasks mask | Input mask to apply to layer state |
| ObjectId id | Input object ID of the viewport whose VPLAYER setting is to be captured |

### SetLayerStateDescription

#### Description
Sets an arbitrary description string on the layer state.
```text
public void SetLayerStateDescription(
    string name, 
    string description
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input layer state whose description is to be updated |
| string description | Input description string up to 255 characters |

### SetLayerStateMask

#### Description
Updates the mask used when restoring a layer state.
```text
public void SetLayerStateMask(
    string name, 
    LayerStateMasks mask
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input name of layer state to mask |
| LayerStateMasks mask | Input mask to apply to layer state |

### LastRestoredLayerState

#### Description
Accesses the last layer state which was restored.
```text
public string LastRestoredLayerState;
```

#### Conditions
Read-only