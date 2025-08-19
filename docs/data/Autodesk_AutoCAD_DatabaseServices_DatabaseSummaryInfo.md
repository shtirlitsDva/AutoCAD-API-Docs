# DatabaseSummaryInfo Structure

## Overview

#### Description
This .NET class wraps the [AcDbDatabaseSummaryInfo](AcDbDatabaseSummaryInfo.md) ObjectARX class. 
That class is a pure virtual class for encapsulating a set of character strings that can be used to add additional information to a DWG file. The maximum length of these strings is dependent on several items, but will always be at least 1,000 characters. This information is stored and retrieved in the SummaryInfo object with specific methods for each information field. 
You may create your own custom fields in addition to the predefined fields. These custom fields are stored in a list, and you can manipulate custom fields by either their name (or key) or by their position (index) in the list. Custom fields are indexed starting at 1, and there is no limit to the number of fields you may create.
```text
public struct DatabaseSummaryInfo {
}
```

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [Author](#author)
- [Comments](#comments)
- [CustomProperties](#customproperties)
- [HyperlinkBase](#hyperlinkbase)
- [Keywords](#keywords)
- [LastSavedBy](#lastsavedby)
- [RevisionNumber](#revisionnumber)
- [Subject](#subject)
- [Title](#title)


## Methods Details

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
| object obj | Input System.Object to compare |

### GetHashCode

#### Description
Returns the hash code for this object. See the Microsoft .NET API documentation for details.
```text
public sealed override int GetHashCode();
```

### ToString()

#### Description
Returns an equivalent string representation of this object. See the Microsoft .NET API documentation for details.
```text
public sealed override string ToString();
```

### ToString(IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider. See the Microsoft .NET API documentation for details.
```text
public string ToString(
    IFormatProvider provider
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IFormatProvider provider | Input System.IFormatProvider object |

### != Operator

#### Description
Compares the two operands and returns true if they are not equivalent.
```text
public static bool operator !=(
    DatabaseSummaryInfo a, 
    DatabaseSummaryInfo b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DatabaseSummaryInfo a | Input left operand |
| DatabaseSummaryInfo b | Input right operand |

### == Operator

#### Description
Compares the two operands and returns true if they are equivalent
```text
public static bool operator ==(
    DatabaseSummaryInfo a, 
    DatabaseSummaryInfo b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DatabaseSummaryInfo a | Input left operand |
| DatabaseSummaryInfo b | Input right operand |

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
```text
public IDictionaryEnumerator CustomProperties;
```

#### Conditions
Read-only
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