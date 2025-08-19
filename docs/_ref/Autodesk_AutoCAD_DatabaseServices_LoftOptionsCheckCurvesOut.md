# LoftOptionsCheckCurvesOut Class

## Overview

#### Description
This class is a container for the Boolean values output by the LoftOptions.checkLoftCurves() ObjectARX function.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.LoftOptionsCheckCurvesOut
```

```text
public class LoftOptionsCheckCurvesOut;
```

### Constructors

- [LoftOptionsCheckCurvesOut](#loftoptionscheckcurvesout)

### Properties

- [AllClosed](#allclosed)
- [AllOpen](#allopen)
- [AllPlanar](#allplanar)


## Constructors Details

### LoftOptionsCheckCurvesOut

#### Description
Default constructor.
```text
public LoftOptionsCheckCurvesOut();
```

### AllClosed

#### Description
Indicates whether all of the cross-section curves are closed
```text
public bool AllClosed;
```

#### Conditions
Read-only
### AllOpen

#### Description
Indicates whether all of the cross-section curves are open
```text
public bool AllOpen;
```

#### Conditions
Read-only
### AllPlanar

#### Description
Indicates whether all of the cross-section curves are planar
```text
public bool AllPlanar;
```

#### Conditions
Read-only