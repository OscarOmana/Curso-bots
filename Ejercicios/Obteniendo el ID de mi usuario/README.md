# Obtener el id de mi usuario.

Algunas veces necesitaremos obtener el id de nuestro usuario, puede ser que sea solo para que nos salude por nuestro nombre o para muchas otras funciones más.

Para este ejemplo usaremos el ejercicio anterior preguntas y respuestas básicas, aquí el [enlace](https://github.com/aminespinoza/Curso-bots/tree/master/Ejercicios/9.%20Preguntas%20y%20respuestas%20b%C3%A1sicas)

Bien para obtener el id de nuestro usuario solo basta con modificar un poco nuestra clase MessagesControlle en el método public async Task<HttpResponseMessage> Post([FromBody]Activity activity)


Lo que necesitaremos es agregar un par de líneas 

``` csharp - C
if(activity.From.Name != null)
string userName= activity.From.Name;
``` 

esto será antes de nuestro await

justo de esta forma…

``` csharp - C
if (activity.Type == ActivityTypes.Message)
            {
                string userName = "";
                if (activity.From.Name != null)
                    userName = activity.From.Name;//Here we are getting user name
                await Conversation.SendAsync(activity, () => new Dialogs.RootDialog());
            }
            else
            {
                HandleSystemMessage(activity);
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
``` 

ahora para que les muestre el nombre de su usuario haremos lo siguiente en nuestra clase de RootDialog antes de nuestro switch (recuerden que seguimos usando el ejercicio de Preguntas y respuestas básicas) pondremos la siguiente línea de código 

``` csharp - C
string blabla = activity.From.Name;
``` 

y después en el primer case podemos hacer esto...

``` csharp - C
    case "hola":
        await context.PostAsync(String.Format("Hola {0}!", blabla));
        break;
``` 

de esta forma el resultado será el siguiente.


<img src="Imagenes/UserOne.PNG"/>

Nota: el usuario en este caso será “User” ya que estamos de manera local. Para demostrar como lo haríamos con el bot publicado sigue este curso y en otra publicación haremos esto pero con el bot ya publicado.
