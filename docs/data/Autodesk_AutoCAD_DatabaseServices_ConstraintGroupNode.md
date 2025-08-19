# ConstraintGroupNode Class

## Overview

#### Description
This class represents a node owned by Assoc2dConstraintGroup. Usually a node is connected with multiple other nodes and the connection between two nodes is not directed. 
A ConstraintGroupNode object should always be created and deleted through higher level APIs and the memory pointed by it is internal held and should never be released by user directly.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
    Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint
    Autodesk.AutoCAD.DatabaseServices.HelpParameter
```

```text
public class ConstraintGroupNode : RXObject;
```

### Properties

- [NodeId](#nodeid)
- [OwningConstraintGroupId](#owningconstraintgroupid)


## Properties Details

### NodeId

#### Description
Gets the node id of the ConstraintGroupNode. 
Every ConstraintGroupNode object in a Assoc2dConstraintGroup has a unique node id which may be cached by the client applications.
```text
public uint NodeId;
```

#### Conditions
Read-only
### OwningConstraintGroupId

#### Description
Gets the ObjectId of its owning Assoc2dConstraintGroup. 
If this node has not been added into a Assoc2dConstraintGroup, ObjectId::Null is returned.
```text
public ObjectId OwningConstraintGroupId;
```

#### Conditions
Read-only