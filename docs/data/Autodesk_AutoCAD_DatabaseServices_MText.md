# MText Class

## Overview

#### Description
This .NET class wraps the AcDbMText ObjectARX class. 
The MText class represents the MTEXT entity type within AutoCAD. 
An MTEXT object is a multiline text entity that stores a specified line width and performs automatic word wrap to keep the text within this width boundary.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.MText
```

```text
public class MText : Entity;
```

#### Notes
  * Each change to an MText object can cause the text contents to be reformatted. On larger objects, this can be a time-consuming operation. To prevent this reformatting, make any MText.Contents call the last operation before closing the object.
  * Rotation works with the current UCS normal in the AutoCAD editor and the object coordinate system (formerly known as the ECS) associated with this normal. The value that this property sets is actually the MText direction. The Direction property (which deals with a WCS vector) is a much more direct and less confusing way to get the same result.

### Constructors

- [MText](#mtext)

### Methods

- [ConvertFieldToText](#convertfieldtotext)
- [CorrectSpelling](#correctspelling)
- [ExplodeFragments(MTextFragmentCallback)](#explodefragments(mtextfragmentcallback))
- [ExplodeFragments(MTextFragmentCallback, object)](#explodefragments(mtextfragmentcallback,-object))
- [ExplodeFragments(MTextFragmentCallback, object, WorldDraw)](#explodefragments(mtextfragmentcallback,-object,-worlddraw))
- [GetBoundingPoints](#getboundingpoints)
- [GetColumnHeight](#getcolumnheight)
- [SetAttachmentMovingLocation](#setattachmentmovinglocation)
- [SetColumnHeight](#setcolumnheight)
- [SetContentsRtf](#setcontentsrtf)
- [SetDynamicColumns](#setdynamiccolumns)
- [SetStaticColumns](#setstaticcolumns)

### Properties

- [ActualHeight](#actualheight)
- [ActualWidth](#actualwidth)
- [AlignChange](#alignchange)
- [Ascent](#ascent)
- [Attachment](#attachment)
- [BackgroundFill](#backgroundfill)
- [BackgroundFillColor](#backgroundfillcolor)
- [BackgroundScaleFactor](#backgroundscalefactor)
- [BackgroundTransparency](#backgroundtransparency)
- [BlockBegin](#blockbegin)
- [BlockEnd](#blockend)
- [ColorChange](#colorchange)
- [ColumnAutoHeight](#columnautoheight)
- [ColumnCount](#columncount)
- [ColumnFlowReversed](#columnflowreversed)
- [ColumnGutterWidth](#columngutterwidth)
- [ColumnType](#columntype)
- [ColumnWidth](#columnwidth)
- [Contents](#contents)
- [ContentsRTF](#contentsrtf)
- [Descent](#descent)
- [Direction](#direction)
- [FlowDirection](#flowdirection)
- [FontChange](#fontchange)
- [Height](#height)
- [HeightChange](#heightchange)
- [LineBreak](#linebreak)
- [LineSpaceDistance](#linespacedistance)
- [LineSpacingFactor](#linespacingfactor)
- [LineSpacingStyle](#linespacingstyle)
- [Location](#location)
- [NonBreakSpace](#nonbreakspace)
- [Normal](#normal)
- [ObliqueChange](#obliquechange)
- [OverlineOff](#overlineoff)
- [OverlineOn](#overlineon)
- [ParagraphBreak](#paragraphbreak)
- [Rotation](#rotation)
- [ShowBorders](#showborders)
- [StackStart](#stackstart)
- [StrikethroughOff](#strikethroughoff)
- [StrikethroughOn](#strikethroughon)
- [Text](#text)
- [TextHeight](#textheight)
- [TextStyleId](#textstyleid)
- [TextStyleName](#textstylename)
- [TrackChange](#trackchange)
- [UnderlineOff](#underlineoff)
- [UnderlineOn](#underlineon)
- [UseBackgroundColor](#usebackgroundcolor)
- [Width](#width)
- [WidthChange](#widthchange)


## Constructors Details

### MText

#### Description
The constructor creates a default, empty object. The default values are: 
| location | 0.0,0.0,0.0 |
| --- | --- |
| normal | (0.0,0.0,1.0) |
| direction | (1.0,0.0,0.0) |
| width | 0.0 |
| textStyle | NULL |
| textHeight | 0.0 |
| attachment | AcDbMText::kTopLeft |
| flowDirection | AcDbMText::kByStyle |
| contents | NULL |

In order to be useful, you must call the TextStyle and Contents member properties with appropriate values. Other member properties may be used to further modify the object, but are not required before the object can be added to an Database.
```text
public MText();
```

### ConvertFieldToText

#### Description
If the contents of MText contains fields, this function converts them to text and removes the fields. It does not evaluate the fields before converting them.
```text
public void ConvertFieldToText();
```

### CorrectSpelling

#### Description
This function is intended to be used internally, and requires that additional speller initialization be performed before calling. It cannot be used from within ObjectARX applications.
```text
public int CorrectSpelling();
```

### ExplodeFragments(MTextFragmentCallback)

#### Description
This .NET method wraps the AcDbMText.explodeFragments() ObjectARX function by calling the ExplodeFragments(MTextFragmentCallback enumerator, Object userData, WorldDraw context) method with both userData and context set to null. 
This function runs through the MText object's text string breaking it up into fragments, calling the fragment elaboration function enumerator for each fragment. The current WorldDraw object is used. 
The elaboration function is called once for each fragment. enumerator points to an MTextFragment structure that's passed into the elaboration function. enumerator provides all the information about the text fragment for which the elaboration function is being called. 
The elaboration function should return 1 to continue the elaboration operation, or 0 to terminate the operation. 
In the context of this function, a fragment is a piece of text that lies on the same "word-wrapped" line and has a specific set of characteristics (that is, font, color, height, width, etc.). So, each word-wrap newline and each change in text characteristics starts a new fragment.
```text
public void ExplodeFragments(
    MTextFragmentCallback enumerator
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| MTextFragmentCallback enumerator | Input fragment elaboration callback function |

### ExplodeFragments(MTextFragmentCallback, object)

#### Description
This .NET method wraps the AcDbMText.explodeFragments() ObjectARX function by calling the ExplodeFragments(MTextFragmentCallback enumerator, Object userData, WorldDraw context) method with context set to null. 
This function runs through the MText object's text string breaking it up into fragments, calling the fragment elaboration function enumerator for each fragment. The current WorldDraw object is used. 
The elaboration function is called once for each fragment. enumerator points to an MTextFragment structure that's passed into the elaboration function. enumerator provides all the information about the text fragment for which the elaboration function is being called. userData contains the value of the param argument passed into the ExplodeFragments() member function. userData can point to anything desired--it is only passed on to the elaboration function enumerator. userData provides a means to pass application-specific data into the elaboration function. 
The elaboration function should return 1 to continue the elaboration operation, or 0 to terminate the operation. 
In the context of this function, a fragment is a piece of text that lies on the same "word-wrapped" line and has a specific set of characteristics (that is, font, color, height, width, etc.). So, each word-wrap newline and each change in text characteristics starts a new fragment.
```text
public void ExplodeFragments(
    MTextFragmentCallback enumerator, 
    object userData
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| MTextFragmentCallback enumerator | Input fragment elaboration callback function |
| object userData | Input user data |

### ExplodeFragments(MTextFragmentCallback, object, WorldDraw)

#### Description
This function runs through the MText object's text string breaking it up into fragments, calling the fragment elaboration function enumerator for each fragment. The WorldDraw object of context is used. 
The elaboration function is called once for each fragment. enumerator points to an MTextFragment structure that's passed into the elaboration function. enumerator provides all the information about the text fragment for which the elaboration function is being called. userData contains the value of the param argument passed into the ExplodeFragments() member function. userData can point to anything desired--it is only passed on to the elaboration function enumerator. userData provides a means to pass application-specific data into the elaboration function. 
The elaboration function should return 1 to continue the elaboration operation, or 0 to terminate the operation. 
In the context of this function, a fragment is a piece of text that lies on the same "word-wrapped" line and has a specific set of characteristics (that is, font, color, height, width, etc.). So, each word-wrap newline and each change in text characteristics starts a new fragment.
```text
public void ExplodeFragments(
    MTextFragmentCallback enumerator, 
    object userData, 
    WorldDraw context
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| MTextFragmentCallback enumerator | Input fragment elaboration callback function |
| object userData | Input user data |
| WorldDraw context | Input WorldDraw object |

### GetBoundingPoints

#### Description
Appends 4 points to the collection as follows: 
```text
[0] == top left corner of text area
[1] == top right corner of text area
[2] == bottom left corner of text area
[3] == bottom right corner of text area
```

Returns the collection of points (in WCS) defining bounding box of text as displayed on screen
```text
public Point3dCollection GetBoundingPoints();
```

### GetColumnHeight

#### Description
Gets the height of the specified column. 
Only valid for dynamic, manual height columns.
```text
public double GetColumnHeight(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | The column's height to get |

### SetAttachmentMovingLocation

#### Description
This member function changes the attachment of the MTEXT object, just as Attachment does, however it also moves the location (as per Location) in order to keep the current extent unchanged. This differs from Attachment, which keeps the Location constant, thus moving the extent relative to that location. 
The AttachmentPoint enumerated type has the following possible values: 
  * TopLeft
  * TopCenter
  * TopRight
  * MiddleLeft
  * MiddleCenter
  * MiddleRight
  * BottomLeft
  * BottomCenter
  * BottomRight

Example: 
Changing attachment point from Top Left to Bottom Right. (* is attachment Location) 
```text
|  |
|  |
|  |
|  |

  --+--+--+--*--+--+--+--
             |ABC     :
             |XYZ     :
             |- - - - +
```

using Attachment: 
```text
   + - - - -|
   :     ABC|
   :     XYZ|
 --+--+--+--*--+--+--+--
|  |
|  |
|  |
|  |

```

using setAttachmentMovingLocation: 
```text

|  |
|  |
|  |
|  |

  --+--+--+--+--+--+--+--
             |     ABC:
             |     XYZ:
             |- - - - *     
```

```text
public void SetAttachmentMovingLocation(
    Autodesk.AutoCAD.DatabaseServices.AttachmentPoint value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.AttachmentPoint value | Input desired AttachmentPoint type value |

### SetColumnHeight

#### Description
Sets the height of the specified column. 
Only valid for dynamic, manual height columns.
```text
public void SetColumnHeight(
    int index, 
    double height
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | The column's height to set |
| double height | Column height |

### SetContentsRtf

#### Description
This method sets the contents of the MText object from the RTF-encoded text string pointed to by unnamed. RTF codes are translated to MText codes. Fonts, colors, tabs, and indents are preserved. Bullets and numbered lists are mapped to hanging paragraphs using the implied setting for tabs and indents.
```text
public int SetContentsRtf(
    string value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string value | Input RTF-encoded string |

### SetDynamicColumns

#### Description
Sets column type to DynamicColumns with specified width, gutter, and auto height setting
```text
public void SetDynamicColumns(
    double width, 
    double gutter, 
    [MarshalAs(UnmanagedType.U1)] bool auto_height
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double width | Input new column width |
| double gutter | Input new column gutter |
| [MarshalAs(UnmanagedType.U1)] bool auto_height | Input new auto-height setting |

### SetStaticColumns

#### Description
Sets column type to StaticColumns with specified width, gutter, and number of columns.
```text
public void SetStaticColumns(
    double width, 
    double gutter, 
    int count
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double width | Input new column width |
| double gutter | Input new column gutter |
| int count | Input new auto-height setting |

### ActualHeight

#### Description
Accesses the overall height of the bounding rectangle that surrounds the formatted text.
```text
public double ActualHeight;
```

#### Conditions
Read-only
### ActualWidth

#### Description
Accesses the overall width of the bounding rectangle that surrounds the formatted text. Note that this value may be different from the value returned by MText.Width.
```text
public double ActualWidth;
```

#### Conditions
Read-only
### AlignChange

#### Description
Accesses the string "A". This function can be used in place of the string constant "A" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "A" indicates an alignment change.
```text
public static string AlignChange;
```

#### Conditions
Read-only
### Ascent

#### Description
Accesses the height of the maximum ascender for the first line of the text. This value can be used with the Text.Descent function to help align multiple MText objects in a table or grid.
```text
public double Ascent;
```

#### Conditions
Read-only
### Attachment

#### Description
Accesses a value describing the attachment point for the MText object. 
The attachment point value determines how the text will be oriented around the insertion point of the MText object. For example, if the attachment point is MText.MiddleCenter, then the text body will be displayed such that the insertion point appears at the geometric center of the text body. 
The property has these valid values: 
AttachmentPoint::TopLeft
AttachmentPoint::TopCenter
AttachmentPoint::TopRight
AttachmentPoint::MiddleLeft
AttachmentPoint::MiddleCenter
AttachmentPoint::MiddleRight
AttachmentPoint::BottomLeft
AttachmentPoint::BottomCenter
AttachmentPoint::BottomRight
```text
public Autodesk.AutoCAD.DatabaseServices.AttachmentPoint Attachment;
```

#### Returns
Returns Acad::eOk if successful or Acad::eInvalidInput if the data passed in is not acceptable
#### Conditions
Read / Write
### BackgroundFill

#### Description
Assesses whether background fill is on.
```text
public bool BackgroundFill;
```

#### Conditions
Read / Write
### BackgroundFillColor

#### Description
Accesses the current background fill color.
```text
public Autodesk.AutoCAD.Colors.Color BackgroundFillColor;
```

#### Conditions
Read / Write
### BackgroundScaleFactor

#### Description
```text
public double BackgroundScaleFactor;
```

#### Conditions
Read-only Accesses 
Read / Write
### BackgroundTransparency

#### Description
Accesses the background fill transparency.
```text
public Transparency BackgroundTransparency;
```

#### Conditions
Read / Write
### BlockBegin

#### Description
Accesses the string "{". This function can be used in place of the string constant "{" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "{" indicates a block beginning.
```text
public static string BlockBegin;
```

#### Conditions
Read-only
### BlockEnd

#### Description
Accesses the string "}". This function can be used in place of the string constant "}" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "}" indicates a block ending.
```text
public static string BlockEnd;
```

#### Conditions
Read-only
### ColorChange

#### Description
Accesses the string "C". This function can be used in place of the string constant "C" in order to make your code more understandable. When used in the string that's returned from MText.contents, the "C" indicates a color change.
```text
public static string ColorChange;
```

#### Conditions
Read-only
### ColumnAutoHeight

#### Description
Accesses the auto height setting, which specifies whether dynamic columns use the MText height or a per-column user-defined height. 
Only valid for dynamic columns.
```text
public bool ColumnAutoHeight;
```

#### Conditions
Read / Write
### ColumnCount

#### Description
Accesses the number of columns.
```text
public int ColumnCount;
```

#### Conditions
Read / Write
### ColumnFlowReversed

#### Description
Accesses the flow reversed setting, which determines how columns are added.
```text
public bool ColumnFlowReversed;
```

#### Conditions
Read / Write
### ColumnGutterWidth

#### Description
Accesses the column gutter width.
```text
public double ColumnGutterWidth;
```

#### Conditions
Read / Write
### ColumnType

#### Description
Accesses the column type.
```text
public Autodesk.AutoCAD.DatabaseServices.ColumnType ColumnType;
```

#### Conditions
Read / Write
### ColumnWidth

#### Description
Accesses the width of each column.
```text
public double ColumnWidth;
```

#### Conditions
Read / Write
### Contents

#### Description
Accesses the character contents of the MText object. Formatting data used for word wrap calculations is removed before the string is copied.
```text
public string Contents;
```

#### Conditions
Read / Write
### ContentsRTF

#### Description
Returns an RTF encoded string that is a translated version of the contents of the AcDbMText object. MText codes are translated to RTF codes. Fonts, colors, tabs, and indents are preserved. The conversion uses 24 as the default point size. That is, text with no height override will have a point size of 24 and text with a height override will have a point size of the height override multiplied by 24. The caller is responsible for freeing the memory used by the returned string (preferrably by using acutDelString().
```text
public string ContentsRTF;
```

#### Conditions
Read / Write
### Descent

#### Description
Accesses the height of the maximum descender for the last line of the text. This value can be used with the MText.Ascent property to help align multiple MText objects in a table or grid.
```text
public double Descent;
```

#### Conditions
Read-only
### Direction

#### Description
Accesses a Vector3d (in WCS) representing the X axis ("horizontal") for the text. 
This direction vector is used to determine the text flow direction.
```text
public Vector3d Direction;
```

#### Conditions
Read / Write
### FlowDirection

#### Description
Accesses the direction that the text string follows from its start to its finish.
```text
public Autodesk.AutoCAD.DatabaseServices.FlowDirection FlowDirection;
```

#### Conditions
Read / Write
### FontChange

#### Description
Accesses the string "F". This function can be used in place of the string constant "F" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "F" indicates a font change.
```text
public static string FontChange;
```

#### Conditions
Read-only
### Height

#### Description
Accesses the height value of the font.
```text
public double Height;
```

#### Conditions
Read / Write
### HeightChange

#### Description
Accesses the string "H". This function can be used in place of the string constant "H" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "H" indicates a height change.
```text
public static string HeightChange;
```

#### Conditions
Read-only
### LineBreak

#### Description
Accesses the string "p". This function can be used in place of the string constant "p" in order to make your code more understandable. When used in a string that is returned from MText.Contents, the "p" indicates a line break.
```text
public static string LineBreak;
```

#### Conditions
Read-only
### LineSpaceDistance

#### Description
Accesses the spacing between lines of text.
```text
public double LineSpaceDistance;
```

#### Conditions
Read / Write
### LineSpacingFactor

#### Description
Accesses the line spacing factor (a value between 0.25 and 4.00). See LineSpacingStyle for more information and examples.
```text
public double LineSpacingFactor;
```

#### Conditions
Read / Write
### LineSpacingStyle

#### Description
Accesses the line spacing style, either AtLeast (the line spacing is a minimum value) or Exactly (the line spacing is absolute). See LineSpacingStyle for more information and examples.
```text
public Autodesk.AutoCAD.DatabaseServices.LineSpacingStyle LineSpacingStyle;
```

#### Conditions
Read / Write
### Location

#### Description
Accesses the insertion point of the MText object.
```text
public Point3d Location;
```

#### Conditions
Read / Write
### NonBreakSpace

#### Description
Accesses the string "~". This function can be used in place of the string constant "~" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "~" indicates a nonbreaking space.
```text
public static string NonBreakSpace;
```

#### Conditions
Read-only
### Normal

#### Description
Accesses the unit normal vector of the MText object.
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
### ObliqueChange

#### Description
Accesses the string "Q". This function can be used in place of the string constant "Q" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "Q" indicates an oblique change.
```text
public static string ObliqueChange;
```

#### Conditions
Read-only
### OverlineOff

#### Description
Accesses the string "o". This function can be used in place of the string constant "o" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "o" indicates overline off.
```text
public static string OverlineOff;
```

#### Conditions
Read-only
### OverlineOn

#### Description
Accesses the string "O". This function can be used in place of the string constant "O" in order to make your code more understandable. When used in the string that's returned from Text.Contents, the "O" indicates overline on.
```text
public static string OverlineOn;
```

#### Conditions
Read-only
### ParagraphBreak

#### Description
Accesses the string "P". This function can be used in place of the string constant "P" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "P" indicates a paragraph break.
```text
public static string ParagraphBreak;
```

#### Conditions
Read-only
### Rotation

#### Description
Accesses the angle between the X axis of the OCS for the normal vector of the current AutoCAD editor's UCS and the projection of the MText object's direction vector onto the plane of the AutoCAD editor's current UCS. The rotation value is in radians, with positive angles as counterclockwise when looking down the UCS normal towards the UCS origin. 
Note that the direction vector need not be orthogonal to the normal vector.
```text
public double Rotation;
```

#### Conditions
Read / Write
### ShowBorders

#### Description
Gets the flag controlling mtext border's visibility.
```text
public bool ShowBorders;
```

#### Conditions
Read / Write
### StackStart

#### Description
Accesses the string "S". This function can be used in place of the string constant "S" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "S" indicates a stack start.
```text
public static string StackStart;
```

#### Conditions
Read-only
### StrikethroughOff

#### Description
Gets the mtext strike-through turning off string. This wraps the AcDbMText::strikethroughOn().
```text
public static string StrikethroughOff;
```

#### Conditions
Read / Write
### StrikethroughOn

#### Description
Gets the mtext strike-through turning on string. This wraps the AcDbMText::strikethroughOn().
```text
public static string StrikethroughOn;
```

#### Conditions
Read / Write
### Text

#### Description
Accesses the MText contents with formatting removed.
```text
public string Text;
```

#### Conditions
Read-only
### TextHeight

#### Description
Accesses the nominal text height of the MText object.
```text
public double TextHeight;
```

#### Conditions
Read / Write
### TextStyleId

#### Description
Accesses the objectId of the textStyle currently referenced by the MText object.
```text
public ObjectId TextStyleId;
```

#### Conditions
Read / Write
### TextStyleName

#### Description
Accesses the name of the current text style.
```text
public string TextStyleName;
```

#### Conditions
Read-only
### TrackChange

#### Description
Accesses the string "T". This function can be used in place of the string constant "T" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "T" indicates a tracking change.
```text
public static string TrackChange;
```

#### Conditions
Read-only
### UnderlineOff

#### Description
Accesses the string "l". This function can be used in place of the string constant "l" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "l" indicates underline off.
```text
public static string UnderlineOff;
```

#### Conditions
Read-only
### UnderlineOn

#### Description
Accesses the string "L". This function can be used in place of the string constant "L" in order to make your code more understandable. When used in the string that's returned from MText.Contents, the "L" indicates underline on.
```text
public static string UnderlineOn;
```

#### Conditions
Read-only
### UseBackgroundColor

#### Description
Accesses if background color is in use for this object.
```text
public bool UseBackgroundColor;
```

#### Conditions
Read / Write
### Width

#### Description
Accesses the maximum width setting used by the MText object for word wrap formatting. It is possible that none of the lines resulting from word wrap formatting will reach this width value. Words which exceed this width value will not be broken, but will extend beyond the given width. The MText.ActualWidth member function returns the actual width of the text, regardless of the maximum width setting. 
If the value is 0.0, then word wrap is currently disabled.
```text
public double Width;
```

#### Conditions
Read / Write
### WidthChange

#### Description
Accesses the string "W", which indicates a width change.
```text
public static string WidthChange;
```

#### Conditions
Read-only