# Autodesk.AutoCAD.DatabaseServices.XrefOperation Enumeration

## Overview

#### Description
This class enumerates the XREF subcommands.
```text
public enum XrefOperation {
  XrefAttachOperation = 0,
  XrefBindOperation = 1,
  XrefDetachOperation = 2,
  XrefOverlayOperation = 3,
  XrefPathOperation = 4,
  XrefReloadOperation = 5,
  XrefResolveOperation = 6,
  XrefUnloadOperation = 7,
  XrefXBindOperation = 1
}
```

#### Members
| Members | Description |
| --- | --- |
| XrefAttachOperation = 0 | Attaches an xref file to the database specified by HostDb or the current document in the editor if HostDb is null. |
| XrefBindOperation = 1 |
| XrefDetachOperation = 2 | Detaches the xref block by its given block name. This assumes a valid xref block exists in the database specified by HostDb (or the current document if HostDb == NULL). |
| XrefOverlayOperation = 3 | Overlays an xref file on the database specified by HostDb (or the current document if HostDb is null). |
| XrefPathOperation = 4 | Path specification of the XREF which is being attached. |
| XrefReloadOperation = 5 | Reloads the xref block by its given block name. This assumes a valid xref block exists in the database specified by HostDb (or the current document if HostDb is null). |
| XrefResolveOperation = 6 | Resolves existing xrefs in HostDb. HostDb must not point to Database that is the primary database for a document in AutoCAD (i.e., it must not point to a database that is loaded in the AutoCAD editor). |
| XrefUnloadOperation = 7 | Unloads the xref block by its given block name. This assumes a valid xref block exists in the database specified by HostDb (or the current document if HostDb == NULL). |
| XrefXBindOperation = 1 | Binds the XREF table records whose object IDs are in symbolIds. This is the same as the XBIND command in AutoCAD. |