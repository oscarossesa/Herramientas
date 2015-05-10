//var rutaUrl = 'http://desarrollo2:8080/servicios/v1/privado/GeoCgr/RegistroGeoReferencia.jsonp?ticket=D6DF9A69-2F0E-482E-B1F4-55A234C8193F'
//var urlAPI = 'http://apiqa.mercadopublico.cl/servicios/v1/privado/GeoCgr/RegistroGeoReferencia.json?ticket=D6DF9A69-2F0E-482E-B1F4-55A234C8193F'

var ticket = "78D4FEE6-7D6B-4EE6-85A8-6B272E237AC1";

var config = '{ "Urls" : [' +
'{ "Web":"api1" , "Url":"http://api1.mercadopublico.cl/servicios/v1/privado/GeoCgr/RegistroGeoReferencia.json?ticket=78D4FEE6-7D6B-4EE6-85A8-6B272E237AC1" },' +
'{ "Web":"api2" , "Url":"http://api2.mercadopublico.cl/servicios/v1/privado/GeoCgr/RegistroGeoReferencia.json?ticket=78D4FEE6-7D6B-4EE6-85A8-6B272E237AC1" },' +
'{ "Web":"api3" , "Url":"http://api3.mercadopublico.cl/servicios/v1/privado/GeoCgr/RegistroGeoReferencia.json?ticket=78D4FEE6-7D6B-4EE6-85A8-6B272E237AC1" },' +
'{ "Web":"api4" , "Url":"http://api4.mercadopublico.cl/servicios/v1/privado/GeoCgr/RegistroGeoReferencia.json?ticket=78D4FEE6-7D6B-4EE6-85A8-6B272E237AC1" },' +
'{ "Web":"api5" , "Url":"http://api5.mercadopublico.cl/servicios/v1/privado/GeoCgr/RegistroGeoReferencia.json?ticket=78D4FEE6-7D6B-4EE6-85A8-6B272E237AC1" },' +
'{ "Web":"api6" , "Url":"http://api6.mercadopublico.cl/servicios/v1/privado/GeoCgr/RegistroGeoReferencia.json?ticket=78D4FEE6-7D6B-4EE6-85A8-6B272E237AC1" } ]}';

var obj = JSON.parse(config);
var objRespuesta = [];

$(document).ready(function () {
    //$('.collapse').collapse();

    $.each(obj.Urls, function (key, value) {
        llamada(value.Web, value.Url);
    });
});

/*
* Prueba interna realizada por DCCP.
*/
function llamada(web, urlAPI) {
    var geoCgr = { licitacion: '500977-275-R114', llave: 'PeOH7j6Q%2BVq52aZplkl1tw%3D%3D', statusGeoCgr: 'test robles produccion' };
    var ajaxTime = new Date().getTime();
    $.ajax({
        url: urlAPI,
        type: "POST",
        data: JSON.stringify(geoCgr),
        dataType: "JSON",
        contentType: "application/json; charset=utf-8",
        crossdomain: true,
        success: function (result) {
            result.Servidor = web;
            result.Url = urlAPI;
            result.Estado = 'OK';

            objRespuesta.push(result);
            mostrarResultado(result);
        },
        error: function (xhr, status, error) {
            var objError = {};
            objError.Servidor = web;
            objError.Url = urlAPI;
            objError.Estado = status;

            objRespuesta.push(objError);
            mostrarResultado(objError);

            console.log(xhr);
            console.log(status);
            console.log(error);
        }
    }).done(function () {
        var totalTime = new Date().getTime() - ajaxTime;
        console.log(totalTime);
    });
}

function mostrarResultado(result) {
    $.ajax({
        url: "/Herramientas/Templates/ResultadoServicioRegistroGeoReferencia.html",
        dataType: 'html',
        async: false,
        cache: false,
        success: function (tmpl) {

            var template = Handlebars.compile(tmpl);
            var output = template(result);

            $('.contenedor').append(output);
        }
    });
}