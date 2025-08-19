# PointCloudColorMap Class

## Overview

#### Description
This is class Autodesk.AutoCAD.DatabaseServices.PointCloudColorMap.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.PointCloudColorMap
```

```text
public class PointCloudColorMap : DBObject;
```

### Events

- [PointCloudColorSchemeChanged](#pointcloudcolorschemechanged)

### Methods

- [ClassificationColorSchemeInUse](#classificationcolorschemeinuse)
- [ClassificationScheme](#classificationscheme)
- [ColorScheme](#colorscheme)
- [ColorSchemeInUse](#colorschemeinuse)
- [DeleteClassificationScheme](#deleteclassificationscheme)
- [DeleteColorScheme](#deletecolorscheme)
- [GetColorMapId](#getcolormapid)
- [HasClassificationScheme](#hasclassificationscheme)
- [HasColorScheme](#hascolorscheme)
- [SetClassificationScheme](#setclassificationscheme)
- [SetColorScheme](#setcolorscheme)

### Properties

- [ClassificationSchemeGUIDs](#classificationschemeguids)
- [ColorSchemeGUIDs](#colorschemeguids)
- [DefaultClassificationColorScheme](#defaultclassificationcolorscheme)
- [DefaultElevationColorScheme](#defaultelevationcolorscheme)
- [DefaultIntensityColorScheme](#defaultintensitycolorscheme)


## Events Details

### PointCloudColorSchemeChanged

#### Description
This is PointCloudColorSchemeChanged, a member of class PointCloudColorMap.
```text
public event PointCloudColorSchemeChangedEventHandler PointCloudColorSchemeChanged;
```

### ClassificationColorSchemeInUse

#### Description
This is ClassificationColorSchemeInUse, a member of class PointCloudColorMap.
```text
public virtual string\[\] ClassificationColorSchemeInUse();
```

### ClassificationScheme

#### Description
This is ClassificationScheme, a member of class PointCloudColorMap.
```text
public virtual bool ClassificationScheme(
    string name, 
    out PointCloudClassificationColorRamp target
);
```

### ColorScheme

#### Description
This is ColorScheme, a member of class PointCloudColorMap.
```text
public virtual bool ColorScheme(
    string name, 
    out PointCloudColorRamp target
);
```

### ColorSchemeInUse

#### Description
This is ColorSchemeInUse, a member of class PointCloudColorMap.
```text
public virtual string\[\] ColorSchemeInUse();
```

### DeleteClassificationScheme

#### Description
This is DeleteClassificationScheme, a member of class PointCloudColorMap.
```text
public virtual bool DeleteClassificationScheme(
    string name
);
```

### DeleteColorScheme

#### Description
This is DeleteColorScheme, a member of class PointCloudColorMap.
```text
public virtual bool DeleteColorScheme(
    string name
);
```

### GetColorMapId

#### Description
This is GetColorMapId, a member of class PointCloudColorMap.
```text
public static ObjectId GetColorMapId(
    Database hostDatabase
);
```

### HasClassificationScheme

#### Description
This is HasClassificationScheme, a member of class PointCloudColorMap.
```text
public virtual bool HasClassificationScheme(
    string name
);
```

### HasColorScheme

#### Description
This is HasColorScheme, a member of class PointCloudColorMap.
```text
public virtual bool HasColorScheme(
    string name
);
```

### SetClassificationScheme

#### Description
This is SetClassificationScheme, a member of class PointCloudColorMap.
```text
public virtual bool SetClassificationScheme(
    string name, 
    PointCloudClassificationColorRamp source
);
```

### SetColorScheme

#### Description
This is SetColorScheme, a member of class PointCloudColorMap.
```text
public virtual bool SetColorScheme(
    string name, 
    PointCloudColorRamp source
);
```

### ClassificationSchemeGUIDs

#### Description
This is ClassificationSchemeGUIDs, a member of class PointCloudColorMap.
```text
public virtual string ClassificationSchemeGUIDs;
```

### ColorSchemeGUIDs

#### Description
This is ColorSchemeGUIDs, a member of class PointCloudColorMap.
```text
public virtual string ColorSchemeGUIDs;
```

### DefaultClassificationColorScheme

#### Description
This is DefaultClassificationColorScheme, a member of class PointCloudColorMap.
```text
public virtual string DefaultClassificationColorScheme;
```

### DefaultElevationColorScheme

#### Description
This is DefaultElevationColorScheme, a member of class PointCloudColorMap.
```text
public virtual string DefaultElevationColorScheme;
```

### DefaultIntensityColorScheme

#### Description
This is DefaultIntensityColorScheme, a member of class PointCloudColorMap.
```text
public virtual string DefaultIntensityColorScheme;
```
