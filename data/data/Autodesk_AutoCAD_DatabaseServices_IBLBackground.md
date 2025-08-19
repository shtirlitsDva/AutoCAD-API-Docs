# IBLBackground Class

## Overview

#### Description
Image based lighting background.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Background
        Autodesk.AutoCAD.DatabaseServices.IBLBackground
```

```text
public class IBLBackground : Background;
```

### Constructors

- [IBLBackground](#iblbackground)

### Properties

- [DisplayImage](#displayimage)
- [Enable](#enable)
- [IBLImageName](#iblimagename)
- [Rotation](#rotation)
- [SecondaryBackground](#secondarybackground)


## Constructors Details

### IBLBackground

#### Description
Constructor.
```text
public IBLBackground();
```

### DisplayImage

#### Description
Gets whether to display the IBL image as the background.
```text
public bool DisplayImage;
```

#### Conditions
Read / Write
### Enable

#### Description
Sets whether IBL is currently active.
```text
public bool Enable;
```

#### Conditions
Read / Write
### IBLImageName

#### Description
Gets the image used for IBL.
```text
public string IBLImageName;
```

#### Conditions
Read / Write
### Rotation

#### Description
Gets the rotation value for the IBL image.
```text
public double Rotation;
```

#### Conditions
Read / Write
### SecondaryBackground

#### Description
Gets the background to display when DisplayImage is set to false.
```text
public ObjectId SecondaryBackground;
```

#### Conditions
Read / Write