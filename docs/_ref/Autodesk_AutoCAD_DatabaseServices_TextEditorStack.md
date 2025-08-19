# TextEditorStack Structure

## Overview

#### Description
This wraps the ObjectARX [AcDbTextEditorStack](AcDbTextEditorStack.md) class.
```text
public struct TextEditorStack {
  public enum StackType {
    HorizontalStack,
    DiagonalStack,
    ToleranceStack,
    DecimalStack
  }
}
```

### Other

- [AutoCAD.DatabaseServices.TextEditorStack.StackType Enumeration](#autocad.databaseservices.texteditorstack.stacktype-enumeration)

### Properties

- [Bottom](#bottom)
- [DecimalChar](#decimalchar)
- [FlowAlign](#flowalign)
- [MaxStackScale](#maxstackscale)
- [MinStackScale](#minstackscale)
- [Scale](#scale)
- [Top](#top)
- [Type](#type)


## Other Details

### AutoCAD.DatabaseServices.TextEditorStack.StackType Enumeration

#### Description
This wraps the ObjectARX [AcDbTextEditorStack::StackType](AcDbTextEditorStack__StackType.md) enum.
```text
public enum StackType {
  HorizontalStack,
  DiagonalStack,
  ToleranceStack,
  DecimalStack
}
```


## Properties Details

### Bottom

#### Description
Gets and sets the stack bottom string. 
This wraps the ObjectARX [AcDbTextEditorStack::bottom](AcDbTextEditorStack__bottom@const.md)() and [AcDbTextEditorStack::setBottom](AcDbTextEditorStack__setBottom@AcString_.md)() methods.
```text
public string Bottom;
```

### DecimalChar

#### Description
Gets and sets the stack decimal char. 
This wraps the ObjectARX [AcDbTextEditorStack::decimalChar](AcDbTextEditorStack__decimalChar@const.md)() and AcDbTextEditorStack::setDecimalChar() methods.
```text
public char DecimalChar;
```

### FlowAlign

#### Description
Gets and sets the stack flow alignment. 
This wraps the ObjectARX [AcDbTextEditorStack::alignType](AcDbTextEditorStack__alignType@const.md)() and [AcDbTextEditorStack::setAlignType](AcDbTextEditorStack__setAlignType@AcDbTextEditorSelectionBase__FlowAlign.md)() methods.
```text
public Autodesk.AutoCAD.DatabaseServices.TextEditorSelectionbase.FlowAlign FlowAlign;
```

### MaxStackScale

#### Description
This wraps the ObjectARX [AcDbTextEditorStack::maxStackScale](AcDbTextEditorStack__maxStackScale.md)() method.
```text
public static double MaxStackScale;
```

### MinStackScale

#### Description
This wraps the ObjectARX [AcDbTextEditorStack::minStackScale](AcDbTextEditorStack__minStackScale.md)() method.
```text
public static double MinStackScale;
```

### Scale

#### Description
Gets and sets the stack scale factor. 
This wraps the ObjectARX [AcDbTextEditorStack::scale](AcDbTextEditorStack__scale@const.md)() and [AcDbTextEditorStack::setScale](AcDbTextEditorStack__setScale@double.md)() methods.
```text
public double Scale;
```

### Top

#### Description
Gets and sets the stack top string. 
This wraps the ObjectARX [AcDbTextEditorStack::top](AcDbTextEditorStack__top@const.md)() and [AcDbTextEditorStack::setTop](AcDbTextEditorStack__setTop@AcString_.md)() methods.
```text
public string Top;
```

### Type

#### Description
Gets and sets the stack type. 
This wraps the ObjectARX [AcDbTextEditorStack::type](AcDbTextEditorStack__type@const.md)() and [AcDbTextEditorStack::setType](AcDbTextEditorStack__setType@StackType.md)() methods.
```text
public StackType Type;
```
