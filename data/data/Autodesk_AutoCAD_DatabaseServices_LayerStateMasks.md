# Autodesk.AutoCAD.DatabaseServices.LayerStateMasks Enumeration

## Overview

#### Description
This .NET class wraps the AcDbLayerStateManager::LayerStateMask ObjectARX class. 
The LayerStateMasks enumeration defines the bits used to specify the layer attributes.
#### Members
| Members | Description |
| --- | --- |
| Color = 0x20 | Allows color changes |
| CurrentViewport = 0x200 | Indicates the user preference regarding whether to restore the current viewport VPLAYER settings during a restore layer state operation |
| Frozen = 2 | Freezes (no regeneration, plotting, or rendering) the layer |
| LastRestored = 0x10000 | Layer is the last one restored |
| LineType = 0x40 | Allows linetype changes |
| LineWeight = 0x80 | Allows lineweight changes |
| Locked = 4 | Locks (no selection or editing) the layer |
| NewViewport = 0x10 | Adds the layer to new viewports |
| None = 0 | No restrictions |
| On = 1 | Makes the layer visible |
| Plot = 8 | Allows the layer to be plotted |
| PlotStyle = 0x100 | Allow plotstyle changes |
| Transparency = 0x400 | Allow transparency changes. |