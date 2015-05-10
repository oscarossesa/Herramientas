//$(document).ready(function() {
    
//});

jQuery.getProyectos = function (options) {
    alert('listado_proyectos.js');

        var defaults = {
            container: null,
            templates: {
                "listadoBase": "/Herramientas/Templates/ListadoProyectos.html"
            }, 
            context: {
                proyectos: [
                    {
                        id: "1",
                        nombre: "Nueva Home",
                        descripcion: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce condimentum vulputate diam ac tincidunt. Curabitur nec tristique urna. Integer luctus libero euismod nisl elementum maximus at nec ex. Duis in fermentum lacus. Etiam sit amet elementum nibh, at fermentum lacus. Pellentesque posuere fringilla volutpat. Curabitur nec blandit est. Vestibulum condimentum est non neque varius, quis condimentum neque ultrices. Maecenas ultricies sodales purus a porttitor. Donec tempor ultrices quam, a convallis nunc varius nec. Vestibulum ullamcorper quam a turpis pretium, eget lobortis tortor ultricies.",
                        sponsor: "Javier Saavedra",
                        impacto: "Medio",
                        riesgo: "Bajo",
                        complejidad: "Alta",
                        avance: "60",
                        jp: {
                            nombre: "Sebastian del Villar",
                            imagen: "sebastian_del_villar.jpg"
                        },
                        lt: {
                            nombre: "Oscar Osses",
                            imagen: "oscar_osses.jpg"
                        },
                        desarrolladores: [{
                            nombre: "Maximiliano Henrriquez",
                            imagen: "maximiliano_henriquez.png"
                        }, {
                            nombre: "Pedro Barreaux",
                            imagen: "pedro_barreaux.jpg"
                        }]
                    },
                    {
                        id: "2",
                        nombre: "Servicio al Usuario",
                        descripcion: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce condimentum vulputate diam ac tincidunt. Curabitur nec tristique urna. Integer luctus libero euismod nisl elementum maximus at nec ex. Duis in fermentum lacus. Etiam sit amet elementum nibh, at fermentum lacus. Pellentesque posuere fringilla volutpat. Curabitur nec blandit est. Vestibulum condimentum est non neque varius, quis condimentum neque ultrices. Maecenas ultricies sodales purus a porttitor. Donec tempor ultrices quam, a convallis nunc varius nec. Vestibulum ullamcorper quam a turpis pretium, eget lobortis tortor ultricies.",
                        sponsor: "No definido",
                        impacto: "Medio",
                        riesgo: "Bajo",
                        complejidad: "Alta",
                        avance: "10",
                        jp: {
                            nombre: "Alex Aedo",
                            imagen: "alex_aedo.jpg"
                        },
                        lt: {
                            nombre: "Andres Castro",
                            imagen: "andres_castro.jpg"
                        },
                        desarrolladores: [{
                            nombre: "Michael García",
                            imagen: "seidor.png"
                        }, {
                            nombre: "Juan Peña",
                            imagen: "juan_pena.jpg"
                        }]
                    },
                    {
                        id: "3",
                        nombre: "Nuevo ChileCompra",
                        descripcion: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce condimentum vulputate diam ac tincidunt. Curabitur nec tristique urna. Integer luctus libero euismod nisl elementum maximus at nec ex. Duis in fermentum lacus. Etiam sit amet elementum nibh, at fermentum lacus. Pellentesque posuere fringilla volutpat. Curabitur nec blandit est. Vestibulum condimentum est non neque varius, quis condimentum neque ultrices. Maecenas ultricies sodales purus a porttitor. Donec tempor ultrices quam, a convallis nunc varius nec. Vestibulum ullamcorper quam a turpis pretium, eget lobortis tortor ultricies.",
                        sponsor: "No definido",
                        impacto: "Medio",
                        riesgo: "Bajo",
                        complejidad: "Alta",
                        avance: "60",
                        jp: {
                            nombre: "Alvaro Cañon",
                            imagen: "alvaro_canon.jpg"
                        },
                        lt: {
                            nombre: "Andres Castro",
                            imagen: "andres_castro.jpg"
                        },
                        desarrolladores: []
                    },
                    {
                        id: "4", nombre: "Sigfe 2",
                        descripcion: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce condimentum vulputate diam ac tincidunt. Curabitur nec tristique urna. Integer luctus libero euismod nisl elementum maximus at nec ex. Duis in fermentum lacus. Etiam sit amet elementum nibh, at fermentum lacus. Pellentesque posuere fringilla volutpat. Curabitur nec blandit est. Vestibulum condimentum est non neque varius, quis condimentum neque ultrices. Maecenas ultricies sodales purus a porttitor. Donec tempor ultrices quam, a convallis nunc varius nec. Vestibulum ullamcorper quam a turpis pretium, eget lobortis tortor ultricies.",
                        sponsor: "No definido",
                        impacto: "Medio",
                        riesgo: "Bajo",
                        complejidad: "Alta",
                        avance: "60",
                        jp: {
                            nombre: "Rodrigo Robles",
                            imagen: "rodrigo_robles.jpg"
                        },
                        lt: {
                            nombre: "Fabian Luco",
                            imagen: "fabian_luco.jpg"
                        },
                        desarrolladores: []
                    },
                    {
                        id: "5",
                        nombre: "Ley del Lobby",
                        descripcion: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce condimentum vulputate diam ac tincidunt. Curabitur nec tristique urna. Integer luctus libero euismod nisl elementum maximus at nec ex. Duis in fermentum lacus. Etiam sit amet elementum nibh, at fermentum lacus. Pellentesque posuere fringilla volutpat. Curabitur nec blandit est. Vestibulum condimentum est non neque varius, quis condimentum neque ultrices. Maecenas ultricies sodales purus a porttitor. Donec tempor ultrices quam, a convallis nunc varius nec. Vestibulum ullamcorper quam a turpis pretium, eget lobortis tortor ultricies.",
                        sponsor: "No definido",
                        impacto: "Medio",
                        riesgo: "Bajo",
                        complejidad: "Alta",
                        avance: "100",
                        jp: {
                            nombre: "Alejandro Gonzalez",
                            imagen: "alejandro_gonzalez.jpg"
                        },
                        lt: {
                            nombre: "Fabian Luco",
                            imagen: "fabian_luco.jpg"
                        },
                        desarrolladores: [{
                            nombre: "Michael García",
                            imagen: "seidor.png"
                        }]
                    },
                    {
                        id: "6",
                        nombre: "Plan de Compras Fase 2",
                        descripcion: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce condimentum vulputate diam ac tincidunt. Curabitur nec tristique urna. Integer luctus libero euismod nisl elementum maximus at nec ex. Duis in fermentum lacus. Etiam sit amet elementum nibh, at fermentum lacus. Pellentesque posuere fringilla volutpat. Curabitur nec blandit est. Vestibulum condimentum est non neque varius, quis condimentum neque ultrices. Maecenas ultricies sodales purus a porttitor. Donec tempor ultrices quam, a convallis nunc varius nec. Vestibulum ullamcorper quam a turpis pretium, eget lobortis tortor ultricies.",
                        sponsor: "No definido",
                        impacto: "Medio",
                        riesgo: "Bajo",
                        complejidad: "Alta",
                        avance: "60",
                        jp: {
                            nombre: "Daniel Marambio",
                            imagen: "daniel_marambio.jpg"
                        },
                        lt: {
                            nombre: "Jose Ortega",
                            imagen: "jose_ortega.jpg"
                        },
                        desarrolladores: []
                    },
                    {
                        id: "7",
                        nombre: "Migración de ChilePaga (ETL)",
                        descripcion: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce condimentum vulputate diam ac tincidunt. Curabitur nec tristique urna. Integer luctus libero euismod nisl elementum maximus at nec ex. Duis in fermentum lacus. Etiam sit amet elementum nibh, at fermentum lacus. Pellentesque posuere fringilla volutpat. Curabitur nec blandit est. Vestibulum condimentum est non neque varius, quis condimentum neque ultrices. Maecenas ultricies sodales purus a porttitor. Donec tempor ultrices quam, a convallis nunc varius nec. Vestibulum ullamcorper quam a turpis pretium, eget lobortis tortor ultricies.",
                        sponsor: "No definido",
                        impacto: "Medio",
                        riesgo: "Bajo",
                        complejidad: "Alta",
                        avance: "60",
                        jp: {
                            nombre: "Sebastián del Villar",
                            imagen: "sebastian_del_villar.jpg"
                        },
                        lt: {
                            nombre: "Andres Castro",
                            imagen: "andres_castro.jpg"
                        },
                        desarrolladores: [{
                            nombre: "José Bascuñan",
                            imagen: "jose_bascunan.jpg"
                        }]
                    },
                    {
                        id: "8",
                        nombre: "Migración de ChilePaga (Sitio Web)",
                        descripcion: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce condimentum vulputate diam ac tincidunt. Curabitur nec tristique urna. Integer luctus libero euismod nisl elementum maximus at nec ex. Duis in fermentum lacus. Etiam sit amet elementum nibh, at fermentum lacus. Pellentesque posuere fringilla volutpat. Curabitur nec blandit est. Vestibulum condimentum est non neque varius, quis condimentum neque ultrices. Maecenas ultricies sodales purus a porttitor. Donec tempor ultrices quam, a convallis nunc varius nec. Vestibulum ullamcorper quam a turpis pretium, eget lobortis tortor ultricies.",
                        sponsor: "No definido",
                        impacto: "Medio",
                        riesgo: "Bajo",
                        complejidad: "Alta",
                        avance: "60",
                        jp: {
                            nombre: "Sebastián del Villar",
                            imagen: "sebastian_del_villar.jpg"
                        },
                        lt: {
                            nombre: "Oscar Osses",
                            imagen: "oscar_osses.jpg"
                        },
                        desarrolladores: [{
                            nombre: "Michael García",
                            imagen: "seidor.png"
                        }, {
                            nombre: "Pedro Barreaux",
                            imagen: "pedro_barreaux.jpg"
                        }, {
                            nombre: "Juan Licanqueo",
                            imagen: "juan_licanqueo.jpg"
                        }, {
                            nombre: "Maximiliano Henrriquez",
                            imagen: "maximiliano_henriquez.png"
                        }]
                    }
                ]
            }
        };

        var config = $.extend(defaults, options);    

        //Se obtiene el template para el listado de proyectos
        $.ajax({
            url: config.templates.listadoBase,
            dataType: 'html',
            async: false,
            cache: false,
            success: function (tmpl) {
                //var template = Handlebars.compile(tmpl);
                //var output = template(config.context);
                //$(config.container).append(output);

                var templateHtml = $("ProyectosTemplate").html();
                var sourceHtml = Handlebars.compile(templateHtml);

                $("#contenedorProyectos").html(sourceHtml);
            }
        });
    };


