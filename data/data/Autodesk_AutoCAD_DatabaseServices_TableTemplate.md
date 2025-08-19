# TableTemplate Class

## Overview

#### Description
This .NET class wraps the AcDbTableTemplate ObjectARX class. 
This class is used to capture, store, and manage templates of AutoCAD tables.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.LinkedData
        Autodesk.AutoCAD.DatabaseServices.LinkedTableData
            Autodesk.AutoCAD.DatabaseServices.FormattedTableData
                Autodesk.AutoCAD.DatabaseServices.TableContent
                    Autodesk.AutoCAD.DatabaseServices.TableTemplate
```

```text
public class TableTemplate : TableContent;
```

### Constructors

- [TableTemplate](#tabletemplate)

### Methods

- [Capture](#capture)
- [CreateTable](#createtable)


## Constructors Details

### TableTemplate

#### Description
Copy constructor.
```text
public TableTemplate(
    Table table, 
    TableCopyOptions copyOption
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Table table | Input table from which to capture the template. |
| TableCopyOptions copyOption | Input copy option specifying what to capture while capturing the template. |

### Capture

#### Description
Captures table template.
```text
public void Capture(
    Table table, 
    TableCopyOptions copyOption
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Table table | Input table from which to capture the template. |
| TableCopyOptions copyOption | Input what to capture while capturing the template. |

### CreateTable

#### Description
Creates a table template.
```text
public Table CreateTable(
    TableCopyOptions copyOption
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| TableCopyOptions copyOption | Input Autodesk.AutoCAD.DatabaseServices.TableCopyOptions object specifying what to capture while capturing the template. |
