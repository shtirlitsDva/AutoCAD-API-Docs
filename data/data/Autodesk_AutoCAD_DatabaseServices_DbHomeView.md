# DbHomeView Class

## Overview

#### Description
This .NET class wraps the AcDbHomeView ObjectARX class. 
This class objectifies the navigation home view. 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DbHomeView
```

```text
public class DbHomeView : DisposableWrapper, ICloneable;
```

Example
```text
DbHomeView hv = HostApplicationServices.WorkingDatabase.HomeView;
AutoCAD.Geometry.Point3d pt = new AutoCAD.Geometry.Point3d(-1, -1, -1);
hv.Center = pt;
HostApplicationServices.WorkingDatabase.HomeView = hv;
```

### Constructors

- [DbHomeView](#dbhomeview)

### Methods

- [Equals](#equals)
- [ToggleDefaultSettings](#toggledefaultsettings)

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [Center](#center)
- [Eye](#eye)
- [Height](#height)
- [Perspective](#perspective)
- [Up](#up)
- [Width](#width)


## Constructors Details

### DbHomeView

#### Description
Default constructor.
```text
public DbHomeView();
```

### Equals

#### Description
Returns true if the two objects are equal.
```text
public override bool Equals(
    object obj
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| object obj | Input object to compare against |

### ToggleDefaultSettings

#### Description
Fills the members of this class with default settings.
```text
public void ToggleDefaultSettings();
```

### != Operator

#### Description
Returns true if lhvm does not equal rhvm.
```text
public static bool operator !=(
    DbHomeView lhvm, 
    DbHomeView rhvw
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DbHomeView lhvm | Left operand |
| DbHomeView rhvw | Right operand |

### == Operator

#### Description
Returns true if lhvm equals rhvm.
```text
public static bool operator ==(
    DbHomeView lhvw, 
    DbHomeView rhvw
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DbHomeView rhvw | Right operand |
| lhvm | Left operand |

### Center

#### Description
Accesses the center point of the view.
```text
public Point3d Center;
```

#### Conditions
Read / Write
### Eye

#### Description
Accesses the eye point of the view.
```text
public Point3d Eye;
```

#### Conditions
Read / Write
### Height

#### Description
Accesses the orthogonal height of the view.
```text
public double Height;
```

#### Conditions
Read / Write
### Perspective

#### Description
Assesses if the view is perspective.
```text
public bool Perspective;
```

#### Conditions
Read / Write
### Up

#### Description
Accesses the up direction of the view.
```text
public Vector3d Up;
```

#### Conditions
Read / Write
### Width

#### Description
Accesses the orthogonal width of the view.
```text
public double Width;
```

#### Conditions
Read / Write