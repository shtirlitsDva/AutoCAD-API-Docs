# FullDwgVersion Structure

## Overview

#### Description
This class encapsulates major and minor DWG versions.
```text
public struct FullDwgVersion {
}
```

### Constructors

- [FullDwgVersion](#fulldwgversion)

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)
- [ToString](#tostring)

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [MajorVersion](#majorversion)
- [MinorVersion](#minorversion)


## Constructors Details

### FullDwgVersion

#### Description
Constructs an object with the given version settings.
```text
public FullDwgVersion(
    DwgVersion majorVersion, 
    Autodesk.AutoCAD.DatabaseServices.MaintenanceReleaseVersion minorVersion
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgVersion majorVersion | Input major version |
| Autodesk.AutoCAD.DatabaseServices.MaintenanceReleaseVersion minorVersion | Input minor version |

### Equals

#### Description
Returns true if this object is identical to the argument object.
```text
public sealed override bool Equals(
    object other
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| object other | Object to compare |

### GetHashCode

#### Description
Returns the hash code for this object. See the Microsoft .NET API documentation for details.
```text
public sealed override int GetHashCode();
```

### ToString

#### Description
Returns an equivalent string representation of this object. See the Microsoft .NET API documentation for details
```text
public sealed override string ToString();
```

### != Operator

#### Description
Returns true if ver1 is not equal to ver2
```text
public static bool operator !=(
    FullDwgVersion ver1, 
    FullDwgVersion ver2
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullDwgVersion ver1 | Left operand |
| FullDwgVersion ver2 | Right operand |

### == Operator

#### Description
Returns true if ver1 is equal to ver2
```text
public static bool operator ==(
    FullDwgVersion ver1, 
    FullDwgVersion ver2
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullDwgVersion ver1 | Left operand |
| FullDwgVersion ver2 | Right operand |

### MajorVersion

#### Description
Accesses the major version number.
```text
public DwgVersion MajorVersion;
```

#### Conditions
Read-only
### MinorVersion

#### Description
Accesses the minor version number.
```text
public Autodesk.AutoCAD.DatabaseServices.MaintenanceReleaseVersion MinorVersion;
```

#### Conditions
Read-only