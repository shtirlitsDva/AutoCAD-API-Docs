# AssocDimDependencyBody Class

## Overview

#### Description
Wrapper AssocDimDependencyBody manages a Dimension entity that serves as the graphical representation of a dimensional constraint. It inherits common functionality from the AssocDimDependencyBodyBase class and overrides the base-class pure virtual methods in which it implements the Dimension-specific functionality.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocDependencyBody
        Autodesk.AutoCAD.DatabaseServices.AssocDimDependencyBodyBase
            Autodesk.AutoCAD.DatabaseServices.AssocDimDependencyBody
```

```text
public class AssocDimDependencyBody : AssocDimDependencyBodyBase;
```

### Constructors

- [AssocDimDependencyBody](#assocdimdependencybody)

### Methods

- [CreateAndPostToDatabase](#createandposttodatabase)
- [UpdateDependentOnObjectOverride](#updatedependentonobjectoverride)

### Properties

- [EntityMeasurementOverride](#entitymeasurementoverride)
- [EntityTextOverride](#entitytextoverride)
- [IsEntityAttachmentChangedOverride](#isentityattachmentchangedoverride)


## Constructors Details

### AssocDimDependencyBody

#### Description
Default constructor.
```text
public AssocDimDependencyBody();
```

### CreateAndPostToDatabase

#### Description
"Pseudo constructor". Creates a new AssocDependency object owning a new AssocDimDependencyBody object and makes the dependent-on object of the new dependency to be the provided Dimension. Posts both objects to the database of the Dimension.
```text
public static void CreateAndPostToDatabase(
    ObjectId dimId, 
    ref ObjectId dimDepId, 
    ref ObjectId dimDepBodyId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId dimId | ObjectId of the Dimension. |
| ref ObjectId dimDepId | ObjectId of the created AssocDependency. |
| ref ObjectId dimDepBodyId | ObjectId of the created AssocDimDependencyBody. |

### UpdateDependentOnObjectOverride

#### Description
Updates position, size and orientation of the controlled Dimension.
```text
public override void UpdateDependentOnObjectOverride();
```

### EntityMeasurementOverride

#### Description
Gets the measurement from the controlled Dimension.
```text
public override double EntityMeasurementOverride;
```

#### Conditions
Read-only
### EntityTextOverride

#### Description
Gets and sets the text of the controlled Dimension. 
```text
public override string EntityTextOverride;
```

#### Conditions
Read / write
### IsEntityAttachmentChangedOverride

#### Description
Indicates whether the attachment of the controlled Dimension changed, such as the Dimension has been repositioned.
```text
public override bool IsEntityAttachmentChangedOverride;
```

#### Conditions
Read-only