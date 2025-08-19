# TextEditorParagraph Class

## Overview

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph](AcDbTextEditorParagraph.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ITextEditorSelectable
    Autodesk.AutoCAD.DatabaseServices.TextEditorParagraph
```

```text
public class TextEditorParagraph : DisposableWrapper, ITextEditorSelectable;
```

### Methods

- [AddTab](#addtab)
- [ContinueNumbering](#continuenumbering)
- [GetTab](#gettab)
- [RemoveTab](#removetab)
- [RestartNumbering](#restartnumbering)

### Other

- [AutoCAD.DatabaseServices.TextEditorParagraph.AlignmentType Enumeration](#autocad.databaseservices.texteditorparagraph.alignmenttype-enumeration)
- [AutoCAD.DatabaseServices.TextEditorParagraph.LineSpacingStyle Enumeration](#autocad.databaseservices.texteditorparagraph.linespacingstyle-enumeration)
- [AutoCAD.DatabaseServices.TextEditorParagraph.NumberingType Enumeration](#autocad.databaseservices.texteditorparagraph.numberingtype-enumeration)

### Properties

- [Alignment](#alignment)
- [EndOfText](#endoftext)
- [FirstIndent](#firstindent)
- [LeftIndent](#leftindent)
- [LineSpaceFactor](#linespacefactor)
- [LineSpaceStyle](#linespacestyle)
- [MaxLineSpacingFactor](#maxlinespacingfactor)
- [MaxSpacingValue](#maxspacingvalue)
- [MinLineSpacingFactor](#minlinespacingfactor)
- [MinSpacingValue](#minspacingvalue)
- [ParaNumberingType](#paranumberingtype)
- [RightIndent](#rightindent)
- [SpaceAfter](#spaceafter)
- [SpaceBefore](#spacebefore)
- [StartOfText](#startoftext)
- [TabsCount](#tabscount)


## Methods Details

### AddTab

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::addTab](AcDbTextEditorParagraph__addTab@AcDbTextEditorParagraphTab_.md)() method.
```text
public void AddTab(
    TextEditorParagraphTab tab
);
```

### ContinueNumbering

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::continueNumbering](AcDbTextEditorParagraph__continueNumbering.md)() method.
```text
public void ContinueNumbering();
```

### GetTab

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::getTab](AcDbTextEditorParagraph__getTab@int@AcDbTextEditorParagraphTab_.md)() method.
```text
public TextEditorParagraphTab GetTab(
    int idx
);
```

### RemoveTab

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::removeTab](AcDbTextEditorParagraph__removeTab@AcDbTextEditorParagraphTab_.md)() method.
```text
public void RemoveTab(
    TextEditorParagraphTab tab
);
```

### RestartNumbering

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::restartNumbering](AcDbTextEditorParagraph__restartNumbering.md)() method.
```text
public void RestartNumbering();
```

### AutoCAD.DatabaseServices.TextEditorParagraph.AlignmentType Enumeration

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::AlignmentType](AcDbTextEditorParagraph__AlignmentType.md) enum.
```text
public enum AlignmentType {
  AlignmentDefault,
  AlignmentLeft,
  AlignmentCenter,
  AlignmentRight,
  AlignmentJustify,
  AlignmentDistribute
}
```

### AutoCAD.DatabaseServices.TextEditorParagraph.LineSpacingStyle Enumeration

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::LineSpacingStyle](AcDbTextEditorParagraph__LineSpacingStyle.md) enum.
```text
public enum LineSpacingStyle {
  LineSpacingDefault,
  LineSpacingExactly,
  LineSpacingAtLeast,
  LineSpacingMultiple
}
```

### AutoCAD.DatabaseServices.TextEditorParagraph.NumberingType Enumeration

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::NumberingType](AcDbTextEditorParagraph__NumberingType.md) enum.
```text
public enum NumberingType {
  Off,
  Bullet,
  Number,
  LetterLower,
  LetterUpper,
  NumberWide,
  LetterLowerWide,
  LetterUpperWide
}
```


## Properties Details

### Alignment

#### Description
Gets and sets the alignment type for the paragraph. 
This wraps the ObjectARX [AcDbTextEditorParagraph::alignment](AcDbTextEditorParagraph__alignment@const.md)() and [AcDbTextEditorParagraph::setAlignment](AcDbTextEditorParagraph__setAlignment@AlignmentType.md)() methods.
```text
public AlignmentType Alignment;
```

### EndOfText

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::endOfText](AcDbTextEditorParagraph__endOfText.md)() method.
```text
public virtual TextEditorLocation EndOfText;
```

### FirstIndent

#### Description
Gets and sets the first indent value for the paragraph. 
This wraps the ObjectARX [AcDbTextEditorParagraph::firstIndent](AcDbTextEditorParagraph__firstIndent@const.md)() and [AcDbTextEditorParagraph::setFirstIndent](AcDbTextEditorParagraph__setFirstIndent@double.md)() methods.
```text
public double FirstIndent;
```

### LeftIndent

#### Description
Gets and sets the left indent value for the paragraph. 
This wraps the ObjectARX [AcDbTextEditorParagraph::leftIndent](AcDbTextEditorParagraph__leftIndent@const.md)() and [AcDbTextEditorParagraph::setLeftIndent](AcDbTextEditorParagraph__setLeftIndent@double.md)() methods.
```text
public double LeftIndent;
```

### LineSpaceFactor

#### Description
Gets and sets the line space factor for the paragraph. 
This wraps the ObjectARX [AcDbTextEditorParagraph::lineSpacingFactor](AcDbTextEditorParagraph__lineSpacingFactor@const.md)() and [AcDbTextEditorParagraph::setLineSpacingFactor](AcDbTextEditorParagraph__setLineSpacingFactor@double.md)() methods.
```text
public double LineSpaceFactor;
```

### LineSpaceStyle

#### Description
Gets and sets the line space style for the paragraph. 
This wraps the ObjectARX [AcDbTextEditorParagraph::lineSpacingStyle](AcDbTextEditorParagraph__lineSpacingStyle@const.md)() and [AcDbTextEditorParagraph::setLineSpacingStyle](AcDbTextEditorParagraph__setLineSpacingStyle@LineSpacingStyle.md)() methods.
```text
public LineSpacingStyle LineSpaceStyle;
```

### MaxLineSpacingFactor

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::maxLineSpacingFactor](AcDbTextEditorParagraph__maxLineSpacingFactor.md)() method.
```text
public double MaxLineSpacingFactor;
```

### MaxSpacingValue

#### Description
Maximum allowable after/before space value.
```text
public double MaxSpacingValue;
```

#### Returns
Returns maximum allowable after/before space value.
#### Conditions
Read only
### MinLineSpacingFactor

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::minLineSpacingFactor](AcDbTextEditorParagraph__minLineSpacingFactor.md)() method.
```text
public double MinLineSpacingFactor;
```

### MinSpacingValue

#### Description
Minimum allowable after/before space value.
```text
public double MinSpacingValue;
```

#### Returns
Returns minimum allowable after/before space value.
#### Conditions
Read only
### ParaNumberingType

#### Description
Gets and sets the numbering type for the paragraph. 
This wraps the ObjectARX [AcDbTextEditorParagraph::numberingType](AcDbTextEditorParagraph__numberingType@const.md)() and [AcDbTextEditorParagraph::setNumberingType](AcDbTextEditorParagraph__setNumberingType@NumberingType.md)() methods.
```text
public NumberingType ParaNumberingType;
```

### RightIndent

#### Description
Gets and sets the right indent value for the paragraph. 
This wraps the ObjectARX [AcDbTextEditorParagraph::rightIndent](AcDbTextEditorParagraph__rightIndent@const.md)() and [AcDbTextEditorParagraph::setRightIndent](AcDbTextEditorParagraph__setRightIndent@double.md)() methods.
```text
public double RightIndent;
```

### SpaceAfter

#### Description
Gets and sets the after space for the paragraph. 
This wraps the ObjectARX [AcDbTextEditorParagraph::spaceAfter](AcDbTextEditorParagraph__spaceAfter@const.md)() and [AcDbTextEditorParagraph::setSpaceAfter](AcDbTextEditorParagraph__setSpaceAfter@double.md)() methods.
```text
public double SpaceAfter;
```

### SpaceBefore

#### Description
Gets and sets the before space for the paragraph. 
This wraps the ObjectARX[AcDbTextEditorParagraph::spaceBefore](AcDbTextEditorParagraph__spaceBefore@const.md)() and [AcDbTextEditorParagraph::setSpaceBefore](AcDbTextEditorParagraph__setSpaceBefore@double.md)() methods.
```text
public double SpaceBefore;
```

### StartOfText

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::startOfText](AcDbTextEditorParagraph__startOfText.md)() method.
```text
public virtual TextEditorLocation StartOfText;
```

### TabsCount

#### Description
This wraps the ObjectARX [AcDbTextEditorParagraph::tabsCount](AcDbTextEditorParagraph__tabsCount@const.md)() method.
```text
public int TabsCount;
```
