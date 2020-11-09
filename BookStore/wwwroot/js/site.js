// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(async () => {
    var resp = await fetch('https://localhost:44310/api/Books'); console.log(resp); $('#getBooks').val(await resp.json())

    
    var cbFunction = async function(resp) {
        console.log("Processing fetch");
        var text = await resp.json();
    }

    fetch('https://localhost:44310/api/Books').then(cbFunction);
    console.log("Processing 1");
    console.log("Processing 2");

}); 


// Carousel for General page
//with jQuery
	 //  $(document).ready(function(){
  //   $('.carousel').carousel();
  // });


	  // Send 
$(document).ready(function(){
	$('#button').click(function(){
		$.getJSON('/api/Books/GetBookList', {} , function(json){
			$('#bookName')[0].innerText = json[0].name;
		});
	});
});