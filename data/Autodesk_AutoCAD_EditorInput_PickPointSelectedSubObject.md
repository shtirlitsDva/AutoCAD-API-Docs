# PickPointSelectedSubObject Class

## Overview

#### Description
This class encapsulates a subobject that is selected by the pick point selection method.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectedSubObject
    Autodesk.AutoCAD.EditorInput.PickPointSelectedSubObject
```

```text
public sealed class PickPointSelectedSubObject : SelectedSubObject;
```

### Constructors

- [PickPointSelectedSubObject(FullSubentityPath, SelectionMethod, IntPtr, PickPointDescriptor)](#pickpointselectedsubobject(fullsubentitypath,-selectionmethod,-intptr,-pickpointdescriptor))
- [PickPointSelectedSubObject(FullSubentityPath, SelectionMethod, long, PickPointDescriptor)](#pickpointselectedsubobject(fullsubentitypath,-selectionmethod,-long,-pickpointdescriptor))

### Methods

- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [PickPoint](#pickpoint)


## Constructors Details

### PickPointSelectedSubObject(FullSubentityPath, SelectionMethod, IntPtr, PickPointDescriptor)

#### Description
Constructor.
```text
public PickPointSelectedSubObject(
    FullSubentityPath path, 
    SelectionMethod method, 
    IntPtr gsMarker, 
    PickPointDescriptor descriptor
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| FullSubentityPath path | Input subentity path |
| SelectionMethod method | Input method of selection |
| IntPtr gsMarker | Input GS markers |
| PickPointDescriptor descriptor | Input pick point descriptor |

### PickPointSelectedSubObject(FullSubentityPath, SelectionMethod, long, PickPointDescriptor)

#### Description
Obsolete - Use the constructor overload taking IntPtr instead.
Class
Autodesk.AutoCAD.EditorInput
#### Parameters
| Parameters | Description |
| --- | --- |
| FullSubentityPath path | Input subentity path |
| SelectionMethod method | Input method of selection |
| long gsMarker | Input GS markers |
| PickPointDescriptor descriptor | Input pick point descriptor |

public PickPointSelectedSubObject( 
FullSubentityPath path, 
SelectionMethod method, 
IntPtr gsMarker, 
PickPointDescriptor descriptor 
);
Previous Declaration
```text
public PickPointSelectedSubObject(FullSubentityPath path, SelectionMethod method, int gsMarker, PickPointDescriptor descriptor);
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
| IFormatProvider provider | Input for culture-specific format |

### PickPoint

#### Description
Gets the pick point that was used to select the subobject.
```text
public PickPointDescriptor PickPoint;
```

#### Conditions
Read-only