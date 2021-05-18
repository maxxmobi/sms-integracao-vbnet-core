Imports Newtonsoft.Json
Imports System.Collections.Generic

Namespace Maxxmobi.SMS
    Public Class FetchRetornosResponse
        <JsonProperty("status")>
        Public Property status As String
        <JsonProperty("listaResposta")>
        Public Property listaResposta As List(Of Retorno)
    End Class
End Namespace

