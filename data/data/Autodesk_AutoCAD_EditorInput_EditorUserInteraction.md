# EditorUserInteraction Class

## Overview

#### Description
This class allows users to interact with AutoCAD from within an application-defined modal dialog box. The application that defines the modal dialog box gets an instance of this class by calling the Editor.StartUserInteraction() method, typically from the dialog box handler. While using this object, the dialog box can invoke the AutoCAD editor to allow the user to make selections. After the user finishes selecting, the window focus automatically returns to the dialog box.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.EditorUserInteraction
```

```text
public sealed class EditorUserInteraction : IDisposable;
```

### Methods

- [End](#end)


## Methods Details

### End

#### Description
Calls Dispose() to end this user interaction.
```text
public void End();
```
