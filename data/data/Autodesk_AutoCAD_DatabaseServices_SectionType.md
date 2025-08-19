# Autodesk.AutoCAD.DatabaseServices.SectionType Enumeration

## Overview

#### Description
This .NET enum wraps the AcDbSectionSettings::SectionType ObjectARX enum. 
It gives options for section generation. This enum is used to get and set properties for generated section geometry.
```text
public enum SectionType {
  LiveSection = 1,
  Section2d = 2,
  Section3d = 4
}
```

#### Members
| Members | Description |
| --- | --- |
| LiveSection = 1 | Live sectioning. |
| Section2d = 2 | 2d section. |
| Section3d = 4 | 3d section. |