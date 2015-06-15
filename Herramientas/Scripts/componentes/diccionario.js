$(document).ready(function () {
    console.log('diccionario.js');
    $.ajax({
        url: "http://localhost/herramientas/api/apidiccionario",
        type: "Get",
        success: function (data) {
            console.log(data);
            $.ajax({
                url: "/Herramientas/Templates/TemplateDiccionario.html",
                dataType: 'html',
                async: false,
                cache: false,
                success: function (tmpl) {
                    var template = Handlebars.compile(tmpl);
                    var output = template(data);
                    $('#content1').append(output);
                }
            });
        },
        error: function (msg) {
            alert(msg);
        }
    });
});