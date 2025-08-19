# GeoCoordinateSystem Class

## Overview

#### Description
The GeoCoordinate class represents a coordinate reference system (CRS) definition. A CRS is also being referred to as a spatial reference system (SRS). This is the wrapper class for the AcDbGeoCoordinateSystem class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GeoCoordinateSystem
```

```text
public class GeoCoordinateSystem : DisposableWrapper;
```

### Methods

- [Create](#create)
- [CreateAll()](#createall())
- [CreateAll(GeoCoordinateCategory)](#createall(geocoordinatecategory))
- [CreateAll(ValueType modopt(Point3d) modopt(IsBoxed))](#createall(valuetype-modopt(point3d)-modopt(isboxed)))
- [GetProjectionParamList](#getprojectionparamlist)

### Properties

- [CartesianExtents](#cartesianextents)
- [Datum](#datum)
- [Description](#description)
- [Ellipsoid](#ellipsoid)
- [EPSGcode](#epsgcode)
- [GeodeticExtents](#geodeticextents)
- [GeoUnit](#geounit)
- [ID](#id)
- [Offset](#offset)
- [ProjectionCode](#projectioncode)
- [Type](#type)
- [Unit](#unit)
- [UnitScale](#unitscale)
- [WktRepresentation](#wktrepresentation)
- [XmlRepresentation](#xmlrepresentation)


## Methods Details

### Create

#### Description
Instantiates a new GeoCoordinateSystem object from the current virtual catalog. If no such CRS definition exists but the input string contains enough information (i.e. WKT or XML) for constructing a temporary AcDbGeoCoordinateSystem instance, this is being returned instead.
```text
public static GeoCoordinateSystem Create(
    string coordSysIdOrFullDef
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string coordSysIdOrFullDef | A coordinate system name. For example: "WORLD-MERCATOR" |

#### Returns
GeoCoordinateSystem object.
### CreateAll()

#### Description
This is CreateAll, a member of class GeoCoordinateSystem.
```text
public static GeoCoordinateSystem\[\] CreateAll();
```

### CreateAll(GeoCoordinateCategory)

#### Description
This is CreateAll, a member of class GeoCoordinateSystem.
```text
public static GeoCoordinateSystem\[\] CreateAll(
    GeoCoordinateCategory coordCategory
);
```

### CreateAll(ValueType modopt(Point3d) modopt(IsBoxed))

#### Description
Instantiates a new AcDbGeoCoordinateSystem object for every existing, persistent project CRS definition from the current virtual catalog, when the passed in geodetic point within the geodetic extents of the CRS.
```text
public static GeoCoordinateSystem\[\] CreateAll(
    ValueType modopt(Point3d) modopt(IsBoxed) geoPt
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ValueType modopt(Point3d) modopt(IsBoxed) geoPt | Input geodetic point in (longitude, latitude, altitude) format. |

#### Returns
Array of GeoCoordinate objects.
### GetProjectionParamList

#### Description
This is GetProjectionParamList, a member of class GeoCoordinateSystem.
```text
public GeoProjectionParam\[\] GetProjectionParamList(
    [MarshalAs(UnmanagedType.U1)] bool includeSpecialParams
);
```

### CartesianExtents

#### Description
Gets the Cartesian extent of this CRS's.
```text
public Extents2d CartesianExtents;
```

#### Conditions
Read-only
### Datum

#### Description
Gets the datum, if any, referenced by this this CRS.
```text
public GeoDatum Datum;
```

#### Conditions
Read-only
### Description

#### Description
Gets the projection method of this CRS. The projection is the conversion of the CRS.
```text
public string Description;
```

#### Conditions
Read-only
### Ellipsoid

#### Description
Gets the related ellipsoid.
```text
public GeoEllipsoid Ellipsoid;
```

#### Conditions
Read-only
### EPSGcode

#### Description
Get this CRS's EPSG code.
```text
public int EPSGcode;
```

#### Conditions
Read-only
### GeodeticExtents

#### Description
Get the geodetic extent of this CRS's, the range of longitude and latitude.
```text
public Extents2d GeodeticExtents;
```

#### Conditions
Read-only
### GeoUnit

#### Description
Gets a factor, that the length units of this CRS instance must be multiplied with to calculate the equivalent in meters. If the CRS is geographic, this value represents the distance in meters of 1° measured along the equatorial great circle of the underlying ellipsoid.
```text
public GeoCSUnit GeoUnit;
```

#### Conditions
Read-only
### ID

#### Description
Get this CRS's identifier string, which is also being referred to as a (coordinate system) code.
```text
public string ID;
```

#### Conditions
Read-only
### Offset

#### Description
Gets the projection method parameter offset easting of this CRS.
```text
public Vector2d Offset;
```

#### Conditions
Read-only
### ProjectionCode

#### Description
Gets the unit of the coordinate system axis of this CRS. All axis contains the same unit.
```text
public GeoCSProjectionCode ProjectionCode;
```

#### Conditions
Read-only
### Type

#### Description
Get this definition's description, if there's any.
```text
public GeoCSType Type;
```

#### Conditions
Read-only
### Unit

#### Description
Gets the unit of the coordinate system axis of this CRS. All axis contains the same unit.
```text
public Autodesk.AutoCAD.DatabaseServices.UnitsValue Unit;
```

#### Conditions
Read-only
### UnitScale

#### Description
Gets a factor, that the length units of this CRS instance must be multiplied with to calculate the equivalent in meters. If the CRS is geographic, this value represents the distance in meters of 1° measured along the equatorial great circle of the underlying ellipsoid.
```text
public double UnitScale;
```

#### Conditions
Read / Write
### WktRepresentation

#### Description
This is WktRepresentation, a member of class GeoCoordinateSystem.
```text
public string WktRepresentation;
```

### XmlRepresentation

#### Description
This is XmlRepresentation, a member of class GeoCoordinateSystem.
```text
public string XmlRepresentation;
```
