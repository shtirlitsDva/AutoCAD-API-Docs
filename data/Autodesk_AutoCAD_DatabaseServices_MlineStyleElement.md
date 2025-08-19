# MlineStyleElement Structure

## Overview

#### Description
This class encapsulates the color, offset, and linetype ID values that define an element in the ACAD_MLINESTYLE dictionary.
```text
public struct MlineStyleElement {
}
```

### Methods

- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [Color](#color)
- [LinetypeId](#linetypeid)
- [Offset](#offset)


## Methods Details

### ToString()

#### Description
Returns an equivalent string representation of this object. See the Microsoft .NET API documentation for details.
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
| IFormatProvider provider | Input culture specific format. |

### Color

#### Description
Accesses the color property.
```text
public Autodesk.AutoCAD.Colors.Color Color;
```

#### Conditions
Read-only
### LinetypeId

#### Description
Accesses the line type ID.
```text
public ObjectId LinetypeId;
```

#### Conditions
Read-only
### Offset

#### Description
Accesses the offset value.
```text
public double Offset;
```

#### Conditions
Read-only