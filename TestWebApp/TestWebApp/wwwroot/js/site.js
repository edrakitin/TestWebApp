var inProcess = false;

function reloadData() {
    if (inProcess == false) {
        inProcess = true;
        $.ajax
            ({
                type: "POST",
                url: 'Films/PagingData',
                data: { currentPage: $('#currentPageValue').val() },
                success: function (data) {
                    $('#mainTableDiv').empty();
                    $('#mainTableDiv').html(data);
                },
                complete: function (data) {
                    inProcess = false;
                }
            });
    }
};

function deleteFilm(filmId) {
    $('#hiddenDeleteFilmId').val(filmId);

    $('#modalDeleteFilm').modal('show');
};
function deleteFilmConfirm(filmId) {
    $('#modalDeleteFilm').modal('hide');

    $.ajax
        ({
            type: "GET",
            url: 'Films/DeleteFilm',
            data: {
                filmId: $('#hiddenDeleteFilmId').val()
            },
            success: function (data) {
                reloadData();
            },
            error: function (error) {
                $('#msgLabelFilm').text('Возникла ошибка ' + error);
                $('#messageModalFilm').modal('show');
            }
        });
};
