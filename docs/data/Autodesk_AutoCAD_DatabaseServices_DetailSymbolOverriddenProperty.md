# Autodesk.AutoCAD.DatabaseServices.DetailSymbolOverriddenProperty Enumeration

## Overview

#### Description
An enum to indicate which property of the style is overridden.
```text
public enum DetailSymbolOverriddenProperty {
  IdentifierPosition = 2,
  ModelEdge = 1
}
```

#### Members

| Members | Description |
| --- | --- |
| IdentifierPosition = 2 | This flag indicates the identifier position has been edited and overridden. |
| ModelEdge = 1 | This flag indicates the model edge type of the associated AcDbDetailSymbolStyle has been overridden. |

#### See Also
AcDbDetailSymbol::OverriddenProperty