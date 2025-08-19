# AssocArray Class

## Overview

#### Description
AssocArray wraps the ObjectARX class [AcDbAssocArrayActionBody](AcDbAssocArrayActionBody.md). It has the object Id of the ID of an associative array (rectangular, polar or path array) and the ID of that associative array's corresponding AcDbAssocArrayActionBody, which is responsible for evaluating the array's parameters. It owns a AssocArrayParameters object to manipulate the parameters of the associative array.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AssocArray
```

```text
public sealed class AssocArray;
```

### Methods

- [AddSourceEntity](#addsourceentity)
- [CreateArray](#createarray)
- [DeleteItem](#deleteitem)
- [Explode](#explode)
- [GetAssociativeArray](#getassociativearray)
- [getItemLocators](#getitemlocators)
- [GetItemTransform](#getitemtransform)
- [GetParameters](#getparameters)
- [IsAssociativeArray](#isassociativearray)
- [RemoveSourceEntity](#removesourceentity)
- [ReplaceItems](#replaceitems)
- [ResetItems](#resetitems)
- [TransformItemBy](#transformitemby)

### Properties

- [EntityId](#entityid)
- [SourceEntities](#sourceentities)


## Methods Details

### AddSourceEntity

#### Description
This method wraps the ObjectARX [AcDbAssocArrayActionBody::addSourceEntity](AcDbAssocArrayActionBody__addSourceEntity@AcDbObjectId@AcGePoint3d_.md)() method.
```text
public void AddSourceEntity(
    ObjectId sourceEntity, 
    Point3d basePoint
);
```

### CreateArray

#### Description
This method wraps [AcDbAssocArrayActionBody::createInstance](AcDbAssocArrayActionBody__createInstance@AcDbObjectIdArray_@AcDbVertexRef_@AcDbAssocArrayParameters_@AcDbObjectId_@AcDbObjectId_.md)() method. 
Creates a AssocArray object with given source entities, base point and parameters, . The newly created AssocArray object will be set as the owner of parameters.
```text
public static AssocArray CreateArray(
    ObjectIdCollection sourceEntities, 
    VertexRef basePoint, 
    AssocArrayParameters parameters
);
```

### DeleteItem

#### Description
This method wraps the ObjectARX [AcDbAssocArrayActionBody::deleteItem](AcDbAssocArrayActionBody__deleteItem@AcDbItemLocator_@bool.md)() method.
```text
public void DeleteItem(
    ItemLocator index, 
    [MarshalAs(UnmanagedType.U1)] bool bErase
);
```

### Explode

#### Description
This method wraps the [AcDbAssocArrayActionBody::explode](AcDbAssocArrayActionBody__explode@AcDbEntity_@AcDbObjectIdArray_.md)() method. 
Obtains the list of object Ids from the exploded associative array, so every previous array item gets an unique object Id in this list.
```text
public static ObjectIdCollection Explode(
    ObjectId entity
);
```

### GetAssociativeArray

#### Description
This method returns the AssocArray object with the given entity. The ID of the ActionBody evaluating this entity (associative array) is attached to this AssocArray object. If no such ActionBody exists, a null pointer is returned.
```text
public static AssocArray GetAssociativeArray(
    ObjectId entity
);
```

### getItemLocators

#### Description
Obtains a list of ItemLocator for given list of subents of an associative array. The subent provided should be a full subentity path of an entity in an array item.
```text
public static ItemLocator\[\] getItemLocators(
    FullSubentityPath\[\] subPaths
);
```

### GetItemTransform

#### Description
This method wraps the ObjectARX [AcDbAssocArrayActionBody::getTransform](AcDbAssocArrayActionBody__getTransform@const.md)() method. 
Returns the transformation matrix applied to the array item identified by the ItemLocator index .
```text
public Matrix3d GetItemTransform(
    ItemLocator index
);
```

### GetParameters

#### Description
Returns the parameter object owned by this AssocArray object.
```text
public AssocArrayParameters GetParameters();
```

### IsAssociativeArray

#### Description
This method wraps the ObjectARX [AcDbAssocArrayActionBody::isAssociativeArray](AcDbAssocArrayActionBody__isAssociativeArray@AcDbEntity_.md)() method.
```text
public static bool IsAssociativeArray(
    ObjectId entity
);
```

### RemoveSourceEntity

#### Description
This method wraps the ObjectARX [AcDbAssocArrayActionBody::removeSourceEntity](AcDbAssocArrayActionBody__removeSourceEntity@AcDbObjectId.md)() method.
```text
public void RemoveSourceEntity(
    ObjectId sourceEntity
);
```

### ReplaceItems

#### Description
Replaces items, identified by their indices in the form of ItemLocator, with given _substEntities_ and _basePoint_. The _substEntities_ form an array item, and this new array item is placed in the locations indicated by the given _indices_. The _basePoint_ is relative to the _substEntities_ , and it is transformed along with the _substEntities_.
```text
public void ReplaceItems(
    ItemLocator\[\] indices, 
    ObjectIdCollection substEntities, 
    VertexRef basePoint
);
```

### ResetItems

#### Description
Removes the item override, such as position, orientation or object replacement, from all items of this associative array.
```text
public void ResetItems();
```

### TransformItemBy

#### Description
This method wraps the ObjectARX [AcDbAssocArrayActionBody::transformItemBy](AcDbAssocArrayActionBody__transformItemBy@AcDbItemLocator_@AcGeMatrix3d_.md)() method.
```text
public void TransformItemBy(
    ItemLocator index, 
    Matrix3d transform
);
```

### EntityId

#### Description
Gets the associative array ID.
```text
public ObjectId EntityId;
```

#### Conditions
Read-only
### SourceEntities

#### Description
Gets the array of IDs of the source entities that form an item in the associative array.
```text
public ObjectIdCollection SourceEntities;
```

#### Conditions
Read-only