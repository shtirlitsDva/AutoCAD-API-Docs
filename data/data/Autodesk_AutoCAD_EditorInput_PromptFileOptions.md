# PromptFileOptions Class

## Overview

#### Description
This is a base class for the File dialog options.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptFileOptions
    Autodesk.AutoCAD.EditorInput.PromptOpenFileOptions
    Autodesk.AutoCAD.EditorInput.PromptSaveFileOptions
```

```text
public abstract class PromptFileOptions;
```

### Properties

- [AllowUrls](#allowurls)
- [DialogCaption](#dialogcaption)
- [DialogName](#dialogname)
- [Filter](#filter)
- [FilterIndex](#filterindex)
- [InitialDirectory](#initialdirectory)
- [InitialFileName](#initialfilename)
- [Message](#message)
- [PreferCommandLine](#prefercommandline)


## Properties Details

### AllowUrls

#### Description
Returns true if urls are allowed in the prompt options.
```text
public bool AllowUrls;
```

#### Conditions
Read / Write
### DialogCaption

#### Description
Returns the dialog caption string.
```text
public string DialogCaption;
```

#### Conditions
Read / Write
### DialogName

#### Description
Returns the dialog name string.
```text
public string DialogName;
```

#### Conditions
Read / Write
### Filter

#### Description
Returns the filter string.
```text
public string Filter;
```

#### Conditions
Read / Write
### FilterIndex

#### Description
Returns the index point of filter.
```text
public int FilterIndex;
```

#### Conditions
Read / Write
### InitialDirectory

#### Description
Return the initial directory string.
```text
public string InitialDirectory;
```

#### Conditions
Read / Write
### InitialFileName

#### Description
Returns the initial file name string.
```text
public string InitialFileName;
```

#### Conditions
Read / Write
### Message

#### Description
Returns the message prompt string.
```text
public string Message;
```

#### Conditions
Read / Write
### PreferCommandLine

#### Description
Returns Boolean indicating whether command line is given the first preference.
```text
public bool PreferCommandLine;
```

#### Conditions
Read / Write