# Keyword Class

## Overview

#### Description
This class represents a keyword in a prompt.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.Keyword
```

```text
public sealed class Keyword;
```

### Properties

- [DisplayName](#displayname)
- [Enabled](#enabled)
- [GlobalName](#globalname)
- [IsReadOnly](#isreadonly)
- [LocalName](#localname)
- [Visible](#visible)


## Properties Details

### DisplayName

#### Description
Gets or sets the display name of the keyword. This is shown on the command line. Usually the same as localName.
```text
public string DisplayName;
```

#### Conditions
Read / Write
### Enabled

#### Description
Gets or sets whether the keyword is currently enabled. When a a keyword is disabled it isn't accepted as user input. 
True if the Keyword is enabled and can be chosen by the user.
```text
public bool Enabled;
```

#### Conditions
Read / Write
### GlobalName

#### Description
Gets or sets the global name of the keyword. This is never displayed and can be used by programs to access keywords without knowing the local translation. 
A string holding the global name of the Keyword.
```text
public string GlobalName;
```

#### Conditions
Read / Write
### IsReadOnly

#### Description
Gets a value indicating whether the Keyword is read-only. 
True if the Keyword is read-only; otherwise, false. The default is false.
```text
public bool IsReadOnly;
```

#### Conditions
Read / Write
### LocalName

#### Description
Gets or sets the global name of the keyword. This is never displayed and can be used by programs to access keywords without knowing the local translation.
```text
public string LocalName;
```

#### Conditions
Read / Write
### Visible

#### Description
Gets or sets whether the keyword should be shown to the user. 
True if the Keyword should be shown.
```text
public bool Visible;
```

#### Conditions
Read / Write