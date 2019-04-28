Imports System

Namespace PredefinedParametersInUriJsonSource
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.label1 = New System.Windows.Forms.Label()
            Me.button1 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(12, 26)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(286, 57)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Show the Report Designer with a predefined parameters on Specify request paramete" & "rs page"
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(15, 86)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(271, 23)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Design-Time JSON Parameters"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(306, 196)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private label1 As System.Windows.Forms.Label
        Private WithEvents button1 As System.Windows.Forms.Button
    End Class
End Namespace

