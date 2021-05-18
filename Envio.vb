Imports Newtonsoft.Json

Namespace Maxxmobi.SMS

    Public Class MensagemSms

        <JsonProperty("idCliente")>
        Public Property IdCliente As String

        <JsonProperty("numero")>
        Public Property Numero As String

        <JsonProperty("mensagem")>
        Public Property Mensagem As String
        
    End Class

End Namespace
