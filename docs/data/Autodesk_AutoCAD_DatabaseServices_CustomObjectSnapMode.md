# CustomObjectSnapMode Class

## Overview

#### Description
This .NET class wraps the AcDbCustomOsnapMode and AcDbCustomOsnapManager ObjectARX classes. 
Whenever a keyword representing a built-in OSNAP mode can be used, the keyword of any of the registered custom OSNAP modes can also be entered. These places include: 
  * establishing an OSNAP override whenever a point is being acquired.
  * establishing the equivalent of running OSNAP modes via the -OSNAP command as explained in _AutoCAD User Guide_ and _Reference_.
  * invoking the AutoLISP (OSNAP) function

It can be specified as a running mode via the OSNAP command, setting the OSNAP system variable, or by on-the-fly OSNAP qualifiers for specific point acquisition as a transient OSNAP mode, and so on. Ideally, dialogs that correspond to OSNAP modes can be expanded to handle any of the registered OSNAP modes also. Typically, the LocalModeString would be visible to the user, and documented, while GlobalModeString would be used by programs intended to run on different localized versions of AutoCAD. 
CustomOsnapManager defines the manager object for registered custom OSNAP modes. A custom OSNAP mode is defined by registering an instance of CustomOsnapMode with the CustomOsnapManager object. Custom modes are registered and deregistered through this object, they can be activated and deactivated, and the set of currently active modes can be queried through this object. 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.CustomObjectSnapMode
```

```text
public sealed class CustomObjectSnapMode : DisposableWrapper;
```

#### See Also
[InputPoint](Autodesk_AutoCAD_EditorInput_InputPointContext.md "InputPointContext Class"), [Glyph](Autodesk_AutoCAD_GraphicsInterface_Glyph.md)

## Members

### Constructors

- [CustomObjectSnapMode(string, string, string, Autodesk.AutoCAD.GraphicsInterface.Glyph)](#customobjectsnapmode(string,-string,-string,-autodesk.autocad.graphicsinterface.glyph))
- [CustomObjectSnapMode(string, string, string, Autodesk.AutoCAD.GraphicsInterface.Glyph, System.Drawing.Bitmap, string)](#customobjectsnapmode(string,-string,-string,-autodesk.autocad.graphicsinterface.glyph,-system.drawing.bitmap,-string))

### Methods

- [Activate](#activate)
- [ApplyToEntityType](#applytoentitytype)
- [Deactivate](#deactivate)
- [IsActive](#isactive)
- [RemoveFromEntityType](#removefromentitytype)

### Properties

- [Bitmap](#bitmap)
- [DisplayString](#displaystring)
- [GlobalModeString](#globalmodestring)
- [Glyph](#glyph)
- [GlyphSize](#glyphsize)
- [LocalModeString](#localmodestring)
- [ToolTipText](#tooltiptext)


## Constructors Details

### CustomObjectSnapMode(string, string, string, Autodesk.AutoCAD.GraphicsInterface.Glyph)

#### Description
Constructor.
```text
public CustomObjectSnapMode(
    string localModeString, 
    string globalModeString, 
    string toolTipText, 
    Autodesk.AutoCAD.GraphicsInterface.Glyph glyph
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string localModeString | Input local mode string |
| string globalModeString | Input global mode string |
| string toolTipText | Input tool tip text |
| Autodesk.AutoCAD.GraphicsInterface.Glyph glyph | Input glyph to use |

### CustomObjectSnapMode(string, string, string, Autodesk.AutoCAD.GraphicsInterface.Glyph, System.Drawing.Bitmap, string)

#### Description
Constructor to initialize a CustomObjectSnapMode, support display icon and string.
```text
public CustomObjectSnapMode(
    string localModeString, 
    string globalModeString, 
    string toolTipText, 
    Autodesk.AutoCAD.GraphicsInterface.Glyph glyph, 
    System.Drawing.Bitmap bitmap, 
    string displayString
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string localModeString | Input local mode string |
| string globalModeString | Input global mode string |
| string toolTipText | Input tool tip text |
| Autodesk.AutoCAD.GraphicsInterface.Glyph glyph | Input glyph to use |
| System.Drawing.Bitmap bitmap | Input menu item icon |
| string displayString | Input menu item display string |

### Activate

#### Description
This function is used to activate an OSNAP mode. The input string is compared with local mode strings if it does not begin with "_", and with the global mode strings if it does begin with "_".
```text
public static void Activate(
    string mode
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string mode | Input custom OSNAP mode string |

### ApplyToEntityType

#### Description
Applies a new callback to the given entity.
```text
public void ApplyToEntityType(
    RXClass entity, 
    AddObjectSnapInfo callback
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| RXClass entity | Input entity to apply to |
| AddObjectSnapInfo callback | Input callback to apply |

### Deactivate

#### Description
Used to deactivate an OSNAP mode. The same search rules apply as for activateOsnapMode().
```text
public static void Deactivate(
    string mode
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string mode | Input mode string |

### IsActive

#### Description
Returns true if the mode is registered and active; otherwise, returns false.
```text
public static bool IsActive(
    string mode
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string mode | Input custom OSNAP mode string |

### RemoveFromEntityType

#### Description
Removes an entity type.
```text
public void RemoveFromEntityType(
    RXClass entity
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| RXClass entity | Input entity to remove |

### Bitmap

#### Description
Gets the bitmap used as osnap menu item icon. 
If no bitmap set, check mark will be used.
```text
public System.Drawing.Bitmap Bitmap;
```

#### Conditions
Read-only
### DisplayString

#### Description
Gets the display string. If no display string is set, local mode string will be used as the menu item string.
```text
public string DisplayString;
```

#### Conditions
Read-only
### GlobalModeString

#### Description
Returns the global custom OSNAP keyword string that user must type in which is the actual text string which AutoCAD point acquisition and running OSNAP modes will recognize.
```text
public string GlobalModeString;
```

#### Conditions
Read-only
### Glyph

#### Description
Returns the custom glyph. Returns NULL if a custom glyph is not used.
```text
public Autodesk.AutoCAD.GraphicsInterface.Glyph Glyph;
```

#### Conditions
Read-only
### GlyphSize

#### Description
Returns the size of the glyph.
```text
public static int GlyphSize;
```

#### Conditions
Read-only
### LocalModeString

#### Description
Returns the local custom OSNAP keyword string the user must type; this is the actual text string that AutoCAD point acquisition and running OSNAP modes will recognize.
```text
public string LocalModeString;
```

#### Conditions
Read-only
### ToolTipText

#### Description
This method returns the OSNAP mode glyph and default tooltip string.
```text
public string ToolTipText;
```

#### Conditions
Read-only