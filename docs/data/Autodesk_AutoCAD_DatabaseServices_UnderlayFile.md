# UnderlayFile Class

## Overview

#### Description
This .NET class wraps the AcDbUnderlayFile ObjectARX class. 
This interface is implemented by host applications that wish to support underlays. UnderlayDefinition and AcDbUnderlayReference objects use this interface to accomplish their mission.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.UnderlayFile
```

```text
public sealed class UnderlayFile : DisposableWrapper;
```

### Properties

- [Items](#items)


## Properties Details

### Items

#### Description
Returns the underlay items that should be referenced.
```text
public UnderlayItemCollection Items;
```

#### Conditions
Read-only