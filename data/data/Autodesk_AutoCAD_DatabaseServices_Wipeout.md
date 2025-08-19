# Wipeout Class

## Overview

#### Description
This .NET class wraps the AcDbWipeout ObjectARX class. 
Objects of the Wipeout class are polygonally clipped raster entities that are used as masks to cover parts of other entities in the drawing. The most common use is as a background mask for text entities.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Image
            Autodesk.AutoCAD.DatabaseServices.RasterImage
                Autodesk.AutoCAD.DatabaseServices.Wipeout
```

```text
public class Wipeout : RasterImage;
```

#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), [Image](Autodesk_AutoCAD_DatabaseServices_Image.md "Image Class"), RasterImage, RasterImageDef, RasterVariables

## Members

### Constructors

- [Wipeout](#wipeout)

### Methods

- [SetFrom](#setfrom)

### Properties

- [HasFrame](#hasframe)


## Constructors Details

### Wipeout

#### Description
Default constructor.
```text
public Wipeout();
```

### SetFrom

#### Description
Sets a new wipeout from existing coordinates.
```text
public void SetFrom(
    Point2dCollection points, 
    Vector3d normal
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point2dCollection points | Data points for initialization |
| Vector3d normal | Normal vector for initialization |

### HasFrame

#### Description
Assesses if the wipeout has a frame.
```text
public bool HasFrame;
```

#### Conditions
Read / Write