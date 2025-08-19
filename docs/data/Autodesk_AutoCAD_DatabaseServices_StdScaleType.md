# Autodesk.AutoCAD.DatabaseServices.StdScaleType Enumeration

## Overview

#### Description
This .NET enum wraps AcDbPlotSettings::stdScaleType> ObjectARX enum. 
The stdScaleType property stores the "standard" print scale selection, including scale-to-fit, for the plot settings object. It is not a number like customPrintScale, but is an enum indicating the desired print scale. AutoCAD uses this, along with other information like the plot area, to compute the customPrintScale when useStandardScale is true. While the stdScaleType property always has a value, it may or may not be reflected in the customPrintScale, depending on the value of the useStandardScale property.
```text
public enum StdScaleType {
  ScaleToFit,
  StdScale1To128InchIs1ft,
  StdScale1To64InchIs1ft,
  StdScale1To32InchIs1ft,
  StdScale1To16InchIs1ft,
  StdScale3To32InchIs1ft,
  StdScale1To8InchIs1ft,
  StdScale3To16InchIs1ft,
  StdScale1To4InchIs1ft,
  StdScale3To8InchIs1ft,
  StdScale1To2InchIs1ft,
  StdScale3To4InchIs1ft,
  StdScale1InchIs1ft,
  StdScale3InchIs1ft,
  StdScale6InchIs1ft,
  StdScale1ftIs1ft,
  StdScale1To1,
  StdScale1To2,
  StdScale1To4,
  StdScale1To5,
  StdScale1To8,
  StdScale1To10,
  StdScale1To16,
  StdScale1To20,
  StdScale1To30,
  StdScale1To40,
  StdScale1To50,
  StdScale1To100,
  StdScale2To1,
  StdScale4To1,
  StdScale8To1,
  StdScale10To1,
  StdScale100To1,
  StdScale1000To1
}
```

#### Members

| Members | Description |
| --- | --- |
| ScaleToFit | Scaled to Fit. |
| StdScale1To128InchIs1ft | 1/128"= 1' |
| StdScale1To64InchIs1ft | 1/16"= 1' |
| StdScale1To32InchIs1ft | 1/32"= 1' |
| StdScale1To16InchIs1ft | 1/16"= 1' |
| StdScale3To32InchIs1ft | 3/32"= 1' |
| StdScale1To8InchIs1ft | 1/8" = 1' |
| StdScale3To16InchIs1ft | 3/16"= 1' |
| StdScale1To4InchIs1ft | 1/4" = 1' |
| StdScale3To8InchIs1ft | 3/8" = 1' |
| StdScale1To2InchIs1ft | 1/2" = 1' |
| StdScale3To4InchIs1ft | 3/4" = 1' |
| StdScale1InchIs1ft | 1"= 1' |
| StdScale3InchIs1ft | 3"= 1' |
| StdScale6InchIs1ft | 6"= 1' |
| StdScale1ftIs1ft | 1'= 1' |
| StdScale1To1 | 1:1 |
| StdScale1To2 | 1:2 |
| StdScale1To4 | 1:4 |
| StdScale1To8 | 1:8 |
| StdScale1To10 | 1:10 |
| StdScale1To16 | 1:16 |
| StdScale1To20 | 1:20 |
| StdScale1To30 | 1:30 |
| StdScale1To40 | 1:40 |
| StdScale1To50 | 1:50 |
| StdScale1To100 | 1:100 |
| StdScale2To1 | 2:1 |
| StdScale4To1 | 4:1 |
| StdScale8To1 | 8:1 |
| StdScale10To1 | 10:1 |
| StdScale100To1 | 100:1 |
| StdScale1000To1 | 1000:1 |