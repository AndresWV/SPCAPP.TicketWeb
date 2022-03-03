
if ($("#ide").val() != null) {
    
    $.get("/TicketSpc/GetTicket", { idd: $("#ide").val() }, function (ticket) {
        console.log(ticket);
        $("#nOrden").val(ticket.id);
        $("#nOrden").focus();
        $.get("/TicketSpc/GetContactos", { term: ticket.codAux }, function (empresaD) {
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
}

$.get("/TicketSpc/GetTicket", function (ticket) {
    /*Con esto dejo setiado la opcion del contacto seleccionado*/
    $.get("/TicketSpc/GetNombresClientesNom", { term: ticket.empresa }, function (dataMedios) {
        $("#aliEdit").val(dataMedios[0].nomAux);
        $("#aliEdit").focus();
       
        
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
        for (var i = 0; i < tecnicos.length; i++) {
            var option = document.createElement("option"); 
            $(option).html(tecnicos[i].tecnicoNom);
            $(option).appendTo("#asignadoo");
            $(option).appendTo("#asignadoo2");
            if (tecnicos[i].tecnicoNom == ticket.userCreaTk) {
                opt = $(option).html(tecnicos[i].tecnicoNom);
            }
        }
        $("#asignadoo").val(opt[0].label);
    });

});
/*FUNCION PARA CONTROLAR CUANDO SE CHECKEA LOS CAMPOS DE LA VISTA AVANCES*/
function checkAvances(op) {
    if ($("#trjProgramadoSele").val()) {
        $("#programadoCheck").val("S");
    } if(op==1){
        $("#programadoCheck").val("N");
    }
}
function checkTrbRealizado(idCampo, idGuardado, op) {
    let checks = ["#visitaCheck", "#remotoCheck", "#tallerCheck", "#telCheck"];
    if ($(idGuardado).val() == "S") {
        for (var i = 0; i < checks.length; i++) {
            $(checks[i]).attr("disabled", false);
        }
        $(idGuardado).val("N")
    } else {
        if ($(idCampo).val()) {
            if (op == 1) {
                $(idGuardado).val("N");
            }
            else {
                $(idGuardado).val("S");
                if (idCampo == "#visitaCheck" || idCampo == "#remotoCheck" || idCampo == "#tallerCheck" || idCampo == "#telCheck") {
                    for (var i = 0; i < checks.length; i++) {
                        if (checks[i] != idCampo) {
                            $(checks[i]).attr("disabled", true);
                        }
                    }
                }
            }
        }
    }
}

function gastosAdd() {
    $("#gastosVista").load("/Avances/gastos");
    $("#gastosVista").show();
    //Traer gastos
    $.get("/TicketSpc/GetGastos", function (dataAsignados) {
        for (var i = 0; i < dataAsignados.length; i++) {
            var option = document.createElement("option"); //Creas el elemento opción
            $(option).html(dataAsignados[i].desGasto); //Escribes en él el nombre de la provincia
            $(option).appendTo("#gastosSelect"); //Lo metes en el select con id provincias
        }
    });
}
function tablaGas(idd) {
    $("#tablaGastos").load("/Avances/TablaGastos", {idd:idd});
    $("#tablaGastos").show();
}
function cargarGastos(idd) {
    gastosAdd();
    tablaGas(idd);
}
