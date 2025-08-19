# Autodesk.AutoCAD.DatabaseServices.MergeCellStyleOption Enumeration

## Overview

#### Description
This .NET class wraps the MergeCellStyleOption ObjectARX enum. 
It contains options for merging cell styles.
```text
public enum MergeCellStyleOption {
  ConvertDuplicatesToOverrrides = 4,
  CopyDuplicates = 1,
  IgnoreNewStyles = 8,
  None = 0,
  OverwriteDuplicates = 2
}
```

#### Members

| Members | Description |
| --- | --- |
| ConvertDuplicatesToOverrrides = 4 | If there are cell style name conflicts, set the cell style format as overrides in the target cells, rows, or columns which reference the cell styles. |
| CopyDuplicates = 1 | If there are cell style name conflicts, copy the conflicting cell styles from source to target table styles as new cell styles |
| IgnoreNewStyles = 8 | If the target table style does not have a referenced cell style don't copy it from source to target table style. |
| None = 0 | No option. If the target table style does not have a referenced cell style it will be copied from from the source to target table style. |
| OverwriteDuplicates = 2 | If there are cell style name conflicts, copy and overwrite the cell styles in target table style |