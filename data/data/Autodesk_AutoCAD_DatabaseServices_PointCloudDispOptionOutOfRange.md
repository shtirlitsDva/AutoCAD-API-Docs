# Autodesk.AutoCAD.DatabaseServices.PointCloudDispOptionOutOfRange Enumeration

## Overview

#### Description
Defines the display options for the points which are out of intensity/elevation range.
```text
public enum PointCloudDispOptionOutOfRange {
  UseMinMaxColors,
  UseRGBScanColors,
  HidePoints
}
```

#### Members
| Members | Description |
| --- | --- |
| UseMinMaxColors | Uses maximum color in the color ramp for the points which are higher than the intensity/elevation range. Uses minimum color in the color ramp for the points which are lower than the intensity/elevation range. |
| UseRGBScanColors | Uses RGB scan colors for the points which are out of intensity/elevation range. |
| HidePoints | Hide points which are out of intensity/elevation range. |