# KeywordCollection Class

## Overview

#### Description
This class holds a collection of Keyword objects.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.KeywordCollection
```

```text
public sealed class KeywordCollection : ICollection, IEnumerable;
```

### Constructors

- [KeywordCollection](#keywordcollection)

### Methods

- [Add(string)](#add(string))
- [Add(string, string)](#add(string,-string))
- [Add(string, string, string)](#add(string,-string,-string))
- [Add(string, string, string, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#add(string,-string,-string,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [Clear](#clear)
- [CopyTo](#copyto)
- [GetDisplayString](#getdisplaystring)
- [GetEnumerator](#getenumerator)

### Properties

- [Count](#count)
- [Default](#default)
- [IsReadOnly](#isreadonly)


## Constructors Details

### KeywordCollection

#### Description
Constructor.
```text
public KeywordCollection();
```

### Add(string)

#### Description
Calls Add(globalName,globalName). 
Adds a keyword to the KeywordCollection class. 
Global name of the keyword is never displayed, but can be used by programs to access keywords when the local translation is not known.
```text
public void Add(
    string globalName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string globalName | Input the global name of the keyword; this is never displayed, but can be used by programs to access keywords when the local translation is not known. |

### Add(string, string)

#### Description
Calls Add(globalName,localName,localName). 
Adds a keyword to the KeywordCollection class. 
The user enters the local name to specify the keyword.
```text
public void Add(
    string globalName, 
    string localName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string globalName | Input the global name of the keyword; this is never displayed, but can be used by programs to access keywords when the local translation is not known. |
| string localName | Input the local name of the keyword; the user enters the local name to specify the keyword. |

### Add(string, string, string)

#### Description
Calls Add(globalName, localName,displayName, true, true). 
Adds a keyword to the KeywordCollection class. 
displayName this is shown on the command line and is usually the same as local name. 
```text
public void Add(
    string globalName, 
    string localName, 
    string displayName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string globalName | Input global name of the keyword; this is never displayed, but can be used by programs to access keywords when the local translation is not known. |
| string localName | Input local name of the keyword; the user enters the local name to specify the keyword. |
| string displayName | Input display name of the keyword; this is shown on the command line and is usually the same as local name. |

### Add(string, string, string, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Adds a keyword to the KeywordCollection class. 
visible indicates whether the keyword should be shown to the user. 
```text
public void Add(
    string globalName, 
    string localName, 
    string displayName, 
    [MarshalAs(UnmanagedType.U1)] bool visible, 
    [MarshalAs(UnmanagedType.U1)] bool enabled
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string globalName | Input global name of the keyword; this is never displayed, but can be used by programs to access keywords when the local translation is not known. |
| string localName | Input local name of the keyword; the user enters the local name to specify the keyword. |
| string displayName | Input display name of the keyword; this is shown on the command line and is usually the same as local name. |
| [MarshalAs(UnmanagedType.U1)] bool visible | Input indicates whether the keyword should be shows to the user. |
| [MarshalAs(UnmanagedType.U1)] bool enabled | Input indicates whether the keyword is currently enabled; a disabled keyword is disabled is not accepted as user input. |

### Clear

#### Description
Removes all elements from the KeywordCollection class.
```text
public void Clear();
```

### CopyTo

#### Description
Copies the KeywordCollection class or a portion of it to a one-dimensional array.
```text
public void CopyTo(
    Keyword\[\] array, 
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Keyword[] array | Input the one-dimensional Array that is the destination of the elements copied from KeywordCollection. The array must have zero-based indexing. |
| int index | Input the zero-based index in array at which copying begins. |

### GetDisplayString

#### Description
Gets a string that represent the keywords in this collection as they should be displayed to the user.
```text
public string GetDisplayString(
    [MarshalAs(UnmanagedType.U1)] bool showNoDefault
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool showNoDefault | Input true if the default values ought not be shown |

### GetEnumerator

#### Description
Returns an IEnumerator for the KeywordCollection.
```text
public IEnumerator GetEnumerator();
```

### Count

#### Description
Gets the number of elements actually contained in the KeywordCollection.
```text
public virtual int Count;
```

#### Conditions
Read / Write
### Default

#### Description
The default keyword to be used when the user presses ENTER without any other input.
```text
public string Default;
```

#### Conditions
Read / Write
### IsReadOnly

#### Description
Gets a value indicating whether the KeywordCollection is read-only. 
True if the KeywordCollection is read-only; otherwise, false. The default is false.
```text
public bool IsReadOnly;
```

#### Conditions
Read / Write