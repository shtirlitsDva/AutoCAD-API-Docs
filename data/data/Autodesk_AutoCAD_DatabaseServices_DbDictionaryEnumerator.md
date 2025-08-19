# DbDictionaryEnumerator Class

## Overview

#### Description
This .NET class wraps the AcDbDictionaryIterator ObjectARX class. 
It provides the ability to iterate through an Dictionary.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DbDictionaryEnumerator
```

```text
public class DbDictionaryEnumerator : RXObject, IDictionaryEnumerator;
```

### Methods

- [MoveNext](#movenext)
- [Reset](#reset)

### Properties

- [Current](#current)
- [Entry](#entry)
- [Key](#key)
- [Value](#value)


## Methods Details

### MoveNext

#### Description
This function attempts to advance the iterator one entry in the dictionary. If another entry is found, it returns true; otherwise, it returns false.
```text
public virtual bool MoveNext();
```

### Reset

#### Description
Resets the iterating position.
```text
public virtual void Reset();
```

### Current

#### Description
Accesses the current iterated position.
```text
public DBDictionaryEntry Current;
```

#### Conditions
Read-only
### Entry

#### Description
Accesses the Entry property value.
```text
public DBDictionaryEntry Entry;
```

#### Conditions
Read-only
### Key

#### Description
Accesses the Key value for the iterated entry.
```text
public string Key;
```

#### Conditions
Read-only
### Value

#### Description
Accesses the value.
```text
public ObjectId Value;
```

#### Conditions
Read-only