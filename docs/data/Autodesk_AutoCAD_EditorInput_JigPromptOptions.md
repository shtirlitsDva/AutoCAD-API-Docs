# JigPromptOptions Class

## Overview

#### Description
This is the base class for containers of input arguments that may be passed to the Jig sampling prompt.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptOptions
    Autodesk.AutoCAD.EditorInput.JigPromptOptions
        Autodesk.AutoCAD.EditorInput.JigPromptGeometryOptions
        Autodesk.AutoCAD.EditorInput.JigPromptStringOptions
```

```text
public abstract class JigPromptOptions : PromptOptions;
```

### Properties

- [Cursor](#cursor)
- [UserInputControls](#userinputcontrols)


## Properties Details

### Cursor

#### Description
Gets or sets the cursor to be associated with the prompt.
```text
public Autodesk.AutoCAD.EditorInput.CursorType Cursor;
```

#### Conditions
Read / Write
### UserInputControls

#### Description
Returns the bitwise OR'd value of all user input control settings in effect at the present time for this particular jig.
```text
public Autodesk.AutoCAD.EditorInput.UserInputControls UserInputControls;
```

#### Conditions
Read / Write