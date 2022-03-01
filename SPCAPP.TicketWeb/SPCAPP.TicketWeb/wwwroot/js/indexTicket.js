document.getElementById("defaultOpen").click();
function addGasto() {
    var gasto = $("#gastosSelect").val();
    var cantidad = $("#cantidad").val();
    var precio = $("#precioGasto").val();
    $.post("/Gastos/CreateGasto", { gasto: gasto, cantidad: cantidad, precio: precio })
}

function openTabs(evt, cityName, id, op) {
    $("#trbReaVist").load("/Avances/trbRealizadoVista", { idd: id });
    $("#trbReaVist2").load("/Avances/trbRealizadoVistaBlock", { idd: id });
   
    $("#passVist").load("/Avances/passwordVista", { idd: id });
    $("#passVist2").load("/Avances/passwordVistaBlock");
    /*$("#gastosVista").load("/Avances/gasto");*/
    $("#avancesVist").load("/Avances/AvancesVista", { idd: id });
    $("#avancesVist2").load("/Avances/AvancesVistaBlock", { idd: id });
    trbRealizadoScript();
    
    // Declare all variables
    var i, tabcontent, tablinks;

    // Get all elements with class="tabcontent" and hide them
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    // Get all elements with class="tablinks" and remove the class "active"
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
        
    }

    // Show the current tab, and add an "active" class to the button that opened the tab
    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " active";
}

