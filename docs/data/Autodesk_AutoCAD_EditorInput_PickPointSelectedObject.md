# PickPointSelectedObject Class

## Overview

#### Description
This class describes an object that was selected by a single pick.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectedObject
    Autodesk.AutoCAD.EditorInput.PickPointSelectedObject
```

```text
public sealed class PickPointSelectedObject : SelectedObject;
```

### Constructors

- [PickPointSelectedObject(ObjectId, SelectionMethod, IntPtr, PickPointDescriptor)](#pickpointselectedobject(objectid,-selectionmethod,-intptr,-pickpointdescriptor))
- [PickPointSelectedObject(ObjectId, SelectionMethod, long, PickPointDescriptor)](#pickpointselectedobject(objectid,-selectionmethod,-long,-pickpointdescriptor))

### Methods

- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [PickPoint](#pickpoint)


## Constructors Details

### PickPointSelectedObject(ObjectId, SelectionMethod, IntPtr, PickPointDescriptor)

#### Description
Constructor.
```text
public PickPointSelectedObject(
    ObjectId id, 
    SelectionMethod method, 
    IntPtr gsMarker, 
    PickPointDescriptor descriptor
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | Input object ID |
| SelectionMethod method | Input method of selection |
| IntPtr gsMarker | Input GS markers |
| PickPointDescriptor descriptor | Input pick point descriptor |

### PickPointSelectedObject(ObjectId, SelectionMethod, long, PickPointDescriptor)

#### Description
Obsolete - Use the constructor overload taking IntPtr instead.
Class
Autodesk.AutoCAD.EditorInput
#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | Input object ID |
| SelectionMethod method | Input method of selection |
| long gsMarker | Input GS markers |
| PickPointDescriptor descriptor | Input pick point descriptor |

public PickPointSelectedObject( 
ObjectId id, 
SelectionMethod method, 
IntPtr gsMarker, 
PickPointDescriptor descriptor 
);
Previous Declaration
```text
public PickPointSelectedObject(ObjectId id, SelectionMethod method, int gsMarker, PickPointDescriptor descriptor);
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

### PickPoint

#### Description
Gets the pick point that was used to select the object.
```text
public PickPointDescriptor PickPoint;
```

#### Conditions
Read-only