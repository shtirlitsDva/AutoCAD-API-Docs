# RasterVariables Class

## Overview

#### Description
This .NET class wraps the AcDbRasterVariables ObjectARX class. 
The RasterVariables object carries all drawing-scope persistent variables associated with AutoCAD raster image management and display. A single object of this type is stored in each drawing file that contains image entities.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.RasterVariables
```

```text
public class RasterVariables : DBObject;
```

#### See Also
DBObject, RasterImage, RasterImageDef

## Members

### Constructors

- [RasterVariables](#rastervariables)

### Properties

- [ImageFrame](#imageframe)
- [ImageQuality](#imagequality)
- [UserScale](#userscale)


## Constructors Details

### RasterVariables

#### Description
Constructs an RasterVariables object and initializes itself to default values.
```text
public RasterVariables();
```

### ImageFrame

#### Description
Accesses the current image frame visibility setting.
```text
public virtual FrameSetting ImageFrame;
```

#### Conditions
Read / Write
### ImageQuality

#### Description
Accesses the current image display quality setting. The Image Quality setting allows users to trade display speed for displayed image quality. In draft mode, fast low-quality image resampling and processing algorithms are used. In high quality mode, more computationally intensive algorithms are used, which usually generate more accurate and visually pleasing output. 
Note that the image quality setting applies only for display. Hardcopy output is always generated in high quality mode. 
See the _Autodesk Image Engine API Reference_ for more information on the specific image processing algorithms used.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.ImageQuality ImageQuality;
```

#### Conditions
Read / Write
### UserScale

#### Description
Accesses the real-world unit representing one AutoCAD drawing unit.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.Unit UserScale;
```

#### Conditions
Read / Write