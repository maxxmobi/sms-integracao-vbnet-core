Imports Newtonsoft.Json

Namespace Maxxmobi.SMS
    Public Class StatusDoSMS
        <JsonProperty("id")>
        Public Property id As Long
        <JsonProperty("seuId")>
        Public Property seuId As String
        <JsonProperty("numero")>
        Public Property numero As String
        <JsonProperty("dataEnvio")>
        Public Property dataEnvio As String
        <JsonProperty("mensagem")>
        Public Property mensagem As String
        <JsonProperty("status")>
        Public Property status As String
        <JsonProperty("operadora")>
        Public Property operadora As String
        <JsonProperty("dataDaAtualizacaoDoStatus")>
        Public Property dataDaAtualizacaoDoStatus As String
    End Class
End Namespace

