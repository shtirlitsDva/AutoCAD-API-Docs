# FieldCodeWithChildren Class

## Overview

#### Description
This class contains a field code plus its embedded or nested (child) fields. See the Field.getFieldCode() function in the ObjectARX Reference.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.FieldCodeWithChildren
```

```text
public class FieldCodeWithChildren : IDisposable;
```

### Methods

- [Add](#add)
- [Dispose()](#dispose())
- [Dispose([MarshalAs(UnmanagedType.U1)] bool)](#dispose([marshalas(unmanagedtype.u1)]-bool))

### Properties

- [Children](#children)
- [FieldCode](#fieldcode)


## Methods Details

### Add

#### Description
Adds the new child field field to the array of children at index i.
```text
public void Add(
    int i, 
    Field field
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int i | Index at which the new entry will be added to the array of children. |
| Field field | New child field to add to the array of children at index i. |

### Dispose()

#### Description
This is Dispose, a member of class FieldCodeWithChildren.
```text
public sealed override void Dispose();
```

### Dispose([MarshalAs(UnmanagedType.U1)] bool)

#### Description
This is Dispose, a member of class FieldCodeWithChildren.
```text
protected virtual void Dispose(
    [MarshalAs(UnmanagedType.U1)] bool A_0
);
```

### Children

#### Description
Accesses the Children property value.
```text
public Field Children;
```

#### Conditions
Read-only
### FieldCode

#### Description
Accesses the FieldCode property value.
```text
public string FieldCode;
```

#### Conditions
Read / Write