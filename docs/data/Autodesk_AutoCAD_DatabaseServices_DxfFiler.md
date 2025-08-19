# DxfFiler Class

## Overview

#### Description
This .NET class wraps the AcDbDxfFiler ObjectARX class. 
This abstract class provides the interface for derived classes that are used for I/O operations that work with the DXF information format. 
Specialty internal classes (that is, not exported to the API) derived from this class are used for DXF filing and for AutoLISP ADSRX function interaction with objects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DxfFiler
```

```text
public abstract class DxfFiler : RXObject;
```

#### Notes
DxfFilers are used for both file I/O and AutoLISP or ADSRX I/O. But, the DXF file format stores the X, Y, and Z coordinates of points and vectors individually, each with their own group codes (for example, group codes 10, 20, and 30 for the X, Y, and Z values of a point), whereas the AutoLISP or ADSRX entget, entmake, and entmod functionality works with a single group code and all three values (for example, group code 10 with all three point coordinates). 
This difference in storage is taken care of automatically by ObjectARX. The read and write functions in this class always take or return the complete point, vector, and so on in one operation using one DXF group code value (represented by the DxfCode enumerated type). If the filer is filing to a DXF file, then the point, vector, and so on is automatically broken into its individual _X_ , _Y_ , and _Z_ components. The _Y_ coordinate gets a DXF group code that is equal to the _X_ coordinate's DXF group code + 10, and the _Z_ value gets a DXF group code 10 greater than the _Y_ coordinate's (for example, DXF group codes 10, 20, 30 or 11, 21, 31). If the filer is filing in from a DXF file, then the DxfFiler.ReadResbuf method (the filer's only input method) reads all the individual _X_ , _Y_ , and _Z_ values into the resbuf's resval.rpoint array. 
When working with data of the int type, do not use the DxfFiler.WriteItem method. If you do, the call resolves to the Adesk.Boolean version of the writeItem function because that is the only one with an int argument. This results in any data value other than 0 or 1 being converted to a 1. To avoid this, either use the Adesk.Int32 data type instead of int, or explicitly call the DxfFiler.WriteInt32 method. 
When implementing an object class's dxfInFields() method (see DBObject.dxfInfields()), in the error-checking code you write to handle an unexpected value read-in, call the filer's PushbackItem() method (see DxfFiler.PushbackItem()) to rewind the filer's file pointer to the line that caused the error and then return with an appropriate ErrorStatus value. If this is not done, then the error information that AutoCAD displays to the user during a DXFIN operation shows an incorrect line number (or byte value in a binary DXF file) for the error's location. 
When objectIds are read in, they come in as ads_names. The calling application (usually the dxfInFields method of a custom object or entity class) must then convert the ads_name to an ObjectId (usually using the global function GetObjectId()). 
Clients that derive from DxfFiler must override the SetVAError() function to avoid a linker error.
#### See Also
DBObject

## Members

### Methods

- [AtSubclassData](#atsubclassdata)
- [FilerStatus](#filerstatus)
- [HaltAtClassBoundaries](#haltatclassboundaries)
- [PushBackItem](#pushbackitem)
- [ReadResultBuffer](#readresultbuffer)
- [ResetFilerStatus](#resetfilerstatus)
- [RewindFiler](#rewindfiler)
- [SetError(Autodesk.AutoCAD.Runtime.ErrorStatus, string, params string[])](#seterror(autodesk.autocad.runtime.errorstatus,-string,-params-string[]))
- [SetError(string, params string[])](#seterror(string,-params-string[]))
- [WriteBool](#writebool)
- [WriteBoolean](#writeboolean)
- [WriteByte](#writebyte)
- [WriteBytes](#writebytes)
- [WriteDouble](#writedouble)
- [WriteEmbeddedObjectStart](#writeembeddedobjectstart)
- [WriteHandle](#writehandle)
- [WriteInt16](#writeint16)
- [WriteInt32](#writeint32)
- [WriteInt64](#writeint64)
- [WriteObjectId](#writeobjectid)
- [WritePoint2d](#writepoint2d)
- [WritePoint3d](#writepoint3d)
- [WriteResultBuffer](#writeresultbuffer)
- [WriteScale3d](#writescale3d)
- [WriteString](#writestring)
- [WriteUInt16](#writeuint16)
- [WriteUInt32](#writeuint32)
- [WriteUInt64](#writeuint64)
- [WriteVector2d](#writevector2d)
- [WriteVector3d](#writevector3d)
- [WriteXDataStart](#writexdatastart)

### Properties

- [AtEmbeddedObjectStart](#atembeddedobjectstart)
- [AtEndOfFile](#atendoffile)
- [AtEndOfObject](#atendofobject)
- [AtExtendedData](#atextendeddata)
- [Database](#database)
- [DwgVersion](#dwgversion)
- [Elevation](#elevation)
- [ErrorMessage](#errormessage)
- [ExtendedMinorVersion](#extendedminorversion)
- [FilerType](#filertype)
- [IncludesDefaultValues](#includesdefaultvalues)
- [IsModifyingExistingObject](#ismodifyingexistingobject)
- [Precision](#precision)
- [Thickness](#thickness)


## Methods Details

### AtSubclassData

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should test to see if the filer is currently pointing to an item with an DxfCode of Subclass and a data value string that exactly matches the subClassName string. If this is the case, then the filer moves the file pointer to the next item and returns true. Otherwise the file pointer is left alone and false is returned. 
The default implementation of this method is to terminate AutoCAD.
```text
public virtual bool AtSubclassData(
    string value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string value | subClassName that should be compared |

### FilerStatus

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It checks the current state of the filer.
```text
public virtual void FilerStatus();
```

### HaltAtClassBoundaries

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. If value is false, then set the filer to read all input without resetting its ErrorStatus unless an I/O error occurs. 
The default implementation of this method is to terminate AutoCAD. 
**Warning**
For the ObjectARX internal filer classes used for DXF and AutoLISP or C++ function I/O, this method terminates AutoCAD when it is called on a filer that is filing data out.
```text
public virtual void HaltAtClassBoundaries(
    [MarshalAs(UnmanagedType.U1)] bool value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool value | Input Boolean indicating whether or not to halt at certain key markers in the file |

### PushBackItem

#### Description
The implementation of this function should follow that of the ObjectARX internal filers: 
Resets the filer to position to where it was before the last item was read. The default implementation of this method is to terminate AutoCAD. 
**Warning**
For the ObjectARX internal filer classes used for DXF and AutoLISP or C++ function I/O, this method terminates AutoCAD when it is called on a filer that is filing data out.
```text
public virtual void PushBackItem();
```

### ReadResultBuffer

#### Description
This method is the only actual "read" input function provided to read data. 
The pRb->restype value indicates what data type is in the resbuf's resval union. 
For single data items such as doubles or ints, this method should follow that of the ObjectARX internal filers. It should: 
  * Read in the DxfCode value and the actual data value that goes with it.
  * Place the DxfCode in the pRb->restype field.
  * Place the data item in the appropriate field of the pRb->resval union.

For data items such as points and vectors that have multiple components, this method should follow that of the ObjectARX internal filers. It should: 
  * Read in all the components and their DxfCodes.
  * Place the first of the DxfCodes in pRb->restype.
  * Place the data items in the pRb->resval.rpoint

For ObjectId data items (including handles), this method should follow that of the ObjectARX internal filers. It should: 
  * Read in the DxfCode value and the actual data value that goes with it.
  * Place the DxfCode in the pRb->restype field.
  * Read in a handle rather than an objectId, if reading from a DXF file. In this case the handle must be converted to the appropriate objectId (using the Database.GetObjectId() method).
  * Place the 64-bit handle value in the first element of the pRb->resval.rlname array.

For string data items, this method should follow that of the ObjectARX internal filers. It should: 
  * Read in the DxfCode value and the actual data value that goes with it.
  * Place the DxfCode in the pRb->restype field.
  * Set the pRb->resval.rstring to the new string copy.

For binary data items, this method should follow that of the ObjectARX internal filers. It should: 
  * Read in the DxfCode value and the actual data value that goes with it.
  * Place the DxfCode in the pRb->restype field.
  * Set the pRb->resval.rbinary.buf to the new binary data copy.

**Warning**
The ObjectARX internal filers maintain their own copy of the pointer to the binary data buffer and free the memory it points to before each new read. So, callers of this function must make their own copy of the binary data returned, rather than just copying the returned buffer's address. 
The default implementation of this method is to terminate AutoCAD. If this function is called when the filer is filing out, AutoCAD is terminated.
```text
public virtual ResultBuffer ReadResultBuffer();
```

### ResetFilerStatus

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should reset the filer's internal error status.
```text
public virtual void ResetFilerStatus();
```

### RewindFiler

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should reset the filer to its default condition without changing the position that the filer is pointing to in the data it's reading or writing. 
In the ObjectARX internal filers, this method always returns 1.
```text
public virtual int RewindFiler();
```

### SetError(Autodesk.AutoCAD.Runtime.ErrorStatus, string, params string[])

#### Description
This method prints the error message represented by the format string format, using parameters passed in values. 
The default implementation of this method terminates AutoCAD.
```text
public virtual void SetError(
    Autodesk.AutoCAD.Runtime.ErrorStatus value, 
    string format, 
    params string\[\] values
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.Runtime.ErrorStatus value | Input ErrorStatus error code |
| string format | Input error message string |
| params string[] values | Input arguments to replace any formatting codes in the error message text |

### SetError(string, params string[])

#### Description
This method prints the error message represented by the format string format, using parameters passed in values.
```text
public virtual void SetError(
    string format, 
    params string\[\] values
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string format | Input error message string |
| params string[] values | Input arguments to replace any formatting codes in the error message text |

### WriteBool

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should do the following: 
  * Check the current filer status.
  * Write out the opCode in the first parameter.
  * Write out the value in the second parameter.

A bool is an integer which is 16-bit on all supported platforms.
```text
public virtual void WriteBool(
    DxfCode opCode, 
    [MarshalAs(UnmanagedType.U1)] bool value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | Input DXF group code to be written out |
| [MarshalAs(UnmanagedType.U1)] bool value | Input boolean value to be written out |

### WriteBoolean

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * Check the current filer status.
  * Write out opCode
  * Write out value.

A Boolean is an integer which is 32-bit on all supported platforms.
```text
public virtual void WriteBoolean(
    DxfCode opCode, 
    [MarshalAs(UnmanagedType.U1)] bool value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out Boolean to be written out |
| [MarshalAs(UnmanagedType.U1)] bool value | Input boolean value to be written out |

### WriteByte

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should do the following: 
  * Check the current filer status.
  * Write out the opCode in the first parameter.
  * Write out the value in the second parameter.

```text
public virtual void WriteByte(
    DxfCode opCode, 
    byte value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | Input DXF group code to be written out |
| byte value | Input byte value to be written out |

### WriteBytes

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should do the following: 
  * Check the current filer status.
  * Write out the opCode in the first parameter.
  * Write out the value in the second parameter.

```text
public virtual void WriteBytes(
    DxfCode opCode, 
    byte\[\] chunk
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | Input DXF group code to be written out |
| byte[] chunk | Input byte array to be written out |

### WriteDouble

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should do the following: 
  * Check the current filer status.
  * Write out the opCode in the first parameter.
  * Write out the value in the second parameter to precision decimal places. If precision is the default ( a value of -1) then the internal default precision is used. If this filing operation is for a DXFOUT command, the precision that you set when executing the DXFOUT command is considered the internal default.

```text
public virtual void WriteDouble(
    DxfCode opCode, 
    double value, 
    int precision
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| double value | Double to be written out |
| int precision | _nt_ |

### WriteEmbeddedObjectStart

#### Description
The implementation of this function should follow the implementation used by ObjectARX internal filers. The steps are as follows: 
  * Write out DxfCode.EmbeddedObjectStart (DXF group code 101)
  * Suppress the writing out of DxfCode.Start (DXF group code 0) for the embedded object that follows.
  * Write out a string data value of "Embedded Object" for the DxfCode.EmbeddedObjectStart group code. This requirement is not negotiable.

This method must be called in the encapsulating object's DxfOutFields() method immediately before it calls the DxfOutFields() method of the embedded object. If multiple embedded objects are involved, this method must be called immediately before each embedded object's DxfOutFields() method is called. This method should be called only in the DxfOutFields() of the encapsulating object. 
The base class implementation of this method is to abort the program. Therefore, it must be overridden in derived classes on which this method is expected to be called.
```text
public virtual void WriteEmbeddedObjectStart();
```

### WriteHandle

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should do the following: 
  * Check the current filer status.
  * Write out the opCode in the first parameter.
  * Write out the value in the second parameter.

```text
public virtual void WriteHandle(
    DxfCode opCode, 
    Handle value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| Handle value | Input Handle value to be written out |

### WriteInt16

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should do the following: 
  * Check the current filer status.
  * Write out the opCode in the first parameter.
  * Write out the value in the second parameter.

```text
public virtual void WriteInt16(
    DxfCode opCode, 
    short value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| short value | Input System.Int16 value to be written out |

### WriteInt32

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should do the following: 
  * Check the current filer status.
  * Write out the opCode in the first parameter.
  * Write out the value in the second parameter.

```text
public virtual void WriteInt32(
    DxfCode opCode, 
    int value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| int value | Input System.Int32 value to be written out |

### WriteInt64

#### Description
This .Net method wraps the ObjectARX method [AcDbDxfFiler::writeInt64](AcDbDxfFiler__writeInt64@AcDb__DxfCode@Adesk__Int64.md).
```text
public virtual void WriteInt64(
    DxfCode opCode, 
    long value
);
```

### WriteObjectId

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should do the following: 
  * Check the current filer status.
  * Write out the opCode in the first parameter.
  * Write out the value in the second parameter.

Note
When filing to a DXF file, the objectId is converted to the handle of the object with that objectId and then filed out as the 16 character (maximum) hexadecimal string representation of that handle. When filing to AutoLISP or ADSRX, the objectId is translated into an entity-name or ads_name.
```text
public virtual void WriteObjectId(
    DxfCode opCode, 
    ObjectId value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| ObjectId value | Input object ID value to be written out |

### WritePoint2d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * Check the current filer status.
  * Write out the opCode
  * Write out the _X_ and _Y_ point coordinate doubles in value to precision decimal places. If filing to a DXF file, file the _X_ coordinate out, then file out the DxfCodecode+10, then file out the _Y_ value. If precision is the default ( a value of -1) then the internal default precision is used. If this filing operation is for a DXFOUT command, the precision that you set when executing the DXFOUT command is considered the internal default.

```text
public virtual void WritePoint2d(
    DxfCode opCode, 
    Point2d value, 
    int precision
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| Point2d value | 2D point to be written out |
| int precision | Decimal places to use when writing out the coordinate double values |

### WritePoint3d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * Check the current filer status.
  * Write out the opCode
  * Write out the _X_ , _Y_ , and _Z_ point coordinate doubles in value to precision decimal places. If filing to a DXF file, file the _X_ coordinate out, then file out the DxfCodecode+10, then file out the _Y_ coordinate, then file out the DxfCode code+20, and last file out the _Z_ coordinate. If precision is the default ( a value of -1) then the internal default precision is used. If this filing operation is for a DXFOUT command, the precision that you set when executing the DXFOUT command is considered the internal default.

```text
public virtual void WritePoint3d(
    DxfCode opCode, 
    Point3d value, 
    int precision
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| Point3d value | 3D point to be written out |
| int precision | Decimal places to use when writing out the coordinate double values |

### WriteResultBuffer

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * Check the current filer status.

When an objectId is to be contained in a resbuf structure, it must be converted to an ads_name and stored in the resbuf's resval.rlnameads_name array. 
  * Call the appropriate filer writeXxxx method to handle the data type contained in the rb resbuf. Pass rb.restype as the DxfCode value and the appropriate field of rb.resval as the data.

```text
public virtual void WriteResultBuffer(
    ResultBuffer buffer
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ResultBuffer buffer | Resbuf structure to be written out |

### WriteScale3d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * Check the current filer status.
  * Write out the opCode
  * Write out the _X_ , and _Y_ doubles in val. If filing to a DXF file, file the _X_ value out, then file out the DxfCode code+10, then file out the Y value, then file out the DxfCode code+20, and last file out the _Z_ value.

If precision is the default then the internal default precision is used. If this filing operation is for a DXFOUT command, the precision that's been set by the user executing the DXFOUT command is considered the internal default.
```text
public virtual void WriteScale3d(
    DxfCode opCode, 
    Scale3d value, 
    int precision
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| Scale3d value | Scale3d object to be written out |
| int precision | Decimal places to use when writing out the Scale3d object |

### WriteString

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should do the following: 
  * Check the current filer status.
  * Write out the opCode in the first parameter.
  * Write out the value in the second parameter.

```text
public virtual void WriteString(
    DxfCode opCode, 
    string value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| string value | Input System.String value to be written out |

### WriteUInt16

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should do the following: 
  * Check the current filer status.
  * Write out the opCode in the first parameter.
  * Write out the value in the second parameter.

```text
public virtual void WriteUInt16(
    DxfCode opCode, 
    ushort value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| ushort value | Input System.UInt16 value to be written out |

### WriteUInt32

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should do the following: 
  * Check the current filer status.
  * Write out the opCode in the first parameter.
  * Write out the value in the second parameter.

```text
public virtual void WriteUInt32(
    DxfCode opCode, 
    uint value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| uint value | Input System.UInt32 value to be written out |

### WriteUInt64

#### Description
This .NET method wraps ObjectARX method [AcDbDxfFiler::writeUInt64](AcDbDxfFiler__writeUInt64@AcDb__DxfCode@Adesk__UInt64.md).
```text
public virtual void WriteUInt64(
    DxfCode opCode, 
    ulong value
);
```

### WriteVector2d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * Check the current filer status.
  * Write out the opCode
  * Write out the _X_ , and _Y_ vector doubles in value to precision decimal places. If filing to a DXF file, file the X value out, then file out the DxfCodecode+10, then file out the _Y_ value. If precision is the default ( a value of -1) then the internal default precision is used. If this filing operation is for a DXFOUT command, the precision that you set when executing the DXFOUT command is considered the internal default.

```text
public virtual void WriteVector2d(
    DxfCode opCode, 
    Vector2d value, 
    int precision
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| Vector2d value | 2D vector to be written out |
| int precision | Decimal places to use when writing out the 2D vector |

### WriteVector3d

#### Description
The implementation of this function should follow that of the ObjectARX internal filers. It should: 
  * Check the current filer status.
  * Write out the opCode
  * Write out the _X_ , and _Y_ doubles in val. If filing to a DXF file, file the _X_ value out, then file out the DxfCode code+10, then file out the _Y_ value, then file out the DxfCode code+20, and last file out the _Z_ value. If this filing operation is for a DXFOUT command, the precision that you set when executing the DXFOUT command is considered the internal default.

```text
public virtual void WriteVector3d(
    DxfCode opCode, 
    Vector3d value, 
    int precision
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DxfCode opCode | DXF group code to be written out |
| Vector3d value | 3D vector to be written out |
| int precision | Decimal places to use when writing out the 3D vector |

### WriteXDataStart

#### Description
If the filer is filing to AutoLISP or ADSRX, then this function writes out the DxfCode.XDataStart (value of -3) to indicate the start of xdata. If the filer is filing to a DXF file, then this function does nothing. 
Note
This function is intended for internal use. The filing of xdata and the DxfCode.XDataStart code are automatically taken care of by the ObjectARX filing mechanism. The only time this method might be used by an ObjectARX application would be during a custom filing operation.
```text
public virtual void WriteXDataStart();
```

### AtEmbeddedObjectStart

#### Description
True if the filer is currently pointing to an item with a DxfCode.EmbeddedObjectStart
```text
public virtual bool AtEmbeddedObjectStart;
```

#### Conditions
Read-only
### AtEndOfFile

#### Description
True if the filer is either at a subclass data marker in the object (that is, next item to read has an DxfCode.Subclass), or at the start of the object's xdata (that is, no more normal object data to read), or at the end of the object's data (that is, another object's data is next or the filer is at the end of the file being read).
```text
public virtual bool AtEndOfFile;
```

#### Conditions
Read-only
### AtEndOfObject

#### Description
True if the end of the object has been reached.
```text
public virtual bool AtEndOfObject;
```

#### Conditions
Read-only
### AtExtendedData

#### Description
True if the filer is currently pointing to an item with an DxfCode.XDataStart or .RegAppName
```text
public virtual bool AtExtendedData;
```

#### Conditions
Read / Write
### Database

#### Description
Accesses the working database being read or written by this filer.
```text
public Autodesk.AutoCAD.DatabaseServices.Database Database;
```

#### Conditions
Read-only
### DwgVersion

#### Description
Accesses the drawing file version, such as Release 13 or Release 14.
```text
public FullDwgVersion DwgVersion;
```

#### Conditions
Read-only
### Elevation

#### Description
Accesses the elevation of the object.
```text
public virtual double Elevation;
```

#### Conditions
Read-only
### ErrorMessage

#### Description
Accesses the error string message the filer is currently set to display if an error occurs.
```text
public virtual string ErrorMessage;
```

#### Conditions
Read-only
### ExtendedMinorVersion

#### Description
This is ExtendedMinorVersion, a member of class DxfFiler.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.MaintenanceReleaseVersion ExtendedMinorVersion;
```

### FilerType

#### Description
Accesses what the filer is, or should be, used for.
```text
public Autodesk.AutoCAD.DatabaseServices.FilerType FilerType;
```

#### Conditions
Read-only
### IncludesDefaultValues

#### Description
Assesses if the filer is being used for a purpose where default values (that is, color BYLAYER, normal = (0,0,1), etc.) are normally filed out. In such cases, the ObjectARX base classes such as DBObject and Entity are filing out default values. 
The implementation of this function in the AutoCAD internal filer for AutoLISP or C++ functions always returns true, whereas the implementation in the AutoCAD internal filer for DXF file I/O always returns false.
```text
public bool IncludesDefaultValues;
```

#### Conditions
Read-only
#### Notes
A return value of true does not mean that the caller must file out default values, but rather that it is recommended in order to be consistent with what other classes are doing.
### IsModifyingExistingObject

#### Description
Assesses if the DxfFiler is being used for an entmod operation.
```text
public virtual bool IsModifyingExistingObject;
```

#### Conditions
Read-only
### Precision

#### Description
Accesses the precision.
```text
public virtual int Precision;
```

#### Conditions
Read / Write
### Thickness

#### Description
Accesses the thickness.
```text
public virtual double Thickness;
```

#### Conditions
Read-only