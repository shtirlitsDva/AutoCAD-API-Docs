# SelectionTextInputEventArgs Class

## Overview

#### Description
This class provides data for UnknownInput and KeywordInput events of a PromptSelectionOptions object.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectionTextInputEventArgs
```

```text
public sealed class SelectionTextInputEventArgs : EventArgs;
```

### Methods

- [AddObjects](#addobjects)
- [SetErrorMessage](#seterrormessage)

### Properties

- [Input](#input)


## Methods Details

### AddObjects

#### Description
Adds objects to the selection set.
```text
public void AddObjects(
    ObjectId\[\] ids
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId[] ids | Input an array of object IDs to be added to the selection set. |

### SetErrorMessage

#### Description
Sets the error message that the selection prompt should display to the user.
```text
public void SetErrorMessage(
    string errorMessage
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string errorMessage | Input the error message text. |

### Input

#### Description
Gets the input that the user entered in the form of string.
```text
public string Input;
```

#### Conditions
Read-only