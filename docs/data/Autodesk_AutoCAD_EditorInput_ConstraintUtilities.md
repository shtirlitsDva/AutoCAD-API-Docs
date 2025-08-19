# ConstraintUtilities Class

## Overview

#### Description
This is class Autodesk.AutoCAD.EditorInput.ConstraintUtilities.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.ConstraintUtilities
```

```text
public class ConstraintUtilities;
```

### Methods

- [ShowConstraintBar](#showconstraintbar)


## Methods Details

### ShowConstraintBar

#### Description
This function is used to show or hide the constraint bars for all or a given set of constrained entities. 
```text
public static bool ShowConstraintBar(
    FullSubentityPath\[\] subentityPaths, 
    [MarshalAs(UnmanagedType.U1)] bool bToShow
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath[] subentityPaths | Array of full sub-entity paths of entities for which constraint bars are to be shown or hidden. If this array is empty, the show/hide action will then be applied to all constrained entities in the active document. |
| [MarshalAs(UnmanagedType.U1)] bool bToShow | Set this to true to show constraint bars, set to false to hide constraint bars. |

#### Returns
Returns true if successful, or false otherwise.