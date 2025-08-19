# GradientBackground Class

## Overview

#### Description
This .NET class wraps the AcDbGradientBackground ObjectARX class. This class represents a gradient background.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Background
        Autodesk.AutoCAD.DatabaseServices.GradientBackground
```

```text
public class GradientBackground : Background;
```

### Constructors

- [GradientBackground](#gradientbackground)

### Properties

- [ColorBottom](#colorbottom)
- [ColorMiddle](#colormiddle)
- [ColorTop](#colortop)
- [Height](#height)
- [Horizon](#horizon)
- [Rotation](#rotation)


## Constructors Details

### GradientBackground

#### Description
Default constructor.
```text
public GradientBackground();
```

### ColorBottom

#### Description
Accesses the current color value of the bottom portion of the background.
```text
public EntityColor ColorBottom;
```

#### Conditions
Read / Write
### ColorMiddle

#### Description
Accesses the current color value of the middle portion of the background.
```text
public EntityColor ColorMiddle;
```

#### Conditions
Read / Write
### ColorTop

#### Description
Accesses the current color value of the top portion of the background.
```text
public EntityColor ColorTop;
```

#### Conditions
Read / Write
### Height

#### Description
Accesses the height value representing a percentage of the second color in a three-color gradient. The start point of the second color is determined by the Horizon setting. If the value is 0, the result is a two-color gradient that uses the Top and Bottom colors.
```text
public double Height;
```

#### Conditions
Read / Write
### Horizon

#### Description
Accesses the horizon value indicating the percentage of unrotated height.
```text
public double Horizon;
```

#### Conditions
Read / Write
### Rotation

#### Description
Accesses the angle at which you can rotate a gradient background.
```text
public double Rotation;
```

#### Conditions
Read / Write