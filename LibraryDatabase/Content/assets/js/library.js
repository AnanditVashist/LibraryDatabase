$(document).ready(function(){
    initHandlers();
});

function searchBooks(alphabet){
    var selector = 'input[data-type="search"]';
    $(selector).val(alphabet);
    $(selector).focus();
    sendEnterToInput();
}

function sendEnterToInput(){
    var e = jQuery.Event("keyup");
    e.which = 13; 
    e.keyCode = 13;
    $('input[data-type="search"]').trigger(e);
}

function showBookDetail(bookIndex) {
    //var books = JSON.parse(books);
    //console.log(books);
    //var template = $('#bookDetailsTemplate').html();
    //var templateScript = Handlebars.compile(template);
    //var html = templateScript(books[2]);
    //$("#bookDetail").append(html);
    //$("#booknames").hide();
    //$("#bookDetail").show();
    $("#selectedBook").val(bookIndex);
    $("#bookDetailForm").submit();
}

function initHandlers(){
    bindResetHandler();
    bindSearchHandler();
}

function bindResetHandler(){
    $("#reset").on("click", function(){
        location.reload(true) ;
    })
}

function bindSearchHandler(){
    $('input[data-type="search"]').on('keyup', function(){
        $("#booknames").show();
        $("#bookDetail").empty();
    });
}

