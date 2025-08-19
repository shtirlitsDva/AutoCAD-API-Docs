# PromptOpenFileOptions Class

## Overview

#### Description
This class contains file dialog configuration options that are passed to the Editor.GetFileNameForOpen()> method.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptFileOptions
    Autodesk.AutoCAD.EditorInput.PromptOpenFileOptions
```

```text
public sealed class PromptOpenFileOptions : PromptFileOptions;
```

### Constructors

- [PromptOpenFileOptions](#promptopenfileoptions)

### Properties

- [SearchPath](#searchpath)
- [TransferRemoteFiles](#transferremotefiles)


## Constructors Details

### PromptOpenFileOptions

#### Description
Constructor.
```text
public PromptOpenFileOptions(
    string message
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### SearchPath

#### Description
Gets or sets whether the prompt allows search path. 
True if search path is allowed, false otherwise.
```text
public bool SearchPath;
```

#### Conditions
Read / Write
### TransferRemoteFiles

#### Description
Gets or sets whether the prompt allows transfer of remote files. 
True if transfer of remote file is allowed, false otherwise.
```text
public bool TransferRemoteFiles;
```

#### Conditions
Read / Write