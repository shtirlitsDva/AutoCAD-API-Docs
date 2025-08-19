# Autodesk.AutoCAD.DatabaseServices.DxfCode Enumeration

## Overview

#### Description
This .NET class wraps the AcDb::DxfCode ObjectARX enum. 
This enumerated type contains all the primary DXF group code values. 
Ranges of DXF group codes represent certain data types. For example, the codes from 40 to 49 are floating point data values. For many of these ranges, only the first code has an enumerated type name. 
To use one of the code values that is not in the enumerated type, you will need to add an integer to the enumerated type value name. For example, to use DXF group code 41, in your code you would use (DxfReal+1). 
This enumerated type also contains names that have the same integer value. For example, ShapeName and BlockName both have an integer value of 2. This duplication occurs because within AutoCAD the same code value (the integer value) may have different meanings for different contexts. So, each context has a different name in the enumerated type.
```text
public enum DxfCode {
  Alpha = 440,
  Angle = 50,
  ArbitraryHandle = 320,
  AttributePrompt = 3,
  AttributeTag = 2,
  BinaryChunk = 310,
  BlockName = 2,
  Bool = 290,
  CircleSides = 0x48,
  CLShapeName = 4,
  CLShapeText = 9,
  Color = 0x3e,
  ColorName = 430,
  ColorRgb = 420,
  Comment = 0x3e7,
  ControlString = 0x66,
  DashLength = 0x31,
  Description = 3,
  DimBlk1 = 6,
  DimBlk2 = 7,
  DimensionAlternativePrefixSuffix = 4,
  DimensionBlock = 5,
  DimPostString = 3,
  DimStyleName = 3,
  DimVarHandle = 0x69,
  Elevation = 0x26,
  EmbeddedObjectStart = 0x65,
  End = -1,
  ExtendedDataAsciiString = 0x3e8,
  ExtendedDataBinaryChunk = 0x3ec,
  ExtendedDataControlString = 0x3ea,
  ExtendedDataDist = 0x411,
  ExtendedDataHandle = 0x3ed,
  ExtendedDataInteger16 = 0x42e,
  ExtendedDataInteger32 = 0x42f,
  ExtendedDataLayerName = 0x3eb,
  ExtendedDataReal = 0x410,
  ExtendedDataRegAppName = 0x3e9,
  ExtendedDataScale = 0x412,
  ExtendedDataWorldXCoordinate = 0x3f3,
  ExtendedDataWorldXDir = 0x3f5,
  ExtendedDataWorldXDisp = 0x3f4,
  ExtendedDataWorldYCoordinate = 0x3fd,
  ExtendedDataWorldYDir = 0x3ff,
  ExtendedDataWorldYDisp = 0x3fe,
  ExtendedDataWorldZCoordinate = 0x407,
  ExtendedDataWorldZDir = 0x409,
  ExtendedDataWorldZDisp = 0x408,
  ExtendedDataXCoordinate = 0x3f2,
  ExtendedDataYCoordinate = 0x3fc,
  ExtendedDataZCoordinate = 0x406,
  ExtendedInt16 = 400,
  FirstEntityId = -2,
  GradientAngle = 460,
  GradientColCount = 0x1c5,
  GradientColVal = 0x1cf,
  GradientName = 470,
  GradientObjType = 450,
  GradientPatType = 0x1c3,
  GradientShift = 0x1cd,
  GradientTintType = 0x1c4,
  GradientTintVal = 0x1ce,
  Handle = 5,
  HardOwnershipId = 360,
  HardPointerId = 340,
  HasSubentities = 0x42,
  HeaderId = -2,
  Int16 = 70,
  Int32 = 90,
  Int64 = 160,
  Int8 = 280,
  Invalid = -9999,
  LayerLinetype = 0x3d,
  LayerName = 8,
  LayoutName = 410,
  LinetypeAlign = 0x48,
  LinetypeElement = 0x31,
  LinetypeName = 6,
  LinetypePdc = 0x49,
  LinetypeProse = 3,
  LinetypeScale = 0x30,
  LineWeight = 370,
  MlineOffset = 0x31,
  MlineStyleName = 2,
  NormalX = 210,
  NormalY = 220,
  NormalZ = 230,
  Operator = -4,
  PixelScale = 0x2f,
  PlotStyleNameId = 390,
  PlotStyleNameType = 380,
  PReactors = -5,
  Real = 40,
  RegAppFlags = 0x47,
  RenderMode = 0x119,
  ShapeName = 2,
  ShapeScale = 0x2e,
  ShapeXOffset = 0x2c,
  ShapeYOffset = 0x2d,
  SoftOwnershipId = 350,
  SoftPointerId = 330,
  Start = 0,
  Subclass = 100,
  SymbolTableName = 2,
  SymbolTableRecordComments = 4,
  SymbolTableRecordName = 2,
  Text = 1,
  TextBigFontFile = 4,
  TextFontFile = 3,
  TextStyleName = 7,
  Thickness = 0x27,
  TxtSize = 40,
  TxtStyleFlags = 0x47,
  TxtStylePSize = 0x2a,
  TxtStyleXScale = 0x29,
  UcsOrg = 110,
  UcsOrientationX = 0x6f,
  UcsOrientationY = 0x70,
  ViewBackClip = 0x2c,
  ViewBrightness = 0x8d,
  ViewContrast = 0x8e,
  ViewFrontClip = 0x2b,
  ViewHeight = 0x2d,
  ViewLensLength = 0x2a,
  ViewMode = 0x47,
  ViewportActive = 0x44,
  ViewportAspect = 0x29,
  ViewportGrid = 0x4c,
  ViewportHeight = 40,
  ViewportIcon = 0x4a,
  ViewportNumber = 0x45,
  ViewportSnap = 0x4b,
  ViewportSnapAngle = 50,
  ViewportSnapPair = 0x4e,
  ViewportSnapStyle = 0x4d,
  ViewportTwist = 0x33,
  ViewportVisibility = 0x43,
  ViewportZoom = 0x49,
  ViewWidth = 0x29,
  Visibility = 60,
  XCoordinate = 10,
  XDataStart = -3,
  XDictionary = -6,
  XInt16 = 170,
  XReal = 140,
  XRefPath = 1,
  XTextString = 300,
  XXInt16 = 270,
  YCoordinate = 20,
  ZCoordinate = 30
}
```

#### Members

| Members | Description |
| --- | --- |
| Alpha = 440 | Base entity property; Alpha is an integer |
| ColorName = 430 | Extended color information for base entities |
| ColorRgb = 420 | Extended color information for base entities |
| ExtendedDataInteger16 = 0x42e |
| ExtendedDataWorldYCoordinate = 0x3fd |
| FirstEntityId = -2 |
| MlineStyleName = 2 |
| SymbolTableRecordComments = 4 |
| SymbolTableRecordName = 2 |
| UcsOrg = 110 |
| UcsOrientationX = 0x6f |
| UcsOrientationY = 0x70 |
| ViewportSnapAngle = 50 | Deprecated. |
| XCoordinate = 10 |
| XDataStart = -3 |
| XDictionary = -6 |
| YCoordinate = 20 |
| ZCoordinate = 30 |