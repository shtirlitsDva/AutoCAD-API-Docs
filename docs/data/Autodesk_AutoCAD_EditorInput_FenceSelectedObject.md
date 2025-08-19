# FenceSelectedObject Class

## Overview

#### Description
This class describes an object that is selected by fence selection.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectedObject
    Autodesk.AutoCAD.EditorInput.FenceSelectedObject
```

```text
public sealed class FenceSelectedObject : SelectedObject;
```

### Constructors

- [FenceSelectedObject(ObjectId, SelectionMethod, IntPtr, PickPointDescriptor[])](#fenceselectedobject(objectid,-selectionmethod,-intptr,-pickpointdescriptor[]))
- [FenceSelectedObject(ObjectId, SelectionMethod, long, PickPointDescriptor[])](#fenceselectedobject(objectid,-selectionmethod,-long,-pickpointdescriptor[]))

### Methods

- [GetIntersectionPoints](#getintersectionpoints)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))


## Constructors Details

### FenceSelectedObject(ObjectId, SelectionMethod, IntPtr, PickPointDescriptor[])

#### Description
Constructor.
```text
public FenceSelectedObject(
    ObjectId id, 
    SelectionMethod method, 
    IntPtr gsMarker, 
    PickPointDescriptor\[\] descriptors
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input object to fence |
| SelectionMethod method | Input selection method |
| IntPtr gsMarker | Input GS markers |
| PickPointDescriptor[] descriptors | Input pick point descriptors |

### FenceSelectedObject(ObjectId, SelectionMethod, long, PickPointDescriptor[])

#### Description
Obsolete - Use the constructor overload taking IntPtr instead.
Class
Autodesk.AutoCAD.EditorInput
#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input object to fence |
| SelectionMethod method | Input selection method |
| long gsMarker | Input GS markers |
| PickPointDescriptor[] descriptors | Input pick point descriptors |

public FenceSelectedObject( 
ObjectId id, 
SelectionMethod method, 
IntPtr gsMarker, 
PickPointDescriptor[] descriptors 
);
Previous Declaration
```text
public FenceSelectedObject(ObjectId id, SelectionMethod method, int gsMarker, PickPointDescriptor[] descriptors);
```

### GetIntersectionPoints

#### Description
Gets an array of pick points used to select the object.
```text
public PickPointDescriptor\[\] GetIntersectionPoints();
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
