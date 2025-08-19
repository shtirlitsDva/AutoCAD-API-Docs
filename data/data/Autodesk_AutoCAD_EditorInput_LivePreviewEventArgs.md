# LivePreviewEventArgs Class

## Overview

#### Description
This is class Autodesk.AutoCAD.EditorInput.LivePreviewEventArgs.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.LivePreviewEventArgs
```

```text
public sealed class LivePreviewEventArgs : EventArgs;
```

### Constructors

- [LivePreviewEventArgs()](#liveprevieweventargs())
- [LivePreviewEventArgs(Autodesk.AutoCAD.ApplicationServices.Document, params object[])](#liveprevieweventargs(autodesk.autocad.applicationservices.document,-params-object[]))
- [LivePreviewEventArgs(params object[])](#liveprevieweventargs(params-object[]))

### Methods

- [LockDocument](#lockdocument)

### Properties

- [CommandParameter](#commandparameter)
- [Document](#document)
- [Parameters](#parameters)


## Constructors Details

### LivePreviewEventArgs()

#### Description
This is LivePreviewEventArgs, a member of class LivePreviewEventArgs.
```text
public LivePreviewEventArgs();
```

### LivePreviewEventArgs(Autodesk.AutoCAD.ApplicationServices.Document, params object[])

#### Description
This is LivePreviewEventArgs, a member of class LivePreviewEventArgs.
```text
public LivePreviewEventArgs(
    Autodesk.AutoCAD.ApplicationServices.Document document, 
    params object\[\] parameters
);
```

### LivePreviewEventArgs(params object[])

#### Description
This is LivePreviewEventArgs, a member of class LivePreviewEventArgs.
```text
public LivePreviewEventArgs(
    params object\[\] parameters
);
```

### LockDocument

#### Description
This is LockDocument, a member of class LivePreviewEventArgs.
```text
public IDisposable LockDocument();
```

### CommandParameter

#### Description
This is CommandParameter, a member of class LivePreviewEventArgs.
```text
public object CommandParameter;
```

### Document

#### Description
This is Document, a member of class LivePreviewEventArgs.
```text
public Autodesk.AutoCAD.ApplicationServices.Document Document;
```

### Parameters

#### Description
This is Parameters, a member of class LivePreviewEventArgs.
```text
public object Parameters;
```
