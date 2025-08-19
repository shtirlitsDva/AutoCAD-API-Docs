# AssocActionParam Class

## Overview

#### Description
Abstract base class for all derived AcDbAssocXxxActionParam classes. Action parameters are owned by AcDbAssocParamBasedActionBody, either directly or via an AcDbAssocCompoundActionParam hierarchy. 
Action parameters provide a uniform and high-level way for custom action bodies derived from AcDbAsscoParamBasedActionBody to keep and access their data. Instead of each custom action body implementing its own code to keep its data and devise its own representation of the data, the action body can keep all of its data in the form of action parameters. The action body then does not need to take care of the data serialization and cloning, because it is performed automatically by the base AcDbAsscoParamBasedActionBody class. External code can inspect the action body data without knowing anything about the action body itself, because the data in the form of action parameters can be traversed and inspected in a general way. 
The concrete derived action parameter classes provide a general and high-level mechanism for keeping and accessing the application data, transparent to the client code. For example, when an action body needs to keep a reference to an edge subentity of an entity (such as to a line entity, segment of a polyline, edge of a solid or surface, or generally to anything that provides AcGeCurve3d geometry), it just creates an object of AcDbAssocEdgeActionParam class that takes care of keeping the data. Anytime the client code needs the current geometry of the edge subentity, it asks the AcDbAssocEdgeActionParam and it provides the geometry to the client code. The AcDbAssocEdgeActionParam takes care of keeping the data in various ways, such as by referencing an AcDbEntity in the database, by referencing an edge subentity of an AcDbEntity, or by directly keeping a constant AcGeCurve. The client code does not need to worry about how the data is kept. It just asks the AcDbAssocEdgeActionParam and obtains the current AcGeCurve3d* from it.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionParam
        Autodesk.AutoCAD.DatabaseServices.AssocAsmBodyActionParam
        Autodesk.AutoCAD.DatabaseServices.AssocCompoundActionParam
        Autodesk.AutoCAD.DatabaseServices.AssocEdgeActionParam
        Autodesk.AutoCAD.DatabaseServices.AssocFaceActionParam
        Autodesk.AutoCAD.DatabaseServices.AssocVertexActionParam
```

```text
public class AssocActionParam : DBObject;
```

### Constructors

- [AssocActionParam](#assocactionparam)

### Methods

- [DetachDependencies](#detachdependencies)
- [GetDependencies](#getdependencies)
- [MakeParamConstant](#makeparamconstant)
- [MakeParamEmpty](#makeparamempty)
- [TransformConstantGeometry](#transformconstantgeometry)

### Properties

- [Name](#name)
- [ParentAction](#parentaction)


## Constructors Details

### AssocActionParam

#### Description
This wraps the ObjectARX [AcDbAssocActionParam::AcDbAssocActionParam](AcDbAssocActionParam__AcDbAssocActionParam@AcDbAssocCreateImpObject.md)() method.
```text
public AssocActionParam();
```

### DetachDependencies

#### Description
This wraps the ObjectARX [AcDbAssocActionParam::detachDependencies](AcDbAssocActionParam__detachDependencies.md)() method.
```text
public void DetachDependencies();
```

### GetDependencies

#### Description
This wraps the ObjectARX [AcDbAssocActionParam::getDependencies](AcDbAssocActionParam__getDependencies@bool@bool@AcDbObjectIdArray_@const.md)() method.
```text
public ObjectIdCollection GetDependencies(
    [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted, 
    [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted
);
```

### MakeParamConstant

#### Description
This wraps the ObjectARX [AcDbAssocActionParam::makeParamConstant](AcDbAssocActionParam__makeParamConstant.md)() method.
```text
public void MakeParamConstant();
```

### MakeParamEmpty

#### Description
This wraps the ObjectARX [AcDbAssocActionParam::makeParamEmpty](AcDbAssocActionParam__makeParamEmpty@bool.md)(bool alsoEraseOwnedObjects) method.
```text
public void MakeParamEmpty(
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseOwnedObjects
);
```

### TransformConstantGeometry

#### Description
This wraps the ObjectARX [AcDbAssocActionParam::transformConstantGeometry](AcDbAssocActionParam__transformConstantGeometry@AcGeMatrix3d_.md)(const AcGeMatrix3d&amp;) method.
```text
public void TransformConstantGeometry(
    Matrix3d transform
);
```

### Name

#### Description
This wraps the ObjectARX [AcDbAssocActionParam::name](AcDbAssocActionParam__name@const.md)() and [AcDbAssocActionParam::setName](AcDbAssocActionParam__setName@AcString_.md)() methods.
```text
public string Name;
```

### ParentAction

#### Description
This wraps the ObjectARX [AcDbAssocActionParam::parentAction](AcDbAssocActionParam__parentAction@const.md)() method.
```text
public ObjectId ParentAction;
```
