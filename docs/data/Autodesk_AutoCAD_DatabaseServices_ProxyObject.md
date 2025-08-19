# ProxyObject Class

## Overview

#### Description
This .NET class wraps the AcDbProxyObject ObjectARX class. 
This abstract class provides an interface to the description data for the objects stored within ProxyObjects in drawings.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.ProxyObject
```

```text
public class ProxyObject : DBObject;
```

#### See Also
ProxyEntity

## Members

### Methods

- [GetReferences](#getreferences)
- [ResurrectMeNow](#resurrectmenow)

### Properties

- [ApplicationDescription](#applicationdescription)
- [OriginalClassName](#originalclassname)
- [OriginalDxfName](#originaldxfname)
- [ProxyFlags](#proxyflags)


## Methods Details

### GetReferences

#### Description
This function appends to the ids collection all reference objectIds in the data of the custom object contained in the proxy.
```text
public DBObjectReferenceCollection GetReferences();
```

### ResurrectMeNow

#### Description
If id represents a proxy object, and the application that defines the class of the object within the proxy is currently loaded, then this function resurrects the proxy by replacing it with the object it contains. 
Normally, resurrection occurs automatically during drawing loading or ObjectARX application loading, but this automatic resurrection occurs in database order. Thus, if there are objects with interdependencies, the object that is resurrected first can use this function to force concurrent resurrection of its interdependent objects.
```text
public static void ResurrectMeNow(
    ObjectId id
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | Input object ID of object to be resurrected |

### ApplicationDescription

#### Description
Accesses the string that represents the application description of the class stored within the proxy object.
```text
public string ApplicationDescription;
```

#### Conditions
Read-only
### OriginalClassName

#### Description
Accesses the class name of the custom object stored in the proxy.
```text
public string OriginalClassName;
```

#### Conditions
Read-only
### OriginalDxfName

#### Description
Accesses the DXF name of the custom object stored in the proxy.
```text
public string OriginalDxfName;
```

#### Conditions
Read-only
### ProxyFlags

#### Description
Accesses the proxy edit flags bit settings for the class of the custom object contained in the proxy.
```text
public int ProxyFlags;
```

#### Conditions
Read-only