# PromptSelectionOptions Class

## Overview

#### Description
This class provides optional parameters to a selection set prompt.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptSelectionOptions
```

```text
public sealed class PromptSelectionOptions;
```

### Constructors

- [PromptSelectionOptions](#promptselectionoptions)

### Events

- [KeywordInput](#keywordinput)
- [UnknownInput](#unknowninput)

### Methods

- [AddKeywordsToMinimalList](#addkeywordstominimallist)
- [RemoveKeywordsFromFullList](#removekeywordsfromfulllist)
- [SetKeywords](#setkeywords)

### Properties

- [AllowDuplicates](#allowduplicates)
- [AllowSubSelections](#allowsubselections)
- [ForceSubSelections](#forcesubselections)
- [Keywords](#keywords)
- [MessageForAdding](#messageforadding)
- [MessageForRemoval](#messageforremoval)
- [PrepareOptionalDetails](#prepareoptionaldetails)
- [RejectObjectsFromNonCurrentSpace](#rejectobjectsfromnoncurrentspace)
- [RejectObjectsOnLockedLayers](#rejectobjectsonlockedlayers)
- [RejectPaperspaceViewport](#rejectpaperspaceviewport)
- [SelectEverythingInAperture](#selecteverythinginaperture)
- [SingleOnly](#singleonly)
- [SinglePickInSpace](#singlepickinspace)


## Constructors Details

### PromptSelectionOptions

#### Description
Constructor.
```text
public PromptSelectionOptions();
```

### KeywordInput

#### Description
Occurs when the user types a keyword in response to a selection prompt.
```text
public event SelectionTextInputEventHandler KeywordInput;
```

### UnknownInput

#### Description
Occurs when the user types arbitrary input in response to a selection prompt.
```text
public event SelectionTextInputEventHandler UnknownInput;
```

### AddKeywordsToMinimalList

#### Description
This function adds the keywords specified by kwds to the base keyword list of "Add/Remove/Undo/Single". 
The kwds argument is a bitwise combination of the AddedKeywords enum values for the keywords to be added. If kwds is outside of the valid range or if RemoveKeywordsFromFullList() has already been called previously, then a System.InvalidOperationException is thrown.
```text
public void AddKeywordsToMinimalList(
    AddedKeywords kwds
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AddedKeywords kwds | bitwise combination of AddedKeywords enum values |

### RemoveKeywordsFromFullList

#### Description
This function removes the keywords specified by kwds from the full keyword list of "Window/Last/Crossing/BOX/ALL/Fence/WPolygon/CPolygon/Group/Add/Remove/Multiple/Previous/Undo/AUto/Single". 
The kwds argument is a bitwise combination of the SubtractedKeywords enum values for the keywords to be added. If kwds is outside of the valid range or if AddKeywordsFromFullList() has already been called previously, then a System.InvalidOperationException is thrown.
```text
public void RemoveKeywordsFromFullList(
    SubtractedKeywords kwds
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| SubtractedKeywords kwds | bitwise combination of SubtractedKeywords enum values |

### SetKeywords

#### Description
This method sets the display keywords to keywords and the global keywords to globalKeywords. The display keywords in keywords must be surrounded by an opening square bracket ("[") at the beginning and a closing square bracket ("]") at the end. The keywords in this list must be delimited by a forward slash character ("/"). 
Each display keyword specified in keywords must also be matched by a keyword in the same position in the globalKeywords string. Keywords in globalKeywords must be delimited by a single space. 
If the bracketed keyword list is missing or empty, a System.ArgumentException is thrown. If the number of global keywords does not match the number of display keywords, a System.ArgumentException is thrown.
```text
public void SetKeywords(
    string keywords, 
    string globalKeywords
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string keywords | Input keywords |
| string globalKeywords | Input global keywords |

### AllowDuplicates

#### Description
Sets the :D mode of acedSSGet.
```text
public bool AllowDuplicates;
```

#### Conditions
Read / Write
### AllowSubSelections

#### Description
Returns true of subselections are allowed in prompt.
```text
public bool AllowSubSelections;
```

#### Conditions
Read / Write
### ForceSubSelections

#### Description
True if subselection is forced to occur when selecting prompt options.
```text
public bool ForceSubSelections;
```

#### Conditions
Read / Write
### Keywords

#### Description
Sets the :K mode of acedSSGet.
```text
public KeywordCollection Keywords;
```

#### Conditions
Read / Write
### MessageForAdding

#### Description
Sets the :$ mode of acedSSGet.
```text
public string MessageForAdding;
```

#### Conditions
Read / Write
### MessageForRemoval

#### Description
Sets the :$ mode.
```text
public string MessageForRemoval;
```

#### Conditions
Read / Write
### PrepareOptionalDetails

#### Description
Sets the :N mode of acedSSGet. 
```text
public bool PrepareOptionalDetails;
```

#### Conditions
Read / Write
### RejectObjectsFromNonCurrentSpace

#### Description
Returns the RejectObjectsFromNonCurrentSpace property value.
```text
public bool RejectObjectsFromNonCurrentSpace;
```

#### Conditions
Read / Write
### RejectObjectsOnLockedLayers

#### Description
Returns the RejectObjectsOnLockedLayers property value.
```text
public bool RejectObjectsOnLockedLayers;
```

#### Conditions
Read / Write
### RejectPaperspaceViewport

#### Description
Returns the RejectPaperspaceViewport property value.
```text
public bool RejectPaperspaceViewport;
```

#### Conditions
Read / Write
### SelectEverythingInAperture

#### Description
Sets the :E mode of acedSSGet.
```text
public bool SelectEverythingInAperture;
```

#### Conditions
Read / Write
### SingleOnly

#### Description
Sets the :S mode of acedSSGet.
```text
public bool SingleOnly;
```

#### Conditions
Read / Write
### SinglePickInSpace

#### Description
Sets the :A mode of acedSSGet.
```text
public bool SinglePickInSpace;
```

#### Conditions
Read / Write 