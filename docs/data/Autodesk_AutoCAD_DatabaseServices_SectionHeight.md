# Autodesk.AutoCAD.DatabaseServices.SectionHeight Enumeration

## Overview

#### Description
This .NET class wraps the AcDbSection::Height ObjectARX enum. 
It gives the height of the section plane above or below the section line. The returned height is the indicator height when the section plane type is either plane or boundary, since the cut extends infinitely in the vertical direction for these two types. The height of the cut is returned when the section plane type is volume.
```text
public enum SectionHeight {
  HeightAboveSectionLine = 1,
  HeightBelowSectionLine = 2
}
```

#### Members

| Members | Description |
| --- | --- |
| HeightAboveSectionLine = 1 | Height of the section plane above section line - from the section plane elevation to the top line of the section plane. |
| HeightBelowSectionLine = 2 | Height of the section plane below the section line - from the section plane elevation to the bottom line of the section plane. |