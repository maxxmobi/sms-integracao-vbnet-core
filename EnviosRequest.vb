Imports System.Collections.Generic
Imports Newtonsoft.Json

Namespace Maxxmobi.SMS

    Public Class EnviosRequest

        <JsonProperty("usuario")>
        Public Property Usuario As String

        <JsonProperty("senha")>
        Public Property Senha As String

        <JsonProperty("requisicao")>
        Public Property Requisicao As List(Of MensagemSms)

    End Class
    
End Namespace
