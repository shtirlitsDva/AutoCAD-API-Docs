# SectionManager Class

## Overview

#### Description
This .NET class wraps the AcDbSectionManager ObjectARX class. 
This class is used to manage the section planes in a database. This class cannot be instantiated. An object of this class can be obtained form the database using the Database.getSectionManager() method.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.SectionManager
```

```text
public class SectionManager : DBObject, IEnumerable;
```

### Constructors

- [SectionManager](#sectionmanager)

### Methods

- [GetEnumerator](#getenumerator)
- [GetSection](#getsection)
- [GetUniqueSectionName](#getuniquesectionname)

### Properties

- [LiveSection](#livesection)
- [NumSections](#numsections)


## Constructors Details

### SectionManager

#### Description
Default constructor.
```text
public SectionManager();
```

### GetEnumerator

#### Description
Returns an enumerator for this collection.
```text
public IEnumerator GetEnumerator();
```

### GetSection

#### Description
Gets the section plane in the database by name.
```text
public ObjectId GetSection(
    string pszName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string pszName | Input name of the section plane to get |

### GetUniqueSectionName

#### Description
Gets a unique section plane name.
```text
public string GetUniqueSectionName(
    string pszBaseName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string pszBaseName | Input System.String object. |

### LiveSection

#### Description
Gets the currently enabled live section plane in the database. Live sectioning is either enabled or disabled individually per section object. Live sectioning can be active for no more than one section object at a time.
```text
public ObjectId LiveSection;
```

#### Conditions
Read-only
### NumSections

#### Description
Returns the number of section planes in the database.
```text
public int NumSections;
```

#### Conditions
Read-only