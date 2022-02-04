document.getElementById("defaultOpen").click();
function openTabs(evt, cityName) {
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
function crearModal(buttonOption, idd) {
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
            cargarScript();
        });
    }
}