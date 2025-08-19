# Autodesk.AutoCAD.DatabaseServices.RowType Enumeration

## Overview

#### Description
This .NET enum wraps the [AcDb::RowType](AcDb__RowType.md) ObjectARX enum. This value represents all row types for a table.
```text
public enum RowType {
  DataRow = 1,
  HeaderRow = 4,
  TitleRow = 2,
  UnknownRow = 0
}
```

#### Members

| Members | Description |
| --- | --- |
| DataRow = 1 | Indicates a row that is neither title row nor header row. |
| HeaderRow = 4 | Indicates the row immediately following the title row. |
| TitleRow = 2 | Indicates the top-most or bottom-most row in a table, depending on the whether the table flow direction is down or up. |
| UnknownRow = 0 | Indicates the uninitialized row type. |