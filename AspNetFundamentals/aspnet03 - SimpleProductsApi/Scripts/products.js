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
    $("#productsList").append('<li>' + product.Name + '</li>');
}