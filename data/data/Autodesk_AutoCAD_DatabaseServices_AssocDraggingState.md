# Autodesk.AutoCAD.DatabaseServices.AssocDraggingState Enumeration

## Overview

#### Description
While in the middle of evaluation, the action may inquire the client code whether the evaluation is happening from inside of the dragging loop and at which stage the dragging is.
```text
public enum AssocDraggingState {
  NotDraggingAssocDraggingState,
  FirstSampleAssocDraggingState,
  IntermediateSampleAssocDraggingState,
  LastSampleAssocDraggingState
}
```

#### Members
| Members | Description |
| --- | --- |
| NotDraggingAssocDraggingState | Not inside the dragging loop. |
| FirstSampleAssocDraggingState | The first drag sample of the dragging loop. |
| IntermediateSampleAssocDraggingState | An intemediate drag sample of the dragging loop. |
| LastSampleAssocDraggingState | The last drag sample of the dragging loop. |