# Autodesk.AutoCAD.DatabaseServices.LoftOptionsNormalOption Enumeration

## Overview

#### Description
This .NET class wraps the AcDbLoftOptions::NormalOption ObjectARX enum. 
It is an enumerated type for specifying plane normal lofting.
```text
public enum LoftOptionsNormalOption {
  NoNormal,
  FirstNormal,
  LastNormal,
  EndsNormal,
  AllNormal,
  UseDraftAngles
}
```

#### Members
| Members | Description |
| --- | --- |
| NoNormal | When set to this value, plane normal lofting is turned off and the system will compute the surface direction at each cross-section |
| FirstNormal | When set to this value, the direction of the surface at the first cross-section will be the same as the plane normal of the cross-section |
| LastNormal | When set to this value, the direction of the surface at the last cross-section will be the same as the plane normal of the cross-section |
| EndsNormal | When set to this value, the direction of the surface at the first and last cross-sections will be the same as the plane normal of the cross-section |
| AllNormal | When set to this value, the direction of the surface at the each cross-section will be the same as the plane normal of the cross-section |
| UseDraftAngles |