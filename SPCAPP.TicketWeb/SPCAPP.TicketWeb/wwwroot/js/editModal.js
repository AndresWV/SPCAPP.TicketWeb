$("#trbReaVist").load("/Avances/trbRealizadoVista");
$("#passVist").load("/Avances/passwordVista");
$("#avancesVist").load("/Avances/AvancesVista");


$.get("/TicketSpc/GetTicket", function (ticket) {
    console.log(ticket);
    /*Con esto dejo setiado la opcion del contacto seleccionado*/
    $.get("/TicketSpc/GetNombresClientesNom", { term: ticket.empresa }, function (dataMedios) {
        $("#aliEdit").val(dataMedios[0].nomAux);
        $("#aliEdit").focus();
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
    $.get("/TicketSpc/GetMContacto", function (mcontactosLista) {
        var opt = '';
        for (var i = 0; i < mcontactosLista.length; i++) {
            var option = document.createElement("option"); //Creas el elemento opción
            $(option).html(mcontactosLista[i].medio1); //Escribes en él el nombre de la provincia
            $(option).appendTo("#mediooEdit"); //Lo metes en el select con id provincias
            if (mcontactosLista[i].medio1 == ticket.modo) {
                opt = $(option).html(mcontactosLista[i].medio1);
            }
        }
        $("#mediooEdit").val(opt[0].label);
    });
    $.get("/TicketSpc/GetTSoporte", function (soportes) {
        var opt = '';
        for (var i = 0; i < soportes.length; i++) {
            var option = document.createElement("option"); //Creas el elemento opción
            $(option).html(soportes[i].tipoDes); //Escribes en él el nombre de la provincia
            $(option).appendTo("#supp"); //Lo metes en el select con id provincias
            if (soportes[i].tipoDes == ticket.tipo) {
                opt = $(option).html(soportes[i].tipoDes);
            }
        }
        $("#supp").val(opt[0].label);
    });
    $.get("/TicketSpc/GetTecnico", function (tecnicos) {
        var opt = '';
        console.log(tecnicos);
        for (var i = 0; i < tecnicos.length; i++) {
            var option = document.createElement("option"); 
            $(option).html(tecnicos[i].tecnicoNom);
            $(option).appendTo("#asignadoo"); 
            if (tecnicos[i].tecnicoNom == ticket.userCreaTk) {
                opt = $(option).html(tecnicos[i].tecnicoNom);
            }
        }
        $("#asignadoo").val(opt[0].label);
    });
});


