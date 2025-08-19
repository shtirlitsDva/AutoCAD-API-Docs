# MlineStyle Class

## Overview

#### Description
This .NET class wraps the AcDbMlineStyle ObjectARX class. 
MlineStyle class objects are used to store the information about the number, linetypes, and offsets of multi-line line patterns to be used by Mline entities. 
An mline style consists of a series of elements, each of which is a line at a given offset from an axis (there may or may not be an element on the axis). 
MlineStyle objects are stored in the ACAD_MLINESTYLE dictionary within the Named Object Dictionary of Database. 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.MlineStyle
```

```text
public class MlineStyle : DBObject;
```

#### See Also
Dictionary, [Database](Autodesk_AutoCAD_DatabaseServices_Database.md "Database Class")

## Members

### Constructors

- [MlineStyle](#mlinestyle)

### Methods

- [Reset](#reset)
- [Set](#set)

### Properties

- [Description](#description)
- [Elements](#elements)
- [EndAngle](#endangle)
- [EndInnerArcs](#endinnerarcs)
- [EndRoundCap](#endroundcap)
- [EndSquareCap](#endsquarecap)
- [FillColor](#fillcolor)
- [Filled](#filled)
- [Name](#name)
- [ShowMiters](#showmiters)
- [StartAngle](#startangle)
- [StartInnerArcs](#startinnerarcs)
- [StartRoundCap](#startroundcap)
- [StartSquareCap](#startsquarecap)


## Constructors Details

### MlineStyle

#### Description
No initialization done in this constructor.
```text
public MlineStyle();
```

### Reset

#### Description
Resets the MlineStyle information.
```text
public void Reset();
```

### Set

#### Description
Copies the information from source into the MlineStyle. 
If checkIfReferenced is true and the mline style object is referenced, then the set operation will be aborted. This indicates that it is not safe to change this mline style object.
```text
public void Set(
    MlineStyle source, 
    [MarshalAs(UnmanagedType.U1)] bool checkIfReferenced
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| MlineStyle source | Input MlineStyle to copy from |
| [MarshalAs(UnmanagedType.U1)] bool checkIfReferenced | Input Boolean indicating whether to check if the style is referenced |

### Description

#### Description
Accesses the description string for the MlineStyle object. The description string is not used by AutoCAD--it is provided as a place to store some descriptive text about the MlineStyle. The description string shows up in the "Description" edit box of the MlineStyle dialog in AutoCAD. The description string can be up to MSTYLE_DESCRIPTION_LENGTH in length.
```text
public string Description;
```

#### Conditions
Read / Write
### Elements

#### Description
Accesses the elements in use.
```text
public MlineStyleElementCollection Elements;
```

#### Conditions
Read-only
### EndAngle

#### Description
Accesses the angle (in radians) to which the end of mlines using this MlineStyle will be "cut." The default value for the end angle is pi/2 radians.
```text
public double EndAngle;
```

#### Conditions
Read / Write
### EndInnerArcs

#### Description
Accesses if the MlineStyle is set to show inner arcs at the mline ends.
```text
public bool EndInnerArcs;
```

#### Conditions
Read / Write
### EndRoundCap

#### Description
Accesses if the MlineStyle is set to use round endcaps.
```text
public bool EndRoundCap;
```

#### Conditions
Read / Write
### EndSquareCap

#### Description
Accesses if the MlineStyle is set to use square endcaps.
```text
public bool EndSquareCap;
```

#### Conditions
Read / Write
### FillColor

#### Description
Accesses a Color object representing the fill color for the MlineStyle.
```text
public Autodesk.AutoCAD.Colors.Color FillColor;
```

#### Conditions
Read / Write
### Filled

#### Description
Accesses if the MlineStyle has fill set to "on" (that is, mlines referencing the MlineStyle will be filled).
```text
public bool Filled;
```

#### Conditions
Read / Write
### Name

#### Description
Accesses the name string in the MlineStyle. The name string can be up to MSTYLE_NAME_LENGTH in length.
```text
public string Name;
```

#### Conditions
Read / Write
### ShowMiters

#### Description
Accesses if the MlineStyle is set to show miterlines in the mline joints.
```text
public bool ShowMiters;
```

#### Conditions
Read / Write
### StartAngle

#### Description
Accesses the angle (in radians) to which the start of Mlines using this MlineStyle will be "cut." An angle of pi/2 radians is perpendicular to the mline's direction.
```text
public double StartAngle;
```

#### Conditions
Read / Write
### StartInnerArcs

#### Description
Accesses if the MlineStyle is set to show inner arcs at the mline starts.
```text
public bool StartInnerArcs;
```

#### Conditions
Read / Write
### StartRoundCap

#### Description
Accesses if the MlineStyle is set to use round startcaps.
```text
public bool StartRoundCap;
```

#### Conditions
Read / Write
### StartSquareCap

#### Description
Accesses if the MlineStyle is set to use square startcaps.
```text
public bool StartSquareCap;
```

#### Conditions
Read / Write