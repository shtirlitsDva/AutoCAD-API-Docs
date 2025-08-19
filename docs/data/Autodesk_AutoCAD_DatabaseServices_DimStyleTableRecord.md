# DimStyleTableRecord Class

## Overview

#### Description
This .NET class wraps the AcDbDimStyleTableRecord ObjectARX class. 
Objects of this class represent the records found in the DimStyleTable. Each of these records contains the information necessary to generate a specific appearance (that is, text above, in, or below the line; arrows, slashes, or dots at the end of the dimension line, and so on) for dimensions that reference it.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTableRecord
        Autodesk.AutoCAD.DatabaseServices.DimStyleTableRecord
```

```text
public class DimStyleTableRecord : SymbolTableRecord;
```

#### Notes
For dimensioning, it is often desirable to have a set of similar styles that are essentially variations on a theme, with each style intended for a different dimension type (that is, angular, linear, radial, and so on). Such a group of styles is known as an DimStyle family.
### Constructors

- [DimStyleTableRecord](#dimstyletablerecord)

### Methods

- [GetArrowId](#getarrowid)

### Properties

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
- [Dimcen](#dimcen)
- [Dimclrd](#dimclrd)
- [Dimclre](#dimclre)
- [Dimclrt](#dimclrt)
- [Dimdec](#dimdec)
- [Dimdle](#dimdle)
- [Dimdli](#dimdli)
- [Dimdsep](#dimdsep)
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
- [Dimtxsty](#dimtxsty)
- [Dimtxt](#dimtxt)
- [Dimtzin](#dimtzin)
- [Dimupt](#dimupt)
- [Dimzin](#dimzin)
- [IsModifiedForRecompute](#ismodifiedforrecompute)


## Constructors Details

### DimStyleTableRecord

#### Description
Default constructor.
```text
public DimStyleTableRecord();
```

### GetArrowId

#### Description
Given an arrowhead, this function returns the ObjectId of the arrowhead.
```text
public ObjectId GetArrowId(
    DimArrowFlag whichArrow
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DimArrowFlag whichArrow | Input a dimension arrowhead |

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
### Dimtxsty

#### Description
Accesses the object ID of the TextStyle specified by the current DIMTXSTY value of the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTXSTY.
```text
public virtual ObjectId Dimtxsty;
```

#### Conditions
Read / Write
### Dimtxt

#### Description
Accesses the current DIMTXT value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTXT.
```text
public virtual double Dimtxt;
```

#### Conditions
Read / Write
### Dimtzin

#### Description
Accesses the current DIMTZIN value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTZIN.
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
### IsModifiedForRecompute

#### Description
Assesses the modified state of this dimension style. 
This is intended to provide a simple method to query a dimension style to find out if objects referencing that style should be updated (without the overhead of adding a persistent reactor to the style table record).
```text
public bool IsModifiedForRecompute;
```

#### Conditions
Read-only