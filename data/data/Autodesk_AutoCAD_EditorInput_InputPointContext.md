# InputPointContext Class

## Overview

#### Description
This class provides input parameters for the PointFilter and PointMonitor events. It wraps the input parameters of the AcEdInputPointFilter.processInputPoint() and AcEdInputPointMonitor.monitorInputPoint() ObjectARX functions.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.InputPointContext
```

```text
public sealed class InputPointContext : IDisposable;
```

### Methods

- [GetAlignmentPaths](#getalignmentpaths)
- [GetCustomObjectSnapModes](#getcustomobjectsnapmodes)
- [GetCustomObjectSnapOverrides](#getcustomobjectsnapoverrides)
- [GetKeyPointEntities](#getkeypointentities)
- [GetPickedEntities](#getpickedentities)

### Properties

- [CartesianSnappedPoint](#cartesiansnappedpoint)
- [ComputedPoint](#computedpoint)
- [Document](#document)
- [DrawContext](#drawcontext)
- [GrippedPoint](#grippedpoint)
- [History](#history)
- [LastPoint](#lastpoint)
- [ObjectSnapMask](#objectsnapmask)
- [ObjectSnapOverrides](#objectsnapoverrides)
- [ObjectSnappedPoint](#objectsnappedpoint)
- [PointComputed](#pointcomputed)
- [RawPoint](#rawpoint)
- [ToolTipText](#tooltiptext)


## Methods Details

### GetAlignmentPaths

#### Description
Input array that contains geometry of type Line3d (ortho and polar snap lines), LineSeg3d (extension lines), or EllipArc3d (extension arcs)
```text
public Curve3d\[\] GetAlignmentPaths();
```

### GetCustomObjectSnapModes

#### Description
Returns the custom OSNAP modes in effect, if pointComputed is true, and history has the Osnaped bit set.
```text
public CustomObjectSnapMode\[\] GetCustomObjectSnapModes();
```

### GetCustomObjectSnapOverrides

#### Description
Returns the custom osnap overrides currently active (even if they didn't participate in the calculation of the computedPoint).
```text
public CustomObjectSnapMode\[\] GetCustomObjectSnapOverrides();
```

### GetKeyPointEntities

#### Description
Returns the entities that were responsible for the calculation of the osnappedPoint. It contains usually one entity, except for the intersection-kind of osnap points (for these cases, keyPointEntities will contain two entities); plus one entry for each entry in the alignmentPaths array.
```text
public FullSubentityPath\[\] GetKeyPointEntities();
```

### GetPickedEntities

#### Description
Returns the picked entity array.
```text
public FullSubentityPath\[\] GetPickedEntities();
```

### CartesianSnappedPoint

#### Description
Returns the old-style snap if history has the CartSnapped bit set.
```text
public Point3d CartesianSnappedPoint;
```

#### Conditions
Read-only
### ComputedPoint

#### Description
Returns the point as it ends up for AutoCAD if pointComputed is true. It is always set, whether any built in filters are performed or not. AutoSnap computations could alter it from osnappedPoint.
```text
public Point3d ComputedPoint;
```

#### Conditions
Read / Write
### Document

#### Description
Returns the document object that this callback emanates from; this makes it easier to plant one instance on all input point managers, and determine which one is making the callback.
```text
public Autodesk.AutoCAD.ApplicationServices.Document Document;
```

#### Conditions
Read-only
### DrawContext

#### Description
Returns view transform, pixel sizes, and other context information; returns whatever visible graphics you want to display
```text
public ViewportDraw DrawContext;
```

#### Conditions
Read / Write
### GrippedPoint

#### Description
Returns the gripped point if history has the Gripped bit set.
```text
public Point3d GrippedPoint;
```

#### Conditions
Read-only
### History

#### Description
Returns the integer with bit fields as defined by the PointHistory enum.
```text
public PointHistoryBits History;
```

#### Conditions
Read-only
### LastPoint

#### Description
Returns the last point if history has the LastPoint bit set.
```text
public Point3d LastPoint;
```

#### Conditions
Read-only
### ObjectSnapMask

#### Description
Returns the current OSNAP modes in effect, if pointComputed is true, and history has the Osnapped bit set.
```text
public ObjectSnapMasks ObjectSnapMask;
```

#### Conditions
Read-only
### ObjectSnapOverrides

#### Description
Returns the osnap overrides currently active (even if they didn't participate in the calculation of the computedPoint).
```text
public ObjectSnapMasks ObjectSnapOverrides;
```

#### Conditions
Read-only
### ObjectSnappedPoint

#### Description
Returns the current OSNAP point, if pointComputed is true, and history has the Osnapped bit set.
```text
public Point3d ObjectSnappedPoint;
```

#### Conditions
Read-only
### PointComputed

#### Description
Returns true if the all the required points are valid, or false if they are not.
```text
public bool PointComputed;
```

#### Conditions
Read-only
### RawPoint

#### Description
Returns the point as tracked by the cursor position before subsequent filtering, or as entered via alternate means, which is subject to far less filtering. Valid only if pointComputed is true
```text
public Point3d RawPoint;
```

#### Conditions
Read-only
### ToolTipText

#### Description
Returns the final tool tip string, as determined by AutoCAD; can be altered by returning a new string.
```text
public string ToolTipText;
```

#### Conditions
Read-only