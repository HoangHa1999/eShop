var SiteController = function () {
    this.initialize = function () {
        regsiterEvents();
        loadQuantityProduct();
    }
    function loadQuantityProduct() {
        const culture = $('#hidCulture').val();
        $.ajax({
            type: "GET",
            url: "/" + culture + '/Cart/GetQuantityProduct',
            success: function (qty) {
                $('#lbl_number_items_header').text(qty);
            }
        });
    }
    function regsiterEvents() {
        // Write your JavaScript code.
        $('body').on('click', '.btn-add-cart', function (e) {
            e.preventDefault();
            const culture = $('#hidCulture').val();
            const id = $(this).data('id');
            $.ajax({
                type: "POST",
                url: "/" + culture + '/Cart/AddToCart',
                data: {
                    id: id,
                    languageId: culture
                },
                success: function (res) {
                    $('#lbl_number_items_header').text(res.length);
                },
                error: function (err) {
                    console.log(err);
                }
            });
        });

        //add detail
        $('body').on('click', '.btn-add', function (e) {
            e.preventDefault();
            const culture = $('#hidCulture').val();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity').val());
            $.ajax({
                type: "POST",
                url: "/" + culture + '/Cart/AddToCart',
                data: {
                    id: id,
                    languageId: culture,
                    quantity: quantity
                },
                success: function (res) {
                    $('#lbl_number_items_header').text(res.length);
                },
                error: function (err) {
                    console.log(err);
                }
            });
        });
    }
}

function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}