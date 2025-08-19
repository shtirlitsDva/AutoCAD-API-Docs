# AssocAction Class

## Overview

#### Description
Any object that wants to exhibit associative behavior, i.e. be automatically evaluated by the associative mechanism when objects it depends on change, needs to be derived from an AssocActionBody class (see comments at the AssocActionBody class) and owned by a parent AssocAction object. The action body is fully owned by its parent action, such as when the parent action is erased, it also erases the owned action body. 
The AssocAction class itself does not have virtual methods that could be overridden, therefore it is not possible for external developers to derive directly from the AssocAction class and override its methods. Internal AutoCAD developers can derive from the AssocAction class and override its virtual methods, but it should only be done when there is no possibility that objects of the derived action classes could become proxies. 
Each action is owned by an AssocNetwork that itself is an action, therefore hirearchical associative structures can be represented. 
The main protocol of the AssocAction class is the evaluate() method that calls the evaluateOverride() method of the owned AssocActionBody object. 
Actions own AssocDependency objects that allow the actions to depend on arbitrary Objects. This is how the connectivity in the network is represented. When objects the dependencies depend on change, the dependencies are notified, actions owning the dependencies are notified and also the hierarchy of the networks owning the actions is notified. This notification just changes AssocStatus of the dependencies and of the actions/networks to "dirty", it does not trigger any action evaluation. 
The actual action evaluation happens when the client code calls the evalaute() method on the top-level network. This automatically evaluates all the actions the network owns that need to be evaluated because they depend, either directly or transitively, on objects that changed. If an action modifies an object (has a write-dependency on it) and there is another action that uses the modified object (has read-dependency on it), then, if the first action is evaluated, the second action also needs to be transitively evaluated. 
The flow of information is as follows: 
Object1 --ReadDep--> Action1 --WriteDep1--> Object2 --ReadDep--> Action2 ... 
Notice that an action may depend on multiple objects and may modify multiple other objects. The network forms a directed acyclic graph. The evalution algoritm makes sure that all actions that need to be evaluated are evaluated and that the evaluation happens in the correct order so that every action is evaluated only after all other actions that modify objects this action depends on have already been evaluated (the situation is actually litle bit more complex, there are other aspects controlling the evaluation order). 
The AssocManager::evaluateTopLevelNetwork() static method should be used to evaluate the top-level network of the database. It will collect and evaluate all the actions that need to be evaluated. Explicit evaluation of the individual sub-networks is not recommended.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocAction
        Autodesk.AutoCAD.DatabaseServices.Assoc2dConstraintGroup
        Autodesk.AutoCAD.DatabaseServices.AssocNetwork
        Autodesk.AutoCAD.DatabaseServices.AssocVariable
