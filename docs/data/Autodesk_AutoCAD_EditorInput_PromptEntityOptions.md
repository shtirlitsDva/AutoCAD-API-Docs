# PromptEntityOptions Class

## Overview

#### Description
This class represents optional parameters for a prompt for an entity.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.PromptEditorOptions
        Autodesk.AutoCAD.EditorInput.PromptEntityOptions
```

```text
public sealed class PromptEntityOptions : PromptEditorOptions;
```

### Constructors

- [PromptEntityOptions(string)](#promptentityoptions(string))
- [PromptEntityOptions(string, string)](#promptentityoptions(string,-string))

### Methods

- [AddAllowedClass](#addallowedclass)
- [RemoveAllowedClass](#removeallowedclass)
- [SetRejectMessage](#setrejectmessage)

### Properties

- [AllowNone](#allownone)
- [AllowObjectOnLockedLayer](#allowobjectonlockedlayer)


## Constructors Details

### PromptEntityOptions(string)

#### Description
Constructor.
```text
public PromptEntityOptions(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### PromptEntityOptions(string, string)

#### Description
Constructor.
```text
public PromptEntityOptions(
    string messageAndKeywords, 
    string globalKeywords
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string messageAndKeywords | Input message and keywords |
| string globalKeywords | Input global keywords |

### AddAllowedClass

#### Description
This method adds type to the internal list of classes allowed for the selection. If exactMatch is true, then only objects of the exact class type are allowed. Otherwise, objects of the specified type and of any derived types are allowed. 
If type is already in the class list, the value of exactMatch is applied to the existing class entry.
```text
public void AddAllowedClass(
    Type type, 
    [MarshalAs(UnmanagedType.U1)] bool exactMatch
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Type type | Input type of class |
| [MarshalAs(UnmanagedType.U1)] bool exactMatch | Input boolean for exact type |

### RemoveAllowedClass

#### Description
This method removes the class indicated by type from the internal list of classes allowed for this selection.
```text
public void RemoveAllowedClass(
    Type type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Type type | Input type of class |

### SetRejectMessage

#### Description
This method sets message as the prompt that is posted if the type of a picked entity is not allowed for this selection.
```text
public void SetRejectMessage(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### AllowNone

#### Description
Gets or sets whether the prompt accepts ENTER as sole input.
```text
public bool AllowNone;
```

#### Conditions
Read / Write
### AllowObjectOnLockedLayer

#### Description
Gets or sets whether the prompt allows object on locked layer entities.
```text
public bool AllowObjectOnLockedLayer;
```

#### Conditions
Read / Write