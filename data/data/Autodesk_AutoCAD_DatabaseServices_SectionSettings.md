# SectionSettings Class

## Overview

#### Description
This .NET class wraps the AcDbSectionSettings ObjectARX class. This class stores section geometry settings.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SectionSettings
```

```text
public class SectionSettings : DBObject;
```

### Constructors

- [SectionSettings](#sectionsettings)

### Methods

- [Color](#color)
- [DestinationBlock](#destinationblock)
- [DestinationFile](#destinationfile)
- [DivisionLines](#divisionlines)
- [EdgeTransparency](#edgetransparency)
- [FaceTransparency](#facetransparency)
- [GenerationOptions](#generationoptions)
- [GetHatchPatternName](#gethatchpatternname)
- [GetHatchPatternType](#gethatchpatterntype)
- [GetSourceObjects](#getsourceobjects)
- [HatchAngle](#hatchangle)
- [HatchScale](#hatchscale)
- [HatchSpacing](#hatchspacing)
- [HatchVisibility](#hatchvisibility)
- [HiddenLine](#hiddenline)
- [Layer](#layer)
- [Linetype](#linetype)
- [LinetypeScale](#linetypescale)
- [LineWeight](#lineweight)
- [PlotStyleName](#plotstylename)
- [Reset()](#reset())
- [SetColor](#setcolor)
- [SetDestinationBlock](#setdestinationblock)
- [SetDestinationFile](#setdestinationfile)
- [SetDivisionLines](#setdivisionlines)
- [SetEdgeTransparency](#setedgetransparency)
- [SetFaceTransparency](#setfacetransparency)
- [SetGenerationOptions](#setgenerationoptions)
- [SetHatchAngle](#sethatchangle)
- [SetHatchPatternName](#sethatchpatternname)
- [SetHatchPatternType](#sethatchpatterntype)
- [SetHatchScale](#sethatchscale)
- [SetHatchSpacing](#sethatchspacing)
- [SetHatchVisibility](#sethatchvisibility)
- [SetHiddenLine](#sethiddenline)
- [SetLayer](#setlayer)
- [SetLinetype](#setlinetype)
- [SetLinetypeScale](#setlinetypescale)
- [SetLineWeight](#setlineweight)
- [SetPlotStyleName](#setplotstylename)
- [SetSourceObjects](#setsourceobjects)
- [SetVisibility](#setvisibility)
- [Visibility](#visibility)

### Properties

- [CurrentSectionType](#currentsectiontype)


## Constructors Details

### SectionSettings

#### Description
Default constructor.
```text
public SectionSettings();
```

### Color

#### Description
Returns the color of the specified section geometry.
```text
public Autodesk.AutoCAD.Colors.Color Color(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### DestinationBlock

#### Description
Returns the ID of the block which will be replaced during section generation when the generation option is DestinationReplaceBlock. Returns null if there is no destination block set.
```text
public ObjectId DestinationBlock(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type for which the destination block is to be returned |

### DestinationFile

#### Description
Returns the output file name to which the generated section will be written when the generation option is DestinationFile.
```text
public string DestinationFile(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type for which the destination file is to be returned |

### DivisionLines

#### Description
Returns the visibility of division lines in the specified section geometry.
```text
public bool DivisionLines(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### EdgeTransparency

#### Description
Returns the edge transparency of the specified section geometry.
```text
public int EdgeTransparency(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### FaceTransparency

#### Description
Returns the face transparency of the specified section geometry.
```text
public int FaceTransparency(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### GenerationOptions

#### Description
Returns the section generation options flag expressed as an Generation> enumerator.
```text
public SectionGeneration GenerationOptions(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type for which the generation options object is to be returned |

### GetHatchPatternName

#### Description
Gets the hatch pattern name of the specified section geometry.
```text
public string GetHatchPatternName(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### GetHatchPatternType

#### Description
Gets the hatch pattern type of the specified section geometry.
```text
public Autodesk.AutoCAD.DatabaseServices.HatchPatternType GetHatchPatternType(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### GetSourceObjects

#### Description
Gets the source object IDs which are used to generate the section when the generation option is SourceSelectedObjects.
```text
public void GetSourceObjects(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    ObjectIdCollection ids
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type for which the source objects are to be returned |
| ObjectIdCollection ids | Output collection of the object IDs |

### HatchAngle

#### Description
Returns the hatch angle of the specified section geometry.
```text
public double HatchAngle(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### HatchScale

#### Description
Returns the hatch scale of the specified section geometry.
```text
public double HatchScale(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### HatchSpacing

#### Description
Returns the hatch spacing of the specified section geometry.
```text
public double HatchSpacing(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### HatchVisibility

#### Description
Returns the visibility of hatch in the specified section geometry.
```text
public bool HatchVisibility(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### HiddenLine

#### Description
Returns the hidden line visibility of the specified section geometry.
```text
public bool HiddenLine(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### Layer

#### Description
Returns the layer name of the specified section geometry.
```text
public string Layer(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### Linetype

#### Description
Returns the linetype of the specified section geometry.
```text
public string Linetype(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### LinetypeScale

#### Description
Returns the linetype scale of the specified section geometry.
```text
public double LinetypeScale(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input section type |

### LineWeight

#### Description
Returns the line weight of the specified section geometry.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight LineWeight(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### PlotStyleName

#### Description
Returns the plot style name of the specified section geometry.
```text
public string PlotStyleName(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### Reset()

#### Description
Resets the settings for the specified section type to defaults based on the section type nSecType whose settings are to be reset.
```text
public void Reset();
public void Reset(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type to be reset |

### SetColor

#### Description
Sets the color of the specified section geometry.
```text
public void SetColor(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    Autodesk.AutoCAD.Colors.Color color
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| Autodesk.AutoCAD.Colors.Color color | Input color to set |

### SetDestinationBlock

#### Description
Sets the block name that will be replaced during section generation when the generation option is DestinationReplaceBlock.
```text
public void SetDestinationBlock(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type for which the destination block is to be set |
| ObjectId id | Input ID of the block to be replaced during section generation |

### SetDestinationFile

#### Description
Sets the output file name to which the generated section will be written when the generation option is DestinationFile.
```text
public void SetDestinationFile(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    string pszFileName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type for which the destination file is to be set |
| string pszFileName | Input destination file name |

### SetDivisionLines

#### Description
Sets the division line visibility of the specified section geometry.
```text
public void SetDivisionLines(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    [MarshalAs(UnmanagedType.U1)] bool bShow
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| [MarshalAs(UnmanagedType.U1)] bool bShow | Input true if division lines are to be shown, or false if they are to be hidden |

### SetEdgeTransparency

#### Description
Sets the edge transparency of the specified section geometry.
```text
public void SetEdgeTransparency(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    int nTransparency
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| int nTransparency | Input edge transparency to set, in the range 0-100 |

### SetFaceTransparency

#### Description
Sets the face transparency of the specified section geometry.
```text
public void SetFaceTransparency(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    int nTransparency
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| int nTransparency | Input edge transparency to set, in the range 0-100 |

### SetGenerationOptions

#### Description
Sets the generation options flag. This will overwrite all the current generation options. 
The options flag should contain one option from each of the following three groups of flags, combined using the OR operator: 
Type of section: Generate2dSection or Generate3dSection
Source: SourceAllObjects or SourceSelectedObjects
```text
public void SetGenerationOptions(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeneration nOptions
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type for which the generation options are to be set |
| SectionGeneration nOptions | Input options flag to set |

### SetHatchAngle

#### Description
Sets the hatch angle of the specified section geometry.
```text
public void SetHatchAngle(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    double fAngle
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| double fAngle | Input hatch angle |

### SetHatchPatternName

#### Description
Sets the hatch pattern name of the specified section geometry.
```text
public void SetHatchPatternName(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    string sNewName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| string sNewName | Input hatch pattern name |

### SetHatchPatternType

#### Description
Sets the hatch pattern type of the specified section geometry.
```text
public void SetHatchPatternType(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    Autodesk.AutoCAD.DatabaseServices.HatchPatternType nPatternType
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| Autodesk.AutoCAD.DatabaseServices.HatchPatternType nPatternType | Input pattern type |

### SetHatchScale

#### Description
Sets the hatch scale of the specified section geometry.
```text
public void SetHatchScale(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    double fScale
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### SetHatchSpacing

#### Description
Sets the hatch spacing of the specified section geometry.
```text
public void SetHatchSpacing(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    double fSpacing
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### SetHatchVisibility

#### Description
Sets the hatch visibility of the specified section geometry.
```text
public void SetHatchVisibility(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    [MarshalAs(UnmanagedType.U1)] bool bVisible
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| [MarshalAs(UnmanagedType.U1)] bool bVisible | Input visibility value |

### SetHiddenLine

#### Description
Sets the hidden line visibility of the specified section geometry.
```text
public void SetHiddenLine(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    [MarshalAs(UnmanagedType.U1)] bool bHiddenLine
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| [MarshalAs(UnmanagedType.U1)] bool bHiddenLine | Input visibility value |

### SetLayer

#### Description
Sets the layer of the specified section geometry.
```text
public void SetLayer(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    string pszLayer
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| string pszLayer | Input layer to set |

### SetLinetype

#### Description
Sets the linetype of the specified section geometry.
```text
public void SetLinetype(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    string pszLinetype
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| string pszLinetype | Input new linetype |

### SetLinetypeScale

#### Description
Sets the linetype scale of the specified section geometry.
```text
public void SetLinetypeScale(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    double fScale
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| double fScale | Input new linetype scale |

### SetLineWeight

#### Description
Sets the line weight of the specified section geometry.
```text
public void SetLineWeight(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    Autodesk.AutoCAD.DatabaseServices.LineWeight nLineWeight
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| Autodesk.AutoCAD.DatabaseServices.LineWeight nLineWeight | Input line weight |

### SetPlotStyleName

#### Description
Sets the plot style name of the specified section geometry.
```text
public void SetPlotStyleName(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    string pszPlotStyleName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| string pszPlotStyleName | Input plot style name |

### SetSourceObjects

#### Description
Sets the source object IDs, which are used to generate a section when the generation option is SourceSelectedObjects.
```text
public void SetSourceObjects(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    ObjectIdCollection ids
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| ObjectIdCollection ids | Input source object IDs |

### SetVisibility

#### Description
Sets the visibility of the specified section geometry.
```text
public void SetVisibility(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry, 
    [MarshalAs(UnmanagedType.U1)] bool bVisible
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |
| [MarshalAs(UnmanagedType.U1)] bool bVisible | Input visibility value |

### Visibility

#### Description
Returns true if the specified section geometry is visible, or false if it is not visible.
```text
public bool Visibility(
    Autodesk.AutoCAD.DatabaseServices.SectionType nSecType, 
    SectionGeometry nGeometry
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.SectionType nSecType | Input section type |
| SectionGeometry nGeometry | Input geometry value |

### CurrentSectionType

#### Description
Returns the current section type set in the section plane, expressed as an SectionSettings.SectionType enumerator.
```text
public Autodesk.AutoCAD.DatabaseServices.SectionType CurrentSectionType;
```

#### Conditions
Read / Write