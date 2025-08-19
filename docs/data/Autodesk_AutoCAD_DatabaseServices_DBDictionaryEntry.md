# DBDictionaryEntry Structure

## Overview

#### Description
This lightweight class represents an entry in a DatabaseServices.DBDictionary object. It contains the key and object ID of the entry, but does not contain the entry itself.
```text
public struct DBDictionaryEntry {
  public string m_key;
  public ObjectId m_value;
}
```

### Constructors

- [DBDictionaryEntry](#dbdictionaryentry)

### Methods

- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Other

- [m_key Field](#m_key-field)
- [m_value Field](#m_value-field)

### Properties

- [Key](#key)
- [Value](#value)


## Constructors Details

### DBDictionaryEntry

#### Description
This constructor creates a new object with the provided key and value.
```text
public DBDictionaryEntry(
    string key, 
    ObjectId value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string key | Original key |
| ObjectId value | Original object ID value |

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
| IFormatProvider provider | Input System.IFormatProvider object. |

### m_key Field

#### Description
Stores the key of an entry.
```text
public string m_key;
```

### m_value Field

#### Description
Stores the object ID of an entry.
```text
public ObjectId m_value;
```

### Key

#### Description
Accesses the Key property value.
```text
public string Key;
```

#### Conditions
Read / Write
### Value

#### Description
Accesses the Value property value.
```text
public ObjectId Value;
```

#### Conditions
Read / Write