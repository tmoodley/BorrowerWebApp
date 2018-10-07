function registerUser() {

    var customer = {
        FirstName: $('[name=FirstName]').val(),  
        LastName: $('[name=LastName]').val(),
        Login: $('[name=Login]').val(),
        Password: $('[name=Password]').val(),
        Gender: $('[name=Gender]').val()
    }; 
    $.ajax({
        url: '/api/borrower',
        type: 'POST',
        dataType: 'json',
        data: JSON.stringify(customer),
        contentType: "application/json",
        success: function (data, textStatus, xhr) {
            $('#myModal').modal('hide');
            refreshGrid();
        },
        error: function (xhr, textStatus, errorThrown) {
            console.log('Error in Operation');
        }
    });  

    function refreshGrid() {
        $('#borrowers').DataTable().ajax.reload(null, false);
    };
}

