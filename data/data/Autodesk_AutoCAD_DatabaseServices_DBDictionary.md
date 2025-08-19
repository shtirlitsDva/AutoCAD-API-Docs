# DBDictionary Class

## Overview

#### Description
This .NET class wraps the AcDbDictionary ObjectARX class. 
DBDictionary is a database-resident object dictionary, which maintains a map between text strings and database objects. An instance of this class represents a single object, such as Drawing Symbol Table, to which objects derived from DBObject may be added, accessed, and removed. Entries in an DBDictionary must be unique. Entries consist of a unique DBObject and string, which comprises the entry's key name. The key may be either an explicit null-terminated text string, or an asterisk (' * ') as the first character in the string to signify an anonymous entry. An anonymous entry's key will be constructed internally by appending an 'A' plus a unique integer value to the asterisk; for example, '*A13'. 
When an object is placed in a dictionary, the dictionary is established as the object's owner, the lookup key string is associated with the object's object ID, and the dictionary itself is attached to the object as a persistent reactor so that the dictionary is notified when the object is erased.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.DBDictionary
        Autodesk.AutoCAD.DatabaseServices.DictionaryWithDefaultDictionary
```

```text
public class DBDictionary : DBObject, IDictionary;
```

#### Notes
Dictionary names honor the rules for symbol names. These general rules are: 
  * Names may be as long as you need them to be (longer than 32 characters, as defined by previous versions of AutoCAD).
  * Names may contain additional characters, such as the space character (' '), the apostrophe ('''), and so on.
  * Names are treated case-insensitively.
  * Names can not contain the following illegal characters: 
    * vertical bar ('|')
    * asterisk ('*'), except as noted above
    * backslash ('')
    * colon (':')
    * semicolon (';')
    * angle brackets ('>', '<')
    * question mark ('?')
    * double quote ('"')
    * comma (',')
    * equal sign ('=')
    * grave accent ('`')

When you're retrieving the key name of a dictionary entry and you are not the person that added that key, then you should make no assumption about the length or contents of the name. For example, if you create a dictionary and only place names of 20 characters in length into the dictionary, then you can safely assume that the dictionary will only contain names of 20 characters. If you are retrieving the key names from a dictionary that you did not create and may be updated by AutoCAD or other ARX programs, then you should be prepared to handle arbitrarily long names 
Object pointers retrieved from the database represent individual objects that are currently opened in the requested mode. The return status indicates the status for opening the entry object. If the status is not Acad.eOk, the returned pointer is NULL. 
Objects added to the dictionary must not have a presence in the database; that is, they must have NULL handles. 
When a dictionary is erased, all the objects within it are erased as well. When a dictionary is unerased, all its contents are unerased as well.
### Constructors

- [DBDictionary](#dbdictionary)

### Methods

- [Contains(ObjectId)](#contains(objectid))
- [Contains(string)](#contains(string))
- [Copy](#copy)
- [CopyTo](#copyto)
- [GetAt](#getat)
- [GetEnumerator](#getenumerator)
- [NameAt](#nameat)
- [Remove(ObjectId)](#remove(objectid))
- [Remove(string)](#remove(string))
- [SetAt](#setat)
- [SetName](#setname)

### Properties

- [Count](#count)
- [IncludingErased](#includingerased)
- [MergeStyle](#mergestyle)
- [TreatElementsAsHard](#treatelementsashard)


## Constructors Details

### DBDictionary

#### Description
Default constructor.
```text
public DBDictionary();
```

### Contains(ObjectId)

#### Description
Returns true if the object specified is in the dictionary.
```text
public bool Contains(
    ObjectId objId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId objId | Object to search for |

### Contains(string)

#### Description
Returns true if the object specified is in the dictionary.
```text
public bool Contains(
    string entryName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string entryName | Name to search by |

### Copy

#### Description
Copies the Dictionary object.
```text
protected virtual DBDictionary Copy();
```

### CopyTo

#### Description
Copies objects in array to this object, starting from index.
```text
public void CopyTo(
    DBDictionaryEntry\[\] array, 
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| DBDictionaryEntry[] array | Array to receive data from |
| int index | Index to begin at |

### GetAt

#### Description
This function searches the dictionary for an entry with key entryName and, if found, returns its object ID.
```text
public virtual ObjectId GetAt(
    string entryName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string entryName | String representing the entry's search key name to look for |

### GetEnumerator

#### Description
This function returns a new enumerator.
```text
public DbDictionaryEnumerator GetEnumerator();
```

### NameAt

#### Description
This function searches the dictionary for an entry with object ID objId and returns the search key name of the dictionary entry.
```text
public virtual string NameAt(
    ObjectId objId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId objId | Object ID to search for |

### Remove(ObjectId)

#### Description
This function removes an entry specified by its object ID in objId from the dictionary.
```text
public void Remove(
    ObjectId objId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId objId | Object ID of the object to remove |

### Remove(string)

#### Description
This function removes and entry specified by its 'key' from the dictionary.
```text
public ObjectId Remove(
    string key
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string key | String representing the entry's key (or name) |

### SetAt

#### Description
This function adds a new entry specified by newValue into the dictionary, if searchKey does not already exist in the dictionary. If the entry with key searchKey already exists, the existing entry is erased, the dictionary is removed from its reactor list, and it is replaced by the newValue object is added to the dictionary in its place. The name of the object is specified by searchKey. The object's objectId entry is returned.
```text
public ObjectId SetAt(
    string searchKey, 
    [CallerMustClose] DBObject newValue
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string searchKey | String representing the object's search key name |
| [CallerMustClose] DBObject newValue | The new object to add to the dictionary |

#### Notes
The UNDO command does not restore the data of the Xrecord in your dictionary after you have used the SetAt() method. You would find that the Xrecord is deleted after an UNDO command.
### SetName

#### Description
This function renames the entry specified by oldName to the new name specified by newName.
```text
public void SetName(
    string oldName, 
    string newName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string oldName | String representing the entry's old key string name |
| string newName | String representing the entry's new key string name |

### Count

#### Description
Accesses the number of items in the dictionary.
```text
public virtual int Count;
```

#### Conditions
Read-only
### IncludingErased

#### Description
Accesses the including erased property value
```text
public DBDictionary IncludingErased;
```

#### Conditions
Read-only
### MergeStyle

#### Description
Accesses the merge style property value.
```text
public override Autodesk.AutoCAD.DatabaseServices.DuplicateRecordCloning MergeStyle;
```

#### Conditions
Read / Write
### TreatElementsAsHard

#### Description
Accesses whether elements are treated hard or not.
```text
public bool TreatElementsAsHard;
```

#### Conditions
Read / Write