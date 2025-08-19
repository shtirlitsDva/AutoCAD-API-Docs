# AssocArrayPathParameters Class

## Overview

#### Description
AssocArrayPathParameters wraps the ObjectARX [AcDbAssocArrayPathParameters](AcDbAssocArrayPathParameters.md) class. 
This class provides and interface for manipulating path array parameters.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocArrayParameters
    Autodesk.AutoCAD.DatabaseServices.AssocArrayCommonParameters
        Autodesk.AutoCAD.DatabaseServices.AssocArrayPathParameters
```

```text
public class AssocArrayPathParameters : AssocArrayCommonParameters;
```

### Constructors

- [AssocArrayPathParameters()](#assocarraypathparameters())
- [AssocArrayPathParameters(double, double, double, int, int, int, double)](#assocarraypathparameters(double,-double,-double,-int,-int,-int,-double))

### Methods

- [GetEndOffset](#getendoffset)
- [GetItemCount](#getitemcount)
- [GetItemSpacing](#getitemspacing)
- [GetStartOffset](#getstartoffset)
- [SetEndOffset](#setendoffset)
- [SetItemCount](#setitemcount)
- [SetItemSpacing](#setitemspacing)
- [SetStartOffset](#setstartoffset)

### Other

- [AutoCAD.DatabaseServices.AssocArrayPathParameters.MethodType Enumeration](#autocad.databaseservices.assocarraypathparameters.methodtype-enumeration)

### Properties

- [AlignItems](#alignitems)
- [EndOffset](#endoffset)
- [ItemCount](#itemcount)
- [ItemSpacing](#itemspacing)
- [Method](#method)
- [Path](#path)
- [PathDirection](#pathdirection)
- [StartOffset](#startoffset)


## Constructors Details

### AssocArrayPathParameters()

#### Description
Default constructor. 
Wraps the default constructor ObjectARX [AcDbAssocArrayPathParameters](AcDbAssocArrayPathParameters__AcDbAssocArrayPathParameters@double@double@double@int@int@int@double.md) constructor, with all default values.
```text
public AssocArrayPathParameters();
protected internal AssocArrayPathParameters(
    IntPtr unmanagedPointer, 
    [MarshalAs(UnmanagedType.U1)] bool autoDelete
);
```

### AssocArrayPathParameters(double, double, double, int, int, int, double)

#### Description
Parameterized constructor.
```text
public AssocArrayPathParameters(
    double itemSpacing, 
    double rowSpacing, 
    double levelSpacing, 
    int itemCount, 
    int rowCount, 
    int levelCount, 
    double rowElevation
);
```

### GetEndOffset

#### Description
Wraps the ObjectARX the [ObjectARX AcDbAssocArrayPathParameters::endOffset](AcDbAssocArrayPathParameters__endOffset@AcString_@AcString_@const.md)() method.
```text
public double GetEndOffset(
    out string expression, 
    out string evaluatorId
);
```

### GetItemCount

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::itemCount](AcDbAssocArrayPathParameters__itemCount@AcString_@AcString_@const.md)() method.
```text
public int GetItemCount(
    out string expression, 
    out string evaluatorId
);
```

### GetItemSpacing

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::itemSpacing](AcDbAssocArrayPathParameters__itemSpacing@AcString_@AcString_@const.md)() method.
```text
public double GetItemSpacing(
    out string expression, 
    out string evaluatorId
);
```

### GetStartOffset

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::startOffset](AcDbAssocArrayPathParameters__startOffset@AcString_@AcString_@const.md)() method.
```text
public double GetStartOffset(
    out string expression, 
    out string evaluatorId
);
```

### SetEndOffset

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::setEndOffset](AcDbAssocArrayPathParameters__setEndOffset@double@AcString_@AcString_@AcString_.md)() method.
```text
public void SetEndOffset(
    double offset, 
    string expression, 
    string evaluatorId
);
```

### SetItemCount

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::setItemCount](AcDbAssocArrayPathParameters__setItemCount@int@AcString_@AcString_@AcString_.md)() method.
```text
public void SetItemCount(
    int count, 
    string expression, 
    string evaluatorId
);
```

### SetItemSpacing

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::setItemSpacing](AcDbAssocArrayPathParameters__setItemSpacing@double@AcString_@AcString_@AcString_.md)() method.
```text
public void SetItemSpacing(
    double spacing, 
    string expression, 
    string evaluatorId
);
```

### SetStartOffset

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::setStartOffset](AcDbAssocArrayPathParameters__setStartOffset@double@AcString_@AcString_@AcString_.md)() method.
```text
public void SetStartOffset(
    double offset, 
    string expression, 
    string evaluatorId
);
```

### AutoCAD.DatabaseServices.AssocArrayPathParameters.MethodType Enumeration

#### Description
The method of arraying items along the path.
```text
public enum MethodType {
  Divide,
  Measure
}
```

#### Members
| Members | Description |
| --- | --- |
| Divide | Divide method arranges given number of items on entire path equidistantly. |
| Measure | Mesure method arranges given number of items at specified item spacing along the path. |


## Properties Details

### AlignItems

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::alignItems](AcDbAssocArrayPathParameters__alignItems@const.md)() 
and [AcDbAssocArrayPathParameters::setAlignItems](AcDbAssocArrayPathParameters__setAlignItems@bool.md)() methods.
```text
public bool AlignItems;
```

#### Conditions
Read / write
### EndOffset

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::endOffset](AcDbAssocArrayPathParameters__endOffset@AcString_@AcString_@const.md)() and [AcDbAssocArrayPathParameters::setEndOffset](AcDbAssocArrayPathParameters__setEndOffset@double@AcString_@AcString_@AcString_.md)() methods.
```text
public double EndOffset;
```

#### Conditions
Read / write
### ItemCount

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::itemCount](AcDbAssocArrayPathParameters__itemCount@AcString_@AcString_@const.md)() and [AcDbAssocArrayPathParameters::setItemCount](AcDbAssocArrayPathParameters__setItemCount@int@AcString_@AcString_@AcString_.md)() methods.
```text
public int ItemCount;
```

#### Conditions
Read / write
### ItemSpacing

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::itemSpacing](AcDbAssocArrayPathParameters__itemSpacing@AcString_@AcString_@const.md)() and [AcDbAssocArrayPathParameters::setItemSpacing](AcDbAssocArrayPathParameters__setItemSpacing@double@AcString_@AcString_@AcString_.md)() methods.
```text
public double ItemSpacing;
```

#### Conditions
Read / write
### Method

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::method](AcDbAssocArrayPathParameters__method@const.md)() and [AcDbAssocArrayPathParameters::setMethod](AcDbAssocArrayPathParameters__setMethod@Method.md)() methods.
```text
public MethodType Method;
```

#### Conditions
Read / write
### Path

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::path](AcDbAssocArrayPathParameters__path@const.md)() and [AcDbAssocArrayPathParameters::setPath](AcDbAssocArrayPathParameters__setPath@AcDbEdgeRef_.md)() methods.
```text
public EdgeRef Path;
```

#### Conditions
Read / write
### PathDirection

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::setPathDirection](AcDbAssocArrayPathParameters__setPathDirection@bool.md)() method.
```text
public bool PathDirection;
```

#### Conditions
Read / write
### StartOffset

#### Description
Wraps the ObjectARX [AcDbAssocArrayPathParameters::startOffset](AcDbAssocArrayPathParameters__startOffset@AcString_@AcString_@const.md)() and [AcDbAssocArrayPathParameters::setStartOffset](AcDbAssocArrayPathParameters__setStartOffset@double@AcString_@AcString_@AcString_.md)() methods.
```text
public double StartOffset;
```

#### Conditions
Read / write