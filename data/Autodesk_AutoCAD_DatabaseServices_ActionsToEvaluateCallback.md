# ActionsToEvaluateCallback Class

## Overview

#### Description
AcDbActionsToEvaluateCallback Wrapper This callback is used by AssocAction::getDependentActionsToEvaluate() method to inform about other actions, dependencies or arbitrary objects that should also be evaluated because they depend on the given action that is to be evaluated.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ActionsToEvaluateCallback
```

```text
public abstract class ActionsToEvaluateCallback : IDisposable;
```

### Constructors

- [ActionsToEvaluateCallback](#actionstoevaluatecallback)

### Methods

- [NeedsToEvaluate](#needstoevaluate)


## Constructors Details

### ActionsToEvaluateCallback

#### Description
Default constructor.
```text
public ActionsToEvaluateCallback();
```

### NeedsToEvaluate

#### Description
This callback method is called by AssocAction::getDependentActionsToEvaluate(). It is a mechanism by which getDependentActionsToEvaluate() informs that an AssocAction, AssocDependency, or an DBObject needs to be evaluated and suggests new status for them that the callback implementation should set. If the given ObjectId is not of an action or of a dependency, but of an arbitrary DBObject, the callback implementation should simply recursively call needsToEvaluate() for all dependencies on that object. 
This callback does not need to be implemented by the client code. The Associative Framework evaluation mechanism provides a default implementation that it uses when calculating a transitive closure of all actions that need to be evaluated.
```text
public abstract void NeedsToEvaluate(
    ObjectId objectId, 
    AssocStatus newStatus, 
    [MarshalAs(UnmanagedType.U1)] bool ownedActionsAlso
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId objectId | ObjectId of an AssocAction, AssocDependency or an arbitrary DBObject that needs to be evaluated. |
| AssocStatus newStatus | The new evaluation request status of the action or dependency. If it is not an evaluation request, the needsToEvaluate() implementation should not change the status of the action or dependency. |
| [MarshalAs(UnmanagedType.U1)] bool ownedActionsAlso | If the action that needs to evaluate is an AssocNetwork, this argument controls whether all the actions owned by the network also need to be evaluated. The caller usually passes true. |
