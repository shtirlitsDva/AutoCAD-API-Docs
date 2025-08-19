# Autodesk.AutoCAD.DatabaseServices.PointCloudStylizationType Enumeration

## Overview

#### Description
Defines colorization mode of the point cloud.
```text
public enum PointCloudStylizationType {
  ClassificationRamp = 6,
  HeightRamp = 4,
  IntensityRamp = 5,
  NormalRamp = 3,
  SingleColor = 2,
  TrueColor = 1
}
```

#### Members
| Members | Description |
| --- | --- |
| ClassificationRamp = 6 | Colorizes points based on a classification assigned to the points. AutoCAD uses a default color scheme for LAS classification values. |
| HeightRamp = 4 | Colorizes each point based on the Z value of the point. AutoCAD uses a default Full color spectrum color scheme by default whose range is mapped to the lowest and highest intensity values of the point cloud object(s). |
| IntensityRamp = 5 | Colorizes each point based on the Intensity value of the point. AutoCAD uses a default full-color spectrum color scheme by default whose range is mapped to the lowest and highest intensity values of the point cloud object(s). |
| NormalRamp = 3 | Colorizes each point based on the normal of the point. AutoCAD uses a default hard-coded color scheme for the normals by default. |
| SingleColor = 2 | Assigns all points the color defined for the object (AutoCAD's object color property). |
| TrueColor = 1 | Colorizes each point based on the colors defined in the scan. |