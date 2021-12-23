#Organizador de Registros

La función de este programa es de guardar registros en un archivo
binario de forma secuencial. Para realziar esto, se hacen los 
cálculos para saber la longitud de cada campo y así tener una 
determinada longitud total para todo el registro. 

A continuación se muestran algunas capturas de la interfaz que 
pueden ser de suma importancia para el usuario:

1. Como se puede ver, el campo ID está bloqueado. Este se aumenta
automáticamente cuando un registro es agregado. 

![](https://raw.githubusercontent.com/JT070/Organizador-Registros/master/imgs/01-BloqueoID.png)

> Img1. Campo ID bloqueado.

2. En caso de haber registros salteados, este busca el número de ID más grande y se posiciona en el n+1 del número encontrado.

![](https://raw.githubusercontent.com/JT070/Organizador-Registros/master/imgs/08-ID_automatico.png)

> Img2. Funcionamiento del campo ID automático.

3. Si se intenta desbloquear el ID, se mostrará el mensaje sigueinte (ver Img3). Solo hay que darle click a "Sí" y este
campo se desbloqueará sin problema.

![](https://raw.githubusercontent.com/JT070/Organizador-Registros/master/imgs/01-BloqueoID-aviso.png)

> Img3. Aviso de desbloqueo de ID.

4. Los botones de "Eliminar" y "Modificar" solo se desbloquearán 
cuando se tenga mostrado un ÚNICO REGISTRO en la tabla.

![](https://raw.githubusercontent.com/JT070/Organizador-Registros/master/imgs/02-BotonesBloqueados-1.png)

> Img4. Funcionamiento de los botones de Eliminar y Modificar

5. Estos son los botones de navegación.

- Los botones de Primero y Último funcionan para comenzar el recorrido de los registros sin necesidad de haber realizado una búsqueda por ID.

- Los botones de Siguiente y Anterior se encuentran bloqueados al inicio del programa. Estos se desbloquean después de haber hecho una búsuqeda por ID o si ya se inició el recorrido de registros, es decir, después de haber presionado los botones de Primero o Último. Es necesario que haya registros ingresados.

- El botón más grande muestra todos los registros guardados.

- El botón azúl hace un ordenamiento burbuja de los índices de los resgistros. Para ver los cambios, se necesita refrescar la tabla donde se muestran los registros (se puede hacer presionando el botón de Mostrar Todo).

![](https://raw.githubusercontent.com/JT070/Organizador-Registros/master/imgs/03-BotonesBloqueados-2.png)

> Img5. Botones de navegación. 

6. Estos botones se encuentran debajo de los campos del formulario. El primero sirve para limpiar todos los campos y la tabla. El segundo agrega el registro.

![](https://raw.githubusercontent.com/JT070/Organizador-Registros/master/imgs/04-Botones.png)

> Img6. Botones de Limpiar y Agregar.

7. Búsquda por ID y Búsqueda Binaria. Dos métodos de búsqueda distintos que toman como parámetro el número que se ingrese en el campo de ID.

**Nota:** _Si se ingresa el número "1340295" en el campo del ID, se agregarán automáticamente 10 registros escritos previamente para realizar pruebas del programa._

![](https://raw.githubusercontent.com/JT070/Organizador-Registros/master/imgs/05-B%C3%BAsqueda.png)

>  Img7. Búsquedas Binaria y por ID.

8. Todos los registros se guardan en un archivo binario con extensión **.dat**, el cual se encuentra en la carpeta **/bin** del proyecto. Este fichero se genera automáticamente al ingresar un primer registro.

![](https://raw.githubusercontent.com/JT070/Organizador-Registros/master/imgs/11-ArchivoBinario.png)

> Img8. Fichero binario que almacena los registros.