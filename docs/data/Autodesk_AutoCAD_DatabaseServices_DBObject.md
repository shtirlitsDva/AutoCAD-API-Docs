# DBObject Class

## Overview

#### Description
This .NET class wraps the AcDbObject ObjectARX class. 
The DBObject class is the base class for all objects that reside in an Database object. This class provides all the functionality for database residency such as objectId, handle, ownership, filing, persistent reactor notification, xdata, deepClone, object state queries, erase, audit, etc. Many of these involve virtual functions so that they can be overridden in classes derived from Object. 
Opening Objects
Objects can be opened in one of three modes: 
| Value | Meaning |
| --- | --- |
| OpenMode.ForRead | Up to 256 readers can be opened at once, as long as object is not already open kForWrite or kForNotify. Member functions invoked when an object is opened kForRead should not cause object to be modified. |
| OpenMode.ForWrite | Can be opened for write if it is not open at all, otherwise an open kForWrite fails. Member functions invoked when an object is opened kForWrite may or may not modify the object. |
| OpenMode.ForNotify | Can be opened for notification whenever it is closed, open for read (any number) or open for write, but not when it is already open for notify. Member functions allowed to be invoked when open in this mode should not interfere with any current readers or writers, although they may cause the object to alter itself. |

ForNotify is intended to be the most powerful open function, and the most transient. Opening in ForNotify mode can only fail if a previous user has left it open in this mode. When open in this mode, any subsequent open requests fail, even ForNotify. Therefore, this mode should be used sparingly, and objects opened in this mode should be sent the proper member function call or calls and closed as soon as possible. 
Because of the restrictions on multiple opening of objects, never leave objects open any longer than necessary and always try to open in the least restrictive mode necessary.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocAction
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
    Autodesk.AutoCAD.DatabaseServices.AssocActionParam
    Autodesk.AutoCAD.DatabaseServices.AssocDependency
    Autodesk.AutoCAD.DatabaseServices.AssocDependencyBody
    Autodesk.AutoCAD.DatabaseServices.AssocManager
    Autodesk.AutoCAD.DatabaseServices.Background
    Autodesk.AutoCAD.DatabaseServices.DataLink
    Autodesk.AutoCAD.DatabaseServices.DataTable
    Autodesk.AutoCAD.DatabaseServices.DBDictionary
    Autodesk.AutoCAD.DatabaseServices.DBVisualStyle
    Autodesk.AutoCAD.DatabaseServices.DetailViewStyle
    Autodesk.AutoCAD.DatabaseServices.DrawOrderTable
    Autodesk.AutoCAD.DatabaseServices.Entity
    Autodesk.AutoCAD.DatabaseServices.Field
    Autodesk.AutoCAD.DatabaseServices.Filters.Filter
    Autodesk.AutoCAD.DatabaseServices.Filters.Index
    Autodesk.AutoCAD.DatabaseServices.GeoLocationData
    Autodesk.AutoCAD.DatabaseServices.Group
    Autodesk.AutoCAD.DatabaseServices.LinkedData
    Autodesk.AutoCAD.DatabaseServices.LongTransaction
    Autodesk.AutoCAD.DatabaseServices.Material
    Autodesk.AutoCAD.DatabaseServices.MLeaderStyle
    Autodesk.AutoCAD.DatabaseServices.MlineStyle
    Autodesk.AutoCAD.DatabaseServices.PlaceHolder
    Autodesk.AutoCAD.DatabaseServices.PlotSettings
    Autodesk.AutoCAD.DatabaseServices.PointCloudColorMap
    Autodesk.AutoCAD.DatabaseServices.PointCloudDefEx
    Autodesk.AutoCAD.DatabaseServices.ProxyObject
    Autodesk.AutoCAD.DatabaseServices.RasterImageDef
    Autodesk.AutoCAD.DatabaseServices.RasterVariables
    Autodesk.AutoCAD.DatabaseServices.RenderEnvironment
    Autodesk.AutoCAD.DatabaseServices.RenderGlobal
    Autodesk.AutoCAD.DatabaseServices.RenderSettings
    Autodesk.AutoCAD.DatabaseServices.SectionManager
    Autodesk.AutoCAD.DatabaseServices.SectionSettings
    Autodesk.AutoCAD.DatabaseServices.SectionViewStyle
    Autodesk.AutoCAD.DatabaseServices.Sun
    Autodesk.AutoCAD.DatabaseServices.SymbolTable
    Autodesk.AutoCAD.DatabaseServices.SymbolTableRecord
    Autodesk.AutoCAD.DatabaseServices.TableStyle
    Autodesk.AutoCAD.DatabaseServices.UnderlayDefinition
    Autodesk.AutoCAD.DatabaseServices.Xrecord
