# PatternDefinition Structure

## Overview

#### Description
This class encapsulates the data returned by the Hatch.getPatternDefinitionAt() ObjectARX function. 
That function gets the pattern definition line data from the hatch entity at the selected pattern line.
```text
public struct PatternDefinition {
}
```

#### See Also
[Hatch](Autodesk_AutoCAD_DatabaseServices_Hatch.md "Hatch Class")

## Members

### Constructors

- [PatternDefinition](#patterndefinition)

### Methods

- [GetDashes](#getdashes)

### Properties

- [Angle](#angle)
- [BaseX](#basex)
- [BaseY](#basey)
- [OffsetX](#offsetx)
- [OffsetY](#offsety)


## Constructors Details

### PatternDefinition

#### Description
Constructs a new object.
```text
public PatternDefinition(
    double patternAngle, 
    Point2d basePoint, 
    Point2d offsetVector, 
    DoubleCollection dashOffsets
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double patternAngle | Input pattern angle |
| Point2d basePoint | Input base coordinates |
| Point2d offsetVector | Input offset coordinates |
| DoubleCollection dashOffsets | Input dash offsets |

### GetDashes

#### Description
Returns a collection of values that specify the dashes in the pattern definition.
```text
public DoubleCollection GetDashes();
```

### Angle

#### Description
Accesses the pattern angle
```text
public double Angle;
```

#### Conditions
Read-only
### BaseX

#### Description
Accesses the baseX coordinate.
```text
public double BaseX;
```

#### Conditions
Read-only
### BaseY

#### Description
Accesses the baseY coordinate.
```text
public double BaseY;
```

#### Conditions
Read-only
### OffsetX

#### Description
Accesses the offsetX coordinate.
```text
public double OffsetX;
```

#### Conditions
Read-only
### OffsetY

#### Description
Accesses the offsetY coordinate.
```text
public double OffsetY;
```

#### Conditions
Read-only