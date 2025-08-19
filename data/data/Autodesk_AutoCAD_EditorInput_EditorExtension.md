# EditorExtension Class

## Overview

#### Description
This is class Autodesk.AutoCAD.EditorInput.EditorExtension.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.EditorExtension
```

```text
public static class EditorExtension;
```

### Methods

- [GetViewportNumber](#getviewportnumber)
- [PointToScreen](#pointtoscreen)
- [PointToWorld(this Editor, Point)](#pointtoworld(this-editor,-point))
- [PointToWorld(this Editor, Point, int)](#pointtoworld(this-editor,-point,-int))
- [StartUserInteraction](#startuserinteraction)


## Methods Details

### GetViewportNumber

#### Description
This is GetViewportNumber, a member of class EditorExtension.
```text
public static int GetViewportNumber(
    this Editor editor, 
    Point point
);
```

### PointToScreen

#### Description
This is PointToScreen, a member of class EditorExtension.
```text
public static Point PointToScreen(
    this Editor editor, 
    Point3d pt, 
    int viewportNumber
);
```

### PointToWorld(this Editor, Point)

#### Description
This is PointToWorld, a member of class EditorExtension.
```text
public static Point3d PointToWorld(
    this Editor editor, 
    Point pt
);
```

### PointToWorld(this Editor, Point, int)

#### Description
This is PointToWorld, a member of class EditorExtension.
```text
public static Point3d PointToWorld(
    this Editor editor, 
    Point pt, 
    int viewportNumber
);
```

### StartUserInteraction

#### Description
This is StartUserInteraction, a member of class EditorExtension.
```text
public static EditorUserInteraction StartUserInteraction(
    this Editor editor, 
    Control modalForm
);
```