```

```text
public abstract class DBObject : Autodesk.AutoCAD.GraphicsInterface.Drawable;
```

#### See Also
Database, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), [Curve](Autodesk_AutoCAD_DatabaseServices_Curve.md "Curve Class"), IdMapping, DwgFiler, DxfFiler, [RXClass](Autodesk_AutoCAD_Runtime_RXClass.md), AuditInfo

## Members

### Events

- [Cancelled](#cancelled)
- [Copied](#copied)
- [Erased](#erased)
- [Goodbye](#goodbye)
- [Modified](#modified)
- [ModifiedXData](#modifiedxdata)
- [ModifyUndone](#modifyundone)
- [ObjectClosed](#objectclosed)
- [OpenedForModify](#openedformodify)
- [Reappended](#reappended)
- [SubObjectModified](#subobjectmodified)
- [Unappended](#unappended)

### Methods

- [AddContext](#addcontext)
- [ApplyPaperOrientationTransform](#applypaperorientationtransform)
- [ApplyPartialUndo](#applypartialundo)
- [Audit](#audit)
- [Cancel](#cancel)
- [Close](#close)
- [CloseAndPage](#closeandpage)
- [CreateExtensionDictionary](#createextensiondictionary)
- [DecomposeForSave](#decomposeforsave)
- [DeepClone](#deepclone)
- [DisableUndoRecording](#disableundorecording)
- [DowngradeOpen](#downgradeopen)
- [DowngradeToNotify](#downgradetonotify)
- [DwgIn](#dwgin)
- [DwgOut](#dwgout)
- [DxfIn](#dxfin)
- [DxfOut](#dxfout)
- [Erase()](#erase())
- [Erase([MarshalAs(UnmanagedType.U1)] bool)](#erase([marshalas(unmanagedtype.u1)]-bool))
- [GetBinaryDataForKey](#getbinarydataforkey)
- [GetField()](#getfield())
- [GetField(string)](#getfield(string))
- [GetObjectSaveVersion(DwgFiler)](#getobjectsaveversion(dwgfiler))
- [GetObjectSaveVersion(DxfFiler)](#getobjectsaveversion(dxffiler))
- [GetPersistentReactorIds](#getpersistentreactorids)
- [GetReactors](#getreactors)
- [GetTransientReactors](#gettransientreactors)
- [GetXDataForApplication](#getxdataforapplication)
- [HandOverTo](#handoverto)
- [HasContext](#hascontext)
- [HasPersistentReactor](#haspersistentreactor)
- [IsCustomObject](#iscustomobject)
- [ReleaseExtensionDictionary](#releaseextensiondictionary)
- [RemoveContext](#removecontext)
- [RemoveField()](#removefield())
- [RemoveField(Autodesk.AutoCAD.DatabaseServices.ObjectId)](#removefield(autodesk.autocad.databaseservices.objectid))
- [RemoveField(string)](#removefield(string))
- [ResetScaleDependentProperties](#resetscaledependentproperties)
- [SetBinaryDataForKey](#setbinarydataforkey)
- [SetField([CallerMustClose] Field)](#setfield([callermustclose]-field))
- [SetField(string, [CallerMustClose] Field)](#setfield(string,-[callermustclose]-field))
- [SetFromStyle](#setfromstyle)
- [SetObjectIdsInFlux](#setobjectidsinflux)
- [SetPaperOrientation](#setpaperorientation)
- [SupportsCollection](#supportscollection)
- [SwapIdWith](#swapidwith)
- [SwapReferences](#swapreferences)
- [UpgradeFromNotify](#upgradefromnotify)
- [UpgradeOpen](#upgradeopen)
- [WblockClone](#wblockclone)
- [XDataTransformBy](#xdatatransformby)

### Properties

- [AcadObject](#acadobject)
- [Annotative](#annotative)
- [ClassID](#classid)
- [Database](#database)
- [Drawable](#drawable)
- [ExtensionDictionary](#extensiondictionary)
- [Handle](#handle)
- [HasFields](#hasfields)
- [HasSaveVersionOverride](#hassaveversionoverride)
- [Id](#id)
- [IsAProxy](#isaproxy)
- [IsCancelling](#iscancelling)
- [IsErased](#iserased)
- [IsEraseStatusToggled](#iserasestatustoggled)
- [IsModified](#ismodified)
- [IsModifiedGraphics](#ismodifiedgraphics)
- [IsModifiedXData](#ismodifiedxdata)
- [IsNewObject](#isnewobject)
- [IsNotifyEnabled](#isnotifyenabled)
- [IsNotifying](#isnotifying)
- [IsObjectIdsInFlux](#isobjectidsinflux)
- [IsPersistent](#ispersistent)
- [IsReadEnabled](#isreadenabled)
- [IsReallyClosing](#isreallyclosing)
- [IsTransactionResident](#istransactionresident)
- [IsUndoing](#isundoing)
- [IsWriteEnabled](#iswriteenabled)
- [MergeStyle](#mergestyle)
- [ObjectBirthVersion](#objectbirthversion)
- [ObjectId](#objectid)
- [OwnerId](#ownerid)
- [PaperOrientation](#paperorientation)
- [UndoFiler](#undofiler)
- [XData](#xdata)


## Events Details

### Cancelled

#### Description
This is Cancelled, a member of class DBObject.
```text
public event EventHandler Cancelled;
```

### Copied

#### Description
This is Copied, a member of class DBObject.
```text
public event ObjectEventHandler Copied;
```

### Erased

#### Description
This is Erased, a member of class DBObject.
```text
public event ObjectErasedEventHandler Erased;
```

### Goodbye

#### Description
This is Goodbye, a member of class DBObject.
```text
public event EventHandler Goodbye;
```

### Modified

#### Description
This is Modified, a member of class DBObject.
```text
public event EventHandler Modified;
```

### ModifiedXData

#### Description
This is ModifiedXData, a member of class DBObject.
```text
public event EventHandler ModifiedXData;
```

### ModifyUndone

#### Description
This is ModifyUndone, a member of class DBObject.
```text
public event EventHandler ModifyUndone;
```

### ObjectClosed

#### Description
This is ObjectClosed, a member of class DBObject.
```text
public event ObjectClosedEventHandler ObjectClosed;
```

### OpenedForModify

#### Description
This is OpenedForModify, a member of class DBObject.
```text
public event EventHandler OpenedForModify;
```

### Reappended

#### Description
This is Reappended, a member of class DBObject.
```text
public event EventHandler Reappended;
```

### SubObjectModified

#### Description
This is SubObjectModified, a member of class DBObject.
```text
public event ObjectEventHandler SubObjectModified;
```

### Unappended

#### Description
This is Unappended, a member of class DBObject.
```text
public event EventHandler Unappended;
```

### AddContext

#### Description
Adds a copy of a context to the object.
```text
public void AddContext(
    ObjectContext context
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectContext context | The context to add. |

### ApplyPaperOrientationTransform

#### Description
Transforms the object to align it to the paper-space viewport if the object supports the paper orientation property.
```text
public void ApplyPaperOrientationTransform(
    Autodesk.AutoCAD.DatabaseServices.Viewport viewport
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.Viewport viewport | The viewport in which the object is to be displayed. |

### ApplyPartialUndo

#### Description
This function is called by AutoCAD whenever an Undo operation is performed on the DBObject object and the object has consistently set the autoUndo Boolean in all assertWriteEnabled() calls to false, thus indicating that it's using the partial undo mechanism. 
When an object transaction consists of all partial Undo modifications, upon Undo, this virtual member function is called. As with dwgInFields(), this member is supposed to be able to know how many and what types of fields to scan, and to be able to stop after reading what it expects.
Note
If, during the time the object is open, different calls to assertWriteEnabled() pass in different parameter values, the first encounter of an true for the autoUndo parameter causes all partial Undo information recorded so far to be flushed, then replaced by a full Undo recording. The filer status is changed to indicate a full undo has been recorded. Once this has occurred, the applyPartialUndo() function is not called for a subsequent Undo operation since the full Undo has taken place.
```text
public virtual void ApplyPartialUndo(
    DwgFiler undoFiler, 
    RXClass classObj
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgFiler undoFiler | The undo filer containing the partial undo information to be re-instated |
| RXClass classObj | The RXClass object for the class that is expected to be handling this Undo information |

### Audit

#### Description
This function is called by AutoCAD when the AUDIT command is executed. The AuditInfo object pointed to by auditInfo contains member functions that are used to determine what to do and also to report the results of the audit operation on the object.
```text
public virtual void Audit(
    AuditInfo auditInfo
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AuditInfo auditInfo | An AuditInfo object |

### Cancel

#### Description
Terminates the current open operation. All changes made to
```text
public void Cancel();
```

#### Conditions
Read-only Accesses the text width factor.
### Close

#### Description
Closes the object. All changes made to the object since it was opened are committed to the database, the object is marked as pageable, and a "closed" notification (as well as any other appropriate notification such as "modified", "erased", and so on) is sent.
```text
public void Close();
```

### CloseAndPage

#### Description
Closes the object and pages it if the object pager is turned on. All changes made to the object since it was opened are committed to the database, and a "closed" notification (as well as any other appropriate notification such as "modified", "erased", and so on) is sent.
```text
public void CloseAndPage(
    [MarshalAs(UnmanagedType.U1)] bool onlyWhenClean
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool onlyWhenClean | Boolean indicating to turn off or on undo recording |

### CreateExtensionDictionary

#### Description
Creates a DBDictionary object and sets it up as the extension dictionary for the DBObject.
```text
public void CreateExtensionDictionary();
```

### DecomposeForSave

#### Description
This member function is used to control behavior for custom objects and entities when saving to previous formats. Custom objects can decompose themselves into other objects and can add additional xdata to the objects created.
```text
public virtual DecomposeForSaveReplacementRecord DecomposeForSave(
    DwgVersion version
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgVersion version | DWG version being saved to |

### DeepClone

#### Description
This function gives control of deep clone operations to the object. In the default implementation, the object is cloned and appended to the owner object (ownerPointer). The cloning is performed by an DeepCloneFiler. A record is also added to the idMap. Then, using the filer, any owned objects are deep cloned, with isPrimary set to false.
```text
public DBObject DeepClone(
    DBObject ownerPointer, 
    IdMapping idMap, 
    [MarshalAs(UnmanagedType.U1)] bool isPrimary
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DBObject ownerPointer | Object to which the clones should be appended |
| IdMapping idMap | Current object ID map |
| [MarshalAs(UnmanagedType.U1)] bool isPrimary | Boolean indicating whether this object is primary or owned |

### DisableUndoRecording

#### Description
Turns off or on the Undo recording for the object. If disable is set to true, then Undo recording is turned off.
```text
public void DisableUndoRecording(
    [MarshalAs(UnmanagedType.U1)] bool disable
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool disable | Boolean indicating to turn off or on Undo recording |

### DowngradeOpen

#### Description
Downgrades the object from being open OpenMode.ForWrite, to being OpenMode.ForRead. In the process, all changes made to the object while it was open for write are committed to the database and appropriate notification is sent. 
**Note**
This function does not need to be preceded by an upgradeOpen() call -- it just requires that the object be open for write when it is called.
```text
public void DowngradeOpen();
```

### DowngradeToNotify

#### Description
Restores an object from being open both OpenMode.ForNotify and OpenMode.ForWrite, to being open just OpenMode.ForNotify. The wasWritable value that was returned from the matching DBObject.upgradeFromNotify() call should be passed into this function to restore the proper open status. 
This function must have been preceded by a call to upgradeFromNotify().
```text
public void DowngradeToNotify(
    [MarshalAs(UnmanagedType.U1)] bool wasWritable
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool wasWritable | Input indicating if object was open for write when upgradeFromNotify was called |

### DwgIn

#### Description
This function does some internal bookkeeping, calls the object's DBObject.dwgInFields() function, and then reads in any xdata attached to the object. If the object's dwgInFields() function does not supermessage its parent class, then an assert is triggered.
```text
public void DwgIn(
    DwgFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgFiler filer | DWG filer to be used for this filing operation |

### DwgOut

#### Description
This function does some internal bookkeeping, calls the object's DBObject.dwgOutFields() function, and then writes out any xdata attached to the object. If the object's dwgOutFields() function does not supermessage its parent class, then an assert is triggered.
```text
public void DwgOut(
    DwgFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgFiler filer | DWG filer to be used for this filing operation |

### DxfIn

#### Description
This function does some internal book keeping by reading in any xdata that comes before the main entity data. The dxfIn function then calls the object's DBObject.dxfInFields() function, and then reads in any xdata that comes after the entity data. 
**Note**
Creating objects with xdata before entity data is not good practice, but for upwards compatibility it remains supported.
```text
public void DxfIn(
    DxfFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DxfFiler filer | DXF filer to be used for this filing operation |

### DxfOut

#### Description
This function does some internal bookkeeping, calls the object's DBObject.dxfOutFields() function, and then writes out any xdata attached to the object.
```text
public void DxfOut(
    DxfFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DxfFiler filer | Filer to be used for this filing operation |

### Erase()

#### Description
Sets the erase bit of the object.
```text
public void Erase();
```

### Erase([MarshalAs(UnmanagedType.U1)] bool)

#### Description
Sets the erase bit of the object.
```text
public void Erase(
    [MarshalAs(UnmanagedType.U1)] bool erasing
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool erasing | Boolean indicating if object is to be erased or unerased |

### GetBinaryDataForKey

#### Description
This function reads a chunk of binary data from this object's extension dictionary. It assumes that the data has been stored as a resbuf chain of 127-byte pieces, which it concatenates into the larger data buffer that is returned. If the data has been stored in any other type of resbuf, this function will throw an eBadDxfCode exception.
```text
public byte\[\] GetBinaryDataForKey(
    string key
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string key | Input extension dictionary key under which the data is stored |

#### Returns
Returns the binary data as an array of bytes.
### GetField()

#### Description
This function provides access to Field objects associated with a database object by returning the object ID.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId GetField();
```

### GetField(string)

#### Description
This function provides access to Field objects associated with a database object and the supplied property name by returning the object ID.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId GetField(
    string propertyName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string propertyName | Input a property name for the field you want to retrieve |

### GetObjectSaveVersion(DwgFiler)

#### Description
Override this function to specify which version the object data needs to be stored in. This does not require super-messaging. 
**Warning**
Do not use filer->dwgVersion() in your dwg(In/Out)Fields() and dxf(In/Out)Fields() methods; this will not work for instances of classes derived from your class. Instead, use self()->getObjectSaveVersion(). Its default implementation is to return filer->dwgVersion() unless the object wants to override the save version.
```text
public virtual FullDwgVersion GetObjectSaveVersion(
    DwgFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DwgFiler filer | Filer to be used for this filing operation |

### GetObjectSaveVersion(DxfFiler)

#### Description
Override this function to specify which version the object data needs to be stored in. This does not require super-messaging. 
**Warning**
Do not use filer->dwgVersion() in your dwg(In/Out)Fields() and dxf(In/Out)Fields() methods; this will not work for instances of classes derived from your class. Instead, use self()->getObjectSaveVersion(). It's default implementation is to return filer->dwgVersion() unless the object wants to override the save version.
```text
public virtual FullDwgVersion GetObjectSaveVersion(
    DxfFiler filer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DxfFiler filer | DXF filer to be used for this filing operation |

### GetPersistentReactorIds

#### Description
Returns the persistent reactor collection list.
```text
public ObjectIdCollection GetPersistentReactorIds();
```

### GetReactors

#### Description
This function is obsolete. One can retrieve all reactors by calling GetTransientReactors() and GetPersistentReactors().
```text
public List<RXObject> GetReactors();
```

### GetTransientReactors

#### Description
Retrieves the transient reactors.
```text
public List<RXObject> GetTransientReactors();
```

### GetXDataForApplication

#### Description
Gets the xdatafrom the identified application.
```text
public ResultBuffer GetXDataForApplication(
    string applicationName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string applicationName | Name of the registered application to use when retrieving the xdata |

### HandOverTo

#### Description
This function provides the ability to exchange a non-database-resident object (NDBRO) in place of an existing database-resident object (DBRO) while retaining the objectId, handle, and reactor list of the DBRO. An example of this situation is when the BREAK command is used to break a circle into one or two arc segments. Arc is a completely different class from Circle, so a new Arc object must be substituted in place of the Circle object that is there now, yet the arc must get the handle and objectId that the circle has. 
To use the handOverTo() function, the object to be replaced (the Circle in the example) must be open OpenMode.ForWrite. The object's handOverTo() function is called with newPointer being a non-database-resident object that replaces it (the Arc in the example). 
keepXData is set to true if the xdata is to be retained or false if the xdata is to be thrown out. 
keepExtensionDictionary is set to true if the extension dictionary and its contents are to be retained, or set to false if the extension dictionary and its contents are to be thrown out. 
Once returned from this function, the replacement object (the Arc in the example) is open for OpenMode.ForWrite and must have its close() member called to commit the change and close out Undo recording. Then it's up to the ObjectARX application to delete the old object (the Circle in the example) from memory since it's no longer database-resident. 
**Note**
This method is not allowed on objects that are transaction resident. If the object on which the method is called is transaction resident, then no handOverTo operation is performed.
```text
public void HandOverTo(
    [CallerMustClose] DBObject newPointer, 
    [MarshalAs(UnmanagedType.U1)] bool keepXData, 
    [MarshalAs(UnmanagedType.U1)] bool keepExtensionDictionary
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [CallerMustClose] DBObject newPointer | Object to be used to replace the current object |
| [MarshalAs(UnmanagedType.U1)] bool keepXData | Boolean indicating if xdata is to be transferred during the process |
| [MarshalAs(UnmanagedType.U1)] bool keepExtensionDictionary | Boolean indicating whether the extension dictionary is passed on from the old object to the new one. If set to kTrue, the extension dictionary will be passed on, otherwise it will be left behind. |

### HasContext

#### Description
Determines whether a context with the specified name exists in the collection.
```text
public bool HasContext(
    ObjectContext context
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectContext context | The context to check for. |

### HasPersistentReactor

#### Description
This method returns true if objId is the object ID of a reactor attached to this object.
```text
public bool HasPersistentReactor(
    Autodesk.AutoCAD.DatabaseServices.ObjectId objId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.ObjectId objId | Object ID of a persistent reactor object |

### IsCustomObject

#### Description
Returns true if id belongs to a custom object.
```text
public static bool IsCustomObject(
    Autodesk.AutoCAD.DatabaseServices.ObjectId id
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.ObjectId id | Custom ID to check. |

### ReleaseExtensionDictionary

#### Description
Removes the object's extension dictionary (that is, removes the object as the owner of the dictionary object) if it exists and is empty. Once removed, this function calls the dictionary's erase() method. Any reactors attached to the extension dictionary receive normal notification appropriate to an open for write, erase, close sequence
```text
public void ReleaseExtensionDictionary();
```

### RemoveContext

#### Description
Removes a context from the collection. 
The active context cannot be removed from a collection.
```text
public void RemoveContext(
    ObjectContext context
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectContext context | The context to remove from the collection. |

### RemoveField()

#### Description
Removes the text field. Returns its field ID.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId RemoveField();
```

### RemoveField(Autodesk.AutoCAD.DatabaseServices.ObjectId)

#### Description
Removes the specified field.
```text
public void RemoveField(
    Autodesk.AutoCAD.DatabaseServices.ObjectId id
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.ObjectId id | Field ID to remove from the object |

### RemoveField(string)

#### Description
Removes the specified field. Returns the object ID of the removed field.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId RemoveField(
    string propertyName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string propertyName | Property name whose field is to be removed |

### ResetScaleDependentProperties

#### Description
Resets any scale dependent object properties to the default values. 
Objects implement this function to support AutoCAD's ANNORESET command. Objects may implement properties which are scale dependent, for example the position or rotation of the object. Objects that wish to support the ANNORESET command should provide an implementation of this method which resets all scale-dependent properties to match the properties of the current scale (or of a default scale, determined by the object, if the object doesn't support the current scale).
```text
public void ResetScaleDependentProperties();
```

### SetBinaryDataForKey

#### Description
This function copies the binary data in the chunk array into this object's extension dictionary. It looks for key in the dictionary, and either creates or overwrites a resbuf chain on an xrecord at that key. The binary data is broken into 127-byte chunks for storage in the resbuf chain.
```text
public void SetBinaryDataForKey(
    string key, 
    byte\[\] chunk
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string key | Input extension dictionary key to be used |
| byte[] chunk | Input a flat array of bytes that are the binary data to save |

### SetField([CallerMustClose] Field)

#### Description
A field can be stored in an object using the property name as the key. If the field is not yet posted to the database, it will be posted to the database. If the field is already in database, it should be opened for write. After calling this method, the field object must be closed.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId SetField(
    [CallerMustClose] Field field
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [CallerMustClose] Field field | Field to set |

### SetField(string, [CallerMustClose] Field)

#### Description
A field can be stored in an object using the property name as the key. The object should be in database for this function to succeed. If the field is not yet posted to the database, it will be posted to the database. If the field is already in database, it should be opened for write. After calling this method, the field object must be closed.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId SetField(
    string propertyName, 
    [CallerMustClose] Field field
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string propertyName | Property name for which to set the field |
| [CallerMustClose] Field field | Field to set |

### SetFromStyle

#### Description
Sets the annotative property of an object from its (optionally) associated style. Returns true on successful return if the annotative property of the object changed.
```text
public bool SetFromStyle();
```

### SetObjectIdsInFlux

#### Description
This function must be called on any newly created objects in DBObject.DeepClone or DBObject.WblockClone. It indicates that reference object IDs are not yet pointing to the correct objects. The references can be translated only when the entire deep clone operation is complete. The flag is cleared at that time.
```text
public void SetObjectIdsInFlux();
```

### SetPaperOrientation

#### Description
Sets the current value of the paper orientation property on an annotative object.
```text
public void SetPaperOrientation(
    [MarshalAs(UnmanagedType.U1)] bool bPaperOrientation
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool bPaperOrientation | The new value for the paper orientation property. |

### SupportsCollection

#### Description
Determines if a particular context type is supported by the object. 
Whether an object supports a collection type is different from whether the object currently participates in any contexts of that type. See also the HasContext() method. 
Returns true if the object supports context types with the specified name.
```text
public bool SupportsCollection(
    string collectionName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string collectionName | The name of the collection (context type) to test for support. |

### SwapIdWith

#### Description
This function swaps objectIds and handles between the object specified by otherId and the object invoking this function. Both objects must currently be database-resident and must reside in the same database. If swapExtendedData is true, then the objects swap extended entity data as well. If swapExtensionDictionary is true, then the objects swap extension dictionaries also.
```text
public void SwapIdWith(
    Autodesk.AutoCAD.DatabaseServices.ObjectId otherId, 
    [MarshalAs(UnmanagedType.U1)] bool swapExtendedData, 
    [MarshalAs(UnmanagedType.U1)] bool swapExtensionDictionary
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.ObjectId otherId |

  * of object to swap with

  
[MarshalAs(UnmanagedType.U1)] bool swapExtendedData |  Boolean indicating whether to swap extended entity data   
[MarshalAs(UnmanagedType.U1)] bool swapExtensionDictionary |  Boolean indicating whether to swap extension dictionaries   
### SwapReferences

#### Description
The purpose of this method is similar to the object ID reference translations done at the end of deep cloning. References between objects in the workset have their object IDs translated to the swapped object IDs of the referenced objects. Unlike cloning, this translation must happen in both directions. Thus, it is possible to see two different ID maps passed in on different calls to this method. 
For example, an original object swapped with a new one will get a mapping of all other original objects swapped with their new ones. Because the long transaction manager is about to erase these original objects, it is important that their inter-object relationships be correct for purposes such as sending erase notifications. 
A new object may or may not have an original with which to swap. In either case, its references must be updated using a mapping from all the other new objects to their originals. 
The default behavior of this method in DBObject is to translate object ID references on the object using idMap, in the same way that translation is done for a DeepClone() operation. 
**Warning**
Custom objects that override this method must super-message their parent. Failure to super-message will cause the process to abort at runtime.
```text
public virtual void SwapReferences(
    IdMapping idMap
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IdMapping idMap | Input refedit ID map |

### UpgradeFromNotify

#### Description
Upgrades the object from being at least open OpenMode.ForNotify to being open both OpenMode.ForNotify and OpenMode.ForWrite. 
This function must be followed at some point by a call to DowngradeToNotify() with no Open() (in any of its forms) or Close() calls in between. 
This method should only be called from within other methods of the same object it is being called from. In other words, this method is intended to be used by an object to change it's own open status so that it can safely modify itself. 
UpgradeFromNotify() and DowngradeToNotify() call pairs are not nestable. 
```text
public bool UpgradeFromNotify();
```

### UpgradeOpen

#### Description
If the object is currently open OpenMode.ForRead with only one reader, then this function upgrades the object to open OpenMode.ForWrite. In the process of changing to open for write, the object is closed, thus triggering any pertinent notification. 
Note
A call of this function does not need to be matched with a call to DowngradeOpen(), since a call to Close() or Cancel() will sufficiently cleanup the entity's open state.
```text
public void UpgradeOpen();
```

### WblockClone

#### Description
This function is almost identical to DBObject.DeepClone, except that a WblockCloneFiler is used and ownership is not carried across database boundaries. Subcloning is based on hard owner and hard pointer connections.
```text
public DBObject WblockClone(
    RXObject ownerPointer, 
    IdMapping idMap, 
    [MarshalAs(UnmanagedType.U1)] bool isPrimary
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| RXObject ownerPointer | Input object to which the clones should be appended. If the owner has not been cloned, then the Database must be passed in. |
| IdMapping idMap | Input current object ID map |
| [MarshalAs(UnmanagedType.U1)] bool isPrimary | Input Boolean indicating whether this object is primary or owned |

### XDataTransformBy

#### Description
This method applies the xform transformation matrix to any XData data types 1011, 1021, 1031, 1012, 1022, 1032, 1013, 1023, 1033, 1041, and 1042 in the object's XData. See the documentation on XData for more information on the way the transformation matrix is applied to the different data types. 
This method should be called from within the TransformBy() method on custom entities so that such entities will transform XData in the same way that the built-in database entities do.
```text
public void XDataTransformBy(
    Matrix3d transform
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Matrix3d transform | Transformation matrix to be applied to the XData |

### AcadObject

#### Description
This is AcadObject, a member of class DBObject.
```text
public object AcadObject;
```

### Annotative

#### Description
Accesses the annotative status
```text
public AnnotativeStates Annotative;
```

#### Conditions
Read / Write
### ClassID

#### Description
Accesses the class ID for the object
```text
public Guid ClassID;
```

#### Conditions
Read-only
### Database

#### Description
Accesses the database used by the object
```text
public Autodesk.AutoCAD.DatabaseServices.Database Database;
```

#### Conditions
Read-only
### Drawable

#### Description
Accesses the Drawable object
```text
public virtual Autodesk.AutoCAD.GraphicsInterface.Drawable Drawable;
```

#### Conditions
Read-only
### ExtensionDictionary

#### Description
Accesses the extension dictionary for the object.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId ExtensionDictionary;
```

#### Conditions
Read-only
### Handle

#### Description
Accesses the associated handle object
```text
public Autodesk.AutoCAD.DatabaseServices.Handle Handle;
```

#### Conditions
Read-only
### HasFields

#### Description
Returns true if the object has one or more fields.
```text
public bool HasFields;
```

#### Conditions
Read / Write
### HasSaveVersionOverride

#### Description
Accesses if the object has the bit set to override the filer version.
```text
public bool HasSaveVersionOverride;
```

#### Conditions
Read / Write
### Id

#### Description
Returns the Id property value.
```text
public override Autodesk.AutoCAD.DatabaseServices.ObjectId Id;
```

#### Conditions
Read-only
### IsAProxy

#### Description
Returns true if the object is a proxy
```text
public bool IsAProxy;
```

#### Conditions
Read-only
### IsCancelling

#### Description
Returns true if the object is currently in the middle of a Cancel() call (that is, an open is being canceled and all changes made are being rolled back).
```text
public bool IsCancelling;
```

#### Conditions
Read-only
### IsErased

#### Description
Returns true if the object associated with this object ID is erased.
```text
public bool IsErased;
```

#### Conditions
Read-only
### IsEraseStatusToggled

#### Description
Returns true if the object's erase bit has been toggled since it was opened.
```text
public bool IsEraseStatusToggled;
```

#### Conditions
Read-only
### IsModified

#### Description
Returns true if the object has had an AssertWriteEnabled() called since it was opened (which would indicate that a member function that can change its data was called).
```text
public bool IsModified;
```

#### Conditions
Read-only
### IsModifiedGraphics

#### Description
Returns true if the object is derived from Entity nabled() called since it was opened (which would indicate that a member function that can change its data was called), or its RecordGraphicsModified() function called with an true argument value.
```text
public bool IsModifiedGraphics;
```

#### Conditions
Read-only
### IsModifiedXData

#### Description
Returns true if the object has had an AssertWriteEnabled() called since it was opened (which would indicate that a member function that can change its data was called) and has then had its SetXData() method called.
```text
public bool IsModifiedXData;
```

#### Conditions
Read-only
### IsNewObject

#### Description
Returns true if the object has not yet been closed since it was first created.
```text
public bool IsNewObject;
```

#### Conditions
Read-only
### IsNotifyEnabled

#### Description
Returns true if the object is currently open OpenMode.ForNotify.
```text
public bool IsNotifyEnabled;
```

#### Conditions
Read-only
### IsNotifying

#### Description
Returns true if the object is in the process of sending notification
```text
public bool IsNotifying;
```

#### Conditions
Read-only
### IsObjectIdsInFlux

#### Description
This refers to a condition that occurs during deep clone operations. It returns true when the cloned objects' IDs have not yet been translated and thus cannot be used in any operations on the objects. This condition normally occurs only during CEventReactorImpl.beginDeepCloneXlation, DBObject.DeepClone, or DBObject.WblockClone. Any operations that involve ObjectId references, such as symbol table records, should be postponed until after endDeepClone. DBObject.SubClose is never called on any objects whose IDs are in flux
```text
public bool IsObjectIdsInFlux;
```

#### Conditions
Read-only
### IsPersistent

#### Description
Returns true if the Drawable object is database resident (belongs to an Model that requires the use of open and close functions).
```text
public override bool IsPersistent;
```

#### Conditions
Read-only
### IsReadEnabled

#### Description
Returns true if the object is currently open OpenMode.ForRead
```text
public bool IsReadEnabled;
```

#### Conditions
Read-only
### IsReallyClosing

#### Description
Returns true if calling Close() at this time would really close the object completely. For example, if the object is not in a transaction, and is open for read with only one reader, then true would be returned.
```text
public bool IsReallyClosing;
```

#### Conditions
Read-only
### IsTransactionResident

#### Description
Returns true if the object is currently part of a transaction.
```text
public bool IsTransactionResident;
```

#### Conditions
Read-only
### IsUndoing

#### Description
Returns true if the object is involved in an Undo operation at this time.
```text
public bool IsUndoing;
```

#### Conditions
Read-only
### IsWriteEnabled

#### Description
Returns true if the object is currently /c> and is **not** currently sending notification.
```text
public bool IsWriteEnabled;
```

#### Conditions
Read-only
### MergeStyle

#### Description
Accesses the merge style of the dictionary.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.DuplicateRecordCloning MergeStyle;
```

#### Conditions
Read / Write
### ObjectBirthVersion

#### Description
Accesses the birth version of an object. The birth version is the version in which the class was introduced. This information needs to be specified when the class is registered with AutoCAD.
```text
public virtual FullDwgVersion ObjectBirthVersion;
```

#### Conditions
Read-only
### ObjectId

#### Description
Accesses the object ID.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId ObjectId;
```

#### Conditions
Read-only
### OwnerId

#### Description
Accesses the owner ID.
```text
public virtual Autodesk.AutoCAD.DatabaseServices.ObjectId OwnerId;
```

#### Conditions
Read-only
### PaperOrientation

#### Description
Accesses the current value of the paper orientation property on an annotative object.
```text
public PaperOrientationStates PaperOrientation;
```

#### Conditions
Read-only
### UndoFiler

#### Description
Accesses the undo filer for the object. 
Custom classes derived from DBObject may use the partial Undo mechanism. For such classes, member functions that call AssertWriteEnabled nabled need to use UndoFiler() in order to write out any Undo information needed for a later Undo (at which point the object's ApplyPartialUndo() function would be called).
```text
public DwgFiler UndoFiler;
```

#### Conditions
Read-only
### XData

#### Description
Accesses the xdata on the object.
```text
public virtual ResultBuffer XData;
```

#### Conditions
Read / Write