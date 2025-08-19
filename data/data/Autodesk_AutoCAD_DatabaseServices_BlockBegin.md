# BlockBegin Class

## Overview

#### Description
This .NET class wraps the AcDbBlockBegin ObjectARX class. 
The BlockBegin class represents the block header portion of a block definition within AutoCAD (that is, group codes 2, 3, 10, 20, 30, and 70). Objects of this class are created and handled automatically by AutoCAD for each BlockTableRecord. 
Applications do not need to create objects of this class nor can they add or remove them from databases. Applications are free to add or manipulate xdata on objects of this class as well as work with extension dictionaries for objects of this class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.BlockBegin
```

```text
public sealed class BlockBegin : Entity;
```

#### Notes
**Warning** : Do not derive from this class. Attempting to do so will cause your application to halt AutoCAD.
#### See Also
SequenceEnd, BlockEnd, DBObject

## Members

### Constructors

- [BlockBegin](#blockbegin)


## Constructors Details

### BlockBegin

#### Description
Default constructor.
```text
public BlockBegin();
```
