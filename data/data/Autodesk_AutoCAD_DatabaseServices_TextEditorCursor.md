# TextEditorCursor Class

## Overview

#### Description
This wraps the ObjectARX [AcDbTextEditorCursor](AcDbTextEditorCursor.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.TextEditorSelectionbase
    Autodesk.AutoCAD.DatabaseServices.TextEditorCursor
```

```text
public class TextEditorCursor : TextEditorSelectionbase;
```

### Properties

- [Column](#column)
- [Location](#location)
- [Paragraph](#paragraph)


## Properties Details

### Column

#### Description
This wraps the ObjectARX [AcDbTextEditorCursor::column](AcDbTextEditorCursor__column.md)() method.
```text
public TextEditorColumn Column;
```

### Location

#### Description
Gets and sets the current cursor location. 
This wraps the ObjectARX [AcDbTextEditorCursor::location](AcDbTextEditorCursor__location@const.md)() and [AcDbTextEditorCursor::setLocation](AcDbTextEditorCursor__setLocation@AcDbTextEditorLocation_.md)() methods.
```text
public TextEditorLocation Location;
```

### Paragraph

#### Description
This wraps the ObjectARX [AcDbTextEditorCursor::paragraph](AcDbTextEditorCursor__paragraph.md)() method.
```text
public TextEditorParagraph Paragraph;
```
