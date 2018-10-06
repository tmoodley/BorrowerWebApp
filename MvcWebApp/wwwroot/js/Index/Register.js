function registerUser() {

    var customer = {
        FirstName: $('[name=FirstName]').val(),  
        LastName: $('[name=LastName]').val(),
        Login: $('[name=Login]').val(),
        Password: $('[name=Password]').val(),
        Gender: $('[name=Gender]').val()
    };
    console.log(customer);
  
    $.ajax({
        url: '/api/borrower',
        type: 'POST',
        dataType: 'json',
        data: JSON.stringify(customer),
        contentType: "application/json",
        success: function (data, textStatus, xhr) {
            console.log(data);
        },
        error: function (xhr, textStatus, errorThrown) {
            console.log('Error in Operation');
        }
    });  

    function useReturnData(data) {
        myvar = data;
        console.log(myvar);
    };
}