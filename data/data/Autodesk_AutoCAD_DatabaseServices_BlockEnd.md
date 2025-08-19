# BlockEnd Class

## Overview

#### Description
This .NET class wraps the AcDbBlockEnd ObjectARX class. 
The BlockEnd class represents the ENDBLK object within AutoCAD. Objects of this class are created and handled automatically by AutoCAD for each BlockTableRecord. 
Applications do not need to create objects of this class nor can they add or remove them from databases. Applications are free to add or manipulate xdata on objects of this class, as well as work with extension dictionaries for objects of this class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.BlockEnd
```

```text
public sealed class BlockEnd : Entity;
```

#### Notes
**Warning** : Do not derive from this class. Attempting to do so will cause your application to halt AutoCAD.

## Members

### Constructors

- [BlockEnd](#blockend)


## Constructors Details

### BlockEnd

#### Description
Default constructor.
```text
public BlockEnd();
```
