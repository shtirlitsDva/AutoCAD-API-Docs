# LinkedData Class

## Overview

#### Description
This .NET class wraps the AcDbLinkedData ObjectARX class. 
This class is used to support data linking.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.LinkedData
        Autodesk.AutoCAD.DatabaseServices.LinkedTableData
```

```text
public abstract class LinkedData : DBObject;
```

### Methods

- [Clear](#clear)

### Properties

- [IsEmpty](#isempty)
- [Name](#name)


## Methods Details

### Clear

#### Description
Deletes the data. This should be implemented by the derived classes and the implementation should delete the current contents. Base class implementation does nothing.
```text
public virtual void Clear();
```

### IsEmpty

#### Description
Assesses whether the object has data or not. This should be implemented by the derived classes and the implementation should return true if the object is currently empty (i.e. it does not have any data).
```text
public virtual bool IsEmpty;
```

#### Conditions
Read-only
### Name

#### Description
Accesses the name of the data. The name can be blank string if there is no name set.
```text
public virtual string Name;
```

#### Conditions
Read / Write