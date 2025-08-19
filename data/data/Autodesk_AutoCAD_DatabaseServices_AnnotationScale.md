# AnnotationScale Class

## Overview

#### Description
This .NET class wraps the AcDbAnnotationScale ObjectARX class. 
That class represents a single annotation scale defined in a drawing in the form of an object context. Objects of the class are obtained from the AnnotationScale context collection.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ObjectContext
    Autodesk.AutoCAD.DatabaseServices.AnnotationScale
```

```text
public class AnnotationScale : ObjectContext;
```

### Constructors

- [AnnotationScale](#annotationscale)

### Properties

- [CollectionName](#collectionname)
- [DrawingUnits](#drawingunits)
- [IsTemporaryScale](#istemporaryscale)
- [Name](#name)
- [PaperUnits](#paperunits)
- [Scale](#scale)
- [UniqueIdentifier](#uniqueidentifier)


## Constructors Details

### AnnotationScale

#### Description
Default constructor.
```text
public AnnotationScale();
```

### CollectionName

#### Description
Accesses the name of the annotation scale collection
```text
public override string CollectionName;
```

#### Conditions
Read-only
### DrawingUnits

#### Description
Accesses the drawing units portion of the annotation scale.
```text
public double DrawingUnits;
```

#### Conditions
Read / Write
#### Notes
The drawing units must be positive and non-zero. Annotation scales are described as a ratio of paper units to drawing units. For example a scale of 1 inch = 1 foot has a paper units scale of 1.0, and a drawing units scale of 12.0, for an effective scale of 0.083.
### IsTemporaryScale

#### Description
Assesses whether the scale is temporarily stored in the drawing.
```text
public bool IsTemporaryScale;
```

#### Conditions
Read-only
#### Notes
The annotation scale collection in a drawing can contain temporary scale entries. These scale entries typically exist because attached XREF objects in the drawing have dependencies on scales that are not directly referenced by other objects in the drawing. Applications should not persist references to temporary scales, as other operations (for exampe detaching an XREF) may remove temporary scales from the collection. Temporary scales are not filed out to a drawing when it is saved.
### Name

#### Description
Accesses the name of the annotation scale. Annotation scale names are not guaranteed to be unique.
```text
public override string Name;
```

#### Conditions
Read / Write
### PaperUnits

#### Description
The paper units must be positive and non-zero. Annotation scales are described as a ratio of paper units to drawing units. For example a scale of 1 inch = 1 foot has a paper units scale of 1.0, and a drawing units scale of 12.0, for an effective scale of 0.083.
```text
public double PaperUnits;
```

#### Conditions
Read / Write
### Scale

#### Description
Accesses the annotation scale factor.
```text
public double Scale;
```

#### Conditions
Read-only
#### Notes
Annotation scales are described as a ratio of paper units to drawing units. For example a scale of 1 inch = 1 foot has a paper units scale of 1.0, and a drawing units scale of 12.0, for a scale factor of 0.083.
### UniqueIdentifier

#### Description
Accesses the unique annotation scale identifier.
```text
public override IntPtr UniqueIdentifier;
```

#### Conditions
Read-only
#### Notes
The unique identifier is invariant for the lifetime of this object and is unique amongst all annotation scale context instances.