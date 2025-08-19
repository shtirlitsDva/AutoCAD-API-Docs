# Autodesk.AutoCAD.DatabaseServices.TextVerticalMode Enumeration

## Overview

#### Description
This .NET class wraps the AcDb::TextVertMode ObjectARX class. 
It gives the vertical modes of the text. 
If vertical mode is set to any value other than .TextBase, then the text object's alignment point is used to determine the text's position. The position point is recalculated based on the text string and the alignment point's value. If vertical mode is .TextBase, then the position point is used to determine the text's position. The alignment point is recalculated based on the text string and the position point's value.
```text
public enum TextVerticalMode {
  TextBase,
  TextBottom,
  TextVerticalMid,
  TextTop
}
```

#### Members
| Members | Description |
| --- | --- |
| TextBase | TV_BASE |
| TextBottom | TV_BOT |
| TextVerticalMid | TV_TOP |
| TextTop | TV_MID |