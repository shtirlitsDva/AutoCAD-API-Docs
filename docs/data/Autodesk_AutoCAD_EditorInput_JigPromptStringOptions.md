# JigPromptStringOptions Class

## Overview

#### Description
This class provides a container for command line options that can be passed to the JigPrompts.AcquireString()> method.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.JigPromptOptions
        Autodesk.AutoCAD.EditorInput.JigPromptStringOptions
```

```text
public sealed class JigPromptStringOptions : JigPromptOptions;
```

### Constructors

- [JigPromptStringOptions()](#jigpromptstringoptions())
- [JigPromptStringOptions(string)](#jigpromptstringoptions(string))
- [JigPromptStringOptions(string, string)](#jigpromptstringoptions(string,-string))

### Properties

- [DefaultValue](#defaultvalue)


## Constructors Details

### JigPromptStringOptions()

#### Description
Constructor.
```text
public JigPromptStringOptions();
```

### JigPromptStringOptions(string)

#### Description
Constructor.
```text
public JigPromptStringOptions(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### JigPromptStringOptions(string, string)

#### Description
Constructor.
```text
public JigPromptStringOptions(
    string messageAndKeywords, 
    string globalKeywords
);
```

### DefaultValue

#### Description
Returns the default value to be used for string option prompt.
```text
public string DefaultValue;
```

#### Conditions
Read / Write