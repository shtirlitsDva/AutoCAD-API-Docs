# TextEditorSelection Class

## Overview

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection](AcDbTextEditorSelection.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.TextEditorSelectionbase
    Autodesk.AutoCAD.DatabaseServices.TextEditorSelection
```

```text
public class TextEditorSelection : TextEditorSelectionbase;
```

### Methods

- [CanSupportFont](#cansupportfont)
- [CanSupportLanguage](#cansupportlanguage)
- [ChangeToLowercase](#changetolowercase)
- [ChangeToUppercase](#changetouppercase)
- [CombineParagraphs](#combineparagraphs)
- [ConvertToPlainText](#converttoplaintext)
- [RemoveAllFormatting](#removeallformatting)
- [RemoveCharacterFormatting](#removecharacterformatting)
- [RemoveParagraphFormatting](#removeparagraphformatting)
- [Stack](#stack)
- [UnStack](#unstack)
- [UpdateField](#updatefield)

### Properties

- [CanChangeCase](#canchangecase)
- [CanStack](#canstack)
- [CanUnStack](#canunstack)
- [FieldObject](#fieldobject)
- [Paragraphs](#paragraphs)
- [SelectionString](#selectionstring)
- [SingleFieldSelected](#singlefieldselected)
- [SingleStackSelected](#singlestackselected)
- [StackSettings](#stacksettings)


## Methods Details

### CanSupportFont

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::fontSupported](AcDbTextEditorSelection__fontSupported@AcString_@bool@const.md)() method.
```text
public bool CanSupportFont(
    Font font
);
```

### CanSupportLanguage

#### Description
This wraps the ObjectARX AcDbTextEditorSelection::languageSupported() method.
```text
public bool CanSupportLanguage(
    int charset
);
```

### ChangeToLowercase

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::changeToLowercase](AcDbTextEditorSelection__changeToLowercase.md)() method.
```text
public bool ChangeToLowercase();
```

### ChangeToUppercase

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::changeToUppercase](AcDbTextEditorSelection__changeToUppercase.md)() method.
```text
public bool ChangeToUppercase();
```

### CombineParagraphs

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::combineParagraphs](AcDbTextEditorSelection__combineParagraphs.md)() method.
```text
public void CombineParagraphs();
```

### ConvertToPlainText

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::convertToPlainText](AcDbTextEditorSelection__convertToPlainText.md)() method.
```text
public void ConvertToPlainText();
```

### RemoveAllFormatting

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::removeAllFormatting(](AcDbTextEditorSelection__removeAllFormatting.md)) method.
```text
public void RemoveAllFormatting();
```

### RemoveCharacterFormatting

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::removeCharacterFormatting](AcDbTextEditorSelection__removeCharacterFormatting.md)() method.
```text
public void RemoveCharacterFormatting();
```

### RemoveParagraphFormatting

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::removeParagraphFormatting](AcDbTextEditorSelection__removeParagraphFormatting.md)() method.
```text
public void RemoveParagraphFormatting();
```

### Stack

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::stack](AcDbTextEditorSelection__stack.md)() method.
```text
public void Stack();
```

### UnStack

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::unStack](AcDbTextEditorSelection__unStack.md)() method.
```text
public void UnStack();
```

### UpdateField

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::updateField](AcDbTextEditorSelection__updateField.md)() method.
```text
public void UpdateField();
```

### CanChangeCase

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::canChangeCase](AcDbTextEditorSelection__canChangeCase@const.md)() method.
```text
public bool CanChangeCase;
```

### CanStack

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::canStack](AcDbTextEditorSelection__canStack@const.md)() method.
```text
public bool CanStack;
```

### CanUnStack

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::canUnStack](AcDbTextEditorSelection__canUnStack@const.md)() method.
```text
public bool CanUnStack;
```

### FieldObject

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::field](AcDbTextEditorSelection__field@const.md)() method.
```text
public Field FieldObject;
```

### Paragraphs

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::paragraph](AcDbTextEditorSelection__paragraph@AcArray_AcDbTextEditorParagraph___.md)() method.
```text
public TextEditorParagraph Paragraphs;
```

### SelectionString

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::getSelectionText](AcDbTextEditorSelection__getSelectionText@AcString_@const.md)() method.
```text
public string SelectionString;
```

### SingleFieldSelected

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::singleFieldSelected](AcDbTextEditorSelection__singleFieldSelected@const.md)() method.
```text
public bool SingleFieldSelected;
```

### SingleStackSelected

#### Description
This wraps the ObjectARX [AcDbTextEditorSelection::singleStackSelected](AcDbTextEditorSelection__singleStackSelected@const.md)() method.
```text
public bool SingleStackSelected;
```

### StackSettings

#### Description
Gets and sets the selected stack object. 
This wraps the ObjectARX [AcDbTextEditorSelection::getStack](AcDbTextEditorSelection__getStack@AcDbTextEditorStack_@const.md)() and [AcDbTextEditorSelection::setStack](AcDbTextEditorSelection__setStack@AcDbTextEditorStack_.md)() methods. 
After you get the StackSettings from current selection and change the properties, you should save the StackSettings back to selection. Otherwise there is no effect for your changes.
```text
public TextEditorStack StackSettings;
```
