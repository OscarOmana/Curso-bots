using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace BotPYRBasico.Dialogs
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


            string message = activity.Text.ToLower();


            switch (message)
            {
                case "hola":
                    await context.PostAsync("Hola señor!");
                    break;
                case "como te llamas?":
                    await context.PostAsync("mi nombre es bot");
                    break;
                case "cuál es tu deporte favorito?":
                    await context.PostAsync("¿Deporte? ¿Qué es eso? ¿Escribir código cuenta como deporte?");
                    break;
                case "donde estoy?":
                    await context.PostAsync("En GitHub");
                    break;
                default:
                    await context.PostAsync("Lo siento, no entendí esto");
                    break;
            }

            context.Wait(MessageReceivedAsync);
        }
    }
}