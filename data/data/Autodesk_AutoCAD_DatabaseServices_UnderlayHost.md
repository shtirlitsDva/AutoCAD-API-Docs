# UnderlayHost Class

## Overview

#### Description
This .NET class wraps the AcDbUnderlayHost ObjectARX class. 
This interface is implemented by host applications that wish to support underlays. UnderlayDefinition and AcDbUnderlayReference objects use this interface to accomplish their mission.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.UnderlayHost
```

```text
public sealed class UnderlayHost;
```

### Methods

- [GetFile](#getfile)

### Properties

- [DgnDocHost](#dgndochost)
- [DgnHost](#dgnhost)
- [DwfHost](#dwfhost)
- [PdfHost](#pdfhost)


## Methods Details

### GetFile

#### Description
Gets an underlay file. If password is set to null but is required by the drawing, this function will prompt the user for a password.
```text
public UnderlayFile GetFile(
    string path, 
    string password
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string path | Input fully qualified path to the file to open |
| string password | Input optional password |

### DgnDocHost

#### Description
Returns the current DGN underlay host that uses the current document for OLE entities.
```text
public static UnderlayHost DgnDocHost;
```

#### Conditions
Read-only
### DgnHost

#### Description
Reserved for future use.
```text
public static UnderlayHost DgnHost;
```

#### Conditions
Read-only
### DwfHost

#### Description
Returns the current DWF underlay host.
```text
public static UnderlayHost DwfHost;
```

#### Conditions
Read-only
### PdfHost

#### Description
Accesses the current UnderlayHost for managing PDF underlays. 
PdfHost manages access to PDF files referenced by PDF underlays.
```text
public static UnderlayHost PdfHost;
```

#### Conditions
Read-only