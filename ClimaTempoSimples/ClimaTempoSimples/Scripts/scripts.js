function obterPrevisaoSemanal() {
    var id = $('#cidades').find(":selected").val();
    var nome = $('#cidades').find(":selected").text();

    $.ajax(
        {
            type: 'GET',
            url: '/Home/obterPrevisaoSemanal',
            data: {
                Id: id,
                Nome: nome
            },
            dataType: 'html',
            cache: false,
            async: true,
            success: function (data) {
                $('#previsaoSemanal').html(data);
            }
        });
}
