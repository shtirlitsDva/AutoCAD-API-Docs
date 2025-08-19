# AssocActionBody Class

## Overview

#### Description
Abstract base class for deriving custom action body classes that implement functionality of custom actions. 
An object of a class derived from the AssocActionBody class is always owned by a parent AssocAction object. The AssocAction object has an HardOwnershipId on it and the AssocActionBody.OwnerId() of the object returns the ObjectId of its parent AssocAction object. 
Therefore a custom action object (in the logical sense of the word "object") is always represented by a pair of physical Objects:
  * The parent action object of the AssocAction class (or possibly, but less commonly, of a derived class).
  * The action body object of a custom class derived from the AssocActionBody abstract base class.

This factoring out of the functionality of the custom actions into separate classes derived from the AssocActionBody class, instead of deriving the custom action classes directly from the AssocAction class, allows better handling of the situations when the application code that implements the custom action behavior is not available. Only the custom object of the AssocActionBody-derived class will become a proxy, but its parent AssocAction object will always be available and the associative mechanism can still function to some extent. 
The abstract AssocActionBody base class defines a set of virtual methods named xxxxxxOverride() that correspond to methods named xxxxxx() in the parent AssocAction class. When a method xxxxxx() is called on the parent action object and the action object owns an action body object, the corresponding xxxxxxOverride() method on the action body object is called and it either supersedes or amends the default xxxxxx() implementation, depending on the particular method. 
If the action object does not own an action body object or if the action body object does not override the xxxxxxOverride() method, the default implementation in the parent action object is performed. Also, when the custom action body object becomes a proxy because its application code is not available, the parent action method just performs its default implementation. 
Custom action body classes derived from the AssocActionBody class implement their behavior by overriding the appropriate xxxxxxOverride() methods. Only the evaluateOverride() method must always be overridden in the custom classes. If not overridden, the other xxxxxxOverride() methods will do nothing and the default implementation in the parent AssocAction object will be performed. This may be the appropriate behavior in most cases. 
The custom action body classes also need to serialize their data. When serializing ObjectIds of the AssocDependencies, these should be serialized as HardPointerIds, not as HardOwnershipIds, because the AssocDependencies are owned (in the AutoCAD database sense) by the parent AssocAction object, not by the custom action body object. 
Because each AssocActionBody object is owned by its parent AssocAction object, erasing the parent AssocAction object also erases the owned AssocActionBody object. There is no need to erase AssocActionBody objects explicitly.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
```

```text
public abstract class AssocActionBody : DBObject;
```

### Constructors

- [ValueParam.ValueParam](#valueparam.valueparam)

### Methods

- [AddDependency](#adddependency)
- [AddMoreObjectsToDeepCloneOverride](#addmoreobjectstodeepcloneoverride)
- [AddParam](#addparam)
- [AreDependenciesEqualOverride](#aredependenciesequaloverride)
- [AreDependenciesOnTheSameThingOverride](#aredependenciesonthesamethingoverride)
- [CreateActionAndActionBodyAndPostToDatabase](#createactionandactionbodyandposttodatabase)
- [currentEvaluationCallback](#currentevaluationcallback)
- [DependentObjectClonedOverride](#dependentobjectclonedoverride)
- [DragStatusOverride](#dragstatusoverride)
- [DwgInFields](#dwginfields)
- [DwgOutFields](#dwgoutfields)
- [DxfInFields](#dxfinfields)
- [DxfOutFields](#dxfoutfields)
- [EvaluateDependencies](#evaluatedependencies)
- [EvaluateDependencyOverride](#evaluatedependencyoverride)
- [EvaluateOverride](#evaluateoverride)
- [EvaluationPriorityOverride](#evaluationpriorityoverride)
- [GetActionBodiesOnObject](#getactionbodiesonobject)
- [GetDependencies](#getdependencies)
- [GetDependenciesOverride](#getdependenciesoverride)
- [GetDependentActionsToEvaluateOverride](#getdependentactionstoevaluateoverride)
- [GetDependentObjectsOverride](#getdependentobjectsoverride)
- [GetParentAction](#getparentaction)
- [GetValueParam(string)](#getvalueparam(string))
- [GetValueParam(string, int)](#getvalueparam(string,-int))
- [GetValueParamArray](#getvalueparamarray)
- [GetValueParamUnitType](#getvalueparamunittype)
- [HasAnyErasedOrBrokenDependencies](#hasanyerasedorbrokendependencies)
- [HasDependencyCachedValueOverride](#hasdependencycachedvalueoverride)
- [IsActionEvaluationInProgress](#isactionevaluationinprogress)
- [IsEqualToOverride](#isequaltooverride)
- [IsExternalDependencyOverride](#isexternaldependencyoverride)
- [IsOwnedDependencyOverride](#isowneddependencyoverride)
- [IsRelevantDependencyChangeOverride](#isrelevantdependencychangeoverride)
- [OwnedDependencyStatusChangedOverride](#owneddependencystatuschangedoverride)
- [OwnedValueParamNames](#ownedvalueparamnames)
- [ParamAtIndex](#paramatindex)
- [ParamAtName(string)](#paramatname(string))
- [ParamAtName(string, int)](#paramatname(string,-int))
- [ParamsAtName](#paramsatname)
- [PostProcessAfterDeepCloneCancelOverride](#postprocessafterdeepclonecanceloverride)
- [PostProcessAfterDeepCloneOverride](#postprocessafterdeepcloneoverride)
- [RemoveAllDependencies](#removealldependencies)
- [RemoveAllDependenciesOverride](#removealldependenciesoverride)
- [RemoveAllParams](#removeallparams)
- [RemoveDependency](#removedependency)
- [RemoveParam](#removeparam)
- [RemoveValueParam](#removevalueparam)
- [SetStatus](#setstatus)
- [SetValueParam(string, ValueParam, [MarshalAs(UnmanagedType.U1)] bool)](#setvalueparam(string,-valueparam,-[marshalas(unmanagedtype.u1)]-bool))
- [SetValueParam(string, ValueParam, [MarshalAs(UnmanagedType.U1)] bool, int)](#setvalueparam(string,-valueparam,-[marshalas(unmanagedtype.u1)]-bool,-int))
- [SetValueParamArray](#setvalueparamarray)
- [SetValueParamUnitType](#setvalueparamunittype)
- [TransformActionByOverride](#transformactionbyoverride)
- [ValueParamInputVariables](#valueparaminputvariables)

### Other

- [ValueParam Structure](#valueparam-structure)

### Properties

- [OwnedParams](#ownedparams)
- [OwningNetwork](#owningnetwork)
- [ParamCount](#paramcount)
- [ParentAction](#parentaction)
- [Status](#status)
- [ValueParam.EvaluatorId](#valueparam.evaluatorid)
- [ValueParam.Expression](#valueparam.expression)
- [ValueParam.Value](#valueparam.value)


## Constructors Details

### ValueParam.ValueParam

#### Description
Constructor.
```text
public ValueParam(
    string expression, 
    string evaluatorId, 
    ResultBuffer value
);
```

### AddDependency

#### Description
Just a shortcut, calls the method on the parent AssocAction that owns this action body object.
```text
public void AddDependency(
    ObjectId dependencyId, 
    [MarshalAs(UnmanagedType.U1)] bool setThisActionAsOwningAction
);
```

### AddMoreObjectsToDeepCloneOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual void AddMoreObjectsToDeepCloneOverride(
    IdMapping idMap, 
    ObjectIdCollection additionalObjectsToClone
);
```

