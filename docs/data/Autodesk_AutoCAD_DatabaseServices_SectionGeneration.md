# Autodesk.AutoCAD.DatabaseServices.SectionGeneration Enumeration

## Overview

#### Description
This .NET class wraps the [AcDbSectionSettings::Generation](AcDbSectionSettings__Generation.md) ObjectARX enum. 
Generation flags to control section creation. There are two groups of flags: source of section to generate and destination. One value from each group should be OR'd to set the generation options. SourceAllObjects and SourceSelectedObjects form the second group to specify the source. DestinationNewBlock, DestinationReplaceBlock, and DestinationFile form the third group to specify destination for the generated geometry.
```text
public enum SectionGeneration {
  DestinationFile = 0x40,
  DestinationNewBlock = 0x10,
  DestinationReplaceBlock = 0x20,
  SourceAllObjects = 1,
  SourceSelectedObjects = 2
}
```

#### Members
| Members | Description |
| --- | --- |
| DestinationFile = 0x40 | Saves the generated section in an external file. |
| DestinationNewBlock = 0x10 | Creates section as a new block |
| DestinationReplaceBlock = 0x20 | Replaces an existing block while creating section |
| SourceAllObjects = 1 | The section plane cuts all the objects found in the drawing |
| SourceSelectedObjects = 2 | The section plane cuts only the selected objects |