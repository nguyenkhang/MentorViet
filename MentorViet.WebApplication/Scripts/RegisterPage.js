$.validator.setDefaults({
    ignore: ""
});

var RegisterPage = {
    init: function () {
        $('label[name="radProfileType"]').click(function () {
            $('#ProfileTypeId').val($(this).children('input').val());
        });
    },
};

$(function () {
    RegisterPage.init();
});