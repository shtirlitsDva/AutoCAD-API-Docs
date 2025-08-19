# Light Class

## Overview

#### Description
This .NET class wraps the AcDbLight ObjectARX class. 
This is a container for all properties relating to a generic light. A dictionary of these objects is resident in the database, in the named object dictionary as ACAD_LIGHTS. They are indexed by the name of the setting objects. In the user interface, the contents of this dictionary correspond to user-defined light properties (displayed on a property palette accessible by selection of the light using a variety of methods.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Light
```

```text
public class Light : Entity;
```

### Constructors

- [Light](#light)

### Methods

- [ResultingColor](#resultingcolor)
- [SetHotspotAndFalloff](#sethotspotandfalloff)

### Properties

- [Attenuation](#attenuation)
- [AttenuationType](#attenuationtype)
- [Direction](#direction)
- [EndLimitOffset](#endlimitoffset)
- [FalloffAngle](#falloffangle)
- [HasTarget](#hastarget)
- [HotspotAngle](#hotspotangle)
- [IlluminanceDistance](#illuminancedistance)
- [Intensity](#intensity)
- [IsOn](#ison)
- [IsPlottable](#isplottable)
- [LampColorPreset](#lampcolorpreset)
- [LampColorRGB](#lampcolorrgb)
- [LampColorTemp](#lampcolortemp)
- [LampColorType](#lampcolortype)
- [LightColor](#lightcolor)
- [LightType](#lighttype)
- [MapSize](#mapsize)
- [Name](#name)
- [PhysicalIntensity](#physicalintensity)
- [PhysicalIntensityMethod](#physicalintensitymethod)
- [Position](#position)
- [Shadow](#shadow)
- [ShadowType](#shadowtype)
- [Softness](#softness)
- [StartLimitOffset](#startlimitoffset)
- [TargetLocation](#targetlocation)
- [UseLimits](#uselimits)
- [WebFile](#webfile)
- [WebRotation](#webrotation)


## Constructors Details

### Light

#### Description
Default constructor.
```text
public Light();
```

### ResultingColor

#### Description
Gets the final color of the light. This is determined by a combination of the Lamp color and the Filter Color. This only applies if LIGHTINGUNITS is set to photometric lighting units (i.e. 1 for American or 2 for International).
```text
public Autodesk.AutoCAD.Colors.Color ResultingColor();
```

### SetHotspotAndFalloff

#### Description
Sets the hotspot and falloff angles. The region between the hotspot and falloff angles is sometimes referred to as the rapid decay area. 
The greater the difference between the hotspot and falloff angles, the softer the edge of the light beam. If the hotspot and falloff angles are equal, the edge of the light beam is sharp. Both values can range from 0 to 160 degrees. You cannot set the hotspot angle to be greater than the falloff angle. 
Valid for spot light type only.
```text
public virtual void SetHotspotAndFalloff(
    double hotspot, 
    double falloff
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double hotspot | Input the hotspot cone angle, in radians. Defines the brightest part of the spot light beam. Must be smaller than or equal to the falloff. |
| double falloff | Input the falloff cone angle, in radians. Defines the full cone of light. This is also known as the field angle. Must be larger than the hotspot. |

#### Notes
This method automatically adjusts invalid values for the hotspot and falloff angles. 
If the new hotspot angle is not equal to the current hotspot angle and is greater than or equal to the falloff angle, then the falloff angle is changed to one degree more than the new hotspot angle . 
If the new falloff angle is not equal to the current falloff angle and is less than or equal to the hotspot angle, then the hotspot angle is changed to one degree less than the new falloff angle. 
Values outside the valid ranges (0-159 for hotspot and 1-160 for falloff) are bound to the valid range.
### Attenuation

#### Description
Accesses the light attenuation type, use limits, start limits, and end limits.
```text
public virtual LightAttenuation Attenuation;
```

#### Conditions
Read / Write
### AttenuationType

#### Description
Accesses the type of attenuation, or decay, for this light. This only applies to point and spot lights. Distant lights always have no attenuation.
```text
public Autodesk.AutoCAD.GraphicsInterface.AttenuationType AttenuationType;
```

#### Conditions
Read / Write
### Direction

#### Description
Accesses the direction (vector) that the rays of a distant light travel. 
Valid for distant light type only.
```text
public virtual Vector3d Direction;
```

#### Conditions
Read / Write
### EndLimitOffset

#### Description
Accesses the end limit parameter of light attenuation.
```text
public double EndLimitOffset;
```

#### Conditions
Read / Write
### FalloffAngle

#### Description
Accesses the falloff angle of this spot light. 
Valid for spot light type only.
```text
public virtual double FalloffAngle;
```

#### Conditions
Read-only
### HasTarget

#### Description
Assesses if the light display has a target grip.
```text
public bool HasTarget;
```

#### Conditions
Read / Write
### HotspotAngle

#### Description
Accesses the hotspot angle of this spot light. 
Valid for spot light type only.
```text
public virtual double HotspotAngle;
```

#### Conditions
Read-only
### IlluminanceDistance

#### Description
Accesses the illuminance distance of the light. 
Only applies if LIGHTINGUNITS is set to photometric lighting units (i.e. 1 for American or 2 for International), and physical intensity method is Illuminance.
```text
public double IlluminanceDistance;
```

#### Conditions
Read / Write
### Intensity

#### Description
Accesses the light intensity. 
A value of 0.0 indicates that the light is off.
```text
public virtual double Intensity;
```

#### Conditions
Read / Write
### IsOn

#### Description
Accesses the Light on/off state.
```text
public virtual bool IsOn;
```

#### Conditions
Read / Write
### IsPlottable

#### Description
Accesses the plottable state of the light.
```text
public virtual bool IsPlottable;
```

#### Conditions
Read / Write
### LampColorPreset

#### Description
Accesses the preset lamp color of the light. 
Only applies if LIGHTINGUNITS is set to photometric lighting units (i.e. 1 for American or 2 for International), and lamp color type is Preset.
```text
public Autodesk.AutoCAD.DatabaseServices.LampColorPreset LampColorPreset;
```

#### Conditions
Read / Write
### LampColorRGB

#### Description
Accesses the RGB value for the light's lamp color. This only applies if LIGHTINGUNITS is set to photometric lighting units (i.e. 1 for American or 2 for International).
```text
public ColorRGB LampColorRGB;
```

#### Conditions
Read / Write
### LampColorTemp

#### Description
Accesses the Kelvin color temperature of the light. This only applies if LIGHTINGUNITS is set to photometric lighting units (i.e. 1 for American or 2 for International), and lamp color type is Kelvin.
```text
public double LampColorTemp;
```

#### Conditions
Read / Write
### LampColorType

#### Description
Accesses the lamp color type of the light. This indicates how the lamp color of the light is specified, either as a Kelvin color temperature or a preset lamp color.It only applies if LIGHTINGUNITS is set to photometric lighting units (i.e. 1 for American or 2 for International).
```text
public Autodesk.AutoCAD.DatabaseServices.LampColorType LampColorType;
```

#### Conditions
Read / Write
### LightColor

#### Description
Accesses the emitted color of the light.
```text
public virtual Autodesk.AutoCAD.Colors.Color LightColor;
```

#### Conditions
Read / Write
### LightType

#### Description
Accesses the type of the light object. Possible values are: SpotLight, PointLight, and DistantLight.
```text
public Autodesk.AutoCAD.GraphicsInterface.DrawableType LightType;
```

#### Conditions
Read / Write
### MapSize

#### Description
Accesses the shadow map size. The returned value should be one of: 64, 128, 256, 512, 1024, 2048, or 4096.
```text
public int MapSize;
```

#### Conditions
Read / Write
### Name

#### Description
Accesses the name of the light object.
```text
public virtual string Name;
```

#### Conditions
Read / Write
### PhysicalIntensity

#### Description
Accesses the physical intensity of the light. The units are based on the physical intensity method (i.e. candela if PeakIntensity, lumen if Flux, lux if Illuminance). This only applies if LIGHTINGUNITS is set to photometric lighting units (i.e. 1 for American or 2 for International).
```text
public double PhysicalIntensity;
```

#### Conditions
Read / Write
### PhysicalIntensityMethod

#### Description
Accesses the physical intensity method of the light. This indicates how the physical intensity of the light is specified, either by peak intensity, flux, or illuminance. This only applies if LIGHTINGUNITS is set to photometric lighting units (i.e. 1 for American or 2 for International).
```text
public Autodesk.AutoCAD.DatabaseServices.PhysicalIntensityMethod PhysicalIntensityMethod;
```

#### Conditions
Read / Write
### Position

#### Description
Accesses the position of the light source, in the coordinate space of the current context. (WCS) 
Valid for spot and point light types only.
```text
public virtual Point3d Position;
```

#### Conditions
Read / Write
### Shadow

#### Description
Accesses the shadow parameters: shadow type, mapsize, softness, on/off, area-sampled shadow parameters.
```text
public virtual ShadowParameters Shadow;
```

#### Conditions
Read / Write
### ShadowType

#### Description
Accesses the shadow type currently in effect.
```text
public Autodesk.AutoCAD.GraphicsInterface.ShadowType ShadowType;
```

#### Conditions
Read / Write
### Softness

#### Description
Accesses the softness shadow parameter.
```text
public byte Softness;
```

#### Conditions
Read / Write
### StartLimitOffset

#### Description
Accesses the start limit shadow parameter.
```text
public double StartLimitOffset;
```

#### Conditions
Read / Write
### TargetLocation

#### Description
Accesses the position of the light target location, in the coordinate space of the current context. (WCS) 
Valid for spot light type only.
```text
public virtual Point3d TargetLocation;
```

#### Conditions
Read / Write
### UseLimits

#### Description
Controls the use of StartLimitOffset and EndLimitOffset properties.
```text
public bool UseLimits;
```

#### Conditions
Read / Write
### WebFile

#### Description
Accesses the path to the file containing the light's goniometric data (e.g. Illuminating Engineering Society or IES file). Only applies if LIGHTINGUNITS is set to photometric lighting units (i.e. 1 for American or 2 for International).
```text
public string WebFile;
```

#### Conditions
Read / Write
### WebRotation

#### Description
Accesses the rotation offset used to orient the goniometric data relative to the light orientation. This only applies if LIGHTINGUNITS is set to photometric lighting units (i.e. 1 for American or 2 for International).
```text
public Vector3d WebRotation;
```

#### Conditions
Read / Write