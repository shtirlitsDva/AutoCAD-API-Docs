# TextEditorSelectionbase Class

## Overview

#### Description
This wraps the ObjectARX [AcDbTextEditorSelectionBase](AcDbTextEditorSelectionBase.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.TextEditorSelectionbase
    Autodesk.AutoCAD.DatabaseServices.TextEditorCursor
    Autodesk.AutoCAD.DatabaseServices.TextEditorSelection
```

```text
public class TextEditorSelectionbase : DisposableWrapper;
```

### Methods

- [InputSpecialChar](#inputspecialchar)
- [InsertColumnBreak](#insertcolumnbreak)
- [InsertImportedText](#insertimportedtext)
- [InsertString](#insertstring)
- [InsertSymbol](#insertsymbol)

### Other

- [AutoCAD.DatabaseServices.TextEditorSelectionbase.FlowAlign Enumeration](#autocad.databaseservices.texteditorselectionbase.flowalign-enumeration)
- [AutoCAD.DatabaseServices.TextEditorSelectionbase.InsertTextType Enumeration](#autocad.databaseservices.texteditorselectionbase.inserttexttype-enumeration)

### Properties

- [Bold](#bold)
- [Color](#color)
- [FlowAlignment](#flowalignment)
- [Font](#font)
- [Height](#height)
- [Italic](#italic)
- [Language](#language)
- [MaxObliqueAngle](#maxobliqueangle)
- [MaxTrackingFactor](#maxtrackingfactor)
- [MaxWidthScale](#maxwidthscale)
- [MinObliqueAngle](#minobliqueangle)
- [MinTrackingFactor](#mintrackingfactor)
- [MinWidthScale](#minwidthscale)
- [ObliqueAngle](#obliqueangle)
- [Overline](#overline)
- [Strikethrough](#strikethrough)
- [TrackingFactor](#trackingfactor)
- [Underline](#underline)
- [WidthScale](#widthscale)


## Methods Details

### InputSpecialChar

#### Description
This wraps the ObjectARX [AcDbTextEditorSelectionBase::inputSpecialChar](AcDbTextEditorSelectionBase__inputSpecialChar@Adesk__UInt32.md)() method.
```text
public void InputSpecialChar(
    [MarshalAs(UnmanagedType.U2)] char ch
);
```

### InsertColumnBreak

#### Description
This wraps the ObjectARX [AcDbTextEditorSelectionBase::insertColumnBreak](AcDbTextEditorSelectionBase__insertColumnBreak.md)() method.
```text
public void InsertColumnBreak();
```

### InsertImportedText

#### Description
This wraps the ObjectARX AcDbTextEditorSelectionBase::insertImportedText() method.
```text
public void InsertImportedText(
    InsertTextType type, 
    byte\[\] data
);
```

### InsertString

#### Description
This wraps the ObjectARX [AcDbTextEditorSelectionBase::insertString](AcDbTextEditorSelectionBase__insertString@AcString_.md)() method.
```text
public void InsertString(
    string @string
);
```

### InsertSymbol

#### Description
This wraps the ObjectARX AcDbTextEditorSelectionBase::insertSymbol() method.
```text
public void InsertSymbol(
    [MarshalAs(UnmanagedType.U2)] char ch, 
    int langId
);
```

### AutoCAD.DatabaseServices.TextEditorSelectionbase.FlowAlign Enumeration

#### Description
This wraps the ObjectARX [AcDbTextEditorSelectionBase::FlowAlign](AcDbTextEditorSelectionBase__FlowAlign.md) enum.
```text
public enum FlowAlign {
  FlowBase,
  FlowCenter,
  FlowTop
}
```

### AutoCAD.DatabaseServices.TextEditorSelectionbase.InsertTextType Enumeration

#### Description
This wraps the ObjectARX [AcDbTextEditorSelectionBase::InsertTextType](AcDbTextEditorSelectionBase__InsertTextType.md) enum.
```text
public enum InsertTextType {
  UnicodeMTextFormat,
  MTextFormat,
  RichTextFormat,
  UnicodeDTextFormat,
  DTextFormat,
  UnicodeTextFormat,
  MultibyteTextFormat
}
```


## Properties Details

### Bold

#### Description
Gets and sets the bold property for the current selection or cursor. 
This wraps the ObjectARX [AcDbTextEditorSelectionBase::bold](AcDbTextEditorSelectionBase__bold@const.md)() and [AcDbTextEditorSelectionBase::toggleBold](AcDbTextEditorSelectionBase__toggleBold.md)() methods.
```text
public bool Bold;
```

### Color

#### Description
Gets and sets the color for the current selection or cursor. 
This wraps the ObjectARX[AcDbTextEditorSelectionBase::color](AcDbTextEditorSelectionBase__color@const.md)() and[AcDbTextEditorSelectionBase::setColor](AcDbTextEditorSelectionBase__setColor@AcCmColor_.md)() methods.
```text
public Autodesk.AutoCAD.Colors.Color Color;
```

### FlowAlignment

#### Description
Gets and sets the flow alignment for the current selection or cursor. 
This wraps the ObjectARX [AcDbTextEditorSelectionBase::flowAlign](AcDbTextEditorSelectionBase__flowAlign@const.md)() and [AcDbTextEditorSelectionBase::setFlowAlign](AcDbTextEditorSelectionBase__setFlowAlign@FlowAlign.md)() methods.
```text
public FlowAlign FlowAlignment;
```

### Font

#### Description
Gets and sSets the font for the current selection or cursor. 
This wraps the ObjectARX [AcDbTextEditorSelectionBase::font](AcDbTextEditorSelectionBase__font@const.md)() and [AcDbTextEditorSelectionBase::setFont](AcDbTextEditorSelectionBase__setFont@AcString_@bool.md)() methods.
```text
public Autodesk.AutoCAD.DatabaseServices.Font Font;
```

### Height

#### Description
Gets and sets the text height for the current selection or cursor. 
This wraps the ObjectARX [AcDbTextEditorSelectionBase::height](AcDbTextEditorSelectionBase__height@const.md)() and [AcDbTextEditorSelectionBase::setHeight](AcDbTextEditorSelectionBase__setHeight@double.md)() methods.
```text
public double Height;
```

### Italic

#### Description
Gets and sets the italic property for the current selection or cursor. 
This wraps the ObjectARX [AcDbTextEditorSelectionBase::italic](AcDbTextEditorSelectionBase__italic@const.md)() and [AcDbTextEditorSelectionBase::toggleItalic](AcDbTextEditorSelectionBase__toggleItalic.md)() methods.
```text
public bool Italic;
```

### Language

#### Description
Gets and sets the language for the current selection or cursor. 
This wraps the ObjectARX [AcDbTextEditorSelectionBase::language](AcDbTextEditorSelectionBase__language@const.md)() and AcDbTextEditorSelectionBase::setLanguage() methods.
```text
public int Language;
```

### MaxObliqueAngle

#### Description
This wraps the ObjectARX [AcDbTextEditorSelectionBase::maxObliqueAngle](AcDbTextEditorSelectionBase__maxObliqueAngle.md)() method.
```text
public static double MaxObliqueAngle;
```

### MaxTrackingFactor

#### Description
This wraps the ObjectARX [AcDbTextEditorSelectionBase::maxTrackingFactor](AcDbTextEditorSelectionBase__maxTrackingFactor.md)() method.
```text
public static double MaxTrackingFactor;
```

### MaxWidthScale

#### Description
This wraps the ObjectARX [AcDbTextEditorSelectionBase::maxWidthScale](AcDbTextEditorSelectionBase__maxWidthScale.md)() method.
```text
public static double MaxWidthScale;
```

### MinObliqueAngle

#### Description
This wraps the ObjectARX [AcDbTextEditorSelectionBase::minObliqueAngle](AcDbTextEditorSelectionBase__minObliqueAngle.md)() method.
```text
public static double MinObliqueAngle;
```

### MinTrackingFactor

#### Description
This wraps the ObjectARX [AcDbTextEditorSelectionBase::minTrackingFactor](AcDbTextEditorSelectionBase__minTrackingFactor.md)() method.
```text
public static double MinTrackingFactor;
```

### MinWidthScale

#### Description
This wraps the ObjectARX [AcDbTextEditorSelectionBase::minWidthScale](AcDbTextEditorSelectionBase__minWidthScale.md)() method.
```text
public static double MinWidthScale;
```

### ObliqueAngle

#### Description
Gets and sets the oblique angle for the current selection or cursor. 
This wraps the ObjectARX [AcDbTextEditorSelectionBase::obliqueAngle](AcDbTextEditorSelectionBase__obliqueAngle@const.md)() and [AcDbTextEditorSelectionBase::setObliqueAngle](AcDbTextEditorSelectionBase__setObliqueAngle@double.md)() methods.
```text
public double ObliqueAngle;
```

### Overline

#### Description
Gets and sets the overline property for the current selection or cursor. 
This wraps the ObjectARX [AcDbTextEditorSelectionBase::overline](AcDbTextEditorSelectionBase__overline@const.md)() and [AcDbTextEditorSelectionBase::toggleOverline](AcDbTextEditorSelectionBase__toggleOverline.md)() methods.
```text
public bool Overline;
```

### Strikethrough

#### Description
Get current strikethrough state.
```text
public bool Strikethrough;
```

#### Returns
Returns true if overline is on, else false.
#### Conditions
Read / Write
### TrackingFactor

#### Description
Gets and sets the tracking factor for the current selection or cursor. 
This wraps the ObjectARX [AcDbTextEditorSelectionBase::trackingFactor](AcDbTextEditorSelectionBase__trackingFactor@const.md)() and [AcDbTextEditorSelectionBase::setTrackingFactor](AcDbTextEditorSelectionBase__setTrackingFactor@double.md)() methods.
```text
public double TrackingFactor;
```

### Underline

#### Description
Gets and sets the underline property for the current selection or cursor. 
This wraps the ObjectARX [AcDbTextEditorSelectionBase::underline](AcDbTextEditorSelectionBase__underline@const.md)() and [AcDbTextEditorSelectionBase::toggleUnderline](AcDbTextEditorSelectionBase__toggleUnderline.md)() methods.
```text
public bool Underline;
```

### WidthScale

#### Description
Gets and sets the width scale factor for the current selection or cursor. 
This wraps the ObjectARX [AcDbTextEditorSelectionBase::widthScale](AcDbTextEditorSelectionBase__widthScale@const.md)() and [AcDbTextEditorSelectionBase::setWidthScale](AcDbTextEditorSelectionBase__setWidthScale@double.md)() methods.
```text
public double WidthScale;
```
