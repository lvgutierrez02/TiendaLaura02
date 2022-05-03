$(document).ready(function () {



    mostrarModal = (url, title) => {
        //console.log(url); 
        $.ajax({
            type: 'GET',
            url: url,
            success: function (respuesta) {
                
                $('#form-modal .modal-body').html(respuesta);
                $('#form-modal .modal-title').html(title);
                $('#form-modal').modal('show');
                
            }
        })
    }







    

});