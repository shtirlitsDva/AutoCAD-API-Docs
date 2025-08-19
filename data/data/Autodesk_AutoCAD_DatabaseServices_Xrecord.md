# Xrecord Class

## Overview

#### Description
This .NET class wraps the AcDbXrecord ObjectARX class. 
The Xrecord class is a data storage class that was implemented primarily to allow ADSRX and AutoLISP programs a means to store data in pieces larger than the xdata's 16KB-per-object limit. Each Xrecord object is capable of storing up to 2GB. By establishing an object's extension dictionary as the xrecord's owner, it's possible to associate large amounts of data with that object. 
The input or output mechanism for the data is via a linked list of resbuf structures very similar to the way xdata is accessed on objects. Unlike xdata, however, xrecords work with the standard AutoCAD group codes, which are all below 1000 in value. All the standard AutoCAD group codes are supported. This means that, in addition to all the normally used data types, an xrecord is capable of storing object IDs in any of the four types (hard owner, soft owner, hard pointer, soft pointer) which allows xrecords to own other objects, including other xrecords.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Xrecord
```

```text
public class Xrecord : DBObject, IEnumerable<TypedValue>;
```

### Constructors

- [Xrecord](#xrecord)

### Methods

- [Append](#append)
- [GetEnumerator](#getenumerator)
- [IEnumerableGetEnumerator](#ienumerablegetenumerator)
- [IEnumerableTypedValueGetEnumerator](#ienumerabletypedvaluegetenumerator)

### Properties

- [Data](#data)
- [MergeStyle](#mergestyle)
- [XlateReferences](#xlatereferences)


## Constructors Details

### Xrecord

#### Description
Default constructor.
```text
public Xrecord();
```

### Append

#### Description
Allows custom applications to add to the Xrecord without getting the existing data, appending to the end of resbuf chain and setting the data back into the xrecord. appendRbChain is more efficient when it comes to undo recording.
```text
public void Append(
    ResultBuffer data
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ResultBuffer data | Input first result buffer (not its address) in a linked list of result buffer that contain the data for the xrecord. |

### GetEnumerator

#### Description
This is GetEnumerator, a member of class Xrecord.
```text
public XrecordEnumerator GetEnumerator();
```

### IEnumerableGetEnumerator

#### Description
This is IEnumerableGetEnumerator, a member of class Xrecord.
```text
public virtual IEnumerator IEnumerableGetEnumerator();
```

### IEnumerableTypedValueGetEnumerator

#### Description
This is IEnumerableTypedValueGetEnumerator, a member of class Xrecord.
```text
public virtual IEnumerator<TypedValue> IEnumerableTypedValueGetEnumerator();
```

### Data

#### Description
Accesses the XRecord data.
```text
public ResultBuffer Data;
```

#### Conditions
Read / Write
### MergeStyle

#### Description
Sets the merge style for insert operations.
```text
public override Autodesk.AutoCAD.DatabaseServices.DuplicateRecordCloning MergeStyle;
```

#### Conditions
Read / Write
### XlateReferences

#### Description
Returns a Boolean indicating whether references are to be translated.
```text
public bool XlateReferences;
```

#### Conditions
Read / Write