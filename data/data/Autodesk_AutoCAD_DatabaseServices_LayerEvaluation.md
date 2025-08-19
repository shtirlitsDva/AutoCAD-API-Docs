# Autodesk.AutoCAD.DatabaseServices.LayerEvaluation Enumeration

## Overview

#### Description
This .NET enum wraps the ObjectARX AcDb::LayerEvaluation enumeration. 
This enum supports the new API exposure of the LAYEREVAL header variable.
```text
public enum LayerEvaluation {
  NoNewLayerEvaluation,
  EvalNewXrefLayers,
  EvalAllNewLayers
}
```

#### Members
| Members | Description |
| --- | --- |
| NoNewLayerEvaluation | New layer creation is not tracked |
| EvalNewXrefLayers | Track new xref layers only |
| EvalAllNewLayers | Track new layer creation in the current drawing and attached xrefs |