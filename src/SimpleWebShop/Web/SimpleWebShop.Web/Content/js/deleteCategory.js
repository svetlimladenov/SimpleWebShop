$(document).ready(async function () {
    let buttons = document.querySelectorAll('.action-button');
    buttons.forEach(x => x.addEventListener('click',
        (e) => {
            let btn = $(x);
            let id = x.dataset.id;
            let name = x.dataset.categoryName;
            let action = x.dataset.action;
            if (confirm(`Are you sure you want to ${action} ${name} category`)) {
                if (action === 'Delete') {
                    $.post('/Administration/CategoriesAdministration/Delete', { id: id }).then(res => {
                        btn.removeClass('delete-btn btn-danger');
                        btn.addClass('undelete-btn btn-success');
                        btn.text('UNDELETE');
                        btn.attr('data-action', 'Undelete');
                    }).catch(err => {
                        console.log(err);
                    });
                } else {
                    $.post('/Administration/CategoriesAdministration/BringBack', { id: id }).then(res => {
                        btn.removeClass('undelete-btn btn-success');
                        btn.addClass('delete-btn btn-danger');
                        btn.text('DELETE');
                        btn.attr('data-action', 'Delete');
                    }).catch(err => {
                        console.log(err);
                    });
                }

            }
        }));
});