### AddParam

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::addParam () method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public void AddParam(
    ObjectId paramId, 
    ref int paramIndex
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### AreDependenciesEqualOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual bool AreDependenciesEqualOverride(
    AssocDependency dependency1, 
    AssocDependency dependency2
);
```

### AreDependenciesOnTheSameThingOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual bool AreDependenciesOnTheSameThingOverride(
    AssocDependency dependency1, 
    AssocDependency dependency2
);
```

### CreateActionAndActionBodyAndPostToDatabase

#### Description
This wraps the ObjectARX [AcDbAssocActionBody::createActionAndActionBodyAndPostToDatabase](AcDbAssocActionBody__createActionAndActionBodyAndPostToDatabase@AcRxClass_@AcDbObjectId_@AcDbObjectId_@AcDbObjectId_.md)() method.
```text
public static void CreateActionAndActionBodyAndPostToDatabase(
    RXClass pActionBodyClass, 
    ObjectId objectId, 
    ObjectId createdActionId, 
    ObjectId createdActionBodyId
);
```

### currentEvaluationCallback

#### Description
Just a shortcut, calls the method on the parent AssocAction that owns this action body object.
```text
public AssocEvaluationCallback currentEvaluationCallback();
```

### DependentObjectClonedOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual void DependentObjectClonedOverride(
    AssocDependency pDependency, 
    DBObject dbObj, 
    DBObject dbNewObj
);
```

### DragStatusOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual void DragStatusOverride(
    DragStatus status
);
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

### EvaluateDependencies

#### Description
Just a shortcut, calls the method on the parent AssocAction that owns this action body object.
```text
public void EvaluateDependencies();
```

### EvaluateDependencyOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual bool EvaluateDependencyOverride(
    AssocDependency dependency
);
```

### EvaluateOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. This method has to be overridden and this is how the behavior of custom actions is implemented.
```text
public abstract void EvaluateOverride();
```

### EvaluationPriorityOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual void EvaluationPriorityOverride(
    ref AssocEvaluationPriority priority
);
```

### GetActionBodiesOnObject

#### Description
This wraps the ObjectARX [AcDbAssocActionBody::getActionBodiesOnObject](AcDbAssocActionBody__getActionBodiesOnObject@AcDbObject_@bool@bool@AcDbObjectId_@AcDbObjectIdArray_@AcDbObjectIdArray_.md)() method.
```text
public static void GetActionBodiesOnObject(
    DBObject pObject, 
    [MarshalAs(UnmanagedType.U1)] bool ignoreInternalActions, 
    [MarshalAs(UnmanagedType.U1)] bool ignoreSuppressedActions, 
    out ObjectId creationActionBodyId, 
    out ObjectIdCollection modificationActionBodyIds, 
    out ObjectIdCollection readOnlyActionBodyIds
);
```

### GetDependencies

#### Description
Just a shortcut, calls the method on the parent AssocAction that owns this action body object.
```text
public ObjectIdCollection GetDependencies(
    [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted, 
    [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted
);
```

### GetDependenciesOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public ObjectIdCollection GetDependenciesOverride(
    [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted, 
    [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted
);
```

### GetDependentActionsToEvaluateOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual void GetDependentActionsToEvaluateOverride(
    ActionsToEvaluateCallback actionsToEvaluateCallback
);
```

### GetDependentObjectsOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public ObjectIdCollection GetDependentObjectsOverride(
    [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted, 
    [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted
);
```

### GetParentAction

#### Description
This wraps the ObjectARX [AcDbAssocActionBody::parentAction](AcDbAssocActionBody__parentAction@const.md)() method.
```text
public static ObjectId GetParentAction(
    ObjectId actionBodyId
);
```

### GetValueParam(string)

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::getValueParam() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public ValueParam GetValueParam(
    string paramName
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### GetValueParam(string, int)

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::getValueParam() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public ValueParam GetValueParam(
    string paramName, 
    int paramIndex
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### GetValueParamArray

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::getValueParamArray() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public ValueParam\[\] GetValueParamArray(
    string paramName
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### GetValueParamUnitType

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::valueParamUnitType() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public Autodesk.AutoCAD.DatabaseServices.UnitType GetValueParamUnitType(
    string paramName
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### HasAnyErasedOrBrokenDependencies

#### Description
This wraps the ObjectARX [AcDbAssocActionBody::hasAnyErasedOrBrokenDependencies](AcDbAssocActionBody__hasAnyErasedOrBrokenDependencies@const.md)() method.
```text
public bool HasAnyErasedOrBrokenDependencies();
```

### HasDependencyCachedValueOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual bool HasDependencyCachedValueOverride(
    AssocDependency dependency
);
```

### IsActionEvaluationInProgress

#### Description
Just a shortcut, calls the method on the parent AssocAction that owns this action body object.
```text
public bool IsActionEvaluationInProgress();
```

### IsEqualToOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual bool IsEqualToOverride(
    AssocAction otherAction
);
```

### IsExternalDependencyOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual bool IsExternalDependencyOverride(
    AssocDependency dependency
);
```

### IsOwnedDependencyOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual bool IsOwnedDependencyOverride(
    AssocDependency dependency
);
```

### IsRelevantDependencyChangeOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual bool IsRelevantDependencyChangeOverride(
    AssocDependency dependency
);
```

### OwnedDependencyStatusChangedOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual void OwnedDependencyStatusChangedOverride(
    AssocDependency ownedDependency, 
    AssocStatus previousStatus
);
```

### OwnedValueParamNames

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::ownedValueParamNames() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public string\[\] OwnedValueParamNames();
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### ParamAtIndex

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::paramAtIndex() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public ObjectId ParamAtIndex(
    int paramIndex
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### ParamAtName(string)

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::paramAtName () method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public ObjectId ParamAtName(
    string paramName
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### ParamAtName(string, int)

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::paramAtName () method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public ObjectId ParamAtName(
    string paramName, 
    int index
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### ParamsAtName

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::paramsAtName () method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public ObjectIdCollection ParamsAtName(
    string paramName
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### PostProcessAfterDeepCloneCancelOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual void PostProcessAfterDeepCloneCancelOverride(
    IdMapping idMap
);
```

### PostProcessAfterDeepCloneOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual void PostProcessAfterDeepCloneOverride(
    IdMapping idMap
);
```

### RemoveAllDependencies

#### Description
Just a shortcut, calls the method on the parent AssocAction that owns this action body object.
```text
public void RemoveAllDependencies(
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseThem
);
```

### RemoveAllDependenciesOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual void RemoveAllDependenciesOverride(
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseThem
);
```

### RemoveAllParams

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::removeAllParams() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public void RemoveAllParams(
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseThem
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### RemoveDependency

#### Description
Just a shortcut, calls the method on the parent AssocAction that owns this action body object.
```text
public void RemoveDependency(
    ObjectId dependencyId, 
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseIt
);
```

### RemoveParam

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::removeParam () method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public void RemoveParam(
    ObjectId paramId, 
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseIt
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### RemoveValueParam

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::removeValueParam() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public void RemoveValueParam(
    string paramName
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### SetStatus

#### Description
Just a shortcut, calls the method on the parent AssocAction that owns this action body object.
```text
public void SetStatus(
    AssocStatus newStatus, 
    [MarshalAs(UnmanagedType.U1)] bool notifyOwningNetwork, 
    [MarshalAs(UnmanagedType.U1)] bool setInOwnedActions
);
```

### SetValueParam(string, ValueParam, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::setValueParam() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public string SetValueParam(
    string paramName, 
    ValueParam param, 
    [MarshalAs(UnmanagedType.U1)] bool silentMode
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### SetValueParam(string, ValueParam, [MarshalAs(UnmanagedType.U1)] bool, int)

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::setValueParam() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public string SetValueParam(
    string paramName, 
    ValueParam param, 
    [MarshalAs(UnmanagedType.U1)] bool silentMode, 
    int paramIndex
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### SetValueParamArray

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::setValueParamArray() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public string\[\] SetValueParamArray(
    string paramName, 
    ValueParam\[\] valueParams, 
    [MarshalAs(UnmanagedType.U1)] bool silentMode
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### SetValueParamUnitType

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::setValueParamUnitType() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public void SetValueParamUnitType(
    string paramName, 
    Autodesk.AutoCAD.DatabaseServices.UnitType unitType
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### TransformActionByOverride

#### Description
Called from the corresponding method of the parent AssocAction class that owns this action body object. It does not need to be overridden.
```text
public virtual void TransformActionByOverride(
    Matrix3d A_0
);
```

### ValueParamInputVariables

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::valueParamInputVariables() method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public ObjectIdCollection ValueParamInputVariables(
    string paramName
);
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### ValueParam Structure

#### Description
This encapsulates the Value Param.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public struct ValueParam {
}
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### OwnedParams

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::ownedParams () method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public ObjectIdCollection OwnedParams;
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### OwningNetwork

#### Description
Just a shortcut, calls the method on the parent AssocAction that owns this action body object.
```text
public ObjectId OwningNetwork;
```

### ParamCount

#### Description
This wraps the ObjectARX AcDbAssocParamBasedActionBody::paramCount () method.
Class
Autodesk.AutoCAD.DatabaseServices.AssocActionBody
```text
public int ParamCount;
```

Previous Class
Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
### ParentAction

#### Description
Returns ObjectId of the parent AssocAction that owns this action body object.
```text
public ObjectId ParentAction;
```

### Status

#### Description
Just a shortcut, calls the method on the parent AssocAction that owns this action body object.
```text
public AssocStatus Status;
```

### ValueParam.EvaluatorId

#### Description
Gets and sets Evaluator ID.
```text
public string EvaluatorId;
```

#### Conditions
Read / write
### ValueParam.Expression

#### Description
Gets and sets the Expression.
```text
public string Expression;
```

#### Conditions
Read / write
### ValueParam.Value

#### Description
Gets and sets the parameter value.
```text
public ResultBuffer Value;
```

#### Conditions
Read / write