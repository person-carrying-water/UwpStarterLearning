﻿#ExternalChecksum("C:\Workspace\DotNet\UwpStarterLearning\UwpStarterLearning\Views\WindowTimer.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "0928381E97E3FAB051A3E3A3B6024D11")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Namespace Global.UwpStarterLearning

    Partial Class WindowTimer
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2


        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Connect(ByVal connectionId As Integer, ByVal target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
            Select Case connectionId
            Case 1 ' Views\WindowTimer.xaml line 1
                    Me.PageWindowTimer = CType(target, Global.Windows.UI.Xaml.Controls.Page)
                    Exit Select
            Case 2 ' Views\WindowTimer.xaml line 11
                    Me.WindowTimer1 = CType(target, Global.Windows.UI.Xaml.Controls.Grid)
                    Exit Select
            Case 3 ' Views\WindowTimer.xaml line 22
                    Me.TextBlockTime = CType(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                    Exit Select
            Case 4 ' Views\WindowTimer.xaml line 23
                    Me.TextBlockCount = CType(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                    Exit Select
            Case 5 ' Views\WindowTimer.xaml line 24
                    Me.ButtonDispaTimer = CType(target, Global.Windows.UI.Xaml.Controls.Button)
                    Exit Select
            Case 6 ' Views\WindowTimer.xaml line 25
                    Me.ButtonDispaStop = CType(target, Global.Windows.UI.Xaml.Controls.Button)
                    Exit Select
            Case 7 ' Views\WindowTimer.xaml line 26
                    Me.ButtonTimersTimer = CType(target, Global.Windows.UI.Xaml.Controls.Button)
                    Exit Select
            Case 8 ' Views\WindowTimer.xaml line 27
                    Me.ButtonTimersStop = CType(target, Global.Windows.UI.Xaml.Controls.Button)
                    Exit Select
            Case 9 ' Views\WindowTimer.xaml line 28
                    Me.ButtonThreadingTimer = CType(target, Global.Windows.UI.Xaml.Controls.Button)
                    Exit Select
            Case 10 ' Views\WindowTimer.xaml line 29
                    Me.ButtonThreadingStop = CType(target, Global.Windows.UI.Xaml.Controls.Button)
                    Exit Select
                    Case Else
                        Exit Select
            End Select
                Me._contentLoaded = true
        End Sub

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function GetBindingConnector(connectionId As Integer, target As Object) As Global.Windows.UI.Xaml.Markup.IComponentConnector Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2.GetBindingConnector
            Dim returnValue As Global.Windows.UI.Xaml.Markup.IComponentConnector = Nothing
            Return returnValue
        End Function
    End Class

End Namespace


