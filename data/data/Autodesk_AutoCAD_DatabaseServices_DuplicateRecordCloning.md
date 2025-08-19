# Autodesk.AutoCAD.DatabaseServices.DuplicateRecordCloning Enumeration

## Overview

#### Description
This .NET class wraps the DuplicateRecordCloning ObjectARX enum.
```text
public enum DuplicateRecordCloning {
  NotApplicable,
  Ignore,
  Replace,
  RefMangleName,
  MangleName,
  UnmangleName
}
```

#### Members
| Members | Description |
| --- | --- |
| NotApplicable |
| Ignore | If a duplicate is found, ignore the clone, and continue to use the existing record in the destination database. This is how the INSERT command and Database.insert() operate. |
| Replace | If a duplicate is found, replace it with the cloned record. |
| RefMangleName | Mangle all the incoming record names using $0$ |
| MangleName | Mangle all the incoming record names using $0$ |
| UnmangleName | Primarily used by RefEdit when it checks records back into the origin database. Any mangling done by MangleName is undone, and then it defaults to Ignore. In other words, if a duplicate is found after the mangling is removed, AutoCAD continues to use the existing record, and ignores the cloned one. |