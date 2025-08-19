# LineWeightConverter Class

## Overview

#### Description
This class is used to convert lineweights.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.LineWeightConverter
```

```text
public class LineWeightConverter : TypeConverter;
```

### Methods

- [CanConvertFrom](#canconvertfrom)
- [ConvertFrom](#convertfrom)
- [ConvertTo](#convertto)


## Methods Details

### CanConvertFrom

#### Description
Returns true if sourceType can be converted to this type.
```text
public override bool CanConvertFrom(
    ITypeDescriptorContext context, 
    Type sourceType
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ITypeDescriptorContext context | Input context with which to handle source |
| Type sourceType | Input source type |

### ConvertFrom

#### Description
Returns the converted object.
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
This method is used to convert a string to a LineWeight value. It attempts to interpret value as a System.String object. If successful, it attempts to find a matching string in the LineWeight enum. If a match is found, this method returns the matching LineWeight value. If no match is found, this method throws a FormatException exception. If value cannot be cast to a System.String object, this method calls the superclass version of this method.
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
| ITypeDescriptorContext context | Input context within which to handle value |
| CultureInfo culture | Input culture within which to handle value |
| object value | Input value to process |
