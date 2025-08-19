# SectionHitTestInfo Structure

## Overview

#### Description
This class is a container for the hit test information returned by DatabaseServices.Section.HitTest()> .
```text
public struct SectionHitTestInfo {
}
```

### Constructors

- [SectionHitTestInfo](#sectionhittestinfo)

### Properties

- [Index](#index)
- [PtOnSegment](#ptonsegment)
- [SubItem](#subitem)


## Constructors Details

### SectionHitTestInfo

#### Description
Default constructor.
```text
public SectionHitTestInfo();
```

### Index

#### Description
Returns the zero-based index of the segment on the section line, which passes near or through the hit point.
```text
public int Index;
```

#### Conditions
Read-only
### PtOnSegment

#### Description
Returns the pointer to receive the actual point on the section plane geometry, or null if this is not required.
```text
public Point3d PtOnSegment;
```

#### Conditions
Read-only
### SubItem

#### Description
Returns or null if this is not required.
```text
public SectionSubItem SubItem;
```

#### Conditions
Read-only