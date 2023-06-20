# Simurala (Segundo parcial Laboratorio II)


## Aclaracion sobre la base de datos
La base de datos necesaria para el correcto funcionamiento del programa se encuentra en la carpeta llamada db/ y son 2 archivos llamados: `Monserrat.Lautaro.TP2.mdf` y `Monserrat.Lautaro.TP2_log.ldf`.
Hay que arrastrarlos a la siguiente ruta: `C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA` y agregarlos desde Microsoft SQL Server con la opcion: Attach database.

## Sobre mi
Mi nombre es Lautaro Monserrat, y tengo 19 años. A la hora de hacer este trabajo, se me hizo algo dificil la forma en la que imaginar como hacer para que la maquina simule el juego, ya que nunca habia programado una aplicacion de ese estilo, y me costo empezar por ese lado. Me parecio un programa divertido de hacer y ademas me ayudo a entender bien el uso de eventos y delegados, ya que en clase no habia entendido del todo en donde podian ser aplicados, y gracias a este poryecto me pude hacer una mejor idea.

## Resumen
La aplicacion es un simulador del juego de mesa Generala, al correrla te permite logearte o registrarte con una cuenta de mail ficticia. Una vez en el menu principal, el usuario podra ser capaz de crear jugadores, tambien ficticios, y poder hacer que jueguen en salas de juego. Es decir, se va a poder crear una nueva sala de juego en donde se seleccione 2 jugadores distintos y se enfrentaran entre ellos. Una vez creadas las salas, hay 2 botones los cuales permiten iniciar el juego y frenar el juego. Por ultimo, habra una seccion de Estadisticas historicas, en donde se podran consultar las victorias y puntajes en total de cada jugador, y ver el historial de todas las partidas jugadas, pudiendo descargar el registro de juego de cada partida.

## Diagrama de clases


## Justificacion tecnica
- **Excepciones:** Este tema lo aplique para la realizacion de validaciones. Ya que me parecio que me permitia manejar los errores de una manera mas sencilla, ya que si alguna validacion daba como incorrecta, en vez de tener que retornar un string con el error generado para utilizarlo en un Windows Forms, podia atraparlo desde el mismo Form con un catch(Exception ex), y mostrarlo como un ex.Message.
- **Pruebas unitarias:** Este tema lo utilice para realizar testeos de todas mis clases. Las use mucho para validar las sobrecargas de los operadores == y !=.
- **Generics:** Este tema lo aplique en la parte de archivos, mas especificamente en la serializacion json, ya que me fueron muy utiles para poder crear solo 2 metodos para lectura y escritura, los cuales reciben un valor generico y lo serializar/deserealizan. 
- **Interfaces:** Este tema lo aplique en una interfaz llamada IPersona, de la cual heredan Usuario y Jugador, en la cual marque que las clases que hereden de esta interfaz iban a tener que tener una propiedad de lectura y escritura de Nombre, Apellido y sobreescribir el metodo ToString().
- **Bases de datos:** Este tema lo aplique para el guardado de datos de los usuarios y jugadores.
- **Delegados:** Este tema lo aplique en mi clase Partida, ya que para lograr el cambio de imagen de los dados en mi form y actualizar el registro de juego, lo que hice fue crear 2 delegados en mi clase Partida para que cada vez que se tiren los dados o alguien haga una jugada, se invoque este metodo y se actualice en el form.
- **Programacion multi-hilo:** Este tema lo aplique para lograr que se puedan jugar mas de una partida en simultaneo, ya que para simular cada partida lo que hago es correrla en un nuevo hilo, para que de esta manera no se trabe el programa ni nada, y el hilo principal pueda continuar fluyendo sin problema.
- **Eventos:** Este tema lo aplique tambien en mi clase partida al igual que delegados, lo que hice fue hacer un evento el cual notifique cuando haya un nuevo ganador. Este se invoca una vez termina la partida y se calculan los resultados.