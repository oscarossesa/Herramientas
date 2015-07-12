$(document).ready(function () {
    //console.log('diccionario.js');
    $.ajax({
        url: "http://localhost/herramientas/api/apidiccionario",
        //url: "/api/apidiccionario",
        type: "Get",
        success: function (data) {
            //console.log(data);
            $.ajax({
                url: "/Herramientas/Templates/TemplateDiccionario.html",
                dataType: 'html',
                async: false,
                cache: false,
                success: function (tmpl) {
                    var template = Handlebars.compile(tmpl);
                    var output = template(data);
                    $('#content1').append(output);

                    //$('#table').dataTable();

                    //$('#table').dataTable({
                    //    "dom": 'T<"clear">lfrtip',
                    //    "tableTools": {
                    //        "sSwfPath": "../swf/copy_csv_xls_pdf.swf"
                    //    }
                    //});

                    $('#table').DataTable({
                        dom: 'T<"clear">lfrtip',
                        tableTools: {
                            "aButtons": [
                                "copy",
                                "csv",
                                "xls",
                                {
                                    "sExtends": "pdf",
                                    "sPdfOrientation": "landscape",
                                    "sPdfMessage": "Your custom message would go here."
                                },
                                "print"
                            ]
                        }
                    });
                }
            });
        },
        error: function (msg) {
            alert(msg);
        }
    });

    // JSON data
    //var chartDataUrl = '@Url.Action("tableJsonData", "Tables")';

    //// Initialize Example 1
    //$('#table').dataTable({
    //    "ajax": chartDataUrl
    //});

    // Initialize Example 2
    
    //$('#word').on('click', function () {
    //    $.ajax({
    //        type: "POST",
    //        url: 'http://localhost/herramientas/api/apidiccionario',
    //        contentType: "application/json; charset=utf-8",
    //        dataType: "json",
    //        success: function (response) {
    //            $("#Content").text(response.d);
    //        },
    //        failure: function (response) {
    //            alert(response.d);
    //        }
    //    });
    //});

    
});