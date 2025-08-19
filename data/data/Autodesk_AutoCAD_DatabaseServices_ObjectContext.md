# ObjectContext Class

## Overview

#### Description
This .NET class wraps the AcDbObjectContext ObjectARX class. 
An abstract base class for representing a particular context which may affect the properties and/or behavior of one or more types of objects.Classes that are derived from this base class are used to represent a particular type of context such as annotation scale.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ObjectContext
    Autodesk.AutoCAD.DatabaseServices.AnnotationScale
```

```text
public abstract class ObjectContext : RXObject;
```

### Properties

- [CollectionName](#collectionname)
- [Name](#name)
- [UniqueIdentifier](#uniqueidentifier)


## Properties Details

### CollectionName

#### Description
Accesses the name of the containing collection. 
Context objects should returns a non-null string even if the context object is not currently residing in a collection. The purpose of this method is to allow clients to identify the context type via a collection name, and to allow clients (including collection objects) to determine whether a context object is allowed in a collection instance.
```text
public virtual string CollectionName;
```

#### Conditions
Read-only
### Name

#### Description
Accesses the name of the object context. 
The name of an object context may appear in user interface components visible to the user, and may change if the context supports renaming. Applications should not identify contexts by name internally but should use the context ID, which is guaranteed to be unique and invariant over time.
```text
public virtual string Name;
```

#### Conditions
Read / Write
### UniqueIdentifier

#### Description
Accesses the unique context identifier 
The unique identifier should be invariant for the lifetime of this object and is unique amongst all instances of the context object type within an ObjectContextCollection. If an ObjectContext is not currently resident within a collection then the returned identifier may not be unique.
```text
public virtual IntPtr UniqueIdentifier;
```

#### Conditions
Read-only