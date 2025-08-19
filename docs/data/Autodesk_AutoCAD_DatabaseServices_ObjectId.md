# ObjectId Structure

## Overview

#### Description
This .NET struct wraps the AcDbObjectId ObjectARX class. 
Since the Release of AutoCAD R13, there has been a mechanism for dealing with database-resident objects in memory. The scheme has two parts for each object. First there is the database-resident object itself, which resides in memory and can be paged out to disk if memory needs to be freed up. The second part is a "stub" object that always resides in memory and acts as the access point for the database-resident object. 
When an object or entity is first added to the database, a new stub object is created and set to point to the object or entity being added to the database. The address of this stub in memory is the ObjectId value for the object or entity added to the database. The same mechanism applies when a database is read into memory from disk. 
When a database-resident object is opened, the ObjectARX application sees that the database-resident object's objectId is passed into the open call and a pointer to the actual database-resident object is returned. What's actually going on is that the objectId is the address of the stub in memory, so the stub is accessed to get a pointer to the actual database-resident object. If the database-resident object is paged out, it is paged in and its new address is returned. 
So, an ObjectId object is a container for the address of a database-resident object's stub. As such, it is an extremely important object because it contains the only session-persistent locator for the database-resident object.
```text
public struct ObjectId : IComparable<ObjectId>, IDynamicMetaObjectProvider {
}
```

