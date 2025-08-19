# Autodesk.AutoCAD.DatabaseServices.IndexCreation Enumeration

## Overview

#### Description
This .NET enum wraps the AcDb::IndexCreation ObjectARX enumeration. 
This enum supports the INDEXCTL header variable. Fields are bit-coded and can be OR'd together using a bitwise OR.
```text
public enum IndexCreation {
  NoIndex,
  IndexByLayer,
  IndexSpatially
}
```

#### Members

| Members | Description |
| --- | --- |
| NoIndex | No layer or spatial indexes are created |
| IndexByLayer | Indexing by Layer is enabled |
| IndexSpatially | Spatial indexing is enabled |