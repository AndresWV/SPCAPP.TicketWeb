$("#trbReaVist").load("/Avances/trbRealizadoVista");
$("#passVist").load("/Avances/passwordVista");
$("#avancesVist").load("/Avances/AvancesVista");

/*Con esto dejo setiado la opcion del contacto seleccionado*/
$.get("/TicketSpc/GetTicket", function (ticket) {
    $.get("/TicketSpc/GetNombresClientesNom", { term: ticket.empresa }, function (dataMedios) {
        $.get("/TicketSpc/GetContactos", { term: dataMedios[0].codAux }, function (empresaD) {
            var opt = '';
            for (var i = 0; i < empresaD.length; i++) {
                var option = document.createElement("option"); //Creas el elemento opción
                $(option).html(empresaD[i].nomCon); //Escribes en él el nombre de la provincia
                $(option).appendTo("#contEdit"); //Lo metes en el select con id provincias
                if (empresaD[i].nomCon == ticket.contacto) {
                    opt = $(option).html(empresaD[i].nomCon);
                }
            } 
            $("#contEdit").val(opt[0].label);
        });
    });
});