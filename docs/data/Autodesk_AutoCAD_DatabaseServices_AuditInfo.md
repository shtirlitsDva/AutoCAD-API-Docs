# AuditInfo Class

## Overview

#### Description
This .NET class wraps the AcDbAuditInfo ObjectARX class. 
This class tracks the basic audit information during a database Audit operation.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.AuditInfo
```

```text
public sealed class AuditInfo : DisposableWrapper;
```

#### See Also
Database.Audit, Database.AuditXData, DBObject.Audit, the AutoCAD AUDIT command, the AutoCAD RECOVER command

## Members

### Methods

- [ErrorsFixed](#errorsfixed)
- [ErrorsFound](#errorsfound)
- [IncNumEntities](#incnumentities)
- [PrintError(DBObject, string, string, string)](#printerror(dbobject,-string,-string,-string))
- [PrintError(string, string, string, string)](#printerror(string,-string,-string,-string))
- [PrintNumEntities](#printnumentities)
- [RequestRegen](#requestregen)
- [ResetNumEntities](#resetnumentities)

### Properties

- [AuditPass](#auditpass)
- [FixErrors](#fixerrors)
- [NumEntities](#numentities)
- [NumErrors](#numerrors)
- [NumFixes](#numfixes)


## Methods Details

### ErrorsFixed

#### Description
Increments the count of errors fixed that is maintained in the instance of AuditInfo by NumFixes.
```text
public void ErrorsFixed(
    int count
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int count | Input the number of errors fixed |

### ErrorsFound

#### Description
Increments the count of errors found that is maintained in the instance of AuditInfo.
```text
public void ErrorsFound(
    int count
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int count | Input the number of errors found |

### IncNumEntities

#### Description
Increments the count of entities being maintained in the instance of AuditInfo by 1.
```text
public void IncNumEntities();
```

### PrintError(DBObject, string, string, string)

#### Description
Prints out log information about the errors detected or fixed using the object pointed to by value to construct a "name" string for the object type (using the name method of the RxClass object for the object type pointed to by value). 
For example, if value points to an Handle object, then name will be "Handle."
```text
public void PrintError(
    DBObject value, 
    string value2, 
    string validation, 
    string defaultValue
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DBObject value | Input the name string will be extracted. |
| string value2 | Input a string describing the value of the bad data |
| string validation | Input a string describing the reason the data is bad |
| string defaultValue | Input a string describing the default value it is set to |

#### Notes
Any of the string fields can be a NULL string if desired.
### PrintError(string, string, string, string)

#### Description
Prints out log information about the errors detected or fixed.
```text
public void PrintError(
    string name, 
    string value, 
    string validation, 
    string defaultValue
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string name | Input a string describing the type of erroneous data found |
| string value | Input a string describing the value of the bad data |
| string validation | Input a string describing the reason the data is bad |
| string defaultValue | Input a string describing the default value it is set to |

#### Notes
Any of the string fields can be a NULL string if desired.
### PrintNumEntities

#### Description
If the current count of entities being maintained in the instance of AuditInfo is a multiple of 100, and msg is not NULL, then this function will print the string pointed to by msg followed by the current entity count out to the audit log file.
```text
public void PrintNumEntities(
    string msg
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string msg | Input the string to be printed |

### RequestRegen

#### Description
This method allows objects which are fixing themselves to tell audit that the windows need to be reloaded from the database. Otherwise the in-core window list remains in effect and the changes to the database are overwritten at the next save time.
```text
public void RequestRegen();
```

### ResetNumEntities

#### Description
Resets the count of entities being maintained in the instance of AuditInfo to zero.
```text
public void ResetNumEntities();
```

### AuditPass

#### Description
Two passes through each object's data are made during the AUDIT command. This method returns if it is PASS1 or PASS2.
```text
public Autodesk.AutoCAD.DatabaseServices.AuditPass AuditPass;
```

#### Conditions
Read-only
### FixErrors

#### Description
Returns true if errors are to be fixed by the entity that is being implemented.
```text
public bool FixErrors;
```

#### Conditions
Read-only
### NumEntities

#### Description
Returns the count maintained in the instance of AuditInfo of the number of entities that were processed.
```text
public int NumEntities;
```

#### Conditions
Read-only
### NumErrors

#### Description
Accesses the count maintained in the instance of AuditInfo of the number of errors.
```text
public int NumErrors;
```

#### Conditions
Read-only
### NumFixes

#### Description
Returns the count maintained in the instance of AuditInfo of the number of errors fixed.
```text
public int NumFixes;
```

#### Conditions
Read-only