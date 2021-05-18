Imports System.Collections.Generic
Imports System
Imports System.Threading
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Namespace Maxxmobi.SMS
    Class Maxxmobi

    'Envia Mensagens em Lote,
    Shared Async Function EnviaMensagensEmLote(ByVal enviosRequest As EnviosRequest) As Task (Of EnviosResponse)
      Dim pagina As String = "https://api.maxx.mobi/ws/maxxmobi/envios/"
      Dim data = JsonConvert.SerializeObject(enviosRequest)
      Dim enviosResponse = Nothing

      Dim content = New StringContent(data, Encoding.UTF8, "application/json")

      Using cliente As HttpClient = New HttpClient()
          Using resposta As HttpResponseMessage = Await cliente.PostAsync(pagina, content)

                Using conteudo As HttpContent = resposta.Content
                    Dim httpResponseBody As String = Await conteudo.ReadAsStringAsync()
                    enviosResponse = JsonConvert.DeserializeObject(Of EnviosResponse)(httpResponseBody)
                End Using
          End Using
      End Using

      return enviosResponse

    End Function

    'Busca Status Nao Lidos, Limitado a 1000 Status
    Shared Async Function BuscaStatusNaoLidos(ByVal fetchStatusRequest As FetchStatusRequest) As Task (Of FetchStatusResponse)
      Dim pagina As String = "https://api.maxx.mobi/ws/maxxmobi/fetch/status/"
      Dim data = JsonConvert.SerializeObject(fetchStatusRequest)
      Dim fetchStatusResponse = Nothing

      Dim content = New StringContent(data, Encoding.UTF8, "application/json")

      Using cliente As HttpClient = New HttpClient()
          Using resposta As HttpResponseMessage = Await cliente.PostAsync(pagina, content)

                Using conteudo As HttpContent = resposta.Content
                    Dim httpResponseBody As String = Await conteudo.ReadAsStringAsync()
                    console.WriteLine(httpResponseBody)
                    fetchStatusResponse = JsonConvert.DeserializeObject(Of FetchStatusResponse)(httpResponseBody)
                End Using
          End Using
      End Using

      return fetchStatusResponse

    End Function

    'Busca Lista de Retornos Nao Lidos, Limitado a 1000 retornos
    Shared Async Function BuscaRetornosNaoLidos(ByVal fetchRetornosRequest As FetchRetornosRequest) As Task (Of FetchRetornosResponse)
      Dim pagina As String = "https://api.maxx.mobi/ws/maxxmobi/fetch/retornos/"
      Dim data = JsonConvert.SerializeObject(fetchRetornosRequest)
      Dim fetchRetornosResponse = Nothing

      Dim content = New StringContent(data, Encoding.UTF8, "application/json")

      Using cliente As HttpClient = New HttpClient()
          Using resposta As HttpResponseMessage = Await cliente.PostAsync(pagina, content)

                Using conteudo As HttpContent = resposta.Content
                    Dim httpResponseBody As String = Await conteudo.ReadAsStringAsync()
                    fetchRetornosResponse = JsonConvert.DeserializeObject(Of FetchRetornosResponse)(httpResponseBody)
                End Using
          End Using
      End Using

      return fetchRetornosResponse

    End Function

    End Class
End Namespace
