# Image Class

## Overview

#### Description
This .NET class wraps the AcDbImage ObjectARX class. 
Abstract base class for immediate mode raster-based entities, including RasterImage. Every time entities derived from this class are drawn on the screen or plotted, the getScanLines method is called by the display or plot driver to get the pixels needed for display in the image format and scale required by the driver. These objects must be drawn at regen time using the ViewportGeometry.RasterImageDc() method accessible through ViewportDraw.Geometry() in the entity's ViewportDraw method.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Image
            Autodesk.AutoCAD.DatabaseServices.RasterImage
```

```text
public class Image : Entity;
```