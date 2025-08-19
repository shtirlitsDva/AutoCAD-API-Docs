# XrefGraph Class

## Overview

#### Description
This .NET class wraps the AcDbXrefGraph ObjectARX class. 
XrefGraph is a derived class for representing xrefs, using the XrefGraphNode class to represent one xref database at each node. 
An XrefGraph is a representation of the relationship between a host drawing, its xref'ed drawings, and any nested xref drawings. Each database or xref block table record is represented by an XrefGraphNode in the graph. The host drawing is always the rootNode. Each reference (between databases) is represented by an edge in the graph, and can be queried by calling GraphNode.in(idx) for what is referencing this node, and GraphNode.out(idx) for what this node references. 
While there can be more than one BlockReference referencing an xref BlockTableRecord, only one corresponding edge is created between each XrefNode.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Graph
    Autodesk.AutoCAD.DatabaseServices.XrefGraph
```

```text
public class XrefGraph : Graph;
```

### Methods

- [GetXrefNode(Database)](#getxrefnode(database))
- [GetXrefNode(int)](#getxrefnode(int))
- [GetXrefNode(ObjectId)](#getxrefnode(objectid))
- [GetXrefNode(string)](#getxrefnode(string))
- [MarkUnresolvedTrees](#markunresolvedtrees)

### Properties

- [HostDrawing](#hostdrawing)


## Methods Details

### GetXrefNode(Database)

#### Description
Returns a pointer to the host drawing's database. 
While it is possible for you to use this method to build your own xref graph, the expected method to use to get the current graph for the current drawing is acedGetCurDwgXrefGraph().
```text
public XrefGraphNode GetXrefNode(
    Database db
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Database db | Input Autodesk.AutoCAD.DatabaseServices.Database object; node database to search for |

### GetXrefNode(int)

#### Description
Searches for the node that corresponds to its passed in parameter, and returns NULL if no nodes match the parameter. 
While it is possible for you to use this method to build your own xref graph, the expected method to use to get the current graph for the current drawing is acedGetCurDwgXrefGraph().
```text
public XrefGraphNode GetXrefNode(
    int idx
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int idx | Input System.Int32 object; Index into the graph |

### GetXrefNode(ObjectId)

#### Description
Returns a pointer to the Terminator Block, if there is one. Otherwise it returns ObjectId.Null. 
The Terminator Block is a block used for "terminating" references to nested overlays or xrefs which cause circular references. It is an anonymous block in the host drawing.
```text
public XrefGraphNode GetXrefNode(
    ObjectId btrId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId btrId | Input Autodesk.AutoCAD.DatabaseServices.ObjectId object; Block table record ID to search for |

### GetXrefNode(string)

#### Description
Searches for the node that corresponds to its passed in parameter, and returns NULL if no nodes match the parameter. 
The DWGNAME system variable can be used to retrieve the host drawing's name. 
While it is possible for you to use this method to build your own xref graph, the expected method to use to get the current graph for the current drawing is acedGetCurDwgXrefGraph().
```text
public XrefGraphNode GetXrefNode(
    string name
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input System.String object; Node name to search for |

### MarkUnresolvedTrees

#### Description
This method marks all unresolved xrefs and their nested xrefs with the GraphNode.UnresTree flag. It is really only effective on an xref graph which includes ghost references. 
Returns true if the graph includes any unresolved xrefs.
```text
public bool MarkUnresolvedTrees();
```

### HostDrawing

#### Description
Returns the node associated with the host drawing. 
```text
public XrefGraphNode HostDrawing;
```

#### Conditions
Read / Write