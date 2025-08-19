# PromptFileNameResult Class

## Overview

#### Description
This class contains the result returned from prompts that request a file name, such as the Editor.GetFileNameForSave() and Editor.GetFileNameForOpen() methods.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptResult
    Autodesk.AutoCAD.EditorInput.PromptFileNameResult
```

```text
public class PromptFileNameResult : PromptResult;
```

### Methods

- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [ReadOnly](#readonly)


## Methods Details

### ToString()

#### Description
Returns an equivalent string representation of this object.
```text
public override string ToString();
```

### ToString(IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider.
```text
public string ToString(
    IFormatProvider provider
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IFormatProvider provider | Input for culture-specific format |

### ReadOnly

#### Description
Returns Boolean indicating whether filename result prompt is read-only.
```text
public bool ReadOnly;
```

#### Conditions
Read-only