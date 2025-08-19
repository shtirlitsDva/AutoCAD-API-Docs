# SelectedSubObject Class

## Overview

#### Description
This is the base for classes that describe subobjects selected through various techniques. It defines the basic data that describes a selected subobject: full subentity path, GS marker, and selection method, as well as optional details.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectedSubObject
    Autodesk.AutoCAD.EditorInput.CrossingOrWindowSelectedSubObject
    Autodesk.AutoCAD.EditorInput.FenceSelectedSubObject
    Autodesk.AutoCAD.EditorInput.PickPointSelectedSubObject
```

```text
public class SelectedSubObject;
```

### Constructors

- [SelectedSubObject(Autodesk.AutoCAD.DatabaseServices.FullSubentityPath, Autodesk.AutoCAD.EditorInput.SelectionMethod, IntPtr)](#selectedsubobject(autodesk.autocad.databaseservices.fullsubentitypath,-autodesk.autocad.editorinput.selectionmethod,-intptr))
- [SelectedSubObject(Autodesk.AutoCAD.DatabaseServices.FullSubentityPath, Autodesk.AutoCAD.EditorInput.SelectionMethod, long)](#selectedsubobject(autodesk.autocad.databaseservices.fullsubentitypath,-autodesk.autocad.editorinput.selectionmethod,-long))

### Methods

- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [FullSubentityPath](#fullsubentitypath)
- [GraphicsSystemMarker](#graphicssystemmarker)
- [GraphicsSystemMarkerPtr](#graphicssystemmarkerptr)
- [OptionalDetails](#optionaldetails)
- [SelectionMethod](#selectionmethod)


## Constructors Details

### SelectedSubObject(Autodesk.AutoCAD.DatabaseServices.FullSubentityPath, Autodesk.AutoCAD.EditorInput.SelectionMethod, IntPtr)

#### Description
Constructor.
```text
public SelectedSubObject(
    Autodesk.AutoCAD.DatabaseServices.FullSubentityPath path, 
    Autodesk.AutoCAD.EditorInput.SelectionMethod method, 
    IntPtr gsMarker
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.FullSubentityPath path | Input object path |
| Autodesk.AutoCAD.EditorInput.SelectionMethod method | Input selection method |
| IntPtr gsMarker | Input GS marker |

### SelectedSubObject(Autodesk.AutoCAD.DatabaseServices.FullSubentityPath, Autodesk.AutoCAD.EditorInput.SelectionMethod, long)

#### Description
Obsolete - Use the constructor overload taking IntPtr instead.
Class
Autodesk.AutoCAD.EditorInput
#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.FullSubentityPath path | Input object path |
| Autodesk.AutoCAD.EditorInput.SelectionMethod method | Input selection method |
| long gsMarker | Input GS marker |

public SelectedSubObject( 
Autodesk.AutoCAD.DatabaseServices.FullSubentityPath path, 
Autodesk.AutoCAD.EditorInput.SelectionMethod method, 
IntPtr gsMarker 
);
Previous Declaration
```text
public SelectedSubObject(Autodesk.AutoCAD.DatabaseServices.FullSubentityPath path, Autodesk.AutoCAD.EditorInput.SelectionMethod method, int gsMarker);
```

### ToString()

#### Description
Returns an equivalent string representation of this object.
```text
public override string ToString();
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

### FullSubentityPath

#### Description
Returns the full subentity path of the selected sub object.
```text
public Autodesk.AutoCAD.DatabaseServices.FullSubentityPath FullSubentityPath;
```

#### Conditions
Read / Write
### GraphicsSystemMarker

#### Description
Obsolete - Use the GraphicsSystemMarkerPtr property instead. 
Gets a value that describes what part of the object was selected. 
A unique integer index for the part of the object that was selected.
Class
Autodesk.AutoCAD.EditorInput.SelectedSubObject
#### Conditions
Read-only
public IntPtr GraphicsSystemMarkerPtr;
Previous Declaration
```text
public int GraphicsSystemMarker;
```

### GraphicsSystemMarkerPtr

#### Description
Returns the GS Marker of the selected sub object.
```text
public IntPtr GraphicsSystemMarkerPtr;
```

#### Conditions
Read-only
### OptionalDetails

#### Description
Returns the optional details of the selected sub object.
```text
public SelectionDetails OptionalDetails;
```

#### Conditions
Read / Write
### SelectionMethod

#### Description
Returns the selection method to select the sub object.
```text
public Autodesk.AutoCAD.EditorInput.SelectionMethod SelectionMethod;
```

#### Conditions
Read / Write