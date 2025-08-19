# Autodesk.AutoCAD.DatabaseServices.HatchPatternType Enumeration

## Overview

#### Description
This .NET class wraps the [AcDbHatch::HatchPatternType](AcDbHatch__HatchPatternType.md) ObjectARX class. 
AutoCAD hatch pattern types: User-defined, Predefined, and Custom. For more detailed information about hatch pattern format, please refer to _AutoCAD Customization Guide_.
```text
public enum HatchPatternType {
  UserDefined,
  PreDefined,
  CustomDefined
}
```

#### Members
| Members | Description |
| --- | --- |
| UserDefined | A user-defined pattern provides a direct method to define a simple hatch pattern using a specified hatch entity linetype. The definition data for user-defined hatch pattern include angle, space and double. "Angle" specifies an angle for the hatch pattern relative to the X axis of the hatch plane in OCS. "Space" defines the vertical distance between two consecutive pattern lines. "Double" specifies that a second set of lines is to be drawn at 90 degrees to the original lines. When specifying a user-defined hatch pattern, you don't need to set the pattern name. AutoCAD designates a default pattern name "U" for all user-defined patterns. |
| PreDefined | A predefined pattern type allows you to select a hatch pattern from the AutoCAD standard hatch pattern file _acad.pat_ in the "support" directory. The file contains many predefined hatch patterns, including ANGLE, ANSI31, BRICK, CLAY, etc. When you use a predefined pattern, you can also specify a scale and angle in order to modify the hatch's appearance. Solid fill is a new predefined pattern type that enables the application to fill in the hatch area with a specified color. The reserved name for this new pattern is "SOLID." SOLID does not appear in the file _acad.pat_ because it has no definition data |
| CustomDefined | A custom-defined pattern type stores the pattern in its own PAT file, in which the name of the hatch pattern must match the name of the file. For instance, you must store the TEST hatch pattern in a file named _test.pat_ , and the file must be located in the ACAD search path. When you use a custom-defined pattern, you can also specify a scale and angle in order to modify the hatch's appearance. |