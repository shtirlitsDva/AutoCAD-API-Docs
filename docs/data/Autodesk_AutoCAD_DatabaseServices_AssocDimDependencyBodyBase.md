# AssocDimDependencyBodyBase Class

## Overview

#### Description
AssocDimDependencyBodyBase ties together the following objects that define a dimensional constraint: 
AssocVariable Keeps dimensional constraint name and expression. Assoc2dConstraintGroup Keeps AcExplicitConstraint. Entity (such as Dimension) Graphical representation of the dimensional constraint. 
AssocDimDependencyBodyBase class represents a dependency of an ExplicitConstraint owned by an Assoc2dConstraintGroup, on an Entity that is the graphical representation of the dimensional constraint. AssocDimDependencyBodyBase is an abstract base class, there are concrete derived classes (such as AssocDimDependencyBody) that deal with concrete entity types (such as Dimension) that are used as graphical representations of dimensional constraints. 
The AssocDimDependencyBodyBase does all the work of managing the graphical entity, receiving notifications about entity text changes, updating the entity text and entity positioning, keeping the entity text in sync with the AssocVariable, and keeping it in sync with the corresponding ExplicitConstraint in Assoc2dConstraintGroup. 
There always is a corresponding AssocVariable that keeps the name, expression and value of the dimensional constraint and is also referenced by the ExplicitConstraint via AssocValueDependency. The AssocDimDependencyBodyBase obtains the corresponding AssocVariable by going up to the Assoc2dConstraintGroup that owns the AssocDimDependencyBody, finds the ExplicitConstraint that references this dependency, obtains the AssocValueDependency and obtains the object it depends on, which is the corresponding AssocVariable.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocDependencyBody
        Autodesk.AutoCAD.DatabaseServices.AssocDimDependencyBodyBase
            Autodesk.AutoCAD.DatabaseServices.AssocDimDependencyBody
