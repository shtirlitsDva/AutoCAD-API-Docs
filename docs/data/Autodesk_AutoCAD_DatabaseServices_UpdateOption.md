# Autodesk.AutoCAD.DatabaseServices.UpdateOption Enumeration

## Overview

#### Description
This .NET enum wraps [AcDb::UpdateOption](AcDb__UpdateOption.md) ObjectARX enum. It gives the options for updating adapters.
```text
public enum UpdateOption {
  AllowSourceUpdate = 0x100000,
  ForceFullSourceUpdate = 0x200000,
  ForPreview = 0x1000000,
  IncludeXrefs = 0x2000000,
  None = 0,
  OverwriteContentModifiedAfterUpdate = 0x400000,
  OverwriteFormatModifiedAfterUpdate = 0x800000,
  SkipFormat = 0x20000,
  UpdateColumnWidth = 0x80000,
  UpdateRowHeight = 0x40000
}
```

#### Members

| Members | Description |
| --- | --- |
| AllowSourceUpdate = 0x100000 | Support writing to source from data. |
| ForceFullSourceUpdate = 0x200000 | While writing to the source, write everything. If this is not set, only modified data is written to source. This option is valid only while updating source from data (i.e. update direction is .UpdateDirDataToSource) |
| ForPreview = 0x1000000 | Update is for showing preview in preview window. |
| IncludeXrefs = 0x2000000 | Update data links within xrefs. Used only by Database.updateDataLink. |
| None = 0 | No update options. |
| OverwriteContentModifiedAfterUpdate = 0x400000 | Overwrites all the content changes done to the linked data since the data was updated from source last time. This option is valid only while updating data from source (i.e. update direction is .UpdateDirSourceToData) |
| OverwriteFormatModifiedAfterUpdate = 0x800000 | Overwrite all the format changes done to the linked data since the data was updated from source last time. This option is valid only while updating data from source (i.e. update direction is .UpdateDirSourceToData) |
| SkipFormat = 0x20000 | Skip the cell format and update only content. |
| UpdateColumnWidth = 0x80000 | Update the column width of linked cells to match the source. |
| UpdateRowHeight = 0x40000 | Update the row height of linked cells to match the source. |