// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(async () => {
    var resp = await fetch('https://localhost:44310/api/Books'); console.log(resp); $('#getBooks').val(await resp.json())

    
    var cbFunction = async function(resp) {
        console.log("Processing fetch");
        var text = await resp.json();
        alert(text);
    }

    fetch('https://localhost:44310/api/Books').then(cbFunction);
    console.log("Processing 1");
    console.log("Processing 2");

}); 

