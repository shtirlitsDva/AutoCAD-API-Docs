# Autodesk.AutoCAD.DatabaseServices.FieldCodeFlags Enumeration

## Overview

#### Description
This .NET class wraps the AcDbField::FieldCodeFlag ObjectARX enum. It represents the field code flags.
```text
public enum FieldCodeFlags {
  AddMarkers = 0x10,
  EscapeBackslash = 0x20,
  EvaluatedChildren = 4,
  EvaluatedText = 2,
  FieldCode = 1,
  ObjectReference = 8,
  PreserveFields = 0x80,
  StripOptions = 0x40,
  TextField = 0x100
}
```

#### Members

| Members | Description |
| --- | --- |
| AddMarkers = 0x10 | If this flag is set, the embedded fields in the text are enclosed using field markers %< and >%. This flag is not applicable when setting the field code, and will be ignored in that context. |
| EscapeBackslash = 0x20 | If this flag is set, all the backslashes are escaped using another backslash (in other words, single backslashes are converted to double backslashes) in the evaluated text. When getting the field code, this flag can be combined with EvaluatedText or EvaluatedChildren. |
| EvaluatedChildren = 4 | Gets the field code with evaluated text for children. This flag is combined with FieldCode. This flag is not applicable when setting the field code, and will be ignored in that context. |
| EvaluatedText = 2 | Gets the evaluated text. This flag is not applicable when setting the field code, and will be ignored in that context. |
| FieldCode = 1 | Gets the raw field code. This flag is not applicable when setting the field code, and will be ignored in that context. |
| ObjectReference = 8 | Gets the embedded fields in the text as references to child field objects stored in ChildFields argument. This flag is valid only for text fields and is used for editing. This flag is not applicable when setting the field code, and will be ignored in that context. |
| PreserveFields = 0x80 | For internal use only. This flag is not applicable when getting the field code, and will be ignored in that context. |
| StripOptions = 0x40 | If this flag is set, the standard options like evaluator ID, format, and hyperlink information are stripped from the field code. For example, if the field code is %<var Date f "m/d/y">%, it strips the standard options and returns only the field code %%. This flag can be combined with FieldCode or EvaluatedChildren. This flag is not applicable when setting the field code, and will be ignored in that context. |
| TextField = 0x100 | If this flag is set, the field code is treated as text with embedded fields. This flag is not applicable when getting the field code, and will be ignored in that context. |