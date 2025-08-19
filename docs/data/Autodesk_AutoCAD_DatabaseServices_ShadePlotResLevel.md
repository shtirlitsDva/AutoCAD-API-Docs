# Autodesk.AutoCAD.DatabaseServices.ShadePlotResLevel Enumeration

## Overview

#### Description
This .NET class wraps the AcDbPlotSettings::ShadePlotResLevel ObjectARX class. 
This enumerated type defines the shade plot resolution level of the current PlotSettings object. The shade plot resolution level specifies the resolution at which shaded and rendered viewports will plot.
```text
public enum ShadePlotResLevel {
  Draft,
  Preview,
  Normal,
  Presentation,
  Maximum,
  Custom
}
```

#### Members

| Members | Description |
| --- | --- |
| Draft | Plot as wireframe; this setting is legacy mode. |
| Preview | Plot at one quarter of the current device resolution, to a maximum of 150 dpi. |
| Normal | Plot at half the current device resolution, to a maximum of 300 dpi; this is the default setting. |
| Presentation | Plot at the current device resolution, to a maximum of 600 dpi. |
| Maximum | Plot at the current device resolution, with no maximum. |
| Custom | Plot at the current device resolution, to a maximum dpi specified by the shade plot custom dpi. |