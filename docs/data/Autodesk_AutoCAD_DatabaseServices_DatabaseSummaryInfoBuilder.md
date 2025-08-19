# DatabaseSummaryInfoBuilder Class

## Overview

#### Description
This class is required to build instances of Autodesk.AutoCAD.DatabaseServices.DatabaseSummaryInfo, which is an immutable value type.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DatabaseSummaryInfoBuilder
```

```text
public class DatabaseSummaryInfoBuilder;
```

### Constructors

- [DatabaseSummaryInfoBuilder()](#databasesummaryinfobuilder())
- [DatabaseSummaryInfoBuilder(DatabaseSummaryInfo)](#databasesummaryinfobuilder(databasesummaryinfo))

### Methods

- [ToDatabaseSummaryInfo](#todatabasesummaryinfo)

### Properties

- [Author](#author)
- [Comments](#comments)
- [CustomProperties](#customproperties)
- [CustomPropertyTable](#custompropertytable)
- [HyperlinkBase](#hyperlinkbase)
- [Keywords](#keywords)
- [LastSavedBy](#lastsavedby)
- [RevisionNumber](#revisionnumber)
- [Subject](#subject)
- [Title](#title)


## Constructors Details

### DatabaseSummaryInfoBuilder()

#### Description
Default constructor.
```text
public DatabaseSummaryInfoBuilder();
```

### DatabaseSummaryInfoBuilder(DatabaseSummaryInfo)

#### Description
Copy constructor.
```text
public DatabaseSummaryInfoBuilder(
    DatabaseSummaryInfo value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DatabaseSummaryInfo value | Input Autodesk.AutoCAD.DatabaseServices.DatabaseSummaryInfo object. |

### ToDatabaseSummaryInfo

#### Description
This method returns a DatabaseSummaryInfo object that contains the values specified in this object.
```text
public DatabaseSummaryInfo ToDatabaseSummaryInfo();
```

### Author

#### Description
Accesses the author property value.
```text
public string Author;
```

#### Conditions
Read-only
### Comments

#### Description
Accesses the comments property value.
```text
public string Comments;
```

#### Conditions
Read-only
### CustomProperties

#### Description
Accesses the custom properties property value. 
This property is obsolete; use CustomPropertyTable instead.
```text
public StringDictionary CustomProperties;
```

#### Conditions
Read-only
### CustomPropertyTable

#### Description
Accesses the custom properties table collection.
```text
public IDictionary CustomPropertyTable;
```

#### Conditions
Read / Write
### HyperlinkBase

#### Description
Accesses the hyperlink base property value.
```text
public string HyperlinkBase;
```

#### Conditions
Read-only
### Keywords

#### Description
Accesses the keywords property value.
```text
public string Keywords;
```

#### Conditions
Read-only
### LastSavedBy

#### Description
Accesses the last saved by property value.
```text
public string LastSavedBy;
```

#### Conditions
Read-only
### RevisionNumber

#### Description
Accesses the revision number.
```text
public string RevisionNumber;
```

#### Conditions
Read-only
### Subject

#### Description
Accesses the subject value.
```text
public string Subject;
```

#### Conditions
Read-only
### Title

#### Description
Accesses the title.
```text
public string Title;
```

#### Conditions
Read-only