# Autodesk.AutoCAD.DatabaseServices.UpdateDirection Enumeration

## Overview

#### Description
This .NET enum wraps [AcDb::UpdateDirection](AcDb__UpdateDirection.md) ObjectARX enum. It gives the enumerations for updating the data source and target data.
```text
public enum UpdateDirection {
  DataToSource = 2,
  SourceToData = 1
}
```

#### Members

| Members | Description |
| --- | --- |
| DataToSource = 2 | Update data source using the target data in AutoCAD object. |
| SourceToData = 1 | Update target data in AutoCAD object from data source. |