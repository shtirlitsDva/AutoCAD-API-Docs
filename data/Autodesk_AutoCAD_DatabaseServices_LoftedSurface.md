# LoftedSurface Class

## Overview

#### Description
This .NET class wraps the AcDbLoftedSurface ObjectARX class. 
This class represents a lofted surface entity. It provides methods to create and manipulate ASM surfaces.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Surface
            Autodesk.AutoCAD.DatabaseServices.LoftedSurface
```

```text
public class LoftedSurface : Surface;
```

#### See Also
LoftOptions

## Members

### Constructors

- [LoftedSurface](#loftedsurface)

### Methods

- [CreateLoftedSurface](#createloftedsurface)
- [GetCrossSectionProfile](#getcrosssectionprofile)
- [GetGuideProfile](#getguideprofile)

### Other

- [AutoCAD.DatabaseServices.LoftedSurface.LoftSurfaceType Enumeration](#autocad.databaseservices.loftedsurface.loftsurfacetype-enumeration)

### Properties

- [Closed](#closed)
- [CrossSectionProfiles](#crosssectionprofiles)
- [CrossSections](#crosssections)
- [EndCrossSectionContinuity](#endcrosssectioncontinuity)
- [EndCrossSectionMagnitude](#endcrosssectionmagnitude)
- [EndGuideCurveContinuity](#endguidecurvecontinuity)
- [EndGuideCurveMagnitude](#endguidecurvemagnitude)
- [GuideCurves](#guidecurves)
- [GuideProfiles](#guideprofiles)
- [LoftOptions](#loftoptions)
- [NumberOfCrossSections](#numberofcrosssections)
- [NumberOfGuideCurves](#numberofguidecurves)
- [PathEntity](#pathentity)
- [PathProfile](#pathprofile)
- [StartCrossSectionContinuity](#startcrosssectioncontinuity)
- [StartCrossSectionMagnitude](#startcrosssectionmagnitude)
- [StartGuideCurveContinuity](#startguidecurvecontinuity)
- [StartGuideCurveMagnitude](#startguidecurvemagnitude)
- [SurfaceType](#surfacetype)


## Constructors Details

### LoftedSurface

#### Description
Default constructor.
```text
public LoftedSurface();
```

### CreateLoftedSurface

#### Description
Creates a lofted surface from the given curves using the specified options. The curves must be either all open or all closed. If the curves are all closed, then this function will accept a point entity as the first and/or last list entry. Each curve in the guideCurves list must intersect each of the cross-section curves, so the guide curves form a net-like structure with the cross-section curves. Both the cross-section curves and the guide curves will lie on the resulting surface. If any guide curves are passed in this list, then pathCurve should be null. If pathCurve is non-null, then the resulting surface will follow the shape of this curve as much as possible. This curve does not need to intersect the cross-section curves and does not even need to be near the cross sections. If this parameter is non-null, then guideCurves should be an empty list.
```text
public virtual void CreateLoftedSurface(
    Entity\[\] crossSections, 
    Entity\[\] guideCurves, 
    Entity pathCurve, 
    Autodesk.AutoCAD.DatabaseServices.LoftOptions loftOptions
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity[] crossSections | Input array of curve entities to be used as cross sections for the lofting operation |
| Entity[] guideCurves | Input optional array of guide curves |
| Entity pathCurve | Input path curve |
| Autodesk.AutoCAD.DatabaseServices.LoftOptions loftOptions | Input loft options |

### GetCrossSectionProfile

#### Description
Returns the cross section profile at zero-based index. The returned object contains the cross section entity and edge data if the profile is for an edge or set of edges, and also contains the continuity and takeoff vector magnitude if idx references the first or last profile. The caller is responsible for deleting the returned pointer.
```text
public LoftProfile GetCrossSectionProfile(
    int idx
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int idx | Input index of cross section. |

#### Returns
Cross section profile.
### GetGuideProfile

#### Description
Returns the guide profile at zero-based index. The returned object contains the guide entity and edge data if the profile is for an edge or set of edges. The caller is responsible for deleting the returned pointer.
```text
public LoftProfile GetGuideProfile(
    int idx
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int idx | Input index of guide. |

#### Returns
Guide profile.
### AutoCAD.DatabaseServices.LoftedSurface.LoftSurfaceType Enumeration

#### Description
This enum represents the type of lofted surface.
```text
public enum LoftSurfaceType {
  LoftSurface,
  BlendSurface,
  NetworkSurface
}
```


## Properties Details

### Closed

#### Description
Indicates whether the lofted surface is closed.
```text
public bool Closed;
```

#### Conditions
Read / write
### CrossSectionProfiles

#### Description
Gets the list of cross section profiles that were used to create the surface. 
The returned objects contain the cross section entity and edge data if the profile is for an edge or set of edges, and also contains the continuity and takeoff vector magnitude for the first and last profiles. The caller is responsible for deleting all pointers in the output list.
```text
public LoftProfile CrossSectionProfiles;
```

#### Conditions
Read-only
### CrossSections

#### Description
Accesses the number of cross sections.
```text
public Entity CrossSections;
```

#### Conditions
Read / Write
### EndCrossSectionContinuity

#### Description
Gets and set the continuity at the last cross section. 0, 1, or 2 which corresponds to G0, G1, or G2.
```text
public int EndCrossSectionContinuity;
```

#### Parameters
| Parameters | Description |
| --- | --- |
| value | Input new continuity (must be 0, 1, or 2). |

### EndCrossSectionMagnitude

#### Description
Gets and sets the magnitude of the surface takeoff vector at the last cross section, magnitude of the surface takeoff vector at the first profile. 
Sets the magnitude of the surface takeoff vector at the last cross section and recreates the surface.
```text
public double EndCrossSectionMagnitude;
```

#### Conditions
Read / write
### EndGuideCurveContinuity

#### Description
Gets the continuity at the last guide. 0, 1, or 2 which corresponds to G0, G1, or G2.
```text
public int EndGuideCurveContinuity;
```

#### Conditions
Read / write
### EndGuideCurveMagnitude

#### Description
Gets and sets the magnitude of the surface takeoff vector at the last guide, magnitude of the surface takeoff vector at the first profile. 
Sets the magnitude of the surface takeoff vector at the last guide and recreates the surface (must be non-negative).
```text
public double EndGuideCurveMagnitude;
```

#### Conditions
Read / write
### GuideCurves

#### Description
Accesses the Autodesk.AutoCAD.DatabaseServices.Entity[] guide curves.
```text
public Entity GuideCurves;
```

#### Conditions
Read-only
### GuideProfiles

#### Description
Gets the list of guide profiles that were used to create the surface. The returned objects contain the guide entity and edge data if the profile is for an edge or set of edges. The caller is responsible for deleting all pointers in the output list.
```text
public LoftProfile GuideProfiles;
```

#### Conditions
Read-only
### LoftOptions

#### Description
Gets the loft options used to create this surface.
```text
public Autodesk.AutoCAD.DatabaseServices.LoftOptions LoftOptions;
```

#### Conditions
Read / write
### NumberOfCrossSections

#### Description
Gets the number of cross sections for the surface.
```text
public int NumberOfCrossSections;
```

#### Conditions
Read-only
### NumberOfGuideCurves

#### Description
Gets the number of guides for the surface.
```text
public int NumberOfGuideCurves;
```

#### Conditions
Read-only
### PathEntity

#### Description
Gets the path curve of the surface, or null if no path profile was used to create the surface. If the path is for an edge or set of edges then the edge curve will be returned. The caller should not delete this pointer.
```text
public Entity PathEntity;
```

#### Conditions
Read-only
### PathProfile

#### Description
Gets the path profile that was used to create the surface, or null if no path was used. The returned object contains the guide entity and edge data if the profile is for an edge or set of edges.
```text
public LoftProfile PathProfile;
```

#### Conditions
Read-only
### StartCrossSectionContinuity

#### Description
Gets the continuity at the first cross section. Sets the continuity at the first cross section and recreates the surface. Input new continuity (must be 0, 1, or 2).
```text
public int StartCrossSectionContinuity;
```

#### Conditions
Read / write
### StartCrossSectionMagnitude

#### Description
Gets the magnitude of the surface takeoff vector at the first cross section, magnitude of the surface takeoff vector at the first profile. 
Sets the magnitude of the surface takeoff vector at the first cross section and recreates the surface (must be non-negative).
```text
public double StartCrossSectionMagnitude;
```

#### Conditions
Read / write
### StartGuideCurveContinuity

#### Description
Gets the continuity at the first guide. Input new continuity (must be 0, 1, or 2).
```text
public int StartGuideCurveContinuity;
```

### StartGuideCurveMagnitude

#### Description
Gets the magnitude of the surface takeoff vector at the first guide, magnitude of the surface takeoff vector at the first profile. 
Sets the magnitude of the surface takeoff vector at the first guide and recreates the surface (must be non-negative).
```text
public double StartGuideCurveMagnitude;
```

#### Conditions
Read / write
### SurfaceType

#### Description
Gets the type of lofted surface: ordinary loft, blend, or network.
```text
public LoftSurfaceType SurfaceType;
```

#### Conditions
Read-only