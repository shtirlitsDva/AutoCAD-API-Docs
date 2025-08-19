# ObjectTypeAttribute Class

## Overview

#### Description
This class reports the type of an object.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ObjectTypeAttribute
```

```text
public sealed class ObjectTypeAttribute : Attribute;
```

### Constructors

- [ObjectTypeAttribute](#objecttypeattribute)

### Properties

- [ObjectType](#objecttype)


## Constructors Details

### ObjectTypeAttribute

#### Description
Creates a new object based on an existing type.
```text
public ObjectTypeAttribute(
    Type type
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Type type | Object type |

### ObjectType

#### Description
Accesses the object type.
```text
public Type ObjectType;
```

#### Conditions
Read-only