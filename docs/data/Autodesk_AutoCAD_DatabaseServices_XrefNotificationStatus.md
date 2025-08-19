# Autodesk.AutoCAD.DatabaseServices.XrefNotificationStatus Enumeration

## Overview

#### Description
This .NET class wraps the [AcDb::XrefNotificationStatus](AcDb__XrefNotificationStatus.md) ObjectARX class. 
XrefNotificationStatus defines statuses for xref resolution notifications. 
```text
public enum XrefNotificationStatus {
  None,
  ResolvedMatch,
  ResolvedElsewhere,
  ResolvedWithUpdate,
  ResolvedUpdateAvailable
}
```

#### Members
| Members | Description |
| --- | --- |
| None | Indicates no information available for xref notifications. This is the default status. |
| ResolvedMatch | Indicates an xref was resolved with a drawing as specified by the block table record. |
| ResolvedElsewhere | Indicates an xref was resolved with a drawing from a different location than the one specified by the block table record. |
| ResolvedWithUpdate | Indicates an xref was resolved with a drawing that has been updated since the last time the reference drawing was saved. |
| ResolvedUpdateAvailable | Indicates an xref has been resolved, but the file has been updated since was resolved and it should be reloaded. |