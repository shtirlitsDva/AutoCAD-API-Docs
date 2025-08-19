# SymbolUtilityServices Class

## Overview

#### Description
This .NET class wraps the Services ObjectARX class within the AcDbSymbolUtilities namespace.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.SymbolUtilityServices
```

```text
public sealed class SymbolUtilityServices;
```

### Methods

- [GetBlockModelSpaceId](#getblockmodelspaceid)
- [GetBlockNameFromInsertPathName](#getblocknamefrominsertpathname)
- [GetBlockPaperSpaceId](#getblockpaperspaceid)
- [GetInsertPathNameFromBlockName](#getinsertpathnamefromblockname)
- [GetLayerDefpointsId](#getlayerdefpointsid)
- [GetLayerZeroId](#getlayerzeroid)
- [GetLinetypeByBlockId](#getlinetypebyblockid)
- [GetLinetypeByLayerId](#getlinetypebylayerid)
- [GetLinetypeContinuousId](#getlinetypecontinuousid)
- [GetMaxSymbolNameLength](#getmaxsymbolnamelength)
- [GetPathNameFromSymbolName](#getpathnamefromsymbolname)
- [GetRegAppAcadId](#getregappacadid)
- [GetSymbolNameFromPathName](#getsymbolnamefrompathname)
- [GetTextStyleStandardId](#gettextstylestandardid)
- [IsBlockLayoutName](#isblocklayoutname)
- [IsBlockModelSpaceName](#isblockmodelspacename)
- [IsBlockPaperSpaceName](#isblockpaperspacename)
- [IsCompatibilityMode](#iscompatibilitymode)
- [IsLayerDefpointsName](#islayerdefpointsname)
- [IsLayerZeroName](#islayerzeroname)
- [IsLinetypeByBlockName](#islinetypebyblockname)
- [IsLinetypeByLayerName](#islinetypebylayername)
- [IsLinetypeContinuousName](#islinetypecontinuousname)
- [IsRegAppAcadName](#isregappacadname)
- [IsTextStyleStandardName](#istextstylestandardname)
- [IsViewportActiveName](#isviewportactivename)
- [MakeDependentName](#makedependentname)
- [PreValidateSymbolName](#prevalidatesymbolname)
- [RepairPreExtendedSymbolName](#repairpreextendedsymbolname)
- [RepairSymbolName](#repairsymbolname)
- [ValidateCompatibleSymbolName](#validatecompatiblesymbolname)
- [ValidatePreExtendedSymbolName](#validatepreextendedsymbolname)
- [ValidateSymbolName](#validatesymbolname)

### Properties

- [BlockModelSpaceName](#blockmodelspacename)
- [BlockPaperSpaceName](#blockpaperspacename)
- [LayerDefpointsName](#layerdefpointsname)
- [LayerZeroName](#layerzeroname)
- [LinetypeByBlockName](#linetypebyblockname)
- [LinetypeByLayerName](#linetypebylayername)
- [LinetypeContinuousName](#linetypecontinuousname)
- [RegAppAcadName](#regappacadname)
- [TextStyleStandardName](#textstylestandardname)
- [ViewportActiveName](#viewportactivename)


## Methods Details

### GetBlockModelSpaceId

#### Description
Returns the ObjectId of the predefined symbol table record for the specified database. This method will always return a non-NULL ObjectId.
```text
public static ObjectId GetBlockModelSpaceId(
    Database databasePointer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database databasePointer | Input database to access |

### GetBlockNameFromInsertPathName

#### Description
Extract a suitable block name from a pathname. This method calls the GetSymbolNameFromPathName() method with "DXF;DWG" as the list of extensions to check.
```text
public static string GetBlockNameFromInsertPathName(
    string pathName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string pathName | Input path name to examine |

### GetBlockPaperSpaceId

#### Description
Returns the ObjectId of the predefined symbol table record for the specified database. This method will always return a non-NULL ObjectId.
```text
public static ObjectId GetBlockPaperSpaceId(
    Database databasePointer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database databasePointer | Input pointer to database to access |

### GetInsertPathNameFromBlockName

#### Description
This function copies the string pointed to by blockName (or an empty string if blockName is null) into the path name string. It then checks to see if the string ends with a .dwg or .dxf extension. This check is not case-sensitive. If the string does not have either extension, then .dwg is appended to the end of the path name string.
```text
public static string GetInsertPathNameFromBlockName(
    string blockName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string blockName | Input name of block from which to get the path |

### GetLayerDefpointsId

#### Description
Returns the ObjectId of the predefined symbol table record for the specified database. 
This method may return ObjectId.Null if the layer does not exist.
```text
public static ObjectId GetLayerDefpointsId(
    Database database
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database database | Input database to access |

### GetLayerZeroId

#### Description
Returns the ObjectId of the predefined symbol table record for the specified database. This method will always return a non-NULL ObjectId.
```text
public static ObjectId GetLayerZeroId(
    Database database
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database database | Input database to access |

### GetLinetypeByBlockId

#### Description
Returns the ObjectId of the predefined symbol table record for the specified database. This method will always return a non-NULL ObjectId.
```text
public static ObjectId GetLinetypeByBlockId(
    Database databasePointer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database databasePointer | Input database to access |

### GetLinetypeByLayerId

#### Description
Returns the ObjectId of the predefined symbol table record for the specified database. This method will always return a non-NULL ObjectId.
```text
public static ObjectId GetLinetypeByLayerId(
    Database databasePointer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database databasePointer | Input database to access |

### GetLinetypeContinuousId

#### Description
Returns the ObjectId of the predefined symbol table record for the specified database. This method will always return a non-NULL ObjectId.
```text
public static ObjectId GetLinetypeContinuousId(
    Database databasePointer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database databasePointer | Input database to access |

### GetMaxSymbolNameLength

#### Description
Returns the maximum allowed length for symbol names, if applicable. 
**Compatibility Mode (Value for EXTNAMES)**
| isNewName | false | true |
| --- | --- | --- |
| false | max=31 | max=255 |
| true | max=31 | not applicable |

```text
public static int GetMaxSymbolNameLength(
    [MarshalAs(UnmanagedType.U1)] bool isNewName, 
    [MarshalAs(UnmanagedType.U1)] bool compatibilityMode
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool isNewName | Input Boolean to indicate whether we want to the length for extended or legacy symbol names |
| [MarshalAs(UnmanagedType.U1)] bool compatibilityMode | Input Boolean to indicate extended or legacy symbol names |

### GetPathNameFromSymbolName

#### Description
This function copies the string pointed to by symbolName (or an empty string if symbolName is null) into path name. It then checks to see if the string ends with one of the extensions specified in extensions. This check is not case-sensitive. If the string does not end in one of the extensions specified in extensions, then a period ('.') followed by the first extension specified in extensions is appended to the end of the path name string. 
The extensions argument must be a list of file extensions separated by semicolons. The file extensions should not contain the '.' separator. For example: "dwg;dxf"
```text
public static string GetPathNameFromSymbolName(
    string symbolName, 
    string extensions
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string symbolName | Input name of block from which to get the path |
| string extensions | Input list of extensions for which to search |

#### Notes
The caller is responsible for releasing the memory used by the string returned in pathName. acutDelString() is the preferred way to do this.
### GetRegAppAcadId

#### Description
Returns the ObjectId of the predefined symbol table record for the specified database. This method will always return a non-NULL ObjectId.
```text
public static ObjectId GetRegAppAcadId(
    Database databasePointer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database databasePointer | Input database to access |

### GetSymbolNameFromPathName

#### Description
Extracts a suitable symbol name from a path name. The symbol name is the filename component of the path. Any of the specified filename extensions are removed. Lexical analysis of only the specified path is performed, and no attempt is made at any type of pathname validation or symbol name validation. Thus, the input pathname may be an invalid pathname and the resulting block name may be an invalid block name. If the pathname pointer is null, it is treated as an empty string. The solidus (‘/’) and backslash (‘\’) are treated as delimiters for directory names. Note that this function is meant to encapsulate a convention for extracting a block name from a pathname. It is not intended for use as a general purpose filename parsing utility. 
extensions is a semicolon-delimited list of filename extensions, for example "dwg;dxf". If this string is empty, no attempt is made to remove any extensions. If this list is just an asterisk ("*"), then any trailing extensions are removed from the path name.
```text
public static string GetSymbolNameFromPathName(
    string pathName, 
    string extensions
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string pathName | Input path name |
| string extensions | Input list of extensions to consider |

### GetTextStyleStandardId

#### Description
Returns the ObjectId of the predefined symbol table record for the specified database. This method will always return a non-NULL ObjectId.
```text
public static ObjectId GetTextStyleStandardId(
    Database databasePointer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database databasePointer | Input database to access |

### IsBlockLayoutName

#### Description
Returns true if the name is a name of a layout’s block-table record or the name of the main paper space block.
```text
public static bool IsBlockLayoutName(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to compare |

### IsBlockModelSpaceName

#### Description
Returns true if name matches a predefined symbol name. The string is normalized before the comparison to the predefined name.
```text
public static bool IsBlockModelSpaceName(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to compare |

### IsBlockPaperSpaceName

#### Description
Returns true if name matches a predefined symbol name. The string is normalized before the comparison to the predefined name
```text
public static bool IsBlockPaperSpaceName(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to compare |

### IsCompatibilityMode

#### Description
Retrieve the EXTNAMES setting of the specified database. True is returned if the database pointer is NULL or EXTNAMES is no longer applicable. The database pointer should not be NULL, so this condition causes an assert.
```text
public static bool IsCompatibilityMode(
    Database database
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database database | Input database to access |

### IsLayerDefpointsName

#### Description
Returns true if name matches a predefined symbol name. The string is normalized before the comparison to the predefined name.
```text
public static bool IsLayerDefpointsName(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to compare |

### IsLayerZeroName

#### Description
Returns true if name matches a predefined symbol name. The string is normalized before the comparison to the predefined name.
```text
public static bool IsLayerZeroName(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to compare |

### IsLinetypeByBlockName

#### Description
Returns true if name matches a predefined symbol name. The string is normalized before the comparison to the predefined name.
```text
public static bool IsLinetypeByBlockName(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to compare |

### IsLinetypeByLayerName

#### Description
Returns true if name matches a predefined symbol name. The string is normalized before the comparison to the predefined name.
```text
public static bool IsLinetypeByLayerName(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to compare |

### IsLinetypeContinuousName

#### Description
Returns true if name matches a predefined symbol name. The string is normalized before the comparison to the predefined name.
```text
public static bool IsLinetypeContinuousName(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to compare |

### IsRegAppAcadName

#### Description
Returns true if name matches a predefined symbol name. The string is normalized before the comparison to the predefined name.
```text
public static bool IsRegAppAcadName(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to compare |

### IsTextStyleStandardName

#### Description
Returns true if name matches a predefined symbol name. The string is normalized before the comparison to the predefined name.
```text
public static bool IsTextStyleStandardName(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to compare |

### IsViewportActiveName

#### Description
Returns true if name matches a predefined symbol name. The string is normalized before the comparison to the predefined name.
```text
public static bool IsViewportActiveName(
    string name
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to compare |

### MakeDependentName

#### Description
Performs the necessary concatenation of the specified drawing name and symbol name to create a dependent symbol name. No validation of the drawing name, symbol name, or the resulting symbol name is done.
```text
public static string MakeDependentName(
    string dwgName, 
    string symbolName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string dwgName | Input the drawing name |
| string symbolName | Input the symbol name |

### PreValidateSymbolName

#### Description
Perform any "pre-validation" steps on a string that will be validated as a symbol name: 
Normalize the name. If preserveCase is false, the symbol name is converted to uppercase. 
Strip leading and trailing whitespace.
#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool preserveCase | Input Boolean to indicate whether to preserve the case of alphabetic letters |

#### Notes
The correspondence between preserveCase and the meaning for EXTNAMES=1. When EXTNAMES=1, AutoCAD preserves the case of symbol names. When EXTNAMES=0, AutoCAD forces names to uppercase, which is the corresponding behavior of passing in false for preserveCase.
Previous Declaration
```text
public static string PreValidateSymbolName([MarshalAs(UnmanagedType.U1)] bool preserveCase);
```

### RepairPreExtendedSymbolName

#### Description
This method returns a "repaired" copy of the specified string. The method uses the same symbol name validation rules as the validation functions (such as validatePreExtendedSymbolname() and validateSymbolName()) except that the returned copy of the string does not contain any illegal characters. Those are replaced with valid replacement characters.
```text
public static string RepairPreExtendedSymbolName(
    string oldName, 
    [MarshalAs(UnmanagedType.U1)] bool allowVerticalBar
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string oldName | Input symbol name to repair |
| [MarshalAs(UnmanagedType.U1)] bool allowVerticalBar | Input Boolean to indicate is vertical bars are allowed in the symbol name |

### RepairSymbolName

#### Description
This method returns a "repaired" copy of the specified string. The method uses the same symbol name validation rules as the validation functions (such as validatePreExtendedSymbolname() and validateSymbolName()) except that the returned copy of the string does not contain any illegal characters. Those are replaced with valid replacement characters.
```text
public static string RepairSymbolName(
    string oldName, 
    [MarshalAs(UnmanagedType.U1)] bool allowVerticalBar
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string oldName | Input symbol name to repair |
| [MarshalAs(UnmanagedType.U1)] bool allowVerticalBar | Input Boolean to indicate if vertical bars are allowed in the symbol name |

### ValidateCompatibleSymbolName

#### Description
Validates name as a symbol name. If name is valid, it is then checked to see if it is within any applicable maximum name length. 
If isNewName is true, then the name is validated as if it will be used as a new symbol name. Otherwise, it is validated as if it is the name of an existing symbol name. 
If compatibilityMode is true, then the extended symbol name rules are used. Otherwise, the pre-extended legacy rules (that is, 31 characters, no spaces) are used. Note that this value corresponds to the true/false interpretation of EXTNAMES. If EXTNAMES=1, then AutoCAD uses the extended rules, and if EXTNAMES=0, then AutoCAD uses the pre-extended rules. 
If allowVerticalBar is true, then vertical bars are allowed in the symbol name.
```text
public static ErrorStatus ValidateCompatibleSymbolName(
    string name, 
    [MarshalAs(UnmanagedType.U1)] bool isNewName, 
    [MarshalAs(UnmanagedType.U1)] bool allowVerticalBar, 
    [MarshalAs(UnmanagedType.U1)] bool compatibilityMode
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to validate |
| [MarshalAs(UnmanagedType.U1)] bool isNewName | Input Boolean to indicate whether to treat the name as a new or an existing name |
| [MarshalAs(UnmanagedType.U1)] bool allowVerticalBar | Input Boolean to indicate whether to allow vertical bars in the name |
| [MarshalAs(UnmanagedType.U1)] bool compatibilityMode | Input Boolean to indicate whether the validate the name as an extended or legacy symbol name |

### ValidatePreExtendedSymbolName

#### Description
This method validates name according to the rules for legacy (AutoCAD Release 14 and earlier) symbol names. name should be a non-NULL pointer. allowVerticalBar should be true to indicate that vertical bars should be considered valid characters in the symbol name, or false if not. name is normalized before validating.
```text
public static void ValidatePreExtendedSymbolName(
    string name, 
    [MarshalAs(UnmanagedType.U1)] bool allowVerticalBar
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to validate |
| [MarshalAs(UnmanagedType.U1)] bool allowVerticalBar | Input Boolean to indicate if vertical bars are valid in the symbol name |

### ValidateSymbolName

#### Description
This method validates name according to the rules for extended (AutoCAD 2000 and later) symbol names. name should be a non-NULL pointer. allowVerticalBar should be true to indicate that vertical bars should be considered valid characters in the symbol name, or false if not. name is normalized before validating.
```text
public static void ValidateSymbolName(
    string name, 
    [MarshalAs(UnmanagedType.U1)] bool allowVerticalBar
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string name | Input name to validate |
| [MarshalAs(UnmanagedType.U1)] bool allowVerticalBar | Input Boolean to indicate if vertical bars are valid in the symbol name |

### BlockModelSpaceName

#### Description
Returns the string used as the value for the predefined symbol record. A NULL pointer or empty string will never be returned.
```text
public static string BlockModelSpaceName;
```

#### Conditions
Read-only
### BlockPaperSpaceName

#### Description
Returns the string used as the value for the predefined symbol record. A NULL pointer or empty string will never be returned.
```text
public static string BlockPaperSpaceName;
```

#### Conditions
Read-only
### LayerDefpointsName

#### Description
Returns the string used as the value for the predefined symbol record. A NULL pointer or empty string will never be returned.
```text
public static string LayerDefpointsName;
```

#### Conditions
Read-only
### LayerZeroName

#### Description
Returns the string used as the value for the predefined symbol record. A NULL pointer or empty string will never be returned.
```text
public static string LayerZeroName;
```

#### Conditions
Read-only
### LinetypeByBlockName

#### Description
Returns the string used as the value for the predefined symbol record. A NULL pointer or empty string will never be returned.
```text
public static string LinetypeByBlockName;
```

#### Conditions
Read-only
### LinetypeByLayerName

#### Description
Returns the string used as the value for the predefined symbol record. A NULL pointer or empty string will never be returned.
```text
public static string LinetypeByLayerName;
```

#### Conditions
Read-only
### LinetypeContinuousName

#### Description
Returns the string used as the value for the predefined symbol record. A NULL pointer or empty string will never be returned.
```text
public static string LinetypeContinuousName;
```

#### Conditions
Read-only
### RegAppAcadName

#### Description
Returns the string used as the value for the predefined symbol record. A NULL pointer or empty string will never be returned.
```text
public static string RegAppAcadName;
```

#### Conditions
Read-only
### TextStyleStandardName

#### Description
Returns the string used as the value for the predefined symbol record. A NULL pointer or empty string will never be returned.
```text
public static string TextStyleStandardName;
```

#### Conditions
Read-only
### ViewportActiveName

#### Description
Returns the string used as the value for the predefined symbol record. A NULL pointer or empty string will never be returned.
```text
public static string ViewportActiveName;
```

#### Conditions
Read-only