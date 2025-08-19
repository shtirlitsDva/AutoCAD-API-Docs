# Vertex Class

## Overview

#### Description
This .NET class wraps the AcDbVertex ObjectARX class. 
The Vertex class is the base class for all the vertex types used by the 2dPolyline, AcDb3dPolyline, PolyFaceMesh, and AcDbPolygonMesh classes within AutoCAD. 
This class provides no methods other than a default constructor and destructor. It is not intended that objects of this class need ever be instantiated by ObjectARX applications, or that this class ever be derived from. 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Vertex
            Autodesk.AutoCAD.DatabaseServices.FaceRecord
            Autodesk.AutoCAD.DatabaseServices.PolyFaceMeshVertex
            Autodesk.AutoCAD.DatabaseServices.PolygonMeshVertex
            Autodesk.AutoCAD.DatabaseServices.PolylineVertex3d
            Autodesk.AutoCAD.DatabaseServices.Vertex2d
```

```text
public class Vertex : Entity;
```

#### Notes
The following members are not implemented for this class, nor any classes derived from it. These members will never be implemented, since they are not appropriate for objects of these classes: 
Entity.explode()
Entity.getEcs()
Entity.getGeomExtents()
Entity.getGripPoints()
Entity.getOsnapPoints()
Entity.getStretchPoint()
Entity.intersectWith()
Entity.moveGripPointsAt()
Entity.moveStretchPointsAt()