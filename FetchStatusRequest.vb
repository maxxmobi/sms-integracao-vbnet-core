Imports Newtonsoft.Json

Namespace Maxxmobi.SMS
    Public Class FetchStatusRequest
        <JsonProperty("usuario")>
        Public Property Usuario As String
        <JsonProperty("senha")>
        Public Property Senha As String
    End Class
End Namespace

