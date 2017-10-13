using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Collections.Generic;

namespace HeroCards.Dialogs
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

            Activity reply = activity.CreateReply("Esto es una **hero card**");
            reply.Attachments = new List<Attachment>();

            var heroCard = new HeroCard()
            {
                Title = "Bot Framework Hero Card",
                Subtitle = "Tus bots — Pueden enriquecer con una hero card",
                Text = "Construye y conecta bots inteligentes para interactuar con los usuarios de una forma mucho más simple pero más efectiva, enriquece tus bots agregando diferente contenido como tarjetas tipo Héroe.",
                Images = new List<CardImage>
                {
                    new CardImage("http://vignette1.wikia.nocookie.net/marvelmovies/images/8/80/CW_Fathead_Render_09.png")
                },

                Buttons = new List<CardAction>
                {
                    new CardAction(ActionTypes.OpenUrl, "Inicia aquí", value: "https://github.com/aminespinoza/Curso-bots")
                }
            };

            Attachment plAttachment = heroCard.ToAttachment();
            reply.Attachments.Add(plAttachment);
            await context.PostAsync(reply);
            context.Wait(MessageReceivedAsync);
        }
    }
}