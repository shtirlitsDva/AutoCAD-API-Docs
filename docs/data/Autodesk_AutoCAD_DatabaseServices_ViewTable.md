# ViewTable Class

## Overview

#### Description
This .NET class wraps the AcDbViewTable ObjectARX class. 
ViewTable is the symbol table for ViewTableRecords, which represent stored views within the drawing database. Within AutoCAD and DXF files this table is known as the "VIEW" table.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTable
        Autodesk.AutoCAD.DatabaseServices.ViewTable
```

```text
public sealed class ViewTable : SymbolTable;
```

#### Conditions
Read / Write