// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//This function is used for the index file to show soldier layout options
//based on the user dropdown list selection
$(function () {
    $('.form-control').change(function () {
        $('.Descriptions').hide();
        $('#' + $(this).val()).show();
    });
});