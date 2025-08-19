# DictionaryWithDefaultDictionary Class

## Overview

#### Description
This .NET class wraps the AcDbDictionaryWithDefault ObjectARX class. 
This class enhances the Dictionary class by adding the concept of a 'default' entry. Each DictionaryWithDefault has an HardPointerId data member that is used to store the object ID of one of its entries. This hard pointer ID is used as the default entry. Get and set methods are provided for accessing this hard pointer.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.DBDictionary
        Autodesk.AutoCAD.DatabaseServices.DictionaryWithDefaultDictionary
```

```text
public class DictionaryWithDefaultDictionary : DBDictionary;
```

#### See Also
ObjectId

## Members

### Constructors

- [DictionaryWithDefaultDictionary](#dictionarywithdefaultdictionary)

### Properties

- [DefaultId](#defaultid)
- [ObjectBirthVersion](#objectbirthversion)


## Constructors Details

### DictionaryWithDefaultDictionary

#### Description
Default constructor.
```text
public DictionaryWithDefaultDictionary();
```

### DefaultId

#### Description
Accesses the object ID that is the default entry for the dictionary.
```text
public ObjectId DefaultId;
```

#### Conditions
Read / Write
### ObjectBirthVersion

#### Description
Accesses the DwgVersion and MaintenanceReleaseVersion in effect when the DictionaryWithDefault object's class was first introduced.
```text
public override FullDwgVersion ObjectBirthVersion;
```

#### Conditions
Read-only