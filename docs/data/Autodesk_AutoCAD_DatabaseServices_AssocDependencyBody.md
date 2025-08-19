# AssocDependencyBody Class

## Overview

#### Description
Abstract base class for deriving custom dependency body classes that implement functionality of custom dependencies. 
An object of a class derived from the AssocDependencyBody class is always owned by a parent AssocDependency object. The AssocDependency object has an HardOwnershipId on it and the AssocDependencyBody.OwnerId() of the object returns the ObjectId of its parent AssocDependency object. 
Therefore a custom dependency object (in the logical sense of the word "object") is always represented by a pair of physical DBObjects:
  * The parent dependency object of the AssocDependency class (or possibly, but less commonly, of a derived class).
  * The dependency body object of a custom class derived from the AssocDependencyBody abstract base class.

This factoring out of the functionality of the custom dependencies into separate classes derived from the AssocDependencyBody class, instead of deriving the custom dependency classes directly from the AssocDependency class, allows better handling of the situations when the application code that implements the custom dependency behavior is not available. Only the custom object of the AssocDependencyBody-derived class will become a proxy, but its parent AssocDependency object will always be available and the associative mechanism can still function to some extent. 
The abstract AssocDependencyBody base class defines a set of virtual methods named xxxxxxOverride() that correspond to methods named xxxxxx() in the parent AssocDependency class. When a method xxxxxx() is called on the parent dependency object and the dependency object owns an dependency body object, the corresponding xxxxxxOverride() method on the dependency body object is called and it either supersedes or amends the default xxxxxx() implementation, depending on the particular method. 
If the dependency object does not own an dependency body object or if the dependency body object does not override the xxxxxxOverride() method, the default implementation in the parent dependency object is performed. Also, when the custom dependency body object becomes a proxy because its application code is not available, the parent dependency method just performs its default implementation. 
Custom dependency body classes derived from the AssocDependencyBody class implement their behavior by overriding the appropriate xxxxxxOverride() methods. Only the evaluateOverride() method must always be overridden in the custom classes. If not overridden, the other xxxxxxOverride() methods will do nothing and the default implementation in the parent AssocDependency object will be performed. This may be the appropriate behavior in most cases. 
Because each AssocDependencyBody object is owned by its parent AssocDependency object, erasing the parent AssocDependency object also erases the owned AssocDependencyBody object. There is no need to erase AssocDependencyBody objects explicitly.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocDependencyBody
        Autodesk.AutoCAD.DatabaseServices.AssocDimDependencyBodyBase
