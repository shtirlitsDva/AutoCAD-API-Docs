# Solid3dMassProperties Structure

## Overview

#### Description
This class encapsulates the data returned by the 3dSolid.getMassProp()ObjectARX function. 
This is used for getting the volume properties of the solid (for example, mass properties with density == 1.0). All the properties are evaluated in the WCS.
```text
public struct Solid3dMassProperties {
}
```

### Constructors

- [Solid3dMassProperties](#solid3dmassproperties)

### Properties

- [Centroid](#centroid)
- [Extents](#extents)
- [MomentsOfIntertia](#momentsofintertia)
- [PrincipalMoments](#principalmoments)
- [ProductsOfIntertia](#productsofintertia)
- [RadiiOfGyration](#radiiofgyration)
- [Volume](#volume)


## Constructors Details

### Solid3dMassProperties

#### Description
Constructor.
```text
public Solid3dMassProperties(
    int dummy
);
```

### Centroid

#### Description
Returns the centroid of the solid.
```text
public Point3d Centroid;
```

#### Conditions
Read-only
### Extents

#### Description
Returns the extents (bounding box) of the solid.
```text
public Extents3d Extents;
```

#### Conditions
Read-only
### MomentsOfIntertia

#### Description
Returns the X, Y, and Z moments of inertia of the solid.
```text
public Vector3d MomentsOfIntertia;
```

#### Conditions
Read-only
### PrincipalMoments

#### Description
Returns the X, Y, and Z principal moments of the solid.
```text
public Vector3d PrincipalMoments;
```

#### Conditions
Read-only
### ProductsOfIntertia

#### Description
Returns the X, Y, and Z products of inertia of the solid.
```text
public Vector3d ProductsOfIntertia;
```

#### Conditions
Read-only
### RadiiOfGyration

#### Description
Returns the X, Y, and Z radii of gyration of the solid.
```text
public Vector3d RadiiOfGyration;
```

#### Conditions
Read-only
### Volume

#### Description
Returns the volume of the solid.
```text
public double Volume;
```

#### Conditions
Read-only