# Autodesk.AutoCAD.DatabaseServices.SourceType Enumeration

## Overview

#### Description
The type of the source of the data for the model documentation view.
```text
public enum SourceType {
  SourceNotDefined,
  InventorSource,
  FusionSource,
  ModelSpaceSource
}
```

#### Members
| Members | Description |
| --- | --- |
| SourceNotDefined | The source of the view data is undefined or unknown. Return value is an enum. |
| InventorSource | The source of the model documentation view is Autodesk Inventor data.. Return value is an enum. |
| FusionSource | The source of the model documentation view is Autodesk Fusion. Return value is an enum. |
| ModelSpaceSource | The source of the model documentation view is AutoCAD model space geometry. Return value is an enum. |