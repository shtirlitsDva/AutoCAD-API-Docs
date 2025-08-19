# PlaceHolder Class

## Overview

#### Description
This .NET class wraps the AcDbPlaceHolder ObjectARX class. 
This class provides a way to instantiate what is essentially just an DBObject. This class has no data members of its own, nor does it implement any new methods. Its sole intent is to provide objects that can be added to dictionaries so that the dictionary lookup key strings can be associated with object IDs. 
Objects of this class are used in the Plot Style Name Dictionary.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.PlaceHolder
```

```text
public sealed class PlaceHolder : DBObject;
```

## Members

### Constructors

- [PlaceHolder](#placeholder)


## Constructors Details

### PlaceHolder

#### Description
Default constructor.
```text
public PlaceHolder();
```

#### Conditions
Read-only