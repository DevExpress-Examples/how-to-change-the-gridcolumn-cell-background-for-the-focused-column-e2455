﻿' Developer Express Code Central Example:
' How to change the GridColumn cell background for the focused column
' 
' This sample illustrates how to change the focused column appearance. Create the
' attached property for the GridColumn that determines whether the row is focused
' or not. Iterate via columns in the FocusedColumnChanged event, to keep this
' attached property up-to-date for every column. In the CellStyle event, change
' the Background property only for columns for which the custom attached property
' is True.
' Starting with version 2013 vol 1 the GridControl.FocusedColumnChanged
' event is marked as obsolete. The GridControl.CurrentColumnChanged event should
' be used instead.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2455

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
    Friend NotInheritable Partial Class Settings
        Inherits System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

        Public Shared ReadOnly Property [Default]() As Settings
            Get
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace
