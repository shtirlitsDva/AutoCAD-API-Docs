# Autodesk.AutoCAD.DatabaseServices.TableEnumeratorOption Enumeration

## Overview

#### Description
This .NET class wraps the AcDb::TableIteratorOption ObjectARX class. It gives the table iterator options.
```text
public enum TableEnumeratorOption {
  IterateColumns = 4,
  IterateRows = 2,
  IterateSelection = 1,
  None = 0,
  SkipMerged = 0x40,
  SkipReadOnlyContent = 0x10,
  SkipReadOnlyFormat = 0x20
}
```

#### Members

| Members | Description |
| --- | --- |
| IterateColumns = 4 | Iterate columns. |
| IterateRows = 2 | Iterate rows. |
| IterateSelection = 1 | Iterate only selected cells. Applicable only for Table object. |
| None = 0 | None. |
| SkipMerged = 0x40 | Skip cells hidden due to merges. This will skip all cells in merge range except the top-left cell. |
| SkipReadOnlyContent = 0x10 | Skip cells with read-only content. |
| SkipReadOnlyFormat = 0x20 | Skip cells with read-only format. |