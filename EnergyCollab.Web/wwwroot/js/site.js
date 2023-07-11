// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
  

function search() {

    var obj_data = {
        Country:"",
        CountryCode: $('#CountryCode').val(),
        SearchPhrase: $('#inputSearchPhrase').val(),
        OrderBy: $('#inputOrderBy').val()

    };
    debugger;
    var searchPhase = $('#inputSearchPhrase').val()
    
    $.ajax({
        url: '/JobSeeker/FilterQuickJobSearch',
        type: 'POST',
        data:JSON.stringify(obj_data),
        contentType: 'application/json',
            success: function (result) {
                $('#jobResults').html(result);
            },
            error: function (xhr,txtStatus,errorThrown) {
                alert('An error occurred while updating the partial view.');
            }
        });
    
}
        
