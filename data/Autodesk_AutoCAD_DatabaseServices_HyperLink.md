# HyperLink Class

## Overview

#### Description
This .NET class wraps the AcDbHyperlink ObjectARX class. 
A Hyperlink object contains the hyperlink name (for example, _http://www.autodesk.com_), a sublocation within that link, and the hyperlink description or friendly name (for example, "Click here for Autodesk's website"). 
See the _ObjectARX Developer's Guide_ for an example of how to use this class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.HyperLink
```

```text
public sealed class HyperLink : DisposableWrapper;
```

### Constructors

- [HyperLink](#hyperlink)

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)

### Properties

- [Description](#description)
- [DisplayString](#displaystring)
- [IsOutermostContainer](#isoutermostcontainer)
- [Name](#name)
- [NestedLevel](#nestedlevel)
- [SubLocation](#sublocation)


## Constructors Details

### HyperLink

#### Description
Default constructor.
```text
public HyperLink();
```

### Equals

#### Description
Returns true if this object is identical to the argument object.
```text
public sealed override bool Equals(
    object other
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| object other | Object to compare |

### GetHashCode

#### Description
Returns the hash code for this object. See the Microsoft .NET API documentation for details.
```text
public sealed override int GetHashCode();
```

### Description

#### Description
Accesses the hyperlink description (or friendly name).
```text
public string Description;
```

#### Conditions
Read / Write
### DisplayString

#### Description
Accesses the hyperlink display string. 
The display string for the hyperlink is usually the same as the hyperlink's description. If the description is NULL, the hyperlink's name and sublocation are returned instead, in 'name - sublocation' format.
```text
public string DisplayString;
```

#### Conditions
Read-only
### IsOutermostContainer

#### Description
Accesses the hyperlink is associated with the outermost container, and false otherwise. 
This method is useful in determining which hyperlinks are editable in a collection that includes container hyperlinks. In the case of an entity within a block, only the hyperlinks associated with the block insert are editable. The hyperlinks associated with the entity and its block definitions are not editable.
```text
public bool IsOutermostContainer;
```

#### Conditions
Read-only
### Name

#### Description
Accesses the hyperlink name.
```text
public string Name;
```

#### Conditions
Read / Write
### NestedLevel

#### Description
Accesses the nesting level of the associated entity.
```text
public int NestedLevel;
```

#### Conditions
Read-only
### SubLocation

#### Description
Accesses the hyperlink sublocation. A sublocation is a specific target name within the named hyperlink.
```text
public string SubLocation;
```

#### Conditions
Read / Write