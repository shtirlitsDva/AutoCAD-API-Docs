# LinetypeTableRecord Class

## Overview

#### Description
This .NET class wraps the AcDbLinetypeTableRecord ObjectARX class. 
Objects of this class represent records in the LinetypeTable. Each of these records contains the information about a linetype in the drawing database. 
Within the LinetypeTableRecord, the dashes (line segments that make up characteristics of the linetype) are stored in a list with an index that is zero based. If the linetype is complex, then embedded shapes or text strings are stored in the list at the same index as the dash that preceded them in the linetype definition. So there will always be a dashLength for any valid index in the list, even if there is a shape or text string sharing the same index. When the linetype is elaborated, a shape's insertion point will coincide with the end of the dash that it shares an index with.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTableRecord
        Autodesk.AutoCAD.DatabaseServices.LinetypeTableRecord
```

```text
public class LinetypeTableRecord : SymbolTableRecord;
```

### Constructors

- [LinetypeTableRecord](#linetypetablerecord)

### Methods

- [DashLengthAt](#dashlengthat)
- [SetDashLengthAt](#setdashlengthat)
- [SetShapeIsUcsOrientedAt](#setshapeisucsorientedat)
- [SetShapeIsUprightAt](#setshapeisuprightat)
- [SetShapeNumberAt](#setshapenumberat)
- [SetShapeOffsetAt](#setshapeoffsetat)
- [SetShapeRotationAt](#setshaperotationat)
- [SetShapeScaleAt](#setshapescaleat)
- [SetShapeStyleAt](#setshapestyleat)
- [SetTextAt](#settextat)
- [ShapeIsUcsOrientedAt](#shapeisucsorientedat)
- [ShapeIsUprightAt](#shapeisuprightat)
- [ShapeNumberAt](#shapenumberat)
- [ShapeOffsetAt](#shapeoffsetat)
- [ShapeRotationAt](#shaperotationat)
- [ShapeScaleAt](#shapescaleat)
- [ShapeStyleAt](#shapestyleat)
- [TextAt](#textat)

### Properties

- [AsciiDescription](#asciidescription)
- [Comments](#comments)
- [IsScaledToFit](#isscaledtofit)
- [NumDashes](#numdashes)
- [PatternLength](#patternlength)


## Constructors Details

### LinetypeTableRecord

#### Description
Default constructor. 
ObjectARX applications should not need to use this constructor. The Database class creates its own copy and there is no other place to use the constructor.
```text
public LinetypeTableRecord();
```

### DashLengthAt

#### Description
This function returns the length (in AutoCAD drawing units--the dash will appear this length when the linetype scale is 1.0) of the index'th dash in the LinetypeTableRecord. 
index must be greater than or equal to zero, but less than the value returned from LinetypeTableRecord.NumDashes. index is a zero-based index (shapes and text strings have the same index as the dash that precedes them in the linetype definition) with the first dash in the linetype being index 0. 
For more information on linetype definitions and dash lengths, see the "Linetypes" section of the _AutoCAD Customization Guide_.
```text
public double DashLengthAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of dash to get length of |

### SetDashLengthAt

