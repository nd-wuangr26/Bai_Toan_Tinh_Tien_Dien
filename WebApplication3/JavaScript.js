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
                    //tien xu ly kq -> json
                    var json = JSON.parse(kq);
                    var tinhtien = json.msg;
                    var html = "Tinh tien: " + tinhtien;
                    $('#ketqua').html(json.msg);
                } else {
                    $('#ketqua').html(json.msg);
            });
    }
    $("#Button1").click(function () {
        goi_api();
    });
});