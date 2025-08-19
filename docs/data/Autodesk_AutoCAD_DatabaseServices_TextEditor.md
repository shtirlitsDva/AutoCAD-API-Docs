# TextEditor Class

## Overview

#### Description
This wraps the ObjectARX [AcDbTextEditor](AcDbTextEditor.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ITextEditorSelectable
    Autodesk.AutoCAD.DatabaseServices.TextEditor
```

```text
public class TextEditor : DisposableWrapper, ITextEditorSelectable;
```

### Methods

- [ClearSelection](#clearselection)
- [Close](#close)
- [CreateTextEditor](#createtexteditor)
- [FindTextW](#findtextw)
- [GetFont](#getfont)
- [MakeSelection](#makeselection)
- [Redraw](#redraw)
- [SelectAll](#selectall)

### Other

- [AutoCAD.DatabaseServices.TextEditor.ExitStatus Enumeration](#autocad.databaseservices.texteditor.exitstatus-enumeration)
- [AutoCAD.DatabaseServices.TextEditor.TextFindFlags Enumeration](#autocad.databaseservices.texteditor.textfindflags-enumeration)

### Properties

- [ActualHeight](#actualheight)
- [ActualWidth](#actualwidth)
- [Attachment](#attachment)
- [AutoCAPS](#autocaps)
- [AutoListEnabled](#autolistenabled)
- [Columns](#columns)
- [Cursor](#cursor)
- [DefaultStackAlignment](#defaultstackalignment)
- [DefaultStackScale](#defaultstackscale)
- [DefinedHeight](#definedheight)
- [DefinedWidth](#definedwidth)
- [EndOfText](#endoftext)
- [FontCount](#fontcount)
- [IsAnnotativeStyle](#isannotativestyle)
- [NumberingEnabled](#numberingenabled)
- [Paragraphs](#paragraphs)
- [Selection](#selection)
- [StackCount](#stackcount)
- [StartOfText](#startoftext)
- [Style](#style)
- [StyleCount](#stylecount)
- [TabOnlyDelimiter](#tabonlydelimiter)
- [TextHeight](#textheight)
- [VerticalSHX](#verticalshx)
- [VerticalTTF](#verticalttf)
- [Wipeout](#wipeout)


## Methods Details

### ClearSelection

#### Description
This wraps the ObjectARX [AcDbTextEditor::clearSelection](AcDbTextEditor__clearSelection.md)() method.
```text
public void ClearSelection();
```

### Close

#### Description
This wraps the ObjectARX [AcDbTextEditor::close](AcDbTextEditor__close@ExitStatus.md)() method.
```text
public void Close(
    ExitStatus stat
);
```

### CreateTextEditor

#### Description
This wraps the ObjectARX [AcDbTextEditor::createDbTextEditor](AcDbTextEditor__createDbTextEditor@AcDbMText_.md)() method.
```text
public static TextEditor CreateTextEditor(
    MText mtext
);
```

### FindTextW

#### Description
This wraps the ObjectARX [AcDbTextEditor::findText](AcDbTextEditor__findText@ACHAR_@int@AcDbTextEditorLocation__@AcDbTextEditorLocation__.md)() method.
```text
public void FindTextW(
    string findString, 
    TextFindFlags findFlags, 
    [In, Out] ref TextEditorLocation start, 
    [In, Out] ref TextEditorLocation end
);
```

### GetFont

#### Description
This wraps the ObjectARX [AcDbTextEditor::getFontName](AcDbTextEditor__getFontName@int@const.md)() and [AcDbTextEditor::isTrueTypeFont](AcDbTextEditor__isTrueTypeFont@int@const.md)() methods.
```text
public Font GetFont(
    int index
);
```

### MakeSelection

#### Description
This wraps the ObjectARX [AcDbTextEditor::makeSelection](AcDbTextEditor__makeSelection@AcDbTextEditorLocation_@AcDbTextEditorLocation_.md)() method.
```text
public void MakeSelection(
    TextEditorLocation start, 
    TextEditorLocation end
);
```

### Redraw

#### Description
This wraps the ObjectARX [AcDbTextEditor::redraw](AcDbTextEditor__redraw.md)() method.
```text
public void Redraw();
```

### SelectAll

#### Description
This wraps the ObjectARX [AcDbTextEditor::selectAll](AcDbTextEditor__selectAll.md)() method.
```text
public void SelectAll();
```

### AutoCAD.DatabaseServices.TextEditor.ExitStatus Enumeration

#### Description
This wraps the ObjectARX [AcDbTextEditor::ExitStatus](AcDbTextEditor__ExitStatus.md) enum.
```text
public enum ExitStatus {
  ExitQuit,
  ExitSave
}
```

### AutoCAD.DatabaseServices.TextEditor.TextFindFlags Enumeration

#### Description
This wraps ObjectARX [AcDbTextEditor::TextFindFlags](AcDbTextEditor__TextFindFlags.md) enum.
```text
public enum TextFindFlags {
  HalfFullForm = 4,
  IgnoreAccent = 8,
  MatchCase = 1,
  UseWildcards = 0x10,
  WholeWord = 2
}
```


## Properties Details

### ActualHeight

#### Description
This wraps the ObjectARX [AcDbTextEditor::actualHeight](AcDbTextEditor__actualHeight@const.md)() method.
```text
public double ActualHeight;
```

### ActualWidth

#### Description
This wraps the ObjectARX [AcDbTextEditor::actualWidth](AcDbTextEditor__actualWidth@const.md)() method.
```text
public double ActualWidth;
```

### Attachment

#### Description
Gets and sets the attachment point for the editor. 
This wraps the ObjectARX [AcDbTextEditor::attachment](AcDbTextEditor__attachment@const.md)() and [AcDbTextEditor::setAttachment](AcDbTextEditor__setAttachment@AcDbMText__AttachmentPoint.md)() methods.
```text
public Autodesk.AutoCAD.DatabaseServices.AttachmentPoint Attachment;
```

### AutoCAPS

#### Description
Gets and sets the auto CAPS flag. 
This wraps the ObjectARX [AcDbTextEditor::autoCAPS](AcDbTextEditor__autoCAPS.md)() and [AcDbTextEditor::setAutoCAPS](AcDbTextEditor__setAutoCAPS@bool.md)() methods.
```text
public bool AutoCAPS;
```

### AutoListEnabled

#### Description
This wraps the ObjectARX [AcDbTextEditor::autolistEnabled](AcDbTextEditor__autolistEnabled@const.md)() and [AcDbTextEditor::setAutolistEnabled](AcDbTextEditor__setAutolistEnabled@bool.md)() methods.
```text
public bool AutoListEnabled;
```

### Columns

#### Description
This wraps the ObjectARX [AcDbTextEditor::columns](AcDbTextEditor__columns.md)() method.
```text
public TextEditorColumns Columns;
```

### Cursor

#### Description
This wraps the ObjectARX [AcDbTextEditor::cursor](AcDbTextEditor__cursor.md)() method.
```text
public TextEditorCursor Cursor;
```

### DefaultStackAlignment

#### Description
Gets and sets the default stack alignment for selection object. 
This wraps the ObjectARX [AcDbTextEditor::defaultStackAlignment](AcDbTextEditor__defaultStackAlignment@const.md)() and[AcDbTextEditor::setDefaultStackAlignment](AcDbTextEditor__setDefaultStackAlignment@AcDbTextEditorSelectionBase__FlowAlign.md)() methods.
```text
public TextEditorSelectionbase.FlowAlign DefaultStackAlignment;
```

### DefaultStackScale

#### Description
Gets and sets the default stack scale factor for selection object. 
This wraps the ObjectARX [AcDbTextEditor::defaultStackScale](AcDbTextEditor__defaultStackScale@const.md)() and [AcDbTextEditor::setDefaultStackScale](AcDbTextEditor__setDefaultStackScale@double.md)() methods.
```text
public double DefaultStackScale;
```

### DefinedHeight

#### Description
Gets and sets the defined height for the editor. 
This wraps the ObjectARX [AcDbTextEditor::definedHeight](AcDbTextEditor__definedHeight@const.md)() and [AcDbTextEditor::setDefinedHeight](AcDbTextEditor__setDefinedHeight@double.md)() methods.
```text
public double DefinedHeight;
```

### DefinedWidth

#### Description
Gets and sets the defined width for the editor. 
This wraps the ObjectARX [AcDbTextEditor::definedWidth](AcDbTextEditor__definedWidth@const.md)() and [AcDbTextEditor::setDefinedWidth](AcDbTextEditor__setDefinedWidth@double.md)() methods.
```text
public double DefinedWidth;
```

### EndOfText

#### Description
This wraps the ObjectARX [AcDbTextEditor::endOfText](AcDbTextEditor__endOfText.md)() method.
```text
public virtual TextEditorLocation EndOfText;
```

### FontCount

#### Description
This wraps the ObjectARX [AcDbTextEditor::getFontCount](AcDbTextEditor__getFontCount@const.md)() method.
```text
public int FontCount;
```

### IsAnnotativeStyle

#### Description
Indicates whether the current text editor style is annotative.
```text
public bool IsAnnotativeStyle;
```

#### Conditions
Read-only
### NumberingEnabled

#### Description
Gets and sets the flag to enable all the paragraphs numbering. 
This wraps the ObjectARX [AcDbTextEditor::numberingEnabled](AcDbTextEditor__numberingEnabled@const.md)() and [AcDbTextEditor::setEnableNumbering](AcDbTextEditor__setEnableNumbering@bool.md)() methods.
```text
public bool NumberingEnabled;
```

### Paragraphs

#### Description
Gets the TextEditorParagraph array of TextEditor.
```text
public TextEditorParagraph Paragraphs;
```

#### Conditions
Read-only
### Selection

#### Description
This wraps the ObjectARX [AcDbTextEditor::selection](AcDbTextEditor__selection.md)() method.
```text
public TextEditorSelection Selection;
```

### StackCount

#### Description
This wraps the ObjectARX [AcDbTextEditor::stackCount](AcDbTextEditor__stackCount@const.md)() method.
```text
public int StackCount;
```

### StartOfText

#### Description
This wraps the ObjectARX [AcDbTextEditor::startOfText](AcDbTextEditor__startOfText.md)() method.
```text
public virtual TextEditorLocation StartOfText;
```

### Style

#### Description
Gets and sets the current text editor text style object Id.
```text
public ObjectId Style;
```

#### Conditions
Read / write
### StyleCount

#### Description
This wraps the ObjectARX [AcDbTextEditor::getStyleCount](AcDbTextEditor__getStyleCount@const.md)() method.
```text
public int StyleCount;
```

### TabOnlyDelimiter

#### Description
This wraps the ObjectARX [AcDbTextEditor::tabOnlyDelimiter](AcDbTextEditor__tabOnlyDelimiter@const.md)() and [AcDbTextEditor::setTabOnlyDelimiter](AcDbTextEditor__setTabOnlyDelimiter@bool.md)() methods.
```text
public bool TabOnlyDelimiter;
```

### TextHeight

#### Description
Gets and sets the text height for the editor. 
This wraps the ObjectARX [AcDbTextEditor::textHeight](AcDbTextEditor__textHeight@const.md)() and [AcDbTextEditor::setTextHeight](AcDbTextEditor__setTextHeight@double.md)() methods.
```text
public double TextHeight;
```

### VerticalSHX

#### Description
This wraps the ObjectARX [AcDbTextEditor::isVerticalSHX](AcDbTextEditor__isVerticalSHX@const.md)() method.
```text
public bool VerticalSHX;
```

### VerticalTTF

#### Description
This wraps the ObjectARX [AcDbTextEditor::isVerticalTTF](AcDbTextEditor__isVerticalTTF@const.md)() method.
```text
public bool VerticalTTF;
```

### Wipeout

#### Description
This wraps the ObjectARX [AcDbTextEditor::wipeout](AcDbTextEditor__wipeout.md)() method.
```text
public TextEditorWipeout Wipeout;
```
