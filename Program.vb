Imports System.Collections.Generic
Imports System
Imports System.Threading
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text


Namespace Maxxmobi.SMS
    Class Program
       
    Public Shared Sub Main(ByVal args As String())

       Dim t As Task = New Task(AddressOf AsyncMain)
       t.Start()
       Console.WriteLine("Aguardando Envios")
       Console.ReadLine()

    End Sub

    Shared Async Sub AsyncMain()

      Dim myusername As String = ""
      Dim mypassword As String = ""

      Console.WriteLine("Envio de SMS")
      Dim enviosResponse = Await Maxxmobi.EnviaMensagensEmLote(New EnviosRequest() With {
        .Usuario = myusername,
        .Senha = mypassword,
        .Requisicao = New List(Of MensagemSms)() From {
          New MensagemSms() With {
            .IdCliente = "uis001",
            .Numero = "5571991919449",
            .Mensagem = "Test Message"
            }
          }
        })
 
       If 0D = enviosResponse.Status Then
         Console.WriteLine("Sms Enviado Status = " & enviosResponse.Resposta & " Lote = " & enviosResponse.Lote)
       Else
         Throw New Exception(enviosResponse.Resposta)
       End If

       Console.WriteLine("Envios Finalizados!" )

       'Exemplo do Método de consulta de status de SMS
       Console.WriteLine("Busca Status Nao Lidos")
       Dim fetchStatusResponse = Await Maxxmobi.BuscaStatusNaoLidos(New FetchStatusRequest() With {
          .Usuario = myusername,
          .Senha = mypassword
       })

       If NameOf(EnumStatusDoRequest.SUCESSO) = fetchStatusResponse.status Then

          For Each status In fetchStatusResponse.listaDeStatus
              Console.WriteLine(JsonConvert.SerializeObject(status))
          Next

       ElseIf NameOf(EnumStatusDoRequest.NENHUM_ITEM_ENCONTRADO) = fetchStatusResponse.status Then

          Console.WriteLine("Nenhum Status Encontrado, espere mais um pouco antes de fazer a próxima consulta")
       Else
          Console.WriteLine("Ocorreu um erro")
       End If

       Console.WriteLine("Consulta Por Status Finlizada!")
       'Fim da Consulta de status de SMS

       'Exemplo do Método de consulta de Retornos de SMS (Mo)
       Console.WriteLine("Consulta Por Retornos de SMS Nao Lidos!")
       Dim fetchRetornosResponse = Await Maxxmobi.BuscaRetornosNaoLidos(New FetchRetornosRequest() With {
          .Usuario = myusername,
          .Senha = mypassword
       })

       If "OK" = fetchRetornosResponse.status Then

          For Each status In fetchRetornosResponse.listaResposta
              Console.WriteLine(JsonConvert.SerializeObject(status))
          Next

       ElseIf "SEM DADOS" = fetchRetornosResponse.status Then

          Console.WriteLine("Nenhum Retorno Encontrado, espere mais um pouco antes de fazer a próxima consulta" & JsonConvert.SerializeObject(fetchRetornosResponse) )
       Else
          Console.WriteLine("Ocorreu um erro" & fetchRetornosResponse.status )
       End If

       Console.WriteLine("Consulta Por Retornos Finlizada!")
       'Fim da Consulta de status de Retornos de SMS (Mo)

       'Finaliza o Programa
       End

    End Sub

    End Class
End Namespace

