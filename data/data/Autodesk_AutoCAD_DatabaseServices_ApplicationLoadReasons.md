# Autodesk.AutoCAD.DatabaseServices.ApplicationLoadReasons Enumeration

## Overview

#### Description
This .NET class wraps the AcadApp::LoadReasons ObjectARX enum. 
That enumerated type contains reasons to demand load an application.
```text
public enum ApplicationLoadReasons {
  LoadDisabled = 0x10,
  OnAutoCADStartup = 2,
  OnCommandInvocation = 4,
  OnLoadRequest = 8,
  OnProxyDetection = 1,
  TransparentlyLoadable = 0x20
}
```

#### Members
| Members | Description |
| --- | --- |
| LoadDisabled = 0x10 | Do not demand load the .NET application for any reason |
| OnAutoCADStartup = 2 | Load the .NET application when AutoCAD starts up |
| OnCommandInvocation = 4 | Load the .NET application whenever an unknown command is executed for which it has a registry entry |
| OnLoadRequest = 8 | Allow loading of the .NET application |
| OnProxyDetection = 1 | Load the ObjectARX application when objects of custom classes it controls are loaded via drawing open, dxfin, insert, and so on |
| TransparentlyLoadable = 0x20 | Load the .NET application transparently |