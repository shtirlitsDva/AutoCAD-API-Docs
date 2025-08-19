# GroundPlaneBackground Class

## Overview

#### Description
This .NET class wraps the AcDbGroundPlaneBackground ObjectARX class. 
This class represents a ground plane background.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Background
        Autodesk.AutoCAD.DatabaseServices.GroundPlaneBackground
```

```text
public class GroundPlaneBackground : Background;
```

### Constructors

- [GroundPlaneBackground](#groundplanebackground)

### Properties

- [ColorGroundPlaneFar](#colorgroundplanefar)
- [ColorGroundPlaneNear](#colorgroundplanenear)
- [ColorSkyHorizon](#colorskyhorizon)
- [ColorSkyZenith](#colorskyzenith)
- [ColorUndergroundAzimuth](#colorundergroundazimuth)
- [ColorUndergroundHorizon](#colorundergroundhorizon)


## Constructors Details

### GroundPlaneBackground

#### Description
Default constructor.
```text
public GroundPlaneBackground();
```

### ColorGroundPlaneFar

#### Description
Accesses the far ground plane color.
```text
public virtual EntityColor ColorGroundPlaneFar;
```

#### Conditions
Read / Write
### ColorGroundPlaneNear

#### Description
Accesses the near ground plane color. 
Accesses the color of the sky horizon.
```text
public virtual EntityColor ColorGroundPlaneNear;
```

#### Conditions
Read / Write 
Read / Write
### ColorSkyHorizon

#### Description
Returns the color of the sky at the horizon.
```text
public virtual EntityColor ColorSkyHorizon;
```

#### Conditions
Read/Write
### ColorSkyZenith

#### Description
Accesses the color at the sky zenith.
```text
public virtual EntityColor ColorSkyZenith;
```

#### Conditions
Read / Write
### ColorUndergroundAzimuth

#### Description
Accesses the underground azimuth color.
```text
public virtual EntityColor ColorUndergroundAzimuth;
```

#### Conditions
Read / Write
### ColorUndergroundHorizon

#### Description
Accesses the underground horizon color.
```text
public virtual EntityColor ColorUndergroundHorizon;
```

#### Conditions
Read / Write