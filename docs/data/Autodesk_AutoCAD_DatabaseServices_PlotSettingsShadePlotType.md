# Autodesk.AutoCAD.DatabaseServices.PlotSettingsShadePlotType Enumeration

## Overview

#### Description
This .NET class wraps the AcDbPlotSettings::ShadePlotType ObjectARX enum. 
This enumerated type defines the shade plot mode of the current PlotSettings object. This mode specifies how viewports will plot.
```text
public enum PlotSettingsShadePlotType {
  AsDisplayed,
  Wireframe,
  Hidden,
  Rendered,
  VisualStyle,
  RenderPreset
}
```

#### Members

| Members | Description |
| --- | --- |
| AsDisplayed | Plot the same way it is displayed. |
| Wireframe | Plot wireframe regardless of display. |
| Hidden | Plot the same way it is displayed. |
| Rendered | Plot the same way it is displayed. |
| VisualStyle | Plot using the visual style settings referenced by the shade plot ID. |
| RenderPreset | Plot using the render preferences referenced by the shade plot ID. |