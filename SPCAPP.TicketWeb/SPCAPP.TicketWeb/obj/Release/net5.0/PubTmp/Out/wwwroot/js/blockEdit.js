function blockEdit() {
    $("#horaEdit2").prop('disabled', true);
    $("#fechaEdit2").prop('disabled', true);
    $("#estadoEdit2").prop('disabled', true);
    $("#clt2").prop('disabled', true);
    $("#aliEdit2").prop('disabled', true);
    $("#emailEm2").prop('disabled', true);
    $("#contEdit2").prop('disabled', true);
    $("#mediooEdit2").prop('disabled', true);
    $("#atrabj2").prop('disabled', true);
    $("#supp2").prop('disabled', true);
    $("#asignadoo2").prop('disabled', true);
    $("#textAreaEdit2").prop('disabled', true);
    $("#supp2").prop('disabled', true);
    $("#btnEdit2").prop('hidden', true);
}
function blockAvances() {
    $("#avancesSele").prop('disabled', true);
    $("#trjProgramadoSele").prop('disabled', true);
    $("#trabjoDate").prop('disabled', true);
    $("#avancesDesc").prop('disabled', true);
}
function blockRealizado() {
    $("#trjR").prop('disabled', true);
    $("#ot").prop('disabled', true);
    $("#tw").prop('disabled', true);
    $("#nOrden").prop('disabled', true);
    $("#dateTrabRlz").prop('disabled', true);
    $("#hraIni").prop('disabled', true);
    $("#hraTerm").prop('disabled', true);
    $("#visitaCheck").prop('disabled', true);
    $("#remotoCheck").prop('disabled', true);
    $("#tallerCheck").prop('disabled', true);
    $("#telCheck").prop('disabled', true);
    $("#trabaRejoDesc").prop('disabled', true);
    $("#asignadoo2").prop('disabled', true);
    $("#telCheck").prop('disabled', true);
    $("#telCheck").prop('disabled', true);
}
function blockGastos() {
    $("#gastosSelect").prop('hidden', true);
    $("#cantidad").prop('hidden', true);
    $("#precioGasto").prop('hidden', true);
    $("#addGastoo").prop('hidden', true);
}
/*SE USA PARA RECICLAR LA VENTANA DE EDIT, PERO COMO ES SOLO VISTA, SE BLOQUEAN LOS CAMPOS PARA QUE EL USUARIO NO PUEDA EDITARLO*/
/*TAB TRABAJO REALIZADO*/
blockRealizado();
/*TAB EDIT*/
blockEdit();
/*TAB avances*/
blockAvances();
/*TAB PASSWORDS*/
$("#passwordDesc").prop('disabled', true);
/*ADD GASTO BLOCK*/
blockGastos();
