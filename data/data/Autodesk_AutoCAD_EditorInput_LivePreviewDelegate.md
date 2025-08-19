# LivePreviewDelegate Class

## Overview

#### Description
This is class Autodesk.AutoCAD.EditorInput.LivePreviewDelegate.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.LivePreviewActionBase
    Autodesk.AutoCAD.EditorInput.LivePreviewDelegate
```

```text
public sealed class LivePreviewDelegate : LivePreviewActionBase;
```

### Constructors

- [LivePreviewDelegate(LivePreviewCallback)](#livepreviewdelegate(livepreviewcallback))
- [LivePreviewDelegate(LivePreviewCallback, LivePreviewCallback)](#livepreviewdelegate(livepreviewcallback,-livepreviewcallback))

### Methods

- [Execute](#execute)
- [OnAborted](#onaborted)


## Constructors Details

### LivePreviewDelegate(LivePreviewCallback)

#### Description
This is LivePreviewDelegate, a member of class LivePreviewDelegate.
```text
public LivePreviewDelegate(
    LivePreviewCallback actCallback
);
```

### LivePreviewDelegate(LivePreviewCallback, LivePreviewCallback)

#### Description
This is LivePreviewDelegate, a member of class LivePreviewDelegate.
```text
public LivePreviewDelegate(
    LivePreviewCallback actCallback, 
    LivePreviewCallback abortedCallback
);
```

### Execute

#### Description
This is Execute, a member of class LivePreviewDelegate.
```text
public sealed override void Execute();
```

### OnAborted

#### Description
This is OnAborted, a member of class LivePreviewDelegate.
```text
public sealed override void OnAborted();
```
