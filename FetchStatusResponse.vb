Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports Newtonsoft.Json.Converters

Namespace Maxxmobi.SMS
    Public Class FetchStatusResponse
        <JsonProperty("status")>
        Public Property status As String 
        <JsonProperty("listaDeStatus")>
        Public Property listaDeStatus As List(Of StatusDoSMS)
    End Class
End Namespace