#### Remarks
Whenever possible, have custom objects and entities file in or out object IDs, since they are automatically translated (to the object's handle) on output or input, so that they always identify the same object or entity from session to session. When filing object IDs, be sure to file them out as the correct subtype (HardPointerId, SoftOwnershipId, etc.) so that the ObjectARX internal mechanisms will treat them correctly. 
If you need to save an object identifier out to an external file (that is, not a DWG or DXF file), then you cannot use object IDs. The actual value in the object ID (its a memory address) is not the same from session to session. For such a situation, you will need to save the object's handle instead of its object ID. If you are working with multiple drawing files, then you need to save the drawing file name as well as the handle, since handle values are not unique across multiple drawings. 
If you have a handle and want the object ID of the object it goes to, use the Database.GetObjectId() function. 
If you have an object ID and want to get the handle of the object it identifies, open the object and use its DBObject.Handle property.
### Constructors

- [ObjectId](#objectid)

### Methods

- [Compare](#compare)
- [ConvertToRedirectedId](#converttoredirectedid)
- [Equals](#equals)
- [GetHashCode](#gethashcode)
- [GetMetaObject](#getmetaobject)
- [GetObject(Autodesk.AutoCAD.DatabaseServices.OpenMode)](#getobject(autodesk.autocad.databaseservices.openmode))
- [GetObject(Autodesk.AutoCAD.DatabaseServices.OpenMode, [MarshalAs(UnmanagedType.U1)] bool)](#getobject(autodesk.autocad.databaseservices.openmode,-[marshalas(unmanagedtype.u1)]-bool))
- [GetObject(Autodesk.AutoCAD.DatabaseServices.OpenMode, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#getobject(autodesk.autocad.databaseservices.openmode,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Other

- [!= Operator](#!=-operator)
- [< Operator](#<-operator)
- [== Operator](#==-operator)
- [> Operator](#>-operator)

### Properties

- [Database](#database)
- [Handle](#handle)
- [IsEffectivelyErased](#iseffectivelyerased)
- [IsErased](#iserased)
- [IsNull](#isnull)
- [IsResident](#isresident)
- [IsValid](#isvalid)
- [IsWellBehaved](#iswellbehaved)
- [NonForwardedHandle](#nonforwardedhandle)
- [Null](#null)
- [ObjectClass](#objectclass)
- [OldId](#oldid)
- [OldIdPtr](#oldidptr)
- [OriginalDatabase](#originaldatabase)


## Constructors Details

### ObjectId

#### Description
Constructs an object ID based on an old integer pointer.
```text
public ObjectId(
    IntPtr oldId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IntPtr oldId | Input pointer to construct from |

### Compare

#### Description
Compares this object to value1 and returns true if they are equal.
```text
public bool Compare(
    ObjectId value1
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value1 | Input object to compare against |

### ConvertToRedirectedId

#### Description
This function will take the object ID for this object if it has been redirected from another database, and convert it to the actual object ID for the other database (for example: the object ID from an xref database). If this object ID is not redirected or if it has a value of Null, the function will do nothing.
```text
public ObjectId ConvertToRedirectedId();
```

### Equals

#### Description
Returns true if this object is equal to the argument object.
```text
public sealed override bool Equals(
    object obj
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| object obj | Input object to check against |

### GetHashCode

#### Description
Returns the hash code for this object. See the Microsoft .NET API documentation for details.
```text
public int GetHashCode();
```

### GetMetaObject

#### Description
This is GetMetaObject, a member of class ObjectId.
```text
public DynamicMetaObject GetMetaObject(
    Expression parameter
);
```

### GetObject(Autodesk.AutoCAD.DatabaseServices.OpenMode)

#### Description
Returns the object associated with this ID.
```text
public DBObject GetObject(
    Autodesk.AutoCAD.DatabaseServices.OpenMode mode
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.OpenMode mode | Input mode to retrieve the object |

### GetObject(Autodesk.AutoCAD.DatabaseServices.OpenMode, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Returns the object associated with this ID.
```text
public DBObject GetObject(
    Autodesk.AutoCAD.DatabaseServices.OpenMode mode, 
    [MarshalAs(UnmanagedType.U1)] bool openErased
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.OpenMode mode | Input mode to retrieve the object |
| [MarshalAs(UnmanagedType.U1)] bool openErased | Input Boolean indicating whether to obtain erased objects |

### GetObject(Autodesk.AutoCAD.DatabaseServices.OpenMode, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Returns the object associated with this ID.
```text
public DBObject GetObject(
    Autodesk.AutoCAD.DatabaseServices.OpenMode mode, 
    [MarshalAs(UnmanagedType.U1)] bool openErased, 
    [MarshalAs(UnmanagedType.U1)] bool forceOpenOnLockedLayer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.OpenMode mode | Input mode to retrieve the object |
| [MarshalAs(UnmanagedType.U1)] bool openErased | Input Boolean indicating whether to obtain erased objects |
| [MarshalAs(UnmanagedType.U1)] bool forceOpenOnLockedLayer | Input true if locked layers should be opened |

### ToString()

#### Description
Returns an equivalent string representation of this object.
```text
public sealed override string ToString();
```

### ToString(IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider. See the Microsoft .NET API documentation for details.
```text
public string ToString(
    IFormatProvider provider
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IFormatProvider provider | Input culture definition |

### != Operator

#### Description
Returns true if a does not equal b.
```text
public static bool operator !=(
    ObjectId a, 
    ObjectId b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId a | Left operand |
| ObjectId b | Right operand |

### < Operator

#### Description
Returns true if value1 is less than value2.
```text
public static bool operator <(
    ObjectId value1, 
    ObjectId value2
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value1 | Left operand |
| ObjectId value2 | Right operand |

### == Operator

#### Description
Returns true if a equals b.
```text
public static bool operator ==(
    ObjectId a, 
    ObjectId b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId a | Left operand |
| ObjectId b | Right operand |

### > Operator

#### Description
Returns true if value1 is greater than value2.
```text
public static bool operator >(
    ObjectId value1, 
    ObjectId value2
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value1 | Left operand |
| ObjectId value2 | Right operand |

### Database

#### Description
Accesses the database in which the object ID is resident. If the object ID is NULL, then NULL is returned.
```text
public Autodesk.AutoCAD.DatabaseServices.Database Database;
```

#### Conditions
Read-only
### Handle

#### Description
Accesses the handle of the object associated with the object ID.
```text
public Autodesk.AutoCAD.DatabaseServices.Handle Handle;
```

#### Conditions
Read-only
### IsEffectivelyErased

#### Description
Assesses true if the object associated with this object ID is erased or if any of the owners in the ownership hierarchy for the object (in other words, the object's owner, the object's owner's owner, etc.) are erased.
```text
public bool IsEffectivelyErased;
```

#### Conditions
Read-only
#### Notes
This method uses the OwnerId property of each object to find the next owner in the hierarchy. If any of the objects in the ownership hierarchy (other than the top level Symbol Table or Named Object Dictionary object) do not have their owner Id set, then this method will not be able to walk all the way up the ownership chain. If this happens, or if any of the owner objects are not able to be opened for read, then this method returns true.
### IsErased

#### Description
Assesses if the object associated with this object ID is erased
```text
public bool IsErased;
```

#### Conditions
Read-only
### IsNull

#### Description
Assesses if the object ID has a null value.
```text
public bool IsNull;
```

#### Conditions
Read-only
### IsResident

#### Description
Assesses if the object associated with this objectId is resident in memory.
```text
public bool IsResident;
```

#### Conditions
Read-only
### IsValid

#### Description
Assesses if the object ID is associated with a database that is currently in memory. If the object ID is associated with a database that is no longer available (in other words, has been deleted), then the value is false.
```text
public bool IsValid;
```

#### Conditions
Read-only
### IsWellBehaved

#### Description
Checks, in a safe way (using an exception handler), whether this AcDbObjectId is "well behaved". 
true if this id is well-behaved, false otherwise. 
Well-behaved ids may be null, valid or "stale", or they may be a garbage value, which happens to fail gracefully (without crashing) when operated on.
```text
public bool IsWellBehaved;
```

#### Conditions
Read-only
### NonForwardedHandle

#### Description
If this object ID is in an xref database and the object associated with this object ID has been redirected to the host database, then the value of this property is the handle in the xref database. If the object associated with this objectId is not from an xref database or is not redirected, then this method is the same as ObjectId.Handle.
```text
public Autodesk.AutoCAD.DatabaseServices.Handle NonForwardedHandle;
```

#### Conditions
Read-ONLY
### Null

#### Description
Accesses a null object ID. This property allows more compact expressions to be used and helps the compiler generate better code (it knows the ObjectId is zero instead of having to lookup the Null object).
```text
public static ObjectId Null;
```

#### Conditions
Read-only
### ObjectClass

#### Description
Accesses the RXClass of the object that is associated with the object id, thus guaranteeing that the result can be safely de-referenced and correctly compared against any class derived from DBObject. This is done because the entire purpose of this property is to streamline code being written; having to always compare the result against NULL would partially defeat the purpose of the function.
```text
public RXClass ObjectClass;
```

#### Conditions
Read-only
#### Notes
Use this property to obtain the associated object class without having to open and close the object itself. 
If the object has not been read in from disk, the disk image will be scanned, but the object will remain on disk after the usage.
### OldId

#### Description
**Obsolete** \- Use the OldIdPtr property instead. 
Accesses the objectId value as a long, which is the old format (an is an array of two longs, the first element of which contains the same value as that in an objectId).
Class
Autodesk.AutoCAD.DatabaseServices.ObjectId
#### Conditions
Read-only
public IntPtr OldIdPtr;
Previous Declaration
```text
public int modopt(IsLong) OldId;
```

### OldIdPtr

#### Description
Accesses the objectId value as a long, which is the old format (an is an array of two longs, the first element of which contains the same value as that in an objectId).
```text
public IntPtr OldIdPtr;
```

#### Conditions
Read-only
### OriginalDatabase

#### Description
If this object ID is in an xref database and the object associated with this object ID has been redirected to the host database, then this property will return a pointer to the xref database. If the object associated with this object ID is not from an xref database or is not redirected, then this property's value is the same as ObjectId.Database.
```text
public Autodesk.AutoCAD.DatabaseServices.Database OriginalDatabase;
```

#### Conditions
Read-only