# Autodesk.AutoCAD.DatabaseServices.ShadePlotType Enumeration

## Overview

#### Description
This .NET class wraps the AcDbViewport::ShadePlotType ObjectARX class. This enumerated type defines the shade plot mode of the current viewport. This mode specifies how the current viewport will plot.
```text
public enum ShadePlotType {
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
| Hidden | Plot hidden regardless of display. |
| Rendered | Plot rendered regardless of display. |
| VisualStyle | Plot using the visual style settings referenced by ShadePlotId. |
| RenderPreset | Plot using the preferences referenced by the ShadePlotId. |