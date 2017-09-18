using Microsoft.Bot.Builder.FormFlow;
using System;
using Microsoft.Bot.Builder.Dialogs;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreguntasRespuestasBasicas.Dialogs
{
    [Serializable]
    public class BasicForm
    {
        [Prompt("Cuál es tu nombre?")]
        public string Nombre;

        [Prompt("Cuál es tu apellido?")]
        public string Apellido;

        [Prompt("Cuál es tu edad?")]
        public string Edad;

        [Prompt("Eres hombre o mujer?")]
        public Genero Genero;

        public static IForm<BasicForm> BuildForm()
        {
            return new FormBuilder<BasicForm>()
                .Message("Hola, vamos a comenzar a conocer tus datos")
                .OnCompletion(async (context, BasicForm) =>
                {
                    await context.PostAsync("Tu perfil está completo.");
                })
                .Build();
        }
    }

    [Serializable]
    public enum Genero
    {
        Hombre = 1,
        Mujer = 2,
        Americanista = 3
    };

}