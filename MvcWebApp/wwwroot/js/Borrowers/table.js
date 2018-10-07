$(document).ready(function () { 

    $("#borrowers").DataTable({
        "processing": true, // for show progress bar  
        "serverSide": false, // for process server side  
        "filter": true, // this is for disable filter (search box)  
        "orderMulti": false, // for disable multiple column at once  
        "ajax": {
            "url": "/api/borrower",
            "type": "GET",
            "datatype": "json",
            "dataSrc": ""
        },
        "columnDefs":
            [{
                "targets": [0],
                "visible": false,
                "searchable": false
            }],
        "columns": [

            { "data": "password", "name": "Password", "autoWidth": true },
            { "data": "firstName", "name": "FirstName", "autoWidth": true },
            { "data": "lastName", "name": "LastName", "autoWidth": true },
            { "data": "gender", "name": "Gender", "autoWidth": true },
            { "data": "login", "name": "Login", "autoWidth": true },
            {
                data: null, render: function (data, type, row) {
                    return "<a href='#' class='btn btn-info' onclick=EditData('" + row.id + "'); >Edit</a>";
                }
            },
            {
                data: null, render: function (data, type, row) {
                    return "<a href='#' class='btn btn-danger' onclick=DeleteData('" + row.id + "'); >Delete</a>";
                }
            }
        ]

    });
});


function DeleteData(CustomerID) {
    if (confirm("Are you sure you want to delete ...?")) {
        Delete(CustomerID);
    }
    else {
        return false;
    }
}


function Delete(CustomerID) {
    var url = "/api/borrower/" + CustomerID;
    $.ajax({
        url: url,
        type: 'DELETE',
        success: function (result) {
            debugger;
            if (result) {
                $('#borrowers').DataTable().ajax.reload(null, false);
            }
            else {
                alert("Something Went Wrong!");
            }
        }
    }); 
} 

function EditData(CustomerID) {
    $('#myModal').modal('show');
    $.get('/borrowers/edit/', function (content) {
        $("#dynamicContentContainer").html(content);
    });
    var url = "/api/borrower/" + CustomerID;
    $.ajax({
        url: url,
        type: 'Get',
        success: function (result) { 
            if (result) {
                $('[name=FirstName]').val(result.firstName);
                $('[name=LastName]').val(result.lastName);
                $('[name=Login]').val(result.login); 
                $("input[name='Gender'][value='" + result.gender + "']").prop('checked', true); 
                $('[name=Id]').val(result.id);
            }
            else {
                alert("Something Went Wrong!");
            }
        }
    });
}  

function Register() {  
    $.get('/home/register/', function (content) {
        $("#dynamicContentContainer").html(content);
    });
}
