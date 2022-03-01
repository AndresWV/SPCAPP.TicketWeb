/*INICIAR CON LA FECHA Y HORA ACTUALES*/
var now = new Date(Date.now());
var formatted = now.getHours() + ":" + now.getMinutes();
$("#horaInicioCreate").val(formatted);

var day = ("0" + now.getDate()).slice(-2);
var month = ("0" + (now.getMonth() + 1)).slice(-2);
var today = now.getFullYear() + "-" + (month) + "-" + (day);
$('#fechaCreate').val(today);


//Metodo para controlar el autocompletado del text input CLIENTE
$(document).ready(function () {
   
    $("#clt").autocomplete({
        source: '/TicketSpc/GetNombresClientes',
    minlength: 1,
    position: { my: "left bottom", at: "left bottom" },
    delay: 300,
        open: function () {
            $("ul.ui-menu").width($(document.getElementById("#clt")).innerWidth());
    },
    classes: {
        "ui-autocomplete": "highlig"
    },
    //Cuando seleccione un elemento del menu desplegable...
    select: function (event, ui) {
        $.get("/TicketSpc/GetNombresClientesNom", { term: ui.item.value }, function (dataNom) {
            //tomar datos en base al cliente seleccionado por el autocompletado
            $.get("/TicketSpc/GetAlias", { term: dataNom[0].nomAux }, function (data) {
                $(".result").html(data);
                //cambiar código
                $("#cod").val("" + data.codAux);
                $('#cod').focus();
                //cambiar folio
                $("#folio").val("" + data.comAux);
                $('#folio').focus();
                //cambiar alias
                $("#ali").val("" + data.noFaux);
                $('#ali').focus();
                //cambiar email empresa
                $("#emailEm").val("" + data.eMailDte);
                $('#emailEm').focus();
                //cargar contactos para el select contacto
                $.get("/TicketSpc/GetContactos", { term: data.codAux }, function (data2) {
                    
                    for (var i = 0; i < data2.length; i++) {
                        var option = document.createElement("option"); //Creas el elemento opción
                        $(option).html(data2[i].nomCon); //Escribes en él el nombre de la provincia
                        $(option).appendTo("#cont"); //Lo metes en el select con id provincias
                    }
                });
                //cargar datos en base al contacto seleccionado
                $("#cont").change(function () {
                    $.get("/TicketSpc/GetContacto", { term: $(this).val() }, function (dataContacto) {
                        //telefono1
                        if (dataContacto.fonCon != null) {
                            $("#telefono1").val("" + dataContacto.fonCon);

                        } else {
                            $("#telefono1").val("" + 0);
                        }
                        $('#telefono1').focus();
                        //telefono2
                        if (dataContacto.fonCon2 != null) {

                            $("#telefono2").val("" + dataContacto.fonCon2);

                        } else {
                            $("#telefono2").val("" + 0);
                        }
                        $('#telefono2').focus();
                        //telefono3
                        if (dataContacto.fonCon3 != null) {
                            $("#telefono3").val("" + dataContacto.fonCon3);

                        } else {
                            $("#telefono3").val("" + 0);
                        }
                        $('#telefono3').focus();
                        //cambiar email empresa
                        $("#email").val("" + dataContacto.email);
                        $('#email').focus();
                    });
                });
            });
        });
    }
});
});
//Traer datos select modo contacto
$.get("/TicketSpc/GetMContacto", function (dataMedios) {
    for (var i = 0; i < dataMedios.length; i++) {
        var option = document.createElement("option"); //Creas el elemento opción
        $(option).html(dataMedios[i].medio1); //Escribes en él el nombre de la provincia
        $(option).appendTo("#medioo"); //Lo metes en el select con id provincias
    }
});
//Traer los tipo de soporte
$.get("/TicketSpc/GetTSoporte", function (dataSoporte) {
    for (var i = 0; i < dataSoporte.length; i++) {
        var option = document.createElement("option"); //Creas el elemento opción
        $(option).html(dataSoporte[i].tipoDes); //Escribes en él el nombre de la provincia
        $(option).appendTo("#supp"); //Lo metes en el select con id provincias
    }
});
//Traer los tecnicos
$.get("/TicketSpc/GetTecnico", function (dataAsignados) {
    for (var i = 0; i < dataAsignados.length; i++) {
        var option = document.createElement("option"); //Creas el elemento opción
        $(option).html(dataAsignados[i].tecnicoNom); //Escribes en él el nombre de la provincia
        $(option).appendTo("#asignadoo"); //Lo metes en el select con id provincias
    }
});

function closeModal(id) {
    $("#modalCreate").modal('hide');
}