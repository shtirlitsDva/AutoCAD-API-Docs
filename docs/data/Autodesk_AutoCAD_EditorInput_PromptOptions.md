# PromptOptions Class

## Overview

#### Description
This is the base class for types that represent optional parameters for prompts.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.JigPromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
```

```text
public abstract class PromptOptions;
```

### Methods

- [SetMessageAndKeywords](#setmessageandkeywords)

### Properties

- [AppendKeywordsToMessage](#appendkeywordstomessage)
- [IsReadOnly](#isreadonly)
- [Keywords](#keywords)
- [Message](#message)


## Methods Details

### SetMessageAndKeywords

#### Description
This method sets the prompt message to the first part of the messageAndKeywords string and sets the display keywords to the latter part of the same string. The display keywords portion of messageAndKeywords must be surrounded by an opening square bracket ("[") at the beginning and a closing square bracket ("]") at the end. The keywords in this list must be delimited by a forward slash character ("/"). 
Each display keyword specified in messageAndKeywords must also be matched by a keyword in the same position in the globalKeywords string. Keywords in globalKeywords must be delimited by a single space. 
If the bracketed keyword list is missing or empty, a System.ArgumentException is thrown. If the number of global keywords does not match the number of display keywords, a System.ArgumentException is thrown.
```text
public void SetMessageAndKeywords(
    string messageAndKeywords, 
    string globalKeywords
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string messageAndKeywords | Input message and keywords |
| string globalKeywords | Input global keywords |

### AppendKeywordsToMessage

#### Description
Returns the AppendKeywordsToMessage property value.
```text
public bool AppendKeywordsToMessage;
```

#### Conditions
Read / Write
### IsReadOnly

#### Description
Gets whether the PromptOptions is read-only. 
True if this instance is read only, otherwise false.
```text
public bool IsReadOnly;
```

#### Conditions
Read-only
### Keywords

#### Description
Gets the collection of keywords that the prompt understands and displays. 
```text
public KeywordCollection Keywords;
```

#### Conditions
Read-only
### Message

#### Description
Gets or sets the prompt message to be displayed by the prompt.
```text
public string Message;
```

#### Conditions
Read / Write