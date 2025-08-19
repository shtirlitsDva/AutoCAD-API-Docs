# SymbolTableRecord Class

## Overview

#### Description
This .NET class wraps the AcDbSymbolTableRecord ObjectARX class. This is the base class for each type of record corresponding to the various symbol tables.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTableRecord
        Autodesk.AutoCAD.DatabaseServices.AbstractViewTableRecord
        Autodesk.AutoCAD.DatabaseServices.BlockTableRecord
        Autodesk.AutoCAD.DatabaseServices.DimStyleTableRecord
        Autodesk.AutoCAD.DatabaseServices.LayerTableRecord
        Autodesk.AutoCAD.DatabaseServices.LinetypeTableRecord
        Autodesk.AutoCAD.DatabaseServices.RegAppTableRecord
        Autodesk.AutoCAD.DatabaseServices.TextStyleTableRecord
        Autodesk.AutoCAD.DatabaseServices.UcsTableRecord
```

```text
public abstract class SymbolTableRecord : DBObject;
```

### Properties

- [IsDependent](#isdependent)
- [IsResolved](#isresolved)
- [Name](#name)


## Properties Details

### IsDependent

#### Description
Returns true when the SymbolTableRecord is a dependent (that is, part of) of an attached xref drawing; otherwise false is returned.
```text
public bool IsDependent;
```

#### Conditions
Read-only
### IsResolved

#### Description
Returns true if the SymbolTableRecord is part of an xref which has been successfully "resolved" (loaded into the drawing). If the record is not part of an xref, or it is part of an xref but the xref has not been successfully resolved, then false is returned. The SymbolTableRecord.IsDependent property can be used to determine if the record is part of an xref. 
```text
public bool IsResolved;
```

#### Conditions
Read-only
### Name

#### Description
Returns the name of the symbol table record. 
The SymbolTableRecord name string is used for DXF group code 2.
```text
public string Name;
```

#### Conditions
Read / Write