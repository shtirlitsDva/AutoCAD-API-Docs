# Autodesk.AutoCAD.DatabaseServices.BlockScaling Enumeration

## Overview

#### Description
This .NET class wraps the AcDbBlockTableRecord::BlockScaling ObjectARX enumeration. 
It is an enum whose values control whether block references associated with this block table record can be uniformly or non-uniformly scaled.
```text
public enum BlockScaling {
  Any,
  Uniform
}
```

#### Members

| Members | Description |
| --- | --- |
| Any | Block references associated with this block table record can be non-uniformly scaled. |
| Uniform | Block references associated with this block table record can only be uniformly scaled. |