# Autodesk.AutoCAD.DatabaseServices.ParseOption Enumeration

## Overview

#### Description
This .NET class wraps the [AcValue::ParseOption](AcValue__ParseOption.md) ObjectARX enum. 
This enumeration describes the parsing options for the value.
```text
public enum ParseOption {
  ParseOptionNone,
  SetDefaultFormat,
  PreserveMtextFormat
}
```

#### Members
| Members | Description |
| --- | --- |
| ParseOptionNone | Use default parsing. |
| SetDefaultFormat | Assign default format based on the data type of the parsed value. |
| PreserveMtextFormat | Preserve MText format in the current format string if the text to be parsed does not have MText format. If the text has MText format then it will override the MText format in the current format string. |