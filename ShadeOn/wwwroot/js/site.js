// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var searchIcon = document.querySelector('.fa-search');
var closeIcon = document.querySelector('.fa-times');
var search = document.getElementById('search');

searchIcon.onclick = () => {
	search.classList.add('expand');
}
closeIcon.onclick = () => {
	search.classList.remove('expand');
}

var button = document.querySelector('.navbar-button');
var menu = document.querySelector('.nav-menu');
button.onclick = () => {
	menu.classList.toggle('expand-mobile');
	button.classList.toggle('expand-icon');

}