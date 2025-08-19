# HostApplicationServices Class

## Overview

#### Description
This .NET class wraps the AcDbHostApplicationServices ObjectARX class. 
The HostApplicationServices class provides various services to host applications at runtime. These services are defined by the RealDWG client. 
A RealDWG host application must provide a class derived from HostApplicationServices. A default service is not provided. 
The controller and transaction methods of this class specify the undo controller and transaction manager that your application will use. You are not required to override or call these methods. The Internet methods allow your application to use URLs (Uniform Resource Locators) directly in your code or through a browser. The methods in the system functions group should generally not be overridden in your host application services class. These methods are set during construction of HostApplicationServices and do not need to be changed.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.HostApplicationServices
```

```text
public abstract class HostApplicationServices : RXObject;
```

### Methods

- [FatalError](#fatalerror)
- [FindFile](#findfile)
- [GetEnvironmentVariable](#getenvironmentvariable)
- [GetPassword](#getpassword)
- [GetRemoteFile](#getremotefile)
- [GetUrl](#geturl)
- [IsUrl](#isurl)
- [LoadApplication](#loadapplication)
- [NotifyCorruptDrawingFoundOnOpen](#notifycorruptdrawingfoundonopen)
- [PutRemoteFile](#putremotefile)
- [UserBreak](#userbreak)

### Properties

- [AllUsersRootFolder](#allusersrootfolder)
- [AlternateFontName](#alternatefontname)
- [ColorBookLocation](#colorbooklocation)
- [CompanyName](#companyname)
- [Current](#current)
- [FontMapFileName](#fontmapfilename)
- [LocalRootFolder](#localrootfolder)
- [MachineRegistryProductRootKey](#machineregistryproductrootkey)
- [ModelerFlavor](#modelerflavor)
- [Product](#product)
- [Program](#program)
- [releaseMarketVersion](#releasemarketversion)
- [RoamableRootFolder](#roamablerootfolder)
- [UserRegistryProductRootKey](#userregistryproductrootkey)
- [WorkingDatabase](#workingdatabase)


## Methods Details

### FatalError

#### Description
The database calls FatalError() when it encounters a fatal error. There is a default implementation that will put the string into the acdb.err error file, and call exit(0) to terminate your application. 
It is highly desirable for the RealDWG host application to override this method, and do whatever needs to be done for a clean and graceful shutdown, for example, allowing the user to save some portion of the work in progress and cleaning up memory allocations. 
```text
public virtual void FatalError(
    string message
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string message | The error message. |

### FindFile

#### Description
This method is called by the database code when it is trying to locate a file. There is no default implementation. The RealDWG host application must override this method. 
The database will sometimes pass you a FindFileHint that you may use to narrow your search. The FindFileHint enum values are shown in the following table: 
| Default | Any file | none |
| --- | --- | --- |
| FontFile | Could be either a shape or TrueType font | SHX or TTF |
| CompiledShapeFile | A shape font file | SHX |
| TrueTypeFontFile | A TrueType font file | TTF |
| EmbeddedImageFile | An image file | ISM |
| XRefDrawing | A drawing template | DWT |
| PatternFile | A hatch pattern file | PAT |
| ARXApplication | An ObjectARX program | ARX |

```text
public abstract string FindFile(
    string fileName, 
    Database database, 
    Autodesk.AutoCAD.DatabaseServices.FindFileHint hint
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Given name of the file to find. |
| Database database | This will give you the path to the DWG file associated with the database, which may also be searched for the requested file. If this file search is not related to a database, database will be NULL. |
| Autodesk.AutoCAD.DatabaseServices.FindFileHint hint | Caller may pass you a hint, that you may choose to use to narrow your search. |

### GetEnvironmentVariable

#### Description
This is GetEnvironmentVariable, a member of class HostApplicationServices.
```text
public virtual string GetEnvironmentVariable(
    string name
);
```

### GetPassword

#### Description
This function is called internally by host applications such as AutoCAD and other ObjectARX applications (via the ReadDwgFile() function) to display a password-request dialog box. 
A default implementation of this function is provided in AcMgHostApplicationServices that uses _passwordUI.dll_ (supplied with AutoCAD) to display a simple password-request dialog. The default implementation returns the password if the user picked the OK button in the password dialog. 
The dwgName is informational only and is supplied to be displayed to the user in whatever interface has been implemented. When multiple encrypted drawings are being accessed at the same time, this will help to indicate which drawing is requiring a password. 
Other RealDWG host applications must override this function to provide their own implementations.
```text
public virtual string GetPassword(
    string dwgName, 
    Autodesk.AutoCAD.DatabaseServices.PasswordOptions options
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string dwgName | Name of the drawing file that is requiring a password |
| Autodesk.AutoCAD.DatabaseServices.PasswordOptions options | Boolean indicating whether dwgName refers to an xref'd drawing |

### GetRemoteFile

#### Description
This method returns the resource (file) identified by the URL url. The Boolean argument ignoreCache determines whether the file should be downloaded even if it has already been transferred earlier in the session. 
This method, if you implement it, should allow the user transparent access to files on remote servers on the Internet.
```text
public virtual string GetRemoteFile(
    Uri url, 
    [MarshalAs(UnmanagedType.U1)] bool ignoreCache
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Uri url | Input URL |
| [MarshalAs(UnmanagedType.U1)] bool ignoreCache | Input Boolean indicating whether to download the file even if it has be cached earlier in the session |

### GetUrl

#### Description
This method is the inverse of the isURL method. It provides a mapping from a local file to the corresponding URL that the file was downloaded from.
```text
public virtual Uri GetUrl(
    string localFile
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string localFile | Input local file |

### IsUrl

#### Description
This method determines whether the string filePath refers to a valid URL; returns true if it is and false otherwise. 
The definition of a 'valid' URL is application-dependent, in that you may not be interested in supporting all Internet protocols. For instance, an application that attempts to connect users to Web sites would probably not need to provide access to FTP sites. In this hypothetical application, an false value would be returned if a URL that begins with something other than 'http://' was entered. 
The AcMgHostApplicationServices override of this method supports FTP, HTTP, HTTPS, and FILE protocols. Some additional intelligence has been built in to recognize 'smart' URLs, that is, ones that don't specify the protocol, such as, www.autodesk.com or ftp.autodesk.com.
```text
public virtual bool IsUrl(
    string filePath
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string filePath | Input string to be evaluated |

### LoadApplication

#### Description
The default implementation of this method simply calls DynamicLinker.LoadApp(). The arguments are equivalent and are passed unchanged. 
This API is provided so that RealDWG developers can override LoadApp() for their host application services implementation, and do anything special needed by their application.
```text
public virtual void LoadApplication(
    string appName, 
    ApplicationLoadReasons why, 
    [MarshalAs(UnmanagedType.U1)] bool printIt, 
    [MarshalAs(UnmanagedType.U1)] bool asCmd
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string appName | Input null-terminated string which is the application name (as set in the system registry) of the ObjectARX module to load |
| ApplicationLoadReasons why | Input LoadReasons values to use during this load |
| [MarshalAs(UnmanagedType.U1)] bool printIt | Input Boolean indicating whether or not to print load status message |
| [MarshalAs(UnmanagedType.U1)] bool asCmd | Input Boolean indicating whether to load the application as if by user command |

### NotifyCorruptDrawingFoundOnOpen

#### Description
This method is called when an attempt is made to read in a corrupt drawing. Return true if your application has handled the error and wishes to continue. If false is returned, fatalError() will be called, and your application must then shut down.
```text
public virtual bool NotifyCorruptDrawingFoundOnOpen(
    ObjectId id, 
    Autodesk.AutoCAD.Runtime.ErrorStatus es
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | The ID of the corrupt DB object that cannot be read. |
| Autodesk.AutoCAD.Runtime.ErrorStatus es | The return code of the attempt to read in the corrupt DB object. |

### PutRemoteFile

#### Description
This method uploads a local resource (file) identified by the pathname localFile to the remote location specified by the URL url. 
PutRemoteFile() is designed to complement GetRemoteFile() in that you can implement outgoing file transfers, where the destination is some remote site specified by the URL in the first argument. The local file that needs to be uploaded is specified by the second argument, localFile. 
```text
public virtual void PutRemoteFile(
    Uri url, 
    string localFile
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Uri url | Input URL to which to upload file |
| string localFile | Input local file to upload |

### UserBreak

#### Description
The UserBreak() method is called by the database code to see if the user has entered a CTRL+C break. 
Returns true if the user can be broken.
```text
public virtual bool UserBreak();
```

### AllUsersRootFolder

#### Description
Returns the full path to the AutoCAD all users folder where the files shared by all users were installed. The default implementation is to return the directory where the EXE is located. This method can be overridden by DBX applications for their own install structure.
```text
public virtual string AllUsersRootFolder;
```

#### Conditions
Read/Write.
### AlternateFontName

#### Description
Accesses the name of the 'alternate' font, that is, the default font to use in the event that any font cannot be found.
```text
public virtual string AlternateFontName;
```

#### Conditions
Read-only
### ColorBookLocation

#### Description
This is ColorBookLocation, a member of class HostApplicationServices.
```text
public virtual string ColorBookLocation;
```

### CompanyName

#### Description
Accesses the "About" information for the company.
```text
public virtual string CompanyName;
```

#### Conditions
Read-only
### Current

#### Description
Accesses the current HostApplicationServices object being used.
```text
public static HostApplicationServices Current;
```

#### Conditions
Read / Write
### FontMapFileName

#### Description
Accesses the name of the fontmap file. The fontmap file is a file containing a list of font names and substitute fonts to use in place of the named fonts.
```text
public virtual string FontMapFileName;
```

#### Conditions
Read-only
### LocalRootFolder

#### Description
Accesses the local directory.
```text
public virtual string LocalRootFolder;
```

#### Conditions
Read-only
### MachineRegistryProductRootKey

#### Description
Use this function to obtain registry root for storing/retrieving product specific data. This location is generally read-only for limited users.
```text
public virtual string MachineRegistryProductRootKey;
```

#### Returns
Returns the registry root of the product in the HKEY_LOCAL_MACHINE hive. In case of AutoCAD, the string returned is the same as the one returned by UserProductRegistryRootKey.
#### Remarks
To use this property, you need to use Current property on HostApplicationServices. For example: 
string appRootString = Autodesk.AutoCAD.DatabaseServices.HostApplicationServices.Current.MachineRegistryProductRootKey;
#### Conditions
Read / Write
### ModelerFlavor

#### Description
Accesses the level of geometric modeler support available from the RealDWG host application.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.ModelerFlavor ModelerFlavor;
```

#### Conditions
Read-only
### Product

#### Description
Accesses the "About" information for the product.
```text
public virtual string Product;
```

#### Conditions
Read-only
### Program

#### Description
Accesses the "About" information for the program.
```text
public virtual string Program;
```

#### Conditions
Read-only
### releaseMarketVersion

#### Description
This value is primarily used in User Interface. It is the year displayed after the product name, as in "AutoCAD 2013."
```text
public virtual string releaseMarketVersion;
```

#### Conditions
Read / Write
### RoamableRootFolder

#### Description
Accesses the local roamable files directory.
```text
public virtual string RoamableRootFolder;
```

#### Conditions
Read-only
### UserRegistryProductRootKey

#### Description
Use this function to obtain registry root for storing/retrieving product specific user data.
```text
public virtual string UserRegistryProductRootKey;
```

#### Returns
Returns the registry root of the product in the HKEY_CURRENT_USER hive. In case of AutoCAD, the string returned is the same as the one returned by MachineProductRegistryRootKey.
#### Remarks
To use this property, you need to use Current property on HostApplicationServices. For example: 
string appRootString2 = Autodesk.AutoCAD.DatabaseServices.HostApplicationServices.Current.UserRegistryProductRootKey;
#### Conditions
Read / Write
### WorkingDatabase

#### Description
Accesses the primary database open in whichever document (window) has focus. In other host applications, the meaning of working database will be application-defined. 
Note that all RealDWG host applications must instantiate and set at least one Database to be the working database. Many areas of ObjectDBX code require a database to query for information. For example, if you make an Entity in memory, it may require default information from a database. It will take that information from the working database. 
If you want to create some form of Multiple Drawing Interface (MDI) application, where your concept of a document includes one or more databases, you'll need to make sure that you update the working database in synch with whatever document switching scheme your application implements.
```text
public static Database WorkingDatabase;
```

#### Conditions
Read / Write