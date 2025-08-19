# FeatureControlFrame Class

## Overview

#### Description
This .NET class wraps the AcDbFcf ObjectARX class. 
Feature Control Frames for Geometric Dimensioning and Tolerancing are the entity type created by the TOLERANCE command in the AutoCAD command editor. Tolerances are considered as dimensions in AutoCAD, which means they are controlled by dimension variable settings and dimension styles. 
Within objects of this class, the text string data member contains symbol and format codes that are used to define the actual graphical representation that will be seen within AutoCAD. For more information on these control codes, see the FeatureControlFrame.SetText() member function description.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.FeatureControlFrame
```

```text
public class FeatureControlFrame : Entity;
```

#### Notes
This class overrides Entity.SubSetDatabaseDefaults() to set the object's dimension style (dimstyle) to the current style for the database. Typically, objects of this class are initialized with a call to SetDatabaseDefaults() followed by a call to SetDimstyleData() using data obtained by a call to Database.GetDimstyleData().
#### See Also
DBObject, [Vector3d](Autodesk_AutoCAD_Geometry_Vector3d.md), [Point3d](Autodesk_AutoCAD_Geometry_Point3d.md), [Point3dArray](Autodesk_AutoCAD_Geometry_Point3dCollection.md)

## Members

### Constructors

- [FeatureControlFrame()](#featurecontrolframe())
- [FeatureControlFrame(string, Point3d, Vector3d, Vector3d)](#featurecontrolframe(string,-point3d,-vector3d,-vector3d))

### Methods

- [GetBoundingPoints](#getboundingpoints)
- [GetBoundingPolyline](#getboundingpolyline)
- [GetDimstyleData](#getdimstyledata)
- [SetDimstyleData](#setdimstyledata)
- [SetOrientation](#setorientation)

### Properties

- [Dimclrd](#dimclrd)
- [Dimclrt](#dimclrt)
- [DimensionStyle](#dimensionstyle)
- [DimensionStyleName](#dimensionstylename)
- [Dimgap](#dimgap)
- [Dimscale](#dimscale)
- [Dimtxsty](#dimtxsty)
- [Dimtxt](#dimtxt)
- [Direction](#direction)
- [Location](#location)
- [Normal](#normal)
- [Text](#text)
- [TextStyleId](#textstyleid)
- [TextStyleName](#textstylename)


## Constructors Details

### FeatureControlFrame()

#### Description
Default constructor.
```text
public FeatureControlFrame();
```

### FeatureControlFrame(string, Point3d, Vector3d, Vector3d)

#### Description
Constructor which sets values for various properties.
```text
public FeatureControlFrame(
    string codes, 
    Point3d insertionPoint, 
    Vector3d normalVector, 
    Vector3d x
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string codes | Input text string containing the codes to specify the feature control symbols and the tolerance for this object. If this value is Null, this is just like calling the default constructor. |
| Point3d insertionPoint | Input Insertion point (WCS) of this Fcf object |
| Vector3d normalVector | Input Normal vector (WCS) of the plane containing this Fcf object |

  * : Input X-direction vector (WCS) of this Fcf

  
### GetBoundingPoints

#### Description
This function returns all the consecutive distinct corner points of the Fcf object. Used in order, these points could be used to define a pline that overlays the border of the complete Fcf object. 
The points start with the top left corner of the Fcf object and run clockwise around the Fcf object's boundary, with the lower left corner as the last point.
```text
public virtual Point3dCollection GetBoundingPoints();
```

### GetBoundingPolyline

#### Description
This function returns a Point3dCollection as follows: 
```text
ptArray[0] == top left corner of Fcf
ptArray[1] == top right corner of Fcf
ptArray[2] == bottom right corner of Fcf
ptArray[3] == bottom left corner of Fcf
```

All points are in WCS coordinates.
```text
public virtual Point3dCollection GetBoundingPolyline();
```

### GetDimstyleData

#### Description
This function copies and returns the DimStyle information from the DimensionStyleTableRecord referenced by this object.
```text
public DimStyleTableRecord GetDimstyleData();
```

### SetDimstyleData

#### Description
Sets a new dimension variable as determiend by style.
```text
public void SetDimstyleData(
    DimStyleTableRecord style
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DimStyleTableRecord style | Input objectId of the desired DimensionStyle to be used by the Fcf |

### SetOrientation

#### Description
Sets norm to be the Fcf plane normal and dir to be the X-direction for the Fcf. Both values are specified in WCS coordinates. dir **must** be perpendicular to norm.
```text
public virtual void SetOrientation(
    Vector3d norm, 
    Vector3d dir
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vector3d norm | Input vector (in WCS) to be used to define the new plane that will contain the Fcf |
| Vector3d dir | Input X-Direction vector (WCS) for the Fcf |

### Dimclrd

#### Description
Accesses the current DIMCLRD value for the feature control frame. If the value is overridden for this dimension, then that value is returned. See the System Variables section of the _AutoCAD Command Reference_ manual for information on DIMCLRD.
```text
public Autodesk.AutoCAD.Colors.Color Dimclrd;
```

#### Conditions
Read / Write
### Dimclrt

#### Description
Accesses the current DIMCLRT value for the feature control frame. If the value is overridden for this dimension, then that value is returned. See the System Variables section of the _AutoCAD Command Reference_ manual for information on DIMCLRT.
```text
public Autodesk.AutoCAD.Colors.Color Dimclrt;
```

#### Conditions
Read / Write
### DimensionStyle

#### Description
Accesses the objectId of the object's DimensionStyle.
```text
public ObjectId DimensionStyle;
```

#### Conditions
Read / Write
### DimensionStyleName

#### Description
Accesses the associated dimension style name.
```text
public string DimensionStyleName;
```

#### Conditions
Read / Write
### Dimgap

#### Description
Accesses the current DIMGAP value for the feature control frame. If the value is overridden for this feature control frame, then that value is returned. See the System Variables section of the _AutoCAD Command Reference_ for information on DIMGAP.
```text
public double Dimgap;
```

#### Conditions
Read / Write
### Dimscale

#### Description
Accesses the current DIMSCALE value for the feature control frame. If the value is overridden for this dimension, then that value is returned. See the System Variables section of the _AutoCAD Command Reference_ manual for information on DIMSCALE.
```text
public double Dimscale;
```

#### Conditions
Read / Write
### Dimtxsty

#### Description
Accesses the objectId of the textStyle specified by the current DIMTXSTY value of the feature control frame. If the value is overridden for this dimension, then that value is returned. See the System Variables section of the _AutoCAD Command Reference_ manual for information on DIMTXSTY.
```text
public ObjectId Dimtxsty;
```

#### Conditions
Read / Write
### Dimtxt

#### Description
Accesses the current DIMTXT value for the feature control frame. If the value is overridden for this dimension, then that value is returned. See the System Variables section of the _AutoCAD Command Reference_ manual for information on DIMTXT.
```text
public double Dimtxt;
```

#### Conditions
Read / Write
### Direction

#### Description
Accesses the X-direction vector (in WCS) for the object. The X-direction vector determines the direction that the object goes away from its "location" point.
```text
public virtual Vector3d Direction;
```

#### Conditions
Read-only
### Location

#### Description
Accesses the insertion point (in WCS) of the Fcf object. The "insertion" point for an Fcf is the middle of the left edge of its first line.
```text
public virtual Point3d Location;
```

#### Conditions
Read / Write
### Normal

#### Description
Accesses the unit normal vector (in WCS) of the plane containing the Fcf object.
```text
public virtual Vector3d Normal;
```

#### Conditions
Read-only
### Text

#### Description
Accesses the text to be the text string used by the Fcf.
```text
public virtual string Text;
```

#### Conditions
Read / Write
### TextStyleId

#### Description
Accesses the text style ID.
```text
public ObjectId TextStyleId;
```

#### Conditions
Read / Write
### TextStyleName

#### Description
Accesses the text style name.
```text
public string TextStyleName;
```

#### Conditions
Read / Write