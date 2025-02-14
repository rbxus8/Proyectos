  // Selecciona todas las imágenes dentro de los divs de la clase 'pers_foto'
  const fotos = document.querySelectorAll(".pers_foto img");
  const imagenPrincipal = document.getElementById("imagen_principal");

  // Agrega un evento de clic a cada imagen
  fotos.forEach((foto) => {
    foto.addEventListener("click", () => {
      // Cambia la imagen principal al hacer clic en una de las imágenes pequeñas
      imagenPrincipal.src = foto.src;
    });
  });