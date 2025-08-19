# Font Structure

## Overview

#### Description
This structure represent the font information needed in the text editor. When the user sets the font, the editor needs to know if the font name is a SHX or a TrueType font.
```text
public struct Font {
}
```

### Constructors

- [Font](#font)

### Properties

- [IsTrueType](#istruetype)
- [Name](#name)


## Constructors Details

### Font

#### Description
Constructor.
```text
public Font(
    string name, 
    [MarshalAs(UnmanagedType.U1)] bool isTrueType
);
```

### IsTrueType

#### Description
Indicates whether the font is true type.
```text
public bool IsTrueType;
```

#### Conditions
Read-only
### Name

#### Description
Gets the name of the font.
```text
public string Name;
```

#### Conditions
Read-only