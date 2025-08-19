# CrossingOrWindowSelectedObject Class

## Overview

#### Description
This class describes an object that was selected by a window or window polygon selection. The selection window may or may not be a crossing window.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectedObject
    Autodesk.AutoCAD.EditorInput.CrossingOrWindowSelectedObject
```

```text
public sealed class CrossingOrWindowSelectedObject : SelectedObject;
```

### Constructors

- [CrossingOrWindowSelectedObject(ObjectId, SelectionMethod, IntPtr)](#crossingorwindowselectedobject(objectid,-selectionmethod,-intptr))
- [CrossingOrWindowSelectedObject(ObjectId, SelectionMethod, long)](#crossingorwindowselectedobject(objectid,-selectionmethod,-long))

### Methods

- [GetPickPoints](#getpickpoints)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))


## Constructors Details

### CrossingOrWindowSelectedObject(ObjectId, SelectionMethod, IntPtr)

#### Description
Constructor.
```text
public CrossingOrWindowSelectedObject(
    ObjectId id, 
    SelectionMethod method, 
    IntPtr gsMarker
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | Input ID of crossing object |
| SelectionMethod method | Input method to select object |
| IntPtr gsMarker | Input any GS markers |

### CrossingOrWindowSelectedObject(ObjectId, SelectionMethod, long)

#### Description
Obsolete - Use the constructor overload taking IntPtr instead.
Class
Autodesk.AutoCAD.EditorInput
#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | Input ID of crossing object |
| SelectionMethod method | Input method to select object |
| long gsMarker | Input any GS markers |

public CrossingOrWindowSelectedObject( 
ObjectId id, 
SelectionMethod method, 
IntPtr gsMarker 
);
Previous Declaration
```text
public CrossingOrWindowSelectedObject(ObjectId id, SelectionMethod method, int gsMarker);
```

### GetPickPoints

#### Description
Gets an array of pick points used to select the object.
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
| IFormatProvider provider | Input culture specific format |
