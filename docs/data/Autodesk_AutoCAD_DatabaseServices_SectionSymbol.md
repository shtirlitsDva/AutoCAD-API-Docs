# SectionSymbol Class

## Overview

#### Description
The SectionSymbol class represents the section view symbol entity used by model documentation views in association with a Viewport entity.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.SectionSymbol
```

```text
public class SectionSymbol : Entity;
```

#### See Also
Autodesk.AutoCAD.DatabaseServices.Viewport;, [Autodesk.AutoCAD.DatabaseServices.ViewBorder](Autodesk_AutoCAD_DatabaseServices_ViewBorder.md "ViewBorder Class")

## Members

### Constructors

- [SectionSymbol](#sectionsymbol)

### Methods

- [AddSectionPoint](#addsectionpoint)
- [GetBulgeAt](#getbulgeat)
- [GetLabelNameAt](#getlabelnameat)
- [GetLabelOffsetAt](#getlabeloffsetat)
- [GetLabelOffsets](#getlabeloffsets)
- [GetSectionPointAt](#getsectionpointat)
- [GetSectionPoints](#getsectionpoints)
- [RemoveSectionPointAt](#removesectionpointat)
- [SetLabelNameAt](#setlabelnameat)
- [SetLabelOffsetAt](#setlabeloffsetat)
- [SetLabelOffsets](#setlabeloffsets)
- [SetSectionPointAt](#setsectionpointat)

### Properties

- [Identifier](#identifier)
- [IsHalfSection](#ishalfsection)
- [IsViewDirectionLeft](#isviewdirectionleft)
- [Scale](#scale)
- [SectionPointsCount](#sectionpointscount)
- [SymbolStyleId](#symbolstyleid)


## Constructors Details

### SectionSymbol

#### Description
Constructor for the SectionSymbol class. For internal use only.
```text
public SectionSymbol();
```

### AddSectionPoint

#### Description
This .NET method wraps the ObjectARX method. For internal use only.
```text
public void AddSectionPoint(
    Point3d pt, 
    double bulge
);
```

### GetBulgeAt

#### Description
Gets the section point bulge factor at the specified index (zero-based).
```text
public double GetBulgeAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input: zero-based index into the section symbol point bulge collection. |

#### Returns
Double
#### See Also
This method wraps the AcDbSectionSymbol::getBulgeAt method.

### GetLabelNameAt

#### Description
Gets the label at the point identified by the specified index. A section identifier is can be created at ever end and bend line point of the section symbol based on the view section style.
```text
public string GetLabelNameAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input: zero-based index into the section symbol point collection. |

#### Returns
System::String
#### Remarks
This method wraps the AcDbSectionSymbol::getLabelNameAt method.
#### See Also
Autodesk.AutoCAD.DatabaseServices.SectionViewStyle

### GetLabelOffsetAt

#### Description
Gets the offset vector for the section symbol point at the specified index.
```text
public Vector3d GetLabelOffsetAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input: zero-based index into the section symbol point collection. |

#### Returns
NAMESPACE_ACGE::Vector3d
#### Remarks
This method wraps the AcDbSectionSymbol::getLabelOffsetAt method.
### GetLabelOffsets

#### Description
Gets all of the label offset vectors for the section symbol.
```text
public Vector3dCollection GetLabelOffsets();
```

#### Returns
NAMESPACE_ACGE::Vector3dCollection
#### Remarks
This method wraps the AcDbSectionSymbol::getLabelOffsets method.
### GetSectionPointAt

#### Description
Gets the section point at the specified index (zero-based).
```text
public Point3d GetSectionPointAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input: zero-based index into the section symbol point collection. |

#### Returns
NAMESPACE_ACGE::Point3d
#### Remarks
This method wraps the AcDbSectionSymbol::getSectionPointAt method.
### GetSectionPoints

#### Description
Gets a collection of all the section points.
```text
public Point3dCollection GetSectionPoints();
```

#### Returns
NAMESPACE_ACGE::Point3dCollection
#### Remarks
This method wraps the AcDbSectionSymbol::getSectionPoints method.
### RemoveSectionPointAt

#### Description
This .NET method wraps the ObjectARX method. For internal use only.
```text
public void RemoveSectionPointAt(
    int index
);
```

### SetLabelNameAt

#### Description
This .NET method wraps the ObjectARX method. For internal use only.
```text
public void SetLabelNameAt(
    int index, 
    string name
);
```

### SetLabelOffsetAt

#### Description
This .NET method wraps the ObjectARX method. For internal use only.
```text
public void SetLabelOffsetAt(
    int index, 
    Vector3d offset
);
```

### SetLabelOffsets

#### Description
This .NET method wraps the ObjectARX method.For internal use only.
```text
public void SetLabelOffsets(
    Vector3dCollection offsets
);
```

### SetSectionPointAt

#### Description
This .NET method wraps the ObjectARX method. For internal use only.
```text
public void SetSectionPointAt(
    int index, 
    Point3d pt, 
    double bulge
);
```

### Identifier

#### Description
The identifier of the section symbol. 
String
```text
public string Identifier;
```

#### Remarks
This property is read-only. 
This property wraps the AcDbSectionSymbol::getIdentifer method. 
### IsHalfSection

#### Description
A flag indicating whether the section symbol annotates is associated to a half section view. 
bool
```text
public bool IsHalfSection;
```

#### Remarks
This property is read-only. 
This property wraps the AcDbSectionSymbol::isHalfSection method. 
### IsViewDirectionLeft

#### Description
A flag indicating whether the view direction is to the left. 
bool
```text
public bool IsViewDirectionLeft;
```

#### Remarks
This property is read-only. 
This property wraps the AcDbSectionSymbol::isViewDirectionLeft method. 
### Scale

#### Description
The scale of the section symbol entity. 
double
```text
public double Scale;
```

#### Remarks
This property is read-only. 
This property wraps the AcDbSectionSymbol::getScale method. 
### SectionPointsCount

#### Description
The number of points in the section symbol. 
int
```text
public int SectionPointsCount;
```

#### Remarks
This property is read-only. 
This property wraps the AcDbSectionSymbol::sectionPointsCount method
Example
```text
int nPoints = sectionSymbol.SectionPointsCount;
```

### SymbolStyleId

#### Description
The object ID of the SectionViewStyle object associated with this entity. Returns ObjectId.
```text
public ObjectId SymbolStyleId;
```

#### Remarks
This property wraps the AcDbSectionSymbol::symbolStyleId and AcDbSectionSymbol::setSymbolStyleId methods.
Example
```text
ObjectId styleId = sectionSymbol.SymbolStyleId;
Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
ed.WriteMessage(" name = ");
SectionViewStyle sectionViewStyle = (SectionViewStyle) trans.GetObject(styleId, OpenMode.ForRead);
ed.WriteMessage(sectionViewStyle.Name);
```

#### See Also
Autodesk.AutoCAD.DatabaseServices.SectionViewStyle