# GradientColor Structure

## Overview

#### Description
This class is a container for the gradient colors used by the Hatch object
```text
public struct GradientColor {
}
```

### Constructors

- [GradientColor](#gradientcolor)

### Methods

- [get_Color](#get_color)
- [get_Value](#get_value)


## Constructors Details

### GradientColor

#### Description
Constructor.
```text
public GradientColor(
    Color color, 
    float value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Color color | Input color making up the parameters |
| float value | Input float representing the interpolation values defining the gradient |

### get_Color

#### Description
Returns the color.
```text
public Color get_Color();
```

### get_Value

#### Description
Returns the interpolation value.
```text
public float get_Value();
```
