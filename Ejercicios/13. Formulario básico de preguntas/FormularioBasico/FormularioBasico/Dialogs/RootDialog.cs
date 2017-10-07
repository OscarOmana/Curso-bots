using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace FormularioBasico.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;
            string receivedString = activity.Text.ToLower();
            string reply = string.Empty;

            switch (receivedString)
            {
                case "hola":
                    reply = "Hola! Cómo te va?";
                    break;
                case "tengo hambre":
                    reply = "No lo creo, creo que tienes sed";
                    break;
                case "cómo te llamas?":
                    reply = "Puedes decirme como quieras, no me ofendo";
                    break;
                case "qué edad tienes?":
                    reply = "soy tan viejo como el tiempo mismo";
                    break;
                default:
                    reply = "Lo siento, no entiendo esta pregunta";
                    break;
            }
            await context.PostAsync(reply);
            context.Wait(MessageReceivedAsync);
        }
    }
}