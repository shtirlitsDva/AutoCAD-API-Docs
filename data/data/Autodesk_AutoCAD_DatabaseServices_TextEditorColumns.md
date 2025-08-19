# TextEditorColumns Class

## Overview

#### Description
This wraps the ObjectARX [AcDbTextEditorColumns](AcDbTextEditorColumns.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.TextEditorColumns
```

```text
public class TextEditorColumns : DisposableWrapper;
```

### Properties

- [AutoHeight](#autoheight)
- [Count](#count)
- [Gutter](#gutter)
- [IsFlowReversed](#isflowreversed)
- [MaxCount](#maxcount)
- [TotalWidth](#totalwidth)
- [Type](#type)
- [Width](#width)


## Properties Details

### AutoHeight

#### Description
Gets and sets the flag of auto height for all the column objects. 
This wraps the ObjectARX [AcDbTextEditorColumns::autoHeight](AcDbTextEditorColumns__autoHeight@const.md)() and [AcDbTextEditorColumns::setAutoHeight](AcDbTextEditorColumns__setAutoHeight@bool.md)() methods.
```text
public bool AutoHeight;
```

### Count

#### Description
Gets and sets the count of the column objects in text editor. 
This wraps the ObjectARX [AcDbTextEditorColumns::count](AcDbTextEditorColumns__count@const.md)() and [AcDbTextEditorColumns::setCount](AcDbTextEditorColumns__setCount@int.md)() methods.
```text
public virtual int Count;
```

### Gutter

#### Description
Gets and sets the gutter value of the column object in editor. This wraps the ObjectARX [AcDbTextEditorColumns::gutter](AcDbTextEditorColumns__gutter@const.md)() and [AcDbTextEditorColumns::setGutter](AcDbTextEditorColumns__setGutter@double.md)() methods.
```text
public double Gutter;
```

### IsFlowReversed

#### Description
Gets and sets if the flows of all the column objects in editor are reversed. 
This wraps the ObjectARX [AcDbTextEditorColumns::isFlowReversed](AcDbTextEditorColumns__isFlowReversed@const.md)() and [AcDbTextEditorColumns::setIsFlowReversed](AcDbTextEditorColumns__setIsFlowReversed@bool.md)() methods.
```text
public bool IsFlowReversed;
```

### MaxCount

#### Description
This wraps the ObjectARX [AcDbTextEditorColumns::maxCount](AcDbTextEditorColumns__maxCount.md)() method.
```text
public int MaxCount;
```

### TotalWidth

#### Description
Gets and sets the total width for all the column objects in editor. 
This wraps the ObjectARX [AcDbTextEditorColumns::totalWidth](AcDbTextEditorColumns__totalWidth@const.md)() and [AcDbTextEditorColumns::setTotalWidth](AcDbTextEditorColumns__setTotalWidth@double.md)() methods.
```text
public double TotalWidth;
```

### Type

#### Description
Gets and sets the type for the column object. 
This wraps the ObjectARX [AcDbTextEditorColumns::columnType](AcDbTextEditorColumns__columnType@const.md)() and [AcDbTextEditorColumns::setColumnType](AcDbTextEditorColumns__setColumnType@AcDbMText__ColumnType.md)() methods.
```text
public Autodesk.AutoCAD.DatabaseServices.ColumnType Type;
```

### Width

#### Description
Gets and sets the width of the column object in editor. 
This wraps the ObjectARX [AcDbTextEditorColumns::width](AcDbTextEditorColumns__width@const.md)() and [AcDbTextEditorColumns::setWidth](AcDbTextEditorColumns__setWidth@double.md)() methods.
```text
public double Width;
```
