Imports Newtonsoft.Json

Namespace Maxxmobi.SMS
    Public Class Retorno
        <JsonProperty("id")>
        Private Property id As Long
        <JsonProperty("mensagem")>
        Private Property mensagem As String
        <JsonProperty("seuId")>
        Private Property seuId As String
        <JsonProperty("data")>
        Private Property data As String
        <JsonProperty("numero")>
        Private Property numero As String
        <JsonProperty("operadora")>
        Private Property operadora As String
    End Class
End Namespace

