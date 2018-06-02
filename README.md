<div align="center">
 <img src="https://user-images.githubusercontent.com/9372893/40866937-1fef04ea-65c6-11e8-95a5-5f5737b237df.png" width="400">
</div>

---

Eva 360 es un sistema de **R.R.H.H.** (recursos humanos) que facilita el proceso de la **evaluación del rendimiento** de los trabajadores de una empresa. Para dicha evaluación se usarán los llamados *Exámenes 360*. De esta manera, el sistema maneja diferentes tipos de usuario con diferentes niveles de aceso.

Adicionalmente EVA 360, brinda un *muro organizacional* en el que de forma similiar a **Facebook** o **Twitter** todos los miembros de la institución podrán compartir contenido y publicar **posts**.
Con una adecuada cuota social, debido al carácter empresarial, EVA 360 notificará a los trabajadores cuando sucedan eventos importantes, como: cumpleaños, aniversarios, reuniones, etc.

## Arquitectura ##

<div align="center">
 <img src="https://user-images.githubusercontent.com/9372893/28237718-d758b9ae-690b-11e7-9649-bb96bd86dfe0.png" alt="eva360">
</div>

### Plataforma ###

Eva 360 está desarrollada en **ASP.NET Core**, como ya todos sabemos han surgido grandes cambios en **Microsoft**, muchos de ellos a partir de la entrada de [Natya Sadella](https://www.pocketables.com/2014/02/official-natya-sadella-microsofts-new-ceo.html) en el 2014.

Microsoft empezó a contribuir con tecnologías y herramientas a la comunidad Open Source, desde entonces los desarrolladores hemos podido disfrutar de muchas de estas contribuciones, tanto que se han vuelto parte de nuestro día a día, tales son el caso de: **Typescript** y **Visual Studio Code**.

<div align="center">
 <img src="https://user-images.githubusercontent.com/9372893/40868739-8fd0e1f2-65d5-11e8-8fd4-4546f533a01b.jpeg" height="400">
</div>

Proyectos notables: la **compra de Xamarin**, el nacimiento del fenómeno llamado **Azure**, la creación de los **UWP**.

Y por supuesto, lo que más nos sorprendió es un completo *rewrite* a una tecnología con más de 10 años en el mercado, volviéndola **Open Source**, **Moderna**, **Portable**, **Escalable**, **Potente** y **Multi-plataforma**. Este ha sido el caso de *NET Framework*, que ahora adopta el nombre de **NET Core**. No se puede evitar resaltar el hecho de que **NET Core** ha sido construida desde el inicio pensando en arquitectura de **microservicios**.

### Frontend Framework ###

Si bien, ahora que podemos usar el *notablemente* mejorado **Razor** de la plataforma **NET Core**, hemos decidido escoger un framework para los componentes visuales de la aplicación. He aqui el porqué de nuestra decsión.

- Usar Vue es extremadamente rápido y fácil, es increible **cuánto tiempo se puede ahorrar** al usar este framework.
- La comunidad de Vue es **contundente**, debido a su gran número de desarrolladores esparcidos a través de todo el mundo, se puede encontrar todo tipo de ayuda, tutoriales, recursos y liberías en buena calidad. Además Vue ofrece un Foro y Chat oficiales que son bastante activos.
- Conocemos (y usamos) otros de los grandes frameworks como [Angular](https://angular.io/) y [React](https://reactjs.org/), el caso de **Angular** es especialmente llamativo, porque mantiene una excelente sinergia con **NET**. Pero no nos arrepentimos de la decisión de usar Vue, es un framework bastante completo.

### Routing y SPA ###

Como mencionamos anteriormente la aplicación tiene 3 tipos de Usuario: *Administrador*, *Empleado* y *Supervisor*.
Para cada usuario, el sistema (despúes de que el usuario ingrese) le retornará una **Single Page Application (SPA)**, de esta manerá cada usuario solo recibirá las funcionalidades que le pertenecen.

<div align="center">
 <img src="https://user-images.githubusercontent.com/9372893/40868971-e77af7fa-65d8-11e8-8db0-38bbf26c7604.png" height="400">
</div>

Los *Single Page Applications* son usados en la actualidad con mucha frecuencia, pero una desventaja es que el tiempo de carga podría llegar a ser elevado, por lo cual el uso de técnicas como el *Server Side Rendering* es siempre recomendado.

### Otros ###

- **Base De Datos**: Microsoft SQL Server
- **Plataforma de Despliegue**: Heroku
- **Generador de Bundles**: Browserify
- **Ejecutor de Tareas**: Gulp
