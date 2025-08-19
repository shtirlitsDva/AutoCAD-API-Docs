# AssocDependency Class

## Overview

#### Description
AssocDependencies represent information about which AssocActions depend on or modify which DBObjects. This is how the associativity in the drawing is represented. Dependencies are owned by actions and are attached to the objects as persistent reactors. When the dependent-on object changes, it notifies the dependency via the persistent reactor mechanism. The dependency checks whether the change is relevant, such as when the dependency is on an endpoint of a line but the color of the line changed, or the other endpoint changed, and if yes, it changes its status indicating that it needs to be evaluated, and also changes the status of the owning action indicating that it needs to be evaluated (and the action changes the status of the AssocNetwork that owns it). 
The base AssocDependency class can be used as it but there are also provided a few concrete derived dependency classes that represent particular kinds of dependencies on particular objects or subobjects, such as on subentities (faces, edges, vertices) of geometric entities, on objects that provide a numerical value, etc. For example, the dependency on a subentity of a geometric entity keeps AssocPersSubentId of the subentity and the cached subentity geometry (such as the [x,y,z] of a vertex subentity, the Curve of an edge subentity, etc.). It can then check whether the subentity really changed by obtaining the subentity geometry from the geometric entity and comparing it with the cached geometry. If they are the same, the change notification is ignored. 
A better way to add a custom dependency class is to derive a custom AssocDependencyBody class (see comments at the AssocDependencyBody class) and make objects of this class owned by the parent AssocDependency objects. The relation between AssocDependency and AssocDependencyBody classes is analogous to the relation between AssocAction and AssocActionBody classes, so please read the comments at the AssocAction class for more information. In particular, the dependency body is fully owned by its parent dependency, such as when the parent dependency is erased, it also erases the owned dependency body. 
A more memory efficient way to implement custom dependency behavior is to use objects of the AssocDependency base class and let them delegate to the owning action (see the isDelegatingToOwningAction() property). The AssocActionBody owned by the action owning the dependency then overrides methods like [AssocActionBody.IsRelevantDependencyChangeOverride](Autodesk_AutoCAD_DatabaseServices_AssocActionBody_IsRelevantDependencyChangeOverride@AssocDependency.md)() to implement the custom dependency behavior.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocDependency
        Autodesk.AutoCAD.DatabaseServices.AssocGeomDependency
        Autodesk.AutoCAD.DatabaseServices.AssocValueDependency
