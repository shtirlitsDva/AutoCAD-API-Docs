# SecurityParameters Class

## Overview

#### Description
This .NET class wraps the SecurityParams ObjectARX struct. 
It stores information for security operations requested during DWG file I/O.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.SecurityParameters
```

```text
public sealed class SecurityParameters;
```

### Constructors

- [SecurityParameters()](#securityparameters())

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [Action](#action)
- [Algorithm](#algorithm)
- [Comment](#comment)
- [Issuer](#issuer)
- [Password](#password)
- [ProviderName](#providername)
- [SerialNumber](#serialnumber)
- [Subject](#subject)
- [TimeServer](#timeserver)


## Constructors Details

### SecurityParameters()

#### Description
Constructor.
```text
public SecurityParameters();
public SecurityParameters(
    string password, 
    string providerName, 
    string subject, 
    string issuer, 
    string serialNumber, 
    string comment, 
    string timeServer, 
    SecurityActions actions, 
    SecurityAlgorithm algorithm, 
    uint keyLength, 
    uint providerType
);
```

### Equals

#### Description
Returns true if this object is identical to the argument object.
```text
public sealed override bool Equals(
    object obj
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| object obj | Input object to compare |

### GetHashCode

#### Description
Returns the hash code for this object.
```text
public sealed override int GetHashCode();
```

### ToString()

#### Description
Returns an equivalent string representation of this object.
```text
public sealed override string ToString();
```

### ToString(IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider.
```text
public string ToString(
    IFormatProvider provider
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IFormatProvider provider | Input System.IFormatProvider object. |

### != Operator

#### Description
Returns true if a does not equal b.
```text
public static bool operator !=(
    SecurityParameters a, 
    SecurityParameters b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SecurityParameters a | Left operand |
| SecurityParameters b | Right operand |

### == Operator

#### Description
Returns true if a equals b.
```text
public static bool operator ==(
    SecurityParameters a, 
    SecurityParameters b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SecurityParameters a | Left operand |
| SecurityParameters b | Right operand |

### Action

#### Description
Accesses the
```text
public SecurityActions Action;
```

#### Conditions
Read / Write
### Algorithm

#### Description
Returns the algorithm identifier; must be SECURITYPARAMS_ALGID_RC4.
```text
public SecurityAlgorithm Algorithm;
```

#### Conditions
Read / Write
### Comment

#### Description
Returns the comment to be included with the signature.
```text
public string Comment;
```

#### Conditions
Read / Write
### Issuer

#### Description
Returns the name of the certificate (digital ID) issuer.
```text
public string Issuer;
```

#### Conditions
Read / Write
### Password

#### Description
Returns the password, formatted as a zero-terminated "wide-char" string.
```text
public string Password;
```

#### Conditions
Read / Write
### ProviderName

#### Description
Returns the name of the cryptography provider.
```text
public string ProviderName;
```

#### Conditions
Read / Write
### SerialNumber

#### Description
Returns the serial number of the certificate (digital ID).
```text
public string SerialNumber;
```

#### Conditions
Read / Write
### Subject

#### Description
Returns the name of the certificate (digital ID) subject.
```text
public string Subject;
```

#### Conditions
Read / Write
### TimeServer

#### Description
Returns the name of the time server used for timestamping. The name must be provided as a wide-char string in the format “Description(server_name)”. An example is “Natl Inst of Standards and Technology(time.nist.gov)”. 
If this member is NULL, the time from the local computer is used.
```text
public string TimeServer;
```

#### Conditions
Read / Write