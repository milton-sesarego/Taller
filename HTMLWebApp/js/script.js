$(document).ready(function () {
    $("#btnGuardar").click(function () {
        if ($("#txtNombre").val() == '') {
            alert("Debe ingresar un Nombre");
            return;
        }
        if ($("#txtDescripcion").val() == '') {
            alert("Debe ingresar una Descripción");
            return;
        }
        if ($("#txtPrecio").val() == '' ){
            alert("Debe ingresar un Precio");
            return;
        } else if ($("#txtPrecio").val() < 0){
            alert("El Precio debe ser mayor a 0");
            return;
        }
        if ($("#txtStock").val() == '') {
            alert("Debe ingresar un Stock");
            return;
        } else if ($("#txtStock").val() < 0) {
            alert("El Stock debe ser mayor a 0");
            return;
        }

        alert("Se ha creado el nuevo registro");
    });
});