# SequenceEnd Class

## Overview

#### Description
This .NET class wraps the AcDbSequenceEnd ObjectARX class. 
The SequenceEnd class represents the SEQEND entity within AutoCAD. Objects of this class are created and handled automatically by AutoCAD for each complex entity that requires them, such as BlockReference, AcDb2dPolyline, 3dPolyline, etc. 
Applications do not need to create objects of this class, nor do they need to add or remove them from databases. Applications are free to add or manipulate xdata on objects of this class, as well as work with extension dictionaries for objects of this class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.SequenceEnd
```

```text
public sealed class SequenceEnd : Entity;
```

#### Notes
Do not derive from this class. Attempting to do so will cause your application to halt AutoCAD.

## Members

### Constructors

- [SequenceEnd](#sequenceend)


## Constructors Details

### SequenceEnd

#### Description
Constructor.
```text
public SequenceEnd();
```

#### Conditions
Read / Write