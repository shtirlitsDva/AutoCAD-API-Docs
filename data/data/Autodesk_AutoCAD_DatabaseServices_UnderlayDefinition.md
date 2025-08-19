# UnderlayDefinition Class

## Overview

#### Description
This .NET class wraps the AcDbUnderlayDefinition ObjectARX class. 
UnderlayDefinition is an abstract class that handles the linkage to external underlay content. Underlays are similar to raster images, except that users can snap to the content of an underlay. 
An UnderlayDefinition object is referenced by zero or more UnderlayReferences. The UnderlayReference class is responsible for the placement of content within the drawing, while the UnderlayDefinition class handles the linkage to the underlay content. Instances of UnderlayReference-derived concrete classes are inserted in a block table record. Instances of UnderlayDefinition-derived concrete classes are inserted into a dictionary within the named object dictionary.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.UnderlayDefinition
        Autodesk.AutoCAD.DatabaseServices.DgnDefinition
        Autodesk.AutoCAD.DatabaseServices.DwfDefinition
        Autodesk.AutoCAD.DatabaseServices.PdfDefinition
```

```text
public abstract class UnderlayDefinition : DBObject;
```

### Methods

- [GetDictionaryKey](#getdictionarykey)
- [Load](#load)
- [SetUnderlayItem](#setunderlayitem)
- [Unload](#unload)

### Properties

- [ActiveFileName](#activefilename)
- [ItemName](#itemname)
- [Loaded](#loaded)
- [SourceFileName](#sourcefilename)
- [UnderlayItem](#underlayitem)


## Methods Details

### GetDictionaryKey

#### Description
Returns the name of the dictionary that holds the UnderlayDefinition objects in the named objects dictionary.
```text
public static string GetDictionaryKey(
    System.Type underlayDefinitionType
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| System.Type underlayDefinitionType | Input the class descriptor of the underlay type for which to retrieve the dictionary name |

### Load

#### Description
Attempts to load the file returned by the [UnderlayDefinition.ActiveFileName](Autodesk_AutoCAD_DatabaseServices_UnderlayDefinition_ActiveFileName.md) property. If password is null but is necessary to open the file, this function will prompt the user.
```text
public void Load(
    string password
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string password | Input optional password |

### SetUnderlayItem

#### Description
Sets the name of the underlay item that this underlay should reference. Calls unload() to unload any previous underlay item. 
**Warning** The underlay definition takes ownership of the item. Therefore, it should not be deleted by the client. 
```text
public void SetUnderlayItem(
    string sourceFileName, 
    string activeFileName, 
    Autodesk.AutoCAD.DatabaseServices.UnderlayItem item
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string sourceFileName | Input source file path |
| string activeFileName | Input current or active file path |
| Autodesk.AutoCAD.DatabaseServices.UnderlayItem item | Input item to be referenced |

### Unload

#### Description
Unloads the underlay file. References will behave as if the file was never loaded.
```text
public void Unload();
```

### ActiveFileName

#### Description
Returns the name of the file that this underlay references. This name is always a full path.
```text
public string ActiveFileName;
```

#### Conditions
Read-only
### ItemName

#### Description
Returns a pointer to the internal data member that holds the name of the underlay item that this underlay currently references. 
**Warning** The returned string should not be modified or freed. Also, it may be invalidated if modifications are made to the underlay definition. 
```text
public string ItemName;
```

#### Conditions
Read / Write
### Loaded

#### Description
Returns a Boolean value indicating whether the underlay is currently loaded. 
Returns true if the underlay is loaded.
```text
public bool Loaded;
```

#### Conditions
Read-only
### SourceFileName

#### Description
Returns a pointer to the internal data member that holds the name of the file that this underlay references. This name is in the form (relative or full path) that the user specified. 
**Warning** The returned string should not be modified or freed. Also, it may be invalidated if modifications are made to the underlay definition. 
```text
public string SourceFileName;
```

#### Conditions
Read / Write
### UnderlayItem

#### Description
Returns a pointer to the internal data member that holds the underlay item that this underlay currently references. 
**Warning** The returned object should not be modified or freed. It may be invalidated if modifications are made to the underlay definition. 
```text
public Autodesk.AutoCAD.DatabaseServices.UnderlayItem UnderlayItem;
```

#### Conditions
Read-only