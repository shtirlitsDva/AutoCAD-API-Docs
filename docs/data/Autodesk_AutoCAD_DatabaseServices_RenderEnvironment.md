# RenderEnvironment Class

## Overview

#### Description
This .NET class wraps the AcDbRenderEnvironment ObjectARX class. 
This is a container class for environment-related properties, including fog / depth cue and the global environment image. Only one object of this type is maintained by the per-drawing RenderGlobal object, at ACAD_RENDER_ENVIRONMENT in the named object dictionary.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.RenderEnvironment
```

```text
public class RenderEnvironment : DBObject;
```

#### See Also
RenderGlobal

## Members

### Constructors

- [DoubleRangeParameter.DoubleRangeParameter](#doublerangeparameter.doublerangeparameter)
- [RenderEnvironment](#renderenvironment)

### Other

- [DoubleRangeParameter Structure](#doublerangeparameter-structure)

### Properties

- [Distances](#distances)
- [DoubleRangeParameter.Far](#doublerangeparameter.far)
- [DoubleRangeParameter.Near](#doublerangeparameter.near)
- [EnvironmentImageEnabled](#environmentimageenabled)
- [EnvironmentImageFileName](#environmentimagefilename)
- [FogBackgroundEnabled](#fogbackgroundenabled)
- [FogColor](#fogcolor)
- [FogDensity](#fogdensity)
- [FogEnabled](#fogenabled)


## Constructors Details

### DoubleRangeParameter.DoubleRangeParameter

#### Description
This constructor initializes the near and fear values.
```text
public DoubleRangeParameter(
    double n, 
    double f
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double n | Near distance |
| double f | Far distance |

### RenderEnvironment

#### Description
Constructor.
```text
public RenderEnvironment();
```

### DoubleRangeParameter Structure

#### Description
This class is a container for the near and far distance parameters used by the RenderEnvironment.FogDensity property.
```text
public struct DoubleRangeParameter {
}
```

### Distances

#### Description
Accesses the near and far distances of the fog effect.
```text
public DoubleRangeParameter Distances;
```

#### Conditions
Read / Write
### DoubleRangeParameter.Far

#### Description
Accesses the far value.
```text
public double Far;
```

#### Conditions
Read-only
### DoubleRangeParameter.Near

#### Description
Accesses the near value.
```text
public double Near;
```

#### Conditions
Read-only
### EnvironmentImageEnabled

#### Description
Assesses whether to use an image for the environment.
```text
public bool EnvironmentImageEnabled;
```

#### Conditions
Read / Write
### EnvironmentImageFileName

#### Description
Accesses the full path and file name of the environment image.
```text
public string EnvironmentImageFileName;
```

#### Conditions
Read / Write
### FogBackgroundEnabled

#### Description
Assesses whether the fog affects the background.
```text
public bool FogBackgroundEnabled;
```

#### Conditions
Read / Write
### FogColor

#### Description
Accesses the color of the fog effect.
```text
public EntityColor FogColor;
```

#### Conditions
Read / Write
### FogDensity

#### Description
Accesses the density of the fog effect.
```text
public DoubleRangeParameter FogDensity;
```

#### Conditions
Read / Write
### FogEnabled

#### Description
Assesses whether a fog effect is enabled.
```text
public bool FogEnabled;
```

#### Conditions
Read / Write