```

```text
public abstract class AssocDimDependencyBodyBase : AssocDependencyBody;
```

### Methods

- [ComposeEntityText](#composeentitytext)
- [Constraint](#constraint)
- [DeactivateConstraint](#deactivateconstraint)
- [DragStatus](#dragstatus)
- [DwgInFields](#dwginfields)
- [DwgOutFields](#dwgoutfields)
- [DxfInFields](#dxfinfields)
- [DxfOutFields](#dxfoutfields)
- [EntityAttachmentPointMoved](#entityattachmentpointmoved)
- [ErasedOverride](#erasedoverride)
- [EvaluateOverride](#evaluateoverride)
- [FormatToCurrentPrecision](#formattocurrentprecision)
- [GetEntityNameAndExpression](#getentitynameandexpression)
- [GetEraseDimensionIfDependencyIsErased](#geterasedimensionifdependencyiserased)
- [GetFromEntity](#getfromentity)
- [GetNameAndExpressionFromEntityText](#getnameandexpressionfromentitytext)
- [GetSubentityGeoms](#getsubentitygeoms)
- [GetVariableNameAndExpression](#getvariablenameandexpression)
- [ModifiedOverride](#modifiedoverride)
- [NotificationIgnorerDotNet.IsIgnoringNotifications](#notificationignorerdotnet.isignoringnotifications)
- [ReactivateConstraint](#reactivateconstraint)
- [SetEntityNameAndExpression](#setentitynameandexpression)
- [SetEraseDimensionIfDependencyIsErased](#seterasedimensionifdependencyiserased)
- [SetNameAndExpression](#setnameandexpression)
- [SetVariableNameAndExpression](#setvariablenameandexpression)
- [SetVariableValueToMeasuredValue](#setvariablevaluetomeasuredvalue)
- [SubErase](#suberase)
- [UpdateDependentOnObjectOverride](#updatedependentonobjectoverride)
- [ValidateEntityText](#validateentitytext)

### Other

- [NotificationIgnorerDotNet Class](#notificationignorerdotnet-class)

### Properties

- [ConstrainedGeoms](#constrainedgeoms)
- [EntityMeasurementOverride](#entitymeasurementoverride)
- [EntityTextOverride](#entitytextoverride)
- [GetCurrentlyUsedEntityNameFormat](#getcurrentlyusedentitynameformat)
- [GetMeasuredValue](#getmeasuredvalue)
- [IsConstraintActive](#isconstraintactive)
- [IsEntityAttachmentChangedOverride](#isentityattachmentchangedoverride)
- [IsReferenceOnly](#isreferenceonly)
- [IsRelevantChangeOverride](#isrelevantchangeoverride)
- [SubentityConstrainedGeoms](#subentityconstrainedgeoms)
- [Variable](#variable)


## Methods Details

### ComposeEntityText

#### Description
Composes the text that the managed entity should display. The text is composed from the corresponding AssocVariable name, expression and/or value. The text formatting follows requiredNameFormat.
```text
public string ComposeEntityText(
    int requiredNameFormat
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int requiredNameFormat | The constraint name format display, deafault value if -1. If requiredNameFormat == -1, CONSTRAINTNAMEFORMAT sysvar is used for choosing the text format. |

### Constraint

#### Description
Returns the corresponding dimensional constraint node.
```text
public ExplicitConstraint Constraint();
```

#### Returns
The dimensional constraint node.
### DeactivateConstraint

#### Description
Deactivates the constraint. 
Deactivating a constraint means still keeping the ExplicitConstraint in the Assoc2dConstraintGroup but removing its d_node or r_node from the DCM dimension system.
```text
public void DeactivateConstraint();
```

### DragStatus

#### Description
This function should be called when dependent object grips are dragged.
```text
public void DragStatus(
    Autodesk.AutoCAD.DatabaseServices.DragStatus status
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.DragStatus status | The current DragStatus. |

### DwgInFields

#### Description
The standard filing protocol.
```text
public override Autodesk.AutoCAD.Runtime.ErrorStatus DwgInFields(
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
public override Autodesk.AutoCAD.Runtime.ErrorStatus DwgOutFields(
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
public override Autodesk.AutoCAD.Runtime.ErrorStatus DxfInFields(
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
public override Autodesk.AutoCAD.Runtime.ErrorStatus DxfOutFields(
    DxfFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DxfFiler filer | The filer to read the object data to. |

### EntityAttachmentPointMoved

#### Description
Updates the constraint geometry when dimension grip points are moved. Any move made through triangular grip should move the constraint geometry by the same amount and update the constraint variable value. Clients of this function need to pass new positions of the dimension attachment in SubentGeometry array, and new dimension measurement. This API performs the following operations:
  1. Moves the constraint geometry sub entity by the same amount the dimension grip point has been moved.
  2. Moves the constrained geometry at the opposite end of the dimensional constraint by identity transform. This is a hint to DCM not to move the opposite end of the dimensional constraint.
  3. Updates the constraint variable value with new measurement.

```text
public void EntityAttachmentPointMoved(
    SubentityGeometry\[\] newAttachedGeometries, 
    double measurement
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| SubentityGeometry[] newAttachedGeometries | The new attached geometries to be updated. |
| double measurement | New measurement, default value is 0.0. |

### ErasedOverride

#### Description
When the dependent-on object (such as an Dimension) is erased, the corresponding AssocVariable is also erased.
#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool isErasing | Boolean isErasing. |
| pDbObj | The controlled entity. |

Previous Declaration
```text
public override void ErasedOverride(
DBObject dbObj,
int isErasing
);
```

### EvaluateOverride

#### Description
This function sets the name and expression in the controlled entity text to be the same as the name and expression of the corresponding AssocVariable.
```text
public override void EvaluateOverride();
```

### FormatToCurrentPrecision

#### Description
Formats the given expression to current precision.
```text
public static string FormatToCurrentPrecision(
    string expression, 
    [MarshalAs(UnmanagedType.U1)] bool isAngular
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string expression | The expression to be formatted. |
| [MarshalAs(UnmanagedType.U1)] bool isAngular | Indicates it is an angular constraint. |

#### Returns
The formatted expression.
### GetEntityNameAndExpression

#### Description
Returns name and expression from the text that the managed entity is displaying.
```text
public void GetEntityNameAndExpression(
    ref string name, 
    ref string expression
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ref string name | Name from the managed entity display text. |
| ref string expression | Expression from the managed entity display text. |

### GetEraseDimensionIfDependencyIsErased

#### Description
Under normal circumstances an associated Dimension object is erased if the AssocDimDependencyBodyBase is erased. This static method returns true iff this behavior is suppressed , i.e. not erasing the Dimension if the AssocDimDependencyBodyBase is erased.
```text
public static bool GetEraseDimensionIfDependencyIsErased();
```

#### Returns
Returns whether the behavior is surpressed or not.
### GetFromEntity

#### Description
Gets the AssocDimDependencyBodyBase from the dependent-on Entity, such as from the AcDbDimension it controls. If the entity does not have an AssocDimDependencyBodyBase attached, ObjectId.Null is returned.
```text
public static ObjectId GetFromEntity(
    ObjectId entityId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId entityId | The entity id of the dependent-on Entity, such as of an Dimension. |

#### Returns
The returned ObjectId of the AssocDimDependencyBodyBase, or ObjectId.Null if none found.
### GetNameAndExpressionFromEntityText

#### Description
Parses the given entityText string and extracts name and expression components from it. It is mainly for internal use.
```text
public static void GetNameAndExpressionFromEntityText(
    string entityText, 
    [MarshalAs(UnmanagedType.U1)] bool useMeasurementIfNoText, 
    double measurement, 
    [MarshalAs(UnmanagedType.U1)] bool isAngular, 
    ref string name, 
    ref string expression
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string entityText | The string to extract name and expression from. |
| [MarshalAs(UnmanagedType.U1)] bool useMeasurementIfNoText | Indicates whether to use measurement value if no text is given. |
| double measurement | The provided entity measurement. |
| [MarshalAs(UnmanagedType.U1)] bool isAngular | Indicates that the constraint is angular. |
| ref string name | Name component extracted from entityText. |
| ref string expression | Expression component extracted from entityText. |

### GetSubentityGeoms

#### Description
Returns all constrained subentities of Entities constrained by this dimensional constraint.
```text
public SubentityGeometry\[\] GetSubentityGeoms(
    Vector3d distanceDirection
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vector3d distanceDirection | Direction of the distance constraint. |

#### Returns
All constrained subentities of Entities constrained by this dimensional constraint.
### GetVariableNameAndExpression

#### Description
Returns name, expression and current value of the AssocVariable that corresponds to this dimensional constraint.
```text
public void GetVariableNameAndExpression(
    ref string name, 
    ref string expression, 
    string value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ref string name | Variable name. |
| ref string expression | Variable expression. |
| string value | Variable value. |

### ModifiedOverride

#### Description
If the controlled entity text changed, this function sets the name and expression of the AssocVariable to be the same as the name and expression in the entity text.
```text
public override void ModifiedOverride(
    DBObject dbObj
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DBObject dbObj | The controlled entity. |

### NotificationIgnorerDotNet.IsIgnoringNotifications

#### Description
Returns true if notifications are ignored.
```text
public static bool IsIgnoringNotifications();
```

#### Returns
Returns whether notifications are ignored.
### ReactivateConstraint

#### Description
Reactivates the constraint. Reactivating a constraint means creating a d_node or r_node for this ExplicitConstraint and adding it to the DCM dimension system.
```text
public void ReactivateConstraint();
```

### SetEntityNameAndExpression

#### Description
Sets name and expression that the managed entity should display. Either name or expression may be empty strings which indicates not to change them.
```text
public void SetEntityNameAndExpression(
    string name, 
    string expression, 
    string value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | New name the managed entity should display. |
| string expression | New expression the managed entity should display. |
| string value | New value the managed entity should display. |

### SetEraseDimensionIfDependencyIsErased

#### Description
Under normal circumstances the controlled Dimension object is erased if the AssocDimDependencyBodyBase is erased. This static method allows this behaviorto be suppressed, i.e., not erasing the Dimension if the AssocDimDependencyBodyBase is erased. This can be useful for the creation of reference constraints since the same dimension should be retained and used for a reference constraint later on.
```text
public static bool SetEraseDimensionIfDependencyIsErased(
    [MarshalAs(UnmanagedType.U1)] bool yesNo
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool yesNo | Indicates to suppress the erase behavior or not. |

#### Returns
Returns whether the behavior is suppressed or not.
### SetNameAndExpression

#### Description
Sets name and expression on both the AssocVariable that corresponds to this dimensional constraint and on the managed entity that serves as the graphical representation of this dimensional constraint. Either name or expression may be empty strings which indicates no change.
```text
public void SetNameAndExpression(
    string name, 
    string expression
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | New name to be set. |
| string expression | New expression to be set. |

### SetVariableNameAndExpression

#### Description
Sets new name and expression of the AssocVariable that corresponds to this dimensional constraint. Either name or expression may be empty strings which indicates no change.
```text
public void SetVariableNameAndExpression(
    string name, 
    string expression
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | New name of the AssocVariable. |
| string expression | New expression of the AssocVariable. |

### SetVariableValueToMeasuredValue

#### Description
Measures the current dimensional constraint based on the current positions and sizes of the constrained geometries and sets the corresponding AssocVariable to this measured value. If the dimensional constraint is satisfied, the AssocVariable value will already be equal to the measured value and no setting is needed, and nothing happens. Notice that if AssocVariable contained an expression, it will be erased and the variable will just contain a numerical value, not an expression.
```text
public void SetVariableValueToMeasuredValue();
```

### SubErase

#### Description
Overridden method from the DBObject base class. It erases the controlled entity, such as the Dimension.
#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool erasing | Boolean erasing. |

#### Returns
OK if successful.
Previous Declaration
```text
public virtual void SubErase(
int erasing
);
```

### UpdateDependentOnObjectOverride

#### Description
This method needs to be overriden and implemented by derived classes. It updates the controlled entity position, size and orientation. The base class implementation just handles reference dimensions that are not dimensional constraints. This method updates the corresponding AssocVariable with the current measured value of the dimension and updates the entity text with the current measurement.
```text
public override void UpdateDependentOnObjectOverride();
```

### ValidateEntityText

#### Description
Checks if the given entityTextToValidate can be used as the text the managed entity displays. Either the name or the expression part of the entityTextToValidate text may be empty which means that the current name/expression should be used.
```text
public string ValidateEntityText(
    string entityTextToValidate
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string entityTextToValidate | The entity text to check. |

#### Returns
The error message if any errors.
### NotificationIgnorerDotNet Class

#### Description
This class is for internal use only. It disables notifications when the dependency is not yet fully setup and these notifications would complain about the data being in inconsistent state.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocDimDependencyBodyBase.NotificationIgnorerDotNet
```

```text
public class NotificationIgnorerDotNet;
```

### ConstrainedGeoms

#### Description
Gets all ConstrainedGeometries constrained by this dimensional constraint.
```text
public ConstrainedGeometry ConstrainedGeoms;
```

#### Conditions
Read-only
### EntityMeasurementOverride

#### Description
Derived classes needs to override this pure virtual read only property to provide the current measurement of the entity they manage.
```text
public abstract double EntityMeasurementOverride;
```

#### Conditions
Read-only
### EntityTextOverride

#### Description
Derived classes needs to override this pure virtual property. This is how they provide the text of the entity they manage.
```text
public abstract string EntityTextOverride;
```

#### Conditions
Read / write
### GetCurrentlyUsedEntityNameFormat

#### Description
Gets the format that is used to display the entity name and expression by looking at the currently displayed entity text. See CONSTRAINTNAMEFORMAT sysvar for the possible format values.
```text
public int GetCurrentlyUsedEntityNameFormat;
```

#### Conditions
Read-only
### GetMeasuredValue

#### Description
Gets the current dimensional constraint based on the current positions and sizes of the constrained geometries. If the dimensional constraint is satisfied, the AssocVariable value will already be equal to the measured value.
```text
public double GetMeasuredValue;
```

#### Conditions
Read-only
### IsConstraintActive

#### Description
Indicates whether the constraint is active.
```text
public bool IsConstraintActive;
```

#### Conditions
Read-only
### IsEntityAttachmentChangedOverride

#### Description
Derived classes need to override this pure virtual read only property to inform whether the attachment of the entity they manage changed, such as whether the entity has been repositioned.
```text
public abstract bool IsEntityAttachmentChangedOverride;
```

#### Conditions
Read-only
### IsReferenceOnly

#### Description
Sets whether the constraint is reference only. A reference "constraint" keeps updating its AssocVariable and the dimension text with the measured value of the dimension, but it does not function as a dimensional constraint.
```text
public bool IsReferenceOnly;
```

#### Conditions
Write-only
### IsRelevantChangeOverride

#### Description
Overridden property from AssocDependencyBody base class. 
Indicates whether one of the following occurred: 
  * Entity text changed in any way
  * Name or expression of the corresponding AssocVariable are different from name or expression in the controlled entity
  * Entity attachment changed.

```text
public override bool IsRelevantChangeOverride;
```

#### Conditions
Read-only
### SubentityConstrainedGeoms

#### Description
Gets all constrained subentities of Entities constrained by this dimensional constraint.
```text
public FullSubentityPath SubentityConstrainedGeoms;
```

#### Conditions
Read-only
### Variable

#### Description
Gets the object id of the corresponding AssocVariable.
```text
public ObjectId Variable;
```

#### Conditions
Read-only