# MInsertBlock Class

## Overview

#### Description
This .NET class wraps the AcDbMInsertBlock ObjectARX class. 
The MInsertBlock class represents a special form of the INSERT entity in which an array of duplicate images of the entities within the referenced BlockTableRecord is displayed. 
Creating an MInsertBlock with a definition of rows = 1 and columns = 1 will create a BlockReference instead.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.BlockReference
            Autodesk.AutoCAD.DatabaseServices.MInsertBlock
```

```text
public class MInsertBlock : BlockReference;
```

#### Notes
The number of rows and columns of images to display can be set, as is the spacing between the rows and columns. 
Do not derive from this class. Attempting to do so will cause your application to halt AutoCAD.
#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), BlockTableRecord

## Members

### Constructors

- [MInsertBlock()](#minsertblock())

### Properties

- [Columns](#columns)
- [ColumnSpacing](#columnspacing)
- [Rows](#rows)
- [RowSpacing](#rowspacing)


## Constructors Details

### MInsertBlock()

#### Description
Default constructor. Initializes the number of rows and columns to 0 and the row and column spacing to 0.0. In addition, the default constructor initialization for the BlockReference parent class takes place.
```text
public MInsertBlock();
public MInsertBlock(
    Point3d position, 
    ObjectId blockTableRecord, 
    short columns, 
    short rows, 
    double colSpacing, 
    double rowSpacing
);
```

### Columns

#### Description
Accesses the number of columns of the BlockTableRecord image that will be displayed by the MInsertBlock object.
```text
public short Columns;
```

#### Conditions
Read / Write
### ColumnSpacing

#### Description
Accesses the spacing between the columns of the BlockTableRecord image that will be displayed by the MInsert object.
```text
public double ColumnSpacing;
```

#### Conditions
Read / Write
### Rows

#### Description
Accesses the number of rows of the BlockTableRecord image that will be displayed by the MInsertBlock object.
```text
public short Rows;
```

#### Conditions
Read / Write
### RowSpacing

#### Description
Accesses the spacing between the rows of the BlockTableRecord image that will be displayed by the MInsert object.
```text
public double RowSpacing;
```

#### Conditions
Read / Write