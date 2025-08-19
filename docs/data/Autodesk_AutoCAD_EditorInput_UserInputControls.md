# Autodesk.AutoCAD.EditorInput.UserInputControls Enumeration

## Overview

#### Description
This .NET class wraps the AcEdJig::UserInputControls ObjectARX class. 
Returns the bitwise OR'd value of all user input control settings in effect at the present time for this particular jig
```text
public enum UserInputControls {
  Accept3dCoordinates = 0x80,
  AcceptMouseUpAsPoint = 0x100,
  AcceptOtherInputString = 0x800,
  AnyBlankTerminatesInput = 0x200,
  DoNotEchoCancelForCtrlC = 4,
  DoNotUpdateLastPoint = 8,
  GovernedByOrthoMode = 1,
  GovernedByUCSDetect = 0x1000,
  InitialBlankTerminatesInput = 0x400,
  NoDwgLimitsChecking = 0x10,
  NoNegativeResponseAccepted = 0x40,
  NoZDirectionOrtho = 0x2000,
  NoZeroResponseAccepted = 0x20,
  NullResponseAccepted = 2,
  UseBasePointElevation = 0x8000
}
```

#### Members

| Members | Description |
| --- | --- |
| Accept3dCoordinates = 0x80 | Sets the "Accept Z coordinate" mode. Input is restricted to 2d input by default. |
| AcceptMouseUpAsPoint = 0x100 | Sets the "Use mouse up for points" mode. Mouse-up events do not register as points by default. |
| AcceptOtherInputString = 0x800 | Sets the "Accept non-keyword string input" mode. This mode is off by default. |
| AnyBlankTerminatesInput = 0x200 | Sets the "Any blank terminates input" mode. This mode is off by default. |
| DoNotEchoCancelForCtrlC = 4 | Sets the "Don't echo *Cancel* for Ctrl-C's" mode. This is off by default, and *Cancel* is displayed. |
| DoNotUpdateLastPoint = 8 | Sets the "Don't update last point" mode. The last point is updated by default. |
| GovernedByOrthoMode = 1 | Sets the "honor ORTHOMODE sysvar" bit of the user input request packet. By default, this bit is not set.Note that the Jig.acquirePoint(Point3d&, const Point3d&basePnt) method always honors the ORTHOMODE sysvar, regardless of this bit's state. |
| GovernedByUCSDetect = 0x1000 | Description to come. |
| InitialBlankTerminatesInput = 0x400 | Sets the "Initial blank terminates input" mode. This mode is off by default. |
| NoDwgLimitsChecking = 0x10 | Sets the "Do not check point limits" mode. Drawing limits are checked by default. |
| NoNegativeResponseAccepted = 0x40 | Sets the "Don't accept negative values" mode. Negative values are accepted by default. This works for the functions acquireDist() and acquireAngle() only. |
| NoZDirectionOrtho = 0x2000 | Description to come. |
| NoZeroResponseAccepted = 0x20 | Sets the "Don't accept zero values" mode. Zero values are accepted by default. This works for the functions acquireDist() and acquireAngle() only. |
| NullResponseAccepted = 2 | Sets the "null input acceptable" bit of the user input request packet. This bit is clear by default, and null input is not acceptable. |