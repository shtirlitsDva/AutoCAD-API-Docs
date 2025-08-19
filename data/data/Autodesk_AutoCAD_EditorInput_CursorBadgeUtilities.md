# CursorBadgeUtilities Class

## Overview

#### Description
This is class Autodesk.AutoCAD.EditorInput.CursorBadgeUtilities, which provides utility functions to manipulate cursor badges.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.CursorBadgeUtilities
```

```text
public class CursorBadgeUtilities;
```

### Methods

- [AddSupplementalCursorImage](#addsupplementalcursorimage)
- [GetSupplementalCursorOffset](#getsupplementalcursoroffset)
- [HasSupplementalCursorImage](#hassupplementalcursorimage)
- [RemoveSupplementalCursorImage](#removesupplementalcursorimage)
- [SetSupplementalCursorOffset](#setsupplementalcursoroffset)


## Methods Details

### AddSupplementalCursorImage

#### Description
Adds a supplemental cursor image. Only one cursor badge image can be shown at a time. If multiple features supply badges the last badge with the highest priorityOrder will be the badge shown.
```text
public bool AddSupplementalCursorImage(
    ImageBGRA32 cursorImage, 
    int priority
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ImageBGRA32 cursorImage | Input image |
| int priority | Stacking order badge should appear in. Higher numbers win. |

#### Returns
Returns true if successful.
### GetSupplementalCursorOffset

#### Description
Gets the cursor offset x, y, which is to the top right corner of the pickbox. 
#### Parameters
| x | x offset |
| --- | --- |
| y | y offset |

```text
public void GetSupplementalCursorOffset(
    ref int x, 
    ref int y
);
```

### HasSupplementalCursorImage

#### Description
Checks if the current supplemental cursor badge is set.
```text
public bool HasSupplementalCursorImage();
```

#### Returns
Returns true if there is supplemental cursor badge; otherwise false.
### RemoveSupplementalCursorImage

#### Description
Removes a previously added supplemental cursor badge.
```text
public bool RemoveSupplementalCursorImage(
    ImageBGRA32 cursorImage
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ImageBGRA32 cursorImage | Input image |

#### Returns
Returns true if successful.
### SetSupplementalCursorOffset

#### Description
Sets x, y to be the cursor offset to the top right corner of the pickbox.
```text
public void SetSupplementalCursorOffset(
    int x, 
    int y
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int y | Input Y offset |

#### Returns
Void