Imports Newtonsoft.Json

Namespace Maxxmobi.SMS

    Public Class EnviosResponse

        <JsonProperty("status")>
        Public Property Status As Integer

        <JsonProperty("resposta")>
        Public Property Resposta As String

        <JsonProperty("lote")>
        Public Property Lote As String
        
    End Class

End Namespace
