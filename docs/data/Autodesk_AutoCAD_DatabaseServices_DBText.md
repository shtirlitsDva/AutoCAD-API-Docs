# DBText Class

## Overview

#### Description
This .NET class wraps the AcDbText ObjectARX class. 
It is the representation for the TEXT entity within AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.DBText
            Autodesk.AutoCAD.DatabaseServices.AttributeDefinition
            Autodesk.AutoCAD.DatabaseServices.AttributeReference
```

```text
public class DBText : Entity;
```

### Constructors

- [DBText](#dbtext)

### Methods

- [AdjustAlignment](#adjustalignment)
- [ConvertFieldToText](#convertfieldtotext)
- [CorrectSpelling](#correctspelling)

### Properties

- [AlignmentPoint](#alignmentpoint)
- [Height](#height)
- [HorizontalMode](#horizontalmode)
- [IsDefaultAlignment](#isdefaultalignment)
- [IsMirroredInX](#ismirroredinx)
- [IsMirroredInY](#ismirrorediny)
- [Justify](#justify)
- [Normal](#normal)
- [Oblique](#oblique)
- [Position](#position)
- [Rotation](#rotation)
- [TextString](#textstring)
- [TextStyleName](#textstylename)
- [Thickness](#thickness)
- [VerticalMode](#verticalmode)
- [WidthFactor](#widthfactor)


## Constructors Details

### DBText

#### Description
Default constructor.
```text
public DBText();
```

### AdjustAlignment

#### Description
Normally when a text entity is closed, the text's position and alignment points are adjusted according to the text's justification settings and the text style. But, if the text entity is embedded in another entity, it will never be closed in which case it won't automatically be adjusted. Or, if the text is added to a transaction before it's first close(), and the graphics are flushed to the screen before the outermost transaction ends, the text will be displayed before the automatic adjustment takes place. 
This method allows a way to cause the text to be adjusted on non-database resident text entities or text entities within transactions. 
When this method is called, the database used must also be the current working database (as returned by HostApplicationServices()->workingDatabase()), the text entity must have non-NULL text string data and a valid text style objectId that resides in the database being used.
```text
public virtual void AdjustAlignment(
    Database alternateDatabaseToUse
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database alternateDatabaseToUse | Database to be used if the text entity is not in a database (this argument is ignored if the text entity is in a database) |

### ConvertFieldToText

#### Description
If the text contains fields, this function converts them to text and removes the fields. It does not evaluate the fields before converting them.
```text
public void ConvertFieldToText();
```

### CorrectSpelling

#### Description
This function runs the spell checker on the text to correct any spelling errors. The spell checker is an AutoCAD-specific function, so this method may not be implemented for other database library uses. 
Returns 0 if completed successfully (with errors fixed or no errors found), otherwise returns 1.
```text
public int CorrectSpelling();
```

### AlignmentPoint

#### Description
Accesses the alignment point of the text.
```text
public Point3d AlignmentPoint;
```

#### Conditions
Read / Write
### Height

#### Description
Accesses the height of the text.
```text
public double Height;
```

#### Conditions
Read / Write
### HorizontalMode

#### Description
Accesses the horizontal mode of the text.
```text
public TextHorizontalMode HorizontalMode;
```

#### Conditions
Read / Write
### IsDefaultAlignment

#### Description
Returns true if the text is in a default alignment.
```text
public bool IsDefaultAlignment;
```

#### Conditions
Read-only
### IsMirroredInX

#### Description
Accesses whether the text is mirrored in the _X_ direction (that is, it appears backward in the horizontal direction). Set to false if it is not mirrored.
```text
public bool IsMirroredInX;
```

#### Conditions
Read / Write
### IsMirroredInY

#### Description
Accesses whether the text is mirrored in the _Y_ direction (that is, it appears upside down). Set to false if it is not mirrored.
```text
public bool IsMirroredInY;
```

#### Conditions
Read / Write
### Justify

#### Description
Accesses the justification point(s) of the text.
```text
public Autodesk.AutoCAD.DatabaseServices.AttachmentPoint Justify;
```

#### Conditions
Read / Write
### Normal

#### Description
Accesses the normal vector of the plane containing the text. The normal vector is in WCS coordinates.
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
### Oblique

#### Description
Accesses the oblique angle (in radians) of the text. The obliquing angle is the angle from the text's vertical; that is, the top of the text "slants" relative to the bottom, the same as the slope in this italic text. Positive angles slant characters forward at their tops. Negative angles have 2pi added to them to convert them to their positive equivalent.
```text
public double Oblique;
```

#### Conditions
Read / Write
### Position

#### Description
Accesses the insertion point of the text in WCS coordinates.
```text
public Point3d Position;
```

#### Conditions
Read / Write
### Rotation

#### Description
Accesses the rotation angle of the text. The rotation angle is relative to the X axis of the text's OCS, with positive angles going counterclockwise when looking down the Z axis towards the origin. The OCS X axis is determined by using the text's normal, the WCS Z axis, and the arbitrary axis algorithm.
```text
public double Rotation;
```

#### Conditions
Read / Write
### TextString

#### Description
Accesses the null-terminated text string used by the Text object. The text string can be up to 256 bytes long (not including the null terminator). The application calling this function is responsible for releasing the memory used by the returned string.
```text
public string TextString;
```

#### Conditions
Read / Write
### TextStyleName

#### Description
Accesses the name of the text style used.
```text
public string TextStyleName;
```

#### Conditions
Read-only
### Thickness

#### Description
Accesses the thickness of the text. The thickness is the text's dimension along its normal vector direction (sometimes called the extrusion direction).
```text
public double Thickness;
```

#### Conditions
Read / Write
### VerticalMode

#### Description
Accesses the vertical mode of the text.
```text
public TextVerticalMode VerticalMode;
```

#### Conditions
Read / Write
### WidthFactor

#### Description
Accesses the width factor (also referred to as the relative X-scale factor) for the text. The width factor is applied to the text's width to allow the width to be adjusted independently of the height. For example, if the width factor value is 0.8, then the text is drawn with a width that is 80% of its normal "unadjusted" width.
```text
public double WidthFactor;
```

#### Conditions
Read / Write