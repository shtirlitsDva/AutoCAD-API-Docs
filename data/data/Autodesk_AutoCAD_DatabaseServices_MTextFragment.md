# MTextFragment Class

## Overview

#### Description
This .NET class wraps the AcDbMTextFragment ObjectARX struct. 
This class is used to describe a fragment of text as extracted by the ExplodeFragments() function. Each fragment consists of a piece of text with a unique combination of style information (font, size, color, and so on).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.MTextFragment
```

```text
public sealed class MTextFragment : DisposableWrapper;
```

### Methods

- [GetOverLinePoints](#getoverlinepoints)
- [GetStrikethroughPoints](#getstrikethroughpoints)
- [GetUnderLinePoints](#getunderlinepoints)

### Properties

- [BigFont](#bigfont)
- [Bold](#bold)
- [CapsHeight](#capsheight)
- [Color](#color)
- [Direction](#direction)
- [Extents](#extents)
- [Italic](#italic)
- [Location](#location)
- [Normal](#normal)
- [ObliqueAngle](#obliqueangle)
- [Overlined](#overlined)
- [ShxFont](#shxfont)
- [StackBottom](#stackbottom)
- [StackTop](#stacktop)
- [Strikethrough](#strikethrough)
- [Text](#text)
- [TrackingFactor](#trackingfactor)
- [TrueTypeFont](#truetypefont)
- [Underlined](#underlined)
- [WidthFactor](#widthfactor)


## Methods Details

### GetOverLinePoints

#### Description
This function returns an array of two points that define the overline for this object, if any is defined.
```text
public Point3d\[\] GetOverLinePoints();
```

### GetStrikethroughPoints

#### Description
This .NET method wraps the ObjectARX method
```text
public Point3d\[\] GetStrikethroughPoints();
```

### GetUnderLinePoints

#### Description
This function returns an array of two points that define the underline for this object, if any is defined.
```text
public Point3d\[\] GetUnderLinePoints();
```

### BigFont

#### Description
Accesses the bigfont text.
```text
public string BigFont;
```

#### Conditions
Read-only
### Bold

#### Description
Assesses if text is TrueType and bold.
```text
public bool Bold;
```

#### Conditions
Read-only
### CapsHeight

#### Description
Accesses the text height.
```text
public double CapsHeight;
```

#### Conditions
Read-only
### Color

#### Description
Accesses the text color.
```text
public EntityColor Color;
```

#### Conditions
Read-only
### Direction

#### Description
Accesses the text flow direction vector.
```text
public Vector3d Direction;
```

#### Conditions
Read-only
### Extents

#### Description
Accesses the text extents. X-coord is the extents box width. Y-coord is the extents box height.
```text
public Point2d Extents;
```

#### Conditions
Read-only
### Italic

#### Description
Assesses if the text is TrueType and italic.
```text
public bool Italic;
```

#### Conditions
Read-only
### Location

#### Description
Accesses the text insertion point.
```text
public Point3d Location;
```

#### Conditions
Read-only
### Normal

#### Description
Accesses the normal vector.
```text
public Vector3d Normal;
```

#### Conditions
Read-only
### ObliqueAngle

#### Description
Accesses the text oblique angle.
```text
public double ObliqueAngle;
```

#### Conditions
Read-only
### Overlined

#### Description
Assesses if overlining is on.
```text
public bool Overlined;
```

#### Conditions
Read-only
### ShxFont

#### Description
Accesses the SHX font.
```text
public string ShxFont;
```

#### Conditions
Read-only
### StackBottom

#### Description
Assesses if the text is bottom part of stacked text
```text
public bool StackBottom;
```

#### Conditions
Read-only
### StackTop

#### Description
Accesses if the text is top part of stacked text.
```text
public bool StackTop;
```

#### Conditions
Read-only
### Strikethrough

#### Description
This wraps the AcDbMTextFragment::strikePoints[2].
```text
public bool Strikethrough;
```

#### Conditions
Read / Write
### Text

#### Description
Accesses the text string.
```text
public string Text;
```

#### Conditions
Read-only
### TrackingFactor

#### Description
Accesses the text tracking factor.
```text
public double TrackingFactor;
```

#### Conditions
Read-only
### TrueTypeFont

#### Description
Accesses the TrueType font.
```text
public string TrueTypeFont;
```

#### Conditions
Read-only
### Underlined

#### Description
Assesses if underlined is on.
```text
public bool Underlined;
```

#### Conditions
Read-only
### WidthFactor

#### Description
Accesses the text width factor.
```text
public double WidthFactor;
```

#### Conditions
Read-only