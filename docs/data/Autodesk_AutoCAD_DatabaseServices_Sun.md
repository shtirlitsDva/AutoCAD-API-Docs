# Sun Class

## Overview

#### Description
This .NET class wraps the AcDbSun ObjectARX class. 
Sun class is a container for all properties relating to a sun object. A sun exists as a hard-owned child of an ViewportTableRecord or an AcDbViewport object. It is created when a sun-related operation is first performed (for example, changing a property on the Sun Properties Dialog or a sun-related parameter in the dashboard). It is also created when viewports are created by the sun study wizard. It is set and accessed by the APIs setSun() and sunId() defined on both viewport classes mentioned above. The properties defined in this class correspond to fields on the Sun property palette, but are also set and queried by other clients as mentioned earlier. 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Sun
```

```text
public class Sun : DBObject;
```

### Constructors

- [Sun](#sun)

### Properties

- [Altitude](#altitude)
- [Azimuth](#azimuth)
- [DateTime](#datetime)
- [Intensity](#intensity)
- [IsDaylightSavingsOn](#isdaylightsavingson)
- [IsOn](#ison)
- [ShadowParameters](#shadowparameters)
- [SkyParameters](#skyparameters)
- [SunColor](#suncolor)
- [SunDirection](#sundirection)


## Constructors Details

### Sun

#### Description
Constructor.
```text
public Sun();
```

#### Conditions
Read-only
### Altitude

#### Description
For internal use only.
```text
public virtual double Altitude;
```

#### Conditions
Read / Write
### Azimuth

#### Description
For internal use only. 
```text
public virtual double Azimuth;
```

#### Conditions
Read / Write
### DateTime

#### Description
Returns the date and the time for the Sun Angle Calculator.
```text
public virtual System.DateTime DateTime;
```

#### Conditions
Read / Write
### Intensity

#### Description
Returns the intensity of the Sun object.
```text
public virtual double Intensity;
```

#### Conditions
Read / Write
### IsDaylightSavingsOn

#### Description
Gets the Daylight Savings On/Off option for the Sun Angle Calculator.
```text
public virtual bool IsDaylightSavingsOn;
```

#### Conditions
Read / Write
### IsOn

#### Description
Gets the Sun's on/off state.
```text
public virtual bool IsOn;
```

#### Conditions
Read / Write
### ShadowParameters

#### Description
Returns the shadow parameters: shadow type, mapsize, softness, and on/off.
```text
public virtual Autodesk.AutoCAD.GraphicsInterface.ShadowParameters ShadowParameters;
```

#### Conditions
Read / Write
### SkyParameters

#### Description
Provides access to sky parameters for this light.
```text
public virtual Autodesk.AutoCAD.GraphicsInterface.SkyParameters SkyParameters;
```

#### Conditions
Read / Write
### SunColor

#### Description
Gets the Sun's color.
```text
public virtual Autodesk.AutoCAD.Colors.Color SunColor;
```

#### Conditions
Read / Write
### SunDirection

#### Description
Returns the direction (vector) of the sunlight, from the sun to the model.
```text
public virtual Vector3d SunDirection;
```

#### Conditions
Read / Write