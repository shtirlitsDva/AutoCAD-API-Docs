# MLeaderStyle Class

## Overview

#### Description
This .NET class wraps the AcDbMLeaderStyle ObjectARX class. 
This class is the main class used for the multiple leader style object.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.MLeaderStyle
```

```text
public class MLeaderStyle : DBObject;
```

### Constructors

- [MLeaderStyle()](#mleaderstyle())
- [MLeaderStyle(MLeaderStyle)](#mleaderstyle(mleaderstyle))

### Methods

- [GetTextAttachmentType](#gettextattachmenttype)
- [OverwritePropChanged](#overwritepropchanged)
- [PostMLeaderStyleToDb](#postmleaderstyletodb)
- [SetTextAttachmentType](#settextattachmenttype)

### Properties

- [ArrowSize](#arrowsize)
- [ArrowSymbolId](#arrowsymbolid)
- [BlockColor](#blockcolor)
- [BlockConnectionType](#blockconnectiontype)
- [BlockId](#blockid)
- [BlockRotation](#blockrotation)
- [BlockScale](#blockscale)
- [BreakSize](#breaksize)
- [ContentType](#contenttype)
- [DefaultMText](#defaultmtext)
- [DoglegLength](#dogleglength)
- [DrawLeaderOrderType](#drawleaderordertype)
- [DrawMLeaderOrderType](#drawmleaderordertype)
- [EnableBlockRotation](#enableblockrotation)
- [EnableBlockScale](#enableblockscale)
- [EnableDogleg](#enabledogleg)
- [EnableFrameText](#enableframetext)
- [EnableLanding](#enablelanding)
- [ExtendLeaderToText](#extendleadertotext)
- [FirstSegmentAngleConstraint](#firstsegmentangleconstraint)
- [LandingGap](#landinggap)
- [LeaderLineColor](#leaderlinecolor)
- [LeaderLineType](#leaderlinetype)
- [LeaderLineTypeId](#leaderlinetypeid)
- [LeaderLineWeight](#leaderlineweight)
- [MaxLeaderSegmentsPoints](#maxleadersegmentspoints)
- [Name](#name)
- [Scale](#scale)
- [SecondSegmentAngleConstraint](#secondsegmentangleconstraint)
- [TextAlignAlwaysLeft](#textalignalwaysleft)
- [TextAlignmentType](#textalignmenttype)
- [TextAngleType](#textangletype)
- [TextAttachmentDirection](#textattachmentdirection)
- [TextAttachmentType](#textattachmenttype)
- [TextColor](#textcolor)
- [TextHeight](#textheight)
- [TextStyleId](#textstyleid)


## Constructors Details

### MLeaderStyle()

#### Description
Default constructor.
```text
public MLeaderStyle();
```

### MLeaderStyle(MLeaderStyle)

#### Description
Copy constructor.
```text
public MLeaderStyle(
    MLeaderStyle mleaderStyle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| MLeaderStyle | Input object to copy. |

### GetTextAttachmentType

#### Description
Returns text attachment type of MText in MLeader content.
```text
public Autodesk.AutoCAD.DatabaseServices.TextAttachmentType GetTextAttachmentType(
    Autodesk.AutoCAD.DatabaseServices.LeaderDirectionType leaderDirection
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.LeaderDirectionType leaderDirection | Input text leader direction type |

### OverwritePropChanged

#### Description
bool overwritePropChanged () const;
```text
public bool OverwritePropChanged();
```

### PostMLeaderStyleToDb

#### Description
ObjectId styleId postMLeaderStyleToDb (AcDbDatabase* pDb, const ACHAR* styleName);
```text
public ObjectId PostMLeaderStyleToDb(
    Database db, 
    string styleName
);
```

### SetTextAttachmentType

#### Description
Sets text attachment type of MText content to a specific direction leader.
```text
public void SetTextAttachmentType(
    Autodesk.AutoCAD.DatabaseServices.TextAttachmentType textAttachmentType, 
    Autodesk.AutoCAD.DatabaseServices.LeaderDirectionType leaderDirection
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.TextAttachmentType textAttachmentType | Input text attachment type |
| Autodesk.AutoCAD.DatabaseServices.LeaderDirectionType leaderDirection | Input text leader direction types |

### ArrowSize

#### Description
Accesses the arrow size.
```text
public double ArrowSize;
```

#### Conditions
Read / Write
### ArrowSymbolId

#### Description
Accesses the objectId of the arrow symbol.
```text
public ObjectId ArrowSymbolId;
```

#### Conditions
Read / Write
### BlockColor

#### Description
Accesses the block color in block content.
```text
public Autodesk.AutoCAD.Colors.Color BlockColor;
```

#### Conditions
Read / Write
### BlockConnectionType

#### Description
Accesses the block connection type.
```text
public Autodesk.AutoCAD.DatabaseServices.BlockConnectionType BlockConnectionType;
```

#### Conditions
Read / Write
### BlockId

#### Description
Accesses the Id of the block table record referenced by MLeader.
```text
public ObjectId BlockId;
```

#### Conditions
Read / Write
### BlockRotation

#### Description
Accesses the rotation of the block referenced by MLeader.
```text
public double BlockRotation;
```

#### Conditions
Read / Write
### BlockScale

#### Description
Accesses the scale of the block referenced by MLeader.
```text
public Scale3d BlockScale;
```

#### Conditions
Read / Write
### BreakSize

#### Description
Accesses the size of the gap used for breaking leader lines.
```text
public double BreakSize;
```

#### Conditions
Read / Write
### ContentType

#### Description
Accesses the content type.
```text
public Autodesk.AutoCAD.DatabaseServices.ContentType ContentType;
```

#### Conditions
Read / Write
### DefaultMText

#### Description
Accesses the default MText.
```text
public MText DefaultMText;
```

#### Conditions
Read / Write
### DoglegLength

#### Description
Accesses the length of dog-leg leader line.
```text
public double DoglegLength;
```

#### Conditions
Read / Write
### DrawLeaderOrderType

#### Description
Accesses the type of leader drawing order.
```text
public Autodesk.AutoCAD.DatabaseServices.DrawLeaderOrderType DrawLeaderOrderType;
```

#### Conditions
Read / Write
### DrawMLeaderOrderType

#### Description
Accesses the type of MLeader drawing order.
```text
public Autodesk.AutoCAD.DatabaseServices.DrawMLeaderOrderType DrawMLeaderOrderType;
```

#### Conditions
Read / Write
### EnableBlockRotation

#### Description
Assesses if the blockRotation value is enabled
```text
public bool EnableBlockRotation;
```

#### Conditions
Read / Write
### EnableBlockScale

#### Description
Assesses if the blockScale value is enabled.
```text
public bool EnableBlockScale;
```

#### Conditions
Read / Write
### EnableDogleg

#### Description
Assesses if dog-leg leader lines are enabled.
```text
public bool EnableDogleg;
```

#### Conditions
Read / Write
### EnableFrameText

#### Description
Accesses whether or not the text frame is displayed around the MText
```text
public bool EnableFrameText;
```

#### Conditions
Read / Write
### EnableLanding

#### Description
Accesses whether landing of leader line is enabled.
```text
public bool EnableLanding;
```

#### Conditions
Read / Write
### ExtendLeaderToText

#### Description
Gets and sets the value indicating whether horizontal leader lines are automatically extended to text.
```text
public bool ExtendLeaderToText;
```

### FirstSegmentAngleConstraint

#### Description
Accesses the angle constraint of the first segment of leader lines.
```text
public AngleConstraint FirstSegmentAngleConstraint;
```

#### Conditions
Read / Write
### LandingGap

#### Description
Accesses the gap between MText and the tail of leader lines.
```text
public double LandingGap;
```

#### Conditions
Read / Write
### LeaderLineColor

#### Description
Accesses the color of leader lines.
```text
public Autodesk.AutoCAD.Colors.Color LeaderLineColor;
```

#### Conditions
Read / Write
### LeaderLineType

#### Description
Accesses the type of leader lines.
```text
public Autodesk.AutoCAD.DatabaseServices.LeaderType LeaderLineType;
```

#### Conditions
Read / Write
### LeaderLineTypeId

#### Description
Accesses the line type of leader lines.
```text
public ObjectId LeaderLineTypeId;
```

#### Conditions
Read / Write
### LeaderLineWeight

#### Description
Accesses the line weight of leader lines.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight LeaderLineWeight;
```

#### Conditions
Read / Write
### MaxLeaderSegmentsPoints

#### Description
Accesses the max number of leader segment points. When -1, there is no limit to segment points number.
```text
public int MaxLeaderSegmentsPoints;
```

#### Conditions
Read / Write
### Name

#### Description
Accesses the name of the MLeader style.
```text
public string Name;
```

#### Conditions
Read-only
### Scale

#### Description
Accesses the scale of MLeader created by this style.
```text
public double Scale;
```

#### Conditions
Read / Write
### SecondSegmentAngleConstraint

#### Description
Accesses the angle constraint of the second segment of leader lines.
```text
public AngleConstraint SecondSegmentAngleConstraint;
```

#### Conditions
Read / Write
### TextAlignAlwaysLeft

#### Description
Assesses true if the text is set to always align left.
```text
public bool TextAlignAlwaysLeft;
```

#### Conditions
Read / Write
### TextAlignmentType

#### Description
Accesses the text alignment type.
```text
public Autodesk.AutoCAD.DatabaseServices.TextAlignmentType TextAlignmentType;
```

#### Conditions
Read / Write
### TextAngleType

#### Description
Accesses the angle type of text with respect to the last leader line segment.
```text
public Autodesk.AutoCAD.DatabaseServices.TextAngleType TextAngleType;
```

#### Conditions
Read / Write
### TextAttachmentDirection

#### Description
Accesses the value of the text attachment Direction of MText content.
```text
public Autodesk.AutoCAD.DatabaseServices.TextAttachmentDirection TextAttachmentDirection;
```

#### Conditions
Read / write
### TextAttachmentType

#### Description
Two new values: AttachmentCenter and AttachmentLinedCenter.
```text
public Autodesk.AutoCAD.DatabaseServices.TextAttachmentType TextAttachmentType;
```

### TextColor

#### Description
Accesses the text color of MText.
```text
public Autodesk.AutoCAD.Colors.Color TextColor;
```

#### Conditions
Read / Write
### TextHeight

#### Description
Accesses the text height of MText.
```text
public double TextHeight;
```

#### Conditions
Read / Write
### TextStyleId

#### Description
Accesses the objectId of text style.
```text
public ObjectId TextStyleId;
```

#### Conditions
Read / Write