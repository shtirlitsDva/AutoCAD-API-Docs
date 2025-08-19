# Field Class

## Overview

#### Description
This .NET class wraps the AcDbField ObjectARX class. 
It represents a field. The field can evaluate to one of the supported data types. The field object acts as a container to store the field expression, evaluated result, and other data. An evaluator is required for evaluating the field.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Field
```

```text
public class Field : DBObject;
```

### Constructors

- [Field()](#field())
- [Field(string)](#field(string))
- [Field(string, [MarshalAs(UnmanagedType.U1)] bool)](#field(string,-[marshalas(unmanagedtype.u1)]-bool))

### Methods

- [ConvertToTextField](#converttotextfield)
- [Evaluate()](#evaluate())
- [Evaluate(int, Database)](#evaluate(int,-database))
- [FindField](#findfield)
- [GetChildren](#getchildren)
- [GetChildrenIds](#getchildrenids)
- [GetData](#getdata)
- [GetFieldCode()](#getfieldcode())
- [GetFieldCode(FieldCodeFlags)](#getfieldcode(fieldcodeflags))
- [GetFieldCodeWithChildren()](#getfieldcodewithchildren())
- [GetFieldCodeWithChildren(FieldCodeFlags)](#getfieldcodewithchildren(fieldcodeflags))
- [GetStringValue](#getstringvalue)
- [SetData(string, object)](#setdata(string,-object))
- [SetData(string, object, [MarshalAs(UnmanagedType.U1)] bool)](#setdata(string,-object,-[marshalas(unmanagedtype.u1)]-bool))
- [SetFieldCode](#setfieldcode)
- [SetFieldCodeWithChildren(FieldCodeFlags, FieldCodeWithChildren)](#setfieldcodewithchildren(fieldcodeflags,-fieldcodewithchildren))
- [SetFieldCodeWithChildren(FieldCodeWithChildren)](#setfieldcodewithchildren(fieldcodewithchildren))

### Properties

- [DataType](#datatype)
- [EvaluationOption](#evaluationoption)
- [EvaluationStatus](#evaluationstatus)
- [EvaluatorId](#evaluatorid)
- [FilingOption](#filingoption)
- [Format](#format)
- [HyperLink](#hyperlink)
- [IsTextField](#istextfield)
- [State](#state)
- [Value](#value)


## Constructors Details

### Field()

#### Description
Default constructor.
```text
public Field();
```

### Field(string)

#### Description
Constructor that sets the field code. It does not evaluate the field.
```text
public Field(
    string fieldCode
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string fieldCode | Input field code |

### Field(string, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Constructor that sets the field code. It does not evaluate the field. 
A text field is used to store text with embedded field codes.
```text
public Field(
    string fieldCode, 
    [MarshalAs(UnmanagedType.U1)] bool textField
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string fieldCode | Input field code |
| [MarshalAs(UnmanagedType.U1)] bool textField | Input flag indicating whether this is a text field |

### ConvertToTextField

#### Description
Converts the field to a text field. A text field encapsulates text with embedded fields.
```text
public void ConvertToTextField();
```

### Evaluate()

#### Description
This method evaluates the field.
```text
public void Evaluate();
```

### Evaluate(int, Database)

#### Description
This method evaluates the field. After creating a field object and setting the field code, call this method to evaluate the field. 
If database is null, the field's database will be used if the field is database resident. If it is null and the field is not database resident, then evaluation will fail if the field requires a database.
```text
public void Evaluate(
    int evaluationOptions, 
    Database database
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int evaluationOptions | Input context in which the field is evaluated; the context flag can be one of the predefined FieldEvaluationContext enum flags or a user-defined context flag |
| Database database | Input database to be used for the evaluation, which can be null |

### FindField

#### Description
This function can be used to extract the embedded fields in text. It can be called in a loop to extract all the fields in the text.
```text
public static bool FindField(
    string text, 
    int iSearchFrom, 
    ref int nStartPos, 
    ref int nEndPos
);
```

#### Returns
True if a field is found; otherwise, false.
### GetChildren

#### Description
Gets the child field. 
If this field is a text field, the child fields are the fields embedded in the text. If this field is not a text field, the child fields are the number of nested fields. 
The returned field object is opened in the specified mode if this field is database resident. The caller is responsible for closing the field object after using it.
```text
public Field\[\] GetChildren();
```

### GetChildrenIds

#### Description
This .NET method wraps the ObjectARX method. 
Gets the child field. Unlike Field.GetChildren, it does require an enclosing transaction. If you call GetChildrenIds on non-db resident field, then you will get Null ObjectIds.
```text
public ObjectId\[\] GetChildrenIds();
```

#### Returns
This returns an array ObjectIds.
### GetData

#### Description
Gets data from the field object using a key.
```text
public object GetData(
    string key
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string key | Input key to get the data; the key cannot be null or an empty string |

### GetFieldCode()

#### Description
This function can be used to get a field code in various forms. It returns the field code as a string.
```text
public string GetFieldCode();
```

### GetFieldCode(FieldCodeFlags)

#### Description
This function can be used to get a field code in various forms.
```text
public string GetFieldCode(
    FieldCodeFlags flags
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| FieldCodeFlags flags | Input flag, which can be one or more of the FieldCodeFlags values |

### GetFieldCodeWithChildren()

#### Description
This function can be used to get a field code in various forms. It returns the field code as a string.
```text
public FieldCodeWithChildren GetFieldCodeWithChildren();
```

### GetFieldCodeWithChildren(FieldCodeFlags)

#### Description
This function can be used to get a field code in various forms.
```text
public FieldCodeWithChildren GetFieldCodeWithChildren(
    FieldCodeFlags flags
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| FieldCodeFlags flags | Input flag, which can be one or more of the FieldCodeFlags values |

### GetStringValue

#### Description
Returns the string.
```text
public string GetStringValue();
```

### SetData(string, object)

#### Description
Sets data in the field object using a key. The data will be copied and stored in the field object, and filed in and filed out with it. If the data contains an object ID, it will be properly translated during wblock operations. 
Pass null for data to delete the data at the specified key.
```text
public void SetData(
    string key, 
    object data
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string key | Input key to use to set and get the data; the key cannot be null or an empty string |
| object data | Input the object that contains the data |

### SetData(string, object, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Sets data in the field object using a key. The data will be copied and stored in the field object, and filed in and filed out with it. If the data contains an object ID, it will be properly translated during wblock operations. 
Pass null for data to delete the data at the specified key.
```text
public void SetData(
    string key, 
    object data, 
    [MarshalAs(UnmanagedType.U1)] bool recursive
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string key | Input key to use to set and get the data; the key cannot be null or an empty string |
| object data | Input the object that contains the data |
| [MarshalAs(UnmanagedType.U1)] bool recursive | Input true if the data is to be set in all child fields, false if it is to be set only in this field |

### SetFieldCode

#### Description
Sets the field code. For fields attached to DBObject objects, the DBObject object should be closed before calling SetFieldCode() to ensure the field contents are updated correctly.
```text
public void SetFieldCode(
    string fieldCode
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string fieldCode | Input field code to set |

### SetFieldCodeWithChildren(FieldCodeFlags, FieldCodeWithChildren)

#### Description
Sets the field code. For fields attached to DBObject objects, the DBObject object should be closed before calling SetFieldCodeWithChildren() to ensure the field contents are updated correctly.
```text
public void SetFieldCodeWithChildren(
    FieldCodeFlags flag, 
    FieldCodeWithChildren fieldCode
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| FieldCodeFlags flag | Input flag, which can be one or more of the FieldCodeFlags values |
| FieldCodeWithChildren fieldCode | Input field code to set |

### SetFieldCodeWithChildren(FieldCodeWithChildren)

#### Description
Sets the field code. For fields attached to DBObject objects, the DBObject object should be closed before calling SetFieldCodeWithChildren() to ensure the field contents are updated correctly.
```text
public void SetFieldCodeWithChildren(
    FieldCodeWithChildren fieldCode
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| FieldCodeWithChildren fieldCode | Input field code to set |

### DataType

#### Description
Accesses the data type of the field evaluation result.
```text
public Autodesk.AutoCAD.DatabaseServices.DataType DataType;
```

#### Conditions
Read-only
### EvaluationOption

#### Description
Accesses the evaluation option explicitly set in the field.
```text
public FieldEvaluationOptions EvaluationOption;
```

#### Conditions
Read / Write
### EvaluationStatus

#### Description
Accesses the evaluation status set by the evaluator
```text
public FieldEvaluationStatusResult EvaluationStatus;
```

#### Conditions
Read-only
### EvaluatorId

#### Description
Accesses the ID of the evaluator used by the field for evaluation.
```text
public string EvaluatorId;
```

#### Conditions
Read / Write
### FilingOption

#### Description
Accesses the filing option set in the field.
```text
public FieldFilingOptions FilingOption;
```

#### Conditions
Read / Write
### Format

#### Description
Accesses the output format set in the field.
```text
public string Format;
```

#### Conditions
Read / Write
### HyperLink

#### Description
Accesses the hyperlink associated with the field. A field can have only one hyperlink associated with it. The hyperlink can be set in a database-resident field object or an in-memory field object.
```text
public Autodesk.AutoCAD.DatabaseServices.HyperLink HyperLink;
```

#### Conditions
Read / Write
### IsTextField

#### Description
Assesses true if this field is a text field, which is text with embedded fields
```text
public bool IsTextField;
```

#### Conditions
Read-only
### State

#### Description
Accesses the field state, which can be one or more of the FieldState values.
```text
public FieldState State;
```

#### Conditions
Read-only
### Value

#### Description
Accesses the field evaluation result in its original data type.
```text
public object Value;
```

#### Conditions
Read-only