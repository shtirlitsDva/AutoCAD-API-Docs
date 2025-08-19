# Database Class

## Overview

#### Description
This .NET class wraps the AcDbDatabase ObjectARX class. 
The Database class represents the AutoCAD drawing file. Each Database object contains the various header variables, symbol tables, table records, entities, and objects that make up the drawing. 
The Database class has member functions to allow access to all the symbol tables, to read and write to DWG files, to get or set database defaults, to execute various database-level operations such as Wblock and DeepCloneObjects, and to get or set all header variables.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Database
```

```text
public sealed class Database : RXObject, IDynamicMetaObjectProvider;
```

#### Notes
  * When a new Database is created, it has Undo recording turned off. In order to enable Undo, you must call Database.DisableUndoRecording(false). This is what AutoCAD itself does for the Database object used in the AutoCAD editor.
  * A DWG which is created or modified as an external database (not the current DWG) and then saved using Database.SaveAs(), loses its preview image. Examples of creating new external databases include an Database.Wblock() of a set of entities and Database.ReadDwgFile().
  * When using the following form of wblock:

```text
void Wblock(
    Database outputDataBase,
    ObjectIdCollection outObjIds,
    Point3d basePoint,
    DuplicateRecordCloning cloning
);
```

the ObjectIdCollection must contain only IDs for Entities. To WblockClone DBObjects, you must add them to the ObjectIdCollection only during the BeginDeepCloneTranslation() callback. If a particular wblock operation is intended for only DBObject entities, and not Entities, it is acceptable to pass an empty ObjectIdCollection to Wblock(), which can be filled with ObjectId entities during the BeginDeepCloneTranslation callback. Wblock() on a set of entities to a new database and then a SaveAs() on the database will not cause the preview image to appear when opening the DWG file.
#### See Also
SymbolTable, DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), [Color](Autodesk_AutoCAD_Colors_Color.md), [Point2d](Autodesk_AutoCAD_Geometry_Point2d.md), [Point3d](Autodesk_AutoCAD_Geometry_Point3d.md), [Handle](Autodesk_AutoCAD_DatabaseServices_Handle.md "Handle Structure")

## Members

### Constructors

- [Database()](#database())
- [Database([MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#database([marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))

### Events

- [AbortDxfIn](#abortdxfin)
- [AbortDxfOut](#abortdxfout)
- [AbortSave](#abortsave)
- [BeginDeepClone](#begindeepclone)
- [BeginDeepCloneTranslation](#begindeepclonetranslation)
- [BeginDxfIn](#begindxfin)
- [BeginDxfOut](#begindxfout)
- [BeginInsert](#begininsert)
- [BeginSave](#beginsave)
- [BeginWblockBlock](#beginwblockblock)
- [BeginWblockEntireDatabase](#beginwblockentiredatabase)
- [BeginWblockObjects](#beginwblockobjects)
- [BeginWblockSelectedObjects](#beginwblockselectedobjects)
- [DatabaseConstructed](#databaseconstructed)
- [DatabaseToBeDestroyed](#databasetobedestroyed)
- [DeepCloneAborted](#deepcloneaborted)
- [DeepCloneEnded](#deepcloneended)
- [Disposed](#disposed)
- [DwgFileOpened](#dwgfileopened)
- [DxfInComplete](#dxfincomplete)
- [DxfOutComplete](#dxfoutcomplete)
- [InitialDwgFileOpenComplete](#initialdwgfileopencomplete)
- [InsertAborted](#insertaborted)
- [InsertEnded](#insertended)
- [InsertMappingAvailable](#insertmappingavailable)
- [ObjectAppended](#objectappended)
- [ObjectErased](#objecterased)
- [ObjectModified](#objectmodified)
- [ObjectOpenedForModify](#objectopenedformodify)
- [ObjectReappended](#objectreappended)
- [ObjectUnappended](#objectunappended)
- [PartialOpenNotice](#partialopennotice)
- [ProxyResurrectionCompleted](#proxyresurrectioncompleted)
- [SaveComplete](#savecomplete)
- [SystemVariableChanged](#systemvariablechanged)
- [SystemVariableWillChange](#systemvariablewillchange)
- [WblockAborted](#wblockaborted)
- [WblockEnded](#wblockended)
- [WblockMappingAvailable](#wblockmappingavailable)
- [WblockNotice](#wblocknotice)
- [XrefAttachAborted](#xrefattachaborted)
- [XrefAttachEnded](#xrefattachended)
- [XrefBeginAttached](#xrefbeginattached)
- [XrefBeginOtherAttached](#xrefbeginotherattached)
- [XrefBeginRestore](#xrefbeginrestore)
- [XrefComandeered](#xrefcomandeered)
- [XrefPreXrefLockFile](#xrefprexreflockfile)
- [XrefRedirected](#xrefredirected)
- [XrefRestoreAborted](#xrefrestoreaborted)
- [XrefRestoreEnded](#xrefrestoreended)
- [XrefSubCommandAborted](#xrefsubcommandaborted)
- [XrefSubCommandEnd](#xrefsubcommandend)
- [XrefSubCommandStart](#xrefsubcommandstart)

### Methods

- [AbortDeepClone](#abortdeepclone)
- [AddDBObject](#adddbobject)
- [ApplyPartialOpenFilters](#applypartialopenfilters)
- [AttachXref](#attachxref)
- [AuditXData](#auditxdata)
- [BindXrefs](#bindxrefs)
- [ClassDxfName](#classdxfname)
- [CloseInput](#closeinput)
- [CountEmptyObjects](#countemptyobjects)
- [CountHardReferences](#counthardreferences)
- [DbFromId](#dbfromid)
- [DeepCloneObjects](#deepcloneobjects)
- [DetachXref](#detachxref)
- [DisablePartialOpen](#disablepartialopen)
- [DisableUndoRecording](#disableundorecording)
- [DxfIn](#dxfin)
- [DxfOut(string, int, [MarshalAs(UnmanagedType.U1)] bool)](#dxfout(string,-int,-[marshalas(unmanagedtype.u1)]-bool))
- [DxfOut(string, int, DwgVersion)](#dxfout(string,-int,-dwgversion))
- [DxfOutEx](#dxfoutex)
- [EraseEmptyObjects](#eraseemptyobjects)
- [EvaluateFields()](#evaluatefields())
- [EvaluateFields(FieldEvaluationContext)](#evaluatefields(fieldevaluationcontext))
- [EvaluateFields(FieldEvaluationContext, string)](#evaluatefields(fieldevaluationcontext,-string))
- [ForceWblockDatabaseCopy](#forcewblockdatabasecopy)
- [FromAcadDatabase](#fromacaddatabase)
- [GetAllDatabases](#getalldatabases)
- [GetDimensionStyleChildData](#getdimensionstylechilddata)
- [GetDimensionStyleChildId](#getdimensionstylechildid)
- [GetDimensionStyleParentId](#getdimensionstyleparentid)
- [GetDimRecentStyleList](#getdimrecentstylelist)
- [GetDimstyleData](#getdimstyledata)
- [GetHostDwgXrefGraph](#gethostdwgxrefgraph)
- [GetMetaObject](#getmetaobject)
- [GetNearestLineWeight](#getnearestlineweight)
- [GetObjectId](#getobjectid)
- [GetSupportedDxfOutVersions](#getsupporteddxfoutversions)
- [GetSupportedSaveVersions](#getsupportedsaveversions)
- [GetViewports](#getviewports)
- [GetVisualStyleList](#getvisualstylelist)
- [IdFromDb](#idfromdb)
- [Insert(Matrix3d, Database, [MarshalAs(UnmanagedType.U1)] bool)](#insert(matrix3d,-database,-[marshalas(unmanagedtype.u1)]-bool))
- [Insert(string, Database, [MarshalAs(UnmanagedType.U1)] bool)](#insert(string,-database,-[marshalas(unmanagedtype.u1)]-bool))
- [Insert(string, string, Database, [MarshalAs(UnmanagedType.U1)] bool)](#insert(string,-string,-database,-[marshalas(unmanagedtype.u1)]-bool))
- [IsObjectNonPersistent](#isobjectnonpersistent)
- [IsValidLineWeight](#isvalidlineweight)
- [LoadLineTypeFile](#loadlinetypefile)
- [LoadMlineStyleFile](#loadmlinestylefile)
- [MarkObjectNonPersistent](#markobjectnonpersistent)
- [OverlayXref](#overlayxref)
- [Purge(ObjectIdCollection)](#purge(objectidcollection))
- [Purge(ObjectIdGraph)](#purge(objectidgraph))
- [ReadDwgFile(IntPtr, [MarshalAs(UnmanagedType.U1)] bool, string)](#readdwgfile(intptr,-[marshalas(unmanagedtype.u1)]-bool,-string))
- [ReadDwgFile(string, FileOpenMode, [MarshalAs(UnmanagedType.U1)] bool, string)](#readdwgfile(string,-fileopenmode,-[marshalas(unmanagedtype.u1)]-bool,-string))
- [ReadDwgFile(string, FileShare, [MarshalAs(UnmanagedType.U1)] bool, string)](#readdwgfile(string,-fileshare,-[marshalas(unmanagedtype.u1)]-bool,-string))
- [ReclaimMemoryFromErasedObjects](#reclaimmemoryfromerasedobjects)
- [ReloadXrefs](#reloadxrefs)
- [ResetTimes](#resettimes)
- [ResolveXrefs](#resolvexrefs)
- [RestoreForwardingXrefSymbols](#restoreforwardingxrefsymbols)
- [RestoreOriginalXrefSymbols](#restoreoriginalxrefsymbols)
- [RuntimeId](#runtimeid)
- [Save](#save)
- [SaveAs(string, [MarshalAs(UnmanagedType.U1)] bool, DwgVersion, Autodesk.AutoCAD.DatabaseServices.SecurityParameters)](#saveas(string,-[marshalas(unmanagedtype.u1)]-bool,-dwgversion,-autodesk.autocad.databaseservices.securityparameters))
- [SaveAs(string, Autodesk.AutoCAD.DatabaseServices.SecurityParameters)](#saveas(string,-autodesk.autocad.databaseservices.securityparameters))
- [SaveAs(string, DwgVersion)](#saveas(string,-dwgversion))
- [SetDimstyleData](#setdimstyledata)
- [SetTimeZoneAsUtcOffset](#settimezoneasutcoffset)
- [SetWorldPaperspaceUcsBaseOrigin](#setworldpaperspaceucsbaseorigin)
- [SetWorldUcsBaseOrigin](#setworlducsbaseorigin)
- [TimeZoneDescription](#timezonedescription)
- [TimeZoneOffset](#timezoneoffset)
- [UnloadXrefs](#unloadxrefs)
- [UpdateExt](#updateext)
- [Wblock()](#wblock())
- [WblockCloneObjects](#wblockcloneobjects)
- [WorldPaperspaceUcsBaseOrigin](#worldpaperspaceucsbaseorigin)
- [WorldUcsBaseOrigin](#worlducsbaseorigin)
- [XBindXrefs](#xbindxrefs)

### Other

- [AutoCAD.DatabaseServices.Database.ApplyPartialOpenFilters@SpatialFilter@Autodesk.AutoCAD.DatabaseServices.Filters.LayerFilter](#autocad.databaseservices.database.applypartialopenfilters@spatialfilter@autodesk.autocad.databaseservices.filters.layerfilter)

### Properties

- [AcadDatabase](#acaddatabase)
- [AllowExtendedNames](#allowextendednames)
- [Angbase](#angbase)
- [Angdir](#angdir)
- [AnnoAllVisible](#annoallvisible)
- [AnnotativeDwg](#annotativedwg)
- [ApproxNumObjects](#approxnumobjects)
- [Attmode](#attmode)
- [Aunits](#aunits)
- [Auprec](#auprec)
- [BlockTableId](#blocktableid)
- [ByBlockLinetype](#byblocklinetype)
- [ByLayerLinetype](#bylayerlinetype)
- [CameraDisplay](#cameradisplay)
- [CameraHeight](#cameraheight)
- [Cannoscale](#cannoscale)
- [Cecolor](#cecolor)
- [Celtscale](#celtscale)
- [Celtype](#celtype)
- [Celweight](#celweight)
- [Cetransparency](#cetransparency)
- [Chamfera](#chamfera)
- [Chamferb](#chamferb)
- [Chamferc](#chamferc)
- [Chamferd](#chamferd)
- [Clayer](#clayer)
- [Cmaterial](#cmaterial)
- [Cmljust](#cmljust)
- [Cmlscale](#cmlscale)
- [CmlstyleID](#cmlstyleid)
- [ColorDictionaryId](#colordictionaryid)
- [ContinuousLinetype](#continuouslinetype)
- [Cshadow](#cshadow)
- [CurrentSpaceId](#currentspaceid)
- [CurrentViewportTableRecordId](#currentviewporttablerecordid)
- [DataLinkDictionaryId](#datalinkdictionaryid)
- [DataLinkManager](#datalinkmanager)
- [DetailViewStyle](#detailviewstyle)
- [DetailViewStyleDictionaryId](#detailviewstyledictionaryid)
- [DgnFrame](#dgnframe)
- [Dimadec](#dimadec)
- [Dimalt](#dimalt)
- [Dimaltd](#dimaltd)
- [Dimaltf](#dimaltf)
- [Dimaltrnd](#dimaltrnd)
- [Dimalttd](#dimalttd)
- [Dimalttz](#dimalttz)
- [Dimaltu](#dimaltu)
- [Dimaltz](#dimaltz)
- [Dimapost](#dimapost)
- [Dimarcsym](#dimarcsym)
- [Dimaso](#dimaso)
- [DimAssoc](#dimassoc)
- [Dimasz](#dimasz)
- [Dimatfit](#dimatfit)
- [Dimaunit](#dimaunit)
- [Dimazin](#dimazin)
- [Dimblk](#dimblk)
- [Dimblk1](#dimblk1)
- [Dimblk2](#dimblk2)
- [Dimcen](#dimcen)
- [Dimclrd](#dimclrd)
- [Dimclre](#dimclre)
- [Dimclrt](#dimclrt)
- [Dimdec](#dimdec)
- [Dimdle](#dimdle)
- [Dimdli](#dimdli)
- [Dimdsep](#dimdsep)
- [Dimexe](#dimexe)
- [Dimexo](#dimexo)
- [Dimfrac](#dimfrac)
- [Dimfxlen](#dimfxlen)
- [DimfxlenOn](#dimfxlenon)
- [Dimgap](#dimgap)
- [Dimjogang](#dimjogang)
- [Dimjust](#dimjust)
- [Dimldrblk](#dimldrblk)
- [Dimlfac](#dimlfac)
- [Dimlim](#dimlim)
- [Dimltex1](#dimltex1)
- [Dimltex2](#dimltex2)
- [Dimltype](#dimltype)
- [Dimlunit](#dimlunit)
- [Dimlwd](#dimlwd)
- [Dimlwe](#dimlwe)
- [Dimpost](#dimpost)
- [Dimrnd](#dimrnd)
- [Dimsah](#dimsah)
- [Dimscale](#dimscale)
- [Dimsd1](#dimsd1)
- [Dimsd2](#dimsd2)
- [Dimse1](#dimse1)
- [Dimse2](#dimse2)
- [Dimsho](#dimsho)
- [Dimsoxd](#dimsoxd)
- [Dimstyle](#dimstyle)
- [DimStyleTableId](#dimstyletableid)
- [Dimtad](#dimtad)
- [Dimtdec](#dimtdec)
- [Dimtfac](#dimtfac)
- [Dimtfill](#dimtfill)
- [Dimtfillclr](#dimtfillclr)
- [Dimtih](#dimtih)
- [Dimtix](#dimtix)
- [Dimtm](#dimtm)
- [Dimtmove](#dimtmove)
- [Dimtofl](#dimtofl)
- [Dimtoh](#dimtoh)
- [Dimtol](#dimtol)
- [Dimtolj](#dimtolj)
- [Dimtp](#dimtp)
- [Dimtsz](#dimtsz)
- [Dimtvp](#dimtvp)
- [Dimtxsty](#dimtxsty)
- [Dimtxt](#dimtxt)
- [Dimtzin](#dimtzin)
- [Dimupt](#dimupt)
- [Dimzin](#dimzin)
- [DispSilh](#dispsilh)
- [dragvs](#dragvs)
- [DrawOrderCtl](#draworderctl)
- [DwfFrame](#dwfframe)
- [DwgFileWasSavedByAutodeskSoftware](#dwgfilewassavedbyautodesksoftware)
- [DxEval](#dxeval)
- [Elevation](#elevation)
- [EndCaps](#endcaps)
- [Extmax](#extmax)
- [Extmin](#extmin)
- [Facetres](#facetres)
- [Filename](#filename)
- [Filletrad](#filletrad)
- [Fillmode](#fillmode)
- [FingerprintGuid](#fingerprintguid)
- [GeoDataObject](#geodataobject)
- [GroupDictionaryId](#groupdictionaryid)
- [HaloGap](#halogap)
- [Handseed](#handseed)
- [HideText](#hidetext)
- [HomeView](#homeview)
- [HpInherit](#hpinherit)
- [HpOrigin](#hporigin)
- [HyperlinkBase](#hyperlinkbase)
- [Indexctl](#indexctl)
- [Insbase](#insbase)
- [Insunits](#insunits)
- [Interferecolor](#interferecolor)
- [Interfereobjvs](#interfereobjvs)
- [Interferevpvs](#interferevpvs)
- [IntersectColor](#intersectcolor)
- [IntersectDisplay](#intersectdisplay)
- [IsBeingDestroyed](#isbeingdestroyed)
- [IsEmr](#isemr)
- [Isolines](#isolines)
- [IsPartiallyOpened](#ispartiallyopened)
- [JoinStyle](#joinstyle)
- [LastSavedAsMaintenanceVersion](#lastsavedasmaintenanceversion)
- [LastSavedAsVersion](#lastsavedasversion)
- [Latitude](#latitude)
- [LayerEval](#layereval)
- [LayerFilters](#layerfilters)
- [LayerNotify](#layernotify)
- [LayerStateManager](#layerstatemanager)
- [LayerTableId](#layertableid)
- [LayerZero](#layerzero)
- [LayoutDictionaryId](#layoutdictionaryid)
- [LensLength](#lenslength)
- [LightGlyphDisplay](#lightglyphdisplay)
- [LightingUnits](#lightingunits)
- [LightsInBlocks](#lightsinblocks)
- [Limcheck](#limcheck)
- [Limmax](#limmax)
- [Limmin](#limmin)
- [LinetypeTableId](#linetypetableid)
- [LineWeightDisplay](#lineweightdisplay)
- [LoftAng1](#loftang1)
- [LoftAng2](#loftang2)
- [LoftMag1](#loftmag1)
- [LoftMag2](#loftmag2)
- [LoftNormals](#loftnormals)
- [LoftParam](#loftparam)
- [Longitude](#longitude)
- [Ltscale](#ltscale)
- [Lunits](#lunits)
- [Luprec](#luprec)
- [MaintenanceReleaseVersion](#maintenancereleaseversion)
- [MaterialDictionaryId](#materialdictionaryid)
- [Maxactvp](#maxactvp)
- [Measurement](#measurement)
- [Menu](#menu)
- [Mirrtext](#mirrtext)
- [MLeaderscale](#mleaderscale)
- [MLeaderstyle](#mleaderstyle)
- [MLeaderStyleDictionaryId](#mleaderstyledictionaryid)
- [MLStyleDictionaryId](#mlstyledictionaryid)
- [MsLtScale](#msltscale)
- [MsOleScale](#msolescale)
- [NamedObjectsDictionaryId](#namedobjectsdictionaryid)
- [NeedsRecovery](#needsrecovery)
- [NorthDirection](#northdirection)
- [NumberOfSaves](#numberofsaves)
- [ObjectContextManager](#objectcontextmanager)
- [ObscuredColor](#obscuredcolor)
- [ObscuredLineType](#obscuredlinetype)
- [OleStartUp](#olestartup)
- [OriginalFileMaintenanceVersion](#originalfilemaintenanceversion)
- [OriginalFileName](#originalfilename)
- [OriginalFileSavedByMaintenanceVersion](#originalfilesavedbymaintenanceversion)
- [OriginalFileSavedByVersion](#originalfilesavedbyversion)
- [OriginalFileVersion](#originalfileversion)
- [Orthomode](#orthomode)
- [PaperSpaceVportId](#paperspacevportid)
- [PdfFrame](#pdfframe)
- [Pdmode](#pdmode)
- [Pdsize](#pdsize)
- [Pelevation](#pelevation)
- [Pextmax](#pextmax)
- [Pextmin](#pextmin)
- [Pinsbase](#pinsbase)
- [Plimcheck](#plimcheck)
- [Plimmax](#plimmax)
- [Plimmin](#plimmin)
- [PlineEllipse](#plineellipse)
- [Plinegen](#plinegen)
- [Plinewid](#plinewid)
- [PlotSettingsDictionaryId](#plotsettingsdictionaryid)
- [PlotStyleMode](#plotstylemode)
- [PlotStyleNameDictionaryId](#plotstylenamedictionaryid)
- [PlotStyleNameId](#plotstylenameid)
- [ProjectName](#projectname)
- [Psltscale](#psltscale)
- [PsolHeight](#psolheight)
- [PsolWidth](#psolwidth)
- [Pucs](#pucs)
- [PucsBase](#pucsbase)
- [Pucsname](#pucsname)
- [Pucsorg](#pucsorg)
- [PucsOrthographic](#pucsorthographic)
- [Pucsxdir](#pucsxdir)
- [Pucsydir](#pucsydir)
- [Qtextmode](#qtextmode)
- [RegAppTableId](#regapptableid)
- [Regenmode](#regenmode)
- [RetainOriginalThumbnailBitmap](#retainoriginalthumbnailbitmap)
- [Saveproxygraphics](#saveproxygraphics)
- [SectionManagerId](#sectionmanagerid)
- [SectionViewStyle](#sectionviewstyle)
- [SectionViewStyleDictionaryId](#sectionviewstyledictionaryid)
- [SecurityParameters](#securityparameters)
- [Shadedge](#shadedge)
- [Shadedif](#shadedif)
- [ShadowPlaneLocation](#shadowplanelocation)
- [ShowHist](#showhist)
- [Sketchinc](#sketchinc)
- [Skpoly](#skpoly)
- [SolidHist](#solidhist)
- [SortEnts](#sortents)
- [Splframe](#splframe)
- [Splinesegs](#splinesegs)
- [Splinetype](#splinetype)
- [StepSize](#stepsize)
- [StepsPerSec](#stepspersec)
- [StyleSheet](#stylesheet)
- [SummaryInfo](#summaryinfo)
- [Surftab1](#surftab1)
- [Surftab2](#surftab2)
- [Surftype](#surftype)
- [Surfu](#surfu)
- [Surfv](#surfv)
- [Tablestyle](#tablestyle)
- [TableStyleDictionaryId](#tablestyledictionaryid)
- [Tdcreate](#tdcreate)
- [Tdindwg](#tdindwg)
- [Tducreate](#tducreate)
- [Tdupdate](#tdupdate)
- [Tdusrtimer](#tdusrtimer)
- [Tduupdate](#tduupdate)
- [Textsize](#textsize)
- [Textstyle](#textstyle)
- [TextStyleTableId](#textstyletableid)
- [Thickness](#thickness)
- [ThumbnailBitmap](#thumbnailbitmap)
- [TileMode](#tilemode)
- [TileModeLightSynch](#tilemodelightsynch)
- [TimeZone](#timezone)
- [Tracewid](#tracewid)
- [TransactionManager](#transactionmanager)
- [Treedepth](#treedepth)
- [TStackAlign](#tstackalign)
- [TstackSize](#tstacksize)
- [Ucs](#ucs)
- [UcsBase](#ucsbase)
- [Ucsname](#ucsname)
- [Ucsorg](#ucsorg)
- [UcsOrthographic](#ucsorthographic)
- [UcsTableId](#ucstableid)
- [Ucsxdir](#ucsxdir)
- [Ucsydir](#ucsydir)
- [UndoRecording](#undorecording)
- [Unitmode](#unitmode)
- [UpdateThumbnail](#updatethumbnail)
- [Useri1](#useri1)
- [Useri2](#useri2)
- [Useri3](#useri3)
- [Useri4](#useri4)
- [Useri5](#useri5)
- [Userr1](#userr1)
- [Userr2](#userr2)
- [Userr3](#userr3)
- [Userr4](#userr4)
- [Userr5](#userr5)
- [Usrtimer](#usrtimer)
- [VersionGuid](#versionguid)
- [ViewportScaleDefault](#viewportscaledefault)
- [ViewportTableId](#viewporttableid)
- [ViewTableId](#viewtableid)
- [Visretain](#visretain)
- [VisualStyleDictionaryId](#visualstyledictionaryid)
- [Worldview](#worldview)
- [XclipFrame](#xclipframe)
- [XrefBlockId](#xrefblockid)
- [XrefEditEnabled](#xrefeditenabled)


## Constructors Details

### Database()

#### Description
Default constructor.
```text
public Database();
```

### Database([MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Constructor with additional options.
```text
public Database(
    [MarshalAs(UnmanagedType.U1)] bool buildDefaultDrawing, 
    [MarshalAs(UnmanagedType.U1)] bool noDocument
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool buildDefaultDrawing | System.Boolean specifying whether or not to build an empty object |
| [MarshalAs(UnmanagedType.U1)] bool noDocument | System.Boolean specifying whether or not to associate this database to the current document |

### AbortDxfIn

#### Description
Wraps AcRxEventReactor::abortDxfIn. The event indicates that the drawing database being operated on was modified by a DXF input operation, but that the operation was terminated before completion.
```text
public event EventHandler AbortDxfIn;
```

### AbortDxfOut

#### Description
Wraps AcRxEventReactor::abortDxfOut. The event indicates that the drawing database being operated on was modified by a DXF output operation, but that the operation was terminated before completion.
```text
public event EventHandler AbortDxfOut;
```

### AbortSave

#### Description
Wraps AcRxEventReactor::abortSave. The event indicates that the drawing database being operated on was not saved, and the save operation failed.
```text
public event EventHandler AbortSave;
```

### BeginDeepClone

#### Description
Wraps AcRxEventReactor::beginDeepClone. This event indicates that a deep clone operation is starting on the drawing database.
```text
public event IdMappingEventHandler BeginDeepClone;
```

### BeginDeepCloneTranslation

#### Description
Wraps AcRxEventReactor::beginDeepCloneTranslation. A deep clone operation has two stages. First, each object and any owned objects are cloned. Second, any object ID references are translated to their cloned IDs. 
This event occurs between these two stages.
```text
public event IdMappingEventHandler BeginDeepCloneTranslation;
```

### BeginDxfIn

#### Description
Wraps AcRxEventReactor::beginDxfIn. The event indicates that the drawing database being operated on is about to be altered by a DXF input operation.
```text
public event EventHandler BeginDxfIn;
```

### BeginDxfOut

#### Description
Wraps AcRxEventReactor::beginDxfOut. The event indicates that the drawing database being operated on is about to be output in a DXF output operation.
```text
public event EventHandler BeginDxfOut;
```

### BeginInsert

#### Description
Wraps AcRxEventReactor::beginInsert. The event indicates that the drawing database being operated on is being added to the drawing database.
```text
public event BeginInsertEventHandler BeginInsert;
```

### BeginSave

#### Description
Wraps AcRxEventReactor::beginSave. The event indicates that the drawing database being operated on is about to be saved.
```text
public event DatabaseIOEventHandler BeginSave;
```

### BeginWblockBlock

#### Description
Wraps AcRxEventReactor::beginWblock. The event indicates that a wblock operation is being performed.
```text
public event BeginWblockBlockEventHandler BeginWblockBlock;
```

### BeginWblockEntireDatabase

#### Description
Wraps AcRxEventReactor::beginWblock. The event indicates that a wblock operation is being performed on the drawing database.
```text
public event BeginWblockEntireDatabaseEventHandler BeginWblockEntireDatabase;
```

### BeginWblockObjects

#### Description
Wraps AcRxEventReactor::beginWblockObjects. The event is made once for the database during each wblock clone execution.
```text
public event BeginWblockObjectsEventHandler BeginWblockObjects;
```

### BeginWblockSelectedObjects

#### Description
Wraps AcRxEventReactor::beginWblock. The event indicates that a wblock operation is being performed on a set of entities within the drawing database.
```text
public event BeginWblockSelectedObjectsEventHandler BeginWblockSelectedObjects;
```

### DatabaseConstructed

#### Description
Wraps AcRxEventReactor::databaseConstructed. The event indicates that the Database constructor has finished.
```text
public static event EventHandler DatabaseConstructed;
```

### DatabaseToBeDestroyed

#### Description
Wraps AcRxEventReactor::databaseToBeDestroyed. The event indicates that the drawing database is about to be destroyed.
```text
public event EventHandler DatabaseToBeDestroyed;
```

### DeepCloneAborted

#### Description
Wraps AcRxEventReactor::abortDeepClone. The event indicates that the deep clone operation terminated.
```text
public event EventHandler DeepCloneAborted;
```

### DeepCloneEnded

#### Description
Wraps AcRxEventReactor::endDeepClone. The event indicates that the deep clone operation concluded successfully.
```text
public event EventHandler DeepCloneEnded;
```

### Disposed

#### Description
Wraps AcDbDatabaseReactor::goodbye. The event indicates that the DWG database is about to be deleted.
```text
public event EventHandler Disposed;
```

### DwgFileOpened

#### Description
Wraps AcRxEventReactor::dwgFileOpened. The event indicates that the drawing file is being read and stored in the drawing database.
```text
public event DatabaseIOEventHandler DwgFileOpened;
```

### DxfInComplete

#### Description
Wraps AcRxEventReactor::dxfInComplete. The event indicates that the drawing database was successfully modified by a DXF input operation.
```text
public event EventHandler DxfInComplete;
```

### DxfOutComplete

#### Description
Wraps AcRxEventReactor::dxfOutComplete. The event indicates that the output operation taking place on the drawing database was successful.
```text
public event EventHandler DxfOutComplete;
```

### InitialDwgFileOpenComplete

#### Description
Wraps AcRxEventReactor::initialDwgFileOpenComplete. The event is sent at the completion of the initial load of a drawing database.
```text
public event EventHandler InitialDwgFileOpenComplete;
```

#### Conditions
Read-only Accesses the pre-existing
### InsertAborted

#### Description
Wraps AcRxEventReactor::abortInsert. The event indicates that an insert operation on the drawing database was terminated and did not complete.
```text
public event EventHandler InsertAborted;
```

### InsertEnded

#### Description
Wraps AcRxEventReactor::endInsert. The event indicates that an insert operation on the drawing database is complete.
```text
public event EventHandler InsertEnded;
```

### InsertMappingAvailable

#### Description
Wraps AcRxEventReactor::otherInsert. The event is sent right before beginDeepCloneTranslation is sent.
```text
public event IdMappingEventHandler InsertMappingAvailable;
```

### ObjectAppended

#### Description
Wraps AcDbDatabaseReactor::objectAppended. The event indicates that an object has been added to the database.
```text
public event ObjectEventHandler ObjectAppended;
```

### ObjectErased

#### Description
Wraps AcDbDatabaseReactor::objectErased. The event indicates that an object is being erased or unerased from the database.
```text
public event ObjectErasedEventHandler ObjectErased;
```

### ObjectModified

#### Description
Wraps AcDbDatabaseReactor::objectModified. The event indicates that an object has been modified.
```text
public event ObjectEventHandler ObjectModified;
```

### ObjectOpenedForModify

#### Description
Wraps AcDbDatabaseReactor::objectModified. The event is invoked before the object has been modified.
```text
public event ObjectEventHandler ObjectOpenedForModify;
```

### ObjectReappended

#### Description
Wraps AcDbDatabaseReactor::objectReAppended. The event is invoked when an object has had its addition to the database dwg undone during an Undo operation, and has now been re-appended to the database due to an execution of the AutoCAD REDO command.
```text
public event ObjectEventHandler ObjectReappended;
```

### ObjectUnappended

#### Description
Wraps AcDbDatabaseReactor::objectUnAppended. The event is invoked when an object has had its addition to the database dwg undone during an Undo operation.
```text
public event ObjectEventHandler ObjectUnappended;
```

### PartialOpenNotice

#### Description
Wraps AcRxEventReactor::partialOpenNotice. The event is invoked just before an attempt to partially open a database.
```text
public event EventHandler PartialOpenNotice;
```

### ProxyResurrectionCompleted

#### Description
Wraps AcDbDatabaseReactor::proxyResurrectionCompleted. The event is invoked when the loading of an ObjectARX or ObjectDBX module resurrects proxy objects in the DWG database.
```text
public event ProxyResurrectionCompletedEventHandler ProxyResurrectionCompleted;
```

### SaveComplete

#### Description
Wraps AcRxEventReactor::saveComplete. The event indicates that the drawing database was saved to a file.
```text
public event DatabaseIOEventHandler SaveComplete;
```

### SystemVariableChanged

#### Description
Wraps AcDbDatabaseReactor::headerSysVarChanged. The event indicates that an attempt was made to change the 'name' system variable.
```text
public event SystemVariableChangedEventHandler SystemVariableChanged;
```

### SystemVariableWillChange

#### Description
Wraps AcDbDatabaseReactor::headerSysVarWillChange. The event indicates that an attempt is being made to change the 'name' system variable.
```text
public event SystemVariableChangingEventHandler SystemVariableWillChange;
```

### WblockAborted

#### Description
Wraps AcRxEventReactor::abortWblock. The event indicates that a wblock being performed to the drawing was terminated and did not complete.
```text
public event EventHandler WblockAborted;
```

### WblockEnded

#### Description
Wraps AcRxEventReactor::endWblock. The event indicates that a wblock being performed to the drawing completed successfully.
```text
public event EventHandler WblockEnded;
```

### WblockMappingAvailable

#### Description
Wraps AcRxEventReactor::otherWblock. The event indicates that a wblock is being performed on the drawing database.
```text
public event IdMappingEventHandler WblockMappingAvailable;
```

### WblockNotice

#### Description
Wraps AcRxEventReactor::wblockNotice. The event indicates that a wblock operation is about to start.
```text
public event WblockNoticeEventHandler WblockNotice;
```

### XrefAttachAborted

#### Description
Wraps AcEditorReactor::abortAttach. The event indicates that an that an external reference attach operation has been performed to the drawing, but has not completed successfully.
```text
public static event EventHandler XrefAttachAborted;
```

### XrefAttachEnded

#### Description
Wraps AcEditorReactor::endAttach. The event indicates that an that an external reference attach operation has been performed to the drawing, and has completed successfully.
```text
public event EventHandler XrefAttachEnded;
```

### XrefBeginAttached

#### Description
Wraps AcEditorReactor::beginAttach. The event indicates that an that an external reference database is to be attached to the database.
```text
public event XrefBeginOperationEventHandler XrefBeginAttached;
```

### XrefBeginOtherAttached

#### Description
Wraps AcEditorReactor::otherAttach. The event is sent just after beginDeepCloneTranslation notification, but only occurs for the xref attach process.
```text
public event XrefBeginOperationEventHandler XrefBeginOtherAttached;
```

### XrefBeginRestore

#### Description
Wraps AcEditorReactor::beginRestore. The event indicates that the Xref was previously unloaded, and now is to be reloaded, but its file has not changed.
```text
public event XrefBeginOperationEventHandler XrefBeginRestore;
```

### XrefComandeered

#### Description
Wraps AcEditorReactor::commandeered. The event indicates that an object is commandeered, meaning that the objectId of the object is appended to the host drawing's (the drawing being XREFd into) symbol table.
```text
public event XrefComandeeredEventHandler XrefComandeered;
```

### XrefPreXrefLockFile

#### Description
Wraps AcEditorReactor::preXrefLockFile. The event is sent just before an Xref is locked.
```text
public event XrefPreXrefLockFileEventHandler XrefPreXrefLockFile;
```

### XrefRedirected

#### Description
Wraps AcEditorReactor::redirected. The event indicates that an objectId is redirected, meaning that an objectId in the xref drawing is modified to point to the associated object in the host drawing (the drawing being XREFd into).
```text
public event XrefRedirectedEventHandler XrefRedirected;
```

### XrefRestoreAborted

#### Description
Wraps AcEditorReactor::abortRestore. The event indicates that a restore operation on the drawing database was terminated and did not complete.
```text
public event EventHandler XrefRestoreAborted;
```

### XrefRestoreEnded

#### Description
Wraps AcEditorReactor::endRestore. The event indicates that that the Xref was previously unloaded, and now has been reloaded, but its file has not changed.
```text
public event EventHandler XrefRestoreEnded;
```

### XrefSubCommandAborted

#### Description
Wraps AcRxEventReactor::xrefSubCommandAborted. This notification is sent if the xref subcommand is aborted during the xrefSubCommandStart() call.
```text
public event XrefSubCommandAbortedEventHandler XrefSubCommandAborted;
```

### XrefSubCommandEnd

#### Description
This is XrefSubCommandEnd, a member of class Database.
```text
public event XrefSubCommandEndEventHandler XrefSubCommandEnd;
```

### XrefSubCommandStart

#### Description
Wraps AcRxEventReactor::xrefSubCommandStart. This notification is sent on the start of an xref subcommand.
```text
public event XrefSubCommandStartEventHandler XrefSubCommandStart;
```

### AbortDeepClone

#### Description
Triggers an Editor notification that the deepClone operation identified by idMap has been aborted. The IdMapping object will uniquely identify a deepClone operation.
Note
This function does not actually abort a deepClone operation.
```text
public void AbortDeepClone(
    IdMapping idMap
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IdMapping idMap | Input used in the deepClone operation being aborted |

### AddDBObject

#### Description
Adds the object pointed to by appendIt to the database, giving it a handle and an object ID. The new object ID is returned.
```text
public ObjectId AddDBObject(
    [CallerMustClose] DBObject appendIt
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [CallerMustClose] DBObject appendIt | Input object to be added to the database |

### ApplyPartialOpenFilters

#### Description
This is ApplyPartialOpenFilters, a member of class Database.
```text
public void ApplyPartialOpenFilters(
    SpatialFilter spatialFilter, 
    Autodesk.AutoCAD.DatabaseServices.LayerFilter layerFilter
);
```

### AttachXref

#### Description
Attaches the xref file specified by fileName to the database, thus creating a new xref BlockTableRecord. The new block table record's name is specified in blockName. Its object ID is returned. 
This function does not lock the document, nor does it create an BlockReference instance of the new block table record.
```text
public ObjectId AttachXref(
    string fileName, 
    string blockName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input xref file path name |
| string blockName | Input xref block name symbol to use |

### AuditXData

#### Description
Currently not implemented.
```text
public void AuditXData(
    AuditInfo info
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AuditInfo info | Not implemented |

### BindXrefs

#### Description
This function binds the xrefs whose BlockTableRecord object IDs are in xrefIds. If insertBind is true, then the symbolTable record names will be changed from the xref naming convention to normal insert block names. 
The object IDs in xrefIds must all be from the database and they must all be resolved.
```text
public void BindXrefs(
    ObjectIdCollection xrefIds, 
    [MarshalAs(UnmanagedType.U1)] bool insertBind
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdCollection xrefIds | Input collection of ObjectIds for the xref BlockTableRecords to bind. |
| [MarshalAs(UnmanagedType.U1)] bool insertBind | Input System.Boolean to indicate whether or not to convert xref symbols to insert-like bind names. |

### ClassDxfName

#### Description
This function returns the DXF name for the class.
```text
public string ClassDxfName(
    RXClass getMyDxfName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| RXClass getMyDxfName | Input Autodesk.AutoCAD.Runtime.RXClass object to get the name of. |

### CloseInput

#### Description
If a drawing file is associated with this Database, then this function forces an immediate read of all necessary information from the file into the Database object and disconnects the file from the Database. 
If closeFile is true, the drawing file will be closed when it has been fully read into, and disconnected from, the Database. If closeFile is false, the drawing file will still be disconnected from the Database, but the drawing file will remain open until the host application session ends. 
This function will only execute once per Database, so multiple calls will have no effect after the first call. 
Passing true for this argument is recommended. 
If a drawing file is associated with this database, then this function forces an immediate read of all necessary information from the file into the database object. If closeFile is true, the drawing file will be closed when it has been fully read into the Database.
```text
public void CloseInput(
    [MarshalAs(UnmanagedType.U1)] bool closeFile
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool closeFile | Input System.Boolean indicating whether to close the drawing file |

#### Notes
**WARNING:** This function should only be called on Database objects that your application has created and read in from a drawing file using the Database.ReadDwgFile() function.
### CountEmptyObjects

#### Description
Counts empty objects (zero length curves and/or empty TEXT/MTEXT) in the database.
```text
public int CountEmptyObjects(
    int flags
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int flags | The setting of the count mode. It is stored as a bitcode using the combination of the following enum values:ZeroLengthCurve - Count zero length curves (AcDbCurve derived objects such as LINE, POLYLINE, SPLINE, etc.)EmptyText - Count empty TEXT/MTEXT objects (which contain only spaces, tabs, enters and/or new lines)AllEmptyObj - Count all empty objects |

#### Returns
Number of empty objects in the database
#### Remarks
RAY and XLINE objects are also derived from AcDbCurve, but they have infinite length by definition. Hence they are not involved in this method.
### CountHardReferences

#### Description
This function traverses the database looking for objects with a hard reference to any of the objects whose objectId entities are in the ids array. Each time such a hard reference is found, the count will be incremented by 1 within the element of count that corresponds to the ids element of the objectId that is being hard referenced. For example, if a hard reference is found to the objectId in ids[2], then count[2] will be incremented by 1. 
It is the caller's responsibility to make sure the elements of count are zero (or whatever other value is desired). This function will simply increment whatever value is there. It is also the caller's responsibility to be sure that the ids and count arrays are the same size.
```text
public void CountHardReferences(
    ObjectIdCollection ids, 
    int\[\] count
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdCollection ids | Input collection of objectId entities of objects to find the count of hard references to those objects |
| int[] count | Input array of the same size as ids that will be filled in with the counts for each corresponding element in ids |

### DbFromId

#### Description
Looks up a runtime ID in a map and returns the associated Database object.
```text
public static Database DbFromId(
    long id
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| long id | Input integer that represents the runtime ID of the Database to return |

#### Returns
Database object if a match to the runtime ID is found, else null.
### DeepCloneObjects

#### Description
Clones all objects in the objectId array and appends them to the container object specified by owner. mapping is filled with IdMapping objects that contain the objectId entities of the original and cloned object pairs. This array can be used for post-processing the objects involved in the deepClone operation. 
When the new objects are assigned owners, layout objects trigger an assert that the owner is the destination database's layout dictionary and the layout is given a name in the dictionary that matches the name stored inside the layout. (The default behavior for dictionary-owned objects would be to give it an anonymous name like "*A1".)
```text
public void DeepCloneObjects(
    ObjectIdCollection identifiers, 
    ObjectId id, 
    IdMapping mapping, 
    [MarshalAs(UnmanagedType.U1)] bool deferTranslation
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdCollection identifiers | Input collection of objects to be deep cloned |
| ObjectId id | Input Object ID of object to be the owner of the clones |
| IdMapping mapping | Returns collection of objects to be used for translating object ID relationships |
| [MarshalAs(UnmanagedType.U1)] bool deferTranslation | Input Boolean indicating whether or not ID translation should be done |

### DetachXref

#### Description
This function detaches the xref in the database whose BlockTableRecord is specified by xrefId.
```text
public void DetachXref(
    ObjectId xrefId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId xrefId | Input object ID of the xref block to detach |

### DisablePartialOpen

#### Description
When called during partial open notification, this function vetoes the partial open operation and causes the entire drawing database to be loaded.
```text
public void DisablePartialOpen();
```

### DisableUndoRecording

#### Description
This function turns Undo recording on or off for operations performed on the database. If disable==true, then Undo recording is turned off. 
This function does not erase any existing Undo information. It only turns the Undo recorder on and off for the database.
Note
Newly created Database objects have Undo turned off. A call to this function with an false argument is necessary to enable the Undo recording in Database.
```text
public void DisableUndoRecording(
    [MarshalAs(UnmanagedType.U1)] bool disable
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool disable | Input Boolean indicating turn Undo on or off |

### DxfIn

#### Description
This function reads the DXF file specified into the database object. 
The default for fileName is no output file. When there is no output file, warning/error messages will be output character-by-character through the displayChar() method in HostApplicationServices. 
**Warning**
This function should be used only on a newly created Database that was created with its constructor's buildDefaultDrawing argument set to false. If this method is used on an Database created with buildDefaultDrawing set to true or a Database that already has information in it (for any reason including a previous call to this method), then memory leaks or possibly fatal errors will result.
```text
public void DxfIn(
    string fileName, 
    string logFilename
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input full path of the DXF file to be read into database |
| string logFilename | Log file to record all warning/error messages from reading the DXF file |

### DxfOut(string, int, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This function creates an DXF file.
Note
The precision may also be set to -1 to change the output format from the default ASCII DXF format to the binary DXF format.
```text
public void DxfOut(
    string fileName, 
    int precision, 
    [MarshalAs(UnmanagedType.U1)] bool saveThumbnailImage
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input name or URL of the new DXF file to create (the .dxf extension is not added automatically) |
| int precision | Input number of bits of accuracy, from 0 to 16 |
| [MarshalAs(UnmanagedType.U1)] bool saveThumbnailImage | Input Boolean indicating whether to save thumbnail |

### DxfOut(string, int, DwgVersion)

#### Description
This function creates an DXF file. 
**Note**
The precision may also be set to -1 to change the output format from the default ASCII DXF format to the binary DXF format.
```text
public void DxfOut(
    string fileName, 
    int precision, 
    DwgVersion version
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input name or URL of the new DXF file to create (the .dxf extension is not added automatically) |
| int precision | Input number of bits of accuracy, from 0 to 16 |
| DwgVersion version | Sets the DWG version major and minor number |

### DxfOutEx

#### Description
Saves this drawing to a DXF file and allows the caller to specify a code page.
```text
public void DxfOutEx(
    string fileName, 
    int precision, 
    DwgVersion version, 
    [MarshalAs(UnmanagedType.U1)] bool saveThumbnailImage, 
    int nCodePage
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input name or URL of the new DXF file to create (the .dxf extension is not added automatically) |
| int precision | Input number of bits of accuracy, from 0 to 16 |
| DwgVersion version | Input as a constant which represents the DXF format version to create, R12 through current |
| [MarshalAs(UnmanagedType.U1)] bool saveThumbnailImage | Input Boolean indicating whether to save thumbnail |
| int nCodePage | Input code page to use for pre-2007 dxf formats |

### EraseEmptyObjects

#### Description
Erases empty objects (zero length curves and/or empty TEXT/MTEXT) in the database.
```text
public int EraseEmptyObjects(
    int flags
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int flags | The setting of the erase mode. It is stored as a bitcode using the combination of the following enum values:ZeroLengthCurve - Erase zero length curves (AcDbCurve derived objects such as LINE, POLYLINE, SPLINE, etc.)EmptyText - Erase empty TEXT/MTEXT objects (which contain only spaces, tabs, enters and/or new lines)AllEmptyObj - Erase all empty objects |

#### Returns
Number of objects which are (or can be) erased.
#### Remarks
RAY and XLINE objects are also derived from AcDbCurve, but they have infinite length by definition. Hence they are not involved in this method.
### EvaluateFields()

#### Description
Evaluates the fields defined in annotation objects. 
**Note:** It is recommended to call this method prior to saving or transmitting a database, or plotting/publishing a layout to ensure all fields show the latest value. 
```text
public FieldEvaluationResult EvaluateFields();
```

### EvaluateFields(FieldEvaluationContext)

#### Description
Evaluates the fields defined in annotation objects. 
**Note:** It is recommended to call this method prior to saving or transmitting a database, or plotting/publishing a layout to ensure all fields show the latest value. 
```text
public FieldEvaluationResult EvaluateFields(
    FieldEvaluationContext context
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FieldEvaluationContext context | Input bitwise value that determines the contexts in which fields should be evaluated. Refer to the DatabaseServices.FieldEvaluationContext enum for available context values. |

### EvaluateFields(FieldEvaluationContext, string)

#### Description
Evaluates the fields defined in annotation objects. 
**Note:** It is recommended to call this method prior to saving or transmitting a database, or plotting/publishing a layout to ensure all fields show the latest value. 
```text
public FieldEvaluationResult EvaluateFields(
    FieldEvaluationContext context, 
    string prop
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FieldEvaluationContext context | Input bitwise value that determines the contexts in which fields should be evaluated. Refer to the DatabaseServices.FieldEvaluationContext enum for available context values. |
| string prop | Input property name whose field is to be evaluated; if empty, all fields are evaluated |

### ForceWblockDatabaseCopy

#### Description
This function causes the next (and only the next) Database.wblock() call on this database to result in a copy of the database. (A database copy was always done by ObjectARX SDK 1.0 and 1.1.) 
Using this function results in a slower wblock operation and an increase in memory requirements. Therefore, this method should only be used if your application does special handling during WBLOCK* notifications, which can only be done if the WBLOCK* copies the database.
```text
public void ForceWblockDatabaseCopy();
```

#### Notes
This method is non-functional unless a wblockNotice event has been received.
### FromAcadDatabase

#### Description
Converts a COM object of the type AcadDatabase to a Database object.
```text
public static Database FromAcadDatabase(
    object acadDatabase
);
```

### GetAllDatabases

#### Description
Returns an array of all currently active databases. 
Can be used to validate a Database object.
```text
public static List<Database> GetAllDatabases();
```

### GetDimensionStyleChildData

#### Description
This function returns the DimStyleTableRecord referenced by the dimension.
```text
public DimStyleTableRecord GetDimensionStyleChildData(
    RXClass classDescriptor
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| RXClass classDescriptor | Input object to check. |

### GetDimensionStyleChildId

#### Description
Given a parent dimension style ID and a dimension class descriptor, this function returns the child dimension style ID, if available, for the given dimension type. 
Returns the given parent dimension style ID if a child dimension style corresponding to the given dimension class is not available.
```text
public ObjectId GetDimensionStyleChildId(
    RXClass classDescriptor, 
    ObjectId parentStyle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| RXClass classDescriptor | Input dimension class descriptor |
| ObjectId parentStyle | Input parent dimension style ID |

### GetDimensionStyleParentId

#### Description
Given a child dimension style ID, this function returns the parent dimension style ID. If the parent is unavailable, the given child dimension style ID is returned.
```text
public ObjectId GetDimensionStyleParentId(
    ObjectId childStyle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId childStyle | Input child dimension style ID |

### GetDimRecentStyleList

#### Description
This function allows the application to get the object ID entities of the most recently used dimstyles (up to 6) for dimension context menu dimstyle MRU list support. Most recently used dimstyle objects are tracked by monitoring the past six dimstyle objects that were current in the database.
```text
public ObjectIdCollection GetDimRecentStyleList();
```

### GetDimstyleData

#### Description
This function copies the database dimension variable values into the DimStyleTableRecord.
```text
public DimStyleTableRecord GetDimstyleData();
```

### GetHostDwgXrefGraph

#### Description
Returns the node associated with the host drawing.
```text
public XrefGraph GetHostDwgXrefGraph(
    [MarshalAs(UnmanagedType.U1)] bool includeGhosts
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool includeGhosts | If set to true, includes ghost nodes. |

### GetMetaObject

#### Description
This is GetMetaObject, a member of class Database.
```text
public DynamicMetaObject GetMetaObject(
    Expression parameter
);
```

### GetNearestLineWeight

#### Description
The getNearestLineWeight() method takes a lineweight and returns the nearest LineWeight enum value. For example, if you pass in 4, then the value LineWeight005 is returned.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight GetNearestLineWeight(
    int weight
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int weight | Input lineweight in hundredths of a millimeter |

### GetObjectId

#### Description
Returns the objectId of the object that has the handle value contained in objHandle. If createIfNotFound is true and the handle is not found in the database, then a new objectId stub object is created using the handle sought. 
Use of the createIfNotFound argument is intended for AutoCAD internal use only (there is no way for an ObjectARX program to do anything with a objectId stub object that is not associated with any database object), so ObjectARX programs should always set this argument to false.
```text
public ObjectId GetObjectId(
    [MarshalAs(UnmanagedType.U1)] bool createIfNotFound, 
    Handle objHandle, 
    int identifier
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool createIfNotFound | Input Boolean indicating to create a objectId stub if input handle is not found |
| Handle objHandle | Input Handle object containing the handle being passed in |
| int identifier | Reserved for future use |

### GetSupportedDxfOutVersions

#### Description
Returns an array with the major and minor version numbers of outputting DXF.
```text
public DwgVersion\[\] GetSupportedDxfOutVersions();
```

### GetSupportedSaveVersions

#### Description
Returns an array with the major and minor version numbers of the saving ability.
```text
public DwgVersion\[\] GetSupportedSaveVersions();
```

### GetViewports

#### Description
This function enumerates the Viewports in a drawing.
```text
public ObjectIdCollection GetViewports(
    [MarshalAs(UnmanagedType.U1)] bool bGetPaperspaceVports
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool bGetPaperspaceVports | Input flag indicating whether to return paperspace viewports associated with layouts |

### GetVisualStyleList

#### Description
This function returns a list containing the localized names of the visual styles defined in the visual style dictionary. Anonymous visual styles and visual styles marked for internal use only are excluded from this list.
```text
public StringCollection GetVisualStyleList();
```

### IdFromDb

#### Description
Looks up a database in a map and returns its runtime ID.
```text
public static long IdFromDb(
    Database dataBase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Database dataBase | Input Database of which to get its runtime ID |

#### Returns
Long integer > 0 if found, else <= 0.
### Insert(Matrix3d, Database, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Inserts the Model Space of the database pointed to by dataBase into the Model Space of the database invoking the insert() function. All objects being inserted have the xform matrix passed into their transformBy() function during the insertion process. 
The preserveSourceDatabase argument determines whether the source database dataBase is left intact or not. The default value of the argument is true. In that case, objects from the source database are copied to the destination database and the source database is not changed. If the caller passes false for this argument, objects from the source database could be physically moved into the destination database. The latter runs faster, but it leaves the source database dependent on the destination database. The caller should make sure that the source database is deleted either immediately or at least before the destination database is deleted.
```text
public void Insert(
    Matrix3d transform, 
    Database dataBase, 
    [MarshalAs(UnmanagedType.U1)] bool preserveSourceDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Matrix3d transform | Input transformation matrix applied to all objects being inserted |
| Database dataBase | Input database to insert from |
| [MarshalAs(UnmanagedType.U1)] bool preserveSourceDatabase | Input to determine whether the source database pDb will be left intact |

### Insert(string, Database, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This function mimics the AutoCAD INSERT command. First a new block table record is created in the database executing this function. This new block table record is given the name pointed to by blockName. Then, all the Model Space entities in the database pointed to by dataBase are copied into the new block table record. 
The preserveSourceDatabase argument determines whether the source database dataBase is left intact. The default value of the argument is true. In that case, objects from the source database are copied to the destination database, and the source database is not changed. If the caller passes false for this argument, objects from the source database could be physically moved into the destination database. The latter runs faster, but it leaves the source database dependent on the destination database. The caller should make sure that the source database is deleted either immediately, or at least before the destination database is deleted. 
Returns the object ID for the new block table record created by this function.
```text
public ObjectId Insert(
    string blockName, 
    Database dataBase, 
    [MarshalAs(UnmanagedType.U1)] bool preserveSourceDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string blockName | Input name to be used by the new block table record created by this function |
| Database dataBase | Input database from which to insert entities |
| [MarshalAs(UnmanagedType.U1)] bool preserveSourceDatabase | Input bool to determine whether the source database is left intact |

### Insert(string, string, Database, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This function creates a new block table record in the database executing this function. This new block table record is given the name pointed to by destinationBlockName. Then, each entity in the block table record whose name is sourceBlockName and which resides in the database pointed to by dataBase is copied into the new block table record. 
The preserveSourceDatabase argument determines whether the source database dataBase is left intact. The default value of the argument is true. In that case, objects from the source database are copied to the destination database, and the source database is not changed. If the caller passes false for this argument, objects from the source database could be physically moved into the destination database. The latter runs faster, but it leaves the source database dependent on the destination database. The caller should make sure that the source database is deleted either immediately, or at least before the destination database is deleted. 
Returns the object ID for the new block table record created by this function.
```text
public ObjectId Insert(
    string sourceBlockName, 
    string destinationBlockName, 
    Database dataBase, 
    [MarshalAs(UnmanagedType.U1)] bool preserveSourceDatabase
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string sourceBlockName | Input name of the blockTableRecord |
| string destinationBlockName | Input name to be used by the new block table record created by this function |
| Database dataBase | Input database from which to insert entities |
| [MarshalAs(UnmanagedType.U1)] bool preserveSourceDatabase | Input bool to determine whether the source database is left intact |

### IsObjectNonPersistent

#### Description
Returns true if the object denoted by id is non-persistent.
```text
public static bool IsObjectNonPersistent(
    ObjectId id
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | Input ID of the object to be interrogated |

### IsValidLineWeight

#### Description
Returns true for lineweights that match one of the predefined lineweights, and false otherwise.
```text
public bool IsValidLineWeight(
    int weight
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int weight | Input lineweight in hundredths of a millimeter |

### LoadLineTypeFile

#### Description
This function loads the linetype specified by lineTypeName from the file specified by filename and stores it in the database on which this method is called. 
The lineTypeName parameter may contain wild card characters. If wild cards are used, multiple linetypes may be loaded. 
If filename is not a URL and does not contain a path, then the AutoCAD library search path is searched for the file.
```text
public void LoadLineTypeFile(
    string lineTypeName, 
    string filename
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string lineTypeName | Input linetype name string (wild cards may be used) |
| string filename | Input path/filename or URL of linetype file to load from (path is optional) |

### LoadMlineStyleFile

#### Description
This function loads the MlineStyle specified by mlineStyleName from the file specified by fileName. If fileName is not a URL and does not contain any path information, then the AutoCAD library search path will be searched for the file. 
mlineStyleName cannot contain wild cards. 
```text
public void LoadMlineStyleFile(
    string mlineStyleName, 
    string fileName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string mlineStyleName | Input MlineStyle name string (no wild cards) |
| string fileName | Input path/filename or URL of file to load from (path is optional) |

### MarkObjectNonPersistent

#### Description
Marks an object non-persistent or persistent. Objects in the drawing database are persistent by default (if they have an owner). This function allows objects to be marked non-persistent.
```text
public static void MarkObjectNonPersistent(
    ObjectId id, 
    [MarshalAs(UnmanagedType.U1)] bool value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | Input ID of the object to be modified |
| [MarshalAs(UnmanagedType.U1)] bool value | Input true to make the object non-persistent, or false to make it persistent |

### OverlayXref

#### Description
Overlays the xref file specified by fileName to the database, thus creating a new xref BlockTableRecord. The new block table record's name is specified in blockName. Its object ID is returned. 
This function does not lock the document, nor does it create an BlockReference instance of the new block table record. 
Xref log file processing is available if that option is enabled. Normal AutoCAD behavior with regard to output indicators, such as progress meters and messages, may be unavailable if scripts are enabled and cmdecho is 0, if menu macros are enabled and menuecho is set to 0, or if menu encryption is set. 
This function is available to non-AutoCAD-based host applications.
```text
public ObjectId OverlayXref(
    string fileName, 
    string blockName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input xref file path name |
| string blockName | Input xref block name symbol to use |

### Purge(ObjectIdCollection)

#### Description
This function searches through the database to see if there are any hard references to objects with object ID entities in the ids array. If any such objects are found, their object ID entities are removed from the ids array. So, when this function returns, the ids array will contain only object ID entities of objects that are not currently hard-referenced and thus can safely be erased. 
If the database is in a partially opened state, object ID entities of objects that were not created in the current editing session are also removed from the ids array.
Note
This function does not modify the database in any way. 
To duplicate the AutoCAD purge mechanism functionality, use this function to determine what database objects (of the type desired) can be purged or erased, and then open each such object, call its erase() method to erase it, and close it. For example, to purge all unreferenced layers, call the purge method, passing in an array containing the object ID entities of all the LayerTableRecords in the LayerTable, then erase all the objects whose object ID entities are still in the array after the purge function has returned.
```text
public void Purge(
    ObjectIdCollection ids
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdCollection ids | Input collection of object ID entities of objects |

### Purge(ObjectIdGraph)

#### Description
This version of the purge() method works in one pass. The method looks for references between the objects passed in so that it does not need to be called multiple times. In other words, if a Layer and a Linetype are passed in, and the only reference to the Linetype is from the Layer, then the graph returned will indicate that both the Layer and the Linetype can be purged. (The older ObjectIdCollection version of purge() would first indicate that only the Layer could be purged. Then a second call, after erasing the Layer, would say that the Linetype could be purged.) 
A graph is returned so that you do not need to erase all the objects passed back, just like in the other purge(). However, if you want to selectively erase only part of the objects passed back, you must only erase root-type nodes on the graph. In other words, from the above example, the graph passed back would contain both the Layer and Linetype nodes, but there would be an edge from the Layer to the Linetype. Thus only the Layer would be a root-type node, with no incoming edges. That means that you could erase the Layer by itself, but not the Linetype. If you want to erase the Linetype, then you must also erase the Layer. That's why the return data is in a graph. 
Note
  * Since the ObjectIdGraph version (this method) does more checking, it is slower than the ObjectIdCollection version.
  * If only one type of symbol is being checked through purge(), and it is not a BTR (which can have references to each other), then the older, faster ObjectIdCollection purge() should be used.
  * Only use this version in cases where there were loops before. In other words, if the types of symbols being passed in can reference each other, then the purge(ObjectIdCollection) function would have had to have been called multiple times. Even though this function is slower, since it only has to be called once, it ends up being faster for this inter-reference case.
  * If you intend to always erase everything returned, then you do not have to examine the graph. You can just iterate on graph nodes and erase the objects, but you must erase all of them. The graph edges only need to be examined if part of the graph is to be erased, to make sure that no edges, or inter-references, are left dangling. In such a case, only nodes with no incoming edges (root-type nodes) can be erased.

```text
public void Purge(
    ObjectIdGraph idGraph
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdGraph idGraph | Input graph of objects in the database. The graph will be returned containing only those objects that may safely be removed from the database. |

### ReadDwgFile(IntPtr, [MarshalAs(UnmanagedType.U1)] bool, string)

#### Description
Reads the drawing file specified by drawingFile into the database object executing this function. 
This function uses the "lazy-load" mechanism, which means that pieces of the drawing are read in only as needed. So, the drawing file is left open until the database object is deleted, at which point the database destructor closes the drawing file. It always tries to open files with read access. It fails if read access is not available. 
The allowCPConversion argument controls the behavior when the user tries to read a dwg file where the NLS files are not available to convert from the codepage of the drawing to the codepage of the system (for example, a Japanese drawing on an English OS). If allowCPConversion is false, AutoCAD will pop up a dialog explaining the situation and asking if the user wants to allow some kind of default conversion, which might cause a data loss. If allowCPConversion is true, the file will be opened and the conversion will happen silently. 
If password is NULL, the user is prompted for a password if one is required and if no applicable password exists in the password cache. 
Warning
This function should only be used on a newly created Database that was created with its constructor's buildDefaultDrawing argument set to false. If this method is used on an Database that was created with buildDefaultDrawing set to true, or an Database that already has information in it (for any reason including a previous call to this function), then memory leaks, or worse, will result.
```text
public void ReadDwgFile(
    IntPtr drawingFile, 
    [MarshalAs(UnmanagedType.U1)] bool allowCPConversion, 
    string password
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IntPtr drawingFile | Input pointer to DWG file to read |
| [MarshalAs(UnmanagedType.U1)] bool allowCPConversion | Input Boolean indicating whether to allow codepage conversion |
| string password | Input string containing a DWG password |

### ReadDwgFile(string, FileOpenMode, [MarshalAs(UnmanagedType.U1)] bool, string)

#### Description
Reads the drawing file specified by fileName into the database object executing this function. fileName must include the extension of the file (which does not have to be _.dwg_) if the file to open has one, even if the extension is _.dwg_. fileName may be a URL. 
This function uses the "lazy-load" mechanism, which means that pieces of the drawing are read in only as needed. So, the drawing file is left open until the database object is deleted, at which point the database destructor closes the drawing file. It always tries to open files with read access. It fails if read access is not available. 
The mode describes how other applications may access the file when the same file has already been opened. 
The allowCPConversion argument controls the behavior when the user tries to read a dwg file where the NLS files are not available to convert from the codepage of the drawing to the codepage of the system (for example, a Japanese drawing on an English OS). If allowCPConversion is false, AutoCAD will pop up a dialog explaining the situation and asking if the user wants to allow some kind of default conversion, which might cause a data loss. If allowCPConversion is true, the file will be opened and the conversion will happen silently. 
If password is NULL, the user is prompted for a password if one is required and if no applicable password exists in the password cache. 
**Warning**
This function should only be used on a newly created Database that was created with its constructor's buildDefaultDrawing argument set to false. If this method is used on an Database that was created with buildDefaultDrawing set to true, or an Database that already has information in it (for any reason including a previous call to this function), then memory leaks, or worse, will result.
```text
public void ReadDwgFile(
    string fileName, 
    FileOpenMode mode, 
    [MarshalAs(UnmanagedType.U1)] bool allowCPConversion, 
    string password
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input name or URL of file to read |
| FileOpenMode mode | Input open mode |
| [MarshalAs(UnmanagedType.U1)] bool allowCPConversion | Input Boolean indicating whether to allow codepage conversion |
| string password | Input string containing a DWG password |

### ReadDwgFile(string, FileShare, [MarshalAs(UnmanagedType.U1)] bool, string)

#### Description
**This function is obsolete and will be removed in a future release.**
Reads the drawing file specified by fileName into the database object executing this function. fileName must include the extension of the file (which does not have to be _.dwg_) if the file to open has one, even if the extension is _.dwg_. fileName may be a URL. 
This function uses the "lazy-load" mechanism, which means that pieces of the drawing are read in only as needed. So, the drawing file is left open until the database object is deleted, at which point the database destructor closes the drawing file. It always tries to open files with read access. It fails if read access is not available. 
The share mode describes how other applications may access the file when the same file has already been opened. The following are share modes supported by AutoCAD: 
| Mode | Function |
| --- | --- |
| _SH_DENYWR | Opens an existing file as read-onlyDenies write-access to the file by other sessions |
| _SH_DENYRW | Opens a file for reading and writingDenies read-write access to the file by other sessions |
| _SH_DENYNO | Opens an existing file as read-onlyPermits read-write access to the file by other sessions |

The fileSharing argument defaults to _SH_DENYWR. This default value gives the same behavior as in previous releases of ObjectARX, and prevents other applications from writing to the file. Also, if the file was already opened by another application for writing, this call will fail. 
Using _SH_DENYNO does not lock out other applications from writing to the file. It is not safe to do a lazy load in such circumstances. Performing a lazy load means that pieces of the drawing are read-in only as needed. This feature, combined with the possibility of other applications updating the drawing file under _SH_DENYNO, can cause inconsistent reads and other errors without the call to CloseInput(). CloseInput() also releases the file handle when it finishes reading from the file. 
The allowCPConversion argument controls the behavior when the user tries to read a dwg file where the NLS files are not available to convert from the codepage of the drawing to the codepage of the system (for example, a Japanese drawing on an English OS). 
For an ObjectARX application, if allowCPConversion is false, AutoCAD will pop up a dialog explaining the situation and asking if the user wants to allow some kind of default conversion, which might cause a data loss. 
However, when a non-AutoCAD host application encounters this situation with an ObjectDBX module, ReadDwgFile() will not work. At that point, the application can decide whether it wants to allow the default conversion by whatever means it chooses (including asking the user). If it chooses to allow the conversion, it can again call ReadDwgFile() and set allowCPConversion to true. 
In either ObjectARX or ObjectDBX, if allowCPConversion is true, the file will be opened and the conversion will happen silently. 
If password is NULL, the user is prompted for a password if one is required and if no applicable password exists in the password cache. 
Returns Acad::eOk if successful.
Warning
This function should only be used on a newly created Database that was created with its constructor's buildDefaultDrawing argument set to false. If this method is used on an Database that was created with buildDefaultDrawing set to true, or an Database that already has information in it (for any reason including a previous call to this function), then memory leaks, or worse, will result.
```text
public void ReadDwgFile(
    string fileName, 
    FileShare fileSharing, 
    [MarshalAs(UnmanagedType.U1)] bool allowCPConversion, 
    string password
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input name or URL of file to read |
| FileShare fileSharing | Input share mode |
| [MarshalAs(UnmanagedType.U1)] bool allowCPConversion | Input Boolean indicating whether to allow codepage conversion |
| string password | Input string containing a DWG password |

### ReclaimMemoryFromErasedObjects

#### Description
This member function deletes the objects underneath the input object ids and performs some related cleanup. 
The object ids in the input array must already be erased, and they should reside in the invoked database. Objects owned by the objects listed in the input array will be erased unless they already are, and their memory also reclaimed. 
All deleted objects and memory will be restored upon undo, and re-deleted upon redo, by use of their DWG filing members.
```text
public void ReclaimMemoryFromErasedObjects(
    ObjectIdCollection ids
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdCollection ids | A collection of object ids whose memory is to be reclaimed by deleting their objects. All object ids in the collection must correspond to erased objects, which must be entirely closed. |

### ReloadXrefs

#### Description
This function reloads the xrefs whose BlockTableRecord ObjectIds are in xrefIds. The ObjectIds in xrefIds must all be from the working database.
```text
public void ReloadXrefs(
    ObjectIdCollection xrefIds
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdCollection xrefIds | Input collection of ObjectIds for the xref BlockTableRecords to unload |

### ResetTimes

#### Description
This function resets the Database TDCREATE, TDUPDATE, TDINDWG, and TDUSRTIMER to the settings for a new drawing (TDCREATE and TDUPDATE to the current date/time, and TDINDWG and TDUSRTIMER to 0).
```text
public void ResetTimes();
```

### ResolveXrefs

#### Description
This function resolves existing xrefs in the working database. 
If useThreadEngine is true, and other factors haven't disabled it, then the multi-thread engine is used for resolving the xrefs. 
If doNewOnly is true, only unresolved xref records are processed. Existing resolved xref LayerTableRecords, LinetypeTableRecords, and BlockTableRecords are ignored. In this case, the useThreadEngine argument also is ignored, and the multi-thread engine is not used. 
**Warning**
No document locking is done by this function; the caller is responsible for locking the document. 
This function is available to non-AutoCAD-based host applications.
```text
public void ResolveXrefs(
    [MarshalAs(UnmanagedType.U1)] bool useThreadEngine, 
    [MarshalAs(UnmanagedType.U1)] bool doNewOnly
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool useThreadEngine | Input Boolean indicating whether to use the thread engine for xref resolution |
| [MarshalAs(UnmanagedType.U1)] bool doNewOnly | Input Boolean indicating whether to process only newly added xrefs |

### RestoreForwardingXrefSymbols

#### Description
This function must be used with RestoreOriginalXrefSymbols(), and should be wrapped around all code with plans to edit and/or save Xref databases. 
RestoreForwardingXrefSymbols() literally redoes all the changes back to a proper Xref resolve status. Thus, if the original symbols are restored, and then changes are made to the symbols before RestoreForwardingXrefSymbols(), those changes will be overwritten. However, newly added symbols will be properly resolved during RestoreForwardingXrefSymbols(), and then will be included in the undo/redo of future calls to these two methods. (The only work-around to wanting to change the symbols themselves is to go ahead and make the changes, save them to disk, and then let RestoreForwardingXrefSymbols() overwrite the changes. When all is done, reload the Xref from disk.) 
The symbols affected are the Table and Records for blocks, layers, linetypes, text styles, dimension styles, registered applications, and plot styles, as well as any custom object changes made during and between the XrefBeginAttached and XrefBeginOtherAttached events. 
In order to properly resolve the Xref, RestoreForwardingXrefSymbols() needs write access to the symbol tables and symbol table records in the host drawing. Therefore, applications should close any open symbol tables or symbol table records before calling RestoreForwardingXrefSymbols().
```text
public void RestoreForwardingXrefSymbols();
```

### RestoreOriginalXrefSymbols

#### Description
This function must be used with RestoreForwardingXrefSymbols(), and should be wrapped around all code with plans to edit and/or save Xref databases. 
The RestoreOriginalXrefSymbols() method undoes all the changes the database did during its resolve, so that the database is now in the same condition it was when it was first read in from its file. 
The symbols affected are the Table and Records for blocks, layers, linetypes, text styles, dimension styles, registered applications, and plot styles, as well as any custom object changes made during and between the XrefBeginAttached and XrefBeginOtherAttached events.
```text
public void RestoreOriginalXrefSymbols();
```

### RuntimeId

#### Description
Get this database instance's runtime ID.
```text
public long RuntimeId();
```

#### Returns
Long integer that contains the runtime ID.
### Save

#### Description
Currently not implemented.
```text
public void Save();
```

### SaveAs(string, [MarshalAs(UnmanagedType.U1)] bool, DwgVersion, Autodesk.AutoCAD.DatabaseServices.SecurityParameters)

#### Description
Runs the save process on the database and writes the drawing information out to fileName. The fileName argument is taken as is. If no file extension is present, _.dwg_ is not appended. 
If the database executing the SaveAs() function is not the current database in the AutoCAD editor, then the thumbnail preview image is not saved to fileName. 
To specify security parameters, set security that conveys your preferences.If the security is not properly initialized, the method fails. See SecurityParameters for more information on initializing this struct. 
If bBakAndRename is false, then no _.bak_ file is created, a full save is always done, and if the Database being saved is the main database for a document in AutoCAD, then the document's filename will NOT change to the saved name.
```text
public void SaveAs(
    string fileName, 
    [MarshalAs(UnmanagedType.U1)] bool bBakAndRename, 
    DwgVersion version, 
    Autodesk.AutoCAD.DatabaseServices.SecurityParameters security
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input file name or URL to write database out to |
| [MarshalAs(UnmanagedType.U1)] bool bBakAndRename | Input bool indicating whether or not to create a .bak file and change document name in AutoCAD |
| DwgVersion version | Input dwg version to which to save the file |
| Autodesk.AutoCAD.DatabaseServices.SecurityParameters security | Input a SecurityParameters structure |

#### Remarks
DWG files can no longer be saved with passwords. The password will be ignored and returns an error if password information is passed in the pSecParams parameter.
#### Notes
The allowed values for version are: 
DwgVersion.AC1014 // R14 
DwgVersion.AC1015 // 2000 
DwgVersion.AC1800 // 2004 
DwgVersion.AC1021 // 2007 
DwgVersion.AC1024 // 2010 
DwgVersion.AC1027 // 2013 
DwgVersion.AC1032 // 2018
### SaveAs(string, Autodesk.AutoCAD.DatabaseServices.SecurityParameters)

#### Description
Runs the save process on the database and writes the drawing information out to fileName. The fileName argument is taken as is. If no file extension is present, _.dwg_ is not appended. 
To specify security parameters, set security to point to a SecurityParameters object that conveys your preferences. If security is non-NULL, its settings override any previous database security settings. If security is NULL, any currently enforced security settings remain in effect. If no previous security-related settings were specified, and security is NULL, no security-related operation is attempted. If the SecurityParameters object passed as the SecurityParameters argument is not properly initialized, the method fails.
```text
public void SaveAs(
    string fileName, 
    Autodesk.AutoCAD.DatabaseServices.SecurityParameters security
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input file name or URL to write database out to |
| Autodesk.AutoCAD.DatabaseServices.SecurityParameters security | Input a SecurityParameters structure |

#### Remarks
DWG files can no longer be saved with passwords. The password will be ignored and returns an error if password information is passed in the pSecParams parameter.
### SaveAs(string, DwgVersion)

#### Description
Runs the save process on the database and writes the drawing information out to fileName. The fileName argument is taken as is. If no file extension is present, _.dwg_ is not appended.
```text
public void SaveAs(
    string fileName, 
    DwgVersion version
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string fileName | Input file name or URL to write database out to |
| DwgVersion version | Input dwg version to which to save the file |

#### Notes
The allowed values for version are: 
DwgVersion.AC1014 // R14 
DwgVersion.AC1015 // 2000 
DwgVersion.AC1800 // 2004 
DwgVersion.AC1021 // 2007 
DwgVersion.AC1024 // 2010 
DwgVersion.AC1027 // 2013 
DwgVersion.AC1032 // 2018
### SetDimstyleData

#### Description
This function copies the dimension variable information in style into the database on which this method is called, making those dimension variable values current for the database.
```text
public void SetDimstyleData(
    DimStyleTableRecord style
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DimStyleTableRecord style | Input pointer to DimStyleTableRecord from which to copy dimension variable information |

### SetTimeZoneAsUtcOffset

#### Description
This .NET function wraps the the AcDbDatabase::setTimeZoneAsUtcOffset() ObjectARX function. 
Sets the current time zone for this database using an offset from UTC (GMT). For example, the offset for the Pacific Time Zone is -8.0. 
Returns the time zone chosen and set through the offset. When there are multiple time zones with the same offset, the first time zone found is used.
```text
public Autodesk.AutoCAD.DatabaseServices.TimeZone SetTimeZoneAsUtcOffset(
    double offset
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double offset | Input the offset, in hours |

#### Exceptions

| Exceptions | Description |
| --- | --- |
| validInput | Thrown if a valid time zone is not found |

#### Notes
The valid range is -12.0 to 13.0, though the offset must match a known time zone (defined in the TimeZone enum).
### SetWorldPaperspaceUcsBaseOrigin

#### Description
This function sets origin to be the new paperspace "default" UCS origin point for the view specified by orthoView. orthoView may be any one of the OrthographicView enumerators.
```text
public void SetWorldPaperspaceUcsBaseOrigin(
    Point3d origin, 
    Autodesk.AutoCAD.DatabaseServices.OrthographicView orthoView
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d origin | Input new origin point in WCS coordinates |
| Autodesk.AutoCAD.DatabaseServices.OrthographicView orthoView | Input view for which base point is desired |

### SetWorldUcsBaseOrigin

#### Description
This function sets origin to be the new model space "default" UCS origin point for the view specified by orthoView. orthoView may be any one of the OrthographicView enumerators.
```text
public void SetWorldUcsBaseOrigin(
    Point3d origin, 
    Autodesk.AutoCAD.DatabaseServices.OrthographicView orthoView
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d origin | Input new origin point in WCS coordinates |
| Autodesk.AutoCAD.DatabaseServices.OrthographicView orthoView | Input view for which base point is desired |

### TimeZoneDescription

#### Description
This .NET function wraps the AcDbDatabase::getTimeZoneInfo() ObjectARX function. 
Returns a description of a time zone. This method does not affect the database's current time zone setting.
```text
public string TimeZoneDescription(
    Autodesk.AutoCAD.DatabaseServices.TimeZone tz
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.TimeZone tz | Input a value from the TimeZone enum |

### TimeZoneOffset

#### Description
This function converts the offset, in hours, of the time zone passed in, from UTC (GMT). For example, the offset for Pacific time is -8.0.
```text
public double TimeZoneOffset(
    Autodesk.AutoCAD.DatabaseServices.TimeZone tz
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.TimeZone tz | Input one of the time zones contained in the TimeZone enum |

#### Exceptions

| Exceptions | Description |
| --- | --- |
| validInput | Thrown if an invalid TimeZone is passed in |

#### Notes
This method does not affect the database's current time zone setting.
### UnloadXrefs

#### Description
Unloads the xrefs whose BlockTableRecord ObjectIds are in xrefIds.
```text
public void UnloadXrefs(
    ObjectIdCollection xrefIds
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdCollection xrefIds | Input collection of ObjectIds for the xref BlockTableRecords to unload |

### UpdateExt

#### Description
This function iterates through all the entities in the database's Model Space and updates the database's Model Space extents variables EXTMAX and EXTMIN to the values determined during the iteration. 
Setting the argument doBestFit to TRUE means that while traversing the database, any BlockReference entities found should have their geomExtentsBestFit() method called instead of geomExtents(). This will be slower but will generate a tighter bounding box (extents). Using the default argument of FALSE will be faster but may not produce the tightest bounding box.
```text
public void UpdateExt(
    [MarshalAs(UnmanagedType.U1)] bool doBestFit
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool doBestFit | Determines whether to generate the tightest bounding box |

### Wblock()

#### Description
Creates a new Database object, and then uses the wblockClone mechanism to write the entire contents of the database on which this function is being called out to the new database.
```text
public Database Wblock();
public Database Wblock(
    ObjectId blockId
);
public Database Wblock(
    ObjectIdCollection outObjIds, 
    Point3d basePoint
);
public void Wblock(
    Database outputDataBase, 
    ObjectIdCollection outObjIds, 
    Point3d basePoint, 
    Autodesk.AutoCAD.DatabaseServices.DuplicateRecordCloning cloning
);
```

### WblockCloneObjects

#### Description
Clones all objects in the identifiers collection and appends them to the container object specified by owner. The objects can be from multiple source databases, and must match the type of owner supplied, but must be from a different database than the owner object. 
id can only be an BlockTableRecord, Dictionary, or SymbolTable object. In multiple calls, the owners must be from the same destination database. If the owner is a dictionary, newly cloned entries are set as anonymous. 
mapping is filled with IdPair objects that contain the objectId entities of the original and cloned object pairs. This array can be used for post-processing the objects involved in the deepClone operation. 
The cloning value determines what happens if symbols or dictionary entries are cloned, and a duplicate is found to already exist in the destination database. cloning must keep the same setting in multiple calls, and can be only one of the following: 
  * Ignore -- If a duplicate is found, ignore the clone, and continue to use the existing record in the destination database. This is how the INSERT command and Database.insert() operate.
  * Replace -- If a duplicate is found, replace it with the cloned record.
  * MangleName -- Mangle all the incoming record names. The mangling will also ensure unique names. This is how the RefEdit command works.
  * UnmangleName -- Primarily used by RefEdit when it checks the records back into the origin database. Any mangling done by kDrcMangleName is undone, and then it defaults to Ignore. In other words, if a duplicate is found after removing the mangling, AutoCAD continues to use the existing record, and ignores the cloned one.

```text
public void WblockCloneObjects(
    ObjectIdCollection identifiers, 
    ObjectId id, 
    IdMapping mapping, 
    Autodesk.AutoCAD.DatabaseServices.DuplicateRecordCloning cloning, 
    [MarshalAs(UnmanagedType.U1)] bool deferTranslation
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdCollection identifiers | Input collection of objects to be deep cloned |
| ObjectId id | Input object ID of object to be the owner of the clones |
| IdMapping mapping | Collection of IdPair objects to be used for translating object ID relationships |
| Autodesk.AutoCAD.DatabaseServices.DuplicateRecordCloning cloning | Input action for duplicate records |
| [MarshalAs(UnmanagedType.U1)] bool deferTranslation | Input Boolean indicating whether or not ID translation should be done |

### WorldPaperspaceUcsBaseOrigin

#### Description
This function returns the database's model space "default" UCS origin point (in WCS coordinates) for the view specified by orthoView. orthoView may be any one of the OrthographicView enumerators.
```text
public Point3d WorldPaperspaceUcsBaseOrigin(
    Autodesk.AutoCAD.DatabaseServices.OrthographicView orthoView
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.OrthographicView orthoView | Input desired view |

### WorldUcsBaseOrigin

#### Description
This function returns the database's model space "default" UCS origin point (in WCS coordinates) for the view specified by orthoView. orthoView may be any one of the OrthographicView enumerators.
```text
public Point3d WorldUcsBaseOrigin(
    Autodesk.AutoCAD.DatabaseServices.OrthographicView orthoView
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.OrthographicView orthoView | Input view for which base point is desired |

### XBindXrefs

#### Description
This function binds the xref symbolTable records whose ObjectIds are in xrefSymbolIds. If insertBind is true, then the symbolTable record names will be changed from the xref naming convention to normal insert symbolTable record names. 
The ObjectIds in xrefSymbolIds must all be from the working database and they must all be from resolved xrefs. 
xrefSymbolIds may contain ObjectIds for the following symbol table record types: BlockTableRecord, LayerTableRecord, LinetypeTableRecord, TextStyleTableRecord (if it does not represent a shape file), RegAppTableRecord, and DimStyleTableRecord. 
```text
public void XBindXrefs(
    ObjectIdCollection xrefSymbolIds, 
    [MarshalAs(UnmanagedType.U1)] bool insertBind
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdCollection xrefSymbolIds | Input collection of ObjectIds of SymbolTableRecord objects to be bound. |
| [MarshalAs(UnmanagedType.U1)] bool insertBind | Input bool to indicate whether or not to convert xref symbols to insert-like bind names. |

### AutoCAD.DatabaseServices.Database.ApplyPartialOpenFilters@SpatialFilter@Autodesk.AutoCAD.DatabaseServices.Filters.LayerFilter

#### Parameters

| Parameters | Description |
| --- | --- |
| spatialFilter | Specifies the model space volume to be used for spatial filtering |
| layerFilter | Specifies the layers to be used for filtering |

#### Description
This function can be called on a database to filter its model space entities to only bring part of the drawing into memory. The filter applied is the intersection of entities in the view and entities on the specified layers. Thus, only entities both within the view and on the specified layers will be brought into memory. To be effective, this function must be called after an readDwgFile() call and before calling closeInput() on the database. The function can also be called on a partially opened database to read additional entities off the disk into the drawing. 
The coordinates for spatialFilter are in the WCS. A NULL pointer will result in no spatial filtering. In other words, objects at all locations in model space that pass the layer filtering will be brought in. 
A NULL layerFilter pointer will result in objects on all layers that pass spatial filtering being brought in. If the filter is empty, then no layers will be used for filtering and no entities in model space except those which have a hard pointer dependence for the rest of the drawing will be brought in.


## Properties Details

### AcadDatabase

#### Description
Returns the current database.
```text
public object AcadDatabase;
```

#### Conditions
Read-only
### AllowExtendedNames

#### Description
Set to true if extended names are permitted.
```text
public bool AllowExtendedNames;
```

#### Conditions
Read / Write
### Angbase

#### Description
Accesses the current ANGBASE value for the database.
```text
public double Angbase;
```

#### Conditions
Read / Write
### Angdir

#### Description
Accesses the current ANGDIR value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on ANGDIR.
```text
public bool Angdir;
```

#### Conditions
Read / Write
### AnnoAllVisible

#### Description
Accesses the current ANNOALLVISIBLE value for the database 
See the System Variables section of the _AutoCAD Command Reference_ for information on ANNOALLVISIBLE.
```text
public bool AnnoAllVisible;
```

#### Conditions
Read / Write
### AnnotativeDwg

#### Description
Controls whether the drawing is treated as an annotative block when it is inserted into other drawings. 
True to treat the drawing as an annotative block when it is inserted into other drawings, false otherwise. The default value for new databases is false.
```text
public bool AnnotativeDwg;
```

#### Conditions
Read / Write
### ApproxNumObjects

#### Description
Returns a value that is at least as large as the number of objects in the database. 
The purpose of this function is to provide a way to determine how large an ObjectIdCollection will be required in order to hold all the objects in the database. Thus the array can be created with the proper initial size instead of growing the array as the objects are appended. For large arrays, this can result in a very noticeable performance gain and greatly reduce memory fragmentation. 
```text
public int ApproxNumObjects;
```

#### Conditions
Read-only
### Attmode

#### Description
Accesses the current ATTMODE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on ATTMODE
```text
public int Attmode;
```

#### Conditions
Read / Write
### Aunits

#### Description
Accesses the current AUNITS value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on AUNITS.
```text
public int Aunits;
```

#### Conditions
Read / Write
### Auprec

#### Description
Accesses the current AUPREC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on AUPREC.
```text
public int Auprec;
```

#### Conditions
Read / Write
### BlockTableId

#### Description
Returns the object ID of the database's BlockTable.
```text
public ObjectId BlockTableId;
```

#### Conditions
Read-only
### ByBlockLinetype

#### Description
Returns the object ID of the BYBLOCK LinetypeTableRecord for the database.
```text
public ObjectId ByBlockLinetype;
```

#### Conditions
Read-only
### ByLayerLinetype

#### Description
Returns the object ID of the BYLAYER LinetypeTableRecord for the database.
```text
public ObjectId ByLayerLinetype;
```

#### Conditions
Read-only
### CameraDisplay

#### Description
Accesses the value of the CAMERADISPLAY sysvar to display or hide cameras.
```text
public bool CameraDisplay;
```

#### Conditions
Read / Write
### CameraHeight

#### Description
Accesses the value of CAMERAHEIGHT system variable.This value is used as the default when creating new cameras.
```text
public double CameraHeight;
```

#### Conditions
Read / Write
### Cannoscale

#### Description
Accesses a AnnotationScale object which will be the CANNOSCALE value for the database when model space is current. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CANNOSCALE.
```text
public AnnotationScale Cannoscale;
```

#### Conditions
Read / Write
### Cecolor

#### Description
Accesses the current CECOLOR value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CECOLOR.
```text
public Autodesk.AutoCAD.Colors.Color Cecolor;
```

#### Conditions
Read / Write
### Celtscale

#### Description
Accesses the current CELTSCALE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CELTSCALE.
```text
public double Celtscale;
```

#### Conditions
Read / Write
### Celtype

#### Description
Accesses the object ID of the linetype specified by the current CELTYPE value of the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CELTYPE.
```text
public ObjectId Celtype;
```

#### Conditions
Read / Write
### Celweight

#### Description
Accesses the LineWeight value indicating what the current line weight is for the database. See the System Variables section of the _AutoCAD Command Reference_ for information on CELWEIGHT.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight Celweight;
```

#### Conditions
Read / Write
### Cetransparency

#### Description
Gets and sets the current CETRANSPARENCY value for the database.
```text
public Transparency Cetransparency;
```

#### Conditions
Read / Write
### Chamfera

#### Description
Accesses the current CHAMFERA value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CHAMFERA.
```text
public double Chamfera;
```

#### Conditions
Read / Write
### Chamferb

#### Description
Accesses the current CHAMFERB value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CHAMFERB.
```text
public double Chamferb;
```

#### Conditions
Read / Write
### Chamferc

#### Description
Accesses the current CHAMFERC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CHAMFERC.
```text
public double Chamferc;
```

#### Conditions
Read / Write
### Chamferd

#### Description
Accesses the current CHAMFERD value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CHAMFERD.
```text
public double Chamferd;
```

#### Conditions
Read / Write
### Clayer

#### Description
Accesses the object ID of the LAYER specified by the current CLAYER value of the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CLAYER.
```text
public ObjectId Clayer;
```

#### Conditions
Read / Write
### Cmaterial

#### Description
Accesses the object ID of the layer material.
```text
public ObjectId Cmaterial;
```

#### Conditions
Read / Write
### Cmljust

#### Description
Accesses the current CMLJUST value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CMLJUST.
```text
public int Cmljust;
```

#### Conditions
Read / Write
### Cmlscale

#### Description
Accesses the current CMLSCALE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CMLSCALE.
```text
public double Cmlscale;
```

#### Conditions
Read / Write
### CmlstyleID

#### Description
Accesses the object ID of the MlineStyle specified by the current CMLSTYLEID value of the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CMLSTYLEID.
```text
public ObjectId CmlstyleID;
```

#### Conditions
Read / Write
### ColorDictionaryId

#### Description
Accesses the object ID of the database's color dictionary.
```text
public ObjectId ColorDictionaryId;
```

#### Conditions
Read-only
### ContinuousLinetype

#### Description
Accesses the object ID of the continuous linetype LinetypeTableRecord for the database.
```text
public ObjectId ContinuousLinetype;
```

#### Conditions
Read-only
### Cshadow

#### Description
Accesses the value of the CSHADOW system variable.
```text
public int Cshadow;
```

#### Conditions
Read / Write
### CurrentSpaceId

#### Description
Accesses the object ID of the BlockTableRecord of the current space (e.g., model space or paper space.)
```text
public ObjectId CurrentSpaceId;
```

#### Conditions
Read-only
### CurrentViewportTableRecordId

#### Description
This .NET property wraps the acdbGetCurVportTableRecordId() ObjectARX function. 
Accesses the current ViewportTableRecord ID for this Database.
```text
public ObjectId CurrentViewportTableRecordId;
```

#### Conditions
Read-only
### DataLinkDictionaryId

#### Description
Accesses the data link's dictionary ID.
```text
public ObjectId DataLinkDictionaryId;
```

#### Conditions
Read-only
### DataLinkManager

#### Description
Returns the ID of the data link manager.
```text
public Autodesk.AutoCAD.DatabaseServices.DataLinkManager DataLinkManager;
```

#### Conditions
Read-only
### DetailViewStyle

#### Description
The Object ID of the current detail view style.
```text
public ObjectId DetailViewStyle;
```

#### Conditions
Read / Write
### DetailViewStyleDictionaryId

#### Description
The Object ID of the detail view style dictionary.
```text
public ObjectId DetailViewStyleDictionaryId;
```

#### Conditions
Read only property.
### DgnFrame

#### Description
Reserved for future use.
```text
public int DgnFrame;
```

#### Conditions
Read / Write
### Dimadec

#### Description
Accesses the current DIMADEC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMADEC.
```text
public int Dimadec;
```

#### Conditions
Read / Write
### Dimalt

#### Description
Accesses the current DIMALT value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALT.
```text
public bool Dimalt;
```

#### Conditions
Read / Write
### Dimaltd

#### Description
Accesses the current DIMALTD value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTD
```text
public int Dimaltd;
```

#### Conditions
Read / Write
### Dimaltf

#### Description
Accesses the current DIMALTF value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTF.
```text
public double Dimaltf;
```

#### Conditions
Read / Write
### Dimaltrnd

#### Description
Accesses the current DIMALTRND value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTRND.
```text
public double Dimaltrnd;
```

#### Conditions
Read / Write
### Dimalttd

#### Description
Accesses the current DIMALTTD value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTTD
```text
public int Dimalttd;
```

#### Conditions
Read / Write
### Dimalttz

#### Description
Accesses the current DIMALTTZ value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTTZ
```text
public int Dimalttz;
```

#### Conditions
Read / Write
### Dimaltu

#### Description
Accesses the current DIMALTU value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTU
```text
public int Dimaltu;
```

#### Conditions
Read / Write
### Dimaltz

#### Description
Accesses the current DIMALTZ value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALTZ
```text
public int Dimaltz;
```

#### Conditions
Read / Write
### Dimapost

#### Description
Accesses the current DIMAPOST value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMAPOST
```text
public string Dimapost;
```

#### Conditions
Read / Write
### Dimarcsym

#### Description
Accesses the arc length placement value.
```text
public int Dimarcsym;
```

#### Conditions
Read / Write
### Dimaso

#### Description
Accesses the current DIMASO value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMASO.
```text
public bool Dimaso;
```

#### Conditions
Read / Write
### DimAssoc

#### Description
Accesses the current DIMASSOC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMASSOC.
```text
public int DimAssoc;
```

#### Conditions
Read / Write
### Dimasz

#### Description
Accesses the current DIMASZ value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMASZ.
```text
public double Dimasz;
```

#### Conditions
Read / Write
### Dimatfit

#### Description
Accesses the current DIMATFIT value for the database.
```text
public int Dimatfit;
```

#### Conditions
Read / Write
### Dimaunit

#### Description
Accesses the current DIMAUNIT value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMAUNIT.
```text
public int Dimaunit;
```

#### Conditions
Read / Write
### Dimazin

#### Description
Accesses the current DIMAZIN value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMAZIN.
```text
public int Dimazin;
```

#### Conditions
Read / Write
### Dimblk

#### Description
Accesses the current DIMBLK value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMBLK.
```text
public ObjectId Dimblk;
```

#### Conditions
Read / Write
### Dimblk1

#### Description
Accesses the current DIMBLK1 value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMBLK1.
```text
public ObjectId Dimblk1;
```

#### Conditions
Read / Write
### Dimblk2

#### Description
Accesses the current DIMBLK2 value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMBLK2.
```text
public ObjectId Dimblk2;
```

#### Conditions
Read / Write
### Dimcen

#### Description
Accesses the current DIMCEN value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMCEN.
```text
public double Dimcen;
```

#### Conditions
Read / Write
### Dimclrd

#### Description
Accesses the current DIMCLRD value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMCLRD.
```text
public Autodesk.AutoCAD.Colors.Color Dimclrd;
```

#### Conditions
Read / Write
### Dimclre

#### Description
Accesses the current DIMCLRE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMCLRE.
```text
public Autodesk.AutoCAD.Colors.Color Dimclre;
```

#### Conditions
Read / Write
### Dimclrt

#### Description
Accesses the current DIMCLRT value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMCLRT.
```text
public Autodesk.AutoCAD.Colors.Color Dimclrt;
```

#### Conditions
Read / Write
### Dimdec

#### Description
Accesses the current DIMDEC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMDEC.
```text
public int Dimdec;
```

#### Conditions
Read / Write
### Dimdle

#### Description
Accesses the current DIMDLE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMDLE.
```text
public double Dimdle;
```

#### Conditions
Read / Write
### Dimdli

#### Description
Accesses the current DIMDLI value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMDLI.
```text
public double Dimdli;
```

#### Conditions
Read / Write
### Dimdsep

#### Description
Accesses the current DIMDSEP value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMDSEP.
```text
public char Dimdsep;
```

#### Conditions
Read / Write
### Dimexe

#### Description
Accesses the current DIMEXE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMEXE.
```text
public double Dimexe;
```

#### Conditions
Read / Write
### Dimexo

#### Description
Accesses the current DIMEXO value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMEXO.
```text
public double Dimexo;
```

#### Conditions
Read / Write
### Dimfrac

#### Description
Accesses the current DIMFRAC value for the database.
```text
public int Dimfrac;
```

#### Conditions
Read / Write
### Dimfxlen

#### Description
Accesses the fixed extension lines value.
```text
public double Dimfxlen;
```

#### Conditions
Read / Write
### DimfxlenOn

#### Description
Accesses a value that indicates whether the fixed extension lines are on.
```text
public bool DimfxlenOn;
```

#### Conditions
Read / Write
### Dimgap

#### Description
Accesses the current DIMGAP value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMGAP
```text
public double Dimgap;
```

#### Conditions
Read / Write
### Dimjogang

#### Description
Accesses the current large radial angle.
```text
public double Dimjogang;
```

#### Conditions
Read / Write
### Dimjust

#### Description
Accesses the current DIMJUST value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMJUST.
```text
public int Dimjust;
```

#### Conditions
Read / Write
### Dimldrblk

#### Description
Accesses the object ID of the block reference specified by the current DIMLDRBLK value of the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMLDRBLK.
```text
public ObjectId Dimldrblk;
```

#### Conditions
Read / Write
### Dimlfac

#### Description
Accesses the current DIMLFAC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMLFAC.
```text
public double Dimlfac;
```

#### Conditions
Read / Write
### Dimlim

#### Description
Accesses the current DIMLIM value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMLIM.
```text
public bool Dimlim;
```

#### Conditions
Read / Write
### Dimltex1

#### Description
Accesses the object ID of the linetype of extension line 1.
```text
public ObjectId Dimltex1;
```

#### Conditions
Read / Write
### Dimltex2

#### Description
Accesses the object ID of the linetype of extension line 2.
```text
public ObjectId Dimltex2;
```

#### Conditions
Read / Write
### Dimltype

#### Description
Accesses the dimension linetype.
```text
public ObjectId Dimltype;
```

#### Conditions
Read / Write
### Dimlunit

#### Description
Accesses the current DIMLUNIT value for the dimension.
```text
public int Dimlunit;
```

#### Conditions
Read / Write
### Dimlwd

#### Description
Accesses the current DIMLWD value for the dimension. 
See the System Variables section of the AutoCAD Command Reference manual for information on DIMLWD.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight Dimlwd;
```

#### Conditions
Read / Write
### Dimlwe

#### Description
Accesses the current DIMLWE value for the dimension. 
See the System Variables section of the AutoCAD Command Reference manual for information on DIMLWE.
```text
public Autodesk.AutoCAD.DatabaseServices.LineWeight Dimlwe;
```

#### Conditions
Read / Write
### Dimpost

#### Description
Accesses the character string that is the current DIMPOST value for the datatbase. 
See the System Variables section of the _AutoCAD Command Reference manual_ for information on DIMPOST.
```text
public string Dimpost;
```

#### Conditions
Read / Write
### Dimrnd

#### Description
Accesses the current DIMRND value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMRND. 
```text
public double Dimrnd;
```

#### Conditions
Read / Write
### Dimsah

#### Description
Accesses current DIMSAH value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMSAH 
```text
public bool Dimsah;
```

#### Conditions
Read / Write
### Dimscale

#### Description
Accesses the current DIMSCALE value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMSCALE.
```text
public double Dimscale;
```

#### Conditions
Read / Write
### Dimsd1

#### Description
Accesses the current DIMSD1 value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMSD1.
```text
public bool Dimsd1;
```

#### Conditions
Read / Write
### Dimsd2

#### Description
Accesses the current DIMSD2 value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMSD2.
```text
public bool Dimsd2;
```

#### Conditions
Read / Write
### Dimse1

#### Description
Accesses the current DIMSD1 value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMSD1.
```text
public bool Dimse1;
```

#### Conditions
Read / Write
### Dimse2

#### Description
Accesses the current DIMSD2 value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD _Command Reference_ for information on DIMSD2.
```text
public bool Dimse2;
```

#### Conditions
Read / Write
### Dimsho

#### Description
Accesses the current DIMSHO value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMSHO.
```text
public bool Dimsho;
```

#### Conditions
Read / Write
### Dimsoxd

#### Description
Accesses the current DIMSOXD value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMSOXD.
```text
public bool Dimsoxd;
```

#### Conditions
Read / Write
### Dimstyle

#### Description
Accesses the object ID of the dimstyle specified by the current DIMSTYLE value of the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMSTYLE.
```text
public ObjectId Dimstyle;
```

#### Conditions
Read / Write
### DimStyleTableId

#### Description
Accesses the object ID of the database's DimStyleTable.
```text
public ObjectId DimStyleTableId;
```

#### Conditions
Read-only
### Dimtad

#### Description
Accesses the current DIMTAD value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTAD.
```text
public int Dimtad;
```

#### Conditions
Read / Write
### Dimtdec

#### Description
Accesses the current DIMTDEC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTDEC.
```text
public int Dimtdec;
```

#### Conditions
Read / Write
### Dimtfac

#### Description
Accesses the current DIMTFAC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTFAC.
```text
public double Dimtfac;
```

#### Conditions
Read / Write
### Dimtfill

#### Description
Accesses the dimension background color state, which can be one of the following values: 
0 means the background color is disabled 
1 means the use background color from dimtfillclr
2 means the use drawing's background color
```text
public int Dimtfill;
```

#### Conditions
Read / Write
### Dimtfillclr

#### Description
Accesses the current dimension background color (if dimtfill is set to 1).
```text
public Autodesk.AutoCAD.Colors.Color Dimtfillclr;
```

#### Conditions
Read / Write
### Dimtih

#### Description
Accesses the current DIMTIH value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTIH.
```text
public bool Dimtih;
```

#### Conditions
Read / Write
### Dimtix

#### Description
Accesses the current DIMTIX value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTIX.
```text
public bool Dimtix;
```

#### Conditions
Read / Write
### Dimtm

#### Description
Accesses the current DIMTM value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTM.
```text
public double Dimtm;
```

#### Conditions
Read / Write
### Dimtmove

#### Description
Accesses the current DIMTMOVE value for the database.
```text
public int Dimtmove;
```

#### Conditions
Read / Write
### Dimtofl

#### Description
Accesses the current DIMTOFL value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTOFL
```text
public bool Dimtofl;
```

#### Conditions
Read / Write
### Dimtoh

#### Description
Accesses the current DIMTOH value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTOH
```text
public bool Dimtoh;
```

#### Conditions
Read / Write
### Dimtol

#### Description
Accesses the current DIMTOL value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTOL
```text
public bool Dimtol;
```

#### Conditions
Read / Write
### Dimtolj

#### Description
Accesses the current DIMTOLJ value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTOLJ
```text
public int Dimtolj;
```

#### Conditions
Read / Write
### Dimtp

#### Description
Accesses the current DIMTP value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTP
```text
public double Dimtp;
```

#### Conditions
Read / Write
### Dimtsz

#### Description
Accesses the current DIMTSZ value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTSZ
```text
public double Dimtsz;
```

#### Conditions
Read / Write
### Dimtvp

#### Description
Accesses the current DIMTVP value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTVP
```text
public double Dimtvp;
```

#### Conditions
Read / Write
### Dimtxsty

#### Description
Accesses the object ID of the TextStyle specified by the current DIMTXSTY value of the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTXSTY.
```text
public ObjectId Dimtxsty;
```

#### Conditions
Read / Write
### Dimtxt

#### Description
Accesses the current DIMTXT value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTXT
```text
public double Dimtxt;
```

#### Conditions
Read / Write
### Dimtzin

#### Description
Accesses the current DIMTZIN value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMTZIN
```text
public int Dimtzin;
```

#### Conditions
Read / Write
### Dimupt

#### Description
Accesses the current DIMUPT value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMALT.
```text
public bool Dimupt;
```

#### Conditions
Read / Write
### Dimzin

#### Description
Accesses the current DIMZIN value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DIMZIN.
```text
public int Dimzin;
```

#### Conditions
Read / Write
### DispSilh

#### Description
Accesses the current DISPSILH value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DISPSILH.
```text
public bool DispSilh;
```

#### Conditions
Read / Write
### dragvs

#### Description
Accesses the visual style set in the DRAGVS system variable. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DRAGVS
```text
public ObjectId dragvs;
```

#### Conditions
Read / Write
### DrawOrderCtl

#### Description
Returns the value of the DRAWORDERCTL system variable, which enables users to revert to legacy draw order mode if required. This system variable is per drawing in order to be consistent with SORTENTS. 
The values are defined as follows: 
| 0 | Full draw order functionality. |
| --- | --- |
| 1 | In-place graphic updates are disabled. When this bit is set, objects that are edited appear in front of other objects. It is important to note that this is actually not guaranteed to be their location after doing a manual REGEN, saving the file, closing it and reopening it, or when plotting. |
| 2 | Setting this bit disables inheritance of objects derived from other objects, such as split objects. When off, the new line created from a split line will be in front of all objects, and the old line will keep its existing draw order. |
| 3 | Both in-place editing and inheritance of objects derived from other objects are disabled. |

```text
public byte DrawOrderCtl;
```

#### Conditions
Read / Write
### DwfFrame

#### Description
Accesses the current DWFFRAME value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on DWFFRAME.
```text
public int DwfFrame;
```

#### Conditions
Read / Write
### DwgFileWasSavedByAutodeskSoftware

#### Description
Returns true if it determines that the database was last saved by Autodesk software (such as AutoCAD or AutoCAD LT).
```text
public bool DwgFileWasSavedByAutodeskSoftware;
```

#### Conditions
Read-only
### DxEval

#### Description
Accesses the DX Eval value.
```text
public int DxEval;
```

#### Conditions
Read-only
### Elevation

#### Description
Accesses the Model Space ELEVATION value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on ELEVATION.
```text
public double Elevation;
```

#### Conditions
Read / Write
### EndCaps

#### Description
Accesses the database's endCaps header variable value.
```text
public EndCap EndCaps;
```

#### Conditions
Read / Write
### Extmax

#### Description
Accesses the current Model Space EXTMAX value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on EXTMAX.
```text
public Point3d Extmax;
```

#### Conditions
Read / Write
### Extmin

#### Description
Accesses the current Model Space EXTMIN value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on EXTMIN.
```text
public Point3d Extmin;
```

#### Conditions
Read / Write
### Facetres

#### Description
Accesses the current Model Space FACETRES value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on FACETRES.
```text
public double Facetres;
```

#### Conditions
Read / Write
### Filename

#### Description
Accesses the filename associated with the database.
```text
public string Filename;
```

#### Conditions
Read-only
### Filletrad

#### Description
Accesses the current FILLETRAD value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on FILLETRAD.
```text
public double Filletrad;
```

#### Conditions
Read / Write
### Fillmode

#### Description
Accesses the current FILLMODE value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on FILLMODE.
```text
public bool Fillmode;
```

#### Conditions
Read / Write
### FingerprintGuid

#### Description
Accesses the database's fingerprintguid header variable.
```text
public string FingerprintGuid;
```

#### Conditions
Read / Write
### GeoDataObject

#### Description
Accesses the Geo data object ID for this database.
```text
public ObjectId GeoDataObject;
```

#### Conditions
Read-only
### GroupDictionaryId

#### Description
Accesses the object ID of the database's Group dictionary.
```text
public ObjectId GroupDictionaryId;
```

#### Conditions
Read-only
### HaloGap

#### Description
Accesses the current HALOGAP value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on HALOGAP.
```text
public int HaloGap;
```

#### Conditions
Read / Write
### Handseed

#### Description
Accesses the current HANDSEED value for the database. The HANDSEED is a counter which maintains the next available handle number. Handles are 64-bit integers represented in DXF and LISP/ADS in hexadecimal form as a string. In hexadecimal, a 64-bit integer can be up to 16 digits.
```text
public Handle Handseed;
```

#### Conditions
Read / Write
### HideText

#### Description
Accesses the current HIDETEXT value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on HIDETEXT.
```text
public int HideText;
```

#### Conditions
Read / Write
### HomeView

#### Description
Accesses the navigation home view associated with the database.
```text
public DbHomeView HomeView;
```

#### Conditions
Read / Write
### HpInherit

#### Description
Accesses a bool indicating the current HPINHERIT value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on HPINHERIT.
```text
public bool HpInherit;
```

#### Conditions
Read / Write
### HpOrigin

#### Description
Accesses a 2D point that is the current HPORIGIN value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on HPORIGIN.
```text
public Point2d HpOrigin;
```

#### Conditions
Read / Write
### HyperlinkBase

#### Description
Accesses the database to use a copy of path as the new value for the HYPERLINKBASE header variable. 
See the system variables documentation in the _AutoCAD Command Reference_ for information on HYPERLINKBASE.
```text
public string HyperlinkBase;
```

#### Conditions
Read / Write
### Indexctl

#### Description
Accesses the INDEXCTL header variable value.
```text
public int Indexctl;
```

#### Conditions
Read / Write
### Insbase

#### Description
Accesses the current Model Space INSBASE value for the database. The point is in WCS coordinates. 
See the System Variables section of the _AutoCAD Command Reference_ for information on INSBASE.
```text
public Point3d Insbase;
```

#### Conditions
Read / Write
### Insunits

#### Description
Accesses the current INSUNITS value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on INSUNITS.
```text
public Autodesk.AutoCAD.DatabaseServices.UnitsValue Insunits;
```

#### Conditions
Read / Write
### Interferecolor

#### Description
Accesses the color for interference objects as defined by the INTERFERECOLOR system variable. 
See the System Variables section of the _AutoCAD Command Reference_ for information on INTERFERECOLOR.
```text
public Autodesk.AutoCAD.Colors.Color Interferecolor;
```

#### Conditions
Read / Write
### Interfereobjvs

#### Description
Accesses the visual style for interference objects as defined by the INTERFEREOBJVS system variable. 
See the System Variables section of the _AutoCAD Command Reference_ for information on INTERFEREOBJVS.
```text
public ObjectId Interfereobjvs;
```

#### Conditions
Read / Write
### Interferevpvs

#### Description
Accesses the visual style for interference objects as defined by the INTERFEREVPVS system variable. 
See the System Variables section of the _AutoCAD Command Reference_ for information on INTERFEREVPVS .
```text
public ObjectId Interferevpvs;
```

#### Conditions
Read / Write
### IntersectColor

#### Description
Accesses the INTERSECTIONCOLOR header variable value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on INTERSECTIONCOLOR.
```text
public int IntersectColor;
```

#### Conditions
Read / Write
### IntersectDisplay

#### Description
Accesses the INTERSECTIONDISPLAY header variable value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on INTERSECTIONDISPLAY.
```text
public int IntersectDisplay;
```

#### Conditions
Read / Write
### IsBeingDestroyed

#### Description
This is IsBeingDestroyed, a member of class Database.
```text
public bool IsBeingDestroyed;
```

### IsEmr

#### Description
Returns the EMR flag for the database. The EMR flag gets set when a drawing is saved by an EMR (Student Version) product. 
  * False is returned if the drawing was never saved by an EMR product
  * True is returned if the drawing was saved by an EMR product at least once

```text
public bool IsEmr;
```

#### Conditions
Read-only
### Isolines

#### Description
Accesses the current ISOLINES value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on ISOLINES.
```text
public int Isolines;
```

#### Conditions
Read / Write
### IsPartiallyOpened

#### Description
Returns true if the database is in a partially opened state; false otherwise.
```text
public bool IsPartiallyOpened;
```

#### Conditions
Read-only
### JoinStyle

#### Description
Accesses the database's joinstyle header variable value
```text
public Autodesk.AutoCAD.DatabaseServices.JoinStyle JoinStyle;
```

#### Conditions
Read / Write
### LastSavedAsMaintenanceVersion

#### Description
Accesses the maintenance version that the current drawing was last saved as in the current session. If the current session has not yet done a save on this drawing, then it returns zero.
```text
public Autodesk.AutoCAD.DatabaseServices.MaintenanceReleaseVersion LastSavedAsMaintenanceVersion;
```

#### Conditions
Read-only
### LastSavedAsVersion

#### Description
Accesses the version that the current drawing was last saved as in the current session. If the current session has not yet done a save on this drawing, then it returns zero.
```text
public DwgVersion LastSavedAsVersion;
```

#### Conditions
Read-only
### Latitude

#### Description
Accesses the latitude for the location of the model, in decimal degrees. Allowable values are -90 to +90 degrees, where positive numbers represent North latitudes.
```text
public double Latitude;
```

#### Conditions
Read / Write
### LayerEval

#### Description
Accesses the LAYEREVAL header variable value.
```text
public int LayerEval;
```

#### Conditions
Read / Write
### LayerFilters

#### Description
Accesses the layer filters.
```text
public LayerFilterTree LayerFilters;
```

#### Conditions
Read / Write
### LayerNotify

#### Description
Accesses the value of the LAYEREVAL header variable.
```text
public int LayerNotify;
```

#### Conditions
Read / Write
### LayerStateManager

#### Description
Accesses Class the layer state manager
```text
public Autodesk.AutoCAD.DatabaseServices.LayerStateManager LayerStateManager;
```

#### Conditions
Read-only
### LayerTableId

#### Description
Accesses the object ID of the database's LayerTable.
```text
public ObjectId LayerTableId;
```

#### Conditions
Read-only
### LayerZero

#### Description
Accesses the object ID of the layer 0 LayerTableRecord for the database.
```text
public ObjectId LayerZero;
```

#### Conditions
Read-only
### LayoutDictionaryId

#### Description
Accesses the object ID of the ACAD_LAYOUT dictionary, which contains objects of type Layout. The Layout dictionary stores characteristics of each Paper Space layout.
```text
public ObjectId LayoutDictionaryId;
```

#### Conditions
Read-only
### LensLength

#### Description
Accesses the value of LENSLENGTH system variable.
```text
public double LensLength;
```

#### Conditions
Read / Write
### LightGlyphDisplay

#### Description
Accesses whether light objects are displayed in the viewport. 
Returns 1 if light objects are displayed, 0 if not.
```text
public int LightGlyphDisplay;
```

#### Conditions
Read / Write
### LightingUnits

#### Description
Accesses the lighting units for the drawing, where 0 = Generic, 1 = International, and 2 = American.
```text
public byte LightingUnits;
```

#### Conditions
Read / Write
### LightsInBlocks

#### Description
Accesses if blocks are ignored and do not contribute lighting to the scene.
```text
public bool LightsInBlocks;
```

#### Conditions
Read / Write
### Limcheck

#### Description
Accesses the current Model Space LIMCHECK value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LIMCHECK.
```text
public bool Limcheck;
```

#### Conditions
Read / Write
### Limmax

#### Description
Accesses the current Model Space LIMMAX value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LIMMAX.
```text
public Point2d Limmax;
```

#### Conditions
Read / Write
### Limmin

#### Description
Accesses the current Model Space LIMMIN value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LIMMIN.
```text
public Point2d Limmin;
```

#### Conditions
Read / Write
### LinetypeTableId

#### Description
Accesses the object ID of the database's LinetypeTable.
```text
public ObjectId LinetypeTableId;
```

#### Conditions
Read-only
### LineWeightDisplay

#### Description
Accesses the line weight display status. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LWDISPLAY
```text
public bool LineWeightDisplay;
```

#### Conditions
Read / Write
### LoftAng1

#### Description
Accesses the current LOFTANG1 value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LOFTANG1.
```text
public double LoftAng1;
```

#### Conditions
Read / Write
### LoftAng2

#### Description
Accesses the current LOFTANG2 value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LOFTANG2.
```text
public double LoftAng2;
```

#### Conditions
Read / Write
### LoftMag1

#### Description
Accesses the current LOFTMAG1 value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LOFTMAG1.
```text
public double LoftMag1;
```

#### Conditions
Read / Write
### LoftMag2

#### Description
Accesses the current LOFTMAG2 value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LOFTMAG2.
```text
public double LoftMag2;
```

#### Conditions
Read / Write
### LoftNormals

#### Description
Accesses the current LOFTNORMALS value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LOFTNORMALS.
```text
public int LoftNormals;
```

#### Conditions
Read / Write
### LoftParam

#### Description
Accesses the current LOFTPARAM value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LOFTPARAM.
```text
public int LoftParam;
```

#### Conditions
Read / Write
### Longitude

#### Description
Accesses the longitude for the location of the model, in decimal degrees. Allowable values are -180 to +180 degrees, where positive numbers represent East longitudes.
```text
public double Longitude;
```

#### Conditions
Read / Write
### Ltscale

#### Description
Accesses the current LTSCALE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LTSCALE.
```text
public double Ltscale;
```

#### Conditions
Read / Write
### Lunits

#### Description
Accesses the current LUNITS value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LUNITS.
```text
public int Lunits;
```

#### Conditions
Read / Write
### Luprec

#### Description
Accesses the current LUPREC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on LUPREC.
```text
public int Luprec;
```

#### Conditions
Read / Write
### MaintenanceReleaseVersion

#### Description
Determines which point release of AutoCAD created this database.
```text
public int MaintenanceReleaseVersion;
```

#### Conditions
Read-only
### MaterialDictionaryId

#### Description
Accesses the object ID of the ACAD_MATERIAL dictionary, which contains objects of type Material.
```text
public ObjectId MaterialDictionaryId;
```

#### Conditions
Read-only
### Maxactvp

#### Description
Accesses the current MAXACTVP value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on MAXACTVP.
```text
public int Maxactvp;
```

#### Conditions
Read / Write
### Measurement

#### Description
Accesses the current MEASUREMENT value for the database.
```text
public Autodesk.AutoCAD.DatabaseServices.MeasurementValue Measurement;
```

#### Conditions
Read / Write
### Menu

#### Description
Accesses the menu display text
```text
public string Menu;
```

#### Conditions
Read-only
### Mirrtext

#### Description
Accesses the current MIRRTEXT value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on MIRRTEXT.
```text
public bool Mirrtext;
```

#### Conditions
Read / Write
### MLeaderscale

#### Description
Accesses the current value of the MLEADERSCALE system variable for the database.
```text
public double MLeaderscale;
```

#### Conditions
Read / Write
### MLeaderstyle

#### Description
Accesses the object ID of the MLeader style specified by the current CMLEADERSTYLE value of the database.
```text
public ObjectId MLeaderstyle;
```

#### Conditions
Read / Write
### MLeaderStyleDictionaryId

#### Description
For the ACAD_MLEADERSTYLE dictionary
```text
public ObjectId MLeaderStyleDictionaryId;
```

#### Conditions
Read-only
### MLStyleDictionaryId

#### Description
Accesses the object ID of the database's MLStyle dictionary.
```text
public ObjectId MLStyleDictionaryId;
```

#### Conditions
Read-only
### MsLtScale

#### Description
Accesses the current MSLTSCALE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on MSLTSCALE.
```text
public bool MsLtScale;
```

#### Conditions
Read / Write
### MsOleScale

#### Description
Accesses the value of the LAYERNOTIFY header variable.
```text
public double MsOleScale;
```

#### Conditions
Read / Write
### NamedObjectsDictionaryId

#### Description
Accesses the object ID of the database's NamedObjects dictionary.
```text
public ObjectId NamedObjectsDictionaryId;
```

#### Conditions
Read-only
### NeedsRecovery

#### Description
Returns true if the database was read from a drawing file and there were read errors, but the errors were not significant enough to cause the ReadDwgFile() method to throw an error exception.
```text
public bool NeedsRecovery;
```

#### Conditions
Read-only
#### Notes
The CloseInput() method should be called before using this property to be sure that all objects in the drawing have been read in.
### NorthDirection

#### Description
Accesses an angle representing a direction towards North, based on the orientation of the drawing model in the WCS.
```text
public double NorthDirection;
```

#### Conditions
Read / Write
### NumberOfSaves

#### Description
Accesses the number of times the database has been saved in the current session, or zero if it has not been saved in the current session.
```text
public int NumberOfSaves;
```

#### Conditions
Read / Write
### ObjectContextManager

#### Description
Accesses the object context manager.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectContextManager ObjectContextManager;
```

#### Conditions
Read-only
### ObscuredColor

#### Description
Accesses the current OBSCUREDCOLOR value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on OBSCUREDCOLOR.
```text
public int ObscuredColor;
```

#### Conditions
Read / Write
### ObscuredLineType

#### Description
Accesses the current OBSCUREDLINETYPE value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on OBSCUREDLINETYPE.
```text
public int ObscuredLineType;
```

#### Conditions
Read / Write
### OleStartUp

#### Description
Accesses the database's OLESTARTUP header variable value. 
See the system variables documentation in the _AutoCAD Command Reference_ for information on OLESTARTUP.
```text
public bool OleStartUp;
```

#### Conditions
Read / Write
### OriginalFileMaintenanceVersion

#### Description
Accesses the maintenance version value that the database file had when it was first opened.
```text
public Autodesk.AutoCAD.DatabaseServices.MaintenanceReleaseVersion OriginalFileMaintenanceVersion;
```

#### Conditions
Read-only
### OriginalFileName

#### Description
Accesses the file name that the database was originally opened under. May return a null pointer if the database was created from a DXF file or a pre-R13 drawing file.
```text
public string OriginalFileName;
```

#### Conditions
Read-only
### OriginalFileSavedByMaintenanceVersion

#### Description
Accesses the maintenance version value of the last AutoCAD product which saved the drawing file, not counting the current session.
```text
public Autodesk.AutoCAD.DatabaseServices.MaintenanceReleaseVersion OriginalFileSavedByMaintenanceVersion;
```

#### Conditions
Read / Write
### OriginalFileSavedByVersion

#### Description
Accesses the version value of the last AutoCAD product which saved the drawing file, not counting the current session.
```text
public DwgVersion OriginalFileSavedByVersion;
```

#### Conditions
Read / Write
### OriginalFileVersion

#### Description
Accesses the version value that the database file had when it was first opened.
```text
public DwgVersion OriginalFileVersion;
```

#### Conditions
Read-only
### Orthomode

#### Description
Accesses the current ORTHOMODE value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on ORTHOMODE. 
```text
public bool Orthomode;
```

#### Conditions
Read / Write
### PaperSpaceVportId

#### Description
Accesses the object ID of the paperspace Viewport for the database.
```text
public ObjectId PaperSpaceVportId;
```

#### Conditions
Read-only
### PdfFrame

#### Description
This .NET property wraps the ObjectARX functions [AcDbDatabase::pdfframe](AcDbDatabase__pdfframe@const.md) and [AcDbDatabase::setPdfframe](AcDbDatabase__setPdfframe@Adesk__Int8.md).
```text
public int PdfFrame;
```

#### Conditions
Read / Write
### Pdmode

#### Description
Accesses the current PDMODE value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on PDMODE. 
```text
public int Pdmode;
```

#### Conditions
Read / Write
### Pdsize

#### Description
Accesses the current PDSIZE value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on PDSIZE. 
```text
public double Pdsize;
```

#### Conditions
Read / Write
### Pelevation

#### Description
Accesses the current ELEVATION value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on ELEVATION. 
```text
public double Pelevation;
```

#### Conditions
Read / Write
### Pextmax

#### Description
Accesses the current EXTMAX value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on EXTMAX. 
```text
public Point3d Pextmax;
```

#### Conditions
Read / Write
### Pextmin

#### Description
Accesses the current EXTMIN value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on EXTMIN. 
```text
public Point3d Pextmin;
```

#### Conditions
Read / Write
### Pinsbase

#### Description
Accesses the current INSBASE value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on INSBASE. 
```text
public Point3d Pinsbase;
```

#### Conditions
Read / Write
### Plimcheck

#### Description
Accesses the current Paper Space LIMCHECK value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD _Command Reference_ for information on LIMCHECK.
```text
public bool Plimcheck;
```

#### Conditions
Read / Write
### Plimmax

#### Description
Accesses the current LIMMAX value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on LIMMAX. 
```text
public Point2d Plimmax;
```

#### Conditions
Read / Write
### Plimmin

#### Description
Accesses the current LIMMIN value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on LIMMIN. 
```text
public Point2d Plimmin;
```

#### Conditions
Read / Write
### PlineEllipse

#### Description
Accesses the current PELLIPSE value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on PELLIPSE.
```text
public bool PlineEllipse;
```

#### Conditions
Read / Write
### Plinegen

#### Description
Accesses the current PLINEGEN value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on PLINEGEN.
```text
public bool Plinegen;
```

#### Conditions
Read / Write
### Plinewid

#### Description
Accesses the current PLINEWID value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on PLINEWID.
```text
public double Plinewid;
```

#### Conditions
Read / Write
### PlotSettingsDictionaryId

#### Description
Accesses the object ID of the ACAD_PLOTSETTINGS dictionary.
```text
public ObjectId PlotSettingsDictionaryId;
```

#### Conditions
Read-only
### PlotStyleMode

#### Description
Returns true when this database is using color-dependent plot styles, and false for named plot styles. See the _AutoCAD User's Guide_ for more information on the two types of plot styles.
```text
public bool PlotStyleMode;
```

#### Conditions
Read-only
### PlotStyleNameDictionaryId

#### Description
Accesses the object ID of the database's plot style name dictionary.
```text
public ObjectId PlotStyleNameDictionaryId;
```

#### Conditions
Read-only
### PlotStyleNameId

#### Description
Accesses the objectId of the entry in the PlotStyleName dictionary for the plotStyleName of the layer table record.
```text
public PlotStyleDescriptor PlotStyleNameId;
```

#### Conditions
Read / Write
### ProjectName

#### Description
Accesses the database's PROJECTNAME header variable string.
```text
public string ProjectName;
```

#### Conditions
Read / Write
### Psltscale

#### Description
Accesses the current PSLTSCALE value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on PSLTSCALE.
```text
public bool Psltscale;
```

#### Conditions
Read / Write
### PsolHeight

#### Description
Accesses the current PSOLHEIGHT value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on PSOLHEIGHT.
```text
public double PsolHeight;
```

#### Conditions
Read / Write
### PsolWidth

#### Description
Accesses the current PSOLWIDTH value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on PSOLWIDTH.
```text
public double PsolWidth;
```

#### Conditions
Read / Write
### Pucs

#### Description
Sets the Paper Space UCS. The Pucsorg(), Pucsxdir(), and Pucsydir() are the query properties for this UCS.
```text
public CoordinateSystem3d Pucs;
```

#### Conditions
Write only
#### Notes
This method only works for AcDbDatabases that are not loaded in the AutoCAD editor.
### PucsBase

#### Description
Accesses the object ID of the UcsTableRecord that defines the origin and orientation of orthographic UCS settings for the database's current paper space.
```text
public ObjectId PucsBase;
```

#### Conditions
Read / Write
### Pucsname

#### Description
Accesses the object ID of the UCS table entry that is currently in use in the Paper Space of the database (Paper Space value of UCSNAME). 
See the System Variables section of the _AutoCAD Command Reference_ for information on UCSNAME.
```text
public ObjectId Pucsname;
```

#### Conditions
Read/Write
### Pucsorg

#### Description
Accesses the current Paper Space UCSORG value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on UCSORG.
```text
public Point3d Pucsorg;
```

#### Conditions
Read-only
### PucsOrthographic

#### Description
Returns false if the database's paper space UCS does not have an orthographic view whose reference UCS matches the database's PUCSBASE system variable.
```text
public Autodesk.AutoCAD.DatabaseServices.OrthographicView PucsOrthographic;
```

#### Conditions
Read-only
### Pucsxdir

#### Description
Accesses the current Paper Space UCSXDIR value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on UCSXDIR.
```text
public Vector3d Pucsxdir;
```

#### Conditions
Read-only
### Pucsydir

#### Description
Accesses the current Paper Space UCSYDIR value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on UCSYDIR.
```text
public Vector3d Pucsydir;
```

#### Conditions
Read-only
### Qtextmode

#### Description
Accesses the current QTEXTMODE value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on QTEXTMODE.
```text
public bool Qtextmode;
```

#### Conditions
Read-only
### RegAppTableId

#### Description
Accesses the object ID of the database's RegAppTable
```text
public ObjectId RegAppTableId;
```

#### Conditions
Read-only
### Regenmode

#### Description
Accesses the current REGENMODE value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD _Command Reference_ for information on REGENMODE.
```text
public bool Regenmode;
```

#### Conditions
Read / Write
### RetainOriginalThumbnailBitmap

#### Description
Accesses the status of the thumbnail bitmap toggle flag. The status is FALSE by default. If it is toggled to TRUE, the Database will always try to retain the original image, no matter what other action is taken.
```text
public bool RetainOriginalThumbnailBitmap;
```

#### Conditions
Read / Write
### Saveproxygraphics

#### Description
Accesses the current PROXYGRAPHICS value for the database. 
See the System Variables section of the AutoCAD _Command Reference_ for information on PROXYGRAPHICS.
```text
public int Saveproxygraphics;
```

#### Conditions
Read / Write
### SectionManagerId

#### Description
Accesses the section manager associated with this database.
```text
public ObjectId SectionManagerId;
```

#### Conditions
Read-only
### SectionViewStyle

#### Description
The Object ID of the current section view style.
```text
public ObjectId SectionViewStyle;
```

#### Conditions
Read / Write
### SectionViewStyleDictionaryId

#### Description
The Object ID of the section view style dictionary.
```text
public ObjectId SectionViewStyleDictionaryId;
```

#### Conditions
Read only property.
### SecurityParameters

#### Description
Accesses the security parameters associated with this database.
```text
public Autodesk.AutoCAD.DatabaseServices.SecurityParameters SecurityParameters;
```

#### Conditions
Read / Write
### Shadedge

#### Description
Accesses the current SHADEDGE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SHADEDGE.
```text
public int Shadedge;
```

#### Conditions
Read / Write
### Shadedif

#### Description
Accesses the current SHADEDIF value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SHADEDIF.
```text
public int Shadedif;
```

#### Conditions
Read / Write
### ShadowPlaneLocation

#### Description
Accesses the current ground plane z position in world coordinates. The ground plane is always parallel to the X-Y world plane.
```text
public double ShadowPlaneLocation;
```

#### Conditions
Read / Write
### ShowHist

#### Description
Accesses the current SHOWHIST value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SHOWHIST.
```text
public int ShowHist;
```

#### Conditions
Read / Write
### Sketchinc

#### Description
Accesses the current SKETCHINC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SKETCHINC.
```text
public double Sketchinc;
```

#### Conditions
Read / Write
### Skpoly

#### Description
Accesses the current SKPOLY value for the database. The value of false is 0. The value of true is 1. See the System Variables section of the AutoCAD Command Reference for information on SKPOLY.
```text
public bool Skpoly;
```

#### Conditions
Read / Write
### SolidHist

#### Description
Accesses the current SOLIDHIST value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SOLIDHIST
```text
public int SolidHist;
```

#### Conditions
Read / Write
### SortEnts

#### Description
Accesses the current SORTENTS value for the database.
```text
public int SortEnts;
```

#### Conditions
Read / Write
#### Notes
The SORTENTS system variable is deprecated, and its documentation has been removed from the _AutoCAD Command Reference_. It remains available in AutoCAD for legacy purposes. New applications should use the DRAWORDERCTL system variable, which supersedes SORTENTS.
### Splframe

#### Description
Accesses the current SPLFRAME value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SPLFRAME.
```text
public bool Splframe;
```

#### Conditions
Read / Write
### Splinesegs

#### Description
Accesses the current SPLINESEGS value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SPLINESEGS.
```text
public int Splinesegs;
```

#### Conditions
Read / Write
### Splinetype

#### Description
Accesses the current SPLINETYPE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SPLINETYPE.
```text
public int Splinetype;
```

#### Conditions
Read / Write
### StepSize

#### Description
Accesses the current STEPSIZE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on STEPSIZE.
```text
public double StepSize;
```

#### Conditions
Read / Write
### StepsPerSec

#### Description
Accesses the current STEPSPERSEC value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on STEPSPERSEC.
```text
public double StepsPerSec;
```

#### Conditions
Read / Write
### StyleSheet

#### Description
Accesses the database's current plot style sheet.
```text
public string StyleSheet;
```

#### Conditions
Read / Write
### SummaryInfo

#### Description
Accesses the database's summary info.
```text
public DatabaseSummaryInfo SummaryInfo;
```

#### Conditions
Read / Write
### Surftab1

#### Description
Accesses the current SURFTAB1 value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SURFTAB1.
```text
public int Surftab1;
```

#### Conditions
Read / Write
### Surftab2

#### Description
Accesses the current SURFTAB2 value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SURFTAB2.
```text
public int Surftab2;
```

#### Conditions
Read / Write
### Surftype

#### Description
Accesses the current SURFTYPE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SURFTYPE.
```text
public int Surftype;
```

#### Conditions
Read / Write
### Surfu

#### Description
Accesses the current SURFU value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SURFU.
```text
public int Surfu;
```

#### Conditions
Read / Write
### Surfv

#### Description
Accesses the current SURFV value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on SURFV.
```text
public int Surfv;
```

#### Conditions
Read / Write
### Tablestyle

#### Description
Accesses object ID of the table style specified by the current CTABLESTYLE value for the database. 
See the System Variables section of the _AutoCAD Command Reference_ for information on CTABLESTYLE.
```text
public ObjectId Tablestyle;
```

#### Conditions
Read / Write
### TableStyleDictionaryId

#### Description
Accesses the object ID of the table style dictionary in named object dictionary.
```text
public ObjectId TableStyleDictionaryId;
```

#### Conditions
Read-only
### Tdcreate

#### Description
Accesses the current TDCREATE value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on TDCREATE.
```text
public DateTime Tdcreate;
```

#### Conditions
Read-only
### Tdindwg

#### Description
Accesses the current TDINDWG value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on TDINDWG.
```text
public TimeSpan Tdindwg;
```

#### Conditions
Read-only
### Tducreate

#### Description
Accesses the current TDUCREATE value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on TDUCREATE.
```text
public DateTime Tducreate;
```

#### Conditions
Read-only
### Tdupdate

#### Description
Accesses the current TDUPDATE value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on TDUPDATE.
```text
public DateTime Tdupdate;
```

#### Conditions
Read-only
### Tdusrtimer

#### Description
Accesses the current TDUSRTIMER value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on TDUSRTIMER.
```text
public TimeSpan Tdusrtimer;
```

#### Conditions
Read-only
### Tduupdate

#### Description
Accesses the current TDUUPDATE value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on TDUUPDATE.
```text
public DateTime Tduupdate;
```

#### Conditions
Read-only
### Textsize

#### Description
Accesses the current TEXTSIZE value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on TEXTSIZE.
```text
public double Textsize;
```

#### Conditions
Read / Write
### Textstyle

#### Description
Accesses the current TEXTSTYLE value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on TEXTSTYLE.
```text
public ObjectId Textstyle;
```

#### Conditions
Read / Write
### TextStyleTableId

#### Description
Accesses the object ID of the database's TextStyleTable
```text
public ObjectId TextStyleTableId;
```

#### Conditions
Read-only
### Thickness

#### Description
Accesses the current THICKNESS value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on THICKNESS.
```text
public double Thickness;
```

#### Conditions
Read / Write
### ThumbnailBitmap

#### Description
Accesses the thumbnail bitmap image.
```text
public Bitmap ThumbnailBitmap;
```

#### Conditions
Read / Write
### TileMode

#### Description
Accesses the current TILEMODE value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD Command Reference for information on TILEMODE.
```text
public bool TileMode;
```

#### Conditions
Read / Write
### TileModeLightSynch

#### Description
For internal use only.
```text
public int TileModeLightSynch;
```

#### Conditions
Read / Write
### TimeZone

#### Description
Accesses the current time zone for the drawing, an enumerated value.
```text
public Autodesk.AutoCAD.DatabaseServices.TimeZone TimeZone;
```

#### Conditions
Read / Write
### Tracewid

#### Description
Accesses the current TRACEWID value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on TRACEWID.
```text
public double Tracewid;
```

#### Conditions
Read / Write
### TransactionManager

#### Description
Accesses the TransactionManager for the database.
```text
public Autodesk.AutoCAD.DatabaseServices.TransactionManager TransactionManager;
```

#### Conditions
Read-only
### Treedepth

#### Description
Accesses the current TREEDEPTH value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on TREEDEPTH.
```text
public int Treedepth;
```

#### Conditions
Read / Write
### TStackAlign

#### Description
Accesses the current TSTACKALIGN value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on TSTACKALIGN.
```text
public int TStackAlign;
```

#### Conditions
Read / Write
### TstackSize

#### Description
Accesses the current TSTACKSIZE value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on TSTACKSIZE.
```text
public int TstackSize;
```

#### Conditions
Read / Write
### Ucs

#### Description
Sets the Model Space UCS. The Ucsorg(), Ucsxdir(), and Ucsydir() are the query properties for this UCS.
```text
public CoordinateSystem3d Ucs;
```

#### Notes
This method only works for AcDbDatabases that are not loaded in the AutoCAD editor.
### UcsBase

#### Description
Accesses the object ID of the UcsTableRecord that defines the origin and orientation of orthographic UCS settings for the database's model space.
```text
public ObjectId UcsBase;
```

#### Conditions
Read / Write
### Ucsname

#### Description
Accesses the object ID of the UCS table entry that is currently in use in the Model Space of the database; that is, the Model Space value of UCSNAME. 
See the System Variables section of the AutoCAD Command Reference for information on UCSNAME.
```text
public ObjectId Ucsname;
```

#### Conditions
Read/Write
### Ucsorg

#### Description
Accesses the current Model Space UCSORG value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on UCSORG.
```text
public Point3d Ucsorg;
```

#### Conditions
Read-only
### UcsOrthographic

#### Description
Accesses the current orthographic view.
```text
public Autodesk.AutoCAD.DatabaseServices.OrthographicView UcsOrthographic;
```

#### Conditions
Read-only
### UcsTableId

#### Description
Accesses the object ID of the database's UCSTable.
```text
public ObjectId UcsTableId;
```

#### Conditions
Read-only
### Ucsxdir

#### Description
Accesses the current Model Space UCSXDIR value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on UCSXDIR.
```text
public Vector3d Ucsxdir;
```

#### Conditions
Read-only
### Ucsydir

#### Description
Accesses the current Model Space UCSYDIR value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on UCSYDIR.
```text
public Vector3d Ucsydir;
```

#### Conditions
Read-only
### UndoRecording

#### Description
Returns true if undo recording is enabled for the database.
```text
public bool UndoRecording;
```

#### Conditions
Read-only
### Unitmode

#### Description
Returns the current UNITMODE value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on UNITMODE.
```text
public int Unitmode;
```

#### Conditions
Read / Write
### UpdateThumbnail

#### Description
Accesses the UPDATETHUMBNAIL header variable value.
```text
public int UpdateThumbnail;
```

#### Conditions
Read / Write
### Useri1

#### Description
Returns the current USERI1 value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on USERI1.
```text
public int Useri1;
```

#### Conditions
Read / Write
### Useri2

#### Description
Returns the current USERI2 value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on USERI2.
```text
public int Useri2;
```

#### Conditions
Read / Write
### Useri3

#### Description
Returns the current USERI3 value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on USERI3.
```text
public int Useri3;
```

#### Conditions
Read / Write
### Useri4

#### Description
Returns the current USERI4 value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on USERI4.
```text
public int Useri4;
```

#### Conditions
Read / Write
### Useri5

#### Description
Returns the current USERI5 value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on USERI5.
```text
public int Useri5;
```

#### Conditions
Read / Write
### Userr1

#### Description
Returns the current USERR1 value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on USERR1.
```text
public double Userr1;
```

#### Conditions
Read / Write
### Userr2

#### Description
Returns the current USERR2 value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on USERR2.
```text
public double Userr2;
```

#### Conditions
Read / Write
### Userr3

#### Description
Returns the current USERR3 value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on USERR3.
```text
public double Userr3;
```

#### Conditions
Read / Write
### Userr4

#### Description
Returns the current USERR4 value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on USERR4.
```text
public double Userr4;
```

#### Conditions
Read / Write
### Userr5

#### Description
Returns the current USERR5 value for the database. 
See the System Variables section of the AutoCAD Command Reference for information on USERR5.
```text
public double Userr5;
```

#### Conditions
Read / Write
### Usrtimer

#### Description
Returns the current USRTIMER value for the database. A value of false is off. A value of true is on.
```text
public bool Usrtimer;
```

#### Conditions
Read / Write
### VersionGuid

#### Description
Accesses the database's Version GUID string
```text
public string VersionGuid;
```

#### Conditions
Read / Write
### ViewportScaleDefault

#### Description
Accesses the database's default value for viewport scale.
```text
public double ViewportScaleDefault;
```

#### Conditions
Read / Write
### ViewportTableId

#### Description
Accesses the object ID of the database's ViewportTable.
```text
public ObjectId ViewportTableId;
```

#### Conditions
Read-only
### ViewTableId

#### Description
Accesses the object ID of the database's ViewTable.
```text
public ObjectId ViewTableId;
```

#### Conditions
Read-only
### Visretain

#### Description
Accesses the current VISRETAIN value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD Command Reference for information on VISRETAIN.
```text
public bool Visretain;
```

#### Conditions
Read / Write
### VisualStyleDictionaryId

#### Description
Accesses the object ID of the ACAD_VISUALSTYLE dictionary, which contains objects of type VisualStyle.
```text
public ObjectId VisualStyleDictionaryId;
```

#### Conditions
Read-only
### Worldview

#### Description
Accesses the current WORLDVIEW value for the database. The value of false is 0. The value of true is 1. 
See the System Variables section of the AutoCAD Command Reference for information on WORLDVIEW.
```text
public bool Worldview;
```

#### Conditions
Read / Write
### XclipFrame

#### Description
Accesses the value of the XCLIPFRAME header variable. 
This .NET property wraps the ObjectARX methods [AcDbDatabase::xclipFrame()](AcDbDatabase__xclipFrame.md) and [AcDbDatabase::setXclipFrame](AcDbDatabase__setXclipFrame@Adesk__UInt8.md).
```text
public int XclipFrame;
```

### XrefBlockId

#### Description
Accesses the object ID of the BlockTableRecord which refers to this database as an xref.
```text
public ObjectId XrefBlockId;
```

#### Conditions
Read-only
### XrefEditEnabled

#### Description
Accesses the database's XEDIT value. A return value of true is the same as an XEDIT value of 1. 
See the system variables documentation in the AutoCAD Command Reference for information on XEDIT.
```text
public bool XrefEditEnabled;
```

#### Conditions
Read / Write