#### Description
This function sets value to be the length (in AutoCAD drawing units--the dash will appear this length when the linetype scale is 1.0) of the index'th dash in the LinetypeTableRecord. 
index must be greater than or equal to zero, but less than the value returned from LinetypeTableRecord.NumDashes. index is a zero-based index (shapes and text strings have the same index as the dash that precedes them in the linetype definition) with the first dash in the linetype being index 0. 
For more information on linetype definitions and dash lengths, see the "Linetypes" section of the _AutoCAD Customization Guide_.
```text
public void SetDashLengthAt(
    int index, 
    double value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of dash to set |
| double value | Input length value for the dash |

### SetShapeIsUcsOrientedAt

#### Description
This function sets the UcsOriented bit (bit 1) for the shape (or text string) at position index in the LinetypeTableRecord. If IsUcsOriented is true, then the bit is set and the shape will orient itself relative to the current UCS when displayed. If IsUcsOriented is false, then the shape will orient itself relative to the line it's embedded within. 
index must be greater than or equal to zero, but less than the value returned from NumDashes. index is a zero-based index (shapes and text strings have the same index as the dash that precedes them in the linetype definition) with the first dash in the linetype being index 0. 
For more information on linetype definitions and embedded shapes, see the "Linetypes" section of the _AutoCAD Customization Guide_.
```text
public void SetShapeIsUcsOrientedAt(
    int index, 
    [MarshalAs(UnmanagedType.U1)] bool isOriented
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of shape (or text string) to get |
| [MarshalAs(UnmanagedType.U1)] bool isOriented | Input Boolean indicating whether or not the shape is to be oriented relative to the current UCS |

### SetShapeIsUprightAt

#### Description
Sets the UprightAt bit for the shape (or text string) at position index in the LinetypeTableRecord. If isUprightAt is True, then the bit is set and the shape will orient itself relative to the line it's embedded within. If isUprightAt is False, then the shape will orient itself relative to the current UCS if isUcsOriented is True. 
index must be greater than or equal to zero, but less than the value returned from NumDashes. index is a zero-based index (shapes and text strings have the same index as the dash that precedes them in the linetype definition) with the first dash in the linetype being index 0. 
For more information on linetype definitions and embedded shapes, see the "Linetypes" section of the _AutoCAD Customization Guide_.
```text
public void SetShapeIsUprightAt(
    int index, 
    [MarshalAs(UnmanagedType.U1)] bool isUpright
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of shape (or text string) to get |
| [MarshalAs(UnmanagedType.U1)] bool isUpright | Input bool to control how the shape is to orient itself |

### SetShapeNumberAt

#### Description
This function sets the index'th dash to embed the shape identified by shapeNumber (the shape's shapeNumber from its shape file). If no shape is to be used at index, then shapeNumber should be 0. 
index must be greater than or equal to zero, but less than the value returned from LinetypeTableRecord.NumDashes. index is a zero-based index (shapes and text strings have the same index as the dash that precedes them in the linetype definition) with the first dash in the linetype being index 0. 
For more information on linetype definitions and embedded shapes, see the "Linetypes" section of the _AutoCAD Customization Guide_.
```text
public void SetShapeNumberAt(
    int index, 
    int shapeNumber
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index at which to set the shape |
| int shapeNumber | Input shape identification number of the shape to use |

### SetShapeOffsetAt

#### Description
This function sets the LinetypeTableRecord to use the X and Y coordinates of offset as the X and Y offsets for the shape (or text string) at position index. If there is to be no shape at index, then the X and Y components of offset should be 0.0. 
index must be greater than or equal to zero, but less than the value returned from LinetypeTableRecord.NumDashes. index is a zero-based index (shapes and text strings have the same index as the dash that precedes them in the linetype definition) with the first dash in the linetype being index 0. 
For more information on linetype definitions and embedded shapes, see the "Linetypes" section of the _AutoCAD Customization Guide_.
```text
public void SetShapeOffsetAt(
    int index, 
    Vector2d offset
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index at which to set the shape (or text string) offset |
| Vector2d offset | Input vector whose X and Y values are the WCS X and Y offsets for the shape |

### SetShapeRotationAt

#### Description
This function sets the rotation angle (in radians) of the shape (or text string) at position index in the LinetypeTableRecord. If the isUcsOriented bit is set in the LinetypeTableRecord, then the rotation angle is relative to the current UCS. Otherwise it's relative to the line's direction. Positive angles are counter-clockwise when looking down the normal of the plane containing the text (or the UCS normal if isUcsOriented). 
index must be greater than or equal to zero, but less than the value returned from LinetypeTableRecord.NumDashes. index is a zero-based index (shapes and text strings have the same index as the dash that precedes them in the linetype definition) with the first dash in the linetype being index 0. 
For more information on linetype definitions and embedded shapes, see the "Linetypes" section of the _AutoCAD Customization Guide_.
```text
public void SetShapeRotationAt(
    int index, 
    double rotation
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of shape (or text string) to get |
| double rotation | Input rotation angle for the shape (or text string) |

### SetShapeScaleAt

#### Description
This function sets the LinetypeTableRecord to use scale as the scale of the shape at position index. If there is to be no shape at index, then scale should be 1.0. 
index must be greater than or equal to zero, but less than the value returned from LinetypeTableRecord.NumDashes. index is a zero-based index (shapes and text strings have the same index as the dash that precedes them in the linetype definition) with the first dash in the linetype being index 0. 
For more information on linetype definitions and embedded shapes, see the "Linetypes" section of the _AutoCAD Customization Guide_.
```text
public void SetShapeScaleAt(
    int index, 
    double scale
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index at which to set the shape (or text string) scale |
| double scale | Input scale factor to be applied to the shape |

### SetShapeStyleAt

#### Description
This function sets the LinetypeTableRecord to use value as the ObjectId of the TextStyleTableRecord for the shape (or textStyle if it's a text string instead of a shape) at position index. If there is to be no shape or text at index, then value should be Null. 
index must be greater than or equal to zero, but less than the value returned from LinetypeTableRecord.NumDashes. index is a zero-based index (shapes and text strings have the same index as the dash that precedes them in the linetype definition) with the first dash in the linetype being index 0. 
For more information on linetype definitions and embedded shapes, see the "Linetypes" section of the _AutoCAD Customization Guide_.
```text
public void SetShapeStyleAt(
    int index, 
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index at which to set the shape (or text string) scale |
| ObjectId id | Input scale factor to be applied to the shape (or text string) |

### SetTextAt

#### Description
This function sets the LinetypeTableRecord to use a copy of the string pointed to by text as the text string at position index. 
index must be greater than or equal to zero, but less than the value returned from LinetypeTableRecord.NumDashes. index is a zero-based index (text strings have the same index as the dash that precedes them in the linetype definition) with the first dash in the linetype being index 0. 
For more information on linetype definitions and embedded shapes, see the "Linetypes" section of the _AutoCAD Customization Guide_.
```text
public void SetTextAt(
    int index, 
    string value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index at which to set the text string |
| string value | Input pointer to the text to use at index |

### ShapeIsUcsOrientedAt

#### Description
This function returns true if the shape (or text string) at position index in the LinetypeTableRecord has the UcsOriented bit (bit 1) set in its shape flags otherwise it returns false.
```text
public bool ShapeIsUcsOrientedAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of shape (or text string) to get |

### ShapeIsUprightAt

#### Description
Gets the value of the UprightAt bit for the shape (or text string) set at position index in the LinetypeTableRecord.
```text
public bool ShapeIsUprightAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of shape (or text string) to get |

#### Returns
Returns True if the shape (or text string) at position index has the UprightAt bit set in its shape flags, otherwise it returns False.
### ShapeNumberAt

#### Description
This function returns the shape number of the shape at position index in the LinetypeTableRecord. If there is no shape at index, then 0 is returned.
```text
public int ShapeNumberAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of shape (or text string) to get |

### ShapeOffsetAt

#### Description
This function returns an Vector2d object whose X and Y coordinates represent the X and Y offsets of the shape (or text string) at position index in the LinetypeTableRecord. If there is no shape at index, then the X and Y components of the returned vector will be 0.0.
```text
public Vector2d ShapeOffsetAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of shape (or text string) to get |

### ShapeRotationAt

#### Description
This function returns of the rotation angle (in radians) of the shape (or text string) at position index in the LinetypeTableRecord. If the isUcsOriented bit is set in the LinetypeTableRecord, then the rotation angle is relative to the current UCS, otherwise it's relative to the line's direction. Positive angles are counter-clockwise when looking down the normal of the plane containing the text (or the UCS normal if isUcsOriented) If there is no shape at index, then 0 is returned.
```text
public double ShapeRotationAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of shape (or text string) to get |

### ShapeScaleAt

#### Description
This functions return the scale factor of the shape (or text string) at position index in the LinetypeTableRecord. If there is no shape at index, then 1.0 is returned.
```text
public double ShapeScaleAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of shape (or text string) to get |

### ShapeStyleAt

#### Description
This function returns the ObjectId of the TextStyleTableRecord of the shape (or textStyle if it's a text string instead of a shape) at position index in the LinetypeTableRecord. If there is no shape or text at index, then Null is returned.
```text
public ObjectId ShapeStyleAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of shape (or text string) to get |

### TextAt

#### Description
This function returns with text pointing to the text string at position index in the LinetypeTableRecord.
```text
public string TextAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0-based) of shape (or text string) to get |

### AsciiDescription

#### Description
This function is obsolete and will be eliminated in a future release of ObjectARX. Please use Comments instead.
```text
public string AsciiDescription;
```

#### Conditions
Read / Write
### Comments

#### Description
Accesses the string used by the LinetypeTableRecord to describe the linetype in the same simple ASCII form as you would find in the linetype definition file (in a description field).
```text
public string Comments;
```

#### Conditions
Read / Write
### IsScaledToFit

#### Description
Accesses the alignment type for the LinetypeTableRecord. If ScaledToFit is true, the alignment wll be "scaled to fit" (equivalent to an 'S' in the alignment field of the linetype definition). If ScaledToFit is false, the alignment will not be "scaled to fit" (equivalent to an 'A' in the alignment field of the linetype definition).
```text
public bool IsScaledToFit;
```

#### Conditions
Read / Write
### NumDashes

#### Description
Accesses the number of dashes in the LinetypeTableRecord. 
For more information on linetype definitions, see the "Linetypes" section of the _AutoCAD Customization Guide_.
```text
public int NumDashes;
```

#### Conditions
Read / Write
### PatternLength

#### Description
Accesses the length (in AutoCAD drawing units--the pattern will appear this length when the linetype scale is 1.0) of the pattern in the LinetypeTableRecord. The pattern length is the total length of all dashes (including pen up spaces). Embedded shapes or text strings do not add to the pattern length because they are overlaid and do not interrupt the actual dash pattern. 
For more information on linetype definitions, see the "Linetypes" section of the _AutoCAD Customization Guide_.
```text
public double PatternLength;
```

#### Conditions
Read / Write