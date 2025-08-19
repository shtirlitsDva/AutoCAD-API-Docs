# LivePreview Class

## Overview

#### Description
This is class Autodesk.AutoCAD.EditorInput.LivePreview.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.LivePreview
```

```text
public sealed class LivePreview : DisposableWrapper;
```

### Constructors

- [LivePreview()](#livepreview())
- [LivePreview(Document)](#livepreview(document))
- [LivePreview(Document, [MarshalAs(UnmanagedType.U1)] bool)](#livepreview(document,-[marshalas(unmanagedtype.u1)]-bool))

### Events

- [PreviewEnded](#previewended)
- [Previewing](#previewing)
- [PreviewStarted](#previewstarted)
- [PreviewWillEnd](#previewwillend)
- [PreviewWillStart](#previewwillstart)
- [RecordingEnded](#recordingended)
- [RecordingStarted](#recordingstarted)
- [RecordingWillEnd](#recordingwillend)
- [RecordingWillStart](#recordingwillstart)

### Methods

- [AbortAll](#abortall)
- [DeleteUnmanagedObject](#deleteunmanagedobject)
- [EndPreview()](#endpreview())
- [EndPreview([MarshalAs(UnmanagedType.U1)] bool)](#endpreview([marshalas(unmanagedtype.u1)]-bool))
- [EndPreview(int)](#endpreview(int))
- [EndPreview(int, [MarshalAs(UnmanagedType.U1)] bool)](#endpreview(int,-[marshalas(unmanagedtype.u1)]-bool))
- [EndRecording](#endrecording)
- [IsPreviewRecording()](#ispreviewrecording())
- [IsPreviewRecording(Document)](#ispreviewrecording(document))
- [IsPreviewStarted()](#ispreviewstarted())
- [IsPreviewStarted(Document)](#ispreviewstarted(document))
- [QueueAction(LivePreviewActionBase)](#queueaction(livepreviewactionbase))
- [QueueAction(LivePreviewActionBase, int)](#queueaction(livepreviewactionbase,-int))
- [StartRecording](#startrecording)


## Constructors Details

### LivePreview()

#### Description
This is LivePreview, a member of class LivePreview.
```text
public LivePreview();
```

### LivePreview(Document)

#### Description
This is LivePreview, a member of class LivePreview.
```text
public LivePreview(
    Document doc
);
```

### LivePreview(Document, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This is LivePreview, a member of class LivePreview.
```text
public LivePreview(
    Document doc, 
    [MarshalAs(UnmanagedType.U1)] bool startPending
);
```

### PreviewEnded

#### Description
This is PreviewEnded, a member of class LivePreview.
```text
public static event EventHandler<LivePreviewEventArgs> PreviewEnded;
```

### Previewing

#### Description
This is Previewing, a member of class LivePreview.
```text
public event EventHandler<LivePreviewEventArgs> Previewing;
```

### PreviewStarted

#### Description
This is PreviewStarted, a member of class LivePreview.
```text
public static event EventHandler<LivePreviewEventArgs> PreviewStarted;
```

### PreviewWillEnd

#### Description
This is PreviewWillEnd, a member of class LivePreview.
```text
public static event EventHandler<LivePreviewEventArgs> PreviewWillEnd;
```

### PreviewWillStart

#### Description
This is PreviewWillStart, a member of class LivePreview.
```text
public static event EventHandler<LivePreviewEventArgs> PreviewWillStart;
```

### RecordingEnded

#### Description
This is RecordingEnded, a member of class LivePreview.
```text
public static event EventHandler<LivePreviewEventArgs> RecordingEnded;
```

### RecordingStarted

#### Description
This is RecordingStarted, a member of class LivePreview.
```text
public static event EventHandler<LivePreviewEventArgs> RecordingStarted;
```

### RecordingWillEnd

#### Description
This is RecordingWillEnd, a member of class LivePreview.
```text
public static event EventHandler<LivePreviewEventArgs> RecordingWillEnd;
```

### RecordingWillStart

#### Description
This is RecordingWillStart, a member of class LivePreview.
```text
public static event EventHandler<LivePreviewEventArgs> RecordingWillStart;
```

### AbortAll

#### Description
This is AbortAll, a member of class LivePreview.
```text
public void AbortAll();
```

### DeleteUnmanagedObject

#### Description
This is DeleteUnmanagedObject, a member of class LivePreview.
```text
protected sealed override void DeleteUnmanagedObject();
```

### EndPreview()

#### Description
This is EndPreview, a member of class LivePreview.
```text
public void EndPreview();
```

### EndPreview([MarshalAs(UnmanagedType.U1)] bool)

#### Description
This is EndPreview, a member of class LivePreview.
```text
public void EndPreview(
    [MarshalAs(UnmanagedType.U1)] bool bRegen
);
```

### EndPreview(int)

#### Description
This is EndPreview, a member of class LivePreview.
```text
public void EndPreview(
    int delayTime
);
```

### EndPreview(int, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This is EndPreview, a member of class LivePreview.
```text
public void EndPreview(
    int delayTime, 
    [MarshalAs(UnmanagedType.U1)] bool bRegen
);
```

### EndRecording

#### Description
This is EndRecording, a member of class LivePreview.
```text
public void EndRecording();
```

### IsPreviewRecording()

#### Description
This is IsPreviewRecording, a member of class LivePreview.
```text
public static bool IsPreviewRecording();
```

### IsPreviewRecording(Document)

#### Description
This is IsPreviewRecording, a member of class LivePreview.
```text
public static bool IsPreviewRecording(
    Document doc
);
```

### IsPreviewStarted()

#### Description
This is IsPreviewStarted, a member of class LivePreview.
```text
public static bool IsPreviewStarted();
```

### IsPreviewStarted(Document)

#### Description
This is IsPreviewStarted, a member of class LivePreview.
```text
public static bool IsPreviewStarted(
    Document doc
);
```

### QueueAction(LivePreviewActionBase)

#### Description
This is QueueAction, a member of class LivePreview.
```text
public void QueueAction(
    LivePreviewActionBase action
);
```

### QueueAction(LivePreviewActionBase, int)

#### Description
This is QueueAction, a member of class LivePreview.
```text
public void QueueAction(
    LivePreviewActionBase action, 
    int delayTime
);
```

### StartRecording

#### Description
This is StartRecording, a member of class LivePreview.
```text
public void StartRecording();
```
