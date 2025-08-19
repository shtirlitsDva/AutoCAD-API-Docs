# UnitsConverter Class

## Overview

#### Description
This class implements the System.ComponentModel.TypeConverter interface.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.UnitsConverter
```

```text
public class UnitsConverter : TypeConverter;
```

### Methods

- [CanConvertFrom](#canconvertfrom)
- [ConvertFrom](#convertfrom)
- [ConvertTo](#convertto)
- [GetConversionFactor](#getconversionfactor)


## Methods Details

### CanConvertFrom

#### Description
Returns true if the object can be converted within the context.
```text
public override bool CanConvertFrom(
    ITypeDescriptorContext context, 
    Type sourceType
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ITypeDescriptorContext context | Input context to convert with |
| Type sourceType | Input source type |

### ConvertFrom

#### Description
This method is used to convert a string to a Units value. It attempts to interpret value as a System.String object. If successful, it attempts to find a matching string in the Unit enum. If a match is found, this method returns the matching Unit value. If no match is found, this method throws a FormatException exception. If value cannot be cast to a System.String object, this method calls the superclass version of this method.
```text
public override object ConvertFrom(
    ITypeDescriptorContext context, 
    CultureInfo culture, 
    object value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ITypeDescriptorContext context | Input context to convert within |
| CultureInfo culture | Input culture to convert within |
| object value | Input object to convert from |

### ConvertTo

#### Description
Returns the result of converting value to destinationType in the specified culture and context.
```text
public override object ConvertTo(
    ITypeDescriptorContext context, 
    CultureInfo culture, 
    object value, 
    Type destinationType
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ITypeDescriptorContext context | Input System.ComponentModel.ITypeDescriptorContext object. |
| CultureInfo culture | Input System.Globalization.CultureInfo object. |
| object value | Input. |
| Type destinationType | Input. |

### GetConversionFactor

#### Description
Computes the conversion factor between the block's units and the current drawing's units.
```text
public static double GetConversionFactor(
    UnitsValue from, 
    UnitsValue to
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| UnitsValue from | Input Autodesk.AutoCAD.DatabaseServices.UnitsValue object to be converted. |
| UnitsValue to | Input Autodesk.AutoCAD.DatabaseServices.UnitsValue object converted to |
