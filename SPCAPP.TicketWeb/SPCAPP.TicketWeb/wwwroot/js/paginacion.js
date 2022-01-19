$(document).ready(function () {
   // var oTable = $('#dtBasicExample').DataTable({
       
   //});
    //oTable.order([[0, "desc"], [0, "desc"]]);
    //oTable.draw();

   // $('.dataTables_length').addClass('bs-select');
    //var currentDate = new Date();
    //var day = currentDate.getDate();
    //var month = currentDate.getMonth() + 1;
    //var year = currentDate.getFullYear();
    //var hour = currentDate.getHours();
    //var minute = currentDate.getMinutes();
    //var seconds = currentDate.getSeconds();

    var oTable = $('#dtBasicExample').DataTable({
        "language": {
            "sProcessing": "Procesando...",
            "sLengthMenu": "Mostrar _MENU_ registros",
            "sZeroRecords": "No se encontraron resultados",
            "sEmptyTable": "Ningún dato disponible en esta tabla",
            "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sInfoPostFix": "",
            "sSearch": "Buscar:",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "oAria": {
                "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                "sSortDescending": ": Activar para ordenar la columna de manera descendente"
            }
        },
        "emptyTable": "No data available in table",
        dom: 'Bfrtip',
        pageLength: 10,
        //"columnDefs": [
        //    {
        //        "targets": [0],
        //        "visible": false
        //    },
        //    {
        //        "targets": [7],
        //        "visible": false
        //    }
        //]
    });
    oTable.order([[0, "desc"], [0, "desc"]]);
    oTable.draw();
    $('#dtBasicExample').show();
    $('#load').hide();


});