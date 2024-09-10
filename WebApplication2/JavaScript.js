$(document).ready(function () {
    fuction goi_api(){
        var data = {
            N: $(#TextBox1).val()
        };

        if (data.N == '' || isNaN(data.N)) {
            $(#ketqua).html('NHập lại giá trị !!!');
            $(#textBox1).focus();
            return;
        }

        $(#ketqua).html('Đang tải API tính toán...');

        $.post("API.aspx",
            data,
            function (kq, status) {
                if (status == "success") {
                    //xu ly ket qua
                    $('#ketqua').html('nhận về');
                } else {
                    $('#ketqua').html('Lỗi khi gọi API.');
            });
    }
    $("#Button1").click(function () {
        goi_api();
    });
});