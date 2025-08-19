# UnderlayItem Class

## Overview

#### Description
This .NET class wraps the AcDbUnderlayItem ObjectARX class. 
This interface is implemented by host applications that wish to support underlays. UnderlayDefinition and AcDbUnderlayReference objects use this interface to accomplish their mission.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.UnderlayItem
    Autodesk.AutoCAD.DatabaseServices.DgnUnderlayItem
```

```text
public class UnderlayItem : DisposableWrapper;
```

### Properties

- [Extents](#extents)
- [Name](#name)
- [Thumbnail](#thumbnail)
- [Units](#units)
- [UsingPartialContent](#usingpartialcontent)


## Properties Details

### Extents

#### Description
Returns the item's extents in item-model coordinates. The UnderlayReference.Transform property provides the transformation matrix from item-model coordinates to block space coordinates. Block space coordinates usually are equal to WCS coordinates unless the UnderlayReference is part of a block. 
```text
public Extents2d Extents;
```

#### Conditions
Read-only
### Name

#### Description
Returns the name for the item. The returned name is unique within the file.
```text
public string Name;
```

#### Conditions
Read-only
### Thumbnail

#### Description
Returns the preview bitmap for the item.
```text
public Bitmap Thumbnail;
```

#### Conditions
Read-only
### Units

#### Description
Returns the units used by the item.
```text
public Autodesk.AutoCAD.DatabaseServices.UnitsValue Units;
```

#### Conditions
Read-only
### UsingPartialContent

#### Description
Specifies whether or not the item is using only some of the content of the sheet/model represented by the item.
```text
public bool UsingPartialContent;
```

#### Conditions
Read-only