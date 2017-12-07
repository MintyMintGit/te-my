// Write your JavaScript code.

$(function () {

    $.validator.addMethod("regexName", function (value, element) {
        return this.optional(element) || /^[a-z0-9.'_-]+$/i.test(value);
    }, "Field must contain only letters, numbers, or dashes.");

    $.validator.addMethod("regexCompanyGST", function (value, element) {
        return this.optional(element) || /^[a-z0-9\s]+$/i.test(value);
    }, "Field must contain only letters, numbers");

});