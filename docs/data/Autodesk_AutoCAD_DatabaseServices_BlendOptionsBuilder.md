# BlendOptionsBuilder Class

## Overview

#### Description
Used to build the BlendOptions.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.BlendOptionsBuilder
```

```text
public class BlendOptionsBuilder;
```

### Methods

- [ToBlendOptions](#toblendoptions)

### Properties

- [CoplanarDirection](#coplanardirection)
- [CoplanarPoint](#coplanarpoint)
- [DriveMode](#drivemode)
- [Quality](#quality)
- [Simplify](#simplify)
- [Solid](#solid)


## Methods Details

### ToBlendOptions

#### Description
Returns the generated BlendOptions.
```text
public BlendOptions ToBlendOptions();
```

### CoplanarDirection

#### Description
Gets and sets the coplanar direction option.
```text
public Vector3d? CoplanarDirection;
```

#### Conditions
Read / write
### CoplanarPoint

#### Description
Gets and sets the coplanar point option.
```text
public Point3d? CoplanarPoint;
```

#### Conditions
Read / write
### DriveMode

#### Description
Gets and sets the driveMode option.
```text
public BlendOptions.DriveModeType DriveMode;
```

#### Conditions
Read / write
### Quality

#### Description
Gets and sets the quality option.
```text
public uint Quality;
```

#### Conditions
Read / write
### Simplify

#### Description
Gets and sets the simplify option.
```text
public bool Simplify;
```

#### Conditions
Read / write
### Solid

#### Description
Gets and sets the solid option.
```text
public bool Solid;
```

#### Conditions
Read / write