# Hero Card

Una Hero Cara es una tarjeta multipropósito que principalmente contiene una imagen grande, un botón y texto plano 

## Agrega una hero card a tu Bot

``` csharp - C
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
```

Y con esto, el resultado será el siguiente.

<img src="Imagenes/UserOne.PNG"/>