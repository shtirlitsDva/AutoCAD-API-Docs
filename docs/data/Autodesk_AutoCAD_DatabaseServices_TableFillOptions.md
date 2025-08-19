# Autodesk.AutoCAD.DatabaseServices.TableFillOptions Enumeration

## Overview

#### Description
This .NET enum wraps [AcDb::TableFillOption](AcDb__TableFillOption.md) ObjectARX enum. It gives the table fill options.
```text
public enum TableFillOptions {
  CopyContent = 8,
  CopyFormat = 0x10,
  GenerateSeries = 4,
  None = 0,
  OverwriteReadOnlyContent = 0x20,
  OverwriteReadOnlyFormat = 0x40,
  Reverse = 2,
  Row = 1
}
```

#### Members

| Members | Description |
| --- | --- |
| CopyContent = 8 | Fill with copy of source cells. |
| CopyFormat = 0x10 | Copy format from source cells to filled cells. |
| GenerateSeries = 4 | Fill with series derived from source cells. |
| None = 0 | None. |
| OverwriteReadOnlyContent = 0x20 | If the filled cells have read-only content, overwrite. |
| OverwriteReadOnlyFormat = 0x40 | If the filled cells have read-only format, overwrite. |
| Reverse = 2 | Fill in reverse direction. |
| Row = 1 | Fill along row by filling cells in row. |