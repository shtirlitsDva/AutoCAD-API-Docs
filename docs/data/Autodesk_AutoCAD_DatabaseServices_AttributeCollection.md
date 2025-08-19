# AttributeCollection Class

## Overview

#### Description
This collection class provides a container for block reference attributes.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AttributeCollection
```

```text
public sealed class AttributeCollection : ICollection, IEnumerable, ISubObject;
```

### Methods

- [AppendAttribute](#appendattribute)
- [CopyTo](#copyto)
- [GetEnumerator](#getenumerator)

### Properties

- [Count](#count)


## Methods Details

### AppendAttribute

#### Description
Returns the block reference with the new attribute.
#### Parameters

| Parameters | Description |
| --- | --- |
| [CallerMustClose] AttributeReference attributeToAddToBlockReference | Input the attribute to add. |

Previous Declaration
```text
public ObjectId AppendAttribute(
AttributeReference attributeToAddToBlockReference
);
```

### CopyTo

#### Description
Copies the objects in the element to the array.
```text
public void CopyTo(
    ObjectId\[\] array, 
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId[] array | Input the array to copy to. |
| int index | Input the index position to start adding at. |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public IEnumerator GetEnumerator();
```

### Count

#### Description
Accesses the number of items in the collection.
```text
public virtual int Count;
```

#### Conditions
Read-only