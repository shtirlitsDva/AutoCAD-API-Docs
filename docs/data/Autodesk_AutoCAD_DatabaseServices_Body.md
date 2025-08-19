# Body Class

## Overview

#### Description
This .NET class wraps the AcDbBody ObjectARX class. 
The Body class is used to represent non-manifold solids and other ShapeManager entities that do not fit the characteristics of the 3dSolid or Region classes.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Body
```

```text
public class Body : Entity;
```

#### See Also
[Region](Autodesk_AutoCAD_DatabaseServices_Region.md "Region Class"), [Solid3d](Autodesk_AutoCAD_DatabaseServices_Solid3d.md "Solid3d Class")

## Members

### Constructors

- [Body](#body)

### Methods

- [AcisIn](#acisin)
- [AcisOut](#acisout)

### Properties

- [IsNull](#isnull)
- [NumChanges](#numchanges)
- [UsesGraphicsCache](#usesgraphicscache)


## Constructors Details

### Body

#### Description
Default constructor. Initializes the change count to 0 and IsNull to true.
```text
public Body();
```

### AcisIn

#### Description
This method reads in all the ACIS entities from the fileName ASCII ACIS SAT file. It then creates Line, Circle, Arc, Ellipse, Spline, Region, Solid3d, or Body objects for each one as appropriate, and adds them to the returned collection.
```text
public static DBObjectCollection AcisIn(
    string fileName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input the file name of ASCII ACIS SAT file to be read in. |

#### Notes
The newly created objects are not added to a Database, so it is the calling application’s responsibility to either add them to a database or delete them from memory when they are no longer needed.
### AcisOut

#### Description
This method writes out all the entities in to the fileName file. The collection may contain any kind of entity, but only objects of the classes Region, Solid3d, Body, or classes derived from these, are written out to the file. The file generated is an ASCII ACIS SAT format file.
```text
public static void AcisOut(
    string fileName, 
    DBObjectCollection entitiesOutToFile
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input the file name to write data to. |
| DBObjectCollection entitiesOutToFile | Input a collection containing all the Entity objects that are to be written out to the file |

### IsNull

#### Description
Returns true if this Body has no ShapeManager object within it.
```text
public virtual bool IsNull;
```

#### Conditions
Read-only
### NumChanges

#### Description
Returns the number of changes that have occurred to this Body since it was first created.
```text
public virtual int NumChanges;
```

#### Conditions
Read-only
### UsesGraphicsCache

#### Description
This property is a wrapper for the AcDbBody::usesGraphicsCache() method which is used by AutoCAD to determine whether or not to use cached graphics for the region. If the method returns true, then cached graphics will be used. Only database resident entities can use graphics caching, so this method is not called for entities not in an AcDbDatabase.
```text
public virtual bool UsesGraphicsCache;
```

#### Conditions
Read / Write