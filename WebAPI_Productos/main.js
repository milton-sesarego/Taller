var myURL = "http://localhost:6030/api/productos";

$(function () {
    actualizarGrilla();
    $('#btnGuardar').click(function () { guardarProducto(); });
    $('#btnEliminar').click(function () { borrarProducto(); });
    $('#btnCancelar').click(function () { limpiarControles(); });
    $('#btnGuardar').val("Nuevo");
});

function actualizarGrilla() {
    ajaxGET();
};

function ajaxGET() {
    $.ajax({
        url: myURL,
        type: 'GET',
        async: true
    }).done(function (data) {
        construyeGrilla(data);
    }).error(function (xhr, status, error) {
        alert(error);
        var s = status;
        var e = error;
    });
}

function ajaxPOST() {
    var obj = obtenerProducto();

    $.ajax({
        url: myURL,
        type: 'POST',
        async: true,
        data: { "Id": obj.Id, "Nombre": obj.Nombre, "Descripción": obj.Descripción, "Precio": obj.Precio, "Stock": obj.Stock }
    }).done(function (data) {
        alert('Elemento insertado')
    }).error(function (xhr, status, error) {
        alert(error);
        var s = status;
        var e = error;
    });
}

function ajaxPUT() {
    var obj = obtenerProducto();

    $.ajax({
        url: myURL,
        type: 'PUT',
        async: true,
        data: obj
    }).done(function (data) {
        alert('Elemento actualizado')
    }).error(function (xhr, status, error) {
        alert(error);
        var s = status;
        var e = error;
    });
}

function ajaxDELETE(id) {
    $.ajax({
        url: myURL + id,
        type: 'DELETE',
        async: true
    }).done(function (data) {
        alert('Elemento borrado')
    }).error(function (xhr, status, error) {
        alert(error);
        var s = status;
        var e = error;
    });
}

function construyeGrilla(data) {
    var grd = $('#grdProductos');
    grd.html("");
    var tbl = $('<table border=1></table>');


    var header = $('<tr></tr>');
    header.append('<td>Id</td>');
    header.append('<td>Nombre</td>');
    header.append('<td>Descripción</td>');
    header.append('<td>Precio</td>');
    header.append('<td>Stock</td>');

    tbl.append(header);


    for (d in data) {
        var row = $('<tr class="jqClickeable"></tr>');
        row.append('<td>' + data[d].Id + '</td>');
        row.append('<td>' + data[d].Nombre + '</td>');
        row.append('<td>' + data[d].Descripcion + '</td>');
        row.append('<td>' + data[d].Precio + '</td>');
        row.append('<td>' + data[d].Stock + '</td>');

        tbl.append(row);
    }

    grd.append(tbl);
    $('.jqClickeable').click(function () { mostrarElemento($(this)); });

}

function borrarProducto() {
    //var id = 0;
    //ajaxDELETE(id);
    actualizarGrilla();
    limpiarControles();
}

function guardarProducto() {
    var id = 0;
    if (id == 0) {
        ajaxPOST();
    }
    else {
        ajaxPUT();
    }
    actualizarGrilla();
    limpiarControles();
}

function mostrarElemento(elem) {
    $('#txtNombre').val(elem.children().eq(1).text());
    $('#txtDescripcion').val(elem.children().eq(2).text());
    $('#txtPrecio').val(elem.children().eq(3).text());
    $('#txtStock').val(elem.children().eq(4).text());
    $('#btnGuardar').val("Modificar");
}

function obtenerProducto() {
    var producto = {};
    producto.Id = 0;
    producto.Nombre = $('#txtNombre').val();
    producto.Descripción = $('#txtDescripcion').val();
    producto.Precio = $('#txtPrecio').val();
    producto.Stock = $('#txtStock').val();
    return producto;
}
function limpiarControles() {
    $('#txtNombre').val("");
    $('#txtDescripcion').val("");
    $('#txtPrecio').val("");
    $('#txtStock').val("");
    $('#btnGuardar').val("Nuevo");
}