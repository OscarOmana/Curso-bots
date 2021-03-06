# ¿Qué es un mensaje?

¡Hola! Hasta ahora hemos hablado de Bots y los mensajes que regresa, pero…

## ¿Qué es un mensaje?

Bien vamos a definir a un mensaje como el tipo de [actividad](https://github.com/aminespinoza/Curso-bots/tree/master/Ejercicios/10.%20Qu%C3%A9%20es%20una%20actividad) más común como lo mencionamos en la lección pasada.

Un mensaje puede ser tan simple como una cadena de texto o contener archivos adjuntos, elementos interactivos y tarjetas enriquecidas. Por ejemplo, en el ejercicio anterior tú hiciste que el bot te avisara que ya estabas siendo agregado como usuario. Ese fue un ejemplo muy fácil, ahora veremos que tanto podemos obtener a partir de un mensaje.


### Esto es texto simple.
<img src="Imagenes/bot.png"/>

### Esto es con datos adjuntos, en este caso una imagen.
<img src="Imagenes/bot1.PNG"/>

### Esto es un ejemplo de tarjeta adaptable.
<img src="Imagenes/card.PNG"/>

Puedes notar en cada uno de los casos con las imágenes anteriores que los mensajes modifican su estructura de acuerdo a cada uno de los casos. Nota la sección de detalles (detail) y ahí encontrarás que el formato de JSON es en esencia el mismo pero también puedes notar que cada ejemplo aumenta sustancialmente la complejidad de cada caso. 

En la lección 13 comenzaremos a trabajar con los mensajes de texto que naturalmente son los más sencillos y servirán como puerta de entrada para todas las demás opciones como los adjuntos o como las tarjetas adaptables.
