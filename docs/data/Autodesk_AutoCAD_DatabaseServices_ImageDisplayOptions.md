# Autodesk.AutoCAD.DatabaseServices.ImageDisplayOptions Enumeration

## Overview

#### Description
This .NET class wraps the AcDbRasterImage::ImageDisplayOpt ObjectARX enum. 
The ImageDisplayOptions types specify display options.
```text
public enum ImageDisplayOptions {
  Clip = 4,
  Show = 1,
  ShowUnaligned = 2,
  Transparent = 8
}
```

#### Members

| Members | Description |
| --- | --- |
| Clip = 4 | Clip image |
| Show = 1 | Show image (or draw frame only) |
| ShowUnaligned = 2 | Show rotates images (or draw frame only) |
| Transparent = 8 | Use transparent background for bitonal images (or use opaque background color) |