# Background Class

## Overview

#### Description
This .NET class wraps the AcDbBackground ObjectARX class. 
Background is the base class of all background objects that describe a viewport background. There are three types of concrete background types: SolidBackground, GradientBackground and AcDbImageBackground. Each object should reside in the ACAD_BACKGROUND dictionary. If a tilemode viewport or a paperspace viewport has a background, it has to refer to one of these classes. 
The application that sets a viewport background has the following responsibilities: 
  * Create a new background, give it a unique name, set appropriate properties and append it to the ACAD_BACKGROUND dictionary.
  * Remove the previous background object from the dictionary (if it does not require it anymore).

Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Background
        Autodesk.AutoCAD.DatabaseServices.GradientBackground
        Autodesk.AutoCAD.DatabaseServices.GroundPlaneBackground
        Autodesk.AutoCAD.DatabaseServices.IBLBackground
        Autodesk.AutoCAD.DatabaseServices.ImageBackground
        Autodesk.AutoCAD.DatabaseServices.SolidBackground
```

```text
public class Background : DBObject;
```

#### Notes
A background object should not be shared among viewports. When a viewport is deleted, its associated background will be deleted too.
### Methods

- [GetBackgroundDictionaryId](#getbackgrounddictionaryid)


## Methods Details

### GetBackgroundDictionaryId

#### Description
Given the database, this function opens the background dictionary. If the dictionary does not exist, it will be created if createIfNotPresent is true.
```text
public static ObjectId GetBackgroundDictionaryId(
    Database database, 
    [MarshalAs(UnmanagedType.U1)] bool createIfNotPresent
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database database | Input the database from which to retrieve the background dictionary |
| [MarshalAs(UnmanagedType.U1)] bool createIfNotPresent | Input whether the function should create the background dictionary if it does not currently exists in the specified database |
