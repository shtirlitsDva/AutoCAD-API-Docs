# AssocEvaluationCallback Class

## Overview

#### Description
This wraps the ObjectARX AcDbAssocEvaluationCallback class. 
A mechanism for AssocActions to notify about the progress of evaluation, to report success or failure, notify about which objects the action is going to use and modify, to allow the evaluation to be cancelled by the client, etc. 
Pointer to an object of AssocEvaluationCallback class in a mandatory argument to the AssocAction.Evaluate() method. AssocManager manages an ordered collection of global AssocEvaluationCallbacks grouped in an AssocEvaluationMultiCallback. AssocManager.EvaluateTopLevelNetwork() passes this multi-callback to the AssocAction.Evaluate() method of the top-level network.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocEvaluationCallback
```

```text
public abstract class AssocEvaluationCallback : IDisposable;
```

### Constructors

- [AssocEvaluationCallback](#assocevaluationcallback)

### Methods

- [BeginActionEvaluation](#beginactionevaluation)
- [BeginActionEvaluationUsingObject](#beginactionevaluationusingobject)
- [CancelActionEvaluation](#cancelactionevaluation)
- [DraggingState](#draggingstate)
- [EndActionEvaluation](#endactionevaluation)
- [EndActionEvaluationUsingObject](#endactionevaluationusingobject)
- [EvaluationMode](#evaluationmode)
- [GetTransformationType](#gettransformationtype)
- [SetActionEvaluationErrorStatus(AssocAction, Autodesk.AutoCAD.Runtime.ErrorStatus)](#setactionevaluationerrorstatus(assocaction,-autodesk.autocad.runtime.errorstatus))
- [SetActionEvaluationErrorStatus(AssocAction, Autodesk.AutoCAD.Runtime.ErrorStatus, ObjectId, DBObject, IntPtr)](#setactionevaluationerrorstatus(assocaction,-autodesk.autocad.runtime.errorstatus,-objectid,-dbobject,-intptr))


## Constructors Details

### AssocEvaluationCallback

#### Description
Default constructor.
```text
public AssocEvaluationCallback();
```

### BeginActionEvaluation

#### Description
The action informs that it is starting its evaluation. This callback is issued at the beginning of AssocAction.Evaluate() call and should not be issued from the individual EvaluateOverride() method calls. The action is open for write when this callback is issued.
```text
public abstract void BeginActionEvaluation(
    AssocAction action
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocAction action | The action that is being evaluated. |

### BeginActionEvaluationUsingObject

#### Description
The action informs that it is going to use or modify an DBObject. The action issues this callback just before it opens the object for read or write. 
The custom evaluation callback code may pass back a pointer to a substitute DBObject. If it happens, the action should use or modify this substitute object instead of the original object. The substitute object is expected to already be correctly open for read or write (if it is a database-resident object), the action does not need to open or close it. Also, the substitute object may possibly be a non-database-resident object and the action should be ok with it. 
This allows the custom evaluation callback code to redirect the action evaluation to use or modify other objects than the action depends on. A common example is dragging, when the action may be redirected to use and modify temporary non-database resident clones of the original objects. The custom evaluation callback code creates non-database resident clones of any relevant Enities when notified by the action that the action is going to modify them, and the action then modifies these temporary clones. The modified clones are then drawn and discarded, the original objects remain untouched.
```text
public abstract void BeginActionEvaluationUsingObject(
    AssocAction pAction, 
    ObjectId objectId, 
    [MarshalAs(UnmanagedType.U1)] bool objectIsGoingToBeUsed, 
    [MarshalAs(UnmanagedType.U1)] bool objectIsGoingToBeModified, 
    DBObject substituteObject
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId objectId | The DBObject that is going to be used or modified by the action. |
| [MarshalAs(UnmanagedType.U1)] bool objectIsGoingToBeUsed | The object contents is going to be used. |
| [MarshalAs(UnmanagedType.U1)] bool objectIsGoingToBeModified | The object contents is going to be modified. |
| DBObject substituteObject | An DBObject optionally provided by the custom evaluation callback code. The custom evaluation callback code should not assign NULL to this output argument if it does not want to provide a substitute object. It should only assign a non-NULL pointer if it intends to provide a substitute object. |
| action | The action that is being evaluated. |

### CancelActionEvaluation

#### Description
The custom evaluation callback code can request that the action evaluation should be cancelled by implementing this callback predicate. The AssocAction.Evaluate() method checks this predicate just after issuing the BeginActionEvaluation() callback, i.e. just before the action EvaluateOverride() method is called. If a whole associative network is evaluated, this predicate is also checked after evaluating each action in the network to see if the network evaluation should continue. Custom actions can freely add their own calls to check this predicate, particularly if the action evaluation is time consuming. 
Once this predicate returns true, requesting the evaluation to be canceled, it should keep returning true, to make sure the evaluation of the whole associative network is canceled. 
When the evaluation is canceled, the status of the not-yet evaluated actions/networks stays unchanged. The status of the actions/networks that have already been evaluated also stays unchanged, i.e. there is no roll-back of the already made changes. 
This predicate should be used to cancel the evaluation of the whole associative network, not to selectively control the evaluation of the individual actions. To selectively enable/disable the evaluation of individual actions, the BeginActionEvaluation() callback can be used. Inside this callback the client code can change the status of the action being evaluated to a status that is not an evaluation request, such as change it to SuppressedAssocStatus, FailedToEvaluateAssocStatus, IsUpToDateAssocStatus, and the action is then not going to be evaluated.
```text
public abstract bool CancelActionEvaluation();
```

#### Returns
Returns true if the evaluation should be cancelled.
### DraggingState

#### Description
The action may inquire of the client code whether the evaluation is happening from inside of the dragging loop and at which stage the dragging is. The custom evaluation callback code may provide this information by implementing this callback.
```text
public virtual AssocDraggingState DraggingState();
```

#### Returns
Returns the dragging state.
### EndActionEvaluation

#### Description
The action informs that it has finished its evaluation. This callback is issued at the end of AssocAction.Evaluate() call and should not be issued from the individual Evaluate() method calls. The action is open for write when this callback is issued.
```text
public abstract void EndActionEvaluation(
    AssocAction action
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocAction action | The action that is being evaluated. |

### EndActionEvaluationUsingObject

#### Description
The action informs that it is done with using or modifying a DBObject. The action issues this callback just before it closes the object. If the object is a substitute object provided by the client code, the action does not close it.
```text
public abstract void EndActionEvaluationUsingObject(
    AssocAction action, 
    ObjectId objectId, 
    DBObject obj
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocAction action | The action that is being evaluated. |
| ObjectId objectId | The same DBObjectId that has been previously passed to the matching BeginActionEvaluationUsingObject() callback. |
| object | The object that has been used or modified by the action. It may be NULL if the original object couldn't be opened or if the substitute object was not of the expected type. |

### EvaluationMode

#### Description
The action needs to call this method at the beginning of the Evaluate() code to obtain the mode in which it should evaluate itself. The default implementation returns [ModifyObjectsAssocEvaluationMode](Autodesk_AutoCAD_DatabaseServices_AssocEvaluationMode.md "AssocEvaluationMode Enumeration").
```text
public virtual AssocEvaluationMode EvaluationMode();
```

#### Returns
The requested evaluation mode.
### GetTransformationType

#### Description
Allows the custom evaluation callback code to pass information about what type of transformation (which AutoCAD command) has been performed with the entities prior to action evaluation. The default implementation returns NotSpecified.
```text
public virtual AssocTransformationType GetTransformationType();
```

#### Returns
[AssocTransformationType](Autodesk_AutoCAD_DatabaseServices_AssocTransformationType.md "AssocTransformationType Enumeration").
### SetActionEvaluationErrorStatus(AssocAction, Autodesk.AutoCAD.Runtime.ErrorStatus)

#### Description
The action informs that an error happened during its evaluation. It does not need to inform if no error happened.
```text
public void SetActionEvaluationErrorStatus(
    AssocAction action, 
    Autodesk.AutoCAD.Runtime.ErrorStatus errorStatus
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocAction action | The action that is being evaluated. |
| Autodesk.AutoCAD.Runtime.ErrorStatus errorStatus | Action evaluation error status. |

### SetActionEvaluationErrorStatus(AssocAction, Autodesk.AutoCAD.Runtime.ErrorStatus, ObjectId, DBObject, IntPtr)

#### Description
The action informs that an error happened during its evaluation. It does not need to inform if no error happened. The action may also inform about which object caused the failure, giving its id, pointer or both, and provide arbitrary additional info.
```text
public abstract void SetActionEvaluationErrorStatus(
    AssocAction action, 
    Autodesk.AutoCAD.Runtime.ErrorStatus errorStatus, 
    ObjectId objectId, 
    DBObject obj, 
    IntPtr errorInfo
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AssocAction action | The action that is being evaluated. |
| Autodesk.AutoCAD.Runtime.ErrorStatus errorStatus | Action evaluation error status. |
| ObjectId objectId | The failed object id (such as of an AssocDependency). |
| IntPtr errorInfo | Additional info about the error. |
| object | The failed object pointer (such as of an AssocDependency). |
