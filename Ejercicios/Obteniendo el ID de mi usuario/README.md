# Obtener el id de mi usuario.

Algunas veces necesitaremos obtener el id de nuestro usuario, puede ser que sea solo para que nos salude por nuestro nombre o para muchas otras funciones más.
Bien para obtener el id de nuestro usuario solo basta con modificar un poco nuestra clase MessagesControlle en el método public async Task<HttpResponseMessage> Post([FromBody]Activity activity)

Lo que necesitaremos hacer es sustituir el contenido se ese método por este


``` csharp - C
if (activity.Type == ActivityTypes.Message)
            {
                string userName = "";
                if (activity.From.Name != null)
                    userName = activity.From.Name;// aquí estamos obteniendo el nombre de usuario
                ConnectorClient connector = new ConnectorClient(new Uri(activity.ServiceUrl));
                Activity reply = activity.CreateReply(userName);
                activity.TextFormat = "markdown";
                await connector.Conversations.ReplyToActivityAsync(reply);

            }
            else
            {
                HandleSystemMessage(activity);
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
``` 
