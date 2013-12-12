Namespace DB
    Public Interface IRepository(Of T)
        Function GetAll() As List(Of T)
        Function Add(ByVal t As T) As Boolean
    End Interface


End Namespace

