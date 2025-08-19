# DBVisualStyle Class

## Overview

#### Description
This is a .NET wrapper for the AcDbVisualStyle ObjectARX class. 
This class describes the visual style database object, which contains a collection of properties that can be applied to faces, edges and the display.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.DBVisualStyle
```

```text
public class DBVisualStyle : DBObject;
```

### Constructors

- [DBVisualStyle](#dbvisualstyle)

### Methods

- [CopyFrom](#copyfrom)
- [CopyTo](#copyto)
- [GetTrait](#gettrait)
- [GetTraitFlag](#gettraitflag)
- [SetTrait(VisualStyleProperty, [MarshalAs(UnmanagedType.U1)] bool, VisualStyleOperation)](#settrait(visualstyleproperty,-[marshalas(unmanagedtype.u1)]-bool,-visualstyleoperation))
- [SetTrait(VisualStyleProperty, Autodesk.AutoCAD.Colors.Color, VisualStyleOperation)](#settrait(visualstyleproperty,-autodesk.autocad.colors.color,-visualstyleoperation))
- [SetTrait(VisualStyleProperty, double, double, double, VisualStyleOperation)](#settrait(visualstyleproperty,-double,-double,-double,-visualstyleoperation))
- [SetTrait(VisualStyleProperty, double, VisualStyleOperation)](#settrait(visualstyleproperty,-double,-visualstyleoperation))
- [SetTrait(VisualStyleProperty, int, VisualStyleOperation)](#settrait(visualstyleproperty,-int,-visualstyleoperation))
- [SetTrait(VisualStyleProperty, object, VisualStyleOperation)](#settrait(visualstyleproperty,-object,-visualstyleoperation))
- [SetTraitFlag](#settraitflag)

### Properties

- [Description](#description)
- [InternalUseOnly](#internaluseonly)
- [Type](#type)


## Constructors Details

### DBVisualStyle

#### Description
Default constructor.
```text
public DBVisualStyle();
```

### CopyFrom

#### Description
Copies the settings from another object.
```text
public virtual void CopyFrom(
    VisualStyle pSrc
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| VisualStyle pSrc | Input visual style source |

### CopyTo

#### Description
Copies the settings to another object.
```text
public virtual void CopyTo(
    VisualStyle pDest
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| VisualStyle pDest | Input visual style destination. |

### GetTrait

#### Description
Gets a property of the visual style.
```text
public object GetTrait(
    VisualStyleProperty prop
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| VisualStyleProperty prop | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleProperty being queried. |

#### Returns
The Autodesk.AutoCAD.GraphicsInterface.Variant value of the property if successful; otherwise, a Variant of type VariantType.Undefined.
### GetTraitFlag

#### Description
Gets a property flag from the visual style for properties that are bitfield enums.
```text
public bool GetTraitFlag(
    VisualStyleProperty prop, 
    uint modopt(IsLong) flagVal
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| uint modopt(IsLong) flagVal | Input bit flag enum unsigned long property being queried. |
| flagProp | Input bitfield enum Autodesk.AutoCAD.GraphicsInterface.VisualStyleProperty being queried. |

#### Returns
True if flag is enabled; otherwise False.
### SetTrait(VisualStyleProperty, [MarshalAs(UnmanagedType.U1)] bool, VisualStyleOperation)

#### Description
Sets a boolean property of the visual style.
```text
public void SetTrait(
    VisualStyleProperty prop, 
    [MarshalAs(UnmanagedType.U1)] bool bVal, 
    VisualStyleOperation __unnamed002
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| VisualStyleProperty prop | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleProperty to set. Valid Property values for this method are:EdgeHidePrecision |
| [MarshalAs(UnmanagedType.U1)] bool bVal | Input boolean property value to set. |
| op | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleOperation to use when setting the property. |

### SetTrait(VisualStyleProperty, Autodesk.AutoCAD.Colors.Color, VisualStyleOperation)

#### Description
Sets a color property of the visual style.
```text
public void SetTrait(
    VisualStyleProperty prop, 
    Autodesk.AutoCAD.Colors.Color color, 
    VisualStyleOperation __unnamed002
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| VisualStyleProperty prop | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleProperty being set. Valid Property values for this method are:FaceMonoColorEdgeIntersectionColorEdgeObscuredColorEdgeColorEdgeSilhouetteColor |
| pColor | Input AcCmColor property value. |
| op | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleOperation to use when setting the property. |

### SetTrait(VisualStyleProperty, double, double, double, VisualStyleOperation)

#### Description
Sets a color property of the visual style.
```text
public void SetTrait(
    VisualStyleProperty prop, 
    double red, 
    double green, 
    double blue, 
    VisualStyleOperation op
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| VisualStyleProperty prop | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleProperty to set. Valid Property values for this method are:FaceMonoColorEdgeIntersectionColorEdgeObscuredColorEdgeColorEdgeSilhouetteColor |
| double red | Input red color value to set. Valid value is from 0.0 to 1.0. |
| double green | Input green color value to set. Valid value is from 0.0 to 1.0. |
| double blue | Input blue color value to set. Valid value is from 0.0 to 1.0. |
| VisualStyleOperation op | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleOperation to use when setting the property. |

### SetTrait(VisualStyleProperty, double, VisualStyleOperation)

#### Description
Sets a double property of the visual style.
```text
public void SetTrait(
    VisualStyleProperty prop, 
    double dVal, 
    VisualStyleOperation op
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| VisualStyleProperty prop | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleProperty to set. Valid Property values for this method are:FaceOpacityFaceSpecularEdgeCreaseAngleEdgeOpacityDisplayBrightness |
| double dVal | Input double property value to set. |
| VisualStyleOperation op | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleOperation to use when setting the property. |

### SetTrait(VisualStyleProperty, int, VisualStyleOperation)

#### Description
Sets an integer property of the visual style.
```text
public void SetTrait(
    VisualStyleProperty prop, 
    int nVal, 
    VisualStyleOperation op
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| VisualStyleProperty prop | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleProperty to set. Valid Property values for this method are:FaceLightingModelFaceLightingQualityFaceColorModeFaceModifierEdgeModelEdgeStyleEdgeObscuredLinePatternEdgeIntersectionLinePatternEdgeModifierEdgeWidthEdgeOverhangEdgeJitterAmountEdgeSilhouetteWidthEdgeHaloGapEdgeIsolinesDisplayStyleDisplayShadowType |
| int nVal | Input integer property value to set. |
| VisualStyleOperation op | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleOperation to use when setting the property. |

### SetTrait(VisualStyleProperty, object, VisualStyleOperation)

#### Description
Sets a property of the visual style.
#### Parameters

| Parameters | Description |
| --- | --- |
| VisualStyleProperty prop | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleProperty to set. |
| object val | Input Autodesk.AutoCAD.GraphicsInterface.Variant property value to set. |
| VisualStyleOperation op | Input Autodesk.AutoCAD.GraphicsInterface.VisualStyleOperation to use when setting the property. |

Previous Declaration
```text
public void SetTrait(
VisualStyleProperty prop,
Autodesk.AutoCAD.GraphicsInterface.Variant val,
VisualStyleOperation op
);
```

### SetTraitFlag

#### Description
Sets a property flag of the visual style, for properties which are bitfield enums.
```text
public void SetTraitFlag(
    VisualStyleProperty prop, 
    uint modopt(IsLong) flagVal, 
    [MarshalAs(UnmanagedType.U1)] bool bEnable
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| uint modopt(IsLong) flagVal | Input bit flag enum unsigned long property to set. |
| [MarshalAs(UnmanagedType.U1)] bool bEnable | True to enable the flag; False to disable. |
| flagProp | Input bitfield enum Autodesk.AutoCAD.GraphicsInterface.VisualStyleProperty to set. |

### Description

#### Description
Accesses the description of the visual style.
```text
public string Description;
```

#### Conditions
Read / Write
### InternalUseOnly

#### Description
Assesses if the visual style is for internal use.
```text
public virtual bool InternalUseOnly;
```

#### Conditions
Read / Write
### Type

#### Description
Assesses the visual style type.
```text
public Autodesk.AutoCAD.GraphicsInterface.VisualStyleType Type;
```

#### Conditions
Read / Write