function trbRealizadoScript() {
    var x = $("#ide").val()
    $.get("/TicketSpc/GetTicket", { idd: x }, function (ticket) {
        $.get("/Avances/areaEmpresa", { codaux: ticket.id }, function (areaEmpresas) {
            var opt = '';
            for (var i = 0; i < areaEmpresas.length; i++) {
                var option = document.createElement("option"); //Creas el elemento opción
                $(option).html(areaEmpresas[i]); //Escribes en él el nombre de la provincia
                $(option).appendTo("#aTrabajo");
                if (areaEmpresas[i] == ticket.fk_procede) {
                    opt = $(option).html(areaEmpresas[i]);
                }
            }
            $("#aTrabajo").val(opt[0].label);
        });
        $.get("/TicketSpc/GetNombresClientesNom", { term: ticket.empresa }, function (data) {
            $("#aliEdit").val(data[0].nomAux)
            $("#aliEdit").focus();
            $.get("/TicketSpc/GetContactos", { term: ticket.codAux }, function (dataContacto) {
                var medioSet = null;
                for (var i = 0; i < dataContacto.length; i++) {
                    var option = document.createElement("option"); //Creas el elemento opción
                    $(option).html(dataContacto[i].nomCon); //Escribes en él el nombre de la provincia
                    $(option).appendTo("#contEdit"); //Lo metes en el select con id provincias
                    if (dataContacto[i].nomCon == ticket.contacto) {
                        medioSet = dataContacto[i].nomCon
                    }
                }
                $("#contEdit").val(medioSet);
            });
            /*SELECT QUE ESTA AL LADO DEL BUTTON DE GASTOS EN EL TAB TRABAJOS REALIZADOS*/
            $.get("/TicketSpc/GetTecnico", function (tecnicos) {
                var opt = '';
                var opterminado = '';
                for (var i = 0; i < tecnicos.length; i++) {
                    var option = document.createElement("option");
                    $(option).html(tecnicos[i].tecnicoNom);
                    $(option).appendTo("#asignadoo");
                    if (tecnicos[i].tecnicoNom == ticket.tecnico) {
                        opt = tecnicos[i].tecnicoNom;
                    }
                }
                $("#asignadoo").val(opt);
            });
            $.get("/TicketSpc/GetTecnico", function (tecnicos) {
                var opt = '';
                var opterminado = '';
                for (var i = 0; i < tecnicos.length; i++) {
                    var option = document.createElement("option");
                    $(option).html(tecnicos[i].tecnicoNom);
                    $(option).appendTo("#asignadoo2");
                    if (tecnicos[i].tecnicoNom == ticket.terminadoPor) {
                        opt = tecnicos[i].tecnicoNom;
                    }
                }
                $("#asignadoo2").val(opt);
            });
        });
        /*INICIAR EL MEDIO DE CONTACTO, CON EL QUE FUE ELEGIDO CUANDO SE CREO EL TICKET*/
        $.get("/TicketSpc/GetMContacto", function (dataMedios) {
            var medioSet = null;
            for (var i = 0; i < dataMedios.length; i++) {
                var option = document.createElement("option"); //Creas el elemento opción
                $(option).html(dataMedios[i].medio1); //Escribes en él el nombre de la provincia
                $(option).appendTo("#mediooEdit"); //Lo metes en el select con id provincias
                if (dataMedios[i].medio1 == ticket.modo) {
                    medioSet = dataMedios[i].medio1
                }
            }
            $("#mediooEdit").val(medioSet);
        });
        /*INICIAR EL TIPO DE SOPORTE, CON EL QUE FUE ELEGIDO CUANDO SE CREO EL TICKET*/
        $.get("/TicketSpc/GetTSoporte", function (dataSoporte) {
            var medioSet = null;
            for (var i = 0; i < dataSoporte.length; i++) {
                var option = document.createElement("option"); //Creas el elemento opción
                $(option).html(dataSoporte[i].tipoDes); //Escribes en él el nombre de la provincia
                $(option).appendTo("#supp"); //Lo metes en el select con id provincias
                if (dataSoporte[i].tipoDes == ticket.tipo) {
                    medioSet = dataSoporte[i].tipoDes;
                }
            }
            $("#supp").val(medioSet);
        });

        /*FECHA AVANCES*/
        $("#trabjoDate").val(ticket.fechaTrabajo);
        /*SETEAR TEXTAREA DE AVANCES*/
        $("#avancesDesc").val(ticket.avance)
        /*SETEAR CHECKBOX PROGRAMADO*/
        if (ticket.programado == "N") { $("#trjProgramado").val("N") }
        else { $("#trjProgramado").val("S")}

        /*SETEAR TEXTAREA DE PASSWORD*/
        $("#passwordDesc").val(ticket.passwords)

        /*SETEAR TEXTAREA DE TRABAJO REALIZADO*/
        $("#trabaRejoDesc").val(ticket.trabajo);
       

        /*FECHA DE CIERRE*/
        //separar fecha de la hora
        if (ticket.fechaCierre != null) {
            var z = ticket.fechaCierre.split("T");
            $("#dateTrabRlz").val(z[0]);
        }
        /*HORA DE INCIO Y TEMRINO*/
        if (ticket.hrsInicio!=null) {
            $("#hraIni").val(ticket.hrsInicio.split("T")[1]);
        }
        if (ticket.hrsTermino!=null) {
            $("#hraTerm").val(ticket.hrsTermino.split("T")[1]);
        }
    });
}
function seleccionarVista(id) {
    $("#avancesDiv").hide();
    $("#passwordDiv").hide();
    $("#trbjRealizado").hide();
    var idd = "#" + id;
    $("#contenedorVistas").show();
    $(idd).show();
}
//Cargar los script como al abrir el modal no se estaban cargando debido a que al abrir una ventana emergente
//no se vuelven a llamar
function cargarScript() {
    //modal
    var s = document.createElement("script");
    s.type = "text/javascript";
    s.src = "/js/modal.js";
    $("head").append(s);
    //mdb input
    var s2 = document.createElement("script");
    s2.type = "text/javascript";
    s2.src = "/js/lineasInput.js";
    $("head").append(s2);
    //calendario
    var s3 = document.createElement("script");
    s3.type = "text/javascript";
    s3.src = "/js/calendarBack.js";
    $("head").append(s3);
    //edit
    var s3 = document.createElement("script");
    s3.type = "text/javascript";
    s3.src = "/js/editModal.js";
    $("head").append(s3);

    $('#modalCreate').modal("show");
    
}
//Controlar que modal se abrira
function crearModal(buttonOption, idd, blockInput) {
    //Crear ticket
    
    if (buttonOption == 1) {
        $("#modalCreate").load("/TicketSpc/Create", function () {
            cargarScript();
        });
    }
    //ver ticket
    else if (buttonOption == 2) {
        $("#modalCreate").load("/TicketSpc/View", { id : idd} ,function () {
            cargarScript();
        });
    }
    //Editat ticket
    else if (buttonOption == 3) {
        $("#modalCreate").load("/TicketSpc/Edit", { id: idd }, function () {
            cargarScript();
        });
    }
    //Eliminar ticket
    else {
        $("#modalCreate").load("/TicketSpc/Delete", { id: idd }, function () {
            cargarScript(4);
        });
    }
}