```

```text
public abstract class AssocDependencyBody : DBObject;
```

### Methods

- [ClonedOverride](#clonedoverride)
- [currentEvaluationCallback](#currentevaluationcallback)
- [DwgInFields](#dwginfields)
- [DwgOutFields](#dwgoutfields)
- [DxfInFields](#dxfinfields)
- [DxfOutFields](#dxfoutfields)
- [ErasedOverride](#erasedoverride)
- [EvaluateOverride](#evaluateoverride)
- [IsDependentOnTheSameThingAsOverride](#isdependentonthesamethingasoverride)
- [IsEqualToOverride](#isequaltooverride)
- [ModifiedOverride](#modifiedoverride)
- [SetStatus](#setstatus)
- [UpdateDependentOnObjectOverride](#updatedependentonobjectoverride)

### Properties

- [DependentOnObject](#dependentonobject)
- [HasCachedValueOverride](#hascachedvalueoverride)
- [IsActionEvaluationInProgress](#isactionevaluationinprogress)
- [IsAttachedToObject](#isattachedtoobject)
- [IsRelevantChangeOverride](#isrelevantchangeoverride)
- [OwningAction](#owningaction)
- [ParentDependency](#parentdependency)
- [Status](#status)


## Methods Details

### ClonedOverride

#### Description
Called from the copied() persistent reactor callback method of the parent AssocDependency class that owns this dependency body object. It does not need to be overridden.
```text
public virtual void ClonedOverride(
    DBObject dbObj, 
    DBObject newObj
);
```

### currentEvaluationCallback

#### Description
Just a shortcut, calls the method on the parent AcDbAssocDependency that owns this dependency body object.
```text
public AssocEvaluationCallback currentEvaluationCallback();
```

### DwgInFields

#### Description
The standard filing protocol.
```text
public virtual Autodesk.AutoCAD.Runtime.ErrorStatus DwgInFields(
    DwgFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgFiler filer | The filer to read the object data from. |

### DwgOutFields

#### Description
The standard filing protocol.
```text
public virtual Autodesk.AutoCAD.Runtime.ErrorStatus DwgOutFields(
    DwgFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgFiler filer | The filer to read the object data to. |

### DxfInFields

#### Description
The standard filing protocol.
```text
public virtual Autodesk.AutoCAD.Runtime.ErrorStatus DxfInFields(
    DxfFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DxfFiler filer | The filer to read the object data from. |

### DxfOutFields

#### Description
The standard filing protocol.
```text
public virtual Autodesk.AutoCAD.Runtime.ErrorStatus DxfOutFields(
    DxfFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DxfFiler filer | The filer to read the object data to. |

### ErasedOverride

#### Description
Called from the corresponding persistent reactor callback method of the parent AssocDependency class that owns this dependency body object. It does not need to be overridden.
```text
public virtual void ErasedOverride(
    DBObject dbObj, 
    [MarshalAs(UnmanagedType.U1)] bool IsErasing
);
```

### EvaluateOverride

#### Description
Called from the corresponding method of the parent AssocDependency class that owns this dependency body object. It has to be overridden.
```text
public abstract void EvaluateOverride();
```

### IsDependentOnTheSameThingAsOverride

#### Description
Called from the corresponding method of the parent AssocDependency class that owns this dependency body object. It does not need to be overridden.
```text
public virtual bool IsDependentOnTheSameThingAsOverride(
    AssocDependency otherDependency
);
```

### IsEqualToOverride

#### Description
Called from the corresponding method of the parent AssocDependency class that owns this dependency body object. It does not need to be overridden.
```text
public virtual bool IsEqualToOverride(
    AssocDependency otherDependency
);
```

### ModifiedOverride

#### Description
Called from the modified() persistent reactor callback method of the parent AssocDependency class that owns this dependency body object. It does not need to be overridden.
```text
public virtual void ModifiedOverride(
    DBObject dbObj
);
```

### SetStatus

#### Description
Just a shortcut, calls the method on the parent AssocDependency that owns this dependency body object.
```text
public void SetStatus(
    AssocStatus newStatus, 
    [MarshalAs(UnmanagedType.U1)] bool notifyOwningAction
);
```

### UpdateDependentOnObjectOverride

#### Description
Called from the corresponding method of the parent AssocDependency class that owns this dependency body object. It does not need to be overridden.
```text
public virtual void UpdateDependentOnObjectOverride();
```

### DependentOnObject

#### Description
Just a shortcut, calls the method on the parent AssocDependency that owns this dependency body object.
```text
public ObjectId DependentOnObject;
```

### HasCachedValueOverride

#### Description
Called from the corresponding method of the parent AssocDependency class that owns this dependency body object. It does not need to be overridden.
```text
public virtual bool HasCachedValueOverride;
```

### IsActionEvaluationInProgress

#### Description
Just a shortcut, calls the method on the parent AssocDependency that owns this dependency body object.
```text
public bool IsActionEvaluationInProgress;
```

### IsAttachedToObject

#### Description
Just a shortcut, calls the method on the parent AssocDependency that owns this dependency body object.
```text
public bool IsAttachedToObject;
```

### IsRelevantChangeOverride

#### Description
Called from the corresponding method of the parent AssocDependency class that owns this dependency body object. It does not need to be overridden.
```text
public virtual bool IsRelevantChangeOverride;
```

### OwningAction

#### Description
Just a shortcut, calls the method on the parent AssocDependency that owns this dependency body object.
```text
public ObjectId OwningAction;
```

### ParentDependency

#### Description
Returns ObjectId of the parent AssocDependency that owns this dependency body object.
```text
public ObjectId ParentDependency;
```

### Status

#### Description
Just a shortcut, calls the method on the parent AssocDependency that owns this dependency body object.
```text
public AssocStatus Status;
```