```

```text
public class AssocDependency : DBObject;
```

### Constructors

- [AssocDependency](#assocdependency)

### Methods

- [AttachToObject](#attachtoobject)
- [DetachFromObject](#detachfromobject)
- [Evaluate](#evaluate)
- [GetDependenciesOnObject](#getdependenciesonobject)
- [GetFirstDependencyOnObject](#getfirstdependencyonobject)
- [IsDependentOnTheSameThingAs](#isdependentonthesamethingas)
- [IsEqualTo](#isequalto)
- [NotifyDependenciesOnObject](#notifydependenciesonobject)
- [SetDependentOnObject](#setdependentonobject)
- [SetStatus](#setstatus)
- [UpdateDependentOnObject](#updatedependentonobject)

### Properties

- [CurrentEvaluationCallback](#currentevaluationcallback)
- [DependencyBody](#dependencybody)
- [DependentOnCompoundObject](#dependentoncompoundobject)
- [DependentOnObject](#dependentonobject)
- [DependentOnObjectStatus](#dependentonobjectstatus)
- [HasCachedValue](#hascachedvalue)
- [IsActionEvaluationInProgress](#isactionevaluationinprogress)
- [IsAttachedToObject](#isattachedtoobject)
- [IsDelegatingToOwningAction](#isdelegatingtoowningaction)
- [IsDependentOnCompoundObject](#isdependentoncompoundobject)
- [IsDependentOnObjectReadOnly](#isdependentonobjectreadonly)
- [IsObjectStateDependent](#isobjectstatedependent)
- [IsReadDependency](#isreaddependency)
- [IsRelevantChange](#isrelevantchange)
- [IsWriteDependency](#iswritedependency)
- [NextDependencyOnObject](#nextdependencyonobject)
- [Order](#order)
- [OwningAction](#owningaction)
- [PrevDependencyOnObject](#prevdependencyonobject)
- [Status](#status)


## Constructors Details

### AssocDependency

#### Description
Default constructor.
```text
public AssocDependency();
```

### AttachToObject

#### Description
Attaches this dependency to a given CompoundObjectId as a persistent reactor and also orders it to be at the correct position in the list of dependencies on the object, based on the dependency order(). The dependency that is being attached must not be currently attached to any object. 
When the CompoundObjectId contains multiple ids, it attaches the dependency to the CompoundObjectId::topId(), and also attaches this dependency as a persistent reactor to all the other objects that the CompoundObjectId references. 
The object may refuse dependencies being attached to it by using or deriving from AssocDependencyPE AcRx protocol extension class and attaching it to the object's AcRxClass. In this case AttachToObject() then returns [Vetoed](Autodesk_AutoCAD_Runtime_ErrorStatus.md) error status. The client code should check the returned error status and do not assume that it is always [OK](Autodesk_AutoCAD_Runtime_ErrorStatus.md).
```text
public void AttachToObject(
    CompoundObjectId compoundId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CompoundObjectId compoundId | The CompoundObjectId to attach the dependency to. If regular ObjectId is passed in, it is automatically converted to CompoundObjectId. |

### DetachFromObject

#### Description
Detaches this dependency from the DBObject it is currently attached to. It also detatches it from the list of persistent reactors of the dependent-on-object, and if the dependency is on a compound object, it detaches this dependency from the persistent reactor lists of all objects the dependency is currently attached to.
```text
public void DetachFromObject();
```

### Evaluate

#### Description
Called by the [AssocAction.EvaluateDependencies](Autodesk_AutoCAD_DatabaseServices_AssocAction_EvaluateDependencies.md)() to update the "dirty" dependencies of the action. The custom dependency classes can implement code to cache the dependent-on data in order to allow filtering-out irrelevant notifications, or do some other work. 
The Evaluate() method calls [AssocDependencyBody.EvaluateOverride](Autodesk_AutoCAD_DatabaseServices_AssocDependencyBody_EvaluateOverride.md)() to do the real work. 
If there is no owned dependency body object, the default implementation calls AssocAction.EvaluateDependency(), i.e. it delegates the work to the action that owns the dependency. The default implementation of AssocAction.EvaluateDependency() just sets the dependency status to IsUpToDateAssocStatus. This delegation can be turned off by calling [IsDelegatingToOwningAction](Autodesk_AutoCAD_DatabaseServices_AssocDependency_IsDelegatingToOwningAction.md)(false).
```text
public void Evaluate();
```

### GetDependenciesOnObject

#### Description
Gets all dependencies on the given DBObject. Dependencies are attached to DBObjects in the form of persistent reactors and are ordered on the object based on their [Order](Autodesk_AutoCAD_DatabaseServices_AssocDependency_Order.md)(). The retuned array contains the dependencies properly ordered.
```text
public static ObjectIdCollection GetDependenciesOnObject(
    DBObject dbObj, 
    [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted, 
    [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool readDependenciesWanted | Read-type dependencies wanted. |
| [MarshalAs(UnmanagedType.U1)] bool writeDependenciesWanted | Write-type dependencies wanted. |
| object | The DBObject whose dependencies are requested. The object needs to be open at least for read. |

#### Returns
Returned ObjectIds of the AssocDependencies.
### GetFirstDependencyOnObject

#### Description
Gets the first dependency on the given DBObject. Dependencies are attached to DBObjects in the form of persistent reactors and are ordered on the object based on their [Order](Autodesk_AutoCAD_DatabaseServices_AssocDependency_Order.md)(). The first dependency in this ordered list is returned.
```text
public static ObjectId GetFirstDependencyOnObject(
    DBObject dbObj
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| object | The DBObject whose first dependency is requested. The object needs to be open at least for read. |

#### Returns
The returned first dependency on the DBObject, or ObjectId::Null if there are no dependencies attached to the DBObject.
### IsDependentOnTheSameThingAs

#### Description
This method returns true if this dependency depends on exactly the same "thing" (such as on the same subentity of the same entity) as the other dependency. 
The default implementation compares the ObjectIds of the two dependent-on objects and if they are not equal, returns false. Otherwise it calls the owning action's [AssocAction.AreDependenciesOnTheSameThing](Autodesk_AutoCAD_DatabaseServices_AssocAction_AreDependenciesOnTheSameThing@AssocDependency@AssocDependency.md)(), i.e., it delegates the decision to the action that owns the dependency. This delegation can be turned off by calling [IsDelegatingToOwningAction](Autodesk_AutoCAD_DatabaseServices_AssocDependency_IsDelegatingToOwningAction.md)(false). The default implementation of AssocAction.AreDependenciesOnTheSameThing(), or if there is no delegation, returns true. returns true 
If the dependency owns an AssocDependencyBody object that overrides the IsDependentOnTheSameThingAsOverride() predicate, this predicate is called and it supersedes the default implementation.
```text
public bool IsDependentOnTheSameThingAs(
    AssocDependency otherDependency
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocDependency otherDependency | The other dependency needs to be open for read. |

#### Returns
true if both dependencies depend on exactly the same "thing". 
false if they depend on different "things".
### IsEqualTo

#### Description
Compares this dependency with the given dependency and returns true if and only if they are equal (whatever it means). Both dependencies need be open at least for read. 
The default implementation does some general tests and if they turn out that the dependencies are not equal, it returns false. Otherwise it calls the owning action's [AssocAction.AreDependenciesEqual](Autodesk_AutoCAD_DatabaseServices_AssocAction_AreDependenciesEqual@AssocDependency@AssocDependency.md)(), i.e. it delegates the decision to the action that owns the dependency. This delegation can be turned off by calling [IsDelegatingToOwningAction](Autodesk_AutoCAD_DatabaseServices_AssocDependency_IsDelegatingToOwningAction.md)(false). The default implementation of AssocAction.AreDependenciesEqual(), or if there is no delegation, returns true. 
If the dependency owns an AssocDependencyBody object that overrides the [IsEqualToOverride](Autodesk_AutoCAD_DatabaseServices_AssocActionBody_IsEqualToOverride@AssocAction.md)() predicate, this predicate is called and it supersedes the default implementation.
```text
public bool IsEqualTo(
    AssocDependency otherDependency
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocDependency otherDependency | The other dependency needs to be open for read. |

#### Returns
True if the two dependencies are equal.
### NotifyDependenciesOnObject

#### Description
Gets all dependencies on the given DBObject and notifies them about a change by setting their status. It notifies both the primary dependencies on the object (when the object is the [DependentOnObject](Autodesk_AutoCAD_DatabaseServices_AssocDependency_DependentOnObject.md)() of the dependency) as well as secondary dependencies (when the object is one of the objects in the CompoundObjectId of the dependency).
```text
public static void NotifyDependenciesOnObject(
    DBObject dbObj, 
    AssocStatus newStatus
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocStatus newStatus | The new status to be set to the dependencies. |
| object | The DBObject whose dependencies are to be notified. The object needs to be open at least for read. |

### SetDependentOnObject

#### Description
Sets the dependent-on object of this dependency to be the given CompoundObjectId. 
Unlike [AttachToObject](Autodesk_AutoCAD_DatabaseServices_AssocDependency_AttachToObject@CompoundObjectId.md)(), it does not add this dependency to the list of persistent reactors of the object. Therefore the dependency is in limbo, neither attached nor non-attached. To really attach this dependency to an object after SetDependentOnObject() has already been called with a non-null ObjectId, SetDependentOnObject() needs to be called first with a null compoundId before AttachToObject() is called. 
This method can mess-up the dependency and the client code should not have (m)any reasons to call it.
```text
public void SetDependentOnObject(
    CompoundObjectId compoundId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| CompoundObjectId compoundId | The CompoundObjectId the dependency should depend-on (may be null). |

### SetStatus

#### Description
Sets the AssocStatus of the dependency. If the status is one of the codes that indicate that the action owning the dependency will need to be evaluated (the [IsEvaluationRequest](Autodesk_AutoCAD_DatabaseServices_AssocGlobalUtility_IsEvaluationRequest@AssocStatus.md)() predicate returns true for such a status), it can also notify the action owning the dependency to change its status indicating that it needs to be evaluated. The action may change its status and notify the network owning the action. The network may change its status and notify its owning network, etc. until all the networks in the hierarchy are notified that they contain an action that needs to be evaluated. 
If the new status satisfies the [IsEvaluationRequest](Autodesk_AutoCAD_DatabaseServices_AssocGlobalUtility_IsEvaluationRequest@AssocStatus.md)() predicate and [EvaluationRequestSeverityLevel](Autodesk_AutoCAD_DatabaseServices_AssocGlobalUtility_EvaluationRequestSeverityLevel@AssocStatus.md)() of the new status is lower than the current evaluation request status of the dependency, the current higher status of the dependency is kept and not overwritten by the new lower status. Also, if the current status of the dependency satisfies the [IsToBeSkipped](Autodesk_AutoCAD_DatabaseServices_AssocGlobalUtility_IsToBeSkipped@AssocStatus.md)() predicate, it is not overwritten by any new status that [IsEvaluationRequest](Autodesk_AutoCAD_DatabaseServices_AssocGlobalUtility_IsEvaluationRequest@AssocStatus.md)(). To change the dependency status in such a case, the dependency status needs to be first changed to [IsUpToDateAssocStatus](Autodesk_AutoCAD_DatabaseServices_AssocStatus.md "AssocStatus Enumeration"), and after that it can be changed to an [IsEvaluationRequest](Autodesk_AutoCAD_DatabaseServices_AssocGlobalUtility_IsEvaluationRequest@AssocStatus.md)() status.
```text
public void SetStatus(
    AssocStatus newStatus, 
    [MarshalAs(UnmanagedType.U1)] bool notifyOwningNetwork
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AssocStatus newStatus | The new AssocStatus of the dependency. |
| notifyOwningAction | If true, and the passed-in status indicates that the dependency needs to be evaluated, the status of the AssocAction owning this dependency is set to the same status (unless the action evaluation status is already more severe than the new one). The action then notifies its owning network. |

### UpdateDependentOnObject

#### Description
Updates the object the dependency depends on, based on the information the dependency obtains from the owning action. If the dependency owns an AssocDependencyBody object, its UpdateDependentOnObject() method is called, otherwise the default implementation of this method does nothing. 
The dependency object must be opened at least for read. This method is not made "const" because it could potentially update some cache kept in the dependency, but it is not expected to do so.
```text
public void UpdateDependentOnObject();
```

### CurrentEvaluationCallback

#### Description
Gets the current AssocEvaluationCallback set by the [AssocAction.Evaluate](Autodesk_AutoCAD_DatabaseServices_AssocAction_Evaluate@AssocEvaluationCallback.md)() call, or NULL if no action evaluation is in progress. Notice that when action evaluation is in progress, there always is a non-NULL AssocEvaluationCallback.
```text
public AssocEvaluationCallback CurrentEvaluationCallback;
```

#### Conditions
Read-only
### DependencyBody

#### Description
Gets and sets the ObjectId of an object of a class derived from AssocDependencyBody, or a null id if no dependency body object has been set. The AssocDependencyBody object is owned by this AssocDependency object and implements the body of the custom dependency. See the comments at the AssocDependencyBody class for more information.
```text
public ObjectId DependencyBody;
```

#### Conditions
Read-only
### DependentOnCompoundObject

#### Description
A dependency is attached as a persistent reactors to all objects of the CompoundObjectId. If the dependency does not use CompoundObjectId, the returned CompoundObjectId is of the [DependentOnObject](Autodesk_AutoCAD_DatabaseServices_AssocDependency_DependentOnObject.md)() converted to an CompoundObjectId.
```text
public CompoundObjectId DependentOnCompoundObject;
```

#### Parameters

| Parameters | Description |
| --- | --- |
| compoundId | The CompoundObjectId, either directly kept in this dependency, or created from the DependentOnObject() ObjectId. |

#### Conditions
Read-only
### DependentOnObject

#### Description
Gets the DBObject this dependency is attached to, or ObjectId::Null if the dependency is not attached to any object. 
A dependency is attached to the dependent-on DBObject as a persistent reactor.
```text
public ObjectId DependentOnObject;
```

#### Conditions
Read-only
### DependentOnObjectStatus

#### Description
Gets the current status of the [DependentOnObject](Autodesk_AutoCAD_DatabaseServices_AssocDependency_DependentOnObject.md), can be OK, NotInitializedYet or InvalidObjectId.
```text
public Autodesk.AutoCAD.Runtime.ErrorStatus DependentOnObjectStatus;
```

#### Conditions
Read-only
### HasCachedValue

#### Description
Indicates whether the dependency currently holds the cached value of the "thing" it depends on. It does not necessarily mean that the cached value is current and the same as the current value of the dependent-on "thing". If the thing changed, the cached value the dependency holds may still be the previously cached value. But if the dependency status is IsUpToDateAssocStatus, the cached value should be in sync with the "thing" the dependency depends on. 
The default implementation of this predicate calls the owning action's [AssocAction.HasDependencyCachedValue](Autodesk_AutoCAD_DatabaseServices_AssocAction_HasDependencyCachedValue@AssocDependency.md)(), i.e., it delegates the decision to the action that owns the dependency. This delegation can be turned off by setting [IsDelegatingToOwningAction](Autodesk_AutoCAD_DatabaseServices_AssocDependency_IsDelegatingToOwningAction.md) to false. The default implementation of AssocAction.HasDependencyCachedValue(), or if there is delegation, returns false. 
If the dependency owns an AssocDependencyBody object that overrides the HasCachedValueOverride() predicate, this predicate is called and it supersedes the default implementation. 
The default value is false.
```text
public bool HasCachedValue;
```

#### Conditions
Read-only
### IsActionEvaluationInProgress

#### Description
Indicates whether the system is currently evaluating an action or a network of actions. 
Notice that when action evaluation is in progress, dependency notifications are disabled. When an object that has dependencies attached to itself is changed, the dependencies ignore this notification and consequently also do not notify the actions owning the dependencies. This is necessary because otherwise if one action evaluation modified some objects, the dependencies on these objects would be notified and the status of other actions owning these dependencies would be changed, requesting the actions to be evaluated again. This would lead to infinite loops.
```text
public bool IsActionEvaluationInProgress;
```

#### Conditions
Read-only
### IsAttachedToObject

#### Description
Indicates whether the dependency it attached to an object. 
A dependency is attached to the dependent-on DBObject as a persistent reactor, but it may also not be attached to any object. In this case [AssocDependency.DependentOnObject](Autodesk_AutoCAD_DatabaseServices_AssocDependency_DependentOnObject.md)() returns ObjectId::Null.
```text
public bool IsAttachedToObject;
```

#### Conditions
Read-only
### IsDelegatingToOwningAction

#### Description
Gets and sets whether some dependency methods delegate to the action that owns the dependency if the method is not directly implemented in the dependency or in the AssocDependencyBody object that the dependency may own. The default is true, i.e., the delegation takes place. Examples of dependency methods that perform the delegation to the owning action are methods like [IsRelevantChange](Autodesk_AutoCAD_DatabaseServices_AssocDependency_IsRelevantChange.md)(), [HasCachedValue](Autodesk_AutoCAD_DatabaseServices_AssocDependency_HasCachedValue.md)(), IsEqualTo(), [IsDependentOnTheSameThingAs](Autodesk_AutoCAD_DatabaseServices_AssocDependency_IsDependentOnTheSameThingAs@AssocDependency.md)(), Evaluate(), etc. 
The reason for this delegation is to give developers of custom actions more freedom in their choice where to keep the data related to the dependencies owned by their custom actions, and to reduce the need to derive new dependency body classes. 
The default is yes, i.e., the dependencies do delegate.
```text
public bool IsDelegatingToOwningAction;
```

#### Conditions
Read / write
### IsDependentOnCompoundObject

#### Description
Indicates whether the dependency is using CompoundObjectId to depend on the dependent-on-object.
```text
public bool IsDependentOnCompoundObject;
```

#### Conditions
Read-only
### IsDependentOnObjectReadOnly

#### Description
Indicates whether the dependent on object is read-only, i.e., the object is not allowed to be changed. The default implementation returns true if the dependent-on object is an Entity on locked layer, otherwise it returns false.
```text
public bool IsDependentOnObjectReadOnly;
```

#### Conditions
Read-only
### IsObjectStateDependent

#### Description
Sets and gets whether the AssocAction owning the dependency requires the dependent-on DBObject to be in the expected "object state" with respect to the list of dependencies on the object, before the action can be evaluated. 
It means actions that own write-type dependencies on the object that precede this dependency in the list of all dependencies on the object need to be evaluated, and actions owning write-type dependencies on the object that follow this dependency in the list must not be evaluated. This also means the object is in the object state just after evaluation of the immediately preceding action that modified the object but before evaluation of the next action that would modify the object again and bring it to the next object state. 
The default value of this flag is true.
```text
public bool IsObjectStateDependent;
```

#### Conditions
Read / write
### IsReadDependency

#### Description
Sets and gets the IsReadDependency property. True indicates the AssocAction owning the dependency uses the value of the dependent-on DBObject.The default value is false. 
```text
public bool IsReadDependency;
```

#### Conditions
Read / write
### IsRelevantChange

#### Description
This property indicates whether the dependent-on "thing" really changed in such a way that the change is relevant to this particular dependency type. For example, if the dependency is on a subentity of a geometric entity, it should check whether the geometry of this subentity is really different from what it was before (such as by comparing it with the cached geometry). 
Using this property makes it possible to filter-out false or irrelevant change notifications and thus avoid unnecessary action reevaluations. When this property is false, the change notification from the dependent-on object is ignored and the status of this dependency is not changed. 
The default implementation of this property returns the owning action's [AssocAction.IsRelevantDependencyChange](Autodesk_AutoCAD_DatabaseServices_AssocAction_IsRelevantDependencyChange@AssocDependency.md)() property, i.e., it delegates the decision to the action that owns the dependency. This delegation can be turned off by setting IsDelegatingToOwningAction to false. The default implementation of AssocAction::IsRelevantDependencyChange(), or if there is no delegation, returns true. 
If the dependency owns an AssocDependencyBody object that overrides the IsRelevantChangeOverride property, this property is accessed and it supersedes the default implementation.
```text
public bool IsRelevantChange;
```

#### Conditions
Read-only
### IsWriteDependency

#### Description
Sets and gets the IsWriteDependency property. True indicates the AssocAction owning the dependency changes the value of the dependent-on DBObject.The default value of this flag is false. 
```text
public bool IsWriteDependency;
```

#### Conditions
Read / write
### NextDependencyOnObject

#### Description
Gets the next dependency in the list of dependencies of an DBObject or ObjectId::Null if it is the last dependency in the list. 
All dependencies attached to the same DBObject are kept in a doubly-linked list. The order in the list is determined by the Order() property of the dependencies in the list.
```text
public ObjectId NextDependencyOnObject;
```

#### Conditions
Read-only
### Order

#### Description
Gets and sets the order of the dependency, i.e., the order where it should be positioned in the list of all dependencies on an DBObject. Dependencies with lower Order() are positioned in the list before the dependencies with higher Order(). Dependencies with the same Order() are ordered based on how they were added to the object, the dependencies added later are positioned after the dependencies added earlier. 
Notice that if a dependency has already been attached to an object AttachToObject(), Order() does not reposition the dependency in the list and should not be set. 
Default value of this data member is 0. 
```text
public int Order;
```

#### Conditions
Read / write
### OwningAction

#### Description
Gets and sets the owning AssocAction. 
Every dependency is owned (in the logical as well as in the AutoCAD database sense) by an AssocAction. 
Every dependency is owned (in the logical as well as in the AutoCAD database sense) by an AssocAction. 
This property should not be set directly; [AssocAction.AddDependency](Autodesk_AutoCAD_DatabaseServices_AssocAction_AddDependency@ObjectId@\[MarshalAsUnmanagedType_U1\]_bool.md)() and [AssocAction.RemoveDependency](Autodesk_AutoCAD_DatabaseServices_AssocAction_RemoveDependency@ObjectId@\[MarshalAsUnmanagedType_U1\]_bool.md)() should be used. 
```text
public ObjectId OwningAction;
```

#### Conditions
Read / write
### PrevDependencyOnObject

#### Description
Gets the previous dependency in the list of dependencies of an DBObject or ObjectId::Null if it is the first dependency in the list. 
All dependencies attached to the same DBObject are kept in a doubly-linked list. The order in the list is determied by the Order() property of the dependencies in the list.
```text
public ObjectId PrevDependencyOnObject;
```

#### Conditions
Read-only
### Status

#### Description
Gets and sets the current AssocStatus of this dependency.
```text
public AssocStatus Status;
```

#### Conditions
Read / write