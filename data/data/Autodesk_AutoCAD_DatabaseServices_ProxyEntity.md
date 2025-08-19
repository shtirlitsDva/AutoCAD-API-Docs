# ProxyEntity Class

## Overview

#### Description
This .NET class wraps the AcDbProxyEntity ObjectARX class. 
This abstract class provides an interface to the description data for the entities stored within ProxyEntities in drawings. It also provides access to an explode method that results in a set of entities that are copies of the graphics metafile data stored in the proxy.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.ProxyEntity
```

```text
public sealed class ProxyEntity : Entity;
```

#### See Also
ProxyObject

## Members

### Methods

- [GetReferences](#getreferences)

### Properties

- [ApplicationDescription](#applicationdescription)
- [GraphicsMetafileType](#graphicsmetafiletype)
- [OriginalClassName](#originalclassname)
- [OriginalDxfName](#originaldxfname)
- [ProxyFlags](#proxyflags)


## Methods Details

### GetReferences

#### Description
This function appends to the ids array all reference objectIds in the data of the custom entity contained in the proxy. The types array have the corresponding reference type DXF group code numbers for the objectIds in the ids array. For example, if the ids[3] element is a hard pointer ID, then types[3] will be HardPointerId (integer value 340).
```text
public DBObjectReferenceCollection GetReferences();
```

### ApplicationDescription

#### Description
Accesses the string that represents the application description of the class stored within the proxy entity. This string is the last argument in the ACRX_DXF_DEFINE_MEMBERS macro used for the class of the entity contained in the proxy. 
The application description for an entity is the fifth (last) argument in the ACRX_DXF_DEFINE_MEMBERS macro used when defining the entity's class.
```text
public string ApplicationDescription;
```

#### Conditions
Read-only
### GraphicsMetafileType

#### Description
Accesses the value indicating what kind of data is in the proxy's graphics metafile (if it has one).
```text
public Autodesk.AutoCAD.DatabaseServices.GraphicsMetafileType GraphicsMetafileType;
```

#### Conditions
Read-only
### OriginalClassName

#### Description
Accesses the string that is the C++ class name of the custom object stored in the proxy. NULL is returned, if the operation fails.
```text
public string OriginalClassName;
```

#### Conditions
Read-only
### OriginalDxfName

#### Description
Accesses the string that is the DXF name of the custom entity stored in the proxy.
```text
public string OriginalDxfName;
```

#### Conditions
Read-only
### ProxyFlags

#### Description
Accesses the
```text
public int ProxyFlags;
```

#### Conditions
Read-only