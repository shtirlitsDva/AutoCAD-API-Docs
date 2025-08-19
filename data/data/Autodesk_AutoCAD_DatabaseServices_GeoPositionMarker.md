# GeoPositionMarker Class

## Overview

#### Description
The GeoPositionMarker class represents a Geographical location aware marker object with label.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.GeoPositionMarker
```

```text
public class GeoPositionMarker : Entity;
```

### Constructors

- [GeoPositionMarker()](#geopositionmarker())
- [GeoPositionMarker(Point3d, double, double)](#geopositionmarker(point3d,-double,-double))

### Properties

- [EnableFrameText](#enableframetext)
- [GeoPosition](#geoposition)
- [LandingGap](#landinggap)
- [MText](#mtext)
- [MTextVisible](#mtextvisible)
- [Normal](#normal)
- [Notes](#notes)
- [Position](#position)
- [Radius](#radius)
- [Text](#text)
- [TextAlignmentType](#textalignmenttype)
- [TextStyle](#textstyle)


## Constructors Details

### GeoPositionMarker()

#### Description
This is GeoPositionMarker, a member of class GeoPositionMarker.
```text
public GeoPositionMarker();
```

### GeoPositionMarker(Point3d, double, double)

#### Description
This is GeoPositionMarker, a member of class GeoPositionMarker.
```text
public GeoPositionMarker(
    Point3d pos, 
    double radius, 
    double landingGap
);
```

### EnableFrameText

#### Description
Label text frame enabling.
```text
public bool EnableFrameText;
```

### GeoPosition

#### Description
The Geographical location of the position marker. 
```text
public Point3d GeoPosition;
```

### LandingGap

#### Description
landing gap of the position marker. 
double
```text
public double LandingGap;
```

### MText

#### Description
The position marker MText label. 
NAMESPACE_ACDB::MText
```text
public Autodesk.AutoCAD.DatabaseServices.MText MText;
```

### MTextVisible

#### Description
The visibility of the MText label. 
bool
```text
public bool MTextVisible;
```

### Normal

#### Description
This is Normal, a member of class GeoPositionMarker.
```text
public virtual Vector3d Normal;
```

### Notes

#### Description
Notes of the position marker. 
System::String
```text
public string Notes;
```

### Position

#### Description
The Insertion point of the position marker. 
Point3d
```text
public Point3d Position;
```

### Radius

#### Description
Radius of the position marker.
```text
public double Radius;
```

#### Returns
Double
### Text

#### Description
The position marker text label. 
System::String
```text
public string Text;
```

### TextAlignmentType

#### Description
label text alignment type. 
TextAlignment
```text
public Autodesk.AutoCAD.DatabaseServices.TextAlignment TextAlignmentType;
```

### TextStyle

#### Description
This is TextStyle, a member of class GeoPositionMarker.
```text
public ObjectId TextStyle;
```
