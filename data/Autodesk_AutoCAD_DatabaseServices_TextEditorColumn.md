# TextEditorColumn Class

## Overview

#### Description
This wraps the ObjectARX [AcDbTextEditorColumn](AcDbTextEditorColumn.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ITextEditorSelectable
    Autodesk.AutoCAD.DatabaseServices.TextEditorColumn
```

```text
public class TextEditorColumn : DisposableWrapper, ITextEditorSelectable;
```

### Properties

- [EndOfText](#endoftext)
- [Height](#height)
- [StartOfText](#startoftext)


## Properties Details

### EndOfText

#### Description
This wraps the ObjectARX [AcDbTextEditorColumn::endOfText](AcDbTextEditorColumn__endOfText.md)() method.
```text
public virtual TextEditorLocation EndOfText;
```

### Height

#### Description
Gets and sets the height of the column object. 
This wraps the ObjectARX [AcDbTextEditorColumn::height](AcDbTextEditorColumn__height.md)() and [AcDbTextEditorColumn::setHeight](AcDbTextEditorColumn__setHeight@double.md)() methods.
```text
public double Height;
```

### StartOfText

#### Description
This wraps the ObjectARX [AcDbTextEditorColumn::startOfText](AcDbTextEditorColumn__startOfText.md)() method.
```text
public virtual TextEditorLocation StartOfText;
```
