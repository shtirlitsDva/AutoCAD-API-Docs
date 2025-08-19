# Dimension Class

## Overview

#### Description
This .NET class wraps the AcDbDimension ObjectARX class. 
The Dimension class is the base class for the classes that represent all the dimension entity types within AutoCAD. The appearance of dimensions is controlled by dimension variable settings and dimension styles.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Dimension
            Autodesk.AutoCAD.DatabaseServices.AlignedDimension
            Autodesk.AutoCAD.DatabaseServices.ArcDimension
            Autodesk.AutoCAD.DatabaseServices.DiametricDimension
            Autodesk.AutoCAD.DatabaseServices.LineAngularDimension2
            Autodesk.AutoCAD.DatabaseServices.OrdinateDimension
            Autodesk.AutoCAD.DatabaseServices.Point3AngularDimension
            Autodesk.AutoCAD.DatabaseServices.RadialDimension
            Autodesk.AutoCAD.DatabaseServices.RadialDimensionLarge
            Autodesk.AutoCAD.DatabaseServices.RotatedDimension
```

```text
public abstract class Dimension : Entity;
```

#### Notes
Although this class has a constructor, it is intended to be used as a base class -- no objects of this class should be created. An object instantiated directly from Dimension cannot be added to the database. Only objects instantiated from a class derived from Dimension can be added to the database. If a dimension object from a derived class wishes to call Dimension.WorldDraw(), it must do so before any calls are made to any of the WorldGeometry or ViewportGeometry geometry creation methods (including Mesh() or Shell()). This is because the parent dimensions WorldDraw() method makes a call to SubEntityTraits.SetSelectionMarker(). 
If you do not set the dimension text automatically, the text becomes the measured value of the dimension. Setting the text using the Dimension.DimensionText property will override the default value. You can revert to the default value by setting the text to "" (an empty string). 
Modifying a dimension in a noncurrent database will cause its DimBlockId to be set to NULL. This ensures that the next time the database is loaded as the current drawing, a new dimension block will be created, and the old one will be purged. This is necessary because dimension blocks in noncurrent databases cannot be created or modified. A dimension opened for write in a noncurrent database will have its DimBlockId set to NULL during close. This may generate problems for applications. 
This behavior can be overridden. Calling RecordGraphicsModified(false) before closing the dimension will prevent the DimBlockId from being set to NULL. Although this will also reset the graphics modified bit, it should cause no other harmful side effects because the operation is on a noncurrent database. The result of overriding this behavior will be as follows: 
  * Newly created dimensions do not have a dimBlock. Therefore, this workaround will have no effect. You cannot create a dimension in a noncurrent database and give it a dimBlock.
  * If the modifications to the Dimension entity do not affect the information in the dimBlock, there will be no noticeable side effects. Doing the workaround is recommended in this case, as it will prevent an unnecessary reconstruction of the dimBlock.
  * If the modifications to the Dimension entity do cause a need for the dimBlock to be updated, the update will not occur until after the drawing is loaded and some subsequent action causes the dimBlock to be updated. In other words, the dimension will appear unchanged when the drawing is next loaded. Then, when some subsequent action causes a change to the dimension (this does not include a regen), all the changes will become visible.
  * To work around this problem, just before saving the noncurrent database, reopen the dimension for write, call  RecordGraphicsModified(true), and close it. This will set DimBlockId to NULL and the changes will be applied the next time the database is loaded as the current drawing.

This class supports Dimension Style Overrides, which means that it has a dimension style and that it honors certain dimension variables. 
This class overrides Entity.SubSetDatabaseDefaults() to set the object's dimension style (dimensionStyle) to the current style for the database. Typically objects of this class are initialized with a call to SetDatabaseDefaults() followed by a call to SetDimstyleData() using data obtained by a call to Database.GetDimstyleData().
#### See Also
DBObject, BlockTableRecord

## Members

### Methods

- [FieldFromMText](#fieldfrommtext)
- [FieldToMText](#fieldtomtext)
- [FormatMeasurement](#formatmeasurement)
- [GenerateLayout](#generatelayout)
- [GetDimstyleData](#getdimstyledata)
- [RecomputeDimensionBlock](#recomputedimensionblock)
- [RemoveTextField](#removetextfield)
- [ResetTextDefinedSize](#resettextdefinedsize)
- [SetDimstyleData](#setdimstyledata)

### Properties

- [AlternatePrefix](#alternateprefix)
- [AlternateSuffix](#alternatesuffix)
- [AltSuppressLeadingZeros](#altsuppressleadingzeros)
- [AltSuppressTrailingZeros](#altsuppresstrailingzeros)
- [AltSuppressZeroFeet](#altsuppresszerofeet)
- [AltSuppressZeroInches](#altsuppresszeroinches)
- [AltToleranceSuppressLeadingZeros](#alttolerancesuppressleadingzeros)
- [AltToleranceSuppressTrailingZeros](#alttolerancesuppresstrailingzeros)
- [AltToleranceSuppressZeroFeet](#alttolerancesuppresszerofeet)
- [AltToleranceSuppressZeroInches](#alttolerancesuppresszeroinches)
- [CenterMarkSize](#centermarksize)
- [CenterMarkType](#centermarktype)
- [Dimadec](#dimadec)
- [Dimalt](#dimalt)
- [Dimaltd](#dimaltd)
- [Dimaltf](#dimaltf)
- [Dimaltrnd](#dimaltrnd)
- [Dimalttd](#dimalttd)
- [Dimalttz](#dimalttz)
- [Dimaltu](#dimaltu)
- [Dimaltz](#dimaltz)
- [Dimapost](#dimapost)
- [Dimarcsym](#dimarcsym)
- [Dimasz](#dimasz)
- [Dimatfit](#dimatfit)
- [Dimaunit](#dimaunit)
- [Dimazin](#dimazin)
- [Dimblk](#dimblk)
- [Dimblk1](#dimblk1)
- [Dimblk2](#dimblk2)
- [DimBlockId](#dimblockid)
- [DimBlockPosition](#dimblockposition)
- [Dimcen](#dimcen)
- [Dimclrd](#dimclrd)
- [Dimclre](#dimclre)
- [Dimclrt](#dimclrt)
- [Dimdec](#dimdec)
- [Dimdle](#dimdle)
- [Dimdli](#dimdli)
- [Dimdsep](#dimdsep)
- [DimensionStyle](#dimensionstyle)
- [DimensionStyleName](#dimensionstylename)
- [DimensionText](#dimensiontext)
- [Dimexe](#dimexe)
- [Dimexo](#dimexo)
- [Dimfrac](#dimfrac)
- [Dimfxlen](#dimfxlen)
- [DimfxlenOn](#dimfxlenon)
- [Dimgap](#dimgap)
- [Dimjogang](#dimjogang)
- [Dimjust](#dimjust)
- [Dimldrblk](#dimldrblk)
- [Dimlfac](#dimlfac)
- [Dimlim](#dimlim)
- [Dimltex1](#dimltex1)
- [Dimltex2](#dimltex2)
- [Dimltype](#dimltype)
- [Dimlunit](#dimlunit)
- [Dimlwd](#dimlwd)
- [Dimlwe](#dimlwe)
- [Dimpost](#dimpost)
- [Dimrnd](#dimrnd)
- [Dimsah](#dimsah)
- [Dimscale](#dimscale)
- [Dimsd1](#dimsd1)
- [Dimsd2](#dimsd2)
- [Dimse1](#dimse1)
- [Dimse2](#dimse2)
- [Dimsoxd](#dimsoxd)
- [Dimtad](#dimtad)
- [Dimtdec](#dimtdec)
- [Dimtfac](#dimtfac)
- [Dimtfill](#dimtfill)
- [Dimtfillclr](#dimtfillclr)
- [Dimtih](#dimtih)
- [Dimtix](#dimtix)
- [Dimtm](#dimtm)
- [Dimtmove](#dimtmove)
- [Dimtofl](#dimtofl)
- [Dimtoh](#dimtoh)
- [Dimtol](#dimtol)
- [Dimtolj](#dimtolj)
- [Dimtp](#dimtp)
- [Dimtsz](#dimtsz)
- [Dimtvp](#dimtvp)
- [Dimtxt](#dimtxt)
- [Dimtzin](#dimtzin)
- [Dimupt](#dimupt)
- [Dimzin](#dimzin)
- [DynamicDimension](#dynamicdimension)
- [Elevation](#elevation)
- [HorizontalRotation](#horizontalrotation)
- [Measurement](#measurement)
- [Normal](#normal)
- [Prefix](#prefix)
- [Suffix](#suffix)
- [SuppressAngularLeadingZeros](#suppressangularleadingzeros)
- [SuppressAngularTrailingZeros](#suppressangulartrailingzeros)
- [SuppressLeadingZeros](#suppressleadingzeros)
- [SuppressTrailingZeros](#suppresstrailingzeros)
- [SuppressZeroFeet](#suppresszerofeet)
- [SuppressZeroInches](#suppresszeroinches)
- [TextAttachment](#textattachment)
- [TextDefinedSize](#textdefinedsize)
- [TextLineSpacingFactor](#textlinespacingfactor)
- [TextLineSpacingStyle](#textlinespacingstyle)
- [TextPosition](#textposition)
- [TextRotation](#textrotation)
- [ToleranceSuppressLeadingZeros](#tolerancesuppressleadingzeros)
- [ToleranceSuppressTrailingZeros](#tolerancesuppresstrailingzeros)
- [ToleranceSuppressZeroFeet](#tolerancesuppresszerofeet)
- [ToleranceSuppressZeroInches](#tolerancesuppresszeroinches)
- [UsingDefaultTextPosition](#usingdefaulttextposition)


## Methods Details

### FieldFromMText

#### Description
If dimMText contains a text field, this function copies that field and adds the copy to this object.
```text
public void FieldFromMText(
    MText dimMText
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| MText dimMText | The MText object from which the text field is copied |

### FieldToMText

#### Description
If this object contains a text field, this function copies the field and adds the copy to dimMText.
```text
public void FieldToMText(
    MText dimMText
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| MText dimMText | MText object to which the new field will be attached |

### FormatMeasurement

#### Description
This method gives you access to the dimension classes' text assembly and formatting logic. You pass in a double corresponding to the desired measurement and get back a string suitable for building MText objects. That MText content string reflects the dimension's dimstyle settings for prefixes, suffixes, units, precision, alternate units, tolerances, text style, and so on. This dimension text string gets combined with DIMPOST, DIMAPOST, and the alternate and primary measurements in the final dimension text.
```text
public string FormatMeasurement(
    double measurement, 
    string dimensionText
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double measurement | Input measurement value. |
| string dimensionText | Input alternate value. |

### GenerateLayout

#### Description
This function will update the dimension according to the current dimension style. It works similar to the Dim, Update subcommand. It computes dimension geometry, including extension lines, dimension lines, dimension arcs, dimension text, arrowheads from given definition points and dimension style. The generated dimension geometry are maintained internally by member data "mGeom" which is a list of in-memory Entity pointers. This API function does not generate the dimension block. 
The dimension block is created automatically from the in-memory entity list when the application posts the dimension object to database and close the object. 
This function enables the dimension object for full use regardless of its database status - resident or non resident. For example, the application may create an instance of Dimension, explode it to get dimension geometry information and delete the object. The application may never need to post the dimension object to database in order to get its dimension geometry data. 
The generated in-memory dimension geometry will be deleted automatically by dimension object destructor.
```text
public void GenerateLayout();
```

### GetDimstyleData

#### Description
This function copies the dimstyle information from the DimStyleTableRecord referenced by the current dimension. After copying the data, any dimension variable overrides currently applied to the dimension will be copied into the returned table record.
```text
public DimStyleTableRecord GetDimstyleData();
```

### RecomputeDimensionBlock

#### Description
This function updates the block table record the dimension references to match any changes made to the dimension since the last time the block table record was updated. 
If forceUpdate is true, then the block table record will be updated regardless of whether or not the dimension has had any changes since the last time the block table record was updated.
```text
public void RecomputeDimensionBlock(
    [MarshalAs(UnmanagedType.U1)] bool forceUpdate
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool forceUpdate | Boolean indicating whether or not to force an update on screen |

### RemoveTextField

#### Description
If this object contains a text field, this function removes it from the extension dictionary and deletes the field object.
```text
public void RemoveTextField();
```

### ResetTextDefinedSize

#### Description
Sets dimension text defined width and defined height to zero
```text
public void ResetTextDefinedSize();
```

### SetDimstyleData

#### Description
This function copies the dimension variable information in the DimStyleTableRecord identified by style into the database on which this method is called, making those dimension variable values current for the database. The DimStyleTableRecord with object ID style does not have to reside in the database on which this method is called.
```text
public void SetDimstyleData(
    DimStyleTableRecord style
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DimStyleTableRecord style | Input object ID of DimStyleTableRecord from which to copy dimension variable information |

### AlternatePrefix

#### Description
Specifies a prefix for the alternate dimension measurement for all dimension types except angular.
```text
public virtual string AlternatePrefix;
```

#### Conditions
Read / Write
### AlternateSuffix

#### Description
Specifies a suffix for the alternate dimension measurement for all dimension types except angular.
```text
public virtual string AlternateSuffix;
```

#### Conditions
Read / Write
### AltSuppressLeadingZeros

#### Description
Specifies the suppression of leading zeros in alternate dimension values.
```text
public virtual bool AltSuppressLeadingZeros;
```

#### Conditions
Read / Write
### AltSuppressTrailingZeros

#### Description
Specifies the suppression of trailing zeros in alternate dimension values.
```text
public virtual bool AltSuppressTrailingZeros;
```

#### Conditions
Read / Write
### AltSuppressZeroFeet

#### Description
Specifies the suppression of a zero foot measurement in alternate dimension values.
```text
public virtual bool AltSuppressZeroFeet;
```

#### Conditions
Read / Write
### AltSuppressZeroInches

#### Description
Specifies the suppression of a zero inch measurement in alternate dimension values.
```text
public virtual bool AltSuppressZeroInches;
```

#### Conditions
Read / Write
### AltToleranceSuppressLeadingZeros

#### Description
Specifies the suppression of leading zeros in alternate dimension values.
```text
public virtual bool AltToleranceSuppressLeadingZeros;
```

#### Conditions
Read / Write
### AltToleranceSuppressTrailingZeros

#### Description
Specifies the suppression of trailing zeros in alternate tolerance values.
```text
public virtual bool AltToleranceSuppressTrailingZeros;
```

#### Conditions
Read / Write
### AltToleranceSuppressZeroFeet

#### Description
Specifies the suppression of a zero foot measurement in alternate tolerance values.
```text
public virtual bool AltToleranceSuppressZeroFeet;
```

#### Conditions
Read / Write
### AltToleranceSuppressZeroInches

#### Description
Specifies the suppression of a zero inch measurement in alternate tolerance values.
```text
public virtual bool AltToleranceSuppressZeroInches;
```

#### Conditions
Read / Write
### CenterMarkSize

#### Description
Specifies the size of the center mark for radial and diameter dimensions.
```text
public virtual double CenterMarkSize;
```

#### Conditions
Read-only
### CenterMarkType

#### Description
Specifies the type of center mark for radial and diameter dimensions.
```text
public virtual DimensionCenterMarkType CenterMarkType;
```

#### Conditions
Read-only
### Dimadec

#### Description
Accesses the current DIMADEC value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on DIMADEC.
```text
public virtual int Dimadec;
```

#### Conditions
Read / Write
### Dimalt

#### Description
Accesses the current DIMALT value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALT.
```text
public virtual bool Dimalt;
```

#### Conditions
Read / Write
### Dimaltd

#### Description
Accesses the current DIMALTD value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMALTD.
```text
public virtual int Dimaltd;
```

#### Conditions
Read / Write
### Dimaltf

#### Description
Accesses the current DIMALTF value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTF.
```text
public virtual double Dimaltf;
```

#### Conditions
Read / Write
### Dimaltrnd

#### Description
Accesses the current DIMALTRND value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTRND.
```text
public virtual double Dimaltrnd;
```

#### Conditions
Read / Write
### Dimalttd

#### Description
Accesses the current DIMALTTD value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTTD.
```text
public virtual int Dimalttd;
```

#### Conditions
Read / Write
### Dimalttz

#### Description
Accesses the current DIMALTTZ value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTTZ.
```text
public virtual int Dimalttz;
```

#### Conditions
Read / Write
### Dimaltu

#### Description
Accesses the current DIMALTU value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTU.
```text
public virtual int Dimaltu;
```

#### Conditions
Read / Write
### Dimaltz

#### Description
Accesses the current DIMALTZ value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTZ.
```text
public virtual int Dimaltz;
```

#### Conditions
Read / Write
### Dimapost

#### Description
Accesses the current DIMAPOST value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMAPOST.
```text
public virtual string Dimapost;
```

#### Conditions
Read / Write
### Dimarcsym

#### Description
Accesses the arc length placement value.
```text
public virtual int Dimarcsym;
```

#### Conditions
Read / Write
### Dimasz

#### Description
Accesses the current DIMASZ value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMASZ.
```text
public virtual double Dimasz;
```

#### Conditions
Read / Write
### Dimatfit

#### Description
Accesses the current DIMATFIT value for the database.
```text
public virtual int Dimatfit;
```

#### Conditions
Read / Write
### Dimaunit

#### Description
Accesses the current DIMAUNIT value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMAUNIT.
```text
public virtual int Dimaunit;
```

#### Conditions
Read / Write
### Dimazin

#### Description
Accesses the current DIMAZIN value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMAZIN.
```text
public virtual int Dimazin;
```

#### Conditions
Read / Write
### Dimblk

#### Description
Accesses the current DIMBLK value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMBLK.
```text
public ObjectId Dimblk;
```

#### Conditions
Read / Write
### Dimblk1

#### Description
Accesses the current DIMBLK1 value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMBLK1.
```text
public ObjectId Dimblk1;
```

#### Conditions
Read / Write
### Dimblk2

#### Description
Accesses the current DIMBLK2 value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMBLK2.
```text
public ObjectId Dimblk2;
```

#### Conditions
Read / Write
### DimBlockId

#### Description
Accesses the object ID of the BlockTableRecord containing the entities that this dimension displays.
```text
public ObjectId DimBlockId;
```

#### Conditions
Read / Write
### DimBlockPosition

#### Description
Accesses the relative position point of the block referenced by the dimension (in WCS coordinates).
```text
public Point3d DimBlockPosition;
```

#### Conditions
Read-only
### Dimcen

#### Description
Accesses the current DIMCEN value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMCEN.
```text
public virtual double Dimcen;
```

#### Conditions
Read / Write
### Dimclrd

#### Description
Accesses the current DIMCLRD value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMCLRD.
```text
public virtual Autodesk.AutoCAD.Colors.Color Dimclrd;
```

#### Conditions
Read / Write
### Dimclre

#### Description
Accesses the current DIMCLRE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMCLRE.
```text
public virtual Autodesk.AutoCAD.Colors.Color Dimclre;
```

#### Conditions
Read / Write
### Dimclrt

#### Description
Accesses the current DIMCLRT value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMCLRT.
```text
public virtual Autodesk.AutoCAD.Colors.Color Dimclrt;
```

#### Conditions
Read / Write
### Dimdec

#### Description
Accesses the current DIMDEC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMDEC.
```text
public virtual int Dimdec;
```

#### Conditions
Read / Write
### Dimdle

#### Description
Accesses the current DIMDLE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMDLE.
```text
public virtual double Dimdle;
```

#### Conditions
Read / Write
### Dimdli

#### Description
Accesses the current DIMDLI value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMDLI.
```text
public virtual double Dimdli;
```

#### Conditions
Read / Write
### Dimdsep

#### Description
Accesses the current DIMDSEP value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMDSEP.
```text
public virtual char Dimdsep;
```

#### Conditions
Read / Write
### DimensionStyle

#### Description
Accesses the object ID of the DimStyleTableRecord referenced by the dimension.
```text
public ObjectId DimensionStyle;
```

#### Conditions
Read / Write
### DimensionStyleName

#### Description
Specifies name of associated dimension style.
```text
public virtual string DimensionStyleName;
```

#### Conditions
Read / Write
### DimensionText

#### Description
Accesses the user-supplied dimension annotation text string (including any multiline text formatting characters).
```text
public string DimensionText;
```

#### Conditions
Read / Write
### Dimexe

#### Description
Accesses the current DIMEXE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMEXE.
```text
public virtual double Dimexe;
```

#### Conditions
Read / Write
### Dimexo

#### Description
Accesses the current DIMEXO value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMEXO.
```text
public virtual double Dimexo;
```

#### Conditions
Read / Write
### Dimfrac

#### Description
Accesses the current DIMFRAC value for the database.
```text
public virtual int Dimfrac;
```

#### Conditions
Read / Write
### Dimfxlen

#### Description
Accesses the fixed extension lines value.
```text
public virtual double Dimfxlen;
```

#### Conditions
Read / Write
### DimfxlenOn

#### Description
Accesses a value that indicates whether the fixed extension lines are on.
```text
public virtual bool DimfxlenOn;
```

#### Conditions
Read / Write
### Dimgap

#### Description
Accesses the current DIMGAP value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMGAP
```text
public virtual double Dimgap;
```

#### Conditions
Read / Write
### Dimjogang

#### Description
Accesses the current large radial angle.
```text
public virtual double Dimjogang;
```

#### Conditions
Read / Write
### Dimjust

#### Description
Accesses the current DIMJUST value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMJUST.
```text
public virtual int Dimjust;
```

#### Conditions
Read / Write
### Dimldrblk

#### Description
Accesses the object ID of the block reference specified by the current DIMLDRBLK value of the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMLDRBLK.
```text
public virtual ObjectId Dimldrblk;
```

#### Conditions
Read / Write
### Dimlfac

#### Description
Accesses the current DIMLFAC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMLFAC.
```text
public virtual double Dimlfac;
```

#### Conditions
Read / Write
### Dimlim

#### Description
Accesses the current DIMLIM value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMLIM.
```text
public virtual bool Dimlim;
```

#### Conditions
Read / Write
### Dimltex1

#### Description
Accesses the object ID of the linetype of extension line 1.
```text
public virtual ObjectId Dimltex1;
```

#### Conditions
Read / Write
### Dimltex2

#### Description
Accesses the object ID of the linetype of extension line 2.
```text
public virtual ObjectId Dimltex2;
```

#### Conditions
Read / Write
### Dimltype

#### Description
Accesses the dimension linetype.
```text
public virtual ObjectId Dimltype;
```

#### Conditions
Read / Write
### Dimlunit

#### Description
Accesses the current DIMLUNIT value for the dimension.
```text
public virtual int Dimlunit;
```

#### Conditions
Read / Write
### Dimlwd

#### Description
Accesses the current DIMLWD value for the dimension. 
See the System Variables section of the AutoCAD Command Reference manual for information on DIMLWD.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.LineWeight Dimlwd;
```

#### Conditions
Read / Write
### Dimlwe

#### Description
Accesses the current DIMLWE value for the dimension. 
See the System Variables section of the AutoCAD Command Reference manual for information on DIMLWE.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.LineWeight Dimlwe;
```

#### Conditions
Read / Write
### Dimpost

#### Description
Accesses the character string that is the current DIMPOST value for the datatbase. 
See the System Variables section of the _AutoCAD Command Reference manual_ for information on DIMPOST.
```text
public virtual string Dimpost;
```

#### Conditions
Read / Write
### Dimrnd

#### Description
Accesses the current DIMRND value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMRND. 
```text
public virtual double Dimrnd;
```

#### Conditions
Read / Write
### Dimsah

#### Description
Accesses current DIMSAH value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMSAH 
```text
public virtual bool Dimsah;
```

#### Conditions
Read / Write
### Dimscale

#### Description
Accesses the current DIMSCALE value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMSCALE.
```text
public virtual double Dimscale;
```

#### Conditions
Read / Write
### Dimsd1

#### Description
Accesses the current DIMSD1 value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMSD1.
```text
public virtual bool Dimsd1;
```

#### Conditions
Read / Write
### Dimsd2

#### Description
Accesses the current DIMSD2 value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMSD2.
```text
public virtual bool Dimsd2;
```

#### Conditions
Read / Write
### Dimse1

#### Description
Accesses the current DIMSD1 value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMSD1.
```text
public virtual bool Dimse1;
```

#### Conditions
Read / Write
### Dimse2

#### Description
Accesses the current DIMSD2 value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMSD2.
```text
public virtual bool Dimse2;
```

#### Conditions
Read / Write
### Dimsoxd

#### Description
Accesses the current DIMSOXD value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMSOXD.
```text
public virtual bool Dimsoxd;
```

#### Conditions
Read / Write
### Dimtad

#### Description
Accesses the current DIMTAD value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTAD.
```text
public virtual int Dimtad;
```

#### Conditions
Read / Write
### Dimtdec

#### Description
Accesses the current DIMTDEC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTDEC.
```text
public virtual int Dimtdec;
```

#### Conditions
Read / Write
### Dimtfac

#### Description
Accesses the current DIMTFAC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTFAC.
```text
public virtual double Dimtfac;
```

#### Conditions
Read / Write
### Dimtfill

#### Description
Accesses the dimension background color state, which can be one of the following values: 
0 means the background color is disabled 
1 means the use background color from dimtfillclr
2 means the use drawing's background color
```text
public virtual int Dimtfill;
```

#### Conditions
Read / Write
### Dimtfillclr

#### Description
Accesses the current dimension background color (if dimtfill is set to 1).
```text
public virtual Autodesk.AutoCAD.Colors.Color Dimtfillclr;
```

#### Conditions
Read / Write
### Dimtih

#### Description
Accesses the current DIMTIH value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTIH.
```text
public virtual bool Dimtih;
```

#### Conditions
Read / Write
### Dimtix

#### Description
Accesses the current DIMTIX value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTIX.
```text
public virtual bool Dimtix;
```

#### Conditions
Read / Write
### Dimtm

#### Description
Accesses the current DIMTM value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTM.
```text
public virtual double Dimtm;
```

#### Conditions
Read / Write
### Dimtmove

#### Description
Accesses the current DIMTMOVE value for the database.
```text
public virtual int Dimtmove;
```

#### Conditions
Read / Write
### Dimtofl

#### Description
Accesses the current DIMTOFL value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTOFL
```text
public virtual bool Dimtofl;
```

#### Conditions
Read / Write
### Dimtoh

#### Description
Accesses the current DIMTOH value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTOH
```text
public virtual bool Dimtoh;
```

#### Conditions
Read / Write
### Dimtol

#### Description
Accesses the current DIMTOL value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTOL
```text
public virtual bool Dimtol;
```

#### Conditions
Read / Write
### Dimtolj

#### Description
Accesses the current DIMTOLJ value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTOLJ
```text
public virtual int Dimtolj;
```

#### Conditions
Read / Write
### Dimtp

#### Description
Accesses the current DIMTP value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTP
```text
public virtual double Dimtp;
```

#### Conditions
Read / Write
### Dimtsz

#### Description
Accesses the current DIMTSZ value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTSZ
```text
public virtual double Dimtsz;
```

#### Conditions
Read / Write
### Dimtvp

#### Description
Accesses the current DIMTVP value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTVP
```text
public virtual double Dimtvp;
```

#### Conditions
Read / Write
### Dimtxt

#### Description
Accesses the current DIMTXT value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTXT
```text
public virtual double Dimtxt;
```

#### Conditions
Read / Write
### Dimtzin

#### Description
Accesses the current DIMTZIN value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTZIN
```text
public virtual int Dimtzin;
```

#### Conditions
Read / Write
### Dimupt

#### Description
Accesses the current DIMUPT value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALT.
```text
public virtual bool Dimupt;
```

#### Conditions
Read / Write
### Dimzin

#### Description
Accesses the current DIMZIN value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMZIN.
```text
public virtual int Dimzin;
```

#### Conditions
Read / Write
### DynamicDimension

#### Description
Assesses if the dimension is dynamic.
```text
public bool DynamicDimension;
```

#### Conditions
Read / Write
### Elevation

#### Description
Accesses the dimension's elevation value. Elevation defines the distance from WCS origin to the plane on which the dimension lies.
```text
public double Elevation;
```

#### Conditions
Read / Write
### HorizontalRotation

#### Description
Accesses the horizontal rotation value (in radians) of the dimension.
```text
public double HorizontalRotation;
```

#### Conditions
Read / Write
### Measurement

#### Description
Accesses the current measurement value.
```text
public double Measurement;
```

#### Conditions
Read / Write
### Normal

#### Description
Accesses the unit normal vector (in WCS coordinates) for the dimension.
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
### Prefix

#### Description
Specifies the dimension value prefix.
```text
public virtual string Prefix;
```

#### Conditions
Read / Write
### Suffix

#### Description
Specifies the dimension value suffix.
```text
public virtual string Suffix;
```

#### Conditions
Read / Write
### SuppressAngularLeadingZeros

#### Description
Specifies the suppression of leading zeros in dimension values.
```text
public virtual bool SuppressAngularLeadingZeros;
```

#### Conditions
Read / Write
### SuppressAngularTrailingZeros

#### Description
Specifies the suppression of trailing zeros in dimension values.
```text
public virtual bool SuppressAngularTrailingZeros;
```

#### Conditions
Read / Write
### SuppressLeadingZeros

#### Description
Specifies the suppression of leading zeros in dimension values.
```text
public virtual bool SuppressLeadingZeros;
```

#### Conditions
Read / Write
### SuppressTrailingZeros

#### Description
Specifies the suppression of leading zeros in dimension values.
```text
public virtual bool SuppressTrailingZeros;
```

#### Conditions
Read / Write
### SuppressZeroFeet

#### Description
Specifies the suppression of a zero foot measurement in dimension values.
```text
public virtual bool SuppressZeroFeet;
```

#### Conditions
Read / Write
### SuppressZeroInches

#### Description
Specifies the suppression of a zero inch measurement in dimension values.
```text
public virtual bool SuppressZeroInches;
```

#### Conditions
Read / Write
### TextAttachment

#### Description
Accesses the attachment point value for the text of the dimension.
```text
public Autodesk.AutoCAD.DatabaseServices.AttachmentPoint TextAttachment;
```

#### Conditions
Read / Write
### TextDefinedSize

#### Description
Specifies the dimension text defined width and defined height from MText in dimension block
```text
public Vector2d TextDefinedSize;
```

#### Conditions
Read / Write
### TextLineSpacingFactor

#### Description
Accesses the line spacing factor (a value between 0.25 and 4.00).
```text
public double TextLineSpacingFactor;
```

#### Conditions
Read / Write
### TextLineSpacingStyle

#### Description
Accesses the line spacing style for the dimension.
```text
public Autodesk.AutoCAD.DatabaseServices.LineSpacingStyle TextLineSpacingStyle;
```

#### Conditions
Read / Write
### TextPosition

#### Description
Accesses the text position of the text (which is itself an MText object with middle-center justification).
```text
public Point3d TextPosition;
```

#### Conditions
Read / Write
### TextRotation

#### Description
Accesses the rotation angle (in radians) of to the horizontal axis used by the text.
```text
public double TextRotation;
```

#### Conditions
Read / Write
### ToleranceSuppressLeadingZeros

#### Description
Specifies the suppression of leading zeroes.
```text
public virtual bool ToleranceSuppressLeadingZeros;
```

#### Conditions
Read / Write
### ToleranceSuppressTrailingZeros

#### Description
Specifies the suppression of trailing zeroes.
```text
public virtual bool ToleranceSuppressTrailingZeros;
```

#### Conditions
Read / Write
### ToleranceSuppressZeroFeet

#### Description
Specifies the suppression of a zero feet.
```text
public virtual bool ToleranceSuppressZeroFeet;
```

#### Conditions
Read / Write
### ToleranceSuppressZeroInches

#### Description
Specifies the suppression of a zero inches.
```text
public virtual bool ToleranceSuppressZeroInches;
```

#### Conditions
Read / Write
### UsingDefaultTextPosition

#### Description
Returns true if the text is in the default position
```text
public bool UsingDefaultTextPosition;
```

#### Conditions
Read / Write