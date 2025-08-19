# XrefGraphNode Class

## Overview

#### Description
This .NET class wraps the AcDbXrefGraphNode ObjectARX class. 
XrefGraph is a derived class for representing an xref. Each XrefGraphNode represents one xref database. 
An XrefGraph is a representation of the relationship between a host drawing, its xref'd drawings, and any nested xref drawings. Each database or xref BlockTableRecord is represented by an XrefGraphNode in the graph. The host drawing is always the rootNode. Each reference (between databases) is represented by an edge in the graph, and can be queried by calling GraphNode.in(idx) for what is referencing this node, and GraphNode.out(idx) for what this node references. 
While there can be more than one BlockReference referencing an xref BlockTableRecord, only one corresponding edge is created between each XrefNode.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GraphNode
    Autodesk.AutoCAD.DatabaseServices.XrefGraphNode
```

```text
public class XrefGraphNode : GraphNode;
```

### Properties

- [BlockTableRecordId](#blocktablerecordid)
- [Database](#database)
- [IsNested](#isnested)
- [Name](#name)
- [XrefNotificationStatus](#xrefnotificationstatus)
- [XrefStatus](#xrefstatus)


## Properties Details

### BlockTableRecordId

#### Description
Returns the object ID of the BlockTableRecord associated with this node.
```text
public ObjectId BlockTableRecordId;
```

#### Conditions
Read-only
### Database

#### Description
Returns a pointer to the database relevant to this node.
```text
public Autodesk.AutoCAD.DatabaseServices.Database Database;
```

#### Conditions
Read-only
### IsNested

#### Description
Returns True if this node represents a nested xref that is not directly referenced in the host drawing.
```text
public bool IsNested;
```

#### Conditions
Read-only
### Name

#### Description
Returns the name for this node.
```text
public string Name;
```

#### Conditions
Read-only
### XrefNotificationStatus

#### Description
Returns the node's xref notification status.
```text
public Autodesk.AutoCAD.DatabaseServices.XrefNotificationStatus XrefNotificationStatus;
```

#### Conditions
Read-only
### XrefStatus

#### Description
Returns the node's xref status.
```text
public Autodesk.AutoCAD.DatabaseServices.XrefStatus XrefStatus;
```

#### Conditions
Read-only