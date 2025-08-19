# Autodesk.AutoCAD.DatabaseServices.GridPropertyParameter Structure

## Overview

#### Description
This .NET class wraps the AcGridProp ObjectARX struct, which stores grid line properties..
```text
public struct GridPropertyParameter {
  public GridProperties PropertyMask;
  public Autodesk.AutoCAD.DatabaseServices.GridLineStyle LineStyle;
  public Autodesk.AutoCAD.DatabaseServices.LineWeight LineWeight;
  public ObjectId Linetype;
  public Autodesk.AutoCAD.Colors.Color Color;
  public Autodesk.AutoCAD.DatabaseServices.Visibility Visibility;
  public double DoubleLineSpacing;
}
```

#### Members

| Members | Description |
| --- | --- |
| public GridProperties PropertyMask; | Mask to specify the grid properties to get or set. The properties should be combined using OR. |
| public Autodesk.AutoCAD.DatabaseServices.GridLineStyle LineStyle; | Grid line style |
| public Autodesk.AutoCAD.DatabaseServices.LineWeight LineWeight; | Grid line weight |
| public ObjectId Linetype; | Grid line type |
| public Autodesk.AutoCAD.Colors.Color Color; | Grid line color |
| public Autodesk.AutoCAD.DatabaseServices.Visibility Visibility; | Grid line visibility |
| public double DoubleLineSpacing; | Grid line double line spacing used if grid has double line style. |