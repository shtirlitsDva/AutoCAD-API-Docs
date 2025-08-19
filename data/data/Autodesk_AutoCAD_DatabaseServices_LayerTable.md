# LayerTable Class

## Overview

#### Description
This .NET class wraps the AcDbLayerTable ObjectARX class. 
This class is the symbol table for layers.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SymbolTable
        Autodesk.AutoCAD.DatabaseServices.LayerTable
```

```text
public sealed class LayerTable : SymbolTable;
```

### Methods

- [GenerateUsageData](#generateusagedata)
- [GetEnumerator](#getenumerator)
- [GetUnreconciledLayers](#getunreconciledlayers)

### Properties

- [HasUnreconciledLayers](#hasunreconciledlayers)
- [IncludingHidden](#includinghidden)
- [SkippingReconciled](#skippingreconciled)


## Methods Details

### GenerateUsageData

#### Description
Generates usage data for each LayerTableRecord in this layer table. The usage data is cached in LayerTableRecords and can be retrieved using the IsUsed property.
```text
public void GenerateUsageData();
```

### GetEnumerator

#### Description
This method returns an enumerator for this collection.
```text
public sealed override SymbolTableEnumerator GetEnumerator();
```

### GetUnreconciledLayers

#### Description
Retrieves the unreconciled layer.
#### Parameters
| Parameters | Description |
| --- | --- |
| idArray | Input ID of the array to retrieve the unreconciled layers |

Previous Declaration
```text
public unsafe void GetUnreconciledLayers( AcArray<AcDbObjectId,AcArrayMemCopyReallocator>* modopt (IsImplicitlyDereferenced) idArray);
```

### HasUnreconciledLayers

#### Description
Assesses if the table has unreconciled layers.
```text
public bool HasUnreconciledLayers;
```

#### Conditions
Read-only
### IncludingHidden

#### Description
Accesses the hidden layers.
```text
public LayerTable IncludingHidden;
```

#### Conditions
Read-only
### SkippingReconciled

#### Description
Accesses the skipped reconciled layers.
```text
public LayerTable SkippingReconciled;
```

#### Conditions
Read-only