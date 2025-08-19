# Autodesk.AutoCAD.DatabaseServices.PointCloudItemType Enumeration

## Overview

#### Description
Describes the type of point cloud item.
```text
public enum PointCloudItemType {
  LegacyPointCloud,
  PointCloudProject,
  IndividualScan,
  Scan,
  Region,
  ScanRootGroup,
  RegionRootGroup,
  UnassignedPoint
}
```

#### Members

| Members | Description |
| --- | --- |
| LegacyPointCloud | Legacy point cloud (load from a .pcg, .isd file). |
| PointCloudProject | Point cloud project (load from a .rcp file which contains several .rcs files). |
| IndividualScan | Individual scan (load from a .rcs file directly). |
| Scan | Scan (a scan file included in a point cloud project file). |
| Region | A region is a Non-overlapping area that are defined in a point cloud for the purpose of filtering the display of meaningful volumes in the scene. |
| ScanRootGroup | Folder to contain all scan items. |
| RegionRootGroup | Folder to contain all region items. |
| UnassignedPoint | Points which are not assigned to any region. |