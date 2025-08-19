# Autodesk.AutoCAD.EditorInput.PromptStatus Enumeration

## Overview

#### Description
This .NET class wraps the Acad::PromptStatus ObjectARX class. 
These values are similar to the RT return status values defined in adscodes.h. In fact, these values can be directly interchanged with acedGetXxxx() function return statuses, except for eDirect as noted below.
```text
public enum PromptStatus {
  Cancel = -5002,
  Error = -5001,
  Keyword = -5005,
  Modeless = 0x13a3,
  None = 0x1388,
  OK = 0x13ec,
  Other = 0x13a4
}
```

#### Members
| Members | Description |
| --- | --- |
| Cancel = -5002 | User canceled the request with a CTRL-C. |
| Error = -5001 | Nonspecific error. |
| Keyword = -5005 | Keyword returned from a "get" routine. |
| Modeless = 0x13a3 | Modeless prompt status. |
| None = 0x1388 | No result. |
| OK = 0x13ec | User clicks OK to accept the prompt status dialog. |
| Other = 0x13a4 | Prompt status other than the default list. |