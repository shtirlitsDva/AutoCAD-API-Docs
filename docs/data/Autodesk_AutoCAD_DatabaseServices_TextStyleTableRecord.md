# TextStyleTableRecord Class

## Overview

#### Description
This .NET class wraps the AcDbTextStyleTableRecord ObjectARX class. 
Objects of this class represent the records that are found in the TextStyleTable (known as the "Style" table in DXF). Each of these records represents a specific set of text parameters such as font, default size, relative x scaling, vertical or horizontal, etc.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTableRecord
        Autodesk.AutoCAD.DatabaseServices.TextStyleTableRecord
```

```text
public class TextStyleTableRecord : SymbolTableRecord;
```

### Constructors

- [TextStyleTableRecord](#textstyletablerecord)

### Properties

- [BigFontFileName](#bigfontfilename)
- [FileName](#filename)
- [FlagBits](#flagbits)
- [Font](#font)
- [IsShapeFile](#isshapefile)
- [IsVertical](#isvertical)
- [ObliquingAngle](#obliquingangle)
- [PriorSize](#priorsize)
- [TextSize](#textsize)
- [XScale](#xscale)


## Constructors Details

### TextStyleTableRecord

#### Description
Constructor.
```text
public TextStyleTableRecord();
```

### BigFontFileName

#### Description
Returns with string, file name, pointing to the name of the big font file for this text style.
```text
public string BigFontFileName;
```

#### Conditions
Read / Write
### FileName

#### Description
Returns with file name pointing to a copy of the name of the font file for this text style.
```text
public string FileName;
```

#### Conditions
Read / Write
### FlagBits

#### Description
Returns the textStyle flagBits value. Only the second and third bits are used. If the second bit is set it indicates that the text is drawn backward (that is, mirrored in X). If the third bit is set it indicates that the text is drawn upside down (that is, mirrored in Y).
```text
public byte FlagBits;
```

#### Conditions
Read / Write
### Font

#### Description
Returns the font definition data from the text style record. The returned values are the typeface, the bold and italics style attributes, the character set, and the pitch and family attributes.
```text
public virtual FontDescriptor Font;
```

#### Conditions
Read / Write
### IsShapeFile

#### Description
This returns true when the text font file is interpreted as a shape record, otherwise it returns false when it is interpreted as a text record.
```text
public bool IsShapeFile;
```

#### Conditions
Read / Write
### IsVertical

#### Description
Returns true if and only if text drawn with this text style is drawn vertically.
```text
public bool IsVertical;
```

#### Conditions
Read / Write
### ObliquingAngle

#### Description
Returns the obliquing angle for the TextStyleTableRecord. 
The obliquing angle is the angle from the text's vertical; that is, the top of the text "slants" relative to the bottom--the same as the slope in this _italic_ text. Positive angles slant characters forward at their tops. Negative angles have 2pi added to them to convert them to their positive equivalent.
```text
public double ObliquingAngle;
```

#### Conditions
Read / Write
### PriorSize

#### Description
Returns the text height used for the last text created using this Text Style. This value is updated automatically by AutoCAD after the creation of any text object that references this TextStyleTableRecord. If the textSize value for this textStyle is 0, then the priorSize value is used by AutoCAD as the default text height for the next text created using this Text Style.
```text
public double PriorSize;
```

#### Conditions
Read / Write
### TextSize

#### Description
Returns the default text size for text drawn with this textStyle. 
If the text size value is 0, then each use of the AutoCAD text and dtext commands prompt for a text height to use in creating the text entity. If textSize is non-zero, the text and dtext commands will not prompt for a text height and will use this value.
```text
public double TextSize;
```

#### Conditions
Read / Write
### XScale

#### Description
This property returns the width factor (also referred to as the relative X-scale factor) for the TextStyleTableRecord. 
The widthFactor is applied to the text's width to allow the width to be adjusted independently of the height. For example, if the widthFactor value is 0.8, then the text is drawn with a width that is 80% of its normal "unadjusted" width.
```text
public double XScale;
```

#### Conditions
Read / Write