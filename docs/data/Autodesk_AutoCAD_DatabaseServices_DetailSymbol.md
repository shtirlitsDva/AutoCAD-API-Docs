# DetailSymbol Class

## Overview

#### Description
The DetailSymbol class represents the detail view symbol entity used by model documentation views in association with a Viewport entity.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.DetailSymbol
```

```text
public class DetailSymbol : Entity;
```

#### See Also
Autodesk.AutoCAD.DatabaseServices.Viewport;, Autodesk.AutoCAD.DatabaseServices.DetailViewStyle

## Members

### Constructors

- [DetailSymbol](#detailsymbol)

### Methods

- [IsOverriddenProperty](#isoverriddenproperty)

### Properties

- [BoundarySize](#boundarysize)
- [BoundaryType](#boundarytype)
- [DetailViewScale](#detailviewscale)
- [Direction](#direction)
- [DisplayIdentifier](#displayidentifier)
- [Identifier](#identifier)
- [IdentifierPosition](#identifierposition)
- [ModelEdgeDirection](#modeledgedirection)
- [ModelEdgeOrigin](#modeledgeorigin)
- [ModelEdgeType](#modeledgetype)
- [Origin](#origin)
- [OwningViewScale](#owningviewscale)
- [Scale](#scale)
- [SymbolStyleId](#symbolstyleid)


## Constructors Details

### DetailSymbol

#### Description
This .NET method wraps the ObjectARX method. For internal use only.
```text
public DetailSymbol();
```

### IsOverriddenProperty

#### Description
Tests the given flag to see if the property is overridden.
```text
public bool IsOverriddenProperty(
    DetailSymbolOverriddenProperty propertyToCheck
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| flag | Input: the NAMESPACE_ACDB::DetailViewModelEdge value to test if it is overridden |

#### Returns
Returns true of the specified property is overridden.
#### Remarks
This method wraps the AcDbDetailSymbol::isOverriddenProperty method.
### BoundarySize

#### Description
Returns the detail symbol's boundary size vector. The value is Vector2d.
```text
public virtual Vector2d BoundarySize;
```

#### Remarks
This is a read only property.
### BoundaryType

#### Description
The type of the detail symbol boundary. Value is NAMESPACE_ACDB::DetailSymbolBoundaryType.
```text
public DetailSymbolBoundaryType BoundaryType;
```

#### Remarks
This is a read only property.
#### See Also
NAMESPACE_ACDB::DetailSymbolBoundaryType

### DetailViewScale

#### Description
Returns the associated detail view's scale.
```text
public double DetailViewScale;
```

#### Remarks
This is a read only property.
### Direction

#### Description
Returns the detail symbol's direction vector. Value is Vector3d.
```text
public virtual Vector3d Direction;
```

#### Remarks
This is a read only property.
### DisplayIdentifier

#### Description
Returns flag indicating whether the detail symbol's identifier is to be displayed. Value is Boolean.
```text
public bool DisplayIdentifier;
```

#### Remarks
This is a read only property.
### Identifier

#### Description
The identifier of the detail symbol. Value is String.
```text
public string Identifier;
```

### IdentifierPosition

#### Description
Returns the detail symbol's identifier position.
```text
public virtual Point3d IdentifierPosition;
```

#### Remarks
This is a read only property.
### ModelEdgeDirection

#### Description
Returns the direction of the detail symbol's model edge (full boundary around detail view). Value is Vector3d.
```text
public virtual Vector3d ModelEdgeDirection;
```

#### Remarks
This is a read only property.
### ModelEdgeOrigin

#### Description
Returns the origin of the detail symbol's model edge (full boundary around detail view). Value is Point3d.
```text
public virtual Point3d ModelEdgeOrigin;
```

#### Remarks
This is a read only property.
### ModelEdgeType

#### Description
The type of the detail symbol Model Edge. Value is NAMESPACE_ACDB::DetailViewModelEdge.
```text
public DetailViewModelEdge ModelEdgeType;
```

#### Remarks
This is a read only property.
#### See Also
NAMESPACE_ACDB::DetailViewModelEdge DetailViewStyle::ModelEdge

### Origin

#### Description
Returns the detail symbol's origin. Value is Point3d.
```text
public virtual Point3d Origin;
```

#### Remarks
This is a read only property.
### OwningViewScale

#### Description
Returns the parent view's scale. Value is double.
```text
public double OwningViewScale;
```

#### Remarks
This is a read only property.
### Scale

#### Description
The scale of the detail symbol entity. Value is double.
```text
public double Scale;
```

### SymbolStyleId

#### Description
The object ID of the DetailViewStyle object associated with this entity. Value is the ObjectId.
```text
public ObjectId SymbolStyleId;
```

#### Remarks
This property wraps the AcDbDetailSymbol::symbolStyleId and AcDbDetailSymbol::setSymbolStyleId methods.
Example
```text
ObjectId styleId = detailSymbol.SymbolStyleId;
Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
ed.WriteMessage(" name = ");
DetailViewStyle detailViewStyle = (DetailViewStyle)trans.GetObject(styleId, OpenMode.ForRead);
ed.WriteMessage(detailViewStyle.Name)
```

#### See Also
Autodesk.AutoCAD.DatabaseServices.DetailViewStyle