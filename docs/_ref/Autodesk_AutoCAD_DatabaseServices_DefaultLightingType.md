# Autodesk.AutoCAD.DatabaseServices.DefaultLightingType Enumeration

## Overview

#### Description
This .NET enum wraps the AcGiViewportTraits.DefaultLightingType ObjectARX enum. 
Enumerates the types of default lights available for viewports and full renders. One of these types is used when no user lights are specified, or when user lights are overridden by a call to SetDefaultLightingOn().
```text
public enum DefaultLightingType {
  OneDistantLight,
  TwoDistantLights
}
```

#### Members
| Members | Description |
| --- | --- |
| OneDistantLight | Default lighting is provided by one distant light and one ambient light. This matches the display characteristics of previous AutoCAD releases |
| TwoDistantLights | Default lighting is provided by two distant lights and one ambient light. This is the default in AutoCAD. |