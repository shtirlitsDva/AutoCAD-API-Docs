# Autodesk.AutoCAD.DatabaseServices.ModelerFlavor Enumeration

## Overview

#### Description
This .NET class wraps the AcDbHostApplicationServices::ModelerFlavor ObjectARX enum. 
It enumerates the possible levels of geometric modeler support available from the RealDWG host application.
```text
public enum ModelerFlavor {
  Full,
  RegionsOnly,
  ObjectsOnly
}
```

#### Members

| Members | Description |
| --- | --- |
| Full | Full modeler support |
| RegionsOnly | Read/view only for all |
| ObjectsOnly | For internal use only |