# RenderSettings Class

## Overview

#### Description
This .NET class wraps the AcDbRenderSettings ObjectARX class. 
This class is a container for all properties relating to a generic high-fidelity renderer. A dictionary of these objects is resident in the database, in the named object dictionary as ACAD_RENDER_SETTINGS. They are indexed by the name of the setting objects. In the user interface, the contents of this dictionary correspond to user-defined render presets (not predefined presets). 
The active render settings object is stored in the named object dictionary as ACAD_RENDER_ACTIVE_SETTINGS.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.RenderSettings
        Autodesk.AutoCAD.DatabaseServices.RapidRTRenderSettings
```

```text
public class RenderSettings : DBObject;
```

#### See Also
MentalRayRenderSettings, [RenderSettingsTraits](Autodesk_AutoCAD_GraphicsInterface_RenderSettingsTraits.md)

## Members

### Constructors

- [RenderSettings](#rendersettings)

### Properties

- [BackFacesEnabled](#backfacesenabled)
- [Description](#description)
- [DiagnosticBackgroundEnabled](#diagnosticbackgroundenabled)
- [DisplayIndex](#displayindex)
- [IsPredefined](#ispredefined)
- [MaterialsEnabled](#materialsenabled)
- [Name](#name)
- [PreviewImageFileName](#previewimagefilename)
- [ShadowsEnabled](#shadowsenabled)
- [TextureSampling](#texturesampling)


## Constructors Details

### RenderSettings

#### Description
Default constructor.
```text
public RenderSettings();
```

### BackFacesEnabled

#### Description
Assesses whether back-facing faces are rendered.
```text
public bool BackFacesEnabled;
```

#### Conditions
Read / Write
### Description

#### Description
Accesses the description of the render settings.
```text
public string Description;
```

#### Conditions
Read / Write
### DiagnosticBackgroundEnabled

#### Description
Assesses whether the diagnostic (checker) background is used for rendering.
```text
public bool DiagnosticBackgroundEnabled;
```

#### Conditions
Read / Write
### DisplayIndex

#### Description
Accesses the display index of this render setting.
```text
public int DisplayIndex;
```

#### Conditions
Read / Write
### IsPredefined

#### Description
Specifies if the settings are predefined or not.
```text
public bool IsPredefined;
```

#### Conditions
Read / Write
### MaterialsEnabled

#### Description
Assesses whether materials are used per-object. When false, all objects are rendered with the global material.
```text
public bool MaterialsEnabled;
```

#### Conditions
Read / Write
### Name

#### Description
Accesses the user-defined name of the render settings.
```text
public string Name;
```

#### Conditions
Read / Write
### PreviewImageFileName

#### Description
Accesses the full path and file name of the preview image.
```text
public string PreviewImageFileName;
```

#### Conditions
Read / Write
### ShadowsEnabled

#### Description
Assesses whether shadows are rendered or not.
```text
public bool ShadowsEnabled;
```

#### Conditions
Read / Write
### TextureSampling

#### Description
Assesses whether sampling (filtering) of image textures is on or off.
```text
public bool TextureSampling;
```

#### Conditions
Read / Write