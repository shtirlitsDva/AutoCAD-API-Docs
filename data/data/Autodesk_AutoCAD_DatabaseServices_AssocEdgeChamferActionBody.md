# AssocEdgeChamferActionBody Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocEdgeChamferActionBody](AcDbAssocEdgeChamferActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocEdgeChamferActionBody
```

```text
public class AssocEdgeChamferActionBody : AssocPathBasedSurfaceActionBody;
```

### Constructors

- [AssocEdgeChamferActionBody](#assocedgechamferactionbody)

### Methods

- [CreateInstance](#createinstance)
- [GetBaseDistance](#getbasedistance)
- [GetOtherDistance](#getotherdistance)
- [SetBaseDistance](#setbasedistance)
- [SetOtherDistance](#setotherdistance)

### Properties

- [BaseDistance](#basedistance)
- [OtherDistance](#otherdistance)


## Constructors Details

### AssocEdgeChamferActionBody

#### Description
This wraps the ObjectARX [AcDbAssocEdgeChamferActionBody::AcDbAssocEdgeChamferActionBody](AcDbAssocEdgeChamferActionBody__AcDbAssocEdgeChamferActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocEdgeChamferActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX [AcDbAssocEdgeChamferActionBody::createInstance](AcDbAssocEdgeChamferActionBody__createInstance@AcDbFullSubentPathArray_@AcDbSubentId_@double@double@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    FullSubentityPath\[\] chamferEdges, 
    SubentityId modopt(IsConst) baseFace, 
    double baseDistance, 
    double otherDistance, 
    [MarshalAs(UnmanagedType.U1)] bool enable
);
```

### GetBaseDistance

#### Description
This wraps the ObjectARX [AcDbAssocEdgeChamferActionBody::baseDistance](AcDbAssocEdgeChamferActionBody__baseDistance@AcString_@AcString_@const.md)() method.
```text
public double GetBaseDistance(
    out string expression, 
    out string evaluatorId
);
```

### GetOtherDistance

#### Description
This wraps the ObjectARX [AcDbAssocEdgeChamferActionBody::otherDistance](AcDbAssocEdgeChamferActionBody__otherDistance@AcString_@AcString_@const.md)() method.
```text
public double GetOtherDistance(
    out string expression, 
    out string evaluatorId
);
```

### SetBaseDistance

#### Description
This wraps the ObjectARX [AcDbAssocEdgeChamferActionBody::setBaseDistance](AcDbAssocEdgeChamferActionBody__setBaseDistance@double@AcString_@AcString_.md)() method.
```text
public void SetBaseDistance(
    double distance, 
    string expression, 
    string evaluatorId
);
```

### SetOtherDistance

#### Description
This wraps the ObjectARX [AcDbAssocEdgeChamferActionBody::setOtherDistance](AcDbAssocEdgeChamferActionBody__setOtherDistance@double@AcString_@AcString_.md)() method.
```text
public void SetOtherDistance(
    double distance, 
    string expression, 
    string evaluatorId
);
```

### BaseDistance

#### Description
This wraps the ObjectARX [AcDbAssocEdgeChamferActionBody::baseDistance](AcDbAssocEdgeChamferActionBody__baseDistance@AcString_@AcString_@const.md)() and [AcDbAssocEdgeChamferActionBody::setBaseDistance](AcDbAssocEdgeChamferActionBody__setBaseDistance@double@AcString_@AcString_.md)() methods.
```text
public double BaseDistance;
```

### OtherDistance

#### Description
This wraps the ObjectARX [AcDbAssocEdgeChamferActionBody::otherDistance](AcDbAssocEdgeChamferActionBody__otherDistance@AcString_@AcString_@const.md) and [AcDbAssocEdgeChamferActionBody::setOtherDistance](AcDbAssocEdgeChamferActionBody__setOtherDistance@double@AcString_@AcString_.md)() methods.
```text
public double OtherDistance;
```
