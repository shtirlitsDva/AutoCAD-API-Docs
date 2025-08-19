# SymbolTable Class

## Overview

#### Description
This .NET class wraps the AcDbSymbolTable ObjectARX class. 
SymbolTable is the base class for all of the classes used to export AutoCAD's built-in symbol tables. 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTable
        Autodesk.AutoCAD.DatabaseServices.AbstractViewTable
        Autodesk.AutoCAD.DatabaseServices.BlockTable
        Autodesk.AutoCAD.DatabaseServices.DimStyleTable
        Autodesk.AutoCAD.DatabaseServices.LayerTable
        Autodesk.AutoCAD.DatabaseServices.LinetypeTable
        Autodesk.AutoCAD.DatabaseServices.RegAppTable
        Autodesk.AutoCAD.DatabaseServices.TextStyleTable
        Autodesk.AutoCAD.DatabaseServices.UcsTable
        Autodesk.AutoCAD.DatabaseServices.ViewportTable
        Autodesk.AutoCAD.DatabaseServices.ViewTable
```

```text
public abstract class SymbolTable : DBObject, IEnumerable;
```

### Methods

- [Add](#add)
- [GetEnumerator](#getenumerator)
- [Has(ObjectId)](#has(objectid))
- [Has(string)](#has(string))

### Properties

- [IncludingErased](#includingerased)


## Methods Details

### Add

#### Description
This function adds the record ID value to both the database containing the table and the table itself
```text
public ObjectId Add(
    [CallerMustClose] SymbolTableRecord value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [CallerMustClose] SymbolTableRecord value | Input record to add to the table |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public virtual SymbolTableEnumerator GetEnumerator();
```

### Has(ObjectId)

#### Description
This function returns true if the table contains a record with an ObjectId that matches id. Otherwise it returns false.
```text
public bool Has(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input object ID of record to search for |

### Has(string)

#### Description
This function returns true if the table contains a record with a name that matches key. If no matches are found, then false is returned.
```text
public bool Has(
    string key
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string key | Input name of record to search for |

### IncludingErased

#### Description
Returns erased SymbolTable entries in addition to any entries already present.
```text
public SymbolTable IncludingErased;
```

#### Conditions
Read-only