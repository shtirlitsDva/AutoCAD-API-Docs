# AssocArrayParameters Class

## Overview

#### Description
AssocArrayParameters wraps the ObjectARX [AcDbAssocArrayParameters](AcDbAssocArrayParameters.md) class. 
This class provides an interface for manipulating array parameters. Its derived classes implement logic for providing array item transforms as well as grip manipulations. AssocArray owns the object of this class and uses its methods to evaluate the entire array.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocArrayParameters
    Autodesk.AutoCAD.DatabaseServices.AssocArrayCommonParameters
```

```text
public abstract class AssocArrayParameters : RXObject;
```

### Methods

- [Commit](#commit)

### Properties

- [Owner](#owner)


## Methods Details

### Commit

#### Description
This method commits the changes contained in the AssocArrayParameters object and syncs the changes with the database, so the changes to the array are visible on the screen. 
If there is no owner of AssocArrayParameters, no changes are committed.
```text
public void Commit();
```

### Owner

#### Description
Gets the owner (AssocArray object) of this AssocArrayParameters object.
```text
public AssocArray Owner;
```

#### Conditions
Read-only