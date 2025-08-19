# PointCloudCrop Class

## Overview

#### Description
This class defines a cropping boundary for the PointCloudEx entity. Each cropping boundary contains a plane which locates the boundary, a cropping type, a flag indicating whether we want what is inside or outside the region, another flag indicating whether the results of this cropping boundary should be inverted.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.PointCloudCrop
```

```text
public class PointCloudCrop : IDisposable;
```

### Methods

- [Clear](#clear)
- [Create](#create)
- [Dispose()](#dispose())
- [Dispose([MarshalAs(UnmanagedType.U1)] bool)](#dispose([marshalas(unmanagedtype.u1)]-bool))
- [IsValid](#isvalid)

### Properties

- [CropPlane](#cropplane)
- [CropType](#croptype)
- [Inside](#inside)
- [Inverted](#inverted)
- [Vertices](#vertices)


## Methods Details

### Clear

#### Description
Clears all cropping boundary information.
```text
public void Clear();
```

### Create

#### Description
Creates a PointCloudCrop instance.
```text
public static PointCloudCrop Create(
    IntPtr unmanagedObjPtr
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IntPtr unmanagedObjPtr | Specifies the AcDbPointCloudCrop pointer. For a valid pointer, it binds the created PointCloudCrop with it; if it is System::IntPtr::Zero, it creates a non-binded PointCloudCrop. |

### Dispose()

#### Description
This is Dispose, a member of class PointCloudCrop.
```text
public sealed override void Dispose();
```

### Dispose([MarshalAs(UnmanagedType.U1)] bool)

#### Description
This is Dispose, a member of class PointCloudCrop.
```text
protected virtual void Dispose(
    [MarshalAs(UnmanagedType.U1)] bool A_0
);
```

### IsValid

#### Description
Checks if this object represents a valid cropping boundary.
```text
public bool IsValid();
```

### CropPlane

#### Description
Gets or sets the plane on which this cropping boundary is defined.
```text
public Plane CropPlane;
```

#### Conditions
Read / Write
### CropType

#### Description
Gets or set the cropping boundary type for this object
```text
public PointCloudCropType CropType;
```

#### Conditions
Read / Write
### Inside

#### Description
Gets or sets whether this cropping boundary is allowing points inside of itself or outside.
```text
public bool Inside;
```

#### Conditions
Read / Write
### Inverted

#### Description
Gets or sets whether this cropping region's results are to be inverted.
```text
public bool Inverted;
```

#### Conditions
Read / Write
### Vertices

#### Description
Gets or sets the points array for point cloud crop boundary.
```text
public Point3dCollection Vertices;
```

#### Remarks
The array should include the start point for the type of rectangle and polygonal, for example: 
  * Rectangle - first corner point, 2nd, 3rd, 4th and first corner point again.
  * Polygonal - 1st, 2nd, 3rd, and etc. points, and the last point is also 1st point again.
  * Circular - there are 2 points, center point and any point which is on the circle's circumference.

#### Conditions
Read / Write