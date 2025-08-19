# Autodesk.AutoCAD.EditorInput.PointHistoryBits Enumeration

## Overview

#### Description
This .NET enum wraps the Acad::PointHistory ObjectARX enum. 
This enums represent bits in a history value that indicates what point filters had an effect on the point on a particular system event. 
The bits are independent from one another except for the following: 
  * Only one flag out of Ortho and PolarAngle will be returned at any given callout.
  * If NotDigitizer is set, then none of the following will ever be set: Gripped, CartSnapped, Ortho, and CyclingPt; but the rest of the flags are independent. In NotDigitizer events, the rawPoint, postGrippedPoint, cartesianSnappedPoint and orthoPoint values will all be identical.
  * (History & CoordinatePending) is really a mask for any of the e[XYZ]Pending coordinate point values directly preceding CoordinatePending.

```text
public enum PointHistoryBits {
  Aligned = 0x400,
  AppFiltered = 0x800,
  CartSnapped = 0x10,
  CoordinatePending = 0x70000,
  CyclingPoint = 0x40,
  DidNotPick = 0,
  ForcedPick = 0x1000,
  FromKeyboard = 0x80000,
  Gripped = 8,
  LastPoint = 4,
  NotDigitizer = 2,
  NotInteractive = 0x100000,
  ObjectSnapped = 0x80,
  Ortho = 0x20,
  PickAborted = 0x8000,
  PickMask = 0xe000,
  PolarAngle = 0x100,
  Tablet = 1,
  UsedObjectSnapBox = 0x4000,
  UsedPickBox = 0x2000,
  XPending = 0x10000,
  YPending = 0x20000,
  ZPending = 0x40000
}
```

#### Members

| Members | Description |
| --- | --- |
| Aligned = 0x400 | AutoAlign enabled. |
| AppFiltered = 0x800 | If a point filter is registered (only monitors will get this bit). |
| CartSnapped = 0x10 | Snap mode on ("old" cartesian snap). |
| CoordinatePending = 0x70000 | Mask for preceding pending coordinate bits. |
| CyclingPoint = 0x40 | Indicates caller is "cycling" so this is not the necessarily the best osnap/alignment computation. |
| DidNotPick = 0 | No picking was done, that is, ForcedPick and no OSNAP was performed. |
| ForcedPick = 0x1000 | "Forced Picking" is enabled. |
| FromKeyboard = 0x80000 | Coordinate has been typed in by the user. |
| Gripped = 8 | Fell into grip gravity. |
| LastPoint = 4 | Indicates lastPoint is valid. |
| NotDigitizer = 2 | Implies rawPoint was typed at keyboard, or fed by program, script, menu macro expansion, or digitizer pick event; anything but digitizer motion. |
| NotInteractive = 0x100000 | Coordinate came from a script, menu macro expansion, an AutoLISP (command) call, or ads_command(). |
| ObjectSnapped = 0x80 | OSNAP enabled. |
| Ortho = 0x20 | Ortho enabled. |
| PickAborted = 0x8000 | If picking of the apertureEntities has been aborted because of outstanding mouse move messages in the AutoCAD message queue. |
| PickMask = 0xe000 | AND mask to strip out "pick mode" bits to compare with DidNotPick, UsedPickBox and UsedOsnapBox as enums. More of these values may be used in the future. |
| PolarAngle = 0x100 | Polar Snap on. |
| Tablet = 1 | Implies window cursor tracking, as opposed to tablet mode. |
| UsedObjectSnapBox = 0x4000 | "Forced picking" used OSNAP box. |
| UsedPickBox = 0x2000 | "Forced picking" used Pick box; used as enum within. |
| XPending = 0x10000 | X coordinate pending. |
| YPending = 0x20000 | Y coordinate pending. |
| ZPending = 0x40000 | Z coordinate pending. |