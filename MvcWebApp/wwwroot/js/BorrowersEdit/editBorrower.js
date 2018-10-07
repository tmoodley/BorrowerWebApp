function registerUser() {

    var customer = {
        FirstName: $('[name=FirstName]').val(),
        LastName: $('[name=LastName]').val(),
        Login: $('[name=Login]').val(),
        Password: $('[name=Password]').val(),
        Gender: $("input[name='Gender']:checked").val(),
        Id: $('[name=Id]').val()
    };
    $.ajax({
        url: '/api/borrower',
        type: 'PUT',
        dataType: 'json',
        data: JSON.stringify(customer),
        contentType: "application/json",
        success: function (data, textStatus, xhr) {
            if (data === true) {
                $('#myModal').modal('hide');
                refreshGrid();
            }
            else {
                alert(data);
            }          
        },
        error: function (xhr, textStatus, errorThrown) {
            console.log('Error in Operation');
        }
    });

    function refreshGrid() {
        $('#borrowers').DataTable().ajax.reload(null, false);
    };
}

