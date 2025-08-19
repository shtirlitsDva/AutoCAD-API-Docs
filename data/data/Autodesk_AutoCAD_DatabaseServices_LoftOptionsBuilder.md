# LoftOptionsBuilder Class

## Overview

#### Description
This is a helper class that is used to populate a DatabaseServices.LoftOptions object from the loft options sysvars.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.LoftOptionsBuilder
```

```text
public class LoftOptionsBuilder;
```

### Constructors

- [LoftOptionsBuilder()](#loftoptionsbuilder())
- [LoftOptionsBuilder(LoftOptions)](#loftoptionsbuilder(loftoptions))

### Methods

- [SetOptionsFromSysvars](#setoptionsfromsysvars)
- [ToLoftOptions](#toloftoptions)

### Properties

- [AlignDirection](#aligndirection)
- [ArcLengthParam](#arclengthparam)
- [Closed](#closed)
- [DraftEnd](#draftend)
- [DraftEndMag](#draftendmag)
- [DraftStart](#draftstart)
- [DraftStartMag](#draftstartmag)
- [NormalOption](#normaloption)
- [NoTwist](#notwist)
- [Ruled](#ruled)
- [Simplify](#simplify)
- [VirtualGuide](#virtualguide)


## Constructors Details

### LoftOptionsBuilder()

#### Description
Default constructor.
```text
public LoftOptionsBuilder();
```

### LoftOptionsBuilder(LoftOptions)

#### Description
This constructor creates an object from an existing LoftOptions object.
```text
public LoftOptionsBuilder(
    LoftOptions value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| LoftOptions value | LoftOptions object to create from |

### SetOptionsFromSysvars

#### Description
Set loft options from the current values of system variables.
```text
public void SetOptionsFromSysvars();
```

### ToLoftOptions

#### Description
Returns a DatabaseServices.LoftOptions object.
```text
public LoftOptions ToLoftOptions();
```

### AlignDirection

#### Description
Accesses the value of the AlignDirection option. This option can be used to orient each of the cross sections so that the normal vector of each cross section points towards the next cross section. The default value of this option is true. If the cross sections are not all oriented in the same direction, then this option should be used to avoid creating a twisted or self-intersecting surface or solid.
```text
public bool AlignDirection;
```

#### Conditions
Read / Write
### ArcLengthParam

#### Description
Accesses the arc length parametrization.
```text
public bool ArcLengthParam;
```

#### Conditions
Read / Write
### Closed

#### Description
Accesses the value of the closed option. If this option is set, then the resulting surface/solid will start and end at the first cross section. If all of the cross sections are closed, then this will result in a torus-like shape. If this option is not set, then the surface or solid will be open or capped with a planar surface at the first and last cross sections. The default value of this option is false. If this option is set, then there must be at least three cross sections.
```text
public bool Closed;
```

#### Conditions
Read / Write
### DraftEnd

#### Description
Accesses the end draft angle in radians. This is the surface take-off direction at the last cross section. The default value of this option is 0, which indicates that no draft angle is defined and the system will compute the optimum angle at the last cross section.
```text
public double DraftEnd;
```

#### Conditions
Read / Write
### DraftEndMag

#### Description
Accesses the end draft magnitude. Controls the magnitude of the surface tangent vector at the last cross-section. The default value of this option is 0, which means that the system will compute the optimum magnitude.
```text
public double DraftEndMag;
```

#### Conditions
Read / Write
### DraftStart

#### Description
Accesses the start draft angle in radians. This is the surface take-off direction at the first cross section. The default value of this option is 0, which indicates that no draft angle is defined and the system will compute the optimum angle at the first cross section.
```text
public double DraftStart;
```

#### Conditions
Read / Write
### DraftStartMag

#### Description
Accesses the start draft magnitude. Controls the magnitude of the surface tangent vector at the first cross-section. The default value of this option is 0, which means that the system will compute the optimum magnitude.
```text
public double DraftStartMag;
```

#### Conditions
Read / Write
### NormalOption

#### Description
Accesses the plane normal option. See LoftOptionsNormalOption for a description of possible values. The default value of this option is NoNormal.
```text
public LoftOptionsNormalOption NormalOption;
```

#### Conditions
Read / Write
### NoTwist

#### Description
Accesses the value of the noTwist option. This option can be used to minimize the amount of twist in the resulting surface or solid when the cross-sections are all closed. The default value of this option is true. If this option is set then the start point of each closed cross-section is aligned with the other cross-sections to minimize twist.
```text
public bool NoTwist;
```

#### Conditions
Read / Write
### Ruled

#### Description
Accesses the value of the ruled option. If this option is set then a ruled surface will be created between each pair of cross sections rather than a single smooth surface. This will result in a much coarser object. The default value of this option is false.
```text
public bool Ruled;
```

#### Conditions
Read / Write
### Simplify

#### Description
Accesses the value of the simplify option. If this option is set, then simple surface types (plane, cylinder, cone, sphere, or torus) will be created whenever all of the cross sections lie on such a surface. Otherwise a general surface type will be created. The default value of this option is true.
```text
public bool Simplify;
```

#### Conditions
Read / Write
### VirtualGuide

#### Description
Accesses the state of the virtual guide option.
```text
public bool VirtualGuide;
```

#### Conditions
Read / Write