// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
const init = function () {
    let audio = document.getElementById("deadSilence");
    audio.volume = 0.01;
    let titles = document.querySelectorAll(".fadeIn p");
    let time = 0;
    titles.forEach(element => {
        element.style.animationDelay = time + "s";
        time += 1;
    });
}
document.addEventListener("DOMContentLoaded", init);