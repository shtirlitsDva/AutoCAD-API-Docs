# DwgFiler Class

## Overview

#### Description
This abstract class provides the interface for derived classes that are used for I/O operations that work with the DWG information format.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DwgFiler
```

```text
public abstract class DwgFiler : RXObject;
```

#### Notes
Specialty internal classes (that is, not exported to the API) derived from this class are used for DWG filing and Undo recording. In addition, the DeepCloneFiler and WblockCloneFiler enums in the API are derived from this class to handle DeepClone and WblockClone filing operations. Remarks When working with data of the int type, do not use the DwgFiler.ReadItem and DwgFiler.WriteItem methods. If you do, the call will resolve to the boolean version of the ReadItem or WriteItem functions because they are the only two with an int argument. This will result in any data value other than 0 or 1 being converted to a 1.
#### See Also
DBObject, [Database](Autodesk_AutoCAD_DatabaseServices_Database.md "Database Class")

## Members

### Constructors

- [DwgFiler](#dwgfiler)

### Methods

- [ReadAddress](#readaddress)
- [ReadBinaryChunk](#readbinarychunk)
- [ReadBoolean](#readboolean)
- [ReadByte](#readbyte)
- [ReadBytes](#readbytes)
- [ReadDouble](#readdouble)
- [ReadHandle](#readhandle)
- [ReadHardOwnershipId](#readhardownershipid)
- [ReadHardPointerId](#readhardpointerid)
- [ReadInt16](#readint16)
- [ReadInt32](#readint32)
- [ReadInt64](#readint64)
- [ReadPoint2d](#readpoint2d)
- [ReadPoint3d](#readpoint3d)
- [ReadScale3d](#readscale3d)
- [ReadSoftOwnershipId](#readsoftownershipid)
- [ReadSoftPointerId](#readsoftpointerid)
- [ReadString](#readstring)
- [ReadUInt16](#readuint16)
- [ReadUInt32](#readuint32)
- [ReadUInt64](#readuint64)
- [ReadVector2d](#readvector2d)
- [ReadVector3d](#readvector3d)
- [ResetFilerStatus](#resetfilerstatus)
- [Seek](#seek)
- [WriteAddress](#writeaddress)
- [WriteBinaryChunk](#writebinarychunk)
- [WriteBoolean](#writeboolean)
- [WriteByte](#writebyte)
- [WriteBytes](#writebytes)
- [WriteDouble](#writedouble)
- [WriteHandle](#writehandle)
- [WriteHardOwnershipId](#writehardownershipid)
- [WriteHardPointerId](#writehardpointerid)
- [WriteInt16](#writeint16)
- [WriteInt32](#writeint32)
- [WriteInt64](#writeint64)
- [WritePoint2d](#writepoint2d)
- [WritePoint3d](#writepoint3d)
- [WriteScale3d](#writescale3d)
- [WriteSoftOwnershipId](#writesoftownershipid)
- [WriteSoftPointerId](#writesoftpointerid)
- [WriteString](#writestring)
- [WriteUInt16](#writeuint16)
- [WriteUInt32](#writeuint32)
- [WriteUInt64](#writeuint64)
- [WriteVector2d](#writevector2d)
- [WriteVector3d](#writevector3d)

### Properties

- [DwgVersion](#dwgversion)
- [ExtendedMinorVersion](#extendedminorversion)
- [FilerStatus](#filerstatus)
- [FilerType](#filertype)
- [Position](#position)


## Constructors Details

### DwgFiler

#### Description
Default constructor.
```text
protected DwgFiler();
```

### ReadAddress

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read in a memory address
  * return the address read.

**Note**
When using the ObjectARX internal filers (that is, not a custom filer), this method does not do anything about platform-dependent byte order.
```text
public abstract IntPtr ReadAddress();
```

### ReadBinaryChunk

#### Description
A BChunk is stored as a length (a short) followed by its data. 
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read in the short indicating the length of binary data.
  * read in the address of the start of the data.
  * allocate memory for the data to be read into.
  * copy the data into the memory just allocated.
  * return the buffer of binary data

Note
When using the ObjectARX internal filers (that is, not a custom filer), this method does not do anything about platform-dependent byte order.
```text
public abstract byte\[\] ReadBinaryChunk();
```

### ReadBoolean

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read in the int that is the boolean value. The value read in should be either 0 or 1. If it is anything other than 0, it should be converted to a 1.
  * return the value

```text
public abstract bool ReadBoolean();
```

### ReadByte

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read a byte into the pre-allocated memory and return it

**Note**
When using the ObjectARX internal filers (that is, not a custom filer), this method does not do anything about platform-dependent byte order.
```text
public abstract byte ReadByte();
```

### ReadBytes

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read the value bytes into buffer.

Note
When using the ObjectARX internal filers (that is, not a custom filer), this method does not do anything about platform-dependent byte order..
```text
public abstract void ReadBytes(
    byte\[\] value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| byte[] value | A pre-allocated memory area to read bytes into |

### ReadDouble

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read a double into the pre-allocated memory and return it

```text
public abstract double ReadDouble();
```

### ReadHandle

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read in a handle value (a 64-bit integer)
  * return the value read.

Note
When using the ObjectARX internal filers (that is, not a custom filer), this method does not do anything about platform-dependent byte order.
```text
public abstract Handle ReadHandle();
```

### ReadHardOwnershipId

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read an object ID (a long) and return it

```text
public abstract ObjectId ReadHardOwnershipId();
```

### ReadHardPointerId

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read an object ID (a long) and return it

```text
public abstract ObjectId ReadHardPointerId();
```

### ReadInt16

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read a System.Int16 (a short) and return it

```text
public abstract short ReadInt16();
```

### ReadInt32

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read a System.Int32 (a long) and return it

```text
public abstract int ReadInt32();
```

### ReadInt64

#### Description
This .NET method wraps the ObjectARX method [AcDbDwgFiler::readInt64](AcDbDwgFiler__readInt64@Adesk__Int64_.md).
```text
public abstract long ReadInt64();
```

### ReadPoint2d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read the _X_ and _Y_ point value doubles into the Autodesk.AutoCAD.Geometry.Point2d and return them

```text
public abstract Point2d ReadPoint2d();
```

### ReadPoint3d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read the _X_ , _Y_ , and _Z_ coordinate value doubles into the Autodesk.AutoCAD.Geometry.Point3d and return them

```text
public abstract Point3d ReadPoint3d();
```

### ReadScale3d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read the _X_ , _Y_ , and _Z_ scale doubles into the Autodesk.AutoCAD.Geometry.Scale3d and return them

```text
public abstract Scale3d ReadScale3d();
```

### ReadSoftOwnershipId

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read an object ID (a long) and return it

```text
public abstract ObjectId ReadSoftOwnershipId();
```

### ReadSoftPointerId

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read an object ID (a long) and return it

```text
public abstract ObjectId ReadSoftPointerId();
```

### ReadString

#### Description
This interface, when implemented, checks filer status. If the status is OK, it reads the data into the System.String reference, and returns it. 
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * copy the string into the referenced System.String object passed in and return its value

```text
public abstract string ReadString();
```

### ReadUInt16

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read an System.UInt16 (an unsigned short) into the pre-allocated memory and return it

```text
public abstract ushort ReadUInt16();
```

### ReadUInt32

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read an System.UInt32 (an unsigned long) into the pre-allocated memory and return it

```text
public abstract uint ReadUInt32();
```

### ReadUInt64

#### Description
This .Net method wraps the ObjectARX method [AcDbDwgFiler::readUInt64](AcDbDwgFiler__readUInt64@Adesk__UInt64_.md).
```text
public abstract ulong ReadUInt64();
```

### ReadVector2d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read the _X_ and _Y_ doubles into the Autodesk.AutoCAD.Geometry.Vector2d object pointed to and returns it

```text
public abstract Vector2d ReadVector2d();
```

### ReadVector3d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * read the _X_ and _Y_ doubles into the Autodesk.AutoCAD.Geometry.Vector3d object pointed to and returns it

```text
public abstract Vector3d ReadVector3d();
```

### ResetFilerStatus

#### Description
This interface when implemented resets the filer status.
```text
public abstract void ResetFilerStatus();
```

### Seek

#### Description
This .Net method wraps the ObjectARX method [AcDbDwgFiler::seek](AcDbDwgFiler__seek@Adesk__Int64@int.md).
```text
public abstract void Seek(
    long offset, 
    int method
);
```

### WriteAddress

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the address to value

**Note**
When using the ObjectARX internal filers (that is, not a custom filer), this method does not do anything about platform-dependent byte order.
```text
public abstract void WriteAddress(
    IntPtr value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IntPtr value | Location to write to |

### WriteBinaryChunk

#### Description
A BChunk is stored as a length (a short) followed by a pointer to its data. 
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the short indicating the length of binary data that will follow.
  * write out the binary data.

**Note** When using the ObjectARX internal filers (that is, not a custom filer), this method does not do anything about platform-dependent byte order. 
```text
public abstract void WriteBinaryChunk(
    byte\[\] chunk
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| byte[] chunk | Location to write to |

### WriteBoolean

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out value

```text
public abstract void WriteBoolean(
    [MarshalAs(UnmanagedType.U1)] bool value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool value | Location to write to |

### WriteByte

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the first byte at the address buffer.

**Note** When using the ObjectARX internal filers (that is, not a custom filer), this method does not do anything about platform-dependent byte order. 
```text
public abstract void WriteByte(
    byte value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| byte value | Location to write to |

### WriteBytes

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the bytes at the address buffer.

**Note** When using the ObjectARX internal filers (that is, not a custom filer), this method does not do anything about platform-dependent byte order. 
```text
public abstract void WriteBytes(
    byte\[\] value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| byte[] value | Location to write to |

### WriteDouble

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out value.

```text
public abstract void WriteDouble(
    double value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double value | Location to write to |

### WriteHandle

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the handle value (a 64-bit integer)

**Note** When using the ObjectARX internal filers (that is, not a custom filer), this method does not do anything about platform-dependent byte order. 
```text
public abstract void WriteHandle(
    Handle handle
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Handle handle | Location to write to |

### WriteHardOwnershipId

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the long

```text
public abstract void WriteHardOwnershipId(
    ObjectId value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId value | Location to write to |

### WriteHardPointerId

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the long

```text
public abstract void WriteHardPointerId(
    ObjectId value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId value | Location to write to |

### WriteInt16

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out System.Int16 (a short) value

```text
public abstract void WriteInt16(
    short value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| short value | Location to write to |

### WriteInt32

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out System.Int32 (a short) value.

```text
public abstract void WriteInt32(
    int value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int value | Location to write to |

### WriteInt64

#### Description
This .Net method wraps the ObjectARX method [AcDbDwgFiler::writeInt64](AcDbDwgFiler__writeInt64@Adesk__Int64.md).
```text
public abstract void WriteInt64(
    long value
);
```

### WritePoint2d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the _X_ and _Y_ point coordinate doubles into value

```text
public abstract void WritePoint2d(
    Point2d value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point2d value | Location to write to |

### WritePoint3d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the _X_ , _Y_ , and _Z_ point coordinate doubles into value.

```text
public abstract void WritePoint3d(
    Point3d value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d value | Location to write to |

### WriteScale3d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the _X_ , _Y_ , and _Z_ scale doubles into value.

```text
public abstract void WriteScale3d(
    Scale3d value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Scale3d value | Location to write to |

### WriteSoftOwnershipId

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the long

```text
public abstract void WriteSoftOwnershipId(
    ObjectId value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId value | Location to write to |

### WriteSoftPointerId

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the long

```text
public abstract void WriteSoftPointerId(
    ObjectId value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId value | Location to write to |

### WriteString

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the string

**Note** When using the ObjectARX internal filers (that is, not a custom filer), this method does not do anything about platform-dependent byte order. 
```text
public abstract void WriteString(
    string value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string value | Location to write to |

### WriteUInt16

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out System.UInt16 (an unsigned short) value.

```text
public abstract void WriteUInt16(
    ushort value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ushort value | Location to write to |

### WriteUInt32

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out System.UInt32 (an unsigned long) value.

```text
public abstract void WriteUInt32(
    uint value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| uint value | Location to write to |

### WriteUInt64

#### Description
This .Net method wraps the ObjectARX method [AcDbDwgFiler::writeUInt64](AcDbDwgFiler__writeUInt64@Adesk__UInt64.md).
```text
public abstract void WriteUInt64(
    ulong value
);
```

### WriteVector2d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the _X_ and _Y_ doubles into value.

```text
public abstract void WriteVector2d(
    Vector2d value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Vector2d value | Location to write to |

### WriteVector3d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * check the current filer status.
  * write out the _X_ , _Y_ , and Z doubles into value.

```text
public abstract void WriteVector3d(
    Vector3d value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Vector3d value | Location to write to |

### DwgVersion

#### Description
Accesses the drawing file version, such as Release 13 or Release 14.
```text
public virtual FullDwgVersion DwgVersion;
```

#### Conditions
Read-only
### ExtendedMinorVersion

#### Description
This is ExtendedMinorVersion, a member of class DwgFiler.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.MaintenanceReleaseVersion ExtendedMinorVersion;
```

### FilerStatus

#### Description
Accesses the current status of the filer.
```text
public abstract Autodesk.AutoCAD.Runtime.ErrorStatus FilerStatus;
```

#### Conditions
Read-only
### FilerType

#### Description
Accesses the actual type of the filer
```text
public abstract Autodesk.AutoCAD.DatabaseServices.FilerType FilerType;
```

#### Conditions
Read-only
### Position

#### Description
This function is not implemented.
```text
public abstract long Position;
```

#### Conditions
Read-only