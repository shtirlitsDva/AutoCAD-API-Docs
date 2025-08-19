# Autodesk.AutoCAD.DatabaseServices.TableCopyOptions Enumeration

## Overview

#### Description
This .NET enum wraps [AcDb::TableCopyOption](AcDb__TableCopyOption.md) ObjectARX enum. It gives the table copy options.
```text
public enum TableCopyOptions {
  ConvertFormatToOverrides = 0x800,
  ExpandOrContractTable = 1,
  FillTarget = 0x20000,
  None = 0,
  OnlyContentModifiedAfterUpdate = 0x400000,
  OnlyFormatModifiedAfterUpdate = 0x800000,
  OverwriteContentModifiedAfterUpdate = 0x100000,
  OverwriteFormatModifiedAfterUpdate = 0x200000,
  OverwriteReadOnlyContent = 0x40000,
  OverwriteReadOnlyFormat = 0x80000,
  SkipBlock = 0x20,
  SkipCellState = 0x1000,
  SkipCellStyle = 0x400,
  SkipContent = 2,
  SkipContentFormat = 0x2000,
  SkipDataCell = 0x100,
  SkipDataLink = 0x40,
  SkipDissimilarContentFormat = 0x4000,
  SkipField = 8,
  SkipFormat = 0x200,
  SkipFormula = 0x10,
  SkipGeometry = 0x8000,
  SkipLabelCell = 0x80,
  SkipMerges = 0x10000,
  SkipValue = 4,
  TableCopyColumnWidth = 0x2000000,
  TableCopyRowHeight = 0x1000000
}
```

#### Members

| Members | Description |
| --- | --- |
| ConvertFormatToOverrides = 0x800 | Convert formats to overrides after copying. |
| ExpandOrContractTable = 1 | Create new rows and columns if the source range does not fit the target range. Delete empty rows and columns if target range is larger than source range. |
| FillTarget = 0x20000 | Fills the target range by repeatedly copying the source range. |
| None = 0 | None. |
| OnlyContentModifiedAfterUpdate = 0x400000 | If target cell has content changes since last update, return only that. |
| OnlyFormatModifiedAfterUpdate = 0x800000 | If target cell has format changes since last update, return only that. |
| OverwriteContentModifiedAfterUpdate = 0x100000 | If target cell has content changes since last update, overwrite. This option is applicable only for linked cells. |
| OverwriteFormatModifiedAfterUpdate = 0x200000 | If target cell has format changes since last update, overwrite. This option is applicable only for linked cells. |
| OverwriteReadOnlyContent = 0x40000 | If target cell has read-only content, overwrite. |
| OverwriteReadOnlyFormat = 0x80000 | If target cell has read-only format, overwrite. |
| SkipBlock = 0x20 | Don't copy content if it is block. |
| SkipCellState = 0x1000 | Don't copy the cell state. |
| SkipCellStyle = 0x400 | Don't copy cell style. |
| SkipContent = 2 | Don't copy the content. |
| SkipContentFormat = 0x2000 | Don't copy content format. Ignored if TableCopySkipFormat is set. |
| SkipDataCell = 0x100 | Don't copy content if it is data cell. |
| SkipDataLink = 0x40 | Don't copy data links. |
| SkipDissimilarContentFormat = 0x4000 | Don't copy content format if content types are not same. Ignored if TableCopySkipFormat or TableCopySkipContentFormat is set. |
| SkipField = 8 | Don't copy content if it is field. |
| SkipFormat = 0x200 | Don't copy format. |
| SkipFormula = 0x10 | Don't copy if it is a formula. |
| SkipGeometry = 0x8000 | Don't copy geometric information like row height, column width, etc. |
| SkipLabelCell = 0x80 | Don't copy content if it is label cell. |
| SkipMerges = 0x10000 | Don't copy cell merges. |
| SkipValue = 4 | Don't copy content if it is value. |
| TableCopyColumnWidth = 0x2000000 | Copy column width while copying cells. Applicable only when cells are copied. Ignored if TableCopySkipGeometry is set or when whole table is copied. |
| TableCopyRowHeight = 0x1000000 | Copy row height while copying cells. Applicable only when cells are copied. Ignored if TableCopySkipGeometry is set or when whole table is copied. |