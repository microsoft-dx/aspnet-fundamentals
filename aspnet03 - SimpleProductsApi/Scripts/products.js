$.ajax({
    url: 'api/Products/GetProducts',
    dataType: 'json',
    success: populateProductList
});

function populateProductList(products) {
    $.each(products, function (index) {
        var product = products[index];

        addProductToList(product);
    });
}

function addProductToList(product) {
    debugger;
    $("#productsList").append('<li>' + product.Name + '</li>');
}

$("#addProductButton").click(function () {

    var product = {
        Id: $("#idInput").val(),
        Name: $("#nameInput").val(),
        Category: $("#categoryInput").val(),
        Price: $("#priceInput").val()
    };

    $.ajax({
        url: 'api/Products/AddProduct',
        dataType: 'json',
        method: 'post',
        data: product,
        success: function () {
            addProductToList(product);
        }
    });
});