# UnderlayLayer Class

## Overview

#### Description
This .NET class wraps the [AcUnderlayLayer](AcUnderlayLayer.md) ObjectARX class. 
UnderlayLayer is an abstract class that represents underlay layers in the drawing. 
Underlays are similar to raster images but their content is snappable. An UnderlayReference must reference a compatible UnderlayDefinition. The UnderlayReference is responsible for the placement of the content within the drawing while UnderlayDefinition handles the linkage to the underlay content. 
Instances of UnderlayReference derived concrete classes are inserted in a block table record. Instances of UnderlayDefinition derived concrete classes are inserted into a dictionary of the named object.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.UnderlayLayer
```

```text
public class UnderlayLayer : DisposableWrapper;
```

### Constructors

- [UnderlayLayer](#underlaylayer)

### Properties

- [Name](#name)
- [State](#state)


## Constructors Details

### UnderlayLayer

#### Description
Constructor.
```text
public UnderlayLayer();
```

### Name

#### Description
Returns the name of the underlay layer.
```text
public string Name;
```

#### Conditions
Read-only
### State

#### Description
Returns the state of the underlay layer.
```text
public UnderlayLayerState State;
```

#### Conditions
Read / Write