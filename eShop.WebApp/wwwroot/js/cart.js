var CartController = function () {
    this.initialize = function () {
        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '.btn-update', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val());
            updateCart(id, quantity);
        });

        $('body').on('click', '.btn-danger', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            updateCart(id, 0);
        });
    }

    function updateCart(id, quantity) {
        const culture = $('#hidCulture').val();
        $.ajax({
            type: "POST",
            url: "/" + culture + '/Cart/UpdateCart',
            data: {
                id: id,
                quantity: quantity
            },
            success: function (res) {
                $('#lbl_number_items_header').text(res.length);
                location.reload();
            },
            error: function (err) {
                console.log(err);
            }
        });
    }
}