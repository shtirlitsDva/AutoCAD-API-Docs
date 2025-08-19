# RegionAreaProperties Structure

## Overview

#### Description
This class encapsulates the data returned by the AcDbRegion::getAreaProp()ObjectARX function.
```text
public struct RegionAreaProperties {
}
```

### Properties

- [Area](#area)
- [Centroid](#centroid)
- [Extents](#extents)
- [MomentsOfInertia](#momentsofinertia)
- [Perimeter](#perimeter)
- [PrincipalMoments](#principalmoments)
- [ProductOfInertia](#productofinertia)
- [RadiiOfGyration](#radiiofgyration)


## Properties Details

### Area

#### Description
Returns the area of the Region
```text
public double Area;
```

#### Conditions
Read / Write
### Centroid

#### Description
Returns the centroid point of the Region
```text
public Point2d Centroid;
```

#### Conditions
Read / Write
### Extents

#### Description
Returns the extents of the Region
```text
public Extents2d Extents;
```

#### Conditions
Read / Write
### MomentsOfInertia

#### Description
Returns the moments of inertia of the Region
```text
public Vector2d MomentsOfInertia;
```

#### Conditions
Read / Write
### Perimeter

#### Description
Returns the perimeter of the Region.
```text
public double Perimeter;
```

#### Conditions
Read / Write
### PrincipalMoments

#### Description
Returns the principal moments of the Region.
```text
public Vector2d PrincipalMoments;
```

#### Conditions
Read / Write
### ProductOfInertia

#### Description
Returns the product of inertia of the Region
```text
public double ProductOfInertia;
```

#### Conditions
Read / Write
### RadiiOfGyration

#### Description
Returns the radii of gyration of the Region
```text
public Vector2d RadiiOfGyration;
```

#### Conditions
Read / Write