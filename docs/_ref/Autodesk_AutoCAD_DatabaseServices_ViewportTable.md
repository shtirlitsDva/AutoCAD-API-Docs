# ViewportTable Class

## Overview

#### Description
This .NET class wraps the AcDbViewportTable ObjectARX class. 
ViewportTable is the symbol table for ViewportTableRecords, which represent viewport configurations within AutoCAD when the system variable TILEMODE == 1. Within AutoCAD and DXF files this symbol table is known as the "VPORT" table.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTable
        Autodesk.AutoCAD.DatabaseServices.ViewportTable
```

```text
public sealed class ViewportTable : SymbolTable, IEnumerable;
```