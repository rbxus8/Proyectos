document.addEventListener("DOMContentLoaded", function () {
  const fotos = document.querySelectorAll(".pers_foto img");
  const imagenPrincipal = document.getElementById("imagen_principal");
  const nombre = document.getElementById("nombre");
  const cargo = document.getElementById("cargo");
  const bio = document.getElementById("bio");

  fotos.forEach((foto) => {
    foto.addEventListener("click", function () {
      const nombreTexto = this.getAttribute("data-nombre");
      const cargoTexto = this.getAttribute("data-cargo");
      const bioTexto = this.getAttribute("data-bio");

      // Cambia la imagen principal y muestra la información correspondiente
      imagenPrincipal.src = this.src;
      nombre.textContent = `Nombre: ${nombreTexto}`;
      cargo.textContent = `Cargo: ${cargoTexto}`;
      bio.textContent = `Descripción: ${bioTexto}`;
    });
  });
});
