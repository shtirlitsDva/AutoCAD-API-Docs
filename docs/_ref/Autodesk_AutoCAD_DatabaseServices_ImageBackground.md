# ImageBackground Class

## Overview

#### Description
This .NET class wraps the AcDbImageBackground ObjectARX class. 
This class represents a background image.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Background
        Autodesk.AutoCAD.DatabaseServices.ImageBackground
```

```text
public class ImageBackground : Background;
```

### Constructors

- [ImageBackground](#imagebackground)

### Properties

- [FitToScreen](#fittoscreen)
- [ImageFileName](#imagefilename)
- [MaintainAspectRatio](#maintainaspectratio)
- [Offset](#offset)
- [Scale](#scale)
- [UseTiling](#usetiling)


## Constructors Details

### ImageBackground

#### Description
Default constructor.
```text
public ImageBackground();
```

### FitToScreen

#### Description
Accesses the value indicating if image background needs to be fit to the screen or not.
```text
public bool FitToScreen;
```

#### Conditions
Read / Write
### ImageFileName

#### Description
Accesses the image file name associated with this background.
```text
public string ImageFileName;
```

#### Conditions
Read / Write
### MaintainAspectRatio

#### Description
Accesses the value indicating the use of aspect ratio of the image file.
```text
public bool MaintainAspectRatio;
```

#### Conditions
Read / Write
### Offset

#### Description
Accesses the image offset.
```text
public Vector2d Offset;
```

#### Conditions
Read / Write
### Scale

#### Description
Accesses the scale values.
```text
public Scale2d Scale;
```

#### Conditions
Read / Write
### UseTiling

#### Description
Accesses the image tiling property.
```text
public bool UseTiling;
```

#### Conditions
Read / Write