```

```text
public class AssocAction : DBObject;
```

### Constructors

- [AssocAction](#assocaction)

### Methods

- [AddDependency](#adddependency)
- [AddMoreObjectsToDeepClone](#addmoreobjectstodeepclone)
- [AreDependenciesEqual](#aredependenciesequal)
- [AreDependenciesOnTheSameThing](#aredependenciesonthesamething)
- [DependentObjectCloned](#dependentobjectcloned)
- [DragStatus](#dragstatus)
- [Evaluate](#evaluate)
- [EvaluateDependencies](#evaluatedependencies)
- [EvaluateDependency](#evaluatedependency)
- [EvaluationPriority](#evaluationpriority)
- [GetActionBody](#getactionbody)
- [GetActionsDependentOnObject(DBObject, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#getactionsdependentonobject(dbobject,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [GetActionsDependentOnObject(DBObject, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, ObjectIdCollection)](#getactionsdependentonobject(dbobject,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool,-objectidcollection))
- [GetDependencies](#getdependencies)
- [GetDependentActionsToEvaluate](#getdependentactionstoevaluate)
- [GetDependentObjects](#getdependentobjects)
- [HasDependencyCachedValue](#hasdependencycachedvalue)
- [IsEqualTo](#isequalto)
- [IsExternalDependency](#isexternaldependency)
- [IsOwnedDependency](#isowneddependency)
- [IsRelevantDependencyChange](#isrelevantdependencychange)
- [ObjectThatOwnsNetworkInstance](#objectthatownsnetworkinstance)
- [OwnedDependencyStatusChanged](#owneddependencystatuschanged)
- [PostProcessAfterDeepClone](#postprocessafterdeepclone)
- [PostProcessAfterDeepCloneCancel](#postprocessafterdeepclonecancel)
- [RemoveActionsControllingObject(ObjectId)](#removeactionscontrollingobject(objectid))
- [RemoveActionsControllingObject(ObjectId, int)](#removeactionscontrollingobject(objectid,-int))
- [RemoveActionsControllingObject(ObjectId, int, ObjectId)](#removeactionscontrollingobject(objectid,-int,-objectid))
- [RemoveAllDependencies](#removealldependencies)
- [RemoveDependency](#removedependency)
- [SetOwningNetwork](#setowningnetwork)
- [SetStatus](#setstatus)
- [TransformActionBy](#transformactionby)

### Properties

- [ActionBody](#actionbody)
- [CurrentEvaluationCallback](#currentevaluationcallback)
- [IsActionBodyAProxy](#isactionbodyaproxy)
- [IsActionEvaluationInProgress](#isactionevaluationinprogress)
- [OwningNetwork](#owningnetwork)
- [Status](#status)


## Constructors Details

### AssocAction

#### Description
Default constructor.
```text
public AssocAction();
```

### AddDependency

#### Description
Adds the given AssocDependency to this action. The dependency may either become owned by this action (if setThisActionAsOwningAction is true) which is the most common case, or just referenced by this action.
```text
public void AddDependency(
    ObjectId dependencyId, 
    [MarshalAs(UnmanagedType.U1)] bool setThisActionAsOwningAction
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId dependencyId | ObjectId of the AssocDependency being added to this action. |
| [MarshalAs(UnmanagedType.U1)] bool setThisActionAsOwningAction | If true, sets this action to be the database owner of the dependency. In this case the dependency must not be already owned by any other action. |

### AddMoreObjectsToDeepClone

#### Description
Called just before the end of the main deep-cloning loop (before AcRxEventReactor::beginDeepCloneXlation() reactor notification), when the objects have already been cloned but their ids haven't been translated yet. 
It asks the actions who have AssocDependencies on some objects that have been cloned, whether the actions want to add some more objects to deep clone. The actions can then report more objects to be deep cloned and the main cloning loop then continues with deep cloning these additional objects. If it caused more objects to be cloned, the actions that have dependencies on these newly cloned objects are asked and may add yet more objects to clone. This process continues until no more objects are cloned. 
If the action owns an AssocActionBody object that overrides the addMoreObjectsToDeepCloneOverride() callback, this callback is called.
```text
public void AddMoreObjectsToDeepClone(
    IdMapping idMap, 
    ObjectIdCollection additionalObjectsToClone
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IdMapping idMap | The IdMapping of the current deep cloning session. |
| ObjectIdCollection additionalObjectsToClone | Additional objects that the action also wants to deep clone. It is legal to add objects that have already been cloned; they will be ignored and not cloned again. |

### AreDependenciesEqual

#### Description
Delegated from he owned dependency's AssocDependency.isEqualTo() predicate. It allows the owning action, instead of the dependency itself, to decide whether the two dependencies are equal. The default implementation just returns false. 
If the action owns an AssocActionBody object that overrides the areDependenciesEqualOveride() predicate, this predicate is called instead of just returning false.
```text
public bool AreDependenciesEqual(
    AssocDependency dependency1, 
    AssocDependency dependency2
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocDependency dependency1 | The dependency owned by this action. It needs to be open at least for read. |
| AssocDependency dependency2 | Another dependency. It needs to be open at least for read. |

#### Returns
true if the two dependencies are "equal", false otherwise. The default implementation returns false.
### AreDependenciesOnTheSameThing

#### Description
Delegated from the owned dependency's AssocDependency.IsDependentOnTheSameThingAs() predicate. It allows the owning action, instead of the dependency itself, to decide whether the two depedencies depend on the same thing. The default implementation just returns true. 
If the action owns an AssocActionBody object that overrides the IsDependentOnTheSameThingOveride() predicate, this predicate is called instead of just returning true.
```text
public bool AreDependenciesOnTheSameThing(
    AssocDependency dependency1, 
    AssocDependency dependency2
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocDependency dependency1 | The dependency owned by this action. It needs to be open at least for read. |
| AssocDependency dependency2 | Another dependency. It needs to be open at least for read. |

#### Returns
Returns true if the two dependencies depend on the same "thing", false otherwise. The default implementation returns false.
### DependentObjectCloned

#### Description
Called from the owned dependency's AssocDependency.copied() persistent reactor callback. It notifies the owning action about the fact that an object the action has a dependency on has been cloned. The cloning may be just shallow clone, not necessarily deep or wblock clone. 
If the action owns an AssocActionBody object that overrides the dependentObjectClonedOverride() callback, this callback is called.
```text
public void DependentObjectCloned(
    AssocDependency dependency, 
    DBObject dbObj, 
    DBObject newObj
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocDependency dependency | The AssocDependency on the DBObject that has been cloned. |
| DBObject dbObj | The original object. |
| DBObject newObj | The newly created clone. |

### DragStatus

#### Description
This function is called to notify the action when a there is a drag operation in progress and some objects the action depends on, either directly or indirectly, are being dragged.
```text
public void DragStatus(
    Autodesk.AutoCAD.DatabaseServices.DragStatus status
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.DragStatus status | See the [DragStatus](Autodesk_AutoCAD_DatabaseServices_DragStatus.md "DragStatus Enumeration") enum. |

### Evaluate

#### Description
This method is called by the client code to evaluate an action or an associative network. It is the crux of the whole associative mechanism. 
It evaluates the action based on the current values of the objects the action depends on (the action has read-dependencies on these objects), changes the objects that depend on this action (the action has write- dependencies on these objects) and sets the status of the action to [IsUpToDateAssocStatus](Autodesk_AutoCAD_DatabaseServices_AssocStatus.md "AssocStatus Enumeration") or to [FailedToEvaluateAssocStatus](Autodesk_AutoCAD_DatabaseServices_AssocStatus.md "AssocStatus Enumeration"). 
If the action owns an AssocActionBody object, its evaluateOverride() method is called to do the real work. For internal classes it is also possible to directly override the AssocAction::evaluateOverride() method. 
AssocAction.evaluateDependencies() should be called from inside of the overridden evaluateOverride() method of a class derived from AssocActionBody or AssocAction to evaluate the dependencies that need to be evaluated. See the description at the evaluateDependencies() method. 
While the action is being evaluated, it calls methods of the currentEvaluationCallback() to inform the client code about the evaluation. See the definition of AssocEvaluationCallback for more details. 
The sequence of events is as follows: 
  * Calls AssocEvaluationCallback.beginActionEvaluation().

  * Marks that action evaluation is in progress and sets the passed-in AssocEvaluationCallback as the current evaluation callback. It can then be obtained by other methods that are being invoked during the evaluation by calling currentEvaluationCallback().

  * Checks whether the action needs to be evaluated. Does not evaluate if not.

  * Calls AssocAction::evaluateOverride() to do the work. This calls the AssocActionBody.evaluateOverride() method if the action owns an action body object. The AssocAction.evaluateOverride() can also be directly overridden in the internal classes.

  * Calls AssocEvaluationCallback.endActionEvaluation().

```text
public void Evaluate(
    AssocEvaluationCallback evaluationCallback
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocEvaluationCallback evaluationCallback | While the action is being evaluated, it calls methods of the callback object to inform the client code about the evaluation. The callback reference must not be NULL. See the definition of AssocEvaluationCallback for more details. |

### EvaluateDependencies

#### Description
This method needs to be called from the client code evaluateOverride() method, usually after the client code inspected the dependencies, found which changed, which were on erased objects, etc. It gets all dependencies of the action and evaluates the ones that need to be evaluated, i.e. dependencies for which IsEvaluationRequest() == true.
```text
public void EvaluateDependencies();
```

### EvaluateDependency

#### Description
Delegated from the owned dependency's AssocDependency.evaluateOverride() method. It allows the owning action, instead of the dependency itself, to do the work. The default implementation just sets the dependency status to IsUpToDateAssocStatus. 
If the action owns an AssocActionBody object that overrides the evaluateDependencyOverride() method, this method is called to do the work.
```text
public void EvaluateDependency(
    AssocDependency dependency
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocDependency dependency | The dependency that is to be evaluated. It needs to be open at least for read. |

### EvaluationPriority

#### Description
This method provides default implementation suitable for most circumstances, but actions may override it to define their special behavior. 
It is called when an AssocNetwork is evaluated during which it sequentially evaluates all the actions in the network that need to be evaluated. The evaluation algorithm first collects all actions that need to be evaluated and then evaluates them based on their evaluation priority by querying the actions. 
The action should return a positive priority number if it can be evaluated and a negative number if it cannot. Higher positive priority numbers mean that the action should be evaluated sooner, ahead of actions with lower positive priority. The negative numbers mean how much the action cannot be evaluated. The smaller the number, the less the action can be evaluated (such as when no action can be evaluated, the actions with least negative priorities are evaluated to break the loop and maybe enable other actions to be evaluated). Priority 0 means that the priority cannot be determined at this time. 
The default implementation returns CanBeEvaluatedAssocEvaluationPriority
  * evaluationRequestSeverityLevel() if the action can be evaluated

because it only depends on objects that are results of actions that have already been evaluated (actually the rules are little bit more complex), and CannotBeEvaluatedAssocEvaluationPriority if the action cannot be evaluated because it depends on some objects that are a result of some not-yet evaluated actions. 
If the action owns an AssocActionBody object that overrides the evaluationPriorityOverride() method, this method is called and it supersedes the default implementation.
```text
public AssocEvaluationPriority EvaluationPriority();
```

#### Returns
Priority greater than 0 means action can be evaluated, priority less than 0 means action cannot be evaluated. Priority 0 means that it cannot be determined at this time.
### GetActionBody

#### Description
This wraps the [AcDbAssocAction::actionBody](AcDbAssocAction__actionBody@const.md)() method.
```text
public static ObjectId GetActionBody(
    ObjectId actionId
);
```

### GetActionsDependentOnObject(DBObject, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
A static method to get all actions depending on the given DBObject (these actions have AssocDependencies on this object).
```text
public static ObjectIdCollection GetActionsDependentOnObject(
    DBObject dbObj, 
    [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted, 
    [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DBObject dbObj | The DBObject whose actions are requested. The object needs to be open at least for read. |
| [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted | Actions that depend-on the object wanted. |
| [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted | Actions that modify the object wanted. |

#### Returns
Returned ObjectIds of the AssocActions.
### GetActionsDependentOnObject(DBObject, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, ObjectIdCollection)

#### Description
This wraps the [AcDbAssocAction::getActionsDependentOnObject](AcDbAssocAction__getActionsDependentOnObject@AcDbObject_@bool@bool@AcDbObjectIdArray_.md)() method.
```text
public static void GetActionsDependentOnObject(
    DBObject dbObj, 
    [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted, 
    [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted, 
    ObjectIdCollection actionIds
);
```

### GetDependencies

#### Description
Gets AssocDependencies of this action. The default implementation obtains all dependencies owned by the base action class and selects the ones based on the required read/write type. 
If the action owns an AssocActionBody object that overrides the getDependenciesOverride() method, this method is called and it supersedes the default implementation. It allows the custom action body classes to control which dependencies to return and which not to mention.
```text
public ObjectIdCollection GetDependencies(
    [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted, 
    [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted | Read-type dependencies wanted. |
| [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted | Write-type dependencies wanted. |

#### Returns
Returned ObjectIds of AssocDependencies.
### GetDependentActionsToEvaluate

#### Description
Lets the action report all other actions that need to be evaluated because this action is evaluated. It is repeatedly used to transitively collect all actions that need to be evaluated, before an associative network is evaluated. This action needs to be open at least for read and it needs to require to be evaluated: IsEvaluationRequest() == true. 
The default implementation checks dependencies of this action and then dependencies of other actions on the objects this action depends on, and reports all dependencies of other actions that need to be evaluated. This default implementation will suffice in most cases. The derived action classes can add their own logic, but they should also always call the base class implementation. 
If the action owns an AssocActionBody object that overrides the getDependentActionsToEvaluateOverride() method, this method is called and it supersedes the default implementation.
```text
public void GetDependentActionsToEvaluate(
    ActionsToEvaluateCallback actionsToEvaluateCallback
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ActionsToEvaluateCallback actionsToEvaluateCallback | The method uses this callback to report other AssocActions, AssocDependencies and arbitrary DBObjects that should also be scheduled to evaluate when this action is evaluated. |

### GetDependentObjects

#### Description
Gets objects that this action depends on or modifies. The default implementation collects all objects on which the action has AssocDependencies. 
If the action owns an AssocActionBody object that overrides the GetDependentObjectsOverride() method, this method is called and it supersedes the default implementation. It allows the custom action body classes to control which objects to return and which not to mention, but usually there is no need to override this method, the default implementation that traverses all the dependencies of the action should suffice.
```text
public ObjectIdCollection GetDependentObjects(
    [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted, 
    [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted | Dependent-on objects wanted. |
| [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted | Modified objects wanted. |

#### Returns
ObjectIds of the objects.
### HasDependencyCachedValue

#### Description
Delegated from the owned dependency's [AssocDependency.HasCachedValue](Autodesk_AutoCAD_DatabaseServices_AssocDependency_HasCachedValue.md)() predicate. It allows the owning action, instead of the dependency itself, to decide whether the dependency has a cached value. The default implementation just returns false. 
This way the the cached value can be stored either in the dependency itself or in the action that owns it, based on what is more convenient for each particular action or dependency type. 
If the action owns an AssocActionBody object that overrides the [HasDependencyCachedValueOverride](Autodesk_AutoCAD_DatabaseServices_AssocActionBody_HasDependencyCachedValueOverride@AssocDependency.md)() predicate, this predicate is called instead of just returning false.
```text
public bool HasDependencyCachedValue(
    AssocDependency dependency
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocDependency dependency | The dependency that is checked whether it has cached value. It needs to be open at least for read. |

#### Returns
Returns true if the dependency has a cached value, false otherwise. The default implementation returns false.
### IsEqualTo

#### Description
Compares this action with the given action and returns true if and only if they are equal (whatever it means). Both actions need to be open at least for read. 
If the action owns an AssocActionBody object that overrides the IsEqualToOverride() predicate, this predicate is called.
```text
public bool IsEqualTo(
    AssocAction otherAction
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocAction otherAction | The other action needs to be open for read. |

#### Returns
True if the two actions are equal.
### IsExternalDependency

#### Description
Checks whether the given AssocDependency, owned by this action, is external to this action, i.e., it depends on an DBObject that is not this action and is not owned by this action (when the action is a network). Also, when the dependency does not depend on any object, it is considered external. 
If the action owns an AssocActionBody object that overrides the IsExternalDependencyOverride() predicate, this predicate is called and it supersedes the default implementation.
```text
public bool IsExternalDependency(
    AssocDependency dependency
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocDependency dependency | The dependency that is checked whether it is external. Needs to be open at least for read. |

#### Returns
True if the given dependency is external to this action.
### IsOwnedDependency

#### Description
Checks whether the given AssocDependency is owned by this action, either directly, or if this action is a network, is owned by an action owned by the network. 
The default implementation first makes a quick check whether the OwnerId() of the dependency is the ObjectId() of this action. If not and it is a network, it calls GetDependencies() and checks if the dependency is one of the returned ones. The second check is generic and applicable to any action, but it has not been used as the default implementation for any action because it is more expensive. 
If the action owns an AssocActionBody object that overrides the isOwnedDependencyOverride() predicate, this predicate is called and it supersedes the default implementation.
```text
public bool IsOwnedDependency(
    AssocDependency dependency
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocDependency dependency | The dependency that is checked whether it is owned by this action. Needs to be open at least for read. |

#### Returns
True if the given dependency is owned by this action.
### IsRelevantDependencyChange

#### Description
Delegated from the owned dependency's [AssocDependency.IsRelevantChange](Autodesk_AutoCAD_DatabaseServices_AssocDependency_IsRelevantChange.md)() predicate. It allows the owning action, instead of the dependency itself, to decide whether the object change is relevant to that particular dependency. The default implementation just returns true. 
This way the data (usually the cached value) that is needed to decide whether an object change is relevant to a particular dependency type or not, can be stored either in the dependency itself or in the action that owns it, based on what is more convenient for each particular action or dependency type. 
If the action owns an AssocActionBody object that overrides the IsRelevantDependencyChangeOverride() predicate, this predicate is called instead of just returning true.
```text
public bool IsRelevantDependencyChange(
    AssocDependency dependency
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocDependency dependency | The dependency that is checked whether the change in the object it depends on is relevant or not. It needs to be open at least for read. |

#### Returns
Returns if the dependency change is relevant. The default implementation returns true.
### ObjectThatOwnsNetworkInstance

#### Description
Starting from this AssocAction, checks this AssocAction and its owners (in "physical" AutoCAD database object owhership sense) until an AssocNetwork is encountered whose "database" owner is not another AssocNetwork. Then finds an inverse of AssocNetwork.GetInstanceFromObject(), i.e., it finds the DBObject for which GetInstanceFromObject() method returns the AssocNetwork.
```text
public ObjectId ObjectThatOwnsNetworkInstance();
```

#### Returns
ObjectId of the DBObject owning an AssocNetwork that owns this AssocAction
### OwnedDependencyStatusChanged

#### Description
This callback is called from [AssocDependency.SetStatus](Autodesk_AutoCAD_DatabaseServices_AssocDependency_SetStatus@AssocStatus@\[MarshalAsUnmanagedType_U1\]_bool.md)(..., true) and notifies the action owning the dependency that the status of the dependency has just been changed. The dependency is still open for write and already has the new status. 
If the action owns an AssocActionBody object that overrides the [OwnedDependencyStatusChangedOverride](Autodesk_AutoCAD_DatabaseServices_AssocActionBody_OwnedDependencyStatusChangedOverride@AssocDependency@AssocStatus.md)() method, it is called after the default implementation in the AssocAction class has been performed. However, there should usually be no need to override this method.
```text
public void OwnedDependencyStatusChanged(
    AssocDependency ownedDependency, 
    AssocStatus previousStatus
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocDependency ownedDependency | The dependency whose status has just been changed. |
| AssocStatus previousStatus | Previous status of the dependency. |

### PostProcessAfterDeepClone

#### Description
Called from a reactor notification method (ids of the clones have already been translated) to inform the source actions that they have been cloned, so that they can update the clones or do some other work that it needed. Notice that the source action can obtain its clone by consulting the provided IdMapping. 
If the action owns an AssocActionBody object that overrides the [PostProcessAfterDeepCloneOverride](Autodesk_AutoCAD_DatabaseServices_AssocActionBody_PostProcessAfterDeepCloneOverride@IdMapping.md)() callback, this callback is called.
```text
public void PostProcessAfterDeepClone(
    IdMapping idMap
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IdMapping idMap | The IdMapping of the current deep cloning session. |

### PostProcessAfterDeepCloneCancel

#### Description
Called from a reactor notification method. Notice that the source action can obtain its clone by consulting the provided IdMapping. 
If the action owns an AssocActionBody object that overrides the [PostProcessAfterDeepCloneCancelOverride](Autodesk_AutoCAD_DatabaseServices_AssocActionBody_PostProcessAfterDeepCloneCancelOverride@IdMapping.md)() callback, this callback is called, but it may usually be safer not to override this callback and just do nothing.
```text
public void PostProcessAfterDeepCloneCancel(
    IdMapping idMap
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IdMapping idMap | The IdMapping of the current deep cloning session. |

### RemoveActionsControllingObject(ObjectId)

#### Description
This wraps the [AcDbAssocAction::removeActionsControllingObject](AcDbAssocAction__removeActionsControllingObject@AcDbObjectId_@int@AcDbObjectId_.md)() method.
```text
public static void RemoveActionsControllingObject(
    ObjectId objID
);
```

### RemoveActionsControllingObject(ObjectId, int)

#### Description
This wraps the [AcDbAssocAction::removeActionsControllingObject](AcDbAssocAction__removeActionsControllingObject@AcDbObjectId_@int@AcDbObjectId_.md)() method.
```text
public static void RemoveActionsControllingObject(
    ObjectId objID, 
    int readOnlyDependencyHandling
);
```

### RemoveActionsControllingObject(ObjectId, int, ObjectId)

#### Description
This wraps the [AcDbAssocAction::removeActionsControllingObject](AcDbAssocAction__removeActionsControllingObject@AcDbObjectId_@int@AcDbObjectId_.md)() method.
```text
public static void RemoveActionsControllingObject(
    ObjectId objID, 
    int readOnlyDependencyHandling, 
    ObjectId objectToRedirectReadOnlyDependenciesTo
);
```

### RemoveAllDependencies

#### Description
Removes all AssocDependencies kept in the vector of dependencies of this action and optionally also erases them. 
If the action owns an AssocActionBody object that overrides the [RemoveAllDependenciesOverride](Autodesk_AutoCAD_DatabaseServices_AssocActionBody_RemoveAllDependenciesOverride@\[MarshalAsUnmanagedType_U1\]_bool.md)() method, this method is called to notify about the dependencies being removed. This happens after all the dependencies have already been removed.
```text
public void RemoveAllDependencies(
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseThem
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool alsoEraseThem | Erase the AssocDependencies after removing them. |

### RemoveDependency

#### Description
Removes the given AssocDependency from this action.
```text
public void RemoveDependency(
    ObjectId dependencyId, 
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseIt
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId dependencyId | ObjectId of the AssocDependency being removed from this action. |
| [MarshalAs(UnmanagedType.U1)] bool alsoEraseIt | Erases the dependency after removing it. |

### SetOwningNetwork

#### Description
Every action except for the topmost AssocNetwork is logically owned by a single AssocNetwork. 
This network may also be the "physical" database owner of the action (the network has hard-ownership id of the action), but the "physical" owner may also be some other object. For example, for networks attached to BlockTableRecords, the "logical" owner is the top-level network of the whole database but the "physical" database owner is the subdictionary of the extension dictionary of the AcBdBlockTableRecord. 
This method should not be called directly, [AssocNetwork.AddAction](Autodesk_AutoCAD_DatabaseServices_AssocNetwork_AddAction@ObjectId@\[MarshalAsUnmanagedType_U1\]_bool.md) and [AssocNetwork.RemoveAction](Autodesk_AutoCAD_DatabaseServices_AssocNetwork_RemoveAction@ObjectId@\[MarshalAsUnmanagedType_U1\]_bool.md)() should be used, which in turn calls setOwningNetwork().
```text
public void SetOwningNetwork(
    ObjectId networkId, 
    [MarshalAs(UnmanagedType.U1)] bool alsoSetAsDatabaseOwner
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId networkId | The AssocNetwork logically owning this action. |
| [MarshalAs(UnmanagedType.U1)] bool alsoSetAsDatabaseOwner | Make the network the database owner of this action. |

### SetStatus

#### Description
Sets the AssocStatus of the action. If the status is one of the codes that indicate that the action will need to be evaluated (the [IsEvaluationRequest](Autodesk_AutoCAD_DatabaseServices_AssocGlobalUtility_IsEvaluationRequest@AssocStatus.md)() predicate returns true for such a status), but the current status of the action is not that it would need to be evaluated, it propagates this status up to the AssocNetwork owning the action, and higher in the network hierarchy to the network owning this network, etc, so that all owning networks know that they contain an action that needs to be evaluated. 
If the new status [IsEvaluationRequest](Autodesk_AutoCAD_DatabaseServices_AssocGlobalUtility_IsEvaluationRequest@AssocStatus.md)() and [EvaluationRequestSeverityLevel](Autodesk_AutoCAD_DatabaseServices_AssocGlobalUtility_EvaluationRequestSeverityLevel@AssocStatus.md)() of the new status is lower than the current evaluation request status of the action, the current higher status of the action is kept and not overwritten by the new lower status. Also, if the current status of the action [IsToBeSkipped](Autodesk_AutoCAD_DatabaseServices_AssocGlobalUtility_IsToBeSkipped@AssocStatus.md)(), it is not overwritten by any new status that IsEvaluationRequest(). To change the action status in such a case, the action status needs to be first changed to [IsUpToDateAssocStatus](Autodesk_AutoCAD_DatabaseServices_AssocStatus.md "AssocStatus Enumeration"), and after that it can be changed to an IsEvaluationRequest() status.
```text
public void SetStatus(
    AssocStatus newStatus, 
    [MarshalAs(UnmanagedType.U1)] bool notifyOwningNetwork, 
    [MarshalAs(UnmanagedType.U1)] bool setInOwnedActions
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocStatus newStatus | The new AssocStatus of the action. |
| [MarshalAs(UnmanagedType.U1)] bool notifyOwningNetwork | If true, and the passed-in status indicates that the action needs to be evaluated, the status of the AssocNetwork owning this dependency is set to the same status (unless the network evaluation status is already more severe than the new one). |
| [MarshalAs(UnmanagedType.U1)] bool setInOwnedActions | If true, and this action owns some other actions (such as AssocNetwork owns actions), the status is also set in all owned actions (both directly owned and recursively owned). |

### TransformActionBy

#### Description
Notifes the action that the owner of the action was transformed, such as that all entities in the BlockTableRecord owning the network that owns the action were transformed.
```text
public void TransformActionBy(
    Matrix3d transform
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Matrix3d transform | The provided transformation matrix. |

### ActionBody

#### Description
Gets and sets the ObjectId of an object of a class derived from AssocActionBody, or null if no action body object has been set. The AssocActionBody object is owned by this AssocAction object and implements the body of the custom action. See more information see [AssocActionBody](Autodesk_AutoCAD_DatabaseServices_AssocActionBody.md "AssocActionBody Class") class. 
```text
public ObjectId ActionBody;
```

#### Conditions
Read / write
### CurrentEvaluationCallback

#### Description
Gets the current AssocEvaluationCallback set by the AssocAction.evaluate() call, or NULL if no action evaluation is in progress. Notice that when action evaluation is in progress, there is always a non-NULL AssocEvaluationCallback.
```text
public AssocEvaluationCallback CurrentEvaluationCallback;
```

#### Conditions
Read-only
### IsActionBodyAProxy

#### Description
This wraps the [AcDbAssocAction::isActionBodyAProxy](AcDbAssocAction__isActionBodyAProxy@const.md)() method.
```text
public bool IsActionBodyAProxy;
```

### IsActionEvaluationInProgress

#### Description
Indicates whether the system is currently evaluating an action or a network of actions. 
Notice that when action evaluation is in progress, dependency notifications are disabled. When an object that has dependencies attached to itself is changed, the dependencies ignore this notification and consequently also do not notify the actions owning the dependencies. This is necessary because otherwise if one action evaluation modified some objects, the dependencies on these objects would be notified and the status of other actions owning these dependencies would be changed, requesting the actions to be evaluated again. This would lead to infinite loops.
```text
public bool IsActionEvaluationInProgress;
```

#### Conditions
Read-only
### OwningNetwork

#### Description
Gets the logically owning AssocNetwork or ObjectId.Null if it is the topmost AssocNetwork. 
Every action except for the topmost AssocNetwork is "logically" owned by a single AssocNetwork. 
This network may also be the "physical" database owner of the action (the network has hard-ownership id of the action), but the "physical" owner may also be some other object. For example, for networks attached to BlockTableRecords, the "logical" owner is the top-level network of the whole database but the "physical" database owner is the subdictionary of the extension dictionary of the AcBdBlockTableRecord.
```text
public ObjectId OwningNetwork;
```

#### Conditions
Read-only
### Status

#### Description
Gets and sets the current AssocStatus of this action.
```text
public AssocStatus Status;
```

#### Conditions
Read / write