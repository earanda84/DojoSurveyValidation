// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function Redirect(){

    return window.location.href = "http://localhost:5081"
}

// Se llama al elemento onclick para el caso el boton que realizará la acción de retornar a la url base
document.addEventListener('DOMContentLoaded', function () {
    document.getElementById('backBtn').onclick = function () {
        Redirect();
    };
});