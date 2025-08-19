# CustomScale Structure

## Overview

#### Description
This class encapsulates the numerator and denominator values that define a custom print scale.
```text
public struct CustomScale {
}
```

### Constructors

- [CustomScale](#customscale)

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)
- [IsEqualTo(CustomScale)](#isequalto(customscale))
- [IsEqualTo(CustomScale, Tolerance)](#isequalto(customscale,-tolerance))
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [Denominator](#denominator)
- [Numerator](#numerator)


## Constructors Details

### CustomScale

#### Description
Constructor.
```text
public CustomScale(
    double numerator, 
    double denominator
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double numerator | Input numerator value |
| double denominator | Input denominator value |

### Equals

#### Description
Returns true if this object is identical to the argument object.
```text
public sealed override bool Equals(
    object obj
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| object obj | Input object to compare |

### GetHashCode

#### Description
Returns the hash code for this object. See the Microsoft .NET API documentation for details.
```text
public sealed override int GetHashCode();
```

### IsEqualTo(CustomScale)

#### Description
This method calls the IsEqualTo(CustomScale a, Tolerance tolerance) overload, with tolerance set to Global.
```text
public bool IsEqualTo(
    CustomScale a
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| CustomScale a | Input scale to compare |

### IsEqualTo(CustomScale, Tolerance)

#### Description
This method compares this CustomScale object to a. It returns a value that indicates whether the difference between the two falls within the range of tolerance.
```text
public bool IsEqualTo(
    CustomScale a, 
    Tolerance tolerance
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| CustomScale a | Input custom scale to compare |
| Tolerance tolerance | Input tolerance range |

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
| IFormatProvider provider | Input System.IFormatProvider object definition. |

### != Operator

#### Description
Returns true if a does not equal b
```text
public static bool operator !=(
    CustomScale a, 
    CustomScale b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| CustomScale a | Input left operand |
| CustomScale b | Input right operand |

### == Operator

#### Description
Returns true if a equals b
```text
public static bool operator ==(
    CustomScale a, 
    CustomScale b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| CustomScale a | Input left operand |
| CustomScale b | Input right operand |

### Denominator

#### Description
Returns the Denominator property value.
```text
public double Denominator;
```

#### Conditions
Read-only
### Numerator

#### Description
Returns the Numerator property value.
```text
public double Numerator;
```

#### Conditions
Read-only