Public Structure Usuario
    Private id As Integer
    Private contrasena As String

    Public Sub New(id As Integer, contrasena As String)
        Me.id = id
        Me.contrasena = contrasena
    End Sub

    Public Property id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Contrasena1 As String
        Get
            Return contrasena
        End Get
        Set(value As String)
            contrasena = value
        End Set
    End Property
End Structure
