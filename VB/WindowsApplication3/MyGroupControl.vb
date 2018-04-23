Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Drawing
Imports DevExpress.Skins
Imports DevExpress.Utils

Namespace WindowsApplication3
    Public Class MyGroupControl
        Inherits GroupControl

        Protected Overrides Function CreatePainter() As ObjectPainter
            If LookAndFeel.ActiveStyle = DevExpress.LookAndFeel.ActiveLookAndFeelStyle.Skin Then
                Return New MyGroupObjectPainter(Me, LookAndFeel.ActiveLookAndFeel)
            End If
            Return MyBase.CreatePainter()
        End Function
    End Class
    Public Class MyGroupObjectPainter
        Inherits SkinGroupObjectPainter

        Public Sub New(ByVal owner As IPanelControlOwner, ByVal provider As ISkinProvider)
            MyBase.New(owner, provider)
        End Sub

        Protected Overrides Function CalcCaptionTextSize(ByVal info As GroupObjectInfoArgs) As Size
            Dim left As Integer = Nothing, top As Integer = Nothing, right As Integer = Nothing, bottom As Integer = Nothing
            CalcContentMargins(info, left, top, right, bottom)
            Dim width As Integer = info.Bounds.Width - left - right
            Dim height As Integer = info.Bounds.Height - top - bottom
            Dim size As Size = info.AppearanceCaption.CalcTextSize(info.Cache, info.AppearanceCaption.GetStringFormat(GetTextOptions()), info.Caption,If(IsVerticalCaption(info), height, width)).ToSize()
            Return size
        End Function

        Protected Overrides Sub CalcCaptionElementsNormal(ByVal info As GroupObjectInfoArgs, ByVal caption As Rectangle)
            Dim left As Integer = Nothing, top As Integer = Nothing, right As Integer = Nothing, bottom As Integer = Nothing
            CalcContentMargins(info, left, top, right, bottom)
            MyBase.CalcCaptionElementsNormal(info, caption)
            Dim rect As Rectangle = info.TextBounds
            Dim textOffset As Integer = (caption.Height - (top + info.TextBounds.Height + bottom)) \ 2
            rect.Y -= textOffset
            rect.Size = CalcCaptionTextSize(info)
            info.TextBounds = rect
        End Sub
    End Class
End Namespace
