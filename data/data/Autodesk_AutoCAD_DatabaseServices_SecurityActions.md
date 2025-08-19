# Autodesk.AutoCAD.DatabaseServices.SecurityActions Enumeration

## Overview

#### Description
This enumeration encapsulates a corresponding ObjectARX enum that is used by the SecurityParams ObjectARX struct. SecurityParams stores information for security operations requested during DWG file I/O.
```text
public enum SecurityActions {
  AddTimeStamp = 0x20,
  EncryptData = 1,
  EncryptProperties = 2,
  SignData = 0x10
}
```

#### Members
| Members | Description |
| --- | --- |
| AddTimeStamp = 0x20 | Adds a time stamp key.The AutoCAD installation program creates a unique time stamp key in the system registry immediately below the release number key (as well as adding the same installation ID to the executable itself). This key ensures that different versions of AutoCAD from the same release will be able to populate their own sections of the system registry. Within this key, values are stored for attributes such as the location of AutoCAD files and the language version. |
| EncryptData = 1 | Encrypted DWG and DXF data. |
| EncryptProperties = 2 | Encrypted DWG and DXF properties. |
| SignData = 0x10 | Signature data. |