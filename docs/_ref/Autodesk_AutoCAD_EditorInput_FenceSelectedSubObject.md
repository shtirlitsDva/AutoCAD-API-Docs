# FenceSelectedSubObject Class

## Overview

#### Description
This class encapsulates a subobject that is selected by the fence selection method.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectedSubObject
    Autodesk.AutoCAD.EditorInput.FenceSelectedSubObject
```

```text
public sealed class FenceSelectedSubObject : SelectedSubObject;
```

### Constructors

- [FenceSelectedSubObject(FullSubentityPath, SelectionMethod, IntPtr, PickPointDescriptor[])](#fenceselectedsubobject(fullsubentitypath,-selectionmethod,-intptr,-pickpointdescriptor[]))
- [FenceSelectedSubObject(FullSubentityPath, SelectionMethod, long, PickPointDescriptor[])](#fenceselectedsubobject(fullsubentitypath,-selectionmethod,-long,-pickpointdescriptor[]))

### Methods

- [GetIntersectionPoints](#getintersectionpoints)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))


## Constructors Details

### FenceSelectedSubObject(FullSubentityPath, SelectionMethod, IntPtr, PickPointDescriptor[])

#### Description
Constructor.
```text
public FenceSelectedSubObject(
    FullSubentityPath path, 
    SelectionMethod method, 
    IntPtr gsMarker, 
    PickPointDescriptor\[\] descriptors
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| FullSubentityPath path | Input subentitiy path |
| SelectionMethod method | Input selection method |
| IntPtr gsMarker | Input GS marker |
| PickPointDescriptor[] descriptors | Input pick points |

### FenceSelectedSubObject(FullSubentityPath, SelectionMethod, long, PickPointDescriptor[])

#### Description
Obsolete - Use the constructor overload taking IntPtr instead.
Class
Autodesk.AutoCAD.EditorInput
#### Parameters
| Parameters | Description |
| --- | --- |
| FullSubentityPath path | Input subentitiy path |
| SelectionMethod method | Input selection method |
| long gsMarker | Input GS marker |
| PickPointDescriptor[] descriptors | Input pick points |

public FenceSelectedSubObject( 
FullSubentityPath path, 
SelectionMethod method, 
IntPtr gsMarker, 
PickPointDescriptor[] descriptors 
);
Previous Declaration
```text
public FenceSelectedSubObject(FullSubentityPath path, SelectionMethod method, int gsMarker, PickPointDescriptor[] descriptors);
```

### GetIntersectionPoints

#### Description
Returns the point descriptor array.
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
