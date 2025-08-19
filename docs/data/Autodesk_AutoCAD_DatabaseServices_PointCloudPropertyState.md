# Autodesk.AutoCAD.DatabaseServices.PointCloudPropertyState Enumeration

## Overview

#### Description
Defines the current state of supported properties in the point cloud data.
```text
public enum PointCloudPropertyState {
  All = 1,
  None = -1,
  Some = 0
}
```

#### Members

| Members | Description |
| --- | --- |
| All = 1 | All scans in the point cloud have the property. |
| None = -1 | No scan in the point cloud has the property. |
| Some = 0 | Some scans in the point cloud have the property and some do not have the property. |