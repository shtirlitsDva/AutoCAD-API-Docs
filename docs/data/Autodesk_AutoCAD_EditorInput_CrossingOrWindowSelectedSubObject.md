# CrossingOrWindowSelectedSubObject Class

## Overview

#### Description
This class encapsulates a subobject that is selected by the crossing or window selection method.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectedSubObject
    Autodesk.AutoCAD.EditorInput.CrossingOrWindowSelectedSubObject
```

```text
public sealed class CrossingOrWindowSelectedSubObject : SelectedSubObject;
```

### Constructors

- [CrossingOrWindowSelectedSubObject(FullSubentityPath, SelectionMethod, IntPtr)](#crossingorwindowselectedsubobject(fullsubentitypath,-selectionmethod,-intptr))
- [CrossingOrWindowSelectedSubObject(FullSubentityPath, SelectionMethod, long)](#crossingorwindowselectedsubobject(fullsubentitypath,-selectionmethod,-long))

### Methods

- [GetPickPoints](#getpickpoints)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))


## Constructors Details

### CrossingOrWindowSelectedSubObject(FullSubentityPath, SelectionMethod, IntPtr)

#### Description
Constructor.
```text
public CrossingOrWindowSelectedSubObject(
    FullSubentityPath path, 
    SelectionMethod method, 
    IntPtr gsMarker
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath path | Input path of object |
| SelectionMethod method | Input method of selection |
| IntPtr gsMarker | Input any GS markers |

### CrossingOrWindowSelectedSubObject(FullSubentityPath, SelectionMethod, long)

#### Description
Obsolete - Use the constructor overload taking IntPtr instead.
Class
Autodesk.AutoCAD.EditorInput
#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath path | Input path of object |
| SelectionMethod method | Input method of selection |
| long gsMarker | Input any GS markers |

public CrossingOrWindowSelectedSubObject( 
FullSubentityPath path, 
SelectionMethod method, 
IntPtr gsMarker 
);
Previous Declaration
```text
public CrossingOrWindowSelectedSubObject(FullSubentityPath path, SelectionMethod method, int gsMarker);
```

### GetPickPoints

#### Description
Returns the list of pick points used to select the subobject.
```text
public PickPointDescriptor\[\] GetPickPoints();
```

### ToString()

#### Description
Returns an equivalent string representation of this object.
```text
public sealed override string ToString();
```

### ToString(IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider.
```text
public string ToString(
    IFormatProvider provider
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IFormatProvider provider | Input culture-specific format |
