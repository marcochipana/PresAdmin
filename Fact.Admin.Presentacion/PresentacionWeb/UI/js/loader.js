/* Mostramos la pantalla Loader */
function showLoader(msj) {
    if ((navigator.userAgent.indexOf("MSIE") != -1) || (!!document.documentMode == true)) //IF IE > 10
    {
        $('#ieLoader-text').text(msj);
        $('#ieLoader-container').css('display', 'block');
    }
    else {
        $('#loader-text').text(msj);
        $('#loader-container').css('display', 'block');
    }
}
function hideLoader() {
    if ((navigator.userAgent.indexOf("MSIE") != -1) || (!!document.documentMode == true)) //IF IE > 10
        $('#ieLoader-container').css('display', 'none');
    else
        $('#loader-container').css('display', 'none');
}
function ShowUpdateLoader(msj) {
    if ((navigator.userAgent.indexOf("MSIE") != -1) || (!!document.documentMode == true)) //IF IE > 10
    {
        $('.ieLoader-text').text(msj);
        $('.ieLoader-container').css('display', 'block');
    }
    else {
        $('.loader-text').text(msj);
        $('.loader-container').css('display', 'block');
    }
}