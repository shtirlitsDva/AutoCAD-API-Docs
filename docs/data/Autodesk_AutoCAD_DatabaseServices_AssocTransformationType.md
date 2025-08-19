# Autodesk.AutoCAD.DatabaseServices.AssocTransformationType Enumeration

## Overview

#### Description
Information about what type of transformation (which AutoCAD command) has been performed with the entities before the actions that have dependencies on these entities are evaluated.
```text
public enum AssocTransformationType {
  NotSpecified,
  Stretch,
  Rotate,
  Move
}
```

#### Members

| Members | Description |
| --- | --- |
| NotSpecified | Transformation type not specified. |
| Stretch | Geometries have been changed through strech command. |
| Rotate | Geometries have been changed through rotate command. |
| Move | Geometries have been changed through move command. |