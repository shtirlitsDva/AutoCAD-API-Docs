# RapidRTRenderSettings Class

## Overview

#### Description
Container for all properties relating to the rapid RT renderer. See the base class RenderSettings for more information.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.RenderSettings
        Autodesk.AutoCAD.DatabaseServices.RapidRTRenderSettings
```

```text
public class RapidRTRenderSettings : RenderSettings;
```

### Constructors

- [RapidRTRenderSettings](#rapidrtrendersettings)

### Methods

- [CopyFrom](#copyfrom)

### Properties

- [FilterHeight](#filterheight)
- [FilterType](#filtertype)
- [FilterWidth](#filterwidth)
- [LightingModel](#lightingmodel)
- [RenderLevel](#renderlevel)
- [RenderTarget](#rendertarget)
- [RenderTime](#rendertime)


## Constructors Details

### RapidRTRenderSettings

#### Description
Default constructor.
```text
public RapidRTRenderSettings();
```

### CopyFrom

#### Description
Copy all the render settings from an AcDbRapidRTRenderSettings object.
```text
public void CopyFrom(
    RapidRTRenderSettings srcObject
);
```

### FilterHeight

#### Description
Returns the filter height.
```text
public float FilterHeight;
```

#### Conditions
Read / Write
### FilterType

#### Description
Returns the filter type.
```text
public RapidRTFilterType FilterType;
```

#### Conditions
Read / Write
### FilterWidth

#### Description
Returns the filter width.
```text
public float FilterWidth;
```

#### Conditions
Read / Write
### LightingModel

#### Description
Returns the lighting model.
```text
public RapidRTLightingMode LightingModel;
```

#### Conditions
Read / Write
### RenderLevel

#### Description
Returns the render level.
```text
public int RenderLevel;
```

#### Conditions
Read / Write
### RenderTarget

#### Description
Return the render target.
```text
public RapidRTRenderTarget RenderTarget;
```

#### Conditions
Read / Write
### RenderTime

#### Description
Get the render time of the RapidRT render settings.
```text
public int RenderTime;
```

#### Conditions
Read / Write