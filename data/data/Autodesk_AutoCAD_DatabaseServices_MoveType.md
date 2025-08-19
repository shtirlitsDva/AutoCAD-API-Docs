# Autodesk.AutoCAD.DatabaseServices.MoveType Enumeration

## Overview

#### Description
This .NET class wraps the AcDbMLeader::MoveType ObjectARX enum. 
It describes the way in which MLeaders can be moved.
```text
public enum MoveType {
  MoveAllPoints,
  MoveAllExceptArrowHeaderPoints,
  MoveContentAndDoglegPoints
}
```

#### Members
| Members | Description |
| --- | --- |
| MoveAllPoints | Move all MLeader points |
| MoveAllExceptArrowHeaderPoints | Move all MLeader points except leaderline's arrowhead points |
| MoveContentAndDoglegPoints | Move dogleg and MLeader content points |