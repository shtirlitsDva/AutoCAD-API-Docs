# Autodesk.AutoCAD.DatabaseServices.ConstrainType Enumeration

## Overview

#### Description
This .NET class wraps the [AcDbHelix::ConstrainType](AcDbHelix__ConstrainType.md) ObjectARX enum. A constraint is used to make a variable constant. When using the height constraint, changes to any other parameters will not change the height. 
When you use a constraint, the order in which you set the properties on the helix is important. For example, to constrain the number of turns, you must set the number of turns before setting the height or turn height.
```text
public enum ConstrainType {
  TurnHeight,
  Turns,
  Height
}
```

#### Members
| Members | Description |
| --- | --- |
| TurnHeight |
| Turns |
| Height |