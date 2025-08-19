# SelectedObject Class

## Overview

#### Description
This is the base class for a selected object.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectedObject
    Autodesk.AutoCAD.EditorInput.CrossingOrWindowSelectedObject
    Autodesk.AutoCAD.EditorInput.FenceSelectedObject
    Autodesk.AutoCAD.EditorInput.PickPointSelectedObject
```

```text
public class SelectedObject;
```

### Constructors

- [SelectedObject(Autodesk.AutoCAD.DatabaseServices.ObjectId, Autodesk.AutoCAD.EditorInput.SelectionMethod, IntPtr)](#selectedobject(autodesk.autocad.databaseservices.objectid,-autodesk.autocad.editorinput.selectionmethod,-intptr))
- [SelectedObject(Autodesk.AutoCAD.DatabaseServices.ObjectId, Autodesk.AutoCAD.EditorInput.SelectionMethod, long)](#selectedobject(autodesk.autocad.databaseservices.objectid,-autodesk.autocad.editorinput.selectionmethod,-long))
- [SelectedObject(Autodesk.AutoCAD.DatabaseServices.ObjectId, SelectedSubObject[])](#selectedobject(autodesk.autocad.databaseservices.objectid,-selectedsubobject[]))

### Methods

- [GetSubentities](#getsubentities)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [GraphicsSystemMarker](#graphicssystemmarker)
- [GraphicsSystemMarkerPtr](#graphicssystemmarkerptr)
- [ObjectId](#objectid)
- [OptionalDetails](#optionaldetails)
- [SelectionMethod](#selectionmethod)


## Constructors Details

### SelectedObject(Autodesk.AutoCAD.DatabaseServices.ObjectId, Autodesk.AutoCAD.EditorInput.SelectionMethod, IntPtr)

#### Description
Constructor.
```text
public SelectedObject(
    Autodesk.AutoCAD.DatabaseServices.ObjectId id, 
    Autodesk.AutoCAD.EditorInput.SelectionMethod method, 
    IntPtr gsMarker
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.EditorInput.SelectionMethod method | Input selection method |
| IntPtr gsMarker | Input GS marker |
| path | Input object path |

### SelectedObject(Autodesk.AutoCAD.DatabaseServices.ObjectId, Autodesk.AutoCAD.EditorInput.SelectionMethod, long)

#### Description
Obsolete - Use the constructor overload taking IntPtr instead.
Class
Autodesk.AutoCAD.EditorInput
#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.ObjectId id | Input object path |
| Autodesk.AutoCAD.EditorInput.SelectionMethod method | Input selection method |
| long gsMarker | Input GS marker |

public SelectedObject( 
Autodesk.AutoCAD.DatabaseServices.ObjectId id, 
Autodesk.AutoCAD.EditorInput.SelectionMethod method, 
IntPtr gsMarker 
);
Previous Declaration
```text
public SelectedObject(Autodesk.AutoCAD.DatabaseServices.ObjectId id, Autodesk.AutoCAD.EditorInput.SelectionMethod method, int gsMarker);
```

### SelectedObject(Autodesk.AutoCAD.DatabaseServices.ObjectId, SelectedSubObject[])

#### Description
Constructor.
```text
public SelectedObject(
    Autodesk.AutoCAD.DatabaseServices.ObjectId id, 
    SelectedSubObject\[\] subSelections
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.ObjectId id | Input selected object's ID |
| SelectedSubObject[] subSelections | Input any subselections |

### GetSubentities

#### Description
Returns the subentities of the selected object in a SelectedSubObject array.
```text
public SelectedSubObject\[\] GetSubentities();
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

### GraphicsSystemMarker

#### Description
Obsolete - Use the GraphicsSystemMarkerPtr property instead. 
Gets a value that describes what part of the object was selected. 
A unique integer index for the part of the object that was selected.
Class
Autodesk.AutoCAD.EditorInput.SelectedObject
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
### ObjectId

#### Description
Gets the object ID of this selected object.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId ObjectId;
```

#### Conditions
Read-only
### OptionalDetails

#### Description
Gets an object describing the selection details useful for nested objects.
```text
public SelectionDetails OptionalDetails;
```

#### Conditions
Read-only
### SelectionMethod

#### Description
Gets a value that describes how the object was selected.
```text
public Autodesk.AutoCAD.EditorInput.SelectionMethod SelectionMethod;
```

#### Conditions
Read-only