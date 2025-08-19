# TextEditorParagraphTab Structure

## Overview

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraphTab](AcDbTextEditorParagraphTab.md) class.
```text
public struct TextEditorParagraphTab {
  public enum ParagraphTabType {
    LeftTab,
    CenterTab,
    RightTab,
    DecimalTab
  }
}
```

### Other

- [AutoCAD.DatabaseServices.TextEditorParagraphTab.ParagraphTabType Enumeration](#autocad.databaseservices.texteditorparagraphtab.paragraphtabtype-enumeration)

### Properties

- [DecimalChar](#decimalchar)
- [Offset](#offset)
- [Type](#type)


## Other Details

### AutoCAD.DatabaseServices.TextEditorParagraphTab.ParagraphTabType Enumeration

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraphTab::ParagraphTabType](AcDbTextEditorParagraphTab__ParagraphTabType.md) enum.
```text
public enum ParagraphTabType {
  LeftTab,
  CenterTab,
  RightTab,
  DecimalTab
}
```


## Properties Details

### DecimalChar

#### Description
Gets and sets the paragraph tab decimal char. 
This wraps the ObjectARX [AcDbTextEditorParagraphTab::decimalChar](AcDbTextEditorParagraphTab__decimalChar@const.md)() and AcDbTextEditorParagraphTab::setDecimalChar() methods.
```text
public char DecimalChar;
```

### Offset

#### Description
Gets and sets the paragraph tab off set value. 
This wraps the ObjectARX [AcDbTextEditorParagraphTab::offset](AcDbTextEditorParagraphTab__offset@const.md)() and [AcDbTextEditorParagraphTab::setOffset](AcDbTextEditorParagraphTab__setOffset@double.md)() methods.
```text
public double Offset;
```

### Type

#### Description
Gets and sets the tab type. 
This wraps the ObjectARX [AcDbTextEditorParagraphTab::type](AcDbTextEditorParagraphTab__type@const.md)() and [AcDbTextEditorParagraphTab::setType](AcDbTextEditorParagraphTab__setType@ParagraphTabType.md)() methods.
```text
public ParagraphTabType Type;
```
