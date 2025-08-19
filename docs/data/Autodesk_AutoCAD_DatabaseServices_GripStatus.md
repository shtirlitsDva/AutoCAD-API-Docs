# Autodesk.AutoCAD.DatabaseServices.GripStatus Enumeration

## Overview

#### Description
This .NET class wraps the AcDb::GripStat ObjectARX enum. 
This enumeration provides status values concerning a grip operation.
```text
public enum GripStatus {
  GripsDone,
  GripsToBeDeleted,
  DimDataToBeDeleted
}
```

#### Members

| Members | Description |
| --- | --- |
| GripsDone | The entity's grips have been deleted in the host application and the entity is no longer involved in any grip edit operations |
| GripsToBeDeleted | The entity's grips are about to be deleted in the host application |
| DimDataToBeDeleted | The application should delete any application data associated with the DynamicDimensionData object being deleted by AutoCAD |