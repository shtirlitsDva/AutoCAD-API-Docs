# ObjectContextCollectionEnumerator Class

## Overview

#### Description
This .NET class wraps the AcDbObjectContextCollectionIterator ObjectARX class. 
An iterator interface for ObjectContext objects stored in an ObjectContextCollection. 
Applications that provide custom ObjectContextCollection implementations must also implement this interface in a custom iterator for their collection.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ObjectContextCollectionEnumerator
```

```text
public abstract class ObjectContextCollectionEnumerator : RXObject, IEnumerator;
```

### Methods

- [MoveNext](#movenext)
- [Reset](#reset)

### Properties

- [Current](#current)


## Methods Details

### MoveNext

#### Description
Positions the iterator to the next context in the collection. 
Returns true if the iterator was positioned to a context in the collection, or false if it has reached the end of the collection.
```text
public virtual bool MoveNext();
```

### Reset

#### Description
Positions the iterator to the beginning of the collection.
```text
public virtual void Reset();
```

### Current

#### Description
Accesses the current object the iterator is pointing to.
```text
public ObjectContext Current;
```

#### Conditions
Read-only