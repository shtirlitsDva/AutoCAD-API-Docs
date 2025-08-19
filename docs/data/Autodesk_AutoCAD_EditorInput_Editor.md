# Editor Class

## Overview

#### Description
This .NET class wraps the AcEditor ObjectARX class. The single system object of a class derived from this abstract base class allows applications to manage AutoCAD drawing editor notification reactors. Applications can add and remove reactors from the AutoCAD drawing editor reactor chain.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.Editor
```

```text
public sealed class Editor : MarshalByRefObject;
```

### Events

- [Dragging](#dragging)
- [DraggingEnded](#draggingended)
- [EnteringQuiescentState](#enteringquiescentstate)
- [LeavingQuiescentState](#leavingquiescentstate)
- [PointFilter](#pointfilter)
- [PointMonitor](#pointmonitor)
- [PromptedForAngle](#promptedforangle)
- [PromptedForCorner](#promptedforcorner)
- [PromptedForDistance](#promptedfordistance)
- [PromptedForDouble](#promptedfordouble)
- [PromptedForEntity](#promptedforentity)
- [PromptedForInteger](#promptedforinteger)
- [PromptedForKeyword](#promptedforkeyword)
- [PromptedForNestedEntity](#promptedfornestedentity)
- [PromptedForPoint](#promptedforpoint)
- [PromptedForSelection](#promptedforselection)
- [PromptedForString](#promptedforstring)
- [PromptForEntityEnding](#promptforentityending)
- [PromptForSelectionEnding](#promptforselectionending)
- [PromptingForAngle](#promptingforangle)
- [PromptingForCorner](#promptingforcorner)
- [PromptingForDistance](#promptingfordistance)
- [PromptingForDouble](#promptingfordouble)
- [PromptingForEntity](#promptingforentity)
- [PromptingForInteger](#promptingforinteger)
- [PromptingForKeyword](#promptingforkeyword)
- [PromptingForNestedEntity](#promptingfornestedentity)
- [PromptingForPoint](#promptingforpoint)
- [PromptingForSelection](#promptingforselection)
- [PromptingForString](#promptingforstring)
- [Rollover](#rollover)
- [SelectionAdded](#selectionadded)
- [SelectionRemoved](#selectionremoved)

### Methods

- [ApplyCurDwgLayerTableChanges](#applycurdwglayertablechanges)
- [Command](#command)
- [CommandAsync](#commandasync)
- [CommandResult.GetAwaiter](#commandresult.getawaiter)
- [CommandResult.GetResult](#commandresult.getresult)
- [CommandResult.OnCompleted](#commandresult.oncompleted)
- [DoPrompt](#doprompt)
- [Drag(Jig)](#drag(jig))
- [Drag(PromptDragOptions)](#drag(promptdragoptions))
- [Drag(SelectionSet, string, DragCallback)](#drag(selectionset,-string,-dragcallback))
- [DrawVector](#drawvector)
- [DrawVectors](#drawvectors)
- [GetAngle(PromptAngleOptions)](#getangle(promptangleoptions))
- [GetAngle(string)](#getangle(string))
- [GetCommandVersion](#getcommandversion)
- [GetCorner(PromptCornerOptions)](#getcorner(promptcorneroptions))
- [GetCorner(string, Point3d)](#getcorner(string,-point3d))
- [GetCurrentView](#getcurrentview)
- [GetDistance(PromptDistanceOptions)](#getdistance(promptdistanceoptions))
- [GetDistance(string)](#getdistance(string))
- [GetDouble(PromptDoubleOptions)](#getdouble(promptdoubleoptions))
- [GetDouble(string)](#getdouble(string))
- [GetEntity(PromptEntityOptions)](#getentity(promptentityoptions))
- [GetEntity(string)](#getentity(string))
- [GetFileNameForOpen(PromptOpenFileOptions)](#getfilenameforopen(promptopenfileoptions))
- [GetFileNameForOpen(string)](#getfilenameforopen(string))
- [GetFileNameForSave(PromptSaveFileOptions)](#getfilenameforsave(promptsavefileoptions))
- [GetFileNameForSave(string)](#getfilenameforsave(string))
- [GetInteger(PromptIntegerOptions)](#getinteger(promptintegeroptions))
- [GetInteger(string)](#getinteger(string))
- [GetKeywords(PromptKeywordOptions)](#getkeywords(promptkeywordoptions))
- [GetKeywords(string, params string[])](#getkeywords(string,-params-string[]))
- [GetNestedEntity(PromptNestedEntityOptions)](#getnestedentity(promptnestedentityoptions))
- [GetNestedEntity(string)](#getnestedentity(string))
- [GetPoint(PromptPointOptions)](#getpoint(promptpointoptions))
- [GetPoint(string)](#getpoint(string))
- [GetSelection()](#getselection())
- [GetSelection(PromptSelectionOptions)](#getselection(promptselectionoptions))
- [GetSelection(PromptSelectionOptions, SelectionFilter)](#getselection(promptselectionoptions,-selectionfilter))
- [GetSelection(SelectionFilter)](#getselection(selectionfilter))
- [GetString(PromptStringOptions)](#getstring(promptstringoptions))
- [GetString(string)](#getstring(string))
- [GetViewportNumber](#getviewportnumber)
- [InitCommandVersion](#initcommandversion)
- [PointToScreen](#pointtoscreen)
- [PointToWorld(Point)](#pointtoworld(point))
- [PointToWorld(Point, int)](#pointtoworld(point,-int))
- [PostCommandPrompt](#postcommandprompt)
- [Regen](#regen)
- [SelectAll()](#selectall())
- [SelectAll(SelectionFilter)](#selectall(selectionfilter))
- [SelectCrossingPolygon(Point3dCollection)](#selectcrossingpolygon(point3dcollection))
- [SelectCrossingPolygon(Point3dCollection, SelectionFilter)](#selectcrossingpolygon(point3dcollection,-selectionfilter))
- [SelectCrossingWindow(Point3d, Point3d)](#selectcrossingwindow(point3d,-point3d))
- [SelectCrossingWindow(Point3d, Point3d, SelectionFilter)](#selectcrossingwindow(point3d,-point3d,-selectionfilter))
- [SelectCrossingWindow(Point3d, Point3d, SelectionFilter, [MarshalAs(UnmanagedType.U1)] bool)](#selectcrossingwindow(point3d,-point3d,-selectionfilter,-[marshalas(unmanagedtype.u1)]-bool))
- [SelectFence(Point3dCollection)](#selectfence(point3dcollection))
- [SelectFence(Point3dCollection, SelectionFilter)](#selectfence(point3dcollection,-selectionfilter))
- [SelectImplied](#selectimplied)
- [SelectLast](#selectlast)
- [SelectPrevious](#selectprevious)
- [SelectWindow(Point3d, Point3d)](#selectwindow(point3d,-point3d))
- [SelectWindow(Point3d, Point3d, SelectionFilter)](#selectwindow(point3d,-point3d,-selectionfilter))
- [SelectWindowPolygon(Point3dCollection)](#selectwindowpolygon(point3dcollection))
- [SelectWindowPolygon(Point3dCollection, SelectionFilter)](#selectwindowpolygon(point3dcollection,-selectionfilter))
- [SetCurrentView](#setcurrentview)
- [SetImpliedSelection(ObjectId[])](#setimpliedselection(objectid[]))
- [SetImpliedSelection(SelectionSet)](#setimpliedselection(selectionset))
- [Snap](#snap)
- [StartUserInteraction(IntPtr)](#startuserinteraction(intptr))
- [StartUserInteraction(Window)](#startuserinteraction(window))
- [SwitchToModelSpace](#switchtomodelspace)
- [SwitchToPaperSpace](#switchtopaperspace)
- [TraceBoundary](#traceboundary)
- [TurnForcedPickOff](#turnforcedpickoff)
- [TurnForcedPickOn](#turnforcedpickon)
- [TurnSubentityWindowSelectionOff](#turnsubentitywindowselectionoff)
- [TurnSubentityWindowSelectionOn](#turnsubentitywindowselectionon)
- [UpdateScreen](#updatescreen)
- [UpdateTiledViewportsFromDatabase](#updatetiledviewportsfromdatabase)
- [UpdateTiledViewportsInDatabase](#updatetiledviewportsindatabase)
- [ViewportIdFromNumber](#viewportidfromnumber)
- [WriteMessage(string)](#writemessage(string))
- [WriteMessage(string, params object[])](#writemessage(string,-params-object[]))

### Other

- [CommandResult Class](#commandresult-class)
- [PauseToken Field](#pausetoken-field)

### Properties

- [ActiveViewportId](#activeviewportid)
- [CommandResult.IsCompleted](#commandresult.iscompleted)
- [CurrentUserCoordinateSystem](#currentusercoordinatesystem)
- [CurrentViewportObjectId](#currentviewportobjectid)
- [Document](#document)
- [IsDragging](#isdragging)
- [IsQuiescent](#isquiescent)
- [IsQuiescentForTransparentCommand](#isquiescentfortransparentcommand)
- [MouseHasMoved](#mousehasmoved)
- [UseCommandLineInterface](#usecommandlineinterface)


## Events Details

### Dragging

#### Description
Occurs when a dragging operation is performed in a drawing.
```text
public event DraggingEventHandler Dragging;
```

### DraggingEnded

#### Description
Occurs when the user ends the dragging operation.
```text
public event DraggingEndedEventHandler DraggingEnded;
```

### EnteringQuiescentState

#### Description
Occurs when the user enters a quiescent state.
```text
public event EventHandler EnteringQuiescentState;
```

### LeavingQuiescentState

#### Description
This event provides notification for the end of an AutoCAD quiescent state.
```text
public event EventHandler LeavingQuiescentState;
```

### PointFilter

#### Description
Occurs when the mouse is moved within the AutoCAD editor window.
```text
public event PointFilterEventHandler PointFilter;
```

### PointMonitor

#### Description
Occurs when the mouse is moved within the AutoCAD editor window.
```text
public event PointMonitorEventHandler PointMonitor;
```

### PromptedForAngle

#### Description
This function provides notification for the end of an AutoCAD angle acquisition operation.
```text
public event PromptDoubleResultEventHandler PromptedForAngle;
```

### PromptedForCorner

#### Description
This function provides notification for the end of an AutoCAD corner acquisition operation.
```text
public event PromptPointResultEventHandler PromptedForCorner;
```

### PromptedForDistance

#### Description
This function provides notification for the end of an AutoCAD distance acquisition operation.
```text
public event PromptDoubleResultEventHandler PromptedForDistance;
```

### PromptedForDouble

#### Description
This function provides notification for the end of an AutoCAD floating point value acquisition operation.
```text
public event PromptDoubleResultEventHandler PromptedForDouble;
```

### PromptedForEntity

#### Description
This function provides notification for the end of an AutoCAD entity selection operation.
```text
public event PromptEntityResultEventHandler PromptedForEntity;
```

### PromptedForInteger

#### Description
This function provides notification for the end of an AutoCAD integer acquisition operation.
```text
public event PromptIntegerResultEventHandler PromptedForInteger;
```

### PromptedForKeyword

#### Description
This function provides notification for the end of an AutoCAD key word acquisition operation.
```text
public event PromptStringResultEventHandler PromptedForKeyword;
```

### PromptedForNestedEntity

#### Description
This function provides notification for the end of an AutoCAD nentsel acquisition operation.
```text
public event PromptNestedEntityResultEventHandler PromptedForNestedEntity;
```

### PromptedForPoint

#### Description
This function provides notification for the end of an AutoCAD point acquisition operation.
```text
public event PromptPointResultEventHandler PromptedForPoint;
```

### PromptedForSelection

#### Description
This function provides notification for the end of an AutoCAD selection set acquisition operation.
```text
public event PromptSelectionResultEventHandler PromptedForSelection;
```

### PromptedForString

#### Description
This function provides notification for the end of an AutoCAD string acquisition operation.
```text
public event PromptStringResultEventHandler PromptedForString;
```

### PromptForEntityEnding

#### Description
This function provides notification for the end of an AutoCAD entity selection operation.
```text
public event PromptForEntityEndingEventHandler PromptForEntityEnding;
```

### PromptForSelectionEnding

#### Description
This function provides notification for the end of an AutoCAD selection set acquisition operation.
```text
public event PromptForSelectionEndingEventHandler PromptForSelectionEnding;
```

### PromptingForAngle

#### Description
This function provides notification for the start of an AutoCAD angle acquisition operation.
```text
public event PromptAngleOptionsEventHandler PromptingForAngle;
```

### PromptingForCorner

#### Description
This function provides notification for the start of an AutoCAD corner acquisition operation.
```text
public event PromptPointOptionsEventHandler PromptingForCorner;
```

### PromptingForDistance

#### Description
This function provides notification for the start of an AutoCAD distance acquisition operation.
```text
public event PromptDistanceOptionsEventHandler PromptingForDistance;
```

### PromptingForDouble

#### Description
This function provides notification for the start of an AutoCAD floating point acquisition operation.
```text
public event PromptDoubleOptionsEventHandler PromptingForDouble;
```

### PromptingForEntity

#### Description
This function provides notification for the start of an AutoCAD entity selection operation.
```text
public event PromptEntityOptionsEventHandler PromptingForEntity;
```

### PromptingForInteger

#### Description
This function provides notification for the start of an AutoCAD integer acquisition operation.
```text
public event PromptIntegerOptionsEventHandler PromptingForInteger;
```

### PromptingForKeyword

#### Description
This function provides notification for the start of an AutoCAD keyword acquisition.
```text
public event PromptKeywordOptionsEventHandler PromptingForKeyword;
```

### PromptingForNestedEntity

#### Description
This function provides notification for the start of an AutoCAD nentsel acquisition operation.
```text
public event PromptNestedEntityOptionsEventHandler PromptingForNestedEntity;
```

### PromptingForPoint

#### Description
This function provides notification for the start of an AutoCAD point acquisition operation.
```text
public event PromptPointOptionsEventHandler PromptingForPoint;
```

### PromptingForSelection

#### Description
This function provides notification for the start of an AutoCAD selection set acquisition operation.
```text
public event PromptSelectionOptionsEventHandler PromptingForSelection;
```

### PromptingForString

#### Description
This function provides notification for the start of an AutoCAD string acquisition operation.
```text
public event PromptStringOptionsEventHandler PromptingForString;
```

### Rollover

#### Description
This function provides notification for rollovers.
```text
public event RolloverEventHandler Rollover;
```

### SelectionAdded

#### Description
This callback provides notification of a subselection. 
A subselection occurs when entities are going to be added to a selection set that is being created. It is indicated in the AutoCAD interface by an "xx found" prompt in which xx is a number greater than or equal to 1. 
This notification is triggered by the following events: 
  * Any modifications to the PICKFIRST set
  * Built-in AutoCAD commands that prompt the user to select entities

```text
public event SelectionAddedEventHandler SelectionAdded;
```

### SelectionRemoved

#### Description
This callback provides notification of the removal of some entities from the selection set.
```text
public event SelectionRemovedEventHandler SelectionRemoved;
```

### ApplyCurDwgLayerTableChanges

#### Description
Updates the cached layer data for the current document in the editor.
```text
public void ApplyCurDwgLayerTableChanges();
```

### Command

#### Description
This is Command, a member of class Editor.
```text
public void Command(
    params object\[\] parameter
);
```

### CommandAsync

#### Description
This is CommandAsync, a member of class Editor.
```text
public CommandResult CommandAsync(
    params object\[\] parameter
);
```

### CommandResult.GetAwaiter

#### Description
This is GetAwaiter, a member of class CommandResult.
```text
public Editor.CommandResult GetAwaiter();
```

### CommandResult.GetResult

#### Description
This is GetResult, a member of class CommandResult.
```text
public void GetResult();
```

### CommandResult.OnCompleted

#### Description
This is OnCompleted, a member of class CommandResult.
```text
public void OnCompleted(
    Action continuation
);
```

### DoPrompt

#### Description
Carries out a prompt with the specified options. Returns the result of the prompt operation.
```text
public PromptResult DoPrompt(
    PromptOptions opt
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptOptions opt | Input options for the prompt |

### Drag(Jig)

#### Description
Starts a Jig operation. Returns the outcome of the Jig operation.
```text
public PromptResult Drag(
    Jig jig
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Jig jig | Input the jig to drag |

### Drag(PromptDragOptions)

#### Description
Prompts the user to modify a selection set by graphically dragging its entities. 
Only entities from the current drawing's model space and paper space can be manipulated by this function. It does not manipulate nongraphical objects or entities in other block definitions.
```text
public PromptPointResult Drag(
    PromptDragOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptDragOptions options | Input dragging options |

### Drag(SelectionSet, string, DragCallback)

#### Description
Prompts the user to modify a selection set by graphically dragging its entities.
```text
public PromptPointResult Drag(
    SelectionSet selection, 
    string message, 
    DragCallback callback
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| SelectionSet selection | Input the selection set |
| string message | Input the prompt message |
| DragCallback callback | Input any drag callbacks |

### DrawVector

#### Description
Draws a vector from a specified beginning and ending points. Its color and highlight values may also be chosen.
```text
public void DrawVector(
    Point3d from, 
    Point3d to, 
    int color, 
    [MarshalAs(UnmanagedType.U1)] bool drawHighlighted
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d from | Input beginning point |
| Point3d to | Input ending point |
| int color | Input color of vector |
| [MarshalAs(UnmanagedType.U1)] bool drawHighlighted | Input Boolean value indicated of the vector ought to be highlighted |

### DrawVectors

#### Description
Draws a set of vectors that are transformed by the given matrix.
```text
public void DrawVectors(
    ResultBuffer rb, 
    Matrix3d transform
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ResultBuffer rb | Input result buffer containing vectors |
| Matrix3d transform | Input transformation matrix |

### GetAngle(PromptAngleOptions)

#### Description
Gets user input for an angle, taking into account the current value of the ANGBASE system variable.
```text
public PromptDoubleResult GetAngle(
    PromptAngleOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptAngleOptions options | Input optional parameters of the prompt. |

### GetAngle(string)

#### Description
Gets user input for an angle, taking into account the current value of the ANGBASE system variable.
```text
public PromptDoubleResult GetAngle(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input message to be displayed to the user during the prompt. |

### GetCommandVersion

#### Description
This function is used to query the requested version of the command in progress in the current document. It does this by querying the version set at this depth of the command version stack.
```text
public int GetCommandVersion();
```

### GetCorner(PromptCornerOptions)

#### Description
Gets user input for the corner of a rectangle.
```text
public PromptPointResult GetCorner(
    PromptCornerOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptCornerOptions options | Input optional parameters of the prompt. |

### GetCorner(string, Point3d)

#### Description
Returns a PromptPointResult object representing the result of the prompt operation.
```text
public PromptPointResult GetCorner(
    string message, 
    Point3d basePoint
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input message to be displayed to the user during the prompt. |
| Point3d basePoint | Input the first corner of the rectangle being selected. |

### GetCurrentView

#### Description
Gets the current view from ViewTableRecord.
```text
public ViewTableRecord GetCurrentView();
```

### GetDistance(PromptDistanceOptions)

#### Description
Gets user input for a linear distance.
```text
public PromptDoubleResult GetDistance(
    PromptDistanceOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptDistanceOptions options | Input optional parameters of the prompt. |

### GetDistance(string)

#### Description
Returns a PromptDoubleResult object representing the result of the prompt operation.
```text
public PromptDoubleResult GetDistance(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input message to be displayed to the user during the prompt. |

### GetDouble(PromptDoubleOptions)

#### Description
Gets user input for a real value.
```text
public PromptDoubleResult GetDouble(
    PromptDoubleOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptDoubleOptions options | Input optional parameters of the prompt. |

### GetDouble(string)

#### Description
Returns a PromptDoubleResult object representing the result of the prompt operation.
```text
public PromptDoubleResult GetDouble(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input message to be displayed to the user during the prompt. |

### GetEntity(PromptEntityOptions)

#### Description
Prompts the user to select an entity by specifying a point. 
Pauses for user input and returns both an entity name and the point that is used to select the entity. 
GetEntity() does not return the names of nongraphical objects. 
```text
public PromptEntityResult GetEntity(
    PromptEntityOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptEntityOptions options | Input optional parameters of the prompt. |

### GetEntity(string)

#### Description
Prompts the user to select an entity by specifying a point. 
Pauses for user input and returns both an entity name and the point that is used to select the entity. 
GetEntity() does not return the names of nongraphical objects. 
```text
public PromptEntityResult GetEntity(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### GetFileNameForOpen(PromptOpenFileOptions)

#### Description
This method emulates the subtleties of AutoCAD file prompting. It properly prompts on the command line when FILEDIA is zero, or if a script or an AutoLISP routine is running.
```text
public PromptFileNameResult GetFileNameForOpen(
    PromptOpenFileOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptOpenFileOptions options | Input file opening options |

### GetFileNameForOpen(string)

#### Description
This method emulates the subtleties of AutoCAD file prompting. It properly prompts on the command line when FILEDIA is zero, or if a script or an AutoLISP routine is running.
```text
public PromptFileNameResult GetFileNameForOpen(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt string |

### GetFileNameForSave(PromptSaveFileOptions)

#### Description
This method emulates the subtleties of AutoCAD file prompting. It properly prompts on the command line when FILEDIA is zero, or if a script or an AutoLISP routine is running.
```text
public PromptFileNameResult GetFileNameForSave(
    PromptSaveFileOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptSaveFileOptions options | Input file saving options |

### GetFileNameForSave(string)

#### Description
This method emulates the subtleties of AutoCAD file prompting. It properly prompts on the command line when FILEDIA is zero, or if a script or an AutoLISP routine is running.
```text
public PromptFileNameResult GetFileNameForSave(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### GetInteger(PromptIntegerOptions)

#### Description
Gets user input for an integer. 
The AutoCAD user can enter any valid (short) integer in the range of -32,768 to +32,767.
```text
public PromptIntegerResult GetInteger(
    PromptIntegerOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptIntegerOptions options | Input optional parameters of the prompt. |

### GetInteger(string)

#### Description
Gets user input for an integer. 
The AutoCAD user can enter any valid (short) integer in the range of -32,768 to +32,767.
```text
public PromptIntegerResult GetInteger(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input message to be displayed to the user during the prompt. |

### GetKeywords(PromptKeywordOptions)

#### Description
Gets user input for a keyword. 
Wraps the acedGetKword() ObjectARX function. 
The AutoCAD user can enter the keyword from the keyboard. The list of keywords that GetKeywords() accepts is set by a prior call to GetInteger(). If the user enters a string not specified in the call to GetInteger(), AutoCAD displays an error message and tries again (and redisplays prompt, if one was specified). If the user types only [Return], GetKeywords() returns an empty string ("") unless the call to GetInteger() also disallowed null input. 
**Note:** The underscore character ("_") has a special meaning and can't be used as a keyword or as part of a keyword.
```text
public PromptResult GetKeywords(
    PromptKeywordOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptKeywordOptions options | Input optional parameters of the prompt. |

### GetKeywords(string, params string[])

#### Description
Gets user input for a keyword. 
Wraps the acedGetKword() ObjectARX function. 
The AutoCAD user can enter the keyword from the keyboard. The list of keywords that GetKeywords() accepts is set by a prior call to GetInteger(). If the user enters a string not specified in the call to GetInteger(), AutoCAD displays an error message and tries again (and redisplays prompt, if one was specified). If the user types only [Return], GetKeywords() returns an empty string ("") unless the call to GetInteger() also disallowed null input. 
**Note:** The underscore character ("_") has a special meaning and can't be used as a keyword or as part of a keyword.
```text
public PromptResult GetKeywords(
    string message, 
    params string\[\] globalKeywords
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input message to be displayed to the user during the prompt. |
| params string[] globalKeywords | Input keywords from which the user is prompted to choose. |

### GetNestedEntity(PromptNestedEntityOptions)

#### Description
Gets the name of an entity selected by the user and the point used to select the entity.
```text
public PromptNestedEntityResult GetNestedEntity(
    PromptNestedEntityOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptNestedEntityOptions options | Input optional parameters of the prompt. |

### GetNestedEntity(string)

#### Description
Gets the name of an entity selected by the user and the point used to select the entity.
```text
public PromptNestedEntityResult GetNestedEntity(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input message to be displayed to the user during the prompt |

### GetPoint(PromptPointOptions)

#### Description
Gets user input for a point.
```text
public PromptPointResult GetPoint(
    PromptPointOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptPointOptions options | Input optional parameters of the prompt. |

### GetPoint(string)

#### Description
Gets user input for a point.
```text
public PromptPointResult GetPoint(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input message to be displayed to the user during the prompt. |

### GetSelection()

#### Description
Returns the selection set obtained.
```text
public PromptSelectionResult GetSelection();
```

### GetSelection(PromptSelectionOptions)

#### Description
This method gets a selection set using the supplied prompt selection options and no filter.
```text
public PromptSelectionResult GetSelection(
    PromptSelectionOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptSelectionOptions options | Input selection options |

### GetSelection(PromptSelectionOptions, SelectionFilter)

#### Description
This method gets a selection set using the supplied prompt selection options and the supplied filter.
```text
public PromptSelectionResult GetSelection(
    PromptSelectionOptions options, 
    SelectionFilter filter
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptSelectionOptions options | Input selection options |
| SelectionFilter filter | Input selection filter |

### GetSelection(SelectionFilter)

#### Description
Returns the selection set obtained using the filter.
```text
public PromptSelectionResult GetSelection(
    SelectionFilter filter
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| SelectionFilter filter | Input selection filter |

### GetString(PromptStringOptions)

#### Description
Gets user input for a string.
```text
public PromptResult GetString(
    PromptStringOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PromptStringOptions options | Input optional parameters of the prompt. |

### GetString(string)

#### Description
Returns the PromptResult object representing the result of the prompt operation.
```text
public PromptResult GetString(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input message to be displayed to the user during the prompt |

### GetViewportNumber

#### Description
Returns the viewport number.
```text
public int GetViewportNumber(
    Point point
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point point | Input point to get viewport number from |

### InitCommandVersion

#### Description
This function sets a variable in the current document establishing the version requested for the next command to be run. The return value is the old version prior to being set. Calling this method will no argument will initialize the value to 0, which indicates that no version has been established.
```text
public int InitCommandVersion(
    int nVersion
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int nVersion | The new version variable to set |

### PointToScreen

#### Description
Returns the 3D point pt on the screen with the viewport number.
```text
public Point PointToScreen(
    Point3d pt, 
    int viewportNumber
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d pt | Input point to grab |
| int viewportNumber | Input the point's viewport number |

### PointToWorld(Point)

#### Description
Returns the 3D point pt on the world view.
```text
public Point3d PointToWorld(
    Point pt
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point pt | Input point to grab |

### PointToWorld(Point, int)

#### Description
Returns the 3D point pt on the world view with the viewport number.
```text
public Point3d PointToWorld(
    Point pt, 
    int viewportNumber
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point pt | Input point to grab |
| int viewportNumber | Input the point's viewport number |

### PostCommandPrompt

#### Description
This function causes AutoCAD to repost the last command prompt message.
```text
public void PostCommandPrompt();
```

### Regen

#### Description
Regenerates the drawing.
```text
public void Regen();
```

### SelectAll()

#### Description
Returns the selection set obtained.
```text
public PromptSelectionResult SelectAll();
```

### SelectAll(SelectionFilter)

#### Description
Returns the selection set obtained using the filter.
```text
public PromptSelectionResult SelectAll(
    SelectionFilter filter
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| SelectionFilter filter | Input selection filter |

### SelectCrossingPolygon(Point3dCollection)

#### Description
Returns the selection set obtained.
```text
public PromptSelectionResult SelectCrossingPolygon(
    Point3dCollection polygon
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3dCollection polygon | Input collection of points that represent vertices of the polygon. |

### SelectCrossingPolygon(Point3dCollection, SelectionFilter)

#### Description
Returns the selection set obtained using the filter.
```text
public PromptSelectionResult SelectCrossingPolygon(
    Point3dCollection polygon, 
    SelectionFilter filter
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3dCollection polygon | Input collection of points that represent vertices of the polygon. |
| SelectionFilter filter | Input selection filter |

### SelectCrossingWindow(Point3d, Point3d)

#### Description
Returns the selection set obtained.
```text
public PromptSelectionResult SelectCrossingWindow(
    Point3d pt1, 
    Point3d pt2
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d pt1 | Input first corner of selection window |
| Point3d pt2 | Input opposite corner of selection window |

### SelectCrossingWindow(Point3d, Point3d, SelectionFilter)

#### Description
Returns the selection set obtained using the filter.
```text
public PromptSelectionResult SelectCrossingWindow(
    Point3d pt1, 
    Point3d pt2, 
    SelectionFilter filter
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d pt1 | Input first corner of selection window |
| Point3d pt2 | Input opposite corner of selection window |
| SelectionFilter filter | Input selection filter |

### SelectCrossingWindow(Point3d, Point3d, SelectionFilter, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This is SelectCrossingWindow, a member of class Editor.
```text
public PromptSelectionResult SelectCrossingWindow(
    Point3d pt1, 
    Point3d pt2, 
    SelectionFilter filter, 
    [MarshalAs(UnmanagedType.U1)] bool forceSubEntitySelection
);
```

### SelectFence(Point3dCollection)

#### Description
Returns the selection set obtained.
```text
public PromptSelectionResult SelectFence(
    Point3dCollection fence
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3dCollection fence | Input collection of points that represent vertices of the fence. |

### SelectFence(Point3dCollection, SelectionFilter)

#### Description
Returns the selection set obtained using the filter.
```text
public PromptSelectionResult SelectFence(
    Point3dCollection fence, 
    SelectionFilter filter
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3dCollection fence | Input collection of points that represent vertices of the fence. |
| SelectionFilter filter | Input selection filter |

### SelectImplied

#### Description
Selects the firstpick set.
```text
public PromptSelectionResult SelectImplied();
```

#### See Also
[Autodesk.AutoCAD.EditorInput.SelectionFlags Enumeration](Autodesk_AutoCAD_EditorInput_SelectionFlags.md "SelectionFlags Enumeration")

### SelectLast

#### Description
Selects last result from the prompt.
```text
public PromptSelectionResult SelectLast();
```

### SelectPrevious

#### Description
Selects previous result from the prompt.
```text
public PromptSelectionResult SelectPrevious();
```

### SelectWindow(Point3d, Point3d)

#### Description
Returns the selection set obtained.
```text
public PromptSelectionResult SelectWindow(
    Point3d pt1, 
    Point3d pt2
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d pt1 | Input first corner of selection window. |
| Point3d pt2 | Input opposite corner of selection window. |

### SelectWindow(Point3d, Point3d, SelectionFilter)

#### Description
Returns the selection set obtained using the filter.
```text
public PromptSelectionResult SelectWindow(
    Point3d pt1, 
    Point3d pt2, 
    SelectionFilter filter
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d pt1 | Input first corner of selection window |
| Point3d pt2 | Input opposite corner of selection window |
| SelectionFilter filter | Input selection filter |

### SelectWindowPolygon(Point3dCollection)

#### Description
Returns the selection set obtained.
```text
public PromptSelectionResult SelectWindowPolygon(
    Point3dCollection polygon
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3dCollection polygon | Input collection of points that represent vertices of the polygon. |

### SelectWindowPolygon(Point3dCollection, SelectionFilter)

#### Description
Returns the selection set obtained using the filter.
```text
public PromptSelectionResult SelectWindowPolygon(
    Point3dCollection polygon, 
    SelectionFilter filter
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3dCollection polygon | Input collection of points that represent vertices of the polygon. |
| SelectionFilter filter | Input selection filter |

### SetCurrentView

#### Description
Sets the current view of ViewTableRecord.
```text
public void SetCurrentView(
    ViewTableRecord value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ViewTableRecord value | Input new view table record value |

### SetImpliedSelection(ObjectId[])

#### Description
This is SetImpliedSelection, a member of class Editor.
```text
public void SetImpliedSelection(
    ObjectId\[\] selectedObjects
);
```

### SetImpliedSelection(SelectionSet)

#### Description
This is SetImpliedSelection, a member of class Editor.
```text
public void SetImpliedSelection(
    SelectionSet selectionSet
);
```

### Snap

#### Description
Changes the snap mode for the point at input.
```text
public Point3d Snap(
    string snapMode, 
    Point3d input
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string snapMode | Input new snap mode |
| Point3d input | Input point to place snap mode |

### StartUserInteraction(IntPtr)

#### Description
Returns a new EditorUserInteraction object.
```text
public EditorUserInteraction StartUserInteraction(
    IntPtr hwnd
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| modalForm | Input control form |

### StartUserInteraction(Window)

#### Description
This is StartUserInteraction, a member of class Editor.
```text
public EditorUserInteraction StartUserInteraction(
    Window window
);
```

### SwitchToModelSpace

#### Description
Switches the current view to model space.
```text
public void SwitchToModelSpace();
```

### SwitchToPaperSpace

#### Description
Switches the current view to paper space.
```text
public void SwitchToPaperSpace();
```

### TraceBoundary

#### Description
Returns the resulting boundary set in a DBObjectCollection.
```text
public DBObjectCollection TraceBoundary(
    Point3d seedPoint, 
    [MarshalAs(UnmanagedType.U1)] bool detectIslands
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d seedPoint | The seed point, in UCS, for the boundary trace. |
| [MarshalAs(UnmanagedType.U1)] bool detectIslands | A boolean indicating whether or not to detect islands. |

#### Returns
The resulting boundary set in a DBObjectCollection if the operation completed sucessfully. When called with detectIslands set to false, the result contains only one entry, representing the outer boundary. When called with detectIslands set to true, the result contain multiple entries. In this case, the last entry is the outermost boundary, and the succeeding entries represent the islands found.
### TurnForcedPickOff

#### Description
This function decrements the forced pick counter, and if the counter hits 0, disables forced picking, which means entity picking occurs under normal AutoCAD conditions, such as when input points are being acquired and an OSNAP mode is active, or normal entity selection operations.
```text
public int TurnForcedPickOff();
```

### TurnForcedPickOn

#### Description
This function will cause the AutoCAD input event mechanism to do a pick under the prevailing pick aperture on all digitizer events, regardless of whether a point is being acquired or whether any OSNAP modes are currently active. If a point is being acquired and OSNAP is active, the object snap aperture dimensions (system variable: APERTURE) define the pick box size. Otherwise the normal system variable PICKBOX value will be used. In the PointHistory enum, the following enum values are related to this capability, as indicated by their related comments: ForcedPick,ePickMask, DidNotPick, UsedPickBox, UsedOsnapBox. 
A count is maintained, so that if multiple applications want to force picking, it occurs until they are all done.
```text
public int TurnForcedPickOn();
```

### TurnSubentityWindowSelectionOff

#### Description
Using this function decrements a reference counter which, when zero, turns off subentity window selection.When subentity window selection is enabled, any form of a window selection (such as _W and _WP in acedSSGet()), coupled with a request of nested entity information (such as the ":n" mode in acedSSGet()), selects the main entity if one or more of the main entity's subentities is fully contained within the window. 
The turnSubentityWindowSelectionOn() method should be used to decrement the reference counter. 
This method will throw an exception if called when the internal reference counter is already zero.
```text
public void TurnSubentityWindowSelectionOff();
```

### TurnSubentityWindowSelectionOn

#### Description
Using this function increments a reference counter which, when non-zero, causes any form of a window selection (such as _W and _WP in acedSSGet()), coupled with a request of nested entity information (such as using the ":n" mode in acedSSGet()), to select the main entity if one or more of the main entity's subentities is fully contained within the window. 
The turnSubentityWindowSelectionOff() method should be used to decrement the reference counter.
```text
public void TurnSubentityWindowSelectionOn();
```

### UpdateScreen

#### Description
Refreshes the screen.
```text
public void UpdateScreen();
```

### UpdateTiledViewportsFromDatabase

#### Description
Updates the tiled viewports from the database.
```text
public void UpdateTiledViewportsFromDatabase();
```

### UpdateTiledViewportsInDatabase

#### Description
Updates the tiled viewports in the database.
```text
public void UpdateTiledViewportsInDatabase();
```

### ViewportIdFromNumber

#### Description
Returns the object ID of the viewport from its number.
```text
public ObjectId ViewportIdFromNumber(
    int viewportNumber
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int viewportNumber | Input viewport number |

### WriteMessage(string)

#### Description
Displays a message on the AutoCAD text screen.
```text
public void WriteMessage(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input messsage |

### WriteMessage(string, params object[])

#### Description
Displays a message on the AutoCAD text screen.
```text
public void WriteMessage(
    string message, 
    params object\[\] parameter
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | Input message |
| params object[] parameter | Input array of objects to include |

### CommandResult Class

#### Description
This is class Autodesk.AutoCAD.EditorInput.Editor.CommandResult.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.Editor.CommandResult
```

```text
public sealed class CommandResult : INotifyCompletion;
```

### PauseToken Field

#### Description
Default definition is as a backslash ("\\\"). 
This token can be passed to the RunCommand() method in order to pause for interactive input.
```text
public const string PauseToken = @"\";
```

### ActiveViewportId

#### Description
Accesses the active viewport ID.
```text
public ObjectId ActiveViewportId;
```

#### Conditions
Read-only
### CommandResult.IsCompleted

#### Description
This is IsCompleted, a member of class CommandResult.
```text
public bool IsCompleted;
```

### CurrentUserCoordinateSystem

#### Description
Returns the current user coordinate system points.
```text
public Matrix3d CurrentUserCoordinateSystem;
```

#### Conditions
Read / Write
### CurrentViewportObjectId

#### Description
Returns the object id of current viewport.
```text
public ObjectId CurrentViewportObjectId;
```

#### Conditions
Read-only
### Document

#### Description
The document that this editor belongs to.
```text
public Autodesk.AutoCAD.ApplicationServices.Document Document;
```

#### Conditions
Read-only
### IsDragging

#### Description
Assesses if the screen is dragging.
```text
public bool IsDragging;
```

#### Conditions
Read-only
### IsQuiescent

#### Description
Returns the isQuiescent property value.
```text
public bool IsQuiescent;
```

#### Conditions
Read-only
### IsQuiescentForTransparentCommand

#### Description
Assesses if the editor is ready for transparent commands.
```text
public bool IsQuiescentForTransparentCommand;
```

#### Conditions
Read-only
### MouseHasMoved

#### Description
This property provides a way for input point monitors and filters to check for mouse movement and be able to return as quickly as possible from the callbacks without doing any time-consuming calculations. 
Returns true if there's another digitizer event in the queue.
```text
public bool MouseHasMoved;
```

#### Conditions
Read / Write
### UseCommandLineInterface

#### Description
Returns UseCommandLineInterface property value.
```text
public bool UseCommandLineInterface;
```

#### Conditions
Read-only