# Material Class

## Overview

#### Description
This .NET class wraps the AcDbMaterial ObjectARX class. 
The Material class is used to define, store, and display material properties for shaded entities. A Material object consists of a variety of shading components, including diffuse, ambient, specular, reflection, opacity, bump, and refraction. Each component defines a different aspect of shading behavior for an entity. 
Material objects are stored in the ACAD_MATERIAL dictionary within the named object dictionary of an Database. 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Material
```

```text
public class Material : DBObject;
```

### Constructors

- [Material](#material)

### Properties

- [Ambient](#ambient)
- [Anonymous](#anonymous)
- [Bump](#bump)
- [ChannelFlags](#channelflags)
- [ColorBleedScale](#colorbleedscale)
- [Description](#description)
- [Diffuse](#diffuse)
- [FinalGather](#finalgather)
- [GlobalIllumination](#globalillumination)
- [IlluminationModel](#illuminationmodel)
- [IndirectBumpScale](#indirectbumpscale)
- [Luminance](#luminance)
- [LuminanceMode](#luminancemode)
- [Mode](#mode)
- [Name](#name)
- [NormalMap](#normalmap)
- [Opacity](#opacity)
- [ReflectanceScale](#reflectancescale)
- [Reflection](#reflection)
- [Reflectivity](#reflectivity)
- [Refraction](#refraction)
- [SelfIllumination](#selfillumination)
- [Specular](#specular)
- [Translucence](#translucence)
- [TransmittanceScale](#transmittancescale)
- [TwoSided](#twosided)


## Constructors Details

### Material

#### Description
Default constructor.
```text
public Material();
```

### Ambient

#### Description
Accesses the ambient component of the material.
```text
public virtual MaterialColor Ambient;
```

#### Conditions
Read / Write
### Anonymous

#### Description
Accesses an indication that the material is "anonymous" in that it is intended for programmatic usage via API only, and should not be exposed through any user interface.
```text
public bool Anonymous;
```

#### Conditions
Read / Write
### Bump

#### Description
Accesses the bump component of the material.
```text
public virtual MaterialMap Bump;
```

#### Conditions
Read / Write
### ChannelFlags

#### Description
Accesses the channel flags for this material. The flags indicate which textures are in use by this material.
```text
public Autodesk.AutoCAD.GraphicsInterface.ChannelFlags ChannelFlags;
```

#### Conditions
Read / Write
### ColorBleedScale

#### Description
Accesses the color bleed scale value for the material.
```text
public double ColorBleedScale;
```

#### Conditions
Read / Write
### Description

#### Description
Accesses the material description string.
```text
public virtual string Description;
```

#### Conditions
Read / Write
### Diffuse

#### Description
Accesses the diffuse component of the material.
```text
public virtual MaterialDiffuseComponent Diffuse;
```

#### Conditions
Read / Write
### FinalGather

#### Description
Accesses the final gathering mode.
```text
public Autodesk.AutoCAD.GraphicsInterface.FinalGatherMode FinalGather;
```

#### Conditions
Read / Write
### GlobalIllumination

#### Description
Accesses the illumination mode.
```text
public Autodesk.AutoCAD.GraphicsInterface.GlobalIlluminationMode GlobalIllumination;
```

#### Conditions
Read / Write
### IlluminationModel

#### Description
Accesses the illumination model set on this material. This model determines the type of shader used to render this material. 
The illumination model affects the color of light reflected from the material. The Blinn shader reflects the color of the light, whereas the Metal shader reflects a light color that is a combination of the color of the light and the material's diffuse color.
```text
public Autodesk.AutoCAD.GraphicsInterface.IlluminationModel IlluminationModel;
```

#### Conditions
Read / Write
### IndirectBumpScale

#### Description
Accesses the indirect bump scale value for the material.
```text
public double IndirectBumpScale;
```

#### Conditions
Read / Write
### Luminance

#### Description
Accesses the luminance value of the material.
```text
public double Luminance;
```

#### Conditions
Read / Write
### LuminanceMode

#### Description
Accesses the luminance mode of the material.
```text
public Autodesk.AutoCAD.GraphicsInterface.LuminanceMode LuminanceMode;
```

#### Conditions
Read / Write
### Mode

#### Description
Accesses the mode of this material.
```text
public Autodesk.AutoCAD.GraphicsInterface.Mode Mode;
```

#### Conditions
Read / Write
### Name

#### Description
Accesses the material name string.
```text
public virtual string Name;
```

#### Conditions
Read / Write
### NormalMap

#### Description
Accesses the material map for the normal map channel of the material, the method used to compute the normal map, and the channel strength.
```text
public MaterialNormalMapComponent NormalMap;
```

#### Conditions
Read / Write
### Opacity

#### Description
Accesses the opacity component of the material.
```text
public virtual MaterialOpacityComponent Opacity;
```

#### Conditions
Read / Write
### ReflectanceScale

#### Description
Accesses the reflectance scale value for the material.
```text
public double ReflectanceScale;
```

#### Conditions
Read / Write
### Reflection

#### Description
Accesses the reflection component of the material.
```text
public virtual MaterialMap Reflection;
```

#### Conditions
Read / Write
### Reflectivity

#### Description
Accesses the refelectivity of the material. A higher value indicates a highly reflective material.
```text
public virtual double Reflectivity;
```

#### Conditions
Read / Write
### Refraction

#### Description
Accesses the refraction component of the material.
```text
public virtual MaterialRefractionComponent Refraction;
```

#### Conditions
Read / Write
### SelfIllumination

#### Description
Accesses the self-illumination property of the material.
```text
public virtual double SelfIllumination;
```

#### Conditions
Read / Write
### Specular

#### Description
Accesses the specular component of the material.
```text
public virtual MaterialSpecularComponent Specular;
```

#### Conditions
Read / Write
### Translucence

#### Description
Accesses the translucence value of the material.
```text
public virtual double Translucence;
```

#### Conditions
Read / Write
### TransmittanceScale

#### Description
Accesses the transmittance scale.
```text
public double TransmittanceScale;
```

#### Conditions
Read / Write
### TwoSided

#### Description
Assesses if the material is two-sided.
```text
public bool TwoSided;
```

#### Conditions
Read / Write