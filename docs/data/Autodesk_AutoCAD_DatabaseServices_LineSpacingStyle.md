# Autodesk.AutoCAD.DatabaseServices.LineSpacingStyle Enumeration

## Overview

#### Description
This .NET class wraps the [AcDb::LineSpacingStyle](AcDb__LineSpacingStyle.md) ObjectARX enum. 
The LineSpacingStyle values are used by the MText property LineSpacingStyle to select the type of spacing. AtLeast specifies that the line spacing is a minimum that may be adjusted to accommodate larger font sizes or graphics that would not otherwise fit within the specified spacing. Exactly means that the line spacing is fixed and is never adjusted. This option makes all lines evenly spaced. 
A block of text with varying sizes can serve as an example. In this text, the "nominal" size is 0.2", but the word "BIG" is 0.5" high. The line spacing factor is 2 and the line spacing style is kAtLeast. 
"This is a testPwith some {H2.5x;BIG} inclusionsPin it."
This results in three lines of text: 
The "BIG" text is two and a half times as big as the surrounding text, and the line spacing factor (set with MText.LineSpacingFactor) is a multiplier of the nominal size. That is, the nominal size gets multiplied by this factor to compute where each line is supposed to be placed, where 1.0 is normal, 2.0 is double-spaced, and so on. The range is 0.25 (squashed together) to 4.0 (quadruple spacing). 
That means, with a line spacing factor of 2.0 and a line spacing style of AtLeast, every line is at least double-spaced, but the "BIG" part is spaced even more (as shown above), because it requires more space. An example with the same line spacing factor of 2.0 but a line spacing style of Exactly is shown below: 
All of these computations get complicated by the 5/3 rule. This rule says that line spacing is really 5/3 of the font size. To do the math, single-spaced 0.2" text is line-spaced at 1/3" (0.2" x 1.0 x 5/3 = 1/3"). A factor of 2.0 is 2/3" between baselines (0.2" x 2.0 x 5/3 = 2/3"). 
This is an artificial example, since there is seldom something that's two and a half times the size of surrounding text. But more realistically, stacked fractions are usually slightly larger than surrounding text (1.4-1.5 times the text size), and they impact line spacing for the lines that they are on. Also, some SHX fonts have unusual spacing requirements for some characters (' and " in Simplex, for example) that impact lines that the characters are on.
```text
public enum LineSpacingStyle {
  AtLeast = 1,
  Exactly = 2
}
```

#### Members

| Members | Description |
| --- | --- |
| AtLeast = 1 | Line spacing is a minimum that may be adjusted to accommodate larger font sizes or graphics that would not otherwise fit within the specified spacing |
| Exactly = 2 | Line spacing is fixed and is never adjusted |