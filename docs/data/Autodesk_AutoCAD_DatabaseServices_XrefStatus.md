# Autodesk.AutoCAD.DatabaseServices.XrefStatus Enumeration

## Overview

#### Description
This .NET enum wraps the [AcDb::XrefStatus](AcDb__XrefStatus.md) ObjectARX enum.
```text
public enum XrefStatus {
  NotAnXref,
  Resolved,
  Unloaded,
  Unreferenced,
  FileNotFound,
  Unresolved
}
```

#### Members

| Members | Description |
| --- | --- |
| NotAnXref | File detected is not an Xref. |
| Resolved | Xref resolved as specified by the block table record. |
| Unloaded | Xref unloaded from block table record. |
| Unreferenced | Xref unreferenced. Unreferenced anonymous blocks are purged from the BLOCK table whenever AutoCAD opens a new drawing. |
| FileNotFound | Xrefed file not found. |
| Unresolved | Xref block table record unresolved. |