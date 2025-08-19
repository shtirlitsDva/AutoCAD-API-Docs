# Autodesk.AutoCAD.DatabaseServices.AuditPass Enumeration

## Overview

#### Description
This .NET class wraps the AcDbAuditInfo::AuditPass ObjectARX enumeration, which keeps track of which pass the command is on.
```text
public enum AuditPass {
  Pass1 = 1,
  Pass2 = 2
}
```

#### Members

| Members | Description |
| --- | --- |
| Pass1 = 1 | PASS1 is when class members should be validating their own data fields and avoiding the validation of other objects, even their existence. |
| Pass2 = 2 | PASS2 is when audit members should be verifying the existence of related objects and of inter-object links. This is the time to recreate missing objects, redirect references, or whatever can be done to repair an object. |