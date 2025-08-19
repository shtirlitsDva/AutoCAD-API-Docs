# Autodesk.AutoCAD.DatabaseServices.NewLayerNotification Enumeration

## Overview

#### Description
This .NET enum wraps the AcDb::NewLayerNotification ObjectARX enumeration. 
This enum supports the LAYERNOTIFY header variable. Fields are bit-coded and can be OR'd together using a bitwise OR.
```text
public enum NewLayerNotification {
  NoNewLayerNotification = 0,
  NotifyOnInsert = 0x20,
  NotifyOnLayerStateRestore = 8,
  NotifyOnOpen = 2,
  NotifyOnPlot = 1,
  NotifyOnSave = 0x10,
  NotifyOnXrefAttachAndReload = 4
}
```

#### Members
| Members | Description |
| --- | --- |
| NoNewLayerNotification = 0 | All notification states are turned off |
| NotifyOnInsert = 0x20 | Display an alert when new layers are created by inserting a block |
| NotifyOnLayerStateRestore = 8 | Display an alert when new layers are created by restoring a layer state |
| NotifyOnOpen = 2 | Display an alert when new layers exist when a drawing is first opened |
| NotifyOnPlot = 1 | Display an alert when new layers exist, and plotting is about to begin |
| NotifyOnSave = 0x10 | Display an alert when new layers exist and the drawing is being saved |
| NotifyOnXrefAttachAndReload = 4 | Display an alert when new layers exist in an xref and the xref is being attached or reloaded |