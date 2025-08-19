# DimStyleTable Class

## Overview

#### Description
This .NET class wraps the AcDbDimStyleTable ObjectARX class. 
It is the symbol table for DimStyleTableRecords, which represents dimension styles within the drawing database.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTable
        Autodesk.AutoCAD.DatabaseServices.DimStyleTable
```

```text
public sealed class DimStyleTable : SymbolTable, IEnumerable;
```

#### Notes
For dimensioning, it is often desirable to have a set of similar styles that are essentially variations on a theme, with each style intended for a different dimension type (that is, angular, linear, radial, and so on). Such a group of styles is known as an DimStyle family.
#### See Also
DBObject