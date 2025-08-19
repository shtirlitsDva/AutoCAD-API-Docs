# Autodesk.AutoCAD.DatabaseServices.SubentityType Enumeration

## Overview

#### Description
This .NET enum wraps the [AcDb::SubentType](AcDb__SubentType.md) ObjectARX enum. 
An entity can be composed of many graphic subentities, such as arcs, lines, text, vertices, edges, faces, etc. This class creates subentity IDs using one of these subentities and an index. The index is the graphics system marker for the subentity.
```text
public enum SubentityType {
  Null,
  Face,
  Edge,
  Vertex,
  MlineCache,
  Class
}
```

#### Members
| Members | Description |
| --- | --- |
| Null | No subentity. |
| Face | Face subentity, formed when AutoCAD face maps with  to create the associated Surface. |
| Edge | Subentities like lines, arcs etc. |
| Vertex | Vertex subentity, formed when AutoCAD vertex maps with  to create the associated Point3d. |
| MlineCache | Multiline cache subentity type. |
| Class | The SubentId.typeClass() property is non-null and points to the Class of the subentity. |